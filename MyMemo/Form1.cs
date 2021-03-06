﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyMemo {
	public partial class Form1 : Form {

		#region: 変数

		private const string ApplicationName = "OchiMemo";

		private const string RegistryKey = @"Software\NikkeiSoftware" + ApplicationName;

		private string _filePath;

		private string _fileNameValue;

		private string FileName {
			get { return _fileNameValue; }
			set {
				this._fileNameValue = value;
				if (value != "") _filePath = System.IO.Path.GetDirectoryName(value);
				this.Edited = false;
			}
		}

		private bool EditedValue;

		private bool Edited {
			get { return EditedValue; }
			set {
				EditedValue = value;
				UpdateStatus();
			}
		}

		private void UpdateStatus() {
			string s = ApplicationName;
			if (FileName != "") s += " - " + FileName;
			if (Edited) s += "（変更あり）";
			this.Text = s;

			if (FileName == "" || !Edited || textBoxMain.TextLength == 0)
				MenuItemFileSave.Enabled = false;
			else
				MenuItemFileSave.Enabled = true;

			if (!Edited || textBoxMain.TextLength == 0)
				MenuItemFileSaveAs.Enabled = false;
			else
				MenuItemFileSaveAs.Enabled = true;

			//TODO:リスト３６「４７　印刷プレビューを可能にする」
			bool b = textBoxMain.TextLength == 0;
			MenuItemFilePrint.Enabled = !b;
			MenuItemFilePrintPreview.Enabled = !b;
		}

		public Form1() {
			InitializeComponent();
		}


		private void LoadFile(string value) {
			if (System.IO.File.Exists(value)) {
				textBoxMain.Text = System.IO.File.ReadAllText(
				value, System.Text.Encoding.GetEncoding("Shift_JIS"));
				this.FileName = value;
			}
			else {
				MessageBox.Show(value + "が見付かりません。", ApplicationName);
			}
		}

		private void SaveFile(string value) {
			System.IO.File.WriteAllText(value, textBoxMain.Text,
				System.Text.Encoding.GetEncoding("Shift_JIS"));
			this.FileName = value;
		}

		private bool AskGiveUpText() {
			if (!Edited || textBoxMain.TextLength == 0)
				return true;
			if (DialogResult.Yes ==
				MessageBox.Show("編集内容を破棄しますか？",
				ApplicationName, MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning)) {
				return true;
			}
			else {
				return false;
			}
		}


		#region 行番号表示　:　DispRowNo

		/// <summary>
		/// 行番号表示
		/// </summary>
		private void DispRowNo() {
			int iGyosu = 1;
			int preIndex = 0;
			int hanteiIndex = 0;
			StringBuilder sb = new StringBuilder();

			#region whileループ
			while (hanteiIndex != -1) {
				hanteiIndex = this.textBoxMain.Text.IndexOf(Environment.NewLine, preIndex);
				if (hanteiIndex != -1)
					preIndex = hanteiIndex + Environment.NewLine.Length;
				sb.Append(iGyosu.ToString()).Append(Environment.NewLine);
				iGyosu++;
			}
			this.label1.Text = sb.ToString();
			#endregion

			#region foreachループ
			//sb.Append(iGyosu.ToString()).Append(Environment.NewLine);
			//iGyosu++;
			//foreach (char i in textBoxMain.Text) {
			//	if (i == '\r') {
			//		sb.Append(iGyosu.ToString()).Append(Environment.NewLine);
			//		iGyosu++;
			//	}
			//}
			//this.label1.Text = sb.ToString();
			#endregion
		}

		#endregion


		#region:印刷

		private void SetPrintDocument1() {
			//TODO:リスト３３「４５　印刷機能をつける」
			PrintString = textBoxMain.Text;
			printDocument1.DefaultPageSettings.Margins =
				new System.Drawing.Printing.Margins(20, 60, 20, 60);
			printDocument1.DocumentName = FileName;
		}
		private string PrintString;

		#endregion


		#region:検索

		private void SearchStart(string searchText) {
			string inTextBoxword = textBoxMain.Text;
			//Console.WriteLine(inTextBoxword.IndexOf(searchText));
			int index = inTextBoxword.IndexOf(searchText);
			textBoxMain.Select(index, searchText.Length);
			this.Focus();
		}
		private void CloseSearchForm() {
			s = null;
		}
		Search s = null;

		#endregion

		#endregion


		#region: イベント

		#region:Form,TextBox
		private void Form1_Load(object sender, EventArgs e) {

			this.FileName = "";

			this.textBoxMain.Multiline = true;
			this.textBoxMain.ScrollBars = ScrollBars.Vertical;

			this.saveFileDialog1.Filter = "テキスト文書|*.txt|すべてのファイル|*.*";
			fontDialog1.ShowEffects = false;
			fontDialog1.AllowScriptChange = false;

			Microsoft.Win32.RegistryKey regKey =
				Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryKey);
			_filePath = regKey.GetValue("FilePath", System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).
				ToString();

			//TODO:リスト２１「３３フォントの設定を覚える」
			string name = regKey.GetValue("FontName", "ＭＳ　ゴシック").ToString();
			Single size = Single.Parse(regKey.GetValue("FontSize", 12).ToString());
			bool bold = bool.Parse(regKey.GetValue("FontBold", false).ToString());
			bool italic = bool.Parse(regKey.GetValue("FontItalic", false).ToString());
			System.Drawing.FontStyle style = new System.Drawing.FontStyle();
			if (bold) style = System.Drawing.FontStyle.Bold;
			if (italic) style = style ^ System.Drawing.FontStyle.Italic;
			textBoxMain.Font = new System.Drawing.Font(name, size, style);
			label1.Font = new System.Drawing.Font(name, size, style);

			//TODO:リスト２２「３４　ウィンドウが小さくなりすぎないように」
			const int initialWidth = 400;
			const int initialHeight = 200;
			this.MinimumSize = new System.Drawing.Size(initialWidth, initialHeight);

			//TODO:リスト２３「３５　ウィンドウの位置と大きさを覚える」
			const int initialLeft = 100;
			const int initialTop = 100;
			int l = int.Parse(regKey.GetValue("Left", initialLeft).ToString());
			int t = int.Parse(regKey.GetValue("Top", initialTop).ToString());
			int w = int.Parse(regKey.GetValue("Width", initialWidth).ToString());
			int h = int.Parse(regKey.GetValue("Height", initialHeight).ToString());
			if (l < Screen.GetWorkingArea(this).Left || l >= Screen.GetWorkingArea(this).Right)
				l = initialLeft;
			if (t < Screen.GetWorkingArea(this).Top || t >= Screen.GetWorkingArea(this).Bottom)
				t = initialTop;
			this.SetDesktopBounds(l, t, w, h);

			if (1 < Environment.GetCommandLineArgs().Length) {
				string[] args = Environment.GetCommandLineArgs();
				LoadFile(args[1]);
			}
			//TODO:リスト２９「４１　不要なものは無効にする」
			MenuItemEdit_DropDownOpening(sender, e);

			//TODO:リスト３４「４６　印刷ダイアログを出す」
			printDialog1.Document = printDocument1;

			//TODO:リスト３５「４７　印刷プレビューを可能にする」
			printPreviewDialog1.Document = printDocument1;

			this.DispRowNo();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			if (!AskGiveUpText()) e.Cancel = true;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
			Microsoft.Win32.RegistryKey regKey =
				Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryKey);
			regKey.SetValue("FilePath", _filePath);
			//TODO:リスト２０「３３フォントの設定を覚える」
			regKey.SetValue("FontName", textBoxMain.Font.Name);
			regKey.SetValue("FontSize", textBoxMain.Font.Size);
			regKey.SetValue("FontBold", textBoxMain.Font.Bold);
			regKey.SetValue("FontItalic", textBoxMain.Font.Italic);
			//TODO:リスト２３「３５　ウィンドウの位置と大きさを覚える」
			regKey.SetValue("Left", DesktopBounds.Left);
			regKey.SetValue("Top", DesktopBounds.Top);
			regKey.SetValue("Width", DesktopBounds.Width);
			regKey.SetValue("Height", DesktopBounds.Height);
		}

		public void textBoxMain_TextChanged(object sender, EventArgs e) {
			this.Edited = true;
			int iTextLength = textBoxMain.Text.Length;
			toolStripStatusLabel1.Text = string.Format("文字数： {0} 字", iTextLength.ToString());


			//処理速度表示
			System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

			#region 行番号
			int iLineBreak = textBoxMain.Text.Length;
			string LineBreak = textBoxMain.Text;
			string kensakuStr = "\r\n";

			this.DispRowNo();

			#endregion
			sw.Stop();
			MessageBox.Show(sw.Elapsed.ToString());
		}

		#endregion


		#region:MenuItemFile
		private void MenuItemFileExit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void MenuItemFileOpen_Click(object sender, EventArgs e) {
			if (!AskGiveUpText()) return;
			this.openFileDialog1.InitialDirectory = _filePath;
			this.openFileDialog1.FileName = "";
			if (DialogResult.OK == openFileDialog1.ShowDialog())
				this.LoadFile(openFileDialog1.FileName);
		}

		private void MenuItemFileSaveAs_Click(object sender, EventArgs e) {
			saveFileDialog1.InitialDirectory = _filePath;
			saveFileDialog1.FileName = System.IO.Path.GetFileName(FileName);
			if (DialogResult.OK == saveFileDialog1.ShowDialog())
				this.SaveFile(saveFileDialog1.FileName);
		}

		private void MenuItemFileSave_Click(object sender, EventArgs e) {
			SaveFile(FileName);
		}

		private void MenuItemFileNew_Click(object sender, EventArgs e) {
			if (!AskGiveUpText()) return;
			textBoxMain.Clear();
			FileName = "";
		}

		private void MenuItemFilePrint_Click(object sender, EventArgs e) {
			//TODO:リスト３３「４５　印刷機能をつける」
			//TODO:リスト３４「４６　印刷ダイアログを出す」
			if (DialogResult.OK == printDialog1.ShowDialog()) {
				SetPrintDocument1();
				printDocument1.Print();
			}
		}

		#region:Print

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
			//TODO:リスト３３「４５　印刷機能をつける」
			int charactersOnPage = 0;
			int linesPerPage = 0;
			e.Graphics.MeasureString(PrintString, textBoxMain.Font, e.MarginBounds.Size,
				System.Drawing.StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);
			e.Graphics.DrawString(PrintString, textBoxMain.Font, System.Drawing.Brushes.Black, e.MarginBounds,
				System.Drawing.StringFormat.GenericTypographic);
			PrintString = PrintString.Substring(charactersOnPage);
			if (PrintString.Length > 0)
				e.HasMorePages = true;
			else {
				e.HasMorePages = false;
				PrintString = textBoxMain.Text;
			}
		}

		private void MenuItemFilePrintPreview_Click(object sender, EventArgs e) {
			//TODO:リスト３４「４６　印刷ダイアログを出す」※動いてない！！！！
			SetPrintDocument1();
			printPreviewDialog1.ShowDialog();
		}

		#endregion

		#endregion


		#region:MenuItemEdit
		private void MenuItemEditUndo_Click(object sender, EventArgs e) {
			//TODO:リスト２５「３７　アンドゥを作る」
			textBoxMain.Undo();
		}

		private void MenuItemEditCut_Click(object sender, EventArgs e) {
			//TODO:リスト２６「３８　クリップボードを利用する」
			textBoxMain.Cut();
		}

		private void MenuItemEditCopy_Click(object sender, EventArgs e) {
			//TODO:リスト２６「３８　クリップボードを利用する」
			textBoxMain.Copy();
		}

		private void MenuItemEditPaste_Click(object sender, EventArgs e) {
			//TODO:リスト２６「３８　クリップボードを利用する」
			textBoxMain.Paste();
		}

		private void MenuItemEditDelete_Click(object sender, EventArgs e) {
			//TODO:リスト２７「３９　『削除』メニューを作る」
			textBoxMain.SelectedText = "";
		}

		private void MenuItemEditSelectAll_Click(object sender, EventArgs e) {
			//TODO:リスト２８「４０　『すべて選択』メニューを作る」
			textBoxMain.SelectAll();
		}

		private void MenuItemEdit_DropDownOpening(object sender, EventArgs e) {
			//TODO:リスト２９「４１不要なものは無効にする」
			MenuItemEditPaste.Enabled = Clipboard.ContainsText();
			bool b = textBoxMain.SelectionLength == 0;
			MenuItemEditCut.Enabled = !b;
			MenuItemEditCopy.Enabled = !b;
			MenuItemEditDelete.Enabled = !b;
			b = textBoxMain.TextLength == 0;
			MenuItemEditSelectAll.Enabled = !b;
		}

		private void MenuItemEditDelete_DropDownClosed(object sender, EventArgs e) {
			MenuItemEditDelete.Enabled = false;
		}

		private void MenuItemEditFind_Click(object sender, EventArgs e) {
			for (int i = 0; i < 1000; i++) {
				if (s == null) {
					bool status = true;
					s = new Search();
					s.SearchMethodCall += new Search.Searching(SearchStart);
					s.word = textBoxMain.Text;
					s.Show();
					s.FinishCall += new Search.Finish(CloseSearchForm);
				}
			}
		}

		#endregion


		#region:MenuItemSetting
		private void MenuItemSettingFont_Click(object sender, EventArgs e) {
			fontDialog1.Font = textBoxMain.Font;
			if (DialogResult.OK == fontDialog1.ShowDialog())
				textBoxMain.Font = fontDialog1.Font;
		}

		#endregion


		#region:MenuItemHelp
		private void MenuItemHelpReadMe_Click(object sender, EventArgs e) {
			//TODO:リスト３０「４２　テキストファイルを表示する」
			string s = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
			s = System.IO.Path.Combine(s, "README.TXT");
			if (System.IO.File.Exists(s))
				System.Diagnostics.Process.Start(s);
			else
				MessageBox.Show(s + "が見付かりません。", ApplicationName);
		}

		private void MenuItemHelpWeb_Click(object sender, EventArgs e) {
			//TODO:リスト３１「４３　Webサイトを表示する」
			System.Diagnostics.Process.Start("http://software.nikkeibp.co.jp/");
		}

		private void MenuItemHelpVersion_Click(object sender, EventArgs e) {
			//TODO:リスト３２「４４　バージョン情報を表示する」
			MessageBox.Show(
				ApplicationName + "0.02" + Environment.NewLine +
				"(c)2016- Yuta Ochi", "バージョン情報");
		}

		#endregion


		#region:Drag&Drop

		private void textBoxMain_DragEnter(object sender, DragEventArgs e) {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void textBoxMain_DragDrop(object sender, DragEventArgs e) {
			string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			if (fileName.Length <= 0) {
				return;
			}

			if (this.textBoxMain == null) {
				return;
			}
			this.LoadFile(fileName[0]);

		}


		#endregion

		#endregion イベント↑↑
	}
}
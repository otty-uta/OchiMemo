namespace MyMemo {
	partial class Form1 {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuItemFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemFilePrint = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemEditUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuItemEditCut = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemEditDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemEditFind = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemEditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuItemEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemSettingFont = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemHelpReadMe = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemHelpWeb = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
			this.textBoxMain = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemEdit,
            this.MenuItemSetting,
            this.MenuItemHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(647, 26);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MenuItemFile
			// 
			this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.MenuItemFileOpen,
            this.MenuItemFileSave,
            this.MenuItemFileSaveAs,
            this.MenuItemSeparator1,
            this.MenuItemFilePrintPreview,
            this.MenuItemFilePrint,
            this.toolStripSeparator1,
            this.MenuItemFileExit});
			this.MenuItemFile.Name = "MenuItemFile";
			this.MenuItemFile.Size = new System.Drawing.Size(85, 22);
			this.MenuItemFile.Text = "ファイル(&F)";
			// 
			// MenuItemFileNew
			// 
			this.MenuItemFileNew.Name = "MenuItemFileNew";
			this.MenuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.MenuItemFileNew.Size = new System.Drawing.Size(274, 22);
			this.MenuItemFileNew.Text = "新規(&N)";
			this.MenuItemFileNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
			// 
			// MenuItemFileOpen
			// 
			this.MenuItemFileOpen.Name = "MenuItemFileOpen";
			this.MenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.MenuItemFileOpen.Size = new System.Drawing.Size(274, 22);
			this.MenuItemFileOpen.Text = "開く(&O)";
			this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
			// 
			// MenuItemFileSave
			// 
			this.MenuItemFileSave.Name = "MenuItemFileSave";
			this.MenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.MenuItemFileSave.Size = new System.Drawing.Size(274, 22);
			this.MenuItemFileSave.Text = "上書き保存(&S)";
			this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
			// 
			// MenuItemFileSaveAs
			// 
			this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
			this.MenuItemFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.MenuItemFileSaveAs.Size = new System.Drawing.Size(274, 22);
			this.MenuItemFileSaveAs.Text = "名前をつけて保存(&A)";
			this.MenuItemFileSaveAs.Click += new System.EventHandler(this.MenuItemFileSaveAs_Click);
			// 
			// MenuItemSeparator1
			// 
			this.MenuItemSeparator1.Name = "MenuItemSeparator1";
			this.MenuItemSeparator1.Size = new System.Drawing.Size(271, 6);
			// 
			// MenuItemFilePrintPreview
			// 
			this.MenuItemFilePrintPreview.Name = "MenuItemFilePrintPreview";
			this.MenuItemFilePrintPreview.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
			this.MenuItemFilePrintPreview.Size = new System.Drawing.Size(274, 22);
			this.MenuItemFilePrintPreview.Text = "印刷プレビュー(&V)";
			this.MenuItemFilePrintPreview.Click += new System.EventHandler(this.MenuItemFilePrintPreview_Click);
			// 
			// MenuItemFilePrint
			// 
			this.MenuItemFilePrint.Name = "MenuItemFilePrint";
			this.MenuItemFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.MenuItemFilePrint.Size = new System.Drawing.Size(274, 22);
			this.MenuItemFilePrint.Text = "印刷(&P)";
			this.MenuItemFilePrint.Click += new System.EventHandler(this.MenuItemFilePrint_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
			// 
			// MenuItemFileExit
			// 
			this.MenuItemFileExit.Name = "MenuItemFileExit";
			this.MenuItemFileExit.Size = new System.Drawing.Size(274, 22);
			this.MenuItemFileExit.Text = "終了(&X)";
			this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
			// 
			// MenuItemEdit
			// 
			this.MenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEditUndo,
            this.MenuItemEditSeparator1,
            this.MenuItemEditCut,
            this.MenuItemEditCopy,
            this.MenuItemEditPaste,
            this.MenuItemEditDelete,
            this.MenuItemEditFind,
            this.MenuItemEditSeparator2,
            this.MenuItemEditSelectAll});
			this.MenuItemEdit.Name = "MenuItemEdit";
			this.MenuItemEdit.Size = new System.Drawing.Size(61, 22);
			this.MenuItemEdit.Text = "編集(&E)";
			// 
			// MenuItemEditUndo
			// 
			this.MenuItemEditUndo.Name = "MenuItemEditUndo";
			this.MenuItemEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.MenuItemEditUndo.Size = new System.Drawing.Size(201, 22);
			this.MenuItemEditUndo.Text = "元に戻す(&U)";
			this.MenuItemEditUndo.Click += new System.EventHandler(this.MenuItemEditUndo_Click);
			// 
			// MenuItemEditSeparator1
			// 
			this.MenuItemEditSeparator1.Name = "MenuItemEditSeparator1";
			this.MenuItemEditSeparator1.Size = new System.Drawing.Size(198, 6);
			// 
			// MenuItemEditCut
			// 
			this.MenuItemEditCut.Name = "MenuItemEditCut";
			this.MenuItemEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.MenuItemEditCut.Size = new System.Drawing.Size(201, 22);
			this.MenuItemEditCut.Text = "切り取り(&X)";
			this.MenuItemEditCut.Click += new System.EventHandler(this.MenuItemEditCut_Click);
			// 
			// MenuItemEditCopy
			// 
			this.MenuItemEditCopy.Name = "MenuItemEditCopy";
			this.MenuItemEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.MenuItemEditCopy.Size = new System.Drawing.Size(201, 22);
			this.MenuItemEditCopy.Text = "コピー(&C)";
			this.MenuItemEditCopy.Click += new System.EventHandler(this.MenuItemEditCopy_Click);
			// 
			// MenuItemEditPaste
			// 
			this.MenuItemEditPaste.Name = "MenuItemEditPaste";
			this.MenuItemEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.MenuItemEditPaste.Size = new System.Drawing.Size(201, 22);
			this.MenuItemEditPaste.Text = "貼り付け(&P)";
			this.MenuItemEditPaste.Click += new System.EventHandler(this.MenuItemEditPaste_Click);
			// 
			// MenuItemEditDelete
			// 
			this.MenuItemEditDelete.Name = "MenuItemEditDelete";
			this.MenuItemEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.MenuItemEditDelete.Size = new System.Drawing.Size(201, 22);
			this.MenuItemEditDelete.Text = "削除(&L)";
			this.MenuItemEditDelete.DropDownClosed += new System.EventHandler(this.MenuItemEditDelete_DropDownClosed);
			this.MenuItemEditDelete.Click += new System.EventHandler(this.MenuItemEditDelete_Click);
			// 
			// MenuItemEditFind
			// 
			this.MenuItemEditFind.Name = "MenuItemEditFind";
			this.MenuItemEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.MenuItemEditFind.Size = new System.Drawing.Size(201, 22);
			this.MenuItemEditFind.Text = "検索(&F)";
			this.MenuItemEditFind.Click += new System.EventHandler(this.MenuItemEditFind_Click);
			// 
			// MenuItemEditSeparator2
			// 
			this.MenuItemEditSeparator2.Name = "MenuItemEditSeparator2";
			this.MenuItemEditSeparator2.Size = new System.Drawing.Size(198, 6);
			// 
			// MenuItemEditSelectAll
			// 
			this.MenuItemEditSelectAll.Name = "MenuItemEditSelectAll";
			this.MenuItemEditSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.MenuItemEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.MenuItemEditSelectAll.Size = new System.Drawing.Size(201, 22);
			this.MenuItemEditSelectAll.Text = "すべて選択(&A)";
			this.MenuItemEditSelectAll.Click += new System.EventHandler(this.MenuItemEditSelectAll_Click);
			// 
			// MenuItemSetting
			// 
			this.MenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSettingFont});
			this.MenuItemSetting.Name = "MenuItemSetting";
			this.MenuItemSetting.Size = new System.Drawing.Size(62, 22);
			this.MenuItemSetting.Text = "設定(&S)";
			// 
			// MenuItemSettingFont
			// 
			this.MenuItemSettingFont.Name = "MenuItemSettingFont";
			this.MenuItemSettingFont.Size = new System.Drawing.Size(124, 22);
			this.MenuItemSettingFont.Text = "フォント";
			this.MenuItemSettingFont.Click += new System.EventHandler(this.MenuItemSettingFont_Click);
			// 
			// MenuItemHelp
			// 
			this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelpReadMe,
            this.MenuItemHelpWeb,
            this.MenuItemHelpVersion});
			this.MenuItemHelp.Name = "MenuItemHelp";
			this.MenuItemHelp.Size = new System.Drawing.Size(75, 22);
			this.MenuItemHelp.Text = "ヘルプ(&H)";
			// 
			// MenuItemHelpReadMe
			// 
			this.MenuItemHelpReadMe.Name = "MenuItemHelpReadMe";
			this.MenuItemHelpReadMe.Size = new System.Drawing.Size(207, 22);
			this.MenuItemHelpReadMe.Text = "README.TXTの表示(&R)";
			this.MenuItemHelpReadMe.Click += new System.EventHandler(this.MenuItemHelpReadMe_Click);
			// 
			// MenuItemHelpWeb
			// 
			this.MenuItemHelpWeb.Name = "MenuItemHelpWeb";
			this.MenuItemHelpWeb.Size = new System.Drawing.Size(207, 22);
			this.MenuItemHelpWeb.Text = "Webサイトの表示(&W)";
			this.MenuItemHelpWeb.Click += new System.EventHandler(this.MenuItemHelpWeb_Click);
			// 
			// MenuItemHelpVersion
			// 
			this.MenuItemHelpVersion.Name = "MenuItemHelpVersion";
			this.MenuItemHelpVersion.Size = new System.Drawing.Size(207, 22);
			this.MenuItemHelpVersion.Text = "バージョン情報(&V)";
			this.MenuItemHelpVersion.Click += new System.EventHandler(this.MenuItemHelpVersion_Click);
			// 
			// textBoxMain
			// 
			this.textBoxMain.AllowDrop = true;
			this.textBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxMain.Location = new System.Drawing.Point(41, 26);
			this.textBoxMain.Multiline = true;
			this.textBoxMain.Name = "textBoxMain";
			this.textBoxMain.Size = new System.Drawing.Size(606, 566);
			this.textBoxMain.TabIndex = 1;
			this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 592);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(647, 23);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 18);
			this.toolStripStatusLabel1.Text = "文字数： 0 字";
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(0, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 566);
			this.label1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 615);
			this.Controls.Add(this.textBoxMain);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
		private System.Windows.Forms.TextBox textBoxMain;
		private System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
		private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
		private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
		private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveAs;
		private System.Windows.Forms.ToolStripSeparator MenuItemSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem MenuItemSetting;
		private System.Windows.Forms.ToolStripMenuItem MenuItemSettingFont;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
		private System.Windows.Forms.ToolStripMenuItem MenuItemEditUndo;
		private System.Windows.Forms.ToolStripSeparator MenuItemEditSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MenuItemEditCut;
		private System.Windows.Forms.ToolStripMenuItem MenuItemEditCopy;
		private System.Windows.Forms.ToolStripMenuItem MenuItemEditPaste;
		private System.Windows.Forms.ToolStripMenuItem MenuItemEditDelete;
		private System.Windows.Forms.ToolStripSeparator MenuItemEditSeparator2;
		private System.Windows.Forms.ToolStripMenuItem MenuItemEditSelectAll;
		private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
		private System.Windows.Forms.ToolStripMenuItem MenuItemHelpReadMe;
		private System.Windows.Forms.ToolStripMenuItem MenuItemHelpWeb;
		private System.Windows.Forms.ToolStripMenuItem MenuItemHelpVersion;
		private System.Windows.Forms.ToolStripMenuItem MenuItemFilePrintPreview;
		private System.Windows.Forms.ToolStripMenuItem MenuItemFilePrint;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem MenuItemEditFind;
		private System.Windows.Forms.Label label1;
	}
}


namespace MyMemo {
	partial class Search {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSearchWord = new System.Windows.Forms.TextBox();
			this.buttonSearchStart = new System.Windows.Forms.Button();
			this.buttonSearchExit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxSearchResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "検索ワード";
			// 
			// textBoxSearchWord
			// 
			this.textBoxSearchWord.Location = new System.Drawing.Point(12, 29);
			this.textBoxSearchWord.Name = "textBoxSearchWord";
			this.textBoxSearchWord.Size = new System.Drawing.Size(232, 19);
			this.textBoxSearchWord.TabIndex = 1;
			// 
			// buttonSearchStart
			// 
			this.buttonSearchStart.Location = new System.Drawing.Point(169, 70);
			this.buttonSearchStart.Name = "buttonSearchStart";
			this.buttonSearchStart.Size = new System.Drawing.Size(75, 23);
			this.buttonSearchStart.TabIndex = 2;
			this.buttonSearchStart.Text = "検索";
			this.buttonSearchStart.UseVisualStyleBackColor = true;
			this.buttonSearchStart.Click += new System.EventHandler(this.buttonSearchStart_Click);
			// 
			// buttonSearchExit
			// 
			this.buttonSearchExit.Location = new System.Drawing.Point(169, 113);
			this.buttonSearchExit.Name = "buttonSearchExit";
			this.buttonSearchExit.Size = new System.Drawing.Size(75, 23);
			this.buttonSearchExit.TabIndex = 3;
			this.buttonSearchExit.Text = "閉じる";
			this.buttonSearchExit.UseVisualStyleBackColor = true;
			this.buttonSearchExit.Click += new System.EventHandler(this.buttonSearchExit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "検索結果";
			// 
			// textBoxSearchResult
			// 
			this.textBoxSearchResult.Location = new System.Drawing.Point(12, 95);
			this.textBoxSearchResult.Name = "textBoxSearchResult";
			this.textBoxSearchResult.ReadOnly = true;
			this.textBoxSearchResult.Size = new System.Drawing.Size(146, 19);
			this.textBoxSearchResult.TabIndex = 5;
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 148);
			this.Controls.Add(this.textBoxSearchResult);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonSearchExit);
			this.Controls.Add(this.buttonSearchStart);
			this.Controls.Add(this.textBoxSearchWord);
			this.Controls.Add(this.label1);
			this.Name = "Search";
			this.Text = "Search";
			this.Load += new System.EventHandler(this.Search_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSearchWord;
		private System.Windows.Forms.Button buttonSearchStart;
		private System.Windows.Forms.Button buttonSearchExit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxSearchResult;
	}
}
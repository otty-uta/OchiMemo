using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMemo {
	public partial class Search : Form {
		
		public string word = "";

		public delegate void Searching(string s);
		public event Searching SearchMethodCall;

		public delegate void Finish();
		public event Finish FinishCall;

		public Search() {
			InitializeComponent();
		}

		private void buttonSearchStart_Click(object sender, EventArgs e) {
			//this.Ageo = this.textBoxSearchWord.Text;
			string inputText = this.textBoxSearchWord.Text;
			this.SearchMethodCall(inputText);
			this.DialogResult = DialogResult.OK;
		}

		private void buttonSearchExit_Click(object sender, EventArgs e) {
			this.FinishCall();
			this.DialogResult = DialogResult.No;
			this.Close();
		}

	}
}

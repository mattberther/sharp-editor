using System;
using System.Windows.Forms;

namespace SharpEd
{
	class Document
	{
		private TextBox textbox;
		public Document(TextBox tb)
		{
			this.textbox = tb;
		}

		public string Text
		{
			get { return textbox.Text; }
			set { textbox.Text = value; }
		}

		public void BoldSelection()
		{
			textbox.SelectedText = String.Format("<b>{0}</b>", textbox.SelectedText);
		}

		public void ItalicizeSelection()
		{
			textbox.SelectedText = String.Format("<i>{0}</i>", textbox.SelectedText);
		}

		public void UnderlineSelection()
		{
			textbox.SelectedText = String.Format("<u>{0}</u>", textbox.SelectedText);
		}

		public void Cut()
		{
			textbox.Cut();
		}

		public void Copy()
		{
			textbox.Copy();
		}

		public void Paste()
		{
			textbox.Paste();
		}
	}
}
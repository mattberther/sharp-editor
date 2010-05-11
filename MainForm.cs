using System;
using System.Windows.Forms;

namespace SharpEd
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem cutMenuItem;
		private System.Windows.Forms.MenuItem copyMenuItem;
		private System.Windows.Forms.MenuItem pasteMenuItem;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.StatusBar statusBar1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.MenuItem undoMenuItem;
		
		private	CommandManager commandManager = new CommandManager();
		private System.Windows.Forms.TextBox documentTextbox;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem underlineMenuItem;
		private System.Windows.Forms.MenuItem boldMenuItem;
		private System.Windows.Forms.MenuItem italicMenuItem;
		private System.Windows.Forms.MenuItem exitMenuItem;
		private Document document;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			document = new Document(this.documentTextbox);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.exitMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.undoMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.cutMenuItem = new System.Windows.Forms.MenuItem();
			this.copyMenuItem = new System.Windows.Forms.MenuItem();
			this.pasteMenuItem = new System.Windows.Forms.MenuItem();
			this.documentTextbox = new System.Windows.Forms.TextBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.boldMenuItem = new System.Windows.Forms.MenuItem();
			this.italicMenuItem = new System.Windows.Forms.MenuItem();
			this.underlineMenuItem = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3,
																					  this.menuItem5});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.exitMenuItem});
			this.menuItem1.Text = "&File";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Index = 0;
			this.exitMenuItem.Text = "E&xit";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.undoMenuItem,
																					  this.menuItem4,
																					  this.cutMenuItem,
																					  this.copyMenuItem,
																					  this.pasteMenuItem});
			this.menuItem3.Text = "&Edit";
			// 
			// undoMenuItem
			// 
			this.undoMenuItem.Index = 0;
			this.undoMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.undoMenuItem.Text = "Undo";
			this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "-";
			// 
			// cutMenuItem
			// 
			this.cutMenuItem.Index = 2;
			this.cutMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.cutMenuItem.Text = "Cu&t";
			this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
			// 
			// copyMenuItem
			// 
			this.copyMenuItem.Index = 3;
			this.copyMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.copyMenuItem.Text = "&Copy";
			this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
			// 
			// pasteMenuItem
			// 
			this.pasteMenuItem.Index = 4;
			this.pasteMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.pasteMenuItem.Text = "&Paste";
			this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
			// 
			// documentTextbox
			// 
			this.documentTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.documentTextbox.Location = new System.Drawing.Point(0, 0);
			this.documentTextbox.Multiline = true;
			this.documentTextbox.Name = "documentTextbox";
			this.documentTextbox.Size = new System.Drawing.Size(528, 360);
			this.documentTextbox.TabIndex = 0;
			this.documentTextbox.Text = "";
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 360);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(528, 22);
			this.statusBar1.TabIndex = 1;
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.boldMenuItem,
																					  this.italicMenuItem,
																					  this.underlineMenuItem});
			this.menuItem5.Text = "Format";
			// 
			// boldMenuItem
			// 
			this.boldMenuItem.Index = 0;
			this.boldMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlB;
			this.boldMenuItem.Text = "&Bold";
			this.boldMenuItem.Click += new System.EventHandler(this.boldMenuItem_Click);
			// 
			// italicMenuItem
			// 
			this.italicMenuItem.Index = 1;
			this.italicMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
			this.italicMenuItem.Text = "&Italic";
			this.italicMenuItem.Click += new System.EventHandler(this.italicMenuItem_Click);
			// 
			// underlineMenuItem
			// 
			this.underlineMenuItem.Index = 2;
			this.underlineMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
			this.underlineMenuItem.Text = "&Underline";
			this.underlineMenuItem.Click += new System.EventHandler(this.underlineMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(528, 382);
			this.Controls.Add(this.documentTextbox);
			this.Controls.Add(this.statusBar1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "SharpEd";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void cutMenuItem_Click(object sender, System.EventArgs e)
		{
			commandManager.ExecuteCommand(new CutCommand(document));		
		}

		private void pasteMenuItem_Click(object sender, System.EventArgs e)
		{
			commandManager.ExecuteCommand(new PasteCommand(document));	
		}

		private void copyMenuItem_Click(object sender, System.EventArgs e)
		{
			commandManager.ExecuteCommand(new CopyCommand(document));		
		}

		private void boldMenuItem_Click(object sender, System.EventArgs e)
		{
			commandManager.ExecuteCommand(new BoldCommand(document));
		}

		private void undoMenuItem_Click(object sender, System.EventArgs e)
		{
			commandManager.Undo();
		}

		private void underlineMenuItem_Click(object sender, System.EventArgs e)
		{
			commandManager.ExecuteCommand(new UnderlineCommand(document));
		}

		private void italicMenuItem_Click(object sender, System.EventArgs e)
		{
			commandManager.ExecuteCommand(new UnderlineCommand(document));
		}

		private void exitMenuItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}

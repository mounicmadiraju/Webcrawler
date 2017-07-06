// Author mounicraju@gmail.com //

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WebCrawler
{
	
	public class WinForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button PauseButton;
		private System.Windows.Forms.Button CrawlButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox URLListBox;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.CheckBox diffDomainCheckBox;
		private System.Windows.Forms.TrackBar updateSpeedTrackBar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.TextBox urlEdit;
    private Label countLabel;
    private WebBrowser WebBrowser;

		public WinForm()
		{
			//
			
			//
			InitializeComponent();

      Application.EnableVisualStyles();
      Application.DoEvents();
      Application.Idle += new EventHandler(Application_Idle);

      urlEdit.Text = Properties.Settings.Default.StartURL;
      updateSpeedTrackBar.Value = Properties.Settings.Default.UpdateSpeed;
      diffDomainCheckBox.Checked = Properties.Settings.Default.PreferDifferentDomains;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose (bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.components = new System.ComponentModel.Container();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.updateSpeedTrackBar = new System.Windows.Forms.TrackBar();
      this.diffDomainCheckBox = new System.Windows.Forms.CheckBox();
      this.PauseButton = new System.Windows.Forms.Button();
      this.CrawlButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.urlEdit = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.URLListBox = new System.Windows.Forms.ListBox();
      this.contextMenu1 = new System.Windows.Forms.ContextMenu();
      this.menuItem1 = new System.Windows.Forms.MenuItem();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.WebBrowser = new System.Windows.Forms.WebBrowser();
      this.countLabel = new System.Windows.Forms.Label();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.updateSpeedTrackBar)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // timer
      // 
      this.timer.Interval = 10000;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.countLabel);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.updateSpeedTrackBar);
      this.panel2.Controls.Add(this.diffDomainCheckBox);
      this.panel2.Controls.Add(this.PauseButton);
      this.panel2.Controls.Add(this.CrawlButton);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.urlEdit);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(592, 64);
      this.panel2.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(183, 37);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(136, 16);
      this.label2.TabIndex = 12;
      this.label2.Text = "Update speed (1-10 secs)";
      // 
      // updateSpeedTrackBar
      // 
      this.updateSpeedTrackBar.Location = new System.Drawing.Point(313, 32);
      this.updateSpeedTrackBar.Minimum = 1;
      this.updateSpeedTrackBar.Name = "updateSpeedTrackBar";
      this.updateSpeedTrackBar.Size = new System.Drawing.Size(104, 45);
      this.updateSpeedTrackBar.TabIndex = 11;
      this.updateSpeedTrackBar.Value = 10;
      this.updateSpeedTrackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
      // 
      // diffDomainCheckBox
      // 
      this.diffDomainCheckBox.Checked = true;
      this.diffDomainCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.diffDomainCheckBox.Location = new System.Drawing.Point(8, 32);
      this.diffDomainCheckBox.Name = "diffDomainCheckBox";
      this.diffDomainCheckBox.Size = new System.Drawing.Size(144, 24);
      this.diffDomainCheckBox.TabIndex = 10;
      this.diffDomainCheckBox.Text = "Prefer different domains";
      // 
      // PauseButton
      // 
      this.PauseButton.Location = new System.Drawing.Point(495, 5);
      this.PauseButton.Name = "PauseButton";
      this.PauseButton.Size = new System.Drawing.Size(75, 24);
      this.PauseButton.TabIndex = 9;
      this.PauseButton.Text = "Pause";
      this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
      // 
      // CrawlButton
      // 
      this.CrawlButton.Location = new System.Drawing.Point(414, 5);
      this.CrawlButton.Name = "CrawlButton";
      this.CrawlButton.Size = new System.Drawing.Size(75, 24);
      this.CrawlButton.TabIndex = 8;
      this.CrawlButton.Text = "Crawl!";
      this.CrawlButton.Click += new System.EventHandler(this.CrawlButton_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(10, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 17);
      this.label1.TabIndex = 6;
      this.label1.Text = "Start URL";
      // 
      // urlEdit
      // 
      this.urlEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.urlEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
      this.urlEdit.Location = new System.Drawing.Point(72, 8);
      this.urlEdit.Name = "urlEdit";
      this.urlEdit.Size = new System.Drawing.Size(336, 20);
      this.urlEdit.TabIndex = 7;
      this.urlEdit.Text = "http://www.doogal.co.uk/links.php";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.URLListBox);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 64);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(592, 69);
      this.panel1.TabIndex = 10;
      // 
      // URLListBox
      // 
      this.URLListBox.ContextMenu = this.contextMenu1;
      this.URLListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.URLListBox.Location = new System.Drawing.Point(0, 0);
      this.URLListBox.Name = "URLListBox";
      this.URLListBox.Size = new System.Drawing.Size(592, 69);
      this.URLListBox.TabIndex = 0;
      // 
      // contextMenu1
      // 
      this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
      // 
      // menuItem1
      // 
      this.menuItem1.Index = 0;
      this.menuItem1.Text = "Copy";
      this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
      // 
      // splitter1
      // 
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter1.Location = new System.Drawing.Point(0, 133);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(592, 3);
      this.splitter1.TabIndex = 11;
      this.splitter1.TabStop = false;
      // 
      // WebBrowser
      // 
      this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.WebBrowser.Location = new System.Drawing.Point(0, 136);
      this.WebBrowser.Name = "WebBrowser";
      this.WebBrowser.ScriptErrorsSuppressed = true;
      this.WebBrowser.Size = new System.Drawing.Size(592, 216);
      this.WebBrowser.TabIndex = 12;
      this.WebBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.WebBrowser_NewWindow);
      // 
      // countLabel
      // 
      this.countLabel.AutoSize = true;
      this.countLabel.Location = new System.Drawing.Point(423, 37);
      this.countLabel.Name = "countLabel";
      this.countLabel.Size = new System.Drawing.Size(67, 13);
      this.countLabel.TabIndex = 13;
      this.countLabel.Text = "Pages found";
      // 
      // WinForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(592, 352);
      this.Controls.Add(this.WebBrowser);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel2);
      this.Name = "WinForm";
      this.Text = "Web Crawler";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinForm_FormClosing);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.updateSpeedTrackBar)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new WinForm());
		}

		private int Index;

		private void ParseDocument()
		{
			if (WebBrowser.Document != null)
			{
        HtmlElementCollection LElements = WebBrowser.Document.All;

				for (int Loop = 0; Loop < LElements.Count; Loop++)
				{
          HtmlElement LField = LElements[Loop];
					if (LField.TagName.ToUpper() == "A")
					{
						string URL = LField.GetAttribute("href");
						if (URL != null)
							AddLink(URL);
					}
				}
			}
				
			if (Index < URLListBox.Items.Count-1)
			{
				Index++;
			
				URLListBox.SelectedIndex = Index;
				WebBrowser.Navigate(URLListBox.Items[Index].ToString());
			}
		}

		private string GetDomainName(string URL)
		{
      Uri uri = new Uri(URL);
      return uri.Host;
		}

		private void AddLink(string URL)
		{
			// don't add it if we already have it
			if (URLListBox.Items.IndexOf(URL) == -1)
			{
				// only add http links
				if (URL.StartsWith("http"))
				{
					// we prefer different domain names since these mean we do more crawling
					bool AlreadyGotDomain = false;
					if (diffDomainCheckBox.Checked)
					{
						string URLDomainName = GetDomainName(URL);
						int Loop = 0;
						while (Loop<URLListBox.Items.Count && !AlreadyGotDomain)
						{
							string CurrentDomainName = GetDomainName(URLListBox.Items[Loop].ToString());
							if (CurrentDomainName == URLDomainName)
							{
								AlreadyGotDomain = true;
                break;
							}
							Loop++;
						}
					}
					else
					{
						// always add at the end if unchecked
						AlreadyGotDomain = true;
					}
						
					if (AlreadyGotDomain)
					{
						// don't bother adding too many items
						if (URLListBox.Items.Count < (Index+1000))
							URLListBox.Items.Add(URL);
					}
					else
						URLListBox.Items.Insert(Index+1, URL);
				}
			}
		}
		
		private void timer_Tick(object sender, System.EventArgs e)
		{
      timer.Enabled = false;
      try
      {
        ParseDocument();
      }
      finally
      {
        timer.Enabled = true;
      }
		}

		private void ShowPauseButtonText()
		{
			if (timer.Enabled)
			{
				PauseButton.Text = "Pause";
			}
			else
			{
				PauseButton.Text = "Resume";
			}
		}

		private void CrawlButton_Click(object sender, System.EventArgs e)
		{
			timer.Enabled = true;
			ShowPauseButtonText();
			Index = 0;
			URLListBox.Items.Clear();
			URLListBox.Items.Add(urlEdit.Text);
			WebBrowser.Navigate(urlEdit.Text);
		}

		private void PauseButton_Click(object sender, System.EventArgs e)
		{
			timer.Enabled = !timer.Enabled;
			ShowPauseButtonText();
		}

		private void trackBar1_ValueChanged(object sender, System.EventArgs e)
		{
			timer.Interval = updateSpeedTrackBar.Value * 1000;
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			if (URLListBox.SelectedIndex > -1)
				Clipboard.SetDataObject(URLListBox.Items[URLListBox.SelectedIndex]);
		}

    private void WebBrowser_NewWindow(object sender, CancelEventArgs e)
    {
      e.Cancel = true;
    }

    private void WinForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.StartURL = urlEdit.Text;
      Properties.Settings.Default.UpdateSpeed = updateSpeedTrackBar.Value;
      Properties.Settings.Default.PreferDifferentDomains = diffDomainCheckBox.Checked;
      Properties.Settings.Default.Save();
    }

    private void Application_Idle(object sender, EventArgs e)
    {
      countLabel.Text = "Pages found: " + URLListBox.Items.Count.ToString();
    }
	}
}

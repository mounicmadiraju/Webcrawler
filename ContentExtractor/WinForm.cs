// Author  mounicraju@gmail.com
// Version 1.0
// ----- code  starts from here --------------- //

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Collections.Generic;

namespace ContentExtractor
{
    /// <summary>
    /// Summary description for WinForm.
    /// </summary>
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
       
        private System.Windows.Forms.TrackBar updateSpeedTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.TextBox urlEdit;
        private Label countLabel;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private WebBrowser WebBrowser;

        public WinForm()
        {
            
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Idle += new EventHandler(Application_Idle);

            urlEdit.Text = Properties.Settings.Default.StartURL;
            updateSpeedTrackBar.Value = Properties.Settings.Default.UpdateSpeed;
            //diffDomainCheckBox.Checked = Properties.Settings.Default.PreferDifferentDomains;
            comboBox1.Items.Add(new ComboBoxItem() { Text = "Select", Value = "" });
            comboBox1.Items.Add(new ComboBoxItem() { Text = "Malaysia", Value = "xxxx" });
            comboBox1.Items.Add(new ComboBoxItem() { Text = "Philippines", Value = "xxxx" });
            comboBox1.Items.Add(new ComboBoxItem() { Text = "Singapore", Value = "xxxx" });
            comboBox1.Items.Add(new ComboBoxItem() { Text = "Indonesia", Value = "xxxx" });
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = true;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateSpeedTrackBar = new System.Windows.Forms.TrackBar();
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.countLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.updateSpeedTrackBar);
            this.panel2.Controls.Add(this.PauseButton);
            this.panel2.Controls.Add(this.CrawlButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.urlEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 171);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Exceptions";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(891, 44);
            this.textBox1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Value";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(691, 58);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(99, 20);
            this.countLabel.TabIndex = 13;
            this.countLabel.Text = "Pages found";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(307, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Update speed (1-10 secs)";
            // 
            // updateSpeedTrackBar
            // 
            this.updateSpeedTrackBar.Location = new System.Drawing.Point(515, 47);
            this.updateSpeedTrackBar.Minimum = 1;
            this.updateSpeedTrackBar.Name = "updateSpeedTrackBar";
            this.updateSpeedTrackBar.Size = new System.Drawing.Size(167, 69);
            this.updateSpeedTrackBar.TabIndex = 11;
            this.updateSpeedTrackBar.Value = 10;
            this.updateSpeedTrackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(792, 7);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(120, 35);
            this.PauseButton.TabIndex = 9;
            this.PauseButton.Text = "Pause";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // CrawlButton
            // 
            this.CrawlButton.Location = new System.Drawing.Point(662, 7);
            this.CrawlButton.Name = "CrawlButton";
            this.CrawlButton.Size = new System.Drawing.Size(120, 35);
            this.CrawlButton.TabIndex = 8;
            this.CrawlButton.Text = "Crawl!";
            this.CrawlButton.Click += new System.EventHandler(this.CrawlButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start URL";
            // 
            // urlEdit
            // 
            this.urlEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.urlEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.urlEdit.Location = new System.Drawing.Point(115, 12);
            this.urlEdit.Name = "urlEdit";
            this.urlEdit.Size = new System.Drawing.Size(538, 26);
            this.urlEdit.TabIndex = 7;
            this.urlEdit.Text = "https://";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.URLListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 101);
            this.panel1.TabIndex = 10;
            // 
            // URLListBox
            // 
            this.URLListBox.ContextMenu = this.contextMenu1;
            this.URLListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.URLListBox.ItemHeight = 20;
            this.URLListBox.Location = new System.Drawing.Point(0, 0);
            this.URLListBox.Name = "URLListBox";
            this.URLListBox.Size = new System.Drawing.Size(1183, 101);
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
            this.splitter1.Location = new System.Drawing.Point(0, 272);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1183, 4);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(0, 276);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.ScriptErrorsSuppressed = true;
            this.WebBrowser.Size = new System.Drawing.Size(1183, 147);
            this.WebBrowser.TabIndex = 12;
            this.WebBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.WebBrowser_NewWindow);
            // 
            // WinForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(1183, 423);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "WinForm";
            this.Text = "Web Spider";
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

            if (Index < URLListBox.Items.Count - 1)
            {
                Index++;

                URLListBox.SelectedIndex = Index;
                WebBrowser.Navigate(URLListBox.Items[Index].ToString());
            }
            //else
            //{
            //    MessageBox.Show("Crawling completed!");
            //}
        }

        private string GetDomainName(string URL)
        {
            Uri uri = new Uri(URL);
            return uri.Host;
        }

        private void AddLink(string URL)
        {
            string ct = "";
            // don't add it if we already have it
            if (URLListBox.Items.IndexOf(URL) == -1)
            {
                if (URL.Contains("Domain"))
                {
                    // only add http links
                    if (URL.StartsWith("http"))
                    {
                        if (comboBox1.SelectedIndex != 0)
                            ct = ((ComboBoxItem)comboBox1.SelectedItem).Text;
                        if (URL.Contains("xxxx"))
                            ct = "Malaysia";
                        if (URL.Contains("xxxx"))
                            ct = "Philippines";
                        if (URL.Contains("xxxx"))
                            ct = "Singapore";
                        if (URL.Contains("xxxx"))
                            ct = "Indonesia";
                        // we prefer different domain names since these mean we do more crawling
                        bool AlreadyGotDomain = false;
                        //if (diffDomainCheckBox.Checked)
                        //{
                        if (comboBox1.SelectedIndex != 0)
                        {
                            string country = ((ComboBoxItem)comboBox1.SelectedItem).Value;
                            if (URL.Contains(country))
                            {
                                AlreadyGotDomain = true;
                                //string URLDomainName = GetDomainName(URL);
                                //int Loop = 0;
                                //while (Loop < URLListBox.Items.Count && !AlreadyGotDomain)
                                //{
                                //    string CurrentDomainName = GetDomainName(URLListBox.Items[Loop].ToString());
                                //    if (CurrentDomainName == URLDomainName)
                                //    {
                                //        AlreadyGotDomain = true;
                                //        break;
                                //    }
                                //    Loop++;
                                //}
                            }
                        }
                        else
                        {
                            // always add at the end if unchecked
                            AlreadyGotDomain = true;
                        }
                        string[] ignores = null;
                        bool[] isIgnore = null;
                        if (textBox1.Text != null)
                        {
                            ignores = textBox1.Text.Split(',');
                            isIgnore = new bool[textBox1.Text.Split(',').Length];
                        }
                        if (AlreadyGotDomain)
                        {
                            // don't bother adding too many items
                            if (URLListBox.Items.Count < (Index + 1000))
                            {
                                if (ignores != null)
                                    for (int i = 0; i < ignores.Length; i++)
                                    {
                                        if (!URL.Contains(ignores[i]))
                                        {
                                            isIgnore[i] = true;
                                        }
                                    }
                                if (isAllTrue(isIgnore))
                                {
                                    if ((!URL.Contains("mailto:") && !URL.Contains("tel:") && !URL.Contains("#") && URL != "" && URL != "/" && !URL.Contains("javascript:") && URL != "."))
                                    {
                                        URLListBox.Items.Add(URL);
                                       // InsertToDB(URL, ct);
                                    }
                                }
                                //else
                                  //  URLListBox.Items.Add(URL);
                            }
                        }
                        //else
                        //{
                        //if (!URL.Contains("xxxx/jobs") && !URL.Contains("login.xxxx.com") && !URL.Contains("jobsearch.xxxx.com") && (!URL.Contains("mailto:") && !URL.Contains("tel:") && !URL.Contains("#") && URL != "" && URL != "/" && !URL.Contains("javascript:") && URL != "."))
                        //{
                        //URLListBox.Items.Insert(Index + 1, URL);
                        //InsertToDB(URL, ct);
                        //}
                        //}
                    }
                }
            }
        }
        bool isAllTrue(bool[] ignores)
        {
            bool isTrue = false;
            for (int i = 0; i < ignores.Length; i++)
            {
                if (ignores[i])
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }
            return isTrue;
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
        }
        public void InsertToDB(string URL, string ct)
        {
            try
            {
                string htmlCode = "";
                using (WebClient client = new WebClient())
                {
                    htmlCode = client.DownloadString(URL);
                }
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());
                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter("select * from ContentChecker", conn);
                SqlCommandBuilder cmdbl = new SqlCommandBuilder(ad);
                DataSet ds = new DataSet("ContentChecker");
                ad.Fill(ds, "ContentChecker");
                if (ds.Tables["ContentChecker"].Select("Address = '" + URL + "'").Length == 0)
                {
                    DataRow row = ds.Tables["ContentChecker"].NewRow();
                    row["Address"] = URL;
                    row["StatusCode"] = 200;
                    row["Status"] = "OK";
                    row["Country"] = ct;
                    row["PageContent"] = htmlCode;
                    row["LastUpdatedOn"] = DateTime.Now;
                    ds.Tables["ContentChecker"].Rows.Add(row);
                }
                else
                {
                    DataRow row = ds.Tables["ContentChecker"].Select("Address = '" + URL + "'")[0];
                    row["PageContent"] = htmlCode;
                    row["LastUpdatedOn"] = DateTime.Now;
                }
                ds.Tables["ContentChecker"].DefaultView.ToTable(true, "Address");
                ad.Update(ds, "ContentChecker");
                conn.Close();
            }
            catch (Exception)
            {
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
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select country!");
            }
            else
            {
                timer.Enabled = true;
                ShowPauseButtonText();
                Index = 0;
                URLListBox.Items.Clear();
                URLListBox.Items.Add(urlEdit.Text);
                WebBrowser.Navigate(urlEdit.Text);
            }
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
            //Properties.Settings.Default.PreferDifferentDomains = diffDomainCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            countLabel.Text = "Pages found: " + URLListBox.Items.Count.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Web_Brauser
{
    public partial class browser : Form
    {
        private int kolPages = 0; // для наследования
        private string pathHistory = @"C:\Users\админ\Desktop\лабы\Web_Brauser\Web_Brauser\HistorySite.xml";
        private string pathMark = @"C:\Users\админ\Desktop\лабы\Web_Brauser\Web_Brauser\Sitemark.xml";
        private string url = string.Empty;

        public browser()
        {
            InitializeComponent();
        }

        void browser_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            pages.SelectedTab.Text = ((WebBrowser)pages.SelectedTab.Controls[0]).DocumentTitle;

            url = e.Url.ToString();

            DateTime localDate = DateTime.Now;

            string data = localDate.ToString();

            XmlDocument doc = new XmlDocument();
            doc.Load(pathHistory);
            XmlElement xRoot = doc.DocumentElement;

            XmlElement siteElem = doc.CreateElement("site");
            XmlAttribute dataAttr = doc.CreateAttribute("data");
            XmlAttribute urlAttr = doc.CreateAttribute("url");

            XmlText dataText = doc.CreateTextNode(data);
            XmlText urlText = doc.CreateTextNode(url);

            dataAttr.AppendChild(dataText);
            urlAttr.AppendChild(urlText);

            siteElem.Attributes.Append(dataAttr);
            siteElem.Attributes.Append(urlAttr);

            xRoot.AppendChild(siteElem);
            doc.Save(pathHistory);
        }
        private void add__Click(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;

            pages.TabPages.Add("новая");
            pages.SelectTab(kolPages);
            pages.SelectedTab.Controls.Add(browser);
            kolPages++;
        }

        private void Go_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(research.Text))
            {
                ((WebBrowser)pages.SelectedTab.Controls[0]).Navigate(research.Text);               
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            ((WebBrowser)pages.SelectedTab.Controls[0]).GoBack();
        }
        private void forward_Click(object sender, EventArgs e)
        {
            ((WebBrowser)pages.SelectedTab.Controls[0]).GoForward();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            ((WebBrowser)pages.SelectedTab.Controls[0]).Refresh();
        }

        private void browser_Load(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.ContextMenuStrip = contextMenuStrip1;
            browser.DocumentCompleted += browser_DocumentCompleted;

            pages.TabPages.Add("новая");
            pages.SelectTab(kolPages);
            pages.SelectedTab.Controls.Add(browser);
            kolPages++;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (pages.TabCount > 1)
            {
                pages.TabPages.RemoveAt(pages.SelectedIndex);
                pages.SelectTab( pages.TabPages.Count - 1);
            }
            else
            {
                Application.Exit();
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            History form = new History();
            form.Show();
        }

        private void siteMark_Click(object sender, EventArgs e)
        {
            SiteMark form = new SiteMark();
            form.Show();
        }

        private void addUrl_Click(object sender, EventArgs e)
        {
            if (url != null)
            {
                DateTime localDate = DateTime.Now;

                string data = localDate.ToString();

                XmlDocument doc = new XmlDocument();
                doc.Load(pathMark);
                XmlElement xRoot = doc.DocumentElement;

                XmlElement siteElem = doc.CreateElement("site");
                XmlAttribute dataAttr = doc.CreateAttribute("data");
                XmlAttribute urlAttr = doc.CreateAttribute("url");

                XmlText dataText = doc.CreateTextNode(data);
                XmlText urlText = doc.CreateTextNode(url);

                dataAttr.AppendChild(dataText);
                urlAttr.AppendChild(urlText);

                siteElem.Attributes.Append(dataAttr);
                siteElem.Attributes.Append(urlAttr);

                xRoot.AppendChild(siteElem);
                doc.Save(pathMark);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string a = client.Site.Name;            
        }
    }
}

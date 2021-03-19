using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Web_Brauser
{
    public partial class SiteMark : Form
    {
        private string path = @"C:\Users\админ\Desktop\лабы\Web_Brauser\Web_Brauser\Sitemark.xml";

        public SiteMark()
        {
            InitializeComponent();
            LoadXML();
        }

        void LoadXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            BindingSource bs1 = new BindingSource();

            MemoryStream rawData = new MemoryStream(File.ReadAllBytes(path));
            XmlSerializer xmls = new XmlSerializer(typeof(SiteMarks));
            var xmlList = (SiteMarks)xmls.Deserialize(rawData);

            bs1.DataSource = xmlList.siteArray;

            //dataGridView1.AutoSize = true;
            dataBaseMark.DataSource = bs1;
        }
        private void delMark_Click(object sender, EventArgs e)
        {
            if (dataBaseMark.Rows.Count != 0)
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(path);
                    XmlElement xRoot = doc.DocumentElement;

                    XmlNode node = xRoot.ChildNodes.Item(dataBaseMark.SelectedRows[0].Index); ;
                    xRoot.RemoveChild(node);
                    doc.Save(path);

                    BindingSource bs1 = new BindingSource();

                    MemoryStream rawData = new MemoryStream(File.ReadAllBytes(path));
                    XmlSerializer xmls = new XmlSerializer(typeof(SiteMarks));
                    var xmlList = (SiteMarks)xmls.Deserialize(rawData);

                    bs1.DataSource = xmlList.siteArray;

                    //dataGridView1.AutoSize = true;
                    dataBaseMark.DataSource = bs1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

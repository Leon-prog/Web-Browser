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
    public partial class History : Form
    {
        private string Path = @"C:\Users\админ\Desktop\лабы\Web_Brauser\Web_Brauser\HistorySite.xml";

        public History()
        {
            InitializeComponent();
            LoadXML();
        }

        void LoadXML()
        {
                XmlDocument doc = new XmlDocument();
                doc.Load(Path);

                BindingSource bs1 = new BindingSource();

                MemoryStream rawData = new MemoryStream(File.ReadAllBytes(Path));
                XmlSerializer xmls = new XmlSerializer(typeof(HistoryNet));
                var xmlList = (HistoryNet)xmls.Deserialize(rawData);

                bs1.DataSource = xmlList.siteArray;

                //dataGridView1.AutoSize = true;
                dataBaseHistory.DataSource = bs1;
        }

        private void delHis_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Path);

                XmlElement xRoot = doc.DocumentElement;
                xRoot.RemoveAll();

                doc.Save(Path);

                BindingSource bs1 = new BindingSource();

                MemoryStream rawData = new MemoryStream(File.ReadAllBytes(Path));
                XmlSerializer xmls = new XmlSerializer(typeof(HistoryNet));
                var xmlList = (HistoryNet)xmls.Deserialize(rawData);

                bs1.DataSource = xmlList.siteArray;

                //dataGridView1.AutoSize = true;
                dataBaseHistory.DataSource = bs1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

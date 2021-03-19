using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Brauser
{
    [System.Xml.Serialization.XmlRoot("HistoryNet")]
    public class HistoryNet
    {
        [System.Xml.Serialization.XmlElement("site")]
        public site[] siteArray { get; set; }
    }
    public class site
    {
        [System.Xml.Serialization.XmlAttribute("data", Namespace = "")]
        public string data { get; set; }
        [System.Xml.Serialization.XmlAttribute("url", Namespace = "")]
        public string Url { get; set; }
    }
}

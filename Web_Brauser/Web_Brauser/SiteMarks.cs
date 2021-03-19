using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Brauser
{
    [System.Xml.Serialization.XmlRoot("Sitemarks")]
    public class SiteMarks
    {
        [System.Xml.Serialization.XmlElement("site")]
        public site[] siteArray { get; set; }
    }
}

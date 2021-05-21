using System;
using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "AuthorizationPeriod", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
    public class AuthorizationPeriod
    {
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        [XmlIgnore]
        public DateTime EndDate { get; set; }

        [XmlElement(ElementName = "StartDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string StartDateString { get => StartDate.ToString("yyyy-MM-dd"); set => StartDate = DateTime.Parse(value); }
        [XmlElement(ElementName = "EndDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string EndDateString { get => EndDate.ToString("yyyy-MM-dd"); set => EndDate = DateTime.Parse(value); }
    }
}

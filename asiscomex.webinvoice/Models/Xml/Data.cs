using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "DATA", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    public class Data
    {
        [XmlElement(ElementName = "UBL21", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
        public string UBL21 { get; set; }
        [XmlElement(ElementName = "Partnership", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
        public Partnership Partnership { get; set; }
    }
}
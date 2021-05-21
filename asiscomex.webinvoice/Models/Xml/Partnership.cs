using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "Partnership", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    public class Partnership
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "TechKey", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
        public string TechKey { get; set; }
        [XmlElement(ElementName = "SetTestID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
        public string SetTestID { get; set; }
    }
}
using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Uuid
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
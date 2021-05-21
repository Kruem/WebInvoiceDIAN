using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Id
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeId { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
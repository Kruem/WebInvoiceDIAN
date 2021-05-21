using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "TaxLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxLevelCode
    {
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
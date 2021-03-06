using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "CreditedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CreditedQuantity
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}

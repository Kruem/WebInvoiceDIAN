using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LineExtensionAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyId { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
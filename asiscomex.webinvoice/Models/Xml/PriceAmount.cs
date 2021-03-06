using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "PriceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PriceAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
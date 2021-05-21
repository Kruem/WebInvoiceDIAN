using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "AuthorizedInvoices", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
    public class AuthorizedInvoices
    {
        [XmlElement(ElementName = "Prefix", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
        public string Prefix { get; set; }
        [XmlElement(ElementName = "From", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
        public string From { get; set; }
        [XmlElement(ElementName = "To", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
        public string To { get; set; }
    }
}

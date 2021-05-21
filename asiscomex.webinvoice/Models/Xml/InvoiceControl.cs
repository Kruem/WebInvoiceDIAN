using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "InvoiceControl", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
    public class InvoiceControl
    {
        [XmlElement(ElementName = "InvoiceAuthorization", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
        public string InvoiceAuthorization { get; set; }
        [XmlElement(ElementName = "AuthorizationPeriod", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
        public AuthorizationPeriod AuthorizationPeriod { get; set; }
        [XmlElement(ElementName = "AuthorizedInvoices", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
        public AuthorizedInvoices AuthorizedInvoices { get; set; }
    }
}

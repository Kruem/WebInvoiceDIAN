using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "DianExtensions", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
    public class DianExtensions
    {
        [XmlElement(ElementName = "InvoiceControl", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
        public InvoiceControl InvoiceControl { get; set; }
    }
}
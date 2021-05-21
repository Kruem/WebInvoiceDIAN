using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "ExtensionContent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class ExtensionContent
    {
        [XmlElement(ElementName = "DianExtensions", Namespace = "dian:gov:co:facturaelectronica:Structures-2-1")]
        public DianExtensions DianExtensions { get; set; }
    }
}

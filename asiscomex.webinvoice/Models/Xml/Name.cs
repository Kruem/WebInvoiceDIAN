using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "Name2", Namespace = "")]
    public class Name
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageId { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
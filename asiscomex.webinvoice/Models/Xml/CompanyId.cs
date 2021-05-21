using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "CompanyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CompanyId
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeId { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyId { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
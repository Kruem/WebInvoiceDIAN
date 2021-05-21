using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "DebitNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")]
    public class DebitNote : InvoiceXmlDocument
    {
        [XmlElement(ElementName = "CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CustomizationId { get; set; }
        [XmlElement(ElementName = "ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ProfileExecutionId { get; set; }
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Uuid Uuid { get; set; }
        [XmlIgnore]
        public DateTime IssueDate { get; set; }
        [XmlElement(ElementName = "IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueDateString { get => IssueDate.ToString("yyyy-MM-dd"); set => IssueDate = DateTime.Parse(value); }
        [XmlElement(ElementName = "IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueTimeString { get => IssueDate.ToString("HH:mm:sszzz"); set => IssueDate = DateTime.Parse(value); }
        [XmlElement(ElementName = "CreditNoteTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CreditNoteTypeCode { get; set; }
        [XmlElement(ElementName = "RequestedMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequestedMonetaryTotal RequestedMonetaryTotal { get; set; }
        [XmlElement(ElementName = "Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string Note { get; set; }
        [XmlElement(ElementName = "DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string DocumentCurrencyCode { get; set; }
        [XmlElement(ElementName = "LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string LineCountNumeric { get; set; }
        [XmlElement(ElementName = "DiscrepancyResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DiscrepancyResponse DiscrepancyResponse { get; set; }
        [XmlElement(ElementName = "BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public BillingReference BillingReference { get; set; }
        [XmlElement(ElementName = "AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AccountingSupplierParty AccountingSupplierParty { get; set; }
        [XmlElement(ElementName = "AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AccountingCustomerParty AccountingCustomerParty { get; set; }
        [XmlElement(ElementName = "PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeans PaymentMeans { get; set; }
        [XmlElement(ElementName = "TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotal TaxTotal { get; set; }
        [XmlElement(ElementName = "LegalMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }
        [XmlElement(ElementName = "DebitNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DebitNoteLine DebitNoteLine { get; set; }
        [XmlElement(ElementName = "DATA", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")]
        public Data Data { get; set; }
        [XmlAttribute(AttributeName = "ds", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ds { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "cac", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Cac { get; set; } = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
        [XmlAttribute(AttributeName = "cbc", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Cbc { get; set; } = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        [XmlAttribute(AttributeName = "ext", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ext { get; set; } = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";
        [XmlAttribute(AttributeName = "sts", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Sts { get; set; } = "dian:gov:co:facturaelectronica:Structures-2-1";
        [XmlAttribute(AttributeName = "xades", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xades { get; set; } = "http://uri.etsi.org/01903/v1.3.2#";
        [XmlAttribute(AttributeName = "xades141", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xades141 { get; set; } = "http://uri.etsi.org/01903/v1.4.1#";
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; } = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2";
    }
}

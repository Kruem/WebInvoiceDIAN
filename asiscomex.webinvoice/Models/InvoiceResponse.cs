namespace Asiscomex.Webinvoice.Models
{
    public class InvoiceResponse
    {
        public bool Successful { get; set; }
        public InvoiceResponseData Data { get; set; }
        public InvoiceError Error { get; set; }
    }
}

using Asiscomex.Webinvoice.Config;
using Asiscomex.Webinvoice.Models.Xml;
using QRCoder;
using System.Drawing;
using System.Text;

namespace Asiscomex.Webinvoice.Qr
{
    public static class InvoiceQr
    {
        public static Bitmap Create(Invoice invoice)
        {
            var body = CreateTextBody(invoice);
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(body, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }

        public static void CreateAndSave(Invoice invoice, string imagePath)
        {
            var bitmap = Create(invoice);
            bitmap.Save(imagePath);
        }

        private static string CreateTextBody(Invoice invoice)
        {
            var body = new StringBuilder();
            body.AppendLine($"{Constants.Qr.IdKey}: {invoice.Id.Text}");
            body.AppendLine($"{Constants.Qr.IssueDateKey}: {invoice.IssueDateString}");
            body.AppendLine($"{Constants.Qr.SupplierCompanyIdKey}: {invoice.AccountingSupplierParty.Party.PartyTaxScheme.CompanyId.Text}");
            body.AppendLine($"{Constants.Qr.CustomerCompanyIdKey}: {invoice.AccountingCustomerParty.Party.PartyTaxScheme.CompanyId.Text}");
            body.AppendLine($"{Constants.Qr.LineExtensionAmountKey}: {invoice.LegalMonetaryTotal.LineExtensionAmount.Text}");
            body.AppendLine($"{Constants.Qr.TaxAmountKey}: {invoice.TaxTotal.TaxAmount.Text}");
            body.AppendLine($"{Constants.Qr.OtherTaxAmountKey}: 0.00");
            body.AppendLine($"{Constants.Qr.PayableAmountKey}: {invoice.LegalMonetaryTotal.PayableAmount.Text}");
            body.AppendLine($"{Constants.Qr.UuidKey}: {invoice.Uuid.Text}");
            return body.ToString();
        }
    }
}

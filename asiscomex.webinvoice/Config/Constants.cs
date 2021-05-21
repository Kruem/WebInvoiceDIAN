namespace Asiscomex.Webinvoice.Config
{
    public static class Constants
    {
        public const string ContentTypeKey = "Content-Type";
        public const string ContentTypeValue = "text/plain";
        public const string AuthTokenKey = "efacturaAuthorizationToken";

        public static class Qr
        {
            public const string IdKey = "NumFac";
            public const string IssueDateKey = "FecFac";
            public const string SupplierCompanyIdKey = "NitFac";
            public const string CustomerCompanyIdKey = "DocAdq";
            public const string LineExtensionAmountKey = "ValFac";
            public const string TaxAmountKey = "ValIva";
            public const string OtherTaxAmountKey = "ValOtroIm";
            public const string PayableAmountKey = "ValFacIm";
            public const string UuidKey = "CUFE";
        }
    }
}

using Asiscomex.Webinvoice.Models;
using Asiscomex.Webinvoice.Config;
using Asiscomex.Webinvoice.Models.Xml;
using RestSharp;

namespace Asiscomex.Webinvoice.Services
{
    public class InvoiceService
    {
        private readonly string url;
        private readonly string token;

        public InvoiceService(string url, string token)
        {
            this.url = url;
            this.token = token;
        }

        public InvoiceResponse Execute(InvoiceXmlDocument invoice)
        {
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader(Constants.AuthTokenKey, token);
            request.AddHeader(Constants.ContentTypeKey, Constants.ContentTypeValue);
            request.AddParameter(Constants.ContentTypeValue, invoice.ToBase64Xml(), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                return new InvoiceResponse()
                {
                    Successful = true,
                    Data = Newtonsoft.Json.JsonConvert.DeserializeObject<InvoiceResponseData>(response.Content)
                };
            }
            else
            {
                return new InvoiceResponse()
                {
                    Successful = false,
                    Error = Newtonsoft.Json.JsonConvert.DeserializeObject<InvoiceError>(response.Content)
                };
            }
        }
    }
}

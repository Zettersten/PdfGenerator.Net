using System;
using System.Net;
using System.Threading.Tasks;
using PdfGenerator.Net.Models;
using RestSharp.Authenticators;

namespace PdfGenerator.Net.Builders
{
    public class RequestBuilder : IRequestBuilder
    {
        private readonly IPdfGeneratorHttpClient pdfGenerator;
        private PdfReportModel pdfReportModel;

        public RequestBuilder(IPdfGeneratorHttpClient pdfGenerator)
        {
            this.pdfGenerator = pdfGenerator;
        }

        public RequestBuilder WithBaseUri(Uri baseUri)
        {
            pdfGenerator.BaseUrl = baseUri;
            return this;
        }

        public RequestBuilder WithAuthenticator(IAuthenticator authenticator)
        {
            pdfGenerator.Authenticator = authenticator;
            return this;
        }

        public RequestBuilder WithProxy(IWebProxy webProxy)
        {
            pdfGenerator.Proxy = webProxy;
            return this;
        }

        public RequestBuilder AddPdfData(PdfReportModel pdfReportModel)
        {
            this.pdfReportModel = pdfReportModel;
            return this;
        }

        public async Task<Uri> SendAsync()
        {
            var response = await pdfGenerator.GeneratePdf(pdfReportModel);

            return new Uri(response.Resource);
        }
    }
}

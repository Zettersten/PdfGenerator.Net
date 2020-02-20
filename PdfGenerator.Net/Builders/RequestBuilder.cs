using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using PdfGenerator.Net.Extensions;
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

        public async Task PreviewAsync(string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Path.Combine(Path.GetTempPath(), pdfReportModel.ToFileName());
            }

            using var fileStream = File.OpenWrite(filePath);
            using var response = await pdfGenerator.GeneratePdfPreview(pdfReportModel);

            await response.CopyToAsync(fileStream);
        }

        public async Task PreviewAsync(Stream stream)
        {   
            using var response = await pdfGenerator.GeneratePdfPreview(pdfReportModel);

            await response.CopyToAsync(stream);
        }
    }
}

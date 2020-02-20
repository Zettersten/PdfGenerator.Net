using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using PdfGenerator.Net.Models;
using RestSharp.Authenticators;

namespace PdfGenerator.Net.Builders
{
    public interface IRequestBuilder
    {
        RequestBuilder AddPdfData(PdfReportModel pdfReportModel);

        Task<Uri> SendAsync();

        Task PreviewAsync(string filePath);

        Task PreviewAsync(Stream stream);

        RequestBuilder WithAuthenticator(IAuthenticator authenticator);

        RequestBuilder WithBaseUri(Uri baseUri);

        RequestBuilder WithProxy(IWebProxy webProxy);
    }
}

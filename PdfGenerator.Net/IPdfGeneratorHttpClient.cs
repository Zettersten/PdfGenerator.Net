using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PdfGenerator.Net.Builders;
using PdfGenerator.Net.Models;
using RestSharp;

namespace PdfGenerator.Net
{
    public interface IPdfGeneratorHttpClient : IRestClient
    {
        ILogger Logger { get; }

        PdfGeneratorOptions Options { get; }

        Task<SuccessModel<string>> GeneratePdf(PdfReportModel pdfReport, CancellationToken cancellationToken = default);

        Task<SuccessModel<string>> GeneratePdf(IReportBuilder builder, CancellationToken cancellationToken = default);

        Task<List<Uri>> GenerateSvgs(IReportBuilder builder, CancellationToken cancellationToken = default);

        Task<List<Uri>> GenerateSvgs(PdfReportModel pdfReport, CancellationToken cancellationToken = default);
    }
}

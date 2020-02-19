using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PdfGenerator.Net.Builders;
using PdfGenerator.Net.Models;
using PdfGenerator.Net.Services;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace PdfGenerator.Net
{
    public class PdfGeneratorHttpClient : RestClient, IPdfGeneratorHttpClient
    {
        /// <summary>
        /// Uses: configuration["PdfGenerator:AccessToken"]
        /// </summary>
        /// <param name="configuration"></param>
        public PdfGeneratorHttpClient(IConfiguration configuration) : this(PdfGeneratorOptions.Create(configuration[$"PdfGenerator:{nameof(PdfGeneratorOptions.AccessToken)}"], configuration[$"PdfGenerator:{nameof(PdfGeneratorOptions.ApplicationId)}"], configuration[$"PdfGenerator:{nameof(PdfGeneratorOptions.ApplicationId)}"])) { }

        public PdfGeneratorHttpClient(IOptions<PdfGeneratorOptions> options) : this(options.Value)
        {
        }

        public PdfGeneratorHttpClient(PdfGeneratorOptions options) : this(new PdfGeneratorAuthenticator(options))
        {
        }

        private PdfGeneratorHttpClient(PdfGeneratorAuthenticator pdfGeneratorAuthenticator) : base(pdfGeneratorAuthenticator.Options.Domain)
        {
            this.UseNewtonsoftJson(PdfGeneratorContentSerialization.SerializerSettings);
            this.Authenticator = pdfGeneratorAuthenticator;
            this.UserAgent = $"{nameof(PdfGeneratorHttpClient)}/{Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion}";
            this.Logger = PdfGeneratorHttpClientLogging.CreateLogger();
        }

        public PdfGeneratorOptions Options => ((PdfGeneratorAuthenticator)this.Authenticator).Options;

        public ILogger Logger { get; }

        public Task<SuccessModel<string>> GeneratePdf(IReportBuilder builder, CancellationToken cancellationToken = default)
        {
            return GeneratePdf(builder.Build(), cancellationToken);
        }

        public async Task<SuccessModel<string>> GeneratePdf(PdfReportModel pdfReport, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("reports", Method.POST, DataFormat.Json);

            request.AddJsonBody(pdfReport);

            var response = await ExecutePostAsync<SuccessModel<string>>(request, cancellationToken);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ErrorModel>(response.Content, PdfGeneratorContentSerialization.SerializerSettings);
                throw new PdfGeneratorException(error);
            }

            return response.Data;
        }

        public Task<Stream> GeneratePdfPreview(IReportBuilder builder, CancellationToken cancellationToken = default)
        {
            return GeneratePdfPreview(builder.Build(), cancellationToken);
        }

        public async Task<Stream> GeneratePdfPreview(PdfReportModel pdfReport, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("reports/preview", Method.POST, DataFormat.Json);

            request.AddJsonBody(pdfReport);

            var response = await ExecutePostAsync(request, cancellationToken);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ErrorModel>(response.Content, PdfGeneratorContentSerialization.SerializerSettings);
                throw new PdfGeneratorException(error);
            }

            return new MemoryStream(response.RawBytes);
        }

        public Task<List<Uri>> GenerateSvgs(IReportBuilder builder, CancellationToken cancellationToken = default)
        {
            return GenerateSvgs(builder.Build(), cancellationToken);
        }

        public async Task<List<Uri>> GenerateSvgs(PdfReportModel pdfReport, CancellationToken cancellationToken = default)
        {
            var report = await GeneratePdf(pdfReport);

            var request = new RestRequest("svg?fileName=" + report.Id, Method.GET);

            var response = await ExecuteGetAsync<SuccessModel<List<string>>>(request, cancellationToken);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ErrorModel>(response.Content, PdfGeneratorContentSerialization.SerializerSettings);
                throw new PdfGeneratorException(error);
            }

            return response.Data.Resource.Select(x => new Uri(x)).ToList();
        }
    }
}

using System.Net;
using Microsoft.Extensions.DependencyInjection;
using PdfGenerator.Net.Builders;
using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPdfGenerator(this IServiceCollection services)
        {
            return services
                .AddSingleton<IChartBuilder, ChartJsBuilder>()
                .AddSingleton<IPdfGeneratorHttpClient, PdfGeneratorHttpClient>()
                .AddTransient<IRequestBuilder, RequestBuilder>()
                .AddTransient<IReportBuilder, ReportBuilder>()
                .AddTransient<ITableBuilder, TableBuilder>();
        }

        public static IServiceCollection AddPdfGenerator(this IServiceCollection services, PdfGeneratorOptions options)
        {
            return services
                .AddSingleton<IChartBuilder, ChartJsBuilder>()
                .AddSingleton<IPdfGeneratorHttpClient>(_ => new PdfGeneratorHttpClient(options))
                .AddTransient<IRequestBuilder, RequestBuilder>()
                .AddTransient<IReportBuilder, ReportBuilder>()
                .AddTransient<ITableBuilder, TableBuilder>();
        }

        public static IServiceCollection AddPdfGenerator(this IServiceCollection services, PdfGeneratorOptions options, IWebProxy webProxy)
        {
            return services
                .AddSingleton<IChartBuilder, ChartJsBuilder>()
                .AddSingleton<IPdfGeneratorHttpClient>(_ => new PdfGeneratorHttpClient(options) { Proxy = webProxy })
                .AddTransient<IRequestBuilder, RequestBuilder>()
                .AddTransient<IReportBuilder, ReportBuilder>()
                .AddTransient<ITableBuilder, TableBuilder>();
        }
    }
}

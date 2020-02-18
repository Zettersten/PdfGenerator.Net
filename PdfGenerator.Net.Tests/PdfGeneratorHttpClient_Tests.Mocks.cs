using PdfGenerator.Net.Builders;
using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Tests
{
    public partial class PdfGeneratorHttpClient_Tests
    {
        public static PdfGeneratorHttpClient PdfGenerator => new PdfGeneratorHttpClient(new PdfGeneratorOptions
        {
            AccessToken = "abc123",
            ApplicationId = "appId"
        });

        public static ReportBuilder ReportBuilder => new ReportBuilder();

        public static TableBuilder TableBuilder => new TableBuilder();

        public static PdfReportModel BasicTable_Sample => ReportBuilder
            .WithMetaData("Erik Zettersten", "Erik The Red", "Erik's Subject")
            .WithPageHeaders("Header Content", 12, "#000000", "Helvetica", "center", "bold", "#FFFFFF", 6)
            .WithPageFooters("Footer Content", 12, "#cccccc", "Helvetica", "center", "bold", "#efefef", 3)
            .WithAlternatingRowBackgroundColors()
            .AddTable(
                TableBuilder
                    .AddHeaderData(new string[] { "Header -> First", "Header -> Second", "Header -> Third", "Header -> Fourth" }, 14, "#FFFFFF", "Helvetica", "left", "bold", "#000000", 2)
                    .AddRowData(new string[] { "Row 1 -> First", "Row 1 -> Second", "Row 1 -> Third", "Row 1 -> Fourth" })
                    .AddRowData(new string[] { "Row 2 -> First", "Row 2 -> Second", "Row 2 -> Third", "Row 2 -> Fourth" })
                    .AddRowData(new string[] { "Row 3 -> First", "Row 3 -> Second", "Row 3 -> Third", "Row 3 -> Fourth" })
                    .AddRowData(new string[] { "Row 4 -> First", "Row 4 -> Second", "Row 4 -> Third", "Row 4 -> Fourth" })
                    .AddRowData(new string[] { "Row 5 -> First", "Row 5 -> Second", "Row 5 -> Third", "Row 5 -> Fourth" })
                    .AddRowData(new string[] { "Row 6 -> First", "Row 6 -> Second", "Row 6 -> Third", "Row 6 -> Fourth" })
                    .AddRowData(new string[] { "Row 7 -> First", "Row 7 -> Second", "Row 7 -> Third", "Row 7 -> Fourth" })
                    .AddRowData(new string[] { "Row 8 -> First", "Row 8 -> Second", "Row 8 -> Third", "Row 8 -> Fourth" })
                    .AddRowData(new string[] { "Row 9 -> First", "Row 9 -> Second", "Row 9 -> Third", "Row 9 -> Fourth" })
                    .AddRowData(new string[] { "Row 10 -> First", "Row 10 -> Second", "Row 10 -> Third", "Row 10 -> Fourth" })
                    .AddRowData(new string[] { "Row 11 -> First", "Row 11 -> Second", "Row 11 -> Third", "Row 11 -> Fourth" })
                    .AddRowData(new string[] { "Row 12 -> First", "Row 12 -> Second", "Row 12 -> Third", "Row 12 -> Fourth" })
                    .AddRowData(new string[] { "Row 13 -> First", "Row 13 -> Second", "Row 13 -> Third", "Row 13 -> Fourth" })
                    .AddRowData(new string[] { "Row 14 -> First", "Row 14 -> Second", "Row 14 -> Third", "Row 14 -> Fourth" })
                    .AddRowData(new string[] { "Row 15 -> First", "Row 15 -> Second", "Row 15 -> Third", "Row 15 -> Fourth" })
                    .AddRowData(new string[] { "Row 16 -> First", "Row 16 -> Second", "Row 16 -> Third", "Row 16 -> Fourth" })
                    .AddRowData(new string[] { "Row 17 -> First", "Row 17 -> Second", "Row 17 -> Third", "Row 17 -> Fourth" })
                    .AddFooterData(new string[] { "Footer -> First", "Footer -> Second", "Footer -> Third", "Footer -> Fourth" }, 12, "#FFFFFF", "Helvetica", "center", "bold", "#000000", 2)
            ).Create();
    }
}
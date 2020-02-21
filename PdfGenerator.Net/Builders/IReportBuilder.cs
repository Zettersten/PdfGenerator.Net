using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    public interface IReportBuilder
    {
        ReportBuilder AddSpacer(int height = 5);

        ReportBuilder AddHorizontalRule(double borderWidth = 1, string borderColor = "#cccccc", string borderDirection = "top");

        ReportBuilder AddTable(PdfTableModel table);

        ReportBuilder AddTable(ITableBuilder tableBuilder);

        ReportBuilder WithMinRowHeight(double minHeight = 13);

        PdfReportModel Build();

        ReportBuilder WithAlternatingRowBackgroundColors(string alternateBackgroundColor = "#efefef");

        ReportBuilder WithMetaData(string name, string author = null, string subject = null);

        ReportBuilder WithPageBorders(double borderWidth, string borderColor = "#cccccc", string borderDirection = "top");

        ReportBuilder AddChart(
            IChartBuilder chartBuilder,
            string textAlign = "center",
            int innerMargins = 0,
            string innerMarginsDirection = null,
            int outerMargins = 0,
            string outerMarginsDirection = null,
            bool newPageAfterChart = false);

        ReportBuilder WithPageFooter(
            string content,
            double fontSize = 11,
            string color = "#000000",
            string fontFamily = "Helvetica",
            string textAlign = "center",
            string fontWeight = "normal",
            string backgroundColor = "#ffffff",
            string fontStyle = "normal",
            string fontDecoration = null,
            string verticalAlignment = "center",
            double margins = 0,
            string marginDirection = null);

        ReportBuilder WithDefaultPageFooter();

        ReportBuilder WithPageHeader(
            string content,
            double fontSize = 11,
            string color = "#000000",
            string fontFamily = "Helvetica",
            string textAlign = "center",
            string fontWeight = "normal",
            string backgroundColor = "#ffffff",
            string fontStyle = "normal",
            string fontDecoration = null,
            string verticalAlignment = "center",
            double margins = 0,
            string marginDirection = null);

        ReportBuilder WithDefaultPageHeader();

        ReportBuilder WithPageNumbers(string pageNumberTemplate = null);

        void Clear();
    }
}

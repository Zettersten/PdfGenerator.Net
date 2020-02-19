using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    public interface IReportBuilder
    {
        ReportBuilder AddSpacer(int height = 5);

        ReportBuilder AddHorizontalRule(double borderWidth = 1, string borderColor = "#cccccc", string borderDirection = "top");

        ReportBuilder AddTable(PdfTableModel table);

        ReportBuilder AddTable(ITableBuilder tableBuilder);

        ReportBuilder AddMinRowHeight(double minHeight = 14);

        PdfReportModel Build();

        ReportBuilder WithAlternatingRowBackgroundColors(string alternateBackgroundColor = "#efefef");

        ReportBuilder WithMetaData(string name, string author = null, string subject = null);

        ReportBuilder WithPageBorders(double borderWidth, string borderColor = "#cccccc", string borderDirection = "top");

        ReportBuilder WithPageFooters(string content, double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "center", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0);

        ReportBuilder WithPageHeaders(string content, double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "center", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0);

        ReportBuilder WithPageNumbers(string pageNumberTemplate = null);
    }
}

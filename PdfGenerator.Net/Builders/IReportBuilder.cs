using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    public interface IReportBuilder
    {
        ReportBuilder AddTable(PdfTableModel table);

        ReportBuilder AddTable(ITableBuilder tableBuilder);

        PdfReportModel Create();

        ReportBuilder WithAlternatingRowBackgroundColors(string alternateBackgroundColor = "#efefef");

        ReportBuilder WithMetaData(string name, string author = null, string subject = null);

        ReportBuilder WithPageBorders(double borderWidth, string borderColor = "#cccccc", string borderDirection = "all");

        ReportBuilder WithPageFooters(string content, double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "center", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0);

        ReportBuilder WithPageHeaders(string content, double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "center", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0);

        ReportBuilder WithPageNumbers(string pageNumberTemplate = null);
    }
}

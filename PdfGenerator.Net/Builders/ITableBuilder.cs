using System.Collections.Generic;
using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    public interface ITableBuilder
    {
        TableBuilder AddFooterData(IEnumerable<PdfReportCellModel> footerContent);

        TableBuilder AddFooterData(string[] footerContent, double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "left", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0, double width = 0, int colSpan = 1);

        TableBuilder AddHeaderData(IEnumerable<PdfReportCellModel> headerContent);

        TableBuilder AddHeaderData(string[] headerContent, double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "left", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0, double width = 0, int colSpan = 1);

        TableBuilder AddRowData(IEnumerable<PdfReportCellModel> rowContent);

        TableBuilder AddRowData(string[] rowContent, double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "left", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0, double width = 0, int colSpan = 1);

        PdfTableModel Build(bool hasAlternatingRowBackgroundColor = false, string alternatingRowBackgroundColor = "#efefef");

        IEnumerator<PdfReportCellModel> GetEnumerator();

        TableBuilder WithInnerMargins(int margins);

        TableBuilder WithOuterMargins(int margins);

        TableBuilder WithPageBreak();

        TableBuilder WithRowNumbers(double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "center", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0, double width = 0, int colSpan = 1);
    }
}

using System.Collections.Generic;
using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    /// <summary>
    /// Report Builder
    /// </summary>
    public class ReportBuilder : IReportBuilder
    {
        private readonly PdfReportModel report;

        public ReportBuilder()
        {
            this.report = new PdfReportModel();
        }

        private bool HasAlternatingRowBackgroundColor { get; set; }

        private string AlternatingRowBackgroundColor { get; set; }

        public ReportBuilder WithAlternatingRowBackgroundColors(string alternateBackgroundColor = "#efefef")
        {
            HasAlternatingRowBackgroundColor = true;
            AlternatingRowBackgroundColor = alternateBackgroundColor;

            return this;
        }

        public ReportBuilder WithMetaData(string name, string author = null, string subject = null)
        {
            report.Name = name;
            report.Author = author;
            report.Subject = subject;

            return this;
        }

        public ReportBuilder WithPageNumbers(string pageNumberTemplate = null)
        {
            report.ShouldGeneratePageNumbers = true;
            report.PageNumberTemplate = pageNumberTemplate;

            return this;
        }

        public ReportBuilder WithPageBorders(double borderWidth, string borderColor = "#cccccc", string borderDirection = "all")
        {
            report.BorderWidth = borderWidth;
            report.BorderColor = borderColor;
            report.BorderDirection = borderDirection;

            return this;
        }

        public ReportBuilder WithPageHeaders(string content, double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "center", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0)
        {
            if (report.PageHeader == null)
            {
                report.PageHeader = new PdfReportCellModel();
            }

            report.PageHeader.FontSize = fontSize;
            report.PageHeader.FontFamily = fontFamily;
            report.PageHeader.FontWeight = fontWeight;
            report.PageHeader.TextAlign = textAlign;
            report.PageHeader.InnerMargins = margins;
            report.PageHeader.Value = content;
            report.PageHeader.Color = color;
            report.PageHeader.BackgroundColor = backgroundColor;

            return this;
        }

        public ReportBuilder WithPageFooters(string content, double fontSize = 12, string color = "#000000", string fontFamily = "Helvetica", string textAlign = "center", string fontWeight = "normal", string backgroundColor = "#ffffff", double margins = 0)
        {
            if (report.PageFooter == null)
            {
                report.PageFooter = new PdfReportCellModel();
            }

            report.PageFooter.FontSize = fontSize;
            report.PageFooter.FontFamily = fontFamily;
            report.PageFooter.FontWeight = fontWeight;
            report.PageFooter.TextAlign = textAlign;
            report.PageFooter.InnerMargins = margins;
            report.PageFooter.Value = content;
            report.PageFooter.Color = color; ;
            report.PageFooter.BackgroundColor = backgroundColor;

            return this;
        }

        public ReportBuilder AddTable(ITableBuilder tableBuilder)
        {
            if (report.Tables == null)
            {
                report.Tables = new List<PdfTableModel>();
            }

            report.Tables.Add(tableBuilder.Build(HasAlternatingRowBackgroundColor, AlternatingRowBackgroundColor));

            return this;
        }

        public ReportBuilder AddTable(PdfTableModel table)
        {
            if (report.Tables == null)
            {
                report.Tables = new List<PdfTableModel>();
            }

            report.Tables.Add(table);

            return this;
        }

        public PdfReportModel Create()
        {
            return report;
        }
    }
}

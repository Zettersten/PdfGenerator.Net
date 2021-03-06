﻿using System;
using System.Collections.Generic;
using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    /// <summary>
    /// Report Builder
    /// </summary>
    public class ReportBuilder : IReportBuilder
    {
        private PdfReportModel report;

        public ReportBuilder()
        {
            this.report = new PdfReportModel();
        }

        public ReportBuilder AddSpacer(int height = 10)
        {
            return AddTable(
                new TableBuilder()
                .WithOuterMargins(height)
                .AddHeaderData(new string[] { " " })
                .AddRowData(new string[] { " " })
                .AddFooterData(new string[] { " " })
             );
        }

        public ReportBuilder AddHorizontalRule(double borderWidth = 2, string borderColor = "#cccccc", string borderDirection = "top")
        {
            return AddTable(
                new TableBuilder()
                .WithInnerMargins(0)
                .WithOuterMargins(0)
                .AddHeaderData(
                    new string[] { " " },
                    borderWidth: borderWidth,
                    borderColor: borderColor,
                    borderDirection: borderDirection)
             );
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

        public ReportBuilder WithPageBorders(double borderWidth, string borderColor = "#cccccc", string borderDirection = "top")
        {
            report.BorderWidth = borderWidth;
            report.BorderColor = borderColor;
            report.BorderDirection = borderDirection;

            return this;
        }

        public ReportBuilder WithPageHeader(
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
            string marginDirection = null)
        {
            if (report.PageHeader == null)
            {
                report.PageHeader = new PdfReportCellModel();
            }

            report.PageHeader.FontSize = fontSize;
            report.PageHeader.FontStyle = fontStyle;
            report.PageHeader.FontDecoration = fontDecoration;
            report.PageHeader.VerticalAlignment = verticalAlignment;
            report.PageHeader.FontFamily = fontFamily;
            report.PageHeader.FontWeight = fontWeight;
            report.PageHeader.TextAlign = textAlign;
            report.PageHeader.InnerMargins = margins;
            report.PageHeader.InnerMarginsDirection = marginDirection;
            report.PageHeader.Value = content;
            report.PageHeader.Color = color;
            report.PageHeader.BackgroundColor = backgroundColor;

            return this;
        }

        public ReportBuilder WithPageFooter(
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
            string marginDirection = null)
        {
            if (report.PageFooter == null)
            {
                report.PageFooter = new PdfReportCellModel();
            }

            report.PageFooter.FontSize = fontSize;
            report.PageFooter.FontStyle = fontStyle;
            report.PageFooter.FontDecoration = fontDecoration;
            report.PageFooter.VerticalAlignment = verticalAlignment;
            report.PageFooter.FontFamily = fontFamily;
            report.PageFooter.FontWeight = fontWeight;
            report.PageFooter.TextAlign = textAlign;
            report.PageFooter.InnerMargins = margins;
            report.PageFooter.InnerMarginsDirection = marginDirection;
            report.PageFooter.Value = content;
            report.PageFooter.Color = color;
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

        public ReportBuilder AddChart(
            IChartBuilder chartBuilder,
            string textAlign = "center",
            int innerMargins = 0,
            string innerMarginsDirection = null,
            int outerMargins = 0,
            string outerMarginsDirection = null,
            bool newPageAfterChart = false)
        {
            var pdfTableModel = new PdfTableModel()
            {
                NewPageAfterTable = newPageAfterChart,
                OuterMargins = outerMargins,
                OuterMarginsDirection = outerMarginsDirection,
                InnerMargins = innerMargins,
                InnerMarginsDirection = innerMarginsDirection
            };

            var cell = chartBuilder.BuildTableCell();
            cell.TextAlign = textAlign;

            pdfTableModel.Body = new List<List<PdfReportCellModel>>
            {
                new List<PdfReportCellModel>
                {
                    cell
                }
            };

            if (report.Tables == null)
            {
                report.Tables = new List<PdfTableModel>();
            }

            report.Tables.Add(pdfTableModel);

            return this;
        }

        public PdfReportModel Build()
        {
            return report;
        }

        public ReportBuilder WithMinRowHeight(double minHeight = 13)
        {
            report.MinRowHeight = minHeight;
            return this;
        }

        public ReportBuilder WithDefaultPageFooter()
        {
            var content = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            if (!string.IsNullOrEmpty(report.Author))
            {
                content = content + " © " + report.Author;
            }

            return WithPageFooter(
                content: content,
                fontSize: 8,
                margins: 10,
                textAlign: "left");
        }

        public ReportBuilder WithDefaultPageHeader()
        {
            return WithDefaultPageFooter();
        }

        public void Clear()
        {
            this.report = new PdfReportModel();
        }
    }
}

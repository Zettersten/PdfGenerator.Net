using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PdfGenerator.Net.Extensions;
using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    public class TableBuilder : IEnumerable<PdfReportCellModel>, IEnumerable, ITableBuilder
    {
        private PdfTableModel table;

        public TableBuilder()
        {
            table = new PdfTableModel();
        }

        public TableBuilder WithOuterMargins(int margins, string marginDirection = null)
        {
            table.OuterMargins = margins;
            table.OuterMarginsDirection = marginDirection;
            return this;
        }

        public TableBuilder WithInnerMargins(int margins, string marginDirection = null)
        {
            table.InnerMargins = margins;
            table.InnerMarginsDirection = marginDirection;
            return this;
        }

        public TableBuilder WithPageBreak()
        {
            table.NewPageAfterTable = true;
            return this;
        }

        public TableBuilder WithRowNumbers(
            double fontSize = 11,
            string color = "#000000",
            string fontFamily = "Helvetica",
            string textAlign = "center",
            string fontWeight = "normal",
            string backgroundColor = "#ffffff",
            double margins = 0,
            string innerMarginsDirection = null,
            double width = 0,
            string borderColor = "#cccccc",
            double borderWidth = 0,
            string borderDirection = "top",
            string fontStyle = "normal",
            string fontDecoration = "none",
            string verticalAlignment = "center",
            int colSpan = 1,
            int rowSpan = 1)
        {
            table.ShouldInsertRowNumbers = true;

            if (table.RowNumberFormat == null)
            {
                table.RowNumberFormat = new PdfReportCellModel();
            }

            table.RowNumberFormat.FontFamily = fontFamily;
            table.RowNumberFormat.FontSize = fontSize;
            table.RowNumberFormat.FontWeight = fontWeight;
            table.RowNumberFormat.Width = width;
            table.RowNumberFormat.Color = color;
            table.RowNumberFormat.TextAlign = textAlign;
            table.RowNumberFormat.ColSpan = colSpan;
            table.RowNumberFormat.RowSpan = rowSpan;
            table.RowNumberFormat.BackgroundColor = backgroundColor;
            table.RowNumberFormat.InnerMargins = margins;
            table.RowNumberFormat.InnerMarginsDirection = innerMarginsDirection;
            table.RowNumberFormat.BorderColor = borderColor;
            table.RowNumberFormat.BorderWidth = borderWidth;
            table.RowNumberFormat.BorderDirection = borderDirection;
            table.RowNumberFormat.VerticalAlignment = verticalAlignment;
            table.RowNumberFormat.FontStyle = fontStyle;
            table.RowNumberFormat.FontDecoration = fontDecoration;

            return this;
        }

        public TableBuilder AddHeaderData(IEnumerable<PdfReportCellModel> headerContent)
        {
            if (table.Header == null)
            {
                table.Header = new List<PdfReportCellModel>();
            }

            table.Header.AddRange(headerContent);

            return this;
        }

        public TableBuilder AddHeaderData(
            string[] headerContent,
            double fontSize = 11,
            string color = "#000000",
            string fontFamily = "Helvetica",
            string textAlign = "left",
            string fontWeight = "normal",
            string backgroundColor = "#ffffff",
            double margins = 0,
            string innerMarginsDirection = null,
            double width = 0,
            string borderColor = "#cccccc",
            double borderWidth = 0,
            string borderDirection = "top",
            string fontStyle = "normal",
            string fontDecoration = "none",
            string verticalAlignment = "center",
            int colSpan = 1,
            int rowSpan = 1)
        {
            return AddHeaderData(headerContent.Select(x => new PdfReportCellModel
            {
                Value = x,
                FontFamily = fontFamily,
                FontSize = fontSize,
                FontWeight = fontWeight,
                Width = width,
                TextAlign = textAlign,
                ColSpan = colSpan,
                RowSpan = rowSpan,
                Color = color,
                BackgroundColor = backgroundColor,
                InnerMargins = margins,
                InnerMarginsDirection = innerMarginsDirection,
                BorderColor = borderColor,
                BorderWidth = borderWidth,
                BorderDirection = borderDirection,
                FontStyle = fontStyle,
                FontDecoration = fontDecoration,
                VerticalAlignment = verticalAlignment
            }));
        }

        public TableBuilder AddFooterData(IEnumerable<PdfReportCellModel> footerContent)
        {
            if (table.Footer == null)
            {
                table.Footer = new List<PdfReportCellModel>();
            }

            table.Footer.AddRange(footerContent);

            return this;
        }

        public TableBuilder AddFooterData(
            string[] footerContent,
            double fontSize = 11,
            string color = "#000000",
            string fontFamily = "Helvetica",
            string textAlign = "left",
            string fontWeight = "normal",
            string backgroundColor = "#ffffff",
            double margins = 0,
            string innerMarginsDirection = null,
            double width = 0,
            string borderColor = "#cccccc",
            double borderWidth = 0,
            string borderDirection = "top",
            string fontStyle = "normal",
            string fontDecoration = "none",
            string verticalAlignment = "center",
            int colSpan = 1,
            int rowSpan = 1)
        {
            return AddFooterData(footerContent.Select(x => new PdfReportCellModel
            {
                Value = x,
                FontFamily = fontFamily,
                FontSize = fontSize,
                FontWeight = fontWeight,
                Width = width,
                TextAlign = textAlign,
                ColSpan = colSpan,
                RowSpan = rowSpan,
                Color = color,
                BackgroundColor = backgroundColor,
                InnerMargins = margins,
                InnerMarginsDirection = innerMarginsDirection,
                BorderColor = borderColor,
                BorderWidth = borderWidth,
                BorderDirection = borderDirection,
                FontStyle = fontStyle,
                FontDecoration = fontDecoration,
                VerticalAlignment = verticalAlignment
            }));
        }

        public TableBuilder AddRowData(IEnumerable<PdfReportCellModel> rowContent)
        {
            if (table.Body == null)
            {
                table.Body = new List<List<PdfReportCellModel>>();
            }

            table.Body.Add(new List<PdfReportCellModel>(rowContent));

            return this;
        }

        public TableBuilder AddRowData(IChartBuilder chartBuilder, int colSpan = 1, string textAlign = "center")
        {
            var cell = chartBuilder.BuildTableCell();
            cell.TextAlign = textAlign;
            cell.ColSpan = colSpan;

            return AddRowData(new List<PdfReportCellModel> { cell });
        }

        public TableBuilder AddRowData(
            string[] rowContent,
            double fontSize = 11,
            string color = "#000000",
            string fontFamily = "Helvetica",
            string textAlign = "left",
            string fontWeight = "normal",
            string backgroundColor = "#ffffff",
            double margins = 0,
            string innerMarginsDirection = null,
            double width = 0,
            string borderColor = "#cccccc",
            double borderWidth = 0,
            string borderDirection = "top",
            string fontStyle = "normal",
            string fontDecoration = "none",
            string verticalAlignment = "center",
            int colSpan = 1,
            int rowSpan = 1)
        {
            return AddRowData(rowContent.Select(x => new PdfReportCellModel
            {
                Value = x,
                FontFamily = fontFamily,
                FontSize = fontSize,
                FontWeight = fontWeight,
                Width = width,
                TextAlign = textAlign,
                ColSpan = colSpan,
                RowSpan = rowSpan,
                Color = color,
                BackgroundColor = backgroundColor,
                InnerMargins = margins,
                InnerMarginsDirection = innerMarginsDirection,
                BorderColor = borderColor,
                BorderWidth = borderWidth,
                BorderDirection = borderDirection,
                FontStyle = fontStyle,
                FontDecoration = fontDecoration,
                VerticalAlignment = verticalAlignment
            }));
        }

        public PdfTableModel Build(bool hasAlternatingRowBackgroundColor = false, string alternatingRowBackgroundColor = "#efefef")
        {
            if (hasAlternatingRowBackgroundColor)
            {
                if (table.Body == null)
                {
                    return table;
                }

                for (int i = 0; i < table.Body.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        continue;
                    }

                    var row = table.Body[i];

                    for (int j = 0; j < row.Count; j++)
                    {
                        var cell = row[j];

                        cell.BackgroundColor = alternatingRowBackgroundColor;
                    }
                }
            }

            var maxCols = table.ToMaxColumnCount();

            if (UsesDefaultHeaderStyle && table.Header != null && table.Header.Count == 1)
            {
                table.Header[0].ColSpan = maxCols;
            }

            if (UsesDefaultFooterStyle && table.Footer != null && table.Footer.Count == 1)
            {
                table.Footer[0].ColSpan = maxCols;
            }

            if (table.Body != null && table.Body.Count > 0)
            {
                foreach (var row in table.Body)
                {
                    foreach (var cell in row)
                    {
                        if (cell.ControlId != "spacer")
                        {
                            continue;
                        }

                        cell.ColSpan = maxCols;
                    }
                }
            }

            return table;
        }

        public IEnumerator<PdfReportCellModel> GetEnumerator() => AllCells.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public TableBuilder AddRowSpacer(int height = 1)
        {
            for (int i = 0; i < height; i++)
            {
                AddRowData(new List<PdfReportCellModel>
                {
                    new PdfReportCellModel
                    {
                        Value = " ",
                        ControlId = "spacer"
                    }
                });
            }

            return this;
        }

        public TableBuilder AddDefaultHeaderData(string content)
        {
            UsesDefaultHeaderStyle = true;

            table.Header = new List<PdfReportCellModel>
            {
                new PdfReportCellModel
                {
                    Value = content,
                    BorderColor = "#000000",
                    BorderWidth = 3,
                    FontWeight = "bold",
                    BorderDirection = "bottom"
                }
            };

            AddRowSpacer();

            return this;
        }

        public TableBuilder AddDefaultFooterData(string content)
        {
            UsesDefaultFooterStyle = true;

            AddRowSpacer();

            table.Footer = new List<PdfReportCellModel>
            {
                new PdfReportCellModel
                {
                    Value = content,
                    BorderColor = "#000000",
                    BorderWidth = 1,
                    BorderDirection = "top",
                    TextAlign = "right"
                }
            };

            return this;
        }

        public void Clear()
        {
            table = new PdfTableModel();
        }

        public TableBuilder SetWidth(double tableWidth)
        {
            table.Width = tableWidth;

            return this;
        }

        public TableBuilder SetAlignment(string alignment)
        {
            table.Alignment = alignment;

            return this;
        }

        private IEnumerable<PdfReportCellModel> AllCells
        {
            get
            {
                var allCells = new List<PdfReportCellModel>();

                if (table.Header != null)
                {
                    allCells.AddRange(table.Header);
                }

                if (table.Body != null)
                {
                    foreach (var row in table.Body)
                    {
                        allCells.AddRange(row);
                    }
                }

                if (table.Footer != null)
                {
                    allCells.AddRange(table.Footer);
                }

                return allCells.AsEnumerable();
            }
        }

        private bool UsesDefaultHeaderStyle { get; set; }

        private bool UsesDefaultFooterStyle { get; set; }
    }
}

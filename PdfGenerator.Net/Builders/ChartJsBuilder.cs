using System.Net;
using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    public class ChartJsBuilder : IChartBuilder
    {
        private ChartJsModel chartJsModel;

        public int? Height { get; set; }

        public int? Width { get; set; }

        public ChartJsBuilder()
        {
            this.chartJsModel = new ChartJsModel();
        }

        public IChartBuilder AddLabels(string label)
        {
            return AddLabels(new string[] { label });
        }

        public IChartBuilder AddLabels(params string[] labels)
        {
            foreach (var label in labels)
            {
                chartJsModel.Data.Labels.Add(label);
            }

            return this;
        }

        public IChartBuilder AddData(params int[] data)
        {
            var dataSet = new ChartJsDatasetModel();

            foreach (var d in data)
            {
                dataSet.Data.Add(d);

                var color = ChartJsColor.NextColor();

                dataSet.BackgroundColor.Add(color);
            }

            chartJsModel.Data.Datasets.Add(dataSet);

            return this;
        }

        public IChartBuilder AddData(int[] data, string[] backgroundColor = null, string[] borderColor = null, string[] labels = null)
        {
            var dataSet = new ChartJsDatasetModel();

            for (int i = 0; i < data.Length; i++)
            {
                var d = data[i];

                dataSet.Data.Add(d);

                if (backgroundColor != null)
                {
                    var c = backgroundColor[i];
                    dataSet.BackgroundColor.Add(c);
                }

                if (borderColor != null)
                {
                    var b = borderColor[i];
                    dataSet.BorderColor.Add(b);
                }

                if (labels != null)
                {
                    var l = labels[i];
                    dataSet.Label.Add(l);
                }
            }

            chartJsModel.Data.Datasets.Add(dataSet);

            return this;
        }

        public void Clear()
        {
            chartJsModel = new ChartJsModel();
        }

        public string Build()
        {
            var jsonQuery = chartJsModel.ToJson();
            var query = WebUtility.UrlEncode(jsonQuery);
            var chartUrl = $"https://quickchart.io/chart?c={query}";

            if (Height.HasValue)
            {
                chartUrl = chartUrl + "&height=" + Height.Value;
            }

            if (Width.HasValue)
            {
                chartUrl = chartUrl + "&width=" + Width.Value;
            }

            return chartUrl;
        }

        public PdfReportCellModel BuildTableCell()
        {
            return new PdfReportCellModel
            {
                ImageHref = Build(),
                Height = Height,
                Width = Width
            };
        }

        public IChartBuilder SetHeight(int height = 300)
        {
            Height = height;
            return this;
        }

        public IChartBuilder SetWidth(int width = 500)
        {
            Width = width;
            return this;
        }

        public IChartBuilder AddPlugin(ChartJsPluginModel plugin)
        {
            chartJsModel.Options = new ChartJsOptionsModel
            {
                Plugins = plugin
            };

            return this;
        }

        public IChartBuilder SetType(string type = "outlabeledPie")
        {
            chartJsModel.Type = type;

            return this;
        }
    }
}

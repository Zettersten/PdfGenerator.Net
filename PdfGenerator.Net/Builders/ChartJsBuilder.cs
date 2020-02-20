using System.Linq;
using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    public class ChartJsBuilder : IChartBuilder
    {
        private ChartJsPieModel chartJsPieModel;

        public ChartJsBuilder()
        {
            this.chartJsPieModel = new ChartJsPieModel();
        }

        public IChartBuilder AddLabels(string label)
        {
            return AddLabels(new string[] { label });
        }

        public IChartBuilder AddLabels(params string[] labels)
        {
            foreach (var label in labels)
            {
                chartJsPieModel.Data.Labels.Add(label);
            }

            return this;
        }

        public IChartBuilder AddData(params int[] data)
        {
            var dataSet = new ChartJsDatasetModel();

            foreach (var d in data)
            {
                dataSet.Data.Add(d);
            }

            chartJsPieModel.Data.Datasets.Add(dataSet);

            return this;
        }

        public void Clear()
        {
            chartJsPieModel = new ChartJsPieModel();
        }

        public string Build()
        {
            var template = "https://quickchart.io/chart?c={type:'<<Type>>',data:{labels:[<<Labels>>], datasets:[{data:[<<Datasets>>]}]}}";
            var labels = string.Join(",", chartJsPieModel.Data.Labels.Select(x => $"'{x}'"));
            var dataSet = string.Join(",", chartJsPieModel.Data.Datasets.SelectMany(x => x.Data));

            var chartUrl = template
                .Replace($"<<{nameof(chartJsPieModel.Type)}>>", chartJsPieModel.Type)
                .Replace($"<<{nameof(chartJsPieModel.Data.Labels)}>>", labels)
                .Replace($"<<{nameof(chartJsPieModel.Data.Datasets)}>>", dataSet)
                .ToString();

            if (chartJsPieModel.Height.HasValue)
            {
                chartUrl = chartUrl + "&height=" + chartJsPieModel.Height.Value;
            }

            if (chartJsPieModel.Width.HasValue)
            {
                chartUrl = chartUrl + "&width=" + chartJsPieModel.Width.Value;
            }

            return chartUrl;
        }

        public PdfReportCellModel BuildTableCell()
        {
            return new PdfReportCellModel
            {
                ImageHref = Build(),
                Height = chartJsPieModel.Height,
                Width = chartJsPieModel.Width
            };
        }

        public IChartBuilder SetHeight(int height = 300)
        {
            chartJsPieModel.Height = height;
            return this;
        }

        public IChartBuilder SetWidth(int width = 500)
        {
            chartJsPieModel.Width = width;
            return this;
        }
    }
}

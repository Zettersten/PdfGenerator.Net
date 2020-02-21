using PdfGenerator.Net.Models;

namespace PdfGenerator.Net.Builders
{
    public interface IChartBuilder
    {
        IChartBuilder AddLabels(string label);

        IChartBuilder AddLabels(params string[] labels);

        IChartBuilder AddData(params int[] data);

        IChartBuilder SetType(string type = "outlabeledPie");

        IChartBuilder AddPlugin(ChartJsPluginModel plugin);

        IChartBuilder AddData(int[] data, string[] backgroundColor = null, string[] borderColor = null, string[] labels = null);

        IChartBuilder SetHeight(int height = 300);

        IChartBuilder SetWidth(int width = 500);

        void Clear();

        string Build();

        PdfReportCellModel BuildTableCell();
    }
}

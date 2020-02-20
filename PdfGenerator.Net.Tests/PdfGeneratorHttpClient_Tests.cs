using System;
using System.IO;
using PdfGenerator.Net.Extensions;
using Xunit;

namespace PdfGenerator.Net.Tests
{
    public partial class PdfGeneratorHttpClient_Tests
    {
        public string ProjectDirectory
        {
            get
            {
                var workingDirectory = Environment.CurrentDirectory;
                var projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

                return projectDirectory;
            }
        }

        [Fact]
        public void Should_create_instance_with_options()
        {
            Assert.NotNull(PdfGenerator);
        }

        [Fact]
        public void Should_generate_basic_table_pdf_and_return_url()
        {
            var pdfGenerator = PdfGenerator;

            var response = pdfGenerator
                .GeneratePdf(
                    BasicTable_Sample
                )
                .GetAwaiter().GetResult();

            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
        }

        [Fact]
        public void Should_generate_basic_statment_pdf_and_return_url()
        {
            var pdfGenerator = PdfGenerator;

            var response = pdfGenerator
                .GeneratePdf(
                    BasicStatment_Sample
                )
                .GetAwaiter().GetResult();

            Assert.NotNull(response);
            Assert.True(response.IsSuccess);
        }

        [Fact]
        public void Should_generate_basic_table_svgs_and_return_urls()
        {
            var pdfGenerator = PdfGenerator;

            var response = pdfGenerator
                .GenerateSvgs(
                    BasicTable_Sample
                )
                .GetAwaiter().GetResult();

            Assert.NotNull(response);
            Assert.True(response.Count > 0);
        }

        [Fact]
        public void Should_generate_basic_statement_svgs_and_return_urls()
        {
            var pdfGenerator = PdfGenerator;

            var response = pdfGenerator
                .GenerateSvgs(
                    BasicStatment_Sample
                )
                .GetAwaiter().GetResult();

            Assert.NotNull(response);
            Assert.True(response.Count > 0);
        }

        [Fact]
        public void Should_generate_basic_statement_preview()
        {
            var requestBuilder = RequestBuilder;
            var fileName = Path.Combine(ProjectDirectory, BasicStatment_Sample.ToFileName());

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            requestBuilder
                .AddPdfData(BasicStatment_Sample)
                .PreviewAsync(fileName)
                .GetAwaiter()
                .GetResult();

            Assert.True(File.Exists(fileName));
        }

        [Fact]
        public void Should_generate_basictable_preview()
        {
            var requestBuilder = RequestBuilder;
            var fileName = Path.Combine(ProjectDirectory, BasicTable_Sample.ToFileName());

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            requestBuilder
                .AddPdfData(BasicTable_Sample)
                .PreviewAsync(fileName)
                .GetAwaiter()
                .GetResult();

            Assert.True(File.Exists(fileName));
        }

        [Fact]
        public void Should_generate_basic_json_from_reportBuilder()
        {
            var jsonString = BasicTable_Sample.ToJson();

            File.WriteAllText(Path.Combine(ProjectDirectory, "basic_table.json"), jsonString);
        }

        [Fact]
        public void Should_generate_statement_json_from_reportBuilder()
        {
            var jsonString = BasicStatment_Sample.ToJson();

            File.WriteAllText(Path.Combine(ProjectDirectory, "basic_statement.json"), jsonString);
        }

        [Fact]
        public void Should_build_simple_chartjs_image_url()
        {
            var chartImage = ChartJsBuilder
                .AddLabels("January", "February", "March", "April", "May")
                .AddData(50, 60, 70, 180, 190)
                .SetWidth(100)
                .Build();

            Assert.NotNull(chartImage);
        }
    }
}

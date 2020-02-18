using Xunit;

namespace PdfGenerator.Net.Tests
{
    public partial class PdfGeneratorHttpClient_Tests
    {
        [Fact]
        public void Should_create_instance_with_options()
        {
            Assert.NotNull(PdfGenerator);
        }

        [Fact]
        public void Should_generate_pdf_and_return_url()
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
        public void Should_generate_svg_and_return_urls()
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
    }
}
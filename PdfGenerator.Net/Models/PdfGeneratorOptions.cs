using System.Text;

namespace PdfGenerator.Net.Models
{
    public class PdfGeneratorOptions
    {
        public string AccessToken { get; set; }

        public string ApplicationId { get; set; }

        public string Domain { get; set; } = "https://pdf.emoney.com/";

        public static PdfGeneratorOptions Create(string accessToken, string applicationId, string domain)
        {
            return new PdfGeneratorOptions
            {
                AccessToken = accessToken,
                ApplicationId = applicationId,
                Domain = domain
            };
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfGeneratorOptions {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}

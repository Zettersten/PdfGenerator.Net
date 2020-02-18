using PdfGenerator.Net.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace PdfGenerator.Net.Services
{
    public class PdfGeneratorAuthenticator : IAuthenticator
    {
        public PdfGeneratorAuthenticator(PdfGeneratorOptions PdfGeneratorOptions)
        {
            this.Options = PdfGeneratorOptions;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            if (!string.IsNullOrEmpty(Options.AccessToken))
            {
                request.AddHeader("Authorization", $"Bearer {Options.AccessToken}");
            }

            if (!string.IsNullOrEmpty(Options.ApplicationId))
            {
                request.AddHeader("X-Application-Id", Options.ApplicationId);
            }
        }

        public PdfGeneratorOptions Options { get; }
    }
}

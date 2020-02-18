using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PdfGenerator.Net.Services
{
    public static class PdfGeneratorContentSerialization
    {
        public static JsonSerializerSettings SerializerSettings
        {
            get
            {
                var defaultSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    DefaultValueHandling = DefaultValueHandling.Include,
                    TypeNameHandling = TypeNameHandling.None,
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.None,
                    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
                };

                defaultSettings.Converters.Add(new MicrosecondEpochConverter());

                return defaultSettings;
            }
        }
    }
}

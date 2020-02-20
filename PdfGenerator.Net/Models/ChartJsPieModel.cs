using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using PdfGenerator.Net.Services;

namespace PdfGenerator.Net.Models
{
    /// <summary>
    /// ChartJsPieModel
    /// </summary>
    [DataContract]
    public class ChartJsPieModel
    {
        public ChartJsPieModel()
        {
            Type = "pie";
            Data = new ChartJsDataModel();
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public ChartJsDataModel Data { get; private set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartJsPieModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, PdfGeneratorContentSerialization.SerializerSettings);
        }
    }

    /// <summary>
    /// ChartJsDataModel
    /// </summary>
    [DataContract]
    public class ChartJsDataModel
    {
        public ChartJsDataModel()
        {
            Labels = new List<string>();
            Datasets = new List<ChartJsDatasetModel>();
        }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "labels")]
        public List<string> Labels { get; private set; }

        /// <summary>
        /// Gets or Sets Datasets
        /// </summary>
        [DataMember(Name = "datasets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "datasets")]
        public List<ChartJsDatasetModel> Datasets { get; private set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartJsDataModel {\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Datasets: ").Append(Datasets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, PdfGeneratorContentSerialization.SerializerSettings);
        }
    }

    /// <summary>
    /// ChartJsDatasetModel
    /// </summary>
    [DataContract]
    public class ChartJsDatasetModel
    {
        public ChartJsDatasetModel()
        {
            Data = new List<int>();
        }

        /// <summary>
        /// Gets or Sets Datasets
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public List<int> Data { get; private set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartJsDataModel {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, PdfGeneratorContentSerialization.SerializerSettings);
        }
    }
}

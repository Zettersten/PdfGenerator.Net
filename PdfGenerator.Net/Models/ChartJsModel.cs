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
    public class ChartJsModel
    {
        public ChartJsModel()
        {
            Data = new ChartJsDataModel();
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; } = "pie";

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public ChartJsDataModel Data { get; private set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "options")]
        public ChartJsOptionsModel Options { get; set; }

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
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None, PdfGeneratorContentSerialization.SerializerSettings);
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
            return JsonConvert.SerializeObject(this, Formatting.None, PdfGeneratorContentSerialization.SerializerSettings);
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
            Label = new List<string>();
            BackgroundColor = new List<string>();
            BorderColor = new List<string>();
        }

        /// <summary>
        /// Gets or Sets Datasets
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public List<int> Data { get; private set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "label")]
        public List<string> Label { get; private set; }

        /// <summary>
        /// Gets or Sets BackgroundColor
        /// </summary>
        [DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "backgroundColor")]
        public List<string> BackgroundColor { get; private set; }

        /// <summary>
        /// Gets or Sets BorderColor
        /// </summary>
        [DataMember(Name = "borderColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderColor")]
        public List<string> BorderColor { get; private set; }

        /// <summary>
        /// Gets or Sets BorderWidth
        /// </summary>
        [DataMember(Name = "borderWidth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderWidth")]
        public int? BorderWidth { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartJsDataModel {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
            sb.Append("  BorderWidth: ").Append(BorderWidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None, PdfGeneratorContentSerialization.SerializerSettings);
        }
    }

    [DataContract]
    public class ChartJsOptionsModel
    {
        /// <summary>
        /// Gets or Sets Plugins
        /// </summary>
        [DataMember(Name = "plugins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "plugins")]
        public ChartJsPluginModel Plugins { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartJsOptionsModel {\n");
            sb.Append("  Plugins: ").Append(Plugins).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None, PdfGeneratorContentSerialization.SerializerSettings);
        }
    }

    [DataContract]
    public class ChartJsPluginModel
    {
        /// <summary>
        /// Gets or Sets Legend
        /// </summary>
        [DataMember(Name = "legend", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "legend")]
        public bool Legend { get; set; } = false;

        /// <summary>
        /// Gets or Sets Outlabels
        /// </summary>
        [DataMember(Name = "outlabels", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outlabels")]
        public ChartJsOutlabelModel Outlabels { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartJsPluginModel {\n");
            sb.Append("  Legend: ").Append(Legend).Append("\n");
            sb.Append("  Outlabels: ").Append(Outlabels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None, PdfGeneratorContentSerialization.SerializerSettings);
        }
    }

    [DataContract]
    public class ChartJsOutlabelModel
    {
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; } = "%l %p";

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; } = "white";

        /// <summary>
        /// Gets or Sets Stretch
        /// </summary>
        [DataMember(Name = "stretch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stretch")]
        public int Stretch { get; set; } = 18;

        /// <summary>
        /// Gets or Sets Font
        /// </summary>
        [DataMember(Name = "font", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "font")]
        public ChartJsFontModel Font { get; set; } = new ChartJsFontModel();

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartJsOutlabelModel {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Stretch: ").Append(Stretch).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None, PdfGeneratorContentSerialization.SerializerSettings);
        }
    }

    [DataContract]
    public class ChartJsFontModel
    {
        /// <summary>
        /// Gets or Sets Resizable
        /// </summary>
        [DataMember(Name = "resizable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resizable")]
        public bool Resizable { get; set; } = true;

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "minSize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minSize")]
        public int MinSize { get; set; } = 6;

        /// <summary>
        /// Gets or Sets MaxSize
        /// </summary>
        [DataMember(Name = "maxSize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maxSize")]
        public int MaxSize { get; set; } = 9;

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartJsFontModel {\n");
            sb.Append("  Resizable: ").Append(Resizable).Append("\n");
            sb.Append("  MinSize: ").Append(MinSize).Append("\n");
            sb.Append("  MaxSize: ").Append(MaxSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None, PdfGeneratorContentSerialization.SerializerSettings);
        }
    }

    public static class ChartJsColor
    {
        public const string OneColor = "#4B1EB3";
        public const string TwoColor = "#FF8C19";
        public const string ThreeColor = "#4B00FF";
        public const string FourColor = "#14CC2B";
        public const string FiveColor = "#09B31E";
        public const string SixColor = "#148CCC";
        public const string SevenColor = "#0977B3";
        public const string EightColor = "#B3121D";
        public const string NineColor = "#66050C";
        public const string TenColor = "#12B339";
        public const string ElevenColor = "#FF3341";
        public const string TwelveColor = "#FF5F01";
        public const string ThirteenColor = "#036665";
        public const string FourteenColor = "#12B3B2";
        public const string FifteenColor = "#66074B";
        public const string SixteenColor = "#B38B6D";

        private static readonly Queue<string> ColorQueue = new Queue<string>(new string[] { OneColor, TwoColor, ThreeColor, FourColor, FiveColor, SixColor, SevenColor, EightColor, NineColor, TenColor, ElevenColor, TwelveColor, ThirteenColor, FourteenColor, FifteenColor, SixteenColor });

        public static string NextColor()
        {
            var nextColor = ColorQueue.Dequeue();

            ColorQueue.Enqueue(nextColor);

            return nextColor;
        }
    }
}

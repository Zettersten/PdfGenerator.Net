using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace PdfGenerator.Net.Models
{
    /// <summary>
    /// PDF Report
    /// </summary>
    [DataContract]
    public class PdfReportModel
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets MinRowHeight
        /// </summary>
        [DataMember(Name = "minRowHeight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minRowHeight")]
        public double? MinRowHeight { get; set; }

        /// <summary>
        /// Gets or Sets BorderWidth
        /// </summary>
        [DataMember(Name = "borderWidth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderWidth")]
        public double? BorderWidth { get; set; }

        /// <summary>
        /// Gets or Sets BorderDirection
        /// </summary>
        [DataMember(Name = "borderDirection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderDirection")]
        public string BorderDirection { get; set; }

        /// <summary>
        /// Gets or Sets BorderColor
        /// </summary>
        [DataMember(Name = "borderColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; }

        /// <summary>
        /// Gets or Sets PageHeader
        /// </summary>
        [DataMember(Name = "pageHeader", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pageHeader")]
        public PdfReportCellModel PageHeader { get; set; }

        /// <summary>
        /// Gets or Sets PageFooter
        /// </summary>
        [DataMember(Name = "pageFooter", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pageFooter")]
        public PdfReportCellModel PageFooter { get; set; }

        /// <summary>
        /// Gets or Sets ShouldGeneratePageNumbers
        /// </summary>
        [DataMember(Name = "shouldGeneratePageNumbers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shouldGeneratePageNumbers")]
        public bool? ShouldGeneratePageNumbers { get; set; }

        /// <summary>
        /// Gets or Sets PageNumberTemplate
        /// </summary>
        [DataMember(Name = "pageNumberTemplate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pageNumberTemplate")]
        public string PageNumberTemplate { get; set; }

        /// <summary>
        /// Gets or Sets HasBorder
        /// </summary>
        [DataMember(Name = "hasBorder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasBorder")]
        public bool? HasBorder { get; set; }

        /// <summary>
        /// Gets or Sets Tables
        /// </summary>
        [DataMember(Name = "tables", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tables")]
        public List<PdfTableModel> Tables { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfReportModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  MinRowHeight: ").Append(MinRowHeight).Append("\n");
            sb.Append("  BorderWidth: ").Append(BorderWidth).Append("\n");
            sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
            sb.Append("  PageHeader: ").Append(PageHeader).Append("\n");
            sb.Append("  PageFooter: ").Append(PageFooter).Append("\n");
            sb.Append("  ShouldGeneratePageNumbers: ").Append(ShouldGeneratePageNumbers).Append("\n");
            sb.Append("  PageNumberTemplate: ").Append(PageNumberTemplate).Append("\n");
            sb.Append("  HasBorder: ").Append(HasBorder).Append("\n");
            sb.Append("  Tables: ").Append(Tables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}

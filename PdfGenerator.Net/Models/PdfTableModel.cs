using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using PdfGenerator.Net.Services;

namespace PdfGenerator.Net.Models
{
    /// <summary>
    /// PDF Table
    /// </summary>
    [DataContract]
    public class PdfTableModel
    {
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name = "tableNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tableNumber")]
        public int? TableNumber { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "width")]
        public double? Width { get; set; }

        /// <summary>
        /// Gets or Sets Alignment
        /// </summary>
        [DataMember(Name = "alignment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "alignment")]
        public string Alignment { get; set; }

        /// <summary>
        /// Gets or Sets InnerMargins
        /// </summary>
        [DataMember(Name = "innerMargins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "innerMargins")]
        public int? InnerMargins { get; set; }

        /// <summary>
        /// Gets or Sets InnerMarginsDirection
        /// </summary>
        [DataMember(Name = "innerMarginsDirection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "innerMarginsDirection")]
        public string InnerMarginsDirection { get; set; }

        /// <summary>
        /// Gets or Sets OuterMargins
        /// </summary>
        [DataMember(Name = "outerMargins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outerMargins")]
        public int? OuterMargins { get; set; }

        /// <summary>
        /// Gets or Sets OuterMarginsDirection
        /// </summary>
        [DataMember(Name = "outerMarginsDirection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outerMarginsDirection")]
        public string OuterMarginsDirection { get; set; }

        /// <summary>
        /// Gets or Sets NewPageAfterTable
        /// </summary>
        [DataMember(Name = "newPageAfterTable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "newPageAfterTable")]
        public bool? NewPageAfterTable { get; set; }

        /// <summary>
        /// Gets or Sets ShouldInsertRowNumbers
        /// </summary>
        [DataMember(Name = "shouldInsertRowNumbers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shouldInsertRowNumbers")]
        public bool? ShouldInsertRowNumbers { get; set; }

        /// <summary>
        /// Gets or Sets RowNumberFormat
        /// </summary>
        [DataMember(Name = "rowNumberFormat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rowNumberFormat")]
        public PdfReportCellModel RowNumberFormat { get; set; }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name = "header", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "header")]
        public List<PdfReportCellModel> Header { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "body")]
        public List<List<PdfReportCellModel>> Body { get; set; }

        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name = "footer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "footer")]
        public List<PdfReportCellModel> Footer { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfTableModel {\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  OuterMargins: ").Append(OuterMargins).Append("\n");
            sb.Append("  InnerMargins: ").Append(InnerMargins).Append("\n");
            sb.Append("  InnerMarginsDirection: ").Append(InnerMarginsDirection).Append("\n");
            sb.Append("  OuterMarginsDirection: ").Append(OuterMarginsDirection).Append("\n");
            sb.Append("  NewPageAfterTable: ").Append(NewPageAfterTable).Append("\n");
            sb.Append("  ShouldInsertRowNumbers: ").Append(ShouldInsertRowNumbers).Append("\n");
            sb.Append("  RowNumberFormat: ").Append(RowNumberFormat).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Alignment: ").Append(Alignment).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
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

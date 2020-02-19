using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace PdfGenerator.Net.Models
{
    /// <summary>
    /// PDF Cell
    /// </summary>
    [DataContract]
    public class PdfReportCellModel
    {
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name = "tableNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tableNumber")]
        public int? TableNumber { get; set; }

        /// <summary>
        /// Gets or Sets CellNumber
        /// </summary>
        [DataMember(Name = "cellNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cellNumber")]
        public int? CellNumber { get; set; }

        /// <summary>
        /// Gets or Sets ColSpan
        /// </summary>
        [DataMember(Name = "colSpan", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "colSpan")]
        public int? ColSpan { get; set; }

        /// <summary>
        /// Gets or Sets RowNumber
        /// </summary>
        [DataMember(Name = "rowNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rowNumber")]
        public int? RowNumber { get; set; }

        /// <summary>
        /// Gets or Sets ImageHref
        /// </summary>
        [DataMember(Name = "imageHref", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imageHref")]
        public string ImageHref { get; set; }

        /// <summary>
        /// Gets or Sets HasImage
        /// </summary>
        [DataMember(Name = "hasImage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasImage")]
        public bool? HasImage { get; set; }

        /// <summary>
        /// Gets or Sets BorderWidth
        /// </summary>
        [DataMember(Name = "borderWidth", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderWidth")]
        public double? BorderWidth { get; set; }

        /// <summary>
        /// Gets or Sets BorderColor
        /// </summary>
        [DataMember(Name = "borderColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; }

        /// <summary>
        /// Gets or Sets BorderDirection
        /// </summary>
        [DataMember(Name = "borderDirection", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "borderDirection")]
        public string BorderDirection { get; set; }

        /// <summary>
        /// Gets or Sets HasBorder
        /// </summary>
        [DataMember(Name = "hasBorder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasBorder")]
        public bool? HasBorder { get; set; }

        /// <summary>
        /// Gets or Sets InnerMargins
        /// </summary>
        [DataMember(Name = "innerMargins", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "innerMargins")]
        public double? InnerMargins { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundColor
        /// </summary>
        [DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets FontFamily
        /// </summary>
        [DataMember(Name = "fontFamily", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fontFamily")]
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or Sets FontWeight
        /// </summary>
        [DataMember(Name = "fontWeight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fontWeight")]
        public string FontWeight { get; set; }

        /// <summary>
        /// Gets or Sets FontSize
        /// </summary>
        [DataMember(Name = "fontSize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fontSize")]
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or Sets LineHeight
        /// </summary>
        [DataMember(Name = "lineHeight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineHeight")]
        public double? LineHeight { get; set; }

        /// <summary>
        /// Gets or Sets LetterSpacing
        /// </summary>
        [DataMember(Name = "letterSpacing", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "letterSpacing")]
        public double? LetterSpacing { get; set; }

        /// <summary>
        /// Gets or Sets TextAlign
        /// </summary>
        [DataMember(Name = "textAlign", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "textAlign")]
        public string TextAlign { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "width")]
        public double? Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "height")]
        public double? Height { get; set; }

        /// <summary>
        /// Gets or Sets PositionX
        /// </summary>
        [DataMember(Name = "positionX", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "positionX")]
        public double? PositionX { get; set; }

        /// <summary>
        /// Gets or Sets PositionY
        /// </summary>
        [DataMember(Name = "positionY", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "positionY")]
        public double? PositionY { get; set; }

        /// <summary>
        /// Gets or Sets ControlId
        /// </summary>
        [DataMember(Name = "controlId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "controlId")]
        public string ControlId { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets HasValue
        /// </summary>
        [DataMember(Name = "hasValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasValue")]
        public bool? HasValue { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfReportCellModel {\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            sb.Append("  CellNumber: ").Append(CellNumber).Append("\n");
            sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
            sb.Append("  ColSpan: ").Append(ColSpan).Append("\n");
            sb.Append("  ImageHref: ").Append(ImageHref).Append("\n");
            sb.Append("  HasImage: ").Append(HasImage).Append("\n");
            sb.Append("  BorderWidth: ").Append(BorderWidth).Append("\n");
            sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
            sb.Append("  BorderDirection: ").Append(BorderDirection).Append("\n");
            sb.Append("  HasBorder: ").Append(HasBorder).Append("\n");
            sb.Append("  InnerMargins: ").Append(InnerMargins).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
            sb.Append("  FontWeight: ").Append(FontWeight).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  LineHeight: ").Append(LineHeight).Append("\n");
            sb.Append("  LetterSpacing: ").Append(LetterSpacing).Append("\n");
            sb.Append("  TextAlign: ").Append(TextAlign).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  PositionX: ").Append(PositionX).Append("\n");
            sb.Append("  PositionY: ").Append(PositionY).Append("\n");
            sb.Append("  ControlId: ").Append(ControlId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  HasValue: ").Append(HasValue).Append("\n");
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

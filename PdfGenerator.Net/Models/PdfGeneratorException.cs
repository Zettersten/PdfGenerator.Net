using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PdfGenerator.Net.Models
{
    public class PdfGeneratorException : Exception
    {
        private readonly ErrorModel errorModel;

        public PdfGeneratorException()
        {
            errorModel = new ErrorModel();
        }

        public PdfGeneratorException(ErrorModel errorModel) : base(errorModel.Message)
        {
            this.errorModel = errorModel;
        }

        public PdfGeneratorException(string message) : base(message)
        {
            errorModel = new ErrorModel
            {
                Message = message,
                Code = "PdfGeneratorException",
                Created = DateTime.Now,
                IsSuccess = false
            };
        }

        public PdfGeneratorException(string message, Exception innerException) : base(message, innerException)
        {
            errorModel = new ErrorModel
            {
                Message = message,
                Code = "PdfGeneratorException",
                Created = DateTime.Now,
                IsSuccess = false,
                StackTrace = innerException.StackTrace
            };
        }

        public override IDictionary Data => new Dictionary<string, object>
        {
            { nameof(errorModel.Message), errorModel.Message },
            { nameof(errorModel.Code), errorModel.Code },
            { nameof(errorModel.Created), errorModel.Created },
            { nameof(errorModel.IsSuccess), errorModel.IsSuccess },
            { nameof(errorModel.StackTrace), errorModel.StackTrace }
        };

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfGeneratorException {\n");
            sb.Append("  Message: ").Append(errorModel.Message).Append("\n");
            sb.Append("  Code: ").Append(errorModel.Code).Append("\n");
            sb.Append("  Created: ").Append(errorModel.Created).Append("\n");
            sb.Append("  IsSuccess: ").Append(errorModel.IsSuccess).Append("\n");
            sb.Append("  StackTrace: ").Append(errorModel.StackTrace).Append("\n");
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
    };
}

/*
 * Insights.Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.DatasetResponse-1_Insights.Api.Models.Responses.Transparency.DatasetRows.ActualGenerationOutputPerGenerationUnitDatasetResponse")]
    public partial class InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse : IEquatable<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        public InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse(List<InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse> data = default(List<InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse>))
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesTransparencyDatasetRowsActualGenerationOutputPerGenerationUnitDatasetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

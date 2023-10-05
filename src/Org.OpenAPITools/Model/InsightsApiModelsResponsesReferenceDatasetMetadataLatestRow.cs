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
    /// InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Reference.DatasetMetadataLatestRow")]
    public partial class InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow : IEquatable<InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow" /> class.
        /// </summary>
        /// <param name="dataset">dataset.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        public InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow(string dataset = default(string), DateTime? lastUpdated = default(DateTime?))
        {
            this.Dataset = dataset;
            this.LastUpdated = lastUpdated;
        }

        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        [DataMember(Name = "dataset", EmitDefaultValue = true)]
        public string Dataset { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow {\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesReferenceDatasetMetadataLatestRow input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Dataset == input.Dataset ||
                    (this.Dataset != null &&
                    this.Dataset.Equals(input.Dataset))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
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
                if (this.Dataset != null)
                {
                    hashCode = (hashCode * 59) + this.Dataset.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
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

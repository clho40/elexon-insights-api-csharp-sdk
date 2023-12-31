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
    /// InsightsApiModelsMetadataApiResponseSourceMetadata
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Metadata.ApiResponseSourceMetadata")]
    public partial class InsightsApiModelsMetadataApiResponseSourceMetadata : IEquatable<InsightsApiModelsMetadataApiResponseSourceMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsMetadataApiResponseSourceMetadata" /> class.
        /// </summary>
        /// <param name="datasets">datasets.</param>
        public InsightsApiModelsMetadataApiResponseSourceMetadata(List<string> datasets = default(List<string>))
        {
            this.Datasets = datasets;
        }

        /// <summary>
        /// Gets or Sets Datasets
        /// </summary>
        /// <example>[&quot;DATASET&quot;]</example>
        [DataMember(Name = "datasets", EmitDefaultValue = true)]
        public List<string> Datasets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsMetadataApiResponseSourceMetadata {\n");
            sb.Append("  Datasets: ").Append(Datasets).Append("\n");
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
            return this.Equals(input as InsightsApiModelsMetadataApiResponseSourceMetadata);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsMetadataApiResponseSourceMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsMetadataApiResponseSourceMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsMetadataApiResponseSourceMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Datasets == input.Datasets ||
                    this.Datasets != null &&
                    input.Datasets != null &&
                    this.Datasets.SequenceEqual(input.Datasets)
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
                if (this.Datasets != null)
                {
                    hashCode = (hashCode * 59) + this.Datasets.GetHashCode();
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

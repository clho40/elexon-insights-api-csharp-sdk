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
    /// InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Generation.DatasetRows.WindGenerationForecast")]
    public partial class InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast : IEquatable<InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast" /> class.
        /// </summary>
        /// <param name="dataset">dataset.</param>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="generation">generation.</param>
        public InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast(string dataset = default(string), DateTime publishTime = default(DateTime), DateTime startTime = default(DateTime), long? generation = default(long?))
        {
            this.Dataset = dataset;
            this.PublishTime = publishTime;
            this.StartTime = startTime;
            this.Generation = generation;
        }

        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        [DataMember(Name = "dataset", EmitDefaultValue = true)]
        public string Dataset { get; set; }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        [DataMember(Name = "publishTime", EmitDefaultValue = false)]
        public DateTime PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets Generation
        /// </summary>
        [DataMember(Name = "generation", EmitDefaultValue = true)]
        public long? Generation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast {\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Generation: ").Append(Generation).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesGenerationDatasetRowsWindGenerationForecast input)
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
                    this.PublishTime == input.PublishTime ||
                    (this.PublishTime != null &&
                    this.PublishTime.Equals(input.PublishTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Generation == input.Generation ||
                    (this.Generation != null &&
                    this.Generation.Equals(input.Generation))
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
                if (this.PublishTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishTime.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.Generation != null)
                {
                    hashCode = (hashCode * 59) + this.Generation.GetHashCode();
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
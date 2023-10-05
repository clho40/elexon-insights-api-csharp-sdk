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
    /// InsightsApiModelsResponsesGenerationWindGenerationForecast
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Generation.WindGenerationForecast")]
    public partial class InsightsApiModelsResponsesGenerationWindGenerationForecast : IEquatable<InsightsApiModelsResponsesGenerationWindGenerationForecast>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesGenerationWindGenerationForecast" /> class.
        /// </summary>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="settlementDate">settlementDate.</param>
        /// <param name="settlementPeriod">settlementPeriod.</param>
        /// <param name="generation">generation.</param>
        public InsightsApiModelsResponsesGenerationWindGenerationForecast(DateTime publishTime = default(DateTime), DateTime startTime = default(DateTime), DateTime settlementDate = default(DateTime), int settlementPeriod = default(int), long? generation = default(long?))
        {
            this.PublishTime = publishTime;
            this.StartTime = startTime;
            this.SettlementDate = settlementDate;
            this.SettlementPeriod = settlementPeriod;
            this.Generation = generation;
        }

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
        /// Gets or Sets SettlementDate
        /// </summary>
        [DataMember(Name = "settlementDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime SettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets SettlementPeriod
        /// </summary>
        [DataMember(Name = "settlementPeriod", EmitDefaultValue = false)]
        public int SettlementPeriod { get; set; }

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
            sb.Append("class InsightsApiModelsResponsesGenerationWindGenerationForecast {\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  SettlementPeriod: ").Append(SettlementPeriod).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesGenerationWindGenerationForecast);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesGenerationWindGenerationForecast instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesGenerationWindGenerationForecast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesGenerationWindGenerationForecast input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.SettlementPeriod == input.SettlementPeriod ||
                    this.SettlementPeriod.Equals(input.SettlementPeriod)
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
                if (this.PublishTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishTime.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.SettlementDate != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SettlementPeriod.GetHashCode();
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

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
    /// InsightsApiModelsResponsesIndicatedForecastIndicatedForecast
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.IndicatedForecast.IndicatedForecast")]
    public partial class InsightsApiModelsResponsesIndicatedForecastIndicatedForecast : IEquatable<InsightsApiModelsResponsesIndicatedForecastIndicatedForecast>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesIndicatedForecastIndicatedForecast" /> class.
        /// </summary>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="settlementDate">settlementDate.</param>
        /// <param name="settlementPeriod">settlementPeriod.</param>
        /// <param name="boundary">boundary.</param>
        /// <param name="indicatedGeneration">indicatedGeneration.</param>
        /// <param name="indicatedDemand">indicatedDemand.</param>
        /// <param name="indicatedMargin">indicatedMargin.</param>
        /// <param name="indicatedImbalance">indicatedImbalance.</param>
        public InsightsApiModelsResponsesIndicatedForecastIndicatedForecast(DateTime? publishTime = default(DateTime?), DateTime startTime = default(DateTime), DateTime settlementDate = default(DateTime), int settlementPeriod = default(int), string boundary = default(string), long? indicatedGeneration = default(long?), long? indicatedDemand = default(long?), long? indicatedMargin = default(long?), long? indicatedImbalance = default(long?))
        {
            this.PublishTime = publishTime;
            this.StartTime = startTime;
            this.SettlementDate = settlementDate;
            this.SettlementPeriod = settlementPeriod;
            this.Boundary = boundary;
            this.IndicatedGeneration = indicatedGeneration;
            this.IndicatedDemand = indicatedDemand;
            this.IndicatedMargin = indicatedMargin;
            this.IndicatedImbalance = indicatedImbalance;
        }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        [DataMember(Name = "publishTime", EmitDefaultValue = true)]
        public DateTime? PublishTime { get; set; }

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
        /// Gets or Sets Boundary
        /// </summary>
        [DataMember(Name = "boundary", EmitDefaultValue = true)]
        public string Boundary { get; set; }

        /// <summary>
        /// Gets or Sets IndicatedGeneration
        /// </summary>
        [DataMember(Name = "indicatedGeneration", EmitDefaultValue = true)]
        public long? IndicatedGeneration { get; set; }

        /// <summary>
        /// Gets or Sets IndicatedDemand
        /// </summary>
        [DataMember(Name = "indicatedDemand", EmitDefaultValue = true)]
        public long? IndicatedDemand { get; set; }

        /// <summary>
        /// Gets or Sets IndicatedMargin
        /// </summary>
        [DataMember(Name = "indicatedMargin", EmitDefaultValue = true)]
        public long? IndicatedMargin { get; set; }

        /// <summary>
        /// Gets or Sets IndicatedImbalance
        /// </summary>
        [DataMember(Name = "indicatedImbalance", EmitDefaultValue = true)]
        public long? IndicatedImbalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesIndicatedForecastIndicatedForecast {\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  SettlementPeriod: ").Append(SettlementPeriod).Append("\n");
            sb.Append("  Boundary: ").Append(Boundary).Append("\n");
            sb.Append("  IndicatedGeneration: ").Append(IndicatedGeneration).Append("\n");
            sb.Append("  IndicatedDemand: ").Append(IndicatedDemand).Append("\n");
            sb.Append("  IndicatedMargin: ").Append(IndicatedMargin).Append("\n");
            sb.Append("  IndicatedImbalance: ").Append(IndicatedImbalance).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesIndicatedForecastIndicatedForecast);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesIndicatedForecastIndicatedForecast instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesIndicatedForecastIndicatedForecast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesIndicatedForecastIndicatedForecast input)
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
                    this.Boundary == input.Boundary ||
                    (this.Boundary != null &&
                    this.Boundary.Equals(input.Boundary))
                ) && 
                (
                    this.IndicatedGeneration == input.IndicatedGeneration ||
                    (this.IndicatedGeneration != null &&
                    this.IndicatedGeneration.Equals(input.IndicatedGeneration))
                ) && 
                (
                    this.IndicatedDemand == input.IndicatedDemand ||
                    (this.IndicatedDemand != null &&
                    this.IndicatedDemand.Equals(input.IndicatedDemand))
                ) && 
                (
                    this.IndicatedMargin == input.IndicatedMargin ||
                    (this.IndicatedMargin != null &&
                    this.IndicatedMargin.Equals(input.IndicatedMargin))
                ) && 
                (
                    this.IndicatedImbalance == input.IndicatedImbalance ||
                    (this.IndicatedImbalance != null &&
                    this.IndicatedImbalance.Equals(input.IndicatedImbalance))
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
                if (this.Boundary != null)
                {
                    hashCode = (hashCode * 59) + this.Boundary.GetHashCode();
                }
                if (this.IndicatedGeneration != null)
                {
                    hashCode = (hashCode * 59) + this.IndicatedGeneration.GetHashCode();
                }
                if (this.IndicatedDemand != null)
                {
                    hashCode = (hashCode * 59) + this.IndicatedDemand.GetHashCode();
                }
                if (this.IndicatedMargin != null)
                {
                    hashCode = (hashCode * 59) + this.IndicatedMargin.GetHashCode();
                }
                if (this.IndicatedImbalance != null)
                {
                    hashCode = (hashCode * 59) + this.IndicatedImbalance.GetHashCode();
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

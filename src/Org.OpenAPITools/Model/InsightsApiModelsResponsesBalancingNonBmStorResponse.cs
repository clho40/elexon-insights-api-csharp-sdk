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
    /// InsightsApiModelsResponsesBalancingNonBmStorResponse
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Balancing.NonBmStorResponse")]
    public partial class InsightsApiModelsResponsesBalancingNonBmStorResponse : IEquatable<InsightsApiModelsResponsesBalancingNonBmStorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesBalancingNonBmStorResponse" /> class.
        /// </summary>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="settlementDate">settlementDate.</param>
        /// <param name="settlementPeriod">settlementPeriod.</param>
        /// <param name="generation">generation.</param>
        public InsightsApiModelsResponsesBalancingNonBmStorResponse(DateTime publishTime = default(DateTime), DateTime startTime = default(DateTime), DateTime settlementDate = default(DateTime), int settlementPeriod = default(int), long generation = default(long))
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
        /// <example>2022-06-25T13:34Z</example>
        [DataMember(Name = "publishTime", EmitDefaultValue = false)]
        public DateTime PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        /// <example>2022-06-25T13:00Z</example>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets SettlementDate
        /// </summary>
        /// <example>Sat Jun 25 02:00:00 CEST 2022</example>
        [DataMember(Name = "settlementDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime SettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets SettlementPeriod
        /// </summary>
        /// <example>29</example>
        [DataMember(Name = "settlementPeriod", EmitDefaultValue = false)]
        public int SettlementPeriod { get; set; }

        /// <summary>
        /// Gets or Sets Generation
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "generation", EmitDefaultValue = false)]
        public long Generation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesBalancingNonBmStorResponse {\n");
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
            return this.Equals(input as InsightsApiModelsResponsesBalancingNonBmStorResponse);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesBalancingNonBmStorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesBalancingNonBmStorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesBalancingNonBmStorResponse input)
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
                    this.Generation.Equals(input.Generation)
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
                hashCode = (hashCode * 59) + this.Generation.GetHashCode();
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

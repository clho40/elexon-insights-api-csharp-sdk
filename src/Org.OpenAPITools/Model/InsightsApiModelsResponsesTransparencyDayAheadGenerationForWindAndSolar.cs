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
    /// InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Transparency.DayAheadGenerationForWindAndSolar")]
    public partial class InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar : IEquatable<InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar" /> class.
        /// </summary>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="processType">processType.</param>
        /// <param name="businessType">businessType.</param>
        /// <param name="psrType">psrType.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="settlementDate">settlementDate.</param>
        /// <param name="settlementPeriod">settlementPeriod.</param>
        /// <param name="quantity">quantity.</param>
        public InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar(DateTime publishTime = default(DateTime), string processType = default(string), string businessType = default(string), string psrType = default(string), DateTime startTime = default(DateTime), DateTime settlementDate = default(DateTime), int settlementPeriod = default(int), double quantity = default(double))
        {
            this.PublishTime = publishTime;
            this.ProcessType = processType;
            this.BusinessType = businessType;
            this.PsrType = psrType;
            this.StartTime = startTime;
            this.SettlementDate = settlementDate;
            this.SettlementPeriod = settlementPeriod;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        /// <example>2023-06-29T17:25:09Z</example>
        [DataMember(Name = "publishTime", EmitDefaultValue = false)]
        public DateTime PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets ProcessType
        /// </summary>
        /// <example>Intraday process</example>
        [DataMember(Name = "processType", EmitDefaultValue = true)]
        public string ProcessType { get; set; }

        /// <summary>
        /// Gets or Sets BusinessType
        /// </summary>
        /// <example>Wind generation</example>
        [DataMember(Name = "businessType", EmitDefaultValue = true)]
        public string BusinessType { get; set; }

        /// <summary>
        /// Gets or Sets PsrType
        /// </summary>
        /// <example>Wind Offshore</example>
        [DataMember(Name = "psrType", EmitDefaultValue = true)]
        public string PsrType { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        /// <example>2023-06-29T15:30Z</example>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets SettlementDate
        /// </summary>
        /// <example>Thu Jun 29 02:00:00 CEST 2023</example>
        [DataMember(Name = "settlementDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime SettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets SettlementPeriod
        /// </summary>
        /// <example>40</example>
        [DataMember(Name = "settlementPeriod", EmitDefaultValue = false)]
        public int SettlementPeriod { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar {\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  ProcessType: ").Append(ProcessType).Append("\n");
            sb.Append("  BusinessType: ").Append(BusinessType).Append("\n");
            sb.Append("  PsrType: ").Append(PsrType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  SettlementPeriod: ").Append(SettlementPeriod).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar input)
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
                    this.ProcessType == input.ProcessType ||
                    (this.ProcessType != null &&
                    this.ProcessType.Equals(input.ProcessType))
                ) && 
                (
                    this.BusinessType == input.BusinessType ||
                    (this.BusinessType != null &&
                    this.BusinessType.Equals(input.BusinessType))
                ) && 
                (
                    this.PsrType == input.PsrType ||
                    (this.PsrType != null &&
                    this.PsrType.Equals(input.PsrType))
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
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
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
                if (this.ProcessType != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessType.GetHashCode();
                }
                if (this.BusinessType != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessType.GetHashCode();
                }
                if (this.PsrType != null)
                {
                    hashCode = (hashCode * 59) + this.PsrType.GetHashCode();
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
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
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
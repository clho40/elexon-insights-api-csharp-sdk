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
    /// InsightsApiModelsResponsesBalancingDynamicRateData
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Balancing.Dynamic.RateData")]
    public partial class InsightsApiModelsResponsesBalancingDynamicRateData : IEquatable<InsightsApiModelsResponsesBalancingDynamicRateData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesBalancingDynamicRateData" /> class.
        /// </summary>
        /// <param name="dataset">dataset.</param>
        /// <param name="settlementDate">settlementDate.</param>
        /// <param name="settlementPeriod">settlementPeriod.</param>
        /// <param name="time">time.</param>
        /// <param name="rate1">rate1.</param>
        /// <param name="elbow2">elbow2.</param>
        /// <param name="rate2">rate2.</param>
        /// <param name="elbow3">elbow3.</param>
        /// <param name="rate3">rate3.</param>
        /// <param name="nationalGridBmUnit">nationalGridBmUnit.</param>
        /// <param name="bmUnit">bmUnit.</param>
        public InsightsApiModelsResponsesBalancingDynamicRateData(string dataset = default(string), DateTime settlementDate = default(DateTime), int settlementPeriod = default(int), DateTime time = default(DateTime), double rate1 = default(double), double? elbow2 = default(double?), double? rate2 = default(double?), double? elbow3 = default(double?), double? rate3 = default(double?), string nationalGridBmUnit = default(string), string bmUnit = default(string))
        {
            this.Dataset = dataset;
            this.SettlementDate = settlementDate;
            this.SettlementPeriod = settlementPeriod;
            this.Time = time;
            this.Rate1 = rate1;
            this.Elbow2 = elbow2;
            this.Rate2 = rate2;
            this.Elbow3 = elbow3;
            this.Rate3 = rate3;
            this.NationalGridBmUnit = nationalGridBmUnit;
            this.BmUnit = bmUnit;
        }

        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        /// <example>RURE</example>
        [DataMember(Name = "dataset", EmitDefaultValue = true)]
        public string Dataset { get; set; }

        /// <summary>
        /// Gets or Sets SettlementDate
        /// </summary>
        /// <example>Fri Jul 01 02:00:00 CEST 2022</example>
        [DataMember(Name = "settlementDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime SettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets SettlementPeriod
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "settlementPeriod", EmitDefaultValue = false)]
        public int SettlementPeriod { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        /// <example>2022-07-01T13:34Z</example>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or Sets Rate1
        /// </summary>
        /// <example>0.4</example>
        [DataMember(Name = "rate1", EmitDefaultValue = false)]
        public double Rate1 { get; set; }

        /// <summary>
        /// Gets or Sets Elbow2
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "elbow2", EmitDefaultValue = true)]
        public double? Elbow2 { get; set; }

        /// <summary>
        /// Gets or Sets Rate2
        /// </summary>
        /// <example>300.2</example>
        [DataMember(Name = "rate2", EmitDefaultValue = true)]
        public double? Rate2 { get; set; }

        /// <summary>
        /// Gets or Sets Elbow3
        /// </summary>
        [DataMember(Name = "elbow3", EmitDefaultValue = true)]
        public double? Elbow3 { get; set; }

        /// <summary>
        /// Gets or Sets Rate3
        /// </summary>
        [DataMember(Name = "rate3", EmitDefaultValue = true)]
        public double? Rate3 { get; set; }

        /// <summary>
        /// Gets or Sets NationalGridBmUnit
        /// </summary>
        /// <example>ABRBO-1</example>
        [DataMember(Name = "nationalGridBmUnit", EmitDefaultValue = true)]
        public string NationalGridBmUnit { get; set; }

        /// <summary>
        /// Gets or Sets BmUnit
        /// </summary>
        /// <example>T_ABRBO-1</example>
        [DataMember(Name = "bmUnit", EmitDefaultValue = true)]
        public string BmUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesBalancingDynamicRateData {\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  SettlementPeriod: ").Append(SettlementPeriod).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Rate1: ").Append(Rate1).Append("\n");
            sb.Append("  Elbow2: ").Append(Elbow2).Append("\n");
            sb.Append("  Rate2: ").Append(Rate2).Append("\n");
            sb.Append("  Elbow3: ").Append(Elbow3).Append("\n");
            sb.Append("  Rate3: ").Append(Rate3).Append("\n");
            sb.Append("  NationalGridBmUnit: ").Append(NationalGridBmUnit).Append("\n");
            sb.Append("  BmUnit: ").Append(BmUnit).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesBalancingDynamicRateData);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesBalancingDynamicRateData instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesBalancingDynamicRateData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesBalancingDynamicRateData input)
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
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.SettlementPeriod == input.SettlementPeriod ||
                    this.SettlementPeriod.Equals(input.SettlementPeriod)
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Rate1 == input.Rate1 ||
                    this.Rate1.Equals(input.Rate1)
                ) && 
                (
                    this.Elbow2 == input.Elbow2 ||
                    (this.Elbow2 != null &&
                    this.Elbow2.Equals(input.Elbow2))
                ) && 
                (
                    this.Rate2 == input.Rate2 ||
                    (this.Rate2 != null &&
                    this.Rate2.Equals(input.Rate2))
                ) && 
                (
                    this.Elbow3 == input.Elbow3 ||
                    (this.Elbow3 != null &&
                    this.Elbow3.Equals(input.Elbow3))
                ) && 
                (
                    this.Rate3 == input.Rate3 ||
                    (this.Rate3 != null &&
                    this.Rate3.Equals(input.Rate3))
                ) && 
                (
                    this.NationalGridBmUnit == input.NationalGridBmUnit ||
                    (this.NationalGridBmUnit != null &&
                    this.NationalGridBmUnit.Equals(input.NationalGridBmUnit))
                ) && 
                (
                    this.BmUnit == input.BmUnit ||
                    (this.BmUnit != null &&
                    this.BmUnit.Equals(input.BmUnit))
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
                if (this.SettlementDate != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SettlementPeriod.GetHashCode();
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rate1.GetHashCode();
                if (this.Elbow2 != null)
                {
                    hashCode = (hashCode * 59) + this.Elbow2.GetHashCode();
                }
                if (this.Rate2 != null)
                {
                    hashCode = (hashCode * 59) + this.Rate2.GetHashCode();
                }
                if (this.Elbow3 != null)
                {
                    hashCode = (hashCode * 59) + this.Elbow3.GetHashCode();
                }
                if (this.Rate3 != null)
                {
                    hashCode = (hashCode * 59) + this.Rate3.GetHashCode();
                }
                if (this.NationalGridBmUnit != null)
                {
                    hashCode = (hashCode * 59) + this.NationalGridBmUnit.GetHashCode();
                }
                if (this.BmUnit != null)
                {
                    hashCode = (hashCode * 59) + this.BmUnit.GetHashCode();
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

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
    /// InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Balancing.DatasetRows.BalancingServicesVolumeData")]
    public partial class InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData : IEquatable<InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData" /> class.
        /// </summary>
        /// <param name="dataset">dataset.</param>
        /// <param name="settlementDate">settlementDate.</param>
        /// <param name="settlementPeriod">settlementPeriod.</param>
        /// <param name="bmUnitApplicableBalancingServicesVolume">bmUnitApplicableBalancingServicesVolume.</param>
        /// <param name="nationalGridBmUnit">nationalGridBmUnit.</param>
        /// <param name="bmUnit">bmUnit.</param>
        public InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData(string dataset = default(string), DateTime settlementDate = default(DateTime), int settlementPeriod = default(int), double bmUnitApplicableBalancingServicesVolume = default(double), string nationalGridBmUnit = default(string), string bmUnit = default(string))
        {
            this.Dataset = dataset;
            this.SettlementDate = settlementDate;
            this.SettlementPeriod = settlementPeriod;
            this.BmUnitApplicableBalancingServicesVolume = bmUnitApplicableBalancingServicesVolume;
            this.NationalGridBmUnit = nationalGridBmUnit;
            this.BmUnit = bmUnit;
        }

        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        /// <example>QAS</example>
        [DataMember(Name = "dataset", EmitDefaultValue = true)]
        public string Dataset { get; set; }

        /// <summary>
        /// Gets or Sets SettlementDate
        /// </summary>
        /// <example>Mon Jul 25 02:00:00 CEST 2022</example>
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
        /// Gets or Sets BmUnitApplicableBalancingServicesVolume
        /// </summary>
        /// <example>123.45</example>
        [DataMember(Name = "bmUnitApplicableBalancingServicesVolume", EmitDefaultValue = false)]
        public double BmUnitApplicableBalancingServicesVolume { get; set; }

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
            sb.Append("class InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData {\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  SettlementPeriod: ").Append(SettlementPeriod).Append("\n");
            sb.Append("  BmUnitApplicableBalancingServicesVolume: ").Append(BmUnitApplicableBalancingServicesVolume).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesBalancingDatasetRowsBalancingServicesVolumeData input)
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
                    this.BmUnitApplicableBalancingServicesVolume == input.BmUnitApplicableBalancingServicesVolume ||
                    this.BmUnitApplicableBalancingServicesVolume.Equals(input.BmUnitApplicableBalancingServicesVolume)
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
                hashCode = (hashCode * 59) + this.BmUnitApplicableBalancingServicesVolume.GetHashCode();
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

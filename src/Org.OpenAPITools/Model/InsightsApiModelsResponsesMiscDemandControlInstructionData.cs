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
    /// InsightsApiModelsResponsesMiscDemandControlInstructionData
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Misc.DemandControlInstructionData")]
    public partial class InsightsApiModelsResponsesMiscDemandControlInstructionData : IEquatable<InsightsApiModelsResponsesMiscDemandControlInstructionData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesMiscDemandControlInstructionData" /> class.
        /// </summary>
        /// <param name="mRID">mRID.</param>
        /// <param name="revisionNumber">revisionNumber.</param>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="publishingPeriodCommencingTime">publishingPeriodCommencingTime.</param>
        /// <param name="affectedDso">affectedDso.</param>
        /// <param name="demandControlId">demandControlId.</param>
        /// <param name="instructionSequence">instructionSequence.</param>
        /// <param name="demandControlEventFlag">demandControlEventFlag.</param>
        /// <param name="timeFrom">timeFrom.</param>
        /// <param name="timeTo">timeTo.</param>
        /// <param name="volume">volume.</param>
        /// <param name="systemManagementActionFlag">systemManagementActionFlag.</param>
        /// <param name="amendmentFlag">amendmentFlag.</param>
        public InsightsApiModelsResponsesMiscDemandControlInstructionData(string mRID = default(string), int revisionNumber = default(int), DateTime? publishTime = default(DateTime?), DateTime publishingPeriodCommencingTime = default(DateTime), string affectedDso = default(string), string demandControlId = default(string), int instructionSequence = default(int), string demandControlEventFlag = default(string), DateTime timeFrom = default(DateTime), DateTime? timeTo = default(DateTime?), double volume = default(double), string systemManagementActionFlag = default(string), string amendmentFlag = default(string))
        {
            this.MRID = mRID;
            this.RevisionNumber = revisionNumber;
            this.PublishTime = publishTime;
            this.PublishingPeriodCommencingTime = publishingPeriodCommencingTime;
            this.AffectedDso = affectedDso;
            this.DemandControlId = demandControlId;
            this.InstructionSequence = instructionSequence;
            this.DemandControlEventFlag = demandControlEventFlag;
            this.TimeFrom = timeFrom;
            this.TimeTo = timeTo;
            this.Volume = volume;
            this.SystemManagementActionFlag = systemManagementActionFlag;
            this.AmendmentFlag = amendmentFlag;
        }

        /// <summary>
        /// Gets or Sets MRID
        /// </summary>
        /// <example>DCI_202104300853_00000030</example>
        [DataMember(Name = "mRID", EmitDefaultValue = true)]
        public string MRID { get; set; }

        /// <summary>
        /// Gets or Sets RevisionNumber
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "revisionNumber", EmitDefaultValue = false)]
        public int RevisionNumber { get; set; }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        /// <example>2021-04-30T08:53:39Z</example>
        [DataMember(Name = "publishTime", EmitDefaultValue = true)]
        public DateTime? PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets PublishingPeriodCommencingTime
        /// </summary>
        /// <example>2021-04-30T08:53:39Z</example>
        [DataMember(Name = "publishingPeriodCommencingTime", EmitDefaultValue = false)]
        public DateTime PublishingPeriodCommencingTime { get; set; }

        /// <summary>
        /// Gets or Sets AffectedDso
        /// </summary>
        /// <example>SP(D)</example>
        [DataMember(Name = "affectedDso", EmitDefaultValue = true)]
        public string AffectedDso { get; set; }

        /// <summary>
        /// Gets or Sets DemandControlId
        /// </summary>
        /// <example>00135</example>
        [DataMember(Name = "demandControlId", EmitDefaultValue = true)]
        public string DemandControlId { get; set; }

        /// <summary>
        /// Gets or Sets InstructionSequence
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "instructionSequence", EmitDefaultValue = false)]
        public int InstructionSequence { get; set; }

        /// <summary>
        /// Gets or Sets DemandControlEventFlag
        /// </summary>
        /// <example>I</example>
        [DataMember(Name = "demandControlEventFlag", EmitDefaultValue = false)]
        public string DemandControlEventFlag { get; set; }

        /// <summary>
        /// Gets or Sets TimeFrom
        /// </summary>
        /// <example>2021-04-30T12:45Z</example>
        [DataMember(Name = "timeFrom", EmitDefaultValue = false)]
        public DateTime TimeFrom { get; set; }

        /// <summary>
        /// Gets or Sets TimeTo
        /// </summary>
        /// <example>2021-04-30T13:09Z</example>
        [DataMember(Name = "timeTo", EmitDefaultValue = true)]
        public DateTime? TimeTo { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        /// <example>68</example>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public double Volume { get; set; }

        /// <summary>
        /// Gets or Sets SystemManagementActionFlag
        /// </summary>
        /// <example>T</example>
        [DataMember(Name = "systemManagementActionFlag", EmitDefaultValue = true)]
        public string SystemManagementActionFlag { get; set; }

        /// <summary>
        /// Gets or Sets AmendmentFlag
        /// </summary>
        /// <example>ORI</example>
        [DataMember(Name = "amendmentFlag", EmitDefaultValue = true)]
        public string AmendmentFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesMiscDemandControlInstructionData {\n");
            sb.Append("  MRID: ").Append(MRID).Append("\n");
            sb.Append("  RevisionNumber: ").Append(RevisionNumber).Append("\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  PublishingPeriodCommencingTime: ").Append(PublishingPeriodCommencingTime).Append("\n");
            sb.Append("  AffectedDso: ").Append(AffectedDso).Append("\n");
            sb.Append("  DemandControlId: ").Append(DemandControlId).Append("\n");
            sb.Append("  InstructionSequence: ").Append(InstructionSequence).Append("\n");
            sb.Append("  DemandControlEventFlag: ").Append(DemandControlEventFlag).Append("\n");
            sb.Append("  TimeFrom: ").Append(TimeFrom).Append("\n");
            sb.Append("  TimeTo: ").Append(TimeTo).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  SystemManagementActionFlag: ").Append(SystemManagementActionFlag).Append("\n");
            sb.Append("  AmendmentFlag: ").Append(AmendmentFlag).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesMiscDemandControlInstructionData);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesMiscDemandControlInstructionData instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesMiscDemandControlInstructionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesMiscDemandControlInstructionData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MRID == input.MRID ||
                    (this.MRID != null &&
                    this.MRID.Equals(input.MRID))
                ) && 
                (
                    this.RevisionNumber == input.RevisionNumber ||
                    this.RevisionNumber.Equals(input.RevisionNumber)
                ) && 
                (
                    this.PublishTime == input.PublishTime ||
                    (this.PublishTime != null &&
                    this.PublishTime.Equals(input.PublishTime))
                ) && 
                (
                    this.PublishingPeriodCommencingTime == input.PublishingPeriodCommencingTime ||
                    (this.PublishingPeriodCommencingTime != null &&
                    this.PublishingPeriodCommencingTime.Equals(input.PublishingPeriodCommencingTime))
                ) && 
                (
                    this.AffectedDso == input.AffectedDso ||
                    (this.AffectedDso != null &&
                    this.AffectedDso.Equals(input.AffectedDso))
                ) && 
                (
                    this.DemandControlId == input.DemandControlId ||
                    (this.DemandControlId != null &&
                    this.DemandControlId.Equals(input.DemandControlId))
                ) && 
                (
                    this.InstructionSequence == input.InstructionSequence ||
                    this.InstructionSequence.Equals(input.InstructionSequence)
                ) && 
                (
                    this.DemandControlEventFlag == input.DemandControlEventFlag ||
                    (this.DemandControlEventFlag != null &&
                    this.DemandControlEventFlag.Equals(input.DemandControlEventFlag))
                ) && 
                (
                    this.TimeFrom == input.TimeFrom ||
                    (this.TimeFrom != null &&
                    this.TimeFrom.Equals(input.TimeFrom))
                ) && 
                (
                    this.TimeTo == input.TimeTo ||
                    (this.TimeTo != null &&
                    this.TimeTo.Equals(input.TimeTo))
                ) && 
                (
                    this.Volume == input.Volume ||
                    this.Volume.Equals(input.Volume)
                ) && 
                (
                    this.SystemManagementActionFlag == input.SystemManagementActionFlag ||
                    (this.SystemManagementActionFlag != null &&
                    this.SystemManagementActionFlag.Equals(input.SystemManagementActionFlag))
                ) && 
                (
                    this.AmendmentFlag == input.AmendmentFlag ||
                    (this.AmendmentFlag != null &&
                    this.AmendmentFlag.Equals(input.AmendmentFlag))
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
                if (this.MRID != null)
                {
                    hashCode = (hashCode * 59) + this.MRID.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RevisionNumber.GetHashCode();
                if (this.PublishTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishTime.GetHashCode();
                }
                if (this.PublishingPeriodCommencingTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishingPeriodCommencingTime.GetHashCode();
                }
                if (this.AffectedDso != null)
                {
                    hashCode = (hashCode * 59) + this.AffectedDso.GetHashCode();
                }
                if (this.DemandControlId != null)
                {
                    hashCode = (hashCode * 59) + this.DemandControlId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InstructionSequence.GetHashCode();
                if (this.DemandControlEventFlag != null)
                {
                    hashCode = (hashCode * 59) + this.DemandControlEventFlag.GetHashCode();
                }
                if (this.TimeFrom != null)
                {
                    hashCode = (hashCode * 59) + this.TimeFrom.GetHashCode();
                }
                if (this.TimeTo != null)
                {
                    hashCode = (hashCode * 59) + this.TimeTo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Volume.GetHashCode();
                if (this.SystemManagementActionFlag != null)
                {
                    hashCode = (hashCode * 59) + this.SystemManagementActionFlag.GetHashCode();
                }
                if (this.AmendmentFlag != null)
                {
                    hashCode = (hashCode * 59) + this.AmendmentFlag.GetHashCode();
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
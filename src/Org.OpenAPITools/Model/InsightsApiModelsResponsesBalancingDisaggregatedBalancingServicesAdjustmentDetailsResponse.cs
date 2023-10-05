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
    /// InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Balancing.DisaggregatedBalancingServicesAdjustmentDetailsResponse")]
    public partial class InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse : IEquatable<InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse" /> class.
        /// </summary>
        /// <param name="settlementDate">settlementDate.</param>
        /// <param name="settlementPeriod">settlementPeriod.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="id">id.</param>
        /// <param name="cost">cost.</param>
        /// <param name="volume">volume.</param>
        /// <param name="price">price.</param>
        /// <param name="soFlag">soFlag.</param>
        /// <param name="storFlag">storFlag.</param>
        /// <param name="partyId">partyId.</param>
        /// <param name="assetId">assetId.</param>
        /// <param name="isTendered">isTendered.</param>
        /// <param name="service">service.</param>
        public InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse(DateTime settlementDate = default(DateTime), int settlementPeriod = default(int), DateTime startTime = default(DateTime), int id = default(int), double? cost = default(double?), double volume = default(double), double? price = default(double?), bool soFlag = default(bool), bool storFlag = default(bool), string partyId = default(string), string assetId = default(string), bool? isTendered = default(bool?), string service = default(string))
        {
            this.SettlementDate = settlementDate;
            this.SettlementPeriod = settlementPeriod;
            this.StartTime = startTime;
            this.Id = id;
            this.Cost = cost;
            this.Volume = volume;
            this.Price = price;
            this.SoFlag = soFlag;
            this.StorFlag = storFlag;
            this.PartyId = partyId;
            this.AssetId = assetId;
            this.IsTendered = isTendered;
            this.Service = service;
        }

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
        /// Gets or Sets StartTime
        /// </summary>
        /// <example>2022-06-25T13:00Z</example>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        /// <example>1850.9</example>
        [DataMember(Name = "cost", EmitDefaultValue = true)]
        public double? Cost { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public double Volume { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        /// <example>370.18</example>
        [DataMember(Name = "price", EmitDefaultValue = true)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets SoFlag
        /// </summary>
        [DataMember(Name = "soFlag", EmitDefaultValue = true)]
        public bool SoFlag { get; set; }

        /// <summary>
        /// Gets or Sets StorFlag
        /// </summary>
        [DataMember(Name = "storFlag", EmitDefaultValue = true)]
        public bool StorFlag { get; set; }

        /// <summary>
        /// Gets or Sets PartyId
        /// </summary>
        /// <example>ElectroRoute Energy Trading Limited</example>
        [DataMember(Name = "partyId", EmitDefaultValue = true)]
        public string PartyId { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        /// <example>ING-ELTR1</example>
        [DataMember(Name = "assetId", EmitDefaultValue = true)]
        public string AssetId { get; set; }

        /// <summary>
        /// Gets or Sets IsTendered
        /// </summary>
        [DataMember(Name = "isTendered", EmitDefaultValue = true)]
        public bool? IsTendered { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        /// <example>Energy</example>
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public string Service { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse {\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  SettlementPeriod: ").Append(SettlementPeriod).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  SoFlag: ").Append(SoFlag).Append("\n");
            sb.Append("  StorFlag: ").Append(StorFlag).Append("\n");
            sb.Append("  PartyId: ").Append(PartyId).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  IsTendered: ").Append(IsTendered).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.Volume == input.Volume ||
                    this.Volume.Equals(input.Volume)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.SoFlag == input.SoFlag ||
                    this.SoFlag.Equals(input.SoFlag)
                ) && 
                (
                    this.StorFlag == input.StorFlag ||
                    this.StorFlag.Equals(input.StorFlag)
                ) && 
                (
                    this.PartyId == input.PartyId ||
                    (this.PartyId != null &&
                    this.PartyId.Equals(input.PartyId))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.IsTendered == input.IsTendered ||
                    (this.IsTendered != null &&
                    this.IsTendered.Equals(input.IsTendered))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
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
                if (this.SettlementDate != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SettlementPeriod.GetHashCode();
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Cost != null)
                {
                    hashCode = (hashCode * 59) + this.Cost.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Volume.GetHashCode();
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SoFlag.GetHashCode();
                hashCode = (hashCode * 59) + this.StorFlag.GetHashCode();
                if (this.PartyId != null)
                {
                    hashCode = (hashCode * 59) + this.PartyId.GetHashCode();
                }
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                if (this.IsTendered != null)
                {
                    hashCode = (hashCode * 59) + this.IsTendered.GetHashCode();
                }
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
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

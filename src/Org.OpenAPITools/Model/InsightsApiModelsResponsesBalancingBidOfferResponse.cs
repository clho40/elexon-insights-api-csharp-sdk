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
    /// InsightsApiModelsResponsesBalancingBidOfferResponse
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Balancing.BidOfferResponse")]
    public partial class InsightsApiModelsResponsesBalancingBidOfferResponse : IEquatable<InsightsApiModelsResponsesBalancingBidOfferResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesBalancingBidOfferResponse" /> class.
        /// </summary>
        /// <param name="settlementDate">settlementDate.</param>
        /// <param name="settlementPeriod">settlementPeriod.</param>
        /// <param name="nationalGridBmUnit">nationalGridBmUnit.</param>
        /// <param name="bmUnit">bmUnit.</param>
        /// <param name="timeFrom">timeFrom.</param>
        /// <param name="timeTo">timeTo.</param>
        /// <param name="levelFrom">levelFrom.</param>
        /// <param name="levelTo">levelTo.</param>
        /// <param name="bid">bid.</param>
        /// <param name="offer">offer.</param>
        /// <param name="pairId">pairId.</param>
        public InsightsApiModelsResponsesBalancingBidOfferResponse(DateTime settlementDate = default(DateTime), int settlementPeriod = default(int), string nationalGridBmUnit = default(string), string bmUnit = default(string), DateTime timeFrom = default(DateTime), DateTime timeTo = default(DateTime), int levelFrom = default(int), int levelTo = default(int), double bid = default(double), double offer = default(double), int pairId = default(int))
        {
            this.SettlementDate = settlementDate;
            this.SettlementPeriod = settlementPeriod;
            this.NationalGridBmUnit = nationalGridBmUnit;
            this.BmUnit = bmUnit;
            this.TimeFrom = timeFrom;
            this.TimeTo = timeTo;
            this.LevelFrom = levelFrom;
            this.LevelTo = levelTo;
            this.Bid = bid;
            this.Offer = offer;
            this.PairId = pairId;
        }

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
        /// Gets or Sets TimeFrom
        /// </summary>
        /// <example>2022-07-01T13:34Z</example>
        [DataMember(Name = "timeFrom", EmitDefaultValue = false)]
        public DateTime TimeFrom { get; set; }

        /// <summary>
        /// Gets or Sets TimeTo
        /// </summary>
        /// <example>2022-07-01T13:34Z</example>
        [DataMember(Name = "timeTo", EmitDefaultValue = false)]
        public DateTime TimeTo { get; set; }

        /// <summary>
        /// Gets or Sets LevelFrom
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "levelFrom", EmitDefaultValue = false)]
        public int LevelFrom { get; set; }

        /// <summary>
        /// Gets or Sets LevelTo
        /// </summary>
        /// <example>46</example>
        [DataMember(Name = "levelTo", EmitDefaultValue = false)]
        public int LevelTo { get; set; }

        /// <summary>
        /// Gets or Sets Bid
        /// </summary>
        /// <example>668.67</example>
        [DataMember(Name = "bid", EmitDefaultValue = false)]
        public double Bid { get; set; }

        /// <summary>
        /// Gets or Sets Offer
        /// </summary>
        /// <example>-71.5</example>
        [DataMember(Name = "offer", EmitDefaultValue = false)]
        public double Offer { get; set; }

        /// <summary>
        /// Gets or Sets PairId
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "pairId", EmitDefaultValue = false)]
        public int PairId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesBalancingBidOfferResponse {\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  SettlementPeriod: ").Append(SettlementPeriod).Append("\n");
            sb.Append("  NationalGridBmUnit: ").Append(NationalGridBmUnit).Append("\n");
            sb.Append("  BmUnit: ").Append(BmUnit).Append("\n");
            sb.Append("  TimeFrom: ").Append(TimeFrom).Append("\n");
            sb.Append("  TimeTo: ").Append(TimeTo).Append("\n");
            sb.Append("  LevelFrom: ").Append(LevelFrom).Append("\n");
            sb.Append("  LevelTo: ").Append(LevelTo).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
            sb.Append("  Offer: ").Append(Offer).Append("\n");
            sb.Append("  PairId: ").Append(PairId).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesBalancingBidOfferResponse);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesBalancingBidOfferResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesBalancingBidOfferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesBalancingBidOfferResponse input)
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
                    this.NationalGridBmUnit == input.NationalGridBmUnit ||
                    (this.NationalGridBmUnit != null &&
                    this.NationalGridBmUnit.Equals(input.NationalGridBmUnit))
                ) && 
                (
                    this.BmUnit == input.BmUnit ||
                    (this.BmUnit != null &&
                    this.BmUnit.Equals(input.BmUnit))
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
                    this.LevelFrom == input.LevelFrom ||
                    this.LevelFrom.Equals(input.LevelFrom)
                ) && 
                (
                    this.LevelTo == input.LevelTo ||
                    this.LevelTo.Equals(input.LevelTo)
                ) && 
                (
                    this.Bid == input.Bid ||
                    this.Bid.Equals(input.Bid)
                ) && 
                (
                    this.Offer == input.Offer ||
                    this.Offer.Equals(input.Offer)
                ) && 
                (
                    this.PairId == input.PairId ||
                    this.PairId.Equals(input.PairId)
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
                if (this.NationalGridBmUnit != null)
                {
                    hashCode = (hashCode * 59) + this.NationalGridBmUnit.GetHashCode();
                }
                if (this.BmUnit != null)
                {
                    hashCode = (hashCode * 59) + this.BmUnit.GetHashCode();
                }
                if (this.TimeFrom != null)
                {
                    hashCode = (hashCode * 59) + this.TimeFrom.GetHashCode();
                }
                if (this.TimeTo != null)
                {
                    hashCode = (hashCode * 59) + this.TimeTo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LevelFrom.GetHashCode();
                hashCode = (hashCode * 59) + this.LevelTo.GetHashCode();
                hashCode = (hashCode * 59) + this.Bid.GetHashCode();
                hashCode = (hashCode * 59) + this.Offer.GetHashCode();
                hashCode = (hashCode * 59) + this.PairId.GetHashCode();
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

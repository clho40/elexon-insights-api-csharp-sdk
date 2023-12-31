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
    /// InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Balancing.Settlement.SettlementMessageResponse")]
    public partial class InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse : IEquatable<InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse" /> class.
        /// </summary>
        /// <param name="settlementDate">settlementDate.</param>
        /// <param name="settlementPeriod">settlementPeriod.</param>
        /// <param name="messageReceivedDateTime">messageReceivedDateTime.</param>
        /// <param name="messageSeverity">messageSeverity.</param>
        /// <param name="messageType">messageType.</param>
        /// <param name="messageText">messageText.</param>
        public InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse(DateTime settlementDate = default(DateTime), int settlementPeriod = default(int), DateTime messageReceivedDateTime = default(DateTime), string messageSeverity = default(string), string messageType = default(string), string messageText = default(string))
        {
            this.SettlementDate = settlementDate;
            this.SettlementPeriod = settlementPeriod;
            this.MessageReceivedDateTime = messageReceivedDateTime;
            this.MessageSeverity = messageSeverity;
            this.MessageType = messageType;
            this.MessageText = messageText;
        }

        /// <summary>
        /// Gets or Sets SettlementDate
        /// </summary>
        /// <example>Mon Sep 18 02:00:00 CEST 2023</example>
        [DataMember(Name = "settlementDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime SettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets SettlementPeriod
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "settlementPeriod", EmitDefaultValue = false)]
        public int SettlementPeriod { get; set; }

        /// <summary>
        /// Gets or Sets MessageReceivedDateTime
        /// </summary>
        /// <example>2023-09-17T15:31:12Z</example>
        [DataMember(Name = "messageReceivedDateTime", EmitDefaultValue = false)]
        public DateTime MessageReceivedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets MessageSeverity
        /// </summary>
        /// <example>Error</example>
        [DataMember(Name = "messageSeverity", EmitDefaultValue = true)]
        public string MessageSeverity { get; set; }

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        /// <example>FPN</example>
        [DataMember(Name = "messageType", EmitDefaultValue = true)]
        public string MessageType { get; set; }

        /// <summary>
        /// Gets or Sets MessageText
        /// </summary>
        /// <example>No FPN files have been received.</example>
        [DataMember(Name = "messageText", EmitDefaultValue = true)]
        public string MessageText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse {\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  SettlementPeriod: ").Append(SettlementPeriod).Append("\n");
            sb.Append("  MessageReceivedDateTime: ").Append(MessageReceivedDateTime).Append("\n");
            sb.Append("  MessageSeverity: ").Append(MessageSeverity).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  MessageText: ").Append(MessageText).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse input)
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
                    this.MessageReceivedDateTime == input.MessageReceivedDateTime ||
                    (this.MessageReceivedDateTime != null &&
                    this.MessageReceivedDateTime.Equals(input.MessageReceivedDateTime))
                ) && 
                (
                    this.MessageSeverity == input.MessageSeverity ||
                    (this.MessageSeverity != null &&
                    this.MessageSeverity.Equals(input.MessageSeverity))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.MessageText == input.MessageText ||
                    (this.MessageText != null &&
                    this.MessageText.Equals(input.MessageText))
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
                if (this.MessageReceivedDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.MessageReceivedDateTime.GetHashCode();
                }
                if (this.MessageSeverity != null)
                {
                    hashCode = (hashCode * 59) + this.MessageSeverity.GetHashCode();
                }
                if (this.MessageType != null)
                {
                    hashCode = (hashCode * 59) + this.MessageType.GetHashCode();
                }
                if (this.MessageText != null)
                {
                    hashCode = (hashCode * 59) + this.MessageText.GetHashCode();
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

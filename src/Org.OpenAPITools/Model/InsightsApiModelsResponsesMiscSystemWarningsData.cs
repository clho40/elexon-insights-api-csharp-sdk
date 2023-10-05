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
    /// InsightsApiModelsResponsesMiscSystemWarningsData
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Misc.SystemWarningsData")]
    public partial class InsightsApiModelsResponsesMiscSystemWarningsData : IEquatable<InsightsApiModelsResponsesMiscSystemWarningsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesMiscSystemWarningsData" /> class.
        /// </summary>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="warningType">warningType.</param>
        /// <param name="warningText">warningText.</param>
        public InsightsApiModelsResponsesMiscSystemWarningsData(DateTime? publishTime = default(DateTime?), string warningType = default(string), string warningText = default(string))
        {
            this.PublishTime = publishTime;
            this.WarningType = warningType;
            this.WarningText = warningText;
        }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        /// <example>2022-09-20T00:00Z</example>
        [DataMember(Name = "publishTime", EmitDefaultValue = true)]
        public DateTime? PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets WarningType
        /// </summary>
        /// <example>IT SYSTEMS OUTAGE</example>
        [DataMember(Name = "warningType", EmitDefaultValue = true)]
        public string WarningType { get; set; }

        /// <summary>
        /// Gets or Sets WarningText
        /// </summary>
        /// <example>NATIONAL GRID NOTIFICATION of excess energy prices used for settlement outside of BALIT for SO to SO Transactions</example>
        [DataMember(Name = "warningText", EmitDefaultValue = true)]
        public string WarningText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesMiscSystemWarningsData {\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  WarningType: ").Append(WarningType).Append("\n");
            sb.Append("  WarningText: ").Append(WarningText).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesMiscSystemWarningsData);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesMiscSystemWarningsData instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesMiscSystemWarningsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesMiscSystemWarningsData input)
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
                    this.WarningType == input.WarningType ||
                    (this.WarningType != null &&
                    this.WarningType.Equals(input.WarningType))
                ) && 
                (
                    this.WarningText == input.WarningText ||
                    (this.WarningText != null &&
                    this.WarningText.Equals(input.WarningText))
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
                if (this.WarningType != null)
                {
                    hashCode = (hashCode * 59) + this.WarningType.GetHashCode();
                }
                if (this.WarningText != null)
                {
                    hashCode = (hashCode * 59) + this.WarningText.GetHashCode();
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

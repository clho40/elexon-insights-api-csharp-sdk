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
    /// InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Transparency.Remit.RemitMessageIdentifierWithUrl")]
    public partial class InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl : IEquatable<InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="mrid">mrid.</param>
        /// <param name="revisionNumber">revisionNumber.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="url">url.</param>
        public InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl(int id = default(int), string mrid = default(string), int revisionNumber = default(int), DateTime createdTime = default(DateTime), string url = default(string))
        {
            this.Id = id;
            this.Mrid = mrid;
            this.RevisionNumber = revisionNumber;
            this.CreatedTime = createdTime;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>24</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Mrid
        /// </summary>
        /// <example>11XINNOGY------2-NGET-RMT-00084421</example>
        [DataMember(Name = "mrid", EmitDefaultValue = true)]
        public string Mrid { get; set; }

        /// <summary>
        /// Gets or Sets RevisionNumber
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "revisionNumber", EmitDefaultValue = false)]
        public int RevisionNumber { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        /// <example>2023-01-31T17:39:15Z</example>
        [DataMember(Name = "createdTime", EmitDefaultValue = false)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        /// <example>https://data.elexon.co.uk/bmrs/api/v1/remit/24</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Mrid: ").Append(Mrid).Append("\n");
            sb.Append("  RevisionNumber: ").Append(RevisionNumber).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Mrid == input.Mrid ||
                    (this.Mrid != null &&
                    this.Mrid.Equals(input.Mrid))
                ) && 
                (
                    this.RevisionNumber == input.RevisionNumber ||
                    this.RevisionNumber.Equals(input.RevisionNumber)
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Mrid != null)
                {
                    hashCode = (hashCode * 59) + this.Mrid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RevisionNumber.GetHashCode();
                if (this.CreatedTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedTime.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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

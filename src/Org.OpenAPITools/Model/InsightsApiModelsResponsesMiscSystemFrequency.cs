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
    /// InsightsApiModelsResponsesMiscSystemFrequency
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Misc.SystemFrequency")]
    public partial class InsightsApiModelsResponsesMiscSystemFrequency : IEquatable<InsightsApiModelsResponsesMiscSystemFrequency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesMiscSystemFrequency" /> class.
        /// </summary>
        /// <param name="measurementTime">measurementTime.</param>
        /// <param name="frequency">frequency.</param>
        public InsightsApiModelsResponsesMiscSystemFrequency(DateTime measurementTime = default(DateTime), double frequency = default(double))
        {
            this.MeasurementTime = measurementTime;
            this.Frequency = frequency;
        }

        /// <summary>
        /// Gets or Sets MeasurementTime
        /// </summary>
        [DataMember(Name = "measurementTime", EmitDefaultValue = false)]
        public DateTime MeasurementTime { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public double Frequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesMiscSystemFrequency {\n");
            sb.Append("  MeasurementTime: ").Append(MeasurementTime).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesMiscSystemFrequency);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesMiscSystemFrequency instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesMiscSystemFrequency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesMiscSystemFrequency input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MeasurementTime == input.MeasurementTime ||
                    (this.MeasurementTime != null &&
                    this.MeasurementTime.Equals(input.MeasurementTime))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
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
                if (this.MeasurementTime != null)
                {
                    hashCode = (hashCode * 59) + this.MeasurementTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
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

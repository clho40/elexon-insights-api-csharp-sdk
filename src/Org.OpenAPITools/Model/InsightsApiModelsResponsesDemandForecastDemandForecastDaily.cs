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
    /// InsightsApiModelsResponsesDemandForecastDemandForecastDaily
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.DemandForecast.DemandForecastDaily")]
    public partial class InsightsApiModelsResponsesDemandForecastDemandForecastDaily : IEquatable<InsightsApiModelsResponsesDemandForecastDemandForecastDaily>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesDemandForecastDemandForecastDaily" /> class.
        /// </summary>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="transmissionSystemDemand">transmissionSystemDemand.</param>
        /// <param name="nationalDemand">nationalDemand.</param>
        /// <param name="forecastDate">forecastDate.</param>
        public InsightsApiModelsResponsesDemandForecastDemandForecastDaily(DateTime? publishTime = default(DateTime?), long transmissionSystemDemand = default(long), long? nationalDemand = default(long?), DateTime forecastDate = default(DateTime))
        {
            this.PublishTime = publishTime;
            this.TransmissionSystemDemand = transmissionSystemDemand;
            this.NationalDemand = nationalDemand;
            this.ForecastDate = forecastDate;
        }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        [DataMember(Name = "publishTime", EmitDefaultValue = true)]
        public DateTime? PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets TransmissionSystemDemand
        /// </summary>
        [DataMember(Name = "transmissionSystemDemand", EmitDefaultValue = false)]
        public long TransmissionSystemDemand { get; set; }

        /// <summary>
        /// Gets or Sets NationalDemand
        /// </summary>
        [DataMember(Name = "nationalDemand", EmitDefaultValue = true)]
        public long? NationalDemand { get; set; }

        /// <summary>
        /// Gets or Sets ForecastDate
        /// </summary>
        [DataMember(Name = "forecastDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ForecastDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesDemandForecastDemandForecastDaily {\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  TransmissionSystemDemand: ").Append(TransmissionSystemDemand).Append("\n");
            sb.Append("  NationalDemand: ").Append(NationalDemand).Append("\n");
            sb.Append("  ForecastDate: ").Append(ForecastDate).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesDemandForecastDemandForecastDaily);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesDemandForecastDemandForecastDaily instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesDemandForecastDemandForecastDaily to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesDemandForecastDemandForecastDaily input)
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
                    this.TransmissionSystemDemand == input.TransmissionSystemDemand ||
                    this.TransmissionSystemDemand.Equals(input.TransmissionSystemDemand)
                ) && 
                (
                    this.NationalDemand == input.NationalDemand ||
                    (this.NationalDemand != null &&
                    this.NationalDemand.Equals(input.NationalDemand))
                ) && 
                (
                    this.ForecastDate == input.ForecastDate ||
                    (this.ForecastDate != null &&
                    this.ForecastDate.Equals(input.ForecastDate))
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
                hashCode = (hashCode * 59) + this.TransmissionSystemDemand.GetHashCode();
                if (this.NationalDemand != null)
                {
                    hashCode = (hashCode * 59) + this.NationalDemand.GetHashCode();
                }
                if (this.ForecastDate != null)
                {
                    hashCode = (hashCode * 59) + this.ForecastDate.GetHashCode();
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

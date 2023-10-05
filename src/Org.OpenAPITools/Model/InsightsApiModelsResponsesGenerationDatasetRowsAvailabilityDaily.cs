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
    /// InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Generation.DatasetRows.AvailabilityDaily")]
    public partial class InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily : IEquatable<InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily" /> class.
        /// </summary>
        /// <param name="dataset">dataset.</param>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="systemZone">systemZone.</param>
        /// <param name="forecastDate">forecastDate.</param>
        /// <param name="outputUsable">outputUsable.</param>
        public InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily(string dataset = default(string), DateTime? publishTime = default(DateTime?), string systemZone = default(string), DateTime forecastDate = default(DateTime), long? outputUsable = default(long?))
        {
            this.Dataset = dataset;
            this.PublishTime = publishTime;
            this.SystemZone = systemZone;
            this.ForecastDate = forecastDate;
            this.OutputUsable = outputUsable;
        }

        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        [DataMember(Name = "dataset", EmitDefaultValue = true)]
        public string Dataset { get; set; }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        [DataMember(Name = "publishTime", EmitDefaultValue = true)]
        public DateTime? PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets SystemZone
        /// </summary>
        [DataMember(Name = "systemZone", EmitDefaultValue = true)]
        public string SystemZone { get; set; }

        /// <summary>
        /// Gets or Sets ForecastDate
        /// </summary>
        [DataMember(Name = "forecastDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ForecastDate { get; set; }

        /// <summary>
        /// Gets or Sets ForecastDateTimezone
        /// </summary>
        [DataMember(Name = "forecastDateTimezone", EmitDefaultValue = true)]
        public string ForecastDateTimezone { get; private set; }

        /// <summary>
        /// Returns false as ForecastDateTimezone should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeForecastDateTimezone()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets OutputUsable
        /// </summary>
        [DataMember(Name = "outputUsable", EmitDefaultValue = true)]
        public long? OutputUsable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily {\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  SystemZone: ").Append(SystemZone).Append("\n");
            sb.Append("  ForecastDate: ").Append(ForecastDate).Append("\n");
            sb.Append("  ForecastDateTimezone: ").Append(ForecastDateTimezone).Append("\n");
            sb.Append("  OutputUsable: ").Append(OutputUsable).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesGenerationDatasetRowsAvailabilityDaily input)
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
                    this.PublishTime == input.PublishTime ||
                    (this.PublishTime != null &&
                    this.PublishTime.Equals(input.PublishTime))
                ) && 
                (
                    this.SystemZone == input.SystemZone ||
                    (this.SystemZone != null &&
                    this.SystemZone.Equals(input.SystemZone))
                ) && 
                (
                    this.ForecastDate == input.ForecastDate ||
                    (this.ForecastDate != null &&
                    this.ForecastDate.Equals(input.ForecastDate))
                ) && 
                (
                    this.ForecastDateTimezone == input.ForecastDateTimezone ||
                    (this.ForecastDateTimezone != null &&
                    this.ForecastDateTimezone.Equals(input.ForecastDateTimezone))
                ) && 
                (
                    this.OutputUsable == input.OutputUsable ||
                    (this.OutputUsable != null &&
                    this.OutputUsable.Equals(input.OutputUsable))
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
                if (this.PublishTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishTime.GetHashCode();
                }
                if (this.SystemZone != null)
                {
                    hashCode = (hashCode * 59) + this.SystemZone.GetHashCode();
                }
                if (this.ForecastDate != null)
                {
                    hashCode = (hashCode * 59) + this.ForecastDate.GetHashCode();
                }
                if (this.ForecastDateTimezone != null)
                {
                    hashCode = (hashCode * 59) + this.ForecastDateTimezone.GetHashCode();
                }
                if (this.OutputUsable != null)
                {
                    hashCode = (hashCode * 59) + this.OutputUsable.GetHashCode();
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
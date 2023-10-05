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
    /// InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow
    /// </summary>
    [DataContract(Name = "Insights.Api.Models.Responses.Transparency.DatasetRows.WeekAheadTotalLoadPerBiddingZoneDatasetRow")]
    public partial class InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow : IEquatable<InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow" /> class.
        /// </summary>
        /// <param name="dataset">dataset.</param>
        /// <param name="documentId">documentId.</param>
        /// <param name="documentRevisionNumber">documentRevisionNumber.</param>
        /// <param name="publishTime">publishTime.</param>
        /// <param name="forecastDate">forecastDate.</param>
        /// <param name="forecastWeek">forecastWeek.</param>
        /// <param name="minimumPossible">minimumPossible.</param>
        /// <param name="maximumAvailable">maximumAvailable.</param>
        public InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow(string dataset = default(string), string documentId = default(string), int documentRevisionNumber = default(int), DateTime publishTime = default(DateTime), DateTime forecastDate = default(DateTime), int forecastWeek = default(int), double minimumPossible = default(double), double maximumAvailable = default(double))
        {
            this.Dataset = dataset;
            this.DocumentId = documentId;
            this.DocumentRevisionNumber = documentRevisionNumber;
            this.PublishTime = publishTime;
            this.ForecastDate = forecastDate;
            this.ForecastWeek = forecastWeek;
            this.MinimumPossible = minimumPossible;
            this.MaximumAvailable = maximumAvailable;
        }

        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        /// <example>WATL</example>
        [DataMember(Name = "dataset", EmitDefaultValue = true)]
        public string Dataset { get; set; }

        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        /// <example>NGET-EMFIP-WATL-16209423</example>
        [DataMember(Name = "documentId", EmitDefaultValue = true)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentRevisionNumber
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "documentRevisionNumber", EmitDefaultValue = false)]
        public int DocumentRevisionNumber { get; set; }

        /// <summary>
        /// Gets or Sets PublishTime
        /// </summary>
        [DataMember(Name = "publishTime", EmitDefaultValue = false)]
        public DateTime PublishTime { get; set; }

        /// <summary>
        /// Gets or Sets ForecastDate
        /// </summary>
        /// <example>Mon Jul 24 02:00:00 CEST 2023</example>
        [DataMember(Name = "forecastDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ForecastDate { get; set; }

        /// <summary>
        /// Gets or Sets ForecastWeek
        /// </summary>
        /// <example>30</example>
        [DataMember(Name = "forecastWeek", EmitDefaultValue = false)]
        public int ForecastWeek { get; set; }

        /// <summary>
        /// Gets or Sets MinimumPossible
        /// </summary>
        /// <example>18034</example>
        [DataMember(Name = "minimumPossible", EmitDefaultValue = false)]
        public double MinimumPossible { get; set; }

        /// <summary>
        /// Gets or Sets MaximumAvailable
        /// </summary>
        /// <example>35011</example>
        [DataMember(Name = "maximumAvailable", EmitDefaultValue = false)]
        public double MaximumAvailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow {\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentRevisionNumber: ").Append(DocumentRevisionNumber).Append("\n");
            sb.Append("  PublishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  ForecastDate: ").Append(ForecastDate).Append("\n");
            sb.Append("  ForecastWeek: ").Append(ForecastWeek).Append("\n");
            sb.Append("  MinimumPossible: ").Append(MinimumPossible).Append("\n");
            sb.Append("  MaximumAvailable: ").Append(MaximumAvailable).Append("\n");
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
            return this.Equals(input as InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow);
        }

        /// <summary>
        /// Returns true if InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow instances are equal
        /// </summary>
        /// <param name="input">Instance of InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsightsApiModelsResponsesTransparencyDatasetRowsWeekAheadTotalLoadPerBiddingZoneDatasetRow input)
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
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.DocumentRevisionNumber == input.DocumentRevisionNumber ||
                    this.DocumentRevisionNumber.Equals(input.DocumentRevisionNumber)
                ) && 
                (
                    this.PublishTime == input.PublishTime ||
                    (this.PublishTime != null &&
                    this.PublishTime.Equals(input.PublishTime))
                ) && 
                (
                    this.ForecastDate == input.ForecastDate ||
                    (this.ForecastDate != null &&
                    this.ForecastDate.Equals(input.ForecastDate))
                ) && 
                (
                    this.ForecastWeek == input.ForecastWeek ||
                    this.ForecastWeek.Equals(input.ForecastWeek)
                ) && 
                (
                    this.MinimumPossible == input.MinimumPossible ||
                    this.MinimumPossible.Equals(input.MinimumPossible)
                ) && 
                (
                    this.MaximumAvailable == input.MaximumAvailable ||
                    this.MaximumAvailable.Equals(input.MaximumAvailable)
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
                if (this.DocumentId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DocumentRevisionNumber.GetHashCode();
                if (this.PublishTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishTime.GetHashCode();
                }
                if (this.ForecastDate != null)
                {
                    hashCode = (hashCode * 59) + this.ForecastDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ForecastWeek.GetHashCode();
                hashCode = (hashCode * 59) + this.MinimumPossible.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumAvailable.GetHashCode();
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

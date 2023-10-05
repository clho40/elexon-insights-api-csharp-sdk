/*
 * Insights.Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing TransparencyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransparencyApiTests : IDisposable
    {
        private TransparencyApi instance;

        public TransparencyApiTests()
        {
            instance = new TransparencyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransparencyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TransparencyApi
            //Assert.IsType<TransparencyApi>(instance);
        }

        /// <summary>
        /// Test DemandTotalActualGet
        /// </summary>
        [Fact]
        public void DemandTotalActualGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //int? settlementPeriodFrom = null;
            //int? settlementPeriodTo = null;
            //string? format = null;
            //var response = instance.DemandTotalActualGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualTotalLoadPerBiddingZone>(response);
        }

        /// <summary>
        /// Test ForecastDemandTotalDayAheadGet
        /// </summary>
        [Fact]
        public void ForecastDemandTotalDayAheadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //int? settlementPeriodFrom = null;
            //int? settlementPeriodTo = null;
            //string? format = null;
            //var response = instance.ForecastDemandTotalDayAheadGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadTotalLoadPerBiddingZone>(response);
        }

        /// <summary>
        /// Test ForecastDemandTotalWeekAheadGet
        /// </summary>
        [Fact]
        public void ForecastDemandTotalWeekAheadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //string? format = null;
            //var response = instance.ForecastDemandTotalWeekAheadGet(from, to, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone>(response);
        }

        /// <summary>
        /// Test ForecastDemandTotalWeekAheadLatestGet
        /// </summary>
        [Fact]
        public void ForecastDemandTotalWeekAheadLatestGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? format = null;
            //var response = instance.ForecastDemandTotalWeekAheadLatestGet(format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone>(response);
        }

        /// <summary>
        /// Test ForecastGenerationDayAheadGet
        /// </summary>
        [Fact]
        public void ForecastGenerationDayAheadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //int? settlementPeriodFrom = null;
            //int? settlementPeriodTo = null;
            //string? format = null;
            //var response = instance.ForecastGenerationDayAheadGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadAggregatedGeneration>(response);
        }

        /// <summary>
        /// Test ForecastGenerationWindAndSolarDayAheadGet
        /// </summary>
        [Fact]
        public void ForecastGenerationWindAndSolarDayAheadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //string processType = null;
            //int? settlementPeriodFrom = null;
            //int? settlementPeriodTo = null;
            //string? format = null;
            //var response = instance.ForecastGenerationWindAndSolarDayAheadGet(from, to, processType, settlementPeriodFrom, settlementPeriodTo, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar>(response);
        }

        /// <summary>
        /// Test GenerationActualPerTypeDayTotalGet
        /// </summary>
        [Fact]
        public void GenerationActualPerTypeDayTotalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? format = null;
            //var response = instance.GenerationActualPerTypeDayTotalGet(format);
            //Assert.IsType<List<InsightsApiModelsResponsesTransparencyAgptSummaryData>>(response);
        }

        /// <summary>
        /// Test GenerationActualPerTypeGet
        /// </summary>
        [Fact]
        public void GenerationActualPerTypeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //int? settlementPeriodFrom = null;
            //int? settlementPeriodTo = null;
            //string? format = null;
            //var response = instance.GenerationActualPerTypeGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod>(response);
        }

        /// <summary>
        /// Test GenerationActualPerTypeWindAndSolarGet
        /// </summary>
        [Fact]
        public void GenerationActualPerTypeWindAndSolarGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //int? settlementPeriodFrom = null;
            //int? settlementPeriodTo = null;
            //string? format = null;
            //var response = instance.GenerationActualPerTypeWindAndSolarGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar>(response);
        }
    }
}

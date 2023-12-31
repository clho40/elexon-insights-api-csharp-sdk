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
    ///  Class for testing GenerationForecastApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GenerationForecastApiTests : IDisposable
    {
        private GenerationForecastApi instance;

        public GenerationForecastApiTests()
        {
            instance = new GenerationForecastApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GenerationForecastApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GenerationForecastApi
            //Assert.IsType<GenerationForecastApi>(instance);
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
    }
}

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
    ///  Class for testing IndicatedForecastApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IndicatedForecastApiTests : IDisposable
    {
        private IndicatedForecastApi instance;

        public IndicatedForecastApiTests()
        {
            instance = new IndicatedForecastApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IndicatedForecastApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IndicatedForecastApi
            //Assert.IsType<IndicatedForecastApi>(instance);
        }

        /// <summary>
        /// Test ForecastIndicatedDayAheadEvolutionGet
        /// </summary>
        [Fact]
        public void ForecastIndicatedDayAheadEvolutionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime settlementDate = null;
            //List<int> settlementPeriod = null;
            //string? boundary = null;
            //string? format = null;
            //var response = instance.ForecastIndicatedDayAheadEvolutionGet(settlementDate, settlementPeriod, boundary, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast>(response);
        }

        /// <summary>
        /// Test ForecastIndicatedDayAheadGet
        /// </summary>
        [Fact]
        public void ForecastIndicatedDayAheadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? boundary = null;
            //string? format = null;
            //var response = instance.ForecastIndicatedDayAheadGet(boundary, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast>(response);
        }

        /// <summary>
        /// Test ForecastIndicatedDayAheadHistoryGet
        /// </summary>
        [Fact]
        public void ForecastIndicatedDayAheadHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime publishTime = null;
            //string? boundary = null;
            //string? format = null;
            //var response = instance.ForecastIndicatedDayAheadHistoryGet(publishTime, boundary, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast>(response);
        }
    }
}

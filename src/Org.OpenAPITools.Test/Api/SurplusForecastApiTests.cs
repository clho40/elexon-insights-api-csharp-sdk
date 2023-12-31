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
    ///  Class for testing SurplusForecastApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SurplusForecastApiTests : IDisposable
    {
        private SurplusForecastApi instance;

        public SurplusForecastApiTests()
        {
            instance = new SurplusForecastApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SurplusForecastApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SurplusForecastApi
            //Assert.IsType<SurplusForecastApi>(instance);
        }

        /// <summary>
        /// Test ForecastSurplusDailyEvolutionGet
        /// </summary>
        [Fact]
        public void ForecastSurplusDailyEvolutionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime forecastDate = null;
            //string? format = null;
            //var response = instance.ForecastSurplusDailyEvolutionGet(forecastDate, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily>(response);
        }

        /// <summary>
        /// Test ForecastSurplusDailyGet
        /// </summary>
        [Fact]
        public void ForecastSurplusDailyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? format = null;
            //var response = instance.ForecastSurplusDailyGet(format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily>(response);
        }

        /// <summary>
        /// Test ForecastSurplusDailyHistoryGet
        /// </summary>
        [Fact]
        public void ForecastSurplusDailyHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime publishTime = null;
            //string? format = null;
            //var response = instance.ForecastSurplusDailyHistoryGet(publishTime, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily>(response);
        }

        /// <summary>
        /// Test ForecastSurplusWeeklyEvolutionGet
        /// </summary>
        [Fact]
        public void ForecastSurplusWeeklyEvolutionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //int week = null;
            //string? range = null;
            //string? format = null;
            //var response = instance.ForecastSurplusWeeklyEvolutionGet(year, week, range, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly>(response);
        }

        /// <summary>
        /// Test ForecastSurplusWeeklyGet
        /// </summary>
        [Fact]
        public void ForecastSurplusWeeklyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? range = null;
            //string? format = null;
            //var response = instance.ForecastSurplusWeeklyGet(range, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly>(response);
        }

        /// <summary>
        /// Test ForecastSurplusWeeklyHistoryGet
        /// </summary>
        [Fact]
        public void ForecastSurplusWeeklyHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime publishTime = null;
            //string? range = null;
            //string? format = null;
            //var response = instance.ForecastSurplusWeeklyHistoryGet(publishTime, range, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly>(response);
        }
    }
}

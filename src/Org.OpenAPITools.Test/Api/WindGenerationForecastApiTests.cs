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
    ///  Class for testing WindGenerationForecastApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WindGenerationForecastApiTests : IDisposable
    {
        private WindGenerationForecastApi instance;

        public WindGenerationForecastApiTests()
        {
            instance = new WindGenerationForecastApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WindGenerationForecastApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WindGenerationForecastApi
            //Assert.IsType<WindGenerationForecastApi>(instance);
        }

        /// <summary>
        /// Test ForecastGenerationWindEarliestGet
        /// </summary>
        [Fact]
        public void ForecastGenerationWindEarliestGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //string? format = null;
            //var response = instance.ForecastGenerationWindEarliestGet(from, to, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast>(response);
        }

        /// <summary>
        /// Test ForecastGenerationWindEarliestStreamGet
        /// </summary>
        [Fact]
        public void ForecastGenerationWindEarliestStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //var response = instance.ForecastGenerationWindEarliestStreamGet(from, to);
            //Assert.IsType<List<InsightsApiModelsServiceWindGenerationForecastRow>>(response);
        }

        /// <summary>
        /// Test ForecastGenerationWindEvolutionGet
        /// </summary>
        [Fact]
        public void ForecastGenerationWindEvolutionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime startTime = null;
            //string? format = null;
            //var response = instance.ForecastGenerationWindEvolutionGet(startTime, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast>(response);
        }

        /// <summary>
        /// Test ForecastGenerationWindGet
        /// </summary>
        [Fact]
        public void ForecastGenerationWindGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? format = null;
            //var response = instance.ForecastGenerationWindGet(format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast>(response);
        }

        /// <summary>
        /// Test ForecastGenerationWindHistoryGet
        /// </summary>
        [Fact]
        public void ForecastGenerationWindHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime publishTime = null;
            //string? format = null;
            //var response = instance.ForecastGenerationWindHistoryGet(publishTime, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast>(response);
        }

        /// <summary>
        /// Test ForecastGenerationWindLatestGet
        /// </summary>
        [Fact]
        public void ForecastGenerationWindLatestGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //string? format = null;
            //var response = instance.ForecastGenerationWindLatestGet(from, to, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast>(response);
        }

        /// <summary>
        /// Test ForecastGenerationWindLatestStreamGet
        /// </summary>
        [Fact]
        public void ForecastGenerationWindLatestStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //var response = instance.ForecastGenerationWindLatestStreamGet(from, to);
            //Assert.IsType<List<InsightsApiModelsServiceWindGenerationForecastRow>>(response);
        }

        /// <summary>
        /// Test ForecastGenerationWindPeakGet
        /// </summary>
        [Fact]
        public void ForecastGenerationWindPeakGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? from = null;
            //DateTime? to = null;
            //string? format = null;
            //var response = instance.ForecastGenerationWindPeakGet(from, to, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast>(response);
        }
    }
}

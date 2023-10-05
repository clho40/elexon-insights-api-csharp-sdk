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
    ///  Class for testing AvailabilityForecastApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AvailabilityForecastApiTests : IDisposable
    {
        private AvailabilityForecastApi instance;

        public AvailabilityForecastApiTests()
        {
            instance = new AvailabilityForecastApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AvailabilityForecastApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AvailabilityForecastApi
            //Assert.IsType<AvailabilityForecastApi>(instance);
        }

        /// <summary>
        /// Test ForecastAvailabilityDailyEvolutionGet
        /// </summary>
        [Fact]
        public void ForecastAvailabilityDailyEvolutionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime forecastDate = null;
            //string? level = null;
            //List<string>? bmUnit = null;
            //List<string>? fuelType = null;
            //string? format = null;
            //var response = instance.ForecastAvailabilityDailyEvolutionGet(forecastDate, level, bmUnit, fuelType, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily>(response);
        }

        /// <summary>
        /// Test ForecastAvailabilityDailyGet
        /// </summary>
        [Fact]
        public void ForecastAvailabilityDailyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? level = null;
            //List<string>? bmUnit = null;
            //List<string>? fuelType = null;
            //string? format = null;
            //var response = instance.ForecastAvailabilityDailyGet(level, bmUnit, fuelType, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily>(response);
        }

        /// <summary>
        /// Test ForecastAvailabilityDailyHistoryGet
        /// </summary>
        [Fact]
        public void ForecastAvailabilityDailyHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime publishTime = null;
            //string? level = null;
            //List<string>? bmUnit = null;
            //List<string>? fuelType = null;
            //string? format = null;
            //var response = instance.ForecastAvailabilityDailyHistoryGet(publishTime, level, bmUnit, fuelType, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily>(response);
        }

        /// <summary>
        /// Test ForecastAvailabilityWeeklyEvolutionGet
        /// </summary>
        [Fact]
        public void ForecastAvailabilityWeeklyEvolutionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //int week = null;
            //string? level = null;
            //List<string>? bmUnit = null;
            //List<string>? fuelType = null;
            //string? format = null;
            //var response = instance.ForecastAvailabilityWeeklyEvolutionGet(year, week, level, bmUnit, fuelType, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly>(response);
        }

        /// <summary>
        /// Test ForecastAvailabilityWeeklyGet
        /// </summary>
        [Fact]
        public void ForecastAvailabilityWeeklyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? level = null;
            //List<string>? bmUnit = null;
            //List<string>? fuelType = null;
            //string? format = null;
            //var response = instance.ForecastAvailabilityWeeklyGet(level, bmUnit, fuelType, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly>(response);
        }

        /// <summary>
        /// Test ForecastAvailabilityWeeklyHistoryGet
        /// </summary>
        [Fact]
        public void ForecastAvailabilityWeeklyHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime publishTime = null;
            //string? level = null;
            //List<string>? bmUnit = null;
            //List<string>? fuelType = null;
            //string? format = null;
            //var response = instance.ForecastAvailabilityWeeklyHistoryGet(publishTime, level, bmUnit, fuelType, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly>(response);
        }
    }
}
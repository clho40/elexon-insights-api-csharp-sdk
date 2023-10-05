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
    ///  Class for testing ActualGenerationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ActualGenerationApiTests : IDisposable
    {
        private ActualGenerationApi instance;

        public ActualGenerationApiTests()
        {
            instance = new ActualGenerationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ActualGenerationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ActualGenerationApi
            //Assert.IsType<ActualGenerationApi>(instance);
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

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
    ///  Class for testing BalancingMechanismDynamicApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BalancingMechanismDynamicApiTests : IDisposable
    {
        private BalancingMechanismDynamicApi instance;

        public BalancingMechanismDynamicApiTests()
        {
            instance = new BalancingMechanismDynamicApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BalancingMechanismDynamicApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BalancingMechanismDynamicApi
            //Assert.IsType<BalancingMechanismDynamicApi>(instance);
        }

        /// <summary>
        /// Test BalancingDynamicAllGet
        /// </summary>
        [Fact]
        public void BalancingDynamicAllGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime settlementDate = null;
            //int? settlementPeriod = null;
            //List<string>? bmUnit = null;
            //List<string>? dataset = null;
            //string? format = null;
            //var response = instance.BalancingDynamicAllGet(settlementDate, settlementPeriod, bmUnit, dataset, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData>(response);
        }

        /// <summary>
        /// Test BalancingDynamicGet
        /// </summary>
        [Fact]
        public void BalancingDynamicGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bmUnit = null;
            //DateTime snapshotAt = null;
            //DateTime? until = null;
            //int? snapshotAtSettlementPeriod = null;
            //int? untilSettlementPeriod = null;
            //List<string>? dataset = null;
            //string? format = null;
            //var response = instance.BalancingDynamicGet(bmUnit, snapshotAt, until, snapshotAtSettlementPeriod, untilSettlementPeriod, dataset, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData>(response);
        }

        /// <summary>
        /// Test BalancingDynamicRatesAllGet
        /// </summary>
        [Fact]
        public void BalancingDynamicRatesAllGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime settlementDate = null;
            //int? settlementPeriod = null;
            //List<string>? bmUnit = null;
            //List<string>? dataset = null;
            //string? format = null;
            //var response = instance.BalancingDynamicRatesAllGet(settlementDate, settlementPeriod, bmUnit, dataset, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData>(response);
        }

        /// <summary>
        /// Test BalancingDynamicRatesGet
        /// </summary>
        [Fact]
        public void BalancingDynamicRatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bmUnit = null;
            //DateTime snapshotAt = null;
            //DateTime? until = null;
            //int? snapshotAtSettlementPeriod = null;
            //int? untilSettlementPeriod = null;
            //List<string>? dataset = null;
            //string? format = null;
            //var response = instance.BalancingDynamicRatesGet(bmUnit, snapshotAt, until, snapshotAtSettlementPeriod, untilSettlementPeriod, dataset, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData>(response);
        }
    }
}

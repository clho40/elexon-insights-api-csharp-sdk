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
    ///  Class for testing BalancingServicesAdjustmentNetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BalancingServicesAdjustmentNetApiTests : IDisposable
    {
        private BalancingServicesAdjustmentNetApi instance;

        public BalancingServicesAdjustmentNetApiTests()
        {
            instance = new BalancingServicesAdjustmentNetApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BalancingServicesAdjustmentNetApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BalancingServicesAdjustmentNetApi
            //Assert.IsType<BalancingServicesAdjustmentNetApi>(instance);
        }

        /// <summary>
        /// Test BalancingNonbmNetbsadEventsGet
        /// </summary>
        [Fact]
        public void BalancingNonbmNetbsadEventsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int count = null;
            //DateTime? before = null;
            //int? settlementPeriodBefore = null;
            //string? format = null;
            //var response = instance.BalancingNonbmNetbsadEventsGet(count, before, settlementPeriodBefore, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse>(response);
        }

        /// <summary>
        /// Test BalancingNonbmNetbsadGet
        /// </summary>
        [Fact]
        public void BalancingNonbmNetbsadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime from = null;
            //DateTime to = null;
            //int? settlementPeriodFrom = null;
            //int? settlementPeriodTo = null;
            //bool? includeZero = null;
            //string? format = null;
            //var response = instance.BalancingNonbmNetbsadGet(from, to, settlementPeriodFrom, settlementPeriodTo, includeZero, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse>(response);
        }
    }
}

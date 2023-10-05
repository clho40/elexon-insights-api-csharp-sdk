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
    ///  Class for testing SAAApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SAAApiTests : IDisposable
    {
        private SAAApi instance;

        public SAAApiTests()
        {
            instance = new SAAApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SAAApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SAAApi
            //Assert.IsType<SAAApi>(instance);
        }

        /// <summary>
        /// Test BalancingSettlementMessagesSettlementDateGet
        /// </summary>
        [Fact]
        public void BalancingSettlementMessagesSettlementDateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime settlementDate = null;
            //string? format = null;
            //var response = instance.BalancingSettlementMessagesSettlementDateGet(settlementDate, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse>(response);
        }

        /// <summary>
        /// Test BalancingSettlementMessagesSettlementDateSettlementPeriodGet
        /// </summary>
        [Fact]
        public void BalancingSettlementMessagesSettlementDateSettlementPeriodGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int settlementPeriod = null;
            //DateTime settlementDate = null;
            //string? format = null;
            //var response = instance.BalancingSettlementMessagesSettlementDateSettlementPeriodGet(settlementPeriod, settlementDate, format);
            //Assert.IsType<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingSettlementSettlementMessageResponse>(response);
        }
    }
}

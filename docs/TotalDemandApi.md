# Org.OpenAPITools.Api.TotalDemandApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DemandTotalActualGet**](TotalDemandApi.md#demandtotalactualget) | **GET** /demand/total/actual | Actual Total Load Per Bidding Zone (ATL / B0610) |

<a id="demandtotalactualget"></a>
# **DemandTotalActualGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualTotalLoadPerBiddingZone DemandTotalActualGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Actual Total Load Per Bidding Zone (ATL / B0610)

This endpoint provides actual total load per bidding zone data.  It can be filtered by settlement period dates.                This API endpoint has a maximum range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandTotalActualGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TotalDemandApi(config);
            var from = 2023-07-18;  // DateTime | 
            var to = 2023-07-21;  // DateTime | 
            var settlementPeriodFrom = 36;  // int? |  (optional) 
            var settlementPeriodTo = 12;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Actual Total Load Per Bidding Zone (ATL / B0610)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualTotalLoadPerBiddingZone result = apiInstance.DemandTotalActualGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TotalDemandApi.DemandTotalActualGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandTotalActualGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Total Load Per Bidding Zone (ATL / B0610)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualTotalLoadPerBiddingZone> response = apiInstance.DemandTotalActualGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TotalDemandApi.DemandTotalActualGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **settlementPeriodFrom** | **int?** |  | [optional]  |
| **settlementPeriodTo** | **int?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualTotalLoadPerBiddingZone**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualTotalLoadPerBiddingZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


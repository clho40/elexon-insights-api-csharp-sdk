# Org.OpenAPITools.Api.BalancingServicesAdjustmentDisaggregatedApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalancingNonbmDisbsadDetailsGet**](BalancingServicesAdjustmentDisaggregatedApi.md#balancingnonbmdisbsaddetailsget) | **GET** /balancing/nonbm/disbsad/details | Disaggregated balancing services adjustment (DISBSAD) per settlement period |
| [**BalancingNonbmDisbsadSummaryGet**](BalancingServicesAdjustmentDisaggregatedApi.md#balancingnonbmdisbsadsummaryget) | **GET** /balancing/nonbm/disbsad/summary | Disaggregated balancing services adjustment (DISBSAD) time series |

<a id="balancingnonbmdisbsaddetailsget"></a>
# **BalancingNonbmDisbsadDetailsGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse BalancingNonbmDisbsadDetailsGet (DateTime settlementDate, int settlementPeriod, string? format = null)

Disaggregated balancing services adjustment (DISBSAD) per settlement period

This endpoint provides disaggregated balancing services adjustment data for a single settlement period. The  response includes all the buying and selling actions that occurred during that settlement period.                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingNonbmDisbsadDetailsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingServicesAdjustmentDisaggregatedApi(config);
            var settlementDate = 2022-10-26;  // DateTime | The settlement date to query.
            var settlementPeriod = 3;  // int | The settlement period to query. This should be an integer from 1-50 inclusive.
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Disaggregated balancing services adjustment (DISBSAD) per settlement period
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse result = apiInstance.BalancingNonbmDisbsadDetailsGet(settlementDate, settlementPeriod, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingServicesAdjustmentDisaggregatedApi.BalancingNonbmDisbsadDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingNonbmDisbsadDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disaggregated balancing services adjustment (DISBSAD) per settlement period
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse> response = apiInstance.BalancingNonbmDisbsadDetailsGetWithHttpInfo(settlementDate, settlementPeriod, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingServicesAdjustmentDisaggregatedApi.BalancingNonbmDisbsadDetailsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDate** | **DateTime** | The settlement date to query. |  |
| **settlementPeriod** | **int** | The settlement period to query. This should be an integer from 1-50 inclusive. |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentDetailsResponse.md)

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

<a id="balancingnonbmdisbsadsummaryget"></a>
# **BalancingNonbmDisbsadSummaryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentSummaryResponse BalancingNonbmDisbsadSummaryGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Disaggregated balancing services adjustment (DISBSAD) time series

This endpoint provides disaggregated balancing services adjustment data batched by settlement period. Each  batch in the time series contains a summary of all records for that settlement period, detailing the number of  buy and sell actions, price information and volume information.    By default, the from and to parameters filter the data by start time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of start time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /balancing/nonbm/disbsad/summary?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /balancing/nonbm/disbsad/summary?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /balancing/nonbm/disbsad/summary?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /balancing/nonbm/disbsad/summary?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingNonbmDisbsadSummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingServicesAdjustmentDisaggregatedApi(config);
            var from = 2022-09-20T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-09-27T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Disaggregated balancing services adjustment (DISBSAD) time series
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentSummaryResponse result = apiInstance.BalancingNonbmDisbsadSummaryGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingServicesAdjustmentDisaggregatedApi.BalancingNonbmDisbsadSummaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingNonbmDisbsadSummaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disaggregated balancing services adjustment (DISBSAD) time series
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentSummaryResponse> response = apiInstance.BalancingNonbmDisbsadSummaryGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingServicesAdjustmentDisaggregatedApi.BalancingNonbmDisbsadSummaryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentSummaryResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDisaggregatedBalancingServicesAdjustmentSummaryResponse.md)

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


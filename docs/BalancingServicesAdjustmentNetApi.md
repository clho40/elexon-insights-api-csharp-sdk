# Org.OpenAPITools.Api.BalancingServicesAdjustmentNetApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalancingNonbmNetbsadEventsGet**](BalancingServicesAdjustmentNetApi.md#balancingnonbmnetbsadeventsget) | **GET** /balancing/nonbm/netbsad/events | Net Balancing Services Adjustment (NETBSAD) events |
| [**BalancingNonbmNetbsadGet**](BalancingServicesAdjustmentNetApi.md#balancingnonbmnetbsadget) | **GET** /balancing/nonbm/netbsad | Net Balancing Services Adjustment (NETBSAD) time series |

<a id="balancingnonbmnetbsadeventsget"></a>
# **BalancingNonbmNetbsadEventsGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse BalancingNonbmNetbsadEventsGet (int count, DateTime? before = null, int? settlementPeriodBefore = null, string? format = null)

Net Balancing Services Adjustment (NETBSAD) events

This endpoint provides data about the start of NGESO Net Balancing Services Adjustment (NETBSAD) events.  An event is a point in time where one of the NETBSAD values has changed from 0 to a value.  Each event details the start time of the event and the NETBSAD values associated with the start of the event.                By default, the before parameter filters the data by start time. If the settlementPeriodBefore parameter is  provided, the before parameter instead filters on settlement date, allowing for searching by start time or  settlement date & settlement period.  Note: When filtering via settlement date, before is treated as a Date only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering latest 3 events:                    /balancing/nonbm/netbsad/events?count=3                Filtering latest 3 events before start time:                    /balancing/nonbm/netbsad/events?before=2022-08-01T00:00Z&count=3                Filtering latest 3 events before settlement date and settlement period:                    /balancing/nonbm/netbsad/events?before=2022-08-01T00:00Z&settlementPeriodBefore=48&count=3

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingNonbmNetbsadEventsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingServicesAdjustmentNetApi(config);
            var count = 3;  // int | The number of events to return.
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | If specified, filters events to those with a start time before or at the date, or a settlement date before the date if  settlementPeriodBefore is also specified.  If omitted, latest events are returned. (optional) 
            var settlementPeriodBefore = 56;  // int? | Filters events to those with a settlement period before or at the value.  Before parameter must be specified if this is specified. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Net Balancing Services Adjustment (NETBSAD) events
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse result = apiInstance.BalancingNonbmNetbsadEventsGet(count, before, settlementPeriodBefore, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingServicesAdjustmentNetApi.BalancingNonbmNetbsadEventsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingNonbmNetbsadEventsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Net Balancing Services Adjustment (NETBSAD) events
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse> response = apiInstance.BalancingNonbmNetbsadEventsGetWithHttpInfo(count, before, settlementPeriodBefore, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingServicesAdjustmentNetApi.BalancingNonbmNetbsadEventsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **count** | **int** | The number of events to return. |  |
| **before** | **DateTime?** | If specified, filters events to those with a start time before or at the date, or a settlement date before the date if  settlementPeriodBefore is also specified.  If omitted, latest events are returned. | [optional]  |
| **settlementPeriodBefore** | **int?** | Filters events to those with a settlement period before or at the value.  Before parameter must be specified if this is specified. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse.md)

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

<a id="balancingnonbmnetbsadget"></a>
# **BalancingNonbmNetbsadGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse BalancingNonbmNetbsadGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, bool? includeZero = null, string? format = null)

Net Balancing Services Adjustment (NETBSAD) time series

This endpoint provides data about the Net Balancing Services Adjustment (NETBSAD). Each  entry in the time series contains the NETBSAD values for that settlement period.                By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /balancing/nonbm/netbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /balancing/nonbm/netbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /balancing/nonbm/netbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /balancing/nonbm/netbsad?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingNonbmNetbsadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingServicesAdjustmentNetApi(config);
            var from = 2022-06-01T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-07-01T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var includeZero = false;  // bool? | Include data points with a generation of zero. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Net Balancing Services Adjustment (NETBSAD) time series
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse result = apiInstance.BalancingNonbmNetbsadGet(from, to, settlementPeriodFrom, settlementPeriodTo, includeZero, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingServicesAdjustmentNetApi.BalancingNonbmNetbsadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingNonbmNetbsadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Net Balancing Services Adjustment (NETBSAD) time series
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse> response = apiInstance.BalancingNonbmNetbsadGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, includeZero, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingServicesAdjustmentNetApi.BalancingNonbmNetbsadGetWithHttpInfo: " + e.Message);
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
| **includeZero** | **bool?** | Include data points with a generation of zero. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingNetBalancingServicesAdjustmentResponse.md)

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


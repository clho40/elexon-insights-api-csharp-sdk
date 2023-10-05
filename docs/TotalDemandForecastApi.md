# Org.OpenAPITools.Api.TotalDemandForecastApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForecastDemandTotalDayAheadGet**](TotalDemandForecastApi.md#forecastdemandtotaldayaheadget) | **GET** /forecast/demand/total/day-ahead | Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620) |
| [**ForecastDemandTotalWeekAheadGet**](TotalDemandForecastApi.md#forecastdemandtotalweekaheadget) | **GET** /forecast/demand/total/week-ahead | Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) filtered by forecast week |
| [**ForecastDemandTotalWeekAheadLatestGet**](TotalDemandForecastApi.md#forecastdemandtotalweekaheadlatestget) | **GET** /forecast/demand/total/week-ahead/latest | Latest Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) |

<a id="forecastdemandtotaldayaheadget"></a>
# **ForecastDemandTotalDayAheadGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadTotalLoadPerBiddingZone ForecastDemandTotalDayAheadGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620)

This endpoint provides day-ahead total load forecast per bidding zone data.  It can be filtered by settlement period dates.                This API endpoint has a maximum range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandTotalDayAheadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TotalDemandForecastApi(config);
            var from = 2023-07-18;  // DateTime | 
            var to = 2023-07-21;  // DateTime | 
            var settlementPeriodFrom = 36;  // int? |  (optional) 
            var settlementPeriodTo = 12;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadTotalLoadPerBiddingZone result = apiInstance.ForecastDemandTotalDayAheadGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TotalDemandForecastApi.ForecastDemandTotalDayAheadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandTotalDayAheadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadTotalLoadPerBiddingZone> response = apiInstance.ForecastDemandTotalDayAheadGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TotalDemandForecastApi.ForecastDemandTotalDayAheadGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadTotalLoadPerBiddingZone**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadTotalLoadPerBiddingZone.md)

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

<a id="forecastdemandtotalweekaheadget"></a>
# **ForecastDemandTotalWeekAheadGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone ForecastDemandTotalWeekAheadGet (DateTime from, DateTime to, string? format = null)

Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) filtered by forecast week

This endpoint returns week-ahead total load forecast per bidding zone data with the minimum possible  and maximum available total loads in MW values, filtered by forecast week.                For a given forecast date, if more than one forecast has been published, only the most recent forecast  is returned.                This API endpoint has a maximum range of 367 days.                Date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandTotalWeekAheadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TotalDemandForecastApi(config);
            var from = 2023-08-21;  // DateTime | The earliest forecast date to include.
            var to = 2023-08-27;  // DateTime | The latest forecast date to include.
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) filtered by forecast week
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone result = apiInstance.ForecastDemandTotalWeekAheadGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TotalDemandForecastApi.ForecastDemandTotalWeekAheadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandTotalWeekAheadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) filtered by forecast week
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone> response = apiInstance.ForecastDemandTotalWeekAheadGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TotalDemandForecastApi.ForecastDemandTotalWeekAheadGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The earliest forecast date to include. |  |
| **to** | **DateTime** | The latest forecast date to include. |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone.md)

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

<a id="forecastdemandtotalweekaheadlatestget"></a>
# **ForecastDemandTotalWeekAheadLatestGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone ForecastDemandTotalWeekAheadLatestGet (string? format = null)

Latest Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630)

This endpoint returns the most recently published WATL / B0630 forecast.                This forecast is the week-ahead total load forecast per bidding zone data,  with minimum possible and maximum available total loads in MW values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandTotalWeekAheadLatestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TotalDemandForecastApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Latest Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone result = apiInstance.ForecastDemandTotalWeekAheadLatestGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TotalDemandForecastApi.ForecastDemandTotalWeekAheadLatestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandTotalWeekAheadLatestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Latest Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone> response = apiInstance.ForecastDemandTotalWeekAheadLatestGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TotalDemandForecastApi.ForecastDemandTotalWeekAheadLatestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone.md)

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


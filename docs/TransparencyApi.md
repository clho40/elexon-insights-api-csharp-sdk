# Org.OpenAPITools.Api.TransparencyApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DemandTotalActualGet**](TransparencyApi.md#demandtotalactualget) | **GET** /demand/total/actual | Actual Total Load Per Bidding Zone (ATL / B0610) |
| [**ForecastDemandTotalDayAheadGet**](TransparencyApi.md#forecastdemandtotaldayaheadget) | **GET** /forecast/demand/total/day-ahead | Day-Ahead Total Load Forecast Per Bidding Zone (DATL / B0620) |
| [**ForecastDemandTotalWeekAheadGet**](TransparencyApi.md#forecastdemandtotalweekaheadget) | **GET** /forecast/demand/total/week-ahead | Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) filtered by forecast week |
| [**ForecastDemandTotalWeekAheadLatestGet**](TransparencyApi.md#forecastdemandtotalweekaheadlatestget) | **GET** /forecast/demand/total/week-ahead/latest | Latest Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630) |
| [**ForecastGenerationDayAheadGet**](TransparencyApi.md#forecastgenerationdayaheadget) | **GET** /forecast/generation/day-ahead | Day-Ahead Aggregated Generation (DAG / B1430) |
| [**ForecastGenerationWindAndSolarDayAheadGet**](TransparencyApi.md#forecastgenerationwindandsolardayaheadget) | **GET** /forecast/generation/wind-and-solar/day-ahead | Day-Ahead Generation forecasts For Wind And Solar (DGWS / B1440) |
| [**GenerationActualPerTypeDayTotalGet**](TransparencyApi.md#generationactualpertypedaytotalget) | **GET** /generation/actual/per-type/day-total | 24-hour Actual Generation Per Type (AGPT / B1620) summary data |
| [**GenerationActualPerTypeGet**](TransparencyApi.md#generationactualpertypeget) | **GET** /generation/actual/per-type | Actual Aggregated Generation Per Type (AGPT / B1620) |
| [**GenerationActualPerTypeWindAndSolarGet**](TransparencyApi.md#generationactualpertypewindandsolarget) | **GET** /generation/actual/per-type/wind-and-solar | Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630) |

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
            var apiInstance = new TransparencyApi(config);
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
                Debug.Print("Exception when calling TransparencyApi.DemandTotalActualGet: " + e.Message);
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
    Debug.Print("Exception when calling TransparencyApi.DemandTotalActualGetWithHttpInfo: " + e.Message);
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
            var apiInstance = new TransparencyApi(config);
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
                Debug.Print("Exception when calling TransparencyApi.ForecastDemandTotalDayAheadGet: " + e.Message);
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
    Debug.Print("Exception when calling TransparencyApi.ForecastDemandTotalDayAheadGetWithHttpInfo: " + e.Message);
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
            var apiInstance = new TransparencyApi(config);
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
                Debug.Print("Exception when calling TransparencyApi.ForecastDemandTotalWeekAheadGet: " + e.Message);
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
    Debug.Print("Exception when calling TransparencyApi.ForecastDemandTotalWeekAheadGetWithHttpInfo: " + e.Message);
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
            var apiInstance = new TransparencyApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Latest Week-Ahead Total Load Forecast Per Bidding Zone (WATL / B0630)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyWeekAheadTotalLoadPerBiddingZone result = apiInstance.ForecastDemandTotalWeekAheadLatestGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransparencyApi.ForecastDemandTotalWeekAheadLatestGet: " + e.Message);
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
    Debug.Print("Exception when calling TransparencyApi.ForecastDemandTotalWeekAheadLatestGetWithHttpInfo: " + e.Message);
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

<a id="forecastgenerationdayaheadget"></a>
# **ForecastGenerationDayAheadGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadAggregatedGeneration ForecastGenerationDayAheadGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Day-Ahead Aggregated Generation (DAG / B1430)

This endpoint provides day-ahead aggregated generation data filtered by settlement date.                This API endpoint has a maximum range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationDayAheadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TransparencyApi(config);
            var from = 2023-07-20;  // DateTime | 
            var to = 2023-07-22;  // DateTime | 
            var settlementPeriodFrom = 13;  // int? |  (optional) 
            var settlementPeriodTo = 19;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day-Ahead Aggregated Generation (DAG / B1430)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadAggregatedGeneration result = apiInstance.ForecastGenerationDayAheadGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransparencyApi.ForecastGenerationDayAheadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationDayAheadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-Ahead Aggregated Generation (DAG / B1430)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadAggregatedGeneration> response = apiInstance.ForecastGenerationDayAheadGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransparencyApi.ForecastGenerationDayAheadGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadAggregatedGeneration**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadAggregatedGeneration.md)

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

<a id="forecastgenerationwindandsolardayaheadget"></a>
# **ForecastGenerationWindAndSolarDayAheadGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar ForecastGenerationWindAndSolarDayAheadGet (DateTime from, DateTime to, string processType, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Day-Ahead Generation forecasts For Wind And Solar (DGWS / B1440)

This endpoint provides day-ahead forecast generation data for wind and solar.                This endpoint filters by startTime and provides a maximum data output range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationWindAndSolarDayAheadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TransparencyApi(config);
            var from = 2023-07-18;  // DateTime | 
            var to = 2023-07-21;  // DateTime | 
            var processType = "all";  // string | 
            var settlementPeriodFrom = 36;  // int? |  (optional) 
            var settlementPeriodTo = 12;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day-Ahead Generation forecasts For Wind And Solar (DGWS / B1440)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar result = apiInstance.ForecastGenerationWindAndSolarDayAheadGet(from, to, processType, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransparencyApi.ForecastGenerationWindAndSolarDayAheadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationWindAndSolarDayAheadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-Ahead Generation forecasts For Wind And Solar (DGWS / B1440)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar> response = apiInstance.ForecastGenerationWindAndSolarDayAheadGetWithHttpInfo(from, to, processType, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransparencyApi.ForecastGenerationWindAndSolarDayAheadGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **processType** | **string** |  |  |
| **settlementPeriodFrom** | **int?** |  | [optional]  |
| **settlementPeriodTo** | **int?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyDayAheadGenerationForWindAndSolar.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generationactualpertypedaytotalget"></a>
# **GenerationActualPerTypeDayTotalGet**
> List&lt;InsightsApiModelsResponsesTransparencyAgptSummaryData&gt; GenerationActualPerTypeDayTotalGet (string? format = null)

24-hour Actual Generation Per Type (AGPT / B1620) summary data

This endpoint provides aggregated AGPT (B1620) data. It returns totals and percentages  for the last half hour and 24 hours for each generation type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationActualPerTypeDayTotalGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TransparencyApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // 24-hour Actual Generation Per Type (AGPT / B1620) summary data
                List<InsightsApiModelsResponsesTransparencyAgptSummaryData> result = apiInstance.GenerationActualPerTypeDayTotalGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransparencyApi.GenerationActualPerTypeDayTotalGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationActualPerTypeDayTotalGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 24-hour Actual Generation Per Type (AGPT / B1620) summary data
    ApiResponse<List<InsightsApiModelsResponsesTransparencyAgptSummaryData>> response = apiInstance.GenerationActualPerTypeDayTotalGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransparencyApi.GenerationActualPerTypeDayTotalGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyAgptSummaryData&gt;**](InsightsApiModelsResponsesTransparencyAgptSummaryData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generationactualpertypeget"></a>
# **GenerationActualPerTypeGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod GenerationActualPerTypeGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Actual Aggregated Generation Per Type (AGPT / B1620)

⚠ This endpoint provides a down-sampled data summary intended for visualisation purposes.  Depending on the quantity of data requested, data returned may be averaged hourly, daily,  weekly or monthly. Quantities are rounded to the nearest MWh.  Use /datasets/AGPT for full access.                This endpoint provides actual aggregated generation data per Power System Resource type   (Fuel Type categories as defined by Commission Regulation (EU) No 543/2013).    This endpoint filters by startTime, and groups results by settlement period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationActualPerTypeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TransparencyApi(config);
            var from = 2023-07-20;  // DateTime | 
            var to = 2023-07-22;  // DateTime | 
            var settlementPeriodFrom = 13;  // int? |  (optional) 
            var settlementPeriodTo = 19;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Actual Aggregated Generation Per Type (AGPT / B1620)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod result = apiInstance.GenerationActualPerTypeGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransparencyApi.GenerationActualPerTypeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationActualPerTypeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Aggregated Generation Per Type (AGPT / B1620)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod> response = apiInstance.GenerationActualPerTypeGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransparencyApi.GenerationActualPerTypeGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generationactualpertypewindandsolarget"></a>
# **GenerationActualPerTypeWindAndSolarGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar GenerationActualPerTypeWindAndSolarGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630)

This endpoint provides actual or estimated wind and solar power generation  per settlement period. It returns generation with Power System Resource type  Solar, Wind Onshore or Wind Offshore (Fuel Type categories as defined by  Commission Regulation (EU) No 543/2013).                This endpoint filters by startTime and provides a maximum data output range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationActualPerTypeWindAndSolarGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TransparencyApi(config);
            var from = 2023-07-18;  // DateTime | 
            var to = 2023-07-21;  // DateTime | 
            var settlementPeriodFrom = 36;  // int? |  (optional) 
            var settlementPeriodTo = 12;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar result = apiInstance.GenerationActualPerTypeWindAndSolarGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransparencyApi.GenerationActualPerTypeWindAndSolarGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationActualPerTypeWindAndSolarGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar> response = apiInstance.GenerationActualPerTypeWindAndSolarGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransparencyApi.GenerationActualPerTypeWindAndSolarGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar.md)

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


# Org.OpenAPITools.Api.GenerationForecastApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForecastGenerationDayAheadGet**](GenerationForecastApi.md#forecastgenerationdayaheadget) | **GET** /forecast/generation/day-ahead | Day-Ahead Aggregated Generation (DAG / B1430) |
| [**ForecastGenerationWindAndSolarDayAheadGet**](GenerationForecastApi.md#forecastgenerationwindandsolardayaheadget) | **GET** /forecast/generation/wind-and-solar/day-ahead | Day-Ahead Generation forecasts For Wind And Solar (DGWS / B1440) |

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
            var apiInstance = new GenerationForecastApi(config);
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
                Debug.Print("Exception when calling GenerationForecastApi.ForecastGenerationDayAheadGet: " + e.Message);
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
    Debug.Print("Exception when calling GenerationForecastApi.ForecastGenerationDayAheadGetWithHttpInfo: " + e.Message);
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
            var apiInstance = new GenerationForecastApi(config);
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
                Debug.Print("Exception when calling GenerationForecastApi.ForecastGenerationWindAndSolarDayAheadGet: " + e.Message);
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
    Debug.Print("Exception when calling GenerationForecastApi.ForecastGenerationWindAndSolarDayAheadGetWithHttpInfo: " + e.Message);
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


# Org.OpenAPITools.Api.IndicatedForecastApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForecastIndicatedDayAheadEvolutionGet**](IndicatedForecastApi.md#forecastindicateddayaheadevolutionget) | **GET** /forecast/indicated/day-ahead/evolution | Evolution Indicated day-ahead forecast |
| [**ForecastIndicatedDayAheadGet**](IndicatedForecastApi.md#forecastindicateddayaheadget) | **GET** /forecast/indicated/day-ahead | Latest indicated day-ahead forecast |
| [**ForecastIndicatedDayAheadHistoryGet**](IndicatedForecastApi.md#forecastindicateddayaheadhistoryget) | **GET** /forecast/indicated/day-ahead/history | Historical indicated day-ahead forecast |

<a id="forecastindicateddayaheadevolutionget"></a>
# **ForecastIndicatedDayAheadEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast ForecastIndicatedDayAheadEvolutionGet (DateTime settlementDate, List<int> settlementPeriod, string? boundary = null, string? format = null)

Evolution Indicated day-ahead forecast

This endpoint provides the forecast indicated day-ahead data over time for the specified settlement date and settlement period.    Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastIndicatedDayAheadEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new IndicatedForecastApi(config);
            var settlementDate = 2022-09-20;  // DateTime | The settlement date for the filter. This must be in the format yyyy-MM-dd.
            var settlementPeriod = new List<int>(); // List<int> | 
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution Indicated day-ahead forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast result = apiInstance.ForecastIndicatedDayAheadEvolutionGet(settlementDate, settlementPeriod, boundary, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndicatedForecastApi.ForecastIndicatedDayAheadEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastIndicatedDayAheadEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution Indicated day-ahead forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast> response = apiInstance.ForecastIndicatedDayAheadEvolutionGetWithHttpInfo(settlementDate, settlementPeriod, boundary, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndicatedForecastApi.ForecastIndicatedDayAheadEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDate** | **DateTime** | The settlement date for the filter. This must be in the format yyyy-MM-dd. |  |
| **settlementPeriod** | [**List&lt;int&gt;**](int.md) |  |  |
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast.md)

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

<a id="forecastindicateddayaheadget"></a>
# **ForecastIndicatedDayAheadGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast ForecastIndicatedDayAheadGet (string? boundary = null, string? format = null)

Latest indicated day-ahead forecast

This endpoint provides the latest forecast indicated day-ahead data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastIndicatedDayAheadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new IndicatedForecastApi(config);
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Latest indicated day-ahead forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast result = apiInstance.ForecastIndicatedDayAheadGet(boundary, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndicatedForecastApi.ForecastIndicatedDayAheadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastIndicatedDayAheadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Latest indicated day-ahead forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast> response = apiInstance.ForecastIndicatedDayAheadGetWithHttpInfo(boundary, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndicatedForecastApi.ForecastIndicatedDayAheadGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast.md)

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

<a id="forecastindicateddayaheadhistoryget"></a>
# **ForecastIndicatedDayAheadHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast ForecastIndicatedDayAheadHistoryGet (DateTime publishTime, string? boundary = null, string? format = null)

Historical indicated day-ahead forecast

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastIndicatedDayAheadHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new IndicatedForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historical indicated day-ahead forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast result = apiInstance.ForecastIndicatedDayAheadHistoryGet(publishTime, boundary, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndicatedForecastApi.ForecastIndicatedDayAheadHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastIndicatedDayAheadHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical indicated day-ahead forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast> response = apiInstance.ForecastIndicatedDayAheadHistoryGetWithHttpInfo(publishTime, boundary, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndicatedForecastApi.ForecastIndicatedDayAheadHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishTime** | **DateTime** |  |  |
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesIndicatedForecastIndicatedForecast.md)

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


# Org.OpenAPITools.Api.SurplusForecastApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForecastSurplusDailyEvolutionGet**](SurplusForecastApi.md#forecastsurplusdailyevolutionget) | **GET** /forecast/surplus/daily/evolution | Evolution Daily Surplus Forecast |
| [**ForecastSurplusDailyGet**](SurplusForecastApi.md#forecastsurplusdailyget) | **GET** /forecast/surplus/daily | Daily Surplus Forecast |
| [**ForecastSurplusDailyHistoryGet**](SurplusForecastApi.md#forecastsurplusdailyhistoryget) | **GET** /forecast/surplus/daily/history | Historical Daily Surplus Forecast |
| [**ForecastSurplusWeeklyEvolutionGet**](SurplusForecastApi.md#forecastsurplusweeklyevolutionget) | **GET** /forecast/surplus/weekly/evolution | Evolution Weekly Surplus Forecast |
| [**ForecastSurplusWeeklyGet**](SurplusForecastApi.md#forecastsurplusweeklyget) | **GET** /forecast/surplus/weekly | Weekly Surplus Forecast |
| [**ForecastSurplusWeeklyHistoryGet**](SurplusForecastApi.md#forecastsurplusweeklyhistoryget) | **GET** /forecast/surplus/weekly/history | Historical Weekly Surplus Forecast |

<a id="forecastsurplusdailyevolutionget"></a>
# **ForecastSurplusDailyEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily ForecastSurplusDailyEvolutionGet (DateTime forecastDate, string? format = null)

Evolution Daily Surplus Forecast

This endpoint provides the daily evolution Generating Plant Operating Surplus covering 2 days ahead to 14 days ahead in MW values.  The Daily API outputs the latest published data for daily surplus forecast for D+2 to D+14.                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastSurplusDailyEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new SurplusForecastApi(config);
            var forecastDate = 2022-09-20;  // DateTime | The forecast date for the filter. This must be in the format yyyy-MM-dd.
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution Daily Surplus Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily result = apiInstance.ForecastSurplusDailyEvolutionGet(forecastDate, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusDailyEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastSurplusDailyEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution Daily Surplus Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily> response = apiInstance.ForecastSurplusDailyEvolutionGetWithHttpInfo(forecastDate, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusDailyEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forecastDate** | **DateTime** | The forecast date for the filter. This must be in the format yyyy-MM-dd. |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily.md)

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

<a id="forecastsurplusdailyget"></a>
# **ForecastSurplusDailyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily ForecastSurplusDailyGet (string? format = null)

Daily Surplus Forecast

This endpoint provides the Generating Plant Operating Surplus covering 2 days ahead to 14 days ahead in MW values.  The Daily API outputs the latest published data for daily surplus forecast for D+2 t D+14

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastSurplusDailyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new SurplusForecastApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Daily Surplus Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily result = apiInstance.ForecastSurplusDailyGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusDailyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastSurplusDailyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Daily Surplus Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily> response = apiInstance.ForecastSurplusDailyGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusDailyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily.md)

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

<a id="forecastsurplusdailyhistoryget"></a>
# **ForecastSurplusDailyHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily ForecastSurplusDailyHistoryGet (DateTime publishTime, string? format = null)

Historical Daily Surplus Forecast

This endpoint provides the historic Generating Plant Operating Surplus covering 2 days ahead to 14 days ahead in MW values.  The historic API outputs the latest published data for historic daily surplus forecast for D+2 to D+14

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastSurplusDailyHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new SurplusForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historical Daily Surplus Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily result = apiInstance.ForecastSurplusDailyHistoryGet(publishTime, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusDailyHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastSurplusDailyHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical Daily Surplus Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily> response = apiInstance.ForecastSurplusDailyHistoryGetWithHttpInfo(publishTime, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusDailyHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishTime** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusDaily.md)

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

<a id="forecastsurplusweeklyevolutionget"></a>
# **ForecastSurplusWeeklyEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly ForecastSurplusWeeklyEvolutionGet (int year, int week, string? range = null, string? format = null)

Evolution Weekly Surplus Forecast

This endpoint provides the evolution Generating Plant Operating Surplus  covering 2 weeks ahead to 156 weeks ahead in MW values.  The weekly API outputs the latest published data for weekly surplus forecast for W+2 to W+156

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastSurplusWeeklyEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new SurplusForecastApi(config);
            var year = 56;  // int | 
            var week = 56;  // int | 
            var range = "52W";  // string? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution Weekly Surplus Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly result = apiInstance.ForecastSurplusWeeklyEvolutionGet(year, week, range, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusWeeklyEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastSurplusWeeklyEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution Weekly Surplus Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly> response = apiInstance.ForecastSurplusWeeklyEvolutionGetWithHttpInfo(year, week, range, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusWeeklyEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** |  |  |
| **week** | **int** |  |  |
| **range** | **string?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly.md)

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

<a id="forecastsurplusweeklyget"></a>
# **ForecastSurplusWeeklyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly ForecastSurplusWeeklyGet (string? range = null, string? format = null)

Weekly Surplus Forecast

This endpoint provides the Generating Plant Operating Surplus covering 2 weeks ahead to 156 weeks ahead in MW values.  The weekly API outputs the latest published data for weekly surplus forecast for W+2 to W+156

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastSurplusWeeklyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new SurplusForecastApi(config);
            var range = "52W";  // string? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Weekly Surplus Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly result = apiInstance.ForecastSurplusWeeklyGet(range, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusWeeklyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastSurplusWeeklyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Weekly Surplus Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly> response = apiInstance.ForecastSurplusWeeklyGetWithHttpInfo(range, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusWeeklyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **range** | **string?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly.md)

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

<a id="forecastsurplusweeklyhistoryget"></a>
# **ForecastSurplusWeeklyHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly ForecastSurplusWeeklyHistoryGet (DateTime publishTime, string? range = null, string? format = null)

Historical Weekly Surplus Forecast

This endpoint provides the historic Generating Plant Operating Surplus covering 2 weeks ahead to 156 weeks ahead in MW values.  The weekly API outputs the latest published data for weekly surplus forecast for W+2 to W+156.  Historical published data of weekly surplus forecasts for a given publish date in the 2-156 week dataset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastSurplusWeeklyHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new SurplusForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var range = "52W";  // string? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historical Weekly Surplus Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly result = apiInstance.ForecastSurplusWeeklyHistoryGet(publishTime, range, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusWeeklyHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastSurplusWeeklyHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical Weekly Surplus Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly> response = apiInstance.ForecastSurplusWeeklyHistoryGetWithHttpInfo(publishTime, range, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurplusForecastApi.ForecastSurplusWeeklyHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishTime** | **DateTime** |  |  |
| **range** | **string?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastSurplusForecastSurplusWeekly.md)

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


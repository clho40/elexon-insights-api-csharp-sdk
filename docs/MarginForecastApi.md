# Org.OpenAPITools.Api.MarginForecastApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForecastMarginDailyEvolutionGet**](MarginForecastApi.md#forecastmargindailyevolutionget) | **GET** /forecast/margin/daily/evolution | Evolution Daily Margin Forecast |
| [**ForecastMarginDailyGet**](MarginForecastApi.md#forecastmargindailyget) | **GET** /forecast/margin/daily | Daily Margin Forecast |
| [**ForecastMarginDailyHistoryGet**](MarginForecastApi.md#forecastmargindailyhistoryget) | **GET** /forecast/margin/daily/history | Historical Daily Margin Forecast |
| [**ForecastMarginWeeklyEvolutionGet**](MarginForecastApi.md#forecastmarginweeklyevolutionget) | **GET** /forecast/margin/weekly/evolution | Evolution Daily Margin Forecast |
| [**ForecastMarginWeeklyGet**](MarginForecastApi.md#forecastmarginweeklyget) | **GET** /forecast/margin/weekly | Weekly Margin Forecast |
| [**ForecastMarginWeeklyHistoryGet**](MarginForecastApi.md#forecastmarginweeklyhistoryget) | **GET** /forecast/margin/weekly/history | Historical Weekly Margin Forecast |

<a id="forecastmargindailyevolutionget"></a>
# **ForecastMarginDailyEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily ForecastMarginDailyEvolutionGet (DateTime forecastDate, string? format = null)

Evolution Daily Margin Forecast

This endpoint provides the daily evolution Generating Plant Operating Margin covering 2 days ahead to 14 days ahead in MW values.  The Daily API outputs the latest published data for daily margin forecast for D+2 to D+14.                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastMarginDailyEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new MarginForecastApi(config);
            var forecastDate = 2022-09-20;  // DateTime | The forecast date for the filter. This must be in the format yyyy-MM-dd.
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution Daily Margin Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily result = apiInstance.ForecastMarginDailyEvolutionGet(forecastDate, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarginForecastApi.ForecastMarginDailyEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastMarginDailyEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution Daily Margin Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily> response = apiInstance.ForecastMarginDailyEvolutionGetWithHttpInfo(forecastDate, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarginForecastApi.ForecastMarginDailyEvolutionGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily.md)

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

<a id="forecastmargindailyget"></a>
# **ForecastMarginDailyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily ForecastMarginDailyGet (string? format = null)

Daily Margin Forecast

This endpoint provides the Generating Plant Operating Margin covering 2 days ahead to 14 days ahead  in MW values. The Daily API outputs the latest published data for daily margin forecast for D+2 t D+14

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastMarginDailyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new MarginForecastApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Daily Margin Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily result = apiInstance.ForecastMarginDailyGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarginForecastApi.ForecastMarginDailyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastMarginDailyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Daily Margin Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily> response = apiInstance.ForecastMarginDailyGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarginForecastApi.ForecastMarginDailyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily.md)

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

<a id="forecastmargindailyhistoryget"></a>
# **ForecastMarginDailyHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily ForecastMarginDailyHistoryGet (DateTime publishTime, string? format = null)

Historical Daily Margin Forecast

This endpoint provides the historic Generating Plant Operating Margin covering 2 days ahead to 14 days ahead in MW values.  The historic API outputs the latest published data for historic daily margin forecast for D+2 to D+14

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastMarginDailyHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new MarginForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historical Daily Margin Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily result = apiInstance.ForecastMarginDailyHistoryGet(publishTime, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarginForecastApi.ForecastMarginDailyHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastMarginDailyHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical Daily Margin Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily> response = apiInstance.ForecastMarginDailyHistoryGetWithHttpInfo(publishTime, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarginForecastApi.ForecastMarginDailyHistoryGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginDaily.md)

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

<a id="forecastmarginweeklyevolutionget"></a>
# **ForecastMarginWeeklyEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly ForecastMarginWeeklyEvolutionGet (int year, int week, string? range = null, string? format = null)

Evolution Daily Margin Forecast

This endpoint provides the daily evolution Generating Plant Operating Margin covering 2 days ahead to 14 days ahead in MW values.  The Daily API outputs the latest published data for daily margin forecast for D+2 t D+14

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastMarginWeeklyEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new MarginForecastApi(config);
            var year = 56;  // int | 
            var week = 56;  // int | 
            var range = "52W";  // string? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution Daily Margin Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly result = apiInstance.ForecastMarginWeeklyEvolutionGet(year, week, range, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarginForecastApi.ForecastMarginWeeklyEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastMarginWeeklyEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution Daily Margin Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly> response = apiInstance.ForecastMarginWeeklyEvolutionGetWithHttpInfo(year, week, range, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarginForecastApi.ForecastMarginWeeklyEvolutionGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly.md)

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

<a id="forecastmarginweeklyget"></a>
# **ForecastMarginWeeklyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly ForecastMarginWeeklyGet (string? range = null, string? format = null)

Weekly Margin Forecast

This endpoint provides the Generating Plant Operating Margin covering 2 weeks ahead to 156 weeks ahead in MW values.  The weekly API outputs the latest published data for weekly margin forecast for W+2 to W+156

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastMarginWeeklyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new MarginForecastApi(config);
            var range = "52W";  // string? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Weekly Margin Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly result = apiInstance.ForecastMarginWeeklyGet(range, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarginForecastApi.ForecastMarginWeeklyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastMarginWeeklyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Weekly Margin Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly> response = apiInstance.ForecastMarginWeeklyGetWithHttpInfo(range, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarginForecastApi.ForecastMarginWeeklyGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly.md)

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

<a id="forecastmarginweeklyhistoryget"></a>
# **ForecastMarginWeeklyHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly ForecastMarginWeeklyHistoryGet (DateTime publishTime, string? range = null, string? format = null)

Historical Weekly Margin Forecast

This endpoint provides the weekly historic  Generating Plant Operating Margin.  This historic API output 2 weeks ahead to 156 weeks ahead in MW values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastMarginWeeklyHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new MarginForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var range = "52W";  // string? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historical Weekly Margin Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly result = apiInstance.ForecastMarginWeeklyHistoryGet(publishTime, range, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarginForecastApi.ForecastMarginWeeklyHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastMarginWeeklyHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical Weekly Margin Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly> response = apiInstance.ForecastMarginWeeklyHistoryGetWithHttpInfo(publishTime, range, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarginForecastApi.ForecastMarginWeeklyHistoryGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesForecastMarginForecastMarginWeekly.md)

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


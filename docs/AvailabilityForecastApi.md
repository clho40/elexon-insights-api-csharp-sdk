# Org.OpenAPITools.Api.AvailabilityForecastApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForecastAvailabilityDailyEvolutionGet**](AvailabilityForecastApi.md#forecastavailabilitydailyevolutionget) | **GET** /forecast/availability/daily/evolution | Evolution Daily Generation Forecast |
| [**ForecastAvailabilityDailyGet**](AvailabilityForecastApi.md#forecastavailabilitydailyget) | **GET** /forecast/availability/daily | Fourteen-day generation forecast |
| [**ForecastAvailabilityDailyHistoryGet**](AvailabilityForecastApi.md#forecastavailabilitydailyhistoryget) | **GET** /forecast/availability/daily/history | Historic Fourteen-day generation forecast |
| [**ForecastAvailabilityWeeklyEvolutionGet**](AvailabilityForecastApi.md#forecastavailabilityweeklyevolutionget) | **GET** /forecast/availability/weekly/evolution | Weekly Generation Forecast |
| [**ForecastAvailabilityWeeklyGet**](AvailabilityForecastApi.md#forecastavailabilityweeklyget) | **GET** /forecast/availability/weekly | Weekly Generation Forecast |
| [**ForecastAvailabilityWeeklyHistoryGet**](AvailabilityForecastApi.md#forecastavailabilityweeklyhistoryget) | **GET** /forecast/availability/weekly/history | Historic Weekly generation forecast |

<a id="forecastavailabilitydailyevolutionget"></a>
# **ForecastAvailabilityDailyEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily ForecastAvailabilityDailyEvolutionGet (DateTime forecastDate, string? level = null, List<string>? bmUnit = null, List<string>? fuelType = null, string? format = null)

Evolution Daily Generation Forecast

This endpoint provides the evolution of all daily generation forecasts over time for a given Forecast Date.                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastAvailabilityDailyEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new AvailabilityForecastApi(config);
            var forecastDate = 2022-09-20;  // DateTime | The forecast date for the filter. This must be in the format yyyy-MM-dd.
            var level = "total";  // string? |  (optional) 
            var bmUnit = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution Daily Generation Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily result = apiInstance.ForecastAvailabilityDailyEvolutionGet(forecastDate, level, bmUnit, fuelType, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityDailyEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastAvailabilityDailyEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution Daily Generation Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily> response = apiInstance.ForecastAvailabilityDailyEvolutionGetWithHttpInfo(forecastDate, level, bmUnit, fuelType, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityDailyEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forecastDate** | **DateTime** | The forecast date for the filter. This must be in the format yyyy-MM-dd. |  |
| **level** | **string?** |  | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily.md)

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

<a id="forecastavailabilitydailyget"></a>
# **ForecastAvailabilityDailyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily ForecastAvailabilityDailyGet (string? level = null, List<string>? bmUnit = null, List<string>? fuelType = null, string? format = null)

Fourteen-day generation forecast

This endpoint provides the latest fourteen-day generation forecast

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastAvailabilityDailyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new AvailabilityForecastApi(config);
            var level = "total";  // string? |  (optional) 
            var bmUnit = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Fourteen-day generation forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily result = apiInstance.ForecastAvailabilityDailyGet(level, bmUnit, fuelType, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityDailyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastAvailabilityDailyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fourteen-day generation forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily> response = apiInstance.ForecastAvailabilityDailyGetWithHttpInfo(level, bmUnit, fuelType, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityDailyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **level** | **string?** |  | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily.md)

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

<a id="forecastavailabilitydailyhistoryget"></a>
# **ForecastAvailabilityDailyHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily ForecastAvailabilityDailyHistoryGet (DateTime publishTime, string? level = null, List<string>? bmUnit = null, List<string>? fuelType = null, string? format = null)

Historic Fourteen-day generation forecast

This endpoint provides the latest fourteen-day generation forecast from a given DateTime

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastAvailabilityDailyHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new AvailabilityForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var level = "total";  // string? |  (optional) 
            var bmUnit = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historic Fourteen-day generation forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily result = apiInstance.ForecastAvailabilityDailyHistoryGet(publishTime, level, bmUnit, fuelType, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityDailyHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastAvailabilityDailyHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historic Fourteen-day generation forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily> response = apiInstance.ForecastAvailabilityDailyHistoryGetWithHttpInfo(publishTime, level, bmUnit, fuelType, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityDailyHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishTime** | **DateTime** |  |  |
| **level** | **string?** |  | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityDaily.md)

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

<a id="forecastavailabilityweeklyevolutionget"></a>
# **ForecastAvailabilityWeeklyEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly ForecastAvailabilityWeeklyEvolutionGet (int year, int week, string? level = null, List<string>? bmUnit = null, List<string>? fuelType = null, string? format = null)

Weekly Generation Forecast

This endpoint provides all weekly generation forecasts over time for a given Year and Week

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastAvailabilityWeeklyEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new AvailabilityForecastApi(config);
            var year = 56;  // int | 
            var week = 56;  // int | 
            var level = "total";  // string? |  (optional) 
            var bmUnit = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Weekly Generation Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly result = apiInstance.ForecastAvailabilityWeeklyEvolutionGet(year, week, level, bmUnit, fuelType, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityWeeklyEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastAvailabilityWeeklyEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Weekly Generation Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly> response = apiInstance.ForecastAvailabilityWeeklyEvolutionGetWithHttpInfo(year, week, level, bmUnit, fuelType, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityWeeklyEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **int** |  |  |
| **week** | **int** |  |  |
| **level** | **string?** |  | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly.md)

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

<a id="forecastavailabilityweeklyget"></a>
# **ForecastAvailabilityWeeklyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly ForecastAvailabilityWeeklyGet (string? level = null, List<string>? bmUnit = null, List<string>? fuelType = null, string? format = null)

Weekly Generation Forecast

This endpoint provides the latest three-year generation forecast

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastAvailabilityWeeklyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new AvailabilityForecastApi(config);
            var level = "total";  // string? |  (optional) 
            var bmUnit = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Weekly Generation Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly result = apiInstance.ForecastAvailabilityWeeklyGet(level, bmUnit, fuelType, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityWeeklyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastAvailabilityWeeklyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Weekly Generation Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly> response = apiInstance.ForecastAvailabilityWeeklyGetWithHttpInfo(level, bmUnit, fuelType, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityWeeklyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **level** | **string?** |  | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly.md)

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

<a id="forecastavailabilityweeklyhistoryget"></a>
# **ForecastAvailabilityWeeklyHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly ForecastAvailabilityWeeklyHistoryGet (DateTime publishTime, string? level = null, List<string>? bmUnit = null, List<string>? fuelType = null, string? format = null)

Historic Weekly generation forecast

This endpoint provides the latest three-year forecast from a given DateTime

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastAvailabilityWeeklyHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new AvailabilityForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var level = "total";  // string? |  (optional) 
            var bmUnit = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historic Weekly generation forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly result = apiInstance.ForecastAvailabilityWeeklyHistoryGet(publishTime, level, bmUnit, fuelType, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityWeeklyHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastAvailabilityWeeklyHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historic Weekly generation forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly> response = apiInstance.ForecastAvailabilityWeeklyHistoryGetWithHttpInfo(publishTime, level, bmUnit, fuelType, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityForecastApi.ForecastAvailabilityWeeklyHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishTime** | **DateTime** |  |  |
| **level** | **string?** |  | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationAvailabilityWeekly.md)

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


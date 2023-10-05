# Org.OpenAPITools.Api.WindGenerationForecastApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForecastGenerationWindEarliestGet**](WindGenerationForecastApi.md#forecastgenerationwindearliestget) | **GET** /forecast/generation/wind/earliest | Earliest wind generation forecast |
| [**ForecastGenerationWindEarliestStreamGet**](WindGenerationForecastApi.md#forecastgenerationwindearlieststreamget) | **GET** /forecast/generation/wind/earliest/stream | Earliest wind generation forecast stream |
| [**ForecastGenerationWindEvolutionGet**](WindGenerationForecastApi.md#forecastgenerationwindevolutionget) | **GET** /forecast/generation/wind/evolution | Evolution wind generation forecast |
| [**ForecastGenerationWindGet**](WindGenerationForecastApi.md#forecastgenerationwindget) | **GET** /forecast/generation/wind | Latest wind generation forecast |
| [**ForecastGenerationWindHistoryGet**](WindGenerationForecastApi.md#forecastgenerationwindhistoryget) | **GET** /forecast/generation/wind/history | Historical wind generation forecast |
| [**ForecastGenerationWindLatestGet**](WindGenerationForecastApi.md#forecastgenerationwindlatestget) | **GET** /forecast/generation/wind/latest | Latest wind generation forecast |
| [**ForecastGenerationWindLatestStreamGet**](WindGenerationForecastApi.md#forecastgenerationwindlateststreamget) | **GET** /forecast/generation/wind/latest/stream | Latest wind generation forecast stream |
| [**ForecastGenerationWindPeakGet**](WindGenerationForecastApi.md#forecastgenerationwindpeakget) | **GET** /forecast/generation/wind/peak | Peak wind generation forecast |

<a id="forecastgenerationwindearliestget"></a>
# **ForecastGenerationWindEarliestGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast ForecastGenerationWindEarliestGet (DateTime from, DateTime to, string? format = null)

Earliest wind generation forecast

This endpoint provides the eariest wind generation forecast data.  This provides wind generation forecast for wind farms which are visible to the ESO and have operational metering.  Updated data is published by NGESO up to 8 times a day at 03:30, 05:30, 08:30, 10:30, 12:30, 16:30, 19:30 and 23:30.  Results are filtered by a range of DateTime parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationWindEarliestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new WindGenerationForecastApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Earliest wind generation forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast result = apiInstance.ForecastGenerationWindEarliestGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindEarliestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationWindEarliestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Earliest wind generation forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast> response = apiInstance.ForecastGenerationWindEarliestGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindEarliestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast.md)

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

<a id="forecastgenerationwindearlieststreamget"></a>
# **ForecastGenerationWindEarliestStreamGet**
> List&lt;InsightsApiModelsServiceWindGenerationForecastRow&gt; ForecastGenerationWindEarliestStreamGet (DateTime from, DateTime to)

Earliest wind generation forecast stream

This endpoint provides the earliest wind generation forecast data.  This provides wind generation forecast for wind farms which are visible to the ESO and have operational metering.  Updated data is published by NGESO up to 8 times a day at 03:30, 05:30, 08:30, 10:30, 12:30, 16:30, 19:30 and 23:30.  Results are filtered by a range of DateTime parameters.  This endpoint has an optimised JSON payload and is aimed at frequent requests for the wind generation forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationWindEarliestStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new WindGenerationForecastApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 

            try
            {
                // Earliest wind generation forecast stream
                List<InsightsApiModelsServiceWindGenerationForecastRow> result = apiInstance.ForecastGenerationWindEarliestStreamGet(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindEarliestStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationWindEarliestStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Earliest wind generation forecast stream
    ApiResponse<List<InsightsApiModelsServiceWindGenerationForecastRow>> response = apiInstance.ForecastGenerationWindEarliestStreamGetWithHttpInfo(from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindEarliestStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsServiceWindGenerationForecastRow&gt;**](InsightsApiModelsServiceWindGenerationForecastRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="forecastgenerationwindevolutionget"></a>
# **ForecastGenerationWindEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast ForecastGenerationWindEvolutionGet (DateTime startTime, string? format = null)

Evolution wind generation forecast

This endpoint provides the evolution wind generation forecast data.  This provides wind generation forecast for wind farms which are visible to the ESO and have operational metering.  Updated data is published by NGESO up to 8 times a day at 03:30, 05:30, 08:30, 10:30, 12:30, 16:30, 19:30 and 23:30.  Results are filtered by a range of DateTime parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationWindEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new WindGenerationForecastApi(config);
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution wind generation forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast result = apiInstance.ForecastGenerationWindEvolutionGet(startTime, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationWindEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution wind generation forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast> response = apiInstance.ForecastGenerationWindEvolutionGetWithHttpInfo(startTime, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTime** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast.md)

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

<a id="forecastgenerationwindget"></a>
# **ForecastGenerationWindGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast ForecastGenerationWindGet (string? format = null)

Latest wind generation forecast

This endpoint provides the latest wind generation forecast data. This provides wind generation forecast for wind farms which are visible to the ESO and have operational metering.  Updated data is published by NGESO up to 8 times a day at 03:30, 05:30, 08:30, 10:30, 12:30, 16:30, 19:30 and 23:30. Results are filtered by a range of DateTime parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationWindGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new WindGenerationForecastApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Latest wind generation forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast result = apiInstance.ForecastGenerationWindGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationWindGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Latest wind generation forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast> response = apiInstance.ForecastGenerationWindGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast.md)

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

<a id="forecastgenerationwindhistoryget"></a>
# **ForecastGenerationWindHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast ForecastGenerationWindHistoryGet (DateTime publishTime, string? format = null)

Historical wind generation forecast

This endpoint provides the historical wind generation forecast data. This provides wind generation forecast for wind farms which are visible to the ESO and have operational metering.  Updated data is published by NGESO up to 8 times a day at 03:30, 05:30, 08:30, 10:30, 12:30, 16:30, 19:30 and 23:30.  Results are filtered by a range of DateTime parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationWindHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new WindGenerationForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historical wind generation forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast result = apiInstance.ForecastGenerationWindHistoryGet(publishTime, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationWindHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical wind generation forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast> response = apiInstance.ForecastGenerationWindHistoryGetWithHttpInfo(publishTime, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindHistoryGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast.md)

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

<a id="forecastgenerationwindlatestget"></a>
# **ForecastGenerationWindLatestGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast ForecastGenerationWindLatestGet (DateTime from, DateTime to, string? format = null)

Latest wind generation forecast

This endpoint provides the latest wind generation forecast data.  This provides wind generation forecast for wind farms which are visible to the ESO and have operational metering.  Updated data is published by NGESO up to 8 times a day at 03:30, 05:30, 08:30, 10:30, 12:30, 16:30, 19:30 and 23:30.  Results are filtered by a range of DateTime parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationWindLatestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new WindGenerationForecastApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Latest wind generation forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast result = apiInstance.ForecastGenerationWindLatestGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindLatestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationWindLatestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Latest wind generation forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast> response = apiInstance.ForecastGenerationWindLatestGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindLatestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast.md)

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

<a id="forecastgenerationwindlateststreamget"></a>
# **ForecastGenerationWindLatestStreamGet**
> List&lt;InsightsApiModelsServiceWindGenerationForecastRow&gt; ForecastGenerationWindLatestStreamGet (DateTime from, DateTime to)

Latest wind generation forecast stream

This endpoint provides the latest wind generation forecast data.  This provides wind generation forecast for wind farms which are visible to the ESO and have operational metering.  Updated data is published by NGESO up to 8 times a day at 03:30, 05:30, 08:30, 10:30, 12:30, 16:30, 19:30 and 23:30.  Results are filtered by a range of DateTime parameters.  This endpoint has an optimised JSON payload and is aimed at frequent requests for the wind generation forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationWindLatestStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new WindGenerationForecastApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 

            try
            {
                // Latest wind generation forecast stream
                List<InsightsApiModelsServiceWindGenerationForecastRow> result = apiInstance.ForecastGenerationWindLatestStreamGet(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindLatestStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationWindLatestStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Latest wind generation forecast stream
    ApiResponse<List<InsightsApiModelsServiceWindGenerationForecastRow>> response = apiInstance.ForecastGenerationWindLatestStreamGetWithHttpInfo(from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindLatestStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |

### Return type

[**List&lt;InsightsApiModelsServiceWindGenerationForecastRow&gt;**](InsightsApiModelsServiceWindGenerationForecastRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="forecastgenerationwindpeakget"></a>
# **ForecastGenerationWindPeakGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast ForecastGenerationWindPeakGet (DateTime? from = null, DateTime? to = null, string? format = null)

Peak wind generation forecast

This endpoint provides the peak wind generation forecast data.  This provides wind generation forecast for wind farms which are visible to the ESO and have operational metering.  Updated data is published by NGESO up to 8 times a day at 03:30, 05:30, 08:30, 10:30, 12:30, 16:30, 19:30 and 23:30.  Results are filtered by a range of DateTime parameters.                Date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastGenerationWindPeakGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new WindGenerationForecastApi(config);
            var from = 2021-10-01;  // DateTime? | The start of the requested date range. (optional) 
            var to = 2021-10-30;  // DateTime? | The end of the requested date range. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Peak wind generation forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast result = apiInstance.ForecastGenerationWindPeakGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindPeakGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastGenerationWindPeakGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Peak wind generation forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast> response = apiInstance.ForecastGenerationWindPeakGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WindGenerationForecastApi.ForecastGenerationWindPeakGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** | The start of the requested date range. | [optional]  |
| **to** | **DateTime?** | The end of the requested date range. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationWindGenerationForecast.md)

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


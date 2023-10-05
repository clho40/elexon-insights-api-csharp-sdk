# Org.OpenAPITools.Api.AvailabilityApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerationAvailabilitySummary14DGet**](AvailabilityApi.md#generationavailabilitysummary14dget) | **GET** /generation/availability/summary/14D | Fourteen-day generation forecast |
| [**GenerationAvailabilitySummary3YWGet**](AvailabilityApi.md#generationavailabilitysummary3ywget) | **GET** /generation/availability/summary/3YW | Three-year generation forecast |

<a id="generationavailabilitysummary14dget"></a>
# **GenerationAvailabilitySummary14DGet**
> List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt; GenerationAvailabilitySummary14DGet (string? format = null)

Fourteen-day generation forecast

This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationAvailabilitySummary14DGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new AvailabilityApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Fourteen-day generation forecast
                List<InsightsApiModelsResponsesGenerationAggregatedForecast> result = apiInstance.GenerationAvailabilitySummary14DGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityApi.GenerationAvailabilitySummary14DGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationAvailabilitySummary14DGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fourteen-day generation forecast
    ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> response = apiInstance.GenerationAvailabilitySummary14DGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityApi.GenerationAvailabilitySummary14DGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;**](InsightsApiModelsResponsesGenerationAggregatedForecast.md)

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

<a id="generationavailabilitysummary3ywget"></a>
# **GenerationAvailabilitySummary3YWGet**
> List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt; GenerationAvailabilitySummary3YWGet (string? format = null)

Three-year generation forecast

This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationAvailabilitySummary3YWGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new AvailabilityApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Three-year generation forecast
                List<InsightsApiModelsResponsesGenerationAggregatedForecast> result = apiInstance.GenerationAvailabilitySummary3YWGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityApi.GenerationAvailabilitySummary3YWGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationAvailabilitySummary3YWGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Three-year generation forecast
    ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> response = apiInstance.GenerationAvailabilitySummary3YWGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityApi.GenerationAvailabilitySummary3YWGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;**](InsightsApiModelsResponsesGenerationAggregatedForecast.md)

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


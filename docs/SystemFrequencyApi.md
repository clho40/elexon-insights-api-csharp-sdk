# Org.OpenAPITools.Api.SystemFrequencyApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SystemFrequencyGet**](SystemFrequencyApi.md#systemfrequencyget) | **GET** /system/frequency | System Frequency |
| [**SystemFrequencyStreamGet**](SystemFrequencyApi.md#systemfrequencystreamget) | **GET** /system/frequency/stream | System Frequency Stream |

<a id="systemfrequencyget"></a>
# **SystemFrequencyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemFrequency SystemFrequencyGet (DateTime? from = null, DateTime? to = null, string? format = null)

System Frequency

This endpoint allows for retrieving a collection of recent system frequency data from National Grid ESO. Results  can be filtered by a range of DateTime parameters. This endpoint is useful for ad-hoc querying frequency data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SystemFrequencyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new SystemFrequencyApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // System Frequency
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemFrequency result = apiInstance.SystemFrequencyGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemFrequencyApi.SystemFrequencyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SystemFrequencyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // System Frequency
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemFrequency> response = apiInstance.SystemFrequencyGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemFrequencyApi.SystemFrequencyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** |  | [optional]  |
| **to** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemFrequency**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemFrequency.md)

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

<a id="systemfrequencystreamget"></a>
# **SystemFrequencyStreamGet**
> List&lt;InsightsApiModelsResponsesMiscSystemFrequency&gt; SystemFrequencyStreamGet (DateTime? from = null, DateTime? to = null)

System Frequency Stream

This endpoint allows for retrieving a stream of recent system frequency data from National Grid ESO. Results can  be filtered by a range of DateTime parameters. This endpoint has an optimised JSON payload and aimed at frequent  request for the frequency data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SystemFrequencyStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new SystemFrequencyApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // System Frequency Stream
                List<InsightsApiModelsResponsesMiscSystemFrequency> result = apiInstance.SystemFrequencyStreamGet(from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemFrequencyApi.SystemFrequencyStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SystemFrequencyStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // System Frequency Stream
    ApiResponse<List<InsightsApiModelsResponsesMiscSystemFrequency>> response = apiInstance.SystemFrequencyStreamGetWithHttpInfo(from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemFrequencyApi.SystemFrequencyStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** |  | [optional]  |
| **to** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesMiscSystemFrequency&gt;**](InsightsApiModelsResponsesMiscSystemFrequency.md)

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


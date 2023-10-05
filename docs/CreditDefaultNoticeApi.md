# Org.OpenAPITools.Api.CreditDefaultNoticeApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CDNGet**](CreditDefaultNoticeApi.md#cdnget) | **GET** /CDN | Credit Default Notice (CDN) |

<a id="cdnget"></a>
# **CDNGet**
> InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingCreditDefaultNoticeResponse CDNGet (string? format = null)

Credit Default Notice (CDN)

This endpoint provides a subset of CDN Index Data received from EC. It returns the defaults that are in force and defaults that have closed within the last 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CDNGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new CreditDefaultNoticeApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Credit Default Notice (CDN)
                InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingCreditDefaultNoticeResponse result = apiInstance.CDNGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditDefaultNoticeApi.CDNGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CDNGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Credit Default Notice (CDN)
    ApiResponse<InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingCreditDefaultNoticeResponse> response = apiInstance.CDNGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditDefaultNoticeApi.CDNGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingCreditDefaultNoticeResponse**](InsightsApiModelsResponsesDatasetResponse1InsightsApiModelsResponsesBalancingCreditDefaultNoticeResponse.md)

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


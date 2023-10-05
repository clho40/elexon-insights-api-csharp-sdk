# Org.OpenAPITools.Api.SystemWarningsApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SystemWarningsGet**](SystemWarningsApi.md#systemwarningsget) | **GET** /system/warnings | System Warnings |

<a id="systemwarningsget"></a>
# **SystemWarningsGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData SystemWarningsGet (string? warningType = null, DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, string? format = null)

System Warnings

This endpoint provides system warnings data. Results can be filtered by warning type and a range of DateTime parameters.  - If no parameters are specified then the latest message is returned  - If just a warning type is specified then the latest message of that type is returned  - If just publish times are specified then all messages within that range are returned

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SystemWarningsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new SystemWarningsApi(config);
            var warningType = IT SYSTEMS OUTAGE;  // string? |  (optional) 
            var publishDateTimeFrom = 2023/06/01 07:00;  // DateTime? |  (optional) 
            var publishDateTimeTo = 2023/06/30 10:00;  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // System Warnings
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData result = apiInstance.SystemWarningsGet(warningType, publishDateTimeFrom, publishDateTimeTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemWarningsApi.SystemWarningsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SystemWarningsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // System Warnings
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData> response = apiInstance.SystemWarningsGetWithHttpInfo(warningType, publishDateTimeFrom, publishDateTimeTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemWarningsApi.SystemWarningsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **warningType** | **string?** |  | [optional]  |
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData.md)

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


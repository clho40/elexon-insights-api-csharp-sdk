# Org.OpenAPITools.Api.DemandControlInstructionsApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SystemDemandControlInstructionsGet**](DemandControlInstructionsApi.md#systemdemandcontrolinstructionsget) | **GET** /system/demand-control-instructions | Demand Control Instruction (DCI) |

<a id="systemdemandcontrolinstructionsget"></a>
# **SystemDemandControlInstructionsGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscDemandControlInstructionData SystemDemandControlInstructionsGet (DateTime? from = null, DateTime? to = null, string? format = null)

Demand Control Instruction (DCI)

This endpoint provides demand control instruction data, filtered by the time range of the instruction.  There is no date range limit on parameters.  If no query parameters are supplied all data is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SystemDemandControlInstructionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandControlInstructionsApi(config);
            var from = 2021-04-30T00:00Z;  // DateTime? |  (optional) 
            var to = 2021-04-30T20:00Z;  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Demand Control Instruction (DCI)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscDemandControlInstructionData result = apiInstance.SystemDemandControlInstructionsGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandControlInstructionsApi.SystemDemandControlInstructionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SystemDemandControlInstructionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Demand Control Instruction (DCI)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscDemandControlInstructionData> response = apiInstance.SystemDemandControlInstructionsGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandControlInstructionsApi.SystemDemandControlInstructionsGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscDemandControlInstructionData**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscDemandControlInstructionData.md)

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


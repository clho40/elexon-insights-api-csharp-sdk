# Org.OpenAPITools.Api.TemperatureApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TemperatureGet**](TemperatureApi.md#temperatureget) | **GET** /temperature | Temperature Data |

<a id="temperatureget"></a>
# **TemperatureGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscTemperatureData TemperatureGet (DateTime? from = null, DateTime? to = null, string? format = null)

Temperature Data

This endpoint provides daily average GB temperature data (in Celsius) as well as reference temperatures (low, normal and high).  This average data is calculated by National Grid ESO from the data retrieved from 6 weather stations around Britain.  NGESO use this data as part of the electricity demand forecasting process.                Date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TemperatureGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new TemperatureApi(config);
            var from = 2022-09-20;  // DateTime? | The from date for the filter. This must be in the format yyyy-MM-dd. (optional) 
            var to = 2022-09-21;  // DateTime? | The to date for the filter. This must be in the format yyyy-MM-dd. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Temperature Data
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscTemperatureData result = apiInstance.TemperatureGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemperatureApi.TemperatureGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemperatureGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Temperature Data
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscTemperatureData> response = apiInstance.TemperatureGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemperatureApi.TemperatureGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** | The from date for the filter. This must be in the format yyyy-MM-dd. | [optional]  |
| **to** | **DateTime?** | The to date for the filter. This must be in the format yyyy-MM-dd. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscTemperatureData**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscTemperatureData.md)

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


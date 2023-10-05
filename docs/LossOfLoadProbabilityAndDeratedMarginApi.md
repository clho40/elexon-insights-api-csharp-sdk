# Org.OpenAPITools.Api.LossOfLoadProbabilityAndDeratedMarginApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LolpdrmForecastEvolutionGet**](LossOfLoadProbabilityAndDeratedMarginApi.md#lolpdrmforecastevolutionget) | **GET** /lolpdrm/forecast/evolution | Loss of Load Probability and De-rated Margin forecasts per settlement period |

<a id="lolpdrmforecastevolutionget"></a>
# **LolpdrmForecastEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscLossOfLoadProbabilityDeratedMarginResponse LolpdrmForecastEvolutionGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Loss of Load Probability and De-rated Margin forecasts per settlement period

This endpoint provides the 1h, 2h, 4h, 8h and 12h+ Loss of Load Probability and De-rated Margin forecasts  for each settlement period over a requested time range.                For each forecast horizon at 1, 2, 4 or 8 hours, the returned value is the forecast received that number of hours  before the start of the settlement period.                For the forecast horizon of 12h, the returned value is the most recent forecast received 12 or more hours  before the start of the settlement period. That is, if the most recent forecast was published today at 00:00,  - for 11:30 today, the 12h forecast is the one published yesterday at 23:30 (12h before)  - for 12:00 today, the 12h forecast is the one published today at 00:00 (12h before)  - for 12:30 today, the 12h forecast is the one published today at 00:00 (the latest published)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LolpdrmForecastEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new LossOfLoadProbabilityAndDeratedMarginApi(config);
            var from = 2023-03-06T07:00Z;  // DateTime | 
            var to = 2023-03-06T12:00Z;  // DateTime | 
            var settlementPeriodFrom = 15;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 25;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Loss of Load Probability and De-rated Margin forecasts per settlement period
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscLossOfLoadProbabilityDeratedMarginResponse result = apiInstance.LolpdrmForecastEvolutionGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LossOfLoadProbabilityAndDeratedMarginApi.LolpdrmForecastEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LolpdrmForecastEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Loss of Load Probability and De-rated Margin forecasts per settlement period
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscLossOfLoadProbabilityDeratedMarginResponse> response = apiInstance.LolpdrmForecastEvolutionGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LossOfLoadProbabilityAndDeratedMarginApi.LolpdrmForecastEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscLossOfLoadProbabilityDeratedMarginResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscLossOfLoadProbabilityDeratedMarginResponse.md)

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


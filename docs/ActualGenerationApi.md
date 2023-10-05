# Org.OpenAPITools.Api.ActualGenerationApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerationActualPerTypeDayTotalGet**](ActualGenerationApi.md#generationactualpertypedaytotalget) | **GET** /generation/actual/per-type/day-total | 24-hour Actual Generation Per Type (AGPT / B1620) summary data |
| [**GenerationActualPerTypeGet**](ActualGenerationApi.md#generationactualpertypeget) | **GET** /generation/actual/per-type | Actual Aggregated Generation Per Type (AGPT / B1620) |
| [**GenerationActualPerTypeWindAndSolarGet**](ActualGenerationApi.md#generationactualpertypewindandsolarget) | **GET** /generation/actual/per-type/wind-and-solar | Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630) |

<a id="generationactualpertypedaytotalget"></a>
# **GenerationActualPerTypeDayTotalGet**
> List&lt;InsightsApiModelsResponsesTransparencyAgptSummaryData&gt; GenerationActualPerTypeDayTotalGet (string? format = null)

24-hour Actual Generation Per Type (AGPT / B1620) summary data

This endpoint provides aggregated AGPT (B1620) data. It returns totals and percentages  for the last half hour and 24 hours for each generation type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationActualPerTypeDayTotalGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new ActualGenerationApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // 24-hour Actual Generation Per Type (AGPT / B1620) summary data
                List<InsightsApiModelsResponsesTransparencyAgptSummaryData> result = apiInstance.GenerationActualPerTypeDayTotalGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActualGenerationApi.GenerationActualPerTypeDayTotalGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationActualPerTypeDayTotalGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 24-hour Actual Generation Per Type (AGPT / B1620) summary data
    ApiResponse<List<InsightsApiModelsResponsesTransparencyAgptSummaryData>> response = apiInstance.GenerationActualPerTypeDayTotalGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActualGenerationApi.GenerationActualPerTypeDayTotalGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyAgptSummaryData&gt;**](InsightsApiModelsResponsesTransparencyAgptSummaryData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json, application/xml, text/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generationactualpertypeget"></a>
# **GenerationActualPerTypeGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod GenerationActualPerTypeGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Actual Aggregated Generation Per Type (AGPT / B1620)

⚠ This endpoint provides a down-sampled data summary intended for visualisation purposes.  Depending on the quantity of data requested, data returned may be averaged hourly, daily,  weekly or monthly. Quantities are rounded to the nearest MWh.  Use /datasets/AGPT for full access.                This endpoint provides actual aggregated generation data per Power System Resource type   (Fuel Type categories as defined by Commission Regulation (EU) No 543/2013).    This endpoint filters by startTime, and groups results by settlement period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationActualPerTypeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new ActualGenerationApi(config);
            var from = 2023-07-20;  // DateTime | 
            var to = 2023-07-22;  // DateTime | 
            var settlementPeriodFrom = 13;  // int? |  (optional) 
            var settlementPeriodTo = 19;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Actual Aggregated Generation Per Type (AGPT / B1620)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod result = apiInstance.GenerationActualPerTypeGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActualGenerationApi.GenerationActualPerTypeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationActualPerTypeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Aggregated Generation Per Type (AGPT / B1620)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod> response = apiInstance.GenerationActualPerTypeGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActualGenerationApi.GenerationActualPerTypeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **settlementPeriodFrom** | **int?** |  | [optional]  |
| **settlementPeriodTo** | **int?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationBySettlementPeriod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generationactualpertypewindandsolarget"></a>
# **GenerationActualPerTypeWindAndSolarGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar GenerationActualPerTypeWindAndSolarGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630)

This endpoint provides actual or estimated wind and solar power generation  per settlement period. It returns generation with Power System Resource type  Solar, Wind Onshore or Wind Offshore (Fuel Type categories as defined by  Commission Regulation (EU) No 543/2013).                This endpoint filters by startTime and provides a maximum data output range of 7 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationActualPerTypeWindAndSolarGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new ActualGenerationApi(config);
            var from = 2023-07-18;  // DateTime | 
            var to = 2023-07-21;  // DateTime | 
            var settlementPeriodFrom = 36;  // int? |  (optional) 
            var settlementPeriodTo = 12;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar result = apiInstance.GenerationActualPerTypeWindAndSolarGet(from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActualGenerationApi.GenerationActualPerTypeWindAndSolarGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationActualPerTypeWindAndSolarGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Actual Or Estimated Wind And Solar Power Generation (AGWS / B1630)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar> response = apiInstance.GenerationActualPerTypeWindAndSolarGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActualGenerationApi.GenerationActualPerTypeWindAndSolarGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **settlementPeriodFrom** | **int?** |  | [optional]  |
| **settlementPeriodTo** | **int?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyActualGenerationWindSolar.md)

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


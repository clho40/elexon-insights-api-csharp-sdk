# Org.OpenAPITools.Api.GenerationOutturnApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerationOutturnFUELINSTHHCURGet**](GenerationOutturnApi.md#generationoutturnfuelinsthhcurget) | **GET** /generation/outturn/FUELINSTHHCUR | Generation by fuel type categories (FUELINSTHHCUR) |
| [**GenerationOutturnHalfHourlyInterconnectorGet**](GenerationOutturnApi.md#generationoutturnhalfhourlyinterconnectorget) | **GET** /generation/outturn/halfHourlyInterconnector | Interconnector Flow |
| [**GenerationOutturnSummaryGet**](GenerationOutturnApi.md#generationoutturnsummaryget) | **GET** /generation/outturn/summary | Outturn Summary |

<a id="generationoutturnfuelinsthhcurget"></a>
# **GenerationOutturnFUELINSTHHCURGet**
> List&lt;InsightsApiModelsResponsesGenerationGenerationByFuelType&gt; GenerationOutturnFUELINSTHHCURGet (List<string>? fuelType = null, string? format = null)

Generation by fuel type categories (FUELINSTHHCUR)

This endpoint provides a snapshot view of the last 24 hours generation by individual fuel type categories including interconnector.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationOutturnFUELINSTHHCURGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new GenerationOutturnApi(config);
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Generation by fuel type categories (FUELINSTHHCUR)
                List<InsightsApiModelsResponsesGenerationGenerationByFuelType> result = apiInstance.GenerationOutturnFUELINSTHHCURGet(fuelType, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenerationOutturnApi.GenerationOutturnFUELINSTHHCURGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationOutturnFUELINSTHHCURGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generation by fuel type categories (FUELINSTHHCUR)
    ApiResponse<List<InsightsApiModelsResponsesGenerationGenerationByFuelType>> response = apiInstance.GenerationOutturnFUELINSTHHCURGetWithHttpInfo(fuelType, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenerationOutturnApi.GenerationOutturnFUELINSTHHCURGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationGenerationByFuelType&gt;**](InsightsApiModelsResponsesGenerationGenerationByFuelType.md)

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

<a id="generationoutturnhalfhourlyinterconnectorget"></a>
# **GenerationOutturnHalfHourlyInterconnectorGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationHalfHourlyInterconnectorOutturn GenerationOutturnHalfHourlyInterconnectorGet (DateTime? publishDateTimeFrom = null, DateTime? publishDateTimeTo = null, DateTime? settlementDateFrom = null, DateTime? settlementDateTo = null, List<int>? settlementPeriod = null, List<string>? interconnectorName = null, string? format = null)

Interconnector Flow

This endpoint provides the interconnector flows report derived from the Generation by Fuel Type (FUELINST)  data and shows both interconnector imports and exports; the data is updated every five minutes.                Settlement date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationOutturnHalfHourlyInterconnectorGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new GenerationOutturnApi(config);
            var publishDateTimeFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var publishDateTimeTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var settlementDateFrom = 2022-09-20;  // DateTime? | The settlement date from filter. This must be in the format yyyy-MM-dd. (optional) 
            var settlementDateTo = 2022-09-21;  // DateTime? | The settlement date to filter. This must be in the format yyyy-MM-dd. (optional) 
            var settlementPeriod = new List<int>?(); // List<int>? |  (optional) 
            var interconnectorName = new List<string>?(); // List<string>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Interconnector Flow
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationHalfHourlyInterconnectorOutturn result = apiInstance.GenerationOutturnHalfHourlyInterconnectorGet(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, interconnectorName, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenerationOutturnApi.GenerationOutturnHalfHourlyInterconnectorGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationOutturnHalfHourlyInterconnectorGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Interconnector Flow
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationHalfHourlyInterconnectorOutturn> response = apiInstance.GenerationOutturnHalfHourlyInterconnectorGetWithHttpInfo(publishDateTimeFrom, publishDateTimeTo, settlementDateFrom, settlementDateTo, settlementPeriod, interconnectorName, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenerationOutturnApi.GenerationOutturnHalfHourlyInterconnectorGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishDateTimeFrom** | **DateTime?** |  | [optional]  |
| **publishDateTimeTo** | **DateTime?** |  | [optional]  |
| **settlementDateFrom** | **DateTime?** | The settlement date from filter. This must be in the format yyyy-MM-dd. | [optional]  |
| **settlementDateTo** | **DateTime?** | The settlement date to filter. This must be in the format yyyy-MM-dd. | [optional]  |
| **settlementPeriod** | [**List&lt;int&gt;?**](int.md) |  | [optional]  |
| **interconnectorName** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationHalfHourlyInterconnectorOutturn**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesGenerationHalfHourlyInterconnectorOutturn.md)

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

<a id="generationoutturnsummaryget"></a>
# **GenerationOutturnSummaryGet**
> List&lt;InsightsApiModelsResponsesGenerationOutturnGenerationBySettlementPeriod&gt; GenerationOutturnSummaryGet (DateTime? startTime = null, DateTime? endTime = null, bool? includeNegativeGeneration = null, string? format = null)

Outturn Summary

⚠ This endpoint provides a down-sampled data summary intended for visualisation purposes.  Use raw dataset endpoints under /datasets for full access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GenerationOutturnSummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new GenerationOutturnApi(config);
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var includeNegativeGeneration = true;  // bool? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Outturn Summary
                List<InsightsApiModelsResponsesGenerationOutturnGenerationBySettlementPeriod> result = apiInstance.GenerationOutturnSummaryGet(startTime, endTime, includeNegativeGeneration, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GenerationOutturnApi.GenerationOutturnSummaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerationOutturnSummaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Outturn Summary
    ApiResponse<List<InsightsApiModelsResponsesGenerationOutturnGenerationBySettlementPeriod>> response = apiInstance.GenerationOutturnSummaryGetWithHttpInfo(startTime, endTime, includeNegativeGeneration, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GenerationOutturnApi.GenerationOutturnSummaryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |
| **includeNegativeGeneration** | **bool?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesGenerationOutturnGenerationBySettlementPeriod&gt;**](InsightsApiModelsResponsesGenerationOutturnGenerationBySettlementPeriod.md)

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


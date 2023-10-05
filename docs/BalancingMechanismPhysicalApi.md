# Org.OpenAPITools.Api.BalancingMechanismPhysicalApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalancingPhysicalAllGet**](BalancingMechanismPhysicalApi.md#balancingphysicalallget) | **GET** /balancing/physical/all | Physical Datasets Market-wide |
| [**BalancingPhysicalGet**](BalancingMechanismPhysicalApi.md#balancingphysicalget) | **GET** /balancing/physical | Physical Datasets Per-BMU |

<a id="balancingphysicalallget"></a>
# **BalancingPhysicalAllGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData BalancingPhysicalAllGet (string dataset, DateTime settlementDate, int? settlementPeriod = null, List<string>? bmUnit = null, string? format = null)

Physical Datasets Market-wide

This endpoint provides the physical data for multiple requested BMUs or all BMUs.  It returns the data valid for a single settlement period.                Only one dataset can be queried at a time: PN, QPN, MILS, or MELS.  The results from each dataset are transformed to a common response model, with fields not present in all 4 datasets dropped.                The settlement period to query can be specified as a date and settlement period, or as a datetime  which will resolve to the settlement period that time falls within.    All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Note: When a settlementPeriod is supplied, the settlementDate parameter is treated as a Date only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.    Some examples of date parameter combinations are shown below.                Filtering by settlement date and period:                    /balancing/physical/all?dataset=PN&settlementDate=2023-01-18&settlementPeriod=3    Filtering by datetime:                    /balancing/physical/all?dataset=PN&settlementDate=2023-01-18T01:00Z

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingPhysicalAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingMechanismPhysicalApi(config);
            var dataset = "PN";  // string | Dataset to query.
            var settlementDate = 2023-01-18;  // DateTime | The settlement date or datetime for the filter.
            var settlementPeriod = 3;  // int? | The settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM Units to query. Elexon or NGC BMU IDs can be used. If omitted, results for all BM units will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Physical Datasets Market-wide
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData result = apiInstance.BalancingPhysicalAllGet(dataset, settlementDate, settlementPeriod, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingMechanismPhysicalApi.BalancingPhysicalAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingPhysicalAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Physical Datasets Market-wide
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData> response = apiInstance.BalancingPhysicalAllGetWithHttpInfo(dataset, settlementDate, settlementPeriod, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingMechanismPhysicalApi.BalancingPhysicalAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataset** | **string** | Dataset to query. |  |
| **settlementDate** | **DateTime** | The settlement date or datetime for the filter. |  |
| **settlementPeriod** | **int?** | The settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM Units to query. Elexon or NGC BMU IDs can be used. If omitted, results for all BM units will be returned. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData.md)

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

<a id="balancingphysicalget"></a>
# **BalancingPhysicalGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData BalancingPhysicalGet (string bmUnit, DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? dataset = null, string? format = null)

Physical Datasets Per-BMU

This endpoint provides the physical data for a requested BMU.  It returns the data valid over a given time range.                By default, all of the relevant datasets are returned: PN, QPN, MILS, & MELS.  The results from each dataset are transformed to a common response model, with fields not present in all 4 datasets dropped.                By default, the from and to parameters filter the data by start time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of start time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /balancing/physical?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /balancing/physical?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /balancing/physical?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /balancing/physical?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingPhysicalGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingMechanismPhysicalApi(config);
            var bmUnit = 2__HFLEX001;  // string | The BM Unit to query.
            var from = 2022-09-22T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-09-23T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var dataset = new List<string>?(); // List<string>? | Datasets to filter. If empty, all datasets will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Physical Datasets Per-BMU
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData result = apiInstance.BalancingPhysicalGet(bmUnit, from, to, settlementPeriodFrom, settlementPeriodTo, dataset, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingMechanismPhysicalApi.BalancingPhysicalGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingPhysicalGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Physical Datasets Per-BMU
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData> response = apiInstance.BalancingPhysicalGetWithHttpInfo(bmUnit, from, to, settlementPeriodFrom, settlementPeriodTo, dataset, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingMechanismPhysicalApi.BalancingPhysicalGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bmUnit** | **string** | The BM Unit to query. |  |
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **dataset** | [**List&lt;string&gt;?**](string.md) | Datasets to filter. If empty, all datasets will be returned. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingPhysicalPhysicalData.md)

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


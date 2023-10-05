# Org.OpenAPITools.Api.BalancingMechanismDynamicApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalancingDynamicAllGet**](BalancingMechanismDynamicApi.md#balancingdynamicallget) | **GET** /balancing/dynamic/all | Dynamic Datasets Market-wide |
| [**BalancingDynamicGet**](BalancingMechanismDynamicApi.md#balancingdynamicget) | **GET** /balancing/dynamic | Dynamic Datasets Per-BMU |
| [**BalancingDynamicRatesAllGet**](BalancingMechanismDynamicApi.md#balancingdynamicratesallget) | **GET** /balancing/dynamic/rates/all | Rate Datasets Market-Wide |
| [**BalancingDynamicRatesGet**](BalancingMechanismDynamicApi.md#balancingdynamicratesget) | **GET** /balancing/dynamic/rates | Rate Datasets Per-BMU |

<a id="balancingdynamicallget"></a>
# **BalancingDynamicAllGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData BalancingDynamicAllGet (DateTime settlementDate, int? settlementPeriod = null, List<string>? bmUnit = null, List<string>? dataset = null, string? format = null)

Dynamic Datasets Market-wide

This endpoint provides the dynamic data for multiple requested BMUs or all BMUs, excluding dynamic rate data.  It returns the data valid for a single settlement period. This includes a snapshot of data valid at the start  of the settlement period, and any changes published during that settlement period.                By default, all of the relevant datasets are returned: SIL, SEL, NDZ, NTB, NTO, MZT, MNZT, MDV & MDP.  The results from each dataset are transformed to a common response model, with the common integer field *Value*  mapped from the fields *Level*, *Period*, *Volume* or *Notice* in the original dataset, as relevant.                The settlement period to query can be specified as a date and settlement period, or as a datetime  which will resolve to the settlement period that time falls within.    All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.    Some examples of date parameter combinations are shown below.                Filtering by datetime:                    /balancing/dynamic/all?settlementDate=2023-01-18T01:00Z                Filtering by settlement date and period:                    /balancing/dynamic/all?settlementDate=2023-01-18&settlementPeriod=3

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingDynamicAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingMechanismDynamicApi(config);
            var settlementDate = 2023-01-18;  // DateTime | The settlement date or datetime to filter.
            var settlementPeriod = 3;  // int? | The settlement period to filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM Units to query. Elexon or NGC BMU IDs can be used. If omitted, results for all BM units will be returned. (optional) 
            var dataset = new List<string>?(); // List<string>? | Datasets to filter. If omitted, all datasets will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Dynamic Datasets Market-wide
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData result = apiInstance.BalancingDynamicAllGet(settlementDate, settlementPeriod, bmUnit, dataset, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingMechanismDynamicApi.BalancingDynamicAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingDynamicAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dynamic Datasets Market-wide
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData> response = apiInstance.BalancingDynamicAllGetWithHttpInfo(settlementDate, settlementPeriod, bmUnit, dataset, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingMechanismDynamicApi.BalancingDynamicAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDate** | **DateTime** | The settlement date or datetime to filter. |  |
| **settlementPeriod** | **int?** | The settlement period to filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM Units to query. Elexon or NGC BMU IDs can be used. If omitted, results for all BM units will be returned. | [optional]  |
| **dataset** | [**List&lt;string&gt;?**](string.md) | Datasets to filter. If omitted, all datasets will be returned. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData.md)

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

<a id="balancingdynamicget"></a>
# **BalancingDynamicGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData BalancingDynamicGet (string bmUnit, DateTime snapshotAt, DateTime? until = null, int? snapshotAtSettlementPeriod = null, int? untilSettlementPeriod = null, List<string>? dataset = null, string? format = null)

Dynamic Datasets Per-BMU

This endpoint provides the dynamic data for a requested BMU, excluding physical rate data.  It returns a \"snapshot\" of data valid at a given time, and optionally a time series of changes over a requested interval.                By default, all of the relevant datasets are returned: SIL, SEL, NDZ, NTB, NTO, MZT, MNZT, MDV, MDP.  The results from each dataset are transformed to a common response model, with the common integer field *Value*  mapped from the fields *Level*, *Period*, *Volume* or *Notice* in the original dataset, as relevant.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingDynamicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingMechanismDynamicApi(config);
            var bmUnit = 2__HFLEX001;  // string | The BM Unit to query.
            var snapshotAt = 2022-08-23T00:00Z;  // DateTime | When to retrieve a snapshot of data at.  That is, the latest datapoint before this time will be returned for each dataset.
            var until = 2022-08-24T00:00Z;  // DateTime? | When to retrieve data until.  Data from the snapshot until this time will be returned. (optional) 
            var snapshotAtSettlementPeriod = 2;  // int? | The settlement period to retrieve a snapshot of data at.  If provided, the time part of SnapshotAt will be ignored. (optional) 
            var untilSettlementPeriod = 2;  // int? | The settlement period to retrieve data until.  If provided, the time part of Until will be ignored. (optional) 
            var dataset = new List<string>?(); // List<string>? | Datasets to filter. If omitted, all datasets will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Dynamic Datasets Per-BMU
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData result = apiInstance.BalancingDynamicGet(bmUnit, snapshotAt, until, snapshotAtSettlementPeriod, untilSettlementPeriod, dataset, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingMechanismDynamicApi.BalancingDynamicGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingDynamicGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dynamic Datasets Per-BMU
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData> response = apiInstance.BalancingDynamicGetWithHttpInfo(bmUnit, snapshotAt, until, snapshotAtSettlementPeriod, untilSettlementPeriod, dataset, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingMechanismDynamicApi.BalancingDynamicGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bmUnit** | **string** | The BM Unit to query. |  |
| **snapshotAt** | **DateTime** | When to retrieve a snapshot of data at.  That is, the latest datapoint before this time will be returned for each dataset. |  |
| **until** | **DateTime?** | When to retrieve data until.  Data from the snapshot until this time will be returned. | [optional]  |
| **snapshotAtSettlementPeriod** | **int?** | The settlement period to retrieve a snapshot of data at.  If provided, the time part of SnapshotAt will be ignored. | [optional]  |
| **untilSettlementPeriod** | **int?** | The settlement period to retrieve data until.  If provided, the time part of Until will be ignored. | [optional]  |
| **dataset** | [**List&lt;string&gt;?**](string.md) | Datasets to filter. If omitted, all datasets will be returned. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicDynamicData.md)

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

<a id="balancingdynamicratesallget"></a>
# **BalancingDynamicRatesAllGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData BalancingDynamicRatesAllGet (DateTime settlementDate, int? settlementPeriod = null, List<string>? bmUnit = null, List<string>? dataset = null, string? format = null)

Rate Datasets Market-Wide

This endpoint provides market-wide physical rate data, for all BMUs or a requested set of multiple BMUs.  It returns the data valid for a given settlement period. This includes a snapshot of data valid at the start  of the settlement period, and any changes published during that settlement period.                The settlement period to query can be specified as a date and settlement period, or as a datetime  which will resolve to the settlement period that time falls within.    By default, all of the relevant datasets are returned: RDRE, RURE, RDRI, RURI.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.    Some examples of date parameter combinations are shown below.                Filtering by datetime:                    /balancing/dynamic/rates/all?settlementDate=2023-01-18T01:00Z                Filtering by settlement date and period:                    /balancing/dynamic/rates/all?settlementDate=2023-01-18&settlementPeriod=3

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingDynamicRatesAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingMechanismDynamicApi(config);
            var settlementDate = 2022-09-01T00:00Z;  // DateTime | The settlement date or datetime to filter.
            var settlementPeriod = 2;  // int? | The settlement period to filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM Units to query. Elexon or NGC BMU IDs can be used. If omitted, results for all BM units will be returned. (optional) 
            var dataset = new List<string>?(); // List<string>? | Datasets to return. If omitted, all datasets will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Rate Datasets Market-Wide
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData result = apiInstance.BalancingDynamicRatesAllGet(settlementDate, settlementPeriod, bmUnit, dataset, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingMechanismDynamicApi.BalancingDynamicRatesAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingDynamicRatesAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rate Datasets Market-Wide
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData> response = apiInstance.BalancingDynamicRatesAllGetWithHttpInfo(settlementDate, settlementPeriod, bmUnit, dataset, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingMechanismDynamicApi.BalancingDynamicRatesAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDate** | **DateTime** | The settlement date or datetime to filter. |  |
| **settlementPeriod** | **int?** | The settlement period to filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM Units to query. Elexon or NGC BMU IDs can be used. If omitted, results for all BM units will be returned. | [optional]  |
| **dataset** | [**List&lt;string&gt;?**](string.md) | Datasets to return. If omitted, all datasets will be returned. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData.md)

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

<a id="balancingdynamicratesget"></a>
# **BalancingDynamicRatesGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData BalancingDynamicRatesGet (string bmUnit, DateTime snapshotAt, DateTime? until = null, int? snapshotAtSettlementPeriod = null, int? untilSettlementPeriod = null, List<string>? dataset = null, string? format = null)

Rate Datasets Per-BMU

This endpoint provides the physical rate data for a requested BMU.  It returns a \"snapshot\" of data valid at a given time, and optionally a time series of changes over a requested interval.                By default, all of the relevant datasets are returned: RDRE, RURE, RDRI, RURI.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingDynamicRatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BalancingMechanismDynamicApi(config);
            var bmUnit = DRAXX-1;  // string | The BM Unit to query.
            var snapshotAt = 2022-09-01T00:00Z;  // DateTime | When to retrieve a snapshot of data at.  That is, the latest datapoint before this time will be returned for each dataset.
            var until = 2022-09-30T00:00Z;  // DateTime? | When to retrieve data until.  Data from the snapshot until this time will be returned. (optional) 
            var snapshotAtSettlementPeriod = 2;  // int? | The settlement period to retrieve a snapshot of data at.  If provided, the time part of SnapshotAt will be ignored. (optional) 
            var untilSettlementPeriod = 2;  // int? | The settlement period to retrieve data until.  If provided, the time part of Until will be ignored. (optional) 
            var dataset = new List<string>?(); // List<string>? | Datasets to filter. If empty, all datasets will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Rate Datasets Per-BMU
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData result = apiInstance.BalancingDynamicRatesGet(bmUnit, snapshotAt, until, snapshotAtSettlementPeriod, untilSettlementPeriod, dataset, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BalancingMechanismDynamicApi.BalancingDynamicRatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingDynamicRatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rate Datasets Per-BMU
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData> response = apiInstance.BalancingDynamicRatesGetWithHttpInfo(bmUnit, snapshotAt, until, snapshotAtSettlementPeriod, untilSettlementPeriod, dataset, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BalancingMechanismDynamicApi.BalancingDynamicRatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bmUnit** | **string** | The BM Unit to query. |  |
| **snapshotAt** | **DateTime** | When to retrieve a snapshot of data at.  That is, the latest datapoint before this time will be returned for each dataset. |  |
| **until** | **DateTime?** | When to retrieve data until.  Data from the snapshot until this time will be returned. | [optional]  |
| **snapshotAtSettlementPeriod** | **int?** | The settlement period to retrieve a snapshot of data at.  If provided, the time part of SnapshotAt will be ignored. | [optional]  |
| **untilSettlementPeriod** | **int?** | The settlement period to retrieve data until.  If provided, the time part of Until will be ignored. | [optional]  |
| **dataset** | [**List&lt;string&gt;?**](string.md) | Datasets to filter. If empty, all datasets will be returned. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingDynamicRateData.md)

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


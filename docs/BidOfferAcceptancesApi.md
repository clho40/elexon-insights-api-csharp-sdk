# Org.OpenAPITools.Api.BidOfferAcceptancesApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalancingAcceptancesAllGet**](BidOfferAcceptancesApi.md#balancingacceptancesallget) | **GET** /balancing/acceptances/all | Bid Offer Acceptances Market-wide |
| [**BalancingAcceptancesGet**](BidOfferAcceptancesApi.md#balancingacceptancesget) | **GET** /balancing/acceptances | Bid Offer Acceptances Per-BMU |

<a id="balancingacceptancesallget"></a>
# **BalancingAcceptancesAllGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse BalancingAcceptancesAllGet (DateTime settlementDate, int? settlementPeriod = null, List<string>? bmUnit = null, string? format = null)

Bid Offer Acceptances Market-wide

This endpoint provides the bid offer acceptance data (BOAL) for multiple requested BMUs or all BMUs.  It returns the data valid for a single settlement period.                The settlement period to query can be specified as a date and settlement period, or as a datetime  which will resolve to the settlement period that time falls within.    All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Note: When a settlementPeriod is supplied, the settlementDate parameter is treated as a Date only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.    Some examples of date parameter combinations are shown below.                Filtering by settlement date and period:                    /balancing/acceptances/all?settlementDate=2023-01-24&settlementPeriod=39                Filtering by datetime:                    /balancing/acceptances/all?settlementDate=2023-01-24T19:00Z

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingAcceptancesAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BidOfferAcceptancesApi(config);
            var settlementDate = 2023-01-24;  // DateTime | The settlement date or datetime for the filter.
            var settlementPeriod = 39;  // int? | The settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM Units to query. Elexon or NGC BMU IDs can be used. If omitted, results for all BM units will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Bid Offer Acceptances Market-wide
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse result = apiInstance.BalancingAcceptancesAllGet(settlementDate, settlementPeriod, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BidOfferAcceptancesApi.BalancingAcceptancesAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingAcceptancesAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bid Offer Acceptances Market-wide
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse> response = apiInstance.BalancingAcceptancesAllGetWithHttpInfo(settlementDate, settlementPeriod, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BidOfferAcceptancesApi.BalancingAcceptancesAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDate** | **DateTime** | The settlement date or datetime for the filter. |  |
| **settlementPeriod** | **int?** | The settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **bmUnit** | [**List&lt;string&gt;?**](string.md) | The BM Units to query. Elexon or NGC BMU IDs can be used. If omitted, results for all BM units will be returned. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse.md)

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

<a id="balancingacceptancesget"></a>
# **BalancingAcceptancesGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse BalancingAcceptancesGet (string bmUnit, DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Bid Offer Acceptances Per-BMU

This endpoint provides the bid offer acceptance data (BOAL) for a requested BMU.                By default, the from and to parameters filter the data by start time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of start time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /balancing/acceptances?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /balancing/acceptances?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /balancing/acceptances?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /balancing/acceptances?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingAcceptancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BidOfferAcceptancesApi(config);
            var bmUnit = T_MILWW-1;  // string | The BM Unit to query.
            var from = 2022-10-03T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-06T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Bid Offer Acceptances Per-BMU
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse result = apiInstance.BalancingAcceptancesGet(bmUnit, from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BidOfferAcceptancesApi.BalancingAcceptancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingAcceptancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bid Offer Acceptances Per-BMU
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse> response = apiInstance.BalancingAcceptancesGetWithHttpInfo(bmUnit, from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BidOfferAcceptancesApi.BalancingAcceptancesGetWithHttpInfo: " + e.Message);
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
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferAcceptancesResponse.md)

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


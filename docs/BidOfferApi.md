# Org.OpenAPITools.Api.BidOfferApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalancingBidOfferAllGet**](BidOfferApi.md#balancingbidofferallget) | **GET** /balancing/bid-offer/all | Bid-Offer Market-Wide Data |
| [**BalancingBidOfferGet**](BidOfferApi.md#balancingbidofferget) | **GET** /balancing/bid-offer | Bid-Offer Data Per-BMU |

<a id="balancingbidofferallget"></a>
# **BalancingBidOfferAllGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse BalancingBidOfferAllGet (DateTime settlementDate, int? settlementPeriod = null, List<string>? bmUnit = null, string? format = null)

Bid-Offer Market-Wide Data

This endpoint provides market-wide Bid-Offer data, for all BMUs or a requested set of multiple BMUs.  It returns the data valid for a given settlement period, excluding any results where LevelFrom and LevelTo are both zero.                The settlement period to query can be specified as a date and settlement period, or as a datetime  which will resolve to the settlement period that time falls within.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Note: When a settlementPeriod is supplied, the settlementDate parameter is treated as a Date only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.    Some examples of date parameter combinations are shown below.                Filtering by settlement date and period:                    /balancing/bid-offer/all?settlementDate=2023-01-18&settlementPeriod=3                Filtering by datetime:                    /balancing/bid-offer/all?settlementDate=2023-01-18T01:00Z

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingBidOfferAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BidOfferApi(config);
            var settlementDate = 2022-09-22;  // DateTime | The settlement date or datetime to filter.
            var settlementPeriod = 1;  // int? | The settlement period to filter. This should be an integer from 1-50 inclusive. (optional) 
            var bmUnit = new List<string>?(); // List<string>? | The BM Units to query. Elexon or NGC BMU IDs can be used. If omitted, results for all BM units will be returned. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Bid-Offer Market-Wide Data
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse result = apiInstance.BalancingBidOfferAllGet(settlementDate, settlementPeriod, bmUnit, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BidOfferApi.BalancingBidOfferAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingBidOfferAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bid-Offer Market-Wide Data
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse> response = apiInstance.BalancingBidOfferAllGetWithHttpInfo(settlementDate, settlementPeriod, bmUnit, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BidOfferApi.BalancingBidOfferAllGetWithHttpInfo: " + e.Message);
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
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse.md)

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

<a id="balancingbidofferget"></a>
# **BalancingBidOfferGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse BalancingBidOfferGet (string bmUnit, DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, string? format = null)

Bid-Offer Data Per-BMU

This endpoint provides the Bid-Offer data for a requested BMU. It returns the data valid over a given time  range, excluding any results where LevelFrom and LevelTo are both zero.                By default, the from and to parameters filter the data inclusively and this endpoint will return any data that  overlaps even at a single instant. If the settlementPeriodFrom or settlementPeriodTo parameters are provided, it  will instead filter to return any data that overlaps with the specified range of settlement periods. It is  possible to search using a combination of time and/or settlement date & settlement period. Note: When  filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For example,  2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering by timeFrom and timeTo:                    /balancing/bid-offer?bmUnit=T_DRAXX-1&from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from timeFrom to settlement date and period:                    /balancing/bid-offer?bmUnit=T_DRAXX-1&from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to TimeTo:                    /balancing/bid-offer?bmUnit=T_DRAXX-1&from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /balancing/bid-offer?bmUnit=T_DRAXX-1&from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingBidOfferGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new BidOfferApi(config);
            var bmUnit = 2__HFLEX001;  // string | The BM Unit to query.
            var from = 2022-09-22T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-09-23T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Bid-Offer Data Per-BMU
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse result = apiInstance.BalancingBidOfferGet(bmUnit, from, to, settlementPeriodFrom, settlementPeriodTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BidOfferApi.BalancingBidOfferGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingBidOfferGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bid-Offer Data Per-BMU
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse> response = apiInstance.BalancingBidOfferGetWithHttpInfo(bmUnit, from, to, settlementPeriodFrom, settlementPeriodTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BidOfferApi.BalancingBidOfferGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingBidOfferResponse.md)

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


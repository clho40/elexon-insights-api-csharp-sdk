# Org.OpenAPITools.Api.MarketIndexApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalancingPricingMarketIndexGet**](MarketIndexApi.md#balancingpricingmarketindexget) | **GET** /balancing/pricing/market-index | Market Index Data (MID) price time series |

<a id="balancingpricingmarketindexget"></a>
# **BalancingPricingMarketIndexGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingMarketIndexResponse BalancingPricingMarketIndexGet (DateTime from, DateTime to, int? settlementPeriodFrom = null, int? settlementPeriodTo = null, List<string>? dataProviders = null, string? format = null)

Market Index Data (MID) price time series

This endpoint provides Market Index Data received from NGESO.                Market Index Data is a key component in the calculation of System Buy Price and System Sell Price for each  Settlement Period. This data is received from each of the appointed Market Index Data Providers (MIDPs) and  reflects the price of wholesale electricity in Great Britain in the short term markets. The Market Index Data  which is received from each MIDP for each Settlement Period consists of a Market Index Volume and  Market Index Price, representing the volume and price of trading for the relevant period in the market operated  by the MIDP. The Market Price (the volume weighed average Market Index Price) is used to derive  the Reverse Price (SBP or SSP).\"                The two data providers available to query are N2EX (\"N2EXMIDP\") and APX (\"APXMIDP\").    By default, the from and to parameters filter the data by time inclusively. If the settlementPeriodFrom or  settlementPeriodTo parameters are provided, the corresponding from or to parameter instead filters on settlement  date, allowing for searching by a combination of time and/or settlement date & settlement period.  Note: When filtering via settlement date, from/to are treated as Dates only, with the time being ignored. For  example, 2022-06-01T00:00Z and 2022-06-01T11:11Z are both treated as the settlement date 2022-06-01.                All Dates and DateTimes should be expressed as defined within  <a href=\"https://datatracker.ietf.org/doc/html/rfc3339#section-5.6\" target=\"_blank\">RFC 3339</a>.                Some examples of date parameter combinations are shown below.                Filtering from start time to start time:                    /balancing/pricing/market-index?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z                Filtering from start time to settlement date and period:                    /balancing/pricing/market-index?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodTo=1                Filtering from settlement date and period to start time:                    /balancing/pricing/market-index?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1                Filtering from settlement date and period to settlement date and period:                    /balancing/pricing/market-index?from=2022-06-01T00:00Z&to=2022-07-01T00:00Z&settlementPeriodFrom=1&settlementPeriodTo=1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalancingPricingMarketIndexGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new MarketIndexApi(config);
            var from = 2022-10-12T00:00Z;  // DateTime | The \"from\" start time or settlement date for the filter.
            var to = 2022-10-13T00:00Z;  // DateTime | The \"to\" start time or settlement date for the filter.
            var settlementPeriodFrom = 56;  // int? | The \"from\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var settlementPeriodTo = 56;  // int? | The \"to\" settlement period for the filter. This should be an integer from 1-50 inclusive. (optional) 
            var dataProviders = new List<string>?(); // List<string>? | The data providers to query. If no data provider is selected both will be displayed. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Market Index Data (MID) price time series
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingMarketIndexResponse result = apiInstance.BalancingPricingMarketIndexGet(from, to, settlementPeriodFrom, settlementPeriodTo, dataProviders, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketIndexApi.BalancingPricingMarketIndexGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalancingPricingMarketIndexGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Market Index Data (MID) price time series
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingMarketIndexResponse> response = apiInstance.BalancingPricingMarketIndexGetWithHttpInfo(from, to, settlementPeriodFrom, settlementPeriodTo, dataProviders, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketIndexApi.BalancingPricingMarketIndexGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** | The \&quot;from\&quot; start time or settlement date for the filter. |  |
| **to** | **DateTime** | The \&quot;to\&quot; start time or settlement date for the filter. |  |
| **settlementPeriodFrom** | **int?** | The \&quot;from\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **settlementPeriodTo** | **int?** | The \&quot;to\&quot; settlement period for the filter. This should be an integer from 1-50 inclusive. | [optional]  |
| **dataProviders** | [**List&lt;string&gt;?**](string.md) | The data providers to query. If no data provider is selected both will be displayed. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingMarketIndexResponse**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesBalancingMarketIndexResponse.md)

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


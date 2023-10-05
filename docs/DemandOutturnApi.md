# Org.OpenAPITools.Api.DemandOutturnApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DemandGet**](DemandOutturnApi.md#demandget) | **GET** /demand | Initial National Demand Outturn |
| [**DemandOutturnDailyGet**](DemandOutturnApi.md#demandoutturndailyget) | **GET** /demand/outturn/daily | Initial National Demand Outturn Daily (INDOD) |
| [**DemandOutturnDailyStreamGet**](DemandOutturnApi.md#demandoutturndailystreamget) | **GET** /demand/outturn/daily/stream | Initial National Demand Outturn Daily (INDOD) stream |
| [**DemandPeakGet**](DemandOutturnApi.md#demandpeakget) | **GET** /demand/peak | Retrieve peak demand data for each day, based on ITSDO data |
| [**DemandPeakIndicativeGet**](DemandOutturnApi.md#demandpeakindicativeget) | **GET** /demand/peak/indicative | Indicative Demand Peaks |
| [**DemandPeakIndicativeOperationalTriadSeasonGet**](DemandOutturnApi.md#demandpeakindicativeoperationaltriadseasonget) | **GET** /demand/peak/indicative/operational/{triadSeason} | Operational Data Demand Peak from a Triad Season |
| [**DemandPeakIndicativeSettlementTriadSeasonGet**](DemandOutturnApi.md#demandpeakindicativesettlementtriadseasonget) | **GET** /demand/peak/indicative/settlement/{triadSeason} | Settlement Data Demand Peak from a Triad Season |
| [**DemandPeakTriadGet**](DemandOutturnApi.md#demandpeaktriadget) | **GET** /demand/peak/triad | Triad Demand Peaks |
| [**DemandRollingSystemDemandGet**](DemandOutturnApi.md#demandrollingsystemdemandget) | **GET** /demand/rollingSystemDemand | Rolling System Demand (ROLSYSDEM) |
| [**DemandStreamGet**](DemandOutturnApi.md#demandstreamget) | **GET** /demand/stream | Initial National Demand Outturn Stream |
| [**DemandSummaryGet**](DemandOutturnApi.md#demandsummaryget) | **GET** /demand/summary | System Demand Summary |

<a id="demandget"></a>
# **DemandGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturn DemandGet (DateTime? settlementDateFrom = null, DateTime? settlementDateTo = null, List<int>? settlementPeriod = null, string? format = null)

Initial National Demand Outturn

This endpoint provides data for Initial National Demand Outturn, which measures the  half-hour average MW demand metered by the Transmission Company based on its operational metering.  The data is updated every 30 minutes and within 15 minutes of the end of the effective Settlement Period. The data is represented with:  - INDO (Initial National Demand Outturn) which takes into account transmission losses but does not include station transformer load, pumped storage demand or interconnector demand.  - ITSDO (Initial Transmission System Demand Outturn) which takes into account transmission losses, station transformer load, pumped storage demand and interconnector demand.                This endpoint is useful for ad-hoc querying of the initial national demand outturn data.                Settlement date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var settlementDateFrom = 2022-09-20;  // DateTime? | The settlement date from for the filter. This must be in the format yyyy-MM-dd. (optional) 
            var settlementDateTo = 2022-09-21;  // DateTime? | The settlement date to for the filter. This must be in the format yyyy-MM-dd. (optional) 
            var settlementPeriod = new List<int>?(); // List<int>? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Initial National Demand Outturn
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturn result = apiInstance.DemandGet(settlementDateFrom, settlementDateTo, settlementPeriod, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initial National Demand Outturn
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturn> response = apiInstance.DemandGetWithHttpInfo(settlementDateFrom, settlementDateTo, settlementPeriod, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDateFrom** | **DateTime?** | The settlement date from for the filter. This must be in the format yyyy-MM-dd. | [optional]  |
| **settlementDateTo** | **DateTime?** | The settlement date to for the filter. This must be in the format yyyy-MM-dd. | [optional]  |
| **settlementPeriod** | [**List&lt;int&gt;?**](int.md) |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturn**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturn.md)

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

<a id="demandoutturndailyget"></a>
# **DemandOutturnDailyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndodRow DemandOutturnDailyGet (DateTime? settlementDateFrom = null, DateTime? settlementDateTo = null, string? format = null)

Initial National Demand Outturn Daily (INDOD)

This endpoint provides initial National Demand outturn daily data. The total daily energy volume is the total  demand volume for the previous day expressed on an Initial National Demand Outturn (INDO) basis, i.e. excluding  station transformer, pumping and interconnector export demand. It is calculated from summing the half hourly  INDO demands (divided by two to convert to MWh).                If no date window is chosen, the search will default to results from the last 31 days.    This API endpoint has a maximum range of 2 years (731 days).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandOutturnDailyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var settlementDateFrom = 2023-08-26;  // DateTime? |  (optional) 
            var settlementDateTo = 2023-08-27;  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Initial National Demand Outturn Daily (INDOD)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndodRow result = apiInstance.DemandOutturnDailyGet(settlementDateFrom, settlementDateTo, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandOutturnDailyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandOutturnDailyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initial National Demand Outturn Daily (INDOD)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndodRow> response = apiInstance.DemandOutturnDailyGetWithHttpInfo(settlementDateFrom, settlementDateTo, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandOutturnDailyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDateFrom** | **DateTime?** |  | [optional]  |
| **settlementDateTo** | **DateTime?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndodRow**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndodRow.md)

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

<a id="demandoutturndailystreamget"></a>
# **DemandOutturnDailyStreamGet**
> List&lt;InsightsApiModelsResponsesDemandOutturnIndodRow&gt; DemandOutturnDailyStreamGet (DateTime? settlementDateFrom = null, DateTime? settlementDateTo = null)

Initial National Demand Outturn Daily (INDOD) stream

This endpoint provides initial National Demand outturn daily data. The total daily energy volume is the total  demand volume for the previous day expressed on an Initial National Demand Outturn (INDO) basis, i.e. excluding  station transformer, pumping and interconnector export demand. It is calculated from summing the half hourly  INDO demands (divided by two to convert to MWh).                If no date window is chosen, the search will default to results from the last 31 days.    This endpoint has an optimised JSON payload and is aimed at frequent requests for the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandOutturnDailyStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var settlementDateFrom = 2023-08-26;  // DateTime? |  (optional) 
            var settlementDateTo = 2023-08-27;  // DateTime? |  (optional) 

            try
            {
                // Initial National Demand Outturn Daily (INDOD) stream
                List<InsightsApiModelsResponsesDemandOutturnIndodRow> result = apiInstance.DemandOutturnDailyStreamGet(settlementDateFrom, settlementDateTo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandOutturnDailyStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandOutturnDailyStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initial National Demand Outturn Daily (INDOD) stream
    ApiResponse<List<InsightsApiModelsResponsesDemandOutturnIndodRow>> response = apiInstance.DemandOutturnDailyStreamGetWithHttpInfo(settlementDateFrom, settlementDateTo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandOutturnDailyStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDateFrom** | **DateTime?** |  | [optional]  |
| **settlementDateTo** | **DateTime?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesDemandOutturnIndodRow&gt;**](InsightsApiModelsResponsesDemandOutturnIndodRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="demandpeakget"></a>
# **DemandPeakGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturnPeak DemandPeakGet (DateTime? from = null, DateTime? to = null, string? format = null)

Retrieve peak demand data for each day, based on ITSDO data

This endpoint allows for retrieving peak ITSDO demand for each day from National Grid ESO.  Results are filtered by a range of Date parameters.  Results default to yesterday's peak if no parameters are supplied.                Date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandPeakGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var from = 2021-10-01;  // DateTime? | The start of the requested date range. (optional) 
            var to = 2021-10-30;  // DateTime? | The end of the requested date range. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Retrieve peak demand data for each day, based on ITSDO data
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturnPeak result = apiInstance.DemandPeakGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandPeakGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandPeakGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve peak demand data for each day, based on ITSDO data
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturnPeak> response = apiInstance.DemandPeakGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandPeakGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime?** | The start of the requested date range. | [optional]  |
| **to** | **DateTime?** | The end of the requested date range. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturnPeak**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnDemandOutturnPeak.md)

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

<a id="demandpeakindicativeget"></a>
# **DemandPeakIndicativeGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak DemandPeakIndicativeGet (string data, int? triadSeasonStartYear = null, DateTime? from = null, DateTime? to = null, string? format = null)

Indicative Demand Peaks

Indicative Demand Peaks using Operational Metering data are daily maxima values determined from  ITSDO and FUELHH data used to determine and visualise Triad.                Indicative Demand Peaks using Settlement Metering data are daily maxima values determined from  metered volume data from the S0142_bpi file. These peaks are not used for Triad visualisation as  they are always calculated based on the latest run type. Triads for settlement data  remain static after the National Grid report posted at the beginning of April after the Triad season has ended.                 If no filters are supplied, results default to the latest or current Triad season.  To specify a custom filter, you can supplier EITHER a Triad season start year, OR a date range, but not both.  If a Triad Season Start year is supplied, data for the Triad season beginning on 1 November  of the specified year will be returned.  If a date range is supplied, data will be returned for settlement dates within the date range inclusively.                Date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandPeakIndicativeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var data = operational;  // string | The type of data. Supports values of 'operational' or 'settlement'.
            var triadSeasonStartYear = 56;  // int? | A year indicating the Triad season starting on 1 November of the given year, e.g. 2021. (optional) 
            var from = 2021-10-01;  // DateTime? | The start of the requested date range. (optional) 
            var to = 2021-10-30;  // DateTime? | The end of the requested date range. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Indicative Demand Peaks
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak result = apiInstance.DemandPeakIndicativeGet(data, triadSeasonStartYear, from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandPeakIndicativeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandPeakIndicativeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Indicative Demand Peaks
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak> response = apiInstance.DemandPeakIndicativeGetWithHttpInfo(data, triadSeasonStartYear, from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandPeakIndicativeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | **string** | The type of data. Supports values of &#39;operational&#39; or &#39;settlement&#39;. |  |
| **triadSeasonStartYear** | **int?** | A year indicating the Triad season starting on 1 November of the given year, e.g. 2021. | [optional]  |
| **from** | **DateTime?** | The start of the requested date range. | [optional]  |
| **to** | **DateTime?** | The end of the requested date range. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak.md)

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

<a id="demandpeakindicativeoperationaltriadseasonget"></a>
# **DemandPeakIndicativeOperationalTriadSeasonGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak DemandPeakIndicativeOperationalTriadSeasonGet (int triadSeason, string? format = null)

Operational Data Demand Peak from a Triad Season

Provides indicative demand peak data for a Triad season ITSDO and FUELHH files over a Triad season. For non-Triad  season dates please use the `peak/indicative` endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandPeakIndicativeOperationalTriadSeasonGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var triadSeason = 2021;  // int | A year indicating the Triad season starting on 1 November of the given year
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Operational Data Demand Peak from a Triad Season
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak result = apiInstance.DemandPeakIndicativeOperationalTriadSeasonGet(triadSeason, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandPeakIndicativeOperationalTriadSeasonGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandPeakIndicativeOperationalTriadSeasonGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Operational Data Demand Peak from a Triad Season
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak> response = apiInstance.DemandPeakIndicativeOperationalTriadSeasonGetWithHttpInfo(triadSeason, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandPeakIndicativeOperationalTriadSeasonGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triadSeason** | **int** | A year indicating the Triad season starting on 1 November of the given year |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak.md)

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

<a id="demandpeakindicativesettlementtriadseasonget"></a>
# **DemandPeakIndicativeSettlementTriadSeasonGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak DemandPeakIndicativeSettlementTriadSeasonGet (int triadSeason, string? format = null)

Settlement Data Demand Peak from a Triad Season

Provides indicative demand peak data for a Triad season from S0142_bpi files that were calculated  during the Triad season. For the data from the latest settlement runs for the Triad season use the  `peak/indicative` endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandPeakIndicativeSettlementTriadSeasonGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var triadSeason = 2021;  // int | A year indicating the Triad season starting on 1 November of the given year
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Settlement Data Demand Peak from a Triad Season
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak result = apiInstance.DemandPeakIndicativeSettlementTriadSeasonGet(triadSeason, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandPeakIndicativeSettlementTriadSeasonGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandPeakIndicativeSettlementTriadSeasonGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Settlement Data Demand Peak from a Triad Season
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak> response = apiInstance.DemandPeakIndicativeSettlementTriadSeasonGetWithHttpInfo(triadSeason, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandPeakIndicativeSettlementTriadSeasonGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **triadSeason** | **int** | A year indicating the Triad season starting on 1 November of the given year |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak.md)

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

<a id="demandpeaktriadget"></a>
# **DemandPeakTriadGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak DemandPeakTriadGet (string data, int? triadSeasonStartYear = null, string? format = null)

Triad Demand Peaks

Operational Triad peaks are calculated from the indicative demand peaks data.    Settlement Triad Peaks are calculated from the latest metered volume data available at the point one month following the Triad season's end.  For any Triad season still in progress, the latest run type data is used.                All Triad peaks are at least 10 days clear of one another.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandPeakTriadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var data = operational;  // string | The type of data. Supports values of 'operational' or 'settlement'.
            var triadSeasonStartYear = 2021;  // int? | A year indicating the Triad season starting on 1 November of the given year. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Triad Demand Peaks
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak result = apiInstance.DemandPeakTriadGet(data, triadSeasonStartYear, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandPeakTriadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandPeakTriadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Triad Demand Peaks
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak> response = apiInstance.DemandPeakTriadGetWithHttpInfo(data, triadSeasonStartYear, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandPeakTriadGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | **string** | The type of data. Supports values of &#39;operational&#39; or &#39;settlement&#39;. |  |
| **triadSeasonStartYear** | **int?** | A year indicating the Triad season starting on 1 November of the given year. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnIndicativeDemandPeak.md)

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

<a id="demandrollingsystemdemandget"></a>
# **DemandRollingSystemDemandGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnRollingSystemDemand DemandRollingSystemDemandGet (DateTime? from = null, DateTime? to = null, string? format = null)

Rolling System Demand (ROLSYSDEM)

This endpoint provides the Rolling System Data and this is derived from the total  of all Fuel Type categories from the Generation by Fuel Type report.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandRollingSystemDemandGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Rolling System Demand (ROLSYSDEM)
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnRollingSystemDemand result = apiInstance.DemandRollingSystemDemandGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandRollingSystemDemandGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandRollingSystemDemandGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rolling System Demand (ROLSYSDEM)
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnRollingSystemDemand> response = apiInstance.DemandRollingSystemDemandGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandRollingSystemDemandGetWithHttpInfo: " + e.Message);
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

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnRollingSystemDemand**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandOutturnRollingSystemDemand.md)

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

<a id="demandstreamget"></a>
# **DemandStreamGet**
> List&lt;InsightsApiModelsResponsesDemandOutturnDemandOutturn&gt; DemandStreamGet (DateTime? settlementDateFrom = null, DateTime? settlementDateTo = null, List<int>? settlementPeriod = null)

Initial National Demand Outturn Stream

This endpoint provides data for Initial National Demand Outturn, which measures the  half-hour average MW demand metered by the Transmission Company based on its operational metering.  The data is updated every 30 minutes and within 15 minutes of the end of the effective Settlement Period. The data is represented with:  - INDO (Initial National Demand Outturn) which takes into account transmission losses but does not include station transformer load, pumped storage demand or interconnector demand.  - ITSDO (Initial Transmission System Demand Outturn) which takes into account transmission losses, station transformer load, pumped storage demand and interconnector demand.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the initial national demand outturn data.                Settlement date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var settlementDateFrom = 2022-09-20;  // DateTime? | The settlement date from for the filter. This must be in the format yyyy-MM-dd. (optional) 
            var settlementDateTo = 2022-09-21;  // DateTime? | The settlement date to for the filter. This must be in the format yyyy-MM-dd. (optional) 
            var settlementPeriod = new List<int>?(); // List<int>? |  (optional) 

            try
            {
                // Initial National Demand Outturn Stream
                List<InsightsApiModelsResponsesDemandOutturnDemandOutturn> result = apiInstance.DemandStreamGet(settlementDateFrom, settlementDateTo, settlementPeriod);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initial National Demand Outturn Stream
    ApiResponse<List<InsightsApiModelsResponsesDemandOutturnDemandOutturn>> response = apiInstance.DemandStreamGetWithHttpInfo(settlementDateFrom, settlementDateTo, settlementPeriod);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDateFrom** | **DateTime?** | The settlement date from for the filter. This must be in the format yyyy-MM-dd. | [optional]  |
| **settlementDateTo** | **DateTime?** | The settlement date to for the filter. This must be in the format yyyy-MM-dd. | [optional]  |
| **settlementPeriod** | [**List&lt;int&gt;?**](int.md) |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesDemandOutturnDemandOutturn&gt;**](InsightsApiModelsResponsesDemandOutturnDemandOutturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="demandsummaryget"></a>
# **DemandSummaryGet**
> List&lt;InsightsApiModelsResponsesDemandOutturnRollingSystemDemand&gt; DemandSummaryGet (DateTime? from = null, DateTime? to = null, string? format = null)

System Demand Summary

⚠ This endpoint provides a down-sampled data summary intended for visualisation purposes.  Use datasets endpoints for full dataset access.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemandSummaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandOutturnApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // System Demand Summary
                List<InsightsApiModelsResponsesDemandOutturnRollingSystemDemand> result = apiInstance.DemandSummaryGet(from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandOutturnApi.DemandSummaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DemandSummaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // System Demand Summary
    ApiResponse<List<InsightsApiModelsResponsesDemandOutturnRollingSystemDemand>> response = apiInstance.DemandSummaryGetWithHttpInfo(from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandOutturnApi.DemandSummaryGetWithHttpInfo: " + e.Message);
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

[**List&lt;InsightsApiModelsResponsesDemandOutturnRollingSystemDemand&gt;**](InsightsApiModelsResponsesDemandOutturnRollingSystemDemand.md)

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


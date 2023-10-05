# Org.OpenAPITools.Api.DemandForecastApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForecastDemandDailyEvolutionGet**](DemandForecastApi.md#forecastdemanddailyevolutionget) | **GET** /forecast/demand/daily/evolution | Evolution Daily Demand Forecast |
| [**ForecastDemandDailyGet**](DemandForecastApi.md#forecastdemanddailyget) | **GET** /forecast/demand/daily | Fourteen day forecast demand |
| [**ForecastDemandDailyHistoryGet**](DemandForecastApi.md#forecastdemanddailyhistoryget) | **GET** /forecast/demand/daily/history | Historical daily forecast demand |
| [**ForecastDemandDayAheadEarliestGet**](DemandForecastApi.md#forecastdemanddayaheadearliestget) | **GET** /forecast/demand/day-ahead/earliest | Earliest published day-ahead demand forecast data for a given settlement period |
| [**ForecastDemandDayAheadEarliestStreamGet**](DemandForecastApi.md#forecastdemanddayaheadearlieststreamget) | **GET** /forecast/demand/day-ahead/earliest/stream | Stream of earliest day-ahead demand forecast data for a given settlement period |
| [**ForecastDemandDayAheadEvolutionGet**](DemandForecastApi.md#forecastdemanddayaheadevolutionget) | **GET** /forecast/demand/day-ahead/evolution | Evolution Day-ahead Demand forecast |
| [**ForecastDemandDayAheadGet**](DemandForecastApi.md#forecastdemanddayaheadget) | **GET** /forecast/demand/day-ahead | Day-ahead demand forecast |
| [**ForecastDemandDayAheadHistoryGet**](DemandForecastApi.md#forecastdemanddayaheadhistoryget) | **GET** /forecast/demand/day-ahead/history | Historical day-ahead forecast demand |
| [**ForecastDemandDayAheadLatestGet**](DemandForecastApi.md#forecastdemanddayaheadlatestget) | **GET** /forecast/demand/day-ahead/latest | Latest published day-ahead demand forecast data for a given settlement period |
| [**ForecastDemandDayAheadLatestStreamGet**](DemandForecastApi.md#forecastdemanddayaheadlateststreamget) | **GET** /forecast/demand/day-ahead/latest/stream | Stream of latest published day-ahead demand forecast data for a given settlement period |
| [**ForecastDemandDayAheadPeakGet**](DemandForecastApi.md#forecastdemanddayaheadpeakget) | **GET** /forecast/demand/day-ahead/peak | Retrieve peak demand data for each day, based on Day Ahead forecast data |
| [**ForecastDemandWeeklyEvolutionGet**](DemandForecastApi.md#forecastdemandweeklyevolutionget) | **GET** /forecast/demand/weekly/evolution | Evolution Weekly Demand Forecast |
| [**ForecastDemandWeeklyGet**](DemandForecastApi.md#forecastdemandweeklyget) | **GET** /forecast/demand/weekly | Weekly forecast demand |
| [**ForecastDemandWeeklyHistoryGet**](DemandForecastApi.md#forecastdemandweeklyhistoryget) | **GET** /forecast/demand/weekly/history | Historical weekly forecast demand |

<a id="forecastdemanddailyevolutionget"></a>
# **ForecastDemandDailyEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily ForecastDemandDailyEvolutionGet (DateTime forecastDate, string? format = null)

Evolution Daily Demand Forecast

This endpoint provides the evolution of all daily demand forecasts over time for a given forecast date.                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDailyEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var forecastDate = 2022-09-20;  // DateTime | The forecast date for the filter. This must be in the format yyyy-MM-dd.
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution Daily Demand Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily result = apiInstance.ForecastDemandDailyEvolutionGet(forecastDate, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDailyEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDailyEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution Daily Demand Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily> response = apiInstance.ForecastDemandDailyEvolutionGetWithHttpInfo(forecastDate, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDailyEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forecastDate** | **DateTime** | The forecast date for the filter. This must be in the format yyyy-MM-dd. |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily.md)

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

<a id="forecastdemanddailyget"></a>
# **ForecastDemandDailyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily ForecastDemandDailyGet (string? format = null)

Fourteen day forecast demand

Retrieve latest 14-day forecast demand data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDailyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Fourteen day forecast demand
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily result = apiInstance.ForecastDemandDailyGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDailyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDailyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fourteen day forecast demand
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily> response = apiInstance.ForecastDemandDailyGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDailyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily.md)

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

<a id="forecastdemanddailyhistoryget"></a>
# **ForecastDemandDailyHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily ForecastDemandDailyHistoryGet (DateTime publishTime, string? format = null)

Historical daily forecast demand

Retrieve historical daily forecast demand data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDailyHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historical daily forecast demand
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily result = apiInstance.ForecastDemandDailyHistoryGet(publishTime, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDailyHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDailyHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical daily forecast demand
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily> response = apiInstance.ForecastDemandDailyHistoryGetWithHttpInfo(publishTime, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDailyHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishTime** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDaily.md)

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

<a id="forecastdemanddayaheadearliestget"></a>
# **ForecastDemandDayAheadEarliestGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead ForecastDemandDayAheadEarliestGet (DateTime from, DateTime to, string? boundary = null, string? format = null)

Earliest published day-ahead demand forecast data for a given settlement period

This endpoint allows for retrieving earliest day-ahead demand forecast data from National Grid ESO.  Results are filtered by settlement time, and only the earliest published forecast for each settlement period is shown.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDayAheadEarliestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Earliest published day-ahead demand forecast data for a given settlement period
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead result = apiInstance.ForecastDemandDayAheadEarliestGet(from, to, boundary, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadEarliestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDayAheadEarliestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Earliest published day-ahead demand forecast data for a given settlement period
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead> response = apiInstance.ForecastDemandDayAheadEarliestGetWithHttpInfo(from, to, boundary, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadEarliestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead.md)

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

<a id="forecastdemanddayaheadearlieststreamget"></a>
# **ForecastDemandDayAheadEarliestStreamGet**
> List&lt;InsightsApiModelsServiceDayAheadDemandForecastRow&gt; ForecastDemandDayAheadEarliestStreamGet (DateTime from, DateTime to, string? boundary = null)

Stream of earliest day-ahead demand forecast data for a given settlement period

This endpoint allows for retrieving a stream of earliest day-ahead demand forecast data from National Grid ESO.  Results are filtered by settlement time, and only the earliest published forecast for each settlement period is shown.  This endpoint has an optimised JSON payload and aimed at frequent request for the day-ahead demand forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDayAheadEarliestStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 

            try
            {
                // Stream of earliest day-ahead demand forecast data for a given settlement period
                List<InsightsApiModelsServiceDayAheadDemandForecastRow> result = apiInstance.ForecastDemandDayAheadEarliestStreamGet(from, to, boundary);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadEarliestStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDayAheadEarliestStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stream of earliest day-ahead demand forecast data for a given settlement period
    ApiResponse<List<InsightsApiModelsServiceDayAheadDemandForecastRow>> response = apiInstance.ForecastDemandDayAheadEarliestStreamGetWithHttpInfo(from, to, boundary);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadEarliestStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsServiceDayAheadDemandForecastRow&gt;**](InsightsApiModelsServiceDayAheadDemandForecastRow.md)

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

<a id="forecastdemanddayaheadevolutionget"></a>
# **ForecastDemandDayAheadEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead ForecastDemandDayAheadEvolutionGet (DateTime settlementDate, List<int> settlementPeriod, string? boundary = null, string? format = null)

Evolution Day-ahead Demand forecast

This endpoint provides the day and day ahead demand forecast and are categorized as National Demand Forecast (NDF) and Transmission System Demand Forecast (TSDF);  the forecast values are derived by NGESO and is based on historically metered generation output for Great Britain.  The data is updated every 30 minutes and within 15 minutes of the end of the effective Settlement Period.  NDF takes into account transmission losses but but does not include station transformer load, pumped storage demand or Interconnector demand;  the data is reported only at national level; and TSDF which takes into account transmission losses , station transformer load, pumped storage demand and interconnector demand.  The data is reported both at national and boundary (system zones) level. Boundary data only available for Transmission System Demand Forecast (TSDF).                Date parameter must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDayAheadEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var settlementDate = 2022-09-20;  // DateTime | The settlement date for the filter. This must be in the format yyyy-MM-dd.
            var settlementPeriod = new List<int>(); // List<int> | 
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution Day-ahead Demand forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead result = apiInstance.ForecastDemandDayAheadEvolutionGet(settlementDate, settlementPeriod, boundary, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDayAheadEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution Day-ahead Demand forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead> response = apiInstance.ForecastDemandDayAheadEvolutionGetWithHttpInfo(settlementDate, settlementPeriod, boundary, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementDate** | **DateTime** | The settlement date for the filter. This must be in the format yyyy-MM-dd. |  |
| **settlementPeriod** | [**List&lt;int&gt;**](int.md) |  |  |
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead.md)

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

<a id="forecastdemanddayaheadget"></a>
# **ForecastDemandDayAheadGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead ForecastDemandDayAheadGet (string? boundary = null, string? format = null)

Day-ahead demand forecast

This endpoint provides the day and day ahead demand forecast and are categorized as National Demand Forecast (NDF) and Transmission System Demand Forecast (TSDF);  the forecast values are derived by NGESO and is based on historically metered generation output for Great Britain.  The data is updated every 30 minutes and within 15 minutes of the end of the effective Settlement Period.  NDF takes into account transmission losses but but does not include station transformer load, pumped storage demand or Interconnector demand;  the data is reported only at national level; and TSDF which takes into account transmission losses , station transformer load, pumped storage demand and interconnector demand.  The data is reported both at national and boundary (system zones) level. Boundary data only available for Transmission System Demand Forecast (TSDF).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDayAheadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Day-ahead demand forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead result = apiInstance.ForecastDemandDayAheadGet(boundary, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDayAheadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Day-ahead demand forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead> response = apiInstance.ForecastDemandDayAheadGetWithHttpInfo(boundary, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead.md)

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

<a id="forecastdemanddayaheadhistoryget"></a>
# **ForecastDemandDayAheadHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead ForecastDemandDayAheadHistoryGet (DateTime publishTime, string? boundary = null, string? format = null)

Historical day-ahead forecast demand

This endpoint provides the day and day ahead demand forecast and are categorized as National Demand Forecast (NDF) and Transmission System Demand Forecast (TSDF);  the forecast values are derived by NGESO and is based on historically metered generation output for Great Britain.  The data is updated every 30 minutes and within 15 minutes of the end of the effective Settlement Period.  NDF takes into account transmission losses but but does not include station transformer load, pumped storage demand or Interconnector demand;  the data is reported only at national level; and TSDF which takes into account transmission losses , station transformer load, pumped storage demand and interconnector demand.  The data is reported both at national and boundary (system zones) level. Boundary data only available for Transmission System Demand Forecast (TSDF).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDayAheadHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historical day-ahead forecast demand
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead result = apiInstance.ForecastDemandDayAheadHistoryGet(publishTime, boundary, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDayAheadHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical day-ahead forecast demand
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead> response = apiInstance.ForecastDemandDayAheadHistoryGetWithHttpInfo(publishTime, boundary, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishTime** | **DateTime** |  |  |
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead.md)

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

<a id="forecastdemanddayaheadlatestget"></a>
# **ForecastDemandDayAheadLatestGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead ForecastDemandDayAheadLatestGet (DateTime from, DateTime to, string? boundary = null, string? format = null)

Latest published day-ahead demand forecast data for a given settlement period

This endpoint allows for retrieving latest day-ahead demand forecast data from National Grid ESO.  Results are filtered by settlement time, and only the latest published forecast for each settlement period is shown.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDayAheadLatestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Latest published day-ahead demand forecast data for a given settlement period
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead result = apiInstance.ForecastDemandDayAheadLatestGet(from, to, boundary, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadLatestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDayAheadLatestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Latest published day-ahead demand forecast data for a given settlement period
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead> response = apiInstance.ForecastDemandDayAheadLatestGetWithHttpInfo(from, to, boundary, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadLatestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastDayAhead.md)

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

<a id="forecastdemanddayaheadlateststreamget"></a>
# **ForecastDemandDayAheadLatestStreamGet**
> List&lt;InsightsApiModelsServiceDayAheadDemandForecastRow&gt; ForecastDemandDayAheadLatestStreamGet (DateTime from, DateTime to, string? boundary = null)

Stream of latest published day-ahead demand forecast data for a given settlement period

This endpoint allows for retrieving a stream of latest day-ahead demand forecast data from National Grid ESO.  Results are filtered by settlement time, and only the latest published forecast for each settlement period is shown.  This endpoint has an optimised JSON payload and aimed at frequent request for the day-ahead demand forecast data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDayAheadLatestStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var boundary = "boundary_example";  // string? | Omitting this will return only national data. Specifying boundary=zonal will return only zonal data. (optional) 

            try
            {
                // Stream of latest published day-ahead demand forecast data for a given settlement period
                List<InsightsApiModelsServiceDayAheadDemandForecastRow> result = apiInstance.ForecastDemandDayAheadLatestStreamGet(from, to, boundary);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadLatestStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDayAheadLatestStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stream of latest published day-ahead demand forecast data for a given settlement period
    ApiResponse<List<InsightsApiModelsServiceDayAheadDemandForecastRow>> response = apiInstance.ForecastDemandDayAheadLatestStreamGetWithHttpInfo(from, to, boundary);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadLatestStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **boundary** | **string?** | Omitting this will return only national data. Specifying boundary&#x3D;zonal will return only zonal data. | [optional]  |

### Return type

[**List&lt;InsightsApiModelsServiceDayAheadDemandForecastRow&gt;**](InsightsApiModelsServiceDayAheadDemandForecastRow.md)

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

<a id="forecastdemanddayaheadpeakget"></a>
# **ForecastDemandDayAheadPeakGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastPeak ForecastDemandDayAheadPeakGet (string? boundary = null, DateTime? from = null, DateTime? to = null, string? format = null)

Retrieve peak demand data for each day, based on Day Ahead forecast data

This endpoint allows for retrieving the peak demand that is forecast for each day from National Grid ESO.  Results are filtered by a range of Date parameters.  Results default to yesterday, today and tomorrow if no parameters are supplied.                Date parameters must be provided in the exact format yyyy-MM-dd.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandDayAheadPeakGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var boundary = "boundary_example";  // string? |  (optional) 
            var from = 2021-10-01;  // DateTime? | The start of the requested date range. (optional) 
            var to = 2021-10-30;  // DateTime? | The end of the requested date range. (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Retrieve peak demand data for each day, based on Day Ahead forecast data
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastPeak result = apiInstance.ForecastDemandDayAheadPeakGet(boundary, from, to, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadPeakGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandDayAheadPeakGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve peak demand data for each day, based on Day Ahead forecast data
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastPeak> response = apiInstance.ForecastDemandDayAheadPeakGetWithHttpInfo(boundary, from, to, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandDayAheadPeakGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **boundary** | **string?** |  | [optional]  |
| **from** | **DateTime?** | The start of the requested date range. | [optional]  |
| **to** | **DateTime?** | The end of the requested date range. | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastPeak**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastPeak.md)

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

<a id="forecastdemandweeklyevolutionget"></a>
# **ForecastDemandWeeklyEvolutionGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly ForecastDemandWeeklyEvolutionGet (int forecastYear, int forecastWeek, string? format = null)

Evolution Weekly Demand Forecast

This endpoint provides all weekly demand forecasts over time for a given forecast Year and Week

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandWeeklyEvolutionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var forecastYear = 56;  // int | 
            var forecastWeek = 56;  // int | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Evolution Weekly Demand Forecast
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly result = apiInstance.ForecastDemandWeeklyEvolutionGet(forecastYear, forecastWeek, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandWeeklyEvolutionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandWeeklyEvolutionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evolution Weekly Demand Forecast
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly> response = apiInstance.ForecastDemandWeeklyEvolutionGetWithHttpInfo(forecastYear, forecastWeek, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandWeeklyEvolutionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **forecastYear** | **int** |  |  |
| **forecastWeek** | **int** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly.md)

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

<a id="forecastdemandweeklyget"></a>
# **ForecastDemandWeeklyGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly ForecastDemandWeeklyGet (string? format = null)

Weekly forecast demand

This endpoint provides the latest weekly forecast demand data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandWeeklyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Weekly forecast demand
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly result = apiInstance.ForecastDemandWeeklyGet(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandWeeklyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandWeeklyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Weekly forecast demand
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly> response = apiInstance.ForecastDemandWeeklyGetWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandWeeklyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly.md)

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

<a id="forecastdemandweeklyhistoryget"></a>
# **ForecastDemandWeeklyHistoryGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly ForecastDemandWeeklyHistoryGet (DateTime publishTime, string? format = null)

Historical weekly forecast demand

Retrieve historical weekly forecast demand data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForecastDemandWeeklyHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new DemandForecastApi(config);
            var publishTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Historical weekly forecast demand
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly result = apiInstance.ForecastDemandWeeklyHistoryGet(publishTime, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemandForecastApi.ForecastDemandWeeklyHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForecastDemandWeeklyHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Historical weekly forecast demand
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly> response = apiInstance.ForecastDemandWeeklyHistoryGetWithHttpInfo(publishTime, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DemandForecastApi.ForecastDemandWeeklyHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publishTime** | **DateTime** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesDemandForecastDemandForecastWeekly.md)

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


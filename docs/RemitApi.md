# Org.OpenAPITools.Api.RemitApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**REMITGet**](RemitApi.md#remitget) | **GET** /REMIT | Remit bulk data by Message IDs |
| [**REMITListByEventGet**](RemitApi.md#remitlistbyeventget) | **GET** /REMIT/list/by-event | Remit list message identifiers by event |
| [**REMITListByEventStreamGet**](RemitApi.md#remitlistbyeventstreamget) | **GET** /REMIT/list/by-event/stream | Remit list message identifiers by event stream |
| [**REMITListByPublishGet**](RemitApi.md#remitlistbypublishget) | **GET** /REMIT/list/by-publish | Remit list message identifiers by publish time |
| [**REMITListByPublishStreamGet**](RemitApi.md#remitlistbypublishstreamget) | **GET** /REMIT/list/by-publish/stream | Remit list message identifiers by publish time stream |
| [**REMITMessageIdGet**](RemitApi.md#remitmessageidget) | **GET** /REMIT/{messageId} | Remit data by Message ID |
| [**REMITRevisionsGet**](RemitApi.md#remitrevisionsget) | **GET** /REMIT/revisions | Remit message revisions by MRID or Message ID |
| [**REMITSearchGet**](RemitApi.md#remitsearchget) | **GET** /REMIT/search | Remit data by MRID |

<a id="remitget"></a>
# **REMITGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId REMITGet (List<int> messageId, string? format = null)

Remit bulk data by Message IDs

This endpoint provides one or more REMIT messages based on the given Message IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class REMITGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new RemitApi(config);
            var messageId = new List<int>(); // List<int> | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Remit bulk data by Message IDs
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId result = apiInstance.REMITGet(messageId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RemitApi.REMITGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the REMITGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remit bulk data by Message IDs
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId> response = apiInstance.REMITGetWithHttpInfo(messageId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RemitApi.REMITGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | [**List&lt;int&gt;**](int.md) |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **404** | No data found for given query parameters |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="remitlistbyeventget"></a>
# **REMITListByEventGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl REMITListByEventGet (DateTime from, DateTime to, string? participantId = null, string? assetId = null, string? messageType = null, string? unavailabilityType = null, List<string>? eventType = null, List<string>? fuelType = null, bool? latestRevisionOnly = null, bool? profileOnly = null, string? format = null)

Remit list message identifiers by event

This endpoint provides a list of REMIT message identifiers based on the event start time, end time and other optional parameters.                - Filtering by LatestRevisionOnly (default = true):     if true, include only the latest revision of each message.                - Filtering by ProfileOnly (default = false):      if true, include only messages with an outage profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class REMITListByEventGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new RemitApi(config);
            var from = 2023/04/13 07:00;  // DateTime | 
            var to = 2023/04/14 07:00;  // DateTime | 
            var participantId = EECL;  // string? |  (optional) 
            var assetId = T_RATSGT-2;  // string? |  (optional) 
            var messageType = UnavailabilitiesOfElectricityFacilities;  // string? |  (optional) 
            var unavailabilityType = Planned;  // string? |  (optional) 
            var eventType = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var latestRevisionOnly = true;  // bool? |  (optional) 
            var profileOnly = false;  // bool? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Remit list message identifiers by event
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl result = apiInstance.REMITListByEventGet(from, to, participantId, assetId, messageType, unavailabilityType, eventType, fuelType, latestRevisionOnly, profileOnly, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RemitApi.REMITListByEventGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the REMITListByEventGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remit list message identifiers by event
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl> response = apiInstance.REMITListByEventGetWithHttpInfo(from, to, participantId, assetId, messageType, unavailabilityType, eventType, fuelType, latestRevisionOnly, profileOnly, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RemitApi.REMITListByEventGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **participantId** | **string?** |  | [optional]  |
| **assetId** | **string?** |  | [optional]  |
| **messageType** | **string?** |  | [optional]  |
| **unavailabilityType** | **string?** |  | [optional]  |
| **eventType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **latestRevisionOnly** | **bool?** |  | [optional]  |
| **profileOnly** | **bool?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="remitlistbyeventstreamget"></a>
# **REMITListByEventStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl&gt; REMITListByEventStreamGet (DateTime from, DateTime to, string? participantId = null, string? assetId = null, string? messageType = null, string? unavailabilityType = null, List<string>? eventType = null, List<string>? fuelType = null, bool? latestRevisionOnly = null, bool? profileOnly = null)

Remit list message identifiers by event stream

This endpoint provides a list of REMIT message identifiers based on the event start, end time and other optional parameters.                - Filtering by LatestRevisionOnly (default = true):     if true, include only the latest revision of each message.                - Filtering by ProfileOnly (default = false):      if true, include only messages with an outage profile.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the Remit list message identifiers data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class REMITListByEventStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new RemitApi(config);
            var from = 2023/04/13 07:00;  // DateTime | 
            var to = 2023/04/14 07:00;  // DateTime | 
            var participantId = EECL;  // string? |  (optional) 
            var assetId = T_RATSGT-2;  // string? |  (optional) 
            var messageType = UnavailabilitiesOfElectricityFacilities;  // string? |  (optional) 
            var unavailabilityType = Planned;  // string? |  (optional) 
            var eventType = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var latestRevisionOnly = true;  // bool? |  (optional) 
            var profileOnly = false;  // bool? |  (optional) 

            try
            {
                // Remit list message identifiers by event stream
                List<InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl> result = apiInstance.REMITListByEventStreamGet(from, to, participantId, assetId, messageType, unavailabilityType, eventType, fuelType, latestRevisionOnly, profileOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RemitApi.REMITListByEventStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the REMITListByEventStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remit list message identifiers by event stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl>> response = apiInstance.REMITListByEventStreamGetWithHttpInfo(from, to, participantId, assetId, messageType, unavailabilityType, eventType, fuelType, latestRevisionOnly, profileOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RemitApi.REMITListByEventStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **participantId** | **string?** |  | [optional]  |
| **assetId** | **string?** |  | [optional]  |
| **messageType** | **string?** |  | [optional]  |
| **unavailabilityType** | **string?** |  | [optional]  |
| **eventType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **latestRevisionOnly** | **bool?** |  | [optional]  |
| **profileOnly** | **bool?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl&gt;**](InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl.md)

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

<a id="remitlistbypublishget"></a>
# **REMITListByPublishGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl REMITListByPublishGet (DateTime from, DateTime to, string? participantId = null, string? assetId = null, string? messageType = null, string? unavailabilityType = null, List<string>? eventType = null, List<string>? fuelType = null, bool? latestRevisionOnly = null, bool? profileOnly = null, string? format = null)

Remit list message identifiers by publish time

This endpoint provides a list of REMIT message identifiers based on the publish time and other optional parameters.                - Filtering by LatestRevisionOnly (default = true):     if true, include only the latest revision of each message.                - Filtering by ProfileOnly (default = false):      if true, include only messages with an outage profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class REMITListByPublishGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new RemitApi(config);
            var from = 2023/04/13 07:00;  // DateTime | 
            var to = 2023/04/14 07:00;  // DateTime | 
            var participantId = EECL;  // string? |  (optional) 
            var assetId = T_RATSGT-2;  // string? |  (optional) 
            var messageType = UnavailabilitiesOfElectricityFacilities;  // string? |  (optional) 
            var unavailabilityType = Planned;  // string? |  (optional) 
            var eventType = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var latestRevisionOnly = true;  // bool? |  (optional) 
            var profileOnly = false;  // bool? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Remit list message identifiers by publish time
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl result = apiInstance.REMITListByPublishGet(from, to, participantId, assetId, messageType, unavailabilityType, eventType, fuelType, latestRevisionOnly, profileOnly, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RemitApi.REMITListByPublishGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the REMITListByPublishGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remit list message identifiers by publish time
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl> response = apiInstance.REMITListByPublishGetWithHttpInfo(from, to, participantId, assetId, messageType, unavailabilityType, eventType, fuelType, latestRevisionOnly, profileOnly, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RemitApi.REMITListByPublishGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **participantId** | **string?** |  | [optional]  |
| **assetId** | **string?** |  | [optional]  |
| **messageType** | **string?** |  | [optional]  |
| **unavailabilityType** | **string?** |  | [optional]  |
| **eventType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **latestRevisionOnly** | **bool?** |  | [optional]  |
| **profileOnly** | **bool?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="remitlistbypublishstreamget"></a>
# **REMITListByPublishStreamGet**
> List&lt;InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl&gt; REMITListByPublishStreamGet (DateTime from, DateTime to, string? participantId = null, string? assetId = null, string? messageType = null, string? unavailabilityType = null, List<string>? eventType = null, List<string>? fuelType = null, bool? latestRevisionOnly = null, bool? profileOnly = null)

Remit list message identifiers by publish time stream

This endpoint provides a list of REMIT message identifiers based on the publish time and other optional parameters.                - Filtering by LatestRevisionOnly (default = true):     if true, include only the latest revision of each message.                - Filtering by ProfileOnly (default = false):      if true, include only messages with an outage profile.                This endpoint has an optimised JSON payload and is aimed at frequent requests for the Remit list message identifiers data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class REMITListByPublishStreamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new RemitApi(config);
            var from = 2023/04/13 07:00;  // DateTime | 
            var to = 2023/04/14 07:00;  // DateTime | 
            var participantId = EECL;  // string? |  (optional) 
            var assetId = T_RATSGT-2;  // string? |  (optional) 
            var messageType = UnavailabilitiesOfElectricityFacilities;  // string? |  (optional) 
            var unavailabilityType = Planned;  // string? |  (optional) 
            var eventType = new List<string>?(); // List<string>? |  (optional) 
            var fuelType = new List<string>?(); // List<string>? |  (optional) 
            var latestRevisionOnly = true;  // bool? |  (optional) 
            var profileOnly = false;  // bool? |  (optional) 

            try
            {
                // Remit list message identifiers by publish time stream
                List<InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl> result = apiInstance.REMITListByPublishStreamGet(from, to, participantId, assetId, messageType, unavailabilityType, eventType, fuelType, latestRevisionOnly, profileOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RemitApi.REMITListByPublishStreamGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the REMITListByPublishStreamGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remit list message identifiers by publish time stream
    ApiResponse<List<InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl>> response = apiInstance.REMITListByPublishStreamGetWithHttpInfo(from, to, participantId, assetId, messageType, unavailabilityType, eventType, fuelType, latestRevisionOnly, profileOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RemitApi.REMITListByPublishStreamGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **DateTime** |  |  |
| **to** | **DateTime** |  |  |
| **participantId** | **string?** |  | [optional]  |
| **assetId** | **string?** |  | [optional]  |
| **messageType** | **string?** |  | [optional]  |
| **unavailabilityType** | **string?** |  | [optional]  |
| **eventType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **fuelType** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **latestRevisionOnly** | **bool?** |  | [optional]  |
| **profileOnly** | **bool?** |  | [optional]  |

### Return type

[**List&lt;InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl&gt;**](InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl.md)

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

<a id="remitmessageidget"></a>
# **REMITMessageIdGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId REMITMessageIdGet (int messageId, string? format = null)

Remit data by Message ID

This endpoint provides a REMIT message based on a given Message ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class REMITMessageIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new RemitApi(config);
            var messageId = 56;  // int | 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Remit data by Message ID
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId result = apiInstance.REMITMessageIdGet(messageId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RemitApi.REMITMessageIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the REMITMessageIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remit data by Message ID
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId> response = apiInstance.REMITMessageIdGetWithHttpInfo(messageId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RemitApi.REMITMessageIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **int** |  |  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **404** | No data found for given id |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="remitrevisionsget"></a>
# **REMITRevisionsGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl REMITRevisionsGet (string? mrid = null, int? messageId = null, string? format = null)

Remit message revisions by MRID or Message ID

This endpoint provides all of the REMIT Message Revisions for a given Message Group.  The Message Group can be specified in two ways:  - via an MRID which specifies a unique Message Group  - via a Message ID, as each Message will belong to a unique Message Group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class REMITRevisionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new RemitApi(config);
            var mrid = 48X000000000080X-NGET-RMT-00014669;  // string? |  (optional) 
            var messageId = 1;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Remit message revisions by MRID or Message ID
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl result = apiInstance.REMITRevisionsGet(mrid, messageId, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RemitApi.REMITRevisionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the REMITRevisionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remit message revisions by MRID or Message ID
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl> response = apiInstance.REMITRevisionsGetWithHttpInfo(mrid, messageId, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RemitApi.REMITRevisionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mrid** | **string?** |  | [optional]  |
| **messageId** | **int?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageIdentifierWithUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **404** | No data found for given query parameters |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="remitsearchget"></a>
# **REMITSearchGet**
> InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId REMITSearchGet (string mrid, int? revisionNumber = null, string? format = null)

Remit data by MRID

This endpoint provides one or more REMIT messages based on the given MRID and revision number. If none is given  it returns the REMIT message with the latest revision number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class REMITSearchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new RemitApi(config);
            var mrid = 48X000000000080X-NGET-RMT-00014669;  // string | 
            var revisionNumber = 56;  // int? |  (optional) 
            var format = "json";  // string? | Response data format. Use json/xml to include metadata. (optional) 

            try
            {
                // Remit data by MRID
                InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId result = apiInstance.REMITSearchGet(mrid, revisionNumber, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RemitApi.REMITSearchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the REMITSearchGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remit data by MRID
    ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId> response = apiInstance.REMITSearchGetWithHttpInfo(mrid, revisionNumber, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RemitApi.REMITSearchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mrid** | **string** |  |  |
| **revisionNumber** | **int?** |  | [optional]  |
| **format** | **string?** | Response data format. Use json/xml to include metadata. | [optional]  |

### Return type

[**InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId**](InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesTransparencyRemitRemitMessageWithId.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Data retrieved |  -  |
| **400** | Error with query parameters - see response for details |  -  |
| **404** | No data found for given query parameters |  -  |
| **500** | Server error - please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


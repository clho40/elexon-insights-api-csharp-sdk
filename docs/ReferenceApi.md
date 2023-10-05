# Org.OpenAPITools.Api.ReferenceApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReferenceBmunitsAllGet**](ReferenceApi.md#referencebmunitsallget) | **GET** /reference/bmunits/all | BM Units and Mappings |
| [**ReferenceFueltypesAllGet**](ReferenceApi.md#referencefueltypesallget) | **GET** /reference/fueltypes/all | Fuel Types |
| [**ReferenceInterconnectorsAllGet**](ReferenceApi.md#referenceinterconnectorsallget) | **GET** /reference/interconnectors/all | Interconnectors |
| [**ReferenceRemitAssetsAllGet**](ReferenceApi.md#referenceremitassetsallget) | **GET** /reference/remit/assets/all | Assets |
| [**ReferenceRemitFueltypesAllGet**](ReferenceApi.md#referenceremitfueltypesallget) | **GET** /reference/remit/fueltypes/all | Remit Fuel Types |
| [**ReferenceRemitParticipantsAllGet**](ReferenceApi.md#referenceremitparticipantsallget) | **GET** /reference/remit/participants/all | Participants |

<a id="referencebmunitsallget"></a>
# **ReferenceBmunitsAllGet**
> List&lt;InsightsApiModelsResponsesReferenceBmUnitData&gt; ReferenceBmunitsAllGet ()

BM Units and Mappings

This endpoint provides a current list of BM units and mappings held by Elexon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceBmunitsAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new ReferenceApi(config);

            try
            {
                // BM Units and Mappings
                List<InsightsApiModelsResponsesReferenceBmUnitData> result = apiInstance.ReferenceBmunitsAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceApi.ReferenceBmunitsAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceBmunitsAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BM Units and Mappings
    ApiResponse<List<InsightsApiModelsResponsesReferenceBmUnitData>> response = apiInstance.ReferenceBmunitsAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceApi.ReferenceBmunitsAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;InsightsApiModelsResponsesReferenceBmUnitData&gt;**](InsightsApiModelsResponsesReferenceBmUnitData.md)

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

<a id="referencefueltypesallget"></a>
# **ReferenceFueltypesAllGet**
> List&lt;string&gt; ReferenceFueltypesAllGet ()

Fuel Types

This endpoint provides a current list of FuelTypes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceFueltypesAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new ReferenceApi(config);

            try
            {
                // Fuel Types
                List<string> result = apiInstance.ReferenceFueltypesAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceApi.ReferenceFueltypesAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceFueltypesAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fuel Types
    ApiResponse<List<string>> response = apiInstance.ReferenceFueltypesAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceApi.ReferenceFueltypesAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

<a id="referenceinterconnectorsallget"></a>
# **ReferenceInterconnectorsAllGet**
> List&lt;InsightsApiModelsResponsesReferenceInterconnectorData&gt; ReferenceInterconnectorsAllGet ()

Interconnectors

This endpoint provides a current list of Interconnectors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceInterconnectorsAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new ReferenceApi(config);

            try
            {
                // Interconnectors
                List<InsightsApiModelsResponsesReferenceInterconnectorData> result = apiInstance.ReferenceInterconnectorsAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceApi.ReferenceInterconnectorsAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceInterconnectorsAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Interconnectors
    ApiResponse<List<InsightsApiModelsResponsesReferenceInterconnectorData>> response = apiInstance.ReferenceInterconnectorsAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceApi.ReferenceInterconnectorsAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;InsightsApiModelsResponsesReferenceInterconnectorData&gt;**](InsightsApiModelsResponsesReferenceInterconnectorData.md)

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

<a id="referenceremitassetsallget"></a>
# **ReferenceRemitAssetsAllGet**
> List&lt;string&gt; ReferenceRemitAssetsAllGet ()

Assets

This endpoint provides a current list of AssetIds received from REMIT messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceRemitAssetsAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new ReferenceApi(config);

            try
            {
                // Assets
                List<string> result = apiInstance.ReferenceRemitAssetsAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceApi.ReferenceRemitAssetsAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceRemitAssetsAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assets
    ApiResponse<List<string>> response = apiInstance.ReferenceRemitAssetsAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceApi.ReferenceRemitAssetsAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

<a id="referenceremitfueltypesallget"></a>
# **ReferenceRemitFueltypesAllGet**
> List&lt;string&gt; ReferenceRemitFueltypesAllGet ()

Remit Fuel Types

This endpoint provides a current list of fuel types received from REMIT messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceRemitFueltypesAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new ReferenceApi(config);

            try
            {
                // Remit Fuel Types
                List<string> result = apiInstance.ReferenceRemitFueltypesAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceApi.ReferenceRemitFueltypesAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceRemitFueltypesAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remit Fuel Types
    ApiResponse<List<string>> response = apiInstance.ReferenceRemitFueltypesAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceApi.ReferenceRemitFueltypesAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

<a id="referenceremitparticipantsallget"></a>
# **ReferenceRemitParticipantsAllGet**
> List&lt;string&gt; ReferenceRemitParticipantsAllGet ()

Participants

This endpoint provides a current list of ParticipantIds received from REMIT messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReferenceRemitParticipantsAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new ReferenceApi(config);

            try
            {
                // Participants
                List<string> result = apiInstance.ReferenceRemitParticipantsAllGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferenceApi.ReferenceRemitParticipantsAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReferenceRemitParticipantsAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Participants
    ApiResponse<List<string>> response = apiInstance.ReferenceRemitParticipantsAllGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReferenceApi.ReferenceRemitParticipantsAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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


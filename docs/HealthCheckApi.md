# Org.OpenAPITools.Api.HealthCheckApi

All URIs are relative to *https://data.elexon.co.uk/bmrs/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HealthGet**](HealthCheckApi.md#healthget) | **GET** /health | Health Check |

<a id="healthget"></a>
# **HealthGet**
> void HealthGet ()

Health Check

This endpoint provides a success status code (200) if the service is alive

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HealthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://data.elexon.co.uk/bmrs/api/v1";
            var apiInstance = new HealthCheckApi(config);

            try
            {
                // Health Check
                apiInstance.HealthGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthCheckApi.HealthGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HealthGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health Check
    apiInstance.HealthGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HealthCheckApi.HealthGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | API is healthy |  -  |
| **503** | API is unhealthy or in degraded state |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


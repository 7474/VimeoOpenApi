# VimeoOpenApi.Api.APIInformationEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEndpoints**](APIInformationEssentialsApi.md#getendpoints) | **GET** / | Get the API specification


<a name="getendpoints"></a>
# **GetEndpoints**
> Endpoint GetEndpoints (bool? openapi = null)

Get the API specification

This method returns the full OpenAPI specification for the Vimeo API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetEndpointsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new APIInformationEssentialsApi(config);
            var openapi = true;  // bool? | Return an OpenAPI specification. (optional) 

            try
            {
                // Get the API specification
                Endpoint result = apiInstance.GetEndpoints(openapi);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APIInformationEssentialsApi.GetEndpoints: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **openapi** | **bool?**| Return an OpenAPI specification. | [optional] 

### Return type

[**Endpoint**](Endpoint.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.endpoint+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Standard request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


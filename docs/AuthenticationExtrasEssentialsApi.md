# VimeoOpenApi.Api.AuthenticationExtrasEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteToken**](AuthenticationExtrasEssentialsApi.md#deletetoken) | **DELETE** /tokens | Revoke the current access token
[**VerifyToken**](AuthenticationExtrasEssentialsApi.md#verifytoken) | **GET** /oauth/verify | Verify an OAuth 2 access token


<a name="deletetoken"></a>
# **DeleteToken**
> void DeleteToken ()

Revoke the current access token

This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationExtrasEssentialsApi(config);

            try
            {
                // Revoke the current access token
                apiInstance.DeleteToken();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationExtrasEssentialsApi.DeleteToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.auth+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The token was revoked. |  -  |
| **400** | Access can&#39;t be revoked for an OAuth 1 token. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifytoken"></a>
# **VerifyToken**
> Auth VerifyToken ()

Verify an OAuth 2 access token

This method verifies that an OAuth 2 access token exists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class VerifyTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationExtrasEssentialsApi(config);

            try
            {
                // Verify an OAuth 2 access token
                Auth result = apiInstance.VerifyToken();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationExtrasEssentialsApi.VerifyToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Auth**](Auth.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.auth+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The token was verified. |  -  |
| **401** | The token isn&#39;t a valid OAuth 2 token. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


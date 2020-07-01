# VimeoOpenApi.Api.AuthenticationExtrasAuthenticateApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClientAuth**](AuthenticationExtrasAuthenticateApi.md#clientauth) | **POST** /oauth/authorize/client | Authorize a client with OAuth


<a name="clientauth"></a>
# **ClientAuth**
> Auth ClientAuth (InlineObject28 inlineObject28)

Authorize a client with OAuth

This method uses the OAuth protocol to authorize a client. For details on OAuth client authorization, see our [Working with Authentication](/api/authentication) guide or the [OAuth spec](https://tools.ietf.org/html/draft-ietf-oauth-v2-31#section-4.4).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class ClientAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationExtrasAuthenticateApi(config);
            var inlineObject28 = new InlineObject28(); // InlineObject28 | 

            try
            {
                // Authorize a client with OAuth
                Auth result = apiInstance.ClientAuth(inlineObject28);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationExtrasAuthenticateApi.ClientAuth: " + e.Message );
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
 **inlineObject28** | [**InlineObject28**](InlineObject28.md)|  | 

### Return type

[**Auth**](Auth.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.auth+json
 - **Accept**: application/vnd.vimeo.auth+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The authorization was successful. |  -  |
| **401** | Error code 8001: No such client secret exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


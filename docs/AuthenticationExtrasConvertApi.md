# VimeoOpenApi.Api.AuthenticationExtrasConvertApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertAccessToken**](AuthenticationExtrasConvertApi.md#convertaccesstoken) | **POST** /oauth/authorize/vimeo_oauth1 | Convert an OAuth 1 access token to an OAuth 2 access token


<a name="convertaccesstoken"></a>
# **ConvertAccessToken**
> Auth ConvertAccessToken (InlineObject29 inlineObject29)

Convert an OAuth 1 access token to an OAuth 2 access token

This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class ConvertAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationExtrasConvertApi(config);
            var inlineObject29 = new InlineObject29(); // InlineObject29 | 

            try
            {
                // Convert an OAuth 1 access token to an OAuth 2 access token
                Auth result = apiInstance.ConvertAccessToken(inlineObject29);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationExtrasConvertApi.ConvertAccessToken: " + e.Message );
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
 **inlineObject29** | [**InlineObject29**](InlineObject29.md)|  | 

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
| **200** | The token was converted. |  -  |
| **400** | * The token is invalid. * The token has unauthorized scopes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


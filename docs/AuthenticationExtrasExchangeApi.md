# VimeoOpenApi.Api.AuthenticationExtrasExchangeApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExchangeAuthCode**](AuthenticationExtrasExchangeApi.md#exchangeauthcode) | **POST** /oauth/access_token | Exchange an authorization code for an access token


<a name="exchangeauthcode"></a>
# **ExchangeAuthCode**
> Auth ExchangeAuthCode (InlineObject27 inlineObject27)

Exchange an authorization code for an access token

This method exchanges an OAuth authorization code for an OAuth access token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class ExchangeAuthCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationExtrasExchangeApi(config);
            var inlineObject27 = new InlineObject27(); // InlineObject27 | 

            try
            {
                // Exchange an authorization code for an access token
                Auth result = apiInstance.ExchangeAuthCode(inlineObject27);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationExtrasExchangeApi.ExchangeAuthCode: " + e.Message );
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
 **inlineObject27** | [**InlineObject27**](InlineObject27.md)|  | 

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
| **200** | The authorization code was exchanged. |  -  |
| **400** | * The grant type is invalid. * The authorization code is invalid. * The redirect URI doesn&#39;t match the URI to create the authorization code. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


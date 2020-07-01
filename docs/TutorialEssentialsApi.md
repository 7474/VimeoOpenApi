# VimeoOpenApi.Api.TutorialEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeveloperTutorial**](TutorialEssentialsApi.md#developertutorial) | **GET** /tutorial | Get started with the Vimeo API


<a name="developertutorial"></a>
# **DeveloperTutorial**
> void DeveloperTutorial ()

Get started with the Vimeo API

This method tests whether users who are working through the [Getting Started](https://developer.vimeo.com/api/guides/start) guides have set up their configurations correctly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeveloperTutorialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TutorialEssentialsApi(config);

            try
            {
                // Get started with the Vimeo API
                apiInstance.DeveloperTutorial();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TutorialEssentialsApi.DeveloperTutorial: " + e.Message );
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
 - **Accept**: Not defined


[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


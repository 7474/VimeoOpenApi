# VimeoOpenApi.Api.VideosLanguagesApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLanguages**](VideosLanguagesApi.md#getlanguages) | **GET** /languages | Get all languages


<a name="getlanguages"></a>
# **GetLanguages**
> List&lt;Language&gt; GetLanguages (string filter = null)

Get all languages

This method returns all available video languages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetLanguagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosLanguagesApi(config);
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `texttracks` - Return languages that can be used for text tracks.  (optional) 

            try
            {
                // Get all languages
                List<Language> result = apiInstance.GetLanguages(filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosLanguagesApi.GetLanguages: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;texttracks&#x60; - Return languages that can be used for text tracks.  | [optional] 

### Return type

[**List&lt;Language&gt;**](Language.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.language+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The languages were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


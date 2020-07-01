# VimeoOpenApi.Api.VideosCreativeCommonsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCcLicenses**](VideosCreativeCommonsApi.md#getcclicenses) | **GET** /creativecommons | Get all Creative Commons licenses


<a name="getcclicenses"></a>
# **GetCcLicenses**
> List&lt;CreativeCommons&gt; GetCcLicenses ()

Get all Creative Commons licenses

This method returns all available Creative Commons licenses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCcLicensesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosCreativeCommonsApi(config);

            try
            {
                // Get all Creative Commons licenses
                List<CreativeCommons> result = apiInstance.GetCcLicenses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosCreativeCommonsApi.GetCcLicenses: " + e.Message );
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

[**List&lt;CreativeCommons&gt;**](CreativeCommons.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.creativecommons+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Creative Commons licenses were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


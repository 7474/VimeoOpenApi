# VimeoOpenApi.Api.OnDemandPostersApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVodPoster**](OnDemandPostersApi.md#addvodposter) | **POST** /ondemand/pages/{ondemand_id}/pictures | Add a poster to an On Demand page
[**EditVodPoster**](OnDemandPostersApi.md#editvodposter) | **PATCH** /ondemand/pages/{ondemand_id}/pictures/{poster_id} | Edit a poster on an On Demand page
[**GetVodPoster**](OnDemandPostersApi.md#getvodposter) | **GET** /ondemand/pages/{ondemand_id}/pictures/{poster_id} | Get a specific poster on an On Demand page
[**GetVodPosters**](OnDemandPostersApi.md#getvodposters) | **GET** /ondemand/pages/{ondemand_id}/pictures | Get all the posters on an On Demand page


<a name="addvodposter"></a>
# **AddVodPoster**
> Picture AddVodPoster (decimal ondemandId)

Add a poster to an On Demand page

This method adds a poster image to the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVodPosterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPostersApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Add a poster to an On Demand page
                Picture result = apiInstance.AddVodPoster(ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPostersApi.AddVodPoster: " + e.Message );
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
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

### Return type

[**Picture**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The poster was added. |  -  |
| **403** | The authenticated user can&#39;t add posters to this On Demand page. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editvodposter"></a>
# **EditVodPoster**
> Picture EditVodPoster (decimal ondemandId, decimal posterId, InlineObject32 inlineObject32 = null)

Edit a poster on an On Demand page

This method edits a poster image on the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditVodPosterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPostersApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var posterId = 12345;  // decimal | The ID of the poster.
            var inlineObject32 = new InlineObject32(); // InlineObject32 |  (optional) 

            try
            {
                // Edit a poster on an On Demand page
                Picture result = apiInstance.EditVodPoster(ondemandId, posterId, inlineObject32);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPostersApi.EditVodPoster: " + e.Message );
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
 **ondemandId** | **decimal**| The ID of the On Demand page. | 
 **posterId** | **decimal**| The ID of the poster. | 
 **inlineObject32** | [**InlineObject32**](InlineObject32.md)|  | [optional] 

### Return type

[**Picture**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.picture+json
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The poster was edited. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodposter"></a>
# **GetVodPoster**
> Picture GetVodPoster (decimal ondemandId, decimal posterId)

Get a specific poster on an On Demand page

This method returns a single poster on the specified On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodPosterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPostersApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var posterId = 12345;  // decimal | The ID of the poster.

            try
            {
                // Get a specific poster on an On Demand page
                Picture result = apiInstance.GetVodPoster(ondemandId, posterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPostersApi.GetVodPoster: " + e.Message );
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
 **ondemandId** | **decimal**| The ID of the On Demand page. | 
 **posterId** | **decimal**| The ID of the poster. | 

### Return type

[**Picture**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The poster was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodposters"></a>
# **GetVodPosters**
> List&lt;Picture&gt; GetVodPosters (decimal ondemandId, decimal? page = null, decimal? perPage = null)

Get all the posters on an On Demand page

This method returns every poster on the specified On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodPostersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPostersApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the posters on an On Demand page
                List<Picture> result = apiInstance.GetVodPosters(ondemandId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPostersApi.GetVodPosters: " + e.Message );
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
 **ondemandId** | **decimal**| The ID of the On Demand. | 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

### Return type

[**List&lt;Picture&gt;**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The posters were returned. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


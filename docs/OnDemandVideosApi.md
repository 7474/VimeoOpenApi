# VimeoOpenApi.Api.OnDemandVideosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoToVod**](OnDemandVideosApi.md#addvideotovod) | **PUT** /ondemand/pages/{ondemand_id}/videos/{video_id} | Add a video to an On Demand page
[**DeleteVideoFromVod**](OnDemandVideosApi.md#deletevideofromvod) | **DELETE** /ondemand/pages/{ondemand_id}/videos/{video_id} | Remove a video from an On Demand page
[**GetVodVideo**](OnDemandVideosApi.md#getvodvideo) | **GET** /ondemand/pages/{ondemand_id}/videos/{video_id} | Get a specific video on an On Demand page
[**GetVodVideos**](OnDemandVideosApi.md#getvodvideos) | **GET** /ondemand/pages/{ondemand_id}/videos | Get all the videos on an On Demand page


<a name="addvideotovod"></a>
# **AddVideoToVod**
> OnDemandVideo AddVideoToVod (decimal ondemandId, decimal videoId, InlineObject36 inlineObject36)

Add a video to an On Demand page

This method adds a video to the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToVodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandVideosApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var videoId = 12345;  // decimal | The ID of the video.
            var inlineObject36 = new InlineObject36(); // InlineObject36 | 

            try
            {
                // Add a video to an On Demand page
                OnDemandVideo result = apiInstance.AddVideoToVod(ondemandId, videoId, inlineObject36);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandVideosApi.AddVideoToVod: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject36** | [**InlineObject36**](InlineObject36.md)|  | 

### Return type

[**OnDemandVideo**](OnDemandVideo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.ondemand.video+json
 - **Accept**: application/vnd.vimeo.ondemand.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The video was added. |  -  |
| **400** | The video can&#39;t be added to this On Demand page. |  -  |
| **403** | The authenticated user can&#39;t add videos to this On Demand page. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideofromvod"></a>
# **DeleteVideoFromVod**
> void DeleteVideoFromVod (decimal ondemandId, decimal videoId)

Remove a video from an On Demand page

This method removes a video from the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoFromVodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandVideosApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var videoId = 12345;  // decimal | The ID of the video.

            try
            {
                // Remove a video from an On Demand page
                apiInstance.DeleteVideoFromVod(ondemandId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandVideosApi.DeleteVideoFromVod: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The video was removed. |  -  |
| **403** | The authenticated user can&#39;t remove videos from this On Demand page. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodvideo"></a>
# **GetVodVideo**
> Video GetVodVideo (decimal ondemandId, decimal videoId)

Get a specific video on an On Demand page

This method returns a single video on the specified On Demand page. Use this method to determine whether the video is on the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandVideosApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var videoId = 12345;  // decimal | The ID of the video.

            try
            {
                // Get a specific video on an On Demand page
                Video result = apiInstance.GetVodVideo(ondemandId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandVideosApi.GetVodVideo: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**Video**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The video was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodvideos"></a>
# **GetVodVideos**
> List&lt;Video&gt; GetVodVideos (decimal ondemandId, string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the videos on an On Demand page

This method returns every video on the specified On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandVideosApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the videos on an On Demand page
                List<Video> result = apiInstance.GetVodVideos(ondemandId, direction, filter, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandVideosApi.GetVodVideos: " + e.Message );
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
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results. | [optional] 

### Return type

[**List&lt;Video&gt;**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | * The videos were returned. * The videos were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# VimeoOpenApi.Api.VideosShowcasesApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddOrRemoveMultipleAlbums**](VideosShowcasesApi.md#addorremovemultiplealbums) | **PATCH** /videos/{video_id}/albums | Add or remove a video from a list of showcases
[**GetVideoAlbums**](VideosShowcasesApi.md#getvideoalbums) | **GET** /videos/{video_id}/albums | Get all the albums that contain a video


<a name="addorremovemultiplealbums"></a>
# **AddOrRemoveMultipleAlbums**
> List&lt;Album&gt; AddOrRemoveMultipleAlbums (decimal videoId, InlineObject52 inlineObject52 = null)

Add or remove a video from a list of showcases

This endpoint adds the specified video to (or removes the video from) muliple showcases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddOrRemoveMultipleAlbumsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosShowcasesApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject52 = new InlineObject52(); // InlineObject52 |  (optional) 

            try
            {
                // Add or remove a video from a list of showcases
                List<Album> result = apiInstance.AddOrRemoveMultipleAlbums(videoId, inlineObject52);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosShowcasesApi.AddOrRemoveMultipleAlbums: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject52** | [**InlineObject52**](InlineObject52.md)|  | [optional] 

### Return type

[**List&lt;Album&gt;**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.album+json
 - **Accept**: application/vnd.vimeo.album+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The videos were added or removed. |  -  |
| **404** | Error code 3433: No such video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoalbums"></a>
# **GetVideoAlbums**
> List&lt;Album&gt; GetVideoAlbums (decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the albums that contain a video

This endpoint returns all the showcases that contain the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoAlbumsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosShowcasesApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the albums that contain a video
                List<Album> result = apiInstance.GetVideoAlbums(videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosShowcasesApi.GetVideoAlbums: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

### Return type

[**List&lt;Album&gt;**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.album+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The showcases were returned. |  -  |
| **404** | Error code 3433: No such video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


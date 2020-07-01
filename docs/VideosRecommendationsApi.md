# VimeoOpenApi.Api.VideosRecommendationsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRelatedVideos**](VideosRecommendationsApi.md#getrelatedvideos) | **GET** /videos/{video_id}/videos | Get all the related videos of a video


<a name="getrelatedvideos"></a>
# **GetRelatedVideos**
> List&lt;Video&gt; GetRelatedVideos (decimal videoId, string filter = null, decimal? page = null, decimal? perPage = null)

Get all the related videos of a video

This method returns every related video of a particular video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetRelatedVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosRecommendationsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `related` - Return related videos.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the related videos of a video
                List<Video> result = apiInstance.GetRelatedVideos(videoId, filter, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosRecommendationsApi.GetRelatedVideos: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;related&#x60; - Return related videos.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

### Return type

[**List&lt;Video&gt;**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The related videos were returned. |  -  |
| **400** | The value of **filter** isn&#39;t &#x60;related&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


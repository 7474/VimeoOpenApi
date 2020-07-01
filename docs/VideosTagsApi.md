# VimeoOpenApi.Api.VideosTagsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoTag**](VideosTagsApi.md#addvideotag) | **PUT** /videos/{video_id}/tags/{word} | Add a specific tag to a video
[**AddVideoTags**](VideosTagsApi.md#addvideotags) | **PUT** /videos/{video_id}/tags | Add a list of tags to a video
[**CheckVideoForTag**](VideosTagsApi.md#checkvideofortag) | **GET** /videos/{video_id}/tags/{word} | Check if a tag has been added to a video
[**DeleteVideoTag**](VideosTagsApi.md#deletevideotag) | **DELETE** /videos/{video_id}/tags/{word} | Remove a tag from a video
[**GetVideoTags**](VideosTagsApi.md#getvideotags) | **GET** /videos/{video_id}/tags | Get all the tags of a video
[**GetVideosWithTag**](VideosTagsApi.md#getvideoswithtag) | **GET** /tags/{word}/videos | Get all the videos with a specific tag


<a name="addvideotag"></a>
# **AddVideoTag**
> Tag AddVideoTag (decimal videoId, string word)

Add a specific tag to a video

This method adds a single tag to the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTagsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var word = awesome;  // string | The tag word.

            try
            {
                // Add a specific tag to a video
                Tag result = apiInstance.AddVideoTag(videoId, word);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTagsApi.AddVideoTag: " + e.Message );
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
 **word** | **string**| The tag word. | 

### Return type

[**Tag**](Tag.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The tag was added. |  -  |
| **400** | * The tag is invalid. * An unsupported parameter was supplied. |  -  |
| **403** | The total number of tags can&#39;t exceed 20. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideotags"></a>
# **AddVideoTags**
> List&lt;Tag&gt; AddVideoTags (decimal videoId, InlineObject61 inlineObject61)

Add a list of tags to a video

This method adds multiple tags to the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTagsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject61 = new InlineObject61(); // InlineObject61 | 

            try
            {
                // Add a list of tags to a video
                List<Tag> result = apiInstance.AddVideoTags(videoId, inlineObject61);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTagsApi.AddVideoTags: " + e.Message );
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
 **inlineObject61** | [**InlineObject61**](InlineObject61.md)|  | 

### Return type

[**List&lt;Tag&gt;**](Tag.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.tag+json
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The tags were added. |  -  |
| **400** | * The request body wasn&#39;t supplied. * A parameter is invalid. * The request body doesn&#39;t contain a JSON-encoded list of tags. |  -  |
| **403** | * The authenticated user can&#39;t add tags to this video. * The total number of tags can&#39;t exceed 20. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkvideofortag"></a>
# **CheckVideoForTag**
> Tag CheckVideoForTag (decimal videoId, string word)

Check if a tag has been added to a video

This method determines whether the specified tag has been added to a video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckVideoForTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTagsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var word = awesome;  // string | The tag word.

            try
            {
                // Check if a tag has been added to a video
                Tag result = apiInstance.CheckVideoForTag(videoId, word);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTagsApi.CheckVideoForTag: " + e.Message );
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
 **word** | **string**| The tag word. | 

### Return type

[**Tag**](Tag.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The tag has been added to the video. |  -  |
| **400** | * A parameter is invalid. * The tag is invalid. |  -  |
| **404** | The video has no such tag. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideotag"></a>
# **DeleteVideoTag**
> void DeleteVideoTag (decimal videoId, string word)

Remove a tag from a video

This method removes the specified tag from a video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTagsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var word = awesome;  // string | The tag word.

            try
            {
                // Remove a tag from a video
                apiInstance.DeleteVideoTag(videoId, word);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTagsApi.DeleteVideoTag: " + e.Message );
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
 **word** | **string**| The tag word. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The tag was removed. |  -  |
| **400** | * A parameter is invalid. * The tag is invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideotags"></a>
# **GetVideoTags**
> List&lt;Tag&gt; GetVideoTags (decimal videoId)

Get all the tags of a video

This method returns all the tags associated with the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTagsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get all the tags of a video
                List<Tag> result = apiInstance.GetVideoTags(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTagsApi.GetVideoTags: " + e.Message );
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

### Return type

[**List&lt;Tag&gt;**](Tag.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The tags were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoswithtag"></a>
# **GetVideosWithTag**
> List&lt;Video&gt; GetVideosWithTag (string word, string direction = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the videos with a specific tag

This method returns all the videos associated with the specified tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideosWithTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTagsApi(config);
            var word = awesome;  // string | The tag word.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `created_time` - Sort the results by creation time.  * `duration` - Sort the results by duration.  * `name` - Sort the results by name.  (optional) 

            try
            {
                // Get all the videos with a specific tag
                List<Video> result = apiInstance.GetVideosWithTag(word, direction, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTagsApi.GetVideosWithTag: " + e.Message );
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
 **word** | **string**| The tag word. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;created_time&#x60; - Sort the results by creation time.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;name&#x60; - Sort the results by name.  | [optional] 

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
| **200** | The videos were returned. |  -  |
| **404** | No such tag exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


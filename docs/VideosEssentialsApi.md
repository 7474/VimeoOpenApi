# VimeoOpenApi.Api.VideosEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckIfUserOwnsVideo**](VideosEssentialsApi.md#checkifuserownsvideo) | **GET** /users/{user_id}/videos/{video_id} | Check if the user owns a video
[**CheckIfUserOwnsVideoAlt1**](VideosEssentialsApi.md#checkifuserownsvideoalt1) | **GET** /me/videos/{video_id} | Check if the user owns a video
[**DeleteVideo**](VideosEssentialsApi.md#deletevideo) | **DELETE** /videos/{video_id} | Delete a video
[**EditVideo**](VideosEssentialsApi.md#editvideo) | **PATCH** /videos/{video_id} | Edit a video
[**GetAppearances**](VideosEssentialsApi.md#getappearances) | **GET** /users/{user_id}/appearances | Get all the videos in which the user appears
[**GetAppearancesAlt1**](VideosEssentialsApi.md#getappearancesalt1) | **GET** /me/appearances | Get all the videos in which the user appears
[**GetVideo**](VideosEssentialsApi.md#getvideo) | **GET** /videos/{video_id} | Get a specific video
[**GetVideos**](VideosEssentialsApi.md#getvideos) | **GET** /users/{user_id}/videos | Get all the videos that the user has uploaded
[**GetVideosAlt1**](VideosEssentialsApi.md#getvideosalt1) | **GET** /me/videos | Get all the videos that the user has uploaded
[**SearchVideos**](VideosEssentialsApi.md#searchvideos) | **GET** /videos | Search for videos


<a name="checkifuserownsvideo"></a>
# **CheckIfUserOwnsVideo**
> Video CheckIfUserOwnsVideo (decimal userId, decimal videoId)

Check if the user owns a video

This method determines whether the authenticated user is the owner of the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserOwnsVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Check if the user owns a video
                Video result = apiInstance.CheckIfUserOwnsVideo(userId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.CheckIfUserOwnsVideo: " + e.Message );
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
 **userId** | **decimal**| The ID of the user. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**Video**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The authenticated user owns the video. |  -  |
| **404** | The authenticated user doesn&#39;t own the video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkifuserownsvideoalt1"></a>
# **CheckIfUserOwnsVideoAlt1**
> Video CheckIfUserOwnsVideoAlt1 (decimal videoId)

Check if the user owns a video

This method determines whether the authenticated user is the owner of the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserOwnsVideoAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Check if the user owns a video
                Video result = apiInstance.CheckIfUserOwnsVideoAlt1(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.CheckIfUserOwnsVideoAlt1: " + e.Message );
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

[**Video**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The authenticated user owns the video. |  -  |
| **404** | The authenticated user doesn&#39;t own the video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideo"></a>
# **DeleteVideo**
> void DeleteVideo (decimal videoId)

Delete a video

This method deletes the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Delete a video
                apiInstance.DeleteVideo(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.DeleteVideo: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The video was deleted. |  -  |
| **403** | The authenticated user can&#39;t delete this video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editvideo"></a>
# **EditVideo**
> Video EditVideo (decimal videoId, InlineObject51 inlineObject51)

Edit a video

This method edits the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject51 = new InlineObject51(); // InlineObject51 | 

            try
            {
                // Edit a video
                Video result = apiInstance.EditVideo(videoId, inlineObject51);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.EditVideo: " + e.Message );
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
 **inlineObject51** | [**InlineObject51**](InlineObject51.md)|  | 

### Return type

[**Video**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.video+json
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The video was edited. |  -  |
| **400** | A parameter is invalid. |  -  |
| **403** | * The authenticated user doesn&#39;t own the video. * The **privacy** field is &#x60;disable&#x60;, and the authenticated user can&#39;t set extra embed options. * The **privacy** field is &#x60;contacts&#x60;, and the authenticated user can&#39;t follow creators. * The authenticated user has an opted-out Pro account, and **privacy.view** is &#x60;users&#x60;, &#x60;password&#x60;, &#x60;nobody&#x60;, or &#x60;public&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappearances"></a>
# **GetAppearances**
> List&lt;Video&gt; GetAppearances (decimal userId, string direction = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos in which the user appears

This method returns all the videos in which the authenticated user has a credited appearance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetAppearancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by date.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the videos in which the user appears
                List<Video> result = apiInstance.GetAppearances(userId, direction, filter, filterEmbeddable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.GetAppearances: " + e.Message );
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
 **userId** | **decimal**| The ID of the user. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;embeddable&#x60; - Return embeddable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappearancesalt1"></a>
# **GetAppearancesAlt1**
> List&lt;Video&gt; GetAppearancesAlt1 (string direction = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos in which the user appears

This method returns all the videos in which the authenticated user has a credited appearance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetAppearancesAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by date.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the videos in which the user appears
                List<Video> result = apiInstance.GetAppearancesAlt1(direction, filter, filterEmbeddable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.GetAppearancesAlt1: " + e.Message );
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
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;embeddable&#x60; - Return embeddable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideo"></a>
# **GetVideo**
> Video GetVideo (decimal videoId)

Get a specific video

This method returns a single video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a specific video
                Video result = apiInstance.GetVideo(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.GetVideo: " + e.Message );
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

[**Video**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The video was returned. |  -  |
| **404** | No such video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideos"></a>
# **GetVideos**
> List&lt;Video&gt; GetVideos (decimal userId, string containingUri = null, string direction = null, string filter = null, bool? filterEmbeddable = null, bool? filterPlayable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos that the user has uploaded

This method returns all the videos that the authenticated user has uploaded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var containingUri = /videos/258684937;  // string | The page that contains the video URI. The field is available only when not paired with **query**. (optional) 
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `app_only` - Return app-only videos.  * `embeddable` - Return embeddable videos.  * `featured` - Return featured videos.  * `playable` - Return playable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var filterPlayable = true;  // bool? | Whether to filter the results by playable videos (`true`) or non-playable videos (`false`). (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically by title.  * `date` - Sort the results by date.  * `default` - Use the default sorting method.  * `duration` - Sort the results by duration.  * `last_user_action_event_date` - Sort the results by last user interaction.  * `likes` - Sort the results by number of likes. To use this option, **direction** must be `desc`.  * `modified_time` - Sort the results by last modification.  * `plays` - Sort the results by number of plays. To use this option, **direction** must be `desc`.  (optional) 

            try
            {
                // Get all the videos that the user has uploaded
                List<Video> result = apiInstance.GetVideos(userId, containingUri, direction, filter, filterEmbeddable, filterPlayable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.GetVideos: " + e.Message );
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
 **userId** | **decimal**| The ID of the user. | 
 **containingUri** | **string**| The page that contains the video URI. The field is available only when not paired with **query**. | [optional] 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;app_only&#x60; - Return app-only videos.  * &#x60;embeddable&#x60; - Return embeddable videos.  * &#x60;featured&#x60; - Return featured videos.  * &#x60;playable&#x60; - Return playable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **filterPlayable** | **bool?**| Whether to filter the results by playable videos (&#x60;true&#x60;) or non-playable videos (&#x60;false&#x60;). | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically by title.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;default&#x60; - Use the default sorting method.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;last_user_action_event_date&#x60; - Sort the results by last user interaction.  * &#x60;likes&#x60; - Sort the results by number of likes. To use this option, **direction** must be &#x60;desc&#x60;.  * &#x60;modified_time&#x60; - Sort the results by last modification.  * &#x60;plays&#x60; - Sort the results by number of plays. To use this option, **direction** must be &#x60;desc&#x60;.  | [optional] 

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
| **304** | The authenticated user hasn&#39;t uploaded any videos since the given **If-Modified-Since** header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideosalt1"></a>
# **GetVideosAlt1**
> List&lt;Video&gt; GetVideosAlt1 (string containingUri = null, string direction = null, string filter = null, bool? filterEmbeddable = null, bool? filterPlayable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos that the user has uploaded

This method returns all the videos that the authenticated user has uploaded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideosAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var containingUri = /videos/258684937;  // string | The page that contains the video URI. The field is available only when not paired with **query**. (optional) 
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `app_only` - Return app-only videos.  * `embeddable` - Return embeddable videos.  * `featured` - Return featured videos.  * `playable` - Return playable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var filterPlayable = true;  // bool? | Whether to filter the results by playable videos (`true`) or non-playable videos (`false`). (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically by title.  * `date` - Sort the results by date.  * `default` - Use the default sorting method.  * `duration` - Sort the results by duration.  * `last_user_action_event_date` - Sort the results by last user interaction.  * `likes` - Sort the results by number of likes. To use this option, **direction** must be `desc`.  * `modified_time` - Sort the results by last modification.  * `plays` - Sort the results by number of plays. To use this option, **direction** must be `desc`.  (optional) 

            try
            {
                // Get all the videos that the user has uploaded
                List<Video> result = apiInstance.GetVideosAlt1(containingUri, direction, filter, filterEmbeddable, filterPlayable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.GetVideosAlt1: " + e.Message );
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
 **containingUri** | **string**| The page that contains the video URI. The field is available only when not paired with **query**. | [optional] 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;app_only&#x60; - Return app-only videos.  * &#x60;embeddable&#x60; - Return embeddable videos.  * &#x60;featured&#x60; - Return featured videos.  * &#x60;playable&#x60; - Return playable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **filterPlayable** | **bool?**| Whether to filter the results by playable videos (&#x60;true&#x60;) or non-playable videos (&#x60;false&#x60;). | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically by title.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;default&#x60; - Use the default sorting method.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;last_user_action_event_date&#x60; - Sort the results by last user interaction.  * &#x60;likes&#x60; - Sort the results by number of likes. To use this option, **direction** must be &#x60;desc&#x60;.  * &#x60;modified_time&#x60; - Sort the results by last modification.  * &#x60;plays&#x60; - Sort the results by number of plays. To use this option, **direction** must be &#x60;desc&#x60;.  | [optional] 

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
| **304** | The authenticated user hasn&#39;t uploaded any videos since the given **If-Modified-Since** header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchvideos"></a>
# **SearchVideos**
> List&lt;Video&gt; SearchVideos (string query, string direction = null, string filter = null, string links = null, decimal? page = null, decimal? perPage = null, string sort = null, string uris = null)

Search for videos

This method returns all the videos that match custom search criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SearchVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEssentialsApi(config);
            var query = staff picks;  // string | The search query.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results. `CC` and related filters target videos with the corresponding Creative Commons licenses. For more information, see our [Creative Commons](https://vimeo.com/creativecommons) page.  Option descriptions:  * `CC` - Return videos under any Creative Commons license.  * `CC-BY` - Return CC BY, or attribution-only, videos.  * `CC-BY-NC` - Return CC BY-NC, or Attribution-NonCommercial, videos.  * `CC-BY-NC-ND` - Return CC BY-NC-ND, or Attribution-NonCommercial-NoDerivs, videos.  * `CC-BY-NC-SA` - Return CC BY-NC-SA, or Attribution-NonCommercial-ShareAlike, videos.  * `CC-BY-ND` - Return CC BY-NDm or Attribution-NoDerivs, videos.  * `CC-BY-SA` - Return CC BY-SA, or Attribution-ShareAlike, videos.  * `CC0` - Return CC0, or public domain, videos.  * `categories` - Filter by categories.  * `duration` - Filter by duration.  * `in-progress` - Return in-progress videos.  * `minimum_likes` - Filter by minimum likes.  * `trending` - Return trending videos.  * `upload_date` - Filter by upload date.  (optional) 
            var links = https://vimeo.com/122375452,https://vimeo.com/273576296;  // string | A comma-separated list of video URLs to find. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by date.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `plays` - Sort the results by number of plays.  * `relevant` - Sort the results by relevance.  (optional) 
            var uris = /videos/122375452,/videos/273576296;  // string | A comma-separated list of video URIs to find. (optional) 

            try
            {
                // Search for videos
                List<Video> result = apiInstance.SearchVideos(query, direction, filter, links, page, perPage, sort, uris);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEssentialsApi.SearchVideos: " + e.Message );
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
 **query** | **string**| The search query. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results. &#x60;CC&#x60; and related filters target videos with the corresponding Creative Commons licenses. For more information, see our [Creative Commons](https://vimeo.com/creativecommons) page.  Option descriptions:  * &#x60;CC&#x60; - Return videos under any Creative Commons license.  * &#x60;CC-BY&#x60; - Return CC BY, or attribution-only, videos.  * &#x60;CC-BY-NC&#x60; - Return CC BY-NC, or Attribution-NonCommercial, videos.  * &#x60;CC-BY-NC-ND&#x60; - Return CC BY-NC-ND, or Attribution-NonCommercial-NoDerivs, videos.  * &#x60;CC-BY-NC-SA&#x60; - Return CC BY-NC-SA, or Attribution-NonCommercial-ShareAlike, videos.  * &#x60;CC-BY-ND&#x60; - Return CC BY-NDm or Attribution-NoDerivs, videos.  * &#x60;CC-BY-SA&#x60; - Return CC BY-SA, or Attribution-ShareAlike, videos.  * &#x60;CC0&#x60; - Return CC0, or public domain, videos.  * &#x60;categories&#x60; - Filter by categories.  * &#x60;duration&#x60; - Filter by duration.  * &#x60;in-progress&#x60; - Return in-progress videos.  * &#x60;minimum_likes&#x60; - Filter by minimum likes.  * &#x60;trending&#x60; - Return trending videos.  * &#x60;upload_date&#x60; - Filter by upload date.  | [optional] 
 **links** | **string**| A comma-separated list of video URLs to find. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;plays&#x60; - Sort the results by number of plays.  * &#x60;relevant&#x60; - Sort the results by relevance.  | [optional] 
 **uris** | **string**| A comma-separated list of video URIs to find. | [optional] 

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
| **200** | The search results were returned. |  -  |
| **400** | * Error code 2101: Either the **uris** or **links** parameter has filtering or sorting arguments. * Error code 2204: A problem occurred with the batch request. |  -  |
| **503** | * Search is disabled. * Error code 7300: An internal search error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


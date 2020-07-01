# VimeoOpenApi.Api.LikesEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckIfUserLikedVideo**](LikesEssentialsApi.md#checkifuserlikedvideo) | **GET** /users/{user_id}/likes/{video_id} | Check if the user has liked a video
[**CheckIfUserLikedVideoAlt1**](LikesEssentialsApi.md#checkifuserlikedvideoalt1) | **GET** /me/likes/{video_id} | Check if the user has liked a video
[**GetLikes**](LikesEssentialsApi.md#getlikes) | **GET** /users/{user_id}/likes | Get all the videos that a user has liked
[**GetLikesAlt1**](LikesEssentialsApi.md#getlikesalt1) | **GET** /me/likes | Get all the videos that a user has liked
[**GetVideoLikes**](LikesEssentialsApi.md#getvideolikes) | **GET** /videos/{video_id}/likes | Get all the users who have liked a video
[**GetVideoLikesAlt1**](LikesEssentialsApi.md#getvideolikesalt1) | **GET** /channels/{channel_id}/videos/{video_id}/likes | Get all the users who have liked a video
[**GetVodLikes**](LikesEssentialsApi.md#getvodlikes) | **GET** /ondemand/pages/{ondemand_id}/likes | Get all the users who have liked a video on an On Demand page
[**LikeVideo**](LikesEssentialsApi.md#likevideo) | **PUT** /users/{user_id}/likes/{video_id} | Cause the user to like a video
[**LikeVideoAlt1**](LikesEssentialsApi.md#likevideoalt1) | **PUT** /me/likes/{video_id} | Cause the user to like a video
[**UnlikeVideo**](LikesEssentialsApi.md#unlikevideo) | **DELETE** /users/{user_id}/likes/{video_id} | Cause a user to unlike a video
[**UnlikeVideoAlt1**](LikesEssentialsApi.md#unlikevideoalt1) | **DELETE** /me/likes/{video_id} | Cause a user to unlike a video


<a name="checkifuserlikedvideo"></a>
# **CheckIfUserLikedVideo**
> void CheckIfUserLikedVideo (decimal userId, decimal videoId)

Check if the user has liked a video

This method checks if the authenticated user has liked the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserLikedVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Check if the user has liked a video
                apiInstance.CheckIfUserLikedVideo(userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.CheckIfUserLikedVideo: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The user has liked the video. |  -  |
| **404** | The user hasn&#39;t liked the video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkifuserlikedvideoalt1"></a>
# **CheckIfUserLikedVideoAlt1**
> void CheckIfUserLikedVideoAlt1 (decimal videoId)

Check if the user has liked a video

This method checks if the authenticated user has liked the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserLikedVideoAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Check if the user has liked a video
                apiInstance.CheckIfUserLikedVideoAlt1(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.CheckIfUserLikedVideoAlt1: " + e.Message );
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
| **204** | The user has liked the video. |  -  |
| **404** | The user hasn&#39;t liked the video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlikes"></a>
# **GetLikes**
> List&lt;Video&gt; GetLikes (decimal userId, string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos that a user has liked

This method returns every video that the authenticated user has liked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetLikesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by creation date.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the videos that a user has liked
                List<Video> result = apiInstance.GetLikes(userId, filter, filterEmbeddable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.GetLikes: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;embeddable&#x60; - Return embeddable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by creation date.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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

<a name="getlikesalt1"></a>
# **GetLikesAlt1**
> List&lt;Video&gt; GetLikesAlt1 (string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos that a user has liked

This method returns every video that the authenticated user has liked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetLikesAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by creation date.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the videos that a user has liked
                List<Video> result = apiInstance.GetLikesAlt1(filter, filterEmbeddable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.GetLikesAlt1: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;embeddable&#x60; - Return embeddable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by creation date.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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

<a name="getvideolikes"></a>
# **GetVideoLikes**
> List&lt;User&gt; GetVideoLikes (decimal videoId, string direction = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the users who have liked a video

This method returns every user who has liked the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoLikesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by join date.  (optional) 

            try
            {
                // Get all the users who have liked a video
                List<User> result = apiInstance.GetVideoLikes(videoId, direction, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.GetVideoLikes: " + e.Message );
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
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by join date.  | [optional] 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.user+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The users were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideolikesalt1"></a>
# **GetVideoLikesAlt1**
> List&lt;User&gt; GetVideoLikesAlt1 (decimal channelId, decimal videoId, string direction = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the users who have liked a video

This method returns every user who has liked the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoLikesAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by join date.  (optional) 

            try
            {
                // Get all the users who have liked a video
                List<User> result = apiInstance.GetVideoLikesAlt1(channelId, videoId, direction, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.GetVideoLikesAlt1: " + e.Message );
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
 **channelId** | **decimal**| The ID of the channel. | 
 **videoId** | **decimal**| The ID of the video. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by join date.  | [optional] 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.user+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The users were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodlikes"></a>
# **GetVodLikes**
> List&lt;User&gt; GetVodLikes (decimal ondemandId, string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the users who have liked a video on an On Demand page

This method returns every user who has liked the specified video on an On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodLikesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `extra` - Consider extra content only.  * `main` - Consider main content only.  * `trailer` - Consider trailer content only.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by join date.  (optional) 

            try
            {
                // Get all the users who have liked a video on an On Demand page
                List<User> result = apiInstance.GetVodLikes(ondemandId, direction, filter, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.GetVodLikes: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;extra&#x60; - Consider extra content only.  * &#x60;main&#x60; - Consider main content only.  * &#x60;trailer&#x60; - Consider trailer content only.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by join date.  | [optional] 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.user+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The users were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="likevideo"></a>
# **LikeVideo**
> void LikeVideo (decimal userId, decimal videoId)

Cause the user to like a video

This method causes the authenticated user to like the specified video. The user can't like their own video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class LikeVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Cause the user to like a video
                apiInstance.LikeVideo(userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.LikeVideo: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The video was liked. |  -  |
| **400** | The authenticated user owns the video and can&#39;t like it. |  -  |
| **403** | The authenticated user can&#39;t like videos. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="likevideoalt1"></a>
# **LikeVideoAlt1**
> void LikeVideoAlt1 (decimal videoId)

Cause the user to like a video

This method causes the authenticated user to like the specified video. The user can't like their own video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class LikeVideoAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Cause the user to like a video
                apiInstance.LikeVideoAlt1(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.LikeVideoAlt1: " + e.Message );
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
| **204** | The video was liked. |  -  |
| **400** | The authenticated user owns the video and can&#39;t like it. |  -  |
| **403** | The authenticated user can&#39;t like videos. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlikevideo"></a>
# **UnlikeVideo**
> void UnlikeVideo (decimal userId, decimal videoId)

Cause a user to unlike a video

This method causes the authenticated user to unlike the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UnlikeVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Cause a user to unlike a video
                apiInstance.UnlikeVideo(userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.UnlikeVideo: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The video was unliked. |  -  |
| **403** | The authenticated user can&#39;t like videos. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlikevideoalt1"></a>
# **UnlikeVideoAlt1**
> void UnlikeVideoAlt1 (decimal videoId)

Cause a user to unlike a video

This method causes the authenticated user to unlike the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UnlikeVideoAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikesEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Cause a user to unlike a video
                apiInstance.UnlikeVideoAlt1(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LikesEssentialsApi.UnlikeVideoAlt1: " + e.Message );
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
| **204** | The video was unliked. |  -  |
| **403** | The authenticated user can&#39;t like videos. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


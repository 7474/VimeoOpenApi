# VimeoOpenApi.Api.WatchLaterQueueEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoToWatchLater**](WatchLaterQueueEssentialsApi.md#addvideotowatchlater) | **PUT** /users/{user_id}/watchlater/{video_id} | Add a video to the user&#39;s Watch Later queue
[**AddVideoToWatchLaterAlt1**](WatchLaterQueueEssentialsApi.md#addvideotowatchlateralt1) | **PUT** /me/watchlater/{video_id} | Add a video to the user&#39;s Watch Later queue
[**CheckWatchLaterQueue**](WatchLaterQueueEssentialsApi.md#checkwatchlaterqueue) | **GET** /users/{user_id}/watchlater/{video_id} | Check if the user has added a video to their Watch Later queue
[**CheckWatchLaterQueueAlt1**](WatchLaterQueueEssentialsApi.md#checkwatchlaterqueuealt1) | **GET** /me/watchlater/{video_id} | Check if the user has added a video to their Watch Later queue
[**DeleteVideoFromWatchLater**](WatchLaterQueueEssentialsApi.md#deletevideofromwatchlater) | **DELETE** /users/{user_id}/watchlater/{video_id} | Remove a video from the user&#39;s Watch Later queue
[**DeleteVideoFromWatchLaterAlt1**](WatchLaterQueueEssentialsApi.md#deletevideofromwatchlateralt1) | **DELETE** /me/watchlater/{video_id} | Remove a video from the user&#39;s Watch Later queue
[**GetWatchLaterQueue**](WatchLaterQueueEssentialsApi.md#getwatchlaterqueue) | **GET** /users/{user_id}/watchlater | Get all the videos in the user&#39;s Watch Later queue
[**GetWatchLaterQueueAlt1**](WatchLaterQueueEssentialsApi.md#getwatchlaterqueuealt1) | **GET** /me/watchlater | Get all the videos in the user&#39;s Watch Later queue


<a name="addvideotowatchlater"></a>
# **AddVideoToWatchLater**
> void AddVideoToWatchLater (decimal userId, decimal videoId)

Add a video to the user's Watch Later queue

This method adds the specified video to the authenticated user's Watch Later queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToWatchLaterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WatchLaterQueueEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add a video to the user's Watch Later queue
                apiInstance.AddVideoToWatchLater(userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WatchLaterQueueEssentialsApi.AddVideoToWatchLater: " + e.Message );
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
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The video was added. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideotowatchlateralt1"></a>
# **AddVideoToWatchLaterAlt1**
> void AddVideoToWatchLaterAlt1 (decimal videoId)

Add a video to the user's Watch Later queue

This method adds the specified video to the authenticated user's Watch Later queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToWatchLaterAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WatchLaterQueueEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add a video to the user's Watch Later queue
                apiInstance.AddVideoToWatchLaterAlt1(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WatchLaterQueueEssentialsApi.AddVideoToWatchLaterAlt1: " + e.Message );
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
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The video was added. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkwatchlaterqueue"></a>
# **CheckWatchLaterQueue**
> Video CheckWatchLaterQueue (decimal userId, decimal videoId)

Check if the user has added a video to their Watch Later queue

This method checks the authenticated user's Watch Later queue for the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckWatchLaterQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WatchLaterQueueEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Check if the user has added a video to their Watch Later queue
                Video result = apiInstance.CheckWatchLaterQueue(userId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WatchLaterQueueEssentialsApi.CheckWatchLaterQueue: " + e.Message );
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
| **200** | The video is in the user&#39;s Watch Later queue. |  -  |
| **404** | The video isn&#39;t in the user&#39;s Watch Later queue. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkwatchlaterqueuealt1"></a>
# **CheckWatchLaterQueueAlt1**
> Video CheckWatchLaterQueueAlt1 (decimal videoId)

Check if the user has added a video to their Watch Later queue

This method checks the authenticated user's Watch Later queue for the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckWatchLaterQueueAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WatchLaterQueueEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Check if the user has added a video to their Watch Later queue
                Video result = apiInstance.CheckWatchLaterQueueAlt1(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WatchLaterQueueEssentialsApi.CheckWatchLaterQueueAlt1: " + e.Message );
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
| **200** | The video is in the user&#39;s Watch Later queue. |  -  |
| **404** | The video isn&#39;t in the user&#39;s Watch Later queue. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideofromwatchlater"></a>
# **DeleteVideoFromWatchLater**
> void DeleteVideoFromWatchLater (decimal userId, decimal videoId)

Remove a video from the user's Watch Later queue

This method removes the specified video from the authenticated user's Watch Later queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoFromWatchLaterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WatchLaterQueueEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Remove a video from the user's Watch Later queue
                apiInstance.DeleteVideoFromWatchLater(userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WatchLaterQueueEssentialsApi.DeleteVideoFromWatchLater: " + e.Message );
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
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The video was removed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideofromwatchlateralt1"></a>
# **DeleteVideoFromWatchLaterAlt1**
> void DeleteVideoFromWatchLaterAlt1 (decimal videoId)

Remove a video from the user's Watch Later queue

This method removes the specified video from the authenticated user's Watch Later queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoFromWatchLaterAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WatchLaterQueueEssentialsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Remove a video from the user's Watch Later queue
                apiInstance.DeleteVideoFromWatchLaterAlt1(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WatchLaterQueueEssentialsApi.DeleteVideoFromWatchLaterAlt1: " + e.Message );
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
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The video was removed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwatchlaterqueue"></a>
# **GetWatchLaterQueue**
> List&lt;Video&gt; GetWatchLaterQueue (decimal userId, string direction = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos in the user's Watch Later queue

This method returns every video from the authenticated user's Watch Later queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetWatchLaterQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WatchLaterQueueEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by date added.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the videos in the user's Watch Later queue
                List<Video> result = apiInstance.GetWatchLaterQueue(userId, direction, filter, filterEmbeddable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WatchLaterQueueEssentialsApi.GetWatchLaterQueue: " + e.Message );
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
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by date added.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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
| **304** | The user hasn&#39;t added any videos to their Watch Later queue since the given &#x60;If-Modified-Since&#x60; header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwatchlaterqueuealt1"></a>
# **GetWatchLaterQueueAlt1**
> List&lt;Video&gt; GetWatchLaterQueueAlt1 (string direction = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos in the user's Watch Later queue

This method returns every video from the authenticated user's Watch Later queue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetWatchLaterQueueAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WatchLaterQueueEssentialsApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by date added.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the videos in the user's Watch Later queue
                List<Video> result = apiInstance.GetWatchLaterQueueAlt1(direction, filter, filterEmbeddable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WatchLaterQueueEssentialsApi.GetWatchLaterQueueAlt1: " + e.Message );
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
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by date added.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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
| **304** | The user hasn&#39;t added any videos to their Watch Later queue since the given &#x60;If-Modified-Since&#x60; header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


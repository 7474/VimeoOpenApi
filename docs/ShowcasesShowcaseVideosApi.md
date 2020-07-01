# VimeoOpenApi.Api.ShowcasesShowcaseVideosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoToShowcase**](ShowcasesShowcaseVideosApi.md#addvideotoshowcase) | **PUT** /users/{user_id}/albums/{album_id}/videos/{video_id} | Add a specific video to a showcase
[**AddVideoToShowcaseAlt1**](ShowcasesShowcaseVideosApi.md#addvideotoshowcasealt1) | **PUT** /me/albums/{album_id}/videos/{video_id} | Add a specific video to a showcase
[**GetAvailableShowcaseVideos**](ShowcasesShowcaseVideosApi.md#getavailableshowcasevideos) | **GET** /albums/{album_id}/available_videos | Get all the user&#39;s videos that can be added to or removed from a showcase
[**GetAvailableVideoShowcases**](ShowcasesShowcaseVideosApi.md#getavailablevideoshowcases) | **GET** /videos/{video_id}/available_albums | Get all the showcases to which the user can add or remove a specific video
[**GetShowcaseVideo**](ShowcasesShowcaseVideosApi.md#getshowcasevideo) | **GET** /users/{user_id}/albums/{album_id}/videos/{video_id} | Get a specific video in a showcase
[**GetShowcaseVideoAlt1**](ShowcasesShowcaseVideosApi.md#getshowcasevideoalt1) | **GET** /me/albums/{album_id}/videos/{video_id} | Get a specific video in a showcase
[**GetShowcaseVideos**](ShowcasesShowcaseVideosApi.md#getshowcasevideos) | **GET** /users/{user_id}/albums/{album_id}/videos | Get all the videos in a showcase
[**GetShowcaseVideosAlt1**](ShowcasesShowcaseVideosApi.md#getshowcasevideosalt1) | **GET** /me/albums/{album_id}/videos | Get all the videos in a showcase
[**RemoveVideoFromShowcase**](ShowcasesShowcaseVideosApi.md#removevideofromshowcase) | **DELETE** /users/{user_id}/albums/{album_id}/videos/{video_id} | Remove a video from a showcase
[**RemoveVideoFromShowcaseAlt1**](ShowcasesShowcaseVideosApi.md#removevideofromshowcasealt1) | **DELETE** /me/albums/{album_id}/videos/{video_id} | Remove a video from a showcase
[**ReplaceVideosInShowcase**](ShowcasesShowcaseVideosApi.md#replacevideosinshowcase) | **PUT** /users/{user_id}/albums/{album_id}/videos | Replace all the videos in a showcase
[**ReplaceVideosInShowcaseAlt1**](ShowcasesShowcaseVideosApi.md#replacevideosinshowcasealt1) | **PUT** /me/albums/{album_id}/videos | Replace all the videos in a showcase
[**SetVideoAsShowcaseFeatured**](ShowcasesShowcaseVideosApi.md#setvideoasshowcasefeatured) | **PATCH** /users/{user_id}/albums/{album_id}/videos/{video_id}/set_featured_video | Set the featured video of a showcase
[**SetVideoAsShowcaseFeaturedAlt1**](ShowcasesShowcaseVideosApi.md#setvideoasshowcasefeaturedalt1) | **PATCH** /me/albums/{album_id}/videos/{video_id}/set_featured_video | Set the featured video of a showcase
[**SetVideoAsShowcaseThumbnail**](ShowcasesShowcaseVideosApi.md#setvideoasshowcasethumbnail) | **POST** /users/{user_id}/albums/{album_id}/videos/{video_id}/set_album_thumbnail | Create a thumbnail for a showcase from a showcase video
[**SetVideoAsShowcaseThumbnailAlt1**](ShowcasesShowcaseVideosApi.md#setvideoasshowcasethumbnailalt1) | **POST** /me/albums/{album_id}/videos/{video_id}/set_album_thumbnail | Create a thumbnail for a showcase from a showcase video


<a name="addvideotoshowcase"></a>
# **AddVideoToShowcase**
> void AddVideoToShowcase (decimal albumId, decimal userId, decimal videoId)

Add a specific video to a showcase

This method adds a single video to the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToShowcaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 12345;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 196367152;  // decimal | The ID of the video.

            try
            {
                // Add a specific video to a showcase
                apiInstance.AddVideoToShowcase(albumId, userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.AddVideoToShowcase: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
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
| **204** | The video was added. |  -  |
| **403** | The supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t add videos to the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideotoshowcasealt1"></a>
# **AddVideoToShowcaseAlt1**
> void AddVideoToShowcaseAlt1 (decimal albumId, decimal videoId)

Add a specific video to a showcase

This method adds a single video to the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToShowcaseAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 12345;  // decimal | The ID of the showcase.
            var videoId = 196367152;  // decimal | The ID of the video.

            try
            {
                // Add a specific video to a showcase
                apiInstance.AddVideoToShowcaseAlt1(albumId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.AddVideoToShowcaseAlt1: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
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
| **204** | The video was added. |  -  |
| **403** | The supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t add videos to the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailableshowcasevideos"></a>
# **GetAvailableShowcaseVideos**
> List&lt;Video&gt; GetAvailableShowcaseVideos (decimal albumId, string direction = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the user's videos that can be added to or removed from a showcase

This endpoint returns every video belonging to the authenticated user that can be added to or removed from the specified showcase. The user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetAvailableShowcaseVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by date.  * `default` - Sort the results by the default method.  * `duration` - Sort the results by duration.  * `last_user_action_event_date` - Sort the results by most recent user interaction.  * `likes` - Sort the results by number of likes.  * `modified_time` - Sort the results by last modification.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the user's videos that can be added to or removed from a showcase
                List<Video> result = apiInstance.GetAvailableShowcaseVideos(albumId, direction, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.GetAvailableShowcaseVideos: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;default&#x60; - Sort the results by the default method.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;last_user_action_event_date&#x60; - Sort the results by most recent user interaction.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;modified_time&#x60; - Sort the results by last modification.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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
| **403** | Error code 3433: The authenticated user can&#39;t add videos to this showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailablevideoshowcases"></a>
# **GetAvailableVideoShowcases**
> List&lt;Album&gt; GetAvailableVideoShowcases (decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the showcases to which the user can add or remove a specific video

This endpoint returns every showcase to which the authenticated user can add or remove the specified video. The user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetAvailableVideoShowcasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the showcases to which the user can add or remove a specific video
                List<Album> result = apiInstance.GetAvailableVideoShowcases(videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.GetAvailableVideoShowcases: " + e.Message );
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
| **403** | Error code 3433: The authenticated user can&#39;t add the video to or remove the video from any showcases. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcasevideo"></a>
# **GetShowcaseVideo**
> Video GetShowcaseVideo (decimal albumId, decimal userId, decimal videoId, string password = null)

Get a specific video in a showcase

This method returns a single video belonging to the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 196367152;  // decimal | The ID of the video.
            var password = hunter1;  // string | The password of the showcase. (optional) 

            try
            {
                // Get a specific video in a showcase
                Video result = apiInstance.GetShowcaseVideo(albumId, userId, videoId, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.GetShowcaseVideo: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **userId** | **decimal**| The ID of the user. | 
 **videoId** | **decimal**| The ID of the video. | 
 **password** | **string**| The password of the showcase. | [optional] 

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
| **404** | No such showcase exists, or the video doesn&#39;t belong to it. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcasevideoalt1"></a>
# **GetShowcaseVideoAlt1**
> Video GetShowcaseVideoAlt1 (decimal albumId, decimal videoId, string password = null)

Get a specific video in a showcase

This method returns a single video belonging to the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseVideoAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var videoId = 196367152;  // decimal | The ID of the video.
            var password = hunter1;  // string | The password of the showcase. (optional) 

            try
            {
                // Get a specific video in a showcase
                Video result = apiInstance.GetShowcaseVideoAlt1(albumId, videoId, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.GetShowcaseVideoAlt1: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **videoId** | **decimal**| The ID of the video. | 
 **password** | **string**| The password of the showcase. | [optional] 

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
| **404** | No such showcase exists, or the video doesn&#39;t belong to it. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcasevideos"></a>
# **GetShowcaseVideos**
> List&lt;Video&gt; GetShowcaseVideos (decimal albumId, decimal userId, string containingUri = null, string direction = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, string password = null, decimal? perPage = null, string query = null, string sort = null, bool? weakSearch = null)

Get all the videos in a showcase

This method returns every video in the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var containingUri = /videos/258684937;  // string | The page containing the video URI. (optional) 
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Filter the results by the **embeddable** attribute.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var password = hunter1;  // string | The password of the showcase. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by date.  * `default` - Sort the results by the default method.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `manual` - Sort the results by their manual order.  * `modified_time` - Sort the results by last modification.  * `plays` - Sort the results by number of plays.  (optional) 
            var weakSearch = false;  // bool? | Whether to include private videos in the search. Please note that a separate search service provides this functionality. The service performs a partial text search on the video's name. (optional) 

            try
            {
                // Get all the videos in a showcase
                List<Video> result = apiInstance.GetShowcaseVideos(albumId, userId, containingUri, direction, filter, filterEmbeddable, page, password, perPage, query, sort, weakSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.GetShowcaseVideos: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **userId** | **decimal**| The ID of the user. | 
 **containingUri** | **string**| The page containing the video URI. | [optional] 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;embeddable&#x60; - Filter the results by the **embeddable** attribute.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **password** | **string**| The password of the showcase. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;default&#x60; - Sort the results by the default method.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;manual&#x60; - Sort the results by their manual order.  * &#x60;modified_time&#x60; - Sort the results by last modification.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 
 **weakSearch** | **bool?**| Whether to include private videos in the search. Please note that a separate search service provides this functionality. The service performs a partial text search on the video&#39;s name. | [optional] 

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
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcasevideosalt1"></a>
# **GetShowcaseVideosAlt1**
> List&lt;Video&gt; GetShowcaseVideosAlt1 (decimal albumId, string containingUri = null, string direction = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, string password = null, decimal? perPage = null, string query = null, string sort = null, bool? weakSearch = null)

Get all the videos in a showcase

This method returns every video in the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseVideosAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var containingUri = /videos/258684937;  // string | The page containing the video URI. (optional) 
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Filter the results by the **embeddable** attribute.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var password = hunter1;  // string | The password of the showcase. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by date.  * `default` - Sort the results by the default method.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `manual` - Sort the results by their manual order.  * `modified_time` - Sort the results by last modification.  * `plays` - Sort the results by number of plays.  (optional) 
            var weakSearch = false;  // bool? | Whether to include private videos in the search. Please note that a separate search service provides this functionality. The service performs a partial text search on the video's name. (optional) 

            try
            {
                // Get all the videos in a showcase
                List<Video> result = apiInstance.GetShowcaseVideosAlt1(albumId, containingUri, direction, filter, filterEmbeddable, page, password, perPage, query, sort, weakSearch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.GetShowcaseVideosAlt1: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **containingUri** | **string**| The page containing the video URI. | [optional] 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;embeddable&#x60; - Filter the results by the **embeddable** attribute.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **password** | **string**| The password of the showcase. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;default&#x60; - Sort the results by the default method.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;manual&#x60; - Sort the results by their manual order.  * &#x60;modified_time&#x60; - Sort the results by last modification.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 
 **weakSearch** | **bool?**| Whether to include private videos in the search. Please note that a separate search service provides this functionality. The service performs a partial text search on the video&#39;s name. | [optional] 

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
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removevideofromshowcase"></a>
# **RemoveVideoFromShowcase**
> void RemoveVideoFromShowcase (decimal albumId, decimal userId, decimal videoId)

Remove a video from a showcase

This method removes the specified video from its showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class RemoveVideoFromShowcaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 12345;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 196367152;  // decimal | The ID of the video.

            try
            {
                // Remove a video from a showcase
                apiInstance.RemoveVideoFromShowcase(albumId, userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.RemoveVideoFromShowcase: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
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
| **204** | The video was removed. |  -  |
| **403** | The supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t remove videos from the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removevideofromshowcasealt1"></a>
# **RemoveVideoFromShowcaseAlt1**
> void RemoveVideoFromShowcaseAlt1 (decimal albumId, decimal videoId)

Remove a video from a showcase

This method removes the specified video from its showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class RemoveVideoFromShowcaseAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 12345;  // decimal | The ID of the showcase.
            var videoId = 196367152;  // decimal | The ID of the video.

            try
            {
                // Remove a video from a showcase
                apiInstance.RemoveVideoFromShowcaseAlt1(albumId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.RemoveVideoFromShowcaseAlt1: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
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
| **204** | The video was removed. |  -  |
| **403** | The supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t remove videos from the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacevideosinshowcase"></a>
# **ReplaceVideosInShowcase**
> void ReplaceVideosInShowcase (decimal albumId, decimal userId, InlineObject42 inlineObject42)

Replace all the videos in a showcase

This method replaces all the videos in the specified showcase with a new set of one or more videos. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class ReplaceVideosInShowcaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject42 = new InlineObject42(); // InlineObject42 | 

            try
            {
                // Replace all the videos in a showcase
                apiInstance.ReplaceVideosInShowcase(albumId, userId, inlineObject42);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.ReplaceVideosInShowcase: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **userId** | **decimal**| The ID of the user. | 
 **inlineObject42** | [**InlineObject42**](InlineObject42.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The videos were added. |  -  |
| **403** | The authenticated user can&#39;t add videos to the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacevideosinshowcasealt1"></a>
# **ReplaceVideosInShowcaseAlt1**
> void ReplaceVideosInShowcaseAlt1 (decimal albumId, InlineObject18 inlineObject18)

Replace all the videos in a showcase

This method replaces all the videos in the specified showcase with a new set of one or more videos. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class ReplaceVideosInShowcaseAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var inlineObject18 = new InlineObject18(); // InlineObject18 | 

            try
            {
                // Replace all the videos in a showcase
                apiInstance.ReplaceVideosInShowcaseAlt1(albumId, inlineObject18);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.ReplaceVideosInShowcaseAlt1: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **inlineObject18** | [**InlineObject18**](InlineObject18.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The videos were added. |  -  |
| **403** | The authenticated user can&#39;t add videos to the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setvideoasshowcasefeatured"></a>
# **SetVideoAsShowcaseFeatured**
> Album SetVideoAsShowcaseFeatured (decimal albumId, decimal userId, decimal videoId)

Set the featured video of a showcase

This method sets the featured video of the specified showcase. The authenticated user must be the owner of the showcase, and the featured video must belong to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SetVideoAsShowcaseFeaturedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 12345;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 196367152;  // decimal | The ID of the video.

            try
            {
                // Set the featured video of a showcase
                Album result = apiInstance.SetVideoAsShowcaseFeatured(albumId, userId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.SetVideoAsShowcaseFeatured: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **userId** | **decimal**| The ID of the user. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The video is now the featured video of the showcase. |  -  |
| **403** | Error code 3429: The authenticated user can&#39;t set the featured video of this showcase. |  -  |
| **404** | Error code 5000: No such showcase, user, or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setvideoasshowcasefeaturedalt1"></a>
# **SetVideoAsShowcaseFeaturedAlt1**
> Album SetVideoAsShowcaseFeaturedAlt1 (decimal albumId, decimal videoId)

Set the featured video of a showcase

This method sets the featured video of the specified showcase. The authenticated user must be the owner of the showcase, and the featured video must belong to it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SetVideoAsShowcaseFeaturedAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 12345;  // decimal | The ID of the showcase.
            var videoId = 196367152;  // decimal | The ID of the video.

            try
            {
                // Set the featured video of a showcase
                Album result = apiInstance.SetVideoAsShowcaseFeaturedAlt1(albumId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.SetVideoAsShowcaseFeaturedAlt1: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The video is now the featured video of the showcase. |  -  |
| **403** | Error code 3429: The authenticated user can&#39;t set the featured video of this showcase. |  -  |
| **404** | Error code 5000: No such showcase, user, or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setvideoasshowcasethumbnail"></a>
# **SetVideoAsShowcaseThumbnail**
> Album SetVideoAsShowcaseThumbnail (decimal albumId, decimal userId, decimal videoId, InlineObject43 inlineObject43 = null)

Create a thumbnail for a showcase from a showcase video

This method creates a thumbnail image for a showcase from the specified frame of a showcase video. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SetVideoAsShowcaseThumbnailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 12345;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 196367152;  // decimal | The ID of the video.
            var inlineObject43 = new InlineObject43(); // InlineObject43 |  (optional) 

            try
            {
                // Create a thumbnail for a showcase from a showcase video
                Album result = apiInstance.SetVideoAsShowcaseThumbnail(albumId, userId, videoId, inlineObject43);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.SetVideoAsShowcaseThumbnail: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **userId** | **decimal**| The ID of the user. | 
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject43** | [**InlineObject43**](InlineObject43.md)|  | [optional] 

### Return type

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The showcase thumbnail was created. |  -  |
| **403** | Error code 3429: The authenticated user can&#39;t create a thumbnail for this showcase. |  -  |
| **404** | Error code 5000: No such showcase, user, or video exists. |  -  |
| **500** | Error code 4016: An unexpected error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setvideoasshowcasethumbnailalt1"></a>
# **SetVideoAsShowcaseThumbnailAlt1**
> Album SetVideoAsShowcaseThumbnailAlt1 (decimal albumId, decimal videoId, InlineObject19 inlineObject19 = null)

Create a thumbnail for a showcase from a showcase video

This method creates a thumbnail image for a showcase from the specified frame of a showcase video. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SetVideoAsShowcaseThumbnailAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesShowcaseVideosApi(config);
            var albumId = 12345;  // decimal | The ID of the showcase.
            var videoId = 196367152;  // decimal | The ID of the video.
            var inlineObject19 = new InlineObject19(); // InlineObject19 |  (optional) 

            try
            {
                // Create a thumbnail for a showcase from a showcase video
                Album result = apiInstance.SetVideoAsShowcaseThumbnailAlt1(albumId, videoId, inlineObject19);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesShowcaseVideosApi.SetVideoAsShowcaseThumbnailAlt1: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject19** | [**InlineObject19**](InlineObject19.md)|  | [optional] 

### Return type

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The showcase thumbnail was created. |  -  |
| **403** | Error code 3429: The authenticated user can&#39;t create a thumbnail for this showcase. |  -  |
| **404** | Error code 5000: No such showcase, user, or video exists. |  -  |
| **500** | Error code 4016: An unexpected error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


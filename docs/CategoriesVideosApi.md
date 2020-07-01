# VimeoOpenApi.Api.CategoriesVideosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckCategoryForVideo**](CategoriesVideosApi.md#checkcategoryforvideo) | **GET** /categories/{category}/videos/{video_id} | Get a specific video in a category
[**GetCategoryVideos**](CategoriesVideosApi.md#getcategoryvideos) | **GET** /categories/{category}/videos | Get all the videos in a category
[**GetVideoCategories**](CategoriesVideosApi.md#getvideocategories) | **GET** /videos/{video_id}/categories | Get all the categories to which a video belongs
[**SuggestVideoCategory**](CategoriesVideosApi.md#suggestvideocategory) | **PUT** /videos/{video_id}/categories | Suggest categories for a video


<a name="checkcategoryforvideo"></a>
# **CheckCategoryForVideo**
> Video CheckCategoryForVideo (string category, decimal videoId)

Get a specific video in a category

This method returns a single video in the specified category. You can use this method to determine whether the video belongs to the category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckCategoryForVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesVideosApi(config);
            var category = animation;  // string | The name of the category.
            var videoId = 273576296;  // decimal | The ID of the video.

            try
            {
                // Get a specific video in a category
                Video result = apiInstance.CheckCategoryForVideo(category, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesVideosApi.CheckCategoryForVideo: " + e.Message );
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
 **category** | **string**| The name of the category. | 
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
| **404** | No such category exists, or the video doesn&#39;t belong to it. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategoryvideos"></a>
# **GetCategoryVideos**
> List&lt;Video&gt; GetCategoryVideos (string category, string direction = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos in a category

This method returns every video that belongs to the specified category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCategoryVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesVideosApi(config);
            var category = animation;  // string | The name of the category.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `conditional_featured` - Return featured videos.  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by date.  * `duration` - Sort the results by duration.  * `featured` - Sort the results by featured status.  * `likes` - Sort the results by number of likes.  * `plays` - Sort the results by number of plays.  * `relevant` - Sort the results by relevance.  (optional) 

            try
            {
                // Get all the videos in a category
                List<Video> result = apiInstance.GetCategoryVideos(category, direction, filter, filterEmbeddable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesVideosApi.GetCategoryVideos: " + e.Message );
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
 **category** | **string**| The name of the category. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;conditional_featured&#x60; - Return featured videos.  * &#x60;embeddable&#x60; - Return embeddable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;featured&#x60; - Sort the results by featured status.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;plays&#x60; - Sort the results by number of plays.  * &#x60;relevant&#x60; - Sort the results by relevance.  | [optional] 

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
| **404** | No such category exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideocategories"></a>
# **GetVideoCategories**
> List&lt;Category&gt; GetVideoCategories (decimal videoId)

Get all the categories to which a video belongs

This method returns every category that contains the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesVideosApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get all the categories to which a video belongs
                List<Category> result = apiInstance.GetVideoCategories(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesVideosApi.GetVideoCategories: " + e.Message );
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

[**List&lt;Category&gt;**](Category.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.category+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The categories were returned. |  -  |
| **404** | No such video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggestvideocategory"></a>
# **SuggestVideoCategory**
> Category SuggestVideoCategory (decimal videoId, InlineObject53 inlineObject53)

Suggest categories for a video

This method suggests up to two categories and one subcategory for the specified video. The authenticated user must be the owner of the video. Vimeo makes the final determination about whether the video belongs in these categories.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SuggestVideoCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesVideosApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject53 = new InlineObject53(); // InlineObject53 | 

            try
            {
                // Suggest categories for a video
                Category result = apiInstance.SuggestVideoCategory(videoId, inlineObject53);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesVideosApi.SuggestVideoCategory: " + e.Message );
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
 **inlineObject53** | [**InlineObject53**](InlineObject53.md)|  | 

### Return type

[**Category**](Category.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.category+json
 - **Accept**: application/vnd.vimeo.category+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The categories were suggested. |  -  |
| **403** | The authenticated user doesn&#39;t own this video. |  -  |
| **404** | No such video exists, or no such category exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


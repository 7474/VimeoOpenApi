# VimeoOpenApi.Api.UsersFeedsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFeed**](UsersFeedsApi.md#getfeed) | **GET** /users/{user_id}/feed | Get all the videos in the user&#39;s feed
[**GetFeedAlt1**](UsersFeedsApi.md#getfeedalt1) | **GET** /me/feed | Get all the videos in the user&#39;s feed


<a name="getfeed"></a>
# **GetFeed**
> List&lt;Activity31&gt; GetFeed (decimal userId, string offset = null, decimal? page = null, decimal? perPage = null, string type = null)

Get all the videos in the user's feed

This method returns every video in the authenticated user's feed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetFeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFeedsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var offset = 280;  // string | The pagination offset. We recommend that you use the pagination links in the feed response instead of working with this value directly. For more details, see our [pagination documentation](https://developer.vimeo.com/api/common-formats#using-the-pagination-parameter). (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var type = type_example;  // string | The feed type.  Option descriptions:  * `appears` - Videos in which the user appears.  * `category_featured` - Featured videos.  * `channel` - Channel videos.  * `facebook_feed` - Videos from the user's Facebook feed.  * `following` - Videos from accounts that the user follows.  * `group` - Group videos.  * `likes` - Liked videos.  * `ondemand_publish` - On Demand videos.  * `share` - Shared videos.  * `tagged_with` - Tagged videos.  * `twitter_timeline` - Videos from the user's Twitter timeline.  * `uploads` - Uploaded videos.  (optional) 

            try
            {
                // Get all the videos in the user's feed
                List<Activity31> result = apiInstance.GetFeed(userId, offset, page, perPage, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFeedsApi.GetFeed: " + e.Message );
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
 **offset** | **string**| The pagination offset. We recommend that you use the pagination links in the feed response instead of working with this value directly. For more details, see our [pagination documentation](https://developer.vimeo.com/api/common-formats#using-the-pagination-parameter). | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **type** | **string**| The feed type.  Option descriptions:  * &#x60;appears&#x60; - Videos in which the user appears.  * &#x60;category_featured&#x60; - Featured videos.  * &#x60;channel&#x60; - Channel videos.  * &#x60;facebook_feed&#x60; - Videos from the user&#39;s Facebook feed.  * &#x60;following&#x60; - Videos from accounts that the user follows.  * &#x60;group&#x60; - Group videos.  * &#x60;likes&#x60; - Liked videos.  * &#x60;ondemand_publish&#x60; - On Demand videos.  * &#x60;share&#x60; - Shared videos.  * &#x60;tagged_with&#x60; - Tagged videos.  * &#x60;twitter_timeline&#x60; - Videos from the user&#39;s Twitter timeline.  * &#x60;uploads&#x60; - Uploaded videos.  | [optional] 

### Return type

[**List&lt;Activity31&gt;**](Activity31.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.activity+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The videos were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeedalt1"></a>
# **GetFeedAlt1**
> List&lt;Activity31&gt; GetFeedAlt1 (string offset = null, decimal? page = null, decimal? perPage = null, string type = null)

Get all the videos in the user's feed

This method returns every video in the authenticated user's feed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetFeedAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFeedsApi(config);
            var offset = 280;  // string | The pagination offset. We recommend that you use the pagination links in the feed response instead of working with this value directly. For more details, see our [pagination documentation](https://developer.vimeo.com/api/common-formats#using-the-pagination-parameter). (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var type = type_example;  // string | The feed type.  Option descriptions:  * `appears` - Videos in which the user appears.  * `category_featured` - Featured videos.  * `channel` - Channel videos.  * `facebook_feed` - Videos from the user's Facebook feed.  * `following` - Videos from accounts that the user follows.  * `group` - Group videos.  * `likes` - Liked videos.  * `ondemand_publish` - On Demand videos.  * `share` - Shared videos.  * `tagged_with` - Tagged videos.  * `twitter_timeline` - Videos from the user's Twitter timeline.  * `uploads` - Uploaded videos.  (optional) 

            try
            {
                // Get all the videos in the user's feed
                List<Activity31> result = apiInstance.GetFeedAlt1(offset, page, perPage, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFeedsApi.GetFeedAlt1: " + e.Message );
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
 **offset** | **string**| The pagination offset. We recommend that you use the pagination links in the feed response instead of working with this value directly. For more details, see our [pagination documentation](https://developer.vimeo.com/api/common-formats#using-the-pagination-parameter). | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **type** | **string**| The feed type.  Option descriptions:  * &#x60;appears&#x60; - Videos in which the user appears.  * &#x60;category_featured&#x60; - Featured videos.  * &#x60;channel&#x60; - Channel videos.  * &#x60;facebook_feed&#x60; - Videos from the user&#39;s Facebook feed.  * &#x60;following&#x60; - Videos from accounts that the user follows.  * &#x60;group&#x60; - Group videos.  * &#x60;likes&#x60; - Liked videos.  * &#x60;ondemand_publish&#x60; - On Demand videos.  * &#x60;share&#x60; - Shared videos.  * &#x60;tagged_with&#x60; - Tagged videos.  * &#x60;twitter_timeline&#x60; - Videos from the user&#39;s Twitter timeline.  * &#x60;uploads&#x60; - Uploaded videos.  | [optional] 

### Return type

[**List&lt;Activity31&gt;**](Activity31.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.activity+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The videos were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


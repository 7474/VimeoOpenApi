# VimeoOpenApi.Api.ChannelsVideosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoToChannel**](ChannelsVideosApi.md#addvideotochannel) | **PUT** /channels/{channel_id}/videos/{video_id} | Add a specific video to a channel
[**AddVideosToChannel**](ChannelsVideosApi.md#addvideostochannel) | **PUT** /channels/{channel_id}/videos | Add a list of videos to a channel
[**DeleteVideoFromChannel**](ChannelsVideosApi.md#deletevideofromchannel) | **DELETE** /channels/{channel_id}/videos/{video_id} | Remove a specific video from a channel
[**GetAvailableVideoChannels**](ChannelsVideosApi.md#getavailablevideochannels) | **GET** /videos/{video_id}/available_channels | Get all the channels to which the user can add or remove a specific video
[**GetChannelVideo**](ChannelsVideosApi.md#getchannelvideo) | **GET** /channels/{channel_id}/videos/{video_id} | Get a specific video in a channel
[**GetChannelVideos**](ChannelsVideosApi.md#getchannelvideos) | **GET** /channels/{channel_id}/videos | Get all the videos in a channel
[**RemoveVideosFromChannel**](ChannelsVideosApi.md#removevideosfromchannel) | **DELETE** /channels/{channel_id}/videos | Remove a list of videos from a channel


<a name="addvideotochannel"></a>
# **AddVideoToChannel**
> void AddVideoToChannel (decimal channelId, decimal videoId)

Add a specific video to a channel

This method adds a single video to the specified channel. The authenticated user must be a moderator of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsVideosApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add a specific video to a channel
                apiInstance.AddVideoToChannel(channelId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsVideosApi.AddVideoToChannel: " + e.Message );
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
| **403** | The video can&#39;t be added to a channel, or the authenticated user can&#39;t add videos to this channel. |  -  |
| **404** | No such channel or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideostochannel"></a>
# **AddVideosToChannel**
> void AddVideosToChannel (decimal channelId, InlineObject8 inlineObject8)

Add a list of videos to a channel

This method adds multiple videos to the specified channel. The authenticated user must be a moderator of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideosToChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsVideosApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var inlineObject8 = new InlineObject8(); // InlineObject8 | 

            try
            {
                // Add a list of videos to a channel
                apiInstance.AddVideosToChannel(channelId, inlineObject8);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsVideosApi.AddVideosToChannel: " + e.Message );
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
 **inlineObject8** | [**InlineObject8**](InlineObject8.md)|  | 

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
| **200** | The videos were added. |  -  |
| **403** | The authenticated user can&#39;t add videos to the channel, or a video can&#39;t be added to the channel. |  -  |
| **404** | No such channel or user exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideofromchannel"></a>
# **DeleteVideoFromChannel**
> void DeleteVideoFromChannel (decimal channelId, decimal videoId)

Remove a specific video from a channel

This method removes a single video from the specified channel. The authenticated user must be a moderator of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoFromChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsVideosApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Remove a specific video from a channel
                apiInstance.DeleteVideoFromChannel(channelId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsVideosApi.DeleteVideoFromChannel: " + e.Message );
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
| **403** | The authenticated user can&#39;t remove videos from this channel, or the video can&#39;t be removed from the channel. |  -  |
| **404** | No such channel or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailablevideochannels"></a>
# **GetAvailableVideoChannels**
> List&lt;Channel&gt; GetAvailableVideoChannels (decimal videoId)

Get all the channels to which the user can add or remove a specific video

This method returns every channel to which the authenticated user can add or remove the specified video. The authenticated user must be a moderator of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetAvailableVideoChannelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsVideosApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get all the channels to which the user can add or remove a specific video
                List<Channel> result = apiInstance.GetAvailableVideoChannels(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsVideosApi.GetAvailableVideoChannels: " + e.Message );
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

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.channel+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The channels were returned. |  -  |
| **403** | The authenticated user can&#39;t add or remove this video from a channel. |  -  |
| **404** | The authenticated user isn&#39;t a moderator of the channel. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelvideo"></a>
# **GetChannelVideo**
> Video GetChannelVideo (decimal channelId, decimal videoId)

Get a specific video in a channel

This method returns a single video in the specified channel. You can use it to determine whether the video is in the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetChannelVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsVideosApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a specific video in a channel
                Video result = apiInstance.GetChannelVideo(channelId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsVideosApi.GetChannelVideo: " + e.Message );
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
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelvideos"></a>
# **GetChannelVideos**
> List&lt;Video&gt; GetChannelVideos (decimal channelId, string containingUri = null, string direction = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos in a channel

This method returns every video in the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetChannelVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsVideosApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var containingUri = /videos/258684937;  // string | The page that contains the video URI. (optional) 
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `added` - Sort the results by date added.  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by creation date.  * `default` - Use the default sorting method.  * `duration` - Sort the results by duration.  * `likes` - Sort the results by number of likes.  * `manual` - Sort the results as the user has arranged them.  * `modified_time` - Sort the results by last modification.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the videos in a channel
                List<Video> result = apiInstance.GetChannelVideos(channelId, containingUri, direction, filter, filterEmbeddable, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsVideosApi.GetChannelVideos: " + e.Message );
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
 **containingUri** | **string**| The page that contains the video URI. | [optional] 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;embeddable&#x60; - Return embeddable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;added&#x60; - Sort the results by date added.  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by creation date.  * &#x60;default&#x60; - Use the default sorting method.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;manual&#x60; - Sort the results as the user has arranged them.  * &#x60;modified_time&#x60; - Sort the results by last modification.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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
| **304** | No videos have been added to this channel since the given &#x60;If-Modified-Since&#x60; header. |  -  |
| **400** | The **sort** field is &#x60;default&#x60;, but the **direction** field has a value. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removevideosfromchannel"></a>
# **RemoveVideosFromChannel**
> void RemoveVideosFromChannel (decimal channelId, InlineObject9 inlineObject9)

Remove a list of videos from a channel

This method removes multiple videos from the specified channel. The authenticated user must be a moderator of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class RemoveVideosFromChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsVideosApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var inlineObject9 = new InlineObject9(); // InlineObject9 | 

            try
            {
                // Remove a list of videos from a channel
                apiInstance.RemoveVideosFromChannel(channelId, inlineObject9);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsVideosApi.RemoveVideosFromChannel: " + e.Message );
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
 **inlineObject9** | [**InlineObject9**](InlineObject9.md)|  | 

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
| **204** | The videos were removed. |  -  |
| **403** | The authenticated user can&#39;t remove videos from this channel, or a video can&#39;t be removed from the channel. |  -  |
| **404** | No such channel or user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


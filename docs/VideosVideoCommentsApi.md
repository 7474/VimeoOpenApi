# VimeoOpenApi.Api.VideosVideoCommentsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateComment**](VideosVideoCommentsApi.md#createcomment) | **POST** /videos/{video_id}/comments | Add a video comment to a video
[**CreateCommentAlt1**](VideosVideoCommentsApi.md#createcommentalt1) | **POST** /channels/{channel_id}/videos/{video_id}/comments | Add a video comment to a video
[**CreateCommentReply**](VideosVideoCommentsApi.md#createcommentreply) | **POST** /videos/{video_id}/comments/{comment_id}/replies | Add a reply to a video comment
[**DeleteComment**](VideosVideoCommentsApi.md#deletecomment) | **DELETE** /videos/{video_id}/comments/{comment_id} | Delete a video comment
[**EditComment**](VideosVideoCommentsApi.md#editcomment) | **PATCH** /videos/{video_id}/comments/{comment_id} | Edit a video comment
[**GetComment**](VideosVideoCommentsApi.md#getcomment) | **GET** /videos/{video_id}/comments/{comment_id} | Get a specific video comment
[**GetCommentReplies**](VideosVideoCommentsApi.md#getcommentreplies) | **GET** /videos/{video_id}/comments/{comment_id}/replies | Get all the replies to a video comment
[**GetComments**](VideosVideoCommentsApi.md#getcomments) | **GET** /videos/{video_id}/comments | Get all the video comments on a video
[**GetCommentsAlt1**](VideosVideoCommentsApi.md#getcommentsalt1) | **GET** /channels/{channel_id}/videos/{video_id}/comments | Get all the video comments on a video


<a name="createcomment"></a>
# **CreateComment**
> Comment CreateComment (decimal videoId, InlineObject54 inlineObject54)

Add a video comment to a video

This method adds a video comment to the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVideoCommentsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject54 = new InlineObject54(); // InlineObject54 | 

            try
            {
                // Add a video comment to a video
                Comment result = apiInstance.CreateComment(videoId, inlineObject54);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVideoCommentsApi.CreateComment: " + e.Message );
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
 **inlineObject54** | [**InlineObject54**](InlineObject54.md)|  | 

### Return type

[**Comment**](Comment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.comment+json
 - **Accept**: application/vnd.vimeo.comment+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The comment was added. |  -  |
| **400** | Error code 2207: The comment text is missing. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | * Error code 3301: The comment was flagged as spam. * Error code 3411: The authenticated user is unverified. * Error code 3412: The authenticated user can&#39;t comment. * Error code 3413: Comments are disabled for this video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcommentalt1"></a>
# **CreateCommentAlt1**
> Comment CreateCommentAlt1 (decimal channelId, decimal videoId, InlineObject10 inlineObject10)

Add a video comment to a video

This method adds a video comment to the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateCommentAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVideoCommentsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject10 = new InlineObject10(); // InlineObject10 | 

            try
            {
                // Add a video comment to a video
                Comment result = apiInstance.CreateCommentAlt1(channelId, videoId, inlineObject10);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVideoCommentsApi.CreateCommentAlt1: " + e.Message );
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
 **inlineObject10** | [**InlineObject10**](InlineObject10.md)|  | 

### Return type

[**Comment**](Comment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.comment+json
 - **Accept**: application/vnd.vimeo.comment+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The comment was added. |  -  |
| **400** | Error code 2207: The comment text is missing. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | * Error code 3301: The comment was flagged as spam. * Error code 3411: The authenticated user is unverified. * Error code 3412: The authenticated user can&#39;t comment. * Error code 3413: Comments are disabled for this video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcommentreply"></a>
# **CreateCommentReply**
> Comment CreateCommentReply (decimal commentId, decimal videoId, InlineObject56 inlineObject56)

Add a reply to a video comment

This method adds a reply to the specified video comment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateCommentReplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVideoCommentsApi(config);
            var commentId = 12345;  // decimal | The ID of the comment.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject56 = new InlineObject56(); // InlineObject56 | 

            try
            {
                // Add a reply to a video comment
                Comment result = apiInstance.CreateCommentReply(commentId, videoId, inlineObject56);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVideoCommentsApi.CreateCommentReply: " + e.Message );
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
 **commentId** | **decimal**| The ID of the comment. | 
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject56** | [**InlineObject56**](InlineObject56.md)|  | 

### Return type

[**Comment**](Comment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.comment+json
 - **Accept**: application/vnd.vimeo.comment+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The reply was added. |  -  |
| **400** | Error code 2207: The comment text is missing. |  -  |
| **403** | * Error code 3301: The comment was flagged as spam. * Error code 3411: The authenticated user is unverified. * Error code 3412: The authenticated user can&#39;t comment. * Error code 3413: Comments are disabled on this video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecomment"></a>
# **DeleteComment**
> void DeleteComment (decimal commentId, decimal videoId)

Delete a video comment

This method deletes the specified video comment. The authenticated user must be the owner of the comment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVideoCommentsApi(config);
            var commentId = 12345;  // decimal | The ID of the comment.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Delete a video comment
                apiInstance.DeleteComment(commentId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVideoCommentsApi.DeleteComment: " + e.Message );
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
 **commentId** | **decimal**| The ID of the comment. | 
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
| **204** | The comment was deleted. |  -  |
| **403** | Error code 3415: The authenticated user can&#39;t delete this comment. |  -  |
| **404** | * No such video or comment exists. * Error code 5000: The comment wasn&#39;t deleted and still exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editcomment"></a>
# **EditComment**
> Comment EditComment (decimal commentId, decimal videoId, InlineObject55 inlineObject55)

Edit a video comment

This method edits the specified video comment. The authenticated user must be the owner of the comment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVideoCommentsApi(config);
            var commentId = 12345;  // decimal | The ID of the comment.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject55 = new InlineObject55(); // InlineObject55 | 

            try
            {
                // Edit a video comment
                Comment result = apiInstance.EditComment(commentId, videoId, inlineObject55);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVideoCommentsApi.EditComment: " + e.Message );
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
 **commentId** | **decimal**| The ID of the comment. | 
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject55** | [**InlineObject55**](InlineObject55.md)|  | 

### Return type

[**Comment**](Comment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.comment+json
 - **Accept**: application/vnd.vimeo.comment+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The comment was edited. |  -  |
| **400** | Error code 2207: The comment text is missing. |  -  |
| **403** | * Error code 3301: The comment was flagged as spam. * Error code 3411: The authenticated user is unverified. * Error code 3412: The authenticated user can&#39;t post comments. * Error code 3414: The authenticated user can&#39;t edit this comment. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomment"></a>
# **GetComment**
> Comment GetComment (decimal commentId, decimal videoId)

Get a specific video comment

This method returns the specified video comment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVideoCommentsApi(config);
            var commentId = 12345;  // decimal | The ID of the comment.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a specific video comment
                Comment result = apiInstance.GetComment(commentId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVideoCommentsApi.GetComment: " + e.Message );
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
 **commentId** | **decimal**| The ID of the comment. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**Comment**](Comment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.comment+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The comment was returned. |  -  |
| **404** | No such video or comment exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommentreplies"></a>
# **GetCommentReplies**
> List&lt;Comment&gt; GetCommentReplies (decimal commentId, decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the replies to a video comment

This method returns every reply to the specified video comment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCommentRepliesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVideoCommentsApi(config);
            var commentId = 12345;  // decimal | The ID of the comment.
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the replies to a video comment
                List<Comment> result = apiInstance.GetCommentReplies(commentId, videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVideoCommentsApi.GetCommentReplies: " + e.Message );
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
 **commentId** | **decimal**| The ID of the comment. | 
 **videoId** | **decimal**| The ID of the video. | 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

### Return type

[**List&lt;Comment&gt;**](Comment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.comment+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The replies were returned. |  -  |
| **404** | No such video or comment exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomments"></a>
# **GetComments**
> List&lt;Comment&gt; GetComments (decimal videoId, string direction = null, decimal? page = null, decimal? perPage = null)

Get all the video comments on a video

This method returns every video comment on the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVideoCommentsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the video comments on a video
                List<Comment> result = apiInstance.GetComments(videoId, direction, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVideoCommentsApi.GetComments: " + e.Message );
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

### Return type

[**List&lt;Comment&gt;**](Comment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.comment+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The comments were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommentsalt1"></a>
# **GetCommentsAlt1**
> List&lt;Comment&gt; GetCommentsAlt1 (decimal channelId, decimal videoId, string direction = null, decimal? page = null, decimal? perPage = null)

Get all the video comments on a video

This method returns every video comment on the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCommentsAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVideoCommentsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the video comments on a video
                List<Comment> result = apiInstance.GetCommentsAlt1(channelId, videoId, direction, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVideoCommentsApi.GetCommentsAlt1: " + e.Message );
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

### Return type

[**List&lt;Comment&gt;**](Comment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.comment+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The comments were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


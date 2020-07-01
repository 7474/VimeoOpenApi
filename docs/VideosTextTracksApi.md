# VimeoOpenApi.Api.VideosTextTracksApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTextTrack**](VideosTextTracksApi.md#createtexttrack) | **POST** /videos/{video_id}/texttracks | Add a text track to a video
[**CreateTextTrackAlt1**](VideosTextTracksApi.md#createtexttrackalt1) | **POST** /channels/{channel_id}/videos/{video_id}/texttracks | Add a text track to a video
[**DeleteTextTrack**](VideosTextTracksApi.md#deletetexttrack) | **DELETE** /videos/{video_id}/texttracks/{texttrack_id} | Delete a text track
[**EditTextTrack**](VideosTextTracksApi.md#edittexttrack) | **PATCH** /videos/{video_id}/texttracks/{texttrack_id} | Edit a text track
[**GetTextTrack**](VideosTextTracksApi.md#gettexttrack) | **GET** /videos/{video_id}/texttracks/{texttrack_id} | Get a specific text track
[**GetTextTracks**](VideosTextTracksApi.md#gettexttracks) | **GET** /videos/{video_id}/texttracks | Get all the text tracks of a video
[**GetTextTracksAlt1**](VideosTextTracksApi.md#gettexttracksalt1) | **GET** /channels/{channel_id}/videos/{video_id}/texttracks | Get all the text tracks of a video


<a name="createtexttrack"></a>
# **CreateTextTrack**
> TextTrack CreateTextTrack (decimal videoId, InlineObject62 inlineObject62)

Add a text track to a video

This method adds a text track to the specified video. For more information, see [Working with Text Track Uploads](https://developer.vimeo.com/api/upload/texttracks).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateTextTrackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTextTracksApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject62 = new InlineObject62(); // InlineObject62 | 

            try
            {
                // Add a text track to a video
                TextTrack result = apiInstance.CreateTextTrack(videoId, inlineObject62);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTextTracksApi.CreateTextTrack: " + e.Message );
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
 **inlineObject62** | [**InlineObject62**](InlineObject62.md)|  | 

### Return type

[**TextTrack**](TextTrack.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.video.texttrack+json
 - **Accept**: application/vnd.vimeo.video.texttrack+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The text track was added. |  -  |
| **403** | * The authenticated user can&#39;t add the text track. * Error code 2204: The request contains errors. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtexttrackalt1"></a>
# **CreateTextTrackAlt1**
> TextTrack CreateTextTrackAlt1 (decimal channelId, decimal videoId, InlineObject13 inlineObject13)

Add a text track to a video

This method adds a text track to the specified video. For more information, see [Working with Text Track Uploads](https://developer.vimeo.com/api/upload/texttracks).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateTextTrackAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTextTracksApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject13 = new InlineObject13(); // InlineObject13 | 

            try
            {
                // Add a text track to a video
                TextTrack result = apiInstance.CreateTextTrackAlt1(channelId, videoId, inlineObject13);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTextTracksApi.CreateTextTrackAlt1: " + e.Message );
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
 **inlineObject13** | [**InlineObject13**](InlineObject13.md)|  | 

### Return type

[**TextTrack**](TextTrack.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.video.texttrack+json
 - **Accept**: application/vnd.vimeo.video.texttrack+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The text track was added. |  -  |
| **403** | * The authenticated user can&#39;t add the text track. * Error code 2204: The request contains errors. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetexttrack"></a>
# **DeleteTextTrack**
> void DeleteTextTrack (decimal texttrackId, decimal videoId)

Delete a text track

This method deletes the specified text track from a video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteTextTrackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTextTracksApi(config);
            var texttrackId = 12345;  // decimal | The ID of the text track.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Delete a text track
                apiInstance.DeleteTextTrack(texttrackId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTextTracksApi.DeleteTextTrack: " + e.Message );
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
 **texttrackId** | **decimal**| The ID of the text track. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video.texttrack+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The text track was deleted. |  -  |
| **403** | * Error code 3430: The authenticated user doesn&#39;t have permission to access the text track. * Error code 3431: This text track is disabled. |  -  |
| **404** | * No such video or text track exists. * The authenticated user can&#39;t delete the text track. * Error code 5014: The specified text track doesn&#39;t exist. * Error code 5015: The specified text track belongs to a different video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittexttrack"></a>
# **EditTextTrack**
> TextTrack EditTextTrack (decimal texttrackId, decimal videoId, InlineObject63 inlineObject63 = null)

Edit a text track

This method edits the specified text track of a video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditTextTrackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTextTracksApi(config);
            var texttrackId = 12345;  // decimal | The ID of the text track.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject63 = new InlineObject63(); // InlineObject63 |  (optional) 

            try
            {
                // Edit a text track
                TextTrack result = apiInstance.EditTextTrack(texttrackId, videoId, inlineObject63);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTextTracksApi.EditTextTrack: " + e.Message );
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
 **texttrackId** | **decimal**| The ID of the text track. | 
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject63** | [**InlineObject63**](InlineObject63.md)|  | [optional] 

### Return type

[**TextTrack**](TextTrack.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.video.texttrack+json
 - **Accept**: application/vnd.vimeo.video.texttrack+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The text track was edited. |  -  |
| **403** | * The authenticated user can&#39;t edit the text track. * Error code 2204: There are errors in the request. * Error code 3430: The authenticated user doesn&#39;t have permission to access the text track. * Error code 3431: This text track is disabled. |  -  |
| **404** | * No such video or text track exists. * Error code 5014: The specified text track doesn&#39;t exist. * Error code 5015: The specified text track belongs to a different video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettexttrack"></a>
# **GetTextTrack**
> TextTrack GetTextTrack (decimal texttrackId, decimal videoId)

Get a specific text track

This method returns a single text track of the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetTextTrackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTextTracksApi(config);
            var texttrackId = 12345;  // decimal | The ID of the text track.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a specific text track
                TextTrack result = apiInstance.GetTextTrack(texttrackId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTextTracksApi.GetTextTrack: " + e.Message );
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
 **texttrackId** | **decimal**| The ID of the text track. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**TextTrack**](TextTrack.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video.texttrack+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The text track was returned. |  -  |
| **403** | * Error code 3430: The authenticated user doesn&#39;t have permission to access the text track. * Error code 3431: This text track is disabled. |  -  |
| **404** | * No such video or text track exists. * Error code 5014: The specified text track doesn&#39;t exist. * Error code 5015: The specified text track belongs to a different video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettexttracks"></a>
# **GetTextTracks**
> List&lt;TextTrack&gt; GetTextTracks (decimal videoId)

Get all the text tracks of a video

This method returns every text track of the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetTextTracksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTextTracksApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get all the text tracks of a video
                List<TextTrack> result = apiInstance.GetTextTracks(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTextTracksApi.GetTextTracks: " + e.Message );
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

[**List&lt;TextTrack&gt;**](TextTrack.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video.texttrack+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The text tracks were returned. |  -  |
| **404** | No such video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettexttracksalt1"></a>
# **GetTextTracksAlt1**
> List&lt;TextTrack&gt; GetTextTracksAlt1 (decimal channelId, decimal videoId)

Get all the text tracks of a video

This method returns every text track of the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetTextTracksAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosTextTracksApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get all the text tracks of a video
                List<TextTrack> result = apiInstance.GetTextTracksAlt1(channelId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosTextTracksApi.GetTextTracksAlt1: " + e.Message );
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

[**List&lt;TextTrack&gt;**](TextTrack.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video.texttrack+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The text tracks were returned. |  -  |
| **404** | No such video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# VimeoOpenApi.Api.VideosLiveM3U8PlaybackApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOneTimeEventM3u8Playback**](VideosLiveM3U8PlaybackApi.md#getonetimeeventm3u8playback) | **GET** /users/{user_id}/videos/{video_id}/m3u8_playback | Get an M3U8 playback URL for a one-time live event
[**GetOneTimeEventM3u8PlaybackAlt1**](VideosLiveM3U8PlaybackApi.md#getonetimeeventm3u8playbackalt1) | **GET** /me/videos/{video_id}/m3u8_playback | Get an M3U8 playback URL for a one-time live event


<a name="getonetimeeventm3u8playback"></a>
# **GetOneTimeEventM3u8Playback**
> void GetOneTimeEventM3u8Playback (decimal userId, decimal videoId)

Get an M3U8 playback URL for a one-time live event

This method returns an M3U8 playback URL for the specified one-time live event stream. You should use this endpoint only in conjunction with our recommended procedure for playing live events via HLS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetOneTimeEventM3u8PlaybackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosLiveM3U8PlaybackApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 12345;  // decimal | The ID of the video.

            try
            {
                // Get an M3U8 playback URL for a one-time live event
                apiInstance.GetOneTimeEventM3u8Playback(userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosLiveM3U8PlaybackApi.GetOneTimeEventM3u8Playback: " + e.Message );
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
| **200** | The M3U8 playback URL was returned. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t access the M3U8 playback URL. |  -  |
| **404** | Error code 5000: No such live event or user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getonetimeeventm3u8playbackalt1"></a>
# **GetOneTimeEventM3u8PlaybackAlt1**
> void GetOneTimeEventM3u8PlaybackAlt1 (decimal videoId)

Get an M3U8 playback URL for a one-time live event

This method returns an M3U8 playback URL for the specified one-time live event stream. You should use this endpoint only in conjunction with our recommended procedure for playing live events via HLS.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetOneTimeEventM3u8PlaybackAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosLiveM3U8PlaybackApi(config);
            var videoId = 12345;  // decimal | The ID of the video.

            try
            {
                // Get an M3U8 playback URL for a one-time live event
                apiInstance.GetOneTimeEventM3u8PlaybackAlt1(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosLiveM3U8PlaybackApi.GetOneTimeEventM3u8PlaybackAlt1: " + e.Message );
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
| **200** | The M3U8 playback URL was returned. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t access the M3U8 playback URL. |  -  |
| **404** | Error code 5000: No such live event or user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


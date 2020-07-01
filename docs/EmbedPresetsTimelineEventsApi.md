# VimeoOpenApi.Api.EmbedPresetsTimelineEventsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVideoCustomLogo**](EmbedPresetsTimelineEventsApi.md#createvideocustomlogo) | **POST** /videos/{video_id}/timelinethumbnails | Add a timeline event thumbnail to a video
[**GetVideoCustomLogo**](EmbedPresetsTimelineEventsApi.md#getvideocustomlogo) | **GET** /videos/{video_id}/timelinethumbnails/{thumbnail_id} | Get a timeline event thumbnail


<a name="createvideocustomlogo"></a>
# **CreateVideoCustomLogo**
> Picture CreateVideoCustomLogo (decimal videoId)

Add a timeline event thumbnail to a video

This method adds a timeline event thumbnail to the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateVideoCustomLogoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsTimelineEventsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add a timeline event thumbnail to a video
                Picture result = apiInstance.CreateVideoCustomLogo(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsTimelineEventsApi.CreateVideoCustomLogo: " + e.Message );
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

[**Picture**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The timeline event thumbnail was added. |  -  |
| **403** | The authenticated user can&#39;t add a timeline event thumbnail to the video. |  -  |
| **404** | No such video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideocustomlogo"></a>
# **GetVideoCustomLogo**
> Picture GetVideoCustomLogo (decimal thumbnailId, decimal videoId)

Get a timeline event thumbnail

This method returns a single timeline event thumbnail that belongs to the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoCustomLogoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsTimelineEventsApi(config);
            var thumbnailId = 12345;  // decimal | The ID of the timeline event thumbnail.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a timeline event thumbnail
                Picture result = apiInstance.GetVideoCustomLogo(thumbnailId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsTimelineEventsApi.GetVideoCustomLogo: " + e.Message );
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
 **thumbnailId** | **decimal**| The ID of the timeline event thumbnail. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**Picture**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The timeline event thumbnail was returned. |  -  |
| **403** | The authenticated user can&#39;t access the timeline event thumbnail. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


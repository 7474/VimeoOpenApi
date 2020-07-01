# VimeoOpenApi.Api.EmbedPresetsVideosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoEmbedPreset**](EmbedPresetsVideosApi.md#addvideoembedpreset) | **PUT** /videos/{video_id}/presets/{preset_id} | Add an embed preset to a video
[**DeleteVideoEmbedPreset**](EmbedPresetsVideosApi.md#deletevideoembedpreset) | **DELETE** /videos/{video_id}/presets/{preset_id} | Remove an embed preset from a video
[**GetEmbedPresetVideos**](EmbedPresetsVideosApi.md#getembedpresetvideos) | **GET** /users/{user_id}/presets/{preset_id}/videos | Get all the videos that have a specific embed preset
[**GetEmbedPresetVideosAlt1**](EmbedPresetsVideosApi.md#getembedpresetvideosalt1) | **GET** /me/presets/{preset_id}/videos | Get all the videos that have a specific embed preset
[**GetVideoEmbedPreset**](EmbedPresetsVideosApi.md#getvideoembedpreset) | **GET** /videos/{video_id}/presets/{preset_id} | Check if an embed preset has been added to a video


<a name="addvideoembedpreset"></a>
# **AddVideoEmbedPreset**
> void AddVideoEmbedPreset (decimal presetId, decimal videoId)

Add an embed preset to a video

This method adds an embed preset to the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoEmbedPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsVideosApi(config);
            var presetId = 12345;  // decimal | The ID of the embed preset.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add an embed preset to a video
                apiInstance.AddVideoEmbedPreset(presetId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsVideosApi.AddVideoEmbedPreset: " + e.Message );
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
 **presetId** | **decimal**| The ID of the embed preset. | 
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
| **204** | The embed preset was added to the video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideoembedpreset"></a>
# **DeleteVideoEmbedPreset**
> void DeleteVideoEmbedPreset (decimal presetId, decimal videoId)

Remove an embed preset from a video

This method removes the specified embed preset from a video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoEmbedPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsVideosApi(config);
            var presetId = 12345;  // decimal | The ID of the embed preset.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Remove an embed preset from a video
                apiInstance.DeleteVideoEmbedPreset(presetId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsVideosApi.DeleteVideoEmbedPreset: " + e.Message );
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
 **presetId** | **decimal**| The ID of the embed preset. | 
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
| **204** | The embed preset was removed. |  -  |
| **404** | No such video or embed preset exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getembedpresetvideos"></a>
# **GetEmbedPresetVideos**
> List&lt;Video&gt; GetEmbedPresetVideos (decimal presetId, decimal userId, decimal? page = null, decimal? perPage = null)

Get all the videos that have a specific embed preset

This method returns every video to which the specified embed preset has been added. The authenticated user must be the owner of videos.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetEmbedPresetVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsVideosApi(config);
            var presetId = 12345;  // decimal | The ID of the embed preset.
            var userId = 152184;  // decimal | The ID of the user.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the videos that have a specific embed preset
                List<Video> result = apiInstance.GetEmbedPresetVideos(presetId, userId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsVideosApi.GetEmbedPresetVideos: " + e.Message );
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
 **presetId** | **decimal**| The ID of the embed preset. | 
 **userId** | **decimal**| The ID of the user. | 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

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

<a name="getembedpresetvideosalt1"></a>
# **GetEmbedPresetVideosAlt1**
> List&lt;Video&gt; GetEmbedPresetVideosAlt1 (decimal presetId, decimal? page = null, decimal? perPage = null)

Get all the videos that have a specific embed preset

This method returns every video to which the specified embed preset has been added. The authenticated user must be the owner of videos.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetEmbedPresetVideosAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsVideosApi(config);
            var presetId = 12345;  // decimal | The ID of the embed preset.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the videos that have a specific embed preset
                List<Video> result = apiInstance.GetEmbedPresetVideosAlt1(presetId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsVideosApi.GetEmbedPresetVideosAlt1: " + e.Message );
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
 **presetId** | **decimal**| The ID of the embed preset. | 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

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

<a name="getvideoembedpreset"></a>
# **GetVideoEmbedPreset**
> void GetVideoEmbedPreset (decimal presetId, decimal videoId)

Check if an embed preset has been added to a video

This method determines whether a video has the specified embed preset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoEmbedPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsVideosApi(config);
            var presetId = 12345;  // decimal | The ID of the embed preset.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Check if an embed preset has been added to a video
                apiInstance.GetVideoEmbedPreset(presetId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsVideosApi.GetVideoEmbedPreset: " + e.Message );
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
 **presetId** | **decimal**| The ID of the embed preset. | 
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
| **204** | The embed preset has been added to the video. |  -  |
| **404** | No such video or embed preset exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


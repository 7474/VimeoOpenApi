# VimeoOpenApi.Api.VideosVersionsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVideoVersion**](VideosVersionsApi.md#createvideoversion) | **POST** /videos/{video_id}/versions | Add a version to a video
[**DeleteVideoVersion**](VideosVersionsApi.md#deletevideoversion) | **DELETE** /videos/{video_id}/versions/{version_id} | Delete a video version
[**EditVideoVersion**](VideosVersionsApi.md#editvideoversion) | **PATCH** /videos/{video_id}/versions/{version_id} | Edit a video version
[**GetVideoVersion**](VideosVersionsApi.md#getvideoversion) | **GET** /videos/{video_id}/versions/{version_id} | Get a specific video version
[**GetVideoVersions**](VideosVersionsApi.md#getvideoversions) | **GET** /videos/{video_id}/versions | Get all the versions of a video
[**GetVideoVersionsAlt1**](VideosVersionsApi.md#getvideoversionsalt1) | **GET** /channels/{channel_id}/videos/{video_id}/versions | Get all the versions of a video


<a name="createvideoversion"></a>
# **CreateVideoVersion**
> VideoVersions CreateVideoVersion (decimal videoId, InlineObject64 inlineObject64)

Add a version to a video

This method adds a version to the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateVideoVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVersionsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject64 = new InlineObject64(); // InlineObject64 | 

            try
            {
                // Add a version to a video
                VideoVersions result = apiInstance.CreateVideoVersion(videoId, inlineObject64);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVersionsApi.CreateVideoVersion: " + e.Message );
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
 **inlineObject64** | [**InlineObject64**](InlineObject64.md)|  | 

### Return type

[**VideoVersions**](VideoVersions.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.video.version+json
 - **Accept**: application/vnd.vimeo.video.version+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The version was added. |  -  |
| **400** | Error code 2204: The request input contains invalid version data. |  -  |
| **403** | Error code 3427: The authenticated user can&#39;t edit the video. |  -  |
| **404** | * Error code 5011: An upload isn&#39;t associated with this version. * Error code 5012: A video isn&#39;t associated with this upload. * Error code 5013: The endpoint isn&#39;t available, because the specified version of the API is less than 3.4 and **upload.approach** isn&#39;t &#x60;tus&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideoversion"></a>
# **DeleteVideoVersion**
> void DeleteVideoVersion (decimal versionId, decimal videoId)

Delete a video version

This method deletes the specified version from a video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVersionsApi(config);
            var versionId = 12345;  // decimal | The ID of the video version.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Delete a video version
                apiInstance.DeleteVideoVersion(versionId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVersionsApi.DeleteVideoVersion: " + e.Message );
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
 **versionId** | **decimal**| The ID of the video version. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video.version+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Standard request. |  -  |
| **404** | * No such video exists. * Error code 8003: The user credentials are invalid. * Error code 3200: The authenticated user can&#39;t access the versions of this video. * Error code 2523: The version isn&#39;t associated with the video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editvideoversion"></a>
# **EditVideoVersion**
> VideoVersions EditVideoVersion (decimal versionId, decimal videoId, InlineObject65 inlineObject65 = null)

Edit a video version

This method edits the specified version of a video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditVideoVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVersionsApi(config);
            var versionId = 12345;  // decimal | The ID of the video version.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject65 = new InlineObject65(); // InlineObject65 |  (optional) 

            try
            {
                // Edit a video version
                VideoVersions result = apiInstance.EditVideoVersion(versionId, videoId, inlineObject65);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVersionsApi.EditVideoVersion: " + e.Message );
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
 **versionId** | **decimal**| The ID of the video version. | 
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject65** | [**InlineObject65**](InlineObject65.md)|  | [optional] 

### Return type

[**VideoVersions**](VideoVersions.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.video.version+json
 - **Accept**: application/vnd.vimeo.video.version+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Standard request. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **404** | * No such video exists. * Error code 2205: A parameter is invalid. * Error code 3200: The authenticated user can&#39;t access the versions of this video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoversion"></a>
# **GetVideoVersion**
> void GetVideoVersion (decimal versionId, decimal videoId)

Get a specific video version

This method returns a single version of the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVersionsApi(config);
            var versionId = 12345;  // decimal | The ID of the video version.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a specific video version
                apiInstance.GetVideoVersion(versionId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVersionsApi.GetVideoVersion: " + e.Message );
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
 **versionId** | **decimal**| The ID of the video version. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video.version+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Standard request. |  -  |
| **404** | * No such video exists. * Error code 8003: The user credentials are invalid. * Error code 3200: The authenticated user can&#39;t access the versions of this video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoversions"></a>
# **GetVideoVersions**
> List&lt;VideoVersions&gt; GetVideoVersions (decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the versions of a video

This method returns every version of the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVersionsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the versions of a video
                List<VideoVersions> result = apiInstance.GetVideoVersions(videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVersionsApi.GetVideoVersions: " + e.Message );
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

[**List&lt;VideoVersions&gt;**](VideoVersions.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video.version+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Standard request. |  -  |
| **401** | * Error code 3200: The authenticated user can&#39;t access the video versions. * Error code 8003: The user credentials are invalid. |  -  |
| **404** | No such video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoversionsalt1"></a>
# **GetVideoVersionsAlt1**
> List&lt;VideoVersions&gt; GetVideoVersionsAlt1 (decimal channelId, decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the versions of a video

This method returns every version of the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoVersionsAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosVersionsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the versions of a video
                List<VideoVersions> result = apiInstance.GetVideoVersionsAlt1(channelId, videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosVersionsApi.GetVideoVersionsAlt1: " + e.Message );
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
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

### Return type

[**List&lt;VideoVersions&gt;**](VideoVersions.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video.version+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Standard request. |  -  |
| **401** | * Error code 3200: The authenticated user can&#39;t access the video versions. * Error code 8003: The user credentials are invalid. |  -  |
| **404** | No such video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


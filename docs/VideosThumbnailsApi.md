# VimeoOpenApi.Api.VideosThumbnailsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVideoThumbnail**](VideosThumbnailsApi.md#createvideothumbnail) | **POST** /videos/{video_id}/pictures | Add a video thumbnail
[**CreateVideoThumbnailAlt1**](VideosThumbnailsApi.md#createvideothumbnailalt1) | **POST** /channels/{channel_id}/videos/{video_id}/pictures | Add a video thumbnail
[**DeleteVideoThumbnail**](VideosThumbnailsApi.md#deletevideothumbnail) | **DELETE** /videos/{video_id}/pictures/{picture_id} | Delete a video thumbnail
[**EditVideoThumbnail**](VideosThumbnailsApi.md#editvideothumbnail) | **PATCH** /videos/{video_id}/pictures/{picture_id} | Edit a video thumbnail
[**GetVideoThumbnail**](VideosThumbnailsApi.md#getvideothumbnail) | **GET** /videos/{video_id}/pictures/{picture_id} | Get a specific video thumbnail
[**GetVideoThumbnails**](VideosThumbnailsApi.md#getvideothumbnails) | **GET** /videos/{video_id}/pictures | Get all the thumbnails of a video
[**GetVideoThumbnailsAlt1**](VideosThumbnailsApi.md#getvideothumbnailsalt1) | **GET** /channels/{channel_id}/videos/{video_id}/pictures | Get all the thumbnails of a video


<a name="createvideothumbnail"></a>
# **CreateVideoThumbnail**
> Picture CreateVideoThumbnail (decimal videoId, InlineObject59 inlineObject59 = null)

Add a video thumbnail

This method adds a thumbnail image to the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateVideoThumbnailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosThumbnailsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject59 = new InlineObject59(); // InlineObject59 |  (optional) 

            try
            {
                // Add a video thumbnail
                Picture result = apiInstance.CreateVideoThumbnail(videoId, inlineObject59);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosThumbnailsApi.CreateVideoThumbnail: " + e.Message );
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
 **inlineObject59** | [**InlineObject59**](InlineObject59.md)|  | [optional] 

### Return type

[**Picture**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.picture+json
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The thumbnail was created. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvideothumbnailalt1"></a>
# **CreateVideoThumbnailAlt1**
> Picture CreateVideoThumbnailAlt1 (decimal channelId, decimal videoId, InlineObject12 inlineObject12 = null)

Add a video thumbnail

This method adds a thumbnail image to the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateVideoThumbnailAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosThumbnailsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject12 = new InlineObject12(); // InlineObject12 |  (optional) 

            try
            {
                // Add a video thumbnail
                Picture result = apiInstance.CreateVideoThumbnailAlt1(channelId, videoId, inlineObject12);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosThumbnailsApi.CreateVideoThumbnailAlt1: " + e.Message );
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
 **inlineObject12** | [**InlineObject12**](InlineObject12.md)|  | [optional] 

### Return type

[**Picture**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.picture+json
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The thumbnail was created. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideothumbnail"></a>
# **DeleteVideoThumbnail**
> void DeleteVideoThumbnail (decimal pictureId, decimal videoId)

Delete a video thumbnail

This method deletes the specified thumbnail image from a video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoThumbnailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosThumbnailsApi(config);
            var pictureId = 12345;  // decimal | The ID of the thumbnail.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Delete a video thumbnail
                apiInstance.DeleteVideoThumbnail(pictureId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosThumbnailsApi.DeleteVideoThumbnail: " + e.Message );
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
 **pictureId** | **decimal**| The ID of the thumbnail. | 
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
| **204** | The thumbnail was deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editvideothumbnail"></a>
# **EditVideoThumbnail**
> Picture EditVideoThumbnail (decimal pictureId, decimal videoId, InlineObject60 inlineObject60 = null)

Edit a video thumbnail

This method edits the specified video thumbnail image. The authenticated user must be the owner of the thumbnail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditVideoThumbnailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosThumbnailsApi(config);
            var pictureId = 12345;  // decimal | The ID of the thumbnail.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject60 = new InlineObject60(); // InlineObject60 |  (optional) 

            try
            {
                // Edit a video thumbnail
                Picture result = apiInstance.EditVideoThumbnail(pictureId, videoId, inlineObject60);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosThumbnailsApi.EditVideoThumbnail: " + e.Message );
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
 **pictureId** | **decimal**| The ID of the thumbnail. | 
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject60** | [**InlineObject60**](InlineObject60.md)|  | [optional] 

### Return type

[**Picture**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.picture+json
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The thumbnail was edited. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideothumbnail"></a>
# **GetVideoThumbnail**
> Picture GetVideoThumbnail (decimal pictureId, decimal videoId)

Get a specific video thumbnail

This method returns a single thumbnail image from the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoThumbnailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosThumbnailsApi(config);
            var pictureId = 12345;  // decimal | The ID of the thumbnail.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a specific video thumbnail
                Picture result = apiInstance.GetVideoThumbnail(pictureId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosThumbnailsApi.GetVideoThumbnail: " + e.Message );
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
 **pictureId** | **decimal**| The ID of the thumbnail. | 
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
| **200** | The thumbnail was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideothumbnails"></a>
# **GetVideoThumbnails**
> List&lt;Picture&gt; GetVideoThumbnails (decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the thumbnails of a video

This method returns every thumbnail images of the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoThumbnailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosThumbnailsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the thumbnails of a video
                List<Picture> result = apiInstance.GetVideoThumbnails(videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosThumbnailsApi.GetVideoThumbnails: " + e.Message );
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

[**List&lt;Picture&gt;**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The thumbnails were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideothumbnailsalt1"></a>
# **GetVideoThumbnailsAlt1**
> List&lt;Picture&gt; GetVideoThumbnailsAlt1 (decimal channelId, decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the thumbnails of a video

This method returns every thumbnail images of the specified video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoThumbnailsAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosThumbnailsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the thumbnails of a video
                List<Picture> result = apiInstance.GetVideoThumbnailsAlt1(channelId, videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosThumbnailsApi.GetVideoThumbnailsAlt1: " + e.Message );
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

[**List&lt;Picture&gt;**](Picture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The thumbnails were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


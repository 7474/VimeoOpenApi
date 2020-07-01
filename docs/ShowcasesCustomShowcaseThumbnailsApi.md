# VimeoOpenApi.Api.ShowcasesCustomShowcaseThumbnailsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateShowcaseCustomThumb**](ShowcasesCustomShowcaseThumbnailsApi.md#createshowcasecustomthumb) | **POST** /users/{user_id}/albums/{album_id}/custom_thumbnails | Add a custom thumbnail to a showcase
[**DeleteShowcaseCustomThumbnail**](ShowcasesCustomShowcaseThumbnailsApi.md#deleteshowcasecustomthumbnail) | **DELETE** /users/{user_id}/albums/{album_id}/custom_thumbnails/{thumbnail_id} | Delete a custom showcase thumbnail
[**GetShowcaseCustomThumbnail**](ShowcasesCustomShowcaseThumbnailsApi.md#getshowcasecustomthumbnail) | **GET** /users/{user_id}/albums/{album_id}/custom_thumbnails/{thumbnail_id} | Get a specific custom showcase thumbnail
[**GetShowcaseCustomThumbs**](ShowcasesCustomShowcaseThumbnailsApi.md#getshowcasecustomthumbs) | **GET** /users/{user_id}/albums/{album_id}/custom_thumbnails | Get all the custom thumbnails of a showcase
[**ReplaceShowcaseCustomThumb**](ShowcasesCustomShowcaseThumbnailsApi.md#replaceshowcasecustomthumb) | **PATCH** /users/{user_id}/albums/{album_id}/custom_thumbnails/{thumbnail_id} | Replace a custom showcase thumbnail


<a name="createshowcasecustomthumb"></a>
# **CreateShowcaseCustomThumb**
> Picture CreateShowcaseCustomThumb (decimal albumId, decimal userId)

Add a custom thumbnail to a showcase

This method adds an uploaded image file as a custom thumbnail for the specified showcase. The image doesn't need to be a still from a showcase video, unlike with the [standard thumbnail method](https://developer.vimeo.com/api/reference/albums#set_video_as_album_thumbnail). The authenticated user must be the owner of the showcase.  For information on how to upload the thumbnail, see our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails) guide, and follow the same steps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateShowcaseCustomThumbExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseThumbnailsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Add a custom thumbnail to a showcase
                Picture result = apiInstance.CreateShowcaseCustomThumb(albumId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseThumbnailsApi.CreateShowcaseCustomThumb: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **userId** | **decimal**| The ID of the user. | 

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
| **201** | The custom thumbnail was added to the showcase. |  -  |
| **403** | The authenticated user can&#39;t add custom thumbnails to this showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshowcasecustomthumbnail"></a>
# **DeleteShowcaseCustomThumbnail**
> void DeleteShowcaseCustomThumbnail (decimal albumId, decimal thumbnailId, decimal userId)

Delete a custom showcase thumbnail

This method deletes the specified custom thumbnail from its showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteShowcaseCustomThumbnailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseThumbnailsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var thumbnailId = 12345;  // decimal | The ID of the custom thumbnail.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Delete a custom showcase thumbnail
                apiInstance.DeleteShowcaseCustomThumbnail(albumId, thumbnailId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseThumbnailsApi.DeleteShowcaseCustomThumbnail: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **thumbnailId** | **decimal**| The ID of the custom thumbnail. | 
 **userId** | **decimal**| The ID of the user. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.picture+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The custom thumbnail was deleted. |  -  |
| **403** | The authenticated user can&#39;t delete this custom thumbnail. |  -  |
| **404** | No such showcase exists, or it doesn&#39;t contain the specified custom thumbnail. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcasecustomthumbnail"></a>
# **GetShowcaseCustomThumbnail**
> Picture GetShowcaseCustomThumbnail (decimal albumId, decimal thumbnailId, decimal userId)

Get a specific custom showcase thumbnail

This method returns a single custom thumbnail of the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseCustomThumbnailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseThumbnailsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var thumbnailId = 12345;  // decimal | The ID of the custom thumbnail.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get a specific custom showcase thumbnail
                Picture result = apiInstance.GetShowcaseCustomThumbnail(albumId, thumbnailId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseThumbnailsApi.GetShowcaseCustomThumbnail: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **thumbnailId** | **decimal**| The ID of the custom thumbnail. | 
 **userId** | **decimal**| The ID of the user. | 

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
| **200** | The custom thumbnail was returned. |  -  |
| **403** | The authenticated user can&#39;t view this custom thumbnail. |  -  |
| **404** | No such showcase exists, or it doesn&#39;t contain the specified custom thumbnail. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcasecustomthumbs"></a>
# **GetShowcaseCustomThumbs**
> List&lt;Picture&gt; GetShowcaseCustomThumbs (decimal albumId, decimal userId, decimal? page = null, decimal? perPage = null)

Get all the custom thumbnails of a showcase

This method returns every custom thumbnail of the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseCustomThumbsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseThumbnailsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the custom thumbnails of a showcase
                List<Picture> result = apiInstance.GetShowcaseCustomThumbs(albumId, userId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseThumbnailsApi.GetShowcaseCustomThumbs: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **userId** | **decimal**| The ID of the user. | 
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
| **200** | The custom thumbnails were returned. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t view the custon thumbnails from this showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceshowcasecustomthumb"></a>
# **ReplaceShowcaseCustomThumb**
> Picture ReplaceShowcaseCustomThumb (decimal albumId, decimal thumbnailId, decimal userId, InlineObject40 inlineObject40 = null)

Replace a custom showcase thumbnail

This method replaces the specified custom showcase thumbnail with a new image file. The authenticated user must be the owner of the showcase.  For information on how to upload the thumbnail, see our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails) guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class ReplaceShowcaseCustomThumbExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseThumbnailsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var thumbnailId = 12345;  // decimal | The ID of the custom thumbnail.
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject40 = new InlineObject40(); // InlineObject40 |  (optional) 

            try
            {
                // Replace a custom showcase thumbnail
                Picture result = apiInstance.ReplaceShowcaseCustomThumb(albumId, thumbnailId, userId, inlineObject40);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseThumbnailsApi.ReplaceShowcaseCustomThumb: " + e.Message );
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
 **albumId** | **decimal**| The ID of the showcase. | 
 **thumbnailId** | **decimal**| The ID of the custom thumbnail. | 
 **userId** | **decimal**| The ID of the user. | 
 **inlineObject40** | [**InlineObject40**](InlineObject40.md)|  | [optional] 

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
| **200** | The custom thumbnail was replaced. |  -  |
| **403** | The authenticated user can&#39;t replace this custom thumbnail. |  -  |
| **404** | No such showcase exists, or it doesn&#39;t contain the specified custom thumbnail. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# VimeoOpenApi.Api.ShowcasesCustomShowcaseLogosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateShowcaseLogo**](ShowcasesCustomShowcaseLogosApi.md#createshowcaselogo) | **POST** /users/{user_id}/albums/{album_id}/logos | Add a custom logo to a showcase
[**DeleteShowcaseLogo**](ShowcasesCustomShowcaseLogosApi.md#deleteshowcaselogo) | **DELETE** /users/{user_id}/albums/{album_id}/logos/{logo_id} | Delete a custom showcase logo
[**GetShowcaseLogo**](ShowcasesCustomShowcaseLogosApi.md#getshowcaselogo) | **GET** /users/{user_id}/albums/{album_id}/logos/{logo_id} | Get a specific custom showcase logo
[**GetShowcaseLogos**](ShowcasesCustomShowcaseLogosApi.md#getshowcaselogos) | **GET** /users/{user_id}/albums/{album_id}/logos | Get all the custom logos of a showcase
[**ReplaceShowcaseLogo**](ShowcasesCustomShowcaseLogosApi.md#replaceshowcaselogo) | **PATCH** /users/{user_id}/albums/{album_id}/logos/{logo_id} | Replace a custom showcase logo


<a name="createshowcaselogo"></a>
# **CreateShowcaseLogo**
> Picture CreateShowcaseLogo (decimal albumId, decimal userId)

Add a custom logo to a showcase

This method adds an image file as a custom logo to the specified showcase. The authenticated user must be the owner of the showcase.  For information on how to upload the logo, see our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails) guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateShowcaseLogoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseLogosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Add a custom logo to a showcase
                Picture result = apiInstance.CreateShowcaseLogo(albumId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseLogosApi.CreateShowcaseLogo: " + e.Message );
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
| **201** | The logo was added to the showcase. |  -  |
| **403** | The authenticated user can&#39;t add custom logos to this showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshowcaselogo"></a>
# **DeleteShowcaseLogo**
> void DeleteShowcaseLogo (decimal albumId, decimal logoId, decimal userId)

Delete a custom showcase logo

This method deletes the specified custom logo from its showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteShowcaseLogoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseLogosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var logoId = 12345;  // decimal | The ID of the custom logo.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Delete a custom showcase logo
                apiInstance.DeleteShowcaseLogo(albumId, logoId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseLogosApi.DeleteShowcaseLogo: " + e.Message );
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
 **logoId** | **decimal**| The ID of the custom logo. | 
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
| **204** | The custom logo was deleted. |  -  |
| **403** | The authenticated user can&#39;t delete this custom logo. |  -  |
| **404** | No such showcase exists, or it doesn&#39;t contain the specified custom logo. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcaselogo"></a>
# **GetShowcaseLogo**
> Picture GetShowcaseLogo (decimal albumId, decimal logoId, decimal userId)

Get a specific custom showcase logo

This method returns a single custom logo of the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseLogoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseLogosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var logoId = 12345;  // decimal | The ID of the custom logo.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get a specific custom showcase logo
                Picture result = apiInstance.GetShowcaseLogo(albumId, logoId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseLogosApi.GetShowcaseLogo: " + e.Message );
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
 **logoId** | **decimal**| The ID of the custom logo. | 
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
| **200** | The custom logo was returned. |  -  |
| **403** | The authenticated user can&#39;t access this custom logo. |  -  |
| **404** | No such showcase exists, or it doesn&#39;t contain the specified custom logo. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcaselogos"></a>
# **GetShowcaseLogos**
> List&lt;Picture&gt; GetShowcaseLogos (decimal albumId, decimal userId, decimal? page = null, decimal? perPage = null)

Get all the custom logos of a showcase

This method returns every custom logo of the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseLogosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseLogosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the custom logos of a showcase
                List<Picture> result = apiInstance.GetShowcaseLogos(albumId, userId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseLogosApi.GetShowcaseLogos: " + e.Message );
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
| **200** | The custom logos were returned. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replaceshowcaselogo"></a>
# **ReplaceShowcaseLogo**
> Picture ReplaceShowcaseLogo (decimal albumId, decimal logoId, decimal userId, InlineObject41 inlineObject41 = null)

Replace a custom showcase logo

This method replaces the specified custom showcase logo with a new image file. The authenticated user must be the owner of the showcase.  For information on how to upload the logo, see our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails) guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class ReplaceShowcaseLogoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesCustomShowcaseLogosApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var logoId = 12345;  // decimal | The ID of the custom logo.
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject41 = new InlineObject41(); // InlineObject41 |  (optional) 

            try
            {
                // Replace a custom showcase logo
                Picture result = apiInstance.ReplaceShowcaseLogo(albumId, logoId, userId, inlineObject41);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesCustomShowcaseLogosApi.ReplaceShowcaseLogo: " + e.Message );
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
 **logoId** | **decimal**| The ID of the custom logo. | 
 **userId** | **decimal**| The ID of the user. | 
 **inlineObject41** | [**InlineObject41**](InlineObject41.md)|  | [optional] 

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
| **200** | The custom logo was replaced. |  -  |
| **403** | The authenticated user can&#39;t replace this custom logo. |  -  |
| **404** | No such showcase exists, or it doesn&#39;t contain the specified custom logo. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


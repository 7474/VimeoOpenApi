# VimeoOpenApi.Api.UsersPicturesApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePicture**](UsersPicturesApi.md#createpicture) | **POST** /users/{user_id}/pictures | Add a picture to the user&#39;s account
[**CreatePictureAlt1**](UsersPicturesApi.md#createpicturealt1) | **POST** /me/pictures | Add a picture to the user&#39;s account
[**DeletePicture**](UsersPicturesApi.md#deletepicture) | **DELETE** /users/{user_id}/pictures/{portraitset_id} | Delete a picture from the user&#39;s account
[**DeletePictureAlt1**](UsersPicturesApi.md#deletepicturealt1) | **DELETE** /me/pictures/{portraitset_id} | Delete a picture from the user&#39;s account
[**EditPicture**](UsersPicturesApi.md#editpicture) | **PATCH** /users/{user_id}/pictures/{portraitset_id} | Edit a picture in the user&#39;s account
[**EditPictureAlt1**](UsersPicturesApi.md#editpicturealt1) | **PATCH** /me/pictures/{portraitset_id} | Edit a picture in the user&#39;s account
[**GetPicture**](UsersPicturesApi.md#getpicture) | **GET** /users/{user_id}/pictures/{portraitset_id} | Get a specific picture that belongs to the user
[**GetPictureAlt1**](UsersPicturesApi.md#getpicturealt1) | **GET** /me/pictures/{portraitset_id} | Get a specific picture that belongs to the user
[**GetPictures**](UsersPicturesApi.md#getpictures) | **GET** /users/{user_id}/pictures | Get all the pictures that belong to the user
[**GetPicturesAlt1**](UsersPicturesApi.md#getpicturesalt1) | **GET** /me/pictures | Get all the pictures that belong to the user


<a name="createpicture"></a>
# **CreatePicture**
> Picture CreatePicture (decimal userId)

Add a picture to the user's account

This method adds a portrait image to the authenticated user's Vimeo account. Send the binary data of the image file to the location that you receive from the **link** field in the response. For step-by-step instructions, see [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails#uploading-a-thumbnail-step-3).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreatePictureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Add a picture to the user's account
                Picture result = apiInstance.CreatePicture(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.CreatePicture: " + e.Message );
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
| **200** | The portrait image was added. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpicturealt1"></a>
# **CreatePictureAlt1**
> Picture CreatePictureAlt1 ()

Add a picture to the user's account

This method adds a portrait image to the authenticated user's Vimeo account. Send the binary data of the image file to the location that you receive from the **link** field in the response. For step-by-step instructions, see [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails#uploading-a-thumbnail-step-3).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreatePictureAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);

            try
            {
                // Add a picture to the user's account
                Picture result = apiInstance.CreatePictureAlt1();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.CreatePictureAlt1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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
| **200** | The portrait image was added. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepicture"></a>
# **DeletePicture**
> void DeletePicture (decimal portraitsetId, decimal userId)

Delete a picture from the user's account

This method removes the specified portrait image from the authenticated user's Vimeo account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeletePictureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);
            var portraitsetId = 12345;  // decimal | The ID of the picture.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Delete a picture from the user's account
                apiInstance.DeletePicture(portraitsetId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.DeletePicture: " + e.Message );
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
 **portraitsetId** | **decimal**| The ID of the picture. | 
 **userId** | **decimal**| The ID of the user. | 

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
| **204** | The portrait image was removed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepicturealt1"></a>
# **DeletePictureAlt1**
> void DeletePictureAlt1 (decimal portraitsetId)

Delete a picture from the user's account

This method removes the specified portrait image from the authenticated user's Vimeo account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeletePictureAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);
            var portraitsetId = 12345;  // decimal | The ID of the picture.

            try
            {
                // Delete a picture from the user's account
                apiInstance.DeletePictureAlt1(portraitsetId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.DeletePictureAlt1: " + e.Message );
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
 **portraitsetId** | **decimal**| The ID of the picture. | 

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
| **204** | The portrait image was removed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpicture"></a>
# **EditPicture**
> Picture EditPicture (decimal portraitsetId, decimal userId, InlineObject46 inlineObject46 = null)

Edit a picture in the user's account

This method edits the specified portrait image belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditPictureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);
            var portraitsetId = 12345;  // decimal | The ID of the picture.
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject46 = new InlineObject46(); // InlineObject46 |  (optional) 

            try
            {
                // Edit a picture in the user's account
                Picture result = apiInstance.EditPicture(portraitsetId, userId, inlineObject46);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.EditPicture: " + e.Message );
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
 **portraitsetId** | **decimal**| The ID of the picture. | 
 **userId** | **decimal**| The ID of the user. | 
 **inlineObject46** | [**InlineObject46**](InlineObject46.md)|  | [optional] 

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
| **200** | The portrait image was edited. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpicturealt1"></a>
# **EditPictureAlt1**
> Picture EditPictureAlt1 (decimal portraitsetId, InlineObject22 inlineObject22 = null)

Edit a picture in the user's account

This method edits the specified portrait image belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditPictureAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);
            var portraitsetId = 12345;  // decimal | The ID of the picture.
            var inlineObject22 = new InlineObject22(); // InlineObject22 |  (optional) 

            try
            {
                // Edit a picture in the user's account
                Picture result = apiInstance.EditPictureAlt1(portraitsetId, inlineObject22);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.EditPictureAlt1: " + e.Message );
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
 **portraitsetId** | **decimal**| The ID of the picture. | 
 **inlineObject22** | [**InlineObject22**](InlineObject22.md)|  | [optional] 

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
| **200** | The portrait image was edited. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpicture"></a>
# **GetPicture**
> Picture GetPicture (decimal portraitsetId, decimal userId)

Get a specific picture that belongs to the user

This method returns a single portrait image belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetPictureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);
            var portraitsetId = 12345;  // decimal | The ID of the picture.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get a specific picture that belongs to the user
                Picture result = apiInstance.GetPicture(portraitsetId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.GetPicture: " + e.Message );
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
 **portraitsetId** | **decimal**| The ID of the picture. | 
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
| **200** | The portrait image was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpicturealt1"></a>
# **GetPictureAlt1**
> Picture GetPictureAlt1 (decimal portraitsetId)

Get a specific picture that belongs to the user

This method returns a single portrait image belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetPictureAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);
            var portraitsetId = 12345;  // decimal | The ID of the picture.

            try
            {
                // Get a specific picture that belongs to the user
                Picture result = apiInstance.GetPictureAlt1(portraitsetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.GetPictureAlt1: " + e.Message );
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
 **portraitsetId** | **decimal**| The ID of the picture. | 

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
| **200** | The portrait image was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpictures"></a>
# **GetPictures**
> List&lt;Picture&gt; GetPictures (decimal userId, decimal? page = null, decimal? perPage = null)

Get all the pictures that belong to the user

This method returns every portrait image belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetPicturesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the pictures that belong to the user
                List<Picture> result = apiInstance.GetPictures(userId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.GetPictures: " + e.Message );
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
| **200** | The portrait images were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpicturesalt1"></a>
# **GetPicturesAlt1**
> List&lt;Picture&gt; GetPicturesAlt1 (decimal? page = null, decimal? perPage = null)

Get all the pictures that belong to the user

This method returns every portrait image belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetPicturesAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersPicturesApi(config);
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the pictures that belong to the user
                List<Picture> result = apiInstance.GetPicturesAlt1(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersPicturesApi.GetPicturesAlt1: " + e.Message );
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
| **200** | The portrait images were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


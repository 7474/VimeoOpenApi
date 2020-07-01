# VimeoOpenApi.Api.OnDemandBackgroundsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVodBackground**](OnDemandBackgroundsApi.md#createvodbackground) | **POST** /ondemand/pages/{ondemand_id}/backgrounds | Add a background to an On Demand page
[**DeleteVodBackground**](OnDemandBackgroundsApi.md#deletevodbackground) | **DELETE** /ondemand/pages/{ondemand_id}/backgrounds/{background_id} | Delete a background on an On Demand page
[**EditVodBackground**](OnDemandBackgroundsApi.md#editvodbackground) | **PATCH** /ondemand/pages/{ondemand_id}/backgrounds/{background_id} | Edit a background on an On Demand page
[**GetVodBackground**](OnDemandBackgroundsApi.md#getvodbackground) | **GET** /ondemand/pages/{ondemand_id}/backgrounds/{background_id} | Get a specific background on an On Demand page
[**GetVodBackgrounds**](OnDemandBackgroundsApi.md#getvodbackgrounds) | **GET** /ondemand/pages/{ondemand_id}/backgrounds | Get all the backgrounds on an On Demand page


<a name="createvodbackground"></a>
# **CreateVodBackground**
> Picture CreateVodBackground (decimal ondemandId)

Add a background to an On Demand page

This method adds a background image to the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateVodBackgroundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandBackgroundsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Add a background to an On Demand page
                Picture result = apiInstance.CreateVodBackground(ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandBackgroundsApi.CreateVodBackground: " + e.Message );
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
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

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
| **200** | The background image was added. |  -  |
| **403** | The authenticated user can&#39;t add a background image to this On Demand page. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevodbackground"></a>
# **DeleteVodBackground**
> void DeleteVodBackground (decimal backgroundId, decimal ondemandId)

Delete a background on an On Demand page

This method deletes the specified background image on an On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVodBackgroundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandBackgroundsApi(config);
            var backgroundId = 12345;  // decimal | The ID of the background image.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Delete a background on an On Demand page
                apiInstance.DeleteVodBackground(backgroundId, ondemandId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandBackgroundsApi.DeleteVodBackground: " + e.Message );
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
 **backgroundId** | **decimal**| The ID of the background image. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

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
| **204** | The background image was deleted. |  -  |
| **403** | The authenticated user can&#39;t delete this background image. |  -  |
| **404** | No such On Demand page or background image exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editvodbackground"></a>
# **EditVodBackground**
> Picture EditVodBackground (decimal backgroundId, decimal ondemandId, InlineObject31 inlineObject31 = null)

Edit a background on an On Demand page

This method edits the specified background image on an On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditVodBackgroundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandBackgroundsApi(config);
            var backgroundId = 12345;  // decimal | The ID of the background image.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var inlineObject31 = new InlineObject31(); // InlineObject31 |  (optional) 

            try
            {
                // Edit a background on an On Demand page
                Picture result = apiInstance.EditVodBackground(backgroundId, ondemandId, inlineObject31);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandBackgroundsApi.EditVodBackground: " + e.Message );
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
 **backgroundId** | **decimal**| The ID of the background image. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 
 **inlineObject31** | [**InlineObject31**](InlineObject31.md)|  | [optional] 

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
| **200** | The background image was edited. |  -  |
| **403** | The authenticated user can&#39;t edit this background image. |  -  |
| **404** | No such On Demand page or background image exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodbackground"></a>
# **GetVodBackground**
> Picture GetVodBackground (decimal backgroundId, decimal ondemandId)

Get a specific background on an On Demand page

This method returns a single background image on the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodBackgroundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandBackgroundsApi(config);
            var backgroundId = 12345;  // decimal | The ID of the background image.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Get a specific background on an On Demand page
                Picture result = apiInstance.GetVodBackground(backgroundId, ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandBackgroundsApi.GetVodBackground: " + e.Message );
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
 **backgroundId** | **decimal**| The ID of the background image. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

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
| **200** | The background image was returned. |  -  |
| **403** | The authenticated user can&#39;t get this background image. |  -  |
| **404** | No such On Demand page or background image exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodbackgrounds"></a>
# **GetVodBackgrounds**
> List&lt;Picture&gt; GetVodBackgrounds (decimal ondemandId, decimal? page = null, decimal? perPage = null)

Get all the backgrounds on an On Demand page

This method returns every background image on the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodBackgroundsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandBackgroundsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the backgrounds on an On Demand page
                List<Picture> result = apiInstance.GetVodBackgrounds(ondemandId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandBackgroundsApi.GetVodBackgrounds: " + e.Message );
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
 **ondemandId** | **decimal**| The ID of the On Demand page. | 
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
| **200** | The background images were returned. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


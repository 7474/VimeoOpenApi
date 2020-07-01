# VimeoOpenApi.Api.EmbedPresetsEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditEmbedPreset**](EmbedPresetsEssentialsApi.md#editembedpreset) | **PATCH** /users/{user_id}/presets/{preset_id} | Edit an embed preset
[**EditEmbedPresetAlt1**](EmbedPresetsEssentialsApi.md#editembedpresetalt1) | **PATCH** /me/presets/{preset_id} | Edit an embed preset
[**GetEmbedPreset**](EmbedPresetsEssentialsApi.md#getembedpreset) | **GET** /users/{user_id}/presets/{preset_id} | Get a specific embed preset
[**GetEmbedPresetAlt1**](EmbedPresetsEssentialsApi.md#getembedpresetalt1) | **GET** /me/presets/{preset_id} | Get a specific embed preset
[**GetEmbedPresets**](EmbedPresetsEssentialsApi.md#getembedpresets) | **GET** /users/{user_id}/presets | Get all the embed presets that a user has created
[**GetEmbedPresetsAlt1**](EmbedPresetsEssentialsApi.md#getembedpresetsalt1) | **GET** /me/presets | Get all the embed presets that a user has created


<a name="editembedpreset"></a>
# **EditEmbedPreset**
> Presets EditEmbedPreset (decimal presetId, decimal userId, InlineObject47 inlineObject47 = null)

Edit an embed preset

This method edits the specified embed preset. The authenticated user must be the owner of the preset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditEmbedPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsEssentialsApi(config);
            var presetId = 12345;  // decimal | The ID of the preset.
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject47 = new InlineObject47(); // InlineObject47 |  (optional) 

            try
            {
                // Edit an embed preset
                Presets result = apiInstance.EditEmbedPreset(presetId, userId, inlineObject47);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsEssentialsApi.EditEmbedPreset: " + e.Message );
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
 **presetId** | **decimal**| The ID of the preset. | 
 **userId** | **decimal**| The ID of the user. | 
 **inlineObject47** | [**InlineObject47**](InlineObject47.md)|  | [optional] 

### Return type

[**Presets**](Presets.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.preset+json
 - **Accept**: application/vnd.vimeo.preset+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The embed preset was edited. |  -  |
| **400** | The outro type is invalid. |  -  |
| **404** | * No such embed preset exists. * The authenticated user can&#39;t edit the embed preset. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editembedpresetalt1"></a>
# **EditEmbedPresetAlt1**
> Presets EditEmbedPresetAlt1 (decimal presetId, InlineObject23 inlineObject23 = null)

Edit an embed preset

This method edits the specified embed preset. The authenticated user must be the owner of the preset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditEmbedPresetAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsEssentialsApi(config);
            var presetId = 12345;  // decimal | The ID of the preset.
            var inlineObject23 = new InlineObject23(); // InlineObject23 |  (optional) 

            try
            {
                // Edit an embed preset
                Presets result = apiInstance.EditEmbedPresetAlt1(presetId, inlineObject23);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsEssentialsApi.EditEmbedPresetAlt1: " + e.Message );
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
 **presetId** | **decimal**| The ID of the preset. | 
 **inlineObject23** | [**InlineObject23**](InlineObject23.md)|  | [optional] 

### Return type

[**Presets**](Presets.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.preset+json
 - **Accept**: application/vnd.vimeo.preset+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The embed preset was edited. |  -  |
| **400** | The outro type is invalid. |  -  |
| **404** | * No such embed preset exists. * The authenticated user can&#39;t edit the embed preset. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getembedpreset"></a>
# **GetEmbedPreset**
> Presets GetEmbedPreset (decimal presetId, decimal userId)

Get a specific embed preset

This method returns a single embed preset. The authenticated user must be the owner of the preset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetEmbedPresetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsEssentialsApi(config);
            var presetId = 12345;  // decimal | The ID of the preset.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get a specific embed preset
                Presets result = apiInstance.GetEmbedPreset(presetId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsEssentialsApi.GetEmbedPreset: " + e.Message );
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
 **presetId** | **decimal**| The ID of the preset. | 
 **userId** | **decimal**| The ID of the user. | 

### Return type

[**Presets**](Presets.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.preset+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The embed preset was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getembedpresetalt1"></a>
# **GetEmbedPresetAlt1**
> Presets GetEmbedPresetAlt1 (decimal presetId)

Get a specific embed preset

This method returns a single embed preset. The authenticated user must be the owner of the preset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetEmbedPresetAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsEssentialsApi(config);
            var presetId = 12345;  // decimal | The ID of the preset.

            try
            {
                // Get a specific embed preset
                Presets result = apiInstance.GetEmbedPresetAlt1(presetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsEssentialsApi.GetEmbedPresetAlt1: " + e.Message );
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
 **presetId** | **decimal**| The ID of the preset. | 

### Return type

[**Presets**](Presets.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.preset+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The embed preset was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getembedpresets"></a>
# **GetEmbedPresets**
> List&lt;Presets&gt; GetEmbedPresets (decimal userId, decimal? page = null, decimal? perPage = null)

Get all the embed presets that a user has created

This method returns every embed preset that belongs to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetEmbedPresetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the embed presets that a user has created
                List<Presets> result = apiInstance.GetEmbedPresets(userId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsEssentialsApi.GetEmbedPresets: " + e.Message );
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

[**List&lt;Presets&gt;**](Presets.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.preset+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The embed presets were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getembedpresetsalt1"></a>
# **GetEmbedPresetsAlt1**
> List&lt;Presets&gt; GetEmbedPresetsAlt1 (decimal? page = null, decimal? perPage = null)

Get all the embed presets that a user has created

This method returns every embed preset that belongs to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetEmbedPresetsAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsEssentialsApi(config);
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the embed presets that a user has created
                List<Presets> result = apiInstance.GetEmbedPresetsAlt1(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsEssentialsApi.GetEmbedPresetsAlt1: " + e.Message );
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

[**List&lt;Presets&gt;**](Presets.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.preset+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The embed presets were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


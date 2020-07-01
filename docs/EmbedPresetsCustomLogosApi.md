# VimeoOpenApi.Api.EmbedPresetsCustomLogosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomLogo**](EmbedPresetsCustomLogosApi.md#createcustomlogo) | **POST** /users/{user_id}/customlogos | Add a custom logo for the user
[**CreateCustomLogoAlt1**](EmbedPresetsCustomLogosApi.md#createcustomlogoalt1) | **POST** /me/customlogos | Add a custom logo for the user
[**GetCustomLogo**](EmbedPresetsCustomLogosApi.md#getcustomlogo) | **GET** /users/{user_id}/customlogos/{logo_id} | Get a specific custom logo for the user
[**GetCustomLogoAlt1**](EmbedPresetsCustomLogosApi.md#getcustomlogoalt1) | **GET** /me/customlogos/{logo_id} | Get a specific custom logo for the user
[**GetCustomLogos**](EmbedPresetsCustomLogosApi.md#getcustomlogos) | **GET** /users/{user_id}/customlogos | Get all the custom logos that belong to the user
[**GetCustomLogosAlt1**](EmbedPresetsCustomLogosApi.md#getcustomlogosalt1) | **GET** /me/customlogos | Get all the custom logos that belong to the user


<a name="createcustomlogo"></a>
# **CreateCustomLogo**
> Picture CreateCustomLogo (decimal userId)

Add a custom logo for the user

This method adds a custom logo representing the authenticated user for display in the embedded player.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateCustomLogoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsCustomLogosApi(config);
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Add a custom logo for the user
                Picture result = apiInstance.CreateCustomLogo(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsCustomLogosApi.CreateCustomLogo: " + e.Message );
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
| **201** | The custom logo was added. |  -  |
| **403** | The authenticated user can&#39;t add the custom logo. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomlogoalt1"></a>
# **CreateCustomLogoAlt1**
> Picture CreateCustomLogoAlt1 ()

Add a custom logo for the user

This method adds a custom logo representing the authenticated user for display in the embedded player.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateCustomLogoAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsCustomLogosApi(config);

            try
            {
                // Add a custom logo for the user
                Picture result = apiInstance.CreateCustomLogoAlt1();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsCustomLogosApi.CreateCustomLogoAlt1: " + e.Message );
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
| **201** | The custom logo was added. |  -  |
| **403** | The authenticated user can&#39;t add the custom logo. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomlogo"></a>
# **GetCustomLogo**
> Picture GetCustomLogo (decimal logoId, decimal userId)

Get a specific custom logo for the user

This method returns a single custom logo belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCustomLogoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsCustomLogosApi(config);
            var logoId = 12345;  // decimal | The ID of the custom logo.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get a specific custom logo for the user
                Picture result = apiInstance.GetCustomLogo(logoId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsCustomLogosApi.GetCustomLogo: " + e.Message );
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
| **403** | The authenticated user can&#39;t access the custom logo. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomlogoalt1"></a>
# **GetCustomLogoAlt1**
> Picture GetCustomLogoAlt1 (decimal logoId)

Get a specific custom logo for the user

This method returns a single custom logo belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCustomLogoAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsCustomLogosApi(config);
            var logoId = 12345;  // decimal | The ID of the custom logo.

            try
            {
                // Get a specific custom logo for the user
                Picture result = apiInstance.GetCustomLogoAlt1(logoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsCustomLogosApi.GetCustomLogoAlt1: " + e.Message );
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
 **logoId** | **decimal**| The ID of the custom logo. | 

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
| **403** | The authenticated user can&#39;t access the custom logo. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomlogos"></a>
# **GetCustomLogos**
> List&lt;Picture&gt; GetCustomLogos (decimal userId)

Get all the custom logos that belong to the user

This method returns every custom logo that belongs to the authenticated user or team owner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCustomLogosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsCustomLogosApi(config);
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get all the custom logos that belong to the user
                List<Picture> result = apiInstance.GetCustomLogos(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsCustomLogosApi.GetCustomLogos: " + e.Message );
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
| **403** | The authenticated user can&#39;t access the custom logos. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomlogosalt1"></a>
# **GetCustomLogosAlt1**
> List&lt;Picture&gt; GetCustomLogosAlt1 ()

Get all the custom logos that belong to the user

This method returns every custom logo that belongs to the authenticated user or team owner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCustomLogosAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmbedPresetsCustomLogosApi(config);

            try
            {
                // Get all the custom logos that belong to the user
                List<Picture> result = apiInstance.GetCustomLogosAlt1();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbedPresetsCustomLogosApi.GetCustomLogosAlt1: " + e.Message );
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
| **403** | The authenticated user can&#39;t access the custom logos. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


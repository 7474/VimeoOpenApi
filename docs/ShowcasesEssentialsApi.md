# VimeoOpenApi.Api.ShowcasesEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateShowcase**](ShowcasesEssentialsApi.md#createshowcase) | **POST** /users/{user_id}/albums | Create a showcase
[**CreateShowcaseAlt1**](ShowcasesEssentialsApi.md#createshowcasealt1) | **POST** /me/albums | Create a showcase
[**DeleteShowcase**](ShowcasesEssentialsApi.md#deleteshowcase) | **DELETE** /users/{user_id}/albums/{album_id} | Delete a showcase
[**DeleteShowcaseAlt1**](ShowcasesEssentialsApi.md#deleteshowcasealt1) | **DELETE** /me/albums/{album_id} | Delete a showcase
[**EditShowcase**](ShowcasesEssentialsApi.md#editshowcase) | **PATCH** /users/{user_id}/albums/{album_id} | Edit a showcase
[**EditShowcaseAlt1**](ShowcasesEssentialsApi.md#editshowcasealt1) | **PATCH** /me/albums/{album_id} | Edit a showcase
[**GetShowcase**](ShowcasesEssentialsApi.md#getshowcase) | **GET** /users/{user_id}/albums/{album_id} | Get a specific showcase
[**GetShowcaseAlt1**](ShowcasesEssentialsApi.md#getshowcasealt1) | **GET** /me/albums/{album_id} | Get a specific showcase
[**GetShowcases**](ShowcasesEssentialsApi.md#getshowcases) | **GET** /users/{user_id}/albums | Get all the showcases that belong to the user
[**GetShowcasesAlt1**](ShowcasesEssentialsApi.md#getshowcasesalt1) | **GET** /me/albums | Get all the showcases that belong to the user


<a name="createshowcase"></a>
# **CreateShowcase**
> Album CreateShowcase (decimal userId, InlineObject38 inlineObject38)

Create a showcase

This method creates a new showcase for the specified user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateShowcaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject38 = new InlineObject38(); // InlineObject38 | 

            try
            {
                // Create a showcase
                Album result = apiInstance.CreateShowcase(userId, inlineObject38);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.CreateShowcase: " + e.Message );
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
 **inlineObject38** | [**InlineObject38**](InlineObject38.md)|  | 

### Return type

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.album+json
 - **Accept**: application/vnd.vimeo.album+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The showcase was created. |  -  |
| **400** | A parameter is invalid. |  -  |
| **403** | The supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t create showcases. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createshowcasealt1"></a>
# **CreateShowcaseAlt1**
> Album CreateShowcaseAlt1 (InlineObject16 inlineObject16)

Create a showcase

This method creates a new showcase for the specified user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateShowcaseAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var inlineObject16 = new InlineObject16(); // InlineObject16 | 

            try
            {
                // Create a showcase
                Album result = apiInstance.CreateShowcaseAlt1(inlineObject16);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.CreateShowcaseAlt1: " + e.Message );
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
 **inlineObject16** | [**InlineObject16**](InlineObject16.md)|  | 

### Return type

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.album+json
 - **Accept**: application/vnd.vimeo.album+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The showcase was created. |  -  |
| **400** | A parameter is invalid. |  -  |
| **403** | The supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t create showcases. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshowcase"></a>
# **DeleteShowcase**
> void DeleteShowcase (decimal albumId, decimal userId)

Delete a showcase

This method deletes the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteShowcaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Delete a showcase
                apiInstance.DeleteShowcase(albumId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.DeleteShowcase: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The showcase was deleted. |  -  |
| **403** | The supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t delete the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshowcasealt1"></a>
# **DeleteShowcaseAlt1**
> void DeleteShowcaseAlt1 (decimal albumId)

Delete a showcase

This method deletes the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteShowcaseAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.

            try
            {
                // Delete a showcase
                apiInstance.DeleteShowcaseAlt1(albumId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.DeleteShowcaseAlt1: " + e.Message );
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
| **204** | The showcase was deleted. |  -  |
| **403** | The supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t delete the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editshowcase"></a>
# **EditShowcase**
> Album EditShowcase (decimal albumId, decimal userId, InlineObject39 inlineObject39 = null)

Edit a showcase

This method edits the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditShowcaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject39 = new InlineObject39(); // InlineObject39 |  (optional) 

            try
            {
                // Edit a showcase
                Album result = apiInstance.EditShowcase(albumId, userId, inlineObject39);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.EditShowcase: " + e.Message );
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
 **inlineObject39** | [**InlineObject39**](InlineObject39.md)|  | [optional] 

### Return type

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.album+json
 - **Accept**: application/vnd.vimeo.album+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The showcase was edited. |  -  |
| **400** | A parameter is invalid. |  -  |
| **403** | The authenticated user doesn&#39;t own the showcase, the supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t edit the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editshowcasealt1"></a>
# **EditShowcaseAlt1**
> Album EditShowcaseAlt1 (decimal albumId, InlineObject17 inlineObject17 = null)

Edit a showcase

This method edits the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditShowcaseAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var inlineObject17 = new InlineObject17(); // InlineObject17 |  (optional) 

            try
            {
                // Edit a showcase
                Album result = apiInstance.EditShowcaseAlt1(albumId, inlineObject17);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.EditShowcaseAlt1: " + e.Message );
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
 **inlineObject17** | [**InlineObject17**](InlineObject17.md)|  | [optional] 

### Return type

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.album+json
 - **Accept**: application/vnd.vimeo.album+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The showcase was edited. |  -  |
| **400** | A parameter is invalid. |  -  |
| **403** | The authenticated user doesn&#39;t own the showcase, the supplied token doesn&#39;t have the proper scopes, or the authenticated user can&#39;t edit the showcase. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcase"></a>
# **GetShowcase**
> Album GetShowcase (decimal albumId, decimal userId)

Get a specific showcase

This method returns the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get a specific showcase
                Album result = apiInstance.GetShowcase(albumId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.GetShowcase: " + e.Message );
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

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.album+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The showcase was returned. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcasealt1"></a>
# **GetShowcaseAlt1**
> Album GetShowcaseAlt1 (decimal albumId)

Get a specific showcase

This method returns the specified showcase. The authenticated user must be the owner of the showcase.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcaseAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var albumId = 3706071;  // decimal | The ID of the showcase.

            try
            {
                // Get a specific showcase
                Album result = apiInstance.GetShowcaseAlt1(albumId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.GetShowcaseAlt1: " + e.Message );
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

### Return type

[**Album**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.album+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The showcase was returned. |  -  |
| **404** | No such showcase exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcases"></a>
# **GetShowcases**
> List&lt;Album&gt; GetShowcases (decimal userId, string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the showcases that belong to the user

This method returns every showcase belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date of creation.  * `duration` - Sort the results by duration.  * `videos` - Sort the results by the number of videos.  (optional) 

            try
            {
                // Get all the showcases that belong to the user
                List<Album> result = apiInstance.GetShowcases(userId, direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.GetShowcases: " + e.Message );
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
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date of creation.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;videos&#x60; - Sort the results by the number of videos.  | [optional] 

### Return type

[**List&lt;Album&gt;**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The showcases were returned. |  -  |
| **400** | A parameter is invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshowcasesalt1"></a>
# **GetShowcasesAlt1**
> List&lt;Album&gt; GetShowcasesAlt1 (string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the showcases that belong to the user

This method returns every showcase belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetShowcasesAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShowcasesEssentialsApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date of creation.  * `duration` - Sort the results by duration.  * `videos` - Sort the results by the number of videos.  (optional) 

            try
            {
                // Get all the showcases that belong to the user
                List<Album> result = apiInstance.GetShowcasesAlt1(direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShowcasesEssentialsApi.GetShowcasesAlt1: " + e.Message );
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
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date of creation.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;videos&#x60; - Sort the results by the number of videos.  | [optional] 

### Return type

[**List&lt;Album&gt;**](Album.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The showcases were returned. |  -  |
| **400** | A parameter is invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


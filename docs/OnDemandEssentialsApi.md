# VimeoOpenApi.Api.OnDemandEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVod**](OnDemandEssentialsApi.md#createvod) | **POST** /users/{user_id}/ondemand/pages | Create an On Demand page
[**CreateVodAlt1**](OnDemandEssentialsApi.md#createvodalt1) | **POST** /me/ondemand/pages | Create an On Demand page
[**DeleteVodDraft**](OnDemandEssentialsApi.md#deletevoddraft) | **DELETE** /ondemand/pages/{ondemand_id} | Delete an On Demand page
[**EditVod**](OnDemandEssentialsApi.md#editvod) | **PATCH** /ondemand/pages/{ondemand_id} | Edit an On Demand page
[**GetUserVods**](OnDemandEssentialsApi.md#getuservods) | **GET** /users/{user_id}/ondemand/pages | Get all the On Demand pages of the user
[**GetUserVodsAlt1**](OnDemandEssentialsApi.md#getuservodsalt1) | **GET** /me/ondemand/pages | Get all the On Demand pages of the user
[**GetVod**](OnDemandEssentialsApi.md#getvod) | **GET** /ondemand/pages/{ondemand_id} | Get a specific On Demand page


<a name="createvod"></a>
# **CreateVod**
> OnDemandPage CreateVod (decimal userId, InlineObject45 inlineObject45)

Create an On Demand page

This method creates a new On Demand page for the specified user. To publish the page, use the edit method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateVodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject45 = new InlineObject45(); // InlineObject45 | 

            try
            {
                // Create an On Demand page
                OnDemandPage result = apiInstance.CreateVod(userId, inlineObject45);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandEssentialsApi.CreateVod: " + e.Message );
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
 **inlineObject45** | [**InlineObject45**](InlineObject45.md)|  | 

### Return type

[**OnDemandPage**](OnDemandPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The On Demand page was created. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvodalt1"></a>
# **CreateVodAlt1**
> OnDemandPage CreateVodAlt1 (InlineObject21 inlineObject21)

Create an On Demand page

This method creates a new On Demand page for the specified user. To publish the page, use the edit method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateVodAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandEssentialsApi(config);
            var inlineObject21 = new InlineObject21(); // InlineObject21 | 

            try
            {
                // Create an On Demand page
                OnDemandPage result = apiInstance.CreateVodAlt1(inlineObject21);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandEssentialsApi.CreateVodAlt1: " + e.Message );
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
 **inlineObject21** | [**InlineObject21**](InlineObject21.md)|  | 

### Return type

[**OnDemandPage**](OnDemandPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The On Demand page was created. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevoddraft"></a>
# **DeleteVodDraft**
> void DeleteVodDraft (decimal ondemandId)

Delete an On Demand page

This method deletes the specified On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVodDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandEssentialsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Delete an On Demand page
                apiInstance.DeleteVodDraft(ondemandId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandEssentialsApi.DeleteVodDraft: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.page+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The On Demand page was deleted. |  -  |
| **403** | The authenticated user can&#39;t delete this On Demand page. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editvod"></a>
# **EditVod**
> OnDemandPage EditVod (decimal ondemandId, InlineObject30 inlineObject30 = null)

Edit an On Demand page

This method edits the specified On Demand page. Use this method to enable preorders on the page or publish the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditVodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandEssentialsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var inlineObject30 = new InlineObject30(); // InlineObject30 |  (optional) 

            try
            {
                // Edit an On Demand page
                OnDemandPage result = apiInstance.EditVod(ondemandId, inlineObject30);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandEssentialsApi.EditVod: " + e.Message );
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
 **inlineObject30** | [**InlineObject30**](InlineObject30.md)|  | [optional] 

### Return type

[**OnDemandPage**](OnDemandPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.ondemand.page+json
 - **Accept**: application/vnd.vimeo.ondemand.page+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The On Demand page was edited. |  -  |
| **403** | The authenticated user can&#39;t edit the On Demand page. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuservods"></a>
# **GetUserVods**
> List&lt;OnDemandPage&gt; GetUserVods (decimal userId, string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the On Demand pages of the user

This method returns every On Demand page belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetUserVodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The type of pages to return. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the On Demand pages of the user
                List<OnDemandPage> result = apiInstance.GetUserVods(userId, direction, filter, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandEssentialsApi.GetUserVods: " + e.Message );
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
 **filter** | **string**| The type of pages to return. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results. | [optional] 

### Return type

[**List&lt;OnDemandPage&gt;**](OnDemandPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.page+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The On Demand pages were returned. |  -  |
| **404** | No such user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuservodsalt1"></a>
# **GetUserVodsAlt1**
> List&lt;OnDemandPage&gt; GetUserVodsAlt1 (string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the On Demand pages of the user

This method returns every On Demand page belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetUserVodsAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandEssentialsApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The type of pages to return. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the On Demand pages of the user
                List<OnDemandPage> result = apiInstance.GetUserVodsAlt1(direction, filter, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandEssentialsApi.GetUserVodsAlt1: " + e.Message );
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
 **filter** | **string**| The type of pages to return. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results. | [optional] 

### Return type

[**List&lt;OnDemandPage&gt;**](OnDemandPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.page+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The On Demand pages were returned. |  -  |
| **404** | No such user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvod"></a>
# **GetVod**
> OnDemandPage GetVod (decimal ondemandId)

Get a specific On Demand page

This method returns the specified On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandEssentialsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Get a specific On Demand page
                OnDemandPage result = apiInstance.GetVod(ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandEssentialsApi.GetVod: " + e.Message );
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

[**OnDemandPage**](OnDemandPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.page+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The On Demand page was returned. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


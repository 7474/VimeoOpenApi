# VimeoOpenApi.Api.CategoriesUsersApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckIfUserSubscribedToCategory**](CategoriesUsersApi.md#checkifusersubscribedtocategory) | **GET** /users/{user_id}/categories/{category} | Check if the user follows a category
[**CheckIfUserSubscribedToCategoryAlt1**](CategoriesUsersApi.md#checkifusersubscribedtocategoryalt1) | **GET** /me/categories/{category} | Check if the user follows a category
[**GetCategorySubscriptions**](CategoriesUsersApi.md#getcategorysubscriptions) | **GET** /users/{user_id}/categories | Get all the categories that the user follows
[**GetCategorySubscriptionsAlt1**](CategoriesUsersApi.md#getcategorysubscriptionsalt1) | **GET** /me/categories | Get all the categories that the user follows
[**SubscribeToCategory**](CategoriesUsersApi.md#subscribetocategory) | **PUT** /users/{user_id}/categories/{category} | Cause the user to follow a specific category
[**SubscribeToCategoryAlt1**](CategoriesUsersApi.md#subscribetocategoryalt1) | **PUT** /me/categories/{category} | Cause the user to follow a specific category
[**UnsubscribeFromCategory**](CategoriesUsersApi.md#unsubscribefromcategory) | **DELETE** /users/{user_id}/categories/{category} | Cause the user to stop following a category
[**UnsubscribeFromCategoryAlt1**](CategoriesUsersApi.md#unsubscribefromcategoryalt1) | **DELETE** /me/categories/{category} | Cause the user to stop following a category


<a name="checkifusersubscribedtocategory"></a>
# **CheckIfUserSubscribedToCategory**
> void CheckIfUserSubscribedToCategory (string category, decimal userId)

Check if the user follows a category

This method determines whether the authenticated user follows the specified category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserSubscribedToCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesUsersApi(config);
            var category = animation;  // string | The name of the category.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Check if the user follows a category
                apiInstance.CheckIfUserSubscribedToCategory(category, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesUsersApi.CheckIfUserSubscribedToCategory: " + e.Message );
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
 **category** | **string**| The name of the category. | 
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
| **204** | The user is following the category. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkifusersubscribedtocategoryalt1"></a>
# **CheckIfUserSubscribedToCategoryAlt1**
> void CheckIfUserSubscribedToCategoryAlt1 (string category)

Check if the user follows a category

This method determines whether the authenticated user follows the specified category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserSubscribedToCategoryAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesUsersApi(config);
            var category = animation;  // string | The name of the category.

            try
            {
                // Check if the user follows a category
                apiInstance.CheckIfUserSubscribedToCategoryAlt1(category);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesUsersApi.CheckIfUserSubscribedToCategoryAlt1: " + e.Message );
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
 **category** | **string**| The name of the category. | 

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
| **204** | The user is following the category. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategorysubscriptions"></a>
# **GetCategorySubscriptions**
> List&lt;Category&gt; GetCategorySubscriptions (decimal userId, string direction = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the categories that the user follows

This method returns every category that the authenticated user follows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCategorySubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesUsersApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date.  * `name` - Sort the results by name.  (optional) 

            try
            {
                // Get all the categories that the user follows
                List<Category> result = apiInstance.GetCategorySubscriptions(userId, direction, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesUsersApi.GetCategorySubscriptions: " + e.Message );
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
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;name&#x60; - Sort the results by name.  | [optional] 

### Return type

[**List&lt;Category&gt;**](Category.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.category+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The categories were returned. |  -  |
| **403** | Error code 3200: Only the authenticated user can access this information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategorysubscriptionsalt1"></a>
# **GetCategorySubscriptionsAlt1**
> List&lt;Category&gt; GetCategorySubscriptionsAlt1 (string direction = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the categories that the user follows

This method returns every category that the authenticated user follows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCategorySubscriptionsAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesUsersApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date.  * `name` - Sort the results by name.  (optional) 

            try
            {
                // Get all the categories that the user follows
                List<Category> result = apiInstance.GetCategorySubscriptionsAlt1(direction, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesUsersApi.GetCategorySubscriptionsAlt1: " + e.Message );
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
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;name&#x60; - Sort the results by name.  | [optional] 

### Return type

[**List&lt;Category&gt;**](Category.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.category+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The categories were returned. |  -  |
| **403** | Error code 3200: Only the authenticated user can access this information. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribetocategory"></a>
# **SubscribeToCategory**
> void SubscribeToCategory (decimal category, decimal userId)

Cause the user to follow a specific category

This method causes the authenticated user to follow the specified category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SubscribeToCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesUsersApi(config);
            var category = 0;  // decimal | The name of the category.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Cause the user to follow a specific category
                apiInstance.SubscribeToCategory(category, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesUsersApi.SubscribeToCategory: " + e.Message );
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
 **category** | **decimal**| The name of the category. | 
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
| **204** | The user is following the category. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribetocategoryalt1"></a>
# **SubscribeToCategoryAlt1**
> void SubscribeToCategoryAlt1 (decimal category)

Cause the user to follow a specific category

This method causes the authenticated user to follow the specified category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SubscribeToCategoryAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesUsersApi(config);
            var category = 0;  // decimal | The name of the category.

            try
            {
                // Cause the user to follow a specific category
                apiInstance.SubscribeToCategoryAlt1(category);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesUsersApi.SubscribeToCategoryAlt1: " + e.Message );
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
 **category** | **decimal**| The name of the category. | 

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
| **204** | The user is following the category. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsubscribefromcategory"></a>
# **UnsubscribeFromCategory**
> void UnsubscribeFromCategory (string category, decimal userId)

Cause the user to stop following a category

This method causes the authenticated user to stop following the specified category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UnsubscribeFromCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesUsersApi(config);
            var category = animation;  // string | The name of the category.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Cause the user to stop following a category
                apiInstance.UnsubscribeFromCategory(category, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesUsersApi.UnsubscribeFromCategory: " + e.Message );
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
 **category** | **string**| The name of the category. | 
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
| **204** | The user has stopped following the category. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsubscribefromcategoryalt1"></a>
# **UnsubscribeFromCategoryAlt1**
> void UnsubscribeFromCategoryAlt1 (string category)

Cause the user to stop following a category

This method causes the authenticated user to stop following the specified category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UnsubscribeFromCategoryAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesUsersApi(config);
            var category = animation;  // string | The name of the category.

            try
            {
                // Cause the user to stop following a category
                apiInstance.UnsubscribeFromCategoryAlt1(category);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesUsersApi.UnsubscribeFromCategoryAlt1: " + e.Message );
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
 **category** | **string**| The name of the category. | 

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
| **204** | The user has stopped following the category. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


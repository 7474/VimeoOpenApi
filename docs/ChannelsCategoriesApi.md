# VimeoOpenApi.Api.ChannelsCategoriesApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddChannelCategories**](ChannelsCategoriesApi.md#addchannelcategories) | **PUT** /channels/{channel_id}/categories | Add a channel to a list of categories
[**CategorizeChannel**](ChannelsCategoriesApi.md#categorizechannel) | **PUT** /channels/{channel_id}/categories/{category} | Add a channel to a specific category
[**DeleteChannelCategory**](ChannelsCategoriesApi.md#deletechannelcategory) | **DELETE** /channels/{channel_id}/categories/{category} | Remove a channel from a category
[**GetChannelCategories**](ChannelsCategoriesApi.md#getchannelcategories) | **GET** /channels/{channel_id}/categories | Get all the categories to which a channel belongs


<a name="addchannelcategories"></a>
# **AddChannelCategories**
> void AddChannelCategories (decimal channelId, InlineObject2 inlineObject2)

Add a channel to a list of categories

This method adds the specified channel to multiple categories.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddChannelCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsCategoriesApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var inlineObject2 = new InlineObject2(); // InlineObject2 | 

            try
            {
                // Add a channel to a list of categories
                apiInstance.AddChannelCategories(channelId, inlineObject2);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsCategoriesApi.AddChannelCategories: " + e.Message );
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
 **inlineObject2** | [**InlineObject2**](InlineObject2.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The channel was added to the categories. |  -  |
| **400** | * Error code 2204: You exceeded the maximum number of channel categories. * Error code 2205: There was no request body, or the request body is malformed. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t add categories to the channel. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categorizechannel"></a>
# **CategorizeChannel**
> void CategorizeChannel (string category, decimal channelId)

Add a channel to a specific category

This method adds the specified channel to a single category. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CategorizeChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsCategoriesApi(config);
            var category = animation;  // string | The name of the category.
            var channelId = 927;  // decimal | The ID of the channel.

            try
            {
                // Add a channel to a specific category
                apiInstance.CategorizeChannel(category, channelId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsCategoriesApi.CategorizeChannel: " + e.Message );
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
 **channelId** | **decimal**| The ID of the channel. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.category+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The channel was added to the category. |  -  |
| **400** | Error code 2204: You exceeded the maximum number of channel categories. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user doesn&#39;t own the channel or isn&#39;t a channel moderator. |  -  |
| **404** | No such channel or category exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechannelcategory"></a>
# **DeleteChannelCategory**
> void DeleteChannelCategory (string category, decimal channelId)

Remove a channel from a category

This method removes a channel from the specified category. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteChannelCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsCategoriesApi(config);
            var category = animation;  // string | The name of the category.
            var channelId = 927;  // decimal | The ID of the channel.

            try
            {
                // Remove a channel from a category
                apiInstance.DeleteChannelCategory(category, channelId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsCategoriesApi.DeleteChannelCategory: " + e.Message );
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
 **channelId** | **decimal**| The ID of the channel. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.category+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The channel was removed. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user doesn&#39;t own the channel or isn&#39;t a channel moderator. |  -  |
| **404** | No such channel or category exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcategories"></a>
# **GetChannelCategories**
> List&lt;Category&gt; GetChannelCategories (decimal channelId)

Get all the categories to which a channel belongs

This method returns every category to which the specified channel belongs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetChannelCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsCategoriesApi(config);
            var channelId = 927;  // decimal | The ID of the channel.

            try
            {
                // Get all the categories to which a channel belongs
                List<Category> result = apiInstance.GetChannelCategories(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsCategoriesApi.GetChannelCategories: " + e.Message );
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
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


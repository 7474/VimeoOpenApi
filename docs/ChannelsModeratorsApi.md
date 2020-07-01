# VimeoOpenApi.Api.ChannelsModeratorsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddChannelModerator**](ChannelsModeratorsApi.md#addchannelmoderator) | **PUT** /channels/{channel_id}/moderators/{user_id} | Add a specific moderator to a channel
[**AddChannelModerators**](ChannelsModeratorsApi.md#addchannelmoderators) | **PUT** /channels/{channel_id}/moderators | Add a list of moderators to a channel
[**GetChannelModerator**](ChannelsModeratorsApi.md#getchannelmoderator) | **GET** /channels/{channel_id}/moderators/{user_id} | Get a specific moderator of a channel
[**GetChannelModerators**](ChannelsModeratorsApi.md#getchannelmoderators) | **GET** /channels/{channel_id}/moderators | Get all the moderators of a channel
[**RemoveChannelModerator**](ChannelsModeratorsApi.md#removechannelmoderator) | **DELETE** /channels/{channel_id}/moderators/{user_id} | Remove a specific moderator from a channel
[**RemoveChannelModerators**](ChannelsModeratorsApi.md#removechannelmoderators) | **DELETE** /channels/{channel_id}/moderators | Remove a list of moderators from a channel
[**ReplaceChannelModerators**](ChannelsModeratorsApi.md#replacechannelmoderators) | **PATCH** /channels/{channel_id}/moderators | Replace the moderators of a channel


<a name="addchannelmoderator"></a>
# **AddChannelModerator**
> void AddChannelModerator (decimal channelId, decimal userId)

Add a specific moderator to a channel

This method adds a single user as a moderator to the specified channel. The authenticated user must be a follower of the requested user to add them as a channel moderator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddChannelModeratorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsModeratorsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Add a specific moderator to a channel
                apiInstance.AddChannelModerator(channelId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsModeratorsApi.AddChannelModerator: " + e.Message );
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
 **userId** | **decimal**| The ID of the user. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.user+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **403** | The authenticated user doesn&#39;t own the channel, the requested user is already a moderator of the channel, or the authenticated user doesn&#39;t follow the requested user. |  -  |
| **404** | No such channel exists, or no such user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addchannelmoderators"></a>
# **AddChannelModerators**
> void AddChannelModerators (decimal channelId, InlineObject3 inlineObject3)

Add a list of moderators to a channel

This method adds multiple users as moderators to the specified channel. The authenticated user must be a follower of a requested user to add this person as a channel moderator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddChannelModeratorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsModeratorsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var inlineObject3 = new InlineObject3(); // InlineObject3 | 

            try
            {
                // Add a list of moderators to a channel
                apiInstance.AddChannelModerators(channelId, inlineObject3);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsModeratorsApi.AddChannelModerators: " + e.Message );
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
 **inlineObject3** | [**InlineObject3**](InlineObject3.md)|  | 

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
| **200** | The moderators were added. |  -  |
| **400** | Error code 2908: The list contains more than 100 users. |  -  |
| **403** | The authenticated user doesn&#39;t own the channel, a requested user is already a moderator of the channel, or the authenticated user doesn&#39;t follow a requested user. |  -  |
| **404** | No such channel exists, or no such user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelmoderator"></a>
# **GetChannelModerator**
> User GetChannelModerator (decimal channelId, decimal userId)

Get a specific moderator of a channel

This method returns a single moderator of the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetChannelModeratorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsModeratorsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get a specific moderator of a channel
                User result = apiInstance.GetChannelModerator(channelId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsModeratorsApi.GetChannelModerator: " + e.Message );
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
 **userId** | **decimal**| The ID of the user. | 

### Return type

[**User**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.user+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The moderator was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelmoderators"></a>
# **GetChannelModerators**
> List&lt;User&gt; GetChannelModerators (decimal channelId, string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the moderators of a channel

This method returns every moderator of the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetChannelModeratorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsModeratorsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date added.  (optional) 

            try
            {
                // Get all the moderators of a channel
                List<User> result = apiInstance.GetChannelModerators(channelId, direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsModeratorsApi.GetChannelModerators: " + e.Message );
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
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date added.  | [optional] 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.user+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The moderators were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removechannelmoderator"></a>
# **RemoveChannelModerator**
> void RemoveChannelModerator (decimal channelId, decimal userId)

Remove a specific moderator from a channel

This method removes a single moderator from the specified channel. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class RemoveChannelModeratorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsModeratorsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Remove a specific moderator from a channel
                apiInstance.RemoveChannelModerator(channelId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsModeratorsApi.RemoveChannelModerator: " + e.Message );
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
 **userId** | **decimal**| The ID of the user. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.user+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The moderator was removed. |  -  |
| **403** | The authenticated user doesn&#39;t own the channel, the requested user isn&#39;t a moderator of the channel, or the requested user is the owner of the channel. |  -  |
| **404** | No such channel exists, or no such user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removechannelmoderators"></a>
# **RemoveChannelModerators**
> void RemoveChannelModerators (decimal channelId, InlineObject4 inlineObject4)

Remove a list of moderators from a channel

This method removes multiple moderators from the specified channel. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class RemoveChannelModeratorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsModeratorsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var inlineObject4 = new InlineObject4(); // InlineObject4 | 

            try
            {
                // Remove a list of moderators from a channel
                apiInstance.RemoveChannelModerators(channelId, inlineObject4);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsModeratorsApi.RemoveChannelModerators: " + e.Message );
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
 **inlineObject4** | [**InlineObject4**](InlineObject4.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.user+json
 - **Accept**: application/vnd.vimeo.user+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The moderators were removed. |  -  |
| **403** | The authenticated user doesn&#39;t own the channel, a requested user isn&#39;t a moderator of the channel, or a requested user is the owner of the channel. |  -  |
| **404** | No such channel exists, or no such user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacechannelmoderators"></a>
# **ReplaceChannelModerators**
> List&lt;User&gt; ReplaceChannelModerators (decimal channelId, InlineObject5 inlineObject5)

Replace the moderators of a channel

This method replaces the current list of channel moderators with a new list. The authenticated user must be the owner of the channel and a follower of each requested user to add them as a channel moderator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class ReplaceChannelModeratorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsModeratorsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var inlineObject5 = new InlineObject5(); // InlineObject5 | 

            try
            {
                // Replace the moderators of a channel
                List<User> result = apiInstance.ReplaceChannelModerators(channelId, inlineObject5);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsModeratorsApi.ReplaceChannelModerators: " + e.Message );
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
 **inlineObject5** | [**InlineObject5**](InlineObject5.md)|  | 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The moderators were replaced. |  -  |
| **400** | Error code 2908: The list contains more than 100 users. |  -  |
| **403** | The authenticated user doesn&#39;t own the channel. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


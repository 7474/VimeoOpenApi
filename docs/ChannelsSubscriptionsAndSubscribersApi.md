# VimeoOpenApi.Api.ChannelsSubscriptionsAndSubscribersApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckIfUserSubscribedToChannel**](ChannelsSubscriptionsAndSubscribersApi.md#checkifusersubscribedtochannel) | **GET** /users/{user_id}/channels/{channel_id} | Check if a user follows a channel
[**CheckIfUserSubscribedToChannelAlt1**](ChannelsSubscriptionsAndSubscribersApi.md#checkifusersubscribedtochannelalt1) | **GET** /me/channels/{channel_id} | Check if a user follows a channel
[**GetChannelSubscribers**](ChannelsSubscriptionsAndSubscribersApi.md#getchannelsubscribers) | **GET** /channels/{channel_id}/users | Get all the followers of a channel
[**SubscribeToChannel**](ChannelsSubscriptionsAndSubscribersApi.md#subscribetochannel) | **PUT** /users/{user_id}/channels/{channel_id} | Subscribe the user to a specific channel
[**SubscribeToChannelAlt1**](ChannelsSubscriptionsAndSubscribersApi.md#subscribetochannelalt1) | **PUT** /me/channels/{channel_id} | Subscribe the user to a specific channel
[**UnsubscribeFromChannel**](ChannelsSubscriptionsAndSubscribersApi.md#unsubscribefromchannel) | **DELETE** /users/{user_id}/channels/{channel_id} | Unsubscribe the user from a specific channel
[**UnsubscribeFromChannelAlt1**](ChannelsSubscriptionsAndSubscribersApi.md#unsubscribefromchannelalt1) | **DELETE** /me/channels/{channel_id} | Unsubscribe the user from a specific channel


<a name="checkifusersubscribedtochannel"></a>
# **CheckIfUserSubscribedToChannel**
> void CheckIfUserSubscribedToChannel (decimal channelId, decimal userId)

Check if a user follows a channel

This method determines whether the specified user is a follower of a particular channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserSubscribedToChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsSubscriptionsAndSubscribersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Check if a user follows a channel
                apiInstance.CheckIfUserSubscribedToChannel(channelId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsSubscriptionsAndSubscribersApi.CheckIfUserSubscribedToChannel: " + e.Message );
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
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The user follows the channel. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkifusersubscribedtochannelalt1"></a>
# **CheckIfUserSubscribedToChannelAlt1**
> void CheckIfUserSubscribedToChannelAlt1 (decimal channelId)

Check if a user follows a channel

This method determines whether the specified user is a follower of a particular channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserSubscribedToChannelAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsSubscriptionsAndSubscribersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.

            try
            {
                // Check if a user follows a channel
                apiInstance.CheckIfUserSubscribedToChannelAlt1(channelId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsSubscriptionsAndSubscribersApi.CheckIfUserSubscribedToChannelAlt1: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The user follows the channel. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelsubscribers"></a>
# **GetChannelSubscribers**
> List&lt;User&gt; GetChannelSubscribers (decimal channelId, string filter, string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the followers of a channel

This method returns every follower of the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetChannelSubscribersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsSubscriptionsAndSubscribersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `moderators` - Return moderators. 
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by follow date.  (optional) 

            try
            {
                // Get all the followers of a channel
                List<User> result = apiInstance.GetChannelSubscribers(channelId, filter, direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsSubscriptionsAndSubscribersApi.GetChannelSubscribers: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;moderators&#x60; - Return moderators.  | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by follow date.  | [optional] 

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
| **200** | The followers were returned. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribetochannel"></a>
# **SubscribeToChannel**
> void SubscribeToChannel (decimal channelId, decimal userId)

Subscribe the user to a specific channel

This method subscribes the authenticated user to the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SubscribeToChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsSubscriptionsAndSubscribersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Subscribe the user to a specific channel
                apiInstance.SubscribeToChannel(channelId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsSubscriptionsAndSubscribersApi.SubscribeToChannel: " + e.Message );
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
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The user is subscribed to the channel. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribetochannelalt1"></a>
# **SubscribeToChannelAlt1**
> void SubscribeToChannelAlt1 (decimal channelId)

Subscribe the user to a specific channel

This method subscribes the authenticated user to the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SubscribeToChannelAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsSubscriptionsAndSubscribersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.

            try
            {
                // Subscribe the user to a specific channel
                apiInstance.SubscribeToChannelAlt1(channelId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsSubscriptionsAndSubscribersApi.SubscribeToChannelAlt1: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The user is subscribed to the channel. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsubscribefromchannel"></a>
# **UnsubscribeFromChannel**
> void UnsubscribeFromChannel (decimal channelId, decimal userId)

Unsubscribe the user from a specific channel

This method unsubscribes the authenticated user from the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UnsubscribeFromChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsSubscriptionsAndSubscribersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Unsubscribe the user from a specific channel
                apiInstance.UnsubscribeFromChannel(channelId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsSubscriptionsAndSubscribersApi.UnsubscribeFromChannel: " + e.Message );
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
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The user is unsubscribed from the channel. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsubscribefromchannelalt1"></a>
# **UnsubscribeFromChannelAlt1**
> void UnsubscribeFromChannelAlt1 (decimal channelId)

Unsubscribe the user from a specific channel

This method unsubscribes the authenticated user from the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UnsubscribeFromChannelAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsSubscriptionsAndSubscribersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.

            try
            {
                // Unsubscribe the user from a specific channel
                apiInstance.UnsubscribeFromChannelAlt1(channelId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsSubscriptionsAndSubscribersApi.UnsubscribeFromChannelAlt1: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The user is unsubscribed from the channel. |  -  |
| **404** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


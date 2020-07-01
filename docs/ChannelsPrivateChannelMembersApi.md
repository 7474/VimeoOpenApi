# VimeoOpenApi.Api.ChannelsPrivateChannelMembersApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteChannelPrivacyUser**](ChannelsPrivateChannelMembersApi.md#deletechannelprivacyuser) | **DELETE** /channels/{channel_id}/privacy/users/{user_id} | Restrict a user from accessing a private channel
[**GetChannelPrivacyUsers**](ChannelsPrivateChannelMembersApi.md#getchannelprivacyusers) | **GET** /channels/{channel_id}/privacy/users | Get all the users who can access a private channel
[**SetChannelPrivacyUser**](ChannelsPrivateChannelMembersApi.md#setchannelprivacyuser) | **PUT** /channels/{channel_id}/privacy/users/{user_id} | Permit a specific user to access a private channel
[**SetChannelPrivacyUsers**](ChannelsPrivateChannelMembersApi.md#setchannelprivacyusers) | **PUT** /channels/{channel_id}/privacy/users | Permit a list of users to access a private channel


<a name="deletechannelprivacyuser"></a>
# **DeleteChannelPrivacyUser**
> void DeleteChannelPrivacyUser (decimal channelId, decimal userId)

Restrict a user from accessing a private channel

This method prevents a single user from being able to access the specified private channel. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteChannelPrivacyUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsPrivateChannelMembersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Restrict a user from accessing a private channel
                apiInstance.DeleteChannelPrivacyUser(channelId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsPrivateChannelMembersApi.DeleteChannelPrivacyUser: " + e.Message );
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
| **204** | The user can&#39;t acceess the private channel. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user doesn&#39;t own the channel. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelprivacyusers"></a>
# **GetChannelPrivacyUsers**
> List&lt;User&gt; GetChannelPrivacyUsers (decimal channelId, string direction = null, decimal? page = null, decimal? perPage = null)

Get all the users who can access a private channel

This method returns all the users who have access to the specified private channel. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetChannelPrivacyUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsPrivateChannelMembersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the users who can access a private channel
                List<User> result = apiInstance.GetChannelPrivacyUsers(channelId, direction, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsPrivateChannelMembersApi.GetChannelPrivacyUsers: " + e.Message );
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
| **200** | The users were returned. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user doesn&#39;t own this channel. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setchannelprivacyuser"></a>
# **SetChannelPrivacyUser**
> void SetChannelPrivacyUser (decimal channelId, decimal userId)

Permit a specific user to access a private channel

This method gives a single user access to the specified private channel. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SetChannelPrivacyUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsPrivateChannelMembersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Permit a specific user to access a private channel
                apiInstance.SetChannelPrivacyUser(channelId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsPrivateChannelMembersApi.SetChannelPrivacyUser: " + e.Message );
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
| **200** | The user can now view the private channel. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user doesn&#39;t own the channel. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setchannelprivacyusers"></a>
# **SetChannelPrivacyUsers**
> List&lt;User&gt; SetChannelPrivacyUsers (decimal channelId, InlineObject6 inlineObject6)

Permit a list of users to access a private channel

This method gives multiple users access to the specified private channel. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SetChannelPrivacyUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsPrivateChannelMembersApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var inlineObject6 = new InlineObject6(); // InlineObject6 | 

            try
            {
                // Permit a list of users to access a private channel
                List<User> result = apiInstance.SetChannelPrivacyUsers(channelId, inlineObject6);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsPrivateChannelMembersApi.SetChannelPrivacyUsers: " + e.Message );
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
 **inlineObject6** | [**InlineObject6**](InlineObject6.md)|  | 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.user+json
 - **Accept**: application/vnd.vimeo.user+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The users can access the private channel. |  -  |
| **400** | * Error code 2205: There was no request body, or the request body is malformed. * Error code 2900: No such user exists. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user doesn&#39;t own this channel. |  -  |
| **404** | Error code 2204: A requested user can&#39;t have access to the channel. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


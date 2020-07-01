# VimeoOpenApi.Api.VideosPrivateVideosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoPrivacyUser**](VideosPrivateVideosApi.md#addvideoprivacyuser) | **PUT** /videos/{video_id}/privacy/users/{user_id} | Permit a specific user to access a private video
[**AddVideoPrivacyUsers**](VideosPrivateVideosApi.md#addvideoprivacyusers) | **PUT** /videos/{video_id}/privacy/users | Permit a list of users to access a private video
[**AddVideoPrivacyUsersAlt1**](VideosPrivateVideosApi.md#addvideoprivacyusersalt1) | **PUT** /channels/{channel_id}/videos/{video_id}/privacy/users | Permit a list of users to access a private video
[**DeleteVideoPrivacyUser**](VideosPrivateVideosApi.md#deletevideoprivacyuser) | **DELETE** /videos/{video_id}/privacy/users/{user_id} | Restrict a user from viewing a private video
[**GetVideoPrivacyUsers**](VideosPrivateVideosApi.md#getvideoprivacyusers) | **GET** /videos/{video_id}/privacy/users | Get all the users who can view a private video
[**GetVideoPrivacyUsersAlt1**](VideosPrivateVideosApi.md#getvideoprivacyusersalt1) | **GET** /channels/{channel_id}/videos/{video_id}/privacy/users | Get all the users who can view a private video


<a name="addvideoprivacyuser"></a>
# **AddVideoPrivacyUser**
> User AddVideoPrivacyUser (decimal userId, decimal videoId)

Permit a specific user to access a private video

This method gives a single user permission to access the specified private video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoPrivacyUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosPrivateVideosApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Permit a specific user to access a private video
                User result = apiInstance.AddVideoPrivacyUser(userId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosPrivateVideosApi.AddVideoPrivacyUser: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 

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
| **200** | The user has been granted access to the private video. |  -  |
| **204** | The user can already access this private video. |  -  |
| **403** | The video doesn&#39;t have a user-defined access list. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideoprivacyusers"></a>
# **AddVideoPrivacyUsers**
> List&lt;User&gt; AddVideoPrivacyUsers (decimal videoId)

Permit a list of users to access a private video

This method gives multiple users permission to access the specified private video. The authenticated user must be the owner of the video. The body of the request should follow our [batch request format](https://developer.vimeo.com/api/common-formats#working-with-batch-requests): each object must contain a single **uri** field whose value is the URI of the user who can access the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoPrivacyUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosPrivateVideosApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Permit a list of users to access a private video
                List<User> result = apiInstance.AddVideoPrivacyUsers(videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosPrivateVideosApi.AddVideoPrivacyUsers: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 

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
| **200** | The users have been granted access to the private video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideoprivacyusersalt1"></a>
# **AddVideoPrivacyUsersAlt1**
> List&lt;User&gt; AddVideoPrivacyUsersAlt1 (decimal channelId, decimal videoId)

Permit a list of users to access a private video

This method gives multiple users permission to access the specified private video. The authenticated user must be the owner of the video. The body of the request should follow our [batch request format](https://developer.vimeo.com/api/common-formats#working-with-batch-requests): each object must contain a single **uri** field whose value is the URI of the user who can access the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoPrivacyUsersAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosPrivateVideosApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Permit a list of users to access a private video
                List<User> result = apiInstance.AddVideoPrivacyUsersAlt1(channelId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosPrivateVideosApi.AddVideoPrivacyUsersAlt1: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 

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
| **200** | The users have been granted access to the private video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideoprivacyuser"></a>
# **DeleteVideoPrivacyUser**
> void DeleteVideoPrivacyUser (decimal userId, decimal videoId)

Restrict a user from viewing a private video

This method prevents a user from being able to view the specified private video. The authenticated user must be the owner of the video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoPrivacyUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosPrivateVideosApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Restrict a user from viewing a private video
                apiInstance.DeleteVideoPrivacyUser(userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosPrivateVideosApi.DeleteVideoPrivacyUser: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 

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
| **204** | The user has been restricted from accessing the private video. |  -  |
| **403** | The video isn&#39;t set to a user-defined access list. |  -  |
| **404** | No such user exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoprivacyusers"></a>
# **GetVideoPrivacyUsers**
> List&lt;User&gt; GetVideoPrivacyUsers (decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the users who can view a private video

This method returns every user who has access to the specified private video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoPrivacyUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosPrivateVideosApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the users who can view a private video
                List<User> result = apiInstance.GetVideoPrivacyUsers(videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosPrivateVideosApi.GetVideoPrivacyUsers: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 
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
| **400** | No users can view this private video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoprivacyusersalt1"></a>
# **GetVideoPrivacyUsersAlt1**
> List&lt;User&gt; GetVideoPrivacyUsersAlt1 (decimal channelId, decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the users who can view a private video

This method returns every user who has access to the specified private video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoPrivacyUsersAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosPrivateVideosApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the users who can view a private video
                List<User> result = apiInstance.GetVideoPrivacyUsersAlt1(channelId, videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosPrivateVideosApi.GetVideoPrivacyUsersAlt1: " + e.Message );
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
 **videoId** | **decimal**| The ID of the video. | 
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
| **400** | No users can view this private video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


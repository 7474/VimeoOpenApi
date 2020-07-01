# VimeoOpenApi.Api.UsersFollowersApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckIfUserIsFollowing**](UsersFollowersApi.md#checkifuserisfollowing) | **GET** /users/{user_id}/following/{follow_user_id} | Check if the user is following another user
[**CheckIfUserIsFollowingAlt1**](UsersFollowersApi.md#checkifuserisfollowingalt1) | **GET** /me/following/{follow_user_id} | Check if the user is following another user
[**FollowUser**](UsersFollowersApi.md#followuser) | **PUT** /users/{user_id}/following/{follow_user_id} | Follow a specific user
[**FollowUserAlt1**](UsersFollowersApi.md#followuseralt1) | **PUT** /me/following/{follow_user_id} | Follow a specific user
[**FollowUsers**](UsersFollowersApi.md#followusers) | **POST** /users/{user_id}/following | Follow a list of users
[**FollowUsersAlt1**](UsersFollowersApi.md#followusersalt1) | **POST** /me/following | Follow a list of users
[**GetFollowers**](UsersFollowersApi.md#getfollowers) | **GET** /users/{user_id}/followers | Get all the followers of the user
[**GetFollowersAlt1**](UsersFollowersApi.md#getfollowersalt1) | **GET** /me/followers | Get all the followers of the user
[**GetUserFollowing**](UsersFollowersApi.md#getuserfollowing) | **GET** /users/{user_id}/following | Get all the users that the user is following
[**GetUserFollowingAlt1**](UsersFollowersApi.md#getuserfollowingalt1) | **GET** /me/following | Get all the users that the user is following
[**UnfollowUser**](UsersFollowersApi.md#unfollowuser) | **DELETE** /users/{user_id}/following/{follow_user_id} | Unfollow a user
[**UnfollowUserAlt1**](UsersFollowersApi.md#unfollowuseralt1) | **DELETE** /me/following/{follow_user_id} | Unfollow a user


<a name="checkifuserisfollowing"></a>
# **CheckIfUserIsFollowing**
> void CheckIfUserIsFollowing (decimal followUserId, decimal userId)

Check if the user is following another user

This method determines whether the authenticated user is a follower of the specified user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserIsFollowingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var followUserId = 3766357;  // decimal | The ID of the user to follow.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Check if the user is following another user
                apiInstance.CheckIfUserIsFollowing(followUserId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.CheckIfUserIsFollowing: " + e.Message );
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
 **followUserId** | **decimal**| The ID of the user to follow. | 
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
| **204** | The authenticated user follows the specified user. |  -  |
| **404** | The authenticated user doesn&#39;t follow the specified user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkifuserisfollowingalt1"></a>
# **CheckIfUserIsFollowingAlt1**
> void CheckIfUserIsFollowingAlt1 (decimal followUserId)

Check if the user is following another user

This method determines whether the authenticated user is a follower of the specified user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserIsFollowingAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var followUserId = 3766357;  // decimal | The ID of the user to follow.

            try
            {
                // Check if the user is following another user
                apiInstance.CheckIfUserIsFollowingAlt1(followUserId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.CheckIfUserIsFollowingAlt1: " + e.Message );
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
 **followUserId** | **decimal**| The ID of the user to follow. | 

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
| **204** | The authenticated user follows the specified user. |  -  |
| **404** | The authenticated user doesn&#39;t follow the specified user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="followuser"></a>
# **FollowUser**
> void FollowUser (decimal followUserId, decimal userId)

Follow a specific user

This method causes the authenticated user to become the follower of the specified user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class FollowUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var followUserId = 3766357;  // decimal | The ID of the user to follow.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Follow a specific user
                apiInstance.FollowUser(followUserId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.FollowUser: " + e.Message );
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
 **followUserId** | **decimal**| The ID of the user to follow. | 
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
| **204** | The user was followed. |  -  |
| **403** | The authenticated user can&#39;t follow other users. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="followuseralt1"></a>
# **FollowUserAlt1**
> void FollowUserAlt1 (decimal followUserId)

Follow a specific user

This method causes the authenticated user to become the follower of the specified user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class FollowUserAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var followUserId = 3766357;  // decimal | The ID of the user to follow.

            try
            {
                // Follow a specific user
                apiInstance.FollowUserAlt1(followUserId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.FollowUserAlt1: " + e.Message );
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
 **followUserId** | **decimal**| The ID of the user to follow. | 

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
| **204** | The user was followed. |  -  |
| **403** | The authenticated user can&#39;t follow other users. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="followusers"></a>
# **FollowUsers**
> void FollowUsers (decimal userId, InlineObject44 inlineObject44)

Follow a list of users

This method causes the authenticated user to become the follower of multiple users. In the body of the request, specify the list of users to follow as an array of URIs, where `user01_id`, `user02_id`, `user03_id`, and so on, are the user IDs of the users in question:  ``` {  [      {\"uri\" : \"/users/{user01_id}\"},      {\"uri\" : \"/users/{user02_id}\"},      {\"uri\" : \"/users/{user03_id}\"}  ] } ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class FollowUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject44 = new InlineObject44(); // InlineObject44 | 

            try
            {
                // Follow a list of users
                apiInstance.FollowUsers(userId, inlineObject44);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.FollowUsers: " + e.Message );
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
 **inlineObject44** | [**InlineObject44**](InlineObject44.md)|  | 

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
| **204** | The users were followed. |  -  |
| **400** | * Error code 2205: The request body is empty, the users array is invalid, or the list of users doesn&#39;t contain URIs. * Error code 2900: A user in the list doesn&#39;t exist. * Error code 2901: The list contains more than 100 users. |  -  |
| **401** | Error code 8000: The user access token is invalid. |  -  |
| **403** | Error code 3417: The authenticated user can&#39;t follow other users. |  -  |
| **429** | Error code 9006: The authenticated user is rate-limited from following other users. |  -  |
| **500** | Error code 4005: An unexpected error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="followusersalt1"></a>
# **FollowUsersAlt1**
> void FollowUsersAlt1 (InlineObject20 inlineObject20)

Follow a list of users

This method causes the authenticated user to become the follower of multiple users. In the body of the request, specify the list of users to follow as an array of URIs, where `user01_id`, `user02_id`, `user03_id`, and so on, are the user IDs of the users in question:  ``` {  [      {\"uri\" : \"/users/{user01_id}\"},      {\"uri\" : \"/users/{user02_id}\"},      {\"uri\" : \"/users/{user03_id}\"}  ] } ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class FollowUsersAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var inlineObject20 = new InlineObject20(); // InlineObject20 | 

            try
            {
                // Follow a list of users
                apiInstance.FollowUsersAlt1(inlineObject20);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.FollowUsersAlt1: " + e.Message );
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
 **inlineObject20** | [**InlineObject20**](InlineObject20.md)|  | 

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
| **204** | The users were followed. |  -  |
| **400** | * Error code 2205: The request body is empty, the users array is invalid, or the list of users doesn&#39;t contain URIs. * Error code 2900: A user in the list doesn&#39;t exist. * Error code 2901: The list contains more than 100 users. |  -  |
| **401** | Error code 8000: The user access token is invalid. |  -  |
| **403** | Error code 3417: The authenticated user can&#39;t follow other users. |  -  |
| **429** | Error code 9006: The authenticated user is rate-limited from following other users. |  -  |
| **500** | Error code 4005: An unexpected error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfollowers"></a>
# **GetFollowers**
> List&lt;User&gt; GetFollowers (decimal userId, string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the followers of the user

This method returns every follower of the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date followed.  (optional) 

            try
            {
                // Get all the followers of the user
                List<User> result = apiInstance.GetFollowers(userId, direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.GetFollowers: " + e.Message );
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
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date followed.  | [optional] 

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
| **200** | The user&#39;s followers were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfollowersalt1"></a>
# **GetFollowersAlt1**
> List&lt;User&gt; GetFollowersAlt1 (string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the followers of the user

This method returns every follower of the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetFollowersAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date followed.  (optional) 

            try
            {
                // Get all the followers of the user
                List<User> result = apiInstance.GetFollowersAlt1(direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.GetFollowersAlt1: " + e.Message );
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
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date followed.  | [optional] 

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
| **200** | The user&#39;s followers were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserfollowing"></a>
# **GetUserFollowing**
> List&lt;User&gt; GetUserFollowing (decimal userId, string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the users that the user is following

This method returns every user that the authenticated user is following.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetUserFollowingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `online` - Return users who are currently online.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date followed.  (optional) 

            try
            {
                // Get all the users that the user is following
                List<User> result = apiInstance.GetUserFollowing(userId, direction, filter, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.GetUserFollowing: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;online&#x60; - Return users who are currently online.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date followed.  | [optional] 

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
| **200** | The followed users were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserfollowingalt1"></a>
# **GetUserFollowingAlt1**
> List&lt;User&gt; GetUserFollowingAlt1 (string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the users that the user is following

This method returns every user that the authenticated user is following.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetUserFollowingAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `online` - Return users who are currently online.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date followed.  (optional) 

            try
            {
                // Get all the users that the user is following
                List<User> result = apiInstance.GetUserFollowingAlt1(direction, filter, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.GetUserFollowingAlt1: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;online&#x60; - Return users who are currently online.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date followed.  | [optional] 

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
| **200** | The followed users were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unfollowuser"></a>
# **UnfollowUser**
> void UnfollowUser (decimal followUserId, decimal userId)

Unfollow a user

This method causes the authenticated user to stop following another user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UnfollowUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var followUserId = 3766357;  // decimal | The ID of the user to unfollow.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Unfollow a user
                apiInstance.UnfollowUser(followUserId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.UnfollowUser: " + e.Message );
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
 **followUserId** | **decimal**| The ID of the user to unfollow. | 
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
| **204** | The user was unfollowed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unfollowuseralt1"></a>
# **UnfollowUserAlt1**
> void UnfollowUserAlt1 (decimal followUserId)

Unfollow a user

This method causes the authenticated user to stop following another user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UnfollowUserAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersFollowersApi(config);
            var followUserId = 3766357;  // decimal | The ID of the user to unfollow.

            try
            {
                // Unfollow a user
                apiInstance.UnfollowUserAlt1(followUserId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersFollowersApi.UnfollowUserAlt1: " + e.Message );
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
 **followUserId** | **decimal**| The ID of the user to unfollow. | 

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
| **204** | The user was unfollowed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


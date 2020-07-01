# VimeoOpenApi.Api.GroupsUsersApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckIfUserJoinedGroup**](GroupsUsersApi.md#checkifuserjoinedgroup) | **GET** /users/{user_id}/groups/{group_id} | Check if a user has joined a group
[**CheckIfUserJoinedGroupAlt1**](GroupsUsersApi.md#checkifuserjoinedgroupalt1) | **GET** /me/groups/{group_id} | Check if a user has joined a group
[**GetGroupMembers**](GroupsUsersApi.md#getgroupmembers) | **GET** /groups/{group_id}/users | Get all the members of a group
[**GetUserGroups**](GroupsUsersApi.md#getusergroups) | **GET** /users/{user_id}/groups | Get all the groups that the user has joined
[**GetUserGroupsAlt1**](GroupsUsersApi.md#getusergroupsalt1) | **GET** /me/groups | Get all the groups that the user has joined


<a name="checkifuserjoinedgroup"></a>
# **CheckIfUserJoinedGroup**
> void CheckIfUserJoinedGroup (decimal groupId, decimal userId)

Check if a user has joined a group

This method determines whether the authenticated user belongs to the specified group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserJoinedGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsUsersApi(config);
            var groupId = 1108;  // decimal | The ID of the group.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Check if a user has joined a group
                apiInstance.CheckIfUserJoinedGroup(groupId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsUsersApi.CheckIfUserJoinedGroup: " + e.Message );
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
 **groupId** | **decimal**| The ID of the group. | 
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
| **204** | The user belongs to the group. |  -  |
| **404** | * No such group exists. * The authenticated user isn&#39;t a member of the group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkifuserjoinedgroupalt1"></a>
# **CheckIfUserJoinedGroupAlt1**
> void CheckIfUserJoinedGroupAlt1 (decimal groupId)

Check if a user has joined a group

This method determines whether the authenticated user belongs to the specified group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfUserJoinedGroupAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsUsersApi(config);
            var groupId = 1108;  // decimal | The ID of the group.

            try
            {
                // Check if a user has joined a group
                apiInstance.CheckIfUserJoinedGroupAlt1(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsUsersApi.CheckIfUserJoinedGroupAlt1: " + e.Message );
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
 **groupId** | **decimal**| The ID of the group. | 

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
| **204** | The user belongs to the group. |  -  |
| **404** | * No such group exists. * The authenticated user isn&#39;t a member of the group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroupmembers"></a>
# **GetGroupMembers**
> List&lt;User&gt; GetGroupMembers (decimal groupId, string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the members of a group

This method returns every user who belongs to the specified group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetGroupMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsUsersApi(config);
            var groupId = 1108;  // decimal | The ID of the group.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `moderators` - Return group moderators.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by creation date.  (optional) 

            try
            {
                // Get all the members of a group
                List<User> result = apiInstance.GetGroupMembers(groupId, direction, filter, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsUsersApi.GetGroupMembers: " + e.Message );
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
 **groupId** | **decimal**| The ID of the group. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;moderators&#x60; - Return group moderators.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by creation date.  | [optional] 

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
| **200** | The members were returned. |  -  |
| **404** | No such group exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroups"></a>
# **GetUserGroups**
> List&lt;Group&gt; GetUserGroups (decimal userId, string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the groups that the user has joined

This method returns every group to which the authenticated user belongs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetUserGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsUsersApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `moderated` - Return moderated groups.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by creation date.  * `members` - Sort the results by number of members.  * `videos` - Sort the results by number of videos.  (optional) 

            try
            {
                // Get all the groups that the user has joined
                List<Group> result = apiInstance.GetUserGroups(userId, direction, filter, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsUsersApi.GetUserGroups: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;moderated&#x60; - Return moderated groups.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by creation date.  * &#x60;members&#x60; - Sort the results by number of members.  * &#x60;videos&#x60; - Sort the results by number of videos.  | [optional] 

### Return type

[**List&lt;Group&gt;**](Group.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.group+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The groups were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusergroupsalt1"></a>
# **GetUserGroupsAlt1**
> List&lt;Group&gt; GetUserGroupsAlt1 (string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the groups that the user has joined

This method returns every group to which the authenticated user belongs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetUserGroupsAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsUsersApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `moderated` - Return moderated groups.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by creation date.  * `members` - Sort the results by number of members.  * `videos` - Sort the results by number of videos.  (optional) 

            try
            {
                // Get all the groups that the user has joined
                List<Group> result = apiInstance.GetUserGroupsAlt1(direction, filter, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsUsersApi.GetUserGroupsAlt1: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;moderated&#x60; - Return moderated groups.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by creation date.  * &#x60;members&#x60; - Sort the results by number of members.  * &#x60;videos&#x60; - Sort the results by number of videos.  | [optional] 

### Return type

[**List&lt;Group&gt;**](Group.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.group+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The groups were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


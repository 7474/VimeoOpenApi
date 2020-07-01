# VimeoOpenApi.Api.GroupsSubscriptionsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JoinGroup**](GroupsSubscriptionsApi.md#joingroup) | **PUT** /users/{user_id}/groups/{group_id} | Add the user to a group
[**JoinGroupAlt1**](GroupsSubscriptionsApi.md#joingroupalt1) | **PUT** /me/groups/{group_id} | Add the user to a group
[**LeaveGroup**](GroupsSubscriptionsApi.md#leavegroup) | **DELETE** /users/{user_id}/groups/{group_id} | Remove the user from a group
[**LeaveGroupAlt1**](GroupsSubscriptionsApi.md#leavegroupalt1) | **DELETE** /me/groups/{group_id} | Remove the user from a group


<a name="joingroup"></a>
# **JoinGroup**
> void JoinGroup (decimal groupId, decimal userId)

Add the user to a group

This method adds the authenticated user to the specified group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class JoinGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsSubscriptionsApi(config);
            var groupId = 1108;  // decimal | The ID of the group.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Add the user to a group
                apiInstance.JoinGroup(groupId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsSubscriptionsApi.JoinGroup: " + e.Message );
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
| **204** | The user joined the group. |  -  |
| **403** | The authenticated user can&#39;t join the group. Possible reasons are that the group isn&#39;t public or that its privacy setting is &#x60;members&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="joingroupalt1"></a>
# **JoinGroupAlt1**
> void JoinGroupAlt1 (decimal groupId)

Add the user to a group

This method adds the authenticated user to the specified group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class JoinGroupAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsSubscriptionsApi(config);
            var groupId = 1108;  // decimal | The ID of the group.

            try
            {
                // Add the user to a group
                apiInstance.JoinGroupAlt1(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsSubscriptionsApi.JoinGroupAlt1: " + e.Message );
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
| **204** | The user joined the group. |  -  |
| **403** | The authenticated user can&#39;t join the group. Possible reasons are that the group isn&#39;t public or that its privacy setting is &#x60;members&#x60;. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leavegroup"></a>
# **LeaveGroup**
> void LeaveGroup (decimal groupId, decimal userId)

Remove the user from a group

This method removes the authenticated user from the specified group. The authenticated user can't be the owner of the group; assign a new owner through a PATCH request first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class LeaveGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsSubscriptionsApi(config);
            var groupId = 1108;  // decimal | The ID of the group.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Remove the user from a group
                apiInstance.LeaveGroup(groupId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsSubscriptionsApi.LeaveGroup: " + e.Message );
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
| **204** | The user was removed from the group. |  -  |
| **403** | The authenticated user can&#39;t leave the group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leavegroupalt1"></a>
# **LeaveGroupAlt1**
> void LeaveGroupAlt1 (decimal groupId)

Remove the user from a group

This method removes the authenticated user from the specified group. The authenticated user can't be the owner of the group; assign a new owner through a PATCH request first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class LeaveGroupAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsSubscriptionsApi(config);
            var groupId = 1108;  // decimal | The ID of the group.

            try
            {
                // Remove the user from a group
                apiInstance.LeaveGroupAlt1(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsSubscriptionsApi.LeaveGroupAlt1: " + e.Message );
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
| **204** | The user was removed from the group. |  -  |
| **403** | The authenticated user can&#39;t leave the group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


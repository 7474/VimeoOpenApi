# VimeoOpenApi.Api.GroupsEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroup**](GroupsEssentialsApi.md#creategroup) | **POST** /groups | Create a group
[**DeleteGroup**](GroupsEssentialsApi.md#deletegroup) | **DELETE** /groups/{group_id} | Delete a group
[**GetGroup**](GroupsEssentialsApi.md#getgroup) | **GET** /groups/{group_id} | Get a specific group
[**GetGroups**](GroupsEssentialsApi.md#getgroups) | **GET** /groups | Get all groups


<a name="creategroup"></a>
# **CreateGroup**
> Group CreateGroup (InlineObject14 inlineObject14)

Create a group

This method creates a new group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsEssentialsApi(config);
            var inlineObject14 = new InlineObject14(); // InlineObject14 | 

            try
            {
                // Create a group
                Group result = apiInstance.CreateGroup(inlineObject14);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsEssentialsApi.CreateGroup: " + e.Message );
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
 **inlineObject14** | [**InlineObject14**](InlineObject14.md)|  | 

### Return type

[**Group**](Group.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.group+json
 - **Accept**: application/vnd.vimeo.group+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The group was created. |  -  |
| **400** | A parameter is invalid. |  -  |
| **403** | The authenticated user can&#39;t create groups. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (decimal groupId)

Delete a group

This method deletes the specified group. The authenticated user must be the owner of the group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsEssentialsApi(config);
            var groupId = 1108;  // decimal | The ID of the group.

            try
            {
                // Delete a group
                apiInstance.DeleteGroup(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsEssentialsApi.DeleteGroup: " + e.Message );
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
| **204** | The group was deleted. |  -  |
| **403** | The authenticated user can&#39;t delete the group. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> Group GetGroup (decimal groupId)

Get a specific group

This method returns the specified group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsEssentialsApi(config);
            var groupId = 1108;  // decimal | The ID of the group.

            try
            {
                // Get a specific group
                Group result = apiInstance.GetGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsEssentialsApi.GetGroup: " + e.Message );
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

[**Group**](Group.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.group+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The group was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroups"></a>
# **GetGroups**
> List&lt;Group&gt; GetGroups (string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all groups

This method returns every available group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsEssentialsApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `featured` - Return featured groups.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by creation date.  * `followers` - Sort the results by number of followers.  * `relevant` - Sort the results by relevance. This option is available for search queries only.  * `videos` - Sort the results by number of videos.  (optional) 

            try
            {
                // Get all groups
                List<Group> result = apiInstance.GetGroups(direction, filter, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsEssentialsApi.GetGroups: " + e.Message );
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
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;featured&#x60; - Return featured groups.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by creation date.  * &#x60;followers&#x60; - Sort the results by number of followers.  * &#x60;relevant&#x60; - Sort the results by relevance. This option is available for search queries only.  * &#x60;videos&#x60; - Sort the results by number of videos.  | [optional] 

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


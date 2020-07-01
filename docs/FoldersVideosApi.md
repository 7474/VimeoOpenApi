# VimeoOpenApi.Api.FoldersVideosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoToProject**](FoldersVideosApi.md#addvideotoproject) | **PUT** /users/{user_id}/projects/{project_id}/videos/{video_id} | Add a specific video to a folder
[**AddVideoToProjectAlt1**](FoldersVideosApi.md#addvideotoprojectalt1) | **PUT** /me/projects/{project_id}/videos/{video_id} | Add a specific video to a folder
[**AddVideosToProject**](FoldersVideosApi.md#addvideostoproject) | **PUT** /users/{user_id}/projects/{project_id}/videos | Add a list of videos to a folder
[**AddVideosToProjectAlt1**](FoldersVideosApi.md#addvideostoprojectalt1) | **PUT** /me/projects/{project_id}/videos | Add a list of videos to a folder
[**GetProjectVideos**](FoldersVideosApi.md#getprojectvideos) | **GET** /users/{user_id}/projects/{project_id}/videos | Get all the videos in a folder
[**GetProjectVideosAlt1**](FoldersVideosApi.md#getprojectvideosalt1) | **GET** /me/projects/{project_id}/videos | Get all the videos in a folder
[**RemoveVideoFromProject**](FoldersVideosApi.md#removevideofromproject) | **DELETE** /users/{user_id}/projects/{project_id}/videos/{video_id} | Remove a specific video from a folder
[**RemoveVideoFromProjectAlt1**](FoldersVideosApi.md#removevideofromprojectalt1) | **DELETE** /me/projects/{project_id}/videos/{video_id} | Remove a specific video from a folder
[**RemoveVideosFromProject**](FoldersVideosApi.md#removevideosfromproject) | **DELETE** /users/{user_id}/projects/{project_id}/videos | Remove a list of videos from a folder
[**RemoveVideosFromProjectAlt1**](FoldersVideosApi.md#removevideosfromprojectalt1) | **DELETE** /me/projects/{project_id}/videos | Remove a list of videos from a folder


<a name="addvideotoproject"></a>
# **AddVideoToProject**
> void AddVideoToProject (decimal projectId, decimal userId, decimal videoId)

Add a specific video to a folder

This method adds a single video to the specified folder. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add a specific video to a folder
                apiInstance.AddVideoToProject(projectId, userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.AddVideoToProject: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
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
| **204** | The video was added. |  -  |
| **404** | Error code 5000: No such user, folder, or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideotoprojectalt1"></a>
# **AddVideoToProjectAlt1**
> void AddVideoToProjectAlt1 (decimal projectId, decimal videoId)

Add a specific video to a folder

This method adds a single video to the specified folder. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToProjectAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add a specific video to a folder
                apiInstance.AddVideoToProjectAlt1(projectId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.AddVideoToProjectAlt1: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
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
| **204** | The video was added. |  -  |
| **404** | Error code 5000: No such user, folder, or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideostoproject"></a>
# **AddVideosToProject**
> void AddVideosToProject (decimal projectId, decimal userId, string uris)

Add a list of videos to a folder

This method adds multiple videos to the specified folder. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideosToProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var userId = 152184;  // decimal | The ID of the user.
            var uris = /videos/258684937,/videos/273576296;  // string | A comma-separated list of video URIs to add.

            try
            {
                // Add a list of videos to a folder
                apiInstance.AddVideosToProject(projectId, userId, uris);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.AddVideosToProject: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
 **userId** | **decimal**| The ID of the user. | 
 **uris** | **string**| A comma-separated list of video URIs to add. | 

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
| **204** | The videos were added. |  -  |
| **400** | Error code 2204: The input is invalid. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such folder or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideostoprojectalt1"></a>
# **AddVideosToProjectAlt1**
> void AddVideosToProjectAlt1 (decimal projectId, string uris)

Add a list of videos to a folder

This method adds multiple videos to the specified folder. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideosToProjectAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var uris = /videos/258684937,/videos/273576296;  // string | A comma-separated list of video URIs to add.

            try
            {
                // Add a list of videos to a folder
                apiInstance.AddVideosToProjectAlt1(projectId, uris);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.AddVideosToProjectAlt1: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
 **uris** | **string**| A comma-separated list of video URIs to add. | 

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
| **204** | The videos were added. |  -  |
| **400** | Error code 2204: The input is invalid. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such folder or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectvideos"></a>
# **GetProjectVideos**
> List&lt;Video&gt; GetProjectVideos (decimal projectId, decimal userId, string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos in a folder

This method returns all the videos that belong to the specified folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetProjectVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date.  * `default` - Use the default sort order.  * `duration` - Sort the results by duration.  * `last_user_action_event_date` - Sort the results by the date of the last user action.  (optional) 

            try
            {
                // Get all the videos in a folder
                List<Video> result = apiInstance.GetProjectVideos(projectId, userId, direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.GetProjectVideos: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
 **userId** | **decimal**| The ID of the user. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;default&#x60; - Use the default sort order.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;last_user_action_event_date&#x60; - Sort the results by the date of the last user action.  | [optional] 

### Return type

[**List&lt;Video&gt;**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The videos were returned. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectvideosalt1"></a>
# **GetProjectVideosAlt1**
> List&lt;Video&gt; GetProjectVideosAlt1 (decimal projectId, string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the videos in a folder

This method returns all the videos that belong to the specified folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetProjectVideosAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date.  * `default` - Use the default sort order.  * `duration` - Sort the results by duration.  * `last_user_action_event_date` - Sort the results by the date of the last user action.  (optional) 

            try
            {
                // Get all the videos in a folder
                List<Video> result = apiInstance.GetProjectVideosAlt1(projectId, direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.GetProjectVideosAlt1: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;default&#x60; - Use the default sort order.  * &#x60;duration&#x60; - Sort the results by duration.  * &#x60;last_user_action_event_date&#x60; - Sort the results by the date of the last user action.  | [optional] 

### Return type

[**List&lt;Video&gt;**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The videos were returned. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removevideofromproject"></a>
# **RemoveVideoFromProject**
> void RemoveVideoFromProject (decimal projectId, decimal userId, decimal videoId)

Remove a specific video from a folder

This method removes a single video from the specified folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class RemoveVideoFromProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Remove a specific video from a folder
                apiInstance.RemoveVideoFromProject(projectId, userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.RemoveVideoFromProject: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
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
| **204** | The video was removed. |  -  |
| **400** | Error code 2204: The input is invalid. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such video exists in the folder. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removevideofromprojectalt1"></a>
# **RemoveVideoFromProjectAlt1**
> void RemoveVideoFromProjectAlt1 (decimal projectId, decimal videoId)

Remove a specific video from a folder

This method removes a single video from the specified folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class RemoveVideoFromProjectAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Remove a specific video from a folder
                apiInstance.RemoveVideoFromProjectAlt1(projectId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.RemoveVideoFromProjectAlt1: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
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
| **204** | The video was removed. |  -  |
| **400** | Error code 2204: The input is invalid. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such video exists in the folder. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removevideosfromproject"></a>
# **RemoveVideosFromProject**
> void RemoveVideosFromProject (decimal projectId, decimal userId, string uris, bool? shouldDeleteClips = null)

Remove a list of videos from a folder

This method removes multiple videos from the specified folder. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class RemoveVideosFromProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var userId = 152184;  // decimal | The ID of the user.
            var uris = /videos/258684937,/videos/273576296;  // string | A comma-separated list of the video URIs to remove.
            var shouldDeleteClips = false;  // bool? | Whether to delete the videos when removing them from the folder. (optional) 

            try
            {
                // Remove a list of videos from a folder
                apiInstance.RemoveVideosFromProject(projectId, userId, uris, shouldDeleteClips);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.RemoveVideosFromProject: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
 **userId** | **decimal**| The ID of the user. | 
 **uris** | **string**| A comma-separated list of the video URIs to remove. | 
 **shouldDeleteClips** | **bool?**| Whether to delete the videos when removing them from the folder. | [optional] 

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
| **204** | The videos were removed. |  -  |
| **400** | Error code 2204: The input is invalid. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removevideosfromprojectalt1"></a>
# **RemoveVideosFromProjectAlt1**
> void RemoveVideosFromProjectAlt1 (decimal projectId, string uris, bool? shouldDeleteClips = null)

Remove a list of videos from a folder

This method removes multiple videos from the specified folder. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class RemoveVideosFromProjectAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersVideosApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var uris = /videos/258684937,/videos/273576296;  // string | A comma-separated list of the video URIs to remove.
            var shouldDeleteClips = false;  // bool? | Whether to delete the videos when removing them from the folder. (optional) 

            try
            {
                // Remove a list of videos from a folder
                apiInstance.RemoveVideosFromProjectAlt1(projectId, uris, shouldDeleteClips);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersVideosApi.RemoveVideosFromProjectAlt1: " + e.Message );
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
 **projectId** | **decimal**| The ID of the folder. | 
 **uris** | **string**| A comma-separated list of the video URIs to remove. | 
 **shouldDeleteClips** | **bool?**| Whether to delete the videos when removing them from the folder. | [optional] 

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
| **204** | The videos were removed. |  -  |
| **400** | Error code 2204: The input is invalid. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


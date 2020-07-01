# VimeoOpenApi.Api.FoldersEssentialsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProject**](FoldersEssentialsApi.md#createproject) | **POST** /users/{user_id}/projects | Create a folder
[**CreateProjectAlt1**](FoldersEssentialsApi.md#createprojectalt1) | **POST** /me/projects | Create a folder
[**DeleteProject**](FoldersEssentialsApi.md#deleteproject) | **DELETE** /users/{user_id}/projects/{project_id} | Delete a folder
[**DeleteProjectAlt1**](FoldersEssentialsApi.md#deleteprojectalt1) | **DELETE** /me/projects/{project_id} | Delete a folder
[**EditProject**](FoldersEssentialsApi.md#editproject) | **PATCH** /users/{user_id}/projects/{project_id} | Edit a folder
[**EditProjectAlt1**](FoldersEssentialsApi.md#editprojectalt1) | **PATCH** /me/projects/{project_id} | Edit a folder
[**GetProject**](FoldersEssentialsApi.md#getproject) | **GET** /users/{user_id}/projects/{project_id} | Get a specific folder
[**GetProjectAlt1**](FoldersEssentialsApi.md#getprojectalt1) | **GET** /me/projects/{project_id} | Get a specific folder
[**GetProjects**](FoldersEssentialsApi.md#getprojects) | **GET** /users/{user_id}/projects | Get all the folders that belong to the user
[**GetProjectsAlt1**](FoldersEssentialsApi.md#getprojectsalt1) | **GET** /me/projects | Get all the folders that belong to the user


<a name="createproject"></a>
# **CreateProject**
> Project CreateProject (decimal userId, InlineObject48 inlineObject48)

Create a folder

This method creates a new folder for the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject48 = new InlineObject48(); // InlineObject48 | 

            try
            {
                // Create a folder
                Project result = apiInstance.CreateProject(userId, inlineObject48);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.CreateProject: " + e.Message );
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
 **inlineObject48** | [**InlineObject48**](InlineObject48.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The folder was created. |  -  |
| **400** | * Error code 2205: The input is empty. * Error code 2204: The input is invalid. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t create folders. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprojectalt1"></a>
# **CreateProjectAlt1**
> Project CreateProjectAlt1 (InlineObject24 inlineObject24)

Create a folder

This method creates a new folder for the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateProjectAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var inlineObject24 = new InlineObject24(); // InlineObject24 | 

            try
            {
                // Create a folder
                Project result = apiInstance.CreateProjectAlt1(inlineObject24);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.CreateProjectAlt1: " + e.Message );
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
 **inlineObject24** | [**InlineObject24**](InlineObject24.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The folder was created. |  -  |
| **400** | * Error code 2205: The input is empty. * Error code 2204: The input is invalid. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t create folders. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproject"></a>
# **DeleteProject**
> void DeleteProject (decimal projectId, decimal userId, bool? shouldDeleteClips = null)

Delete a folder

This method deletes the specified folder and optionally also the videos that it contains. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var userId = 152184;  // decimal | The ID of the user.
            var shouldDeleteClips = true;  // bool? | Whether to delete all the videos in the folder along with the folder itself. (optional) 

            try
            {
                // Delete a folder
                apiInstance.DeleteProject(projectId, userId, shouldDeleteClips);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.DeleteProject: " + e.Message );
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
 **shouldDeleteClips** | **bool?**| Whether to delete all the videos in the folder along with the folder itself. | [optional] 

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
| **204** | The folder was deleted. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t delete the folder. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprojectalt1"></a>
# **DeleteProjectAlt1**
> void DeleteProjectAlt1 (decimal projectId, bool? shouldDeleteClips = null)

Delete a folder

This method deletes the specified folder and optionally also the videos that it contains. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteProjectAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var shouldDeleteClips = true;  // bool? | Whether to delete all the videos in the folder along with the folder itself. (optional) 

            try
            {
                // Delete a folder
                apiInstance.DeleteProjectAlt1(projectId, shouldDeleteClips);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.DeleteProjectAlt1: " + e.Message );
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
 **shouldDeleteClips** | **bool?**| Whether to delete all the videos in the folder along with the folder itself. | [optional] 

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
| **204** | The folder was deleted. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t delete the folder. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editproject"></a>
# **EditProject**
> Project EditProject (decimal projectId, decimal userId, InlineObject49 inlineObject49)

Edit a folder

This method edits the specified folder. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject49 = new InlineObject49(); // InlineObject49 | 

            try
            {
                // Edit a folder
                Project result = apiInstance.EditProject(projectId, userId, inlineObject49);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.EditProject: " + e.Message );
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
 **inlineObject49** | [**InlineObject49**](InlineObject49.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The folder was edited. |  -  |
| **400** | * Error code 2204: The input is invalid. * Error code 2205: The input is empty. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t edit the folder. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editprojectalt1"></a>
# **EditProjectAlt1**
> Project EditProjectAlt1 (decimal projectId, InlineObject25 inlineObject25)

Edit a folder

This method edits the specified folder. The authenticated user must be the owner of the folder.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditProjectAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var inlineObject25 = new InlineObject25(); // InlineObject25 | 

            try
            {
                // Edit a folder
                Project result = apiInstance.EditProjectAlt1(projectId, inlineObject25);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.EditProjectAlt1: " + e.Message );
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
 **inlineObject25** | [**InlineObject25**](InlineObject25.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The folder was edited. |  -  |
| **400** | * Error code 2204: The input is invalid. * Error code 2205: The input is empty. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t edit the folder. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproject"></a>
# **GetProject**
> Project GetProject (decimal projectId, decimal userId)

Get a specific folder

This method returns a single folder belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get a specific folder
                Project result = apiInstance.GetProject(projectId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.GetProject: " + e.Message );
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

### Return type

[**Project**](Project.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The folder was returned. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectalt1"></a>
# **GetProjectAlt1**
> Project GetProjectAlt1 (decimal projectId)

Get a specific folder

This method returns a single folder belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetProjectAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var projectId = 12345;  // decimal | The ID of the folder.

            try
            {
                // Get a specific folder
                Project result = apiInstance.GetProjectAlt1(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.GetProjectAlt1: " + e.Message );
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

### Return type

[**Project**](Project.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The folder was returned. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |
| **404** | Error code 5000: No such folder exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojects"></a>
# **GetProjects**
> List&lt;Project&gt; GetProjects (decimal userId, string direction = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the folders that belong to the user

This method returns all the folders belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetProjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the folders that belong to the user
                List<Project> result = apiInstance.GetProjects(userId, direction, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.GetProjects: " + e.Message );
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
 **sort** | **string**| The way to sort the results. | [optional] 

### Return type

[**List&lt;Project&gt;**](Project.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The folders were returned. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprojectsalt1"></a>
# **GetProjectsAlt1**
> List&lt;Project&gt; GetProjectsAlt1 (string direction = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the folders that belong to the user

This method returns all the folders belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetProjectsAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FoldersEssentialsApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the folders that belong to the user
                List<Project> result = apiInstance.GetProjectsAlt1(direction, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersEssentialsApi.GetProjectsAlt1: " + e.Message );
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
 **sort** | **string**| The way to sort the results. | [optional] 

### Return type

[**List&lt;Project&gt;**](Project.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The folders were returned. |  -  |
| **401** | Error code 8000: The user credentials are invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# VimeoOpenApi.Api.UsersWatchHistoryApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteFromWatchHistory**](UsersWatchHistoryApi.md#deletefromwatchhistory) | **DELETE** /me/watched/videos/{video_id} | Delete a specific video from the user&#39;s watch history
[**DeleteWatchHistory**](UsersWatchHistoryApi.md#deletewatchhistory) | **DELETE** /me/watched/videos | Delete the user&#39;s watch history
[**GetWatchHistory**](UsersWatchHistoryApi.md#getwatchhistory) | **GET** /me/watched/videos | Get all the videos that a user has watched


<a name="deletefromwatchhistory"></a>
# **DeleteFromWatchHistory**
> void DeleteFromWatchHistory (decimal videoId)

Delete a specific video from the user's watch history

This method deletes the specified video from the authenticated user's watch history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteFromWatchHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersWatchHistoryApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Delete a specific video from the user's watch history
                apiInstance.DeleteFromWatchHistory(videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersWatchHistoryApi.DeleteFromWatchHistory: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The video was deleted from the authenticated user&#39;s watch history. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewatchhistory"></a>
# **DeleteWatchHistory**
> void DeleteWatchHistory ()

Delete the user's watch history

This method deletes the entire watch history of the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteWatchHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersWatchHistoryApi(config);

            try
            {
                // Delete the user's watch history
                apiInstance.DeleteWatchHistory();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersWatchHistoryApi.DeleteWatchHistory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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
| **204** | The authenticated user&#39;s watch history was deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwatchhistory"></a>
# **GetWatchHistory**
> List&lt;Video&gt; GetWatchHistory (decimal? page = null, decimal? perPage = null)

Get all the videos that a user has watched

This method returns every video on the authenticated user's watch history.  **NOTE:** This endpoint is deprecated. Any request to it returns empty data with HTTP status code 200.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetWatchHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersWatchHistoryApi(config);
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the videos that a user has watched
                List<Video> result = apiInstance.GetWatchHistory(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersWatchHistoryApi.GetWatchHistory: " + e.Message );
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
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

### Return type

[**List&lt;Video&gt;**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The videos were returned. |  -  |
| **403** | The authenticated user can&#39;t view another user&#39;s watch history. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


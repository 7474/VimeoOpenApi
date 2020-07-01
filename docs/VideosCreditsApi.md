# VimeoOpenApi.Api.VideosCreditsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoCredit**](VideosCreditsApi.md#addvideocredit) | **POST** /videos/{video_id}/credits | Credit a user in a video
[**AddVideoCreditAlt1**](VideosCreditsApi.md#addvideocreditalt1) | **POST** /channels/{channel_id}/videos/{video_id}/credits | Credit a user in a video
[**DeleteVideoCredit**](VideosCreditsApi.md#deletevideocredit) | **DELETE** /videos/{video_id}/credits/{credit_id} | Delete the credit for a user in a video
[**EditVideoCredit**](VideosCreditsApi.md#editvideocredit) | **PATCH** /videos/{video_id}/credits/{credit_id} | Edit the credit for a user in a video
[**GetVideoCredit**](VideosCreditsApi.md#getvideocredit) | **GET** /videos/{video_id}/credits/{credit_id} | Get a specific credited user in a video
[**GetVideoCredits**](VideosCreditsApi.md#getvideocredits) | **GET** /videos/{video_id}/credits | Get all the credited users in a video
[**GetVideoCreditsAlt1**](VideosCreditsApi.md#getvideocreditsalt1) | **GET** /channels/{channel_id}/videos/{video_id}/credits | Get all the credited users in a video


<a name="addvideocredit"></a>
# **AddVideoCredit**
> Credit AddVideoCredit (decimal videoId, InlineObject57 inlineObject57)

Credit a user in a video

This method adds a user credit to the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoCreditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosCreditsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject57 = new InlineObject57(); // InlineObject57 | 

            try
            {
                // Credit a user in a video
                Credit result = apiInstance.AddVideoCredit(videoId, inlineObject57);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosCreditsApi.AddVideoCredit: " + e.Message );
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
 **inlineObject57** | [**InlineObject57**](InlineObject57.md)|  | 

### Return type

[**Credit**](Credit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.credit+json
 - **Accept**: application/vnd.vimeo.credit+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The credit was added. |  -  |
| **400** | * A parameter is invalid. * The authenticated user has an unverified email address. * There is a user block between the video owner and the person receiving credit. |  -  |
| **403** | The authenticated user doesn&#39;t own the video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideocreditalt1"></a>
# **AddVideoCreditAlt1**
> Credit AddVideoCreditAlt1 (decimal channelId, decimal videoId, InlineObject11 inlineObject11)

Credit a user in a video

This method adds a user credit to the specified video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoCreditAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosCreditsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject11 = new InlineObject11(); // InlineObject11 | 

            try
            {
                // Credit a user in a video
                Credit result = apiInstance.AddVideoCreditAlt1(channelId, videoId, inlineObject11);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosCreditsApi.AddVideoCreditAlt1: " + e.Message );
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
 **inlineObject11** | [**InlineObject11**](InlineObject11.md)|  | 

### Return type

[**Credit**](Credit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.credit+json
 - **Accept**: application/vnd.vimeo.credit+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The credit was added. |  -  |
| **400** | * A parameter is invalid. * The authenticated user has an unverified email address. * There is a user block between the video owner and the person receiving credit. |  -  |
| **403** | The authenticated user doesn&#39;t own the video. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideocredit"></a>
# **DeleteVideoCredit**
> void DeleteVideoCredit (decimal creditId, decimal videoId)

Delete the credit for a user in a video

This method deletes the specified user credit from a video. The authenticated user must be the creator of the credit or the credited user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoCreditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosCreditsApi(config);
            var creditId = 12345;  // decimal | The ID of the credit.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Delete the credit for a user in a video
                apiInstance.DeleteVideoCredit(creditId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosCreditsApi.DeleteVideoCredit: " + e.Message );
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
 **creditId** | **decimal**| The ID of the credit. | 
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
| **204** | The credit was deleted. |  -  |
| **400** | The authenticated user isn&#39;t the creator of the credit or the credited user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editvideocredit"></a>
# **EditVideoCredit**
> Credit EditVideoCredit (decimal creditId, decimal videoId, InlineObject58 inlineObject58 = null)

Edit the credit for a user in a video

This method edits the specified user credit in a video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class EditVideoCreditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosCreditsApi(config);
            var creditId = 12345;  // decimal | The ID of the credit.
            var videoId = 258684937;  // decimal | The ID of the video.
            var inlineObject58 = new InlineObject58(); // InlineObject58 |  (optional) 

            try
            {
                // Edit the credit for a user in a video
                Credit result = apiInstance.EditVideoCredit(creditId, videoId, inlineObject58);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosCreditsApi.EditVideoCredit: " + e.Message );
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
 **creditId** | **decimal**| The ID of the credit. | 
 **videoId** | **decimal**| The ID of the video. | 
 **inlineObject58** | [**InlineObject58**](InlineObject58.md)|  | [optional] 

### Return type

[**Credit**](Credit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.credit+json
 - **Accept**: application/vnd.vimeo.credit+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The credit was edited. |  -  |
| **400** | A parameter is invalid. |  -  |
| **404** | No such video or credit exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideocredit"></a>
# **GetVideoCredit**
> Credit GetVideoCredit (decimal creditId, decimal videoId)

Get a specific credited user in a video

This method returns a single credited user in a video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoCreditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosCreditsApi(config);
            var creditId = 12345;  // decimal | The ID of the credit.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a specific credited user in a video
                Credit result = apiInstance.GetVideoCredit(creditId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosCreditsApi.GetVideoCredit: " + e.Message );
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
 **creditId** | **decimal**| The ID of the credit. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**Credit**](Credit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.credit+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The credit was returned. |  -  |
| **404** | No such video or credit exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideocredits"></a>
# **GetVideoCredits**
> List&lt;Credit&gt; GetVideoCredits (decimal videoId, string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the credited users in a video

This method returns every credited user in a video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoCreditsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosCreditsApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date.  (optional) 

            try
            {
                // Get all the credited users in a video
                List<Credit> result = apiInstance.GetVideoCredits(videoId, direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosCreditsApi.GetVideoCredits: " + e.Message );
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
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date.  | [optional] 

### Return type

[**List&lt;Credit&gt;**](Credit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.credit+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The credited users were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideocreditsalt1"></a>
# **GetVideoCreditsAlt1**
> List&lt;Credit&gt; GetVideoCreditsAlt1 (decimal channelId, decimal videoId, string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the credited users in a video

This method returns every credited user in a video.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoCreditsAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosCreditsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var videoId = 258684937;  // decimal | The ID of the video.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date.  (optional) 

            try
            {
                // Get all the credited users in a video
                List<Credit> result = apiInstance.GetVideoCreditsAlt1(channelId, videoId, direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosCreditsApi.GetVideoCreditsAlt1: " + e.Message );
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
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date.  | [optional] 

### Return type

[**List&lt;Credit&gt;**](Credit.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.credit+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The credited users were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


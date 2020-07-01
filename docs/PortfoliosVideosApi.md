# VimeoOpenApi.Api.PortfoliosVideosApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoToPortfolio**](PortfoliosVideosApi.md#addvideotoportfolio) | **PUT** /users/{user_id}/portfolios/{portfolio_id}/videos/{video_id} | Add a video to a portfolio
[**AddVideoToPortfolioAlt1**](PortfoliosVideosApi.md#addvideotoportfolioalt1) | **PUT** /me/portfolios/{portfolio_id}/videos/{video_id} | Add a video to a portfolio
[**DeleteVideoFromPortfolio**](PortfoliosVideosApi.md#deletevideofromportfolio) | **DELETE** /users/{user_id}/portfolios/{portfolio_id}/videos/{video_id} | Remove a video from a portfolio
[**DeleteVideoFromPortfolioAlt1**](PortfoliosVideosApi.md#deletevideofromportfolioalt1) | **DELETE** /me/portfolios/{portfolio_id}/videos/{video_id} | Remove a video from a portfolio
[**GetPortfolioVideo**](PortfoliosVideosApi.md#getportfoliovideo) | **GET** /users/{user_id}/portfolios/{portfolio_id}/videos/{video_id} | Get a specific video in a portfolio
[**GetPortfolioVideoAlt1**](PortfoliosVideosApi.md#getportfoliovideoalt1) | **GET** /me/portfolios/{portfolio_id}/videos/{video_id} | Get a specific video in a portfolio
[**GetPortfolioVideos**](PortfoliosVideosApi.md#getportfoliovideos) | **GET** /users/{user_id}/portfolios/{portfolio_id}/videos | Get all the videos in a portfolio
[**GetPortfolioVideosAlt1**](PortfoliosVideosApi.md#getportfoliovideosalt1) | **GET** /me/portfolios/{portfolio_id}/videos | Get all the videos in a portfolio


<a name="addvideotoportfolio"></a>
# **AddVideoToPortfolio**
> void AddVideoToPortfolio (decimal portfolioId, decimal userId, decimal videoId)

Add a video to a portfolio

This method adds a video to the specified portfolio belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToPortfolioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosVideosApi(config);
            var portfolioId = 12345;  // decimal | The ID of the portfolio.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add a video to a portfolio
                apiInstance.AddVideoToPortfolio(portfolioId, userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosVideosApi.AddVideoToPortfolio: " + e.Message );
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
 **portfolioId** | **decimal**| The ID of the portfolio. | 
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
| **404** | No such portfolio or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideotoportfolioalt1"></a>
# **AddVideoToPortfolioAlt1**
> void AddVideoToPortfolioAlt1 (decimal portfolioId, decimal videoId)

Add a video to a portfolio

This method adds a video to the specified portfolio belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoToPortfolioAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosVideosApi(config);
            var portfolioId = 12345;  // decimal | The ID of the portfolio.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add a video to a portfolio
                apiInstance.AddVideoToPortfolioAlt1(portfolioId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosVideosApi.AddVideoToPortfolioAlt1: " + e.Message );
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
 **portfolioId** | **decimal**| The ID of the portfolio. | 
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
| **404** | No such portfolio or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideofromportfolio"></a>
# **DeleteVideoFromPortfolio**
> void DeleteVideoFromPortfolio (decimal portfolioId, decimal userId, decimal videoId)

Remove a video from a portfolio

This method removes a video from the specified portfolio belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoFromPortfolioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosVideosApi(config);
            var portfolioId = 12345;  // decimal | The ID of the portfolio.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Remove a video from a portfolio
                apiInstance.DeleteVideoFromPortfolio(portfolioId, userId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosVideosApi.DeleteVideoFromPortfolio: " + e.Message );
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
 **portfolioId** | **decimal**| The ID of the portfolio. | 
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
| **404** | No such portfolio or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideofromportfolioalt1"></a>
# **DeleteVideoFromPortfolioAlt1**
> void DeleteVideoFromPortfolioAlt1 (decimal portfolioId, decimal videoId)

Remove a video from a portfolio

This method removes a video from the specified portfolio belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoFromPortfolioAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosVideosApi(config);
            var portfolioId = 12345;  // decimal | The ID of the portfolio.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Remove a video from a portfolio
                apiInstance.DeleteVideoFromPortfolioAlt1(portfolioId, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosVideosApi.DeleteVideoFromPortfolioAlt1: " + e.Message );
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
 **portfolioId** | **decimal**| The ID of the portfolio. | 
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
| **404** | No such portfolio or video exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliovideo"></a>
# **GetPortfolioVideo**
> Video GetPortfolioVideo (decimal portfolioId, decimal userId, decimal videoId)

Get a specific video in a portfolio

This method returns a single video from the specified portfolio belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetPortfolioVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosVideosApi(config);
            var portfolioId = 12345;  // decimal | The ID of the portfolio.
            var userId = 152184;  // decimal | The ID of the user.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a specific video in a portfolio
                Video result = apiInstance.GetPortfolioVideo(portfolioId, userId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosVideosApi.GetPortfolioVideo: " + e.Message );
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
 **portfolioId** | **decimal**| The ID of the portfolio. | 
 **userId** | **decimal**| The ID of the user. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**Video**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The video was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliovideoalt1"></a>
# **GetPortfolioVideoAlt1**
> Video GetPortfolioVideoAlt1 (decimal portfolioId, decimal videoId)

Get a specific video in a portfolio

This method returns a single video from the specified portfolio belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetPortfolioVideoAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosVideosApi(config);
            var portfolioId = 12345;  // decimal | The ID of the portfolio.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Get a specific video in a portfolio
                Video result = apiInstance.GetPortfolioVideoAlt1(portfolioId, videoId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosVideosApi.GetPortfolioVideoAlt1: " + e.Message );
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
 **portfolioId** | **decimal**| The ID of the portfolio. | 
 **videoId** | **decimal**| The ID of the video. | 

### Return type

[**Video**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The video was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliovideos"></a>
# **GetPortfolioVideos**
> List&lt;Video&gt; GetPortfolioVideos (decimal portfolioId, decimal userId, string containingUri = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the videos in a portfolio

This method returns every video from the specified portfolio belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetPortfolioVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosVideosApi(config);
            var portfolioId = 12345;  // decimal | The ID of the portfolio.
            var userId = 152184;  // decimal | The ID of the user.
            var containingUri = /videos/258684937;  // string | The page that contains the video URI. (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by creation date.  * `default` - Use the default sorting method.  * `likes` - Sort the results by number of likes.  * `manual` - Sort the results by their user-specified order.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the videos in a portfolio
                List<Video> result = apiInstance.GetPortfolioVideos(portfolioId, userId, containingUri, filter, filterEmbeddable, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosVideosApi.GetPortfolioVideos: " + e.Message );
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
 **portfolioId** | **decimal**| The ID of the portfolio. | 
 **userId** | **decimal**| The ID of the user. | 
 **containingUri** | **string**| The page that contains the video URI. | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;embeddable&#x60; - Return embeddable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by creation date.  * &#x60;default&#x60; - Use the default sorting method.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;manual&#x60; - Sort the results by their user-specified order.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliovideosalt1"></a>
# **GetPortfolioVideosAlt1**
> List&lt;Video&gt; GetPortfolioVideosAlt1 (decimal portfolioId, string containingUri = null, string filter = null, bool? filterEmbeddable = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the videos in a portfolio

This method returns every video from the specified portfolio belonging to the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetPortfolioVideosAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosVideosApi(config);
            var portfolioId = 12345;  // decimal | The ID of the portfolio.
            var containingUri = /videos/258684937;  // string | The page that contains the video URI. (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results.  Option descriptions:  * `embeddable` - Return embeddable videos.  (optional) 
            var filterEmbeddable = true;  // bool? | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `comments` - Sort the results by number of comments.  * `date` - Sort the results by creation date.  * `default` - Use the default sorting method.  * `likes` - Sort the results by number of likes.  * `manual` - Sort the results by their user-specified order.  * `plays` - Sort the results by number of plays.  (optional) 

            try
            {
                // Get all the videos in a portfolio
                List<Video> result = apiInstance.GetPortfolioVideosAlt1(portfolioId, containingUri, filter, filterEmbeddable, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosVideosApi.GetPortfolioVideosAlt1: " + e.Message );
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
 **portfolioId** | **decimal**| The ID of the portfolio. | 
 **containingUri** | **string**| The page that contains the video URI. | [optional] 
 **filter** | **string**| The attribute by which to filter the results.  Option descriptions:  * &#x60;embeddable&#x60; - Return embeddable videos.  | [optional] 
 **filterEmbeddable** | **bool?**| Whether to filter the results by embeddable videos (&#x60;true&#x60;) or non-embeddable videos (&#x60;false&#x60;). This parameter is required only when **filter** is &#x60;embeddable&#x60;. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;comments&#x60; - Sort the results by number of comments.  * &#x60;date&#x60; - Sort the results by creation date.  * &#x60;default&#x60; - Use the default sorting method.  * &#x60;likes&#x60; - Sort the results by number of likes.  * &#x60;manual&#x60; - Sort the results by their user-specified order.  * &#x60;plays&#x60; - Sort the results by number of plays.  | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


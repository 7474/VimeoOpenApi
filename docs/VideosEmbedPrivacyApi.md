# VimeoOpenApi.Api.VideosEmbedPrivacyApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVideoPrivacyDomain**](VideosEmbedPrivacyApi.md#addvideoprivacydomain) | **PUT** /videos/{video_id}/privacy/domains/{domain} | Add a domain to a video&#39;s whitelist
[**DeleteVideoPrivacyDomain**](VideosEmbedPrivacyApi.md#deletevideoprivacydomain) | **DELETE** /videos/{video_id}/privacy/domains/{domain} | Remove a domain from a video&#39;s whitelist
[**GetVideoPrivacyDomains**](VideosEmbedPrivacyApi.md#getvideoprivacydomains) | **GET** /videos/{video_id}/privacy/domains | Get all the domains on a video&#39;s whitelist


<a name="addvideoprivacydomain"></a>
# **AddVideoPrivacyDomain**
> void AddVideoPrivacyDomain (string domain, decimal videoId)

Add a domain to a video's whitelist

This method adds the specified domain to a video's whitelist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVideoPrivacyDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEmbedPrivacyApi(config);
            var domain = example.com;  // string | The domain name.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Add a domain to a video's whitelist
                apiInstance.AddVideoPrivacyDomain(domain, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEmbedPrivacyApi.AddVideoPrivacyDomain: " + e.Message );
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
 **domain** | **string**| The domain name. | 
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
| **204** | The video is embeddable on the domain. |  -  |
| **403** | The video doesn&#39;t have a user-defined access list. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevideoprivacydomain"></a>
# **DeleteVideoPrivacyDomain**
> void DeleteVideoPrivacyDomain (string domain, decimal videoId)

Remove a domain from a video's whitelist

This method removes the specified domain from a video's whitelist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVideoPrivacyDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEmbedPrivacyApi(config);
            var domain = example.com;  // string | The domain name.
            var videoId = 258684937;  // decimal | The ID of the video.

            try
            {
                // Remove a domain from a video's whitelist
                apiInstance.DeleteVideoPrivacyDomain(domain, videoId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEmbedPrivacyApi.DeleteVideoPrivacyDomain: " + e.Message );
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
 **domain** | **string**| The domain name. | 
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
| **204** | The domain was removed. |  -  |
| **403** | The video&#39;s embed privacy setting isn&#39;t &#x60;whitelist&#x60;. |  -  |
| **404** | No such domain exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvideoprivacydomains"></a>
# **GetVideoPrivacyDomains**
> List&lt;Domain&gt; GetVideoPrivacyDomains (decimal videoId, decimal? page = null, decimal? perPage = null)

Get all the domains on a video's whitelist

This method returns every domain on the specified video's whitelist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVideoPrivacyDomainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosEmbedPrivacyApi(config);
            var videoId = 258684937;  // decimal | The ID of the video.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the domains on a video's whitelist
                List<Domain> result = apiInstance.GetVideoPrivacyDomains(videoId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosEmbedPrivacyApi.GetVideoPrivacyDomains: " + e.Message );
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

[**List&lt;Domain&gt;**](Domain.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.domain+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The domains were returned. |  -  |
| **403** | There are no domains on which the video can be embedded. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


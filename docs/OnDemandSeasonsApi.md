# VimeoOpenApi.Api.OnDemandSeasonsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVodSeason**](OnDemandSeasonsApi.md#getvodseason) | **GET** /ondemand/pages/{ondemand_id}/seasons/{season_id} | Get a specific season on an On Demand page
[**GetVodSeasonVideos**](OnDemandSeasonsApi.md#getvodseasonvideos) | **GET** /ondemand/pages/{ondemand_id}/seasons/{season_id}/videos | Get all the videos in a season on an On Demand page
[**GetVodSeasons**](OnDemandSeasonsApi.md#getvodseasons) | **GET** /ondemand/pages/{ondemand_id}/seasons | Get all the seasons on an On Demand page


<a name="getvodseason"></a>
# **GetVodSeason**
> OnDemandSeason GetVodSeason (decimal ondemandId, decimal seasonId)

Get a specific season on an On Demand page

This method returns a single season on the specified On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodSeasonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandSeasonsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var seasonId = 12345;  // decimal | The ID of the season.

            try
            {
                // Get a specific season on an On Demand page
                OnDemandSeason result = apiInstance.GetVodSeason(ondemandId, seasonId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandSeasonsApi.GetVodSeason: " + e.Message );
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
 **ondemandId** | **decimal**| The ID of the On Demand page. | 
 **seasonId** | **decimal**| The ID of the season. | 

### Return type

[**OnDemandSeason**](OnDemandSeason.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.season+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The season was returned. |  -  |
| **404** | No such On Demand page or season exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodseasonvideos"></a>
# **GetVodSeasonVideos**
> List&lt;Video&gt; GetVodSeasonVideos (decimal ondemandId, decimal seasonId, string filter = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the videos in a season on an On Demand page

This method returns every video in the specified season on an On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodSeasonVideosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandSeasonsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var seasonId = 12345;  // decimal | The ID of the season.
            var filter = filter_example;  // string | The attribute by which to filter the results. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the videos in a season on an On Demand page
                List<Video> result = apiInstance.GetVodSeasonVideos(ondemandId, seasonId, filter, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandSeasonsApi.GetVodSeasonVideos: " + e.Message );
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
 **ondemandId** | **decimal**| The ID of the On Demand page. | 
 **seasonId** | **decimal**| The ID of the season. | 
 **filter** | **string**| The attribute by which to filter the results. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results. | [optional] 

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

<a name="getvodseasons"></a>
# **GetVodSeasons**
> List&lt;OnDemandSeason&gt; GetVodSeasons (decimal ondemandId, string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the seasons on an On Demand page

This method returns every season on the specified On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodSeasonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandSeasonsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the seasons on an On Demand page
                List<OnDemandSeason> result = apiInstance.GetVodSeasons(ondemandId, direction, filter, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandSeasonsApi.GetVodSeasons: " + e.Message );
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
 **ondemandId** | **decimal**| The ID of the On Demand page. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **sort** | **string**| The way to sort the results. | [optional] 

### Return type

[**List&lt;OnDemandSeason&gt;**](OnDemandSeason.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.season+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The seasons were returned. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


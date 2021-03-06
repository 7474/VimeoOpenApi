# VimeoOpenApi.Api.CategoriesChannelsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCategoryChannels**](CategoriesChannelsApi.md#getcategorychannels) | **GET** /categories/{category}/channels | Get all the channels in a category


<a name="getcategorychannels"></a>
# **GetCategoryChannels**
> List&lt;Channel&gt; GetCategoryChannels (string category, string direction = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the channels in a category

This method returns every channel that belongs to the specified category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetCategoryChannelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesChannelsApi(config);
            var category = animation;  // string | The name of the category.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results.  Option descriptions:  * `alphabetical` - Sort the results alphabetically.  * `date` - Sort the results by date.  * `followers` - Sort the results by number of followers.  * `videos` - Sort the results by number of videos.  (optional) 

            try
            {
                // Get all the channels in a category
                List<Channel> result = apiInstance.GetCategoryChannels(category, direction, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesChannelsApi.GetCategoryChannels: " + e.Message );
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
 **category** | **string**| The name of the category. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results.  Option descriptions:  * &#x60;alphabetical&#x60; - Sort the results alphabetically.  * &#x60;date&#x60; - Sort the results by date.  * &#x60;followers&#x60; - Sort the results by number of followers.  * &#x60;videos&#x60; - Sort the results by number of videos.  | [optional] 

### Return type

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.channel+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The channels were returned. |  -  |
| **404** | No such category exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


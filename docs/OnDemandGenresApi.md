# VimeoOpenApi.Api.OnDemandGenresApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVodGenre**](OnDemandGenresApi.md#addvodgenre) | **PUT** /ondemand/pages/{ondemand_id}/genres/{genre_id} | Add a genre to an On Demand page
[**DeleteVodGenre**](OnDemandGenresApi.md#deletevodgenre) | **DELETE** /ondemand/pages/{ondemand_id}/genres/{genre_id} | Remove a genre from an On Demand page
[**GetGenreVod**](OnDemandGenresApi.md#getgenrevod) | **GET** /ondemand/genres/{genre_id}/pages/{ondemand_id} | Get a specific On Demand page in a genre
[**GetGenreVods**](OnDemandGenresApi.md#getgenrevods) | **GET** /ondemand/genres/{genre_id}/pages | Get all the On Demand pages in a genre
[**GetVodGenre**](OnDemandGenresApi.md#getvodgenre) | **GET** /ondemand/genres/{genre_id} | Get a specific On Demand genre
[**GetVodGenreByOndemandId**](OnDemandGenresApi.md#getvodgenrebyondemandid) | **GET** /ondemand/pages/{ondemand_id}/genres/{genre_id} | Check whether an On Demand page belongs to a specific genre
[**GetVodGenres**](OnDemandGenresApi.md#getvodgenres) | **GET** /ondemand/genres | Get all On Demand genres
[**GetVodGenresByOndemandId**](OnDemandGenresApi.md#getvodgenresbyondemandid) | **GET** /ondemand/pages/{ondemand_id}/genres | Get all the genres of an On Demand page


<a name="addvodgenre"></a>
# **AddVodGenre**
> OnDemandGenre AddVodGenre (string genreId, decimal ondemandId)

Add a genre to an On Demand page

This method adds the specified genre designation to an On Demand page. A page can be associated with a maximum of two genres. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVodGenreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandGenresApi(config);
            var genreId = animation;  // string | The ID of the genre.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Add a genre to an On Demand page
                OnDemandGenre result = apiInstance.AddVodGenre(genreId, ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandGenresApi.AddVodGenre: " + e.Message );
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
 **genreId** | **string**| The ID of the genre. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

### Return type

[**OnDemandGenre**](OnDemandGenre.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.genre+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The genre was added. |  -  |
| **400** | The On Demand page already has two genres. |  -  |
| **403** | The authenticated user can&#39;t add a genre to this On Demand page. |  -  |
| **404** | No such On Demand page or genre exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevodgenre"></a>
# **DeleteVodGenre**
> void DeleteVodGenre (string genreId, decimal ondemandId)

Remove a genre from an On Demand page

This method removes a genre association from the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVodGenreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandGenresApi(config);
            var genreId = animation;  // string | The ID of the genre.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Remove a genre from an On Demand page
                apiInstance.DeleteVodGenre(genreId, ondemandId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandGenresApi.DeleteVodGenre: " + e.Message );
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
 **genreId** | **string**| The ID of the genre. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.genre+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The genre was removed. |  -  |
| **400** | The On Demand page must belong to at least one genre. |  -  |
| **403** | The authenticated user can&#39;t remove a genre from this On Demand page. |  -  |
| **404** | No such On Demand page or genre exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgenrevod"></a>
# **GetGenreVod**
> OnDemandPage GetGenreVod (string genreId, decimal ondemandId)

Get a specific On Demand page in a genre

This method returns a single On Demand page that belongs to the specified genre.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetGenreVodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandGenresApi(config);
            var genreId = animation;  // string | The ID of the genre.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Get a specific On Demand page in a genre
                OnDemandPage result = apiInstance.GetGenreVod(genreId, ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandGenresApi.GetGenreVod: " + e.Message );
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
 **genreId** | **string**| The ID of the genre. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

### Return type

[**OnDemandPage**](OnDemandPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.page+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The On Demand page in the genre was returned. |  -  |
| **404** | No such On Demand page or genre exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgenrevods"></a>
# **GetGenreVods**
> List&lt;OnDemandPage&gt; GetGenreVods (string genreId, string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string query = null, string sort = null)

Get all the On Demand pages in a genre

This method returns every On Demand page that belongs to the specified genre.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetGenreVodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandGenresApi(config);
            var genreId = animation;  // string | The ID of the genre.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The attribute by which to filter the results. (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var query = Stop motion;  // string | The search query to use to filter the results. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the On Demand pages in a genre
                List<OnDemandPage> result = apiInstance.GetGenreVods(genreId, direction, filter, page, perPage, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandGenresApi.GetGenreVods: " + e.Message );
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
 **genreId** | **string**| The ID of the genre. | 
 **direction** | **string**| The sort direction of the results.  Option descriptions:  * &#x60;asc&#x60; - Sort the results in ascending order.  * &#x60;desc&#x60; - Sort the results in descending order.  | [optional] 
 **filter** | **string**| The attribute by which to filter the results. | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
 **query** | **string**| The search query to use to filter the results. | [optional] 
 **sort** | **string**| The way to sort the results. | [optional] 

### Return type

[**List&lt;OnDemandPage&gt;**](OnDemandPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.page+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The On Demand pages in the genre were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodgenre"></a>
# **GetVodGenre**
> OnDemandGenre GetVodGenre (string genreId)

Get a specific On Demand genre

This method returns a single On Demand genre.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodGenreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandGenresApi(config);
            var genreId = animation;  // string | The ID of the genre.

            try
            {
                // Get a specific On Demand genre
                OnDemandGenre result = apiInstance.GetVodGenre(genreId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandGenresApi.GetVodGenre: " + e.Message );
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
 **genreId** | **string**| The ID of the genre. | 

### Return type

[**OnDemandGenre**](OnDemandGenre.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.genre+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The genre was returned. |  -  |
| **404** | No such genre exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodgenrebyondemandid"></a>
# **GetVodGenreByOndemandId**
> OnDemandGenre GetVodGenreByOndemandId (string genreId, decimal ondemandId)

Check whether an On Demand page belongs to a specific genre

This method determines whether an On Demand page is associated with the specified genre.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodGenreByOndemandIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandGenresApi(config);
            var genreId = animation;  // string | The ID of the genre.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Check whether an On Demand page belongs to a specific genre
                OnDemandGenre result = apiInstance.GetVodGenreByOndemandId(genreId, ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandGenresApi.GetVodGenreByOndemandId: " + e.Message );
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
 **genreId** | **string**| The ID of the genre. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

### Return type

[**OnDemandGenre**](OnDemandGenre.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.genre+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The On Demand page is in this genre. |  -  |
| **404** | No such On Demand page or genre exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodgenres"></a>
# **GetVodGenres**
> List&lt;OnDemandGenre&gt; GetVodGenres ()

Get all On Demand genres

This method returns every existing On Demand genre.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodGenresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandGenresApi(config);

            try
            {
                // Get all On Demand genres
                List<OnDemandGenre> result = apiInstance.GetVodGenres();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandGenresApi.GetVodGenres: " + e.Message );
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

[**List&lt;OnDemandGenre&gt;**](OnDemandGenre.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.genre+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The genres were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodgenresbyondemandid"></a>
# **GetVodGenresByOndemandId**
> List&lt;OnDemandGenre&gt; GetVodGenresByOndemandId (decimal ondemandId)

Get all the genres of an On Demand page

This method returns every genre associated with the specified On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodGenresByOndemandIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandGenresApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Get all the genres of an On Demand page
                List<OnDemandGenre> result = apiInstance.GetVodGenresByOndemandId(ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandGenresApi.GetVodGenresByOndemandId: " + e.Message );
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

### Return type

[**List&lt;OnDemandGenre&gt;**](OnDemandGenre.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.genre+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The genres were returned. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


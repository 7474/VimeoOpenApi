# VimeoOpenApi.Api.OnDemandPurchasesAndRentalsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckIfVodWasPurchasedAlt1**](OnDemandPurchasesAndRentalsApi.md#checkifvodwaspurchasedalt1) | **GET** /me/ondemand/purchases/{ondemand_id} | Check if a user has made a purchase or rental from an On Demand page
[**GetVodPurchases**](OnDemandPurchasesAndRentalsApi.md#getvodpurchases) | **GET** /users/{user_id}/ondemand/purchases | Get all the On Demand purchases and rentals that the user has made
[**GetVodPurchasesAlt1**](OnDemandPurchasesAndRentalsApi.md#getvodpurchasesalt1) | **GET** /me/ondemand/purchases | Get all the On Demand purchases and rentals that the user has made


<a name="checkifvodwaspurchasedalt1"></a>
# **CheckIfVodWasPurchasedAlt1**
> OnDemandPage CheckIfVodWasPurchasedAlt1 (decimal ondemandId)

Check if a user has made a purchase or rental from an On Demand page

This method determines whether the authenticated user has made a purchase or rental from the specified On Demand page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfVodWasPurchasedAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPurchasesAndRentalsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Check if a user has made a purchase or rental from an On Demand page
                OnDemandPage result = apiInstance.CheckIfVodWasPurchasedAlt1(ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPurchasesAndRentalsApi.CheckIfVodWasPurchasedAlt1: " + e.Message );
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

[**OnDemandPage**](OnDemandPage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.page+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The authenticated user has made this purchase. |  -  |
| **403** | The authenticated user can&#39;t make purchases for another user&#39;s account. |  -  |
| **404** | No such user or On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodpurchases"></a>
# **GetVodPurchases**
> List&lt;OnDemandPage&gt; GetVodPurchases (decimal userId, string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the On Demand purchases and rentals that the user has made

This method returns every purchase and rental that the authenticated user has made across all On Demand pages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodPurchasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPurchasesAndRentalsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The type of On Demand videos to show.  Option descriptions:  * `important` - This option shows the pages that are about to expire.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the On Demand purchases and rentals that the user has made
                List<OnDemandPage> result = apiInstance.GetVodPurchases(userId, direction, filter, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPurchasesAndRentalsApi.GetVodPurchases: " + e.Message );
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
 **filter** | **string**| The type of On Demand videos to show.  Option descriptions:  * &#x60;important&#x60; - This option shows the pages that are about to expire.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
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
| **200** | The purchases and rentals were returned. |  -  |
| **403** | The authenticated user can&#39;t get purchases and rentals for another user&#39;s account. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodpurchasesalt1"></a>
# **GetVodPurchasesAlt1**
> List&lt;OnDemandPage&gt; GetVodPurchasesAlt1 (string direction = null, string filter = null, decimal? page = null, decimal? perPage = null, string sort = null)

Get all the On Demand purchases and rentals that the user has made

This method returns every purchase and rental that the authenticated user has made across all On Demand pages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodPurchasesAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPurchasesAndRentalsApi(config);
            var direction = asc;  // string | The sort direction of the results.  Option descriptions:  * `asc` - Sort the results in ascending order.  * `desc` - Sort the results in descending order.  (optional) 
            var filter = filter_example;  // string | The type of On Demand videos to show.  Option descriptions:  * `important` - This option shows the pages that are about to expire.  (optional) 
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 
            var sort = sort_example;  // string | The way to sort the results. (optional) 

            try
            {
                // Get all the On Demand purchases and rentals that the user has made
                List<OnDemandPage> result = apiInstance.GetVodPurchasesAlt1(direction, filter, page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPurchasesAndRentalsApi.GetVodPurchasesAlt1: " + e.Message );
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
 **filter** | **string**| The type of On Demand videos to show.  Option descriptions:  * &#x60;important&#x60; - This option shows the pages that are about to expire.  | [optional] 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 
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
| **200** | The purchases and rentals were returned. |  -  |
| **403** | The authenticated user can&#39;t get purchases and rentals for another user&#39;s account. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


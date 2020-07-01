# VimeoOpenApi.Api.OnDemandPromotionsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVodPromotion**](OnDemandPromotionsApi.md#createvodpromotion) | **POST** /ondemand/pages/{ondemand_id}/promotions | Add a promotion to an On Demand page
[**DeleteVodPromotion**](OnDemandPromotionsApi.md#deletevodpromotion) | **DELETE** /ondemand/pages/{ondemand_id}/promotions/{promotion_id} | Delete a promotion on an On Demand page
[**GetVodPromotion**](OnDemandPromotionsApi.md#getvodpromotion) | **GET** /ondemand/pages/{ondemand_id}/promotions/{promotion_id} | Get a specific promotion on an On Demand page
[**GetVodPromotionCodes**](OnDemandPromotionsApi.md#getvodpromotioncodes) | **GET** /ondemand/pages/{ondemand_id}/promotions/{promotion_id}/codes | Get all the codes of a promotion on an On Demand page
[**GetVodPromotions**](OnDemandPromotionsApi.md#getvodpromotions) | **GET** /ondemand/pages/{ondemand_id}/promotions | Get all the promotions on an On Demand page


<a name="createvodpromotion"></a>
# **CreateVodPromotion**
> OnDemandPromotion CreateVodPromotion (decimal ondemandId, InlineObject33 inlineObject33)

Add a promotion to an On Demand page

This method adds a promotion to the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CreateVodPromotionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPromotionsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var inlineObject33 = new InlineObject33(); // InlineObject33 | 

            try
            {
                // Add a promotion to an On Demand page
                OnDemandPromotion result = apiInstance.CreateVodPromotion(ondemandId, inlineObject33);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPromotionsApi.CreateVodPromotion: " + e.Message );
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
 **inlineObject33** | [**InlineObject33**](InlineObject33.md)|  | 

### Return type

[**OnDemandPromotion**](OnDemandPromotion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.ondemand.promotion+json
 - **Accept**: application/vnd.vimeo.ondemand.promotion+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The promotion was added. |  -  |
| **400** | There are errors in the request, or the promo code already exists. |  -  |
| **403** | The authenticated user can&#39;t add promotions to this On Demand page. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevodpromotion"></a>
# **DeleteVodPromotion**
> void DeleteVodPromotion (decimal ondemandId, decimal promotionId)

Delete a promotion on an On Demand page

This method deletes a promotion on the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVodPromotionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPromotionsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var promotionId = 12345;  // decimal | The ID of the promotion.

            try
            {
                // Delete a promotion on an On Demand page
                apiInstance.DeleteVodPromotion(ondemandId, promotionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPromotionsApi.DeleteVodPromotion: " + e.Message );
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
 **promotionId** | **decimal**| The ID of the promotion. | 

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
| **204** | The promotion was deleted. |  -  |
| **403** | The authenticated user can&#39;t delete promotions on this On Demand page. |  -  |
| **404** | No such On Demand page or promotion exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodpromotion"></a>
# **GetVodPromotion**
> OnDemandPromotion GetVodPromotion (decimal ondemandId, decimal promotionId)

Get a specific promotion on an On Demand page

This method returns a single promotion on the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodPromotionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPromotionsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var promotionId = 12345;  // decimal | The ID of the promotion.

            try
            {
                // Get a specific promotion on an On Demand page
                OnDemandPromotion result = apiInstance.GetVodPromotion(ondemandId, promotionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPromotionsApi.GetVodPromotion: " + e.Message );
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
 **promotionId** | **decimal**| The ID of the promotion. | 

### Return type

[**OnDemandPromotion**](OnDemandPromotion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.promotion+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The promotion was returned. |  -  |
| **403** | The authenticated user can&#39;t get promotions on this On Demand page. |  -  |
| **404** | No such On Demand page or promotion exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodpromotioncodes"></a>
# **GetVodPromotionCodes**
> OnDemandPromotionCode GetVodPromotionCodes (decimal ondemandId, decimal promotionId, decimal? page = null, decimal? perPage = null)

Get all the codes of a promotion on an On Demand page

This method returns every code of the specified promotion on an On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodPromotionCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPromotionsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var promotionId = 12345;  // decimal | The ID of the promotion.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the codes of a promotion on an On Demand page
                OnDemandPromotionCode result = apiInstance.GetVodPromotionCodes(ondemandId, promotionId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPromotionsApi.GetVodPromotionCodes: " + e.Message );
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
 **promotionId** | **decimal**| The ID of the promotion. | 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

### Return type

[**OnDemandPromotionCode**](OnDemandPromotionCode.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.promocode+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The codes were returned. |  -  |
| **403** | The authenticated user can&#39;t get promotions on this On Demand page. |  -  |
| **404** | No such On Demand page or promotion exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodpromotions"></a>
# **GetVodPromotions**
> OnDemandPromotion GetVodPromotions (decimal ondemandId, string filter, decimal? page = null, decimal? perPage = null)

Get all the promotions on an On Demand page

This method returns every promotion on the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodPromotionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandPromotionsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var filter = filter_example;  // string | The filter to apply to the results.
            var page = 1;  // decimal? | The page number of the results to show. (optional) 
            var perPage = 10;  // decimal? | The number of items to show on each page of results, up to a maximum of 100. (optional) 

            try
            {
                // Get all the promotions on an On Demand page
                OnDemandPromotion result = apiInstance.GetVodPromotions(ondemandId, filter, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandPromotionsApi.GetVodPromotions: " + e.Message );
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
 **filter** | **string**| The filter to apply to the results. | 
 **page** | **decimal?**| The page number of the results to show. | [optional] 
 **perPage** | **decimal?**| The number of items to show on each page of results, up to a maximum of 100. | [optional] 

### Return type

[**OnDemandPromotion**](OnDemandPromotion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.promotion+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The promotions were returned. |  -  |
| **400** | The filter is invalid. |  -  |
| **403** | The authenticated user can&#39;t get promotions on this On Demand page. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


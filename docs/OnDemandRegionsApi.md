# VimeoOpenApi.Api.OnDemandRegionsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddVodRegion**](OnDemandRegionsApi.md#addvodregion) | **PUT** /ondemand/pages/{ondemand_id}/regions/{country} | Add a specific region to an On Demand page
[**DeleteVodRegion**](OnDemandRegionsApi.md#deletevodregion) | **DELETE** /ondemand/pages/{ondemand_id}/regions/{country} | Remove a specific region from an On Demand page
[**DeleteVodRegions**](OnDemandRegionsApi.md#deletevodregions) | **DELETE** /ondemand/pages/{ondemand_id}/regions | Remove a list of regions from an On Demand page
[**GetRegion**](OnDemandRegionsApi.md#getregion) | **GET** /ondemand/regions/{country} | Get a specific On Demand region
[**GetRegions**](OnDemandRegionsApi.md#getregions) | **GET** /ondemand/regions | Get all the On Demand regions
[**GetVodRegion**](OnDemandRegionsApi.md#getvodregion) | **GET** /ondemand/pages/{ondemand_id}/regions/{country} | Get a specific region on an On Demand page
[**GetVodRegions**](OnDemandRegionsApi.md#getvodregions) | **GET** /ondemand/pages/{ondemand_id}/regions | Get all the regions on an On Demand page
[**SetVodRegions**](OnDemandRegionsApi.md#setvodregions) | **PUT** /ondemand/pages/{ondemand_id}/regions | Add a list of regions to an On Demand page


<a name="addvodregion"></a>
# **AddVodRegion**
> OnDemandRegion AddVodRegion (string country, decimal ondemandId)

Add a specific region to an On Demand page

This method adds a single region to the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddVodRegionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandRegionsApi(config);
            var country = US;  // string | The country code of the region to add.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Add a specific region to an On Demand page
                OnDemandRegion result = apiInstance.AddVodRegion(country, ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandRegionsApi.AddVodRegion: " + e.Message );
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
 **country** | **string**| The country code of the region to add. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

### Return type

[**OnDemandRegion**](OnDemandRegion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.region+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The region was added. |  -  |
| **403** | The authenticated user can&#39;t add regions to this On Demand page. |  -  |
| **404** | No such On Demand page or region exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevodregion"></a>
# **DeleteVodRegion**
> void DeleteVodRegion (string country, decimal ondemandId)

Remove a specific region from an On Demand page

This method removes a single region from the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVodRegionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandRegionsApi(config);
            var country = US;  // string | The country code of the region to remove.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Remove a specific region from an On Demand page
                apiInstance.DeleteVodRegion(country, ondemandId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandRegionsApi.DeleteVodRegion: " + e.Message );
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
 **country** | **string**| The country code of the region to remove. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.region+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The region was removed. |  -  |
| **403** | The authenticated user can&#39;t remove regions from this On Demand page. |  -  |
| **404** | No such On Demand page or region exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevodregions"></a>
# **DeleteVodRegions**
> List&lt;OnDemandRegion&gt; DeleteVodRegions (decimal ondemandId, InlineObject35 inlineObject35 = null)

Remove a list of regions from an On Demand page

This method removes multiple regions from the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteVodRegionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandRegionsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var inlineObject35 = new InlineObject35(); // InlineObject35 |  (optional) 

            try
            {
                // Remove a list of regions from an On Demand page
                List<OnDemandRegion> result = apiInstance.DeleteVodRegions(ondemandId, inlineObject35);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandRegionsApi.DeleteVodRegions: " + e.Message );
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
 **inlineObject35** | [**InlineObject35**](InlineObject35.md)|  | [optional] 

### Return type

[**List&lt;OnDemandRegion&gt;**](OnDemandRegion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.ondemand.region+json
 - **Accept**: application/vnd.vimeo.ondemand.region+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The regions were removed. |  -  |
| **403** | The authenticated user can&#39;t remove regions from this On Demand page. |  -  |
| **404** | No such On Demand page or region exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregion"></a>
# **GetRegion**
> OnDemandRegion GetRegion (string country)

Get a specific On Demand region

This method returns a single On Demand region.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetRegionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandRegionsApi(config);
            var country = US;  // string | The country code of the region to return.

            try
            {
                // Get a specific On Demand region
                OnDemandRegion result = apiInstance.GetRegion(country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandRegionsApi.GetRegion: " + e.Message );
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
 **country** | **string**| The country code of the region to return. | 

### Return type

[**OnDemandRegion**](OnDemandRegion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.region+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The region was returned. |  -  |
| **404** | No such region exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregions"></a>
# **GetRegions**
> List&lt;OnDemandRegion&gt; GetRegions ()

Get all the On Demand regions

This method returns every existing On Demand region.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetRegionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandRegionsApi(config);

            try
            {
                // Get all the On Demand regions
                List<OnDemandRegion> result = apiInstance.GetRegions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandRegionsApi.GetRegions: " + e.Message );
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

[**List&lt;OnDemandRegion&gt;**](OnDemandRegion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.region+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The regions were returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodregion"></a>
# **GetVodRegion**
> OnDemandRegion GetVodRegion (string country, decimal ondemandId)

Get a specific region on an On Demand page

This method returns a single region on the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodRegionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandRegionsApi(config);
            var country = US;  // string | The country code of the region to return.
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Get a specific region on an On Demand page
                OnDemandRegion result = apiInstance.GetVodRegion(country, ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandRegionsApi.GetVodRegion: " + e.Message );
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
 **country** | **string**| The country code of the region to return. | 
 **ondemandId** | **decimal**| The ID of the On Demand page. | 

### Return type

[**OnDemandRegion**](OnDemandRegion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.region+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The region was returned. |  -  |
| **404** | No such On Demand page or region exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvodregions"></a>
# **GetVodRegions**
> List&lt;OnDemandRegion&gt; GetVodRegions (decimal ondemandId)

Get all the regions on an On Demand page

This method returns every region on the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetVodRegionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandRegionsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.

            try
            {
                // Get all the regions on an On Demand page
                List<OnDemandRegion> result = apiInstance.GetVodRegions(ondemandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandRegionsApi.GetVodRegions: " + e.Message );
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

[**List&lt;OnDemandRegion&gt;**](OnDemandRegion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.ondemand.region+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The regions were returned. |  -  |
| **404** | No such On Demand page exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setvodregions"></a>
# **SetVodRegions**
> OnDemandRegion SetVodRegions (decimal ondemandId, InlineObject34 inlineObject34)

Add a list of regions to an On Demand page

This method adds multiple regions to the specified On Demand page. The authenticated user must be the owner of the page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class SetVodRegionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OnDemandRegionsApi(config);
            var ondemandId = 61326;  // decimal | The ID of the On Demand page.
            var inlineObject34 = new InlineObject34(); // InlineObject34 | 

            try
            {
                // Add a list of regions to an On Demand page
                OnDemandRegion result = apiInstance.SetVodRegions(ondemandId, inlineObject34);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnDemandRegionsApi.SetVodRegions: " + e.Message );
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
 **inlineObject34** | [**InlineObject34**](InlineObject34.md)|  | 

### Return type

[**OnDemandRegion**](OnDemandRegion.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.ondemand.region+json
 - **Accept**: application/vnd.vimeo.ondemand.region+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of regions was added. |  -  |
| **403** | The authenticated user can&#39;t add regions to this On Demand page. |  -  |
| **404** | No such On Demand page or region exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


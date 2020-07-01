# VimeoOpenApi.Api.ChannelsTagsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddChannelTag**](ChannelsTagsApi.md#addchanneltag) | **PUT** /channels/{channel_id}/tags/{word} | Add a specific tag to a channel
[**AddTagsToChannel**](ChannelsTagsApi.md#addtagstochannel) | **PUT** /channels/{channel_id}/tags | Add a list of tags to a channel
[**CheckIfChannelHasTag**](ChannelsTagsApi.md#checkifchannelhastag) | **GET** /channels/{channel_id}/tags/{word} | Check if a tag has been added to a channel
[**DeleteTagFromChannel**](ChannelsTagsApi.md#deletetagfromchannel) | **DELETE** /channels/{channel_id}/tags/{word} | Remove a tag from a channel
[**GetChannelTags**](ChannelsTagsApi.md#getchanneltags) | **GET** /channels/{channel_id}/tags | Get all the tags that have been added to a channel


<a name="addchanneltag"></a>
# **AddChannelTag**
> void AddChannelTag (decimal channelId, string word)

Add a specific tag to a channel

This method adds a single tag to the specified channel. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddChannelTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsTagsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var word = awesome;  // string | The word to use as the tag.

            try
            {
                // Add a specific tag to a channel
                apiInstance.AddChannelTag(channelId, word);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsTagsApi.AddChannelTag: " + e.Message );
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
 **word** | **string**| The word to use as the tag. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The tag was added. |  -  |
| **400** | * The tag is invalid, or a parameter is invalid. * Error code 2501: The channel can&#39;t have more than 20 tags. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t add tags to this channel. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtagstochannel"></a>
# **AddTagsToChannel**
> List&lt;Tag&gt; AddTagsToChannel (decimal channelId, InlineObject7 inlineObject7)

Add a list of tags to a channel

This method adds multiple tags to the specified channel. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class AddTagsToChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsTagsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var inlineObject7 = new InlineObject7(); // InlineObject7 | 

            try
            {
                // Add a list of tags to a channel
                List<Tag> result = apiInstance.AddTagsToChannel(channelId, inlineObject7);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsTagsApi.AddTagsToChannel: " + e.Message );
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
 **inlineObject7** | [**InlineObject7**](InlineObject7.md)|  | 

### Return type

[**List&lt;Tag&gt;**](Tag.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/vnd.vimeo.tag+json
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The tags were added. |  -  |
| **400** | * No such channel exists, or a parameter is invalid. * Error code 2501: The channel can&#39;t have more than 20 tags. * Error code 2205: There was no request body, or the request body is malformed. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t add tags to this channel. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkifchannelhastag"></a>
# **CheckIfChannelHasTag**
> void CheckIfChannelHasTag (decimal channelId, string word)

Check if a tag has been added to a channel

This method determines whether a tag has been added to the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CheckIfChannelHasTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsTagsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var word = awesome;  // string | The word to use as the tag.

            try
            {
                // Check if a tag has been added to a channel
                apiInstance.CheckIfChannelHasTag(channelId, word);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsTagsApi.CheckIfChannelHasTag: " + e.Message );
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
 **word** | **string**| The word to use as the tag. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The tag has been added to the channel. |  -  |
| **400** | No such tag exists. |  -  |
| **404** | Error code 5000: The tag exists, but the channel isn&#39;t tagged by it. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetagfromchannel"></a>
# **DeleteTagFromChannel**
> void DeleteTagFromChannel (decimal channelId, string word)

Remove a tag from a channel

This method removes a single tag from the specified channel. The authenticated user must be the owner of the channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class DeleteTagFromChannelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsTagsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.
            var word = awesome;  // string | The word to use as the tag.

            try
            {
                // Remove a tag from a channel
                apiInstance.DeleteTagFromChannel(channelId, word);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsTagsApi.DeleteTagFromChannel: " + e.Message );
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
 **word** | **string**| The word to use as the tag. | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The tag was removed. |  -  |
| **400** | The tag is invalid, or a parameter is invalid. |  -  |
| **401** | Error code 8003: The user credentials are invalid. |  -  |
| **403** | Error code 3200: The authenticated user can&#39;t remove tags from this channel. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchanneltags"></a>
# **GetChannelTags**
> List&lt;Tag&gt; GetChannelTags (decimal channelId)

Get all the tags that have been added to a channel

This method returns every tag that has been added to the specified channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetChannelTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChannelsTagsApi(config);
            var channelId = 927;  // decimal | The ID of the channel.

            try
            {
                // Get all the tags that have been added to a channel
                List<Tag> result = apiInstance.GetChannelTags(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsTagsApi.GetChannelTags: " + e.Message );
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

### Return type

[**List&lt;Tag&gt;**](Tag.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.tag+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The tags were returned. |  -  |
| **400** | No such channel exists. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


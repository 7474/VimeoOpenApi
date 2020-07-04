# VimeoOpenApi.Api.VideosUploadsApi

All URIs are relative to *https://api.vimeo.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompleteStreamingUpload**](VideosUploadsApi.md#completestreamingupload) | **DELETE** /users/{user_id}/uploads/{upload_id} | Complete a streaming upload
[**GetUploadAttempt**](VideosUploadsApi.md#getuploadattempt) | **GET** /users/{user_id}/uploads/{upload_id} | Get an upload attempt
[**UploadVideo**](VideosUploadsApi.md#uploadvideo) | **POST** /users/{user_id}/videos | Upload a video
[**UploadVideoAlt1**](VideosUploadsApi.md#uploadvideoalt1) | **POST** /me/videos | Upload a video


<a name="completestreamingupload"></a>
# **CompleteStreamingUpload**
> void CompleteStreamingUpload (decimal uploadId, decimal userId, string signature, decimal videoFileId)

Complete a streaming upload

This method completes the specified streaming upload of the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class CompleteStreamingUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosUploadsApi(config);
            var uploadId = 12345;  // decimal | The ID of the streaming upload.
            var userId = 152184;  // decimal | The ID of the user.
            var signature = cd89a20adde7a608f3331e71c37bdfa087bacbf3;  // string | The crypto signature of the completed upload.
            var videoFileId = 1234;  // decimal | The ID of the uploaded file.

            try
            {
                // Complete a streaming upload
                apiInstance.CompleteStreamingUpload(uploadId, userId, signature, videoFileId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosUploadsApi.CompleteStreamingUpload: " + e.Message );
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
 **uploadId** | **decimal**| The ID of the streaming upload. | 
 **userId** | **decimal**| The ID of the user. | 
 **signature** | **string**| The crypto signature of the completed upload. | 
 **videoFileId** | **decimal**| The ID of the uploaded file. | 

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
| **201** | The streaming upload has been completed. |  -  |
| **400** | Error code 2502: The format of the video file is invalid. |  -  |
| **404** | * Error code 5006: No such video file exists. * Error code 5007: No such signature exists. * Error code 8400: The signature is invalid. |  -  |
| **500** | Error code 4011: The upload server returned an HTTP status code other than 200. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuploadattempt"></a>
# **GetUploadAttempt**
> UploadAttempt GetUploadAttempt (decimal uploadId, decimal userId)

Get an upload attempt

This method returns the specified upload attempt of the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class GetUploadAttemptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosUploadsApi(config);
            var uploadId = 12345;  // decimal | The ID of the upload attempt.
            var userId = 152184;  // decimal | The ID of the user.

            try
            {
                // Get an upload attempt
                UploadAttempt result = apiInstance.GetUploadAttempt(uploadId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosUploadsApi.GetUploadAttempt: " + e.Message );
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
 **uploadId** | **decimal**| The ID of the upload attempt. | 
 **userId** | **decimal**| The ID of the user. | 

### Return type

[**UploadAttempt**](UploadAttempt.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.vimeo.uploadattempt+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upload attempt was returned. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadvideo"></a>
# **UploadVideo**
> Video UploadVideo (decimal userId, InlineObject50 inlineObject50)

Upload a video

This method begins the video upload process for the authenticated user. For more information, see our [upload documentation](https://developer.vimeo.com/api/upload/videos).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UploadVideoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosUploadsApi(config);
            var userId = 152184;  // decimal | The ID of the user.
            var inlineObject50 = new InlineObject50(); // InlineObject50 | 

            try
            {
                // Upload a video
                Video result = apiInstance.UploadVideo(userId, inlineObject50);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosUploadsApi.UploadVideo: " + e.Message );
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
 **inlineObject50** | [**InlineObject50**](InlineObject50.md)|  | 

### Return type

[**Video**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The upload procedure has begun. |  -  |
| **400** | * Error code 2205: The body of the request isn&#39;t formatted properly. * Error code 2204: The request contains invalid body parameters. * Error code 2230: The upload type is invalid. * Error code 3116: The **type** payload parameter was supplied. instead of **upload.approach**. Use **upload.approach** starting from API version 3.4. |  -  |
| **401** | Error code 8002: No user is associated with the access token. |  -  |
| **403** | * Error code 4102: The authenticated user&#39;s allotted quota has been reached. * Error code 4101: The authenticated user&#39;s maximum disk space has been reached. |  -  |
| **500** | Error code 4003: There is a problem initiating the upload. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadvideoalt1"></a>
# **UploadVideoAlt1**
> Video UploadVideoAlt1 (InlineObject26 inlineObject26)

Upload a video

This method begins the video upload process for the authenticated user. For more information, see our [upload documentation](https://developer.vimeo.com/api/upload/videos).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VimeoOpenApi.Api;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace Example
{
    public class UploadVideoAlt1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vimeo.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VideosUploadsApi(config);
            var inlineObject26 = new InlineObject26(); // InlineObject26 | 

            try
            {
                // Upload a video
                Video result = apiInstance.UploadVideoAlt1(inlineObject26);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VideosUploadsApi.UploadVideoAlt1: " + e.Message );
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
 **inlineObject26** | [**InlineObject26**](InlineObject26.md)|  | 

### Return type

[**Video**](Video.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.vimeo.video+json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The upload procedure has begun. |  -  |
| **400** | * Error code 2205: The body of the request isn&#39;t formatted properly. * Error code 2204: The request contains invalid body parameters. * Error code 2230: The upload type is invalid. * Error code 3116: The **type** payload parameter was supplied. instead of **upload.approach**. Use **upload.approach** starting from API version 3.4. |  -  |
| **401** | Error code 8002: No user is associated with the access token. |  -  |
| **403** | * Error code 4102: The authenticated user&#39;s allotted quota has been reached. * Error code 4101: The authenticated user&#39;s maximum disk space has been reached. |  -  |
| **500** | Error code 4003: There is a problem initiating the upload. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


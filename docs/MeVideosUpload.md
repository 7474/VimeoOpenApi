# VimeoOpenApi.Model.MeVideosUpload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Approach** | **string** | The upload approach.  Option descriptions:  * &#x60;post&#x60; - Use the &#x60;post&#x60; approach.  * &#x60;pull&#x60; - Use the &#x60;pull&#x60; approach.  * &#x60;streaming&#x60; - Use the &#x60;streaming&#x60; approach.  * &#x60;tus&#x60; - Use the &#x60;tus&#x60; approach.  | 
**Link** | **string** | The public URL at which the video is hosted. The URL must be valid for at least 24 hours. Use this parameter when **approach** is &#x60;pull&#x60;. | [optional] 
**RedirectUrl** | **string** | The app&#39;s redirect URL. Use this parameter when **approach** is &#x60;post&#x60;. | [optional] 
**Size** | **string** | The size in bytes of the video to upload. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


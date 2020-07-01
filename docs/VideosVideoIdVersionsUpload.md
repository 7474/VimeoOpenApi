# VimeoOpenApi.Model.VideosVideoIdVersionsUpload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Approach** | **string** | The approach by which to upload the version.  Option descriptions:  * &#x60;post&#x60; - Use the &#x60;post&#x60; method.  * &#x60;pull&#x60; - Use the &#x60;pull&#x60; method.  * &#x60;streaming&#x60; - Use the &#x60;streaming&#x60; method.  * &#x60;tus&#x60; - Use the &#x60;tus&#x60; method.  | 
**Link** | **string** | When **upload.approach** is &#x60;pull&#x60;, the public URL from which to download the version. This URL must be valid for at least 24 hours. | [optional] 
**RedirectUrl** | **string** | When **upload.approach** is &#x60;post&#x60;, the app&#39;s redirect URL. | [optional] 
**Size** | **string** | The upload size of the version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


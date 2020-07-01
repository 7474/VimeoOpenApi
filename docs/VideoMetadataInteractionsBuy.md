# VimeoOpenApi.Model.VideoMetadataInteractionsBuy
The Buy interaction for a On Demand video.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | The currency code for the current user&#39;s region. | 
**DisplayPrice** | **string** | Formatted price to display to buy an On Demand video. | 
**Download** | **string** | The user&#39;s download access to this On Demand video:  Option descriptions:  * &#x60;available&#x60; - The video is available for download.  * &#x60;purchased&#x60; - The user has purchased the video.  * &#x60;restricted&#x60; - The user isn&#39;t permitted to download the video.  * &#x60;unavailable&#x60; - The video isn&#39;t available for download.  | 
**Drm** | **bool** | Whether the video has DRM. | 
**Link** | **string** | The URL to buy the On Demand video on Vimeo. | 
**Price** | **decimal?** | The numeric value of the price for buying the On Demand video. | 
**PurchaseTime** | **string** | The time in ISO 8601 format when the On Demand video was purchased. | 
**Stream** | **string** | The user&#39;s streaming access to this On Demand video:  Option descriptions:  * &#x60;available&#x60; - The video is available for streaming.  * &#x60;purchased&#x60; - The user has purchased the video.  * &#x60;restricted&#x60; - The user isn&#39;t permitted to stream the video.  * &#x60;unavailable&#x60; - The video isn&#39;t available for streaming  | 
**Uri** | **string** | The product URI to purchase the On Demand video. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


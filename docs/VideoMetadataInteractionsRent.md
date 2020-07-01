# VimeoOpenApi.Model.VideoMetadataInteractionsRent
The Rent interaction for an On Demand video.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | The currency code for the current user&#39;s region. | 
**DisplayPrice** | **string** | Formatted price to display to rent an On Demand video. | 
**Drm** | **bool** | Whether the video has DRM. | 
**ExpiresTime** | **string** | The time in ISO 8601 format when the rental period for the video expires. | 
**Link** | **string** | The URL to rent the On Demand video on Vimeo. | 
**Price** | **decimal?** | The numeric value of the price for buying the On Demand video. | 
**PurchaseTime** | **string** | The time in ISO 8601 format when the On Demand video was rented. | 
**Stream** | **string** | The user&#39;s streaming access to this On Demand video:  Option descriptions:  * &#x60;available&#x60; - The video is available for streaming.  * &#x60;purchased&#x60; - The user has purchased the video.  * &#x60;restricted&#x60; - The user isn&#39;t permitted to stream the video.  * &#x60;unavailable&#x60; - The video isn&#39;t available for streaming.  | 
**Uri** | **string** | The product URI to rent the On Demand video. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


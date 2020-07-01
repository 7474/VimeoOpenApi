# VimeoOpenApi.Model.TextTrack
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Whether this text track is active. | 
**HlsLink** | **string** | The read-only URL of the text track file, intended for use with HLS playback. | 
**HlsLinkExpiresTime** | **string** | The time in ISO 8601 format when the read-only HLS playback text track file expires. | 
**Language** | **string** | The language code for this text track. To see a full list, request &#x60;/languages?filter&#x3D;texttrack&#x60;. | 
**Link** | **string** | The read-only URL of the text track file. You can upload to this link when you create it for the first time. | 
**LinkExpiresTime** | **string** | The time in ISO 8601 format when the text track link expires. | 
**Name** | **string** | The descriptive name of this text track. | 
**Type** | **string** | The type of the text track:  Option descriptions:  * &#x60;captions&#x60; - The text track is for captions.  * &#x60;subtitles&#x60; - The text track is for subtitles.  | 
**Uri** | **string** | The relative URI of the text track. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


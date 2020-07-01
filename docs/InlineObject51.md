# VimeoOpenApi.Model.InlineObject51
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentRating** | **List&lt;string&gt;** | A list of values describing the content in this video. Find the full list in the [&#x60;/contentratings&#x60;](https://developer.vimeo.com/api/reference/videos#get_content_ratings) endpoint. | [optional] 
**Description** | **string** | The description of the video. | [optional] 
**Embed** | [**MeVideosEmbed**](MeVideosEmbed.md) |  | [optional] 
**License** | **string** | The Creative Commons license under which the video is offered. | [optional] 
**Locale** | **string** | The video&#39;s default language. For a full list of supported languages, use the [&#x60;/languages?filter&#x3D;texttracks&#x60;](https://developer.vimeo.com/api/reference/videos#get_languages) endpoint. | [optional] 
**Name** | **string** | The title of the video. | [optional] 
**Password** | **string** | The password. When you set **privacy.view** to &#x60;password&#x60;, you must provide the password as an additional parameter. | [optional] 
**Privacy** | [**VideosVideoIdPrivacy**](VideosVideoIdPrivacy.md) |  | [optional] 
**ReviewPage** | [**MeVideosReviewPage**](MeVideosReviewPage.md) |  | [optional] 
**Spatial** | [**VideosVideoIdSpatial**](VideosVideoIdSpatial.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


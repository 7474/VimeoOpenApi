# VimeoOpenApi.Model.InlineObject26
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentRating** | **List&lt;string&gt;** | A list of values describing the content in this video. Find the full list in the [&#x60;/contentratings&#x60;](https://developer.vimeo.com/api/reference/videos#get_content_ratings) endpoint. | [optional] 
**Description** | **string** | The description of the video. | [optional] 
**Embed** | [**MeVideosEmbed**](MeVideosEmbed.md) |  | [optional] 
**License** | **string** | The Creative Commons license under which the video is offered.  Option descriptions:  * &#x60;by&#x60; - The video is offered under CC BY, or the attibution-only license.  * &#x60;by-nc&#x60; - The video is offered under CC BY-NC, or the Attribution-NonCommercial license.  * &#x60;by-nc-nd&#x60; - The video is offered under CC BY-NC-ND, or the Attribution-NonCommercian-NoDerivs license.  * &#x60;by-nc-sa&#x60; - The video is offered under CC BY-NC-SA, or the Attribution-NonCommercial-ShareAlike licence.  * &#x60;by-nd&#x60; - The video is offered under CC BY-ND, or the Attribution-NoDerivs license.  * &#x60;by-sa&#x60; - The video is offered under CC BY-SA, or the Attribution-ShareAlike license.  * &#x60;cc0&#x60; - The video is offered under CC0, or the public domain license.  | [optional] 
**Locale** | **string** | The video&#39;s default language. For a full list of supported languages, use the [&#x60;/languages?filter&#x3D;texttracks&#x60;](https://developer.vimeo.com/api/reference/videos#get_languages) endpoint. | [optional] 
**Name** | **string** | The title of the video. | [optional] 
**Password** | **string** | The password. This field is required when **privacy.view** is &#x60;password&#x60;. | [optional] 
**Privacy** | [**MeVideosPrivacy1**](MeVideosPrivacy1.md) |  | [optional] 
**ReviewPage** | [**MeVideosReviewPage**](MeVideosReviewPage.md) |  | [optional] 
**Spatial** | [**MeVideosSpatial**](MeVideosSpatial.md) |  | [optional] 
**Upload** | [**MeVideosUpload**](MeVideosUpload.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


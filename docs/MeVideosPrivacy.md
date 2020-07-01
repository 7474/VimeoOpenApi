# VimeoOpenApi.Model.MeVideosPrivacy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Add** | **bool** | Whether the user can add videos to showcases, channels, or groups by default. | [optional] 
**Comments** | **string** | Who can comment on the user&#39;s video uploads by default.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment.  * &#x60;contacts&#x60; - Only the user&#39;s contacts can comment.  * &#x60;nobody&#x60; - No one can comment.  | [optional] 
**Download** | **bool** | Whether the user can download videos. This value becomes the default download setting for all future videos that the user uploads. | [optional] 
**Embed** | **string** | The privacy for the user&#39;s embedded videos. The whitelist value enables you to define all valid embeddable domains. See our [Interacting with Videos](https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy) guide for details on adding and removing domains.  Option descriptions:  * &#x60;private&#x60; - The videos can&#39;t be embedded on any domain.  * &#x60;public&#x60; - The videos can be embedded on any domain.  * &#x60;whitelist&#x60; - The videos can be embedded on the specified domains only.  | [optional] 
**View** | **string** | Who can access the user&#39;s videos by default.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the videos.  * &#x60;contacts&#x60; - Only the user&#39;s contacts can access the videos.  * &#x60;disable&#x60; - The videos are disabled.  * &#x60;nobody&#x60; - No one can access the videos.  * &#x60;password&#x60; - Only those with the password can access the videos.  * &#x60;unlisted&#x60; - The videos are unlisted.  * &#x60;users&#x60; - Only other Vimeo members can access the videos.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


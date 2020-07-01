# VimeoOpenApi.Model.MeVideosPrivacy1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Add** | **bool** | Whether a user can add the video to a showcase, channel, or group. | [optional] 
**Comments** | **string** | The privacy level required to comment on the video.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the video.  * &#x60;contacts&#x60; - Only the video owner&#39;s contacts can comment on the video.  * &#x60;nobody&#x60; - No one can comment on the video.  | [optional] 
**Download** | **bool** | Whether a user can download the video. This field isn&#39;t available to Vimeo Basic members. | [optional] 
**Embed** | **string** | The video&#39;s embed setting. Specify the &#x60;whitelist&#x60; value to restrict embedding to a specific set of domains. For more information, see our [Interacting with Videos](https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy) guide.  Option descriptions:  * &#x60;private&#x60; - The video can&#39;t be embedded.  * &#x60;public&#x60; - The video can be embedded.  * &#x60;whitelist&#x60; - The video can be embedded on the specified domains only.  | [optional] 
**View** | **string** | The video&#39;s privacy setting. When this value is &#x60;users&#x60;, &#x60;application/json&#x60; is the only valid content type. Also, Vimeo Basic members can&#39;t set this value to &#x60;disable&#x60; or &#x60;unlisted&#x60;.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can acess the video.  * &#x60;contacts&#x60; - Only the owner&#39;s contacts can access the video.  * &#x60;disable&#x60; - The video is disabled.  * &#x60;nobody&#x60; - No one except the owner can access the video.  * &#x60;password&#x60; - Only those with the password can access the video.  * &#x60;unlisted&#x60; - The video is unlisted. Anyone can access it, but it doesn&#39;t appear in search.  * &#x60;users&#x60; - Only Vimeo members can access the video.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


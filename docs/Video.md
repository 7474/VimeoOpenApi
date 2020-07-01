# VimeoOpenApi.Model.Video
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Categories** | [**List&lt;Category&gt;**](Category.md) | The categories to which this video belongs. | 
**ContentRating** | **List&lt;string&gt;** | The content ratings of this video. | 
**Context** | [**VideoContext**](VideoContext.md) |  | 
**CreatedTime** | **string** | The time in ISO 8601 format when the video was created. | 
**Description** | **string** | A brief explanation of the video&#39;s content. | 
**Duration** | **decimal** | The video&#39;s duration in seconds. | 
**Embed** | [**EmbedSettings**](EmbedSettings.md) | Information about embedding this video. | 
**Height** | **decimal** | The video&#39;s height in pixels. | 
**Language** | **string** | The video&#39;s primary language. | 
**LastUserActionEventDate** | **string** | The time in ISO 8601 format when the user last modified the video. | [optional] 
**License** | **string** | The [Creative Commons](http://creativecommons.org/licenses/) license used for the video:  Option descriptions:  * &#x60;by&#x60; - Attribution  * &#x60;by-nc&#x60; - Attribution Non-Commercial  * &#x60;by-nc-nd&#x60; - Attribution Non-Commercial No Derivatives  * &#x60;by-nc-sa&#x60; - Attribution Non-Commercial Share Alike  * &#x60;by-nd&#x60; - Attribution No Derivatives  * &#x60;by-sa&#x60; - Attribution Share Alike  * &#x60;cc0&#x60; - Public Domain Dedication  | 
**Link** | **string** | The link to the video. | 
**Metadata** | [**VideoMetadata**](VideoMetadata.md) |  | 
**ModifiedTime** | **string** | The time in ISO 8601 format when the video metadata was last modified. | 
**Name** | **string** | The video&#39;s title. | 
**ParentFolder** | [**Project**](Project.md) | Information about the folder that contains this video. | [optional] 
**Password** | **string** | The privacy-enabled password to watch this video. Only users can see their own video passwords. This data requires a bearer token with the &#x60;private&#x60; scope. | [optional] 
**Pictures** | [**Picture**](Picture.md) | The active picture for this video. | 
**Privacy** | [**VideoPrivacy**](VideoPrivacy.md) |  | 
**ReleaseTime** | **string** | The time in ISO 8601 format when the video was released. | 
**ResourceKey** | **string** | The resource key string of the video. | 
**Spatial** | [**VideoSpatial**](VideoSpatial.md) |  | 
**Stats** | [**VideoStats**](VideoStats.md) |  | 
**Status** | **string** | The status code for the availability of the video. This field is deprecated in favor of &#x60;upload&#x60; and &#x60;transcode&#x60;.  Option descriptions:  * &#x60;available&#x60; - The video is available.  * &#x60;quota_exceeded&#x60; - The user&#39;s quota is exceeded with this video.  * &#x60;total_cap_exceeded&#x60; - The user has exceeded their total cap with this video.  * &#x60;transcode_starting&#x60; - Transcoding is beginning for the video.  * &#x60;transcoding&#x60; - Transcoding is underway for the video.  * &#x60;transcoding_error&#x60; - There was an error in transcoding the video.  * &#x60;unavailable&#x60; - The video is unavailable.  * &#x60;uploading&#x60; - The video is being uploaded.  * &#x60;uploading_error&#x60; - There was an error in uploading the video.  | 
**Tags** | [**List&lt;Tag&gt;**](Tag.md) | An array of all tags assigned to this video. | 
**Transcode** | [**VideoTranscode**](VideoTranscode.md) |  | 
**Type** | **string** | The type of the video.  Option descriptions:  * &#x60;live&#x60; - The video is or was a live event.  * &#x60;stock&#x60; - The video is a Vimeo Stock video.  * &#x60;video&#x60; - The video is a standard Vimeo video.  | 
**Upload** | [**VideoUpload**](VideoUpload.md) |  | 
**Uri** | **string** | The video&#39;s canonical relative URI. | 
**User** | [**User**](User.md) | The video owner. | 
**Width** | **decimal** | The video&#39;s width in pixels. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


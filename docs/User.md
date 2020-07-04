# VimeoOpenApi.Model.User
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | The user&#39;s account type:  Option descriptions:  * &#x60;basic&#x60; - The user has a Vimeo Basic subscription.  * &#x60;business&#x60; - The user has a Vimeo Business subscription.  * &#x60;live_business&#x60; - The user has a Vimeo Business Live subscription.  * &#x60;live_premium&#x60; - The user has a Vimeo Premium subscription.  * &#x60;live_pro&#x60; - The user has a Vimeo PRO Live subscription.  * &#x60;plus&#x60; - The user has a Vimeo Plus subscription.  * &#x60;pro&#x60; - The user has a Vimeo Pro subscription.  * &#x60;pro_unlimited&#x60; - The user has a Vimeo PRO Unlimited subscription.  * &#x60;producer&#x60; - The user has a Vimeo Producer subscription.  | 
**AvailableForHire** | **bool** | Whether the user is available for hire. | 
**Bio** | **string** | The user&#39;s long bio text. | 
**CanWorkRemotely** | **bool** | Whether the user can work remotely. | 
**ContentFilter** | **List&lt;string&gt;** | The authenticated user&#39;s content filters.  Option descriptions:  * &#x60;drugs&#x60; - Drugs or alcohol use.  * &#x60;language&#x60; - Profanity or sexually suggestive content.  * &#x60;nudity&#x60; - Nudity.  * &#x60;safe&#x60; - Suitable for all audiences.  * &#x60;unrated&#x60; - No rating.  * &#x60;violence&#x60; - Violent or graphic content.  | [optional] 
**CreatedTime** | **string** | The time in ISO 8601 format when the user account was created. | 
**Gender** | **string** | The authenticated user&#39;s gender | 
**Link** | **string** | The absolute URL of the authenticated users&#39;s profile page. | 
**Location** | **string** | The authenticated user&#39;s location. | 
**Metadata** | [**UserMetadata**](UserMetadata.md) |  | 
**Name** | **string** | The authenticated user&#39;s display name. | 
**Pictures** | [**Picture**](Picture.md) | The active portrait of the authenticated user. | 
**Preferences** | [**UserPreferences**](UserPreferences.md) |  | [optional] 
**ResourceKey** | **string** | The authenticated user&#39;s resource key string. | 
**ShortBio** | **string** | The user&#39;s short bio text. | 
**Skills** | [**List&lt;Skill&gt;**](Skill.md) | A list of the user&#39;s skills. | 
**UploadQuota** | [**UserUploadQuota**](UserUploadQuota.md) |  | 
**Uri** | **string** | The authenticated user&#39;s canonical relative URI. | 
**Websites** | [**List&lt;UserWebsites&gt;**](UserWebsites.md) | The authenticated user&#39;s websites. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


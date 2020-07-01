# VimeoOpenApi.Model.ChannelMetadataInteractionsFollow
An action indicating if the authenticated user has followed this channel. This data requires a bearer token with the `private` scope.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Added** | **bool** | Whether the authenticated user has followed this channel. This data requires a bearer token with the &#x60;private&#x60; scope. | 
**AddedTime** | **string** | The time in ISO 8601 format that the user followed this channel, or the null value if the user hasn&#39;t followed the channel. This data requires a bearer token with the &#x60;private&#x60; scope. | 
**Type** | **string** | Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;moderator&#x60; - The authenticated user is a moderator.  * &#x60;subscriber&#x60; - The authenticated user is a subscriber.  | 
**Uri** | **string** | The URI for following or unfollowing this channel. PUT to this URI to follow the channel, or DELETE to this URI to unfollow the channel. This data requires a bearer token with the &#x60;private&#x60; scope. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# VimeoOpenApi.Model.GroupMetadataInteractionsJoin
An action indicating that someone has joined the group. This data requires a bearer token with the `private` scope.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Added** | **bool** | Whether the authenticated user has followed the group. This data requires a bearer token with the &#x60;private&#x60; scope. | 
**AddedTime** | **string** | The time in ISO 8601 format when the authenticated user joined the group. This data requires a bearer token with the &#x60;private&#x60; scope. | 
**Title** | **string** | The authenticated user&#39;s title. If not applicable, this field takes the null value. This data requires a bearer token with the &#x60;private&#x60; scope. | 
**Type** | **string** | Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;member&#x60; - The authenticated user is a member.  * &#x60;moderator&#x60; - The authenticated user is a moderator.  | 
**Uri** | **string** | The URI for following the group. PUT to this URI to follow the group, or DELETE to this URI to unfollow the group. This data requires a bearer token with the &#x60;private&#x60; scope. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


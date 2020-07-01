# VimeoOpenApi.Model.InlineObject17
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BrandColor** | **string** | The hexadecimal code for the color of the player buttons and showcase controls. | [optional] 
**Description** | **string** | The description of the showcase. | [optional] 
**Domain** | **string** | The custom domain of the showcase. | [optional] 
**HideNav** | **bool** | Whether to hide Vimeo navigation when displaying the showcase. | [optional] 
**HideUpcoming** | **bool** | Whether to include the upcoming live event in the showcase. | [optional] 
**Layout** | **string** | The type of layout for presenting the showcase.  Option descriptions:  * &#x60;grid&#x60; - The videos appear in a grid.  * &#x60;player&#x60; - The videos appear in the player.  | [optional] 
**Name** | **string** | The name of the showcase. | [optional] 
**Password** | **string** | The showcase&#39;s password. This field is required only when **privacy** is &#x60;password&#x60;. | [optional] 
**Privacy** | **string** | The privacy level of the showcase.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the showcase, either on Vimeo or through an embed.  * &#x60;embed_only&#x60; - The showcase doesn&#39;t appear on Vimeo, but it can be embedded on other sites.  * &#x60;nobody&#x60; - No one can access the showcase, including the authenticated user.  * &#x60;password&#x60; - Only people with the password can access the showcase.  * &#x60;team&#x60; - Only members of the authenticated user&#39;s team can access the showcase.  | [optional] 
**ReviewMode** | **bool** | Whether showcase videos use the review mode URL. | [optional] 
**Sort** | **string** | The default sort order of the videos as they appear in the showcase.  Option descriptions:  * &#x60;added_first&#x60; - The videos appear according to when they were added to the showcase, with the most recently added first.  * &#x60;added_last&#x60; - The videos appear according to when they were added to the showcase, with the most recently added last.  * &#x60;alphabetical&#x60; - The videos appear alphabetically by their title.  * &#x60;arranged&#x60; - The videos appear as arranged by the owner of the showcase.  * &#x60;comments&#x60; - The videos appear according to their number of comments.  * &#x60;likes&#x60; - The videos appear according to their number of likes.  * &#x60;newest&#x60; - The videos appear in chronological order with the newest first.  * &#x60;oldest&#x60; - The videos appear in chronological order with the oldest first.  * &#x60;plays&#x60; - The videos appear according to their number of plays.  | [optional] 
**Theme** | **string** | The color theme of the showcase.  Option descriptions:  * &#x60;dark&#x60; - The showcase uses the dark theme.  * &#x60;standard&#x60; - The showcase uses the standard theme.  | [optional] 
**Url** | **string** | The custom Vimeo URL of the showcase. | [optional] 
**UseCustomDomain** | **bool** | Whether the user has opted for a custom domain for their showcase. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


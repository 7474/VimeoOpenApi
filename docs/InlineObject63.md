# VimeoOpenApi.Model.InlineObject63
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Whether the current text track is the *active text track,* or the one that appears in the player. Only one text track per language and per type can be active. | [optional] 
**Language** | **string** | The language of the text track. For a full list of supported languages, use the [&#x60;/languages?filter&#x3D;texttracks&#x60;](https://developer.vimeo.com/api/reference/videos#get_languages) endpoint. | [optional] 
**Name** | **string** | The name of the text track. | [optional] 
**Type** | **string** | The type of the text track.  Option descriptions:  * &#x60;captions&#x60; - The text track is the captions type.  * &#x60;chapters&#x60; - The text track is the chapters type.  * &#x60;descriptions&#x60; - The text track is the descriptions type.  * &#x60;metadata&#x60; - The text track is the metadata type.  * &#x60;subtitles&#x60; - The text track is the subtitles type.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


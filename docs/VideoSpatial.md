# VimeoOpenApi.Model.VideoSpatial
360 spatial data.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DirectorTimeline** | [**List&lt;VideoSpatialDirectorTimeline&gt;**](VideoSpatialDirectorTimeline.md) | 360 director timeline. | 
**FieldOfView** | **decimal?** | The 360 field of view, from 30 (minimum) to 90 (maximum). The default is 50. | 
**Projection** | **string** | The 360 spatial projection:  Option descriptions:  * &#x60;cubical&#x60; - The spatial projection is cubical.  * &#x60;cylindrical&#x60; - The spatial projection is cylindrical.  * &#x60;dome&#x60; - The spatial projection is dome-shaped.  * &#x60;equirectangular&#x60; - The spatial projection is equirectangular.  * &#x60;pyramid&#x60; - The spatial projection is pyramid-shaped.  | 
**StereoFormat** | **string** | The 360 stereo format:  Option descriptions:  * &#x60;left-right&#x60; - The stereo format is left-right.  * &#x60;mono&#x60; - The audio is monaural.  * &#x60;top-bottom&#x60; - The stereo format is top-bottom.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


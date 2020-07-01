# VimeoOpenApi.Model.Category
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Icon** | [**Picture**](Picture.md) | The active icon for the category. | [optional] 
**LastVideoFeaturedTime** | **string** | The most recent time in ISO 8601 format when the video was featured. | 
**Link** | **string** | The URL to access the category in a browser. | 
**Metadata** | [**CategoryMetadata**](CategoryMetadata.md) |  | 
**Name** | **string** | The display name that identifies the category. | 
**Parent** | [**CategoryParent**](CategoryParent.md) |  | 
**Pictures** | [**Picture**](Picture.md) | The active picture for this category. The default shows vertical color bars. | 
**ResourceKey** | **string** | The resource key of the category. | 
**Subcategories** | [**List&lt;CategorySubcategories&gt;**](CategorySubcategories.md) | All the subcategories that belong to the category, if the current category is a top-level parent. | [optional] 
**TopLevel** | **bool** | Whether the category isn&#39;t a subcategory of another category. | 
**Uri** | **string** | The unique identifier to access the category resource. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


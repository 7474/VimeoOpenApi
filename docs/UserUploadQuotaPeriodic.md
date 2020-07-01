# VimeoOpenApi.Model.UserUploadQuotaPeriodic
Information about the authenticated user's usage for the current period.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Free** | **decimal?** | The number of bytes remaining in the authenticated user&#39;s upload quota for the current period. | 
**Max** | **decimal?** | The total number of bytes that the authenticated user can upload per period. | 
**ResetDate** | **string** | The time in ISO 8601 format when the authenticated user&#39;s upload quota resets. | 
**Used** | **decimal?** | The number of bytes that the authenticated user has already uploaded against their quota in the current period. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


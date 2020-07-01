# VimeoOpenApi.Model.InlineObject33
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessType** | **string** | The promotion access type, which is a purchase option that isn&#39;t available in the On Demand container. Use the **download** and **stream_period** fields to define additional characteristics for the &#x60;vip&#x60; type.  Option descriptions:  * &#x60;default&#x60; - The promotion grants a discount on the existing purchase options for an On Demand container.  * &#x60;vip&#x60; - The promotion grants free access to On Demand content before it&#39;s released.  | [optional] 
**Code** | **string** | The promotion code. This field is ignored for batch promotions. | [optional] 
**DiscountType** | **string** | The type of discount offered by the promo code. When &#x60;access_type&#x60; is &#x60;vip&#x60;, the value of this field must be &#x60;free&#x60;.  Option descriptions:  * &#x60;free&#x60; - This option reduces the price to zero.  * &#x60;percent&#x60; - This option reduces the price by the percentage defined in the **percent_off** field.  | [optional] 
**Download** | **bool** | Whether the promotion grants download access to On Demand content. This is necessary only when not previously defined in the On Demand container or when **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;buy&#x60;. | 
**EndTime** | **string** | The end of the promotion period. If this field has no value, the promotion never expires. | [optional] 
**Label** | **string** | For batch promotions, the description of the promotion. This field is ignored for single promotions. | [optional] 
**PercentOff** | **decimal** | The percentage of the discount. This field is applicable only when **discount_type** is &#x60;percent&#x60;. | [optional] 
**ProductType** | **string** | The type of transaction to which the promotion applies. When **access_type** is &#x60;default&#x60;, the default value is &#x60;any&#x60;. When **access_type** is &#x60;vip&#x60;, the default value is &#x60;rent&#x60;. Also, when **access_type** is &#x60;vip&#x60;, the only valid product types are &#x60;buy&#x60; and &#x60;rent&#x60;. | [optional] 
**StartTime** | **string** | The start of the promotion period. If this field has no value, the start time defaults to the time that the promotion was created. | [optional] 
**StreamPeriod** | **string** | The amount of time that a user has access to On Demand content upon redeeming a promo code. This field is necessary only when not defined in the On Demand container or when creating promotions where **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;rent&#x60;. | 
**Total** | **decimal** | When **type** is &#x60;batch&#x60;, the number of promotions to generate. When **type** is &#x60;single&#x60;, the number of uses of the promotion. | 
**Type** | **string** | The type of the promotion. When **access_type** is &#x60;vip&#x60;, the value for this field must be &#x60;batch&#x60;.  Option descriptions:  * &#x60;batch&#x60; - This option generates many random promo codes with one use each.  * &#x60;single&#x60; - This option generates one promo code that can be used many times.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


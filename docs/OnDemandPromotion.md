# VimeoOpenApi.Model.OnDemandPromotion
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessType** | **string** | The type of access that the promotion grants.  Option descriptions:  * &#x60;default&#x60; - The promotion grants discounts on existing product offerings.  * &#x60;vip&#x60; - The promotion grants free access to On Demand content before it is released or to access types that aren&#39;t part of the existing product offerings.  | 
**DiscountType** | **string** | The type of discount that the promotion provides.  Option descriptions:  * &#x60;dollars&#x60; - The promotion discounts a fixed amount from the full purchase price.  * &#x60;free&#x60; - The promotion discounts the full purchase price. When **access_type** is &#x60;vip&#x60;, **discount_type** is always &#x60;free&#x60;.  * &#x60;percent&#x60; - The promotion discounts a percentage of the full purchase price.  | 
**Download** | **bool** | Whether the promotion grants download access to On Demand content. | 
**Label** | **string** | The prefix string for batch codes, or the null value for single codes. | 
**Metadata** | [**OnDemandPromotionMetadata**](OnDemandPromotionMetadata.md) |  | 
**PercentOff** | **decimal** | When **discount_type** is &#x60;percent&#x60;, the percentage amount that is deducted from the product price. | 
**ProductType** | **string** | The type of product to which the promotion can be applied. Only the &#x60;buy&#x60; and &#x60;rent&#x60; options are available when **access_type** is &#x60;vip&#x60;.  Option descriptions:  * &#x60;any&#x60; - The promotion can be applied to any product.  * &#x60;buy&#x60; - The promotion can be applied to a buyable single video.  * &#x60;buy_episode&#x60; - The promotion can be applied to a buyable single episode.  * &#x60;rent&#x60; - The promotion can be applied to a rentable single video.  * &#x60;rent_episode&#x60; - The promotion can be applied to a rentable single episode.  * &#x60;subscribe&#x60; - The promotion can be applied to a subscription.  | 
**StreamPeriod** | **string** | The amount of time that the user has access to the On Demand content after redeeming a promo code.  Option descriptions:  * &#x60;1_week&#x60; - Access lasts for one week.  * &#x60;1_year&#x60; - Access lasts for one year.  * &#x60;24_hour&#x60; - Access lasts for 24 hours.  * &#x60;30_days&#x60; - Access lasts for 30 days.  * &#x60;3_month&#x60; - Access lasts for three months.  * &#x60;48_hour&#x60; - Access lasts for 48 hours.  * &#x60;6_month&#x60; - Access lasts for six months.  * &#x60;72_hour&#x60; - Access lasts for 72 hours.  | 
**Total** | **decimal** | When **type** is &#x60;single&#x60;, the total number of times that the promotion can be used. When **type** is &#x60;batch&#x60; or &#x60;batch_prefix&#x60;, the total number of promo codes that have been generated. | 
**Type** | **string** | The way in which the promotion generates promo codes.  Option descriptions:  * &#x60;batch&#x60; - The promotion provides a unique promo code for each user.  * &#x60;batch_prefix&#x60; - Like &#x60;batch&#x60;, except that all codes have a similar prefix string. This option is deprecated, yet it may still appear for some users.  * &#x60;single&#x60; - The promotion provides a single promo code for all users.  | 
**Uri** | **string** | The promotion&#39;s canonical relative URI. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


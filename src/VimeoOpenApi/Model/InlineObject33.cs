/* 
 * Vimeo API
 *
 * Build something great. Vimeo's API supports flexible, high-quality video integration with your custom apps.
 *
 * The version of the OpenAPI document: 3.4
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = VimeoOpenApi.Client.OpenAPIDateConverter;

namespace VimeoOpenApi.Model
{
    /// <summary>
    /// InlineObject33
    /// </summary>
    [DataContract]
    public partial class InlineObject33 :  IEquatable<InlineObject33>, IValidatableObject
    {
        /// <summary>
        /// The promotion access type, which is a purchase option that isn&#39;t available in the On Demand container. Use the **download** and **stream_period** fields to define additional characteristics for the &#x60;vip&#x60; type.  Option descriptions:  * &#x60;default&#x60; - The promotion grants a discount on the existing purchase options for an On Demand container.  * &#x60;vip&#x60; - The promotion grants free access to On Demand content before it&#39;s released. 
        /// </summary>
        /// <value>The promotion access type, which is a purchase option that isn&#39;t available in the On Demand container. Use the **download** and **stream_period** fields to define additional characteristics for the &#x60;vip&#x60; type.  Option descriptions:  * &#x60;default&#x60; - The promotion grants a discount on the existing purchase options for an On Demand container.  * &#x60;vip&#x60; - The promotion grants free access to On Demand content before it&#39;s released. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessTypeEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,

            /// <summary>
            /// Enum Vip for value: vip
            /// </summary>
            [EnumMember(Value = "vip")]
            Vip = 2

        }

        /// <summary>
        /// The promotion access type, which is a purchase option that isn&#39;t available in the On Demand container. Use the **download** and **stream_period** fields to define additional characteristics for the &#x60;vip&#x60; type.  Option descriptions:  * &#x60;default&#x60; - The promotion grants a discount on the existing purchase options for an On Demand container.  * &#x60;vip&#x60; - The promotion grants free access to On Demand content before it&#39;s released. 
        /// </summary>
        /// <value>The promotion access type, which is a purchase option that isn&#39;t available in the On Demand container. Use the **download** and **stream_period** fields to define additional characteristics for the &#x60;vip&#x60; type.  Option descriptions:  * &#x60;default&#x60; - The promotion grants a discount on the existing purchase options for an On Demand container.  * &#x60;vip&#x60; - The promotion grants free access to On Demand content before it&#39;s released. </value>
        [DataMember(Name="access_type", EmitDefaultValue=false)]
        public AccessTypeEnum? AccessType { get; set; }
        /// <summary>
        /// The type of discount offered by the promo code. When &#x60;access_type&#x60; is &#x60;vip&#x60;, the value of this field must be &#x60;free&#x60;.  Option descriptions:  * &#x60;free&#x60; - This option reduces the price to zero.  * &#x60;percent&#x60; - This option reduces the price by the percentage defined in the **percent_off** field. 
        /// </summary>
        /// <value>The type of discount offered by the promo code. When &#x60;access_type&#x60; is &#x60;vip&#x60;, the value of this field must be &#x60;free&#x60;.  Option descriptions:  * &#x60;free&#x60; - This option reduces the price to zero.  * &#x60;percent&#x60; - This option reduces the price by the percentage defined in the **percent_off** field. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiscountTypeEnum
        {
            /// <summary>
            /// Enum Free for value: free
            /// </summary>
            [EnumMember(Value = "free")]
            Free = 1,

            /// <summary>
            /// Enum Percent for value: percent
            /// </summary>
            [EnumMember(Value = "percent")]
            Percent = 2

        }

        /// <summary>
        /// The type of discount offered by the promo code. When &#x60;access_type&#x60; is &#x60;vip&#x60;, the value of this field must be &#x60;free&#x60;.  Option descriptions:  * &#x60;free&#x60; - This option reduces the price to zero.  * &#x60;percent&#x60; - This option reduces the price by the percentage defined in the **percent_off** field. 
        /// </summary>
        /// <value>The type of discount offered by the promo code. When &#x60;access_type&#x60; is &#x60;vip&#x60;, the value of this field must be &#x60;free&#x60;.  Option descriptions:  * &#x60;free&#x60; - This option reduces the price to zero.  * &#x60;percent&#x60; - This option reduces the price by the percentage defined in the **percent_off** field. </value>
        [DataMember(Name="discount_type", EmitDefaultValue=false)]
        public DiscountTypeEnum? DiscountType { get; set; }
        /// <summary>
        /// The type of transaction to which the promotion applies. When **access_type** is &#x60;default&#x60;, the default value is &#x60;any&#x60;. When **access_type** is &#x60;vip&#x60;, the default value is &#x60;rent&#x60;. Also, when **access_type** is &#x60;vip&#x60;, the only valid product types are &#x60;buy&#x60; and &#x60;rent&#x60;.
        /// </summary>
        /// <value>The type of transaction to which the promotion applies. When **access_type** is &#x60;default&#x60;, the default value is &#x60;any&#x60;. When **access_type** is &#x60;vip&#x60;, the default value is &#x60;rent&#x60;. Also, when **access_type** is &#x60;vip&#x60;, the only valid product types are &#x60;buy&#x60; and &#x60;rent&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductTypeEnum
        {
            /// <summary>
            /// Enum Any for value: any
            /// </summary>
            [EnumMember(Value = "any")]
            Any = 1,

            /// <summary>
            /// Enum Buy for value: buy
            /// </summary>
            [EnumMember(Value = "buy")]
            Buy = 2,

            /// <summary>
            /// Enum Buyepisode for value: buy_episode
            /// </summary>
            [EnumMember(Value = "buy_episode")]
            Buyepisode = 3,

            /// <summary>
            /// Enum Rent for value: rent
            /// </summary>
            [EnumMember(Value = "rent")]
            Rent = 4,

            /// <summary>
            /// Enum Rentepisode for value: rent_episode
            /// </summary>
            [EnumMember(Value = "rent_episode")]
            Rentepisode = 5,

            /// <summary>
            /// Enum Subscribe for value: subscribe
            /// </summary>
            [EnumMember(Value = "subscribe")]
            Subscribe = 6

        }

        /// <summary>
        /// The type of transaction to which the promotion applies. When **access_type** is &#x60;default&#x60;, the default value is &#x60;any&#x60;. When **access_type** is &#x60;vip&#x60;, the default value is &#x60;rent&#x60;. Also, when **access_type** is &#x60;vip&#x60;, the only valid product types are &#x60;buy&#x60; and &#x60;rent&#x60;.
        /// </summary>
        /// <value>The type of transaction to which the promotion applies. When **access_type** is &#x60;default&#x60;, the default value is &#x60;any&#x60;. When **access_type** is &#x60;vip&#x60;, the default value is &#x60;rent&#x60;. Also, when **access_type** is &#x60;vip&#x60;, the only valid product types are &#x60;buy&#x60; and &#x60;rent&#x60;.</value>
        [DataMember(Name="product_type", EmitDefaultValue=false)]
        public ProductTypeEnum? ProductType { get; set; }
        /// <summary>
        /// The amount of time that a user has access to On Demand content upon redeeming a promo code. This field is necessary only when not defined in the On Demand container or when creating promotions where **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;rent&#x60;.
        /// </summary>
        /// <value>The amount of time that a user has access to On Demand content upon redeeming a promo code. This field is necessary only when not defined in the On Demand container or when creating promotions where **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;rent&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StreamPeriodEnum
        {
            /// <summary>
            /// Enum _1week for value: 1_week
            /// </summary>
            [EnumMember(Value = "1_week")]
            _1week = 1,

            /// <summary>
            /// Enum _1year for value: 1_year
            /// </summary>
            [EnumMember(Value = "1_year")]
            _1year = 2,

            /// <summary>
            /// Enum _24hour for value: 24_hour
            /// </summary>
            [EnumMember(Value = "24_hour")]
            _24hour = 3,

            /// <summary>
            /// Enum _30day for value: 30_day
            /// </summary>
            [EnumMember(Value = "30_day")]
            _30day = 4,

            /// <summary>
            /// Enum _3month for value: 3_month
            /// </summary>
            [EnumMember(Value = "3_month")]
            _3month = 5,

            /// <summary>
            /// Enum _48hour for value: 48_hour
            /// </summary>
            [EnumMember(Value = "48_hour")]
            _48hour = 6,

            /// <summary>
            /// Enum _6month for value: 6_month
            /// </summary>
            [EnumMember(Value = "6_month")]
            _6month = 7,

            /// <summary>
            /// Enum _72hour for value: 72_hour
            /// </summary>
            [EnumMember(Value = "72_hour")]
            _72hour = 8

        }

        /// <summary>
        /// The amount of time that a user has access to On Demand content upon redeeming a promo code. This field is necessary only when not defined in the On Demand container or when creating promotions where **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;rent&#x60;.
        /// </summary>
        /// <value>The amount of time that a user has access to On Demand content upon redeeming a promo code. This field is necessary only when not defined in the On Demand container or when creating promotions where **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;rent&#x60;.</value>
        [DataMember(Name="stream_period", EmitDefaultValue=false)]
        public StreamPeriodEnum StreamPeriod { get; set; }
        /// <summary>
        /// The type of the promotion. When **access_type** is &#x60;vip&#x60;, the value for this field must be &#x60;batch&#x60;.  Option descriptions:  * &#x60;batch&#x60; - This option generates many random promo codes with one use each.  * &#x60;single&#x60; - This option generates one promo code that can be used many times. 
        /// </summary>
        /// <value>The type of the promotion. When **access_type** is &#x60;vip&#x60;, the value for this field must be &#x60;batch&#x60;.  Option descriptions:  * &#x60;batch&#x60; - This option generates many random promo codes with one use each.  * &#x60;single&#x60; - This option generates one promo code that can be used many times. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Batch for value: batch
            /// </summary>
            [EnumMember(Value = "batch")]
            Batch = 1,

            /// <summary>
            /// Enum Single for value: single
            /// </summary>
            [EnumMember(Value = "single")]
            Single = 2

        }

        /// <summary>
        /// The type of the promotion. When **access_type** is &#x60;vip&#x60;, the value for this field must be &#x60;batch&#x60;.  Option descriptions:  * &#x60;batch&#x60; - This option generates many random promo codes with one use each.  * &#x60;single&#x60; - This option generates one promo code that can be used many times. 
        /// </summary>
        /// <value>The type of the promotion. When **access_type** is &#x60;vip&#x60;, the value for this field must be &#x60;batch&#x60;.  Option descriptions:  * &#x60;batch&#x60; - This option generates many random promo codes with one use each.  * &#x60;single&#x60; - This option generates one promo code that can be used many times. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject33" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject33() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject33" /> class.
        /// </summary>
        /// <param name="accessType">The promotion access type, which is a purchase option that isn&#39;t available in the On Demand container. Use the **download** and **stream_period** fields to define additional characteristics for the &#x60;vip&#x60; type.  Option descriptions:  * &#x60;default&#x60; - The promotion grants a discount on the existing purchase options for an On Demand container.  * &#x60;vip&#x60; - The promotion grants free access to On Demand content before it&#39;s released. .</param>
        /// <param name="code">The promotion code. This field is ignored for batch promotions..</param>
        /// <param name="discountType">The type of discount offered by the promo code. When &#x60;access_type&#x60; is &#x60;vip&#x60;, the value of this field must be &#x60;free&#x60;.  Option descriptions:  * &#x60;free&#x60; - This option reduces the price to zero.  * &#x60;percent&#x60; - This option reduces the price by the percentage defined in the **percent_off** field. .</param>
        /// <param name="download">Whether the promotion grants download access to On Demand content. This is necessary only when not previously defined in the On Demand container or when **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;buy&#x60;. (required).</param>
        /// <param name="endTime">The end of the promotion period. If this field has no value, the promotion never expires..</param>
        /// <param name="label">For batch promotions, the description of the promotion. This field is ignored for single promotions..</param>
        /// <param name="percentOff">The percentage of the discount. This field is applicable only when **discount_type** is &#x60;percent&#x60;..</param>
        /// <param name="productType">The type of transaction to which the promotion applies. When **access_type** is &#x60;default&#x60;, the default value is &#x60;any&#x60;. When **access_type** is &#x60;vip&#x60;, the default value is &#x60;rent&#x60;. Also, when **access_type** is &#x60;vip&#x60;, the only valid product types are &#x60;buy&#x60; and &#x60;rent&#x60;..</param>
        /// <param name="startTime">The start of the promotion period. If this field has no value, the start time defaults to the time that the promotion was created..</param>
        /// <param name="streamPeriod">The amount of time that a user has access to On Demand content upon redeeming a promo code. This field is necessary only when not defined in the On Demand container or when creating promotions where **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;rent&#x60;. (required).</param>
        /// <param name="total">When **type** is &#x60;batch&#x60;, the number of promotions to generate. When **type** is &#x60;single&#x60;, the number of uses of the promotion. (required).</param>
        /// <param name="type">The type of the promotion. When **access_type** is &#x60;vip&#x60;, the value for this field must be &#x60;batch&#x60;.  Option descriptions:  * &#x60;batch&#x60; - This option generates many random promo codes with one use each.  * &#x60;single&#x60; - This option generates one promo code that can be used many times.  (required).</param>
        public InlineObject33(AccessTypeEnum? accessType = default(AccessTypeEnum?), string code = default(string), DiscountTypeEnum? discountType = default(DiscountTypeEnum?), bool download = default(bool), string endTime = default(string), string label = default(string), decimal percentOff = default(decimal), ProductTypeEnum? productType = default(ProductTypeEnum?), string startTime = default(string), StreamPeriodEnum streamPeriod = default(StreamPeriodEnum), decimal total = default(decimal), TypeEnum type = default(TypeEnum))
        {
            this.Download = download;
            this.StreamPeriod = streamPeriod;
            this.Total = total;
            this.Type = type;
            this.AccessType = accessType;
            this.Code = code;
            this.DiscountType = discountType;
            this.EndTime = endTime;
            this.Label = label;
            this.PercentOff = percentOff;
            this.ProductType = productType;
            this.StartTime = startTime;
        }
        
        /// <summary>
        /// The promotion code. This field is ignored for batch promotions.
        /// </summary>
        /// <value>The promotion code. This field is ignored for batch promotions.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Whether the promotion grants download access to On Demand content. This is necessary only when not previously defined in the On Demand container or when **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;buy&#x60;.
        /// </summary>
        /// <value>Whether the promotion grants download access to On Demand content. This is necessary only when not previously defined in the On Demand container or when **access_type** is &#x60;vip&#x60; or **product_type** is &#x60;buy&#x60;.</value>
        [DataMember(Name="download", EmitDefaultValue=false)]
        public bool Download { get; set; }

        /// <summary>
        /// The end of the promotion period. If this field has no value, the promotion never expires.
        /// </summary>
        /// <value>The end of the promotion period. If this field has no value, the promotion never expires.</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// For batch promotions, the description of the promotion. This field is ignored for single promotions.
        /// </summary>
        /// <value>For batch promotions, the description of the promotion. This field is ignored for single promotions.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// The percentage of the discount. This field is applicable only when **discount_type** is &#x60;percent&#x60;.
        /// </summary>
        /// <value>The percentage of the discount. This field is applicable only when **discount_type** is &#x60;percent&#x60;.</value>
        [DataMember(Name="percent_off", EmitDefaultValue=false)]
        public decimal PercentOff { get; set; }

        /// <summary>
        /// The start of the promotion period. If this field has no value, the start time defaults to the time that the promotion was created.
        /// </summary>
        /// <value>The start of the promotion period. If this field has no value, the start time defaults to the time that the promotion was created.</value>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// When **type** is &#x60;batch&#x60;, the number of promotions to generate. When **type** is &#x60;single&#x60;, the number of uses of the promotion.
        /// </summary>
        /// <value>When **type** is &#x60;batch&#x60;, the number of promotions to generate. When **type** is &#x60;single&#x60;, the number of uses of the promotion.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject33 {\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  PercentOff: ").Append(PercentOff).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StreamPeriod: ").Append(StreamPeriod).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineObject33);
        }

        /// <summary>
        /// Returns true if InlineObject33 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject33 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject33 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessType == input.AccessType ||
                    this.AccessType.Equals(input.AccessType)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.DiscountType == input.DiscountType ||
                    this.DiscountType.Equals(input.DiscountType)
                ) && 
                (
                    this.Download == input.Download ||
                    this.Download.Equals(input.Download)
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.PercentOff == input.PercentOff ||
                    this.PercentOff.Equals(input.PercentOff)
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    this.ProductType.Equals(input.ProductType)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.StreamPeriod == input.StreamPeriod ||
                    this.StreamPeriod.Equals(input.StreamPeriod)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.AccessType.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                hashCode = hashCode * 59 + this.Download.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                hashCode = hashCode * 59 + this.PercentOff.GetHashCode();
                hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                hashCode = hashCode * 59 + this.StreamPeriod.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

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
    /// The Rent interaction for an On Demand video.
    /// </summary>
    [DataContract]
    public partial class VideoMetadataInteractionsRent :  IEquatable<VideoMetadataInteractionsRent>, IValidatableObject
    {
        /// <summary>
        /// The user&#39;s streaming access to this On Demand video:  Option descriptions:  * &#x60;available&#x60; - The video is available for streaming.  * &#x60;purchased&#x60; - The user has purchased the video.  * &#x60;restricted&#x60; - The user isn&#39;t permitted to stream the video.  * &#x60;unavailable&#x60; - The video isn&#39;t available for streaming. 
        /// </summary>
        /// <value>The user&#39;s streaming access to this On Demand video:  Option descriptions:  * &#x60;available&#x60; - The video is available for streaming.  * &#x60;purchased&#x60; - The user has purchased the video.  * &#x60;restricted&#x60; - The user isn&#39;t permitted to stream the video.  * &#x60;unavailable&#x60; - The video isn&#39;t available for streaming. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StreamEnum
        {
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 1,

            /// <summary>
            /// Enum Purchased for value: purchased
            /// </summary>
            [EnumMember(Value = "purchased")]
            Purchased = 2,

            /// <summary>
            /// Enum Restricted for value: restricted
            /// </summary>
            [EnumMember(Value = "restricted")]
            Restricted = 3,

            /// <summary>
            /// Enum Unavailable for value: unavailable
            /// </summary>
            [EnumMember(Value = "unavailable")]
            Unavailable = 4

        }

        /// <summary>
        /// The user&#39;s streaming access to this On Demand video:  Option descriptions:  * &#x60;available&#x60; - The video is available for streaming.  * &#x60;purchased&#x60; - The user has purchased the video.  * &#x60;restricted&#x60; - The user isn&#39;t permitted to stream the video.  * &#x60;unavailable&#x60; - The video isn&#39;t available for streaming. 
        /// </summary>
        /// <value>The user&#39;s streaming access to this On Demand video:  Option descriptions:  * &#x60;available&#x60; - The video is available for streaming.  * &#x60;purchased&#x60; - The user has purchased the video.  * &#x60;restricted&#x60; - The user isn&#39;t permitted to stream the video.  * &#x60;unavailable&#x60; - The video isn&#39;t available for streaming. </value>
        [DataMember(Name="stream", EmitDefaultValue=false)]
        public StreamEnum Stream { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataInteractionsRent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoMetadataInteractionsRent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataInteractionsRent" /> class.
        /// </summary>
        /// <param name="currency">The currency code for the current user&#39;s region. (required).</param>
        /// <param name="displayPrice">Formatted price to display to rent an On Demand video. (required).</param>
        /// <param name="drm">Whether the video has DRM. (required).</param>
        /// <param name="expiresTime">The time in ISO 8601 format when the rental period for the video expires. (required).</param>
        /// <param name="link">The URL to rent the On Demand video on Vimeo. (required).</param>
        /// <param name="price">The numeric value of the price for buying the On Demand video. (required).</param>
        /// <param name="purchaseTime">The time in ISO 8601 format when the On Demand video was rented. (required).</param>
        /// <param name="stream">The user&#39;s streaming access to this On Demand video:  Option descriptions:  * &#x60;available&#x60; - The video is available for streaming.  * &#x60;purchased&#x60; - The user has purchased the video.  * &#x60;restricted&#x60; - The user isn&#39;t permitted to stream the video.  * &#x60;unavailable&#x60; - The video isn&#39;t available for streaming.  (required).</param>
        /// <param name="uri">The product URI to rent the On Demand video. (required).</param>
        public VideoMetadataInteractionsRent(string currency = default(string), string displayPrice = default(string), bool drm = default(bool), string expiresTime = default(string), string link = default(string), decimal? price = default(decimal?), string purchaseTime = default(string), StreamEnum stream = default(StreamEnum), string uri = default(string))
        {
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency is a required property for VideoMetadataInteractionsRent and cannot be null");
            // to ensure "displayPrice" is required (not null)
            this.DisplayPrice = displayPrice ?? throw new ArgumentNullException("displayPrice is a required property for VideoMetadataInteractionsRent and cannot be null");
            this.Drm = drm;
            // to ensure "expiresTime" is required (not null)
            this.ExpiresTime = expiresTime ?? throw new ArgumentNullException("expiresTime is a required property for VideoMetadataInteractionsRent and cannot be null");
            // to ensure "link" is required (not null)
            this.Link = link ?? throw new ArgumentNullException("link is a required property for VideoMetadataInteractionsRent and cannot be null");
            // to ensure "price" is required (not null)
            this.Price = price ?? throw new ArgumentNullException("price is a required property for VideoMetadataInteractionsRent and cannot be null");
            // to ensure "purchaseTime" is required (not null)
            this.PurchaseTime = purchaseTime ?? throw new ArgumentNullException("purchaseTime is a required property for VideoMetadataInteractionsRent and cannot be null");
            this.Stream = stream;
            // to ensure "uri" is required (not null)
            this.Uri = uri ?? throw new ArgumentNullException("uri is a required property for VideoMetadataInteractionsRent and cannot be null");
        }
        
        /// <summary>
        /// The currency code for the current user&#39;s region.
        /// </summary>
        /// <value>The currency code for the current user&#39;s region.</value>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// Formatted price to display to rent an On Demand video.
        /// </summary>
        /// <value>Formatted price to display to rent an On Demand video.</value>
        [DataMember(Name="display_price", EmitDefaultValue=true)]
        public string DisplayPrice { get; set; }

        /// <summary>
        /// Whether the video has DRM.
        /// </summary>
        /// <value>Whether the video has DRM.</value>
        [DataMember(Name="drm", EmitDefaultValue=false)]
        public bool Drm { get; set; }

        /// <summary>
        /// The time in ISO 8601 format when the rental period for the video expires.
        /// </summary>
        /// <value>The time in ISO 8601 format when the rental period for the video expires.</value>
        [DataMember(Name="expires_time", EmitDefaultValue=true)]
        public string ExpiresTime { get; set; }

        /// <summary>
        /// The URL to rent the On Demand video on Vimeo.
        /// </summary>
        /// <value>The URL to rent the On Demand video on Vimeo.</value>
        [DataMember(Name="link", EmitDefaultValue=true)]
        public string Link { get; set; }

        /// <summary>
        /// The numeric value of the price for buying the On Demand video.
        /// </summary>
        /// <value>The numeric value of the price for buying the On Demand video.</value>
        [DataMember(Name="price", EmitDefaultValue=true)]
        public decimal? Price { get; set; }

        /// <summary>
        /// The time in ISO 8601 format when the On Demand video was rented.
        /// </summary>
        /// <value>The time in ISO 8601 format when the On Demand video was rented.</value>
        [DataMember(Name="purchase_time", EmitDefaultValue=true)]
        public string PurchaseTime { get; set; }

        /// <summary>
        /// The product URI to rent the On Demand video.
        /// </summary>
        /// <value>The product URI to rent the On Demand video.</value>
        [DataMember(Name="uri", EmitDefaultValue=true)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoMetadataInteractionsRent {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DisplayPrice: ").Append(DisplayPrice).Append("\n");
            sb.Append("  Drm: ").Append(Drm).Append("\n");
            sb.Append("  ExpiresTime: ").Append(ExpiresTime).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PurchaseTime: ").Append(PurchaseTime).Append("\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(input as VideoMetadataInteractionsRent);
        }

        /// <summary>
        /// Returns true if VideoMetadataInteractionsRent instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoMetadataInteractionsRent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoMetadataInteractionsRent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.DisplayPrice == input.DisplayPrice ||
                    (this.DisplayPrice != null &&
                    this.DisplayPrice.Equals(input.DisplayPrice))
                ) && 
                (
                    this.Drm == input.Drm ||
                    this.Drm.Equals(input.Drm)
                ) && 
                (
                    this.ExpiresTime == input.ExpiresTime ||
                    (this.ExpiresTime != null &&
                    this.ExpiresTime.Equals(input.ExpiresTime))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.PurchaseTime == input.PurchaseTime ||
                    (this.PurchaseTime != null &&
                    this.PurchaseTime.Equals(input.PurchaseTime))
                ) && 
                (
                    this.Stream == input.Stream ||
                    this.Stream.Equals(input.Stream)
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DisplayPrice != null)
                    hashCode = hashCode * 59 + this.DisplayPrice.GetHashCode();
                hashCode = hashCode * 59 + this.Drm.GetHashCode();
                if (this.ExpiresTime != null)
                    hashCode = hashCode * 59 + this.ExpiresTime.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.PurchaseTime != null)
                    hashCode = hashCode * 59 + this.PurchaseTime.GetHashCode();
                hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
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

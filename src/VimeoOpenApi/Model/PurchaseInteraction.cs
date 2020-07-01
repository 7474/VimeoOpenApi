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
    /// PurchaseInteraction
    /// </summary>
    [DataContract]
    public partial class PurchaseInteraction :  IEquatable<PurchaseInteraction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseInteraction" /> class.
        /// </summary>
        /// <param name="buy">buy.</param>
        /// <param name="rent">Information on renting this video..</param>
        /// <param name="subscribe">subscribe.</param>
        public PurchaseInteraction(PurchaseInteractionBuy buy = default(PurchaseInteractionBuy), Object rent = default(Object), PurchaseInteractionSubscribe subscribe = default(PurchaseInteractionSubscribe))
        {
            this.Buy = buy;
            this.Rent = rent;
            this.Subscribe = subscribe;
        }
        
        /// <summary>
        /// Gets or Sets Buy
        /// </summary>
        [DataMember(Name="buy", EmitDefaultValue=true)]
        public PurchaseInteractionBuy Buy { get; set; }

        /// <summary>
        /// Information on renting this video.
        /// </summary>
        /// <value>Information on renting this video.</value>
        [DataMember(Name="rent", EmitDefaultValue=true)]
        public Object Rent { get; set; }

        /// <summary>
        /// Gets or Sets Subscribe
        /// </summary>
        [DataMember(Name="subscribe", EmitDefaultValue=true)]
        public PurchaseInteractionSubscribe Subscribe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseInteraction {\n");
            sb.Append("  Buy: ").Append(Buy).Append("\n");
            sb.Append("  Rent: ").Append(Rent).Append("\n");
            sb.Append("  Subscribe: ").Append(Subscribe).Append("\n");
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
            return this.Equals(input as PurchaseInteraction);
        }

        /// <summary>
        /// Returns true if PurchaseInteraction instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseInteraction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseInteraction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Buy == input.Buy ||
                    (this.Buy != null &&
                    this.Buy.Equals(input.Buy))
                ) && 
                (
                    this.Rent == input.Rent ||
                    (this.Rent != null &&
                    this.Rent.Equals(input.Rent))
                ) && 
                (
                    this.Subscribe == input.Subscribe ||
                    (this.Subscribe != null &&
                    this.Subscribe.Equals(input.Subscribe))
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
                if (this.Buy != null)
                    hashCode = hashCode * 59 + this.Buy.GetHashCode();
                if (this.Rent != null)
                    hashCode = hashCode * 59 + this.Rent.GetHashCode();
                if (this.Subscribe != null)
                    hashCode = hashCode * 59 + this.Subscribe.GetHashCode();
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

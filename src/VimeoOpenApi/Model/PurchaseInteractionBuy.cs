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
    /// Information on purchasing this video.
    /// </summary>
    [DataContract]
    public partial class PurchaseInteractionBuy :  IEquatable<PurchaseInteractionBuy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseInteractionBuy" /> class.
        /// </summary>
        /// <param name="drm">Whether the On Demand video for purchase has DRM..</param>
        public PurchaseInteractionBuy(bool drm = default(bool))
        {
            this.Drm = drm;
        }
        
        /// <summary>
        /// Whether the On Demand video for purchase has DRM.
        /// </summary>
        /// <value>Whether the On Demand video for purchase has DRM.</value>
        [DataMember(Name="drm", EmitDefaultValue=false)]
        public bool Drm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseInteractionBuy {\n");
            sb.Append("  Drm: ").Append(Drm).Append("\n");
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
            return this.Equals(input as PurchaseInteractionBuy);
        }

        /// <summary>
        /// Returns true if PurchaseInteractionBuy instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseInteractionBuy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseInteractionBuy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Drm == input.Drm ||
                    this.Drm.Equals(input.Drm)
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
                hashCode = hashCode * 59 + this.Drm.GetHashCode();
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

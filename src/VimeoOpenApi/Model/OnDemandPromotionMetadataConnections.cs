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
    /// A list of resource URIs related to the promotion.
    /// </summary>
    [DataContract]
    public partial class OnDemandPromotionMetadataConnections :  IEquatable<OnDemandPromotionMetadataConnections>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnDemandPromotionMetadataConnections" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OnDemandPromotionMetadataConnections() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OnDemandPromotionMetadataConnections" /> class.
        /// </summary>
        /// <param name="codes">codes (required).</param>
        public OnDemandPromotionMetadataConnections(OnDemandPromotionMetadataConnectionsCodes codes = default(OnDemandPromotionMetadataConnectionsCodes))
        {
            // to ensure "codes" is required (not null)
            this.Codes = codes ?? throw new ArgumentNullException("codes is a required property for OnDemandPromotionMetadataConnections and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Codes
        /// </summary>
        [DataMember(Name="codes", EmitDefaultValue=false)]
        public OnDemandPromotionMetadataConnectionsCodes Codes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnDemandPromotionMetadataConnections {\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
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
            return this.Equals(input as OnDemandPromotionMetadataConnections);
        }

        /// <summary>
        /// Returns true if OnDemandPromotionMetadataConnections instances are equal
        /// </summary>
        /// <param name="input">Instance of OnDemandPromotionMetadataConnections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnDemandPromotionMetadataConnections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Codes == input.Codes ||
                    (this.Codes != null &&
                    this.Codes.Equals(input.Codes))
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
                if (this.Codes != null)
                    hashCode = hashCode * 59 + this.Codes.GetHashCode();
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

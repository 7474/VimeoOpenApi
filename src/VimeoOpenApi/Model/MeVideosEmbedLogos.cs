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
    /// MeVideosEmbedLogos
    /// </summary>
    [DataContract]
    public partial class MeVideosEmbedLogos :  IEquatable<MeVideosEmbedLogos>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeVideosEmbedLogos" /> class.
        /// </summary>
        /// <param name="custom">custom.</param>
        /// <param name="vimeo">Whether to show the Vimeo logo on the embeddable player..</param>
        public MeVideosEmbedLogos(MeVideosEmbedLogosCustom custom = default(MeVideosEmbedLogosCustom), bool vimeo = default(bool))
        {
            this.Custom = custom;
            this.Vimeo = vimeo;
        }
        
        /// <summary>
        /// Gets or Sets Custom
        /// </summary>
        [DataMember(Name="custom", EmitDefaultValue=false)]
        public MeVideosEmbedLogosCustom Custom { get; set; }

        /// <summary>
        /// Whether to show the Vimeo logo on the embeddable player.
        /// </summary>
        /// <value>Whether to show the Vimeo logo on the embeddable player.</value>
        [DataMember(Name="vimeo", EmitDefaultValue=false)]
        public bool Vimeo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeVideosEmbedLogos {\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  Vimeo: ").Append(Vimeo).Append("\n");
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
            return this.Equals(input as MeVideosEmbedLogos);
        }

        /// <summary>
        /// Returns true if MeVideosEmbedLogos instances are equal
        /// </summary>
        /// <param name="input">Instance of MeVideosEmbedLogos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeVideosEmbedLogos input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Custom == input.Custom ||
                    (this.Custom != null &&
                    this.Custom.Equals(input.Custom))
                ) && 
                (
                    this.Vimeo == input.Vimeo ||
                    this.Vimeo.Equals(input.Vimeo)
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
                if (this.Custom != null)
                    hashCode = hashCode * 59 + this.Custom.GetHashCode();
                hashCode = hashCode * 59 + this.Vimeo.GetHashCode();
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

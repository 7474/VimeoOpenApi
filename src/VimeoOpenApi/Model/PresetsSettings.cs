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
    /// The contents of the presets group.
    /// </summary>
    [DataContract]
    public partial class PresetsSettings :  IEquatable<PresetsSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresetsSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PresetsSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PresetsSettings" /> class.
        /// </summary>
        /// <param name="buttons">buttons (required).</param>
        /// <param name="logos">logos (required).</param>
        /// <param name="outro">outro (required).</param>
        public PresetsSettings(PresetsSettingsButtons buttons = default(PresetsSettingsButtons), PresetsSettingsLogos logos = default(PresetsSettingsLogos), PresetsSettingsOutro outro = default(PresetsSettingsOutro))
        {
            // to ensure "buttons" is required (not null)
            this.Buttons = buttons ?? throw new ArgumentNullException("buttons is a required property for PresetsSettings and cannot be null");
            // to ensure "logos" is required (not null)
            this.Logos = logos ?? throw new ArgumentNullException("logos is a required property for PresetsSettings and cannot be null");
            // to ensure "outro" is required (not null)
            this.Outro = outro ?? throw new ArgumentNullException("outro is a required property for PresetsSettings and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Buttons
        /// </summary>
        [DataMember(Name="buttons", EmitDefaultValue=false)]
        public PresetsSettingsButtons Buttons { get; set; }

        /// <summary>
        /// Gets or Sets Logos
        /// </summary>
        [DataMember(Name="logos", EmitDefaultValue=false)]
        public PresetsSettingsLogos Logos { get; set; }

        /// <summary>
        /// Gets or Sets Outro
        /// </summary>
        [DataMember(Name="outro", EmitDefaultValue=false)]
        public PresetsSettingsOutro Outro { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PresetsSettings {\n");
            sb.Append("  Buttons: ").Append(Buttons).Append("\n");
            sb.Append("  Logos: ").Append(Logos).Append("\n");
            sb.Append("  Outro: ").Append(Outro).Append("\n");
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
            return this.Equals(input as PresetsSettings);
        }

        /// <summary>
        /// Returns true if PresetsSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of PresetsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresetsSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Buttons == input.Buttons ||
                    (this.Buttons != null &&
                    this.Buttons.Equals(input.Buttons))
                ) && 
                (
                    this.Logos == input.Logos ||
                    (this.Logos != null &&
                    this.Logos.Equals(input.Logos))
                ) && 
                (
                    this.Outro == input.Outro ||
                    (this.Outro != null &&
                    this.Outro.Equals(input.Outro))
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
                if (this.Buttons != null)
                    hashCode = hashCode * 59 + this.Buttons.GetHashCode();
                if (this.Logos != null)
                    hashCode = hashCode * 59 + this.Logos.GetHashCode();
                if (this.Outro != null)
                    hashCode = hashCode * 59 + this.Outro.GetHashCode();
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

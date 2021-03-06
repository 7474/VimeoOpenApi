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
    /// OnDemandVideoMetadataConnections
    /// </summary>
    [DataContract]
    public partial class OnDemandVideoMetadataConnections :  IEquatable<OnDemandVideoMetadataConnections>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnDemandVideoMetadataConnections" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OnDemandVideoMetadataConnections() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OnDemandVideoMetadataConnections" /> class.
        /// </summary>
        /// <param name="season">season (required).</param>
        public OnDemandVideoMetadataConnections(OnDemandVideoMetadataConnectionsSeason season = default(OnDemandVideoMetadataConnectionsSeason))
        {
            // to ensure "season" is required (not null)
            this.Season = season ?? throw new ArgumentNullException("season is a required property for OnDemandVideoMetadataConnections and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public OnDemandVideoMetadataConnectionsSeason Season { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnDemandVideoMetadataConnections {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
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
            return this.Equals(input as OnDemandVideoMetadataConnections);
        }

        /// <summary>
        /// Returns true if OnDemandVideoMetadataConnections instances are equal
        /// </summary>
        /// <param name="input">Instance of OnDemandVideoMetadataConnections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnDemandVideoMetadataConnections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
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
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
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

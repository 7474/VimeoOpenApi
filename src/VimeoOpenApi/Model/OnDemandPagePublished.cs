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
    /// OnDemandPagePublished
    /// </summary>
    [DataContract]
    public partial class OnDemandPagePublished :  IEquatable<OnDemandPagePublished>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnDemandPagePublished" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OnDemandPagePublished() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OnDemandPagePublished" /> class.
        /// </summary>
        /// <param name="enabled">Whether the On Demand page has been published. (required).</param>
        /// <param name="time">The time in ISO 8601 format when this page was published. (required).</param>
        public OnDemandPagePublished(bool enabled = default(bool), string time = default(string))
        {
            this.Enabled = enabled;
            // to ensure "time" is required (not null)
            this.Time = time ?? throw new ArgumentNullException("time is a required property for OnDemandPagePublished and cannot be null");
        }
        
        /// <summary>
        /// Whether the On Demand page has been published.
        /// </summary>
        /// <value>Whether the On Demand page has been published.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The time in ISO 8601 format when this page was published.
        /// </summary>
        /// <value>The time in ISO 8601 format when this page was published.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnDemandPagePublished {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(input as OnDemandPagePublished);
        }

        /// <summary>
        /// Returns true if OnDemandPagePublished instances are equal
        /// </summary>
        /// <param name="input">Instance of OnDemandPagePublished to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnDemandPagePublished input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
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

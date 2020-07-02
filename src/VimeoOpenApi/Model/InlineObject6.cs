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
    /// InlineObject6
    /// </summary>
    [DataContract]
    public partial class InlineObject6 :  IEquatable<InlineObject6>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject6" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject6() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject6" /> class.
        /// </summary>
        /// <param name="users">The array of either the user URIs or the user IDs to permit to access the private channel. (required).</param>
        public InlineObject6(List<string> users = default(List<string>))
        {
            // to ensure "users" is required (not null)
            this.Users = users ?? throw new ArgumentNullException("users is a required property for InlineObject6 and cannot be null");
        }
        
        /// <summary>
        /// The array of either the user URIs or the user IDs to permit to access the private channel.
        /// </summary>
        /// <value>The array of either the user URIs or the user IDs to permit to access the private channel.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject6 {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as InlineObject6);
        }

        /// <summary>
        /// Returns true if InlineObject6 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject6 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    input.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
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
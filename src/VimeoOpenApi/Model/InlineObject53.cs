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
    /// InlineObject53
    /// </summary>
    [DataContract]
    public partial class InlineObject53 :  IEquatable<InlineObject53>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject53" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject53() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject53" /> class.
        /// </summary>
        /// <param name="category">An array of the names of the desired categories. (required).</param>
        public InlineObject53(List<string> category = default(List<string>))
        {
            // to ensure "category" is required (not null)
            this.Category = category ?? throw new ArgumentNullException("category is a required property for InlineObject53 and cannot be null");
        }
        
        /// <summary>
        /// An array of the names of the desired categories.
        /// </summary>
        /// <value>An array of the names of the desired categories.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public List<string> Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject53 {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(input as InlineObject53);
        }

        /// <summary>
        /// Returns true if InlineObject53 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject53 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject53 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    this.Category != null &&
                    input.Category != null &&
                    this.Category.SequenceEqual(input.Category)
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
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

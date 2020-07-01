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
    /// The container of the category&#39;s parent category, if the current category is a subcategory.
    /// </summary>
    [DataContract]
    public partial class CategoryParent :  IEquatable<CategoryParent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryParent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryParent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryParent" /> class.
        /// </summary>
        /// <param name="link">The URL to access the parent category in a browser. (required).</param>
        /// <param name="name">The display name that identifies the parent category. (required).</param>
        /// <param name="uri">The unique identifier to access the parent of the category resource. (required).</param>
        public CategoryParent(string link = default(string), string name = default(string), string uri = default(string))
        {
            // to ensure "link" is required (not null)
            this.Link = link ?? throw new ArgumentNullException("link is a required property for CategoryParent and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CategoryParent and cannot be null");
            // to ensure "uri" is required (not null)
            this.Uri = uri ?? throw new ArgumentNullException("uri is a required property for CategoryParent and cannot be null");
        }
        
        /// <summary>
        /// The URL to access the parent category in a browser.
        /// </summary>
        /// <value>The URL to access the parent category in a browser.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// The display name that identifies the parent category.
        /// </summary>
        /// <value>The display name that identifies the parent category.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier to access the parent of the category resource.
        /// </summary>
        /// <value>The unique identifier to access the parent of the category resource.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryParent {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CategoryParent);
        }

        /// <summary>
        /// Returns true if CategoryParent instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryParent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryParent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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

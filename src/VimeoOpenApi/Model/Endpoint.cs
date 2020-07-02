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
    /// Endpoint
    /// </summary>
    [DataContract]
    public partial class Endpoint :  IEquatable<Endpoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Endpoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        /// <param name="methods">All HTTP methods permitted on this endpoint. (required).</param>
        /// <param name="path">The path section of the URL, which, when appended to the API host &#x60;https:///api.vimeo.com&#x60;, builds a full API endpoint. (required).</param>
        public Endpoint(List<string> methods = default(List<string>), string path = default(string))
        {
            // to ensure "methods" is required (not null)
            this.Methods = methods ?? throw new ArgumentNullException("methods is a required property for Endpoint and cannot be null");
            // to ensure "path" is required (not null)
            this.Path = path ?? throw new ArgumentNullException("path is a required property for Endpoint and cannot be null");
        }
        
        /// <summary>
        /// All HTTP methods permitted on this endpoint.
        /// </summary>
        /// <value>All HTTP methods permitted on this endpoint.</value>
        [DataMember(Name="methods", EmitDefaultValue=false)]
        public List<string> Methods { get; set; }

        /// <summary>
        /// The path section of the URL, which, when appended to the API host &#x60;https:///api.vimeo.com&#x60;, builds a full API endpoint.
        /// </summary>
        /// <value>The path section of the URL, which, when appended to the API host &#x60;https:///api.vimeo.com&#x60;, builds a full API endpoint.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Endpoint {\n");
            sb.Append("  Methods: ").Append(Methods).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(input as Endpoint);
        }

        /// <summary>
        /// Returns true if Endpoint instances are equal
        /// </summary>
        /// <param name="input">Instance of Endpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Endpoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Methods == input.Methods ||
                    this.Methods != null &&
                    input.Methods != null &&
                    this.Methods.SequenceEqual(input.Methods)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Methods != null)
                    hashCode = hashCode * 59 + this.Methods.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
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
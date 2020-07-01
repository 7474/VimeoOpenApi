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
    /// Metadata about the group.
    /// </summary>
    [DataContract]
    public partial class TagMetadata :  IEquatable<TagMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TagMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TagMetadata" /> class.
        /// </summary>
        /// <param name="connections">connections (required).</param>
        public TagMetadata(TagMetadataConnections connections = default(TagMetadataConnections))
        {
            // to ensure "connections" is required (not null)
            this.Connections = connections ?? throw new ArgumentNullException("connections is a required property for TagMetadata and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Connections
        /// </summary>
        [DataMember(Name="connections", EmitDefaultValue=false)]
        public TagMetadataConnections Connections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagMetadata {\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
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
            return this.Equals(input as TagMetadata);
        }

        /// <summary>
        /// Returns true if TagMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of TagMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Connections == input.Connections ||
                    (this.Connections != null &&
                    this.Connections.Equals(input.Connections))
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
                if (this.Connections != null)
                    hashCode = hashCode * 59 + this.Connections.GetHashCode();
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

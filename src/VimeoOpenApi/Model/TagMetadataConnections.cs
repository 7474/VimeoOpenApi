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
    /// A collection of information that is connected to this resource.
    /// </summary>
    [DataContract]
    public partial class TagMetadataConnections :  IEquatable<TagMetadataConnections>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagMetadataConnections" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TagMetadataConnections() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TagMetadataConnections" /> class.
        /// </summary>
        /// <param name="videos">videos (required).</param>
        public TagMetadataConnections(TagMetadataConnectionsVideos videos = default(TagMetadataConnectionsVideos))
        {
            // to ensure "videos" is required (not null)
            this.Videos = videos ?? throw new ArgumentNullException("videos is a required property for TagMetadataConnections and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name="videos", EmitDefaultValue=false)]
        public TagMetadataConnectionsVideos Videos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagMetadataConnections {\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
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
            return this.Equals(input as TagMetadataConnections);
        }

        /// <summary>
        /// Returns true if TagMetadataConnections instances are equal
        /// </summary>
        /// <param name="input">Instance of TagMetadataConnections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagMetadataConnections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Videos == input.Videos ||
                    (this.Videos != null &&
                    this.Videos.Equals(input.Videos))
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
                if (this.Videos != null)
                    hashCode = hashCode * 59 + this.Videos.GetHashCode();
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
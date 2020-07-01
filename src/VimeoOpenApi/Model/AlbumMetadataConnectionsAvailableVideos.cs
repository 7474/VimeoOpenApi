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
    /// Information about the authenticated user&#39;s videos that can be added to or removed from this showcase. This data requires a bearer token with the &#x60;private&#x60; scope.
    /// </summary>
    [DataContract]
    public partial class AlbumMetadataConnectionsAvailableVideos :  IEquatable<AlbumMetadataConnectionsAvailableVideos>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumMetadataConnectionsAvailableVideos" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlbumMetadataConnectionsAvailableVideos() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumMetadataConnectionsAvailableVideos" /> class.
        /// </summary>
        /// <param name="options">An array of HTTP methods permitted on this URI. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        /// <param name="total">The total number of videos on this connection. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        /// <param name="uri">The API URI that resolves to the connection data. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        public AlbumMetadataConnectionsAvailableVideos(List<string> options = default(List<string>), decimal total = default(decimal), string uri = default(string))
        {
            // to ensure "options" is required (not null)
            this.Options = options ?? throw new ArgumentNullException("options is a required property for AlbumMetadataConnectionsAvailableVideos and cannot be null");
            this.Total = total;
            // to ensure "uri" is required (not null)
            this.Uri = uri ?? throw new ArgumentNullException("uri is a required property for AlbumMetadataConnectionsAvailableVideos and cannot be null");
        }
        
        /// <summary>
        /// An array of HTTP methods permitted on this URI. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>An array of HTTP methods permitted on this URI. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<string> Options { get; set; }

        /// <summary>
        /// The total number of videos on this connection. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>The total number of videos on this connection. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal Total { get; set; }

        /// <summary>
        /// The API URI that resolves to the connection data. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>The API URI that resolves to the connection data. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlbumMetadataConnectionsAvailableVideos {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as AlbumMetadataConnectionsAvailableVideos);
        }

        /// <summary>
        /// Returns true if AlbumMetadataConnectionsAvailableVideos instances are equal
        /// </summary>
        /// <param name="input">Instance of AlbumMetadataConnectionsAvailableVideos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlbumMetadataConnectionsAvailableVideos input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
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

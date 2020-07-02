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
    /// Information about the versions of this video.
    /// </summary>
    [DataContract]
    public partial class VideoMetadataConnectionsVersions :  IEquatable<VideoMetadataConnectionsVersions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataConnectionsVersions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoMetadataConnectionsVersions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataConnectionsVersions" /> class.
        /// </summary>
        /// <param name="currentUri">The URI of the current version of the video..</param>
        /// <param name="options">An array of HTTP methods permitted on this URI. (required).</param>
        /// <param name="resourceKey">The resource key string of the current version of the video..</param>
        /// <param name="total">The total number of versions on this connection. (required).</param>
        /// <param name="uri">The API URI that resolves to the connection data. (required).</param>
        public VideoMetadataConnectionsVersions(string currentUri = default(string), List<string> options = default(List<string>), string resourceKey = default(string), decimal total = default(decimal), string uri = default(string))
        {
            // to ensure "options" is required (not null)
            this.Options = options ?? throw new ArgumentNullException("options is a required property for VideoMetadataConnectionsVersions and cannot be null");
            this.Total = total;
            // to ensure "uri" is required (not null)
            this.Uri = uri ?? throw new ArgumentNullException("uri is a required property for VideoMetadataConnectionsVersions and cannot be null");
            this.CurrentUri = currentUri;
            this.ResourceKey = resourceKey;
        }
        
        /// <summary>
        /// The URI of the current version of the video.
        /// </summary>
        /// <value>The URI of the current version of the video.</value>
        [DataMember(Name="current_uri", EmitDefaultValue=false)]
        public string CurrentUri { get; set; }

        /// <summary>
        /// An array of HTTP methods permitted on this URI.
        /// </summary>
        /// <value>An array of HTTP methods permitted on this URI.</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<string> Options { get; set; }

        /// <summary>
        /// The resource key string of the current version of the video.
        /// </summary>
        /// <value>The resource key string of the current version of the video.</value>
        [DataMember(Name="resource_key", EmitDefaultValue=false)]
        public string ResourceKey { get; set; }

        /// <summary>
        /// The total number of versions on this connection.
        /// </summary>
        /// <value>The total number of versions on this connection.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal Total { get; set; }

        /// <summary>
        /// The API URI that resolves to the connection data.
        /// </summary>
        /// <value>The API URI that resolves to the connection data.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoMetadataConnectionsVersions {\n");
            sb.Append("  CurrentUri: ").Append(CurrentUri).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  ResourceKey: ").Append(ResourceKey).Append("\n");
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
            return this.Equals(input as VideoMetadataConnectionsVersions);
        }

        /// <summary>
        /// Returns true if VideoMetadataConnectionsVersions instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoMetadataConnectionsVersions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoMetadataConnectionsVersions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentUri == input.CurrentUri ||
                    (this.CurrentUri != null &&
                    this.CurrentUri.Equals(input.CurrentUri))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.ResourceKey == input.ResourceKey ||
                    (this.ResourceKey != null &&
                    this.ResourceKey.Equals(input.ResourceKey))
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
                if (this.CurrentUri != null)
                    hashCode = hashCode * 59 + this.CurrentUri.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.ResourceKey != null)
                    hashCode = hashCode * 59 + this.ResourceKey.GetHashCode();
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
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
    /// Group
    /// </summary>
    [DataContract]
    public partial class Group :  IEquatable<Group>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Group() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="createdTime">The time in ISO 8601 format when the group was created. (required).</param>
        /// <param name="description">The group&#39;s description. (required).</param>
        /// <param name="link">The link to the group. (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="modifiedTime">The time in ISO 8601 format when the group was last modified. (required).</param>
        /// <param name="name">The group&#39;s display name. (required).</param>
        /// <param name="pictures">The active picture for the group. (required).</param>
        /// <param name="privacy">privacy (required).</param>
        /// <param name="resourceKey">The resource key of the group. (required).</param>
        /// <param name="uri">The canonical relative URI of the group. (required).</param>
        /// <param name="user">The owner of the group..</param>
        public Group(string createdTime = default(string), string description = default(string), string link = default(string), GroupMetadata metadata = default(GroupMetadata), string modifiedTime = default(string), string name = default(string), Picture pictures = default(Picture), GroupPrivacy privacy = default(GroupPrivacy), string resourceKey = default(string), string uri = default(string), User user = default(User))
        {
            // to ensure "createdTime" is required (not null)
            this.CreatedTime = createdTime ?? throw new ArgumentNullException("createdTime is a required property for Group and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for Group and cannot be null");
            // to ensure "link" is required (not null)
            this.Link = link ?? throw new ArgumentNullException("link is a required property for Group and cannot be null");
            // to ensure "metadata" is required (not null)
            this.Metadata = metadata ?? throw new ArgumentNullException("metadata is a required property for Group and cannot be null");
            // to ensure "modifiedTime" is required (not null)
            this.ModifiedTime = modifiedTime ?? throw new ArgumentNullException("modifiedTime is a required property for Group and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for Group and cannot be null");
            // to ensure "pictures" is required (not null)
            this.Pictures = pictures ?? throw new ArgumentNullException("pictures is a required property for Group and cannot be null");
            // to ensure "privacy" is required (not null)
            this.Privacy = privacy ?? throw new ArgumentNullException("privacy is a required property for Group and cannot be null");
            // to ensure "resourceKey" is required (not null)
            this.ResourceKey = resourceKey ?? throw new ArgumentNullException("resourceKey is a required property for Group and cannot be null");
            // to ensure "uri" is required (not null)
            this.Uri = uri ?? throw new ArgumentNullException("uri is a required property for Group and cannot be null");
            this.User = user;
        }
        
        /// <summary>
        /// The time in ISO 8601 format when the group was created.
        /// </summary>
        /// <value>The time in ISO 8601 format when the group was created.</value>
        [DataMember(Name="created_time", EmitDefaultValue=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The group&#39;s description.
        /// </summary>
        /// <value>The group&#39;s description.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// The link to the group.
        /// </summary>
        /// <value>The link to the group.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public GroupMetadata Metadata { get; set; }

        /// <summary>
        /// The time in ISO 8601 format when the group was last modified.
        /// </summary>
        /// <value>The time in ISO 8601 format when the group was last modified.</value>
        [DataMember(Name="modified_time", EmitDefaultValue=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// The group&#39;s display name.
        /// </summary>
        /// <value>The group&#39;s display name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The active picture for the group.
        /// </summary>
        /// <value>The active picture for the group.</value>
        [DataMember(Name="pictures", EmitDefaultValue=false)]
        public Picture Pictures { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name="privacy", EmitDefaultValue=false)]
        public GroupPrivacy Privacy { get; set; }

        /// <summary>
        /// The resource key of the group.
        /// </summary>
        /// <value>The resource key of the group.</value>
        [DataMember(Name="resource_key", EmitDefaultValue=false)]
        public string ResourceKey { get; set; }

        /// <summary>
        /// The canonical relative URI of the group.
        /// </summary>
        /// <value>The canonical relative URI of the group.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The owner of the group.
        /// </summary>
        /// <value>The owner of the group.</value>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public User User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ModifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pictures: ").Append(Pictures).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  ResourceKey: ").Append(ResourceKey).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="input">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.ModifiedTime == input.ModifiedTime ||
                    (this.ModifiedTime != null &&
                    this.ModifiedTime.Equals(input.ModifiedTime))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Pictures == input.Pictures ||
                    (this.Pictures != null &&
                    this.Pictures.Equals(input.Pictures))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    (this.Privacy != null &&
                    this.Privacy.Equals(input.Privacy))
                ) && 
                (
                    this.ResourceKey == input.ResourceKey ||
                    (this.ResourceKey != null &&
                    this.ResourceKey.Equals(input.ResourceKey))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.ModifiedTime != null)
                    hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pictures != null)
                    hashCode = hashCode * 59 + this.Pictures.GetHashCode();
                if (this.Privacy != null)
                    hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                if (this.ResourceKey != null)
                    hashCode = hashCode * 59 + this.ResourceKey.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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

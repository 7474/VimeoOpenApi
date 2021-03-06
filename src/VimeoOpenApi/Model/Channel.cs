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
    /// Channel
    /// </summary>
    [DataContract]
    public partial class Channel :  IEquatable<Channel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Channel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        /// <param name="categories">The categories to which the channel belongs as specified by the channel moderators. (required).</param>
        /// <param name="createdTime">The time in ISO 8601 format when the channel was created. (required).</param>
        /// <param name="description">A brief explanation of the channel&#39;s content. (required).</param>
        /// <param name="header">The banner that appears by default at the top of the channel page. (required).</param>
        /// <param name="link">The URL to access the channel in a browser. (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="modifiedTime">The time in ISO 8601 format when the channel was last modified. (required).</param>
        /// <param name="name">The display name that identifies the channel. (required).</param>
        /// <param name="pictures">The active image for the channel. The default is the thumbnail of the last video added to the channel. (required).</param>
        /// <param name="privacy">privacy (required).</param>
        /// <param name="resourceKey">The channel resource key. (required).</param>
        /// <param name="tags">An array of all tags assigned to the channel. (required).</param>
        /// <param name="uri">The unique identifier to access the channel resource. (required).</param>
        /// <param name="user">The Vimeo user who owns the channel. (required).</param>
        public Channel(List<Category> categories = default(List<Category>), string createdTime = default(string), string description = default(string), Picture header = default(Picture), string link = default(string), ChannelMetadata metadata = default(ChannelMetadata), string modifiedTime = default(string), string name = default(string), Picture pictures = default(Picture), ChannelPrivacy privacy = default(ChannelPrivacy), string resourceKey = default(string), List<Tag> tags = default(List<Tag>), string uri = default(string), User user = default(User))
        {
            // to ensure "categories" is required (not null)
            this.Categories = categories ?? throw new ArgumentNullException("categories is a required property for Channel and cannot be null");
            // to ensure "createdTime" is required (not null)
            this.CreatedTime = createdTime ?? throw new ArgumentNullException("createdTime is a required property for Channel and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for Channel and cannot be null");
            // to ensure "header" is required (not null)
            this.Header = header ?? throw new ArgumentNullException("header is a required property for Channel and cannot be null");
            // to ensure "link" is required (not null)
            this.Link = link ?? throw new ArgumentNullException("link is a required property for Channel and cannot be null");
            // to ensure "metadata" is required (not null)
            this.Metadata = metadata ?? throw new ArgumentNullException("metadata is a required property for Channel and cannot be null");
            // to ensure "modifiedTime" is required (not null)
            this.ModifiedTime = modifiedTime ?? throw new ArgumentNullException("modifiedTime is a required property for Channel and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for Channel and cannot be null");
            // to ensure "pictures" is required (not null)
            this.Pictures = pictures ?? throw new ArgumentNullException("pictures is a required property for Channel and cannot be null");
            // to ensure "privacy" is required (not null)
            this.Privacy = privacy ?? throw new ArgumentNullException("privacy is a required property for Channel and cannot be null");
            // to ensure "resourceKey" is required (not null)
            this.ResourceKey = resourceKey ?? throw new ArgumentNullException("resourceKey is a required property for Channel and cannot be null");
            // to ensure "tags" is required (not null)
            this.Tags = tags ?? throw new ArgumentNullException("tags is a required property for Channel and cannot be null");
            // to ensure "uri" is required (not null)
            this.Uri = uri ?? throw new ArgumentNullException("uri is a required property for Channel and cannot be null");
            // to ensure "user" is required (not null)
            this.User = user ?? throw new ArgumentNullException("user is a required property for Channel and cannot be null");
        }
        
        /// <summary>
        /// The categories to which the channel belongs as specified by the channel moderators.
        /// </summary>
        /// <value>The categories to which the channel belongs as specified by the channel moderators.</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// The time in ISO 8601 format when the channel was created.
        /// </summary>
        /// <value>The time in ISO 8601 format when the channel was created.</value>
        [DataMember(Name="created_time", EmitDefaultValue=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// A brief explanation of the channel&#39;s content.
        /// </summary>
        /// <value>A brief explanation of the channel&#39;s content.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// The banner that appears by default at the top of the channel page.
        /// </summary>
        /// <value>The banner that appears by default at the top of the channel page.</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public Picture Header { get; set; }

        /// <summary>
        /// The URL to access the channel in a browser.
        /// </summary>
        /// <value>The URL to access the channel in a browser.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ChannelMetadata Metadata { get; set; }

        /// <summary>
        /// The time in ISO 8601 format when the channel was last modified.
        /// </summary>
        /// <value>The time in ISO 8601 format when the channel was last modified.</value>
        [DataMember(Name="modified_time", EmitDefaultValue=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// The display name that identifies the channel.
        /// </summary>
        /// <value>The display name that identifies the channel.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The active image for the channel. The default is the thumbnail of the last video added to the channel.
        /// </summary>
        /// <value>The active image for the channel. The default is the thumbnail of the last video added to the channel.</value>
        [DataMember(Name="pictures", EmitDefaultValue=false)]
        public Picture Pictures { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name="privacy", EmitDefaultValue=false)]
        public ChannelPrivacy Privacy { get; set; }

        /// <summary>
        /// The channel resource key.
        /// </summary>
        /// <value>The channel resource key.</value>
        [DataMember(Name="resource_key", EmitDefaultValue=false)]
        public string ResourceKey { get; set; }

        /// <summary>
        /// An array of all tags assigned to the channel.
        /// </summary>
        /// <value>An array of all tags assigned to the channel.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// The unique identifier to access the channel resource.
        /// </summary>
        /// <value>The unique identifier to access the channel resource.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The Vimeo user who owns the channel.
        /// </summary>
        /// <value>The Vimeo user who owns the channel.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Channel {\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ModifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pictures: ").Append(Pictures).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  ResourceKey: ").Append(ResourceKey).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as Channel);
        }

        /// <summary>
        /// Returns true if Channel instances are equal
        /// </summary>
        /// <param name="input">Instance of Channel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Channel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
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
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
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
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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

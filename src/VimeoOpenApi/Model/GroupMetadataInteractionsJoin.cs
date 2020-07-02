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
    /// An action indicating that someone has joined the group. This data requires a bearer token with the &#x60;private&#x60; scope.
    /// </summary>
    [DataContract]
    public partial class GroupMetadataInteractionsJoin :  IEquatable<GroupMetadataInteractionsJoin>, IValidatableObject
    {
        /// <summary>
        /// Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;member&#x60; - The authenticated user is a member.  * &#x60;moderator&#x60; - The authenticated user is a moderator. 
        /// </summary>
        /// <value>Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;member&#x60; - The authenticated user is a member.  * &#x60;moderator&#x60; - The authenticated user is a moderator. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Member for value: member
            /// </summary>
            [EnumMember(Value = "member")]
            Member = 1,

            /// <summary>
            /// Enum Moderator for value: moderator
            /// </summary>
            [EnumMember(Value = "moderator")]
            Moderator = 2

        }

        /// <summary>
        /// Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;member&#x60; - The authenticated user is a member.  * &#x60;moderator&#x60; - The authenticated user is a moderator. 
        /// </summary>
        /// <value>Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;member&#x60; - The authenticated user is a member.  * &#x60;moderator&#x60; - The authenticated user is a moderator. </value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMetadataInteractionsJoin" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupMetadataInteractionsJoin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMetadataInteractionsJoin" /> class.
        /// </summary>
        /// <param name="added">Whether the authenticated user has followed the group. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        /// <param name="addedTime">The time in ISO 8601 format when the authenticated user joined the group. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        /// <param name="title">The authenticated user&#39;s title. If not applicable, this field takes the null value. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        /// <param name="type">Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;member&#x60; - The authenticated user is a member.  * &#x60;moderator&#x60; - The authenticated user is a moderator.  (required).</param>
        /// <param name="uri">The URI for following the group. PUT to this URI to follow the group, or DELETE to this URI to unfollow the group. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        public GroupMetadataInteractionsJoin(bool added = default(bool), string addedTime = default(string), string title = default(string), TypeEnum type = default(TypeEnum), string uri = default(string))
        {
            this.Added = added;
            // to ensure "addedTime" is required (not null)
            this.AddedTime = addedTime ?? throw new ArgumentNullException("addedTime is a required property for GroupMetadataInteractionsJoin and cannot be null");
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for GroupMetadataInteractionsJoin and cannot be null");
            this.Type = type;
            // to ensure "uri" is required (not null)
            this.Uri = uri ?? throw new ArgumentNullException("uri is a required property for GroupMetadataInteractionsJoin and cannot be null");
        }
        
        /// <summary>
        /// Whether the authenticated user has followed the group. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>Whether the authenticated user has followed the group. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="added", EmitDefaultValue=false)]
        public bool Added { get; set; }

        /// <summary>
        /// The time in ISO 8601 format when the authenticated user joined the group. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>The time in ISO 8601 format when the authenticated user joined the group. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="added_time", EmitDefaultValue=true)]
        public string AddedTime { get; set; }

        /// <summary>
        /// The authenticated user&#39;s title. If not applicable, this field takes the null value. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>The authenticated user&#39;s title. If not applicable, this field takes the null value. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// The URI for following the group. PUT to this URI to follow the group, or DELETE to this URI to unfollow the group. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>The URI for following the group. PUT to this URI to follow the group, or DELETE to this URI to unfollow the group. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMetadataInteractionsJoin {\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  AddedTime: ").Append(AddedTime).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GroupMetadataInteractionsJoin);
        }

        /// <summary>
        /// Returns true if GroupMetadataInteractionsJoin instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupMetadataInteractionsJoin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMetadataInteractionsJoin input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Added == input.Added ||
                    this.Added.Equals(input.Added)
                ) && 
                (
                    this.AddedTime == input.AddedTime ||
                    (this.AddedTime != null &&
                    this.AddedTime.Equals(input.AddedTime))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.AddedTime != null)
                    hashCode = hashCode * 59 + this.AddedTime.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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
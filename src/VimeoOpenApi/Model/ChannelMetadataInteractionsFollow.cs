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
    /// An action indicating if the authenticated user has followed this channel. This data requires a bearer token with the &#x60;private&#x60; scope.
    /// </summary>
    [DataContract]
    public partial class ChannelMetadataInteractionsFollow :  IEquatable<ChannelMetadataInteractionsFollow>, IValidatableObject
    {
        /// <summary>
        /// Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;moderator&#x60; - The authenticated user is a moderator.  * &#x60;subscriber&#x60; - The authenticated user is a subscriber. 
        /// </summary>
        /// <value>Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;moderator&#x60; - The authenticated user is a moderator.  * &#x60;subscriber&#x60; - The authenticated user is a subscriber. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Moderator for value: moderator
            /// </summary>
            [EnumMember(Value = "moderator")]
            Moderator = 1,

            /// <summary>
            /// Enum Subscriber for value: subscriber
            /// </summary>
            [EnumMember(Value = "subscriber")]
            Subscriber = 2

        }

        /// <summary>
        /// Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;moderator&#x60; - The authenticated user is a moderator.  * &#x60;subscriber&#x60; - The authenticated user is a subscriber. 
        /// </summary>
        /// <value>Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;moderator&#x60; - The authenticated user is a moderator.  * &#x60;subscriber&#x60; - The authenticated user is a subscriber. </value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelMetadataInteractionsFollow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelMetadataInteractionsFollow() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelMetadataInteractionsFollow" /> class.
        /// </summary>
        /// <param name="added">Whether the authenticated user has followed this channel. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        /// <param name="addedTime">The time in ISO 8601 format that the user followed this channel, or the null value if the user hasn&#39;t followed the channel. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        /// <param name="type">Whether the authenticated user is a moderator or subscriber. This data requires a bearer token with the &#x60;private&#x60; scope.  Option descriptions:  * &#x60;moderator&#x60; - The authenticated user is a moderator.  * &#x60;subscriber&#x60; - The authenticated user is a subscriber.  (required).</param>
        /// <param name="uri">The URI for following or unfollowing this channel. PUT to this URI to follow the channel, or DELETE to this URI to unfollow the channel. This data requires a bearer token with the &#x60;private&#x60; scope. (required).</param>
        public ChannelMetadataInteractionsFollow(bool added = default(bool), string addedTime = default(string), TypeEnum type = default(TypeEnum), string uri = default(string))
        {
            this.Added = added;
            // to ensure "addedTime" is required (not null)
            this.AddedTime = addedTime ?? throw new ArgumentNullException("addedTime is a required property for ChannelMetadataInteractionsFollow and cannot be null");
            this.Type = type;
            // to ensure "uri" is required (not null)
            this.Uri = uri ?? throw new ArgumentNullException("uri is a required property for ChannelMetadataInteractionsFollow and cannot be null");
        }
        
        /// <summary>
        /// Whether the authenticated user has followed this channel. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>Whether the authenticated user has followed this channel. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="added", EmitDefaultValue=false)]
        public bool Added { get; set; }

        /// <summary>
        /// The time in ISO 8601 format that the user followed this channel, or the null value if the user hasn&#39;t followed the channel. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>The time in ISO 8601 format that the user followed this channel, or the null value if the user hasn&#39;t followed the channel. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="added_time", EmitDefaultValue=true)]
        public string AddedTime { get; set; }

        /// <summary>
        /// The URI for following or unfollowing this channel. PUT to this URI to follow the channel, or DELETE to this URI to unfollow the channel. This data requires a bearer token with the &#x60;private&#x60; scope.
        /// </summary>
        /// <value>The URI for following or unfollowing this channel. PUT to this URI to follow the channel, or DELETE to this URI to unfollow the channel. This data requires a bearer token with the &#x60;private&#x60; scope.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelMetadataInteractionsFollow {\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  AddedTime: ").Append(AddedTime).Append("\n");
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
            return this.Equals(input as ChannelMetadataInteractionsFollow);
        }

        /// <summary>
        /// Returns true if ChannelMetadataInteractionsFollow instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelMetadataInteractionsFollow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelMetadataInteractionsFollow input)
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

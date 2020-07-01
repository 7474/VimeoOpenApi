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
    /// The context of the video&#39;s subscription, if this video is part of a subscription.
    /// </summary>
    [DataContract]
    public partial class VideoContext :  IEquatable<VideoContext>, IValidatableObject
    {
        /// <summary>
        /// The contextual action:  Option descriptions:  * &#x60;Added to&#x60; - An Added To action.  * &#x60;Appearance by&#x60; - An Appearance By action.  * &#x60;Liked by&#x60; - A Liked By action.  * &#x60;Uploaded by&#x60; - An Unloaded By action. 
        /// </summary>
        /// <value>The contextual action:  Option descriptions:  * &#x60;Added to&#x60; - An Added To action.  * &#x60;Appearance by&#x60; - An Appearance By action.  * &#x60;Liked by&#x60; - A Liked By action.  * &#x60;Uploaded by&#x60; - An Unloaded By action. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Addedto for value: Added to
            /// </summary>
            [EnumMember(Value = "Added to")]
            Addedto = 1,

            /// <summary>
            /// Enum Appearanceby for value: Appearance by
            /// </summary>
            [EnumMember(Value = "Appearance by")]
            Appearanceby = 2,

            /// <summary>
            /// Enum Likedby for value: Liked by
            /// </summary>
            [EnumMember(Value = "Liked by")]
            Likedby = 3,

            /// <summary>
            /// Enum Uploadedby for value: Uploaded by
            /// </summary>
            [EnumMember(Value = "Uploaded by")]
            Uploadedby = 4

        }

        /// <summary>
        /// The contextual action:  Option descriptions:  * &#x60;Added to&#x60; - An Added To action.  * &#x60;Appearance by&#x60; - An Appearance By action.  * &#x60;Liked by&#x60; - A Liked By action.  * &#x60;Uploaded by&#x60; - An Unloaded By action. 
        /// </summary>
        /// <value>The contextual action:  Option descriptions:  * &#x60;Added to&#x60; - An Added To action.  * &#x60;Appearance by&#x60; - An Appearance By action.  * &#x60;Liked by&#x60; - A Liked By action.  * &#x60;Uploaded by&#x60; - An Unloaded By action. </value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContext" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoContext() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContext" /> class.
        /// </summary>
        /// <param name="action">The contextual action:  Option descriptions:  * &#x60;Added to&#x60; - An Added To action.  * &#x60;Appearance by&#x60; - An Appearance By action.  * &#x60;Liked by&#x60; - A Liked By action.  * &#x60;Uploaded by&#x60; - An Unloaded By action.  (required).</param>
        /// <param name="resource">The contextual resource: a user, group, or channel representation, or an object of a tag. (required).</param>
        /// <param name="resourceType">The contextual resource type. (required).</param>
        public VideoContext(ActionEnum action = default(ActionEnum), Object resource = default(Object), string resourceType = default(string))
        {
            this.Action = action;
            // to ensure "resource" is required (not null)
            this.Resource = resource ?? throw new ArgumentNullException("resource is a required property for VideoContext and cannot be null");
            // to ensure "resourceType" is required (not null)
            this.ResourceType = resourceType ?? throw new ArgumentNullException("resourceType is a required property for VideoContext and cannot be null");
        }
        
        /// <summary>
        /// The contextual resource: a user, group, or channel representation, or an object of a tag.
        /// </summary>
        /// <value>The contextual resource: a user, group, or channel representation, or an object of a tag.</value>
        [DataMember(Name="resource", EmitDefaultValue=true)]
        public Object Resource { get; set; }

        /// <summary>
        /// The contextual resource type.
        /// </summary>
        /// <value>The contextual resource type.</value>
        [DataMember(Name="resource_type", EmitDefaultValue=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoContext {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
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
            return this.Equals(input as VideoContext);
        }

        /// <summary>
        /// Returns true if VideoContext instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
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

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
    /// UserPreferencesVideosPrivacy
    /// </summary>
    [DataContract]
    public partial class UserPreferencesVideosPrivacy :  IEquatable<UserPreferencesVideosPrivacy>, IValidatableObject
    {
        /// <summary>
        /// The authenticated user&#39;s privacy preference for comments.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can comment on the user&#39;s videos.  * &#x60;nobody&#x60; - No one can comment on the user&#39;s videos. 
        /// </summary>
        /// <value>The authenticated user&#39;s privacy preference for comments.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can comment on the user&#39;s videos.  * &#x60;nobody&#x60; - No one can comment on the user&#39;s videos. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommentsEnum
        {
            /// <summary>
            /// Enum Anybody for value: anybody
            /// </summary>
            [EnumMember(Value = "anybody")]
            Anybody = 1,

            /// <summary>
            /// Enum Contacts for value: contacts
            /// </summary>
            [EnumMember(Value = "contacts")]
            Contacts = 2,

            /// <summary>
            /// Enum Nobody for value: nobody
            /// </summary>
            [EnumMember(Value = "nobody")]
            Nobody = 3

        }

        /// <summary>
        /// The authenticated user&#39;s privacy preference for comments.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can comment on the user&#39;s videos.  * &#x60;nobody&#x60; - No one can comment on the user&#39;s videos. 
        /// </summary>
        /// <value>The authenticated user&#39;s privacy preference for comments.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can comment on the user&#39;s videos.  * &#x60;nobody&#x60; - No one can comment on the user&#39;s videos. </value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public CommentsEnum? Comments { get; set; }
        /// <summary>
        /// The authenticated user&#39;s privacy preference for embeds.  Option descriptions:  * &#x60;private&#x60; - Only the user can embed their own videos.  * &#x60;public&#x60; - Anyone can embed the user&#39;s videos.  * &#x60;whitelist&#x60; - Only those on the whitelist can embed the user&#39;s videos. 
        /// </summary>
        /// <value>The authenticated user&#39;s privacy preference for embeds.  Option descriptions:  * &#x60;private&#x60; - Only the user can embed their own videos.  * &#x60;public&#x60; - Anyone can embed the user&#39;s videos.  * &#x60;whitelist&#x60; - Only those on the whitelist can embed the user&#39;s videos. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmbedEnum
        {
            /// <summary>
            /// Enum Private for value: private
            /// </summary>
            [EnumMember(Value = "private")]
            Private = 1,

            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 2,

            /// <summary>
            /// Enum Whitelist for value: whitelist
            /// </summary>
            [EnumMember(Value = "whitelist")]
            Whitelist = 3

        }

        /// <summary>
        /// The authenticated user&#39;s privacy preference for embeds.  Option descriptions:  * &#x60;private&#x60; - Only the user can embed their own videos.  * &#x60;public&#x60; - Anyone can embed the user&#39;s videos.  * &#x60;whitelist&#x60; - Only those on the whitelist can embed the user&#39;s videos. 
        /// </summary>
        /// <value>The authenticated user&#39;s privacy preference for embeds.  Option descriptions:  * &#x60;private&#x60; - Only the user can embed their own videos.  * &#x60;public&#x60; - Anyone can embed the user&#39;s videos.  * &#x60;whitelist&#x60; - Only those on the whitelist can embed the user&#39;s videos. </value>
        [DataMember(Name="embed", EmitDefaultValue=false)]
        public EmbedEnum? Embed { get; set; }
        /// <summary>
        /// The authenticated user&#39;s privacy preference for views.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can view the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can view the user&#39;s videos.  * &#x60;disable&#x60; - Views are disabled for the user&#39;s videos.  * &#x60;nobody&#x60; - No one except the user can view the user&#39;s videos.  * &#x60;password&#x60; - Only those with the password can view the user&#39;s videos.  * &#x60;unlisted&#x60; - Anybody can view the user&#39;s videos if they have a link.  * &#x60;users&#x60; - Only other Vimeo members can view the user&#39;s videos. 
        /// </summary>
        /// <value>The authenticated user&#39;s privacy preference for views.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can view the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can view the user&#39;s videos.  * &#x60;disable&#x60; - Views are disabled for the user&#39;s videos.  * &#x60;nobody&#x60; - No one except the user can view the user&#39;s videos.  * &#x60;password&#x60; - Only those with the password can view the user&#39;s videos.  * &#x60;unlisted&#x60; - Anybody can view the user&#39;s videos if they have a link.  * &#x60;users&#x60; - Only other Vimeo members can view the user&#39;s videos. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ViewEnum
        {
            /// <summary>
            /// Enum Anybody for value: anybody
            /// </summary>
            [EnumMember(Value = "anybody")]
            Anybody = 1,

            /// <summary>
            /// Enum Contacts for value: contacts
            /// </summary>
            [EnumMember(Value = "contacts")]
            Contacts = 2,

            /// <summary>
            /// Enum Disable for value: disable
            /// </summary>
            [EnumMember(Value = "disable")]
            Disable = 3,

            /// <summary>
            /// Enum Nobody for value: nobody
            /// </summary>
            [EnumMember(Value = "nobody")]
            Nobody = 4,

            /// <summary>
            /// Enum Password for value: password
            /// </summary>
            [EnumMember(Value = "password")]
            Password = 5,

            /// <summary>
            /// Enum Unlisted for value: unlisted
            /// </summary>
            [EnumMember(Value = "unlisted")]
            Unlisted = 6,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 7

        }

        /// <summary>
        /// The authenticated user&#39;s privacy preference for views.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can view the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can view the user&#39;s videos.  * &#x60;disable&#x60; - Views are disabled for the user&#39;s videos.  * &#x60;nobody&#x60; - No one except the user can view the user&#39;s videos.  * &#x60;password&#x60; - Only those with the password can view the user&#39;s videos.  * &#x60;unlisted&#x60; - Anybody can view the user&#39;s videos if they have a link.  * &#x60;users&#x60; - Only other Vimeo members can view the user&#39;s videos. 
        /// </summary>
        /// <value>The authenticated user&#39;s privacy preference for views.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can view the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can view the user&#39;s videos.  * &#x60;disable&#x60; - Views are disabled for the user&#39;s videos.  * &#x60;nobody&#x60; - No one except the user can view the user&#39;s videos.  * &#x60;password&#x60; - Only those with the password can view the user&#39;s videos.  * &#x60;unlisted&#x60; - Anybody can view the user&#39;s videos if they have a link.  * &#x60;users&#x60; - Only other Vimeo members can view the user&#39;s videos. </value>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public ViewEnum? View { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesVideosPrivacy" /> class.
        /// </summary>
        /// <param name="add">Whether other users can add the authenticated user&#39;s videos..</param>
        /// <param name="comments">The authenticated user&#39;s privacy preference for comments.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can comment on the user&#39;s videos.  * &#x60;nobody&#x60; - No one can comment on the user&#39;s videos. .</param>
        /// <param name="download">Whether other users can download the authenticated user&#39;s videos..</param>
        /// <param name="embed">The authenticated user&#39;s privacy preference for embeds.  Option descriptions:  * &#x60;private&#x60; - Only the user can embed their own videos.  * &#x60;public&#x60; - Anyone can embed the user&#39;s videos.  * &#x60;whitelist&#x60; - Only those on the whitelist can embed the user&#39;s videos. .</param>
        /// <param name="password">The password for viewing the authenticated user&#39;s videos..</param>
        /// <param name="view">The authenticated user&#39;s privacy preference for views.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can view the user&#39;s videos.  * &#x60;contacts&#x60; - Only contacts can view the user&#39;s videos.  * &#x60;disable&#x60; - Views are disabled for the user&#39;s videos.  * &#x60;nobody&#x60; - No one except the user can view the user&#39;s videos.  * &#x60;password&#x60; - Only those with the password can view the user&#39;s videos.  * &#x60;unlisted&#x60; - Anybody can view the user&#39;s videos if they have a link.  * &#x60;users&#x60; - Only other Vimeo members can view the user&#39;s videos. .</param>
        public UserPreferencesVideosPrivacy(bool add = default(bool), CommentsEnum? comments = default(CommentsEnum?), bool download = default(bool), EmbedEnum? embed = default(EmbedEnum?), string password = default(string), ViewEnum? view = default(ViewEnum?))
        {
            this.Add = add;
            this.Comments = comments;
            this.Download = download;
            this.Embed = embed;
            this.Password = password;
            this.View = view;
        }
        
        /// <summary>
        /// Whether other users can add the authenticated user&#39;s videos.
        /// </summary>
        /// <value>Whether other users can add the authenticated user&#39;s videos.</value>
        [DataMember(Name="add", EmitDefaultValue=false)]
        public bool Add { get; set; }

        /// <summary>
        /// Whether other users can download the authenticated user&#39;s videos.
        /// </summary>
        /// <value>Whether other users can download the authenticated user&#39;s videos.</value>
        [DataMember(Name="download", EmitDefaultValue=false)]
        public bool Download { get; set; }

        /// <summary>
        /// The password for viewing the authenticated user&#39;s videos.
        /// </summary>
        /// <value>The password for viewing the authenticated user&#39;s videos.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPreferencesVideosPrivacy {\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  Embed: ").Append(Embed).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
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
            return this.Equals(input as UserPreferencesVideosPrivacy);
        }

        /// <summary>
        /// Returns true if UserPreferencesVideosPrivacy instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPreferencesVideosPrivacy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPreferencesVideosPrivacy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Add == input.Add ||
                    this.Add.Equals(input.Add)
                ) && 
                (
                    this.Comments == input.Comments ||
                    this.Comments.Equals(input.Comments)
                ) && 
                (
                    this.Download == input.Download ||
                    this.Download.Equals(input.Download)
                ) && 
                (
                    this.Embed == input.Embed ||
                    this.Embed.Equals(input.Embed)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.View == input.View ||
                    this.View.Equals(input.View)
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
                hashCode = hashCode * 59 + this.Add.GetHashCode();
                hashCode = hashCode * 59 + this.Comments.GetHashCode();
                hashCode = hashCode * 59 + this.Download.GetHashCode();
                hashCode = hashCode * 59 + this.Embed.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
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
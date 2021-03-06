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
    /// MeVideosPrivacy1
    /// </summary>
    [DataContract]
    public partial class MeVideosPrivacy1 :  IEquatable<MeVideosPrivacy1>, IValidatableObject
    {
        /// <summary>
        /// The privacy level required to comment on the video.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the video.  * &#x60;contacts&#x60; - Only the video owner&#39;s contacts can comment on the video.  * &#x60;nobody&#x60; - No one can comment on the video. 
        /// </summary>
        /// <value>The privacy level required to comment on the video.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the video.  * &#x60;contacts&#x60; - Only the video owner&#39;s contacts can comment on the video.  * &#x60;nobody&#x60; - No one can comment on the video. </value>
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
        /// The privacy level required to comment on the video.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the video.  * &#x60;contacts&#x60; - Only the video owner&#39;s contacts can comment on the video.  * &#x60;nobody&#x60; - No one can comment on the video. 
        /// </summary>
        /// <value>The privacy level required to comment on the video.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the video.  * &#x60;contacts&#x60; - Only the video owner&#39;s contacts can comment on the video.  * &#x60;nobody&#x60; - No one can comment on the video. </value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public CommentsEnum? Comments { get; set; }
        /// <summary>
        /// The video&#39;s embed setting. Specify the &#x60;whitelist&#x60; value to restrict embedding to a specific set of domains. For more information, see our [Interacting with Videos](https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy) guide.  Option descriptions:  * &#x60;private&#x60; - The video can&#39;t be embedded.  * &#x60;public&#x60; - The video can be embedded.  * &#x60;whitelist&#x60; - The video can be embedded on the specified domains only. 
        /// </summary>
        /// <value>The video&#39;s embed setting. Specify the &#x60;whitelist&#x60; value to restrict embedding to a specific set of domains. For more information, see our [Interacting with Videos](https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy) guide.  Option descriptions:  * &#x60;private&#x60; - The video can&#39;t be embedded.  * &#x60;public&#x60; - The video can be embedded.  * &#x60;whitelist&#x60; - The video can be embedded on the specified domains only. </value>
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
        /// The video&#39;s embed setting. Specify the &#x60;whitelist&#x60; value to restrict embedding to a specific set of domains. For more information, see our [Interacting with Videos](https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy) guide.  Option descriptions:  * &#x60;private&#x60; - The video can&#39;t be embedded.  * &#x60;public&#x60; - The video can be embedded.  * &#x60;whitelist&#x60; - The video can be embedded on the specified domains only. 
        /// </summary>
        /// <value>The video&#39;s embed setting. Specify the &#x60;whitelist&#x60; value to restrict embedding to a specific set of domains. For more information, see our [Interacting with Videos](https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy) guide.  Option descriptions:  * &#x60;private&#x60; - The video can&#39;t be embedded.  * &#x60;public&#x60; - The video can be embedded.  * &#x60;whitelist&#x60; - The video can be embedded on the specified domains only. </value>
        [DataMember(Name="embed", EmitDefaultValue=false)]
        public EmbedEnum? Embed { get; set; }
        /// <summary>
        /// The video&#39;s privacy setting. When this value is &#x60;users&#x60;, &#x60;application/json&#x60; is the only valid content type. Also, Vimeo Basic members can&#39;t set this value to &#x60;disable&#x60; or &#x60;unlisted&#x60;.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can acess the video.  * &#x60;contacts&#x60; - Only the owner&#39;s contacts can access the video.  * &#x60;disable&#x60; - The video is disabled.  * &#x60;nobody&#x60; - No one except the owner can access the video.  * &#x60;password&#x60; - Only those with the password can access the video.  * &#x60;unlisted&#x60; - The video is unlisted. Anyone can access it, but it doesn&#39;t appear in search.  * &#x60;users&#x60; - Only Vimeo members can access the video. 
        /// </summary>
        /// <value>The video&#39;s privacy setting. When this value is &#x60;users&#x60;, &#x60;application/json&#x60; is the only valid content type. Also, Vimeo Basic members can&#39;t set this value to &#x60;disable&#x60; or &#x60;unlisted&#x60;.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can acess the video.  * &#x60;contacts&#x60; - Only the owner&#39;s contacts can access the video.  * &#x60;disable&#x60; - The video is disabled.  * &#x60;nobody&#x60; - No one except the owner can access the video.  * &#x60;password&#x60; - Only those with the password can access the video.  * &#x60;unlisted&#x60; - The video is unlisted. Anyone can access it, but it doesn&#39;t appear in search.  * &#x60;users&#x60; - Only Vimeo members can access the video. </value>
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
        /// The video&#39;s privacy setting. When this value is &#x60;users&#x60;, &#x60;application/json&#x60; is the only valid content type. Also, Vimeo Basic members can&#39;t set this value to &#x60;disable&#x60; or &#x60;unlisted&#x60;.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can acess the video.  * &#x60;contacts&#x60; - Only the owner&#39;s contacts can access the video.  * &#x60;disable&#x60; - The video is disabled.  * &#x60;nobody&#x60; - No one except the owner can access the video.  * &#x60;password&#x60; - Only those with the password can access the video.  * &#x60;unlisted&#x60; - The video is unlisted. Anyone can access it, but it doesn&#39;t appear in search.  * &#x60;users&#x60; - Only Vimeo members can access the video. 
        /// </summary>
        /// <value>The video&#39;s privacy setting. When this value is &#x60;users&#x60;, &#x60;application/json&#x60; is the only valid content type. Also, Vimeo Basic members can&#39;t set this value to &#x60;disable&#x60; or &#x60;unlisted&#x60;.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can acess the video.  * &#x60;contacts&#x60; - Only the owner&#39;s contacts can access the video.  * &#x60;disable&#x60; - The video is disabled.  * &#x60;nobody&#x60; - No one except the owner can access the video.  * &#x60;password&#x60; - Only those with the password can access the video.  * &#x60;unlisted&#x60; - The video is unlisted. Anyone can access it, but it doesn&#39;t appear in search.  * &#x60;users&#x60; - Only Vimeo members can access the video. </value>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public ViewEnum? View { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeVideosPrivacy1" /> class.
        /// </summary>
        /// <param name="add">Whether a user can add the video to a showcase, channel, or group..</param>
        /// <param name="comments">The privacy level required to comment on the video.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can comment on the video.  * &#x60;contacts&#x60; - Only the video owner&#39;s contacts can comment on the video.  * &#x60;nobody&#x60; - No one can comment on the video. .</param>
        /// <param name="download">Whether a user can download the video. This field isn&#39;t available to Vimeo Basic members..</param>
        /// <param name="embed">The video&#39;s embed setting. Specify the &#x60;whitelist&#x60; value to restrict embedding to a specific set of domains. For more information, see our [Interacting with Videos](https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy) guide.  Option descriptions:  * &#x60;private&#x60; - The video can&#39;t be embedded.  * &#x60;public&#x60; - The video can be embedded.  * &#x60;whitelist&#x60; - The video can be embedded on the specified domains only. .</param>
        /// <param name="view">The video&#39;s privacy setting. When this value is &#x60;users&#x60;, &#x60;application/json&#x60; is the only valid content type. Also, Vimeo Basic members can&#39;t set this value to &#x60;disable&#x60; or &#x60;unlisted&#x60;.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can acess the video.  * &#x60;contacts&#x60; - Only the owner&#39;s contacts can access the video.  * &#x60;disable&#x60; - The video is disabled.  * &#x60;nobody&#x60; - No one except the owner can access the video.  * &#x60;password&#x60; - Only those with the password can access the video.  * &#x60;unlisted&#x60; - The video is unlisted. Anyone can access it, but it doesn&#39;t appear in search.  * &#x60;users&#x60; - Only Vimeo members can access the video. .</param>
        public MeVideosPrivacy1(bool add = default(bool), CommentsEnum? comments = default(CommentsEnum?), bool download = default(bool), EmbedEnum? embed = default(EmbedEnum?), ViewEnum? view = default(ViewEnum?))
        {
            this.Add = add;
            this.Comments = comments;
            this.Download = download;
            this.Embed = embed;
            this.View = view;
        }
        
        /// <summary>
        /// Whether a user can add the video to a showcase, channel, or group.
        /// </summary>
        /// <value>Whether a user can add the video to a showcase, channel, or group.</value>
        [DataMember(Name="add", EmitDefaultValue=false)]
        public bool Add { get; set; }

        /// <summary>
        /// Whether a user can download the video. This field isn&#39;t available to Vimeo Basic members.
        /// </summary>
        /// <value>Whether a user can download the video. This field isn&#39;t available to Vimeo Basic members.</value>
        [DataMember(Name="download", EmitDefaultValue=false)]
        public bool Download { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeVideosPrivacy1 {\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  Embed: ").Append(Embed).Append("\n");
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
            return this.Equals(input as MeVideosPrivacy1);
        }

        /// <summary>
        /// Returns true if MeVideosPrivacy1 instances are equal
        /// </summary>
        /// <param name="input">Instance of MeVideosPrivacy1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeVideosPrivacy1 input)
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

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
    /// The privacy settings of the channel.
    /// </summary>
    [DataContract]
    public partial class ChannelPrivacy :  IEquatable<ChannelPrivacy>, IValidatableObject
    {
        /// <summary>
        /// The privacy setting of the channel.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the channel.  * &#x60;moderators&#x60; - Only moderators can access the channel.  * &#x60;users&#x60; - Only registered users can access the channel. 
        /// </summary>
        /// <value>The privacy setting of the channel.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the channel.  * &#x60;moderators&#x60; - Only moderators can access the channel.  * &#x60;users&#x60; - Only registered users can access the channel. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ViewEnum
        {
            /// <summary>
            /// Enum Anybody for value: anybody
            /// </summary>
            [EnumMember(Value = "anybody")]
            Anybody = 1,

            /// <summary>
            /// Enum Moderators for value: moderators
            /// </summary>
            [EnumMember(Value = "moderators")]
            Moderators = 2,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 3

        }

        /// <summary>
        /// The privacy setting of the channel.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the channel.  * &#x60;moderators&#x60; - Only moderators can access the channel.  * &#x60;users&#x60; - Only registered users can access the channel. 
        /// </summary>
        /// <value>The privacy setting of the channel.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the channel.  * &#x60;moderators&#x60; - Only moderators can access the channel.  * &#x60;users&#x60; - Only registered users can access the channel. </value>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public ViewEnum View { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelPrivacy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelPrivacy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelPrivacy" /> class.
        /// </summary>
        /// <param name="view">The privacy setting of the channel.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the channel.  * &#x60;moderators&#x60; - Only moderators can access the channel.  * &#x60;users&#x60; - Only registered users can access the channel.  (required).</param>
        public ChannelPrivacy(ViewEnum view = default(ViewEnum))
        {
            this.View = view;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelPrivacy {\n");
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
            return this.Equals(input as ChannelPrivacy);
        }

        /// <summary>
        /// Returns true if ChannelPrivacy instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelPrivacy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelPrivacy input)
        {
            if (input == null)
                return false;

            return 
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
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
    /// A collection of information about the embeddable player&#39;s title bar.
    /// </summary>
    [DataContract]
    public partial class EmbedSettingsTitle :  IEquatable<EmbedSettingsTitle>, IValidatableObject
    {
        /// <summary>
        /// How the embeddable player handles the video title.  Option descriptions:  * &#x60;hide&#x60; - The title is hidden.  * &#x60;show&#x60; - The title is shown. 
        /// </summary>
        /// <value>How the embeddable player handles the video title.  Option descriptions:  * &#x60;hide&#x60; - The title is hidden.  * &#x60;show&#x60; - The title is shown. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum Hide for value: hide
            /// </summary>
            [EnumMember(Value = "hide")]
            Hide = 1,

            /// <summary>
            /// Enum Show for value: show
            /// </summary>
            [EnumMember(Value = "show")]
            Show = 2,

            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 3

        }

        /// <summary>
        /// How the embeddable player handles the video title.  Option descriptions:  * &#x60;hide&#x60; - The title is hidden.  * &#x60;show&#x60; - The title is shown. 
        /// </summary>
        /// <value>How the embeddable player handles the video title.  Option descriptions:  * &#x60;hide&#x60; - The title is hidden.  * &#x60;show&#x60; - The title is shown. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// How the embeddable player handles the video owner&#39;s information.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s information is hidden.  * &#x60;show&#x60; - The owner&#39;s information is shown. 
        /// </summary>
        /// <value>How the embeddable player handles the video owner&#39;s information.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s information is hidden.  * &#x60;show&#x60; - The owner&#39;s information is shown. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OwnerEnum
        {
            /// <summary>
            /// Enum Hide for value: hide
            /// </summary>
            [EnumMember(Value = "hide")]
            Hide = 1,

            /// <summary>
            /// Enum Show for value: show
            /// </summary>
            [EnumMember(Value = "show")]
            Show = 2,

            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 3

        }

        /// <summary>
        /// How the embeddable player handles the video owner&#39;s information.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s information is hidden.  * &#x60;show&#x60; - The owner&#39;s information is shown. 
        /// </summary>
        /// <value>How the embeddable player handles the video owner&#39;s information.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s information is hidden.  * &#x60;show&#x60; - The owner&#39;s information is shown. </value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public OwnerEnum Owner { get; set; }
        /// <summary>
        /// How the embeddable player handles the video owner&#39;s portrait.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s portrait is hidden  * &#x60;show&#x60; - The owner&#39;s portrait is shown. 
        /// </summary>
        /// <value>How the embeddable player handles the video owner&#39;s portrait.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s portrait is hidden  * &#x60;show&#x60; - The owner&#39;s portrait is shown. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PortraitEnum
        {
            /// <summary>
            /// Enum Hide for value: hide
            /// </summary>
            [EnumMember(Value = "hide")]
            Hide = 1,

            /// <summary>
            /// Enum Show for value: show
            /// </summary>
            [EnumMember(Value = "show")]
            Show = 2,

            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 3

        }

        /// <summary>
        /// How the embeddable player handles the video owner&#39;s portrait.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s portrait is hidden  * &#x60;show&#x60; - The owner&#39;s portrait is shown. 
        /// </summary>
        /// <value>How the embeddable player handles the video owner&#39;s portrait.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s portrait is hidden  * &#x60;show&#x60; - The owner&#39;s portrait is shown. </value>
        [DataMember(Name="portrait", EmitDefaultValue=false)]
        public PortraitEnum Portrait { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedSettingsTitle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbedSettingsTitle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedSettingsTitle" /> class.
        /// </summary>
        /// <param name="name">How the embeddable player handles the video title.  Option descriptions:  * &#x60;hide&#x60; - The title is hidden.  * &#x60;show&#x60; - The title is shown.  (required).</param>
        /// <param name="owner">How the embeddable player handles the video owner&#39;s information.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s information is hidden.  * &#x60;show&#x60; - The owner&#39;s information is shown.  (required).</param>
        /// <param name="portrait">How the embeddable player handles the video owner&#39;s portrait.  Option descriptions:  * &#x60;hide&#x60; - The owner&#39;s portrait is hidden  * &#x60;show&#x60; - The owner&#39;s portrait is shown.  (required).</param>
        public EmbedSettingsTitle(NameEnum name = default(NameEnum), OwnerEnum owner = default(OwnerEnum), PortraitEnum portrait = default(PortraitEnum))
        {
            this.Name = name;
            this.Owner = owner;
            this.Portrait = portrait;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbedSettingsTitle {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Portrait: ").Append(Portrait).Append("\n");
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
            return this.Equals(input as EmbedSettingsTitle);
        }

        /// <summary>
        /// Returns true if EmbedSettingsTitle instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbedSettingsTitle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbedSettingsTitle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.Owner == input.Owner ||
                    this.Owner.Equals(input.Owner)
                ) && 
                (
                    this.Portrait == input.Portrait ||
                    this.Portrait.Equals(input.Portrait)
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
                hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Owner.GetHashCode();
                hashCode = hashCode * 59 + this.Portrait.GetHashCode();
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

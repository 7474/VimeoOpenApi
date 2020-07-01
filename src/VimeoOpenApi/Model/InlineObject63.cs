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
    /// InlineObject63
    /// </summary>
    [DataContract]
    public partial class InlineObject63 :  IEquatable<InlineObject63>, IValidatableObject
    {
        /// <summary>
        /// The type of the text track.  Option descriptions:  * &#x60;captions&#x60; - The text track is the captions type.  * &#x60;chapters&#x60; - The text track is the chapters type.  * &#x60;descriptions&#x60; - The text track is the descriptions type.  * &#x60;metadata&#x60; - The text track is the metadata type.  * &#x60;subtitles&#x60; - The text track is the subtitles type. 
        /// </summary>
        /// <value>The type of the text track.  Option descriptions:  * &#x60;captions&#x60; - The text track is the captions type.  * &#x60;chapters&#x60; - The text track is the chapters type.  * &#x60;descriptions&#x60; - The text track is the descriptions type.  * &#x60;metadata&#x60; - The text track is the metadata type.  * &#x60;subtitles&#x60; - The text track is the subtitles type. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Captions for value: captions
            /// </summary>
            [EnumMember(Value = "captions")]
            Captions = 1,

            /// <summary>
            /// Enum Chapters for value: chapters
            /// </summary>
            [EnumMember(Value = "chapters")]
            Chapters = 2,

            /// <summary>
            /// Enum Descriptions for value: descriptions
            /// </summary>
            [EnumMember(Value = "descriptions")]
            Descriptions = 3,

            /// <summary>
            /// Enum Metadata for value: metadata
            /// </summary>
            [EnumMember(Value = "metadata")]
            Metadata = 4,

            /// <summary>
            /// Enum Subtitles for value: subtitles
            /// </summary>
            [EnumMember(Value = "subtitles")]
            Subtitles = 5

        }

        /// <summary>
        /// The type of the text track.  Option descriptions:  * &#x60;captions&#x60; - The text track is the captions type.  * &#x60;chapters&#x60; - The text track is the chapters type.  * &#x60;descriptions&#x60; - The text track is the descriptions type.  * &#x60;metadata&#x60; - The text track is the metadata type.  * &#x60;subtitles&#x60; - The text track is the subtitles type. 
        /// </summary>
        /// <value>The type of the text track.  Option descriptions:  * &#x60;captions&#x60; - The text track is the captions type.  * &#x60;chapters&#x60; - The text track is the chapters type.  * &#x60;descriptions&#x60; - The text track is the descriptions type.  * &#x60;metadata&#x60; - The text track is the metadata type.  * &#x60;subtitles&#x60; - The text track is the subtitles type. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject63" /> class.
        /// </summary>
        /// <param name="active">Whether the current text track is the *active text track,* or the one that appears in the player. Only one text track per language and per type can be active..</param>
        /// <param name="language">The language of the text track. For a full list of supported languages, use the [&#x60;/languages?filter&#x3D;texttracks&#x60;](https://developer.vimeo.com/api/reference/videos#get_languages) endpoint..</param>
        /// <param name="name">The name of the text track..</param>
        /// <param name="type">The type of the text track.  Option descriptions:  * &#x60;captions&#x60; - The text track is the captions type.  * &#x60;chapters&#x60; - The text track is the chapters type.  * &#x60;descriptions&#x60; - The text track is the descriptions type.  * &#x60;metadata&#x60; - The text track is the metadata type.  * &#x60;subtitles&#x60; - The text track is the subtitles type. .</param>
        public InlineObject63(bool active = default(bool), string language = default(string), string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Active = active;
            this.Language = language;
            this.Name = name;
            this.Type = type;
        }
        
        /// <summary>
        /// Whether the current text track is the *active text track,* or the one that appears in the player. Only one text track per language and per type can be active.
        /// </summary>
        /// <value>Whether the current text track is the *active text track,* or the one that appears in the player. Only one text track per language and per type can be active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// The language of the text track. For a full list of supported languages, use the [&#x60;/languages?filter&#x3D;texttracks&#x60;](https://developer.vimeo.com/api/reference/videos#get_languages) endpoint.
        /// </summary>
        /// <value>The language of the text track. For a full list of supported languages, use the [&#x60;/languages?filter&#x3D;texttracks&#x60;](https://developer.vimeo.com/api/reference/videos#get_languages) endpoint.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The name of the text track.
        /// </summary>
        /// <value>The name of the text track.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject63 {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as InlineObject63);
        }

        /// <summary>
        /// Returns true if InlineObject63 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject63 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject63 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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

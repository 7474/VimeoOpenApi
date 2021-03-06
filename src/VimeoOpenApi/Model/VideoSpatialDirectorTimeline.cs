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
    /// VideoSpatialDirectorTimeline
    /// </summary>
    [DataContract]
    public partial class VideoSpatialDirectorTimeline :  IEquatable<VideoSpatialDirectorTimeline>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSpatialDirectorTimeline" /> class.
        /// </summary>
        /// <param name="pitch">The director timeline pitch, from -90 (minimum) to 90 (maximum)..</param>
        /// <param name="roll">The director timeline roll..</param>
        /// <param name="timeCode">The director timeline time code..</param>
        /// <param name="yaw">The director timeline yaw, from 0 (minimum) to 360 (maximum)..</param>
        public VideoSpatialDirectorTimeline(decimal pitch = default(decimal), decimal roll = default(decimal), decimal timeCode = default(decimal), decimal yaw = default(decimal))
        {
            this.Pitch = pitch;
            this.Roll = roll;
            this.TimeCode = timeCode;
            this.Yaw = yaw;
        }
        
        /// <summary>
        /// The director timeline pitch, from -90 (minimum) to 90 (maximum).
        /// </summary>
        /// <value>The director timeline pitch, from -90 (minimum) to 90 (maximum).</value>
        [DataMember(Name="pitch", EmitDefaultValue=false)]
        public decimal Pitch { get; set; }

        /// <summary>
        /// The director timeline roll.
        /// </summary>
        /// <value>The director timeline roll.</value>
        [DataMember(Name="roll", EmitDefaultValue=false)]
        public decimal Roll { get; set; }

        /// <summary>
        /// The director timeline time code.
        /// </summary>
        /// <value>The director timeline time code.</value>
        [DataMember(Name="time_code", EmitDefaultValue=false)]
        public decimal TimeCode { get; set; }

        /// <summary>
        /// The director timeline yaw, from 0 (minimum) to 360 (maximum).
        /// </summary>
        /// <value>The director timeline yaw, from 0 (minimum) to 360 (maximum).</value>
        [DataMember(Name="yaw", EmitDefaultValue=false)]
        public decimal Yaw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoSpatialDirectorTimeline {\n");
            sb.Append("  Pitch: ").Append(Pitch).Append("\n");
            sb.Append("  Roll: ").Append(Roll).Append("\n");
            sb.Append("  TimeCode: ").Append(TimeCode).Append("\n");
            sb.Append("  Yaw: ").Append(Yaw).Append("\n");
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
            return this.Equals(input as VideoSpatialDirectorTimeline);
        }

        /// <summary>
        /// Returns true if VideoSpatialDirectorTimeline instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoSpatialDirectorTimeline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoSpatialDirectorTimeline input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pitch == input.Pitch ||
                    this.Pitch.Equals(input.Pitch)
                ) && 
                (
                    this.Roll == input.Roll ||
                    this.Roll.Equals(input.Roll)
                ) && 
                (
                    this.TimeCode == input.TimeCode ||
                    this.TimeCode.Equals(input.TimeCode)
                ) && 
                (
                    this.Yaw == input.Yaw ||
                    this.Yaw.Equals(input.Yaw)
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
                hashCode = hashCode * 59 + this.Pitch.GetHashCode();
                hashCode = hashCode * 59 + this.Roll.GetHashCode();
                hashCode = hashCode * 59 + this.TimeCode.GetHashCode();
                hashCode = hashCode * 59 + this.Yaw.GetHashCode();
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

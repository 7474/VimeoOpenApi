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
    /// 360 spatial data.
    /// </summary>
    [DataContract]
    public partial class VideoSpatial :  IEquatable<VideoSpatial>, IValidatableObject
    {
        /// <summary>
        /// The 360 spatial projection:  Option descriptions:  * &#x60;cubical&#x60; - The spatial projection is cubical.  * &#x60;cylindrical&#x60; - The spatial projection is cylindrical.  * &#x60;dome&#x60; - The spatial projection is dome-shaped.  * &#x60;equirectangular&#x60; - The spatial projection is equirectangular.  * &#x60;pyramid&#x60; - The spatial projection is pyramid-shaped. 
        /// </summary>
        /// <value>The 360 spatial projection:  Option descriptions:  * &#x60;cubical&#x60; - The spatial projection is cubical.  * &#x60;cylindrical&#x60; - The spatial projection is cylindrical.  * &#x60;dome&#x60; - The spatial projection is dome-shaped.  * &#x60;equirectangular&#x60; - The spatial projection is equirectangular.  * &#x60;pyramid&#x60; - The spatial projection is pyramid-shaped. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProjectionEnum
        {
            /// <summary>
            /// Enum Cubical for value: cubical
            /// </summary>
            [EnumMember(Value = "cubical")]
            Cubical = 1,

            /// <summary>
            /// Enum Cylindrical for value: cylindrical
            /// </summary>
            [EnumMember(Value = "cylindrical")]
            Cylindrical = 2,

            /// <summary>
            /// Enum Dome for value: dome
            /// </summary>
            [EnumMember(Value = "dome")]
            Dome = 3,

            /// <summary>
            /// Enum Equirectangular for value: equirectangular
            /// </summary>
            [EnumMember(Value = "equirectangular")]
            Equirectangular = 4,

            /// <summary>
            /// Enum Pyramid for value: pyramid
            /// </summary>
            [EnumMember(Value = "pyramid")]
            Pyramid = 5

        }

        /// <summary>
        /// The 360 spatial projection:  Option descriptions:  * &#x60;cubical&#x60; - The spatial projection is cubical.  * &#x60;cylindrical&#x60; - The spatial projection is cylindrical.  * &#x60;dome&#x60; - The spatial projection is dome-shaped.  * &#x60;equirectangular&#x60; - The spatial projection is equirectangular.  * &#x60;pyramid&#x60; - The spatial projection is pyramid-shaped. 
        /// </summary>
        /// <value>The 360 spatial projection:  Option descriptions:  * &#x60;cubical&#x60; - The spatial projection is cubical.  * &#x60;cylindrical&#x60; - The spatial projection is cylindrical.  * &#x60;dome&#x60; - The spatial projection is dome-shaped.  * &#x60;equirectangular&#x60; - The spatial projection is equirectangular.  * &#x60;pyramid&#x60; - The spatial projection is pyramid-shaped. </value>
        [DataMember(Name="projection", EmitDefaultValue=true)]
        public ProjectionEnum Projection { get; set; }
        /// <summary>
        /// The 360 stereo format:  Option descriptions:  * &#x60;left-right&#x60; - The stereo format is left-right.  * &#x60;mono&#x60; - The audio is monaural.  * &#x60;top-bottom&#x60; - The stereo format is top-bottom. 
        /// </summary>
        /// <value>The 360 stereo format:  Option descriptions:  * &#x60;left-right&#x60; - The stereo format is left-right.  * &#x60;mono&#x60; - The audio is monaural.  * &#x60;top-bottom&#x60; - The stereo format is top-bottom. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StereoFormatEnum
        {
            /// <summary>
            /// Enum LeftRight for value: left-right
            /// </summary>
            [EnumMember(Value = "left-right")]
            LeftRight = 1,

            /// <summary>
            /// Enum Mono for value: mono
            /// </summary>
            [EnumMember(Value = "mono")]
            Mono = 2,

            /// <summary>
            /// Enum TopBottom for value: top-bottom
            /// </summary>
            [EnumMember(Value = "top-bottom")]
            TopBottom = 3

        }

        /// <summary>
        /// The 360 stereo format:  Option descriptions:  * &#x60;left-right&#x60; - The stereo format is left-right.  * &#x60;mono&#x60; - The audio is monaural.  * &#x60;top-bottom&#x60; - The stereo format is top-bottom. 
        /// </summary>
        /// <value>The 360 stereo format:  Option descriptions:  * &#x60;left-right&#x60; - The stereo format is left-right.  * &#x60;mono&#x60; - The audio is monaural.  * &#x60;top-bottom&#x60; - The stereo format is top-bottom. </value>
        [DataMember(Name="stereo_format", EmitDefaultValue=true)]
        public StereoFormatEnum StereoFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSpatial" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoSpatial() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSpatial" /> class.
        /// </summary>
        /// <param name="directorTimeline">360 director timeline. (required).</param>
        /// <param name="fieldOfView">The 360 field of view, from 30 (minimum) to 90 (maximum). The default is 50. (required).</param>
        /// <param name="projection">The 360 spatial projection:  Option descriptions:  * &#x60;cubical&#x60; - The spatial projection is cubical.  * &#x60;cylindrical&#x60; - The spatial projection is cylindrical.  * &#x60;dome&#x60; - The spatial projection is dome-shaped.  * &#x60;equirectangular&#x60; - The spatial projection is equirectangular.  * &#x60;pyramid&#x60; - The spatial projection is pyramid-shaped.  (required).</param>
        /// <param name="stereoFormat">The 360 stereo format:  Option descriptions:  * &#x60;left-right&#x60; - The stereo format is left-right.  * &#x60;mono&#x60; - The audio is monaural.  * &#x60;top-bottom&#x60; - The stereo format is top-bottom.  (required).</param>
        public VideoSpatial(List<VideoSpatialDirectorTimeline> directorTimeline = default(List<VideoSpatialDirectorTimeline>), decimal? fieldOfView = default(decimal?), ProjectionEnum projection = default(ProjectionEnum), StereoFormatEnum stereoFormat = default(StereoFormatEnum))
        {
            // to ensure "directorTimeline" is required (not null)
            this.DirectorTimeline = directorTimeline ?? throw new ArgumentNullException("directorTimeline is a required property for VideoSpatial and cannot be null");
            // to ensure "fieldOfView" is required (not null)
            this.FieldOfView = fieldOfView ?? throw new ArgumentNullException("fieldOfView is a required property for VideoSpatial and cannot be null");
            this.Projection = projection;
            this.StereoFormat = stereoFormat;
        }
        
        /// <summary>
        /// 360 director timeline.
        /// </summary>
        /// <value>360 director timeline.</value>
        [DataMember(Name="director_timeline", EmitDefaultValue=false)]
        public List<VideoSpatialDirectorTimeline> DirectorTimeline { get; set; }

        /// <summary>
        /// The 360 field of view, from 30 (minimum) to 90 (maximum). The default is 50.
        /// </summary>
        /// <value>The 360 field of view, from 30 (minimum) to 90 (maximum). The default is 50.</value>
        [DataMember(Name="field_of_view", EmitDefaultValue=true)]
        public decimal? FieldOfView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoSpatial {\n");
            sb.Append("  DirectorTimeline: ").Append(DirectorTimeline).Append("\n");
            sb.Append("  FieldOfView: ").Append(FieldOfView).Append("\n");
            sb.Append("  Projection: ").Append(Projection).Append("\n");
            sb.Append("  StereoFormat: ").Append(StereoFormat).Append("\n");
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
            return this.Equals(input as VideoSpatial);
        }

        /// <summary>
        /// Returns true if VideoSpatial instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoSpatial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoSpatial input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DirectorTimeline == input.DirectorTimeline ||
                    this.DirectorTimeline != null &&
                    input.DirectorTimeline != null &&
                    this.DirectorTimeline.SequenceEqual(input.DirectorTimeline)
                ) && 
                (
                    this.FieldOfView == input.FieldOfView ||
                    (this.FieldOfView != null &&
                    this.FieldOfView.Equals(input.FieldOfView))
                ) && 
                (
                    this.Projection == input.Projection ||
                    this.Projection.Equals(input.Projection)
                ) && 
                (
                    this.StereoFormat == input.StereoFormat ||
                    this.StereoFormat.Equals(input.StereoFormat)
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
                if (this.DirectorTimeline != null)
                    hashCode = hashCode * 59 + this.DirectorTimeline.GetHashCode();
                if (this.FieldOfView != null)
                    hashCode = hashCode * 59 + this.FieldOfView.GetHashCode();
                hashCode = hashCode * 59 + this.Projection.GetHashCode();
                hashCode = hashCode * 59 + this.StereoFormat.GetHashCode();
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

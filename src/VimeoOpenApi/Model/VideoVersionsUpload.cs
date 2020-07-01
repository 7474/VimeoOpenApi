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
    /// The upload information for this version.
    /// </summary>
    [DataContract]
    public partial class VideoVersionsUpload :  IEquatable<VideoVersionsUpload>, IValidatableObject
    {
        /// <summary>
        /// The approach for uploading the video.
        /// </summary>
        /// <value>The approach for uploading the video.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApproachEnum
        {
            /// <summary>
            /// Enum Post for value: post
            /// </summary>
            [EnumMember(Value = "post")]
            Post = 1,

            /// <summary>
            /// Enum Pull for value: pull
            /// </summary>
            [EnumMember(Value = "pull")]
            Pull = 2,

            /// <summary>
            /// Enum Streaming for value: streaming
            /// </summary>
            [EnumMember(Value = "streaming")]
            Streaming = 3,

            /// <summary>
            /// Enum Tus for value: tus
            /// </summary>
            [EnumMember(Value = "tus")]
            Tus = 4

        }

        /// <summary>
        /// The approach for uploading the video.
        /// </summary>
        /// <value>The approach for uploading the video.</value>
        [DataMember(Name="approach", EmitDefaultValue=false)]
        public ApproachEnum? Approach { get; set; }
        /// <summary>
        /// The status code for the availability of the uploaded video:  Option descriptions:  * &#x60;complete&#x60; - The upload is complete.  * &#x60;error&#x60; - The upload ended with an error.  * &#x60;in_progress&#x60; - The upload is underway. 
        /// </summary>
        /// <value>The status code for the availability of the uploaded video:  Option descriptions:  * &#x60;complete&#x60; - The upload is complete.  * &#x60;error&#x60; - The upload ended with an error.  * &#x60;in_progress&#x60; - The upload is underway. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Complete for value: complete
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete = 1,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 2,

            /// <summary>
            /// Enum Inprogress for value: in_progress
            /// </summary>
            [EnumMember(Value = "in_progress")]
            Inprogress = 3

        }

        /// <summary>
        /// The status code for the availability of the uploaded video:  Option descriptions:  * &#x60;complete&#x60; - The upload is complete.  * &#x60;error&#x60; - The upload ended with an error.  * &#x60;in_progress&#x60; - The upload is underway. 
        /// </summary>
        /// <value>The status code for the availability of the uploaded video:  Option descriptions:  * &#x60;complete&#x60; - The upload is complete.  * &#x60;error&#x60; - The upload ended with an error.  * &#x60;in_progress&#x60; - The upload is underway. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVersionsUpload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoVersionsUpload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVersionsUpload" /> class.
        /// </summary>
        /// <param name="approach">The approach for uploading the video..</param>
        /// <param name="completeUri">The URI for completing the upload..</param>
        /// <param name="form">The HTML form for uploading a video through the post approach..</param>
        /// <param name="link">The link of the video to capture through the pull approach..</param>
        /// <param name="redirectUrl">The redirect URL for the upload app..</param>
        /// <param name="size">The file size in bytes of the uploaded video..</param>
        /// <param name="status">The status code for the availability of the uploaded video:  Option descriptions:  * &#x60;complete&#x60; - The upload is complete.  * &#x60;error&#x60; - The upload ended with an error.  * &#x60;in_progress&#x60; - The upload is underway.  (required).</param>
        /// <param name="uploadLink">The link for sending video file data..</param>
        public VideoVersionsUpload(ApproachEnum? approach = default(ApproachEnum?), string completeUri = default(string), string form = default(string), string link = default(string), string redirectUrl = default(string), decimal size = default(decimal), StatusEnum status = default(StatusEnum), string uploadLink = default(string))
        {
            this.Status = status;
            this.Approach = approach;
            this.CompleteUri = completeUri;
            this.Form = form;
            this.Link = link;
            this.RedirectUrl = redirectUrl;
            this.Size = size;
            this.UploadLink = uploadLink;
        }
        
        /// <summary>
        /// The URI for completing the upload.
        /// </summary>
        /// <value>The URI for completing the upload.</value>
        [DataMember(Name="complete_uri", EmitDefaultValue=false)]
        public string CompleteUri { get; set; }

        /// <summary>
        /// The HTML form for uploading a video through the post approach.
        /// </summary>
        /// <value>The HTML form for uploading a video through the post approach.</value>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public string Form { get; set; }

        /// <summary>
        /// The link of the video to capture through the pull approach.
        /// </summary>
        /// <value>The link of the video to capture through the pull approach.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// The redirect URL for the upload app.
        /// </summary>
        /// <value>The redirect URL for the upload app.</value>
        [DataMember(Name="redirect_url", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The file size in bytes of the uploaded video.
        /// </summary>
        /// <value>The file size in bytes of the uploaded video.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal Size { get; set; }

        /// <summary>
        /// The link for sending video file data.
        /// </summary>
        /// <value>The link for sending video file data.</value>
        [DataMember(Name="upload_link", EmitDefaultValue=false)]
        public string UploadLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoVersionsUpload {\n");
            sb.Append("  Approach: ").Append(Approach).Append("\n");
            sb.Append("  CompleteUri: ").Append(CompleteUri).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UploadLink: ").Append(UploadLink).Append("\n");
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
            return this.Equals(input as VideoVersionsUpload);
        }

        /// <summary>
        /// Returns true if VideoVersionsUpload instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoVersionsUpload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoVersionsUpload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Approach == input.Approach ||
                    this.Approach.Equals(input.Approach)
                ) && 
                (
                    this.CompleteUri == input.CompleteUri ||
                    (this.CompleteUri != null &&
                    this.CompleteUri.Equals(input.CompleteUri))
                ) && 
                (
                    this.Form == input.Form ||
                    (this.Form != null &&
                    this.Form.Equals(input.Form))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.UploadLink == input.UploadLink ||
                    (this.UploadLink != null &&
                    this.UploadLink.Equals(input.UploadLink))
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
                hashCode = hashCode * 59 + this.Approach.GetHashCode();
                if (this.CompleteUri != null)
                    hashCode = hashCode * 59 + this.CompleteUri.GetHashCode();
                if (this.Form != null)
                    hashCode = hashCode * 59 + this.Form.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UploadLink != null)
                    hashCode = hashCode * 59 + this.UploadLink.GetHashCode();
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

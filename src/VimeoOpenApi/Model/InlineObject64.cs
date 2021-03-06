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
    /// InlineObject64
    /// </summary>
    [DataContract]
    public partial class InlineObject64 :  IEquatable<InlineObject64>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject64" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject64() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject64" /> class.
        /// </summary>
        /// <param name="fileName">The name of the version. (required).</param>
        /// <param name="upload">upload (required).</param>
        public InlineObject64(string fileName = default(string), VideosVideoIdVersionsUpload upload = default(VideosVideoIdVersionsUpload))
        {
            // to ensure "fileName" is required (not null)
            this.FileName = fileName ?? throw new ArgumentNullException("fileName is a required property for InlineObject64 and cannot be null");
            // to ensure "upload" is required (not null)
            this.Upload = upload ?? throw new ArgumentNullException("upload is a required property for InlineObject64 and cannot be null");
        }
        
        /// <summary>
        /// The name of the version.
        /// </summary>
        /// <value>The name of the version.</value>
        [DataMember(Name="file_name", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets Upload
        /// </summary>
        [DataMember(Name="upload", EmitDefaultValue=false)]
        public VideosVideoIdVersionsUpload Upload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject64 {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Upload: ").Append(Upload).Append("\n");
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
            return this.Equals(input as InlineObject64);
        }

        /// <summary>
        /// Returns true if InlineObject64 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject64 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject64 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Upload == input.Upload ||
                    (this.Upload != null &&
                    this.Upload.Equals(input.Upload))
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
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Upload != null)
                    hashCode = hashCode * 59 + this.Upload.GetHashCode();
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

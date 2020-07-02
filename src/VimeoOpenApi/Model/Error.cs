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
    /// Error
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Error() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="developerMessage">The error message that technical users receive. (required).</param>
        /// <param name="error">The error message that general users receive. (required).</param>
        /// <param name="errorCode">The error code. (required).</param>
        /// <param name="link">A link to more information about the error. (required).</param>
        public Error(string developerMessage = default(string), string error = default(string), decimal errorCode = default(decimal), string link = default(string))
        {
            // to ensure "developerMessage" is required (not null)
            this.DeveloperMessage = developerMessage ?? throw new ArgumentNullException("developerMessage is a required property for Error and cannot be null");
            // to ensure "error" is required (not null)
            this._Error = error ?? throw new ArgumentNullException("error is a required property for Error and cannot be null");
            this.ErrorCode = errorCode;
            // to ensure "link" is required (not null)
            this.Link = link ?? throw new ArgumentNullException("link is a required property for Error and cannot be null");
        }
        
        /// <summary>
        /// The error message that technical users receive.
        /// </summary>
        /// <value>The error message that technical users receive.</value>
        [DataMember(Name="developer_message", EmitDefaultValue=false)]
        public string DeveloperMessage { get; set; }

        /// <summary>
        /// The error message that general users receive.
        /// </summary>
        /// <value>The error message that general users receive.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string _Error { get; set; }

        /// <summary>
        /// The error code.
        /// </summary>
        /// <value>The error code.</value>
        [DataMember(Name="error_code", EmitDefaultValue=false)]
        public decimal ErrorCode { get; set; }

        /// <summary>
        /// A link to more information about the error.
        /// </summary>
        /// <value>A link to more information about the error.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  DeveloperMessage: ").Append(DeveloperMessage).Append("\n");
            sb.Append("  _Error: ").Append(_Error).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeveloperMessage == input.DeveloperMessage ||
                    (this.DeveloperMessage != null &&
                    this.DeveloperMessage.Equals(input.DeveloperMessage))
                ) && 
                (
                    this._Error == input._Error ||
                    (this._Error != null &&
                    this._Error.Equals(input._Error))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    this.ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.DeveloperMessage != null)
                    hashCode = hashCode * 59 + this.DeveloperMessage.GetHashCode();
                if (this._Error != null)
                    hashCode = hashCode * 59 + this._Error.GetHashCode();
                hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
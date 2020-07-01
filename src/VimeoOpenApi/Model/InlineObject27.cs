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
    /// InlineObject27
    /// </summary>
    [DataContract]
    public partial class InlineObject27 :  IEquatable<InlineObject27>, IValidatableObject
    {
        /// <summary>
        /// The grant type. The value of this field must be &#x60;authorization_code&#x60;.
        /// </summary>
        /// <value>The grant type. The value of this field must be &#x60;authorization_code&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GrantTypeEnum
        {
            /// <summary>
            /// Enum Authorizationcode for value: authorization_code
            /// </summary>
            [EnumMember(Value = "authorization_code")]
            Authorizationcode = 1

        }

        /// <summary>
        /// The grant type. The value of this field must be &#x60;authorization_code&#x60;.
        /// </summary>
        /// <value>The grant type. The value of this field must be &#x60;authorization_code&#x60;.</value>
        [DataMember(Name="grant_type", EmitDefaultValue=false)]
        public GrantTypeEnum GrantType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject27" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject27() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject27" /> class.
        /// </summary>
        /// <param name="code">The authorization code received from the authorization server. (required).</param>
        /// <param name="grantType">The grant type. The value of this field must be &#x60;authorization_code&#x60;. (required).</param>
        /// <param name="redirectUri">The redirect URI. The value of this field must match the URI from &#x60;/oauth/authorize&#x60;. (required).</param>
        public InlineObject27(string code = default(string), GrantTypeEnum grantType = default(GrantTypeEnum), string redirectUri = default(string))
        {
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for InlineObject27 and cannot be null");
            this.GrantType = grantType;
            // to ensure "redirectUri" is required (not null)
            this.RedirectUri = redirectUri ?? throw new ArgumentNullException("redirectUri is a required property for InlineObject27 and cannot be null");
        }
        
        /// <summary>
        /// The authorization code received from the authorization server.
        /// </summary>
        /// <value>The authorization code received from the authorization server.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The redirect URI. The value of this field must match the URI from &#x60;/oauth/authorize&#x60;.
        /// </summary>
        /// <value>The redirect URI. The value of this field must match the URI from &#x60;/oauth/authorize&#x60;.</value>
        [DataMember(Name="redirect_uri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject27 {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
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
            return this.Equals(input as InlineObject27);
        }

        /// <summary>
        /// Returns true if InlineObject27 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject27 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject27 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.GrantType == input.GrantType ||
                    this.GrantType.Equals(input.GrantType)
                ) && 
                (
                    this.RedirectUri == input.RedirectUri ||
                    (this.RedirectUri != null &&
                    this.RedirectUri.Equals(input.RedirectUri))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.GrantType.GetHashCode();
                if (this.RedirectUri != null)
                    hashCode = hashCode * 59 + this.RedirectUri.GetHashCode();
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

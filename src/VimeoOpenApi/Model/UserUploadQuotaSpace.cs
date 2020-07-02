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
    /// Information about the authenticated user&#39;s upload space remaining for the current period.
    /// </summary>
    [DataContract]
    public partial class UserUploadQuotaSpace :  IEquatable<UserUploadQuotaSpace>, IValidatableObject
    {
        /// <summary>
        /// Whether the values of the upload_quota.space fields are for the lifetime quota or the periodic quota.
        /// </summary>
        /// <value>Whether the values of the upload_quota.space fields are for the lifetime quota or the periodic quota.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShowingEnum
        {
            /// <summary>
            /// Enum Lifetime for value: lifetime
            /// </summary>
            [EnumMember(Value = "lifetime")]
            Lifetime = 1,

            /// <summary>
            /// Enum Periodic for value: periodic
            /// </summary>
            [EnumMember(Value = "periodic")]
            Periodic = 2

        }

        /// <summary>
        /// Whether the values of the upload_quota.space fields are for the lifetime quota or the periodic quota.
        /// </summary>
        /// <value>Whether the values of the upload_quota.space fields are for the lifetime quota or the periodic quota.</value>
        [DataMember(Name="showing", EmitDefaultValue=false)]
        public ShowingEnum Showing { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUploadQuotaSpace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserUploadQuotaSpace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUploadQuotaSpace" /> class.
        /// </summary>
        /// <param name="free">The number of bytes remaining in the authenticated user&#39;s upload quota. (required).</param>
        /// <param name="max">The maximum number of bytes allotted to the authenticated user&#39;s upload quota. (required).</param>
        /// <param name="showing">Whether the values of the upload_quota.space fields are for the lifetime quota or the periodic quota. (required).</param>
        /// <param name="used">The number of bytes that the authenticated user has already uploaded against their quota. (required).</param>
        public UserUploadQuotaSpace(decimal free = default(decimal), decimal? max = default(decimal?), ShowingEnum showing = default(ShowingEnum), decimal used = default(decimal))
        {
            this.Free = free;
            // to ensure "max" is required (not null)
            this.Max = max ?? throw new ArgumentNullException("max is a required property for UserUploadQuotaSpace and cannot be null");
            this.Showing = showing;
            this.Used = used;
        }
        
        /// <summary>
        /// The number of bytes remaining in the authenticated user&#39;s upload quota.
        /// </summary>
        /// <value>The number of bytes remaining in the authenticated user&#39;s upload quota.</value>
        [DataMember(Name="free", EmitDefaultValue=false)]
        public decimal Free { get; set; }

        /// <summary>
        /// The maximum number of bytes allotted to the authenticated user&#39;s upload quota.
        /// </summary>
        /// <value>The maximum number of bytes allotted to the authenticated user&#39;s upload quota.</value>
        [DataMember(Name="max", EmitDefaultValue=true)]
        public decimal? Max { get; set; }

        /// <summary>
        /// The number of bytes that the authenticated user has already uploaded against their quota.
        /// </summary>
        /// <value>The number of bytes that the authenticated user has already uploaded against their quota.</value>
        [DataMember(Name="used", EmitDefaultValue=false)]
        public decimal Used { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUploadQuotaSpace {\n");
            sb.Append("  Free: ").Append(Free).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Showing: ").Append(Showing).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
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
            return this.Equals(input as UserUploadQuotaSpace);
        }

        /// <summary>
        /// Returns true if UserUploadQuotaSpace instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUploadQuotaSpace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUploadQuotaSpace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Free == input.Free ||
                    this.Free.Equals(input.Free)
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.Showing == input.Showing ||
                    this.Showing.Equals(input.Showing)
                ) && 
                (
                    this.Used == input.Used ||
                    this.Used.Equals(input.Used)
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
                hashCode = hashCode * 59 + this.Free.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                hashCode = hashCode * 59 + this.Showing.GetHashCode();
                hashCode = hashCode * 59 + this.Used.GetHashCode();
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
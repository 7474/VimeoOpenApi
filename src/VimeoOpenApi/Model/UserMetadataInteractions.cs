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
    /// UserMetadataInteractions
    /// </summary>
    [DataContract]
    public partial class UserMetadataInteractions :  IEquatable<UserMetadataInteractions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetadataInteractions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserMetadataInteractions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetadataInteractions" /> class.
        /// </summary>
        /// <param name="addPrivacyUser">addPrivacyUser.</param>
        /// <param name="block">block (required).</param>
        /// <param name="connectedApps">connectedApps (required).</param>
        /// <param name="follow">follow (required).</param>
        /// <param name="report">report (required).</param>
        public UserMetadataInteractions(UserMetadataInteractionsAddPrivacyUser addPrivacyUser = default(UserMetadataInteractionsAddPrivacyUser), UserMetadataInteractionsBlock block = default(UserMetadataInteractionsBlock), UserMetadataInteractionsConnectedApps connectedApps = default(UserMetadataInteractionsConnectedApps), UserMetadataInteractionsFollow follow = default(UserMetadataInteractionsFollow), UserMetadataInteractionsReport report = default(UserMetadataInteractionsReport))
        {
            // to ensure "block" is required (not null)
            this.Block = block ?? throw new ArgumentNullException("block is a required property for UserMetadataInteractions and cannot be null");
            // to ensure "connectedApps" is required (not null)
            this.ConnectedApps = connectedApps ?? throw new ArgumentNullException("connectedApps is a required property for UserMetadataInteractions and cannot be null");
            // to ensure "follow" is required (not null)
            this.Follow = follow ?? throw new ArgumentNullException("follow is a required property for UserMetadataInteractions and cannot be null");
            // to ensure "report" is required (not null)
            this.Report = report ?? throw new ArgumentNullException("report is a required property for UserMetadataInteractions and cannot be null");
            this.AddPrivacyUser = addPrivacyUser;
        }
        
        /// <summary>
        /// Gets or Sets AddPrivacyUser
        /// </summary>
        [DataMember(Name="add_privacy_user", EmitDefaultValue=false)]
        public UserMetadataInteractionsAddPrivacyUser AddPrivacyUser { get; set; }

        /// <summary>
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public UserMetadataInteractionsBlock Block { get; set; }

        /// <summary>
        /// Gets or Sets ConnectedApps
        /// </summary>
        [DataMember(Name="connected_apps", EmitDefaultValue=false)]
        public UserMetadataInteractionsConnectedApps ConnectedApps { get; set; }

        /// <summary>
        /// Gets or Sets Follow
        /// </summary>
        [DataMember(Name="follow", EmitDefaultValue=false)]
        public UserMetadataInteractionsFollow Follow { get; set; }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name="report", EmitDefaultValue=false)]
        public UserMetadataInteractionsReport Report { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserMetadataInteractions {\n");
            sb.Append("  AddPrivacyUser: ").Append(AddPrivacyUser).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  ConnectedApps: ").Append(ConnectedApps).Append("\n");
            sb.Append("  Follow: ").Append(Follow).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
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
            return this.Equals(input as UserMetadataInteractions);
        }

        /// <summary>
        /// Returns true if UserMetadataInteractions instances are equal
        /// </summary>
        /// <param name="input">Instance of UserMetadataInteractions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserMetadataInteractions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddPrivacyUser == input.AddPrivacyUser ||
                    (this.AddPrivacyUser != null &&
                    this.AddPrivacyUser.Equals(input.AddPrivacyUser))
                ) && 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.ConnectedApps == input.ConnectedApps ||
                    (this.ConnectedApps != null &&
                    this.ConnectedApps.Equals(input.ConnectedApps))
                ) && 
                (
                    this.Follow == input.Follow ||
                    (this.Follow != null &&
                    this.Follow.Equals(input.Follow))
                ) && 
                (
                    this.Report == input.Report ||
                    (this.Report != null &&
                    this.Report.Equals(input.Report))
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
                if (this.AddPrivacyUser != null)
                    hashCode = hashCode * 59 + this.AddPrivacyUser.GetHashCode();
                if (this.Block != null)
                    hashCode = hashCode * 59 + this.Block.GetHashCode();
                if (this.ConnectedApps != null)
                    hashCode = hashCode * 59 + this.ConnectedApps.GetHashCode();
                if (this.Follow != null)
                    hashCode = hashCode * 59 + this.Follow.GetHashCode();
                if (this.Report != null)
                    hashCode = hashCode * 59 + this.Report.GetHashCode();
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

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
    /// InlineObject30
    /// </summary>
    [DataContract]
    public partial class InlineObject30 :  IEquatable<InlineObject30>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject30" /> class.
        /// </summary>
        /// <param name="link">The custom string to use in the Vimeo URL of the On Demand page..</param>
        /// <param name="preorder">preorder.</param>
        /// <param name="publish">publish.</param>
        /// <param name="publishWhenReady">Whether to publish the On Demand page automatically after all videos are finished transcoding..</param>
        public InlineObject30(string link = default(string), OndemandPagesOndemandIdPreorder preorder = default(OndemandPagesOndemandIdPreorder), OndemandPagesOndemandIdPublish publish = default(OndemandPagesOndemandIdPublish), bool publishWhenReady = default(bool))
        {
            this.Link = link;
            this.Preorder = preorder;
            this.Publish = publish;
            this.PublishWhenReady = publishWhenReady;
        }
        
        /// <summary>
        /// The custom string to use in the Vimeo URL of the On Demand page.
        /// </summary>
        /// <value>The custom string to use in the Vimeo URL of the On Demand page.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets Preorder
        /// </summary>
        [DataMember(Name="preorder", EmitDefaultValue=false)]
        public OndemandPagesOndemandIdPreorder Preorder { get; set; }

        /// <summary>
        /// Gets or Sets Publish
        /// </summary>
        [DataMember(Name="publish", EmitDefaultValue=false)]
        public OndemandPagesOndemandIdPublish Publish { get; set; }

        /// <summary>
        /// Whether to publish the On Demand page automatically after all videos are finished transcoding.
        /// </summary>
        /// <value>Whether to publish the On Demand page automatically after all videos are finished transcoding.</value>
        [DataMember(Name="publish_when_ready", EmitDefaultValue=false)]
        public bool PublishWhenReady { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject30 {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Preorder: ").Append(Preorder).Append("\n");
            sb.Append("  Publish: ").Append(Publish).Append("\n");
            sb.Append("  PublishWhenReady: ").Append(PublishWhenReady).Append("\n");
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
            return this.Equals(input as InlineObject30);
        }

        /// <summary>
        /// Returns true if InlineObject30 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject30 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject30 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Preorder == input.Preorder ||
                    (this.Preorder != null &&
                    this.Preorder.Equals(input.Preorder))
                ) && 
                (
                    this.Publish == input.Publish ||
                    (this.Publish != null &&
                    this.Publish.Equals(input.Publish))
                ) && 
                (
                    this.PublishWhenReady == input.PublishWhenReady ||
                    this.PublishWhenReady.Equals(input.PublishWhenReady)
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
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Preorder != null)
                    hashCode = hashCode * 59 + this.Preorder.GetHashCode();
                if (this.Publish != null)
                    hashCode = hashCode * 59 + this.Publish.GetHashCode();
                hashCode = hashCode * 59 + this.PublishWhenReady.GetHashCode();
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

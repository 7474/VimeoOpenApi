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
    /// A list of resource URIs related to the activity.
    /// </summary>
    [DataContract]
    public partial class Activity31MetadataConnections :  IEquatable<Activity31MetadataConnections>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity31MetadataConnections" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Activity31MetadataConnections() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity31MetadataConnections" /> class.
        /// </summary>
        /// <param name="related">related (required).</param>
        public Activity31MetadataConnections(Activity31MetadataConnectionsRelated related = default(Activity31MetadataConnectionsRelated))
        {
            // to ensure "related" is required (not null)
            this.Related = related ?? throw new ArgumentNullException("related is a required property for Activity31MetadataConnections and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name="related", EmitDefaultValue=true)]
        public Activity31MetadataConnectionsRelated Related { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activity31MetadataConnections {\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
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
            return this.Equals(input as Activity31MetadataConnections);
        }

        /// <summary>
        /// Returns true if Activity31MetadataConnections instances are equal
        /// </summary>
        /// <param name="input">Instance of Activity31MetadataConnections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity31MetadataConnections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Related == input.Related ||
                    (this.Related != null &&
                    this.Related.Equals(input.Related))
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
                if (this.Related != null)
                    hashCode = hashCode * 59 + this.Related.GetHashCode();
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

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
    /// MeOndemandPagesBuy
    /// </summary>
    [DataContract]
    public partial class MeOndemandPagesBuy :  IEquatable<MeOndemandPagesBuy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeOndemandPagesBuy" /> class.
        /// </summary>
        /// <param name="active">Whether the video can be purchased. This parameter is required when **rent.active** is &#x60;false&#x60;..</param>
        /// <param name="download">Whether people who buy the video can download it. To use this parameter, **type** must be &#x60;film&#x60;..</param>
        /// <param name="price">price.</param>
        public MeOndemandPagesBuy(bool active = default(bool), bool download = default(bool), MeOndemandPagesBuyPrice price = default(MeOndemandPagesBuyPrice))
        {
            this.Active = active;
            this.Download = download;
            this.Price = price;
        }
        
        /// <summary>
        /// Whether the video can be purchased. This parameter is required when **rent.active** is &#x60;false&#x60;.
        /// </summary>
        /// <value>Whether the video can be purchased. This parameter is required when **rent.active** is &#x60;false&#x60;.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// Whether people who buy the video can download it. To use this parameter, **type** must be &#x60;film&#x60;.
        /// </summary>
        /// <value>Whether people who buy the video can download it. To use this parameter, **type** must be &#x60;film&#x60;.</value>
        [DataMember(Name="download", EmitDefaultValue=false)]
        public bool Download { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public MeOndemandPagesBuyPrice Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeOndemandPagesBuy {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
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
            return this.Equals(input as MeOndemandPagesBuy);
        }

        /// <summary>
        /// Returns true if MeOndemandPagesBuy instances are equal
        /// </summary>
        /// <param name="input">Instance of MeOndemandPagesBuy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeOndemandPagesBuy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Download == input.Download ||
                    this.Download.Equals(input.Download)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
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
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                hashCode = hashCode * 59 + this.Download.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
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
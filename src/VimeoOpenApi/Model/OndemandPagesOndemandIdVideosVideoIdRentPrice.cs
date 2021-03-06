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
    /// OndemandPagesOndemandIdVideosVideoIdRentPrice
    /// </summary>
    [DataContract]
    public partial class OndemandPagesOndemandIdVideosVideoIdRentPrice :  IEquatable<OndemandPagesOndemandIdVideosVideoIdRentPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OndemandPagesOndemandIdVideosVideoIdRentPrice" /> class.
        /// </summary>
        /// <param name="aUD">The rental price of the video in Australian dollars..</param>
        /// <param name="cAD">The rental price of the video in Canadian dollars..</param>
        /// <param name="cHF">The rental price of the video in Swiss francs..</param>
        /// <param name="dKK">The rental price of the video in Danish krone..</param>
        /// <param name="eUR">The rental price of the video in euros..</param>
        /// <param name="gBP">The rental price of the video in British pounds..</param>
        /// <param name="jPY">The rental price of the video in Japanese yen..</param>
        /// <param name="kRW">The rental price of the video in South Korean won..</param>
        /// <param name="nOK">The rental price of the video in Norwegian krone..</param>
        /// <param name="pLN">The rental price of the video in Polish zloty..</param>
        /// <param name="sEK">The rental price of the video in Swedish krona..</param>
        /// <param name="uSD">The rental price of the video in United States dollars. This field is required when **rent.active** is &#x60;true&#x60;..</param>
        public OndemandPagesOndemandIdVideosVideoIdRentPrice(decimal aUD = default(decimal), decimal cAD = default(decimal), decimal cHF = default(decimal), decimal dKK = default(decimal), decimal eUR = default(decimal), decimal gBP = default(decimal), decimal jPY = default(decimal), decimal kRW = default(decimal), decimal nOK = default(decimal), decimal pLN = default(decimal), decimal sEK = default(decimal), decimal uSD = default(decimal))
        {
            this.AUD = aUD;
            this.CAD = cAD;
            this.CHF = cHF;
            this.DKK = dKK;
            this.EUR = eUR;
            this.GBP = gBP;
            this.JPY = jPY;
            this.KRW = kRW;
            this.NOK = nOK;
            this.PLN = pLN;
            this.SEK = sEK;
            this.USD = uSD;
        }
        
        /// <summary>
        /// The rental price of the video in Australian dollars.
        /// </summary>
        /// <value>The rental price of the video in Australian dollars.</value>
        [DataMember(Name="AUD", EmitDefaultValue=false)]
        public decimal AUD { get; set; }

        /// <summary>
        /// The rental price of the video in Canadian dollars.
        /// </summary>
        /// <value>The rental price of the video in Canadian dollars.</value>
        [DataMember(Name="CAD", EmitDefaultValue=false)]
        public decimal CAD { get; set; }

        /// <summary>
        /// The rental price of the video in Swiss francs.
        /// </summary>
        /// <value>The rental price of the video in Swiss francs.</value>
        [DataMember(Name="CHF", EmitDefaultValue=false)]
        public decimal CHF { get; set; }

        /// <summary>
        /// The rental price of the video in Danish krone.
        /// </summary>
        /// <value>The rental price of the video in Danish krone.</value>
        [DataMember(Name="DKK", EmitDefaultValue=false)]
        public decimal DKK { get; set; }

        /// <summary>
        /// The rental price of the video in euros.
        /// </summary>
        /// <value>The rental price of the video in euros.</value>
        [DataMember(Name="EUR", EmitDefaultValue=false)]
        public decimal EUR { get; set; }

        /// <summary>
        /// The rental price of the video in British pounds.
        /// </summary>
        /// <value>The rental price of the video in British pounds.</value>
        [DataMember(Name="GBP", EmitDefaultValue=false)]
        public decimal GBP { get; set; }

        /// <summary>
        /// The rental price of the video in Japanese yen.
        /// </summary>
        /// <value>The rental price of the video in Japanese yen.</value>
        [DataMember(Name="JPY", EmitDefaultValue=false)]
        public decimal JPY { get; set; }

        /// <summary>
        /// The rental price of the video in South Korean won.
        /// </summary>
        /// <value>The rental price of the video in South Korean won.</value>
        [DataMember(Name="KRW", EmitDefaultValue=false)]
        public decimal KRW { get; set; }

        /// <summary>
        /// The rental price of the video in Norwegian krone.
        /// </summary>
        /// <value>The rental price of the video in Norwegian krone.</value>
        [DataMember(Name="NOK", EmitDefaultValue=false)]
        public decimal NOK { get; set; }

        /// <summary>
        /// The rental price of the video in Polish zloty.
        /// </summary>
        /// <value>The rental price of the video in Polish zloty.</value>
        [DataMember(Name="PLN", EmitDefaultValue=false)]
        public decimal PLN { get; set; }

        /// <summary>
        /// The rental price of the video in Swedish krona.
        /// </summary>
        /// <value>The rental price of the video in Swedish krona.</value>
        [DataMember(Name="SEK", EmitDefaultValue=false)]
        public decimal SEK { get; set; }

        /// <summary>
        /// The rental price of the video in United States dollars. This field is required when **rent.active** is &#x60;true&#x60;.
        /// </summary>
        /// <value>The rental price of the video in United States dollars. This field is required when **rent.active** is &#x60;true&#x60;.</value>
        [DataMember(Name="USD", EmitDefaultValue=false)]
        public decimal USD { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OndemandPagesOndemandIdVideosVideoIdRentPrice {\n");
            sb.Append("  AUD: ").Append(AUD).Append("\n");
            sb.Append("  CAD: ").Append(CAD).Append("\n");
            sb.Append("  CHF: ").Append(CHF).Append("\n");
            sb.Append("  DKK: ").Append(DKK).Append("\n");
            sb.Append("  EUR: ").Append(EUR).Append("\n");
            sb.Append("  GBP: ").Append(GBP).Append("\n");
            sb.Append("  JPY: ").Append(JPY).Append("\n");
            sb.Append("  KRW: ").Append(KRW).Append("\n");
            sb.Append("  NOK: ").Append(NOK).Append("\n");
            sb.Append("  PLN: ").Append(PLN).Append("\n");
            sb.Append("  SEK: ").Append(SEK).Append("\n");
            sb.Append("  USD: ").Append(USD).Append("\n");
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
            return this.Equals(input as OndemandPagesOndemandIdVideosVideoIdRentPrice);
        }

        /// <summary>
        /// Returns true if OndemandPagesOndemandIdVideosVideoIdRentPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of OndemandPagesOndemandIdVideosVideoIdRentPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OndemandPagesOndemandIdVideosVideoIdRentPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AUD == input.AUD ||
                    this.AUD.Equals(input.AUD)
                ) && 
                (
                    this.CAD == input.CAD ||
                    this.CAD.Equals(input.CAD)
                ) && 
                (
                    this.CHF == input.CHF ||
                    this.CHF.Equals(input.CHF)
                ) && 
                (
                    this.DKK == input.DKK ||
                    this.DKK.Equals(input.DKK)
                ) && 
                (
                    this.EUR == input.EUR ||
                    this.EUR.Equals(input.EUR)
                ) && 
                (
                    this.GBP == input.GBP ||
                    this.GBP.Equals(input.GBP)
                ) && 
                (
                    this.JPY == input.JPY ||
                    this.JPY.Equals(input.JPY)
                ) && 
                (
                    this.KRW == input.KRW ||
                    this.KRW.Equals(input.KRW)
                ) && 
                (
                    this.NOK == input.NOK ||
                    this.NOK.Equals(input.NOK)
                ) && 
                (
                    this.PLN == input.PLN ||
                    this.PLN.Equals(input.PLN)
                ) && 
                (
                    this.SEK == input.SEK ||
                    this.SEK.Equals(input.SEK)
                ) && 
                (
                    this.USD == input.USD ||
                    this.USD.Equals(input.USD)
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
                hashCode = hashCode * 59 + this.AUD.GetHashCode();
                hashCode = hashCode * 59 + this.CAD.GetHashCode();
                hashCode = hashCode * 59 + this.CHF.GetHashCode();
                hashCode = hashCode * 59 + this.DKK.GetHashCode();
                hashCode = hashCode * 59 + this.EUR.GetHashCode();
                hashCode = hashCode * 59 + this.GBP.GetHashCode();
                hashCode = hashCode * 59 + this.JPY.GetHashCode();
                hashCode = hashCode * 59 + this.KRW.GetHashCode();
                hashCode = hashCode * 59 + this.NOK.GetHashCode();
                hashCode = hashCode * 59 + this.PLN.GetHashCode();
                hashCode = hashCode * 59 + this.SEK.GetHashCode();
                hashCode = hashCode * 59 + this.USD.GetHashCode();
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

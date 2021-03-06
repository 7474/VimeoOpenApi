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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// The user&#39;s account type:  Option descriptions:  * &#x60;basic&#x60; - The user has a Vimeo Basic subscription.  * &#x60;business&#x60; - The user has a Vimeo Business subscription.  * &#x60;live_business&#x60; - The user has a Vimeo Business Live subscription.  * &#x60;live_premium&#x60; - The user has a Vimeo Premium subscription.  * &#x60;live_pro&#x60; - The user has a Vimeo PRO Live subscription.  * &#x60;plus&#x60; - The user has a Vimeo Plus subscription.  * &#x60;pro&#x60; - The user has a Vimeo Pro subscription.  * &#x60;pro_unlimited&#x60; - The user has a Vimeo PRO Unlimited subscription.  * &#x60;producer&#x60; - The user has a Vimeo Producer subscription. 
        /// </summary>
        /// <value>The user&#39;s account type:  Option descriptions:  * &#x60;basic&#x60; - The user has a Vimeo Basic subscription.  * &#x60;business&#x60; - The user has a Vimeo Business subscription.  * &#x60;live_business&#x60; - The user has a Vimeo Business Live subscription.  * &#x60;live_premium&#x60; - The user has a Vimeo Premium subscription.  * &#x60;live_pro&#x60; - The user has a Vimeo PRO Live subscription.  * &#x60;plus&#x60; - The user has a Vimeo Plus subscription.  * &#x60;pro&#x60; - The user has a Vimeo Pro subscription.  * &#x60;pro_unlimited&#x60; - The user has a Vimeo PRO Unlimited subscription.  * &#x60;producer&#x60; - The user has a Vimeo Producer subscription. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountEnum
        {
            /// <summary>
            /// Enum Basic for value: basic
            /// </summary>
            [EnumMember(Value = "basic")]
            Basic = 1,

            /// <summary>
            /// Enum Business for value: business
            /// </summary>
            [EnumMember(Value = "business")]
            Business = 2,

            /// <summary>
            /// Enum Livebusiness for value: live_business
            /// </summary>
            [EnumMember(Value = "live_business")]
            Livebusiness = 3,

            /// <summary>
            /// Enum Livepremium for value: live_premium
            /// </summary>
            [EnumMember(Value = "live_premium")]
            Livepremium = 4,

            /// <summary>
            /// Enum Livepro for value: live_pro
            /// </summary>
            [EnumMember(Value = "live_pro")]
            Livepro = 5,

            /// <summary>
            /// Enum Plus for value: plus
            /// </summary>
            [EnumMember(Value = "plus")]
            Plus = 6,

            /// <summary>
            /// Enum Pro for value: pro
            /// </summary>
            [EnumMember(Value = "pro")]
            Pro = 7,

            /// <summary>
            /// Enum Prounlimited for value: pro_unlimited
            /// </summary>
            [EnumMember(Value = "pro_unlimited")]
            Prounlimited = 8,

            /// <summary>
            /// Enum Producer for value: producer
            /// </summary>
            [EnumMember(Value = "producer")]
            Producer = 9

        }

        /// <summary>
        /// The user&#39;s account type:  Option descriptions:  * &#x60;basic&#x60; - The user has a Vimeo Basic subscription.  * &#x60;business&#x60; - The user has a Vimeo Business subscription.  * &#x60;live_business&#x60; - The user has a Vimeo Business Live subscription.  * &#x60;live_premium&#x60; - The user has a Vimeo Premium subscription.  * &#x60;live_pro&#x60; - The user has a Vimeo PRO Live subscription.  * &#x60;plus&#x60; - The user has a Vimeo Plus subscription.  * &#x60;pro&#x60; - The user has a Vimeo Pro subscription.  * &#x60;pro_unlimited&#x60; - The user has a Vimeo PRO Unlimited subscription.  * &#x60;producer&#x60; - The user has a Vimeo Producer subscription. 
        /// </summary>
        /// <value>The user&#39;s account type:  Option descriptions:  * &#x60;basic&#x60; - The user has a Vimeo Basic subscription.  * &#x60;business&#x60; - The user has a Vimeo Business subscription.  * &#x60;live_business&#x60; - The user has a Vimeo Business Live subscription.  * &#x60;live_premium&#x60; - The user has a Vimeo Premium subscription.  * &#x60;live_pro&#x60; - The user has a Vimeo PRO Live subscription.  * &#x60;plus&#x60; - The user has a Vimeo Plus subscription.  * &#x60;pro&#x60; - The user has a Vimeo Pro subscription.  * &#x60;pro_unlimited&#x60; - The user has a Vimeo PRO Unlimited subscription.  * &#x60;producer&#x60; - The user has a Vimeo Producer subscription. </value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public AccountEnum Account { get; set; }
        /// <summary>
        /// Defines ContentFilter
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContentFilterEnum
        {
            /// <summary>
            /// Enum Drugs for value: drugs
            /// </summary>
            [EnumMember(Value = "drugs")]
            Drugs = 1,

            /// <summary>
            /// Enum Language for value: language
            /// </summary>
            [EnumMember(Value = "language")]
            Language = 2,

            /// <summary>
            /// Enum Nudity for value: nudity
            /// </summary>
            [EnumMember(Value = "nudity")]
            Nudity = 3,

            /// <summary>
            /// Enum Safe for value: safe
            /// </summary>
            [EnumMember(Value = "safe")]
            Safe = 4,

            /// <summary>
            /// Enum Unrated for value: unrated
            /// </summary>
            [EnumMember(Value = "unrated")]
            Unrated = 5,

            /// <summary>
            /// Enum Violence for value: violence
            /// </summary>
            [EnumMember(Value = "violence")]
            Violence = 6

        }


        /// <summary>
        /// The authenticated user&#39;s content filters.  Option descriptions:  * &#x60;drugs&#x60; - Drugs or alcohol use.  * &#x60;language&#x60; - Profanity or sexually suggestive content.  * &#x60;nudity&#x60; - Nudity.  * &#x60;safe&#x60; - Suitable for all audiences.  * &#x60;unrated&#x60; - No rating.  * &#x60;violence&#x60; - Violent or graphic content. 
        /// </summary>
        /// <value>The authenticated user&#39;s content filters.  Option descriptions:  * &#x60;drugs&#x60; - Drugs or alcohol use.  * &#x60;language&#x60; - Profanity or sexually suggestive content.  * &#x60;nudity&#x60; - Nudity.  * &#x60;safe&#x60; - Suitable for all audiences.  * &#x60;unrated&#x60; - No rating.  * &#x60;violence&#x60; - Violent or graphic content. </value>
        [DataMember(Name="content_filter", EmitDefaultValue=false)]
        public List<ContentFilterEnum> ContentFilter { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="account">The user&#39;s account type:  Option descriptions:  * &#x60;basic&#x60; - The user has a Vimeo Basic subscription.  * &#x60;business&#x60; - The user has a Vimeo Business subscription.  * &#x60;live_business&#x60; - The user has a Vimeo Business Live subscription.  * &#x60;live_premium&#x60; - The user has a Vimeo Premium subscription.  * &#x60;live_pro&#x60; - The user has a Vimeo PRO Live subscription.  * &#x60;plus&#x60; - The user has a Vimeo Plus subscription.  * &#x60;pro&#x60; - The user has a Vimeo Pro subscription.  * &#x60;pro_unlimited&#x60; - The user has a Vimeo PRO Unlimited subscription.  * &#x60;producer&#x60; - The user has a Vimeo Producer subscription.  (required).</param>
        /// <param name="availableForHire">Whether the user is available for hire. (required).</param>
        /// <param name="bio">The user&#39;s long bio text. (required).</param>
        /// <param name="canWorkRemotely">Whether the user can work remotely. (required).</param>
        /// <param name="contentFilter">The authenticated user&#39;s content filters.  Option descriptions:  * &#x60;drugs&#x60; - Drugs or alcohol use.  * &#x60;language&#x60; - Profanity or sexually suggestive content.  * &#x60;nudity&#x60; - Nudity.  * &#x60;safe&#x60; - Suitable for all audiences.  * &#x60;unrated&#x60; - No rating.  * &#x60;violence&#x60; - Violent or graphic content. .</param>
        /// <param name="createdTime">The time in ISO 8601 format when the user account was created. (required).</param>
        /// <param name="gender">The authenticated user&#39;s gender (required).</param>
        /// <param name="link">The absolute URL of the authenticated users&#39;s profile page. (required).</param>
        /// <param name="location">The authenticated user&#39;s location. (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="name">The authenticated user&#39;s display name. (required).</param>
        /// <param name="pictures">The active portrait of the authenticated user. (required).</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="resourceKey">The authenticated user&#39;s resource key string. (required).</param>
        /// <param name="shortBio">The user&#39;s short bio text. (required).</param>
        /// <param name="skills">A list of the user&#39;s skills. (required).</param>
        /// <param name="uploadQuota">uploadQuota (required).</param>
        /// <param name="uri">The authenticated user&#39;s canonical relative URI. (required).</param>
        /// <param name="websites">The authenticated user&#39;s websites. (required).</param>
        public User(AccountEnum account = default(AccountEnum), bool availableForHire = default(bool), string bio = default(string), bool canWorkRemotely = default(bool), List<ContentFilterEnum> contentFilter = default(List<ContentFilterEnum>), string createdTime = default(string), string gender = default(string), string link = default(string), string location = default(string), UserMetadata metadata = default(UserMetadata), string name = default(string), Picture pictures = default(Picture), UserPreferences preferences = default(UserPreferences), string resourceKey = default(string), string shortBio = default(string), List<Skill> skills = default(List<Skill>), UserUploadQuota uploadQuota = default(UserUploadQuota), string uri = default(string), List<UserWebsites> websites = default(List<UserWebsites>))
        {
            this.Account = account;
            this.AvailableForHire = availableForHire;
            // to ensure "bio" is required (not null)
            this.Bio = bio ?? throw new ArgumentNullException("bio is a required property for User and cannot be null");
            this.CanWorkRemotely = canWorkRemotely;
            // to ensure "createdTime" is required (not null)
            this.CreatedTime = createdTime ?? throw new ArgumentNullException("createdTime is a required property for User and cannot be null");
            // to ensure "gender" is required (not null)
            this.Gender = gender ?? throw new ArgumentNullException("gender is a required property for User and cannot be null");
            // to ensure "link" is required (not null)
            this.Link = link ?? throw new ArgumentNullException("link is a required property for User and cannot be null");
            // to ensure "location" is required (not null)
            this.Location = location ?? throw new ArgumentNullException("location is a required property for User and cannot be null");
            // to ensure "metadata" is required (not null)
            this.Metadata = metadata ?? throw new ArgumentNullException("metadata is a required property for User and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for User and cannot be null");
            // to ensure "pictures" is required (not null)
            this.Pictures = pictures ?? throw new ArgumentNullException("pictures is a required property for User and cannot be null");
            // to ensure "resourceKey" is required (not null)
            this.ResourceKey = resourceKey ?? throw new ArgumentNullException("resourceKey is a required property for User and cannot be null");
            // to ensure "shortBio" is required (not null)
            this.ShortBio = shortBio ?? throw new ArgumentNullException("shortBio is a required property for User and cannot be null");
            // to ensure "skills" is required (not null)
            this.Skills = skills ?? throw new ArgumentNullException("skills is a required property for User and cannot be null");
            // to ensure "uploadQuota" is required (not null)
            this.UploadQuota = uploadQuota ?? throw new ArgumentNullException("uploadQuota is a required property for User and cannot be null");
            // to ensure "uri" is required (not null)
            this.Uri = uri ?? throw new ArgumentNullException("uri is a required property for User and cannot be null");
            // to ensure "websites" is required (not null)
            this.Websites = websites ?? throw new ArgumentNullException("websites is a required property for User and cannot be null");
            this.ContentFilter = contentFilter;
            this.Preferences = preferences;
        }
        
        /// <summary>
        /// Whether the user is available for hire.
        /// </summary>
        /// <value>Whether the user is available for hire.</value>
        [DataMember(Name="available_for_hire", EmitDefaultValue=false)]
        public bool AvailableForHire { get; set; }

        /// <summary>
        /// The user&#39;s long bio text.
        /// </summary>
        /// <value>The user&#39;s long bio text.</value>
        [DataMember(Name="bio", EmitDefaultValue=true)]
        public string Bio { get; set; }

        /// <summary>
        /// Whether the user can work remotely.
        /// </summary>
        /// <value>Whether the user can work remotely.</value>
        [DataMember(Name="can_work_remotely", EmitDefaultValue=false)]
        public bool CanWorkRemotely { get; set; }

        /// <summary>
        /// The time in ISO 8601 format when the user account was created.
        /// </summary>
        /// <value>The time in ISO 8601 format when the user account was created.</value>
        [DataMember(Name="created_time", EmitDefaultValue=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The authenticated user&#39;s gender
        /// </summary>
        /// <value>The authenticated user&#39;s gender</value>
        [DataMember(Name="gender", EmitDefaultValue=true)]
        public string Gender { get; set; }

        /// <summary>
        /// The absolute URL of the authenticated users&#39;s profile page.
        /// </summary>
        /// <value>The absolute URL of the authenticated users&#39;s profile page.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// The authenticated user&#39;s location.
        /// </summary>
        /// <value>The authenticated user&#39;s location.</value>
        [DataMember(Name="location", EmitDefaultValue=true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public UserMetadata Metadata { get; set; }

        /// <summary>
        /// The authenticated user&#39;s display name.
        /// </summary>
        /// <value>The authenticated user&#39;s display name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The active portrait of the authenticated user.
        /// </summary>
        /// <value>The active portrait of the authenticated user.</value>
        [DataMember(Name="pictures", EmitDefaultValue=false)]
        public Picture Pictures { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public UserPreferences Preferences { get; set; }

        /// <summary>
        /// The authenticated user&#39;s resource key string.
        /// </summary>
        /// <value>The authenticated user&#39;s resource key string.</value>
        [DataMember(Name="resource_key", EmitDefaultValue=false)]
        public string ResourceKey { get; set; }

        /// <summary>
        /// The user&#39;s short bio text.
        /// </summary>
        /// <value>The user&#39;s short bio text.</value>
        [DataMember(Name="short_bio", EmitDefaultValue=true)]
        public string ShortBio { get; set; }

        /// <summary>
        /// A list of the user&#39;s skills.
        /// </summary>
        /// <value>A list of the user&#39;s skills.</value>
        [DataMember(Name="skills", EmitDefaultValue=true)]
        public List<Skill> Skills { get; set; }

        /// <summary>
        /// Gets or Sets UploadQuota
        /// </summary>
        [DataMember(Name="upload_quota", EmitDefaultValue=false)]
        public UserUploadQuota UploadQuota { get; set; }

        /// <summary>
        /// The authenticated user&#39;s canonical relative URI.
        /// </summary>
        /// <value>The authenticated user&#39;s canonical relative URI.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The authenticated user&#39;s websites.
        /// </summary>
        /// <value>The authenticated user&#39;s websites.</value>
        [DataMember(Name="websites", EmitDefaultValue=false)]
        public List<UserWebsites> Websites { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AvailableForHire: ").Append(AvailableForHire).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  CanWorkRemotely: ").Append(CanWorkRemotely).Append("\n");
            sb.Append("  ContentFilter: ").Append(ContentFilter).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pictures: ").Append(Pictures).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  ResourceKey: ").Append(ResourceKey).Append("\n");
            sb.Append("  ShortBio: ").Append(ShortBio).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  UploadQuota: ").Append(UploadQuota).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    this.Account.Equals(input.Account)
                ) && 
                (
                    this.AvailableForHire == input.AvailableForHire ||
                    this.AvailableForHire.Equals(input.AvailableForHire)
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.CanWorkRemotely == input.CanWorkRemotely ||
                    this.CanWorkRemotely.Equals(input.CanWorkRemotely)
                ) && 
                (
                    this.ContentFilter == input.ContentFilter ||
                    this.ContentFilter.SequenceEqual(input.ContentFilter)
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Pictures == input.Pictures ||
                    (this.Pictures != null &&
                    this.Pictures.Equals(input.Pictures))
                ) && 
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
                ) && 
                (
                    this.ResourceKey == input.ResourceKey ||
                    (this.ResourceKey != null &&
                    this.ResourceKey.Equals(input.ResourceKey))
                ) && 
                (
                    this.ShortBio == input.ShortBio ||
                    (this.ShortBio != null &&
                    this.ShortBio.Equals(input.ShortBio))
                ) && 
                (
                    this.Skills == input.Skills ||
                    this.Skills != null &&
                    input.Skills != null &&
                    this.Skills.SequenceEqual(input.Skills)
                ) && 
                (
                    this.UploadQuota == input.UploadQuota ||
                    (this.UploadQuota != null &&
                    this.UploadQuota.Equals(input.UploadQuota))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Websites == input.Websites ||
                    this.Websites != null &&
                    input.Websites != null &&
                    this.Websites.SequenceEqual(input.Websites)
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
                hashCode = hashCode * 59 + this.Account.GetHashCode();
                hashCode = hashCode * 59 + this.AvailableForHire.GetHashCode();
                if (this.Bio != null)
                    hashCode = hashCode * 59 + this.Bio.GetHashCode();
                hashCode = hashCode * 59 + this.CanWorkRemotely.GetHashCode();
                hashCode = hashCode * 59 + this.ContentFilter.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pictures != null)
                    hashCode = hashCode * 59 + this.Pictures.GetHashCode();
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                if (this.ResourceKey != null)
                    hashCode = hashCode * 59 + this.ResourceKey.GetHashCode();
                if (this.ShortBio != null)
                    hashCode = hashCode * 59 + this.ShortBio.GetHashCode();
                if (this.Skills != null)
                    hashCode = hashCode * 59 + this.Skills.GetHashCode();
                if (this.UploadQuota != null)
                    hashCode = hashCode * 59 + this.UploadQuota.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Websites != null)
                    hashCode = hashCode * 59 + this.Websites.GetHashCode();
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

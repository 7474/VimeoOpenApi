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
    /// InlineObject39
    /// </summary>
    [DataContract]
    public partial class InlineObject39 :  IEquatable<InlineObject39>, IValidatableObject
    {
        /// <summary>
        /// The type of layout for presenting the showcase.  Option descriptions:  * &#x60;grid&#x60; - The videos appear in a grid.  * &#x60;player&#x60; - The videos appear in the player. 
        /// </summary>
        /// <value>The type of layout for presenting the showcase.  Option descriptions:  * &#x60;grid&#x60; - The videos appear in a grid.  * &#x60;player&#x60; - The videos appear in the player. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayoutEnum
        {
            /// <summary>
            /// Enum Grid for value: grid
            /// </summary>
            [EnumMember(Value = "grid")]
            Grid = 1,

            /// <summary>
            /// Enum Player for value: player
            /// </summary>
            [EnumMember(Value = "player")]
            Player = 2

        }

        /// <summary>
        /// The type of layout for presenting the showcase.  Option descriptions:  * &#x60;grid&#x60; - The videos appear in a grid.  * &#x60;player&#x60; - The videos appear in the player. 
        /// </summary>
        /// <value>The type of layout for presenting the showcase.  Option descriptions:  * &#x60;grid&#x60; - The videos appear in a grid.  * &#x60;player&#x60; - The videos appear in the player. </value>
        [DataMember(Name="layout", EmitDefaultValue=false)]
        public LayoutEnum? Layout { get; set; }
        /// <summary>
        /// The privacy level of the showcase.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the showcase, either on Vimeo or through an embed.  * &#x60;embed_only&#x60; - The showcase doesn&#39;t appear on Vimeo, but it can be embedded on other sites.  * &#x60;nobody&#x60; - No one can access the showcase, including the authenticated user.  * &#x60;password&#x60; - Only people with the password can access the showcase.  * &#x60;team&#x60; - Only members of the authenticated user&#39;s team can access the showcase. 
        /// </summary>
        /// <value>The privacy level of the showcase.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the showcase, either on Vimeo or through an embed.  * &#x60;embed_only&#x60; - The showcase doesn&#39;t appear on Vimeo, but it can be embedded on other sites.  * &#x60;nobody&#x60; - No one can access the showcase, including the authenticated user.  * &#x60;password&#x60; - Only people with the password can access the showcase.  * &#x60;team&#x60; - Only members of the authenticated user&#39;s team can access the showcase. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrivacyEnum
        {
            /// <summary>
            /// Enum Anybody for value: anybody
            /// </summary>
            [EnumMember(Value = "anybody")]
            Anybody = 1,

            /// <summary>
            /// Enum Embedonly for value: embed_only
            /// </summary>
            [EnumMember(Value = "embed_only")]
            Embedonly = 2,

            /// <summary>
            /// Enum Nobody for value: nobody
            /// </summary>
            [EnumMember(Value = "nobody")]
            Nobody = 3,

            /// <summary>
            /// Enum Password for value: password
            /// </summary>
            [EnumMember(Value = "password")]
            Password = 4,

            /// <summary>
            /// Enum Team for value: team
            /// </summary>
            [EnumMember(Value = "team")]
            Team = 5

        }

        /// <summary>
        /// The privacy level of the showcase.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the showcase, either on Vimeo or through an embed.  * &#x60;embed_only&#x60; - The showcase doesn&#39;t appear on Vimeo, but it can be embedded on other sites.  * &#x60;nobody&#x60; - No one can access the showcase, including the authenticated user.  * &#x60;password&#x60; - Only people with the password can access the showcase.  * &#x60;team&#x60; - Only members of the authenticated user&#39;s team can access the showcase. 
        /// </summary>
        /// <value>The privacy level of the showcase.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the showcase, either on Vimeo or through an embed.  * &#x60;embed_only&#x60; - The showcase doesn&#39;t appear on Vimeo, but it can be embedded on other sites.  * &#x60;nobody&#x60; - No one can access the showcase, including the authenticated user.  * &#x60;password&#x60; - Only people with the password can access the showcase.  * &#x60;team&#x60; - Only members of the authenticated user&#39;s team can access the showcase. </value>
        [DataMember(Name="privacy", EmitDefaultValue=false)]
        public PrivacyEnum? Privacy { get; set; }
        /// <summary>
        /// The default sort order of the videos as they appear in the showcase.  Option descriptions:  * &#x60;added_first&#x60; - The videos appear according to when they were added to the showcase, with the most recently added first.  * &#x60;added_last&#x60; - The videos appear according to when they were added to the showcase, with the most recently added last.  * &#x60;alphabetical&#x60; - The videos appear alphabetically by their title.  * &#x60;arranged&#x60; - The videos appear as arranged by the owner of the showcase.  * &#x60;comments&#x60; - The videos appear according to their number of comments.  * &#x60;likes&#x60; - The videos appear according to their number of likes.  * &#x60;newest&#x60; - The videos appear in chronological order with the newest first.  * &#x60;oldest&#x60; - The videos appear in chronological order with the oldest first.  * &#x60;plays&#x60; - The videos appear according to their number of plays. 
        /// </summary>
        /// <value>The default sort order of the videos as they appear in the showcase.  Option descriptions:  * &#x60;added_first&#x60; - The videos appear according to when they were added to the showcase, with the most recently added first.  * &#x60;added_last&#x60; - The videos appear according to when they were added to the showcase, with the most recently added last.  * &#x60;alphabetical&#x60; - The videos appear alphabetically by their title.  * &#x60;arranged&#x60; - The videos appear as arranged by the owner of the showcase.  * &#x60;comments&#x60; - The videos appear according to their number of comments.  * &#x60;likes&#x60; - The videos appear according to their number of likes.  * &#x60;newest&#x60; - The videos appear in chronological order with the newest first.  * &#x60;oldest&#x60; - The videos appear in chronological order with the oldest first.  * &#x60;plays&#x60; - The videos appear according to their number of plays. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortEnum
        {
            /// <summary>
            /// Enum Addedfirst for value: added_first
            /// </summary>
            [EnumMember(Value = "added_first")]
            Addedfirst = 1,

            /// <summary>
            /// Enum Addedlast for value: added_last
            /// </summary>
            [EnumMember(Value = "added_last")]
            Addedlast = 2,

            /// <summary>
            /// Enum Alphabetical for value: alphabetical
            /// </summary>
            [EnumMember(Value = "alphabetical")]
            Alphabetical = 3,

            /// <summary>
            /// Enum Arranged for value: arranged
            /// </summary>
            [EnumMember(Value = "arranged")]
            Arranged = 4,

            /// <summary>
            /// Enum Comments for value: comments
            /// </summary>
            [EnumMember(Value = "comments")]
            Comments = 5,

            /// <summary>
            /// Enum Likes for value: likes
            /// </summary>
            [EnumMember(Value = "likes")]
            Likes = 6,

            /// <summary>
            /// Enum Newest for value: newest
            /// </summary>
            [EnumMember(Value = "newest")]
            Newest = 7,

            /// <summary>
            /// Enum Oldest for value: oldest
            /// </summary>
            [EnumMember(Value = "oldest")]
            Oldest = 8,

            /// <summary>
            /// Enum Plays for value: plays
            /// </summary>
            [EnumMember(Value = "plays")]
            Plays = 9

        }

        /// <summary>
        /// The default sort order of the videos as they appear in the showcase.  Option descriptions:  * &#x60;added_first&#x60; - The videos appear according to when they were added to the showcase, with the most recently added first.  * &#x60;added_last&#x60; - The videos appear according to when they were added to the showcase, with the most recently added last.  * &#x60;alphabetical&#x60; - The videos appear alphabetically by their title.  * &#x60;arranged&#x60; - The videos appear as arranged by the owner of the showcase.  * &#x60;comments&#x60; - The videos appear according to their number of comments.  * &#x60;likes&#x60; - The videos appear according to their number of likes.  * &#x60;newest&#x60; - The videos appear in chronological order with the newest first.  * &#x60;oldest&#x60; - The videos appear in chronological order with the oldest first.  * &#x60;plays&#x60; - The videos appear according to their number of plays. 
        /// </summary>
        /// <value>The default sort order of the videos as they appear in the showcase.  Option descriptions:  * &#x60;added_first&#x60; - The videos appear according to when they were added to the showcase, with the most recently added first.  * &#x60;added_last&#x60; - The videos appear according to when they were added to the showcase, with the most recently added last.  * &#x60;alphabetical&#x60; - The videos appear alphabetically by their title.  * &#x60;arranged&#x60; - The videos appear as arranged by the owner of the showcase.  * &#x60;comments&#x60; - The videos appear according to their number of comments.  * &#x60;likes&#x60; - The videos appear according to their number of likes.  * &#x60;newest&#x60; - The videos appear in chronological order with the newest first.  * &#x60;oldest&#x60; - The videos appear in chronological order with the oldest first.  * &#x60;plays&#x60; - The videos appear according to their number of plays. </value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public SortEnum? Sort { get; set; }
        /// <summary>
        /// The color theme of the showcase.  Option descriptions:  * &#x60;dark&#x60; - The showcase uses the dark theme.  * &#x60;standard&#x60; - The showcase uses the standard theme. 
        /// </summary>
        /// <value>The color theme of the showcase.  Option descriptions:  * &#x60;dark&#x60; - The showcase uses the dark theme.  * &#x60;standard&#x60; - The showcase uses the standard theme. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ThemeEnum
        {
            /// <summary>
            /// Enum Dark for value: dark
            /// </summary>
            [EnumMember(Value = "dark")]
            Dark = 1,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 2

        }

        /// <summary>
        /// The color theme of the showcase.  Option descriptions:  * &#x60;dark&#x60; - The showcase uses the dark theme.  * &#x60;standard&#x60; - The showcase uses the standard theme. 
        /// </summary>
        /// <value>The color theme of the showcase.  Option descriptions:  * &#x60;dark&#x60; - The showcase uses the dark theme.  * &#x60;standard&#x60; - The showcase uses the standard theme. </value>
        [DataMember(Name="theme", EmitDefaultValue=false)]
        public ThemeEnum? Theme { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject39" /> class.
        /// </summary>
        /// <param name="brandColor">The hexadecimal code for the color of the player buttons and showcase controls..</param>
        /// <param name="description">The description of the showcase..</param>
        /// <param name="domain">The custom domain of the showcase..</param>
        /// <param name="hideNav">Whether to hide Vimeo navigation when displaying the showcase..</param>
        /// <param name="hideUpcoming">Whether to include the upcoming live event in the showcase..</param>
        /// <param name="layout">The type of layout for presenting the showcase.  Option descriptions:  * &#x60;grid&#x60; - The videos appear in a grid.  * &#x60;player&#x60; - The videos appear in the player. .</param>
        /// <param name="name">The name of the showcase..</param>
        /// <param name="password">The showcase&#39;s password. This field is required only when **privacy** is &#x60;password&#x60;..</param>
        /// <param name="privacy">The privacy level of the showcase.  Option descriptions:  * &#x60;anybody&#x60; - Anyone can access the showcase, either on Vimeo or through an embed.  * &#x60;embed_only&#x60; - The showcase doesn&#39;t appear on Vimeo, but it can be embedded on other sites.  * &#x60;nobody&#x60; - No one can access the showcase, including the authenticated user.  * &#x60;password&#x60; - Only people with the password can access the showcase.  * &#x60;team&#x60; - Only members of the authenticated user&#39;s team can access the showcase. .</param>
        /// <param name="reviewMode">Whether showcase videos use the review mode URL..</param>
        /// <param name="sort">The default sort order of the videos as they appear in the showcase.  Option descriptions:  * &#x60;added_first&#x60; - The videos appear according to when they were added to the showcase, with the most recently added first.  * &#x60;added_last&#x60; - The videos appear according to when they were added to the showcase, with the most recently added last.  * &#x60;alphabetical&#x60; - The videos appear alphabetically by their title.  * &#x60;arranged&#x60; - The videos appear as arranged by the owner of the showcase.  * &#x60;comments&#x60; - The videos appear according to their number of comments.  * &#x60;likes&#x60; - The videos appear according to their number of likes.  * &#x60;newest&#x60; - The videos appear in chronological order with the newest first.  * &#x60;oldest&#x60; - The videos appear in chronological order with the oldest first.  * &#x60;plays&#x60; - The videos appear according to their number of plays. .</param>
        /// <param name="theme">The color theme of the showcase.  Option descriptions:  * &#x60;dark&#x60; - The showcase uses the dark theme.  * &#x60;standard&#x60; - The showcase uses the standard theme. .</param>
        /// <param name="url">The custom Vimeo URL of the showcase..</param>
        /// <param name="useCustomDomain">Whether the user has opted for a custom domain for their showcase..</param>
        public InlineObject39(string brandColor = default(string), string description = default(string), string domain = default(string), bool hideNav = default(bool), bool hideUpcoming = default(bool), LayoutEnum? layout = default(LayoutEnum?), string name = default(string), string password = default(string), PrivacyEnum? privacy = default(PrivacyEnum?), bool reviewMode = default(bool), SortEnum? sort = default(SortEnum?), ThemeEnum? theme = default(ThemeEnum?), string url = default(string), bool useCustomDomain = default(bool))
        {
            this.BrandColor = brandColor;
            this.Description = description;
            this.Domain = domain;
            this.HideNav = hideNav;
            this.HideUpcoming = hideUpcoming;
            this.Layout = layout;
            this.Name = name;
            this.Password = password;
            this.Privacy = privacy;
            this.ReviewMode = reviewMode;
            this.Sort = sort;
            this.Theme = theme;
            this.Url = url;
            this.UseCustomDomain = useCustomDomain;
        }
        
        /// <summary>
        /// The hexadecimal code for the color of the player buttons and showcase controls.
        /// </summary>
        /// <value>The hexadecimal code for the color of the player buttons and showcase controls.</value>
        [DataMember(Name="brand_color", EmitDefaultValue=false)]
        public string BrandColor { get; set; }

        /// <summary>
        /// The description of the showcase.
        /// </summary>
        /// <value>The description of the showcase.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The custom domain of the showcase.
        /// </summary>
        /// <value>The custom domain of the showcase.</value>
        [DataMember(Name="domain", EmitDefaultValue=true)]
        public string Domain { get; set; }

        /// <summary>
        /// Whether to hide Vimeo navigation when displaying the showcase.
        /// </summary>
        /// <value>Whether to hide Vimeo navigation when displaying the showcase.</value>
        [DataMember(Name="hide_nav", EmitDefaultValue=false)]
        public bool HideNav { get; set; }

        /// <summary>
        /// Whether to include the upcoming live event in the showcase.
        /// </summary>
        /// <value>Whether to include the upcoming live event in the showcase.</value>
        [DataMember(Name="hide_upcoming", EmitDefaultValue=false)]
        public bool HideUpcoming { get; set; }

        /// <summary>
        /// The name of the showcase.
        /// </summary>
        /// <value>The name of the showcase.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The showcase&#39;s password. This field is required only when **privacy** is &#x60;password&#x60;.
        /// </summary>
        /// <value>The showcase&#39;s password. This field is required only when **privacy** is &#x60;password&#x60;.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Whether showcase videos use the review mode URL.
        /// </summary>
        /// <value>Whether showcase videos use the review mode URL.</value>
        [DataMember(Name="review_mode", EmitDefaultValue=false)]
        public bool ReviewMode { get; set; }

        /// <summary>
        /// The custom Vimeo URL of the showcase.
        /// </summary>
        /// <value>The custom Vimeo URL of the showcase.</value>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Whether the user has opted for a custom domain for their showcase.
        /// </summary>
        /// <value>Whether the user has opted for a custom domain for their showcase.</value>
        [DataMember(Name="use_custom_domain", EmitDefaultValue=false)]
        public bool UseCustomDomain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject39 {\n");
            sb.Append("  BrandColor: ").Append(BrandColor).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  HideNav: ").Append(HideNav).Append("\n");
            sb.Append("  HideUpcoming: ").Append(HideUpcoming).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  ReviewMode: ").Append(ReviewMode).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UseCustomDomain: ").Append(UseCustomDomain).Append("\n");
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
            return this.Equals(input as InlineObject39);
        }

        /// <summary>
        /// Returns true if InlineObject39 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject39 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject39 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BrandColor == input.BrandColor ||
                    (this.BrandColor != null &&
                    this.BrandColor.Equals(input.BrandColor))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.HideNav == input.HideNav ||
                    this.HideNav.Equals(input.HideNav)
                ) && 
                (
                    this.HideUpcoming == input.HideUpcoming ||
                    this.HideUpcoming.Equals(input.HideUpcoming)
                ) && 
                (
                    this.Layout == input.Layout ||
                    this.Layout.Equals(input.Layout)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
                ) && 
                (
                    this.ReviewMode == input.ReviewMode ||
                    this.ReviewMode.Equals(input.ReviewMode)
                ) && 
                (
                    this.Sort == input.Sort ||
                    this.Sort.Equals(input.Sort)
                ) && 
                (
                    this.Theme == input.Theme ||
                    this.Theme.Equals(input.Theme)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.UseCustomDomain == input.UseCustomDomain ||
                    this.UseCustomDomain.Equals(input.UseCustomDomain)
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
                if (this.BrandColor != null)
                    hashCode = hashCode * 59 + this.BrandColor.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                hashCode = hashCode * 59 + this.HideNav.GetHashCode();
                hashCode = hashCode * 59 + this.HideUpcoming.GetHashCode();
                hashCode = hashCode * 59 + this.Layout.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                hashCode = hashCode * 59 + this.ReviewMode.GetHashCode();
                hashCode = hashCode * 59 + this.Sort.GetHashCode();
                hashCode = hashCode * 59 + this.Theme.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.UseCustomDomain.GetHashCode();
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

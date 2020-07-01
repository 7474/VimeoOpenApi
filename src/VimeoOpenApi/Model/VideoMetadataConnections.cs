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
    /// A list of resource URIs related to the video.
    /// </summary>
    [DataContract]
    public partial class VideoMetadataConnections :  IEquatable<VideoMetadataConnections>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataConnections" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoMetadataConnections() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataConnections" /> class.
        /// </summary>
        /// <param name="albums">albums (required).</param>
        /// <param name="availableAlbums">availableAlbums (required).</param>
        /// <param name="availableChannels">availableChannels (required).</param>
        /// <param name="comments">comments (required).</param>
        /// <param name="credits">credits (required).</param>
        /// <param name="likes">likes (required).</param>
        /// <param name="ondemand">ondemand (required).</param>
        /// <param name="pictures">pictures (required).</param>
        /// <param name="playback">playback (required).</param>
        /// <param name="publishToSocial">publishToSocial (required).</param>
        /// <param name="recommendations">recommendations (required).</param>
        /// <param name="related">related (required).</param>
        /// <param name="season">season (required).</param>
        /// <param name="texttracks">texttracks (required).</param>
        /// <param name="trailer">trailer (required).</param>
        /// <param name="usersWithAccess">usersWithAccess (required).</param>
        /// <param name="versions">versions (required).</param>
        public VideoMetadataConnections(VideoMetadataConnectionsAlbums albums = default(VideoMetadataConnectionsAlbums), VideoMetadataConnectionsAvailableAlbums availableAlbums = default(VideoMetadataConnectionsAvailableAlbums), VideoMetadataConnectionsAvailableChannels availableChannels = default(VideoMetadataConnectionsAvailableChannels), VideoMetadataConnectionsComments comments = default(VideoMetadataConnectionsComments), VideoMetadataConnectionsCredits credits = default(VideoMetadataConnectionsCredits), VideoMetadataConnectionsLikes likes = default(VideoMetadataConnectionsLikes), VideoMetadataConnectionsOndemand ondemand = default(VideoMetadataConnectionsOndemand), VideoMetadataConnectionsPictures pictures = default(VideoMetadataConnectionsPictures), VideoMetadataConnectionsPlayback playback = default(VideoMetadataConnectionsPlayback), VideoMetadataConnectionsPublishToSocial publishToSocial = default(VideoMetadataConnectionsPublishToSocial), VideoMetadataConnectionsRecommendations recommendations = default(VideoMetadataConnectionsRecommendations), VideoMetadataConnectionsRelated related = default(VideoMetadataConnectionsRelated), VideoMetadataConnectionsSeason season = default(VideoMetadataConnectionsSeason), VideoMetadataConnectionsTexttracks texttracks = default(VideoMetadataConnectionsTexttracks), VideoMetadataConnectionsTrailer trailer = default(VideoMetadataConnectionsTrailer), VideoMetadataConnectionsUsersWithAccess usersWithAccess = default(VideoMetadataConnectionsUsersWithAccess), VideoMetadataConnectionsVersions versions = default(VideoMetadataConnectionsVersions))
        {
            // to ensure "albums" is required (not null)
            this.Albums = albums ?? throw new ArgumentNullException("albums is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "availableAlbums" is required (not null)
            this.AvailableAlbums = availableAlbums ?? throw new ArgumentNullException("availableAlbums is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "availableChannels" is required (not null)
            this.AvailableChannels = availableChannels ?? throw new ArgumentNullException("availableChannels is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "comments" is required (not null)
            this.Comments = comments ?? throw new ArgumentNullException("comments is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "credits" is required (not null)
            this.Credits = credits ?? throw new ArgumentNullException("credits is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "likes" is required (not null)
            this.Likes = likes ?? throw new ArgumentNullException("likes is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "ondemand" is required (not null)
            this.Ondemand = ondemand ?? throw new ArgumentNullException("ondemand is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "pictures" is required (not null)
            this.Pictures = pictures ?? throw new ArgumentNullException("pictures is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "playback" is required (not null)
            this.Playback = playback ?? throw new ArgumentNullException("playback is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "publishToSocial" is required (not null)
            this.PublishToSocial = publishToSocial ?? throw new ArgumentNullException("publishToSocial is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "recommendations" is required (not null)
            this.Recommendations = recommendations ?? throw new ArgumentNullException("recommendations is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "related" is required (not null)
            this.Related = related ?? throw new ArgumentNullException("related is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "season" is required (not null)
            this.Season = season ?? throw new ArgumentNullException("season is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "texttracks" is required (not null)
            this.Texttracks = texttracks ?? throw new ArgumentNullException("texttracks is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "trailer" is required (not null)
            this.Trailer = trailer ?? throw new ArgumentNullException("trailer is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "usersWithAccess" is required (not null)
            this.UsersWithAccess = usersWithAccess ?? throw new ArgumentNullException("usersWithAccess is a required property for VideoMetadataConnections and cannot be null");
            // to ensure "versions" is required (not null)
            this.Versions = versions ?? throw new ArgumentNullException("versions is a required property for VideoMetadataConnections and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Albums
        /// </summary>
        [DataMember(Name="albums", EmitDefaultValue=false)]
        public VideoMetadataConnectionsAlbums Albums { get; set; }

        /// <summary>
        /// Gets or Sets AvailableAlbums
        /// </summary>
        [DataMember(Name="available_albums", EmitDefaultValue=false)]
        public VideoMetadataConnectionsAvailableAlbums AvailableAlbums { get; set; }

        /// <summary>
        /// Gets or Sets AvailableChannels
        /// </summary>
        [DataMember(Name="available_channels", EmitDefaultValue=false)]
        public VideoMetadataConnectionsAvailableChannels AvailableChannels { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public VideoMetadataConnectionsComments Comments { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [DataMember(Name="credits", EmitDefaultValue=true)]
        public VideoMetadataConnectionsCredits Credits { get; set; }

        /// <summary>
        /// Gets or Sets Likes
        /// </summary>
        [DataMember(Name="likes", EmitDefaultValue=false)]
        public VideoMetadataConnectionsLikes Likes { get; set; }

        /// <summary>
        /// Gets or Sets Ondemand
        /// </summary>
        [DataMember(Name="ondemand", EmitDefaultValue=false)]
        public VideoMetadataConnectionsOndemand Ondemand { get; set; }

        /// <summary>
        /// Gets or Sets Pictures
        /// </summary>
        [DataMember(Name="pictures", EmitDefaultValue=false)]
        public VideoMetadataConnectionsPictures Pictures { get; set; }

        /// <summary>
        /// Gets or Sets Playback
        /// </summary>
        [DataMember(Name="playback", EmitDefaultValue=false)]
        public VideoMetadataConnectionsPlayback Playback { get; set; }

        /// <summary>
        /// Gets or Sets PublishToSocial
        /// </summary>
        [DataMember(Name="publish_to_social", EmitDefaultValue=true)]
        public VideoMetadataConnectionsPublishToSocial PublishToSocial { get; set; }

        /// <summary>
        /// Gets or Sets Recommendations
        /// </summary>
        [DataMember(Name="recommendations", EmitDefaultValue=true)]
        public VideoMetadataConnectionsRecommendations Recommendations { get; set; }

        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name="related", EmitDefaultValue=true)]
        public VideoMetadataConnectionsRelated Related { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public VideoMetadataConnectionsSeason Season { get; set; }

        /// <summary>
        /// Gets or Sets Texttracks
        /// </summary>
        [DataMember(Name="texttracks", EmitDefaultValue=false)]
        public VideoMetadataConnectionsTexttracks Texttracks { get; set; }

        /// <summary>
        /// Gets or Sets Trailer
        /// </summary>
        [DataMember(Name="trailer", EmitDefaultValue=false)]
        public VideoMetadataConnectionsTrailer Trailer { get; set; }

        /// <summary>
        /// Gets or Sets UsersWithAccess
        /// </summary>
        [DataMember(Name="users_with_access", EmitDefaultValue=false)]
        public VideoMetadataConnectionsUsersWithAccess UsersWithAccess { get; set; }

        /// <summary>
        /// Gets or Sets Versions
        /// </summary>
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public VideoMetadataConnectionsVersions Versions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoMetadataConnections {\n");
            sb.Append("  Albums: ").Append(Albums).Append("\n");
            sb.Append("  AvailableAlbums: ").Append(AvailableAlbums).Append("\n");
            sb.Append("  AvailableChannels: ").Append(AvailableChannels).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Likes: ").Append(Likes).Append("\n");
            sb.Append("  Ondemand: ").Append(Ondemand).Append("\n");
            sb.Append("  Pictures: ").Append(Pictures).Append("\n");
            sb.Append("  Playback: ").Append(Playback).Append("\n");
            sb.Append("  PublishToSocial: ").Append(PublishToSocial).Append("\n");
            sb.Append("  Recommendations: ").Append(Recommendations).Append("\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Texttracks: ").Append(Texttracks).Append("\n");
            sb.Append("  Trailer: ").Append(Trailer).Append("\n");
            sb.Append("  UsersWithAccess: ").Append(UsersWithAccess).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
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
            return this.Equals(input as VideoMetadataConnections);
        }

        /// <summary>
        /// Returns true if VideoMetadataConnections instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoMetadataConnections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoMetadataConnections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Albums == input.Albums ||
                    (this.Albums != null &&
                    this.Albums.Equals(input.Albums))
                ) && 
                (
                    this.AvailableAlbums == input.AvailableAlbums ||
                    (this.AvailableAlbums != null &&
                    this.AvailableAlbums.Equals(input.AvailableAlbums))
                ) && 
                (
                    this.AvailableChannels == input.AvailableChannels ||
                    (this.AvailableChannels != null &&
                    this.AvailableChannels.Equals(input.AvailableChannels))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Credits == input.Credits ||
                    (this.Credits != null &&
                    this.Credits.Equals(input.Credits))
                ) && 
                (
                    this.Likes == input.Likes ||
                    (this.Likes != null &&
                    this.Likes.Equals(input.Likes))
                ) && 
                (
                    this.Ondemand == input.Ondemand ||
                    (this.Ondemand != null &&
                    this.Ondemand.Equals(input.Ondemand))
                ) && 
                (
                    this.Pictures == input.Pictures ||
                    (this.Pictures != null &&
                    this.Pictures.Equals(input.Pictures))
                ) && 
                (
                    this.Playback == input.Playback ||
                    (this.Playback != null &&
                    this.Playback.Equals(input.Playback))
                ) && 
                (
                    this.PublishToSocial == input.PublishToSocial ||
                    (this.PublishToSocial != null &&
                    this.PublishToSocial.Equals(input.PublishToSocial))
                ) && 
                (
                    this.Recommendations == input.Recommendations ||
                    (this.Recommendations != null &&
                    this.Recommendations.Equals(input.Recommendations))
                ) && 
                (
                    this.Related == input.Related ||
                    (this.Related != null &&
                    this.Related.Equals(input.Related))
                ) && 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.Texttracks == input.Texttracks ||
                    (this.Texttracks != null &&
                    this.Texttracks.Equals(input.Texttracks))
                ) && 
                (
                    this.Trailer == input.Trailer ||
                    (this.Trailer != null &&
                    this.Trailer.Equals(input.Trailer))
                ) && 
                (
                    this.UsersWithAccess == input.UsersWithAccess ||
                    (this.UsersWithAccess != null &&
                    this.UsersWithAccess.Equals(input.UsersWithAccess))
                ) && 
                (
                    this.Versions == input.Versions ||
                    (this.Versions != null &&
                    this.Versions.Equals(input.Versions))
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
                if (this.Albums != null)
                    hashCode = hashCode * 59 + this.Albums.GetHashCode();
                if (this.AvailableAlbums != null)
                    hashCode = hashCode * 59 + this.AvailableAlbums.GetHashCode();
                if (this.AvailableChannels != null)
                    hashCode = hashCode * 59 + this.AvailableChannels.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Credits != null)
                    hashCode = hashCode * 59 + this.Credits.GetHashCode();
                if (this.Likes != null)
                    hashCode = hashCode * 59 + this.Likes.GetHashCode();
                if (this.Ondemand != null)
                    hashCode = hashCode * 59 + this.Ondemand.GetHashCode();
                if (this.Pictures != null)
                    hashCode = hashCode * 59 + this.Pictures.GetHashCode();
                if (this.Playback != null)
                    hashCode = hashCode * 59 + this.Playback.GetHashCode();
                if (this.PublishToSocial != null)
                    hashCode = hashCode * 59 + this.PublishToSocial.GetHashCode();
                if (this.Recommendations != null)
                    hashCode = hashCode * 59 + this.Recommendations.GetHashCode();
                if (this.Related != null)
                    hashCode = hashCode * 59 + this.Related.GetHashCode();
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Texttracks != null)
                    hashCode = hashCode * 59 + this.Texttracks.GetHashCode();
                if (this.Trailer != null)
                    hashCode = hashCode * 59 + this.Trailer.GetHashCode();
                if (this.UsersWithAccess != null)
                    hashCode = hashCode * 59 + this.UsersWithAccess.GetHashCode();
                if (this.Versions != null)
                    hashCode = hashCode * 59 + this.Versions.GetHashCode();
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

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
    /// The list of resource URIs related to the authenticated user.
    /// </summary>
    [DataContract]
    public partial class UserMetadataConnections :  IEquatable<UserMetadataConnections>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetadataConnections" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserMetadataConnections() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserMetadataConnections" /> class.
        /// </summary>
        /// <param name="albums">albums (required).</param>
        /// <param name="appearances">appearances (required).</param>
        /// <param name="block">block (required).</param>
        /// <param name="categories">categories (required).</param>
        /// <param name="channels">channels (required).</param>
        /// <param name="connectedApps">connectedApps (required).</param>
        /// <param name="feed">feed (required).</param>
        /// <param name="folders">folders (required).</param>
        /// <param name="followers">followers (required).</param>
        /// <param name="following">following (required).</param>
        /// <param name="groups">groups (required).</param>
        /// <param name="likes">likes (required).</param>
        /// <param name="moderatedChannels">moderatedChannels (required).</param>
        /// <param name="pictures">pictures (required).</param>
        /// <param name="portfolios">portfolios (required).</param>
        /// <param name="recommendedChannels">recommendedChannels (required).</param>
        /// <param name="recommendedUsers">recommendedUsers (required).</param>
        /// <param name="shared">shared (required).</param>
        /// <param name="videos">videos (required).</param>
        /// <param name="watchedVideos">watchedVideos (required).</param>
        /// <param name="watchlater">watchlater (required).</param>
        public UserMetadataConnections(UserMetadataConnectionsAlbums albums = default(UserMetadataConnectionsAlbums), UserMetadataConnectionsAppearances appearances = default(UserMetadataConnectionsAppearances), UserMetadataConnectionsBlock block = default(UserMetadataConnectionsBlock), UserMetadataConnectionsCategories categories = default(UserMetadataConnectionsCategories), UserMetadataConnectionsChannels channels = default(UserMetadataConnectionsChannels), UserMetadataConnectionsConnectedApps connectedApps = default(UserMetadataConnectionsConnectedApps), UserMetadataConnectionsFeed feed = default(UserMetadataConnectionsFeed), UserMetadataConnectionsFolders folders = default(UserMetadataConnectionsFolders), UserMetadataConnectionsFollowers followers = default(UserMetadataConnectionsFollowers), UserMetadataConnectionsFollowing following = default(UserMetadataConnectionsFollowing), UserMetadataConnectionsGroups groups = default(UserMetadataConnectionsGroups), UserMetadataConnectionsLikes likes = default(UserMetadataConnectionsLikes), UserMetadataConnectionsModeratedChannels moderatedChannels = default(UserMetadataConnectionsModeratedChannels), UserMetadataConnectionsPictures pictures = default(UserMetadataConnectionsPictures), UserMetadataConnectionsPortfolios portfolios = default(UserMetadataConnectionsPortfolios), UserMetadataConnectionsRecommendedChannels recommendedChannels = default(UserMetadataConnectionsRecommendedChannels), UserMetadataConnectionsRecommendedUsers recommendedUsers = default(UserMetadataConnectionsRecommendedUsers), UserMetadataConnectionsShared shared = default(UserMetadataConnectionsShared), UserMetadataConnectionsVideos videos = default(UserMetadataConnectionsVideos), UserMetadataConnectionsWatchedVideos watchedVideos = default(UserMetadataConnectionsWatchedVideos), UserMetadataConnectionsWatchlater watchlater = default(UserMetadataConnectionsWatchlater))
        {
            // to ensure "albums" is required (not null)
            this.Albums = albums ?? throw new ArgumentNullException("albums is a required property for UserMetadataConnections and cannot be null");
            // to ensure "appearances" is required (not null)
            this.Appearances = appearances ?? throw new ArgumentNullException("appearances is a required property for UserMetadataConnections and cannot be null");
            // to ensure "block" is required (not null)
            this.Block = block ?? throw new ArgumentNullException("block is a required property for UserMetadataConnections and cannot be null");
            // to ensure "categories" is required (not null)
            this.Categories = categories ?? throw new ArgumentNullException("categories is a required property for UserMetadataConnections and cannot be null");
            // to ensure "channels" is required (not null)
            this.Channels = channels ?? throw new ArgumentNullException("channels is a required property for UserMetadataConnections and cannot be null");
            // to ensure "connectedApps" is required (not null)
            this.ConnectedApps = connectedApps ?? throw new ArgumentNullException("connectedApps is a required property for UserMetadataConnections and cannot be null");
            // to ensure "feed" is required (not null)
            this.Feed = feed ?? throw new ArgumentNullException("feed is a required property for UserMetadataConnections and cannot be null");
            // to ensure "folders" is required (not null)
            this.Folders = folders ?? throw new ArgumentNullException("folders is a required property for UserMetadataConnections and cannot be null");
            // to ensure "followers" is required (not null)
            this.Followers = followers ?? throw new ArgumentNullException("followers is a required property for UserMetadataConnections and cannot be null");
            // to ensure "following" is required (not null)
            this.Following = following ?? throw new ArgumentNullException("following is a required property for UserMetadataConnections and cannot be null");
            // to ensure "groups" is required (not null)
            this.Groups = groups ?? throw new ArgumentNullException("groups is a required property for UserMetadataConnections and cannot be null");
            // to ensure "likes" is required (not null)
            this.Likes = likes ?? throw new ArgumentNullException("likes is a required property for UserMetadataConnections and cannot be null");
            // to ensure "moderatedChannels" is required (not null)
            this.ModeratedChannels = moderatedChannels ?? throw new ArgumentNullException("moderatedChannels is a required property for UserMetadataConnections and cannot be null");
            // to ensure "pictures" is required (not null)
            this.Pictures = pictures ?? throw new ArgumentNullException("pictures is a required property for UserMetadataConnections and cannot be null");
            // to ensure "portfolios" is required (not null)
            this.Portfolios = portfolios ?? throw new ArgumentNullException("portfolios is a required property for UserMetadataConnections and cannot be null");
            // to ensure "recommendedChannels" is required (not null)
            this.RecommendedChannels = recommendedChannels ?? throw new ArgumentNullException("recommendedChannels is a required property for UserMetadataConnections and cannot be null");
            // to ensure "recommendedUsers" is required (not null)
            this.RecommendedUsers = recommendedUsers ?? throw new ArgumentNullException("recommendedUsers is a required property for UserMetadataConnections and cannot be null");
            // to ensure "shared" is required (not null)
            this.Shared = shared ?? throw new ArgumentNullException("shared is a required property for UserMetadataConnections and cannot be null");
            // to ensure "videos" is required (not null)
            this.Videos = videos ?? throw new ArgumentNullException("videos is a required property for UserMetadataConnections and cannot be null");
            // to ensure "watchedVideos" is required (not null)
            this.WatchedVideos = watchedVideos ?? throw new ArgumentNullException("watchedVideos is a required property for UserMetadataConnections and cannot be null");
            // to ensure "watchlater" is required (not null)
            this.Watchlater = watchlater ?? throw new ArgumentNullException("watchlater is a required property for UserMetadataConnections and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Albums
        /// </summary>
        [DataMember(Name="albums", EmitDefaultValue=false)]
        public UserMetadataConnectionsAlbums Albums { get; set; }

        /// <summary>
        /// Gets or Sets Appearances
        /// </summary>
        [DataMember(Name="appearances", EmitDefaultValue=false)]
        public UserMetadataConnectionsAppearances Appearances { get; set; }

        /// <summary>
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public UserMetadataConnectionsBlock Block { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public UserMetadataConnectionsCategories Categories { get; set; }

        /// <summary>
        /// Gets or Sets Channels
        /// </summary>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public UserMetadataConnectionsChannels Channels { get; set; }

        /// <summary>
        /// Gets or Sets ConnectedApps
        /// </summary>
        [DataMember(Name="connected_apps", EmitDefaultValue=false)]
        public UserMetadataConnectionsConnectedApps ConnectedApps { get; set; }

        /// <summary>
        /// Gets or Sets Feed
        /// </summary>
        [DataMember(Name="feed", EmitDefaultValue=false)]
        public UserMetadataConnectionsFeed Feed { get; set; }

        /// <summary>
        /// Gets or Sets Folders
        /// </summary>
        [DataMember(Name="folders", EmitDefaultValue=false)]
        public UserMetadataConnectionsFolders Folders { get; set; }

        /// <summary>
        /// Gets or Sets Followers
        /// </summary>
        [DataMember(Name="followers", EmitDefaultValue=false)]
        public UserMetadataConnectionsFollowers Followers { get; set; }

        /// <summary>
        /// Gets or Sets Following
        /// </summary>
        [DataMember(Name="following", EmitDefaultValue=false)]
        public UserMetadataConnectionsFollowing Following { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public UserMetadataConnectionsGroups Groups { get; set; }

        /// <summary>
        /// Gets or Sets Likes
        /// </summary>
        [DataMember(Name="likes", EmitDefaultValue=false)]
        public UserMetadataConnectionsLikes Likes { get; set; }

        /// <summary>
        /// Gets or Sets ModeratedChannels
        /// </summary>
        [DataMember(Name="moderated_channels", EmitDefaultValue=false)]
        public UserMetadataConnectionsModeratedChannels ModeratedChannels { get; set; }

        /// <summary>
        /// Gets or Sets Pictures
        /// </summary>
        [DataMember(Name="pictures", EmitDefaultValue=false)]
        public UserMetadataConnectionsPictures Pictures { get; set; }

        /// <summary>
        /// Gets or Sets Portfolios
        /// </summary>
        [DataMember(Name="portfolios", EmitDefaultValue=false)]
        public UserMetadataConnectionsPortfolios Portfolios { get; set; }

        /// <summary>
        /// Gets or Sets RecommendedChannels
        /// </summary>
        [DataMember(Name="recommended_channels", EmitDefaultValue=false)]
        public UserMetadataConnectionsRecommendedChannels RecommendedChannels { get; set; }

        /// <summary>
        /// Gets or Sets RecommendedUsers
        /// </summary>
        [DataMember(Name="recommended_users", EmitDefaultValue=false)]
        public UserMetadataConnectionsRecommendedUsers RecommendedUsers { get; set; }

        /// <summary>
        /// Gets or Sets Shared
        /// </summary>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public UserMetadataConnectionsShared Shared { get; set; }

        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name="videos", EmitDefaultValue=false)]
        public UserMetadataConnectionsVideos Videos { get; set; }

        /// <summary>
        /// Gets or Sets WatchedVideos
        /// </summary>
        [DataMember(Name="watched_videos", EmitDefaultValue=false)]
        public UserMetadataConnectionsWatchedVideos WatchedVideos { get; set; }

        /// <summary>
        /// Gets or Sets Watchlater
        /// </summary>
        [DataMember(Name="watchlater", EmitDefaultValue=false)]
        public UserMetadataConnectionsWatchlater Watchlater { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserMetadataConnections {\n");
            sb.Append("  Albums: ").Append(Albums).Append("\n");
            sb.Append("  Appearances: ").Append(Appearances).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  ConnectedApps: ").Append(ConnectedApps).Append("\n");
            sb.Append("  Feed: ").Append(Feed).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
            sb.Append("  Following: ").Append(Following).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Likes: ").Append(Likes).Append("\n");
            sb.Append("  ModeratedChannels: ").Append(ModeratedChannels).Append("\n");
            sb.Append("  Pictures: ").Append(Pictures).Append("\n");
            sb.Append("  Portfolios: ").Append(Portfolios).Append("\n");
            sb.Append("  RecommendedChannels: ").Append(RecommendedChannels).Append("\n");
            sb.Append("  RecommendedUsers: ").Append(RecommendedUsers).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            sb.Append("  WatchedVideos: ").Append(WatchedVideos).Append("\n");
            sb.Append("  Watchlater: ").Append(Watchlater).Append("\n");
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
            return this.Equals(input as UserMetadataConnections);
        }

        /// <summary>
        /// Returns true if UserMetadataConnections instances are equal
        /// </summary>
        /// <param name="input">Instance of UserMetadataConnections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserMetadataConnections input)
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
                    this.Appearances == input.Appearances ||
                    (this.Appearances != null &&
                    this.Appearances.Equals(input.Appearances))
                ) && 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.Categories == input.Categories ||
                    (this.Categories != null &&
                    this.Categories.Equals(input.Categories))
                ) && 
                (
                    this.Channels == input.Channels ||
                    (this.Channels != null &&
                    this.Channels.Equals(input.Channels))
                ) && 
                (
                    this.ConnectedApps == input.ConnectedApps ||
                    (this.ConnectedApps != null &&
                    this.ConnectedApps.Equals(input.ConnectedApps))
                ) && 
                (
                    this.Feed == input.Feed ||
                    (this.Feed != null &&
                    this.Feed.Equals(input.Feed))
                ) && 
                (
                    this.Folders == input.Folders ||
                    (this.Folders != null &&
                    this.Folders.Equals(input.Folders))
                ) && 
                (
                    this.Followers == input.Followers ||
                    (this.Followers != null &&
                    this.Followers.Equals(input.Followers))
                ) && 
                (
                    this.Following == input.Following ||
                    (this.Following != null &&
                    this.Following.Equals(input.Following))
                ) && 
                (
                    this.Groups == input.Groups ||
                    (this.Groups != null &&
                    this.Groups.Equals(input.Groups))
                ) && 
                (
                    this.Likes == input.Likes ||
                    (this.Likes != null &&
                    this.Likes.Equals(input.Likes))
                ) && 
                (
                    this.ModeratedChannels == input.ModeratedChannels ||
                    (this.ModeratedChannels != null &&
                    this.ModeratedChannels.Equals(input.ModeratedChannels))
                ) && 
                (
                    this.Pictures == input.Pictures ||
                    (this.Pictures != null &&
                    this.Pictures.Equals(input.Pictures))
                ) && 
                (
                    this.Portfolios == input.Portfolios ||
                    (this.Portfolios != null &&
                    this.Portfolios.Equals(input.Portfolios))
                ) && 
                (
                    this.RecommendedChannels == input.RecommendedChannels ||
                    (this.RecommendedChannels != null &&
                    this.RecommendedChannels.Equals(input.RecommendedChannels))
                ) && 
                (
                    this.RecommendedUsers == input.RecommendedUsers ||
                    (this.RecommendedUsers != null &&
                    this.RecommendedUsers.Equals(input.RecommendedUsers))
                ) && 
                (
                    this.Shared == input.Shared ||
                    (this.Shared != null &&
                    this.Shared.Equals(input.Shared))
                ) && 
                (
                    this.Videos == input.Videos ||
                    (this.Videos != null &&
                    this.Videos.Equals(input.Videos))
                ) && 
                (
                    this.WatchedVideos == input.WatchedVideos ||
                    (this.WatchedVideos != null &&
                    this.WatchedVideos.Equals(input.WatchedVideos))
                ) && 
                (
                    this.Watchlater == input.Watchlater ||
                    (this.Watchlater != null &&
                    this.Watchlater.Equals(input.Watchlater))
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
                if (this.Appearances != null)
                    hashCode = hashCode * 59 + this.Appearances.GetHashCode();
                if (this.Block != null)
                    hashCode = hashCode * 59 + this.Block.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.ConnectedApps != null)
                    hashCode = hashCode * 59 + this.ConnectedApps.GetHashCode();
                if (this.Feed != null)
                    hashCode = hashCode * 59 + this.Feed.GetHashCode();
                if (this.Folders != null)
                    hashCode = hashCode * 59 + this.Folders.GetHashCode();
                if (this.Followers != null)
                    hashCode = hashCode * 59 + this.Followers.GetHashCode();
                if (this.Following != null)
                    hashCode = hashCode * 59 + this.Following.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Likes != null)
                    hashCode = hashCode * 59 + this.Likes.GetHashCode();
                if (this.ModeratedChannels != null)
                    hashCode = hashCode * 59 + this.ModeratedChannels.GetHashCode();
                if (this.Pictures != null)
                    hashCode = hashCode * 59 + this.Pictures.GetHashCode();
                if (this.Portfolios != null)
                    hashCode = hashCode * 59 + this.Portfolios.GetHashCode();
                if (this.RecommendedChannels != null)
                    hashCode = hashCode * 59 + this.RecommendedChannels.GetHashCode();
                if (this.RecommendedUsers != null)
                    hashCode = hashCode * 59 + this.RecommendedUsers.GetHashCode();
                if (this.Shared != null)
                    hashCode = hashCode * 59 + this.Shared.GetHashCode();
                if (this.Videos != null)
                    hashCode = hashCode * 59 + this.Videos.GetHashCode();
                if (this.WatchedVideos != null)
                    hashCode = hashCode * 59 + this.WatchedVideos.GetHashCode();
                if (this.Watchlater != null)
                    hashCode = hashCode * 59 + this.Watchlater.GetHashCode();
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

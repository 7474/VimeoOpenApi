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
    public partial class VideoMetadataInteractions :  IEquatable<VideoMetadataInteractions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataInteractions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoMetadataInteractions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataInteractions" /> class.
        /// </summary>
        /// <param name="album">album (required).</param>
        /// <param name="buy">buy (required).</param>
        /// <param name="channel">channel (required).</param>
        /// <param name="like">like (required).</param>
        /// <param name="rent">rent (required).</param>
        /// <param name="report">report (required).</param>
        /// <param name="subscribe">subscribe.</param>
        /// <param name="watched">watched (required).</param>
        /// <param name="watchlater">watchlater (required).</param>
        public VideoMetadataInteractions(VideoMetadataInteractionsAlbum album = default(VideoMetadataInteractionsAlbum), VideoMetadataInteractionsBuy buy = default(VideoMetadataInteractionsBuy), VideoMetadataInteractionsChannel channel = default(VideoMetadataInteractionsChannel), VideoMetadataInteractionsLike like = default(VideoMetadataInteractionsLike), VideoMetadataInteractionsRent rent = default(VideoMetadataInteractionsRent), VideoMetadataInteractionsReport report = default(VideoMetadataInteractionsReport), VideoMetadataInteractionsSubscribe subscribe = default(VideoMetadataInteractionsSubscribe), VideoMetadataInteractionsWatched watched = default(VideoMetadataInteractionsWatched), VideoMetadataInteractionsWatchlater watchlater = default(VideoMetadataInteractionsWatchlater))
        {
            // to ensure "album" is required (not null)
            this.Album = album ?? throw new ArgumentNullException("album is a required property for VideoMetadataInteractions and cannot be null");
            // to ensure "buy" is required (not null)
            this.Buy = buy ?? throw new ArgumentNullException("buy is a required property for VideoMetadataInteractions and cannot be null");
            // to ensure "channel" is required (not null)
            this.Channel = channel ?? throw new ArgumentNullException("channel is a required property for VideoMetadataInteractions and cannot be null");
            // to ensure "like" is required (not null)
            this.Like = like ?? throw new ArgumentNullException("like is a required property for VideoMetadataInteractions and cannot be null");
            // to ensure "rent" is required (not null)
            this.Rent = rent ?? throw new ArgumentNullException("rent is a required property for VideoMetadataInteractions and cannot be null");
            // to ensure "report" is required (not null)
            this.Report = report ?? throw new ArgumentNullException("report is a required property for VideoMetadataInteractions and cannot be null");
            // to ensure "watched" is required (not null)
            this.Watched = watched ?? throw new ArgumentNullException("watched is a required property for VideoMetadataInteractions and cannot be null");
            // to ensure "watchlater" is required (not null)
            this.Watchlater = watchlater ?? throw new ArgumentNullException("watchlater is a required property for VideoMetadataInteractions and cannot be null");
            this.Subscribe = subscribe;
        }
        
        /// <summary>
        /// Gets or Sets Album
        /// </summary>
        [DataMember(Name="album", EmitDefaultValue=true)]
        public VideoMetadataInteractionsAlbum Album { get; set; }

        /// <summary>
        /// Gets or Sets Buy
        /// </summary>
        [DataMember(Name="buy", EmitDefaultValue=true)]
        public VideoMetadataInteractionsBuy Buy { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=true)]
        public VideoMetadataInteractionsChannel Channel { get; set; }

        /// <summary>
        /// Gets or Sets Like
        /// </summary>
        [DataMember(Name="like", EmitDefaultValue=false)]
        public VideoMetadataInteractionsLike Like { get; set; }

        /// <summary>
        /// Gets or Sets Rent
        /// </summary>
        [DataMember(Name="rent", EmitDefaultValue=true)]
        public VideoMetadataInteractionsRent Rent { get; set; }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name="report", EmitDefaultValue=false)]
        public VideoMetadataInteractionsReport Report { get; set; }

        /// <summary>
        /// Gets or Sets Subscribe
        /// </summary>
        [DataMember(Name="subscribe", EmitDefaultValue=true)]
        public VideoMetadataInteractionsSubscribe Subscribe { get; set; }

        /// <summary>
        /// Gets or Sets Watched
        /// </summary>
        [DataMember(Name="watched", EmitDefaultValue=false)]
        public VideoMetadataInteractionsWatched Watched { get; set; }

        /// <summary>
        /// Gets or Sets Watchlater
        /// </summary>
        [DataMember(Name="watchlater", EmitDefaultValue=false)]
        public VideoMetadataInteractionsWatchlater Watchlater { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoMetadataInteractions {\n");
            sb.Append("  Album: ").Append(Album).Append("\n");
            sb.Append("  Buy: ").Append(Buy).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Like: ").Append(Like).Append("\n");
            sb.Append("  Rent: ").Append(Rent).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  Subscribe: ").Append(Subscribe).Append("\n");
            sb.Append("  Watched: ").Append(Watched).Append("\n");
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
            return this.Equals(input as VideoMetadataInteractions);
        }

        /// <summary>
        /// Returns true if VideoMetadataInteractions instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoMetadataInteractions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoMetadataInteractions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Album == input.Album ||
                    (this.Album != null &&
                    this.Album.Equals(input.Album))
                ) && 
                (
                    this.Buy == input.Buy ||
                    (this.Buy != null &&
                    this.Buy.Equals(input.Buy))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Like == input.Like ||
                    (this.Like != null &&
                    this.Like.Equals(input.Like))
                ) && 
                (
                    this.Rent == input.Rent ||
                    (this.Rent != null &&
                    this.Rent.Equals(input.Rent))
                ) && 
                (
                    this.Report == input.Report ||
                    (this.Report != null &&
                    this.Report.Equals(input.Report))
                ) && 
                (
                    this.Subscribe == input.Subscribe ||
                    (this.Subscribe != null &&
                    this.Subscribe.Equals(input.Subscribe))
                ) && 
                (
                    this.Watched == input.Watched ||
                    (this.Watched != null &&
                    this.Watched.Equals(input.Watched))
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
                if (this.Album != null)
                    hashCode = hashCode * 59 + this.Album.GetHashCode();
                if (this.Buy != null)
                    hashCode = hashCode * 59 + this.Buy.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Like != null)
                    hashCode = hashCode * 59 + this.Like.GetHashCode();
                if (this.Rent != null)
                    hashCode = hashCode * 59 + this.Rent.GetHashCode();
                if (this.Report != null)
                    hashCode = hashCode * 59 + this.Report.GetHashCode();
                if (this.Subscribe != null)
                    hashCode = hashCode * 59 + this.Subscribe.GetHashCode();
                if (this.Watched != null)
                    hashCode = hashCode * 59 + this.Watched.GetHashCode();
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

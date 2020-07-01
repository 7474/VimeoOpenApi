# VimeoOpenApi.Model.Album
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowContinuousPlay** | **bool** | Whether the showcase permits continuous play. | 
**AllowDownloads** | **bool** | Whether the showcase permits downloads. | 
**AllowShare** | **bool** | Whether the showcase permits sharing. | 
**Autoplay** | **bool** | Whether to start playback of the next video in the showcase&#39;s embedded playlist immediately after the previous video finishes. | 
**BrandColor** | **string** | The hexadecimal code for the color of the player buttons and showcase controls. | 
**CreatedTime** | **string** | The time in ISO 8601 format when the showcase was created. | 
**CustomLogo** | [**Picture**](Picture.md) | The custom logo of the showcase. | 
**Description** | **string** | A brief description of the showcase&#39;s content. | 
**Domain** | **string** | The custom domain of the showcase. | 
**DomainCertificateState** | **string** | The state of the SSL certificate that is associated with the showcase&#39;s domain.  Option descriptions:  * &#x60;null&#x60; - There is no associated HTTPS domain with this showcase.  * &#x60;0&#x60; - The new certificate has yet to be processed.  * &#x60;1&#x60; - The new certificate is being processed in the queue.  * &#x60;2&#x60; - The certificate is being processed for renewal in the queue.  * &#x60;3&#x60; - The new certificate has failed to be issued in the queue.  * &#x60;4&#x60; - The certificate has failed to be renewed in the queue.  * &#x60;5&#x60; - The certificate has been successfully issued.  * &#x60;6&#x60; - The certificate has been successfully renewed.  * &#x60;7&#x60; - The certificate has failed in the polling flow.  * &#x60;8&#x60; - The certificate has failed to be renewed in the polling flow.  | 
**Duration** | **decimal** | The total duration in seconds of all the videos in the showcase. | 
**Embed** | [**AlbumEmbed**](AlbumEmbed.md) |  | 
**EmbedBrandColor** | **bool?** | Whether to show the showcase&#39;s custom brand color in the player of the showcase&#39;s embedded playlist. | 
**EmbedCustomLogo** | **bool?** | Whether to show the showcase&#39;s custom logo in the player of the showcase&#39;s embedded playlist. | 
**HideNav** | **bool** | Whether to hide Vimeo navigation when displaying the showcase. | 
**HideUpcoming** | **bool** | Whether to include the upcoming live event in the showcase. | 
**HideVimeoLogo** | **bool?** | Whether to hide the Vimeo logo in the player of the showcase&#39;s embedded playlist. | 
**Layout** | **string** | The type of layout for presenting the showcase.  Option descriptions:  * &#x60;grid&#x60; - The showcase videos appear in a grid.  * &#x60;player&#x60; - The showcase videos appear in the player.  | 
**Link** | **string** | The URL of the showcase. | 
**Loop** | **bool** | Whether automatic playback restarts at the top of the showcase&#39;s embedded playlist after reaching the end of the last video in the playlist. | 
**Metadata** | [**AlbumMetadata**](AlbumMetadata.md) |  | 
**ModifiedTime** | **string** | The time in ISO 8601 format when the showcase was last modified. | 
**Name** | **string** | The display name of the showcase. | 
**Pictures** | [**Picture**](Picture.md) | The active image of the showcase. This field defaults to the thumbnail of the last video added to the showcase. | 
**Privacy** | [**AlbumPrivacy**](AlbumPrivacy.md) |  | 
**ResourceKey** | **string** | The resource key of the showcase. | 
**ReviewMode** | **bool** | Whether showcase videos use the review mode URL. | 
**SeoAllowIndexed** | **bool** | Whether search engines can index the showcase. | 
**SeoDescription** | **string** | The SEO description of the showcase. | 
**SeoKeywords** | **List&lt;string&gt;** | The SEO keywords of the showcase. | 
**SeoTitle** | **string** | The SEO title of the showcase. | 
**ShareLink** | **string** | The URL for sharing the showcase. | 
**Sort** | **string** | The sort order of the showcase.  Option descriptions:  * &#x60;added_first&#x60; - Sort the showcase videos in order of those most recently added.  * &#x60;added_last&#x60; - Sort the showcase videos in order of those least recently added.  * &#x60;alphabetical&#x60; - Sort the showcase videos alphabetically.  * &#x60;arranged&#x60; - Sort the showcase videos according to their custom arrangement.  * &#x60;comments&#x60; - Sort the showcase videos by number of comments.  * &#x60;likes&#x60; - Sort the showcase videos by number of likes.  * &#x60;newest&#x60; - Sort the showcase videos in order of creation date with the newest first.  * &#x60;oldest&#x60; - Sort the showcase videos in order of creation date with the oldest first.  * &#x60;plays&#x60; - Sort the showcase videos by number of plays.  | 
**Theme** | **string** | The color theme of the showcase.  Option descriptions:  * &#x60;dark&#x60; - The showcase uses the dark theme.  * &#x60;standard&#x60; - The showcase uses the standard theme.  | 
**Uri** | **string** | The URI of the showcase. | 
**Url** | **string** | The custom Vimeo URL of the showcase. | 
**UseCustomDomain** | **bool** | Whether the showcase uses a custom domain. | 
**User** | [**User**](User.md) | The owner of the showcase. | 
**WebBrandColor** | **bool** | Whether to use the showcase&#39;s brand color in the web layout. | 
**WebCustomLogo** | **bool** | Whether to use the showcase&#39;s custom logo in the web layout. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


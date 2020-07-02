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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using VimeoOpenApi.Client;
using VimeoOpenApi.Model;

namespace VimeoOpenApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVideosShowcasesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add or remove a video from a list of showcases
        /// </summary>
        /// <remarks>
        /// This endpoint adds the specified video to (or removes the video from) muliple showcases.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="inlineObject52"> (optional)</param>
        /// <returns>List&lt;Album&gt;</returns>
        List<Album> AddOrRemoveMultipleAlbums (decimal videoId, InlineObject52 inlineObject52 = default(InlineObject52));

        /// <summary>
        /// Add or remove a video from a list of showcases
        /// </summary>
        /// <remarks>
        /// This endpoint adds the specified video to (or removes the video from) muliple showcases.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="inlineObject52"> (optional)</param>
        /// <returns>ApiResponse of List&lt;Album&gt;</returns>
        ApiResponse<List<Album>> AddOrRemoveMultipleAlbumsWithHttpInfo (decimal videoId, InlineObject52 inlineObject52 = default(InlineObject52));
        /// <summary>
        /// Get all the albums that contain a video
        /// </summary>
        /// <remarks>
        /// This endpoint returns all the showcases that contain the specified video.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>List&lt;Album&gt;</returns>
        List<Album> GetVideoAlbums (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?));

        /// <summary>
        /// Get all the albums that contain a video
        /// </summary>
        /// <remarks>
        /// This endpoint returns all the showcases that contain the specified video.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>ApiResponse of List&lt;Album&gt;</returns>
        ApiResponse<List<Album>> GetVideoAlbumsWithHttpInfo (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVideosShowcasesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add or remove a video from a list of showcases
        /// </summary>
        /// <remarks>
        /// This endpoint adds the specified video to (or removes the video from) muliple showcases.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="inlineObject52"> (optional)</param>
        /// <returns>Task of List&lt;Album&gt;</returns>
        System.Threading.Tasks.Task<List<Album>> AddOrRemoveMultipleAlbumsAsync (decimal videoId, InlineObject52 inlineObject52 = default(InlineObject52));

        /// <summary>
        /// Add or remove a video from a list of showcases
        /// </summary>
        /// <remarks>
        /// This endpoint adds the specified video to (or removes the video from) muliple showcases.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="inlineObject52"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Album&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Album>>> AddOrRemoveMultipleAlbumsAsyncWithHttpInfo (decimal videoId, InlineObject52 inlineObject52 = default(InlineObject52));
        /// <summary>
        /// Get all the albums that contain a video
        /// </summary>
        /// <remarks>
        /// This endpoint returns all the showcases that contain the specified video.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>Task of List&lt;Album&gt;</returns>
        System.Threading.Tasks.Task<List<Album>> GetVideoAlbumsAsync (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?));

        /// <summary>
        /// Get all the albums that contain a video
        /// </summary>
        /// <remarks>
        /// This endpoint returns all the showcases that contain the specified video.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Album&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Album>>> GetVideoAlbumsAsyncWithHttpInfo (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVideosShowcasesApi : IVideosShowcasesApiSync, IVideosShowcasesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VideosShowcasesApi : IVideosShowcasesApi
    {
        private VimeoOpenApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosShowcasesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VideosShowcasesApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosShowcasesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VideosShowcasesApi(String basePath)
        {
            this.Configuration = VimeoOpenApi.Client.Configuration.MergeConfigurations(
                VimeoOpenApi.Client.GlobalConfiguration.Instance,
                new VimeoOpenApi.Client.Configuration { BasePath = basePath }
            );
            this.Client = new VimeoOpenApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new VimeoOpenApi.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = VimeoOpenApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosShowcasesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VideosShowcasesApi(VimeoOpenApi.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = VimeoOpenApi.Client.Configuration.MergeConfigurations(
                VimeoOpenApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new VimeoOpenApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new VimeoOpenApi.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = VimeoOpenApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosShowcasesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public VideosShowcasesApi(VimeoOpenApi.Client.ISynchronousClient client,VimeoOpenApi.Client.IAsynchronousClient asyncClient, VimeoOpenApi.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = VimeoOpenApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public VimeoOpenApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public VimeoOpenApi.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public VimeoOpenApi.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public VimeoOpenApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Add or remove a video from a list of showcases This endpoint adds the specified video to (or removes the video from) muliple showcases.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="inlineObject52"> (optional)</param>
        /// <returns>List&lt;Album&gt;</returns>
        public List<Album> AddOrRemoveMultipleAlbums (decimal videoId, InlineObject52 inlineObject52 = default(InlineObject52))
        {
             VimeoOpenApi.Client.ApiResponse<List<Album>> localVarResponse = AddOrRemoveMultipleAlbumsWithHttpInfo(videoId, inlineObject52);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add or remove a video from a list of showcases This endpoint adds the specified video to (or removes the video from) muliple showcases.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="inlineObject52"> (optional)</param>
        /// <returns>ApiResponse of List&lt;Album&gt;</returns>
        public VimeoOpenApi.Client.ApiResponse< List<Album> > AddOrRemoveMultipleAlbumsWithHttpInfo (decimal videoId, InlineObject52 inlineObject52 = default(InlineObject52))
        {
            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/vnd.vimeo.album+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.album+json"
            };

            var localVarContentType = VimeoOpenApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VimeoOpenApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("video_id", VimeoOpenApi.Client.ClientUtils.ParameterToString(videoId)); // path parameter
            localVarRequestOptions.Data = inlineObject52;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch< List<Album> >("/videos/{video_id}/albums", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddOrRemoveMultipleAlbums", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add or remove a video from a list of showcases This endpoint adds the specified video to (or removes the video from) muliple showcases.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="inlineObject52"> (optional)</param>
        /// <returns>Task of List&lt;Album&gt;</returns>
        public async System.Threading.Tasks.Task<List<Album>> AddOrRemoveMultipleAlbumsAsync (decimal videoId, InlineObject52 inlineObject52 = default(InlineObject52))
        {
             VimeoOpenApi.Client.ApiResponse<List<Album>> localVarResponse = await AddOrRemoveMultipleAlbumsAsyncWithHttpInfo(videoId, inlineObject52);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add or remove a video from a list of showcases This endpoint adds the specified video to (or removes the video from) muliple showcases.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="inlineObject52"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Album&gt;)</returns>
        public async System.Threading.Tasks.Task<VimeoOpenApi.Client.ApiResponse<List<Album>>> AddOrRemoveMultipleAlbumsAsyncWithHttpInfo (decimal videoId, InlineObject52 inlineObject52 = default(InlineObject52))
        {

            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/vnd.vimeo.album+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.album+json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("video_id", VimeoOpenApi.Client.ClientUtils.ParameterToString(videoId)); // path parameter
            localVarRequestOptions.Data = inlineObject52;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PatchAsync<List<Album>>("/videos/{video_id}/albums", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddOrRemoveMultipleAlbums", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all the albums that contain a video This endpoint returns all the showcases that contain the specified video.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>List&lt;Album&gt;</returns>
        public List<Album> GetVideoAlbums (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?))
        {
             VimeoOpenApi.Client.ApiResponse<List<Album>> localVarResponse = GetVideoAlbumsWithHttpInfo(videoId, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all the albums that contain a video This endpoint returns all the showcases that contain the specified video.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>ApiResponse of List&lt;Album&gt;</returns>
        public VimeoOpenApi.Client.ApiResponse< List<Album> > GetVideoAlbumsWithHttpInfo (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?))
        {
            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.album+json"
            };

            var localVarContentType = VimeoOpenApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VimeoOpenApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("video_id", VimeoOpenApi.Client.ClientUtils.ParameterToString(videoId)); // path parameter
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(VimeoOpenApi.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(VimeoOpenApi.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< List<Album> >("/videos/{video_id}/albums", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVideoAlbums", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all the albums that contain a video This endpoint returns all the showcases that contain the specified video.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>Task of List&lt;Album&gt;</returns>
        public async System.Threading.Tasks.Task<List<Album>> GetVideoAlbumsAsync (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?))
        {
             VimeoOpenApi.Client.ApiResponse<List<Album>> localVarResponse = await GetVideoAlbumsAsyncWithHttpInfo(videoId, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all the albums that contain a video This endpoint returns all the showcases that contain the specified video.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Album&gt;)</returns>
        public async System.Threading.Tasks.Task<VimeoOpenApi.Client.ApiResponse<List<Album>>> GetVideoAlbumsAsyncWithHttpInfo (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?))
        {

            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.album+json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("video_id", VimeoOpenApi.Client.ClientUtils.ParameterToString(videoId)); // path parameter
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(VimeoOpenApi.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(VimeoOpenApi.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Album>>("/videos/{video_id}/albums", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVideoAlbums", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
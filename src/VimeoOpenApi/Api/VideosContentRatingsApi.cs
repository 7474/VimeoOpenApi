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
    public interface IVideosContentRatingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all content ratings
        /// </summary>
        /// <remarks>
        /// This method returns all available content ratings.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ContentRating&gt;</returns>
        List<ContentRating> GetContentRatings ();

        /// <summary>
        /// Get all content ratings
        /// </summary>
        /// <remarks>
        /// This method returns all available content ratings.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ContentRating&gt;</returns>
        ApiResponse<List<ContentRating>> GetContentRatingsWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVideosContentRatingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get all content ratings
        /// </summary>
        /// <remarks>
        /// This method returns all available content ratings.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;ContentRating&gt;</returns>
        System.Threading.Tasks.Task<List<ContentRating>> GetContentRatingsAsync ();

        /// <summary>
        /// Get all content ratings
        /// </summary>
        /// <remarks>
        /// This method returns all available content ratings.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ContentRating&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ContentRating>>> GetContentRatingsAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVideosContentRatingsApi : IVideosContentRatingsApiSync, IVideosContentRatingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VideosContentRatingsApi : IVideosContentRatingsApi
    {
        private VimeoOpenApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosContentRatingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VideosContentRatingsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosContentRatingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VideosContentRatingsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="VideosContentRatingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VideosContentRatingsApi(VimeoOpenApi.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="VideosContentRatingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public VideosContentRatingsApi(VimeoOpenApi.Client.ISynchronousClient client,VimeoOpenApi.Client.IAsynchronousClient asyncClient, VimeoOpenApi.Client.IReadableConfiguration configuration)
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
        /// Get all content ratings This method returns all available content ratings.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ContentRating&gt;</returns>
        public List<ContentRating> GetContentRatings ()
        {
             VimeoOpenApi.Client.ApiResponse<List<ContentRating>> localVarResponse = GetContentRatingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all content ratings This method returns all available content ratings.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ContentRating&gt;</returns>
        public VimeoOpenApi.Client.ApiResponse< List<ContentRating> > GetContentRatingsWithHttpInfo ()
        {
            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.contentrating+json"
            };

            var localVarContentType = VimeoOpenApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VimeoOpenApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< List<ContentRating> >("/contentratings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetContentRatings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all content ratings This method returns all available content ratings.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;ContentRating&gt;</returns>
        public async System.Threading.Tasks.Task<List<ContentRating>> GetContentRatingsAsync ()
        {
             VimeoOpenApi.Client.ApiResponse<List<ContentRating>> localVarResponse = await GetContentRatingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all content ratings This method returns all available content ratings.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ContentRating&gt;)</returns>
        public async System.Threading.Tasks.Task<VimeoOpenApi.Client.ApiResponse<List<ContentRating>>> GetContentRatingsAsyncWithHttpInfo ()
        {

            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.contentrating+json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ContentRating>>("/contentratings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetContentRatings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}

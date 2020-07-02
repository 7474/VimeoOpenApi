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
    public interface IVideosEmbedPrivacyApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a domain to a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method adds the specified domain to a video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns></returns>
        void AddVideoPrivacyDomain (string domain, decimal videoId);

        /// <summary>
        /// Add a domain to a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method adds the specified domain to a video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddVideoPrivacyDomainWithHttpInfo (string domain, decimal videoId);
        /// <summary>
        /// Remove a domain from a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method removes the specified domain from a video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns></returns>
        void DeleteVideoPrivacyDomain (string domain, decimal videoId);

        /// <summary>
        /// Remove a domain from a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method removes the specified domain from a video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteVideoPrivacyDomainWithHttpInfo (string domain, decimal videoId);
        /// <summary>
        /// Get all the domains on a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method returns every domain on the specified video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>List&lt;Domain&gt;</returns>
        List<Domain> GetVideoPrivacyDomains (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?));

        /// <summary>
        /// Get all the domains on a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method returns every domain on the specified video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>ApiResponse of List&lt;Domain&gt;</returns>
        ApiResponse<List<Domain>> GetVideoPrivacyDomainsWithHttpInfo (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVideosEmbedPrivacyApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add a domain to a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method adds the specified domain to a video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddVideoPrivacyDomainAsync (string domain, decimal videoId);

        /// <summary>
        /// Add a domain to a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method adds the specified domain to a video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddVideoPrivacyDomainAsyncWithHttpInfo (string domain, decimal videoId);
        /// <summary>
        /// Remove a domain from a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method removes the specified domain from a video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteVideoPrivacyDomainAsync (string domain, decimal videoId);

        /// <summary>
        /// Remove a domain from a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method removes the specified domain from a video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVideoPrivacyDomainAsyncWithHttpInfo (string domain, decimal videoId);
        /// <summary>
        /// Get all the domains on a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method returns every domain on the specified video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>Task of List&lt;Domain&gt;</returns>
        System.Threading.Tasks.Task<List<Domain>> GetVideoPrivacyDomainsAsync (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?));

        /// <summary>
        /// Get all the domains on a video&#39;s whitelist
        /// </summary>
        /// <remarks>
        /// This method returns every domain on the specified video&#39;s whitelist.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Domain&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Domain>>> GetVideoPrivacyDomainsAsyncWithHttpInfo (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVideosEmbedPrivacyApi : IVideosEmbedPrivacyApiSync, IVideosEmbedPrivacyApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VideosEmbedPrivacyApi : IVideosEmbedPrivacyApi
    {
        private VimeoOpenApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosEmbedPrivacyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VideosEmbedPrivacyApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosEmbedPrivacyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VideosEmbedPrivacyApi(String basePath)
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
        /// Initializes a new instance of the <see cref="VideosEmbedPrivacyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VideosEmbedPrivacyApi(VimeoOpenApi.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="VideosEmbedPrivacyApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public VideosEmbedPrivacyApi(VimeoOpenApi.Client.ISynchronousClient client,VimeoOpenApi.Client.IAsynchronousClient asyncClient, VimeoOpenApi.Client.IReadableConfiguration configuration)
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
        /// Add a domain to a video&#39;s whitelist This method adds the specified domain to a video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns></returns>
        public void AddVideoPrivacyDomain (string domain, decimal videoId)
        {
             AddVideoPrivacyDomainWithHttpInfo(domain, videoId);
        }

        /// <summary>
        /// Add a domain to a video&#39;s whitelist This method adds the specified domain to a video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public VimeoOpenApi.Client.ApiResponse<Object> AddVideoPrivacyDomainWithHttpInfo (string domain, decimal videoId)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new VimeoOpenApi.Client.ApiException(400, "Missing required parameter 'domain' when calling VideosEmbedPrivacyApi->AddVideoPrivacyDomain");

            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = VimeoOpenApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VimeoOpenApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("domain", VimeoOpenApi.Client.ClientUtils.ParameterToString(domain)); // path parameter
            localVarRequestOptions.PathParameters.Add("video_id", VimeoOpenApi.Client.ClientUtils.ParameterToString(videoId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/videos/{video_id}/privacy/domains/{domain}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddVideoPrivacyDomain", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a domain to a video&#39;s whitelist This method adds the specified domain to a video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddVideoPrivacyDomainAsync (string domain, decimal videoId)
        {
             await AddVideoPrivacyDomainAsyncWithHttpInfo(domain, videoId);

        }

        /// <summary>
        /// Add a domain to a video&#39;s whitelist This method adds the specified domain to a video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<VimeoOpenApi.Client.ApiResponse<Object>> AddVideoPrivacyDomainAsyncWithHttpInfo (string domain, decimal videoId)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new VimeoOpenApi.Client.ApiException(400, "Missing required parameter 'domain' when calling VideosEmbedPrivacyApi->AddVideoPrivacyDomain");


            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("domain", VimeoOpenApi.Client.ClientUtils.ParameterToString(domain)); // path parameter
            localVarRequestOptions.PathParameters.Add("video_id", VimeoOpenApi.Client.ClientUtils.ParameterToString(videoId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/videos/{video_id}/privacy/domains/{domain}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddVideoPrivacyDomain", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a domain from a video&#39;s whitelist This method removes the specified domain from a video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns></returns>
        public void DeleteVideoPrivacyDomain (string domain, decimal videoId)
        {
             DeleteVideoPrivacyDomainWithHttpInfo(domain, videoId);
        }

        /// <summary>
        /// Remove a domain from a video&#39;s whitelist This method removes the specified domain from a video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public VimeoOpenApi.Client.ApiResponse<Object> DeleteVideoPrivacyDomainWithHttpInfo (string domain, decimal videoId)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new VimeoOpenApi.Client.ApiException(400, "Missing required parameter 'domain' when calling VideosEmbedPrivacyApi->DeleteVideoPrivacyDomain");

            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = VimeoOpenApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VimeoOpenApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("domain", VimeoOpenApi.Client.ClientUtils.ParameterToString(domain)); // path parameter
            localVarRequestOptions.PathParameters.Add("video_id", VimeoOpenApi.Client.ClientUtils.ParameterToString(videoId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/videos/{video_id}/privacy/domains/{domain}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteVideoPrivacyDomain", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a domain from a video&#39;s whitelist This method removes the specified domain from a video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteVideoPrivacyDomainAsync (string domain, decimal videoId)
        {
             await DeleteVideoPrivacyDomainAsyncWithHttpInfo(domain, videoId);

        }

        /// <summary>
        /// Remove a domain from a video&#39;s whitelist This method removes the specified domain from a video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">The domain name.</param>
        /// <param name="videoId">The ID of the video.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<VimeoOpenApi.Client.ApiResponse<Object>> DeleteVideoPrivacyDomainAsyncWithHttpInfo (string domain, decimal videoId)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new VimeoOpenApi.Client.ApiException(400, "Missing required parameter 'domain' when calling VideosEmbedPrivacyApi->DeleteVideoPrivacyDomain");


            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("domain", VimeoOpenApi.Client.ClientUtils.ParameterToString(domain)); // path parameter
            localVarRequestOptions.PathParameters.Add("video_id", VimeoOpenApi.Client.ClientUtils.ParameterToString(videoId)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/videos/{video_id}/privacy/domains/{domain}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteVideoPrivacyDomain", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all the domains on a video&#39;s whitelist This method returns every domain on the specified video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>List&lt;Domain&gt;</returns>
        public List<Domain> GetVideoPrivacyDomains (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?))
        {
             VimeoOpenApi.Client.ApiResponse<List<Domain>> localVarResponse = GetVideoPrivacyDomainsWithHttpInfo(videoId, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all the domains on a video&#39;s whitelist This method returns every domain on the specified video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>ApiResponse of List&lt;Domain&gt;</returns>
        public VimeoOpenApi.Client.ApiResponse< List<Domain> > GetVideoPrivacyDomainsWithHttpInfo (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?))
        {
            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.domain+json"
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
            var localVarResponse = this.Client.Get< List<Domain> >("/videos/{video_id}/privacy/domains", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVideoPrivacyDomains", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all the domains on a video&#39;s whitelist This method returns every domain on the specified video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>Task of List&lt;Domain&gt;</returns>
        public async System.Threading.Tasks.Task<List<Domain>> GetVideoPrivacyDomainsAsync (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?))
        {
             VimeoOpenApi.Client.ApiResponse<List<Domain>> localVarResponse = await GetVideoPrivacyDomainsAsyncWithHttpInfo(videoId, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all the domains on a video&#39;s whitelist This method returns every domain on the specified video&#39;s whitelist.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="videoId">The ID of the video.</param>
        /// <param name="page">The page number of the results to show. (optional)</param>
        /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Domain&gt;)</returns>
        public async System.Threading.Tasks.Task<VimeoOpenApi.Client.ApiResponse<List<Domain>>> GetVideoPrivacyDomainsAsyncWithHttpInfo (decimal videoId, decimal? page = default(decimal?), decimal? perPage = default(decimal?))
        {

            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.domain+json"
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Domain>>("/videos/{video_id}/privacy/domains", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVideoPrivacyDomains", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
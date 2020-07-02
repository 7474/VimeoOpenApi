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
    public interface IAuthenticationExtrasConvertApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Convert an OAuth 1 access token to an OAuth 2 access token
        /// </summary>
        /// <remarks>
        /// This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject29"></param>
        /// <returns>Auth</returns>
        Auth ConvertAccessToken (InlineObject29 inlineObject29);

        /// <summary>
        /// Convert an OAuth 1 access token to an OAuth 2 access token
        /// </summary>
        /// <remarks>
        /// This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject29"></param>
        /// <returns>ApiResponse of Auth</returns>
        ApiResponse<Auth> ConvertAccessTokenWithHttpInfo (InlineObject29 inlineObject29);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationExtrasConvertApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Convert an OAuth 1 access token to an OAuth 2 access token
        /// </summary>
        /// <remarks>
        /// This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject29"></param>
        /// <returns>Task of Auth</returns>
        System.Threading.Tasks.Task<Auth> ConvertAccessTokenAsync (InlineObject29 inlineObject29);

        /// <summary>
        /// Convert an OAuth 1 access token to an OAuth 2 access token
        /// </summary>
        /// <remarks>
        /// This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject29"></param>
        /// <returns>Task of ApiResponse (Auth)</returns>
        System.Threading.Tasks.Task<ApiResponse<Auth>> ConvertAccessTokenAsyncWithHttpInfo (InlineObject29 inlineObject29);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationExtrasConvertApi : IAuthenticationExtrasConvertApiSync, IAuthenticationExtrasConvertApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationExtrasConvertApi : IAuthenticationExtrasConvertApi
    {
        private VimeoOpenApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExtrasConvertApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationExtrasConvertApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExtrasConvertApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationExtrasConvertApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AuthenticationExtrasConvertApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationExtrasConvertApi(VimeoOpenApi.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AuthenticationExtrasConvertApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthenticationExtrasConvertApi(VimeoOpenApi.Client.ISynchronousClient client,VimeoOpenApi.Client.IAsynchronousClient asyncClient, VimeoOpenApi.Client.IReadableConfiguration configuration)
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
        /// Convert an OAuth 1 access token to an OAuth 2 access token This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject29"></param>
        /// <returns>Auth</returns>
        public Auth ConvertAccessToken (InlineObject29 inlineObject29)
        {
             VimeoOpenApi.Client.ApiResponse<Auth> localVarResponse = ConvertAccessTokenWithHttpInfo(inlineObject29);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Convert an OAuth 1 access token to an OAuth 2 access token This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject29"></param>
        /// <returns>ApiResponse of Auth</returns>
        public VimeoOpenApi.Client.ApiResponse< Auth > ConvertAccessTokenWithHttpInfo (InlineObject29 inlineObject29)
        {
            // verify the required parameter 'inlineObject29' is set
            if (inlineObject29 == null)
                throw new VimeoOpenApi.Client.ApiException(400, "Missing required parameter 'inlineObject29' when calling AuthenticationExtrasConvertApi->ConvertAccessToken");

            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/vnd.vimeo.auth+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.auth+json"
            };

            var localVarContentType = VimeoOpenApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VimeoOpenApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = inlineObject29;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< Auth >("/oauth/authorize/vimeo_oauth1", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConvertAccessToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Convert an OAuth 1 access token to an OAuth 2 access token This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject29"></param>
        /// <returns>Task of Auth</returns>
        public async System.Threading.Tasks.Task<Auth> ConvertAccessTokenAsync (InlineObject29 inlineObject29)
        {
             VimeoOpenApi.Client.ApiResponse<Auth> localVarResponse = await ConvertAccessTokenAsyncWithHttpInfo(inlineObject29);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Convert an OAuth 1 access token to an OAuth 2 access token This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inlineObject29"></param>
        /// <returns>Task of ApiResponse (Auth)</returns>
        public async System.Threading.Tasks.Task<VimeoOpenApi.Client.ApiResponse<Auth>> ConvertAccessTokenAsyncWithHttpInfo (InlineObject29 inlineObject29)
        {
            // verify the required parameter 'inlineObject29' is set
            if (inlineObject29 == null)
                throw new VimeoOpenApi.Client.ApiException(400, "Missing required parameter 'inlineObject29' when calling AuthenticationExtrasConvertApi->ConvertAccessToken");


            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/vnd.vimeo.auth+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.auth+json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = inlineObject29;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Auth>("/oauth/authorize/vimeo_oauth1", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConvertAccessToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
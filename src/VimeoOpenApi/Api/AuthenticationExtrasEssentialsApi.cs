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
    public interface IAuthenticationExtrasEssentialsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Revoke the current access token
        /// </summary>
        /// <remarks>
        /// This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void DeleteToken ();

        /// <summary>
        /// Revoke the current access token
        /// </summary>
        /// <remarks>
        /// This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteTokenWithHttpInfo ();
        /// <summary>
        /// Verify an OAuth 2 access token
        /// </summary>
        /// <remarks>
        /// This method verifies that an OAuth 2 access token exists.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Auth</returns>
        Auth VerifyToken ();

        /// <summary>
        /// Verify an OAuth 2 access token
        /// </summary>
        /// <remarks>
        /// This method verifies that an OAuth 2 access token exists.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Auth</returns>
        ApiResponse<Auth> VerifyTokenWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationExtrasEssentialsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Revoke the current access token
        /// </summary>
        /// <remarks>
        /// This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteTokenAsync ();

        /// <summary>
        /// Revoke the current access token
        /// </summary>
        /// <remarks>
        /// This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTokenAsyncWithHttpInfo ();
        /// <summary>
        /// Verify an OAuth 2 access token
        /// </summary>
        /// <remarks>
        /// This method verifies that an OAuth 2 access token exists.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Auth</returns>
        System.Threading.Tasks.Task<Auth> VerifyTokenAsync ();

        /// <summary>
        /// Verify an OAuth 2 access token
        /// </summary>
        /// <remarks>
        /// This method verifies that an OAuth 2 access token exists.
        /// </remarks>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Auth)</returns>
        System.Threading.Tasks.Task<ApiResponse<Auth>> VerifyTokenAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationExtrasEssentialsApi : IAuthenticationExtrasEssentialsApiSync, IAuthenticationExtrasEssentialsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationExtrasEssentialsApi : IAuthenticationExtrasEssentialsApi
    {
        private VimeoOpenApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExtrasEssentialsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationExtrasEssentialsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExtrasEssentialsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationExtrasEssentialsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AuthenticationExtrasEssentialsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationExtrasEssentialsApi(VimeoOpenApi.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AuthenticationExtrasEssentialsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthenticationExtrasEssentialsApi(VimeoOpenApi.Client.ISynchronousClient client,VimeoOpenApi.Client.IAsynchronousClient asyncClient, VimeoOpenApi.Client.IReadableConfiguration configuration)
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
        /// Revoke the current access token This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void DeleteToken ()
        {
             DeleteTokenWithHttpInfo();
        }

        /// <summary>
        /// Revoke the current access token This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public VimeoOpenApi.Client.ApiResponse<Object> DeleteTokenWithHttpInfo ()
        {
            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.auth+json"
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
            var localVarResponse = this.Client.Delete<Object>("/tokens", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Revoke the current access token This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteTokenAsync ()
        {
             await DeleteTokenAsyncWithHttpInfo();

        }

        /// <summary>
        /// Revoke the current access token This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<VimeoOpenApi.Client.ApiResponse<Object>> DeleteTokenAsyncWithHttpInfo ()
        {

            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.auth+json"
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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/tokens", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Verify an OAuth 2 access token This method verifies that an OAuth 2 access token exists.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Auth</returns>
        public Auth VerifyToken ()
        {
             VimeoOpenApi.Client.ApiResponse<Auth> localVarResponse = VerifyTokenWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Verify an OAuth 2 access token This method verifies that an OAuth 2 access token exists.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Auth</returns>
        public VimeoOpenApi.Client.ApiResponse< Auth > VerifyTokenWithHttpInfo ()
        {
            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.auth+json"
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
            var localVarResponse = this.Client.Get< Auth >("/oauth/verify", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Verify an OAuth 2 access token This method verifies that an OAuth 2 access token exists.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Auth</returns>
        public async System.Threading.Tasks.Task<Auth> VerifyTokenAsync ()
        {
             VimeoOpenApi.Client.ApiResponse<Auth> localVarResponse = await VerifyTokenAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Verify an OAuth 2 access token This method verifies that an OAuth 2 access token exists.
        /// </summary>
        /// <exception cref="VimeoOpenApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Auth)</returns>
        public async System.Threading.Tasks.Task<VimeoOpenApi.Client.ApiResponse<Auth>> VerifyTokenAsyncWithHttpInfo ()
        {

            VimeoOpenApi.Client.RequestOptions localVarRequestOptions = new VimeoOpenApi.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.vimeo.auth+json"
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Auth>("/oauth/verify", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using VimeoOpenApi.Client;
using VimeoOpenApi.Api;
using VimeoOpenApi.Model;

namespace VimeoOpenApi.Test
{
    /// <summary>
    ///  Class for testing AuthenticationExtrasAuthenticateApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthenticationExtrasAuthenticateApiTests : IDisposable
    {
        private AuthenticationExtrasAuthenticateApi instance;

        public AuthenticationExtrasAuthenticateApiTests()
        {
            instance = new AuthenticationExtrasAuthenticateApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthenticationExtrasAuthenticateApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthenticationExtrasAuthenticateApi
            //Assert.IsType(typeof(AuthenticationExtrasAuthenticateApi), instance, "instance is a AuthenticationExtrasAuthenticateApi");
        }

        
        /// <summary>
        /// Test ClientAuth
        /// </summary>
        [Fact]
        public void ClientAuthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject28 inlineObject28 = null;
            //var response = instance.ClientAuth(inlineObject28);
            //Assert.IsType<Auth> (response, "response is Auth");
        }
        
    }

}
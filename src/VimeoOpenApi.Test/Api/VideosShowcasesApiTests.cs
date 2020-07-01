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
    ///  Class for testing VideosShowcasesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VideosShowcasesApiTests : IDisposable
    {
        private VideosShowcasesApi instance;

        public VideosShowcasesApiTests()
        {
            instance = new VideosShowcasesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VideosShowcasesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VideosShowcasesApi
            //Assert.IsType(typeof(VideosShowcasesApi), instance, "instance is a VideosShowcasesApi");
        }

        
        /// <summary>
        /// Test AddOrRemoveMultipleAlbums
        /// </summary>
        [Fact]
        public void AddOrRemoveMultipleAlbumsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal videoId = null;
            //InlineObject52 inlineObject52 = null;
            //var response = instance.AddOrRemoveMultipleAlbums(videoId, inlineObject52);
            //Assert.IsType<List<Album>> (response, "response is List<Album>");
        }
        
        /// <summary>
        /// Test GetVideoAlbums
        /// </summary>
        [Fact]
        public void GetVideoAlbumsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal videoId = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetVideoAlbums(videoId, page, perPage);
            //Assert.IsType<List<Album>> (response, "response is List<Album>");
        }
        
    }

}

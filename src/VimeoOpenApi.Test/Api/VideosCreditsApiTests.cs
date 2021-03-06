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
    ///  Class for testing VideosCreditsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VideosCreditsApiTests : IDisposable
    {
        private VideosCreditsApi instance;

        public VideosCreditsApiTests()
        {
            instance = new VideosCreditsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VideosCreditsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VideosCreditsApi
            //Assert.IsType(typeof(VideosCreditsApi), instance, "instance is a VideosCreditsApi");
        }

        
        /// <summary>
        /// Test AddVideoCredit
        /// </summary>
        [Fact]
        public void AddVideoCreditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal videoId = null;
            //InlineObject57 inlineObject57 = null;
            //var response = instance.AddVideoCredit(videoId, inlineObject57);
            //Assert.IsType<Credit> (response, "response is Credit");
        }
        
        /// <summary>
        /// Test AddVideoCreditAlt1
        /// </summary>
        [Fact]
        public void AddVideoCreditAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal channelId = null;
            //decimal videoId = null;
            //InlineObject11 inlineObject11 = null;
            //var response = instance.AddVideoCreditAlt1(channelId, videoId, inlineObject11);
            //Assert.IsType<Credit> (response, "response is Credit");
        }
        
        /// <summary>
        /// Test DeleteVideoCredit
        /// </summary>
        [Fact]
        public void DeleteVideoCreditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal creditId = null;
            //decimal videoId = null;
            //instance.DeleteVideoCredit(creditId, videoId);
            
        }
        
        /// <summary>
        /// Test EditVideoCredit
        /// </summary>
        [Fact]
        public void EditVideoCreditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal creditId = null;
            //decimal videoId = null;
            //InlineObject58 inlineObject58 = null;
            //var response = instance.EditVideoCredit(creditId, videoId, inlineObject58);
            //Assert.IsType<Credit> (response, "response is Credit");
        }
        
        /// <summary>
        /// Test GetVideoCredit
        /// </summary>
        [Fact]
        public void GetVideoCreditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal creditId = null;
            //decimal videoId = null;
            //var response = instance.GetVideoCredit(creditId, videoId);
            //Assert.IsType<Credit> (response, "response is Credit");
        }
        
        /// <summary>
        /// Test GetVideoCredits
        /// </summary>
        [Fact]
        public void GetVideoCreditsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal videoId = null;
            //string direction = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //string query = null;
            //string sort = null;
            //var response = instance.GetVideoCredits(videoId, direction, page, perPage, query, sort);
            //Assert.IsType<List<Credit>> (response, "response is List<Credit>");
        }
        
        /// <summary>
        /// Test GetVideoCreditsAlt1
        /// </summary>
        [Fact]
        public void GetVideoCreditsAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal channelId = null;
            //decimal videoId = null;
            //string direction = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //string query = null;
            //string sort = null;
            //var response = instance.GetVideoCreditsAlt1(channelId, videoId, direction, page, perPage, query, sort);
            //Assert.IsType<List<Credit>> (response, "response is List<Credit>");
        }
        
    }

}

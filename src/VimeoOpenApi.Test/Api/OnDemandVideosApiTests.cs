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
    ///  Class for testing OnDemandVideosApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OnDemandVideosApiTests : IDisposable
    {
        private OnDemandVideosApi instance;

        public OnDemandVideosApiTests()
        {
            instance = new OnDemandVideosApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OnDemandVideosApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OnDemandVideosApi
            //Assert.IsType(typeof(OnDemandVideosApi), instance, "instance is a OnDemandVideosApi");
        }

        
        /// <summary>
        /// Test AddVideoToVod
        /// </summary>
        [Fact]
        public void AddVideoToVodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //decimal videoId = null;
            //InlineObject36 inlineObject36 = null;
            //var response = instance.AddVideoToVod(ondemandId, videoId, inlineObject36);
            //Assert.IsType<OnDemandVideo> (response, "response is OnDemandVideo");
        }
        
        /// <summary>
        /// Test DeleteVideoFromVod
        /// </summary>
        [Fact]
        public void DeleteVideoFromVodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //decimal videoId = null;
            //instance.DeleteVideoFromVod(ondemandId, videoId);
            
        }
        
        /// <summary>
        /// Test GetVodVideo
        /// </summary>
        [Fact]
        public void GetVodVideoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //decimal videoId = null;
            //var response = instance.GetVodVideo(ondemandId, videoId);
            //Assert.IsType<Video> (response, "response is Video");
        }
        
        /// <summary>
        /// Test GetVodVideos
        /// </summary>
        [Fact]
        public void GetVodVideosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //string direction = null;
            //string filter = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //string sort = null;
            //var response = instance.GetVodVideos(ondemandId, direction, filter, page, perPage, sort);
            //Assert.IsType<List<Video>> (response, "response is List<Video>");
        }
        
    }

}

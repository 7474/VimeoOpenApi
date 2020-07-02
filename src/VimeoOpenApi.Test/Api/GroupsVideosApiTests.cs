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
    ///  Class for testing GroupsVideosApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupsVideosApiTests : IDisposable
    {
        private GroupsVideosApi instance;

        public GroupsVideosApiTests()
        {
            instance = new GroupsVideosApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupsVideosApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupsVideosApi
            //Assert.IsType(typeof(GroupsVideosApi), instance, "instance is a GroupsVideosApi");
        }

        
        /// <summary>
        /// Test AddVideoToGroup
        /// </summary>
        [Fact]
        public void AddVideoToGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal groupId = null;
            //decimal videoId = null;
            //var response = instance.AddVideoToGroup(groupId, videoId);
            //Assert.IsType<Video> (response, "response is Video");
        }
        
        /// <summary>
        /// Test DeleteVideoFromGroup
        /// </summary>
        [Fact]
        public void DeleteVideoFromGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal groupId = null;
            //decimal videoId = null;
            //instance.DeleteVideoFromGroup(groupId, videoId);
            
        }
        
        /// <summary>
        /// Test GetGroupVideo
        /// </summary>
        [Fact]
        public void GetGroupVideoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal groupId = null;
            //decimal videoId = null;
            //var response = instance.GetGroupVideo(groupId, videoId);
            //Assert.IsType<Video> (response, "response is Video");
        }
        
        /// <summary>
        /// Test GetGroupVideos
        /// </summary>
        [Fact]
        public void GetGroupVideosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal groupId = null;
            //string direction = null;
            //string filter = null;
            //bool? filterEmbeddable = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //string query = null;
            //string sort = null;
            //var response = instance.GetGroupVideos(groupId, direction, filter, filterEmbeddable, page, perPage, query, sort);
            //Assert.IsType<List<Video>> (response, "response is List<Video>");
        }
        
    }

}
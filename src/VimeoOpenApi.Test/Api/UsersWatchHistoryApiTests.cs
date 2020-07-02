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
    ///  Class for testing UsersWatchHistoryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersWatchHistoryApiTests : IDisposable
    {
        private UsersWatchHistoryApi instance;

        public UsersWatchHistoryApiTests()
        {
            instance = new UsersWatchHistoryApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersWatchHistoryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersWatchHistoryApi
            //Assert.IsType(typeof(UsersWatchHistoryApi), instance, "instance is a UsersWatchHistoryApi");
        }

        
        /// <summary>
        /// Test DeleteFromWatchHistory
        /// </summary>
        [Fact]
        public void DeleteFromWatchHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal videoId = null;
            //instance.DeleteFromWatchHistory(videoId);
            
        }
        
        /// <summary>
        /// Test DeleteWatchHistory
        /// </summary>
        [Fact]
        public void DeleteWatchHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DeleteWatchHistory();
            
        }
        
        /// <summary>
        /// Test GetWatchHistory
        /// </summary>
        [Fact]
        public void GetWatchHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetWatchHistory(page, perPage);
            //Assert.IsType<List<Video>> (response, "response is List<Video>");
        }
        
    }

}
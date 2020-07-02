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
    ///  Class for testing EmbedPresetsVideosApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EmbedPresetsVideosApiTests : IDisposable
    {
        private EmbedPresetsVideosApi instance;

        public EmbedPresetsVideosApiTests()
        {
            instance = new EmbedPresetsVideosApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmbedPresetsVideosApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EmbedPresetsVideosApi
            //Assert.IsType(typeof(EmbedPresetsVideosApi), instance, "instance is a EmbedPresetsVideosApi");
        }

        
        /// <summary>
        /// Test AddVideoEmbedPreset
        /// </summary>
        [Fact]
        public void AddVideoEmbedPresetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal presetId = null;
            //decimal videoId = null;
            //instance.AddVideoEmbedPreset(presetId, videoId);
            
        }
        
        /// <summary>
        /// Test DeleteVideoEmbedPreset
        /// </summary>
        [Fact]
        public void DeleteVideoEmbedPresetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal presetId = null;
            //decimal videoId = null;
            //instance.DeleteVideoEmbedPreset(presetId, videoId);
            
        }
        
        /// <summary>
        /// Test GetEmbedPresetVideos
        /// </summary>
        [Fact]
        public void GetEmbedPresetVideosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal presetId = null;
            //decimal userId = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetEmbedPresetVideos(presetId, userId, page, perPage);
            //Assert.IsType<List<Video>> (response, "response is List<Video>");
        }
        
        /// <summary>
        /// Test GetEmbedPresetVideosAlt1
        /// </summary>
        [Fact]
        public void GetEmbedPresetVideosAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal presetId = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetEmbedPresetVideosAlt1(presetId, page, perPage);
            //Assert.IsType<List<Video>> (response, "response is List<Video>");
        }
        
        /// <summary>
        /// Test GetVideoEmbedPreset
        /// </summary>
        [Fact]
        public void GetVideoEmbedPresetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal presetId = null;
            //decimal videoId = null;
            //instance.GetVideoEmbedPreset(presetId, videoId);
            
        }
        
    }

}
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
    ///  Class for testing VideosTextTracksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VideosTextTracksApiTests : IDisposable
    {
        private VideosTextTracksApi instance;

        public VideosTextTracksApiTests()
        {
            instance = new VideosTextTracksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VideosTextTracksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VideosTextTracksApi
            //Assert.IsType(typeof(VideosTextTracksApi), instance, "instance is a VideosTextTracksApi");
        }

        
        /// <summary>
        /// Test CreateTextTrack
        /// </summary>
        [Fact]
        public void CreateTextTrackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal videoId = null;
            //InlineObject62 inlineObject62 = null;
            //var response = instance.CreateTextTrack(videoId, inlineObject62);
            //Assert.IsType<TextTrack> (response, "response is TextTrack");
        }
        
        /// <summary>
        /// Test CreateTextTrackAlt1
        /// </summary>
        [Fact]
        public void CreateTextTrackAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal channelId = null;
            //decimal videoId = null;
            //InlineObject13 inlineObject13 = null;
            //var response = instance.CreateTextTrackAlt1(channelId, videoId, inlineObject13);
            //Assert.IsType<TextTrack> (response, "response is TextTrack");
        }
        
        /// <summary>
        /// Test DeleteTextTrack
        /// </summary>
        [Fact]
        public void DeleteTextTrackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal texttrackId = null;
            //decimal videoId = null;
            //instance.DeleteTextTrack(texttrackId, videoId);
            
        }
        
        /// <summary>
        /// Test EditTextTrack
        /// </summary>
        [Fact]
        public void EditTextTrackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal texttrackId = null;
            //decimal videoId = null;
            //InlineObject63 inlineObject63 = null;
            //var response = instance.EditTextTrack(texttrackId, videoId, inlineObject63);
            //Assert.IsType<TextTrack> (response, "response is TextTrack");
        }
        
        /// <summary>
        /// Test GetTextTrack
        /// </summary>
        [Fact]
        public void GetTextTrackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal texttrackId = null;
            //decimal videoId = null;
            //var response = instance.GetTextTrack(texttrackId, videoId);
            //Assert.IsType<TextTrack> (response, "response is TextTrack");
        }
        
        /// <summary>
        /// Test GetTextTracks
        /// </summary>
        [Fact]
        public void GetTextTracksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal videoId = null;
            //var response = instance.GetTextTracks(videoId);
            //Assert.IsType<List<TextTrack>> (response, "response is List<TextTrack>");
        }
        
        /// <summary>
        /// Test GetTextTracksAlt1
        /// </summary>
        [Fact]
        public void GetTextTracksAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal channelId = null;
            //decimal videoId = null;
            //var response = instance.GetTextTracksAlt1(channelId, videoId);
            //Assert.IsType<List<TextTrack>> (response, "response is List<TextTrack>");
        }
        
    }

}

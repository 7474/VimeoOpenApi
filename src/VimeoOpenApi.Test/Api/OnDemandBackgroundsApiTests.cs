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
    ///  Class for testing OnDemandBackgroundsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OnDemandBackgroundsApiTests : IDisposable
    {
        private OnDemandBackgroundsApi instance;

        public OnDemandBackgroundsApiTests()
        {
            instance = new OnDemandBackgroundsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OnDemandBackgroundsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OnDemandBackgroundsApi
            //Assert.IsType(typeof(OnDemandBackgroundsApi), instance, "instance is a OnDemandBackgroundsApi");
        }

        
        /// <summary>
        /// Test CreateVodBackground
        /// </summary>
        [Fact]
        public void CreateVodBackgroundTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //var response = instance.CreateVodBackground(ondemandId);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test DeleteVodBackground
        /// </summary>
        [Fact]
        public void DeleteVodBackgroundTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal backgroundId = null;
            //decimal ondemandId = null;
            //instance.DeleteVodBackground(backgroundId, ondemandId);
            
        }
        
        /// <summary>
        /// Test EditVodBackground
        /// </summary>
        [Fact]
        public void EditVodBackgroundTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal backgroundId = null;
            //decimal ondemandId = null;
            //InlineObject31 inlineObject31 = null;
            //var response = instance.EditVodBackground(backgroundId, ondemandId, inlineObject31);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test GetVodBackground
        /// </summary>
        [Fact]
        public void GetVodBackgroundTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal backgroundId = null;
            //decimal ondemandId = null;
            //var response = instance.GetVodBackground(backgroundId, ondemandId);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test GetVodBackgrounds
        /// </summary>
        [Fact]
        public void GetVodBackgroundsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetVodBackgrounds(ondemandId, page, perPage);
            //Assert.IsType<List<Picture>> (response, "response is List<Picture>");
        }
        
    }

}
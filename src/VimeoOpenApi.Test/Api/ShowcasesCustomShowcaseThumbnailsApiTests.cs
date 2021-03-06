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
    ///  Class for testing ShowcasesCustomShowcaseThumbnailsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ShowcasesCustomShowcaseThumbnailsApiTests : IDisposable
    {
        private ShowcasesCustomShowcaseThumbnailsApi instance;

        public ShowcasesCustomShowcaseThumbnailsApiTests()
        {
            instance = new ShowcasesCustomShowcaseThumbnailsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowcasesCustomShowcaseThumbnailsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ShowcasesCustomShowcaseThumbnailsApi
            //Assert.IsType(typeof(ShowcasesCustomShowcaseThumbnailsApi), instance, "instance is a ShowcasesCustomShowcaseThumbnailsApi");
        }

        
        /// <summary>
        /// Test CreateShowcaseCustomThumb
        /// </summary>
        [Fact]
        public void CreateShowcaseCustomThumbTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal albumId = null;
            //decimal userId = null;
            //var response = instance.CreateShowcaseCustomThumb(albumId, userId);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test DeleteShowcaseCustomThumbnail
        /// </summary>
        [Fact]
        public void DeleteShowcaseCustomThumbnailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal albumId = null;
            //decimal thumbnailId = null;
            //decimal userId = null;
            //instance.DeleteShowcaseCustomThumbnail(albumId, thumbnailId, userId);
            
        }
        
        /// <summary>
        /// Test GetShowcaseCustomThumbnail
        /// </summary>
        [Fact]
        public void GetShowcaseCustomThumbnailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal albumId = null;
            //decimal thumbnailId = null;
            //decimal userId = null;
            //var response = instance.GetShowcaseCustomThumbnail(albumId, thumbnailId, userId);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test GetShowcaseCustomThumbs
        /// </summary>
        [Fact]
        public void GetShowcaseCustomThumbsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal albumId = null;
            //decimal userId = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetShowcaseCustomThumbs(albumId, userId, page, perPage);
            //Assert.IsType<List<Picture>> (response, "response is List<Picture>");
        }
        
        /// <summary>
        /// Test ReplaceShowcaseCustomThumb
        /// </summary>
        [Fact]
        public void ReplaceShowcaseCustomThumbTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal albumId = null;
            //decimal thumbnailId = null;
            //decimal userId = null;
            //InlineObject40 inlineObject40 = null;
            //var response = instance.ReplaceShowcaseCustomThumb(albumId, thumbnailId, userId, inlineObject40);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
    }

}

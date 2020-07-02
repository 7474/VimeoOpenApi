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
    ///  Class for testing UsersPicturesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersPicturesApiTests : IDisposable
    {
        private UsersPicturesApi instance;

        public UsersPicturesApiTests()
        {
            instance = new UsersPicturesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersPicturesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersPicturesApi
            //Assert.IsType(typeof(UsersPicturesApi), instance, "instance is a UsersPicturesApi");
        }

        
        /// <summary>
        /// Test CreatePicture
        /// </summary>
        [Fact]
        public void CreatePictureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal userId = null;
            //var response = instance.CreatePicture(userId);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test CreatePictureAlt1
        /// </summary>
        [Fact]
        public void CreatePictureAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreatePictureAlt1();
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test DeletePicture
        /// </summary>
        [Fact]
        public void DeletePictureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal portraitsetId = null;
            //decimal userId = null;
            //instance.DeletePicture(portraitsetId, userId);
            
        }
        
        /// <summary>
        /// Test DeletePictureAlt1
        /// </summary>
        [Fact]
        public void DeletePictureAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal portraitsetId = null;
            //instance.DeletePictureAlt1(portraitsetId);
            
        }
        
        /// <summary>
        /// Test EditPicture
        /// </summary>
        [Fact]
        public void EditPictureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal portraitsetId = null;
            //decimal userId = null;
            //InlineObject46 inlineObject46 = null;
            //var response = instance.EditPicture(portraitsetId, userId, inlineObject46);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test EditPictureAlt1
        /// </summary>
        [Fact]
        public void EditPictureAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal portraitsetId = null;
            //InlineObject22 inlineObject22 = null;
            //var response = instance.EditPictureAlt1(portraitsetId, inlineObject22);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test GetPicture
        /// </summary>
        [Fact]
        public void GetPictureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal portraitsetId = null;
            //decimal userId = null;
            //var response = instance.GetPicture(portraitsetId, userId);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test GetPictureAlt1
        /// </summary>
        [Fact]
        public void GetPictureAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal portraitsetId = null;
            //var response = instance.GetPictureAlt1(portraitsetId);
            //Assert.IsType<Picture> (response, "response is Picture");
        }
        
        /// <summary>
        /// Test GetPictures
        /// </summary>
        [Fact]
        public void GetPicturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal userId = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetPictures(userId, page, perPage);
            //Assert.IsType<List<Picture>> (response, "response is List<Picture>");
        }
        
        /// <summary>
        /// Test GetPicturesAlt1
        /// </summary>
        [Fact]
        public void GetPicturesAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetPicturesAlt1(page, perPage);
            //Assert.IsType<List<Picture>> (response, "response is List<Picture>");
        }
        
    }

}
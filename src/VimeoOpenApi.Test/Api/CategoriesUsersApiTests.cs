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
    ///  Class for testing CategoriesUsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CategoriesUsersApiTests : IDisposable
    {
        private CategoriesUsersApi instance;

        public CategoriesUsersApiTests()
        {
            instance = new CategoriesUsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CategoriesUsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CategoriesUsersApi
            //Assert.IsType(typeof(CategoriesUsersApi), instance, "instance is a CategoriesUsersApi");
        }

        
        /// <summary>
        /// Test CheckIfUserSubscribedToCategory
        /// </summary>
        [Fact]
        public void CheckIfUserSubscribedToCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //decimal userId = null;
            //instance.CheckIfUserSubscribedToCategory(category, userId);
            
        }
        
        /// <summary>
        /// Test CheckIfUserSubscribedToCategoryAlt1
        /// </summary>
        [Fact]
        public void CheckIfUserSubscribedToCategoryAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //instance.CheckIfUserSubscribedToCategoryAlt1(category);
            
        }
        
        /// <summary>
        /// Test GetCategorySubscriptions
        /// </summary>
        [Fact]
        public void GetCategorySubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal userId = null;
            //string direction = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //string sort = null;
            //var response = instance.GetCategorySubscriptions(userId, direction, page, perPage, sort);
            //Assert.IsType<List<Category>> (response, "response is List<Category>");
        }
        
        /// <summary>
        /// Test GetCategorySubscriptionsAlt1
        /// </summary>
        [Fact]
        public void GetCategorySubscriptionsAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string direction = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //string sort = null;
            //var response = instance.GetCategorySubscriptionsAlt1(direction, page, perPage, sort);
            //Assert.IsType<List<Category>> (response, "response is List<Category>");
        }
        
        /// <summary>
        /// Test SubscribeToCategory
        /// </summary>
        [Fact]
        public void SubscribeToCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal category = null;
            //decimal userId = null;
            //instance.SubscribeToCategory(category, userId);
            
        }
        
        /// <summary>
        /// Test SubscribeToCategoryAlt1
        /// </summary>
        [Fact]
        public void SubscribeToCategoryAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal category = null;
            //instance.SubscribeToCategoryAlt1(category);
            
        }
        
        /// <summary>
        /// Test UnsubscribeFromCategory
        /// </summary>
        [Fact]
        public void UnsubscribeFromCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //decimal userId = null;
            //instance.UnsubscribeFromCategory(category, userId);
            
        }
        
        /// <summary>
        /// Test UnsubscribeFromCategoryAlt1
        /// </summary>
        [Fact]
        public void UnsubscribeFromCategoryAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //instance.UnsubscribeFromCategoryAlt1(category);
            
        }
        
    }

}

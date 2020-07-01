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
    ///  Class for testing OnDemandPurchasesAndRentalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OnDemandPurchasesAndRentalsApiTests : IDisposable
    {
        private OnDemandPurchasesAndRentalsApi instance;

        public OnDemandPurchasesAndRentalsApiTests()
        {
            instance = new OnDemandPurchasesAndRentalsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OnDemandPurchasesAndRentalsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OnDemandPurchasesAndRentalsApi
            //Assert.IsType(typeof(OnDemandPurchasesAndRentalsApi), instance, "instance is a OnDemandPurchasesAndRentalsApi");
        }

        
        /// <summary>
        /// Test CheckIfVodWasPurchasedAlt1
        /// </summary>
        [Fact]
        public void CheckIfVodWasPurchasedAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //var response = instance.CheckIfVodWasPurchasedAlt1(ondemandId);
            //Assert.IsType<OnDemandPage> (response, "response is OnDemandPage");
        }
        
        /// <summary>
        /// Test GetVodPurchases
        /// </summary>
        [Fact]
        public void GetVodPurchasesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal userId = null;
            //string direction = null;
            //string filter = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //string sort = null;
            //var response = instance.GetVodPurchases(userId, direction, filter, page, perPage, sort);
            //Assert.IsType<List<OnDemandPage>> (response, "response is List<OnDemandPage>");
        }
        
        /// <summary>
        /// Test GetVodPurchasesAlt1
        /// </summary>
        [Fact]
        public void GetVodPurchasesAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string direction = null;
            //string filter = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //string sort = null;
            //var response = instance.GetVodPurchasesAlt1(direction, filter, page, perPage, sort);
            //Assert.IsType<List<OnDemandPage>> (response, "response is List<OnDemandPage>");
        }
        
    }

}

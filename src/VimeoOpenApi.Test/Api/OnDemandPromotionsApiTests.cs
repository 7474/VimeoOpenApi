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
    ///  Class for testing OnDemandPromotionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OnDemandPromotionsApiTests : IDisposable
    {
        private OnDemandPromotionsApi instance;

        public OnDemandPromotionsApiTests()
        {
            instance = new OnDemandPromotionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OnDemandPromotionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OnDemandPromotionsApi
            //Assert.IsType(typeof(OnDemandPromotionsApi), instance, "instance is a OnDemandPromotionsApi");
        }

        
        /// <summary>
        /// Test CreateVodPromotion
        /// </summary>
        [Fact]
        public void CreateVodPromotionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //InlineObject33 inlineObject33 = null;
            //var response = instance.CreateVodPromotion(ondemandId, inlineObject33);
            //Assert.IsType<OnDemandPromotion> (response, "response is OnDemandPromotion");
        }
        
        /// <summary>
        /// Test DeleteVodPromotion
        /// </summary>
        [Fact]
        public void DeleteVodPromotionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //decimal promotionId = null;
            //instance.DeleteVodPromotion(ondemandId, promotionId);
            
        }
        
        /// <summary>
        /// Test GetVodPromotion
        /// </summary>
        [Fact]
        public void GetVodPromotionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //decimal promotionId = null;
            //var response = instance.GetVodPromotion(ondemandId, promotionId);
            //Assert.IsType<OnDemandPromotion> (response, "response is OnDemandPromotion");
        }
        
        /// <summary>
        /// Test GetVodPromotionCodes
        /// </summary>
        [Fact]
        public void GetVodPromotionCodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //decimal promotionId = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetVodPromotionCodes(ondemandId, promotionId, page, perPage);
            //Assert.IsType<OnDemandPromotionCode> (response, "response is OnDemandPromotionCode");
        }
        
        /// <summary>
        /// Test GetVodPromotions
        /// </summary>
        [Fact]
        public void GetVodPromotionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal ondemandId = null;
            //string filter = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetVodPromotions(ondemandId, filter, page, perPage);
            //Assert.IsType<OnDemandPromotion> (response, "response is OnDemandPromotion");
        }
        
    }

}

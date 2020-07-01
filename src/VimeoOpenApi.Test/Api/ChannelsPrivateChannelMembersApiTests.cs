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
    ///  Class for testing ChannelsPrivateChannelMembersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ChannelsPrivateChannelMembersApiTests : IDisposable
    {
        private ChannelsPrivateChannelMembersApi instance;

        public ChannelsPrivateChannelMembersApiTests()
        {
            instance = new ChannelsPrivateChannelMembersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChannelsPrivateChannelMembersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ChannelsPrivateChannelMembersApi
            //Assert.IsType(typeof(ChannelsPrivateChannelMembersApi), instance, "instance is a ChannelsPrivateChannelMembersApi");
        }

        
        /// <summary>
        /// Test DeleteChannelPrivacyUser
        /// </summary>
        [Fact]
        public void DeleteChannelPrivacyUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal channelId = null;
            //decimal userId = null;
            //instance.DeleteChannelPrivacyUser(channelId, userId);
            
        }
        
        /// <summary>
        /// Test GetChannelPrivacyUsers
        /// </summary>
        [Fact]
        public void GetChannelPrivacyUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal channelId = null;
            //string direction = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetChannelPrivacyUsers(channelId, direction, page, perPage);
            //Assert.IsType<List<User>> (response, "response is List<User>");
        }
        
        /// <summary>
        /// Test SetChannelPrivacyUser
        /// </summary>
        [Fact]
        public void SetChannelPrivacyUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal channelId = null;
            //decimal userId = null;
            //instance.SetChannelPrivacyUser(channelId, userId);
            
        }
        
        /// <summary>
        /// Test SetChannelPrivacyUsers
        /// </summary>
        [Fact]
        public void SetChannelPrivacyUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal channelId = null;
            //InlineObject6 inlineObject6 = null;
            //var response = instance.SetChannelPrivacyUsers(channelId, inlineObject6);
            //Assert.IsType<List<User>> (response, "response is List<User>");
        }
        
    }

}

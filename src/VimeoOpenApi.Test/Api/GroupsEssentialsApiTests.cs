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
    ///  Class for testing GroupsEssentialsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupsEssentialsApiTests : IDisposable
    {
        private GroupsEssentialsApi instance;

        public GroupsEssentialsApiTests()
        {
            instance = new GroupsEssentialsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupsEssentialsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupsEssentialsApi
            //Assert.IsType(typeof(GroupsEssentialsApi), instance, "instance is a GroupsEssentialsApi");
        }

        
        /// <summary>
        /// Test CreateGroup
        /// </summary>
        [Fact]
        public void CreateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject14 inlineObject14 = null;
            //var response = instance.CreateGroup(inlineObject14);
            //Assert.IsType<Group> (response, "response is Group");
        }
        
        /// <summary>
        /// Test DeleteGroup
        /// </summary>
        [Fact]
        public void DeleteGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal groupId = null;
            //instance.DeleteGroup(groupId);
            
        }
        
        /// <summary>
        /// Test GetGroup
        /// </summary>
        [Fact]
        public void GetGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal groupId = null;
            //var response = instance.GetGroup(groupId);
            //Assert.IsType<Group> (response, "response is Group");
        }
        
        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Fact]
        public void GetGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string direction = null;
            //string filter = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //string query = null;
            //string sort = null;
            //var response = instance.GetGroups(direction, filter, page, perPage, query, sort);
            //Assert.IsType<List<Group>> (response, "response is List<Group>");
        }
        
    }

}

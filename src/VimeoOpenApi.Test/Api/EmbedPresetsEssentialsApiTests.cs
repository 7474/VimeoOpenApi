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
    ///  Class for testing EmbedPresetsEssentialsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EmbedPresetsEssentialsApiTests : IDisposable
    {
        private EmbedPresetsEssentialsApi instance;

        public EmbedPresetsEssentialsApiTests()
        {
            instance = new EmbedPresetsEssentialsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmbedPresetsEssentialsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EmbedPresetsEssentialsApi
            //Assert.IsType(typeof(EmbedPresetsEssentialsApi), instance, "instance is a EmbedPresetsEssentialsApi");
        }

        
        /// <summary>
        /// Test EditEmbedPreset
        /// </summary>
        [Fact]
        public void EditEmbedPresetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal presetId = null;
            //decimal userId = null;
            //InlineObject47 inlineObject47 = null;
            //var response = instance.EditEmbedPreset(presetId, userId, inlineObject47);
            //Assert.IsType<Presets> (response, "response is Presets");
        }
        
        /// <summary>
        /// Test EditEmbedPresetAlt1
        /// </summary>
        [Fact]
        public void EditEmbedPresetAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal presetId = null;
            //InlineObject23 inlineObject23 = null;
            //var response = instance.EditEmbedPresetAlt1(presetId, inlineObject23);
            //Assert.IsType<Presets> (response, "response is Presets");
        }
        
        /// <summary>
        /// Test GetEmbedPreset
        /// </summary>
        [Fact]
        public void GetEmbedPresetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal presetId = null;
            //decimal userId = null;
            //var response = instance.GetEmbedPreset(presetId, userId);
            //Assert.IsType<Presets> (response, "response is Presets");
        }
        
        /// <summary>
        /// Test GetEmbedPresetAlt1
        /// </summary>
        [Fact]
        public void GetEmbedPresetAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal presetId = null;
            //var response = instance.GetEmbedPresetAlt1(presetId);
            //Assert.IsType<Presets> (response, "response is Presets");
        }
        
        /// <summary>
        /// Test GetEmbedPresets
        /// </summary>
        [Fact]
        public void GetEmbedPresetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal userId = null;
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetEmbedPresets(userId, page, perPage);
            //Assert.IsType<List<Presets>> (response, "response is List<Presets>");
        }
        
        /// <summary>
        /// Test GetEmbedPresetsAlt1
        /// </summary>
        [Fact]
        public void GetEmbedPresetsAlt1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? page = null;
            //decimal? perPage = null;
            //var response = instance.GetEmbedPresetsAlt1(page, perPage);
            //Assert.IsType<List<Presets>> (response, "response is List<Presets>");
        }
        
    }

}

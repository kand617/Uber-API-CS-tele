/*
 * UberAPI.Tests
 *
 * This file was automatically generated for ACME Corp. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using ACME.CORP.API;
using ACME.CORP.API.Utilities; 
using ACME.CORP.API.Http.Client;
using ACME.CORP.API.Http.Response;
using ACME.CORP.API.Helpers;
using NUnit.Framework;
using ACME.CORP.API;
using ACME.CORP.API.Controllers;
using ACME.CORP.API.Models;
using ACME.CORP.API.Exceptions;

namespace ACME.CORP.API
{
    [TestFixture]
    public class ProductsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ProductsController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Products;
        }

        /// <summary>
        /// TODO: Add description for test TestEnsureUberPoolIsShownInSF 
        /// </summary>
        [Test]
        public async Task TestEnsureUberPoolIsShownInSF() 
        {
            // Parameters for the API call
            double latitude = 123;
            double longitude = 123;

            // Perform API call
            List<ProductModel> result = null;

            try
            {
                result = await controller.GetProductsAsync(latitude, longitude);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.AreEqual("[\n{\"name\":\"x\"},\n{\"name\":\"y\"}\n]", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody),
                    "Response body should match exactly (string literal match)");
        }

    }
}
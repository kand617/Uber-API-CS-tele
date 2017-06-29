/*
 * UberAPI.PCL
 *
 * This file was automatically generated for ACME Corp. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using ACME.CORP.API;
using ACME.CORP.API.Utilities;
using ACME.CORP.API.Http.Request;
using ACME.CORP.API.Http.Response;
using ACME.CORP.API.Http.Client;
using ACME.CORP.API.Exceptions;
using ACME.CORP.API.Models;

namespace ACME.CORP.API.Controllers
{
    public partial class EstimatesController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static EstimatesController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static EstimatesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new EstimatesController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Time Estimates
        /// </summary>
        /// <param name="startLatitude">Required parameter: Latitude component of start location.</param>
        /// <param name="startLongitude">Required parameter: Longitude component of start location.</param>
        /// <param name="customerUuid">Optional parameter: Unique customer identifier to be used for experience customization.</param>
        /// <param name="productId">Optional parameter: Unique identifier representing a specific product for a given latitude & longitude.</param>
        /// <return>Returns the List<Models.ProductModel> response from the API call</return>
        public List<Models.ProductModel> GetEstimatesTime(
                double startLatitude,
                double startLongitude,
                Guid? customerUuid = null,
                string productId = null)
        {
            Task<List<Models.ProductModel>> t = GetEstimatesTimeAsync(startLatitude, startLongitude, customerUuid, productId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Time Estimates
        /// </summary>
        /// <param name="startLatitude">Required parameter: Latitude component of start location.</param>
        /// <param name="startLongitude">Required parameter: Longitude component of start location.</param>
        /// <param name="customerUuid">Optional parameter: Unique customer identifier to be used for experience customization.</param>
        /// <param name="productId">Optional parameter: Unique identifier representing a specific product for a given latitude & longitude.</param>
        /// <return>Returns the List<Models.ProductModel> response from the API call</return>
        public async Task<List<Models.ProductModel>> GetEstimatesTimeAsync(
                double startLatitude,
                double startLongitude,
                Guid? customerUuid = null,
                string productId = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/estimates/time");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "start_latitude", startLatitude },
                { "start_longitude", startLongitude },
                { "customer_uuid", customerUuid },
                { "product_id", productId }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new ErrorErrorException(@"Unexpected error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<List<Models.ProductModel>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Price Estimates
        /// </summary>
        /// <param name="startLatitude">Required parameter: Latitude component of start location.</param>
        /// <param name="startLongitude">Required parameter: Longitude component of start location.</param>
        /// <param name="endLatitude">Required parameter: Latitude component of end location.</param>
        /// <param name="endLongitude">Required parameter: Longitude component of end location.</param>
        /// <return>Returns the List<Models.PriceEstimateModel> response from the API call</return>
        public List<Models.PriceEstimateModel> GetEstimatesPrice(
                double startLatitude,
                double startLongitude,
                double endLatitude,
                double endLongitude)
        {
            Task<List<Models.PriceEstimateModel>> t = GetEstimatesPriceAsync(startLatitude, startLongitude, endLatitude, endLongitude);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Price Estimates
        /// </summary>
        /// <param name="startLatitude">Required parameter: Latitude component of start location.</param>
        /// <param name="startLongitude">Required parameter: Longitude component of start location.</param>
        /// <param name="endLatitude">Required parameter: Latitude component of end location.</param>
        /// <param name="endLongitude">Required parameter: Longitude component of end location.</param>
        /// <return>Returns the List<Models.PriceEstimateModel> response from the API call</return>
        public async Task<List<Models.PriceEstimateModel>> GetEstimatesPriceAsync(
                double startLatitude,
                double startLongitude,
                double endLatitude,
                double endLongitude)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/estimates/price");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "start_latitude", startLatitude },
                { "start_longitude", startLongitude },
                { "end_latitude", endLatitude },
                { "end_longitude", endLongitude }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new ErrorErrorException(@"Unexpected error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<List<Models.PriceEstimateModel>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 
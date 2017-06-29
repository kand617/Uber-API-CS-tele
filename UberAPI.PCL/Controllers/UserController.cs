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
    public partial class UserController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static UserController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static UserController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new UserController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// User Profile
        /// </summary>
        /// <return>Returns the Models.ProfileModel response from the API call</return>
        public Models.ProfileModel GetMe()
        {
            Task<Models.ProfileModel> t = GetMeAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// User Profile
        /// </summary>
        /// <return>Returns the Models.ProfileModel response from the API call</return>
        public async Task<Models.ProfileModel> GetMeAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/me");


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
                return APIHelper.JsonDeserialize<Models.ProfileModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// User Activity
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is zero.</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve. Default is 5, maximum is 100.</param>
        /// <return>Returns the Models.ActivitiesModel response from the API call</return>
        public Models.ActivitiesModel GetHistory(int? offset = null, int? limit = null)
        {
            Task<Models.ActivitiesModel> t = GetHistoryAsync(offset, limit);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// User Activity
        /// </summary>
        /// <param name="offset">Optional parameter: Offset the list of returned results by this amount. Default is zero.</param>
        /// <param name="limit">Optional parameter: Number of items to retrieve. Default is 5, maximum is 100.</param>
        /// <return>Returns the Models.ActivitiesModel response from the API call</return>
        public async Task<Models.ActivitiesModel> GetHistoryAsync(int? offset = null, int? limit = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/history");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "offset", offset },
                { "limit", limit }
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
                return APIHelper.JsonDeserialize<Models.ActivitiesModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 
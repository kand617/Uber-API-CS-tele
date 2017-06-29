/*
 * UberAPI.PCL
 *
 * This file was automatically generated for ACME Corp. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ACME.CORP.API.Http.Client;

using ACME.CORP.API.Models;
using ACME.CORP.API;
using ACME.CORP.API.Utilities;


namespace ACME.CORP.API.Exceptions
{
    public class ErrorErrorException : APIException 
    {
        // These fields hold the values for the public properties.
        private int? code;
        private string message;
        private string fields;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("code")]
        public int? Code 
        { 
            get 
            {
                return this.code; 
            } 
            private set 
            {
                this.code = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            private set 
            {
                this.message = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("fields")]
        public string Fields 
        { 
            get 
            {
                return this.fields; 
            } 
            private set 
            {
                this.fields = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ErrorErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 
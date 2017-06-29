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
using ACME.CORP.API;
using ACME.CORP.API.Utilities;


namespace ACME.CORP.API.Models
{
    public class ActivityModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string uuid;

        /// <summary>
        /// Unique identifier for the activity
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid 
        { 
            get 
            {
                return this.uuid; 
            } 
            set 
            {
                this.uuid = value;
                onPropertyChanged("Uuid");
            }
        }
    }
} 
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
    public class ActivitiesModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? offset;
        private int? limit;
        private int? count;
        private List<Models.ActivityModel> history;

        /// <summary>
        /// Position in pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset 
        { 
            get 
            {
                return this.offset; 
            } 
            set 
            {
                this.offset = value;
                onPropertyChanged("Offset");
            }
        }

        /// <summary>
        /// Number of items to retrieve (100 max).
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit 
        { 
            get 
            {
                return this.limit; 
            } 
            set 
            {
                this.limit = value;
                onPropertyChanged("Limit");
            }
        }

        /// <summary>
        /// Total number of items available.
        /// </summary>
        [JsonProperty("count")]
        public int? Count 
        { 
            get 
            {
                return this.count; 
            } 
            set 
            {
                this.count = value;
                onPropertyChanged("Count");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("history")]
        public List<Models.ActivityModel> History 
        { 
            get 
            {
                return this.history; 
            } 
            set 
            {
                this.history = value;
                onPropertyChanged("History");
            }
        }
    }
} 
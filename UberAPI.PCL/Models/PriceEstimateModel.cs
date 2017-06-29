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
    public class PriceEstimateModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string productId;
        private string currencyCode;
        private string displayName;
        private string estimate;
        private double? lowEstimate;
        private double? highEstimate;
        private double? surgeMultiplier;

        /// <summary>
        /// Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId 
        { 
            get 
            {
                return this.productId; 
            } 
            set 
            {
                this.productId = value;
                onPropertyChanged("ProductId");
            }
        }

        /// <summary>
        /// [ISO 4217](http://en.wikipedia.org/wiki/ISO_4217) currency code.
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode 
        { 
            get 
            {
                return this.currencyCode; 
            } 
            set 
            {
                this.currencyCode = value;
                onPropertyChanged("CurrencyCode");
            }
        }

        /// <summary>
        /// Display name of product.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName 
        { 
            get 
            {
                return this.displayName; 
            } 
            set 
            {
                this.displayName = value;
                onPropertyChanged("DisplayName");
            }
        }

        /// <summary>
        /// Formatted string of estimate in local currency of the start location. Estimate could be a range, a single number (flat rate) or "Metered" for TAXI.
        /// </summary>
        [JsonProperty("estimate")]
        public string Estimate 
        { 
            get 
            {
                return this.estimate; 
            } 
            set 
            {
                this.estimate = value;
                onPropertyChanged("Estimate");
            }
        }

        /// <summary>
        /// Lower bound of the estimated price.
        /// </summary>
        [JsonProperty("low_estimate")]
        public double? LowEstimate 
        { 
            get 
            {
                return this.lowEstimate; 
            } 
            set 
            {
                this.lowEstimate = value;
                onPropertyChanged("LowEstimate");
            }
        }

        /// <summary>
        /// Upper bound of the estimated price.
        /// </summary>
        [JsonProperty("high_estimate")]
        public double? HighEstimate 
        { 
            get 
            {
                return this.highEstimate; 
            } 
            set 
            {
                this.highEstimate = value;
                onPropertyChanged("HighEstimate");
            }
        }

        /// <summary>
        /// Expected surge multiplier. Surge is active if surge_multiplier is greater than 1. Price estimate already factors in the surge multiplier.
        /// </summary>
        [JsonProperty("surge_multiplier")]
        public double? SurgeMultiplier 
        { 
            get 
            {
                return this.surgeMultiplier; 
            } 
            set 
            {
                this.surgeMultiplier = value;
                onPropertyChanged("SurgeMultiplier");
            }
        }
    }
} 
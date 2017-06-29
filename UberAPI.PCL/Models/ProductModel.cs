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
    public class ProductModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string productId;
        private string description;
        private string displayName;
        private string capacity;
        private string image;

        /// <summary>
        /// Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.
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
        /// Description of product.
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
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
        /// Capacity of product. For example, 4 people.
        /// </summary>
        [JsonProperty("capacity")]
        public string Capacity 
        { 
            get 
            {
                return this.capacity; 
            } 
            set 
            {
                this.capacity = value;
                onPropertyChanged("Capacity");
            }
        }

        /// <summary>
        /// Image URL representing the product.
        /// </summary>
        [JsonProperty("image")]
        public string Image 
        { 
            get 
            {
                return this.image; 
            } 
            set 
            {
                this.image = value;
                onPropertyChanged("Image");
            }
        }
    }
} 
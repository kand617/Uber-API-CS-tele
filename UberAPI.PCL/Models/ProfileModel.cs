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
    public class ProfileModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string firstName;
        private string lastName;
        private string email;
        private string picture;
        private string promoCode;

        /// <summary>
        /// First name of the Uber user.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName 
        { 
            get 
            {
                return this.firstName; 
            } 
            set 
            {
                this.firstName = value;
                onPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Last name of the Uber user.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName 
        { 
            get 
            {
                return this.lastName; 
            } 
            set 
            {
                this.lastName = value;
                onPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Email address of the Uber user
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Image URL of the Uber user.
        /// </summary>
        [JsonProperty("picture")]
        public string Picture 
        { 
            get 
            {
                return this.picture; 
            } 
            set 
            {
                this.picture = value;
                onPropertyChanged("Picture");
            }
        }

        /// <summary>
        /// Promo code of the Uber user.
        /// </summary>
        [JsonProperty("promo_code")]
        public string PromoCode 
        { 
            get 
            {
                return this.promoCode; 
            } 
            set 
            {
                this.promoCode = value;
                onPropertyChanged("PromoCode");
            }
        }
    }
} 
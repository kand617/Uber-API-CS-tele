/*
 * UberAPI.PCL
 *
 * This file was automatically generated for ACME Corp. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using ACME.CORP.API.Controllers;
using ACME.CORP.API.Http.Client;

namespace ACME.CORP.API
{
    public partial class UberAPIClient
    {

        /// <summary>
        /// Singleton access to User controller
        /// </summary>
        public UserController User
        {
            get
            {
                return UserController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Estimates controller
        /// </summary>
        public EstimatesController Estimates
        {
            get
            {
                return EstimatesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Products controller
        /// </summary>
        public ProductsController Products
        {
            get
            {
                return ProductsController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public UberAPIClient() { }
    }
}
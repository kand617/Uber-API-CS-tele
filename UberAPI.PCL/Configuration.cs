using System.Collections.Generic;
using System.Text;
using ACME.CORP.API.Models;
using ACME.CORP.API.Utilities;

namespace ACME.CORP.API
{
    public partial class Configuration
    {
        public enum Environments
        {
            PRODUCTION,
            TESTING,
        }
        public enum Servers
        {
            DEFAULT,
            AUTH,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //TODO: Replace the TemplateParam with an appropriate value
        public static Models.TemplateParamEnum? TemplateParam = TemplateParamEnum.ABC;

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.DEFAULT,"https://api.uber.com/" },
                        { Servers.AUTH,"http://auth.example.com/{templateParam}" },
                    }
                },
                { 
                    Environments.TESTING,new Dictionary<Servers, string>
                    {
                        { Servers.DEFAULT,"http://uber.example.com/testing" },
                        { Servers.AUTH,"http://uberauth.example.com/testing" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("templateParam", Models.TemplateParamEnumHelper.ToValue(TemplateParam.Value)),
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}
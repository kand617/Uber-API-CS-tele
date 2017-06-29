/*
 * UberAPI.PCL
 *
 * This file was automatically generated for ACME Corp. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ACME.CORP.API;
using ACME.CORP.API.Utilities;

namespace ACME.CORP.API.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum TemplateParamEnum
    {
        ABC, //TODO: Write general description for this method
        DEF, //TODO: Write general description for this method
        GHI, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type TemplateParamEnum
    /// </summary>
    public static class TemplateParamEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "abc", "def", "ghi" };

        /// <summary>
        /// Converts a TemplateParamEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The TemplateParamEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(TemplateParamEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case TemplateParamEnum.ABC:
                case TemplateParamEnum.DEF:
                case TemplateParamEnum.GHI:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of TemplateParamEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of TemplateParamEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<TemplateParamEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into TemplateParamEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed TemplateParamEnum value</returns>
        public static TemplateParamEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type TemplateParamEnum", value));

            return (TemplateParamEnum) index;
        }
    }
} 
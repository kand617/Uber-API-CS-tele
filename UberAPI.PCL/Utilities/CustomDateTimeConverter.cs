using Newtonsoft.Json.Converters;

namespace ACME.CORP.API.Utilities
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
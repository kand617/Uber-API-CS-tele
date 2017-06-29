/*
 * UberAPI.Tests
 *
 * This file was automatically generated for ACME Corp. by APIMATIC v2.0 ( https://apimatic.io )
 */
using ACME.CORP.API.Http.Client;
using ACME.CORP.API.Http.Request;
using ACME.CORP.API.Http.Response;

namespace ACME.CORP.API.Helpers
{
    public class HttpCallBackEventsHandler
    {
        public HttpRequest Request { get; private set; }

        public HttpResponse Response { get; private set; }

        public void OnBeforeHttpRequestEventHandler(IHttpClient source, HttpRequest request)
        {
            this.Request = request;
        }

        public void OnAfterHttpResponseEventHandler(IHttpClient source, HttpResponse response)
        {
            this.Response = response;
        }
    }
}

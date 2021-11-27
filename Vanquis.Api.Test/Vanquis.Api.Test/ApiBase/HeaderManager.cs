using RestSharp;
using System.Collections.Generic;

namespace Vanquis.Api.Test
{
    /// <summary>
    /// This class is to be used to add request headers to the container to be sent to the API
    /// </summary>
    public static class HeaderManager
    {
        /// <summary>
        /// This method adds a request header to the container to be sent to the API
        /// </summary>
        /// <param name="restRequest"> Container for data that is sent to API </param>
        /// <param name="name"> The name of the parameter </param>
        /// <param name="value"> The value of the parameter </param>
        /// <returns> Container for data that is sent to API </returns>
        public static IRestRequest AddRequestHeader(RestRequest restRequest, string name, string value)
        {
            return restRequest.AddHeader(name, value);
        }

        /// <summary>
        /// This method receive multiple headers to add to the container to be sent to the API
        /// </summary>
        /// <param name="restRequest"> Container for data that is sent to API </param>
        /// <param name="headers"> The list of headers </param>
        /// <returns> Container for data that is sent to API </returns>
        public static IRestRequest AddRequestHeader(RestRequest restRequest, Dictionary<string, string> headers)
        {
            foreach (KeyValuePair<string, string> header in headers)
            {
                restRequest.AddHeader(header.Key, header.Value);
            }
            return restRequest;
        }
    }
}
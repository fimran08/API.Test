using RestSharp;
using System.Collections.Generic;

namespace Vanquis.Api.Test
{
    /// <summary>
    /// The methods in this class can be used to add Query parameter to the container to be sent to the API
    /// </summary>
    public class QueryParameterManager
    {
        /// <summary>
        /// Method for adding a query parameter to the container to be sent to the API. This can be used for adding a header, query parameter or request body to the container
        /// </summary>
        /// <param name="restRequest"> Container for data that is sent to API </param>
        /// <param name="name"> The name of the parameter </param>
        /// <param name="value"> The value of the parameter </param>
        /// <returns> Container for data that is sent to API </returns>
        public static IRestRequest AddRequestQueryParameter(RestRequest restRequest, string name, string value)
        {
            return restRequest.AddQueryParameter(name, value);
        }

        /// <summary>
        /// This method receive multiple Query parameter to add to the container to be sent to the API
        /// </summary>
        /// <param name="restRequest"> Container for data that is sent to API </param>
        /// <param name="queryParameters"> The list of parameters </param>
        /// <returns> Container for data that is sent to API </returns>
        public static IRestRequest AddRequestQueryParameter(RestRequest restRequest, Dictionary<string, string> queryParameters)
        {
            foreach (KeyValuePair<string, string> parameter in queryParameters)
            {
                restRequest.AddQueryParameter(parameter.Key, parameter.Value);
            }
            return restRequest;
        }
    }
}

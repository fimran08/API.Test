using RestSharp;

namespace Vanquis.Api.Test
{
    /// <summary>
    /// This is the base class that all API tests will inherit from.
    /// </summary>
    public abstract class ApiBase
    {
        /// <summary>
        ///  Client to translate RestRequests into HTTP requests and process response results
        /// </summary>
        public static RestClient RestClient;

        /// <summary>
        /// Container for the data sent to the API
        /// </summary>
        public static RestRequest RestRequest;
        
        /// <summary>
        /// Interface for the container for the data sent to the API
        /// Contains the Endpoint, Headers, Body etc
        /// </summary>
        public static IRestRequest IRestRequest;

        /// <summary>
        /// Container for the data sent back from the API
        /// Contains the response status code, response content etc
        /// </summary>
        public static IRestResponse RestResponse;

        /// <summary>
        /// Constructor used to initialise the API base
        /// </summary>
        /// <param name="restClient"> Client to translate RestRequests into HTTP requests and process response results </param>
        /// <param name="restRequest"> Container for the data sent to the API </param>
        /// <param name="iRestRequest"> Interface for the container for the data sent to the API </param>
        /// <param name="restResponse"> Container for the data sent back from the API </param>
        public ApiBase(RestClient restClient, RestRequest restRequest, IRestRequest iRestRequest, IRestResponse restResponse)
        {
            RestClient = restClient;
            RestRequest = restRequest;
            RestResponse = restResponse;
            IRestRequest = iRestRequest;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public ApiBase() { }
    }
}
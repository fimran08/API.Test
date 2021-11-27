using RestSharp;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Vanquis.Api.Test.Actions
{
    /// <summary>
    /// This class methods will receive the parameters and create the GET request and triggers the request to get the Response 
    /// </summary>
    public class GetCallManager : ApiBase
    {
        /// <summary>
        /// This method will receive the parameters to create the GET request and send the respone back
        /// </summary>
        /// <param name="endPoint"> The URL request need to triggered </param>
        /// <param name="dataFormat"> Type of body format </param>
        /// <param name="parameters"> List of all parameters with its type</param>
        /// <returns> Response from API </returns>
        public static IRestResponse TriggerCall(string endPoint, DataFormat dataFormat, [Optional]IList<RequestParameter> parameters)
        {
            RestRequest = RequestMethodManager.SetRequestMethod(RestRequest, Method.GET, dataFormat);
            if (parameters != null)
                IRestRequest = ParameterManager.AddRequestParameter(RestRequest, parameters);
            IRestRequest = RestRequest;
            RestClient = EndpointManager.SetRequestEndpoint(RestClient, endPoint);
            RestResponse = RequestManager.SendRequestAndGetResponse(RestClient, RestResponse, IRestRequest);
            return RestResponse;
        }

        /// <summary>
        /// This method will receive the parameters to create the GET request and send the respone back
        /// </summary>
        /// <param name="endPoint"> The URL request need to triggered </param>
        /// <param name="dataFormat"> Type of body format </param>
        /// <param name="parameters"> Dictionary of parameter of one type QueryString or Header </param>
        /// <param name="parameterType"> Type of dictionary parameter </param>
        /// <returns> Response from API </returns>
        public static IRestResponse TriggerCall(string endPoint, DataFormat dataFormat, [Optional]Dictionary<string, string> parameters, [Optional] ParameterType parameterType)
        {
            RestRequest = RequestMethodManager.SetRequestMethod(RestRequest, Method.GET, dataFormat);
            if (parameters != null)
                IRestRequest = ParameterManager.AddRequestParameter(RestRequest, parameters, parameterType);
            IRestRequest = RestRequest;
            RestClient = EndpointManager.SetRequestEndpoint(RestClient, endPoint);
            RestResponse = RequestManager.SendRequestAndGetResponse(RestClient, RestResponse, IRestRequest);
            return RestResponse;
        }
    }
}
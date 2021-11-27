using RestSharp;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Vanquis.Api.Test.Actions
{
    /// <summary>
    /// This class methods will receive the parameters to create the  Post request and triggers the request to get the Response 
    /// </summary>
    public class PostCallManager : ApiBase
    {
        /// <summary>
        /// This method will receive the parameters to create the  Post request and send the respone back
        /// </summary>
        /// <param name="endPoint"> The URL request need to triggered </param>
        /// <param name="dataFormat"> Type of body format </param>
        /// <param name="parameters"> Dictionary of parameter of one type QueryString or Header </param>
        /// <param name="parameterType"> Type of dictionary parameter </param>
        /// <param name="requestBody"> Request object that is sent to the API </param>
        /// <returns> Response from API </returns>
        public static IRestResponse TriggerCall(string endPoint, DataFormat dataFormat, object requestBody, [Optional] Dictionary<string, string> parameters, [Optional] ParameterType parameterType)
        {
            RestRequest = RequestMethodManager.SetRequestMethod(RestRequest, Method.POST, dataFormat);
            if (parameters != null)
                IRestRequest = ParameterManager.AddRequestParameter(RestRequest, parameters, parameterType);
            IRestRequest = RequestBodyManager.AddJsonRequestToBody(RestRequest, requestBody);
            RestClient = EndpointManager.SetRequestEndpoint(RestClient, endPoint);
            RestResponse = RequestManager.SendRequestAndGetResponse(RestClient, RestResponse, IRestRequest);
            return RestResponse;
        }
    }
}
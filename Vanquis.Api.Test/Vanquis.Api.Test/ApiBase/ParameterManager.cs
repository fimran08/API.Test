using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace Vanquis.Api.Test
{
    /// <summary>
    /// The methods in this class can be used to add parameters to the container to be sent to the API
    /// </summary>
    public static class ParameterManager
    {
        /// <summary>
        /// Method for adding a parameter to the container to be sent to the API. This can be used for adding a header, query parameter or request body to the container
        /// This allows a JSON object to be added to the container
        /// </summary>
        /// <param name="restRequest"> Container for data that is sent to API </param>
        /// <param name="name"> The name of the parameter </param>
        /// <param name="value"> The value of the parameter </param>
        /// <param name="parameterType"> Types of parameter that can be added to a request </param>
        /// <returns> Container for data that is sent to API </returns>
        public static IRestRequest AddRequestParameter(RestRequest restRequest, string name, object value, ParameterType parameterType)
        {
            var requestJson = JsonConvert.SerializeObject(value);
            return restRequest.AddParameter(name, requestJson, parameterType);
        }

        /// <summary>
        /// Method for adding a parameter to the container to be sent to the API. This can be used for adding a header, query parameter or request body to the container
        /// </summary>
        /// <param name="restRequest"> Container for data that is sent to API </param>
        /// <param name="name"> The name of the parameter </param>
        /// <param name="value"> The value of the parameter </param>
        /// <param name="parameterType"> Types of parameter that can be added to a request </param>
        /// <returns> Container for data that is sent to API </returns>
        public static IRestRequest AddRequestParameter(RestRequest restRequest, string name, string value, ParameterType parameterType)
        {
            return restRequest.AddParameter(name, value, parameterType);
        }

        
        /// <summary>
        /// This method receive multiple paremeter which can be query string or header to add to the container to be sent to the API
        /// </summary>
        /// <param name="restRequest"> Container for data that is sent to API </param>
        /// <param name="Parameters"> This dictionary contains multiple query string or headers </param>
        /// <param name="type"> To identify the paramert type </param>
        /// <returns> Container for data that is sent to API </returns>
        public static IRestRequest AddRequestParameter(RestRequest restRequest, Dictionary<string, string> Parameters, ParameterType type)
        {
            switch (type)
            {
                case ParameterType.HttpHeader:

                    foreach (KeyValuePair<string, string> parameter in Parameters)
                    {
                        restRequest.AddHeader(parameter.Key, parameter.Value);
                    }
                    break;
                case ParameterType.QueryString:
                    foreach (KeyValuePair<string, string> parameter in Parameters)
                    {
                        restRequest.AddQueryParameter(parameter.Key, parameter.Value);
                    }
                    break;
            }
            return restRequest;
        }

        /// <summary>
        /// This method will receive the Parameter object containing key, name and parameter type to add to the container to be sent to the API
        /// </summary>
        /// <param name="restRequest"> Container for data that is sent to API </param>
        /// <param name="parameters"> This is object of Parameter which will contain key, value and type for each entry in list </param>
        /// <returns> Container for data that is sent to API </returns>
        public static IRestRequest AddRequestParameter(RestRequest restRequest, IList<RequestParameter> parameters)
        {
            foreach(RequestParameter parameter in parameters)
            {
                restRequest.AddParameter(parameter.parameterKey, parameter.parameterValue, parameter.parameterType);
            }
            return restRequest; 
        }
    }
}
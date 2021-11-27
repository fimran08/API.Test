using RestSharp;

namespace Vanquis.Api.Test
{
    /// <summary>
    /// This class is used to create an object to rtecive the list of request parameter
    /// </summary>
    public class RequestParameter
    {
        /// <summary>
        /// this field will contain the Key of parameter to be added in request
        /// </summary>
        public string parameterKey { get; set; }

        /// <summary>
        /// This field will contain the value of key
        /// </summary>
        public string parameterValue { get; set; }

        /// <summary>
        /// This field will contain the parameter type to be adeed in request 
        /// </summary>
        public ParameterType parameterType { get; set; }
    }
}

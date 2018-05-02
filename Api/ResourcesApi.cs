/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using DocuSign.Core.Client;
using DocuSign.Core.Model;

namespace DocuSign.Core.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IResourcesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Lists resources for REST version specified
        /// </summary>
        /// <remarks>
        /// Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Resources</returns>
        Resources ServiceInformationGetResourceInformation ();

        /// <summary>
        /// Lists resources for REST version specified
        /// </summary>
        /// <remarks>
        /// Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Resources</returns>
        ApiResponse<Resources> ServiceInformationGetResourceInformationWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Lists resources for REST version specified
        /// </summary>
        /// <remarks>
        /// Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Resources</returns>
        System.Threading.Tasks.Task<Resources> ServiceInformationGetResourceInformationAsync ();

        /// <summary>
        /// Lists resources for REST version specified
        /// </summary>
        /// <remarks>
        /// Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Resources)</returns>
        System.Threading.Tasks.Task<ApiResponse<Resources>> ServiceInformationGetResourceInformationAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ResourcesApi : IResourcesApi
    {
        private DocuSign.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResourcesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = DocuSign.Core.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ResourcesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = DocuSign.Core.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DocuSign.Core.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Lists resources for REST version specified Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Resources</returns>
        public Resources ServiceInformationGetResourceInformation ()
        {
             ApiResponse<Resources> localVarResponse = ServiceInformationGetResourceInformationWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lists resources for REST version specified Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Resources</returns>
        public ApiResponse< Resources > ServiceInformationGetResourceInformationWithHttpInfo ()
        {

            var localVarPath = "/v2";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInformationGetResourceInformation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Resources>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Resources) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Resources)));
            
        }

        /// <summary>
        /// Lists resources for REST version specified Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Resources</returns>
        public async System.Threading.Tasks.Task<Resources> ServiceInformationGetResourceInformationAsync ()
        {
             ApiResponse<Resources> localVarResponse = await ServiceInformationGetResourceInformationAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lists resources for REST version specified Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Resources)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Resources>> ServiceInformationGetResourceInformationAsyncWithHttpInfo ()
        {

            var localVarPath = "/v2";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInformationGetResourceInformation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Resources>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Resources) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Resources)));
            
        }

    }
}

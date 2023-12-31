/*
 * Insights.Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemWarningsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// System Warnings
        /// </summary>
        /// <remarks>
        /// This endpoint provides system warnings data. Results can be filtered by warning type and a range of DateTime parameters.  - If no parameters are specified then the latest message is returned  - If just a warning type is specified then the latest message of that type is returned  - If just publish times are specified then all messages within that range are returned
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warningType"> (optional)</param>
        /// <param name="publishDateTimeFrom"> (optional)</param>
        /// <param name="publishDateTimeTo"> (optional)</param>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData</returns>
        InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData SystemWarningsGet(string? warningType = default(string?), DateTime? publishDateTimeFrom = default(DateTime?), DateTime? publishDateTimeTo = default(DateTime?), string? format = default(string?), int operationIndex = 0);

        /// <summary>
        /// System Warnings
        /// </summary>
        /// <remarks>
        /// This endpoint provides system warnings data. Results can be filtered by warning type and a range of DateTime parameters.  - If no parameters are specified then the latest message is returned  - If just a warning type is specified then the latest message of that type is returned  - If just publish times are specified then all messages within that range are returned
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warningType"> (optional)</param>
        /// <param name="publishDateTimeFrom"> (optional)</param>
        /// <param name="publishDateTimeTo"> (optional)</param>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData</returns>
        ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData> SystemWarningsGetWithHttpInfo(string? warningType = default(string?), DateTime? publishDateTimeFrom = default(DateTime?), DateTime? publishDateTimeTo = default(DateTime?), string? format = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemWarningsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// System Warnings
        /// </summary>
        /// <remarks>
        /// This endpoint provides system warnings data. Results can be filtered by warning type and a range of DateTime parameters.  - If no parameters are specified then the latest message is returned  - If just a warning type is specified then the latest message of that type is returned  - If just publish times are specified then all messages within that range are returned
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warningType"> (optional)</param>
        /// <param name="publishDateTimeFrom"> (optional)</param>
        /// <param name="publishDateTimeTo"> (optional)</param>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData</returns>
        System.Threading.Tasks.Task<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData> SystemWarningsGetAsync(string? warningType = default(string?), DateTime? publishDateTimeFrom = default(DateTime?), DateTime? publishDateTimeTo = default(DateTime?), string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// System Warnings
        /// </summary>
        /// <remarks>
        /// This endpoint provides system warnings data. Results can be filtered by warning type and a range of DateTime parameters.  - If no parameters are specified then the latest message is returned  - If just a warning type is specified then the latest message of that type is returned  - If just publish times are specified then all messages within that range are returned
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warningType"> (optional)</param>
        /// <param name="publishDateTimeFrom"> (optional)</param>
        /// <param name="publishDateTimeTo"> (optional)</param>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData)</returns>
        System.Threading.Tasks.Task<ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData>> SystemWarningsGetWithHttpInfoAsync(string? warningType = default(string?), DateTime? publishDateTimeFrom = default(DateTime?), DateTime? publishDateTimeTo = default(DateTime?), string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemWarningsApi : ISystemWarningsApiSync, ISystemWarningsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SystemWarningsApi : ISystemWarningsApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemWarningsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemWarningsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemWarningsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemWarningsApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemWarningsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SystemWarningsApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemWarningsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SystemWarningsApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
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
        /// System Warnings This endpoint provides system warnings data. Results can be filtered by warning type and a range of DateTime parameters.  - If no parameters are specified then the latest message is returned  - If just a warning type is specified then the latest message of that type is returned  - If just publish times are specified then all messages within that range are returned
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warningType"> (optional)</param>
        /// <param name="publishDateTimeFrom"> (optional)</param>
        /// <param name="publishDateTimeTo"> (optional)</param>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData</returns>
        public InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData SystemWarningsGet(string? warningType = default(string?), DateTime? publishDateTimeFrom = default(DateTime?), DateTime? publishDateTimeTo = default(DateTime?), string? format = default(string?), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData> localVarResponse = SystemWarningsGetWithHttpInfo(warningType, publishDateTimeFrom, publishDateTimeTo, format);
            return localVarResponse.Data;
        }

        /// <summary>
        /// System Warnings This endpoint provides system warnings data. Results can be filtered by warning type and a range of DateTime parameters.  - If no parameters are specified then the latest message is returned  - If just a warning type is specified then the latest message of that type is returned  - If just publish times are specified then all messages within that range are returned
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warningType"> (optional)</param>
        /// <param name="publishDateTimeFrom"> (optional)</param>
        /// <param name="publishDateTimeTo"> (optional)</param>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData</returns>
        public Org.OpenAPITools.Client.ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData> SystemWarningsGetWithHttpInfo(string? warningType = default(string?), DateTime? publishDateTimeFrom = default(DateTime?), DateTime? publishDateTimeTo = default(DateTime?), string? format = default(string?), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "text/csv"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (warningType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "warningType", warningType));
            }
            if (publishDateTimeFrom != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "publishDateTimeFrom", publishDateTimeFrom));
            }
            if (publishDateTimeTo != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "publishDateTimeTo", publishDateTimeTo));
            }
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }

            localVarRequestOptions.Operation = "SystemWarningsApi.SystemWarningsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData>("/system/warnings", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SystemWarningsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// System Warnings This endpoint provides system warnings data. Results can be filtered by warning type and a range of DateTime parameters.  - If no parameters are specified then the latest message is returned  - If just a warning type is specified then the latest message of that type is returned  - If just publish times are specified then all messages within that range are returned
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warningType"> (optional)</param>
        /// <param name="publishDateTimeFrom"> (optional)</param>
        /// <param name="publishDateTimeTo"> (optional)</param>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData</returns>
        public async System.Threading.Tasks.Task<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData> SystemWarningsGetAsync(string? warningType = default(string?), DateTime? publishDateTimeFrom = default(DateTime?), DateTime? publishDateTimeTo = default(DateTime?), string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData> localVarResponse = await SystemWarningsGetWithHttpInfoAsync(warningType, publishDateTimeFrom, publishDateTimeTo, format, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// System Warnings This endpoint provides system warnings data. Results can be filtered by warning type and a range of DateTime parameters.  - If no parameters are specified then the latest message is returned  - If just a warning type is specified then the latest message of that type is returned  - If just publish times are specified then all messages within that range are returned
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warningType"> (optional)</param>
        /// <param name="publishDateTimeFrom"> (optional)</param>
        /// <param name="publishDateTimeTo"> (optional)</param>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData>> SystemWarningsGetWithHttpInfoAsync(string? warningType = default(string?), DateTime? publishDateTimeFrom = default(DateTime?), DateTime? publishDateTimeTo = default(DateTime?), string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "text/csv"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (warningType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "warningType", warningType));
            }
            if (publishDateTimeFrom != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "publishDateTimeFrom", publishDateTimeFrom));
            }
            if (publishDateTimeTo != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "publishDateTimeTo", publishDateTimeTo));
            }
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }

            localVarRequestOptions.Operation = "SystemWarningsApi.SystemWarningsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<InsightsApiModelsResponsesResponseWithMetadata1InsightsApiModelsResponsesMiscSystemWarningsData>("/system/warnings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SystemWarningsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

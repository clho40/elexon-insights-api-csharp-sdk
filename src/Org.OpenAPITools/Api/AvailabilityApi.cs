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
    public interface IAvailabilityApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fourteen-day generation forecast
        /// </summary>
        /// <remarks>
        /// This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        List<InsightsApiModelsResponsesGenerationAggregatedForecast> GenerationAvailabilitySummary14DGet(string? format = default(string?), int operationIndex = 0);

        /// <summary>
        /// Fourteen-day generation forecast
        /// </summary>
        /// <remarks>
        /// This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> GenerationAvailabilitySummary14DGetWithHttpInfo(string? format = default(string?), int operationIndex = 0);
        /// <summary>
        /// Three-year generation forecast
        /// </summary>
        /// <remarks>
        /// This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        List<InsightsApiModelsResponsesGenerationAggregatedForecast> GenerationAvailabilitySummary3YWGet(string? format = default(string?), int operationIndex = 0);

        /// <summary>
        /// Three-year generation forecast
        /// </summary>
        /// <remarks>
        /// This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> GenerationAvailabilitySummary3YWGetWithHttpInfo(string? format = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAvailabilityApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Fourteen-day generation forecast
        /// </summary>
        /// <remarks>
        /// This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        System.Threading.Tasks.Task<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> GenerationAvailabilitySummary14DGetAsync(string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Fourteen-day generation forecast
        /// </summary>
        /// <remarks>
        /// This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>>> GenerationAvailabilitySummary14DGetWithHttpInfoAsync(string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Three-year generation forecast
        /// </summary>
        /// <remarks>
        /// This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        System.Threading.Tasks.Task<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> GenerationAvailabilitySummary3YWGetAsync(string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Three-year generation forecast
        /// </summary>
        /// <remarks>
        /// This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>>> GenerationAvailabilitySummary3YWGetWithHttpInfoAsync(string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAvailabilityApi : IAvailabilityApiSync, IAvailabilityApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AvailabilityApi : IAvailabilityApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AvailabilityApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AvailabilityApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AvailabilityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AvailabilityApi(Org.OpenAPITools.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AvailabilityApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AvailabilityApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
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
        /// Fourteen-day generation forecast This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        public List<InsightsApiModelsResponsesGenerationAggregatedForecast> GenerationAvailabilitySummary14DGet(string? format = default(string?), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> localVarResponse = GenerationAvailabilitySummary14DGetWithHttpInfo(format);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fourteen-day generation forecast This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        public Org.OpenAPITools.Client.ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> GenerationAvailabilitySummary14DGetWithHttpInfo(string? format = default(string?), int operationIndex = 0)
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

            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }

            localVarRequestOptions.Operation = "AvailabilityApi.GenerationAvailabilitySummary14DGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<InsightsApiModelsResponsesGenerationAggregatedForecast>>("/generation/availability/summary/14D", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GenerationAvailabilitySummary14DGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fourteen-day generation forecast This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        public async System.Threading.Tasks.Task<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> GenerationAvailabilitySummary14DGetAsync(string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> localVarResponse = await GenerationAvailabilitySummary14DGetWithHttpInfoAsync(format, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fourteen-day generation forecast This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>>> GenerationAvailabilitySummary14DGetWithHttpInfoAsync(string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }

            localVarRequestOptions.Operation = "AvailabilityApi.GenerationAvailabilitySummary14DGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<InsightsApiModelsResponsesGenerationAggregatedForecast>>("/generation/availability/summary/14D", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GenerationAvailabilitySummary14DGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Three-year generation forecast This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        public List<InsightsApiModelsResponsesGenerationAggregatedForecast> GenerationAvailabilitySummary3YWGet(string? format = default(string?), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> localVarResponse = GenerationAvailabilitySummary3YWGetWithHttpInfo(format);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Three-year generation forecast This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        public Org.OpenAPITools.Client.ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> GenerationAvailabilitySummary3YWGetWithHttpInfo(string? format = default(string?), int operationIndex = 0)
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

            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }

            localVarRequestOptions.Operation = "AvailabilityApi.GenerationAvailabilitySummary3YWGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<InsightsApiModelsResponsesGenerationAggregatedForecast>>("/generation/availability/summary/3YW", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GenerationAvailabilitySummary3YWGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Three-year generation forecast This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;</returns>
        public async System.Threading.Tasks.Task<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> GenerationAvailabilitySummary3YWGetAsync(string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>> localVarResponse = await GenerationAvailabilitySummary3YWGetWithHttpInfoAsync(format, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Three-year generation forecast This endpoint provides a summary of generation forecast data aggregated by forecast date,  intended for visualisation purposes. Use datasets endpoints for full dataset access.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Response data format. Use json/xml to include metadata. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;InsightsApiModelsResponsesGenerationAggregatedForecast&gt;)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<List<InsightsApiModelsResponsesGenerationAggregatedForecast>>> GenerationAvailabilitySummary3YWGetWithHttpInfoAsync(string? format = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }

            localVarRequestOptions.Operation = "AvailabilityApi.GenerationAvailabilitySummary3YWGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<InsightsApiModelsResponsesGenerationAggregatedForecast>>("/generation/availability/summary/3YW", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GenerationAvailabilitySummary3YWGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}

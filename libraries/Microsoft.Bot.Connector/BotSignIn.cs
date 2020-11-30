﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Connector
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Bot.Schema;
    using Microsoft.Rest;
    using Newtonsoft.Json;

    /// <summary>
    /// BotSignIn operations.
    /// </summary>
    public partial class BotSignIn : IServiceOperations<OAuthClient>, IBotSignIn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotSignIn"/> class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null.
        /// </exception>
        public BotSignIn(OAuthClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException(nameof(client));
            }

            Client = client;
        }

        /// <summary>
        /// Gets a reference to the OAuthClient.
        /// </summary>
        public OAuthClient Client { get; private set; }

#pragma warning disable SA1625 // Element documentation should not be copied and pasted
        /// <param name='state'>State.</param>
        /// <param name='codeChallenge'>Code challenge.</param>
        /// <param name='emulatorUrl'>Emulator URL.</param>
        /// <param name='finalRedirect'>Final redirect.</param>
        /// <param name='customHeaders'>Headers that will be added to request.</param>
        /// <param name='cancellationToken'>The cancellation token.</param>
        /// <exception cref="HttpOperationException">Thrown when the operation returned an invalid status code.</exception>
        /// <exception cref="SerializationException">Thrown when unable to deserialize the response.</exception>
        /// <exception cref="ValidationException">Thrown when a required parameter is null.</exception>
        /// <exception cref="System.ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <return>A response object containing the response body and response headers.</return>
        public async Task<HttpOperationResponse<string>> GetSignInUrlWithHttpMessagesAsync(string state, string codeChallenge = default(string), string emulatorUrl = default(string), string finalRedirect = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
#pragma warning restore SA1625 // Element documentation should not be copied and pasted
        {
            if (state == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "state");
            }

            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("state", state);
                tracingParameters.Add("codeChallenge", codeChallenge);
                tracingParameters.Add("emulatorUrl", emulatorUrl);
                tracingParameters.Add("finalRedirect", finalRedirect);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetSignInUrl", tracingParameters);
            }

            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "api/botsignin/GetSignInUrl").ToString();
            List<string> _queryParameters = new List<string>();
            if (state != null)
            {
                _queryParameters.Add(string.Format("state={0}", System.Uri.EscapeDataString(state)));
            }

            if (codeChallenge != null)
            {
                _queryParameters.Add(string.Format("code_challenge={0}", System.Uri.EscapeDataString(codeChallenge)));
            }

            if (emulatorUrl != null)
            {
                _queryParameters.Add(string.Format("emulatorUrl={0}", System.Uri.EscapeDataString(emulatorUrl)));
            }

            if (finalRedirect != null)
            {
                _queryParameters.Add(string.Format("finalRedirect={0}", System.Uri.EscapeDataString(finalRedirect)));
            }

            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }

            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);

            // Set Headers
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }

                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;

            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }

            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }

            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }

            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null)
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else
                {
                    _responseContent = string.Empty;
                }

                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }

                _httpRequest.Dispose();

                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }

                throw ex;
            }

            // Create Result
            var _result = new HttpOperationResponse<string>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;

            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    // MANUAL SWAGGER UPDATE
                    _result.Body = _responseContent;
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }

                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }

            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }

            return _result;
        }
    }
}

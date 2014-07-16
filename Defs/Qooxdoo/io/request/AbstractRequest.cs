// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.io.request
{
    /// <summary>
	/// <para>AbstractRequest serves as a base class for <see cref="qx.io.request.Xhr"/>
	/// and <see cref="qx.io.request.Jsonp"/>. It contains methods to conveniently
	/// communicate with transports found in <see cref="qx.bom.request"/>.</para>
	/// <para>The general procedure to derive a new request is to choose a
	/// transport (override <see cref="#_createTransport"/>) and link
	/// the transport&#8217;s response (override <see cref="#_getParsedResponse"/>).
	/// The transport must implement <see cref="qx.bom.request.IRequest"/>.</para>
	/// <para>To adjust the behavior of <see cref="Send"/> override
	/// <see cref="#_getConfiguredUrl"/> and <see cref="#_getConfiguredRequestHeaders"/>.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.io.request.AbstractRequest", OmitOptionalParameters = true, Export = false)]
    public abstract partial class AbstractRequest : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fired when request is aborted.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnAbort;

		/// <summary>
		/// <para>Fired on change of the phase.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangePhase;

		/// <summary>
		/// <para>Fired on change of the parsed response.</para>
		/// <para>This event allows to use data binding with the
		/// parsed response as source.</para>
		/// <para>For example, to bind the response to the value of a label:</para>
		/// <code>
		/// // req is an instance of qx.io.request.*,
		/// // label an instance of qx.ui.basic.Label
		/// req.bind("response", label, "value");
		/// </code>
		/// <para>The response is parsed (and therefore changed) only
		/// after the request completes successfully. This means
		/// that when a new request is made the initial emtpy value
		/// is ignored, instead only the final value is bound.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeResponse;

		/// <summary>
		/// <para>Fired when request completes with error.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnError;

		/// <summary>
		/// <para>Fired on timeout, error or remote error.</para>
		/// <para>This event is fired for convenience. Usually, it is recommended
		/// to handle error related events in a more granular approach.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnFail;

		/// <summary>
		/// <para>Fired when request completes without error.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnLoad;

		/// <summary>
		/// <para>Fired when request completes with or without error.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnLoadEnd;

		/// <summary>
		/// <para>Fired on every change of the transport&#8217;s readyState.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnReadyStateChange;

		/// <summary>
		/// <para>Fired when request completes without error but erroneous HTTP status.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnStatusError;

		/// <summary>
		/// <para>Fired when request completes without error and transport&#8217;s status
		/// indicates success.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnSuccess;

		/// <summary>
		/// <para>Fired when request reaches timeout limit.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnTimeout;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Authentication delegate.</para>
		/// <para>The delegate must implement <see cref="qx.io.request.authentication.IAuthentication"/>.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "authentication", NativeField = true)]
		public qx.io.request.authentication.IAuthentication Authentication { get; set; }

		/// <summary>
		/// <para>Data to be send as part of the request.</para>
		/// <para>Supported types:</para>
		/// <list type="bullet">
		/// <item>String</item>
		/// <item>Map</item>
		/// <item>qooxdoo Object</item>
		/// </list>
		/// <para>For every supported type except strings, a URL encoded string
		/// with unsafe characters escaped is internally generated and sent
		/// as part of the request.</para>
		/// <para>Depending on the underlying transport and its configuration, the request
		/// data is transparently included as URL query parameters or embedded in the
		/// request body as form data.</para>
		/// <para>If a string is given the user must make sure it is properly formatted and
		/// escaped. See <see cref="qx.lang.Object.ToUriParameter"/>.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "requestData", NativeField = true)]
		public object RequestData { get; set; }

		/// <summary>
		/// <para>Timeout limit in milliseconds. Default (0) means no limit.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "timeout", NativeField = true)]
		public double Timeout { get; set; }

		/// <summary>
		/// <para>The URL of the resource to request.</para>
		/// <para>Note: Depending on the configuration of the request
		/// and/or the transport chosen, query params may be appended
		/// automatically.</para>
		/// </summary>
		[JsProperty(Name = "url", NativeField = true)]
		public string Url { get; set; }

		#endregion Properties

		#region Methods

		public AbstractRequest() { throw new NotImplementedException(); }

		/// <param name="url">The URL of the resource to request.</param>
		public AbstractRequest(string url) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Abort request.</para>
		/// </summary>
		[JsMethod(Name = "abort")]
		public void Abort() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get all response headers from response.</para>
		/// </summary>
		/// <returns>All response headers.</returns>
		[JsMethod(Name = "getAllResponseHeaders")]
		public string GetAllResponseHeaders() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property authentication.</para>
		/// </summary>
		[JsMethod(Name = "getAuthentication")]
		public qx.io.request.authentication.IAuthentication GetAuthentication() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get current phase.</para>
		/// <para>A more elaborate version of <see cref="GetReadyState"/>, this method indicates
		/// the current phase of the request. Maps to stateful (i.e. deterministic)
		/// events (success, abort, timeout, statusError) and intermediate
		/// readyStates (unsent, configured, loading, load).</para>
		/// <para>When the requests is successful, it progresses the states:</para>
		/// <para>&#8216;unsent&#8217;, &#8216;opened&#8217;, &#8216;sent&#8217;, &#8216;loading&#8217;, &#8216;load&#8217;, &#8216;success&#8217;</para>
		/// <para>In case of failure, the final state is one of:</para>
		/// <para>&#8216;abort&#8217;, &#8216;timeout&#8217;, &#8216;statusError&#8217;</para>
		/// <para>For each change of the phase, a <see cref="ChangePhase"/> data event is fired.</para>
		/// </summary>
		/// <returns>Current phase.</returns>
		[JsMethod(Name = "getPhase")]
		public string GetPhase() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get current ready state.</para>
		/// <para>States can be:
		/// UNSENT:           0,
		/// OPENED:           1,
		/// HEADERS_RECEIVED: 2,
		/// LOADING:          3,
		/// DONE:             4</para>
		/// </summary>
		/// <returns>Ready state.</returns>
		[JsMethod(Name = "getReadyState")]
		public double GetReadyState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property requestData.</para>
		/// </summary>
		[JsMethod(Name = "getRequestData")]
		public object GetRequestData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a request header.</para>
		/// </summary>
		/// <param name="key">Key of the header.</param>
		/// <returns>The value of the header.</returns>
		[JsMethod(Name = "getRequestHeader")]
		public string GetRequestHeader(string key) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get parsed response.</para>
		/// </summary>
		/// <returns>The parsed response of the request.</returns>
		[JsMethod(Name = "getResponse")]
		public string GetResponse() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the content type response header from response.</para>
		/// </summary>
		/// <returns>Content type response header.</returns>
		[JsMethod(Name = "getResponseContentType")]
		public string GetResponseContentType() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a single response header from response.</para>
		/// </summary>
		/// <param name="key">Key of the header to get the value from.</param>
		/// <returns>Response header.</returns>
		[JsMethod(Name = "getResponseHeader")]
		public string GetResponseHeader(string key) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get raw (unprocessed) response.</para>
		/// </summary>
		/// <returns>The raw response of the request.</returns>
		[JsMethod(Name = "getResponseText")]
		public string GetResponseText() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get status code.</para>
		/// </summary>
		/// <returns>The transport&#8217;s status code.</returns>
		[JsMethod(Name = "getStatus")]
		public double GetStatus() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get status text.</para>
		/// </summary>
		/// <returns>The transport&#8217;s status text.</returns>
		[JsMethod(Name = "getStatusText")]
		public string GetStatusText() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property timeout.</para>
		/// </summary>
		[JsMethod(Name = "getTimeout")]
		public double GetTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get low-level transport.</para>
		/// <para>Note: To be used with caution!</para>
		/// <para>This method can be used to query the transport directly,
		/// but should be used with caution. Especially, it
		/// is not advisable to call any destructive methods
		/// such as open or send.</para>
		/// </summary>
		/// <returns>An instance of a class found in qx.bom.request.*</returns>
		[JsMethod(Name = "getTransport")]
		public object GetTransport() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property url.</para>
		/// </summary>
		[JsMethod(Name = "getUrl")]
		public string GetUrl() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property authentication
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property authentication.</param>
		[JsMethod(Name = "initAuthentication")]
		public void InitAuthentication(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property requestData
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property requestData.</param>
		[JsMethod(Name = "initRequestData")]
		public void InitRequestData(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property timeout
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property timeout.</param>
		[JsMethod(Name = "initTimeout")]
		public void InitTimeout(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property url
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property url.</param>
		[JsMethod(Name = "initUrl")]
		public void InitUrl(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether request completed (is done).</para>
		/// </summary>
		[JsMethod(Name = "isDone")]
		public void IsDone() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove a request header.</para>
		/// <para>Note: Removing request headers has no effect after the request was send.</para>
		/// </summary>
		/// <param name="key">Key of the header.</param>
		[JsMethod(Name = "removeRequestHeader")]
		public void RemoveRequestHeader(string key) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property authentication.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAuthentication")]
		public void ResetAuthentication() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property requestData.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequestData")]
		public void ResetRequestData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property timeout.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTimeout")]
		public void ResetTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property url.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetUrl")]
		public void ResetUrl() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Send request.</para>
		/// </summary>
		[JsMethod(Name = "send")]
		public void Send() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property authentication.</para>
		/// </summary>
		/// <param name="value">New value for property authentication.</param>
		[JsMethod(Name = "setAuthentication")]
		public void SetAuthentication(qx.io.request.authentication.IAuthentication value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property requestData.</para>
		/// </summary>
		/// <param name="value">New value for property requestData.</param>
		[JsMethod(Name = "setRequestData")]
		public void SetRequestData(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set a request header.</para>
		/// <para>Note: Setting request headers has no effect after the request was send.</para>
		/// </summary>
		/// <param name="key">Key of the header.</param>
		/// <param name="value">Value of the header.</param>
		[JsMethod(Name = "setRequestHeader")]
		public void SetRequestHeader(string key, string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property timeout.</para>
		/// </summary>
		/// <param name="value">New value for property timeout.</param>
		[JsMethod(Name = "setTimeout")]
		public void SetTimeout(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property url.</para>
		/// </summary>
		/// <param name="value">New value for property url.</param>
		[JsMethod(Name = "setUrl")]
		public void SetUrl(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}
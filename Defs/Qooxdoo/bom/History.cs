// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>A helper for using the browser history in JavaScript Applications without
	/// reloading the main page.</para>
	/// <para>Adds entries to the browser history and fires a &#8220;request&#8221; event when one of
	/// the entries was requested by the user (e.g. by clicking on the back button).</para>
	/// <para>This class is an abstract template class. Concrete implementations have to
	/// provide implementations for the <see cref="#_readState"/> and <see cref="#_writeState"/>
	/// methods.</para>
	/// <para>Browser history support is currently available for Internet Explorer 6/7,
	/// Firefox, Opera 9 and WebKit. Safari 2 and older are not yet supported.</para>
	/// <para>This module is based on the ideas behind the YUI Browser History Manager
	/// by Julien Lecomte (Yahoo), which is described at
	/// http://yuiblog.com/blog/2007/02/21/browser-history-manager/. The Yahoo
	/// implementation can be found at http://developer.yahoo.com/yui/history.
	/// The original code is licensed under a BSD license
	/// (http://developer.yahoo.com/yui/license.txt).</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.History", OmitOptionalParameters = true, Export = false)]
    public abstract partial class History : qx.core.Object
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="State"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeState;

		/// <summary>
		/// Fired on change of the property <see cref="Title"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeTitle;

		/// <summary>
		/// <para>Fired when the user moved in the history. The data property of the event
		/// holds the state, which was passed to <see cref="AddToHistory"/>.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnRequest;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Property holding the current state of the history.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "state", NativeField = true)]
		public string State { get; set; }

		/// <summary>
		/// <para>Property holding the current title</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "title", NativeField = true)]
		public string Title { get; set; }

		#endregion Properties

		#region Methods

		public History() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the singleton instance of the history manager.</para>
		/// </summary>
		/// <returns></returns>
		[JsMethod(Name = "getInstance")]
		public static History GetInstance() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds an entry to the browser history.</para>
		/// </summary>
		/// <param name="state">a string representing the state of the application. This command will be delivered in the data property of the &#8220;request&#8221; event.</param>
		/// <param name="newTitle">the page title to set after the history entry is done. This title should represent the new state of the application.</param>
		[JsMethod(Name = "addToHistory")]
		public void AddToHistory(string state, string newTitle = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property state.</para>
		/// </summary>
		[JsMethod(Name = "getState")]
		public string GetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property title.</para>
		/// </summary>
		[JsMethod(Name = "getTitle")]
		public string GetTitle() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property state
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property state.</param>
		[JsMethod(Name = "initState")]
		public void InitState(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property title
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property title.</param>
		[JsMethod(Name = "initTitle")]
		public void InitTitle(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Navigates back in the browser history.
		/// Simulates a back button click.</para>
		/// </summary>
		[JsMethod(Name = "navigateBack")]
		public void NavigateBack() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Navigates forward in the browser history.
		/// Simulates a forward button click.</para>
		/// </summary>
		[JsMethod(Name = "navigateForward")]
		public void NavigateForward() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property state.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetState")]
		public void ResetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property title.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTitle")]
		public void ResetTitle() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property state.</para>
		/// </summary>
		/// <param name="value">New value for property state.</param>
		[JsMethod(Name = "setState")]
		public void SetState(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property title.</para>
		/// </summary>
		/// <param name="value">New value for property title.</param>
		[JsMethod(Name = "setTitle")]
		public void SetTitle(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}
// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.module
{
    /// <summary>
	/// <para>Module for querying information about the environment / runtime.
	/// It adds a static key env to qxWeb and offers the given methods.</para>
	/// <code>
	/// q.env.get("engine.name"); // return "webkit" e.g.
	/// </code>
	/// <para>The following values are predefined:</para>
	/// <list type="bullet">
	/// <item>browser.name : The name of the browser</item>
	/// <item>browser.version : The version of the browser</item>
	/// <item>browser.quirksmode  : true if the browser is in quirksmode</item>
	/// <item>browser.documentmode : The document mode of the browser</item>
	/// </list>
	/// <list type="bullet">
	/// <item>device.name : The name of the device e.g. iPad.</item>
	/// <item>device.type : Either desktop, tablet or mobile.</item>
	/// </list>
	/// <list type="bullet">
	/// <item>engine.name : The name of the browser engine</item>
	/// <item>engine.version : The version of the browser engine</item>
	/// </list>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.module.Environment", OmitOptionalParameters = true, Export = false)]
    public partial class Environment 
    {
		#region Methods

		public Environment() { throw new NotImplementedException(); }

		#endregion Methods
    }
}
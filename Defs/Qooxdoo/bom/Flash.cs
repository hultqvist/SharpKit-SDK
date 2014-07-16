// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Flash&#8482; embed via script</para>
	/// <para>Include:</para>
	/// <list type="bullet">
	/// <item>Simple movie embedding (returning a cross-browser working DOM node)</item>
	/// <item>Support for custom parameters and attributes</item>
	/// <item>Support for Flash&#8482; variables</item>
	/// </list>
	/// <para>Does not include the following features from SWFFix:</para>
	/// <list type="bullet">
	/// <item>Active content workarounds for already inserted movies (via markup)</item>
	/// <item>Express install support</item>
	/// <item>Transformation of standard conformance markup to cross browser support</item>
	/// <item>Support for alternative content (alt text)</item>
	/// </list>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Flash", OmitOptionalParameters = true, Export = false)]
    public partial class Flash 
    {
		#region Methods

		public Flash() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates an DOM element</para>
		/// <para>The dimension of the movie should define through CSS styles <see cref="qx.bom.element.Style"/></para>
		/// <para>It is possible to add these parameters as supported by Flash movies:
		/// http://kb.adobe.com/selfservice/viewContent.do?externalId=tn_12701</para>
		/// </summary>
		/// <param name="element">Parent DOM element node to add flash movie</param>
		/// <param name="attributes">attributes for the object tag like id or mayscript</param>
		/// <param name="variables">Flash variable data (these are available in the movie later)</param>
		/// <param name="paramsx">Flash parameter data (these are used to configure the movie itself)</param>
		/// <param name="win">Window to create the element for</param>
		/// <returns>The created Flash element</returns>
		[JsMethod(Name = "create")]
		public static qx.html.Element Create(qx.html.Element element, object attributes, object variables = null, object paramsx = null, Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Destroys the flash object from DOM, but not the parent DOM element.</para>
		/// <para>Note: Removing the flash object like this:</para>
		/// <code>
		/// var div = qx.dom.Element.create("div");
		/// document.body.appendChild(div);
		/// var flashObject = qx.bom.Flash.create(div, { movie : "Flash.swf", id : "id" });
		/// div.removeChild(div.firstChild);
		/// </code>
		/// <para>involve memory leaks in Internet Explorer.</para>
		/// </summary>
		/// <param name="element">Either the DOM element that contains the flash object or the flash object itself.</param>
		/// <param name="win">Window that the element, which is to be destroyed, belongs to.</param>
		[JsMethod(Name = "destroy")]
		public static void Destroy(qx.html.Element element, Window win) { throw new NotImplementedException(); }

		#endregion Methods
    }
}
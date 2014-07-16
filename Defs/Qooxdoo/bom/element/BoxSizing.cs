// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.element
{
    /// <summary>
	/// <para>Contains methods to control and query the element&#8217;s box-sizing property.</para>
	/// <para>Supported values:</para>
	/// <list type="bullet">
	/// <item>&#8220;content-box&#8221; = W3C model (dimensions are content specific)</item>
	/// <item>&#8220;border-box&#8221; = Microsoft model (dimensions are box specific incl. border and padding)</item>
	/// </list>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.element.BoxSizing", OmitOptionalParameters = true, Export = false)]
    public partial class BoxSizing 
    {
		#region Methods

		public BoxSizing() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Compiles the given box sizing into a CSS compatible string.</para>
		/// </summary>
		/// <param name="value">Valid CSS box-sizing value</param>
		/// <returns>CSS string</returns>
		[JsMethod(Name = "compile")]
		public static string Compile(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the box sizing for the given element.</para>
		/// </summary>
		/// <param name="element">The element to query</param>
		/// <returns>Box sizing value of the given element.</returns>
		[JsMethod(Name = "get")]
		public static string Get(qx.html.Element element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the local box sizing applied to the element</para>
		/// </summary>
		/// <param name="element">The element to modify</param>
		[JsMethod(Name = "reset")]
		public static void Reset(qx.html.Element element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Applies a new box sizing to the given element</para>
		/// </summary>
		/// <param name="element">The element to modify</param>
		/// <param name="value">New box sizing value to set</param>
		[JsMethod(Name = "set")]
		public static void Set(qx.html.Element element, string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}
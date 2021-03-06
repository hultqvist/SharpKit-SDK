// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.cell
{
    /// <summary>
	/// <para>Objects, which are used as delegates for <see cref="qx.ui.virtual.cell.WidgetCell"/> may
	/// implement any of the methods described in this interface. The delegate does
	/// not need implement all of the methods of this interface. If a method is not
	/// implemented the <see cref="qx.ui.virtual.cell.WidgetCell"/> provides a default implementation.</para>
	/// <para>Note: This interface is meant to document the delegate but should not be
	/// listed in the implement key of a class unless all methods are
	/// really implemented.</para>
	/// </summary>
	public interface IWidgetCellDelegate
    {
		#region Methods

		/// <summary>
		/// <para>Creates a Widget which will be used for rendering.</para>
		/// </summary>
		/// <returns>A new created Widget.</returns>
		qx.ui.core.LayoutItem CreateWidget();

		#endregion Methods
    }
}
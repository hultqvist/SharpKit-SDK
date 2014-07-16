// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.layout
{
    /// <summary>
	/// <para>The grid layout manager arranges the items in a two dimensional
	/// grid. Widgets can be placed into the grid&#8217;s cells and may span multiple rows
	/// and columns.</para>
	/// <para>Features</para>
	/// <list type="bullet">
	/// <item>Flex values for rows and columns</item>
	/// <item>Minimal and maximal column and row sizes</item>
	/// <item>Manually setting of column and row sizes</item>
	/// <item>Horizontal and vertical alignment</item>
	/// <item>Horizontal and vertical spacing</item>
	/// <item>Column and row spans</item>
	/// <item>Auto-sizing</item>
	/// </list>
	/// <para>Item Properties</para>
	/// <list type="bullet">
	/// <item>row (Integer): The row of the cell the
	/// widget should occupy. Each cell can only contain one widget. This layout
	/// property is mandatory.
	/// </item>
	/// <item>column (Integer): The column of the cell the
	/// widget should occupy. Each cell can only contain one widget. This layout
	/// property is mandatory.
	/// </item>
	/// <item>rowSpan (Integer): The number of rows, the
	/// widget should span, starting from the row specified in the row
	/// property. The cells in the spanned rows must be empty as well.
	/// </item>
	/// <item>colSpan (Integer): The number of columns, the
	/// widget should span, starting from the column specified in the column
	/// property. The cells in the spanned columns must be empty as well.
	/// </item>
	/// </list>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the grid layout.</para>
	/// <code>
	/// var layout = new qx.ui.layout.Grid();
	/// layout.setRowFlex(0, 1); // make row 0 flexible
	/// layout.setColumnWidth(1, 200); // set with of column 1 to 200 pixel
	/// var container = new qx.ui.container.Composite(layout);
	/// container.add(new qx.ui.core.Widget(), {row: 0, column: 0});
	/// container.add(new qx.ui.core.Widget(), {row: 0, column: 1});
	/// container.add(new qx.ui.core.Widget(), {row: 1, column: 0, rowSpan: 2});
	/// </code>
	/// <para>External Documentation</para>
	/// 
	/// Extended documentation and links to demos of this layout in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.layout.Grid", OmitOptionalParameters = true, Export = false)]
    public partial class Grid : qx.ui.layout.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>The horizontal spacing between grid cells.</para>
		/// </summary>
		[JsProperty(Name = "spacingX", NativeField = true)]
		public double SpacingX { get; set; }

		/// <summary>
		/// <para>The vertical spacing between grid cells.</para>
		/// </summary>
		[JsProperty(Name = "spacingY", NativeField = true)]
		public double SpacingY { get; set; }

		#endregion Properties

		#region Methods

		public Grid() { throw new NotImplementedException(); }

		/// <param name="spacingX">The horizontal spacing between grid cells. Sets #spacingX.</param>
		/// <param name="spacingY">The vertical spacing between grid cells. Sets #spacingY.</param>
		public Grid(double spacingX = 0, double spacingY = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a map of the cell&#8217;s alignment. For vertical alignment the row alignment
		/// takes precedence over the column alignment. For horizontal alignment it is
		/// the over way round. If an alignment is set on the cell widget using
		/// <see cref="qx.ui.core.LayoutItem.SetLayoutProperties"/>, this alignment takes
		/// always precedence over row or column alignment.</para>
		/// </summary>
		/// <param name="row">The cell&#8217;s row index</param>
		/// <param name="column">The cell&#8217;s column index</param>
		/// <returns>A map with the keys vAlign and hAlign containing the vertical and horizontal cell alignment.</returns>
		[JsMethod(Name = "getCellAlign")]
		public object GetCellAlign(double row, double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the widget located in the cell. If a the cell is empty or the widget
		/// has a <see cref="qx.ui.core.Widget.Visibility"/> value of exclude,
		/// null is returned.</para>
		/// </summary>
		/// <param name="row">The cell&#8217;s row index</param>
		/// <param name="column">The cell&#8217;s column index</param>
		/// <returns>The cell&#8217;s widget. The value may be null.</returns>
		[JsMethod(Name = "getCellWidget")]
		public qx.ui.core.Widget GetCellWidget(double row, double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a map of the column&#8217;s alignment.</para>
		/// </summary>
		/// <param name="column">The column index</param>
		/// <returns>A map with the keys vAlign and hAlign containing the vertical and horizontal column alignment.</returns>
		[JsMethod(Name = "getColumnAlign")]
		public object GetColumnAlign(double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the number of columns in the grid layout.</para>
		/// </summary>
		/// <returns>The number of columns in the layout</returns>
		[JsMethod(Name = "getColumnCount")]
		public double GetColumnCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the flex value of a grid column.</para>
		/// </summary>
		/// <param name="column">The column index</param>
		/// <returns>The column&#8217;s flex value</returns>
		[JsMethod(Name = "getColumnFlex")]
		public double GetColumnFlex(double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the maximum width of a grid column.</para>
		/// </summary>
		/// <param name="column">The column index</param>
		/// <returns>The column&#8217;s maximum width</returns>
		[JsMethod(Name = "getColumnMaxWidth")]
		public double GetColumnMaxWidth(double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the minimum width of a grid column.</para>
		/// </summary>
		/// <param name="column">The column index</param>
		/// <returns>The column&#8217;s minimum width</returns>
		[JsMethod(Name = "getColumnMinWidth")]
		public double GetColumnMinWidth(double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the preferred width of a grid column.</para>
		/// </summary>
		/// <param name="column">The column index</param>
		/// <returns>The column&#8217;s width</returns>
		[JsMethod(Name = "getColumnWidth")]
		public double GetColumnWidth(double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a map of the row&#8217;s alignment.</para>
		/// </summary>
		/// <param name="row">The Row index</param>
		/// <returns>A map with the keys vAlign and hAlign containing the vertical and horizontal row alignment.</returns>
		[JsMethod(Name = "getRowAlign")]
		public object GetRowAlign(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the number of rows in the grid layout.</para>
		/// </summary>
		/// <returns>The number of rows in the layout</returns>
		[JsMethod(Name = "getRowCount")]
		public double GetRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the flex value of a grid row.</para>
		/// </summary>
		/// <param name="row">The row index</param>
		/// <returns>The row&#8217;s flex value</returns>
		[JsMethod(Name = "getRowFlex")]
		public double GetRowFlex(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the preferred height of a grid row.</para>
		/// </summary>
		/// <param name="row">The row index</param>
		/// <returns>The row&#8217;s width</returns>
		[JsMethod(Name = "getRowHeight")]
		public double GetRowHeight(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the maximum height of a grid row.</para>
		/// </summary>
		/// <param name="row">The row index</param>
		/// <returns>The row&#8217;s maximum width</returns>
		[JsMethod(Name = "getRowMaxHeight")]
		public double GetRowMaxHeight(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the minimum height of a grid row.</para>
		/// </summary>
		/// <param name="row">The row index</param>
		/// <returns>The row&#8217;s minimum width</returns>
		[JsMethod(Name = "getRowMinHeight")]
		public double GetRowMinHeight(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property spacingX.</para>
		/// </summary>
		[JsMethod(Name = "getSpacingX")]
		public double GetSpacingX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property spacingY.</para>
		/// </summary>
		[JsMethod(Name = "getSpacingY")]
		public double GetSpacingY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property spacingX
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property spacingX.</param>
		[JsMethod(Name = "initSpacingX")]
		public void InitSpacingX(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property spacingY
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property spacingY.</param>
		[JsMethod(Name = "initSpacingY")]
		public void InitSpacingY(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Invalidate all layout relevant caches. Automatically deletes the size hint.</para>
		/// </summary>
		[JsMethod(Name = "invalidateLayoutCache")]
		public void InvalidateLayoutCache() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Applies the children layout.</para>
		/// </summary>
		/// <param name="availWidth">Final width available for the content (in pixel)</param>
		/// <param name="availHeight">Final height available for the content (in pixel)</param>
		[JsMethod(Name = "renderLayout")]
		public void RenderLayout(double availWidth, double availHeight) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property spacingX.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSpacingX")]
		public void ResetSpacingX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property spacingY.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSpacingY")]
		public void ResetSpacingY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the default cell alignment for a column. This alignment can be
		/// overridden on a per cell basis by setting the cell&#8217;s content widget&#8217;s
		/// alignX and alignY properties.</para>
		/// <para>If on a grid cell both row and a column alignment is set, the horizontal
		/// alignment is taken from the column and the vertical alignment is taken
		/// from the row.</para>
		/// </summary>
		/// <param name="column">Column index</param>
		/// <param name="hAlign">The horizontal alignment. Valid values are &#8220;left&#8221;, &#8220;center&#8221; and &#8220;right&#8221;.</param>
		/// <param name="vAlign">The vertical alignment. Valid values are &#8220;top&#8221;, &#8220;middle&#8221;, &#8220;bottom&#8221;</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setColumnAlign")]
		public qx.ui.layout.Grid SetColumnAlign(double column, string hAlign, string vAlign) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the flex value for a grid column.
		/// By default the column flex value is 0.</para>
		/// </summary>
		/// <param name="column">The column index</param>
		/// <param name="flex">The column&#8217;s flex value</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setColumnFlex")]
		public qx.ui.layout.Grid SetColumnFlex(double column, double flex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the maximum width of a grid column.
		/// The default value is Infinity.</para>
		/// </summary>
		/// <param name="column">The column index</param>
		/// <param name="maxWidth">The column&#8217;s maximum width</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setColumnMaxWidth")]
		public qx.ui.layout.Grid SetColumnMaxWidth(double column, double maxWidth) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the minimum width of a grid column.
		/// The default value is 0.</para>
		/// </summary>
		/// <param name="column">The column index</param>
		/// <param name="minWidth">The column&#8217;s minimum width</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setColumnMinWidth")]
		public qx.ui.layout.Grid SetColumnMinWidth(double column, double minWidth) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the preferred width of a grid column.
		/// The default value is Infinity.</para>
		/// </summary>
		/// <param name="column">The column index</param>
		/// <param name="width">The column&#8217;s width</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setColumnWidth")]
		public qx.ui.layout.Grid SetColumnWidth(double column, double width) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the default cell alignment for a row. This alignment can be
		/// overridden on a per cell basis by setting the cell&#8217;s content widget&#8217;s
		/// alignX and alignY properties.</para>
		/// <para>If on a grid cell both row and a column alignment is set, the horizontal
		/// alignment is taken from the column and the vertical alignment is taken
		/// from the row.</para>
		/// </summary>
		/// <param name="row">Row index</param>
		/// <param name="hAlign">The horizontal alignment. Valid values are &#8220;left&#8221;, &#8220;center&#8221; and &#8220;right&#8221;.</param>
		/// <param name="vAlign">The vertical alignment. Valid values are &#8220;top&#8221;, &#8220;middle&#8221;, &#8220;bottom&#8221;</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setRowAlign")]
		public qx.ui.layout.Grid SetRowAlign(double row, string hAlign, string vAlign) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the flex value for a grid row.
		/// By default the row flex value is 0.</para>
		/// </summary>
		/// <param name="row">The row index</param>
		/// <param name="flex">The row&#8217;s flex value</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setRowFlex")]
		public qx.ui.layout.Grid SetRowFlex(double row, double flex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the preferred height of a grid row.
		/// The default value is Infinity.</para>
		/// </summary>
		/// <param name="row">The row index</param>
		/// <param name="height">The row&#8217;s width</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setRowHeight")]
		public qx.ui.layout.Grid SetRowHeight(double row, double height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the maximum height of a grid row.
		/// The default value is Infinity.</para>
		/// </summary>
		/// <param name="row">The row index</param>
		/// <param name="maxHeight">The row&#8217;s maximum width</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setRowMaxHeight")]
		public qx.ui.layout.Grid SetRowMaxHeight(double row, double maxHeight) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the minimum height of a grid row.
		/// The default value is 0.</para>
		/// </summary>
		/// <param name="row">The row index</param>
		/// <param name="minHeight">The row&#8217;s minimum width</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "setRowMinHeight")]
		public qx.ui.layout.Grid SetRowMinHeight(double row, double minHeight) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Shortcut to set both horizontal and vertical spacing between grid cells
		/// to the same value.</para>
		/// </summary>
		/// <param name="spacing">new horizontal and vertical spacing</param>
		/// <returns>This object (for chaining support).</returns>
		[JsMethod(Name = "setSpacing")]
		public qx.ui.layout.Grid SetSpacing(double spacing) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property spacingX.</para>
		/// </summary>
		/// <param name="value">New value for property spacingX.</param>
		[JsMethod(Name = "setSpacingX")]
		public void SetSpacingX(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property spacingY.</para>
		/// </summary>
		/// <param name="value">New value for property spacingY.</param>
		[JsMethod(Name = "setSpacingY")]
		public void SetSpacingY(double value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}
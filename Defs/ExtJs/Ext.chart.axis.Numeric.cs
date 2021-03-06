//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.chart.axis
{
    #region Numeric
    /// <inheritdocs />
    /// <summary>
    /// <p>An axis to handle numeric values. This axis is used for quantitative data as
    /// opposed to the category axis. You can set mininum and maximum values to the
    /// axis so that the values are bound to that. If no values are set, then the
    /// scale will auto-adjust to the values.</p>
    /// <pre><code>var store = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.JsonStore">Ext.data.JsonStore</see>', {
    /// fields: ['name', 'data1', 'data2', 'data3', 'data4', 'data5'],
    /// data: [
    /// {'name':'metric one', 'data1':10, 'data2':12, 'data3':14, 'data4':8, 'data5':13},
    /// {'name':'metric two', 'data1':7, 'data2':8, 'data3':16, 'data4':10, 'data5':3},
    /// {'name':'metric three', 'data1':5, 'data2':2, 'data3':14, 'data4':12, 'data5':7},
    /// {'name':'metric four', 'data1':2, 'data2':14, 'data3':6, 'data4':1, 'data5':23},
    /// {'name':'metric five', 'data1':27, 'data2':38, 'data3':36, 'data4':13, 'data5':33}
    /// ]
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.chart.Chart">Ext.chart.Chart</see>', {
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// width: 500,
    /// height: 300,
    /// store: store,
    /// axes: [{
    /// type: 'Numeric',
    /// grid: true,
    /// position: 'left',
    /// fields: ['data1', 'data2', 'data3', 'data4', 'data5'],
    /// title: 'Sample Values',
    /// grid: {
    /// odd: {
    /// opacity: 1,
    /// fill: '#ddd',
    /// stroke: '#bbb',
    /// 'stroke-width': 1
    /// }
    /// },
    /// minimum: 0,
    /// adjustMinimumByMajorUnit: 0
    /// }, {
    /// type: 'Category',
    /// position: 'bottom',
    /// fields: ['name'],
    /// title: 'Sample Metrics',
    /// grid: true,
    /// label: {
    /// rotate: {
    /// degrees: 315
    /// }
    /// }
    /// }],
    /// series: [{
    /// type: 'area',
    /// highlight: false,
    /// axis: 'left',
    /// xField: 'name',
    /// yField: ['data1', 'data2', 'data3', 'data4', 'data5'],
    /// style: {
    /// opacity: 0.93
    /// }
    /// }]
    /// });
    /// </code></pre>
    /// <p>In this example we create an axis of Numeric type. We set a minimum value so that
    /// even if all series have values greater than zero, the grid starts at zero. We bind
    /// the axis onto the left part of the surface by setting <c>position</c> to <c>left</c>.
    /// We bind three different store fields to this axis by setting <c>fields</c> to an array.
    /// We set the title of the axis to <em>Number of Hits</em> by using the <c>title</c> property.
    /// We use a <c>grid</c> configuration to set odd background rows to a certain style and even rows
    /// to be transparent/ignored.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Numeric : Axis
    {
        /// <summary>
        /// If true, the values of the chart will be rendered only if they belong between minimum and maximum
        /// If false, all values of the chart will be rendered, regardless of whether they belong between minimum and maximum or not
        /// Default's true if maximum and minimum is specified.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool constrain;
        /// <summary>
        /// Indicates whether to extend maximum beyond data's maximum to the nearest
        /// majorUnit.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool adjustMaximumByMajorUnit{get;set;}
        /// <summary>
        /// Indicates whether to extend the minimum beyond data's minimum to the
        /// nearest majorUnit.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool adjustMinimumByMajorUnit{get;set;}
        /// <summary>
        /// The number of decimals to round the value to.
        /// Defaults to: <c>2</c>
        /// </summary>
        public JsNumber decimals{get;set;}
        /// <summary>
        /// The maximum value drawn by the axis. If not set explicitly, the axis
        /// maximum will be calculated automatically.
        /// </summary>
        public JsNumber maximum{get;set;}
        /// <summary>
        /// The minimum value drawn by the axis. If not set explicitly, the axis
        /// minimum will be calculated automatically.
        /// </summary>
        public JsNumber minimum{get;set;}
        /// <summary>
        /// The scaling algorithm to use on this axis. May be "linear" or
        /// "logarithmic".  Currently only linear scale is implemented.
        /// Defaults to: <c>&quot;linear&quot;</c>
        /// </summary>
        private JsString scale{get;set;}
        public Numeric(NumericConfig config){}
        public Numeric(){}
        public Numeric(params object[] args){}
    }
    #endregion
    #region NumericConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NumericConfig : AxisConfig
    {
        /// <summary>
        /// If true, the values of the chart will be rendered only if they belong between minimum and maximum
        /// If false, all values of the chart will be rendered, regardless of whether they belong between minimum and maximum or not
        /// Default's true if maximum and minimum is specified.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool constrain;
        public NumericConfig(params object[] args){}
    }
    #endregion
    #region NumericEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NumericEvents : AxisEvents
    {
        public NumericEvents(params object[] args){}
    }
    #endregion
}

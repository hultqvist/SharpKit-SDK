// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.form;

namespace qx.ui.mobile.form
{
    /// <summary>
	/// <para>The Slider widget provides horizontal slider.</para>
	/// <para>The Slider is the classic widget for controlling a bounded value.
	/// It lets the user move a slider handle along a horizontal
	/// groove and translates the handle&#8217;s position into an integer value
	/// within the defined range.
	/// Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var slider= new qx.ui.mobile.form.Slider().set({
	/// minimum : 0,
	/// maximum : 10,
	/// step : 2
	/// });
	/// slider.addListener("changeValue", handler, this);
	/// this.getRoot.add(slider);
	/// </code>
	/// <para>This example creates a slider and attaches an
	/// event listener to the <see cref="ChangeValue"/> event.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.form.Slider", OmitOptionalParameters = true, Export = false)]
    public partial class Slider : qx.ui.mobile.core.Widget, qx.ui.form.IForm, qx.ui.form.IModel, qx.ui.form.INumberForm
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Maximum"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeMaximum;

		/// <summary>
		/// Fired on change of the property <see cref="Minimum"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeMinimum;

		/// <summary>
		/// Fired on change of the property <see cref="Step"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeStep;

		/// <summary>
		/// <para>Fired when the value was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValue;

		/// <summary>
		/// <para>The event is fired on every keystroke modifying the value of the field.</para>
		/// <para>The method <see cref="qx.event.type.Data.GetData"/> returns the
		/// current value of the text field.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnInput;

		/// <summary>
		/// <para>Fired when the invalidMessage was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeInvalidMessage;

		/// <summary>
		/// <para>Fired when the required was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeRequired;

		/// <summary>
		/// <para>Fired when the valid state was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValid;

		/// <summary>
		/// <para>Fired when the model data changes</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The default CSS class used for this widget. The default CSS class
		/// should contain the common appearance of the widget.
		/// It is set to the container element of the widget. Use <see cref="AddCssClass"/>
		/// to enhance the default appearance of the widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public string DefaultCssClass { get; set; }

		/// <summary>
		/// <para>The maximum slider value (may be negative). This value must be larger
		/// than <see cref="Minimum"/>.</para>
		/// </summary>
		[JsProperty(Name = "maximum", NativeField = true)]
		public double Maximum { get; set; }

		/// <summary>
		/// <para>The minimum slider value (may be negative). This value must be smaller
		/// than <see cref="Maximum"/>.</para>
		/// </summary>
		[JsProperty(Name = "minimum", NativeField = true)]
		public double Minimum { get; set; }

		/// <summary>
		/// <para>Reverses the display direction of the slider knob. If true, the maxium of
		/// the slider is on the left side and minimum on the right side.</para>
		/// </summary>
		[JsProperty(Name = "reverseDirection", NativeField = true)]
		public bool ReverseDirection { get; set; }

		/// <summary>
		/// <para>The amount to increment on each event. Typically corresponds
		/// to the user moving the knob.</para>
		/// </summary>
		[JsProperty(Name = "step", NativeField = true)]
		public double Step { get; set; }

		/// <summary>
		/// <para>Whether the <see cref="ChangeValue"/> event should be fired on every key
		/// input. If set to true, the changeValue event is equal to the
		/// <see cref="Input"/> event.</para>
		/// </summary>
		[JsProperty(Name = "liveUpdate", NativeField = true)]
		public bool LiveUpdate { get; set; }

		/// <summary>
		/// <para>Message which is shown in an invalid tooltip.</para>
		/// </summary>
		[JsProperty(Name = "invalidMessage", NativeField = true)]
		public string InvalidMessage { get; set; }

		/// <summary>
		/// <para>Flag signaling if a widget is required.</para>
		/// </summary>
		[JsProperty(Name = "required", NativeField = true)]
		public bool Required { get; set; }

		/// <summary>
		/// <para>Message which is shown in an invalid tooltip if the <see cref="Required"/> is
		/// set to true.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "requiredInvalidMessage", NativeField = true)]
		public string RequiredInvalidMessage { get; set; }

		/// <summary>
		/// <para>Flag signaling if a widget is valid. If a widget is invalid, an invalid
		/// state will be set.</para>
		/// </summary>
		[JsProperty(Name = "valid", NativeField = true)]
		public bool Valid { get; set; }

		/// <summary>
		/// <para>Model property for storing additional information for the including
		/// object. It can act as value property on form items for example.</para>
		/// <para>Be careful using that property as this is used for the
		/// <see cref="qx.ui.form.MModelSelection"/> it has some restrictions:</para>
		/// <list type="bullet">
		/// <item>Don&#8217;t use equal models in one widget using the
		/// <see cref="qx.ui.form.MModelSelection"/>.</item>
		/// </list>
		/// <list type="bullet">
		/// <item>Avoid setting only some model properties if the widgets are added to
		/// a <see cref="qx.ui.form.MModelSelection"/> widge.</item>
		/// </list>
		/// <para>Both restrictions result of the fact, that the set models are deputies
		/// for their widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public object Model { get; set; }

		#endregion Properties

		#region Methods

		public Slider() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property maximum.</para>
		/// </summary>
		[JsMethod(Name = "getMaximum")]
		public double GetMaximum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property minimum.</para>
		/// </summary>
		[JsMethod(Name = "getMinimum")]
		public double GetMinimum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property reverseDirection.</para>
		/// </summary>
		[JsMethod(Name = "getReverseDirection")]
		public bool GetReverseDirection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property step.</para>
		/// </summary>
		[JsMethod(Name = "getStep")]
		public double GetStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maximum
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maximum.</param>
		[JsMethod(Name = "initMaximum")]
		public void InitMaximum(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property minimum
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property minimum.</param>
		[JsMethod(Name = "initMinimum")]
		public void InitMinimum(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property reverseDirection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property reverseDirection.</param>
		[JsMethod(Name = "initReverseDirection")]
		public void InitReverseDirection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property step
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property step.</param>
		[JsMethod(Name = "initStep")]
		public void InitStep(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property reverseDirection equals true.</para>
		/// </summary>
		[JsMethod(Name = "isReverseDirection")]
		public void IsReverseDirection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Increments the current value.</para>
		/// </summary>
		[JsMethod(Name = "nextValue")]
		public void NextValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Decrements the current value.</para>
		/// </summary>
		[JsMethod(Name = "previousValue")]
		public void PreviousValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maximum.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaximum")]
		public void ResetMaximum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property minimum.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMinimum")]
		public void ResetMinimum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property reverseDirection.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetReverseDirection")]
		public void ResetReverseDirection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property step.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetStep")]
		public void ResetStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property maximum.</para>
		/// </summary>
		/// <param name="value">New value for property maximum.</param>
		[JsMethod(Name = "setMaximum")]
		public void SetMaximum(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property minimum.</para>
		/// </summary>
		/// <param name="value">New value for property minimum.</param>
		[JsMethod(Name = "setMinimum")]
		public void SetMinimum(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property reverseDirection.</para>
		/// </summary>
		/// <param name="value">New value for property reverseDirection.</param>
		[JsMethod(Name = "setReverseDirection")]
		public void SetReverseDirection(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property step.</para>
		/// </summary>
		/// <param name="value">New value for property step.</param>
		[JsMethod(Name = "setStep")]
		public void SetStep(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property reverseDirection.</para>
		/// </summary>
		[JsMethod(Name = "toggleReverseDirection")]
		public void ToggleReverseDirection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property liveUpdate.</para>
		/// </summary>
		[JsMethod(Name = "getLiveUpdate")]
		public bool GetLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The element&#8217;s user set value.</para>
		/// </summary>
		/// <returns>The value.</returns>
		[JsMethod(Name = "getValue")]
		public double GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property liveUpdate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property liveUpdate.</param>
		[JsMethod(Name = "initLiveUpdate")]
		public void InitLiveUpdate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property liveUpdate equals true.</para>
		/// </summary>
		[JsMethod(Name = "isLiveUpdate")]
		public void IsLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property liveUpdate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLiveUpdate")]
		public void ResetLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property liveUpdate.</para>
		/// </summary>
		/// <param name="value">New value for property liveUpdate.</param>
		[JsMethod(Name = "setLiveUpdate")]
		public void SetLiveUpdate(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the element&#8217;s value.</para>
		/// </summary>
		/// <param name="value">The new value of the element.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property liveUpdate.</para>
		/// </summary>
		[JsMethod(Name = "toggleLiveUpdate")]
		public void ToggleLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the invalid message of the widget.</para>
		/// </summary>
		/// <returns>The current set message.</returns>
		[JsMethod(Name = "getInvalidMessage")]
		public string GetInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current required state of the widget.</para>
		/// </summary>
		/// <returns>True, if the widget is required.</returns>
		[JsMethod(Name = "getRequired")]
		public bool GetRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the invalid message if required of the widget.</para>
		/// </summary>
		/// <returns>The current set message.</returns>
		[JsMethod(Name = "getRequiredInvalidMessage")]
		public string GetRequiredInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the valid state of the widget.</para>
		/// </summary>
		/// <returns>If the state of the widget is valid.</returns>
		[JsMethod(Name = "getValid")]
		public bool GetValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property invalidMessage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property invalidMessage.</param>
		[JsMethod(Name = "initInvalidMessage")]
		public void InitInvalidMessage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property required
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property required.</param>
		[JsMethod(Name = "initRequired")]
		public void InitRequired(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property requiredInvalidMessage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property requiredInvalidMessage.</param>
		[JsMethod(Name = "initRequiredInvalidMessage")]
		public void InitRequiredInvalidMessage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property valid
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property valid.</param>
		[JsMethod(Name = "initValid")]
		public void InitValid(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property required equals true.</para>
		/// </summary>
		[JsMethod(Name = "isRequired")]
		public void IsRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property valid equals true.</para>
		/// </summary>
		[JsMethod(Name = "isValid")]
		public void IsValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property invalidMessage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInvalidMessage")]
		public void ResetInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property required.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequired")]
		public void ResetRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property requiredInvalidMessage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequiredInvalidMessage")]
		public void ResetRequiredInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property valid.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetValid")]
		public void ResetValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the invalid message of the widget.</para>
		/// </summary>
		/// <param name="message">The invalid message.</param>
		[JsMethod(Name = "setInvalidMessage")]
		public void SetInvalidMessage(string message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the required state of a widget.</para>
		/// </summary>
		/// <param name="required">A flag signaling if the widget is required.</param>
		[JsMethod(Name = "setRequired")]
		public void SetRequired(bool required) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the invalid message if required of the widget.</para>
		/// </summary>
		/// <param name="message">The invalid message.</param>
		[JsMethod(Name = "setRequiredInvalidMessage")]
		public void SetRequiredInvalidMessage(string message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the valid state of the widget.</para>
		/// </summary>
		/// <param name="valid">The valid state of the widget.</param>
		[JsMethod(Name = "setValid")]
		public void SetValid(bool valid) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property required.</para>
		/// </summary>
		[JsMethod(Name = "toggleRequired")]
		public void ToggleRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property valid.</para>
		/// </summary>
		[JsMethod(Name = "toggleValid")]
		public void ToggleValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the representative data for the item</para>
		/// </summary>
		/// <returns>The data.</returns>
		[JsMethod(Name = "getModel")]
		public object GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the representative data to null.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the representative data for the item.</para>
		/// </summary>
		/// <param name="value">The data.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a state to the element</para>
		/// </summary>
		/// <param name="state">the state to be added</param>
		[JsMethod(Name = "addState")]
		public void AddState(string state) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checkes whether the element has the state passed as argument</para>
		/// </summary>
		/// <param name="state">the state to be checked</param>
		/// <returns>true if the element has the state, false if it doesn&#8217;t.</returns>
		[JsMethod(Name = "hasState")]
		public bool HasState(string state) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes a state from the element</para>
		/// </summary>
		/// <param name="state">the state to be removed</param>
		[JsMethod(Name = "removeState")]
		public void RemoveState(string state) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Replaces a state of the element with a new state.
		/// If the element doesn&#8217;t have the state to be removed, then th new state will
		/// just be added.</para>
		/// </summary>
		/// <param name="oldState">the state to be replaced</param>
		/// <param name="newState">the state to get injected in the oldState&#8217;s place</param>
		[JsMethod(Name = "replaceState")]
		public void ReplaceState(string oldState, string newState) { throw new NotImplementedException(); }

		#endregion Methods
    }
}
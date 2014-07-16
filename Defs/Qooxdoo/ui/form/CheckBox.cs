// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form
{
    /// <summary>
	/// <para>A check box widget with an optional label.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.CheckBox", OmitOptionalParameters = true, Export = false)]
    public partial class CheckBox : qx.ui.form.ToggleButton, qx.ui.form.IForm, qx.ui.form.IModel
    {
		#region Events

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
		/// <para>Whether the item can grow horizontally.</para>
		/// </summary>
		[JsProperty(Name = "allowGrowX", NativeField = true)]
		public bool AllowGrowX { get; set; }

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

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

		public CheckBox() { throw new NotImplementedException(); }

		/// <param name="label">An optional label for the check box.</param>
		public CheckBox(string label = null) { throw new NotImplementedException(); }

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

		#endregion Methods
    }
}
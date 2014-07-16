// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.type
{
    /// <summary>
	/// <para>This class is the common superclass for most array classes in
	/// qooxdoo. It supports all of the shiny 1.6 JavaScript array features
	/// like forEach and map.</para>
	/// <para>This class may be instantiated instead of the native Array if
	/// one wants to work with a feature-unified Array instead of the native
	/// one. This class uses native features whereever possible but fills
	/// all missing implementations with custom ones.</para>
	/// <para>Through the ability to extend from this class one could add even
	/// more utility features on top of it.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.type.BaseArray", OmitOptionalParameters = true, Export = false)]
    public partial class BaseArray : JsArray
    {
		#region Methods

		public BaseArray() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a new Array with the given length or the listed elements.</para>
		/// <code>
		/// var arr1 = new qx.type.BaseArray(arrayLength);
		/// var arr2 = new qx.type.BaseArray(item0, item1, ..., itemN);
		/// </code>
		/// <list type="bullet">
		/// <item>arrayLength: The initial length of the array. You can access
		/// this value using the length property. If the value specified is not a
		/// number, an array of length 1 is created, with the first element having
		/// the specified value. The maximum length allowed for an
		/// array is 2^32-1, i.e. 4,294,967,295.</item>
		/// <item>itemN:  A value for the element in that position in the
		/// array. When this form is used, the array is initialized with the specified
		/// values as its elements, and the array&#8217;s length property is set to the
		/// number of arguments.</item>
		/// </list>
		/// </summary>
		/// <param name="length_or_items">The initial length of the array OR an argument list of values.</param>
		public BaseArray(object length_or_items = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a new array comprised of this array joined with other array(s) and/or value(s).</para>
		/// <para>This method does not modify the array and returns a modified copy of the original.</para>
		/// </summary>
		/// <param name="varargs">Arrays and/or values to concatenate to the resulting array.</param>
		/// <returns>New array built of the given arrays or values.</returns>
		[JsMethod(Name = "concat")]
		public qx.type.BaseArray Concat(object varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Tests whether all elements in the array pass the test implemented by the provided function.</para>
		/// every executes the provided callback function once for each element
		/// present in the array until it finds one where callback returns a false value. If
		/// such an element is found, the every method immediately returns false.
		/// Otherwise, if callback returned a true value for all elements, every
		/// will return true.  callback is invoked only for indexes of the array
		/// which have assigned values; it is not invoked for indexes which have been deleted or which have
		/// never been assigned values.
		/// callback is invoked with three arguments: the value of the element, the index of
		/// the element, and the Array object being traversed.
		/// <para>If a obj parameter is provided to every, it will be used as
		/// the this for each invocation of the callback. If it is not provided,
		/// or is null, the global object associated with callback is used instead.</para>
		/// every does not mutate the array on which it is called. The range of elements processed
		/// by every is set before the first invocation of callback. Elements which
		/// are appended to the array after the call to every begins will not be visited by
		/// callback.  If existing elements of the array are changed, their value as passed
		/// to callback will be the value at the time every visits them; elements
		/// that are deleted are not visited.
		/// </summary>
		/// <param name="callback">Function to test for each element.</param>
		/// <param name="obj">Object to use as this when executing callback.</param>
		/// <returns>Whether all elements passed the test</returns>
		[JsMethod(Name = "every")]
		public bool Every(Action<object> callback, object obj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a new array with all elements that pass the test implemented by the provided
		/// function.</para>
		/// filter calls a provided callback function once for each
		/// element in an array, and constructs a new array of all the values for which
		/// callback returns a true value.  callback is invoked only
		/// for indexes of the array which have assigned values; it is not invoked for indexes
		/// which have been deleted or which have never been assigned values.  Array elements which
		/// do not pass the callback test are simply skipped, and are not included
		/// in the new array.
		/// callback is invoked with three arguments: the value of the element, the
		/// index of the element, and the Array object being traversed.
		/// <para>If a obj parameter is provided to filter, it will
		/// be used as the this for each invocation of the callback.
		/// If it is not provided, or is null, the global object associated with
		/// callback is used instead.</para>
		/// filter does not mutate the array on which it is called. The range of
		/// elements processed by filter is set before the first invocation of
		/// callback. Elements which are appended to the array after the call to
		/// filter begins will not be visited by callback. If existing
		/// elements of the array are changed, or deleted, their value as passed to callback
		/// will be the value at the time filter visits them; elements that are deleted
		/// are not visited.
		/// </summary>
		/// <param name="callback">Function to test each element of the array.</param>
		/// <param name="obj">Object to use as this when executing callback.</param>
		/// <returns>The newly created array with all matching elements</returns>
		[JsMethod(Name = "filter")]
		public BaseArray Filter(Action<object> callback, object obj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Executes a provided function once per array element.</para>
		/// forEach executes the provided function (callback) once for each
		/// element present in the array.  callback is invoked only for indexes of the array
		/// which have assigned values; it is not invoked for indexes which have been deleted or which
		/// have never been assigned values.
		/// callback is invoked with three arguments: the value of the element, the index
		/// of the element, and the Array object being traversed.
		/// <para>If a obj parameter is provided to forEach, it will be used
		/// as the this for each invocation of the callback.  If it is not
		/// provided, or is null, the global object associated with callback
		/// is used instead.</para>
		/// forEach does not mutate the array on which it is called.
		/// <para>The range of elements processed by forEach is set before the first invocation of
		/// callback.  Elements which are appended to the array after the call to
		/// forEach begins will not be visited by callback. If existing elements
		/// of the array are changed, or deleted, their value as passed to callback will be
		/// the value at the time forEach visits them; elements that are deleted are not visited.</para>
		/// </summary>
		/// <param name="callback">Function to execute for each element.</param>
		/// <param name="obj">Object to use as this when executing callback.</param>
		[JsMethod(Name = "forEach")]
		public void ForEach(Action<object> callback, object obj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the first (least) index of an element within the array equal to the specified value, or -1 if none is found.</para>
		/// </summary>
		/// <param name="searchElement">Element to locate in the array.</param>
		/// <param name="fromIndex">The index at which to begin the search. Defaults to 0, i.e. the whole array will be searched. If the index is greater than or equal to the length of the array, -1 is returned, i.e. the array will not be searched. If negative, it is taken as the offset from the end of the array. Note that even when the index is negative, the array is still searched from front to back. If the calculated index is less than 0, the whole array will be searched.</param>
		/// <returns>The index of the given element</returns>
		[JsMethod(Name = "indexOf")]
		public double IndexOf(object searchElement, double fromIndex = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Joins all elements of an array into a string.</para>
		/// </summary>
		/// <param name="separator">Specifies a string to separate each element of the array. The separator is converted to a string if necessary. If omitted, the array elements are separated with a comma.</param>
		/// <returns>The stringified values of all elements divided by the given separator.</returns>
		[JsMethod(Name = "join")]
		public string Join(string separator) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the last (greatest) index of an element within the array equal to the specified value, or -1 if none is found.</para>
		/// </summary>
		/// <param name="searchElement">Element to locate in the array.</param>
		/// <param name="fromIndex">The index at which to start searching backwards. Defaults to the array&#8217;s length, i.e. the whole array will be searched. If the index is greater than or equal to the length of the array, the whole array will be searched. If negative, it is taken as the offset from the end of the array. Note that even when the index is negative, the array is still searched from back to front. If the calculated index is less than 0, -1 is returned, i.e. the array will not be searched.</param>
		/// <returns>The index of the given element</returns>
		[JsMethod(Name = "lastIndexOf")]
		public double LastIndexOf(object searchElement, double? fromIndex = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a new array with the results of calling a provided function on every element in this array.</para>
		/// map calls a provided callback function once for each element in an array,
		/// in order, and constructs a new array from the results.  callback is invoked only for
		/// indexes of the array which have assigned values; it is not invoked for indexes which have been
		/// deleted or which have never been assigned values.
		/// callback is invoked with three arguments: the value of the element, the index of the
		/// element, and the Array object being traversed.
		/// <para>If a obj parameter is provided to map, it will be used as the
		/// this for each invocation of the callback. If it is not provided, or is
		/// null, the global object associated with callback is used instead.</para>
		/// map does not mutate the array on which it is called.
		/// <para>The range of elements processed by map is set before the first invocation of
		/// callback. Elements which are appended to the array after the call to map
		/// begins will not be visited by callback.  If existing elements of the array are changed,
		/// or deleted, their value as passed to callback will be the value at the time
		/// map visits them; elements that are deleted are not visited.</para>
		/// </summary>
		/// <param name="callback">Function produce an element of the new Array from an element of the current one.</param>
		/// <param name="obj">Object to use as this when executing callback.</param>
		/// <returns>A new array which contains the return values of every item executed through the given function</returns>
		[JsMethod(Name = "map")]
		public BaseArray Map(Action<object> callback, object obj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the last element from an array and returns that element.</para>
		/// <para>This method modifies the array.</para>
		/// </summary>
		/// <returns>The last element of the array.</returns>
		[JsMethod(Name = "pop")]
		public object Pop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds one or more elements to the end of an array and returns the new length of the array.</para>
		/// <para>This method modifies the array.</para>
		/// </summary>
		/// <param name="varargs">The elements to add to the end of the array.</param>
		/// <returns>The new array&#8217;s length</returns>
		[JsMethod(Name = "push")]
		public double Push(object varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Reverses the order of the elements of an array&#8212;the first becomes the last, and the last becomes the first.</para>
		/// <para>This method modifies the array.</para>
		/// </summary>
		/// <returns>Returns the modified array (works in place)</returns>
		[JsMethod(Name = "reverse")]
		public JsArray Reverse() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the first element from an array and returns that element.</para>
		/// <para>This method modifies the array.</para>
		/// </summary>
		/// <returns>The first element of the array.</returns>
		[JsMethod(Name = "shift")]
		public object Shift() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Extracts a section of an array and returns a new array.</para>
		/// </summary>
		/// <param name="begin">Zero-based index at which to begin extraction. As a negative index, start indicates an offset from the end of the sequence. slice(-2) extracts the second-to-last element and the last element in the sequence.</param>
		/// <param name="end">Zero-based index at which to end extraction. slice extracts up to but not including end. slice(1,4) extracts the second element through the fourth element (elements indexed 1, 2, and 3). As a negative index, end indicates an offset from the end of the sequence. slice(2,-1) extracts the third element through the second-to-last element in the sequence. If end is omitted, slice extracts to the end of the sequence.</param>
		/// <returns>An new array which contains a copy of the given region.</returns>
		[JsMethod(Name = "slice")]
		public BaseArray Slice(double begin, double? end = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Tests whether some element in the array passes the test implemented by the provided function.</para>
		/// some executes the callback function once for each element present in
		/// the array until it finds one where callback returns a true value. If such an element
		/// is found, some immediately returns true. Otherwise, some
		/// returns false. callback is invoked only for indexes of the array which
		/// have assigned values; it is not invoked for indexes which have been deleted or which have never
		/// been assigned values.
		/// callback is invoked with three arguments: the value of the element, the index of the
		/// element, and the Array object being traversed.
		/// <para>If a obj parameter is provided to some, it will be used as the
		/// this for each invocation of the callback. If it is not provided, or is
		/// null, the global object associated with callback is used instead.</para>
		/// some does not mutate the array on which it is called.
		/// <para>The range of elements processed by some is set before the first invocation of
		/// callback.  Elements that are appended to the array after the call to some
		/// begins will not be visited by callback. If an existing, unvisited element of the array
		/// is changed by callback, its value passed to the visiting callback will
		/// be the value at the time that some visits that element&#8217;s index; elements that are
		/// deleted are not visited.</para>
		/// </summary>
		/// <param name="callback">Function to test for each element.</param>
		/// <param name="obj">Object to use as this when executing callback.</param>
		/// <returns>Whether at least one elements passed the test</returns>
		[JsMethod(Name = "some")]
		public bool Some(Action<object> callback, object obj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sorts the elements of an array.</para>
		/// <para>This method modifies the array.</para>
		/// </summary>
		/// <param name="compareFunction">Specifies a function that defines the sort order. If omitted, the array is sorted lexicographically (in dictionary order) according to the string conversion of each element.</param>
		/// <returns>Returns the modified array (works in place)</returns>
		[JsMethod(Name = "sort")]
		public JsArray Sort(Action<object> compareFunction = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds and/or removes elements from an array.</para>
		/// </summary>
		/// <param name="index">Index at which to start changing the array. If negative, will begin that many elements from the end.</param>
		/// <param name="howMany">An integer indicating the number of old array elements to remove. If howMany is 0, no elements are removed. In this case, you should specify at least one new element.</param>
		/// <param name="varargs">The elements to add to the array. If you don&#8217;t specify any elements, splice simply removes elements from the array.</param>
		/// <returns>New array with the removed elements.</returns>
		[JsMethod(Name = "splice")]
		public BaseArray Splice(double index, double howMany, object varargs = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts a base array to a native Array</para>
		/// </summary>
		/// <returns>The native array</returns>
		[JsMethod(Name = "toArray")]
		public JsArray ToArray() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a string representing the array and its elements. Overrides the Object.prototype.toString method.</para>
		/// </summary>
		/// <returns>The string representation of the array.</returns>
		[JsMethod(Name = "toString")]
		public string ToString() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds one or more elements to the front of an array and returns the new length of the array.</para>
		/// <para>This method modifies the array.</para>
		/// </summary>
		/// <param name="varargs">The elements to add to the front of the array.</param>
		/// <returns>The new array&#8217;s length</returns>
		[JsMethod(Name = "unshift")]
		public double Unshift(object varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current number of items stored in the Array</para>
		/// </summary>
		/// <returns>number of items</returns>
		[JsMethod(Name = "valueOf")]
		public double ValueOf() { throw new NotImplementedException(); }

		#endregion Methods
    }
}
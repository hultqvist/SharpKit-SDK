
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/mediastream/RTCPeerConnection.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2014 Sebastian Loncar, Web: http://loncar.de
  Copyright (C) 2009 Apple Inc. All Rights Reserved.

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;

namespace SharpKit.Html.mediastream
{

using SharpKit.JavaScript;
using SharpKit.Html.fileapi;
using SharpKit.Html.html.shadow;
using SharpKit.Html.html.track;
using SharpKit.Html.inspector;
using SharpKit.Html.loader.appcache;
using SharpKit.Html.battery;
using SharpKit.Html.filesystem;
using SharpKit.Html.gamepad;
using SharpKit.Html.geolocation;
using SharpKit.Html.indexeddb;
using SharpKit.Html.intents;
using SharpKit.Html.mediasource;
using SharpKit.Html.mediastream;
using SharpKit.Html.navigatorcontentutils;
using SharpKit.Html.networkinfo;
using SharpKit.Html.notifications;
using SharpKit.Html.proximity;
using SharpKit.Html.quota;
using SharpKit.Html.speech;
using SharpKit.Html.vibration;
using SharpKit.Html.webaudio;
using SharpKit.Html.webdatabase;
using SharpKit.Html.plugins;
using SharpKit.Html.storage;
using SharpKit.Html.svg;
using SharpKit.Html.workers;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "RTCPeerConnection")]
public partial class RTCPeerConnection
{
	public   RTCPeerConnection(object rtcIceServers, object mediaConstraints) {}
	public  void createOffer(RTCSessionDescriptionCallback successCallback, RTCErrorCallback failureCallback) {}
	public  void createOffer(RTCSessionDescriptionCallback successCallback, RTCErrorCallback failureCallback, object mediaConstraints) {}
	public  void createAnswer(RTCSessionDescriptionCallback successCallback, RTCErrorCallback failureCallback) {}
	public  void createAnswer(RTCSessionDescriptionCallback successCallback, RTCErrorCallback failureCallback, object mediaConstraints) {}
	public  void setLocalDescription(RTCSessionDescription description, VoidCallback successCallback, RTCErrorCallback failureCallback) {}
	public  RTCSessionDescription localDescription {get; set; }
	public  void setRemoteDescription(RTCSessionDescription description, VoidCallback successCallback, RTCErrorCallback failureCallback) {}
	public  RTCSessionDescription remoteDescription {get; set; }
	public  JsString readyState {get; set; }
	public  void updateIce() {}
	public  void updateIce(object configuration) {}
	public  void updateIce(object configuration, object mediaConstraints) {}
	public  void addIceCandidate(RTCIceCandidate candidate) {}
	public  JsString iceGatheringState {get; set; }
	public  JsString iceState {get; set; }
	public  MediaStreamList localStreams {get; set; }
	public  MediaStreamList remoteStreams {get; set; }
	public  void addStream(MediaStream stream) {}
	public  void addStream(MediaStream stream, object mediaConstraints) {}
	public  void removeStream(MediaStream stream) {}
	public  void getStats(RTCStatsCallback successCallback, MediaStreamTrack selector) {}
	public  RTCDataChannel createDataChannel(string label) { return default(RTCDataChannel); }
	public  RTCDataChannel createDataChannel(string label, object options) { return default(RTCDataChannel); }
	public  void close() {}
	public  EventListener onnegotiationneeded {get; set; }
	public  EventListener onicecandidate {get; set; }
	public  EventListener onopen {get; set; }
	public  EventListener onstatechange {get; set; }
	public  EventListener onaddstream {get; set; }
	public  EventListener onremovestream {get; set; }
	public  EventListener ongatheringchange {get; set; }
	public  EventListener onicechange {get; set; }
	public  EventListener ondatachannel {get; set; }
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent @event) { return default(bool); }
}

}
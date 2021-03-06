/* Generated by SharpKit 5 v5.4.9 */
"use strict";
if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}


if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var System$Runtime$Serialization$IExtensibleDataObject = {
    fullname: "System.Runtime.Serialization.IExtensibleDataObject",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    Kind: "Interface"
};
JsTypes.push(System$Runtime$Serialization$IExtensibleDataObject);
var System$Runtime$Serialization$ISerializable = {
    fullname: "System.Runtime.Serialization.ISerializable",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    Kind: "Interface"
};
JsTypes.push(System$Runtime$Serialization$ISerializable);
var SharpKit$PropertyInfoExtensions = {
    fullname: "SharpKit.PropertyInfoExtensions",
    baseTypeName: "System.Object",
    staticDefinition: {
        IsStatic: function (pi){
            return pi._IsStatic;
        },
        IsPublic: function (pi){
            throw new Error('Not Implemented');
        }
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKit$PropertyInfoExtensions);
var SharpKit$Extensions2 = {
    fullname: "SharpKit.Extensions2",
    baseTypeName: "System.Object",
    staticDefinition: {
        GetValueOrDefaultIfNullOrEmpty: function (s, defaultValue){
            if(s==null || s.length==0) return defaultValue; return s;
        },
        IsNullOrEmpty$$String: function (s){
            return s == null || s.length == 0;
        },
        IsNotNullOrEmpty$$String: function (s){
            return s != null && s.length > 0;
        },
        HtmlEscape: function (s){
            return s.Replace$$String$$String("&", "&amp;").Replace$$String$$String("<", "&lt;").Replace$$String$$String(">", "&gt;").Replace$$String$$String("\n", "<br/>");
        },
        ReplaceFirst$$String$$String$$String: function (s, search, replace){
            return s.ReplaceFirst(search, replace);
        },
        ReplaceFirst$$String$$String$$String$$StringComparison: function (s, search, replace, comparisonType){
            var index = s.indexOf(search, comparisonType);
            if (index != -1){
                var finalStr = System.String.Concat$$String$$String$$String(s.substr(0, index), replace, s.substr(search.length + index));
                return finalStr;
            }
            return s;
        },
        FixCamelCasing: function (s){
            var sb = new System.Text.StringBuilder.ctor();
            var first = true;
            var $it19 = s.GetEnumerator();
            while ($it19.MoveNext()){
                var c = $it19.get_Current();
                if (System.Char.IsUpper$$Char(c) && !first){
                    sb.Append$$Char(" ");
                }
                sb.Append$$Char(c);
                first = false;
            }
            return sb.toString();
        },
        RemoveLast: function (s, count){
            return s.substr(s, s.length-count);
        },
        TrimEnd: function (s, trimText){
            if (s.EndsWith$$String(trimText))
                return SharpKit.Extensions2.RemoveLast(s, trimText.length);
            return s;
        },
        EqualsIgnoreCase: function (s1, s2){
            return System.String.Compare$$String$$String$$Boolean(s1, s2, true) == 0;
        }
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKit$Extensions2);
var SharpKit$JavaScript$Utils$Js = {
    fullname: "SharpKit.JavaScript.Utils.Js",
    baseTypeName: "System.Object",
    staticDefinition: {
        cctor: function (){
            SharpKit.JavaScript.Utils.Js.undefined = null;
        },
        escape: function (s){
            return escape(s);
        },
        JsEquals: function (obj, value){
            return obj==value;
        },
        JsExactEqualsToUndefined: function (obj){
            return obj===undefined;
        },
        JsExactEquals: function (obj, value){
            return obj===value;
        },
        Typeof: function (obj){
            return typeof(obj);
        },
        ApplyFunction: function (func, thisArg, prms){
            throw $CreateException(new System.NotImplementedException.ctor$$String("TODO: Implement"), new Error());
        },
        CallFunction: function (func, thisArg, prms){
            throw $CreateException(new System.NotImplementedException.ctor$$String("TODO: Implement"), new Error());
        },
        CallFunction2: function (obj, funcName, prms){
            return obj[funcName].apply(obj, Arguments.from(arguments, 2));
        },
        FindOverloadedMethodName: function (obj, funcName){
            funcName+='$$';for(var o in obj)
if (typeof(obj[o])=='function' && o.indexOf(funcName)==0) 
	return o; 
return null;
        },
        Eval: function (code){
            eval(code)
        },
        Compile: function (){
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        GetHashKey: function (key){
            return JsCompiler.GetHashKey(key);
        },
        DeleteMember: function (obj, name){
            delete obj[name];
        },
        parseFloat: function (s){
            return parseFloat(s);
        },
        parseInt: function (s){
            return parseInt(s);
        },
        ApplyNew: function (jsCtor, prms){
            if(prms==null || prms.length==0) return new jsCtor(); return new jsCtor(prms[0], prms[1], prms[2], prms[3], prms[4], prms[5], prms[6], prms[7], prms[8]);
        },
        IsArray: function (obj){
            return obj instanceof Array;
        },
        isNaN: function (obj){
            return isNaN(obj);
        },
        decodeURIComponent: function (encodedURIString){
            return decodeURIComponent(encodedURIString)
        },
        encodeURIComponent: function (encodedURIString){
            return encodeURIComponent(encodedURIString)
        },
        encodeURI: function (URIString){
            return encodeURI(URIString)
        },
        decodeURI: function (URIString){
            return decodeURI(URIString)
        },
        unescape: function (s){
            return unescape(s)
        }
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKit$JavaScript$Utils$Js);
var SharpKit$JsClr$Utils$JsClrClientSerializer = {
    fullname: "SharpKit.JsClr.Utils.JsClrClientSerializer",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            this.ObjInfos = null;
            this.RefIndex = 0;
            this.IgnoreFields = null;
            System.Object.ctor.call(this);
            this.ObjInfos = new System.Collections.Generic.Dictionary$2.ctor(System.Object.ctor, "SharpKit.JsClr.Utils.ObjInfo");
            this.IgnoreFields = new Object();
            this.IgnoreFields["_type"] = true;
            this.IgnoreFields["_hashKey"] = true;
        },
        Serialize: function (obj){
            var obj2 = this.Serialize2(obj);
            return JSON.stringify(obj2);
        },
        Serialize2: function (obj){
            if (obj === undefined)
                return undefined;
            if (obj === null)
                return null;
            var jsType = typeof(obj);
            if (jsType == "object"){
                return this.SerializeRefOrContent(obj);
            }
            else if (jsType == "function"){
                return undefined;
            }
            else {
                return obj;
            }
        },
        SerializeRefOrContent: function (obj){
            if (!this.ObjInfos.ContainsKey(obj)){
                var info = {};
                this.ObjInfos.Add(obj, info);
                this.SerializeFirstRef(obj, info);
                return info.FirstRef;
            }
            else {
                var info = this.ObjInfos.get_Item$$TKey(obj);
                if (info.Ref == null){
                    this.RefIndex++;
                    info.Ref = {
                        $r: this.RefIndex.toString(),
                        $t: "ObjRef"
                    };
                    info.FirstRef.$k = info.Ref.$r;
                }
                return info.Ref;
            }
        },
        SerializeFirstRef: function (obj, info){
            var obj2 = {};
            info.FirstRef = obj2;
            var type = obj.GetType();
            obj2.$t = type.get_FullName();
            var obj3 = obj;
            if (Is(obj, System.Collections.IList.ctor)){
                var list = obj;
                obj2.$l =  [];
                var $it20 = list.GetEnumerator();
                while ($it20.MoveNext()){
                    var item = $it20.get_Current();
                    var item2 = this.Serialize2(item);
                    obj2.$l.push(item2);
                }
            }
            else {
                for (var p in obj3){
                    if (this.IgnoreFields[p])
                        continue;
                    if (!obj3.hasOwnProperty(p))
                        continue;
                    var value = obj3[p];
                    obj2[p] = this.Serialize2(value);
                }
            }
            return obj2;
        }
    }
};
JsTypes.push(SharpKit$JsClr$Utils$JsClrClientSerializer);
var SharpKit$JavaScript$JsNamingHelper = {
    fullname: "SharpKit.JavaScript.JsNamingHelper",
    baseTypeName: "System.Object",
    staticDefinition: {
        JsFunctionNameToClrMethodName: function (jsFuncName){
            var methodName = jsFuncName;
            var di = jsFuncName.indexOf("$");
            if (di > 0)
                methodName = jsFuncName.substr(0, di);
            return methodName;
        },
        ClrTypeToJsTypeRef: function (type){
            var att = System.Linq.Enumerable.FirstOrDefault$1$$IEnumerable$1(SharpKit.JavaScript.JsTypeAttribute.ctor, System.Linq.Enumerable.OfType$1(SharpKit.JavaScript.JsTypeAttribute.ctor, type.GetCustomAttributes$$Type$$Boolean(Typeof(SharpKit.JavaScript.JsTypeAttribute.ctor), false)));
            if (att != null && SharpKit.Extensions2.IsNotNullOrEmpty$$String(att.get_Name())){
                return att.get_Name().Replace$$Char$$Char("`", "$");
            }
            return type.get_Namespace() + "." + type.get_Name().Replace$$Char$$Char("`", "$");
        },
        ClrConstructorToJsFunctionName: function (mi){
            var sb = new System.Text.StringBuilder.ctor();
            var typeRef = SharpKit.JavaScript.JsNamingHelper.ClrTypeToJsTypeRef(mi.get_DeclaringType());
            sb.Append$$String(typeRef);
            sb.Append$$String(".ctor");
            SharpKit.JavaScript.JsNamingHelper.ConvertParametersToJsFunctionName(mi.GetParameters(), sb);
            return sb.toString();
        },
        ConvertParametersToJsFunctionName: function (prms, sb){
            for (var $i22 = 0,$l22 = prms.length,prm = prms[$i22]; $i22 < $l22; $i22++, prm = prms[$i22]){
                sb.Append$$String("$$");
                sb.Append$$String(prm.get_ParameterType().get_Name());
            }
        },
        ClrMethodBaseToJsFunctionName: function (mi){
            if (mi.get_MemberType() == 1){
                return SharpKit.JavaScript.JsNamingHelper.ClrMethodToJsFunctionName(Cast(mi, System.Reflection.MethodInfo.ctor));
            }
            else if (mi.get_MemberType() == 8){
                return SharpKit.JavaScript.JsNamingHelper.ClrConstructorToJsFunctionName(Cast(mi, System.Reflection.ConstructorInfo.ctor));
            }
            else
                throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        ClrMethodToJsFunctionName: function (mi){
            if (SharpKit.JavaScript.JsNamingHelper.IsPropertySetter(mi)){
                return mi.get_Name();
            }
            var name = mi.get_Name();
            var type = mi.get_DeclaringType();
            if (type.get_IsGenericType()){
                type = type.GetGenericTypeDefinition();
                mi = type.GetMethod$$String(name);
            }
            var sb = new System.Text.StringBuilder.ctor();
            if (mi.get_IsStatic()){
                sb.Append$$String(SharpKit.JavaScript.JsNamingHelper.ClrTypeToJsTypeRef(type));
                var att = System.Linq.Enumerable.FirstOrDefault$1$$IEnumerable$1(SharpKit.JavaScript.JsTypeAttribute.ctor, System.Linq.Enumerable.OfType$1(SharpKit.JavaScript.JsTypeAttribute.ctor, type.GetCustomAttributes$$Type$$Boolean(Typeof(SharpKit.JavaScript.JsTypeAttribute.ctor), false)));
                if (att == null || att.get_Mode() == 2){
                    sb.Append$$String(".staticDefinition.");
                }
                else {
                    sb.Append$$String(".");
                }
            }
            sb.Append$$String(name);
            SharpKit.JavaScript.JsNamingHelper.ConvertParametersToJsFunctionName(mi.GetParameters(), sb);
            return sb.toString();
        },
        IsPropertySetter: function (mi){
            var name = mi.get_Name();
            return name.StartsWith$$String("set_") && mi.GetParameters().length == 1;
        }
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(SharpKit$JavaScript$JsNamingHelper);


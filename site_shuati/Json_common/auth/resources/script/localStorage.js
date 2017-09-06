/** 存储登录值 start */
//根据名字获取cookie
function local_get(key) {
	return $.cookie(key);
}

//添加cookie
function local_add(key, value) {
	$.cookie(key, value, {
		path : "/",
		expires : 7
	});
}

//删除cookie
function local_delete(key) {
	$.cookie(key, null, {
		path : "/"
	});
}

//清除所有的cookie
function loccal_clear() {
	var keys = document.cookie.match(/[^ =;]+(?=\=)/g);
	if (keys) {
		for (var i = keys.length; i--;)
			document.cookie = keys[i] + '=0;expires='
					+ new Date(0).toUTCString();
	}
}

function local_clear_except_city() {
	local_delete("identity");
}

function get_identity() {
	return $.cookie("identity");
}

function set_identity(value) {
	$.cookie("identity", value, {
		path : "/",
		expires : 30
	});
}

function get_systemId() {
	return local_get("systemId");
}
function set_systemId(value) {
	local_add("systemId", value);
}

function set_city_id(id) {
	local_add("city_id", id);
}

function get_city_id() {
	return local_get("city_id");
}

function set_city_name(name) {
	local_add("city_name", name);
}

function get_city_name() {
	return local_get("city_name");
}
/** 存储登录值 end */

function isEmpty(value) {
	if (value == null || value == undefined || value == '' || value == 'null'
			|| value == 'undefined') {
		return true;
	}
	return false;
}

function encodeMap(param) {
	for ( var key in param) {
		if (param[key] != null && param[key] != undefined && param[key] != ''
				&& param[key] != 'null' && param[key] != 'undefined') {
			param[key] = encodeURIComponent(param[key], "UTF-8");
		}
	}
	return param;
}

function decodeMap(param) {
	for ( var key in param) {
		if (param[key] != null && param[key] != undefined && param[key] != ''
				&& param[key] != 'null' && param[key] != 'undefined') {
			param[key] = decodeURIComponent(param[key], "UTF-8");
		}
	}
	return param;
}

//Array.prototype.remove = function(val) {  
//    var index = this.indexOf(val);  
//    if (index > -1) {  
//        this.splice(index, 1);  
//    }  
//};

function valueTovalue(obj1, obj2) {
	for ( var key in obj1) {
		obj2[key] = obj1[key];
	}
	return obj2;
}

function isWeiXin() {
	var ua = window.navigator.userAgent.toLowerCase();
	if (ua.match(/MicroMessenger/i) == 'micromessenger') {
		return true;
	} else {
		return false;
	}
}

function showLoading() {
	$(".loading-model").show();
}

function hideLoading() {
	$(".loading-model").hide();
}

function searchParam(par) {
	var param = {};
	if (isEmpty(par)) {
		return param;
	} else {
		if (par.indexOf("?") != -1) {
			par = par.substring(1, par.length);
		}
		var array = par.split("&");
		for (var i = 0; i < array.length; i++) {
			var array2 = new Array();
			var ss = array[i].toString();
			array2[0] = ss.substring(0, array[i].indexOf("="));
			array2[1] = array[i].substring(array[i].indexOf("=") + 1,
					array[i].length);
			param[array2[0]] = array2[1];
		}
		return param;
	}
}

function paramTourl(param) {
	var urlparam = "";
	var i = 0;
	for ( var key in param) {
		if (i == 0) {
			urlparam = key + "=" + param[key];
			i++;
		} else {
			urlparam = urlparam + "&" + key + "=" + param[key];
		}
	}
	return urlparam;
}

function getCurrentUrl() {
	var url = window.location.href;
	if (url.indexOf("#") != -1) {
		var array = url.split("#");
		url = array[0];
	}
	if (url.indexOf("?") != -1) {
		var array = url.split("?");
		return array[0];
	}
	return url;
}

function historyBack() {
	if (window.history.length > 0) {
		window.history.back();
	} else {
		myhref.href = "authentication";
	}
};

function dateFormat(date, format) {
	date = new Date(date);
	var map = {
		"M" : date.getMonth() + 1, //月份 
		"d" : date.getDate(), //日 
		"h" : date.getHours(), //小时 
		"m" : date.getMinutes(), //分 
		"s" : date.getSeconds(), //秒 
		"q" : Math.floor((date.getMonth() + 3) / 3), //季度 
		"S" : date.getMilliseconds()
	//毫秒 
	};

	format = format.replace(/([yMdhmsqS])+/g, function(all, t) {
		var v = map[t];
		if (v !== undefined) {
			if (all.length > 1) {
				v = '0' + v;
				v = v.substr(v.length - 2);
			}
			return v;
		} else if (t === 'y') {
			return (date.getFullYear() + '').substr(4 - all.length);
		}
		return all;
	});
	return format;
}

// 是否是ios浏览器
function isIos() {
	var u = navigator.userAgent, app = navigator.appVersion;
	var isiOS = !!u.match(/\(i[^;]+;( U;)? CPU.+Mac OS X/); //ios终端
	return isiOS;
}

// 判断是android浏览器
function isAndroid() {
	var u = navigator.userAgent, app = navigator.appVersion;
	var isAndroid = u.indexOf('Android') > -1 || u.indexOf('Linux') > -1;
	return isAndroid;
}

function connectWebViewJavascriptBridge(callback) {

	if (window.WebViewJavascriptBridge) {

		callback(WebViewJavascriptBridge);

	} else {

		document.addEventListener('WebViewJavascriptBridgeReady', function() {

			callback(WebViewJavascriptBridge);

		}, false);
	}
}

function fillParam(param) {
	if (isEmpty(param)) {
		param = {};
	}
	param.appKey = "QTSHE_WECHAT";
	param.version = "weixin";
	param.deviceId = "weixin";

	return param;
}
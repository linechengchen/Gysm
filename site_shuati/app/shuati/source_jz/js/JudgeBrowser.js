function isAlipay() { //判断是否支付宝浏览器
	var u = navigator.userAgent,app = navigator.appVersion;
	if (u.indexOf('AlipayDefined') > -1) {
		return true;
	} else {
		return false;
	}
}

function isWeiXin() {//判断是否微信浏览器
	var ua = window.navigator.userAgent.toLowerCase();
	if(ua.match(/MicroMessenger/i) == 'micromessenger') {
		return true;
	} else {
		return false; 
	}
}

function isIos() {//判断IOS
	var u = navigator.userAgent, app = navigator.appVersion;
	var isiOS = !!u.match(/\(i[^;]+;( U;)? CPU.+Mac OS X/);
	return isiOS;
}

function isAndroid() {//判断安卓
	var u = navigator.userAgent, app = navigator.appVersion;
	var isAndroid = u.indexOf('Android') > -1 || u.indexOf('Linux') > -1;
	return isAndroid;
}

function isQQ(){//判断是否QQ浏览器
	var u = navigator.userAgent, app = navigator.appVersion; 
	if(u.indexOf('MQQBrowser') > -1) {
		return true;
	}else{
		return false; 
	}
}

function IsPC() {//判断是否为PC端
    var userAgentInfo = navigator.userAgent;
    var Agents = ["Android", "iPhone","SymbianOS", "Windows Phone", "iPad", "iPod"];
    var flag = true;
    for (var v = 0; v < Agents.length; v++) {
        if (userAgentInfo.indexOf(Agents[v]) > 0) {
            flag = false;
            break;
        }
    }
    return flag;
}
function isIE() { //判断是否为IE浏览器
    if (!!window.ActiveXObject || "ActiveXObject" in window) {
    	return true;
    } else {
    	return false;
    }
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
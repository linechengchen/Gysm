

// 判断是否是 微信浏览器
function isWeiXin() {
	var ua = window.navigator.userAgent.toLowerCase();
	if(ua.match(/MicroMessenger/i) == 'micromessenger') {
		return true;
	} else {
		return false; 
	}
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
// 判断qq浏览器
function isQQ(){
	var u = navigator.userAgent, app = navigator.appVersion; 
	if(u.indexOf('MQQBrowser') > -1) {
		return true;
	}else{
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

//console.clear();
var fixUrlJson = "https://user.qtshe.com",
	appKey = "QTSHE_WECHAT",
	version = "4.0.0";
if (window.location.href.indexOf("6225") != -1) {
    var num1 = window.location.href.indexOf("6225") + 4;
    fixUrlJson = 'https://localhost:6225' + window.location.href[num1] + '/Json_JianZhi/user';//'../json_shuati/';
}else
    fixUrlJson = "../../../Json_JianZhi/user";//zlg

var JsonPares = (function () {
	function set(key, json) {
		localStorage.setItem(key, JSON.stringify(json));
	}
	function get(key) {
		return JSON.parse(localStorage.getItem(key));
	}
	function remove(key) {
		localStorage.removeItem(key);
	}
	return {
		set: set,
		get: get,
		remove: remove
	};
})();
//JsonPares.set("haha", jsonD);
//alert(JsonPares.get("haha"));
//JsonPares.remove("haha");

var DeviceIds = Math.random();//随机数的产生
var nowUrl = window.location.href;//获取当前地址栏链接

var ajaxJsonStr = false;
function postAjax(url, data, fixurl2) {
    
    var realUrl = fixUrlJson + url;
    if (fixurl2)
        var realUrl = fixurl2;
	
	var p = new promise.Promise();
	data.appKey = appKey;
	data.version = version;
	if(isEmpty(JsonPares.get("random_number"))) {
		data.deviceId = DeviceIds;
		JsonPares.set("random_number", DeviceIds);
	} else {
		data.deviceId = JsonPares.get("random_number");
	}   
	// 添加开放平台参数
	data = addOpenParam(data);
    //alert('data:' + url + data);
	var dataStr = JSON.stringify(data);
	console.log(realUrl+"  下面是参数");
	console.log("//参数：" + dataStr);
	$.ajax(realUrl, {
	    //data: data,
	    data: (ajaxJsonStr) ? dataStr : data,
		dataType: 'json', // 服务器返回json格式数据
		type: 'post', // HTTP请求类型
		timeout: 10000, // 超时时间设置为10秒；
		success: function(data) {
			if (!data.success) {
				if(nowUrl.indexOf('AgentPlatform') < 0){
					if (data.errCode == 4007) {
						myhref.href = "wanshan.html?redirect_uri="+encodeURIComponent(redirect_uri);
					} else if (data.errCode == 4004) {
						myhref.href = "../pagesCommon/login.html?redirect_uri="+encodeURIComponent(redirect_uri);
					}
				}

			}
			p.done(data);
		},
		error: function(xhr, type, errorThrown) {
			//异常处理；
			console.log(errorThrown);
		}
	});
	return p;
}
function postAsyncAjax(url, data) {
	var realUrl = fixUrlJson + url;
	var p = new promise.Promise();
	data.appKey = appKey;
	data.version = version;
	if(isEmpty(JsonPares.get("random_number"))) {
		data.deviceId = DeviceIds;
		JsonPares.set("random_number", DeviceIds);
	} else {
		data.deviceId = JsonPares.get("random_number");
	}
	// 添加开放平台参数
	data = addOpenParam(data);
	$.ajax(realUrl, {
		data: data,
		dataType: 'json', // 服务器返回json格式数据
		type: 'post', // HTTP请求类型
		timeout: 10000, // 超时时间设置为10秒；
		async: false,
		success: function(data) {
			if (!data.success) {
				if (data.errCode == 4007) {
					myhref.href = "wanshan.html?redirect_uri="+encodeURIComponent(redirect_uri);
				} else if (data.errCode == 4004) {
					myhref.href = "../pagesCommon/login.html?redirect_uri="+encodeURIComponent(redirect_uri);
				}

			}
			p.done(data);
		},
		error: function(xhr, type, errorThrown) {
			//异常处理；
			console.log(errorThrown);
		}
	});
	return p;
}

// 上传图片封装
function postSubmit(url, data, formId) {
	var realUrl = fixUrlJson + url;
	var p = new promise.Promise();
	data.appKey = appKey;
	data.version = version;
	if(isEmpty(JsonPares.get("random_number"))) {
		data.deviceId = DeviceIds;
		JsonPares.set("random_number", DeviceIds);
	} else {
		data.deviceId = JsonPares.get("random_number");
	}
	// 添加开放平台参数
	data = addOpenParam(data);
	$("#" + formId).ajaxSubmit({
		type: "post", // 提交方式 get/post
		url: realUrl, // 需要提交的 url
		data: data,
		dataType: "json",
		success: function(data) { // data 保存提交后返回的数据，一般为 json 数据
			if (!data.success) {
				if (data.errCode == 4007) {
				    myhref.href = "wanshan.html?redirect_uri="+encodeURIComponent(redirect_uri);
				} else if (data.errCode == 4004) {
					myhref.href = "../pagesCommon/login.html?redirect_uri="+encodeURIComponent(redirect_uri);
				}
			}
			p.done(data);
		},
		error: function() {
			alert("提交失败");
		}
	});
	// return false; // 阻止表单自动提交事件
	return p;
}

function ajaxSubmit(formId,url,data) {
	var realUrl = fixUrlJson + url;
	var p = new promise.Promise();
	data.appKey = appKey;
	data.version = version;
	// 同步上传图片和数据的封装处理函数
	 $("#" + formId).ajaxSubmit({
         type: "post", // 提交方式 get/post
         url: realUrl, // 需要提交的 url
         data:data,
         dataType: "json", //图片上传必备
         success: function(data) {
        	 p.done(data);
         },
         error:function() {
           alert('发生了错误，请稍后重试！');
         }
       });
	 return p;
}

//我的页面上传头像
function postImgAjax(url, data) {
	var realUrl = fixUrlJson + url;
	var p = new promise.Promise();
	data.appKey = appKey;
	data.version = version;
	if(isEmpty(JsonPares.get("random_number"))) {
		data.deviceId = DeviceIds;
		JsonPares.set("random_number", DeviceIds);
	} else {
		data.deviceId = JsonPares.get("random_number");
	}
	
	// 添加开放平台参数
	data = addOpenParam(data);
	
	$.ajax(realUrl, {
		data: data,
		dataType: 'json', // 服务器返回json格式数据
		type: 'post', // HTTP请求类型
		timeout: 10000, // 超时时间设置为10秒
		cache: false,
		contentType: false, //不可缺
		processData: false, //不可缺
		success: function(data) {
			if (!data.success) {
				if (data.errCode == 4007) {
					myhref.href = "wanshan.html?redirect_uri="+encodeURIComponent(redirect_uri);
				} else if (data.errCode == 4004) {
					myhref.href = "../pagesCommon/login.html?redirect_uri="+encodeURIComponent(redirect_uri);
				}

			}
			p.done(data);
		},
		error: function(xhr, type, errorThrown) {
			//异常处理；
			console.log(errorThrown);
		}
	});
	return p;
}

createActive();
function createActive() {
    var data = {};
    data.activityName = window.location.href;
    data.activityTitle = $("title").text();
    postAjax('/behaviorTracking.aspx', data);
    //$('body').append('<img src="'+ fixUrlJson +'" />');
}

getOpenParam();
// 获取开放平台参数
function getOpenParam() {
	var param = searchParam(window.location.search);
	if(!isEmpty(param.openOsUserId)) {
		sessionStorage.setItem('openOsUserId' , param.openOsUserId);
	}
}

// 添加开放平台参数
function addOpenParam(data) {
	if(isEmpty(data)) {
		data = {};
	}
	if(!isEmpty(sessionStorage.getItem('openOsUserId')) && !isEmpty() ) {
		data.openOsUserId = sessionStorage.getItem('openOsUserId');
	}
	return data;
}
// 分享到第三方平台  比如 微信 qq  
// param 
// title:分享标题
// link:分享链接
// imgUrl:分享图标
// desc:内容
function shareThirdPlatform(dataWeixin, dataWeixinFriend , dataQQ , dataQQZone) {
	//获取判断微信 用于分享
		var timestamp, signature, nonceStr;
		function shareInitPartJobList() {
			var url_param = {};
			url_param.local_url = window.location.href.split('#')[0];
			postAjax("/JsApiSign.aspx", url_param).then(function (data) {
				timestamp = data.timestamp;
				signature = data.signature;
				nonceStr = data.nonceStr;

				initWX();
			});
		}

		var locUrl = window.location.href;

		function initWX() {
			wx.config({
				debug: false,
				appId: 'wx7357df8d57420ae4',
				timestamp: timestamp,
				nonceStr: nonceStr,
				signature: signature,
				jsApiList: [
					'checkJsApi',
					'onMenuShareTimeline',
					'onMenuShareAppMessage',
					'onMenuShareQQ',
					'onMenuShareWeibo',
					'hideMenuItems',
					'showMenuItems',
					'hideAllNonBaseMenuItem',
					'showAllNonBaseMenuItem',
					'translateVoice',
					'startRecord',
					'stopRecord',
					'onRecordEnd',
					'playVoice',
					'pauseVoice',
					'stopVoice',
					'uploadVoice',
					'downloadVoice',
					'chooseImage',
					'previewImage',
					'uploadImage',
					'downloadImage',
					'getNetworkType',
					'openLocation',
					'getLocation',
					'hideOptionMenu',
					'showOptionMenu',
					'closeWindow',
					'scanQRCode',
					'chooseWXPay',
					'openProductSpecificView',
					'addCard',
					'chooseCard',
					'openCard'
				]
			});
			wx.ready(function() {
				wx.onMenuShareTimeline({
					title: dataWeixinFriend.title, // 分享标题
					link: dataWeixinFriend.link, // 分享链接
					imgUrl: dataWeixinFriend.imgUrl, // 分享图标
					success: function() {
						// 用户确认分享后执行的回调函数

					},
					cancel: function() {
						// 用户取消分享后执行的回调函数

					}
				});
				wx.onMenuShareAppMessage({
					title: dataWeixin.title, // 分享标题
					desc: dataWeixin.desc, // 分享描述
					link: dataWeixin.link, // 分享链接
					imgUrl: dataWeixin.imgUrl, // 分享图标
					type: 'link', // 分享类型,music、video或link，不填默认为link
					dataUrl: '', // 如果type是music或video，则要提供数据链接，默认为空
					success: function() {
						// 用户确认分享后执行的回调函数

					},
					cancel: function() {
						// 用户取消分享后执行的回调函数
					}
				});
				wx.onMenuShareQQ({ //分享到QQ
					title: dataQQ.title, // 分享标题
					desc: dataQQ.desc, // 分享描述
					link: dataQQ.link, // 分享链接
					imgUrl: dataQQ.imgUrl, // 分享图标
					success: function() {
						// 用户确认分享后执行的回调函数
					},
					cancel: function() {
						// 用户取消分享后执行的回调函数
					}
				});
				wx.onMenuShareQZone({ //分享到QQ空间
					title: dataQQZone.title, // 分享标题
					desc: dataQQZone.desc, // 分享描述
					link: dataQQZone.link, // 分享链接
					imgUrl: dataQQZone.imgUrl, // 分享图标
					success: function() {
						// 用户确认分享后执行的回调函数
					},
					cancel: function() {
						// 用户取消分享后执行的回调函数
					}
				});
			});
		}
	}
function isEmpty(value) { //判空
	if(value == null || value == undefined || value == '' || value == 'null' || value == 'undefined') {
		return true;
	}
	return false;
}

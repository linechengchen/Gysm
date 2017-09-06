/** 存储登录值 start */
//根据名字获取cookie
function local_get(key) {
	return $.cookie(key);
}

function local_add(key,value) {
	$.cookie(key, value, { path: "/",expires: 7}); 
}

//删除cookie
function local_delete(key) {
	$.cookie(key, null, { path: "/"}); 
}

//清除所有的cookie
function local_clear() {
	var keys=document.cookie.match(/[^ =;]+(?=\=)/g); 
	if (keys) {
		for (var i = keys.length; i--;)
			document.cookie=keys[i]+'=0;expires=' + new Date( 0).toUTCString();
	} 
}

// 存储登陆信息
function add_login_cookie(json) {
	local_add("loginMsg",JSON.stringify(json));
}

// 将cookie转化JSON
function get_login_cookie() { //获取存储信息时：get_login_cookie().token  // get_login_cookie().name
	if(local_get("loginMsg") == null) {
		return null;
	}
	return JSON.parse(local_get("loginMsg"));
}



// 清除身份id
function local_clear_except_city() {
	local_delete("identity_new");
}
// 获取身份id
function get_identity() {
	return local_get("identity_new");
}
// 存储身份证id
function set_identity(value) {
	local_add("identity_new",value);
}

// 获取学校id
function get_schoolId() {
	return local_get("school_id");
}
// 存储学校id
function set_schoolId(value) {
	local_add("school_id",value);
}

function get_systemId() {
	return local_get("systemId");
}
function set_systemId(value) {
	local_add("systemId",value);
}

function set_town_id(id) {
	local_add("townId",id);
}

function get_town_id() {
	return local_get("townId");
}

function set_town_name(name) {
	local_add("townName",name);
}

function get_town_name() {
	return local_get("townName");
}

//存储组团ID
function set_groupPartJobId(name) {
	local_add("groupPartJobId",name);
}

function get_groupPartJobId() {
	return local_get("groupPartJobId");
}

//储存获取经纬度

//经度
function set_longitude(lng) {
	local_add("longitude",lng);
}

function get_longitude() {
	return local_get("longitude");
}
//纬度
function set_latitude(lat) {
	local_add("latitude",lat);
}

function get_latitude() {
	return local_get("latitude");
}
//存储地址
function set_address(address) {
	local_add("address",address);
}

function get_address() {
	return local_get("address");
}

function set_uid(uid) {//兼职授权
	local_add("uid",uid);
}

function get_uid() {
	return local_get("uid");
}

function set_partJobId(partJobId) {//存取兼职ID
	local_add("partJobId",partJobId);
}

function get_partJobId() {
	return local_get("partJobId");
}

function set_phones(phones) {//存取兼职手机号
	local_add("phones",phones);
}

function get_phones() {
	return local_get("phones");
}

function set_openOsUserId(openOsUserId) {//开放平台ID
	sessionStorage.setItem("openOsUserId",openOsUserId);//将value存储到key字段
}
function get_openOsUserId() {
	return sessionStorage.getItem("openOsUserId");//获取指定key本地存储的值
}
function del_openOsUserId() {
	sessionStorage.removeItem("openOsUserId");//删除指定key本地存储的值
}


/** 存储登录值 end */

function isEmpty(value) {
	if(value == null || value == undefined || value == '' || value == 'null' || value == 'undefined') {
		return true;
	}
	return false;
}

//编码
function encodeMap(param) {
	for (var key in param) {
		if(param[key] != null && param[key] != undefined && param[key] != '' && param[key] != 'null' && param[key] != 'undefined') {
			param[key] = encodeURIComponent(param[key],"UTF-8");
		}
	}
	return param;
}

//解码
function decodeMap(param) {
	for (var key in param) {
		if(param[key] != null && param[key] != undefined && param[key] != '' && param[key] != 'null' && param[key] != 'undefined') {
			param[key] = decodeURIComponent(param[key],"UTF-8");
		}
	}
	return param;
}


function valueTovalue(obj1,obj2) {
	for ( var key in obj1) {
		obj2[key] = obj1[key];
	}
	return obj2; 
}

function isWeiXin() {
	var ua = window.navigator.userAgent.toLowerCase();
	if(ua.match(/MicroMessenger/i) == 'micromessenger'){
		return true;
	}else{
		return false;
	}
}

function showLoading() {
	$(".loading-model").show();
}

function hideLoading() {
	$(".loading-model").hide();
}

// 搜索url
function searchParam(par) {
	var param = {};
	if(isEmpty(par)) {
		return param;
	} else {
		if(par.indexOf("?") != -1) {
			par = par.substring(1,par.length);
		}
		
		par = par.replace("#","");
		
		var array = par.split("&");
		for (var i = 0; i < array.length; i++) {
			var array2 = new Array();
			var ss = array[i].toString();
			array2[0] = ss.substring(0,array[i].indexOf("="));
			array2[1] = array[i].substring(array[i].indexOf("=") + 1,array[i].length);
			param[array2[0]] = array2[1];
		}
		return param;
	}
}

// 解析hash对象
function hashParam(hashurl) {
	var param = {};
	hashurl = hashurl.replace("#","");
	var array = hashurl.split("&");
	for (var i = 0; i < array.length; i++) {
			var array2 = new Array();
			var ss = array[i].toString();
			array2[0] = ss.substring(0,array[i].indexOf("="));
			array2[1] = array[i].substring(array[i].indexOf("=") + 1,array[i].length);
			param[array2[0]] = array2[1];
	}
	return param;
}

// 拼接url
function paramTourl(param) {
	var urlparam = "";
	var i = 0;
	for ( var key in param) {
		if(i == 0){
			urlparam = key + "=" + param[key];
			i++;
		} else {
			urlparam = urlparam + "&" + key + "=" + param[key];
		}
	}
	return urlparam;
}

// 获取当前url
function getCurrentUrl() {
	var url = window.location.href;
	if(url.indexOf("#") != -1) {
		var array = url.split("#");
		url = array[0];
	}
	if(url.indexOf("?") != -1) {
		var array = url.split("?");
		return array[0];
	}
	return url;
}


function historyBack() {
	if(window.history.length > 0) {
		window.history.back();
	} else {
		myhref.href = "partjobList";
	}
};

function dateFormat(date, format) {
    date = new Date(date);
    var map = {
        "M": date.getMonth() + 1, //月份 
        "d": date.getDate(), //日 
        "h": date.getHours(), //小时 
        "m": date.getMinutes(), //分 
        "s": date.getSeconds(), //秒 
        "q": Math.floor((date.getMonth() + 3) / 3), //季度 
        "S": date.getMilliseconds() //毫秒 
    };
    
    format = format.replace(/([yMdhmsqS])+/g, function(all, t) {
        var v = map[t];
        if (v !== undefined) {
            if (all.length > 1) {
                v = '0' + v;
                v = v.substr(v.length - 2);
            }
            return v;
        }
        else if (t === 'y') {
                return (date.getFullYear() + '').substr(4 - all.length);
            }
        return all;
    });
    return format;
}

function fillParam(param) {
	if(isEmpty(param)) {
		param = {};
	}
	param.appKey = "QTSHE_WECHAT";
	param.version = "weixin";
	param.deviceId = "weixin";
	
	return param;
}

function setHistory(array) { //存localStorage数组
	array = unique(array);
	if(array.length > 5) {
		array = array.slice(0,5);
	}
	localStorage.history = array.join(",");
}
function getHistory() { //取出数组
	return localStorage.history;
}
// 数组去重
function unique(arr) {
    var result = [], hash = {};
    for (var i = 0, elem; (elem = arr[i]) != null; i++) {
        if (!hash[elem]) {
            result.push(elem);
            hash[elem] = true;
        }
    }
    return result;
}		


// 同盾科技cookie
function getTongdunCookie() {
	var value = $.cookie("tongdunkeji-uuid");
	if(isEmpty(value)) {
		saveTongdunkeji(Math.uuid());
		value = $.cookie("tongdunkeji-uuid");
	}
	return value;
}

// 存储同盾科技
function saveTongdunkeji(value) {
	$.cookie("tongdunkeji-uuid", value, { path: "/" });
}
function popover(msg) {
	$('body').append('<div class="modal trans"><div class="popover">' + msg + '</div></div>');
	$('.popover').css('margin-top', -$('.popover').height() / 2 + 'px');
	setInterval(function() {
		$('.popover').animate({
			opacity: '0'
		}, 1000, 'linear', function() {
			$('.modal').remove();
		});
	}, 1000);
}
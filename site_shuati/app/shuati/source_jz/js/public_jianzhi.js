

//接口前缀URl
var fixUrlJson = "http://user.qtshe.com";
fixUrlJson = "../../../Json_JianZhi/user";

var mUrl = "../../m";//"http://m.qtshe.com
var qtbaoUrl = "../../../Json_JianZhi/qtbao";//"http://qtbao.qtshe.com

//芝麻信用链接
var SESAMECREDIT = "http://localhost:62259/app/jianzhi/auth/auth/zmxy/myauthentication.aspx";//http://jianzhi.qtshe.com
SESAMECREDIT = authUrl + "/auth/zmxy/myauthentication.aspx";
//帮粉币链接
var GREENTREASURE = "http://qtbao.qtshe.com";
GREENTREASURE = "../../../Json_JianZhi/qtbao";

//弹出窗口，提示//zlg
function popover(msg) {
	$('body').append('<div class="modal trans"><div class="popover">' + msg + '</div></div>');
	$('.popover').css('margin-top', -$('.popover').height() / 2 + 'px');
	setInterval(function() {
		$('.popover').animate({
			opacity: '0'
		}, 1000, 'linear', function() {
			$('.modal').remove();
		});
	}, 2000);
}

function popoverer(msg) {
	$('body').append('<div class="modal trans"><div class="popoverer">' + '<img src="../../../source_7niu//2016070411@3x.png">' + msg + '</div></div>');
	$('.popoverer').css('margin-top', -$('.popoverer').height() / 2 + 'px');
	setInterval(function() {
		$('.popoverer').animate({
			opacity: '0'
		}, 1000, 'linear', function() {
			$('.modal').remove();
		});
	}, 2000);
}

var user_id = localUserInfo.user_id;// getCookie("identity_new");
//token = "c78c4b48-e81e-4fd6-9010-0b3775113430";
MALE = "MALE",
	FEMALE = "FEMALE",
	sexName = null;
var emailReg = /^([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$/;
if(localStorage.sexName == null) {
	sexName = MALE;
} else {
	sexName = localStorage.sexName;
}
var cityItem = localStorage.getItem("city") || '';
if(cityItem != null) {
	city_id = cityItem.split(":")[0];
	city_name = cityItem.split(":")[1];
}
// 写cookies
function setCookie(name, value, days) {
	var Days = days;
	var exp = new Date();
	exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
	document.cookie = name + "=" + encodeURIComponent(value) + ";expires=" + exp.toGMTString() + ";path=/";
}

// 读取cookies
function getCookie(name) {
	var arr, reg = new RegExp("(^| )" + name + "=([^;]*)(;|$)");
	if (arr = document.cookie.match(reg))
	    return unescape(arr[2]);
	else {
	    if (name == 'identity_new' && window.location.toString().indexOf('http://localhost') != -1)//zlg测试的时候
	        return 'c78c4b48-e81e-4fd6-9010-0b3775113430';
	    return null;
	}
}

//清除cookie
function clearCookie() {
	setCookie("identity_new", "", -1);
	local_delete("identity_new");
}

function isEmpty(value) { //判空
	if(value == null || value == undefined || value == '' || value == 'null' || value == 'undefined') {
		return true;
	}
	return false;
}
//分析url参数
function getQueryString(name) {
	var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
	var r = window.location.search.substr(1).match(reg);
	if(r != null)
		return unescape(r[2]);
	return null;
}
var jsonp = (function() {
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
//jsonp.set("haha", jsonD);
//alert(jsonp.get("haha"));
//jsonp.remove("haha");

function searchParam(par) { //获取地址栏参数
	var param = {};
	if(isEmpty(par)) {
		return param;
	} else {
		if(par.indexOf("?") != -1) {
			par = par.substring(1, par.length);
		}
		var array = par.split("&");
		for(var i = 0; i < array.length; i++) {
			var array2 = new Array();
			var ss = array[i].toString();
			array2[0] = ss.substring(0, array[i].indexOf("="));
			array2[1] = array[i].substring(array[i].indexOf("=") + 1, array[i].length);
			param[array2[0]] = array2[1];
		}
		return param;
	}
}

function hashParam(par) { //获取地址栏#号后面的参数
	var param = {};
	if(isEmpty(par)) {
		return param;
	} else {
		if(par.indexOf("#") != -1) {
			par = par.substring(1, par.length);
		}
		var array = par.split("&");
		for(var i = 0; i < array.length; i++) {
			var array2 = new Array();
			var ss = array[i].toString();
			array2[0] = ss.substring(0, array[i].indexOf("="));
			array2[1] = array[i].substring(array[i].indexOf("=") + 1, array[i].length);
			param[array2[0]] = array2[1];
		}
		return param;
	}
}

//显示模态
function showModalTang(cla) {
	$('#modalBackground').removeClass('hide');
	$("." + cla).removeClass('hide');
}

//隐藏模态
function hideModalTang(cla) {
	$('#modalBackground').addClass('hide');
	$("." + cla).addClass('hide');
}

//function guanjian() { //获取搜索关键字
//	var data = {};
//	postAjax('/keywords/random', data).then(function(data) {
//		var success = data.success;
//		if(success) {
//			var jData = data.data;
//			console.log(jData);
//			$("#search").attr("placeholder", jData.keywords);
//		} else {
//			alert(data.errMsg);
//		}
//	});
//}

//芝麻信用链接
//帮粉币链接

//下载提示start
//function downLoad() {
//	if (isAndroid) {
//		myhref.href = 'http://at.umeng.com/iSz0Hb';
//	} else if(isIos()){
//		myhref.href = 'http://at.umeng.com/yKvO9r';
//	}
//}

var _hmt = _hmt || [];
(function() {
	var hm = document.createElement("script");
	hm.src = "//hm.baidu.com/hm.js?6f4263b4de0dabb5617085bbee488029";
	var s = document.getElementsByTagName("script")[0];
	s.parentNode.insertBefore(hm, s);
})();

window.bughd = window.bughd || function() {};
bughd("create", {
	key: "f1e773ade455d649d3e660085cad5c30"
})

function GetDateStr(AddDayCount) {
	var dd = new Date();
	dd.setDate(dd.getDate() + AddDayCount); //获取AddDayCount天后的日期 
	var y = dd.getFullYear();
	var m = dd.getMonth() + 1; //获取当前月份的日期 
	var d = dd.getDate();
	if(m < 10) {
		m = "0" + m;
	}
	if(d < 10) {
		d = "0" + d;
	}
	return y + "-" + m + "-" + d;
}
//document.write("前天："+GetDateStr(-2)); 
//document.write("<br />昨天："+GetDateStr(-1)); 
//document.write("<br />今天："+GetDateStr(0)); 
//document.write("<br />明天："+GetDateStr(1)); 
//document.write("<br />后天："+GetDateStr(2)); 
//document.write("<br />大后天："+GetDateStr(3)); 

function miaoToSFM(m) {
	var dateTimes = new Array();
	var s = m / 60 / 60;
	s = parseInt(s);
	dateTimes[0] = s;
	var fenM = m - (s * 60 * 60);
	if(fen != 0) {
		var fen = parseInt((fenM / 60));
		if(fen == 0) {
			dateTimes[1] = 0;
			dateTimes[2] = fenM;
		} else {
			fen = parseInt(fen);
			dateTimes[1] = fen;
			var m = fenM - (fen * 60);
			dateTimes[2] = m;
		}
	} else {
		dateTimes[1] = 0;
		dateTimes[2] = 0;
	}
	return dateTimes;
}

function miaoToDSFM(m) {
	var dateTimes = new Array();
	var SFM = miaoToSFM(m);
	var miaoToSFMS = SFM[0];
	var days = parseInt((miaoToSFMS / 24));
	dateTimes[0] = days;
	dateTimes[1] = miaoToSFMS - (days * 24);
	dateTimes[2] = SFM[1];
	dateTimes[3] = SFM[2];
	dateTimes[4] = miaoToSFMS;
	return dateTimes;
}

function Timersertim(intDiff) { //倒计时方法
	window.setInterval(function() {
		var day = 0,
			hour = 0,
			AllHour = 0,
			minute = 0,
			second = 0; //时间默认值		
		if(intDiff > 0) {
			day = Math.floor(intDiff / (60 * 60 * 24));
			hour = Math.floor(intDiff / (60 * 60)) - (day * 24);
			AllHour = Math.floor(intDiff / (60 * 60));
			minute = Math.floor(intDiff / 60) - (day * 24 * 60) - (hour * 60);
			second = Math.floor(intDiff) - (day * 24 * 60 * 60) - (hour * 60 * 60) - (minute * 60);
		}
		if(AllHour <= 9) AllHour = '0' + AllHour;
		if(minute <= 9) minute = '0' + minute;
		if(second <= 9) second = '0' + second;
		//			$('#day_show').html(day+"天");
		$('.hours').text(AllHour);
		$('.minutes').text(minute);
		$('.seconds').text(second);
		intDiff--;
	}, 1000);
}

function NoToChinese(num) { //阿拉伯数字切换成中文
	if(!/^\d*(\.\d*)?$/.test(num)) { alert("Number is wrong!"); return "Number is wrong!"; }
	var AA = new Array("零", "一", "二", "三", "四", "五", "六", "七", "八", "九");
	var BB = new Array("", "拾", "佰", "仟", "萬", "億", "点", "");
	var a = ("" + num).replace(/(^0*)/g, "").split("."),
		k = 0,
		re = "";
	for(var i = a[0].length - 1; i >= 0; i--) {
		switch(k) {
			case 0:
				re = BB[7] + re;
				break;
			case 4:
				if(!new RegExp("0{4}\\d{" + (a[0].length - i - 1) + "}$").test(a[0]))
					re = BB[4] + re;
				break;
			case 8:
				re = BB[5] + re;
				BB[7] = BB[5];
				k = 0;
				break;
		}
		if(k % 4 == 2 && a[0].charAt(i + 2) != 0 && a[0].charAt(i + 1) == 0) re = AA[0] + re;
		if(a[0].charAt(i) != 0) re = AA[a[0].charAt(i)] + BB[k % 4] + re;
		k++;
	}

	if(a.length > 1) //加上小数部分(如果有小数部分) 
	{
		re += BB[6];
		for(var i = 0; i < a[1].length; i++) re += AA[a[1].charAt(i)];
	}
	return re;
}

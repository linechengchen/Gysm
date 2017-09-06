
var transJsonToQuery, localSchoolInfo, localUserInfo, localCityInfo;

//获取本地学校信息
function getLocalSchoolInfo() {
    var schoolinfo = {
        sc_id: "",
        sc_name: "",
        school_id: "",
        school_name: "",
        department_id: "",
        department_name: ""
    }
    if (!schoolinfo.school_id) {
        if (window.localStorage) {
            schoolinfo.sc_id = localStorage.getItem("sc_id") || '';
            schoolinfo.sc_name = localStorage.getItem("sc_name") || '';
            schoolinfo.school_id = localStorage.getItem("school_id") || '';
            schoolinfo.school_name = localStorage.getItem("school_name") || '';
            schoolinfo.department_id = localStorage.getItem("department_id") || '';
            schoolinfo.department_name = localStorage.getItem("department_name") || '';
        }
    }
    return schoolinfo;
}
//获取本地城市信息
function getLocalCityInfo() {
    var cityinfo = {
        city_id: "",
        city_name: "",
        latitude: "",
        longitude: "",
        address: ""
    }
    if (!cityinfo.city_id) {
        if (window.localStorage) {
            cityinfo.city_id = localStorage.getItem("city_id") || '';
            cityinfo.city_name = localStorage.getItem("city_name") || '';
            cityinfo.latitude = localStorage.getItem("latitude") || '';
            cityinfo.longitude = localStorage.getItem("longitude") || '';
        }
    }
    return cityinfo;
}
//获取本地用户信息
function getLocalUserInfo() {
    var userinfo = {
        user_id: "",
        token: "",
        openid: "",
        unionid: "",
        phone_number: "",
        source1: "",

        sc: "",
        sc_id: "",
        city_id: "",
        city_name: "",
        school_name: "",
        school_id: "",
        department_name: "",
        department_id: "",
    }
    if (!userinfo.user_id) {
        if (window.localStorage) {
            userinfo.user_id = localStorage.getItem("user_id") || '';
            userinfo.token = localStorage.getItem("token") || '';
            userinfo.openid = localStorage.getItem("openid") || '';
            userinfo.unionid = localStorage.getItem("unionid") || '';
            userinfo.phone_number = localStorage.getItem("phone_number") || '';
            userinfo.source1 = localStorage.getItem("source1") || '';
            
            userinfo.sc = localStorage.getItem("sc") || '';
            userinfo.sc_id = localStorage.getItem("sc_id") || '';
            userinfo.city_id = localStorage.getItem("city_id") || '';
            userinfo.city_name = localStorage.getItem("city_name") || '';
            userinfo.school_name = localStorage.getItem("school_name") || '';
            userinfo.school_id = localStorage.getItem("school_id") || '';
            userinfo.department_name = localStorage.getItem("department_name") || '';
            userinfo.department_id = localStorage.getItem("department_id") || '';
        }
    }
    if (!userinfo.token) userinfo.token = getCookie("identity_new"); return userinfo;
}
// 配置项
console_log("系统" + app_path1 + "，登录信息-用户-城市-学校"); console_log(localUserInfo = getLocalUserInfo());
console_log(localCityInfo = getLocalCityInfo()); console_log(localSchoolInfo = getLocalSchoolInfo());
console_log(cookieObj = getCookieObj());
if (cookieObj && cookieObj.wx1) {
    alert(cookieObj.wx1);
    clearCookie("wx1");
}
//if (cookieObj && localUserInfo && localUserInfo.openid != cookieObj.openid)
//    localUserInfo.openid = cookieObj.openid;

//if (cookieObj.isLogin)
{
    console.warn('刚刚登录！');
    if (!localUserInfo.user_id && cookieObj.user_id)
        localUserInfo.user_id = cookieObj.user_id;
    if (!localUserInfo.openid && cookieObj.openid)
        localUserInfo.openid = cookieObj.openid;
    if (!localUserInfo.unionid && cookieObj.unionid)
        localUserInfo.unionid = cookieObj.unionid;
    if (!localUserInfo.source1 && cookieObj.source1)
        localUserInfo.source1 = cookieObj.source1;
}
//http://stbd.aibangxs.com/site_common/Json_common/r.aspx
var isWaiBao = true;

var authUrl = "http://stbd.aibangxs.com/site_common/Json_common/auth";//"http://auth.qtshe.com
var rootUrl = "http://stbd.aibangxs.com/site_" + app_path1;
var baseUrlJson = "http://stbd.aibangxs.com/site_" + app_path1 + "/Json_" + app_path1;
var baseUrlUser = baseUrlJson.replace(app_path1, "common").replace(app_path1, "common");
var baseUrlCommon = baseUrlUser;
var baseUrlHtml = "..";//app/shuati
var baseUrlHtml2 = "http://stbd.aibangxs.com/site_" + app_path1 + "/app/" + app_path1 ;//服务器路径地址  腾讯微信跳转ReadiuRl
var contentType = 'application/octet-stream';
//'use strict'
var imgSiteUrl = "http://stbd.aibangxs.com/site_" + app_path1 + "/app_image/";
var siteUrlJson = baseUrlJson + '/';
var indexPageUrl;
var isDebug = false;
var isNeice = false;
var isApp = false;
var params = {};
var useragent = navigator.userAgent; var isWeixin = false; var isMobile = false;//微信
if (useragent.match(/MicroMessenger/i) == 'MicroMessenger') isWeixin = true;
if (useragent.indexOf('QQBrowser') != -1 && (useragent.indexOf('Android') != -1 || useragent.indexOf('iPhone') != -1)) isMobile = true;

//url参数处理
var isNull = function (obj1) {
    if (!obj1 || obj1 == null || obj1 == undefined || obj1 == '' || obj1 == 'null' || obj1 == 'undefined')
        return true; return false;
}
var isEmpty = function (value) { return isNull(value); }
var isNotNull = function (obj1) { return !isNull(obj1); }
// 转化query格式为 Json格式
var getParseQuery = function () {
    var reg = /([^=&\s]+)[=\s]*([^=&\s]*)/g;
    var obj = {};
    while (reg.exec(location.search.replace('?', ''))) {//正则表达式匹配，不断遍历，获得两个匹配项
        if (isNotNull(RegExp.$2)) {
            obj[RegExp.$1] = RegExp.$2;
        }
    }
    return obj;
}
var LocString = String(window.document.location.href);
function getQueryStr(str) {
    var rs = new RegExp("(^|)" + str + "=([^&]*)(&|$)", "gi").exec(LocString), tmp;
    if (tmp = rs) {
        return tmp[2];
    }
    return "";
}
params = getParseQuery();

//zlg
if (params.source1) {
    localUserInfo.source1 = params.source1;
    localStorage.setItem("source1", params.source1);
} else if (localUserInfo.source1)
    params.source1 = localUserInfo.source1;

if (params.sc != "999") {
    localUserInfo.sc = params.sc;
    localStorage.setItem("sc", params.sc);
} else if (localUserInfo.sc)
    params.sc = localUserInfo.sc;
else if (localSchoolInfo.sc_id)
    params.sc = localSchoolInfo.sc_id;

if (params.app_path1) app_path1 = params.app_path1;
//app跑这里

//window.onerror = function (sMsg, sUrl, sLine) {
//    if (sUrl.indexOf("mui") == -1 && sUrl.indexOf("jquery") == -1)
//        alert("意外情况，请帮忙截图给爱帮女生，谢谢您：\n" + sMsg + "=" + sUrl + "=" + sLine); return true;
//}

if (window.location.href.indexOf('file:///storage/') != -1) {
    isNeice = true;
    isApp = true;
}
else if (window.location.host == "stbd.javalong.com" || window.location.host == "stbd.aibangxs.com" || window.location.host == "stbd.aibangxs.com") {
    isDebug = false;
    baseUrlJson = "http://" + window.location.host + "/site_" + app_path1 + "/Json_" + app_path1;// api地址
    baseUrlHtml = "http://" + window.location.host + "/site_" + app_path1 + "/app/" + app_path1;// 项目地址，也用于editCookie
}
else if (!isWaiBao && window.location.href.indexOf("localhost") != -1 || window.location.href.indexOf("127.0.0.1") != -1 || window.location.href.indexOf("192.168.") != -1 || window.location.href.indexOf("10.128.") != -1 || window.location.href.indexOf("fuwuqicch") != -1) {
    isNeice = true;
    isDebug = true;
    var host1 = window.location.host + "/site_" + app_path1 + "";
    if (window.location.host.indexOf("localhost:") != -1)
        host1 = window.location.host;

    baseUrlJson = "http://" + host1 + "/Json_" + app_path1;
    alertr(baseUrlJson)
    baseUrlHtml = "http://" + host1 + "/app/" + app_path1;
}
else if (isWaiBao == false) {
    if (window.location.href.indexOf("neice=1") == -1) {
        // 对浏览器的UserAgent进行正则匹配，不含有微信独有标识的则为其他浏览器
        var useragent = navigator.userAgent;
        //微信
        if (!isWeixin && !isMobile) {
            // 这里警告框会阻塞当前页面继续加载
            alert('您需要使用微信浏览器访问本页面，才能获得完整功能');
            // 以下代码是用javascript强行关闭当前页面
            var opened = window.open('about:blank', '_self');
            opened.opener = null;
            opened.close();
        }
    }
}
baseUrlHtml = baseUrlHtml.replace("/common/", "/" + app_path1 + "/");
var baseUrlHtmlLong = baseUrlHtml; baseUrlUser = baseUrlJson.replace(app_path1, "common").replace(app_path1, "common");
baseUrlCommon = baseUrlUser; var baseUrlWish = baseUrlJson; siteUrlJson = baseUrlJson + '/'; console_log("页面Json地址=" + baseUrlJson);
//baseUrlHtml = ".."; 
//zlg测试用
if (window.location.href.indexOf("/site_shuati2/".replace("shuati", app_path1)) != -1) {
    rootUrl = rootUrl.replace("/site_shuati".replace("shuati", app_path1), "/site_shuati2".replace("shuati", app_path1));
    baseUrlJson = baseUrlJson.replace("/site_shuati/".replace("shuati", app_path1), "/site_shuati2/".replace("shuati", app_path1));
    baseUrlUser = baseUrlUser.replace("/site_shuati/".replace("shuati", app_path1), "/site_shuati2/".replace("shuati", app_path1));
    baseUrlCommon = baseUrlCommon.replace("/site_shuati/".replace("shuati", app_path1), "/site_shuati2/".replace("shuati", app_path1));
    baseUrlHtml = baseUrlHtml.replace("/site_shuati/".replace("shuati", app_path1), "/site_shuati2/".replace("shuati", app_path1));
    baseUrlHtml2 = baseUrlHtml2.replace("/site_shuati/".replace("shuati", app_path1), "/site_shuati2/".replace("shuati", app_path1));
    siteUrlJson = siteUrlJson.replace("/site_shuati/".replace("shuati", app_path1), "/site_shuati2/".replace("shuati", app_path1));
    baseUrlHtmlLong = baseUrlHtmlLong.replace("/site_shuati/".replace("shuati", app_path1), "/site_shuati2/".replace("shuati", app_path1));
}
if (params.openid && !localUserInfo.openid) {
    localStorage.setItem("openid", params.openid);
    localUserInfo.openid = params.openid;
}

console_log('baseUrlJson ' + baseUrlJson)
console_log('baseUrlUser ' + baseUrlUser)

console_log("页面地址location=" + window.location.href);

var siteRootUrl = siteUrlJson.replace("/json_shuati/".replace("shuati", app_path1), "");
indexPageUrl = "kemuIndex.html";

console_log("页面Json地址=" + siteUrlJson);

// 转化Json格式为 query格式  ex: {name:'zhucx',id: '1'}  => name=zhucx&id=1
transJsonToQuery = function (obj, noName) {
    var str = '';
    for (var name in obj) {
        if (('' + obj[name]) == '[object Object]')
            continue;
        if (!obj[name] || obj[name] == undefined || obj[name] == '')
            continue;
        if (isNotNull(noName) && name == noName)
            continue;
        str += name + "=" + obj[name] + "&";
    }
    str = str.substring(0, str.length - 1);
    //console_log(str);
    return str
};
//end url参数处理
// 写cookies
function setCookie(name, value, days) {
    var Days = days;
    var exp = new Date();
    exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
    document.cookie = name + "=" + encodeURIComponent(value) + ";expires=" + exp.toGMTString() + ";path=/";
}
//清除cookie    
function clearCookie(name) {
    setCookie(name, "", -1);
}

if (isNeice) { params.neice = '1'; } if (params.zhengshi) { isDebug = false; }

//读取次数
var cishu = function () {
    var cishu1 = 0;
    cishu1 = window.localStorage.getItem('cishu1');
    if (isNaN(cishu1)) cishu1 = 0;
    if (isNull(cishu1)) {
        cishu1 = 0;
    }
    cishu1++;
    localStorage.setItem('cishu1', cishu1);
    console_log('次数:' + cishu1);//这里输出的
    return cishu1;
}
cishu();
//次数和转发设置
function checkInZF() {
    try {
        if (isApp) return;
        var wxmsg = "";
        setLocal("checkInZF_url", window.location.href);
        fetchwx(params, function (json) {
            try {
                if (isNotNull(json)) {//.code == '200'
                    if (params.neice == '1') {
                        //mui.toast(json.type1 + ',' + json.trans + ',' + params.source1);
                    }
                    var href_1 = getLocal("checkInZF_url").toLowerCase();
                    if (href_1 && href_1.indexOf("Json_") != -1)
                        return;

                    if (window.location.href.indexOf("localhost") == -1 && window.location.href.indexOf("127.0.0.1:") == -1) {
                        if (json.trans == '0') {//
                            if (href_1.indexOf('?') == -1)
                                href_1 = href_1 + "?"
                            href_1 = href_1 + '&type1=' + json.type1 + '&source1=' + params.source1;
                            //alert(href_1)
                            //myhref.href = href_1;
                        }
                        else if (json.trans == '1') {//findme
                            var href_1 = href_1.toLowerCase().replace("kemuindex.html", "findme.html");
                            var href_1 = href_1.toLowerCase().replace("indexpage1_shuati.html", "findme.html");
                            if (href_1.indexOf('?') == -1)
                                href_1 = href_1 + "?"

                            href_1 = rootUrl + "/app/" + app_path1 + "/pages/findme.html?sc=" + params.sc;
                            location.href = href_1 + '&trans=' + json.trans + '&source1=' + params.source1;
                        }
                        else if (json.trans == '3') {//findme
                            var href_1 = href_1.toLowerCase().replace("kemuindex.html", "findme.html");
                            var href_1 = href_1.toLowerCase().replace("indexpage1_shuati.html", "findme.html");
                            var href_1 = href_1.toLowerCase().replace("indexpage1_" + app_path1 + ".html", "findme.html");
                            var href_1 = href_1.toLowerCase().replace(app_path1 + ".html", "findme.html");
                            if (href_1.indexOf('?') == -1)
                                href_1 = href_1 + "?"

                            href_1 = rootUrl + "/app/" + app_path1 + "/pages/findme.html?sc=" + params.sc;
                            //
                            if (isNull(params.neice)) {
                                if (isShowFindMe(params.sc)) {
                                    location.href = href_1 + '&trans=' + json.trans + '&source1=' + params.source1;
                                }
                            }
                        }
                        else if (json.trans == '8') {

                        }
                        params.trans = json.trans;
                        //document.getElementById('a1').innerText = document.getElementById('a1').innerText + json.trans + json.cache;
                        //mui.toast(json.trans);
                    }
                    //if (params.trans) {
                    if (cishu() == 3) {
                        //if (sc1 == '999')
                        mui.toast('2017全新云架构，祝小伙伴们事事顺利！帮我们多推荐一下。\r\n错题库云存储为您保留永久备份\r\n邀请热心小伙伴们完善大学所有题库！');
                        // + json.trans + '\r\n'
                        //mui.toast('邀请热心大侠，提供题库给学弟学妹们。2017云架构，终于可以流畅刷题');
                    }
                    //}
                }
            } catch (e) { console.error(e); }
        });
    }
    catch (e) { console.error(e); }
}

//利用guid或者UTC时间临时作为ID值
function guid() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
        var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
        return v.toString(16);
    });
}
function getUtc() {
    var d = new Date();
    return Date.UTC(d.getFullYear()
        , d.getMonth()
        , d.getDate()
        , d.getHours()
        , d.getMinutes()
        , d.getSeconds()
        , d.getMilliseconds());
}
function uuid() {
    var s = [];
    var hexDigits = "0123456789abcdef";
    for (var i = 0; i < 36; i++) {
        s[i] = hexDigits.substr(Math.floor(Math.random() * 0x10), 1);
    }
    s[14] = "4";  // bits 12-15 of the time_hi_and_version field to 0010
    s[19] = hexDigits.substr((s[19] & 0x3) | 0x8, 1);  // bits 6-7 of the clock_seq_hi_and_reserved to 01
    s[8] = s[13] = s[18] = s[23] = "-";

    var uuid = s.join("");
    return uuid;
}
var isShowFindMe = function (sc) {
    //if ('787||'.indexOf(sc) == -1)
    if (cishu() > 3) {
        //几点之后，需要找我
        var hour1 = new Date().getHours();
        var minu1 = new Date().getMinutes();//(hour1 == 8 && minu1 >= 45 && minu1 <= 50) || 
        if ((hour1 == 8 && minu1 == 80) || (hour1 == 9 && minu1 == 80) || (hour1 >= 11 && hour1 <= 24)) {
            return true;
        }
    }
    return false;
};
var isShowGuanZhu = function (sc) {
    //if ('787||'.indexOf(sc) == -1)
    if (cishu() > 8) {
        //几点之后，需要关注
        var hour1 = new Date().getHours();
        if ((hour1 >= 8 && hour1 <= 22) || (hour1 >= 22 && hour1 <= 24)) {
            return true;
        }
    }
    return false;
};

var fetchwx, GetUpdateMsgTimer, fetchRedis, GetUpdateMsg, postAjaxMUI;

try {
    //  ========== 
    //  = 依赖mui document 方法 = 
    //  ========== 
    (function ($, doc) {
        //postAjaxMUI(siteUrlJson + 'PostTUserZsInfo.aspx', data, "post", callback);
        //postAjaxMUI(siteUrlJson + 'PostTUserZsInfo.aspx', data, "get", callback);
        postAjaxMUI = function (url, data, type1, callback) {
            try {
                data = data || {};
                if (!type1) type1 = 'post';//"get"
                var url1 = url.replace(siteUrlJson, '');
                var dataStr = transJsonToQuery(data);
                if (dataStr.length < 100) {
                    console_log("请求JSON-Url:" + url + "?" + dataStr);
                    //console_log("请求参数:");
                    //console_log(dataStr);
                }
                else {
                    console_log("请求参数长度:" + dataStr.length);
                }

                var urlKey = url1 + ((dataStr.length < 100) ? dataStr : dataStr.length);
                //var ajax1 = getSession(urlKey); if (ajax1) return callback && callback(ajax1);
                //第二种方法是
                //var p = new promise.Promise();
                try {
                    var ajax = mui.ajax(url, {
                        data: data,//用dataStr还是data没影响
                        dataType: 'text',//因为加密需要
                        type: type1, //HTTP请求类型
                        timeout: 10000, //超时时间设置为10秒；
                        //不能加下面  不然需要流的方式获取数据，不能用request
                        //headers: {
                        //    'Content-Type': 'application/json'
                        //},
                        success: function (data) {
                            //p.done(data);
                            if (data && data.length < 100)
                                console_log(data);
                            data = de1(data);
                            if (type1.toLowerCase() != 'post') {
                                if (data.code && data.code == 200 && data.data)
                                    setSession(urlKey, data);
                            }
                            callback && callback(data);
                        },
                    });
                } catch (e) { console.error('错误1008' + e); alert(e.message); }
                //return p;
                return ajax;
            } catch (e) { console.error(e); alert(e.message); }
        }
        //获取微信信息
        fetchwx = function (options, callback) {
            postAjaxMUI('http://stbd.aibangxs.com/wx/wx.aspx', options, "get", callback);
        };
        //获取微信信息
        fetchRedis = function (options, callback) {
            postAjaxMUI(baseUrlCommon + '/r.aspx', options, "post", callback);
        };

        GetUpdateMsgTimer = function (options) {
            options = options || {};
            window.setTimeout(function () {
                fetchRedis(options);
            }, 6000);
            window.setTimeout(function () {
                GetUpdateMsg(options);
            }, 5000);
            window.setInterval(function () {
                GetUpdateMsg(options);
            }, 60000);
        };
        //获取系统升级消息
        GetUpdateMsg = function (options) {
            options = options || {};
            try {
                console_log(".9999999999999=" + options.trans);
                if (isShowFindMe(options.sc) && options.trans == "3") {
                    var href_1 = rootUrl + "/app/" + app_path1 + "/pages/findme.html?1=1";//"http://stbd.aibangxs.com/site_shuati/app/";
                    myhref.href = href_1 + '&trans=' + options.trans + '&source1=' + params.source1;
                }
            } catch (e) {
                console_log(e);
            }
            var data1 = transJsonToQuery(options);
            console_log('GetUpdateMsg获取系统升级消息')
            mui.ajax(baseUrlCommon + '/GetUpdateMsg.aspx', {
                data: data1,
                dataType: 'json',
                type: 'get', //HTTP请求类型
                timeout: 20000, //超时时间设置为10秒；
                headers: {
                    'Content-Type': 'application/json'
                },
                success: function (json) {
                    console_log(json);
                    if (isNotNull(json) && isNotNull(json.updateMsg)) {
                        var updateMsg1 = window.localStorage.getItem('GetUpdateMsg');
                        if (json.updateMsg != updateMsg1) {
                            mui.toast(json.updateMsg);
                            localStorage.setItem('GetUpdateMsg', json.updateMsg);
                        }
                    }
                },
            });
        };
    }(mui, document));
}
catch (e) { console_log(e); }

function isLetter(str) {
    if (/^[A-Za-z]+$/.test(str)) {
        return true;
    } else {
        return false;
    }
}
function isZi(str) {
    if (/^[\u4e00-\u9fa5]+$/.test(str)) {
        return true;
    } else {
        return false;
    }
}
function isLetterOrZi(str) {
    if (/^[A-Za-z\u4e00-\u9fa5]+$/.test(str)) {
        return true;
    } else {
        return false;
    }
}
function de1(s1) {
    try {
        //if (typeof s1 === 'object')
        //    return s1;
        var reg = new RegExp("^copyright");
        if (!reg.test(s1)) {
            if (typeof s1 === 'string') {
                //return JSON && JSON.parse(str);
                return JSON.parse(s1);//eval("(" + s1 + ")");
                //console_log("s1值");
                //console_log(s1);
            } else
                return s1;
        }
        var ret = "";
        for (var i = 9; i < s1.length; i++) {
            var c2 = s1[i];
            var c = s1.charCodeAt(i);
            switch (c2) {
                case '`':
                    ret += '{';
                    break;
                case 'É':
                    ret += '}';
                    break;
                case 'ò':
                    ret += ':';
                    break;
                default:
                    if (isLetterOrZi(c2)) {//isLetter(c2) || isZi(c2)) {
                        var newChar = (((c - 3))) & 65535;;//(((c - 3)  0)) & 65535;
                        var new2 = String.fromCharCode(newChar);
                        if (!isLetterOrZi(new2)) {//(!isLetter(new2) && !isZi(new2)) {
                            newChar = (newChar + (26)) & 65535;
                            ret += String.fromCharCode(newChar);
                        } else
                            ret += new2;
                    }
                    else {
                        ret += c2;//String.fromCharCode(c);
                    }
                    break;
            }
        }
        return JSON.parse(ret);//eval("(" + ret + ")");
    } catch (e) { console.error(e.toString()); console.error(s1); }
    return s1;
}

//localstorage.js  
//csdn常用js操作//整理by 
//localStorage支持的默认空间大小为5M  需要注意的是在手机上使用的时候需要后台开辟内存空间支持才行。
//localStorage存数的数据是不能跨浏览器共用的，一个浏览器只能读取各自浏览器的数据,储存空间5M。
var setLocal = function (key, value) {
    try {
        if (arguments.length === 2) {
            var v = value;
            if (typeof v == 'object') {
                v = JSON.stringify(v);
                v = 'obj-' + v;
            } else {
                v = 'str-' + v;
            }
            var ls = window.localStorage;
            if (ls) {
                //建议使用removeItem zlg
                //ls.removeItem(key);
                ls.setItem(key, v);
            }
        }
    } catch (e) {
        //解决方法是在setItem之前先removeItem()。
        //相信原生方法的原则应尽量使用原生的方法来操作localStorage
        //"QUOTA_EXCEEDED_ERR”"是一个异常，如果你使用的存储容量超过了限度（5M）就会报这个异常
        alert('缓存空间不足' + e);
        var 剩余空间 = 1024 * 1024 * 5 - unescape(encodeURIComponent(JSON.stringify(localStorage))).length;
        alert('local剩余空间:' + 剩余空间 + ',截图反馈客服,谢谢您');
        if (e.name.indexOf('QuotaExceededError') != -1)
            removeLocal(key);
    }
};
var removeLocal = function (key) {
    try {
        if (arguments.length > 0) {
            var ls = window.localStorage;
            if (ls) {
                //建议使用removeItem zlg
                //ls.removeItem(key);
                ls.removeItem(key);
            }
        }
    } catch (e) {
        //解决方法是在setItem之前先removeItem()。
        //相信原生方法的原则应尽量使用原生的方法来操作localStorage
        //"QUOTA_EXCEEDED_ERR”"是一个异常，如果你使用的存储容量超过了限度（5M）就会报这个异常
        console_log(e);
    }
};

//var fengegelishi = function (value) {
//    return value.split("|");

//}
var getLocal = function (key) {
    //console_log(key);
    var ls = window.localStorage;
    if (ls) {
        var v = ls.getItem(key);
        //console_log(v);
        if (!v) {
            //console_log(v);
            return null;
        }
        if (v.indexOf('obj-') === 0) {
            v = v.slice(4);
            //console_log(v);
            var jsonObj1 = JSON.parse(v); return jsonObj1;
        } else if (v.indexOf('str-') === 0) {
            //console_log(v);
            return v.slice(4);
        }
    }
};
var setSession = function (key, value) {
    try {
        if (!value) return;
        if (arguments.length === 2) {
            var v = value;
            if (typeof v == 'object') {
                v = JSON.stringify(v);
                v = 'obj-' + v;
            } else {
                v = 'str-' + v;
            }
            var ls = window.sessionStorage;
            if (ls) {
                //建议使用removeItem zlg
                //ls.removeItem(key);
                ls.setItem(key, v);
            }
        }
    } catch (e) {
        //解决方法是在setItem之前先removeItem()。
        //相信原生方法的原则应尽量使用原生的方法来操作localStorage
        //"QUOTA_EXCEEDED_ERR”QuotaExceededError"是一个异常，如果你使用的存储容量超过了限度（5M）就会报这个异常QuotaExceededError
        alert('临时缓存空间不足'+e);
        var 剩余空间 = 1024 * 1024 * 5 - unescape(encodeURIComponent(JSON.stringify(sessionStorage))).length;
        console_log('sessionStorage剩余空间:' + 剩余空间);
        if (e.name.indexOf('QuotaExceededError') != -1)
            sessionStorage.clear();
    }
};
var removeSession = function (key) {
    try {
        if (arguments.length === 2) {
            var ls = window.sessionStorage;
            if (ls) {
                //建议使用removeItem zlg
                //ls.removeItem(key);
                ls.removeItem(key);
            }
        }
    } catch (e) {
        //解决方法是在setItem之前先removeItem()。
        //相信原生方法的原则应尽量使用原生的方法来操作localStorage
        //"QUOTA_EXCEEDED_ERR”"是一个异常，如果你使用的存储容量超过了限度（5M）就会报这个异常
        console_log(e);
    }
};
var getSession = function (key) {
    if (params.neice == '1' || window.location.href.indexOf('localhost') != -1)
        return null;
    //console_log(key);
    var ls = window.sessionStorage;
    if (ls) {
        var v = ls.getItem(key);
        //console_log(v);
        if (!v) {
            //console_log(v);
            return null;
        }
        if (v.indexOf('obj-') === 0) {
            v = v.slice(4);
            //console_log(v);
            return JSON.parse(v);
        } else if (v.indexOf('str-') === 0) {
            //console_log(v);
            return v.slice(4);
        }
    }
};
////window.localStorage
//var Storage = function () {
//    return window.localStorage;
//};

var isAndroid = (/android/gi).test(navigator.appVersion);

//ajax_xs.js

//zlg
function getCookieObj() {
    var cookie = document.cookie,
    cookieObj = {};
    var cstr = "";
    if (cookie || (document.cookie = "Token=2", document.cookie = "isLogin=false"), cookie) {
        var arr = cookie.split("; ");
        arr.length || (arr = cookie.split(";"));
        for (var i = 0,
        length = arr.length; i < length; i++) {
            var _arr = arr[i].split("=");
            cookieObj[_arr[0]] = _arr[1];
            cstr += _arr[0] + '=' + _arr[1] + '  |  ';
        }
    }
    //console_log('注意cookie=' + cstr);
    return cookieObj
}
function console_log(msg1) {
    if (isDebug || isNeice)
        console.log(msg1);
}
//存储本地城市信息 进入首页，获取定位数据
function setLocalCityInfo(cid, cname, latitude, longitude) {
    //add zlg永久存储 modify cch
    if (window.localStorage) {
        if (cid)
            localStorage.setItem("city_id", cid);
        if (cname)
            localStorage.setItem("city_name", cname);
        if (latitude)
            localStorage.setItem("latitude", latitude);
        if (longitude)
            localStorage.setItem("longitude", longitude);
        console_log('localStorage' + cname);
    }
}
function saveLocalSchoolInfo() {
    if (localSchoolInfo.sc_id)
        localStorage.setItem("sc_id", localSchoolInfo.sc_id);
    if (localSchoolInfo.sc_name)
        localStorage.setItem("sc_name", localSchoolInfo.sc_name);
    if (localSchoolInfo.school_id)
        localStorage.setItem("school_id", localSchoolInfo.school_id);
    if (localSchoolInfo.school_name)
        localStorage.setItem("school_name", localSchoolInfo.school_name);
    if (localSchoolInfo.department_id)
        localStorage.setItem("department_id", localSchoolInfo.department_id);
    if (localSchoolInfo.department_name)
        localStorage.setItem("department_name", localSchoolInfo.department_name);
}
//存储本地城市信息 进入首页，获取定位数据
function setLocalSchoolInfo(sc_id, school_id, school_name, department_id, department_name) {
    //add zlg永久存储 modify cch
    if (window.localStorage) {
        if (sc_id)
            localStorage.setItem("sc_id", sc_id);
        if (school_id)
            localStorage.setItem("school_id", school_id);
        if (school_name)
            localStorage.setItem("school_name", school_name);
        if (department_id)
            localStorage.setItem("department_id", department_id);
        if (department_name)
            localStorage.setItem("department_name", department_name);
        console_log('localStorage:' + school_name);
    }
    localSchoolInfo = getLocalSchoolInfo();
}

//清除学校信息
function clearLocalSchoolInfo() {
    localStorage.removeItem("sc_id");
    localStorage.removeItem("sc_name");
    localStorage.removeItem("school_id");
    localStorage.removeItem("school_name");
    localStorage.removeItem("department_id");
    localStorage.removeItem("department_name");
    localSchoolInfo = getLocalSchoolInfo();
}
function clearLocalCityInfo() {
    localStorage.removeItem("city_id");
    localStorage.removeItem("city_name");
    localStorage.removeItem("latitude");
    localStorage.removeItem("longitude");
    localCityInfo = getLocalCityInfo();
}

function clearLocalUserInfo() {
    localStorage.removeItem("openid");
    localStorage.removeItem("user_id");
    localStorage.removeItem("token");
    localUserInfo = getLocalUserInfo();
}
var localStorageJson
{
    function setItem(key, Obj) {

    }
}


function getCookie(name) {
    var arr, reg = new RegExp("(^| )" + name + "=([^;]*)(;|$)");
    if (arr = document.cookie.match(reg))
        return unescape(arr[2]);
    else
        return null;
}


//设置本地用户信息
function setLocalUserInfo(user_id, token, openid, phone_number, source1) {
    if (window.localStorage) {
        if (user_id)
            localStorage.setItem("user_id", user_id);
        if (openid)
            localStorage.setItem("openid", openid);
        if (unionid)
            localStorage.setItem("unionid", unionid);
        if (phone_number)
            localStorage.setItem("phone_number", phone_number);
        if (token)
            localStorage.setItem("token", token);
        else
            localStorage.setItem("token", user_id);
        if (source1)
            localStorage.setItem("source1", source1);
    }
}


function isBindCloudBook() {
    if (isNotNull(cookieObj.user_id)
        && cookieObj.Token && 2 != cookieObj.Token && cookieObj.isLogin) {
        if (isNull(cookieObj.openid) && isNull(cookieObj.unionid)) return { code: 200, message: '微信未登陆' };
        return { code: 200 };
    } else {
        var ajax = $.ajax({
            //dataType: "json",
            url: baseUrlUser + "/user/check_exist_user.aspx",
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("content-type", "application/json");
                request.setRequestHeader("OriginType", "h5");
                request.setRequestHeader("version", "1.0");
            },
            data: JSON.stringify(data)
        });
        return ajax;
    }
}
// 获取cookie
var currentCityId, currentCityName, token;// localCityInfo, localSchoolInfo, localUserInfo = getLocalUserInfo();
openid = localUserInfo.openid;
unionid = localUserInfo.unionid;
user_id = localUserInfo.user_id;
// 此微信是否绑定过作业云搜账号
var data = { "oper_type": 203, "openid": cookieObj.openid };

//localCityInfo = getLocalCityInfo();
//localSchoolInfo = getLocalSchoolInfo();
//如果url页面包含 Login 之类的参数进入判断
var href9 = location.href.toLowerCase();
if (href9.indexOf('login') == -1 && href9.indexOf('password') == -1
    && href9.indexOf('regist') == -1 && href9.indexOf('indexpage') == -1 && href9.indexOf('kemuindex') == -1
    && href9.indexOf('kemudetaillist.html') == -1 && href9.indexOf('kemu_shuati.html') == -1
    && href9.indexOf('indexPage_searchcitylist.html') == -1
    && href9.indexOf('select') == -1 && href9.indexOf('set.html') == -1
    && href9.indexOf('change.html') == -1 && href9.indexOf('set.html') == -1 && href9.indexOf('kemu_category') == -1
    ) {
    //alert(localUserInfo.user_id)
    if (isNull(localUserInfo.user_id))   //缓存user_id为空 存储网址存在historyUrl 以便跳回，跳登录页        
        if (cookieObj.user_id) localUserInfo.user_id = cookieObj.user_id;
    if (isNull(localUserInfo.openid))
        if (cookieObj.openid) localUserInfo.openid = cookieObj.openid;
    if (isNull(localUserInfo.unionid))
        if (cookieObj.unionid) localUserInfo.unionid = cookieObj.unionid;

    if (!isWaiBao && !isWeixin) {        
        alert(localUserInfo.user_id)
        if (isNull(localUserInfo.user_id)) //isNull(localUserInfo.openid) && 
            location.href = "../pagesCommon/registerNew.html?msg=chooseSchool";
        if (isNull(localSchoolInfo) || isNull(localSchoolInfo.school_id))
            location.href = "../pagesCommon/indexPage_searchcitylist.html?msg=chooseSchool";
    }
    else//是微信
    {
        if (isNull(localUserInfo.openid)) {
            localStorage.setItem("historyUrl", href9), localStorage.setItem("flagUrl", !0);

            location.href = "../pagesCommon/login.html?" + transJsonToQuery(params);
        }
        else if (isNull(localUserInfo.user_id)) {
            //localStorage.setItem("historyUrl", href9), localStorage.setItem("flagUrl", !0);
            //location.href = "../pagesCommon/registerNew.html";
        }
        else if (isNull(localSchoolInfo) || isNull(localSchoolInfo.school_id)) {  //缓存学校或者学校ID为空 存储网址存在historyUrl 以便跳回，跳登录页
            //登录前选择学校
            if (href9.indexOf('indexPage') == -1) {//indexPage_select
                (localStorage.setItem("historyUrl", href9), localStorage.setItem("flagUrl", !0));
                //alert(localSchoolInfo)
                location.href = "../pagesCommon/indexPage_searchcitylist.html?msg=chooseSchool";
            }
        }
    }
}

function isLogin(toHtml, loginHtml, toHtmlParams) {
    myhref.href = toHtml;
}


// webapp用户绑定手机号: 发送验证码
function sendMessageForBindPhone(phone_number) {
    if (!phone_number) return;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/users/webapp_bind.aspx",
        type: "POST",
        data: {
            "phone_number": phone_number
        }
    });
    return ajax;
}
// webapp用户绑定手机号: 检验验证码
function bindPhoneByVerifyCode(phone_number, verifyCode) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/users/bind.aspx",
        type: "POST",
        data: {
            "phone_number": phone_number,
            "verifyCode": verifyCode
        }
    });
    return ajax;
}

// 获取微信分享参数
function getWechatShareConfig(url) {
    console_log(url);
    console_log(baseUrlUser + "/wxshare/jsapi.aspx");
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlUser + "/wxshare/jsapi.aspx",
        data: {
            "url": url
        },
        type: "POST"
    });
    return ajax;
}


// 获取微信分享参数
function getWechatShareConfig(url) {
    console_log(url);
    console_log(baseUrlUser + "/wxshare/jsapi.aspx");
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlUser + "/wxshare/jsapi.aspx",
        data: {
            "url": url
        },
        type: "POST"
    });
    return ajax;
}
function href_long(href) {
    if (!href)
        href = window.location.href;
    if (href.indexOf('?') == -1)
        href += '?';
    if (params.app_path1 && href.indexOf('app_path1') == -1)
        href += '&app_path1=' + params.app_path1;
    if (params.source1 && href.indexOf('source1') == -1)
        href += '&source1=' + params.source1;
    if (params.neice && href.indexOf('neice') == -1)
        href += '&neice=' + params.neice;
    if (params.sc && href.indexOf('sc') == -1)
        href += '&sc=' + params.sc;
    if (params.trans && href.indexOf('trans') == -1)
        href += '&trans=' + params.trans;
    if (params.openid && href.indexOf('openid') == -1)
        href += '&openid=' + params.openid;
    if (params.unionid && href.indexOf('unionid') == -1)
        href += '&unionid=' + params.unionid;
    return href;
}

try {
    $(function () {
        getCurrentCityGPS('#currentCity');

        $("body").on('tap', '[data-href]', function (e) {
            //e.stopPropagation();
            //e.preventDefault();
            var href = $(this).attr("data-href");
            console_log(href);
            //app_path1=shuati&openid={{openid}}&trans={{trans}}&sc={{sc}}&source1={{source1}}&neice={{neice}}&r=121

            //if (params.app_path1=='shuati')

            href && (myhref.href = href);
        });
    });
} catch (e) {
    //console.error('错误777' + e);
    try {
        //var $j = jQuery.noConflict();
        (function ($, doc) {
            getCurrentCityGPS('#currentCity');

            $("body").on('tap', '[data-href]', function (e) {
                //e.stopPropagation();
                //e.preventDefault();
                //alert('111')
                var href = this.getAttribute("data-href"); if (!isDebug && href.toLowerCase().indexOf('indexpage1_') != -1) { mui.toast('即将推出，请同学们多提建议'); return; }//$(this).attr("data-href");
                //console_log(href);
                href && mui.openWindow({ url: href });
                //href && (myhref.href = href);
            });
        }(mui, document));
    } catch (e) {
        console.error('错误888' + e);
    }
}

function translatePoint(position) {
    if (location.href.indexOf('indexPage') == -1) return;
    var g1 = cityinfo_Gps;
    try {
        console_log('定位...');
        var currentLat = position.coords.latitude;
        var currentLon = position.coords.longitude;
        //setCookie("curLat", currentLat, 1);//设置cookie  
        //setCookie("curLng", currentLon, 1);//设置cookie  
        var gpsPoint = new BMap.Point(currentLon, currentLat);

        var pt = new BMap.Point(currentLon, currentLat);
        var geoc = new BMap.Geocoder();
        geoc.getLocation(pt, function (rs) {
            var addComp = rs.addressComponents;
            setCookie("curLat", currentLat, 1); //设置cookie  
            setCookie("curLng", currentLon, 1); //设置cookie  
            g1.latitude = currentLat;
            g1.longitude = currentLon;
            //alert(JSON.stringify(addComp));  
            var city_name = addComp.city.replace('市', '');
            g1.city_name = city_name;
            //获得具体街道信息    
            var texts = addComp.district + "-" + addComp.street + "-" + addComp.streetNumber;
            g1.address = texts;
            isGpsTrue1 = true;
            setCity();
            //$("#nowRoad").text(texts);
        });
    } catch (e) {
        try {
            if (!isGpsTrue1) {
                $.when(getCurrentCityByBaiDu()).done(function (data) {
                    var g1 = cityinfo_Gps;
                    if (data && data.address) {
                        g1.city_name = data.address.city.replace('市', '');
                        //console_log(data);
                        g1.latitude = data.latitude;
                        g1.longitude = data.longitude;
                        isGpsTrue1 = true;
                        setCity();
                    }
                });
            }
        } catch (e1) { console.warn(e1); }
    }
}
/**
 * 获取当前城市
 */
function getCurrentCityByBaiDu(deferred) {
    try {
        var _deferred = deferred ? deferred : $.Deferred();
        var geolocation = new BMap.Geolocation();
        geolocation.getCurrentPosition(function (r) {
            if (this.getStatus() == BMAP_STATUS_SUCCESS) {
                _deferred.resolve(r);
            }
            //else {
            //    mui.toast("无定位权限 获取城市异常");
            //}
        }, { enableHighAccuracy: true });
        console_log("获取到定位");
        setSession("gpsCity", _deferred);
        setSession("gpsCityTime", new Date());
        return _deferred;
    } catch (e) {
        console.warn(e);
    }
}

// 搜索城市，第二次进入则缓存
function searchCity(city_name) {
    if (!city_name) return;
    var url1 = baseUrlCommon + "/home/cities.aspx?city_name=" + city_name;
    var ajax1 = getSession(url1); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "GET",
        success: function (data) { setSession(url1, data); }
    });
    return ajax;
}
var isGpsTrue2 = false;
var isGpsTrue1 = false;
var cityinfo_Gps = {
    city_id: "",
    city_name: "",
    latitude: "",
    longitude: "",
    address: ""
}
var cityNameControlId = "";
function getCurrentCityGPS(cityNameControlId1) {
    cityNameControlId = cityNameControlId1;
    if (!isGpsTrue1) {
        try {
            navigator.geolocation.getCurrentPosition(translatePoint); //定位  
        } catch (e) {
            console.warn(e);
        }
    }
}
function setCity() {
    var g1 = cityinfo_Gps;
    if (isGpsTrue1 && g1.city_name) {
        console_log(g1.city_name);
        $.when(searchCity(g1.city_name)).done(function (cityData) {
            //if (typeof cityData == "string") {
            //    cityData = JSON.parse(cityData);
            //}
            console_log(cityData);
            if (cityData.code == 200) {
                if (!cityData.data.cities.length) {
                    // 一个未知的城市
                    g1.city_name = "温州";//"杭州市";1
                    g1.city_id = "36";
                } else {
                    g1.city_id = cityData.data.cities[0].id;
                    g1.city_name = cityData.data.cities[0].name;
                    if (g1.city_id) {
                        if (!localCityInfo.city_id) {
                            setLocalCityInfo(g1.city_id, g1.city_name, g1.latitude, g1.longitude);
                        }
                    }
                }
                //设置控件
                if (g1.city_name && cityNameControlId) {
                    var c1 = $(cityNameControlId);
                    if (c1) {
                        c1.text(g1.city_name).attr("data-id", g1.city_id);
                        //mui.toast("获取城市成功");
                    }
                }
                isGpsTrue1 = true;
                return g1;
            }
        });
    } else {
        //mui.toast("无定位权限 获取城市异常");
    }
}
function getCurrentCityCache(cityNameControlId1) {
    var cityinfo = getLocalCityInfo();
    try {
        if (!cityinfo.city_id) {//上一次的读取城市
            getCurrentCityGPS(cityNameControlId1);
        }
        //设置控件
        if (cityinfo.city_name && cityNameControlId1) {
            var c1 = $(cityNameControlId1);
            if (c1)
                c1.text(cityinfo.city_name).attr("data-id", cityinfo.city_id);
        }
        console_log('本页面城市-')
        console_log(cityinfo);
    } catch (e) { mui.toast(e.message); }
    return cityinfo;
}
var myhref = {//window.location.replace("../pagesCommon/login.html");	//在子页面中返回就返回到更前面的页面。
    //_href: '',
    set href(val0) {
        if (val0) {
            var val1 = val0.toLowerCase();//目标地址
            var isHttp = (val1.indexOf("://") != -1 && val1.indexOf("..") == -1)
            var isCommon = (val1.indexOf('bindphone') != -1 || val1.indexOf('findpassword') != -1 || val1.indexOf('indexpage_searchcitylist') != -1 || val1.indexOf('indexpage_select') != -1 ||
                val1.indexOf('indexpage_selectschool') != -1 || val1.indexOf('login.html') != -1 || val1.indexOf('redirect.html') != -1 || val1.indexOf('register') != -1
                 || val1.indexOf('set') != -1)
            if (!isHttp) {
                if (isCommon)
                    val0 = "../pagescommon/" + val0;
                else
                    val0 = "../pages/" + val0;
            }
            var u1 = getLocalUserInfo();
            if (!u1 && !u1.source1) {
                if (val0.indexOf("?") != -1)
                    val0 += "&source1=" + u1.source1;
                else
                    val0 += "?source1=" + u1.source1;
            }
            //alert(val1)
            try {
                mui.openWindow({
                    url: val0  //hrefUrl1
                });
                //alert("mui==" + val0)
                return;
            } catch (e) { console.error(e); }
            //alert(val0)
            window.location.href = val0; //在子页面中返回就返回到当前的页面。
        }
    }
};
//
// 判断是android浏览器
function isAndroid() {
    var u = navigator.userAgent, app = navigator.appVersion;
    var isAndroid = u.indexOf('Android') > -1 || u.indexOf('Linux') > -1;
    return isAndroid;
}
//zlg 新增

/**
 * 获取当前城市中的学校 add zlg
 */
function searchSchool(city_name) {
    if (!city_name) return;
    var url1 = baseUrlCommon + "/schools.aspx?city=" + city_name;
    //var ajax1 = getSession(url1); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "GET",
        success: function (data) { setSession(url1, data); }
    });
    return ajax;
}
// 首页
// 按首字母获取城市
function getAllCity() {
    var url1 = baseUrlCommon + "/home/cities.aspx";
    //var ajax1 = getSession(url1); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlCommon + "/home/cities.aspx",
        type: "GET"
    , success: function (data) { setSession(url1, data); }
    });

    return ajax;
}
// 获取城市列表
function getCityList() {
    var url1 = baseUrlCommon + "/home/cities.aspx?type=onlycity";
    //var ajax1 = getSession(url1); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "GET"
        , success: function (data) { setSession(url1, data); }
    });
    return ajax;
}
// 搜索城市，第二次进入则缓存
function searchCity(city_name) {
    if (!city_name) return;
    var url1 = baseUrlCommon + "/home/cities.aspx?city_name=" + city_name;
    //var ajax1 = getSession(url1); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "GET",
        success: function (data) { setSession(url1, data); }
    });
    return ajax;
}

/**
 * 获取学校专业
 */
function seachDepartment(school_id) {
    if (!school_id) return;
    var url1 = baseUrlCommon + "/department.aspx?school_id=" + school_id;
    //var ajax1 = getSession(url1); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: url1, //baseUrlJson + "/department.aspx?school_id=" + school_id,
        type: "GET"
       , success: function (data) { setSession(url1, data); }
    });
    return ajax;
}



/**
 * 提交专业
 */
function postCity(data1) {
    var ajax = postAjaxMUI(baseUrlCommon + "/postCity.aspx", data1, "post", function (json) {
        //操作json.data;
        if (json.code == 200) {
            mui.toast("城市设置成功");
            //myhref.href = "indexPage1_" + app_path1 + ".html";
        } else if (json.code == 201)
            mui.toast("城市已存在");
        else
            mui.toast("提交失败");
    });
    return ajax;
}
/**
 * 提交专业
 */
function postDepartment(data1) {
    var ajax = postAjaxMUI(baseUrlCommon + "/postDepartment.aspx", data1, "post", function (json) {
        //操作json.data;
        if (json.code == 200) {
            mui.toast("分院设置成功");
            //myhref.href = "indexPage1_" + app_path1 + ".html";
        } else if (json.code == 201)
            mui.toast("分院已存在");
        else
            mui.toast("提交失败");
    });
    return ajax;
}
/**
 * 提交学校
 */
function postSchool(data1) {
    var ajax = postAjaxMUI(baseUrlCommon + "/postSchool.aspx", data1, "post", function (json) {
        //操作json.data;
        if (json.code == 200) {
            mui.toast("学校设置成功");
            //myhref.href = "indexPage1_" + app_path1 + ".html";
        } else if (json.code == 201)
            mui.toast("学校已存在");
        else
            mui.toast("提交失败");
    });
    return ajax;
}


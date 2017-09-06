
//$.ajaxSetup({
//    headers: getAjaxHeader(),
//    beforeSend: ajaxDataHandle,
//    contentType: contentType,
//    processData: false,
//    success: successHandle,
//    error: errorHandle, //dataType: "json",
//    dataType: "json"
//});

/**
 * 获取当前城市中的学校 add zlg
 */
function searchSchool(city_name) {
    if (!city_name) return;
    var url1 = baseUrlCommon + "/schools.aspx?city=" + city_name;
    var ajax1 = getSession(url1); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "GET",
        success: function (data) { setSession(url1, data); }
    });

    return ajax;
}

/**
 * 用户未注册的情况
 * 本地cookie是没有城市信息的
 * 需要在本地db里获取
 * 用户注册cookie里就有城市信息所有从cookie获取
 */
//if (cookieObj.city_id && cookieObj.city_name) {  cch注释， 用了localcityinfo
//    currentCityId = cookieObj.city_id;
//    currentCityName = decodeURI(cookieObj.city_name);
//    console.log(currentCityName);
//} else if (localCityInfo.city_id && localCityInfo.city_name) {
//    currentCityId = localCityInfo.city_id;
//    currentCityName = localCityInfo.city_name;
//}

//if (currentCityId == "undefined") {
//    currentCityId = "1";
//    //myhref.href = "index.html";
//}
//if (currentCityName == "undefined") {
//    currentCityName = "杭州";
//}
function getCookie(name) {
    var arr, reg = new RegExp("(^| )" + name + "=([^;]*)(;|$)");
    if (arr = document.cookie.match(reg))
        return unescape(arr[2]);
    else
        return null;
}
function delCookie(name) {
    var exp = new Date();
    exp.setTime(exp.getTime() - 100);
    var cval = getCookie(name);
    if (cval != null)
        document.cookie = name + "=" + cval + ";expires=" + exp.toGMTString();
}
function deleteAllCookie() {
    var strCookie = document.cookie;
    var arrCookie = strCookie.split("; "); // 将多cookie切割为多个名/值对
    for (var i = 0; i < arrCookie.length; i++) { // 遍历cookie数组，处理每个cookie对
        var arr = arrCookie[i].split("=");
        if (arr.length > 0)
            delCookie(arr[0]);
    }
}
var isTest = true;
//function getCookieObj_delete() {
//    if (isTest) {
//        //deleteAllCookie();
//    }
//    var cookie = document.cookie;
//    console.log('cookie=' + cookie);
//    var cookieObj = {};
//    if(isTest && !cookie)
//    {
//        //   //测试用
//        var Days = 30;
//        var exp = new Date();
//        exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
//        document.cookie = "Token=fe78f338ef2fec25a3488b3701732176" + ";expires=" + exp.toGMTString();
//        document.cookie = "cityInfo=1" + ";expires=" + exp.toGMTString();
//        document.cookie = "city_name=%E6%9D%AD%E5%B7%9E" + ";expires=" + exp.toGMTString();
//        document.cookie = "utrace=1bba7fcb571bc0cc8e82fefde3eea763" + ";expires=" + exp.toGMTString();
//        document.cookie = "isLogin=true" + ";expires=" + exp.toGMTString();

//        document.cookie = "user_id=9A9AE185-8F07-4413-9013-96B983BDD36E" + ";expires=" + exp.toGMTString();
//        document.cookie = "openid=9A9AE185-8F07-4413-9013-96B983BDD36E" + ";expires=" + exp.toGMTString();
//        document.cookie = "head_img_url=http:\\\\wx.qlogo.cn\\mmopen\\Zqv43iauMibM6UVIFtBBLyV2lZlpb77LNxRIoZf6QfNmSM4AlPkKx5LAuFy8JibuoyGX4fh9ZpuHqzKFj7Zgglefy8k8w32syrV\\0" + ";expires=" + exp.toGMTString();
//        //cookieObj.user_id,cookieObj.openid}isLogin||!cookieObj.Token;
//        cookie = document.cookie;
//    }
//    if (cookie) {
//        var arr = cookie.split("; ");
//        if (!arr.length) {
//            arr = cookie.split(";");
//        }
//        for (var i = 0, length = arr.length; i < length; i++) {
//            var _arr = arr[i].split("=");
//            cookieObj[_arr[0]] = _arr[1];
//        }
//    } else {
//        successHandle({ "code": 402 });
//    }
//    if (!cookieObj.isLogin || !cookieObj.Token) {
//        successHandle({ "code": 402 });
//    }
//    console.log('cookieObj==user_id=' + cookieObj.user_id + "&isLogin=" + cookieObj.isLogin + cookieObj.Token);
//    return cookieObj;
//}

function successHandle(data) {
    console.log('data.code=' + data.code);
    if (!isTest && data.code == 402) {
        //登录超时
        myhref.href = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + appId +
            "&redirect_uri=" +
            //baseUrlHtml + "/wechat/wxlogin.aspx?redirectUrl=" +
            baseUrlJson + "/wechat/wxlogin.aspx?redirectUrl=" +
            baseUrlHtml + "/pages/indexPage.html" +
            "&response_type=code&scope=snsapi_userinfo&connect_redirect=1#wechat_redirect";
    }
    else if (isTest || data.code == 417) {//app里的
        // 未绑定手机号 作统一处理
        myhref.href = "../pagesCommon/bindPhone.html";
    }
    else if ((data.code != 200) && data.message) {
        mui.toast(data.message);
    }
    //zlg
    //mui.toast("3417" + baseUrlHtml);
}

function successHandle(data) {
    417 == data.code ? myhref.href = "../pagesCommon/bindPhone.html" : 200 != data.code && data.message && mui.toast(data.message)
}

function errorHandle(data) {
    //mui.toast("网络异常");
}
function ajaxDataHandle() {
    var data = this.data;
    if (data) {
        var string = JSON.stringify(data);
        this.data = new TextEncoder().encode(string);
    }
}
function getAjaxHeader() {
    var header = {};
    header.version = "2.0";
    header.OriginType = "mp";
    header.token = cookieObj.Token;
    return header;
}
function dataFilter(data, dataType) {
    if (typeof data == "string") {
        data = JSON.parse(data);
    }
    return data;
}
// 获得验证码
function getVerifyCode(phone_number, type) {
    if (!phone_number) return;
    // type: 1为登录,2 为注册,3为修改账户信息
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/user/verify_code.aspx",
        type: "POST",
        data: {
            "phone_number": phone_number,
            "type": type
        }
    });
    return ajax;
}
// 注册
function userRegister(phone_number, verifyCode) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/user/register.aspx",
        type: "POST",
        crossDomain: true,
        data: {
            "phone_number": phone_number,
            "verifyCode": verifyCode
        }
    });
    return ajax;
}
// 用户登陆
function userLogin(phone_number, verifyCode) {
    if (!phone_number) return;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/user/login.aspx",
        type: "POST",
        crossDomain: true,
        data: {
            "phone_number": phone_number,
            "verifyCode": verifyCode
        }
    });
    return ajax;
}
// 用户登出
function userLogout() {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/user/logout.aspx",
        type: "POST"
    });
    return ajax;
}


// 智能查询
function searchKeywordTips(keyword, app_path1) {
    //if (!keyword || keyword=='') return;
    var url1 = baseUrlJson + "/keywordTips.aspx?1" + keyword + app_path1;
    var ajax1 = getSession(url1); if (ajax1) return ajax1;
    // type: 1为登录,2 为注册,3为修改账户信息
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/keywordTips.aspx",
        type: "POST",
        data: {
            "keyword": keyword,
            "app_path1": app_path1
        }, success: function (data) { setSession(url1, data); }
    });
    return ajax;
}
// 智能查询kenu cch
function searchKeywordTipskemu(keyword, app_path1) {
    //if (!keyword || keyword=='') return;
    var url1 = baseUrlJson + "/searchkemu.aspx?" + keyword;
    var ajax1 = getSession(url1); if (ajax1) return ajax1;
    // type: 1为登录,2 为注册,3为修改账户信息
    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "POST",
        data: {
            "keyword": keyword,
            "app_path1": app_path1
        }, success: function (data) { setSession(url1, data); }
    });
    return ajax;
}
// 获取轮播图
function getBannersByCityId(city_id) {
    //if (!city_id) return;
    var url1 = baseUrlCommon + "/home/banners.aspx?city_id=" + city_id + '&app_path1=' + app_path1;
    var ajax1 = getSession(url1); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "GET"
        , success: function (data) { setSession(url1, data); }
    })
    return ajax;
}
// 首页3+2推荐数据
function getRecommends(city_id) {
    var url1 = baseUrlJson + "/home/recommends.aspx?city_id=" + city_id + '&app_path1=' + app_path1;
    var ajax1 = getSession(url1); if (ajax1) return ajax1;

    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "GET"
        , success: function (data) { setSession(url1, data); }
    });

    return ajax;

}
// 根据id获取新品书籍信息
function getRecommendItemInfo(recommendItemId) {
    var url1 = baseUrlJson + "/newItem.aspx?recommendItemId=" + recommendItemId;
    var ajax1 = getSession(url1); if (ajax1) return ajax1;
    if (!recommendItemId) return;
    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "GET"
     , success: function (data) { setSession(url1, data); }
    });
    return ajax;
}
// 根据id获取推荐专题详情
function getRecommendThemeInfo(themeId) {
    var url1 = baseUrlJson + "/imgTheme.aspx?themeId=" + themeId;
    var ajax1 = getSession(url1); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: url1,
        type: "GET", timeout: 11000
      , success: function (data) { setSession(url1, data); }

    });
    return ajax;
}
// 根据推荐列表id获取单品书籍列表
function getRecommendBooksByTypeAndId(type, id) {
    if (!id) return;
    var ur1l = baseUrlJson + "/recommendbooks12.aspx?type=" + type + "&id=" + id;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json", dataType: "json", dataType: "json",
        url: baseUrlJson + "/recommendbooks12.aspx?type=" + type + "&id=" + id,
        //baseUrlJson + "/recommendbooks/"+type+"/"+id,
        //"http://localhost:62259/Json_xianshu/b_recommendBook.aspx
        type: "GET", success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}
// 搜索书本
function searchBooks(keyword, city_id, page) {
    console.log('searchBooks==');
    var ur1l = baseUrlJson + "/search.aspx" + keyword;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json", dataType: "json",
        url: baseUrlJson + "/search.aspx",//"http://localhost:62259/Json_xianshu/b_searchResult.aspx",//baseUrlJson + "/search",
        type: "POST",
        data: {
            "keyword": keyword,
            "city_id": city_id,
            "page": page
        }, success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}

// 搜索科目ccccc
function searchkemu(keyword, city_id, page) {
    console.log('searchkemu==');
    var ur1l = baseUrlJson + "/searchkemu.aspx" + keyword; //cch
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json", dataType: "json",
        url: baseUrlJson + "/searchkemu.aspx",//"http://localhost:62259/Json_xianshu/b_searchResult.aspx",//baseUrlJson + "/search",
        type: "POST",
        data: {
            "keyword": keyword,
            "city_id": city_id,
            "page": page
        }, success: function (data) { setSession(ur1l, data); }
        //}, success: function (data) {  }

    });
    return ajax;
}
// 根据城市id获取书库页面分类数据
function getCategoryByCityId(city_id) {
    var ur1l = baseUrlJson + "/categories.aspx?city_id=" + city_id;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    //if (!city_id) return;
    var ajax = $.ajax({
        dataType: "json", dataType: "json",
        url: baseUrlJson + "/categories.aspx?city_id=" + city_id,
        type: "GET", success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}
// 根据parentId获取分类数据
function getCategoryChildrenByParentId(parentId) {
    var ur1l = baseUrlJson + "/categories/children.aspx?parentId=" + parentId;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json", dataType: "json",
        url: baseUrlJson + "/categories/children.aspx?parentId=" + parentId,
        type: "GET",
        dataFilter: dataFilter, success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}
// 根据分类id获取书籍列表
function getBooksByCategoryId(categoryId, city_id, sort, page, pageSize) {
    if (!categoryId) return;
    pageSize = pageSize ? pageSize : "10";

    var ur1l = baseUrlJson + "/categories/books.aspx?categoryId=" + categoryId + page + pageSize + city_id;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json", dataType: "json",
        url: baseUrlJson + "/categories/books.aspx?categoryId=" + categoryId,
        type: "POST",
        data: {
            "city_id": city_id,
            "sort": sort,
            "page": page,
            "pageSize": pageSize
        }, success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}


// 申请成为ceo
function applyToBeCeo(name, sex, city_id, school_id, phone_number, verifyCode) {
    if (!name) return;
    var ajax = $.ajax({
        dataType: "json", dataType: "json",
        url: baseUrlJson + "/ceoApply.aspx",
        data: {
            "name": name,
            "sex": sex,
            "city_id": city_id,
            "school_id": school_id,
            "phone_number": phone_number,
            "verifyCode": verifyCode
        },
        type: "POST"
    });
    return ajax;
}
// 申请成为ceo发送验证码
function sendMessageForApplyCeo(phone_number) {
    if (!phone_number) return;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/apply/" + phone_number + "/message.aspx",
        type: "GET"
    });
    return ajax;
}

// 抢购详情接口
function getPanicBuy() {
    var ur1l = baseUrlJson + "/panicBuy.aspx";
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: ur1l,
        type: "GET", success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}
// webapp用户绑定手机号: 发送验证码
function sendMessageForBindPhone(phone_number) {
    if (!phone_number) return;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/user/webapp_bind.aspx",
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
        url: baseUrlJson + "/user/bind.aspx",
        type: "POST",
        data: {
            "phone_number": phone_number,
            "verifyCode": verifyCode
        }
    });
    return ajax;
}

// 刷新微信分享参数
function refreshWechatShareConfig(url) {
    //var ajax = $.ajax({ dataType: "json",
    //  url: baseUrlUser + "/wxshare/jsapi.aspx",
    //  data: {
    //    "url": url
    //  },
    //  type: "PUT"
    //});
    //return ajax;
}
// 设置微信分享参数
var private_hasRefresh = false;// 使refresh仅执行一次
function setWechatShareConfig(title, desc, link, imgUrl) {
    //title||(title = '作业云搜  免费领取教材');
    //desc||(desc = '我在作业云搜领取了三本免费的上课教材，你也来试一下吧！');
    //link||(link = window.location.origin+"/pages/indexPage.html");
    //imgUrl||(imgUrl = "http://image.qess.me/logo/yunshu.png");

    //var config = {
    //  title: title,
    //  desc: desc,
    //  link: link,
    //  imgUrl: imgUrl,
    //  success: function() {

    //  },
    //  cancel: function() {

    //  }
    //};
    //wx.ready(function(data) {
    //  // 朋友圈
    //  wx.onMenuShareTimeline(config);
    //  // 朋友
    //  wx.onMenuShareAppMessage(config);
    //  // QQ
    //  wx.onMenuShareQQ(config);
    //  // 腾讯微博
    //  wx.onMenuShareWeibo(config);
    //  // QQ空间
    //  wx.onMenuShareQZone(config);
    //});
    //// 如果失败那么刷新参数
    //wx.error(function(res){
    //  if(!private_hasRefresh){
    //    private_hasRefresh = true;
    //    $.when(refreshWechatShareConfig(window.location.href)).done(function(data){
    //      if(data.code == 200){
    //        wx.config({
    //          debug: false, // 开启调试模式,调用的所有api的返回值会在客户端alert出来，若要查看传入的参数，可以在pc端打开，参数信息会通过log打出，仅在pc端时才会打印。
    //          appId: appId, // 必填，公众号的唯一标识
    //          timestamp: data.data.timestamp, // 必填，生成签名的时间戳
    //          nonceStr: data.data.nonceStr, // 必填，生成签名的随机串
    //          signature: data.data.signature,// 必填，签名，见附录1
    //          jsApiList: ["onMenuShareTimeline", "onMenuShareAppMessage", "onMenuShareQQ", "onMenuShareWeibo", "onMenuShareQZone"] // 必填，需要使用的JS接口列表，所有JS接口列表见附录2
    //        });
    //        setWechatShareConfig("","","","");
    //      }
    //    });
    //  }
    //})
}
//发起微信支付
function getWechatPayParams(tradeNo, payType, change) {
    //var ajax = $.ajax({ dataType: "json",
    //  url: baseUrlJson + "/trade/wxPayParams",
    //  data: {
    //    "tradeNo": tradeNo,
    //    "payType": payType,
    //    "change": change
    //  },
    //  type: "POST"
    //});
    //return ajax;
}
// 微信端改cookie
function editCookie(city_id) {
    if (!city_id) return;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlCommon + "/wechat/editCookie.aspx?city_id=" + city_id,
        type: "GET"
    });
    return ajax;
}


// 获取优惠券
function getCouponsList(page, type) {
    var ur1l = baseUrlJson + "/user/coupons.aspx?page=" + page + "&type=" + type + "&user_id=" + cookieObj.user_id;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/user/coupons.aspx?page=" + page + "&type=" + type + "&user_id=" + cookieObj.user_id,//zlg add
        cache: false,
        type: "GET", success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}
// 添加优惠券
function exchangeCoupon(code) {
    if (!code) return;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/user/coupons.aspx?action=exchange" + "&user_id=" + cookieObj.user_id,//zlg add
        data: {
            "code": code
        },
        type: "POST"
    });
    return ajax;
}
// 优惠券详情
function getCouponById(id) {
    var ur1l = baseUrlJson + "/user/coupons.aspx?id=" + id + "&user_id=" + cookieObj.user_id;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/user/coupons.aspx?id=" + id + "&user_id=" + cookieObj.user_id,//zlg add
        type: "GET", success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}
// 获得过期的优惠券
function getExpiredCouponsList(page, type) {
    if (!page) return;

    var ur1l = baseUrlJson + "/user/coupons.aspx?action=expired&page=" + page + "&type=" + type + "&user_id=" + cookieObj.user_id;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/user/coupons.aspx?action=expired&page=" + page + "&type=" + type + "&user_id=" + cookieObj.user_id,//zlg add
        type: "GET", success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}
// 获取优惠券二维码
function getQRCodeByCouponId(couponId) {
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/qrcode/coupon.aspx?couponId=" + couponId + "&Token=" + cookieObj.Token,
        type: "GET"
    });
    return ajax;
}
// 是否已绑定手机号
function isBindPhone(phone_number) {
    if (!phone_number) return;
    var data = { "oper_type": 201, "phone_number": phone_number }
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlUser + "/user/check_exist_user.aspx",
        type: "POST",
        beforeSend: function (request) {
            request.setRequestHeader("content-type", "application/json");
            request.setRequestHeader("OriginType", "h5");
            request.setRequestHeader("version", "1.0");
        },
        data: JSON.stringify(data)
    });
    alert(ajax.code)
    return ajax;
}


//获取优惠券数量
function getConponsNumber() {
    if (!cookieObj.user_id) return;
    var ur1l = baseUrlJson + "/user/coupons.aspx?action=count&user_id=" + cookieObj.user_id;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        //url: baseUrlJson + "/user/coupons.aspx?action=count",
        url: baseUrlJson + "/user/coupons.aspx?action=count&user_id=" + cookieObj.user_id,
        type: "GET",
        cache: false, success: function (data) { setSession(ur1l, data); }
        //data: JSON.stringify(data)//add zlg
    });
    return ajax;
}

//加入心愿清单信息
function addMyHopeInfo(id, title, path, author, publisher) {
    if (!cookieObj.user_id) return;
    var data = {
        "user_id": cookieObj.user_id,
        "city_id": cookieObj.city_id,
        "wish_type": 0,
        "id": id,
        "title": title,
        "path": path,
        "marketPrice": "0.00",
        "publisher": publisher,
        "author": author
    }
    var ajax = $.ajax({
        dataType: "json",
        url: "http://121.199.30.122:12002/basket/wish",
        beforeSend: function (request) {
            request.setRequestHeader("content-type", "application/json");
        },
        type: "post",
        data: JSON.stringify(data),
        cache: false, success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}

//伪推荐书籍
function fakeRecommendbook(type) {
    var ur1l = baseUrlJson + "/recommendbooks1.aspx?type=" + type;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/recommendbooks1.aspx?type=" + type,
        type: "GET",
        cache: false, success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}

//优惠券张数
function getMyEffectiveCoupons(no) {
    if (!no) return;
    var ur1l = baseUrlJson + "/orders/reduction.aspx?no=" + no;
    var ajax1 = getSession(ur1l); if (ajax1) return ajax1;
    var ajax = $.ajax({
        dataType: "json",
        url: baseUrlJson + "/orders/reduction.aspx?no=" + no,
        type: "GET",
        cache: false, success: function (data) { setSession(ur1l, data); }
    });
    return ajax;
}

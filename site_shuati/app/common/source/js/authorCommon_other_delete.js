
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


//if (sessionStorage.getItem('flagUrl') == "true") {
//    console.log('绑定完了进入');
//    sessionStorage.setItem('flagUrl', false);
//    var his1 = sessionStorage.getItem('historyUrl');
//    if (his1) {
//        sessionStorage.setItem('flagUrl', false);
//        myhref.href = his1;
//    }
//}


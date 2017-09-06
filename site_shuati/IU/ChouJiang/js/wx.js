/*
    测试号
 AppId     ：wx8b15f55155a8b996
 AppSecret ：d3d836e009fa023d9785eec549a1321c
 学霸优选
 AppId     ：wx1d5993af684bee55
 AppSecret ：8c2ce78f641208713d4052256c95e127
刷题宝典 
 AppId     ：wx1f49864edcede162
 AppSecret ：397321322f90543dd09719a1aedcb5a5
 */
var appid = "wx1d5993af684bee55";
var AppSecret = "8c2ce78f641208713d4052256c95e127";
var timestamp = (new Date()).valueOf();

wx.config({
    debug: true, // 开启调试模式,调用的所有api的返回值会在客户端alert出来，若要查看传入的参数，可以在pc端打开，参数信息会通过log打出，仅在pc端时才会打印。
    appId: 'wx1d5993af684bee55', // 必填，公众号的唯一标识
    timestamp:timestamp , // 必填，生成签名的时间戳
    nonceStr: 'chenchenghang', // 必填，生成签名的随机串
    signature: '',// 必填，签名，见附录1
    jsApiList: [] // 必填，需要使用的JS接口列表，所有JS接口列表见附录2
});

wx.ready(function () {
     // 1 判断当前版本是否支持指定 JS 接口，支持批量判断
     document.querySelector('#checkJsApi').onclick = function () {
         wx.checkJsApi({
             jsApiList: [
               'getNetworkType',
               'previewImage'
             ],
             success: function (res) {
                 alert(JSON.stringify(res));
             }
         });
     };




    //var aa = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + appid + "&secret=" + AppSecret;
    //console.log(aa)
    //$(document).ready(function () {
       
    //    $.get("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + appid + "&secret=" + AppSecret", function (result) {
    //        conso.log(result)
    //        conso.log(111222)
     
    //    });
    //});


// https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid='+ appid +'&secret='+AppSecret'";
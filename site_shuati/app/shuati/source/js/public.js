

var LocString = String(window.document.location.href);
function getQueryStr(str) {
    var rs = new RegExp("(^|)" + str + "=([^&]*)(&|$)", "gi").exec(LocString), tmp;
    if (tmp = rs) {
        //alert(tmp[2] + "=====" + str);
        return tmp[2];
    }
    // parameter cannot be found 
    return "";
}

// var currentCityId = window.localStorage.getItem("city_id");
// var currentCityName = window.localStorage.getItem("city_name");
// if(currentCityName&&currentCityId){
// 	// 已获取当前城市及id
// }
// else{
// 	myhref.href = "index.html";
// }
// 百度统计
var _hmt = _hmt || [];
(function() {
  var hm = document.createElement("script");
  hm.src = "//hm.baidu.com/hm.js?1958976bdfd7dc01acfaabd54ae2d104";
  var s = document.getElementsByTagName("script")[0]; 
  s.parentNode.insertBefore(hm, s);

  // var ipAddress = document.createElement("script");
  // ipAddress.src = "http://www.w3dev.cn/getip.ashx?js=1";
  // var s1 = document.getElementsByTagName("script")[0];
  // s1.parentNode.insertBefore(ipAddress, s1);
})();
$(function () {
    $.when(getWechatShareConfig(window.location.href)).done(function(data){
        if (data && data.code == 200) {
            //wx.config({
            //    debug: false, // 开启调试模式,调用的所有api的返回值会在客户端alert出来，若要查看传入的参数，可以在pc端打开，参数信息会通过log打出，仅在pc端时才会打印。
            //    appId: appId, // 必填，公众号的唯一标识
            //    timestamp: data.data.timestamp, // 必填，生成签名的时间戳
            //    nonceStr: data.data.nonceStr, // 必填，生成签名的随机串
            //    signature: data.data.signature,// 必填，签名，见附录1
            //    jsApiList: ["onMenuShareTimeline", "onMenuShareAppMessage", "onMenuShareQQ", "onMenuShareWeibo", "onMenuShareQZone"] // 必填，需要使用的JS接口列表，所有JS接口列表见附录2
            //});
            //setWechatShareConfig("","","","");
        }
    });
});
function encodeObj(obj) {
    return encodeURI(JSON.stringify(obj));
}
function getQueryData(){
    var searchUrl = window.location.search.split("?")[1];
    if(searchUrl&&searchUrl.search("=")>0){
        searchUrl = searchUrl.split("=")[0];
    }
    var URI = decodeURI(searchUrl);
    var parseURI = URI;
    if(URI){
        try{
            parseURI = JSON.parse(URI);
        }
        catch(e){
            parseURI = "";
        }
    }
    return parseURI;
}
/* 一些书本列表页面公用的方法
*/
var bookTableCellHtml = '<ul class="mui-table-view" style="margin-top: 10px;">'+
        '<li class="mui-table-view-cell">'+
            '<a data-href="">'+
                '<div class="mui-table">'+
                    '<div class="mui-table-cell mui-col-xs-3">'+
                        '<div class="icon iconfont info icon-book" style="line-height: 100%;   font-size: 40px; " src="" />' +
                    '</div>'+
                    '<div class="mui-table-cell mui-col-xs-9">'+
                       '<h4 style="margin-bottom: 10px;font-size: 15px;" class="title mui-ellipsis"></h4>'+
                        //'<h6>热门科目<span class="author"></span></h6>'+
                        '<h6>贡献人：<span class="publisher">帮学妹</span></h6>'+
                        //'<span class="mui-h4 linkColor">¥<span class="marketPrice"></span></span>'+
                    '</div>'+
                '</div>'+
            '</a>'+
            //'<img class="smallCartIcon" src="../source/webslice/0_common/common_add_cart.png" />'+
        '</li>'+
    '</ul>';
var bookTableCellHtml1 = '<ul class="mui-table-view" style="margin-top: 10px;">'+
    '<li class="mui-table-view-cell">'+
        '<a data-href="">'+
            '<div class="mui-table">'+
                '<div class="mui-table-cell mui-col-xs-3">'+
                    '<div class="bookCoverImage" style="width: 80%;" src="" />'+
                    '<div class="mask">暂无库存</div>'+
                '</div>'+
                '<div class="mui-table-cell mui-col-xs-9">'+
                   '<h4 style="margin-bottom: 10px;font-size: 14px;" class="title mui-ellipsis"></h4>'+
                    '<h6 style="line-height:15px;">作者：<span class="author"></span></h6>'+
                    '<h6 style="line-height:15px;">出版社：<span class="publisher"></span></h6>'+
                    '<span style="display:inline-block;margin-top:12px;" class="mui-h4 linkColor">¥<span class="marketPrice"></span></span>'+
                '</div>'+
            '</div>'+
        '</a>'+
        '<img style="padding-bottom: 12px;" class="smallHopeIcon" src="../source/webslice/0_common/common_add_my_hope.png" />'+
    '</li>'+
'</ul>';
function getSingleBookTableCell(id,path,title,author,publisher,marketPrice,supply){
    var tableCell = supply == 0 ? $(bookTableCellHtml1):$(bookTableCellHtml);
    tableCell.find('.bookCoverImage').attr("class", "icon iconfont" + path).end()
        .find('.title').text(title).end()
        .find('.author').text(author).end()
        .find('.publisher').text("帮学妹").end()
        //.find('.marketPrice').text(marketPrice).end()
        .find("a").attr("data-href", "../../shuati/views/kemuDetailList.html?kemuId=" + id).end()
        .attr("data-bookId",id)
        .attr("data-path",path)
        .attr("data-title",title)
        .attr("data-author",author)
        .attr("data-publisher",publisher)
        .attr("data-marketPrice",marketPrice)
        .attr("data-supply",supply);
    return $("<div>").append(tableCell).html();
}























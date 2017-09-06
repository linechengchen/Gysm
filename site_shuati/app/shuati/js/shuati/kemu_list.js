
// 
//  common.js
//  Shuati
//  
//  Created by 成新 朱 on 2016-12-03.
//  Copyright 2016 成新 朱. All rights reserved.
// 
'use strict'
var fetchNextQuestion, fetchmi,
    fetchCacheLastQuestion,
    fetchQuestions,
	fetchTopic,
	addQuestionToDomAfter,
    addQuestionToDomBefore,
	removeQuestionBeforeDom,
	removeQuestionAfterDom,
	//list页面
    fetchTimuTypeListPage, fetchTimuTypeListPageError, addOptionListToDomAfter,
    fetchKemuListPage, addKemuListToDomAfter,
    postTUserZsInfo,
    onwxClick,
    setKaoShiTime, postKemu,
    fetchZs, postTUserZsInfo, postTUserZsInfo ;

var lastTime1 = new Date('2015-10-10');
function IsLater(miniSeconds) {
    //var diff = new Date().valueOf() - lastTime1.valueOf();
    var diff_s = parseInt(Math.abs((new Date() - lastTime1)));// / (900) * 60 * 60 * 24
    if (diff_s > miniSeconds) {
        lastTime1 = new Date();
        return true;
    } else {
    }
    return false;
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
//  ========== 
//  = 依赖mui document 方法 = 
//  ========== 

//onwxClick = function (lastUrl) {
//    console.log(lastUrl)
//    console.log(escape(lastUrl));
//    //var url1 = siteUrlJson.replace("json", "wxInfo") + "test1.aspx?lastUrl=" + escape(lastUrl);
//    //myhref.href = url1;
//}
(function ($, doc) {
    setKaoShiTime = function (options, callback) {
        options = options || {};
        var btnArray = ['取消', '确定'];
        var title1 = '您考这门科目的日期';
        var title2 = '1月几日';
        mui.prompt(title2, '', title1, btnArray, function (e) {
            try {
                if (e.index == 1) {
                    var riqi1 = (e.value);//parseInt
                    if (1 <= riqi1) { //&& questionId1 <= params.question_sum
                        console.log('riqi1' + riqi1);
                        options.riqi1 = riqi1;
                        postKemu(options);
                    }
                    //info.innerText = '谢谢你的评语：' + e.value;
                } else {
                    //info.innerText = '你点了取消按钮';
                }
            } catch (e) {
                mui.toast(e);
            }
        });
    };
    //KemuInfoJson // ZsInfoJson
    //提交科目配置
    postKemu = function (options, callback) {
        postAjaxMUI(siteUrlJson + 'PostKemu.aspx', options, "post", callback);
    };
    		// 提交类目方法
    postTUserZsInfo = function (options, callback) {
        postAjaxMUI(siteUrlJson + 'PostTUserZsInfo.aspx', options, "post", callback);
    }
    // 请求类目方法
    fetchZs = function (options, callback) {
        options = options || {};
        options.kemuId = options.kemuId || '200003';
        options.kemuName = options.kemuName || '军事理论';
        options.sc = options.sc || '192';
        options.type = options.type || '1';

        postAjaxMUI(siteUrlJson + 'ListZs.aspx', options, "get", callback);
    }
    //KemuInfoJson // ZsInfoJson
    //提交科目配置
    postTUserZsInfo = function (options, callback) {
        postAjaxMUI(siteUrlJson + 'PostTUserZsInfo.aspx', options, "post", callback);
    };
    // 请求题型数目方法
    fetchTimuTypeListPage = function (options, callback) {
        postAjaxMUI(siteUrlJson + 'ListTimuType.aspx', options, "get", callback);
    };

    // 请求题型错题cuoti数目方法
    fetchTimuTypeListPageError = function (options, callback) {
        postAjaxMUI(siteUrlJson + 'ListTimuTypeError.aspx', options, "get", callback);
    };

    // 生成html
    addOptionListToDomAfter = function (data) {
        try {
            if (data) {                
                var html = template('optionTypeList-detail-tpl', data);
                document.getElementById("optionTypeList-parent").innerHTML=(html);
                //console.log(data.AutoId);
                //window.stSwiper.slides[window.stSwiper.slides.length - 1].title = data.QuestionId;
            } else
                console.log(data);
        } catch (e) {
            console.log('addOptionListToDomAfter函数' + e);
            console.log(data);
        }
    }

    // 请求kemu方法
    fetchmi = function (options, callback) {
        postAjaxMUI(siteUrlJson + 'aes.aspx', options, "get", callback);
    };

    // 请求kemu方法
    fetchKemuListPage = function (options, callback) {
        postAjaxMUI(siteUrlJson + 'ListKemuIndex.aspx', options, "get", callback);
    };

    // 生成html
    addKemuListToDomAfter = function (data) {
        try {
            if (data) {
                var html = template('kemuList-detail-tpl', data);
                //console.log(html);
                document.getElementById("kemuList-div").innerHTML = (html);
            } else
                console.log(data);
        } catch (e) {
            console.log('addOptionListToDomAfter函数' + e);
            console.log(data);
        }
    }
    
}(mui, document));

    //  ========== 
    //  = 不依赖 mui，document的 function = 
//  ========== 


/////////////
/////////////
/////////////
/////////////

template.helper("parseInt", function (e) {
    return parseInt(e);
});
template.helper("getxs", function (list) {
    var html1 = 'aui-col-xs-3  aui-text-center';
    try {
        if (!list || !list.length || list.length == 0) {
            html1 = "aui-col-xs-0 aui-text-center hide1";
        }
    } catch (e) {
        console.log('getxs函数' + e);
    }
    return html1;
});
template.helper("getZsHtml", function (list) {
    var html1 = '';
    try {
        if (!list || !list.length || list.length == 0) {
            html1 = document.createElement("li");
            html1.className = 'aui-col-xs-12 aui-text-center';
        }
    } catch (e) {
        console.log('getZsHtml函数' + e);
    }
    return html1;
});

template.helper("setStyle", function (question_sum11) {    
    var style1 = "display:none;";
    if (parseInt(question_sum11) > 0)
        style1 = "";
    return style1;
});

template.helper("getIcon", function (icon1, i, kind) {
    var j = i + parseInt(i / 4); //console.log("j" + j);
    if (j % 4 == 1) {
        if (kind == 1)
            icon1 = 'aui-iconfont aui-icon-edit aui-text-info';
        else
            icon1 = 'aui-iconfont aui-icon-pay aui-text-info';
    }
    else if (j % 4 == 2) {
        if (kind == 1)
            icon1 = 'aui-iconfont aui-icon-edit aui-text-warning';
        else
            icon1 = 'aui-iconfont aui-icon-pay aui-text-warning';
    }
    else if (j % 4 == 3) {
        if (kind == 1)
            icon1 = 'aui-iconfont aui-icon-edit aui-text-primary';
        else
            icon1 = 'aui-iconfont aui-icon-pay aui-text-primary';
    }
    else if (j % 4 == 0) {
        if (kind == 1)
            icon1 = 'aui-iconfont aui-icon-edit aui-text-danger';
        else
            icon1 = 'aui-iconfont aui-icon-pay aui-text-danger';
    }
    return icon1;
});
template.helper("getZsIcon", function (icon1, i, kind) {
    var j = i + parseInt(i / 4); //console.log("j" + j);
    if (j % 4 == 1) {
        //if (kind == 1)
        //    icon1 = 'aui-iconfont aui-icon-edit aui-text-info';
        //else
            icon1 = 'aui-iconfont aui-icon-pay aui-text-info';
    }
    else if (j % 4 == 2) {
        //if (kind == 1)
        //    icon1 = 'aui-iconfont aui-icon-edit aui-text-warning';
        //else
            icon1 = 'aui-iconfont aui-icon-pay aui-text-warning';
    }
    else if (j % 4 == 3) {
        //if (kind == 1)
        //    icon1 = 'aui-iconfont aui-icon-edit aui-text-primary';
        //else
            icon1 = 'aui-iconfont aui-icon-pay aui-text-primary';
    }
    else if (j % 4 == 0) {
        //if (kind == 1)
        //    icon1 = 'aui-iconfont aui-icon-edit aui-text-danger';
        //else
            icon1 = 'aui-iconfont aui-icon-pay aui-text-danger';
    }
    return icon1;
});
//jsonp代码来源：http://www.cnblogs.com/napoleon_liu/archive/2010/11/04/1869369.html
var jsonp = (function(window){
    var document = window.document;
    var extend = function(obj, attrs){
        for(var name in attrs){
            obj[name] = attrs[name];
        }
    };

    var Class={
        create: function(class_define){
            var class_ = function(){};
            extend(class_, class_define);
            class_.create = function(attrs){
                var obj = new class_();
                extend(obj, attrs);
                if(obj.init){obj.init();}
                return obj;
            };
            return class_;
        }
    };

    var is_ie = !!window.ActiveXObject;

    var jsonp_imp=null;
    var jsonp = function () {
        jsonp_imp.apply(null, arguments);    
    };

    extend(jsonp, {
        guid:0,
        requests:{},
        avail_tag:[],
        request_timeout:5 //seconds
    });

    var removeChildSafe = function(parent, node) {
        for(var i=0, len=node.childNodes.length; i<len; ++i) {
            removeChildSafe(node, node.childNodes[i]);
        }
		setTimeout(function(){parent.removeChild(node);}, 2500);
    };

    var Request = Class.create({
        prototype:{
            remove:function(){
                var js = this.js;
                if(is_ie) {    
                    this.finished = 1;
                    this.on_ready_state_change();
                    js.detachEvent("onreadystatechange", this.on_ready_state_change);
                    this.js = null;
                }
                removeChildSafe(js.parentNode, js);    
                js = null;
                delete jsonp.requests[this.id];
            },
            on_complete:function(){
                if(this.success) {
                    this.success();
                    this.success = null;
                }
            },
            on_timeout:function(){
                var state = this.js.readyState;
                if( state != 'complete' &&  state != 'loaded' && this.failed) {
                    this.failed();
                    this.failed = null;
                }
                state = null;
                this.remove();
            },
            init:function(){
                var request = this;
                if(is_ie) {
                    request.on_ready_state_change = function(){
                        if(request.finished) {
                            request = null;
                            return;
                        }
                        if(request.js.readyState=='complete' || request.js.readyState=='loaded') {
                            request.on_complete();
                        }
                    };
                    this.js.attachEvent("onreadystatechange", request.on_ready_state_change);
                } else {
                    this.js.onload = function(){ 
                        request.on_complete();
                    };
                }
                setTimeout(function(){request.on_timeout();}, request.timeout);
            }
        }
    });

    var head = document.getElementsByTagName('head')[0];
    jsonp_imp = function(url, charset, timeout, failed, success) {
        var js = document.createElement('script');
        head.appendChild(js);
        if(!charset) {charset = 'utf-8';}
        var id = jsonp.guid++;
        if(!timeout) {timeout = jsonp.request_timeout*1000;}
        var now = new Date();
        var request = Request.create({
                    id: id,
                    url: url,
                    charset: charset, 
                    failed: failed, 
                    success: success,
                    js: js, 
                    stat_time: now,
                    timeout: timeout
        });
        jsonp.requests[id] = request;
        js.charset = charset;
        js.src = url;
        return id;
    };
    
    return jsonp;
})(window);

var xUtil =  {};

xUtil.debug = {};

xUtil.debug.outputTxt = function(text){
	var outputHalt = arguments[1] ? arguments[1] : false;
	$('#debugTxt').append(text + '<br />');
	if(outputHalt){
		$('#debugTxt').append(new Date() + '运行被终止<br />');
	}
	//return false;
};

xUtil.debug.clearTxt = function(){
	document.getElementById('debugTxt').innerHTML = '';
};



var xController =  {};
var xModel =  {};

xController.sina = {};

xController.sina.getShortUrl = function(){
	xController.sina.clearShortUrl();
	xUtil.debug.clearTxt();
	xUtil.debug.outputTxt(new Date() + ' 开始运行');
	
	var appkey = $('#appkey').val();
	var longurl = $('#longurl').val();
	if(appkey == ''){
		return xUtil.debug.outputTxt('错误：appkey不能为空！如果不熟悉，请填写1681459862', true);
	}else if(longurl == ''){
		return xUtil.debug.outputTxt('错误：长链接不能为空！', true);
	}
	xModel.sina.runShortUrlJsonp(longurl, appkey);
	//alert(rst.error);
	xUtil.debug.outputTxt(new Date() + ' xController.sina.getShortUrl运行完毕。');
};

xController.sina.getShortUrlCount = function(){
	xUtil.debug.outputTxt(new Date() + ' xController.sina.getShortUrlCount开始运行');
	
	var appkey = $('#appkey').val();
	var shorturl = $('#shorturl').val();
	if(appkey == ''){
		return xUtil.debug.outputTxt('错误：appkey不能为空！如果不熟悉，请填写4180478377', true);
	}else if(shorturl == ''){
		return xUtil.debug.outputTxt('错误：短链接不能为空！', true);
	}
	
	xModel.sina.runShortUrlCountJsonp(shorturl, appkey);
	xUtil.debug.outputTxt(new Date() + ' xController.sina.getShortUrlCount运行完毕。');
};

xController.sina.displayShortUrl = function (data) {
    alert(data)
	if(data.urls == undefined){
		return xUtil.debug.outputTxt('错误：API报错。', true);
	}
	
	var debugTxt = 'JSONP运行成功！得到短链接：<a href="' + data.urls[0].url_short + '" target="_blank">' + data.urls[0].url_short + '</a>';
	xUtil.debug.outputTxt(debugTxt);
	$('#shorturl').val(data.urls[0].url_short);
	xUtil.debug.outputTxt(new Date() + ' xController.sina.displayShortUrl运行完毕。');
	xController.sina.getShortUrlCount();
};

xController.sina.displayShortUrlCount = function (data) {
    alert(data)
	var debugTxt = 'JSONP运行成功！得到分享数：' + data.urls[0].share_counts;
	xUtil.debug.outputTxt(debugTxt);
	$('#sharecount').html(data.urls[0].share_counts);
	xUtil.debug.outputTxt(new Date() + ' xController.sina.displayShortUrlCount运行完毕。');
};

xController.sina.clearShortUrl = function(){
	$('#sharecount').html(0);
	$('#shorturl').val("");
};

xController.sina.openShareLong = function(){
	xUtil.debug.clearTxt();
	var appkey = $('#appkey').val();
	var longurl = $('#longurl').val();
	if(appkey == ''){
		return xUtil.debug.outputTxt('错误：appkey不能为空！如果不熟悉，请填写4180478377', true);
	}else if(longurl == ''){
		return xUtil.debug.outputTxt('错误：长链接不能为空！', true);
	}
	xController.sina.openShareWindow(longurl, '', appkey);
};

xController.sina.openShareShort = function(){
	xUtil.debug.clearTxt();
	var appkey = $('#appkey').val();
	var shorturl = $('#shorturl').val();
	if(appkey == ''){
		return xUtil.debug.outputTxt('错误：appkey不能为空！如果不熟悉，请填写4180478377', true);
	}else if(shorturl == ''){
		return xUtil.debug.outputTxt('错误：短链接不能为空！', true);
	}
	xController.sina.openShareWindow(shorturl, '#分享#', appkey);
};

xController.sina.openShareWindow = function(url, title, appkey){
	window.open('http://service.t.sina.com.cn/share/share.php?url=' + url + '&appkey=' + appkey + '&title=' + encodeURIComponent(title), '_blank','width=615,height=505');
};

xController.common = {};

xController.common.openLongUrl = function(){
	xUtil.debug.clearTxt();
	var url = $('#longurl').val();
	if(url == ''){
		return xUtil.debug.outputTxt('错误：长链接不能为空！', true);
	}
	window.open(url, '_blank');
};

xController.common.openShortUrl = function(){
	xUtil.debug.clearTxt();
	var url = $('#shorturl').val();
	if(url == ''){
		return xUtil.debug.outputTxt('错误：短链接不能为空！', true);
	}
	window.open(url, '_blank');
};


xModel.sina = {};

xModel.sina.shortUrlcallfunction = 'jsonpshorturl123';
xModel.sina.runShortUrlJsonp = function(longurl, appkey){
	var short_url = "http://gzbusnow.duapp.com/surl/surl_proxy.php";
	var short_data = "source=" + appkey + "&url_long=" + encodeURIComponent(longurl) + "&callback=" + xModel.sina.shortUrlcallfunction;
	var url = short_url + '?' + short_data;
	alert(url)
	console.log(url)
	//xUtil.debug.outputTxt('开始载入JSONP：' + url);
	xUtil.debug.outputTxt('xModel.sina.runShortUrlJsonp 开始载入JSONP');
	jsonp(url,
		    null,
		    function(){
				xUtil.debug.outputTxt(new Date() + ' xModel.sina.runShortUrlJsonp载入JSONP超时！', true);
	    	},
		    function(){
	    		xUtil.debug.outputTxt(new Date() + ' xModel.sina.runShortUrlJsonp载入JSONP失败！', true);
			},
		    function(){
	    		xUtil.debug.outputTxt(new Date() + ' xModel.sina.runShortUrlJsonp载入JSONP成功！');
			}
	);
    
    var createBackurl = "http://101.surl.sinaapp.com/return.html";
	var createBackData = "long=" + encodeURIComponent(longurl) + "&source=" + appkey;
	var createBackurl_final = createBackurl + '?' + createBackData;
	alert(createBackurl_final)
	console.log(createBackurl_final)
	jsonp(createBackurl_final,
		    null,
		    function(){
				
	    	},
		    function(){
	    		
			},
		    function(){
	    		
			}
	);
};

xModel.sina.shortUrlCountcallfunction = 'jsonpshorturlcount123';
xModel.sina.runShortUrlCountJsonp = function(shorturl, appkey){
    return ;
};

function jsonpshorturl123(data){
	xController.sina.displayShortUrl(data);
}

function jsonpshorturlcount123(data){
}

$("#submitsearch").on("click", function(event){xController.sina.getShortUrl();});

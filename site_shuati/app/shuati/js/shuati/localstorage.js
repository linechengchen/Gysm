
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
            var ls = Storage();
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
        console.log(e);
        return 0;
    }
    return 1;
};
var removeLocal = function (key) {
    try {
        if (arguments.length > 0) {
            var ls = Storage();
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
        console.log(e);
    }
};
var getLocal = function (key) {
    //console.log(key);
    var ls = Storage();
    if (ls) {
        var v = ls.getItem(key);
        //console.log(v);
        if (!v) {
            //console.log(v);
            return null;
        }
        if (v.indexOf('obj-') === 0) {
            v = v.slice(4);
            //console.log(v);
            return JSON.parse(v);
        } else if (v.indexOf('str-') === 0) {
            //console.log(v);
            return v.slice(4);
        }
    }
};
//window.localStorage
var Storage = function () {
    var ls = window.localStorage;
    return ls;
};

var createAjax = function () {
    var xhr = null; try {
        //IE系列浏览器
        xhr = new ActiveXObject("microsoft.xmlhttp");
    } catch (e1) {
        try {
            //非IE浏览器
            xhr = new XMLHttpRequest();
        } catch (e2) {
            window.alert("您的浏览器不支持ajax，请更换！");
        }
    } return xhr;
};

var ajax = function (conf) {
    // 初始化 
    //type参数,可选
    var type = conf.type;
    //url参数，必填  
    var url = conf.url;
    //data参数可选，只有在post请求时需要 
    var data = conf.data;
    //datatype参数可选 
    var dataType = conf.dataType;
    //回调函数可选 
    var success = conf.success;
    if (type == null) {
        //type参数可选，默认为get
        type = "get";
    } if (dataType == null) {
        //dataType参数可选，默认为text
        dataType = "text";
    } // 创建ajax引擎对象 
    var xhr = createAjax();
    // 打开 
    xhr.open(type, url, true);
    // 发送 

    if (type == "GET" || type == "get") {
        xhr.send(null);
    } else if (type == "POST" || type == "post") {
        xhr.setRequestHeader("content-type", "application/x-www-form-urlencoded");
        xhr.send(data);
    }
    xhr.onreadystatechange = function () {
        if (xhr.readyState == 4 && xhr.status == 200) {
            if (dataType == "text" || dataType == "TEXT") {
                if (success != null) {
                    //普通文本
                    success(xhr.responseText);
                }
            } else if (dataType == "xml" || dataType == "XML") {
                if (success != null) {
                    //接收xml文档  
                    success(xhr.responseXML);
                }
            } else if (dataType == "json" || dataType == "JSON") {
                if (success != null) {
                    //将json字符串转换为js对象  
                    success(eval("(" + xhr.responseText + ")"));
                }
            }
        }
    };
};

var addEvt = function (el, name, fn, useCapture) {

    useCapture = useCapture || false;
    if (el.addEventListener) {
        el.addEventListener(name, fn, useCapture);
    }
};

//class操作
var hasCls = function (el, cls) {
    if (el.className.indexOf(cls) > -1) {
        return true;
    } else {
        return false;
    }
};
var addCls = function (el, cls) {

    if ('classList' in el) {
        el.classList.add(cls);
    } else {
        var preCls = el.className;
        var newCls = preCls + ' ' + cls;
        el.className = newCls;
    }
    return el;
};
//移除错误的选中效果
var removeCls = function (el, cls) {
    if ('classList' in el) {
        el.classList.remove(cls);
    } else {
        var preCls = el.className;
        var newCls = preCls.replace(cls, '');
        el.className = newCls;
    }
    return el;
};
var getbyId = function (id) {
    return document.getElementById(id);
};

var append = function (el, html) {
    el.insertAdjacentHTML('beforeend', html);
    return el;
};
var mytext = function (el, txt) {
    if (arguments.length === 1) {
        return el.textContent;
    } else if (arguments.length === 2) {
        //alert(el.textContent)
        el.textContent = txt;
        return el;
    }
};
var myhtml = function (el, txt) {
    if (arguments.length === 1) {
        return el.innerHTML;
    } else if (arguments.length === 2) {
        el.innerHTML = txt;
        return el;
    }
};
var isElement = function (obj) {
    return !!(obj && obj.nodeType == 1);
};

var remove = function (el) {
    if (el && el.parentNode) {
        el.parentNode.removeChild(el);
    }
};
var closest = function (el, selector) {
    if (!isElement(el)) {

        return;
    }
    var doms, targetDom;
    var isSame = function (doms, el) {
        var i = 0, len = doms.length;
        for (i; i < len; i++) {
            if (doms[i].isEqualNode(el)) {
                return doms[i];
            }
        }
        return false;
    };
    var traversal = function (el, selector) {
        doms = domAll(el.parentNode, selector);
        targetDom = isSame(doms, el);
        while (!targetDom) {
            el = el.parentNode;
            if (el != null && el.nodeType == el.DOCUMENT_NODE) {
                return false;
            }
            traversal(el, selector);
        }

        return targetDom;
    };

    return traversal(el, selector);
};

var domAll = function (el, selector) {
    if (arguments.length === 1 && typeof arguments[0] == 'string') {
        if (document.querySelectorAll) {
            return document.querySelectorAll(arguments[0]);
        }
    } else if (arguments.length === 2) {
        if (el.querySelectorAll) {
            return el.querySelectorAll(selector);
        }
    }
};

var isAndroid = (/android/gi).test(navigator.appVersion);

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

//function intercept(example, funName, fun) {  //example 遍历对象，funName需要拦截的方法名 ，fun拦截后执行的方法  
//    Object.getOwnPropertyNames(example).forEach(function (property) {
//        var original = example[property];        
//        if (typeof original === "function" && (funName == null || original.name == funName)) {
//            alert(property);
//            example[property] = function () {
//                if (fun) {
//                    fun(property);
//                } else {
//                    return false;
//                }
//                console.log("事件：" + property);
//                original.apply(example, Array.prototype.slice.call(arguments));
//            }
//        }
//    });
//}
//intercept(window, null);

//function AttributeNodeModified(evt) {
//    console.log('AttributeNodeModified' + evt);
//    if (evt.attrName == "href") { } if (evt.attrName == "src") { } if (evt.attrName == "action") {
//        console.clear();        
//    }
//}
//document.addEventListener("DOMAttrModified", AttributeNodeModified, false);

//try {
//    Object.defineProperty(window, "location", { value: window.location, writable: false });
//    //Object.defineProperty(window.location, "href", { value: window.location.href, writable: false });
//    Object.defineProperty(window.location, "href", {
//        get: function () { console.clear(); return window.location.href; },
//        set: function (newValue) { console.clear(); myhref.href = newValue; },
//        enumerable: true,
//        configurable: true
//    });
//    Object.defineProperty(window.location, "hash", {
//        get: function () { console.clear(); return window.location.hash; },
//        set: function (newValue) { console.clear(); window.location.hash = newValue; },
//        enumerable: true,
//        configurable: true
//    });
//} catch (e) {
//    console.log('异常'+e);
//}

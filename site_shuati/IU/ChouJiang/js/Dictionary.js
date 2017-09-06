/**
 * Created by Leo on 2015/4/26.
 */

//var QuestionObject = function (QuestionId, QuestionJson, QuestionIndex) {
//    this.element = {
//        QuestionId: QuestionId,
//        QuestionJson: QuestionJson,
//        QuestionIndex: QuestionIndex
//    };
//}

var Dictionary = function () {
    //var arr = new Array();
    this.elements = new Array();
    this.maxId = 0;
    this.minId = 999999;

    this.addClone = function (Dictionary1) {
        for (var i = 0; i < Dictionary1.elements.length; i++) {
            var e1 = Dictionary1.elements[i];
            this.add(e1.QuestionJson.QuestionId, e1.QuestionJson);
        }
    }
    this.removeLocal = function (localKeyStr) {
        removeLocal(localKeyStr, new Array());
    };
    //this.addLocal = function (localKeyStr) {
    //    var elements1 = getLocal(localKeyStr);
    //    if (elements1 && elements1.length > 0) {
    //        try {
    //            for (var i = 0, iLen = elements1.length ; i < iLen; i++) {
    //                set(elements1[i].QuestionJson.QuestionId, elements1[i].QuestionJson);
    //            }
    //        }
    //        catch (ex) {
    //        }
    //    }
    //    setLocal(localKeyStr, this);
    //};
    this.reSetLocal = function (localKeyStr, QuestionId, QuestionJson) {
        try {
            this.elements = new Array();
            this.add(QuestionId, QuestionJson);
            setLocal(localKeyStr, this);
        }
        catch (ex) {
            console.log(ex);
        }
    };
    this.setLocal1 = function (localKeyStr) {
        setLocal(localKeyStr, this);
    };
    this.getMaxId = function () {
        if (!this.maxId || this.maxId == 0 || this.maxId == NaN)
            try {
                for (var i = 0, iLen = this.length() ; i < iLen; i++) {
                    if (this.elements[i].QuestionJson.QuestionId > this.maxId) {
                        this.maxId = parseInt(this.elements[i].QuestionJson.QuestionId);
                    }
                }
            }
            catch (ex) {
                console.log('getMaxId函数 '+ex);
            }
        return this.maxId;
    }
    this.getMaxIndex = function () {
        if (this.elements && this.elements.length > 0)
            return this.elements[this.elements.length - 1].QuestionIndex;
        return 0;
    }
    this.getMaxItem = function () {
        try {
            if (this.elements && this.elements.length > 0)
                return this.elements[this.elements.length - 1];
        }
        catch (ex) {
            console.log(ex);
        }
        return new Object();
    }
    this.getMinId = function () {
        if (!this.minId || this.minId == 0 || this.minId == NaN)
            try {
                for (var i = 0, iLen = this.length() ; i < iLen; i++) {
                    if (this.elements[i].QuestionJson.QuestionId < this.minId) {
                        this.minId = parseInt(this.elements[i].QuestionJson.QuestionId);
                    }
                }
            }
            catch (ex) {
                console.log('getMaxId函数 ' + ex);
            }
        return this.minId;
    }
    this.parseJsonObj = function (obj1) {
        try {
            if (obj1 && obj1.elements) {
                this.elements = obj1.elements;
                //console.log(obj1.elements.length > 0)
                if (obj1.elements.length > 0) {
                    for (var i = 0, iLen = obj1.elements.length ; i < iLen; i++) {
                        try {
                            //console.log(1111111111111);
                            //console.log(obj1.elements[i].QuestionJson.QuestionId)
                            //console.log(obj1.elements[i].QuestionJson)
                            this.add(obj1.elements[i].QuestionJson.QuestionId, obj1.elements[i].QuestionJson);
                        }
                        catch (ex1) {
                            console.log(ex1);
                        }
                    }
                }
            }
        }
        catch (ex) {
            console.log(ex);
        }
    }
    this.parseJsonStr = function (jsonStr1) {
        var elements1 = null;
        try {
            var obj1 = JSON.parse(jsonStr1);
            this.parseJsonObj(obj1);
        }
        catch (ex) {
            console.log(ex);
        }
    }
    this.getLocal1 = function (localKeyStr) {
        var elements1 = null;
        try {
            var obj1 = getLocal(localKeyStr);
            this.parseJsonObj(obj1);
        }
        catch (ex) {
            console.log(ex);
        }
        //return elements1;
    };
    //Length of Dictionary
    this.length = function () {
        return this.elements.length;
    };
    //Check whether the Dictionary is empty
    this.isEmpty = function () {
        return (this.length() < 1);
    };
    //remove all elements from the Dictionary
    this.removeAll = function () {
        this.elements = new Array();
    };
    //get specify element of the dictionary
    this.element = function (QuestionIndex) {
        var rlt = new Object();
        if (QuestionIndex >= 0 && QuestionIndex < this.elements.length) {
            rlt = this.elements[QuestionIndex];
        }
        return rlt;
    };
    //get specify element of the dictionary
    this.getKey = function (index1) {
        var rlt = null;
        if (index1 >= 0 && index1 < this.elements.length) {
            rlt = this.elements[index1].QuestionJson.QuestionId;
        }
        return rlt;
    };
    //get specify element of the dictionary
    this.getValue = function (index1) {
        var rlt = null;
        if (index1 >= 0 && index1 < this.elements.length) {
            rlt = this.elements[index1].QuestionJson;
        }
        return rlt;
    };
    //get specify element of the dictionary
    this.getIndex = function (index1) {
        var rlt = null;
        if (index1 >= 0 && index1 < this.elements.length) {
            rlt = this.elements[index1];
        }
        return rlt;
    };
    //check whether the Dictionary contains this QuestionId
    this.Exists = function (QuestionId) {
        var rlt = false;
        try {
            for (var i = 0, iLen = this.length() ; i < iLen; i++) {
                if (this.elements[i].QuestionJson.QuestionId == QuestionId) {
                    rlt = true;
                    break;
                }
            }
        }
        catch (ex) {
            console.log(ex);
        }
        return rlt;
    };
    //check whether the Dictionary contains this QuestionJson
    this.containsKey = function (QuestionId) {
        var rlt = false;
        try {
            for (var i = 0, iLen = this.length() ; i < iLen; i++) {
                if (this.elements[i].QuestionJson.QuestionId == QuestionId) {
                    rlt = true;
                    break;
                }
            }
        }
        catch (ex) {
            console.log(ex);
        }
        return rlt;
    };
    //check whether the Dictionary contains this QuestionJson
    this.containsValue = function (QuestionJson) {
        var rlt = false;
        try {
            for (var i = 0, iLen = this.length() ; i < iLen; i++) {
                if (this.elements[i].QuestionJson == QuestionJson) {
                    rlt = true;
                    break;
                }
            }
        }
        catch (ex) {
            console.log(ex);
        }
        return rlt;
    };
    //remove this QuestionId from the Dictionary
    this.remove = function (QuestionId) {
        var rlt = false;
        try {
            for (var i = 0, iLen = this.length() ; i < iLen; i++) {
                if (this.elements[i].QuestionJson.QuestionId == QuestionId) {
                    this.elements.splice(i, 1);//删除从指定位置deletePos开始的指定数量deleteCount的元素，数组形式返回所移除的元素                    
                    rlt = true;
                    break;
                }
            }
        }
        catch (ex) {
            console.log(ex);
        }
        return rlt;
    };
    
    this.addBefore = function (QuestionId, QuestionJson) {
        this.remove(QuestionId);
        this.unshift(QuestionId, QuestionJson, this.elements.length);
    };
    //add this QuestionId/QuestionJson to the Dictionary,if QuestionId is exists,replace the QuestionJson
    this.add = function (QuestionId, QuestionJson) {
        var length1 = this.length();
        if (QuestionId != QuestionJson.QuestionId)
            console.log("QuestionJson内的QuestionId 与外部QuestionId 不一致");
        this.remove(QuestionId);
        this.push(QuestionId, QuestionJson, this.elements.length);
        //arr.push(QuestionId);
        //arr = arr.unique();
        //this.elements = this.elements.unique();
        var length2 = this.length();
        if (length2 > length1)
            return true;
        return false;
    };
    
    this.unshift = function (QuestionId, QuestionJson, QuestionIndex) {   	
        var qq1 = {
            QuestionId: parseInt(QuestionId),
            QuestionJson: QuestionJson,
            QuestionIndex: parseInt(QuestionIndex)
        };

        if (parseInt(QuestionId) > this.maxId)
            this.maxId = parseInt(QuestionId);
        if (parseInt(QuestionId) < this.minId)
            this.minId = parseInt(QuestionId);

        this.elements.unshift(qq1);
    };
    this.push = function (QuestionId, QuestionJson, QuestionIndex) {
        var qq1 = {
            //QuestionId: parseInt(QuestionId),
            QuestionJson: QuestionJson,
            QuestionIndex: parseInt(QuestionIndex)
        };

        if (parseInt(QuestionJson.QuestionId) > this.maxId)
            this.maxId = parseInt(QuestionJson.QuestionId);
        if (parseInt(QuestionJson.QuestionId) < this.minId)
            this.minId = parseInt(QuestionJson.QuestionId);

        //console.log('maxId' + this.maxId);
        //console.log('QuestionId ' + maxId + ' length ' + this.elements.length);

        //if (this.elements.length > QuestionId - 1)
        //    this.elements.splice(QuestionId - 1, 0, qq1);//将一个或多个新元素插入到数组的指定位置，插入位置的元素自动后移，返回""。
        //else
            this.elements.push(qq1);
//          this.elements.sort(function(a, b){
//          		console.log(66);
//          		return a.QuestionId - b.QuestionId
//          });
        //arr.push(QuestionId);
        //arr = arr.unique();
        //this.elements = this.elements.unique();
    };
    //add this QuestionId/QuestionJson to the Dictionary,if QuestionId is exists,append QuestionJson
    this.set = function (QuestionId, QuestionJson) {
        try {
            this.push(QuestionId, QuestionJson, this.elements.length);//zlg移动上来了
            var arr = this.getItem(QuestionId).QuestionJson;
            if (arr && arr != null) {
                //this.remove(QuestionId);
                //if (QuestionJson)
                //    arr = QuestionJson;
                try {
                    if (typeof (arr) == "object") {
                        arr.unshift.apply(arr, QuestionJson);//unshift() 方法可向数组的开头添加一个或更多元素，并返回新的长度。
                        QuestionJson = arr;
                    }
                    else {
                        var array = [];
                        array.push(arr);
                        array.unshift.apply(array, QuestionJson);
                        QuestionJson = array;
                    }
                    this.remove(QuestionId);
                } catch (e1) {
                    console.log(e1);
                }
            }
        } catch (e) {
            console.log(e);
        }
    }
    //get QuestionJson of the QuestionId
    this.getItemAfter = function (QuestionId) {
        var rlt = null;
        try {
            var ret = false;
            for (var i = 0, iLen = this.length() ; i < iLen; i++) {
                if (this.elements[i].QuestionJson.QuestionId == QuestionId) {
                    if (i + 1 < Len)
                        rlt = this.elements[i + 1];
                }
            }
        }
        catch (ex) {
            console.log(ex);
        }
        return rlt;
    };
    //get QuestionJson of the QuestionId
    this.getItemBefore = function (QuestionId) {
        var rlt = null;
        try {
            var ret = false;
            for (var i = 0, iLen = this.length() ; i < iLen; i++) {
                if (this.elements[i].QuestionJson.QuestionId == QuestionId) {
                    if (i - 1 > 0)
                        rlt = this.elements[i - 1];
                }
            }
        }
        catch (ex) {
            console.log(ex);
        }
        return rlt;
    };
    //get QuestionJson of the QuestionId
    this.getItemList = function (lastCacheQuestionJson) {
        var this1, next, prev, prevprev, nextnext, index;
        try {
            if (!lastCacheQuestionJson || !lastCacheQuestionJson.QuestionId) {
                //console.log('错误：lastCacheQuestionJson.QuestionId:null');
                //return null;
                lastCacheQuestionJson = this.elements[0].QuestionJson;
                console.log(lastCacheQuestionJson.QuestionId + '=' + this1.QuestionId);
            }
            for (var i = 0; i < this.elements.length; i++) {
                if (this.elements[i].QuestionJson.QuestionId == parseInt(lastCacheQuestionJson.QuestionId)) {
                    this1 = this.elements[i].QuestionJson;
                    index = i;
                    console.log(index + '==this.elements[i].QuestionJson.QuestionId==' + this.elements[i].QuestionJson.QuestionId)
                    break;
                }
            }
            console.log('getItemList1111111==' + this.elements.length);
            console.log('index:' + index);
            console.log(this.elements[index]);
            if (index == undefined) {
                index = 0;
            }
            if (!lastCacheQuestionJson)
                lastCacheQuestionJson.QuestionId = this.elements[index].QuestionJson.QuestionId

        }
        catch (e) {
            console.log('getItemList函数异常 ' + e);
        }
        try {
            if (index != undefined) {
                if (this.elements[index + 1]) {
                    next = (this.elements[index + 1]).QuestionJson;
                }
                if (this.elements[index + 2]) {
                    nextnext = (this.elements[index + 2]).QuestionJson;
                    console.log('nextnext待增加' + nextnext.QuestionId + '在' + (index + 2));
                }
                if (this.elements[index - 1]) {
                    prev = (this.elements[index - 1]).QuestionJson;
                }
                if (this.elements[index - 2]) {
                    prevprev = (this.elements[index - 2]).QuestionJson;
                    console.log('prevprev待增加' + prevprev.QuestionId + '在' + (index - 2));
                }
            } else
                console.log("错误在这里：index--undefined");

            if (!next && !nextnext) {

                console.log('连续两个下一页题号不存在！！！');
            }
            if (!prev && !prevprev) {

                console.log('连续两个下一页题号不存在！！！');
            }
        }
        catch (e) {
            console.log('getItemList函数异常 ' + e);
        }
        //console.log(rlt);
        //console.log(next);
        //console.log(prev);
        return {
            "prev": prev, "this1": this1, "next": next, "nextnext": nextnext, "prevprev": prevprev,
            "index": index, "minId": this.elements[0].QuestionJson.QuestionId, "maxId": this.elements[this.elements.length - 1].QuestionJson.QuestionId
        };
    };
    //function randomsort(a, b) {
    //    return Math.random() > .5 ? -1 : 1;
    //    //用Math.random()函数生成0~1之间的随机数与0.5比较，返回-1或1  
    //}
    this.sort = function (cutiType, order) {
        if (params.cutiType == "random") {
            //this.elements.sort(function (a, b) {
            //    return b.QuestionId - a.QuestionId
            //});
            this.elements.sort(function (a, b) {
                return Math.random() > .5 ? -1 : 1;
            });
        }
        else {
            this.elements.sort(function (a, b) {
                if (order && order == 1)
                    return b.QuestionJson.AutoId - a.QuestionJson.AutoId;
                else
                    return a.QuestionJson.AutoId - b.QuestionJson.AutoId;
            });
        }
    };
    //get QuestionJson of the QuestionId
    this.getItem = function (QuestionId) {
        var rlt = null;
        try {
            for (var i = 0, iLen = this.length() ; i < iLen; i++) {
                if (this.elements[i].QuestionJson.QuestionId == parseInt(QuestionId)) {
                    rlt = this.elements[i];
                    break;
                }
            }
            console.log('getItem找不到元素啊');
        }
        catch (ex) {
            console.log(ex);
        }
        return rlt;
    };
    
    this.getIndexById = function (questionId) {
        var index;
        try {
        		for (var i = 0; i < this.elements.length; i++) {
        		    if (this.elements[i].QuestionJson.QuestionId == parseInt(questionId)) {
        				index = i;
        				break;
        			}    			
        		}
        }
        catch (ex) {
            console.log(ex);
        }
        return index;
    }    
    this.getItemByIndex = function (index) {
        var rlt = null;
        try {
            rlt = this.elements[index]; return rlt;
        }
        catch (ex) {
            console.log(ex);
        }
        console.log('getItem找不到元素啊');
        return rlt;
    };
    //get all keys of the dictionary
    this.keys = function () {
        var arr = [];
        for (var i = 0, iLen = this.length() ; i < iLen; i++) {
            arr.push(this.elements[i].QuestionJson.QuestionId);
        }
        return arr;
    }
    //get all values of the dictionary
    this.values = function () {
        var arr = [];
        for (var i = 0, iLen = this.length() ; i < iLen; i++) {
            arr.push(this.elements[i].QuestionJson.QuestionJson);
        }
        return arr;
    }
    //get all values of the dictionary
    this.valuesJson = function () {
        var json1 = '';
        for (var i = 0, iLen = this.length() ; i < iLen; i++) {
            json1 += (JSON.stringify(this.elements[i].QuestionJson)) + "|";
        }
        return json1;
    }
}

//// 自定义字典对象  
//function Dictionary() {
//    this.data = new Array();

//    this.put = function (QuestionId, QuestionJson) {
//        this.data[QuestionId] = QuestionJson;
//    };

//    this.get = function (QuestionId) {
//        return this.data[QuestionId];
//    };

//    this.remove = function (QuestionId) {
//        this.data[QuestionId] = null;
//    };

//    this.isEmpty = function () {
//        return this.data.length == 0;
//    };

//    this.size = function () {
//        return this.data.length;
//    };
//}


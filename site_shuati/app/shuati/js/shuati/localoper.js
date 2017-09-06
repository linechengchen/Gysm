

var loadStorage = function (jump_num) {
	//第二次进来的时候，不论是哪个出题类型，都记住题号
    if (window.cutiType != "cuoti") {        
        window.NowIndex = getLocal(window.kemuId + '|' + window.cutiType); 
        if ((!window.NowIndex) || (parseInt(window.NowIndex) > parseInt(window.question_sum)) || (parseInt(window.NowIndex) < 1)) {
            window.NowIndex = 1;
        }
    } else {
        window.NowIndex = getLocal(window.kemuId + '|' + window.cutiType);
        
        if (window.NowIndex == 'undefined') {
            window.NowIndex = 1
        }
    }
    if (jump_num && jump_num != '') {
        //alert(window.NowIndex);
        window.NowIndex = jump_num;
    }
    if (parseInt(window.question_sum) == 0) {
        alert("此分类的题库没有或未录入，请点下方联系我，帮忙补充题库");
        history.go(-1);
        return;
    }
    if (parseInt(window.question_sum) < 6) {
        alert("此分类的题库没有或未录入。暂时是样例题库，请帮忙一起补充题库");
        history.go(-1);
        return;
    }
    ////=
    ////alert(window.NowIndex)
    //switch (window.cutiType) {
    //    case 'sequence':
    //        var url = 'sql.aspx?kemuId=' + window.kemuId + '&kemuId=' + window.kemuId + '&id=' + window.NowIndex + '&type=' + window.cutiType
    //            + "&sc=" + window.sc + "&optiontype=" + window.optiontype + "&jump_num=" + jump_num + "&LastSeq=" + window.LastSeq;
    //        //alert(url);
    //        //showLoading();
    //        ajax({
    //            type: "get",
    //            url: url,
    //            dataType: "json",
    //            success: function (data) {
    //                deal_json(data);
    //                setTimeout("closeLoading();", 400);
    //            }
    //        });
    //        break;
    //    case 'random':
    //        var url = 'sql.aspx?kemuId=' + window.kemuId + '&kemuId=' + window.kemuId + '&type=' + window.cutiType
    //            + "&sc=" + window.sc + "&optiontype=" + window.optiontype + "&jump_num=" + jump_num + "&LastSeq=" + window.LastSeq;
    //        showLoading();
    //        ajax({
    //            type: "get",
    //            url: url,
    //            dataType: "json",
    //            success: function (data) {
    //                deal_json(data);
    //                setTimeout("closeLoading();", 400);
    //            }
    //        });
    //        break;
    //    case 'cuoti':
    //        var url = 'sql.aspx?kemuId=' + window.kemuId + '&kemuId=' + window.kemuId + '&id=' + window.NowIndex + '&type=sequence'
    //            + "&sc=" + window.sc + "&optiontype=" + window.optiontype + "&jump_num=" + jump_num;
    //        showLoading();
    //        ajax({
    //            type: "get",
    //            url: url,
    //            dataType: "json",
    //            success: function (data) {
    //                deal_json(data);
    //                setTimeout("closeLoading();", 400);
    //            }
    //        });
    //        break;
    //}
};

function handleErr(msg, url, l) {
    txt = "看到这个页面，说明神器出现异常，帮忙反馈给帮先生，谢谢.\n\n";
    txt += "Error: " + msg + "\n";
    txt += "URL: " + url + "\n";
    txt += "Line: " + l + "\n\n";
    txt += "Click OK to continue.\n\n";
    alert(txt);
    return true;
};

var deal_json = function (data) {    
    if (data) {
        if (data.length == 0) {
            alert("该类目下没有题目");
            return
        };
        window.rightAn = data.Answer;
        window.NowIndex = data.Id;
        window.Favor = '';
        window.tixing = data.OptionType;

        //
        window.sourcefile = data.SourceFile;
        window.sourceid = data.Sourceid;
        window.jiexi = data.Explain;
        //

        var option = data.OptionStr.split("|");
        addquest(data.Id + "" + data.Question);
        if (window.neice && window.neice != '')
            addneice(window.sourcefile + "==" + data.Answer + "==" + data.sourceid);
        switch (data.OptionType.toString()) {
            case '0':
                var tixing = '单选';
                break;
            case '1':
                var tixing = '多选';
                break;
            case '2':
                var tixing = '判断';
                break;
            case '3':
                var tixing = '论述';
                break;
            default:
                var tixing = '多选';
        }
        addoptions(option, data.OptionType, data.Answer);
        var shuoming1 = getbyId("shuoming");
        myhtml(shuoming1, " （题型:<font style='color:blue'>" + tixing + "</font>）-（总共:" + window.question_sum + "）");//mytext //"题号:" + data.id + 

        var err11 = getbyId("err1");
        removeCls(err11, "aui-icon-favorfill")
        addCls(err11, "aui-icon-favor");
        err11.innerText = "";

        var err0 = getbyId("err0");
        err0.innerText = "";

        var jiexi1 = getbyId("jiexi");
        jiexi1.innerText = "";

        //var num1 = getbyId("num1");
        //num1.innerText = "";
    }
};
  
String.prototype.startWith = function(str){  
    if(str==null||str==""||this.length==0||str.length>this.length)  
        return false;  
    if(this.substr(0,str.length)==str)  
        return true;  
    else  
        return false;  
    return true;  
}  
String.prototype.endWith = function(str){  
    if(str==null||str==""||this.length==0||str.length>this.length)  
        return false;  
    if(this.substring(this.length-str.length)==str)  
        return true;  
    else  
        return false;  
    return true;  
}
String.prototype.contains = function (str1) {
    if (this.indexOf(str1) >= 0) {
        return true;
    }
    return false;
}

//String.prototype.startWith = function (str) {
//    var reg = new RegExp("^" + str);
//    return reg.test(this);
//}

//String.prototype.endWith = function (str) {
//    var reg = new RegExp(str + "$");
//    return reg.test(this);
//}
var addclick = function (el, type, ans_num) {
    var el = getbyId(el);
    switch (type) {
        case false:
            addEvt(el, 'click', function () {
                if (hasCls(el, "aui-btn-danger1")) {
                    removeCls(el, "aui-btn-danger1")
                } else {
                    window.btn_el = el;
                    addCls(el, "aui-btn-danger1");
                    //加入错题数组
                    add_err_list(window.NowIndex);

                    var err11 = getbyId("err1");
                    removeCls(err11, "aui-icon-favor")
                    addCls(err11, "aui-icon-favorfill");

                    if (!el.innerHTML.endWith('×'))
                        el.innerHTML = el.innerHTML + "&nbsp;&nbsp;×";

                    //alert(err11.innerText); alert(el.innerHTML[0]);
                    if (!err11.innerText.contains(el.innerHTML[0])) {
                        err11.innerText = err11.innerText + el.innerHTML[0];
                    }
                    //setTimeout("removeCls(window.btn_el, 'aui-btn-danger1');", 250);
                    var err0 = getbyId("err0");
                    if (err0.innerText == '')
                        err0.innerText = "选错";
                }
            });
            break;
        case true:
            addEvt(el, 'click', function () {
                var color1 = "aui-btn-success";
                if (hasCls(el, color1)) {
                    removeCls(el, color1)
                } else {
                    if (!el.innerHTML.endWith('√</font>'))
                        el.innerHTML = el.innerHTML + "&nbsp;&nbsp;<font color='blue'>√</font>";
                    addCls(el, color1);
                    var sle_arr_1 = domAll('.' + color1);
                    //
                    if (sle_arr_1.length == ans_num) {
                        if (window.cutiType == "cuoti") {//我的错题
                            remove_err_list(window.NowIndex);
                        }
                        else {
                        }

                        var err11 = getbyId("err1");
                        var len1 = lenzimu(err11.innerText);
                        var err0 = getbyId("err0");
                        if (len1 > 1) {
                            //err0.innerText = "请温习";
                            //if (window.jumpEnd1 != '1')
                            //    setTimeout("swiper.slideTo(2, 299, true);", 3500);//250
                        } else if (len1 > 0) {
                            //err0.innerText = "请温习";
                            //if (window.jumpEnd1 != '1')
                            //    setTimeout("swiper.slideTo(2, 299, true);", 3000);//250
                        } else {
                            if (window.jumpEnd1 != '1') {
                                setTimeout("swiper.slideTo(2, 299, true);", 599);//250
                            }
                        }
                        if (len1 > 0) {
                            var jiexi1 = getbyId("jiexi");
                            jiexi1.innerHTML = "";
                            if (window.rightAn && window.rightAn != '') {
                                var jiexi1 = getbyId("jiexi"); //alert(jiexi1.innerText)
                                jiexi1.innerHTML += '&nbsp;&nbsp;&nbsp;&nbsp;答案:<br />&nbsp;&nbsp;&nbsp;&nbsp;<font color="red">'
                                    + getAnList(window.tixing, window.rightAn) + "</font>【请向左滑进入下一题】";//jiexi1.innerText.replace('{解析}', window.jiexi);
                            }
                            if (window.jiexi && window.jiexi != '') {
                                var jiexi1 = getbyId("jiexi"); //alert(jiexi1.innerText)
                                var len1 = len(window.jiexi);

                                jiexi1.innerHTML += '<br />&nbsp;&nbsp;&nbsp;&nbsp;<font color="green">解析:<br />&nbsp;&nbsp;&nbsp;&nbsp;'
                                    + window.jiexi + "</font>";//jiexi1.innerText.replace('{解析}', window.jiexi);

                                var swiper1 = getbyId("swiper1");
                                if (len1 > 1000) {
                                    swiper1.style.height = "1000px";
                                }
                                else if (len1 > 500) {
                                    swiper1.style.height = "900px";
                                }
                                else if (len1 > 300) {
                                    swiper1.style.height = "850px";
                                }
                                else if (len1 > 200) {
                                    swiper1.style.height = "800px";
                                }
                                else if (len1 > 100) {
                                    swiper1.style.height = "750px";
                                }
                            }
                        }
                    }
                }
            });
            break;
    }
};

function getAnList(tixing, answer1) {
    var l = '';
    var a = answer1.split("");
    for (var i = 0; i < a.length; i++) {
        l += getAn(tixing, a[i]);
    }
    return l;
}
var getAn = function (tixing, answer1) {
    if (answer1 == '1') {
        if (tixing == '2')
            return "对";
        else
            return "A";
    }
    if (answer1 == '2') {
        if (tixing == '2')
            return "错";
        else
            return "B";
    }
    if (answer1 == '3')
        return "C";
    if (answer1 == '4')
        return "D";
    if (answer1 == '5')
        return "E";
    if (answer1 == '6')
        return "F";
}
var addoptions = function (option, type, answer) {
    var html1 = '<li class="aui-list-view-cell" data-win="list_arrow">';
    var html2 = '<a class="aui-text-left aui-ellipsis-1  aui-btn " id="btn';
    var html3 = '">';
    var html4 = '</a></li>';
    switch (type) {
        case '0'://单选
            for (var i = 0; i < option.length; i++) {
                var html = html1 + html2 + i.toString() + html3 + option[i] + html4;

                append(getbyId('answerid'), html);
                if (i == (answer - 1)) {
                    //alert('dui') 复习模式
                    addclick("btn" + i, true, 1);
                } else {
                    //alert('cuo')
                    addclick("btn" + i, false);
                };
            };
            break;
        case '1'://多选
            for (var i = 0; i < option.length; i++) {
                var html = html1 + html2 + i.toString() + html3 + option[i] + html4;
                append(getbyId('answerid'), html);

                if (check_num((i + 1), answer)) {
                    addclick("btn" + i, true, answer.length);
                } else {
                    addclick("btn" + i, false);
                };
            };
            break;
        case '2'://判断
            for (var i = 0; i < 2; i++) {
                var t = "错";
                if (i == 0) {
                    t = "对";
                };
                var html = html1 + html2 + i.toString() + html3 + t + html4;
                append(getbyId('answerid'), html);
                if (i == (answer - 1)) {
                    addclick("btn" + i, true, 1);
                } else {
                    addclick("btn" + i, false);
                };
            };
            break;
        case '3'://论述
            for (var i = 0; i < option.length; i++) {
                var html = html1 + html2 + i.toString() + html3 + option[i] + html4;
                append(getbyId('answerid'), html);
                if (i == (answer - 1)) {
                    //alert('dui') 复习模式
                    addclick("btn" + i, true, 1);
                } else {
                    //alert('cuo')
                    addclick("btn" + i, true);//无论怎样都进入下一题
                };
            };
            break;
        default://多选
            for (var i = 0; i < option.length; i++) {
                var html = html1 + html2 + i.toString() + html3 + option[i] + html4;
                append(getbyId('answerid'), html);

                if (check_num((i + 1), answer)) {
                    addclick("btn" + i, true, answer.length);
                } else {
                    addclick("btn" + i, false);
                };
            };
            break;
    };
};
function len(s) {
    var l = 0;
    var a = s.split("");
    for (var i = 0; i < a.length; i++) {        
        if (a[i].charCodeAt(0) < 299) {
            l++;
        } else {
            l += 2;
        }
    }
    return l;
}
function lenzimu(s) {
    var l = 0;
    var a = s.split("");    
    return a.length;
}
var addneice = function (neice) {
    try {
        //alert(neice);
        mytext(getbyId('neice'), neice);
    }
    catch (error) {
        //alert(111);
    }
    finally {
    }
};
var addquest = function (question) {
    try {
        var que1 = getbyId('question');
        var span1 = getbyId('span1');
        mytext(que1, question);
        //alert(que1.style.height);//300px
        var len1 = len(question);
        que1.style.height = "300px";
        getbyId('question').style.fontSize = '15px';
        if (len1 > 501) {
            que1.style.height = "400px";
            span1.style.height = "0px";//默认70
        } else if (len1 > 401) {
            span1.style.height = "10px";//默认70
        } else if (len1 > 301) {
            span1.style.height = "20px";//默认70
        } else if (len1 > 301) {
            span1.style.height = "30px";//默认70
        } else if (len1 > 201) {
            span1.style.height = "50px";//默认70
        } else if (len1 > 101) {
            span1.style.height = "70px";//默认70
        } else
            span1.style.height = "90px";//默认70
        
        if (len1 > 601) {
            que1.style.fontSize = '10px';
        } else if (len1 > 501) {
            que1.style.fontSize = '11px';
        } else if (len1 > 401) {
            que1.style.fontSize = '14px';
        }
        //text(getbyId('question2'), question);
    }
    catch (error) {
        //alert(111);
    }
    finally {
    }
};
var check_num = function (num, num2) {
    var num = num.toString();
    var num2 = num2.toString();
    for (var i = 0; i < num2.length; i++) {
        if (num == num2.charAt(i)) {
            return true;
        }
    }
};

function ChangePage1() {
    for (var i = 0; i < 8; i++) {
        remove(closest(document.getElementById("btn" + i.toString()), ".aui-list-view-cell"))
    }
    window.LastSeq = '1';
    //alert('ChangePage');
    loadStorage();
};
function ChangePage2() {
    for (var i = 0; i < 8; i++) {
        remove(closest(document.getElementById("btn" + i.toString()), ".aui-list-view-cell"))
    }
    //alert('ChangePage');
    window.LastSeq = '';
    loadStorage();
};

////jmp1 上面
//var jump = function () {
//    var num = parseInt(prompt("请输入要选择的题号", '50'));
//    if (1 <= num && num <= window.question_sum) {
//        for (var i = 0; i < 8; i++) {
//            remove(closest(document.getElementById("btn" + i.toString()), ".aui-list-view-cell"));
//        }
//        //alert('jump')
//        loadStorage(num);
//    } else if (num > window.question_sum) {
//        alert("题号超过题库最大值=" + window.question_sum);
//    }
//};
//function jump1() {
//    var num = parseInt(prompt("请输入跳转的题号", '1'));
//    if (1 <= num && num <= window.question_sum) {
//        for (var i = 0; i < 8; i++) {
//            remove(closest(document.getElementById("btn" + i.toString()), ".aui-list-view-cell"));
//        }
//        //alert('jump1')
//        loadStorage(num);
//    } else if (num > window.question_sum) {
//        alert("题号超过题库最大值=" + window.question_sum);
//    }
//};
//function jumpEnd()
//{
//    var jumpEnd1 = getbyId("jumpEnd1");
//    if (window.jumpEnd1 != '1') {
//        window.jumpEnd1 = '1';
//        jumpEnd1.innerText = "自动模式";
//        alert('切换为手动刷题模式，右滑进下一题');
//    }
//    else {
//        window.jumpEnd1 = '0';
//        jumpEnd1.innerText = "手动模式";
//        //alert('已切换为自动刷题模式');
//    }
//}


var getLocalArray = function (kemuId) {
    str = getLocal(kemuId);//马克思错题题号列表
    if (str != undefined) {
        arr = JSON.parse(str);//
    } else {
        arr = new Dictionary()
    }
    return arr
}

///////////////////////////////////////缓存错题题号
var get_err_list = function () {//function (num) {
	var arr;
    str = getLocal("err_list" + window.kemuId);//马克思错误列表

    if (str != undefined) {
        arr = JSON.parse(str);//
    } else {
        arr = new Array()
    }
    return arr
}
function clear_err_list(num) {
    err_list = get_err_list();
    for (var i = 0; i < err_list.length; i++) {
        err_list.remove(i)
    }
    console.log('清理err_list-' + JSON.stringify(err_list));
    setLocal("err_list" + window.kemuId, JSON.stringify(err_list))
};
function remove_err_list(num) {
    err_list = get_err_list();
    for (var i = 0; i < err_list.length; i++) {
        if (err_list[i] == num) {
            err_list.remove(i)
            break;
        }
    }
    setLocal("err_list" + window.kemuId, JSON.stringify(err_list))
};
//一个科目一个错题列表
function add_err_list(num) {
    err_list = get_err_list();
    err_list.push(num);
    err_list = err_list.unique();
    setLocal("err_list" + window.kemuId, JSON.stringify(err_list))
};
///////////////////////////////////////缓存所有题目
function remove_all_list(num) {
    all_list = get_all_list();
    for (var i = 0; i < all_list.length; i++) {
        if (all_list[i] == num) {
            all_list.remove(i)
            break;
        }
    }
    setLocal("all_list" + window.kemuId, JSON.stringify(all_list))
};
function clear_all_list(num) {
    all_list = get_all_list();
    for (var i = 0; i < all_list.length; i++) {
        all_list.remove(i);
    }
    setLocal("all_list" + window.kemuId, JSON.stringify(all_list))
};
var get_all_list = function (kemuId) {
    str = getLocal("all_list" + window.kemuId);//马克思错题题号列表
    if (str != undefined) {
        arr = JSON.parse(str);//
    } else {
        arr = new Array()
    }
    return arr
}
//一个科目一个错题列表
function add_all_list(questionsData1) {
    all_list = get_all_list();
    all_list.push(questionsData1);
    all_list = all_list.unique();
    setLocal("all_list" + window.kemuId, JSON.stringify(all_list))
};
///////////////////////////////////////缓存单个题目


Array.prototype.unique = function () {
    var res = [],
        hash = {};
    for (var i = 0, elem;
    (elem = this[i]) != null; i++) {
        if (!hash[elem]) {
            res.push(elem);
            hash[elem] = true;
        }
    }
    return res;
};
Array.prototype.remove = function (dx) {
    if (isNaN(dx) || dx > this.length) {
        return false;
    }
    for (var i = 0, n = 0; i < this.length; i++) {
        if (this[i] != this[dx]) {
            this[n++] = this[i]
        }
    }
    this.length -= 1
};

//var swiper = new Swiper('.swiper-container', {
//    noSwiping: true,
//    resistanceRatio: 0,
//    initialSlide: 1,
//    onSlideChangeEnd: function (swiper) {
//        if (swiper.progress == 0) {
//            //上一题
//            if (window.cutiType == "cuoti") {
//                var arr = get_err_list();
//                var num = arr.indexOf(window.NowIndex)
//                if (arr[num - 1] == undefined) {
//                    //alert(arr[num - 1]); alert(arr[num])
//                    if (arr[num] == undefined) {
//                        alert("您还没有错题哦")
//                        window.history.go(-1);
//                    } else {
//                        alert("这是第一题，前面没有了！请往后做题")
//                        setLocal(window.kemuId + '|' + window.cutiType, arr[num])
//                    }
//                } else {
//                    setLocal(window.kemuId + '|' + window.cutiType, arr[num - 1])
//                }
//            } else {
//                setLocal(window.kemuId + '|' + window.cutiType, parseInt(window.NowIndex) - 1)
//            }
//            ChangePage1();
//        } else if (swiper.progress == 1) {
//            //下一题
//            if (window.cutiType == "cuoti") {
//                var arr = get_err_list();
//                var num = arr.indexOf(window.NowIndex)
//                if (arr[num + 1] == undefined) {
//                    //alert(arr[num + 1]); alert(arr[num])
//                    if (arr[num] == undefined) {
//                        alert("您还没有错题哦");
//                        window.history.go(-1);
//                    } else {
//                        alert("这是最后一题，后面没有了！恭喜你 错题已做完！");
//                        setLocal(window.kemuId + '|' + window.cutiType, arr[num]);
//                    }
//                } else {
//                    setLocal(window.kemuId + '|' + window.cutiType, arr[num + 1]);
//                }
//            } else {
//                setLocal(window.kemuId + '|' + window.cutiType, parseInt(window.NowIndex) + 1);
//            }
//            ChangePage2();
//        } else {
//            //alert(swiper.progress)==0.5
//            ChangePage2();
//        }
//        swiper.slideTo(1, 299, false);//250
//    }
//});

function showLoading() {
    getbyId("over").style.display = "block";
    getbyId("layout").style.display = "block";
}

function closeLoading() {
    getbyId("over").style.display = "none";
    getbyId("layout").style.display = "none";
}

function post_error() {
    getbyId("over").style.display = "none";
    getbyId("layout").style.display = "none";
}
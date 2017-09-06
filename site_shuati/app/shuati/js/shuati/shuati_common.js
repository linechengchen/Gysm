//  Copyright 版权.
// 
'use strict'
var fetchNextQuestion,
	fetchCacheLastQuestion,
	fetchQuestions,
    fetchErrQuestions,
	fetchZs,
	fetchComment,
	fetchTopic,
	addQuestionToDomAfter,
	addQuestionToDomBefore,
	removeQuestionBeforeDom,
	removeQuestionAfterDom,
	//list页面
	fetchTimuTypeListPage,
    addOptionListToDomAfter,
    addQuestionOptionToDom,
    fetchwxUserInfo,
    postErrTimu,
    postTUserZsInfo,
    postJiuCuo,
    testAlert;

	//  ========== 
	//  = 依赖mui 方法 = 
	//  ========== 
(function ($, doc) {
    testAlert = function () {//测试
        alert('1');
    }
    //提交纠错
    postJiuCuo = function (options, callback) {
        options = options || {};
        options.r = 1;
        var data1 = transJsonToQuery(options);
        console.log('params22.data1:' + data1);
        console.log('postJiuCuo提交纠错')
        $.ajax(siteUrlJson + 'postJiuCuo.aspx', {
            data: data1,
            dataType: 'json',
            type: 'POST', //HTTP请求类型
            timeout: 20000, //超时时间设置为10秒；
            headers: {
                'Content-Type': 'application/json'
            },
            success: function (data) {
                //console.log(data);
                data = de1(data);
                callback && callback(data);
            },
        });
    };
    //提交错题
    postErrTimu = function (options, callback) {
        options = options || {};
        options.r = 1;
        var data1 = transJsonToQuery(options);
        console.log('postErrTimu提交错题')
        $.ajax(siteUrlJson + 'PostListTimuError.aspx', {
            data: data1,
            dataType: 'json',
            type: 'POST', //HTTP请求类型
            timeout: 20000, //超时时间设置为10秒；
            headers: {
                'Content-Type': 'application/json'
            },
            success: function (data) {
                //console.log(data);
                data = de1(data);
                callback && callback(data);
            },
        });
    };
    
    //获取微信信息
    fetchwxUserInfo = function (options, callback) {
        var data1 = transJsonToQuery(options);
        $.ajax(siteUrlJson.replace('Json','wxInfo') + 'getUser.aspx', {
            data: data1,
            dataType: 'json',
            type: 'get', //HTTP请求类型
            timeout: 20000, //超时时间设置为10秒；
            headers: {
                'Content-Type': 'application/json'
            },
            success: function (data) {
                //console.log(data);
                data = de1(data);
                callback && callback(data);
            },
        });
    };
    		

    // 请求题目方法
		fetchErrQuestions = function (options, callback) {
		    options = options || {};
		    options.kemuId = options.kemuId || '200001';

		    var data1 = transJsonToQuery(options);
		    console.log('fetchErrQuestions:' + data1);
		    var url1 = 'fetchErrQuestions:' + data1;
		    var ajax1 = getSession(url1); if (ajax1) return callback && callback(ajax1);

		    $.ajax(siteUrlJson + 'ListTimuError.aspx', {
		        data: data1,
		        dataType: 'json',
		        type: 'get', //HTTP请求类型
		        timeout: 20000, //超时时间设置为10秒
		        headers: {
		            'Content-Type': 'application/json'
		        },
		        success: function (data) {
		            //console.log(data);
		            data = de1(data);
		            callback && callback(data); setSession(url1, data);
		        },
		    });
		}

        // 请求评论方法
		fetchComment = function (options, callback) {
		    options = options || {};
		    options.kemuId = options.kemuId || '100001';
		    options.cutiType = options.cutiType || 'sequence'; //错题类型
		    options.sc = options.sc || '999';
		    options.optionType = options.optionType || '';
		    options.commentId = options.commentId || '100';

		    var data1 = transJsonToQuery(options);
		    console.log('fetchComment:' + data1);
		    var url1 = 'fetchComment:' + data1;
		    var ajax1 = getSession(url1); if (ajax1) return callback && callback(ajax1);

		    $.ajax(siteUrlJson + 'ListComments.aspx', {
		        data: data1,
		        dataType: 'json',
		        type: 'get', //HTTP请求类型
		        timeout: 15000, //超时时间设置为10秒；
		        headers: {
		            'Content-Type': 'application/json'
		        },
		        success: function (data) {
		            //console.log(data);
		            data = de1(data);
		            callback && callback(data); setSession(url1, data);
		        },
		    });
		}

		// 请求题目方法
		fetchQuestions = function (options, callback) {
			options = options || {};
			options.kemuId = options.kemuId || '200001';
			options.cutiType = options.cutiType || 'sequence'; //错题类型
			options.sc = options.sc || '999';
			options.optionType = options.optionType || ''; 

			var data1 = transJsonToQuery(options);
			console.log('fetchQuestions:' + data1);
			var url1 = 'fetchQuestions:' + data1;
            
            //zlg
			var ajax1 = getSession(url1); if (ajax1) return callback && callback(ajax1);

			$.ajax(siteUrlJson + 'ListTimu.aspx', {
				data: data1,
				dataType: 'text',
				type: 'get', //HTTP请求类型
				timeout: 15000, //超时时间设置为10秒；
				headers: {
					'Content-Type': 'application/json'
				},
				success: function(data) {
////					console.log(data);
//					var str = data.slice(0,8) + data.slice(32)
////					console.log(str);
				    // var cctest = AesCtr.decrypt(str, '616818bcdef67890', 128)
				    data = de1(data);
					//console.log(cctest)
				    callback && callback(data);
				    //for (var i = 0; i < 1000000; i++)//测试缓存区
				    //    setSession(url1 + i, data);
				    if (data && data.code && data.code == '200' && data.data && data.data.St_TTimuDaXue)
				        setSession(url1, data);
				},
			});
		}
		addQuestionOptionToDom = function (data) {
		    //console.log('5555555555')
		    if (data.OptionStr)//data.OptionType == '0' || data.OptionType == '1' || data.OptionType == '4'
		    {
		        data.optionArr = transOptionstrToArray(data.OptionStr, data.OptionType);
		    }
		    else if (data.OptionType == '2')//判断题
		    {
		        data.optionArr = transOptionstrToArray('A.对|B.错', data.OptionType);
		    }
		    else// if (data.OptionType == '3')//论述题
		    {
		        //|C.再给个提示
		        data.optionArr = transOptionstrToArray('A.我会，直接过|B.我不熟悉，给个提示', data.OptionType);
		        if (data.Answer.length > 0 ) {//&& data.Answer[0] != '1'
		            var tishi1 = data.Answer.substring(0, 10);
		            var tishi2 = data.Answer.substring(10);
		            data.Answer = '1|' + tishi1 + "|" + tishi2;
		        }
		    }
		    data.Question = data.Question.trim();
		    //修改Answer从字母到数字
		    var optionStr = 'abcdefgh';
		    var str = data.Answer;
		    var answer2 ='';
		    for (var i = 0; i < str.length; i++) {
		        //console.log('index1:' + index1);
		        if (optionStr.indexOf(str[i]) != -1) {
		            //    if (optionStr[str[i] - 1]) {
		            answer2 += optionStr.indexOf(str[i]) + 1;
		            //    }
		        } else
		            break;
		    }
		    if (answer2.length > 0) {
		        data.Answer = answer2;
		        //console.log(data.Answer);
		    }
		    if (!data.questionid_min && params.questionid_min)
		        data.questionid_min = params.questionid_min;
		    if (!data.questionid_max && params.questionid_max)
		        data.questionid_max = params.questionid_max;
		};
		// 生成html
		addQuestionToDomAfter = function(data) {
		    try {
		        if (data) {
			        addQuestionOptionToDom(data);
					var html = template('question-detail-tpl', data);
					window.stSwiper.appendSlide(html);
					//console.log(data.AutoId);
					//window.stSwiper.slides[window.stSwiper.slides.length - 1].title = data.QuestionId;
				} else
					console.log(data);
			} catch(e) {
				console.log('addQuestionToDomAfter函数' + e);
				console.log(data);
			}
		}

		// 插入一个旧html，生成html
		addQuestionToDomBefore = function(data) {
		    try {
		        //console.log('977777777777777')
				if(data) {
				    addQuestionOptionToDom(data);
					var html = template('question-detail-tpl', data);
					window.stSwiper.prependSlide(html);
					//window.stSwiper.slides[0].title = data.QuestionId;
				}
			} catch(e) {
				console.log('addQuestionToDomBefore函数' + e);
				console.log(data);
			}
		}

		// 生成html
		removeQuestionAfterDom = function() {
			var children = $('.question-detail');
			var child = children[children.length - 1];
			doc.getElementById('sliderContent').removeChild(child);
		}

		// 生成html
		removeQuestionBeforeDom = function() {
			var child = $('.question-detail')[0];
			doc.getElementById('sliderContent').removeChild(child);
		}

	}(mui, document));


	//  ========== 
	//  = 不依赖 mui，document的 function = 
    //  ========== 

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
var cloneObj = function (obj) {
    var newobj = obj.constructor === Object ? {} : [];
    if (typeof JSON === 'object') {
        var s = JSON.stringify(obj), //系列化对象
		newobj = JSON.parse(s); //反系列化（还原）
    } else {
        if (newobj.constructor === Array) {
            newobj.concat(obj);
        } else {
            for (var i in obj) {
                newobj[i] = obj[i];
            }
        }
    }
    return newobj;
}
var deepCopy = function(source) { 
    var result={};
    for (var key in source) {
        result[key] = typeof source[key] === 'object' ? deepCopy(source[key]) : source[key];
    } 
    return result; 
}

var transOptionstrToArray = function (str, OptionType) {
	try {
	    var option = str.split('|');
	    if (isNotNull(option) && option.length < 2)
	        option = str.split(';');
	    var optionStr = 'ABCDEFGH';
	    var optionStr2 = '.、,． ';
		//A.培养德智体美全面发展的人才|B.培养德智体美全面发展的社会主义建设者|C.培养德智体美全面发展的社会主义建设者和接班人|D.培养德智体美全面发展的国家接班人
		option = option.map(function(value, i) {
			var obj = {};
			var arr;
			if (optionStr.indexOf(value[0]) != -1) {
			    arr = value.substr(1);
			    if (arr && optionStr.indexOf(arr[0]) != -1) {
			        arr = arr.substr(1);
			        if (arr && optionStr.indexOf(arr[0]) != -1)
			            arr = arr.substr(1);
			    }
			    if (arr && optionStr2.indexOf(arr[0]) != -1) {
			        arr = arr.substr(1);
			        if (arr && optionStr2.indexOf(arr[0]) != -1)
			            arr = arr.substr(1);
			    }
			}
		    if (!arr) {
		        arr = value;
		    }
		    obj.selection = optionStr[i];
		    if (OptionType == 2)
		    {
		        if (optionStr[i] == "A") obj.selection = "1";
		        if (optionStr[i] == "B") obj.selection = "2";
		    }
			obj.text = arr;
			obj.id = i;
			return obj
		});
		return option;
	} catch(e) {
		console.log('transOptionstrToArray函数' + e + '==' + str);
	}
}

//初始化答题结果字段
var initAnswerResult = function (questionsDic, questionsData1, QuestionIndex) {
	for(var i = 0; i < questionsData1.length; i++) {
		if(questionsData1 && questionsData1[i].optionStr != '') {
			if(!questionsData1[i].AnswerResult) {//最新的答题结果
				questionsData1[i].AnswerResult = '';
			}
			if (!questionsData1[i].AnswerRecord) {//最新的答题记录
			    questionsData1[i].AnswerRecord = '';
			}
			if (!questionsData1[i].AnswerCount) {//答题次数
			    questionsData1[i].AnswerCount = 0;
			}

		    //存在判断题，简答题
			//if(questionsData1[i].OptionStr == '') {
			//    //console.log(questionsData1[i].AutoId + "=AutoId=QuestionId=" + questionsData1[i].QuestionId);
			//	continue;
			//}
			var question1 = questionsDic.getValue(questionsData1[i].QuestionId);
			if(!question1) {
				questionsDic.add(questionsData1[i].QuestionId, questionsData1[i]);
				//console.log('maxId' + questionsDic.maxId);
				//console.log('增加题目：' + questionsData1[i].AutoId);
			} else {
				if(question1.Question != questionsData1[i].Question || question1.OptionStr != questionsData1[i].OptionStr)
					questionsDic.add(questionsData1[i].QuestionId, questionsData1[i]);
			}
			//if (!questionsData1[i].QuestionIndex)
			    questionsData1[i].QuestionIndex = i;//questionsDic.length();
			//else
			//    questionsData1[i].QuestionIndex = parseInt(questionsData1[i].QuestionIndex);
			//if (!questionsDic.elements[questionsDic.length() - 1].QuestionIndex) {
			//    //增加一个模拟题号
			//    questionsData1[i].QuestionIndex = questionsDic.length();
			//}
			//else {
			//    questionsData1[i].QuestionIndex = questionsDic.elements[questionsDic.length() - 1].QuestionIndex + 1;
			//    //add_one_list(questionsData1[i].AutoId, questionsData1[i]);
			//}
			    console.log('QuestionIndex:' + QuestionIndex)
			if (!QuestionIndex) 
			    questionsData1[i].QuestionIndex += QuestionIndex
		}
	}
	//return questionsDic;
}

////初始化答题结果字段
//var initAnswerResultBefore = function(questionsDic, questionsData1) {
//	for(var i = questionsData1.length - 1; i >= 0; i--) {
//		if(questionsData1 && questionsData1[i].optionStr != '') {
//			if(!questionsData1[i].AnswerResult) {
//				questionsData1[i].AnswerResult = '';
//				//检查选项总数 是否与正确选择一样多。
//				//questionsData1[i].answer_sum = questionsData1[i].answer.length;
//			}
//			//增加一个模拟题号
//			questionsData1[i].QuestionIndex = i;

//			if(questionsData1[i].OptionStr == '') {
//			    //console.log(questionsData1[i].AutoId + "=AutoId=QuestionId=" + questionsData1[i].QuestionId);
//				continue;
//			}

//			var question1 = questionsDic.getValue(questionsData1[i].QuestionId);
//			if(!question1) {
//				questionsDic.addBefore(questionsData1[i].QuestionId, questionsData1[i]);

//				//console.log('maxId' + questionsDic.maxId);
//				//console.log('增加题目：' + questionsData1[i].AutoId);
//			} else {
//				if(question1.Question != questionsData1[i].Question || question1.OptionStr != questionsData1[i].OptionStr)
//					questionsDic.addBefore(questionsData1[i].QuestionId, questionsData1[i]);
//			}
//			//add_one_list(questionsData1[i].AutoId, questionsData1[i]);
//		}
//	}
//	//return questionsDic;
//}

var log = function(question1, msg) {
	if(question1 && question1) {
		if(msg) //' QuestionIndex:' + question1.QuestionIndex + 
			console.log(msg + ' 显示题号:' + question1.AutoId + '     questionId:' + question1.QuestionId);
		else
			console.log('显示题号:' + question1.AutoId + '      questionId:' + question1.QuestionId);
	}
}
var showAnswered = function (dom) {
    try {
        var rAnswers = dom.parentNode.childNodes;
        for (var i = 0; i < rAnswers.length; i++) {
            //console.log('rAnswers[i].' + rAnswers[i].className);
            if (rAnswers[i].classList && !rAnswers[i].classList.contains('has-answered')) {
                var icon;
                for (var j = 0; j < rAnswers[i].childNodes.length; j++) {
                    if (!rAnswers[i]) continue;
                    var classStr = rAnswers[i].childNodes[j].className || '';
                    if (classStr.indexOf('circle-box') > -1) {
                        icon = rAnswers[i].childNodes[j];
                        break;
                    }
                }
                var anstr = 'success';
                if (rAnswers[i].classList.contains('answer-err'))
                    anstr = 'error';
                if (icon && icon.className) {
                    if (!icon.className.contains(anstr))
                        icon.className = icon.className + ' ' + anstr; //success//error
                }
                rAnswers[i].classList.add('has-answered');
            }
        }
    }catch(e)
    { console.log(e);}
}
//答题
var answered = function(dom, anstr, answerItem) {
	var icon;
	if (!dom.classList.contains('answer-did')) {//如果是非正确的选项，显示 试题解析
	    //if (lastCacheQuestionJson.OptionType == 1)
	    //{
	    //    setTimeout(function () {
	    //        dom.parentNode.nextElementSibling.classList.add('show'); //nextElementSibling nextSibling 是获取元素的同级下个节点。适应ie8以下
	    //    }, 2000);
	    //}else
	    //    dom.parentNode.nextElementSibling.classList.add('show');
	}
	for(var i = 0; i < dom.childNodes.length; i++) {
		var classStr = dom.childNodes[i].className || '';
		if(classStr.indexOf('circle-box') > -1) {
			icon = dom.childNodes[i];
			break
		}
	}
    //显示结果样式
	if (!icon.className.contains(anstr))
	    icon.className = icon.className + ' ' + anstr; //success//error
	else
	    icon.className = icon.className.replace(anstr, ''); //success//error

    //if(answerItem.AnswerResult) {//已经回答过了，不触发事件。
	//    return -1;//异常
	//} else
	{
		//答题正确
	    if (anstr == 'success') {
	        if (!dom.classList.contains('has-answered'))
	            dom.classList.add('has-answered');
	        else {
	            dom.classList.remove('has-answered');
	        }
			var rAnswers = dom.parentNode.getElementsByClassName('answer-did');
			for(var i = 0; i < rAnswers.length; i++) {
				if(!rAnswers[i].classList.contains('has-answered')) {
					//多项情况下还未完全作答
				    return 0;//未完全作答
				}
			}
	        //缓存答题结果
			answerItem.AnswerResult = 'right';

			var rAnswers2 = dom.parentNode.getElementsByClassName('answer-err');
			console.log('rAnswers2.length' + rAnswers2.length)
			for (var i = 0; i < rAnswers2.length; i++) {
			    if (rAnswers2[i].classList.contains('has-answered')) {
			        //多项情况下还未完全作答
			        return 2;//除了对的答案，还有错误的答案
			    }
			} 
			return 1 //所有都答对
		//答题错误	
	    } else if (anstr == 'error') {
	        if (!dom.classList.contains('has-answered')) {
	            dom.classList.add('has-answered');
	        }
	        else {
	            dom.classList.remove('has-answered');
	        }
	        //缓存答题结果
	        answerItem.AnswerResult = 'error';
	        var rAnswers = dom.parentNode.getElementsByClassName('answer-did');
	        for (var i = 0; i < rAnswers.length; i++) {
	            if (!rAnswers[i].classList.contains('has-answered')) {
	                //多项情况下还未完全作答
	                return 0;//未完全作答
	            }
	        }    
			return 2;
	    }
	    if (dom.parentNode.childNodes[dom.parentNode.childNodes.length - 1].contains('has-answered'))//最后一题已作答，则自动下滑到下一题
	        return 2;
	}
}

var reloadResult = function (questionsDic) {
    var errCount = 0;
    var rightCount = 0;
    for (var i = 0; i < questionsDic.length() ; i++) {
        if (questionsDic.getValue(i).AnswerResult == 'right') {
            rightCount += 1;
        } else if (questionsDic.getValue(i).AnswerResult == 'error') {
            errCount += 1;
        }
    }
    setHTML('right-count', rightCount);
    setHTML('error-count', errCount);
}
var setHTML = function (id, value) {
    var r1 = document.getElementById(id);
    if (r1) r1.innerHTML = value;
    else console.log("找不到元素:getElementById(" + id);
}
template.helper("transAnswerToABC", function (str, OptionType) {
    var optionStr2 = '';
    try {
        //console.log("88888888888888" + str)
        if (OptionType == 0 || OptionType == 1 || OptionType == 4) {
            //str.length < 6) {
            //123-->ABC
            if (OptionType < 3) {
                var optionStr = '12345678';
                var optionStr1 = 'ABCDEFGH';
                for (var i = 0; i < str.length; i++) {
                    if (optionStr.indexOf(str[i]) != -1) {
                        optionStr2 += optionStr1[str[i] - 1];
                    }
                }
            }
            return "<span style='color:red'>" + optionStr2 + "</span>";
        } else if (OptionType == 2) {
            if (str == '1' || str == 'A') optionStr2 = "对";
            if (str == '2' || str == 'B') optionStr2 = "错";
            return "<span style='color:red'>" + optionStr2 + "</span>";
        } else// if (OptionType==5)
        {
            var kk = str.split('|');
            if (kk.length > 1) {
                for (var i = 1; i < kk.length; i++) {
                    optionStr2 += "  " + kk[i];
                }
            }
        }
        if (optionStr2 == '') {
            optionStr2 = str;
        }
        if (optionStr2[0] == '答')
            optionStr2 = optionStr2.substring(1);
        if (optionStr2[0] == '1')
            optionStr2 = optionStr2.substring(1);
        if (optionStr2[0] == '|')
            optionStr2 = optionStr2.substring(1);

        if (OptionType == 3) {//论述
            optionStr2 = optionStr2.replace("1、", "<br>1、").replace("2、", "<br>2、").replace("3、", "<br>3、").replace("4、", "<br>4、")
                .replace("1.", "<br>1.").replace("2.", "<br>2.").replace("3.", "<br>3.").replace("4.", "<br>4.")
                .replace("一、", "<br>一、").replace("二、", "<br>二、").replace("三、", "<br>三、").replace("四、", "<br>四、");
        }
        optionStr2 = optionStr2.replace('\n', "<br>").replace('\n', "<br>").replace('\n', "<br>")
            .replace('。', "<br>").replace('<br><br>', "<br>");
        if (OptionType == 5) {
            return "<span style='color:red'>" + optionStr2 + "</span>";
        }
        else
        {
            return "<span style='color:black;font-weight:300;line-height:35px;'><br>  " + optionStr2 + "</span>";
        }
    } catch (e) {
        console.log('transAnswerToABC函数' + e + '==' + str);
    }
});
template.helper("getSourceFile", function (sourceFile, Sourceid) {
    var ss1 = '';
    if (isNotNull(sourceFile)) {
        try {
            if (params.sc && sourceFile.indexOf(params.sc) != -1)
                return sourceFile;
            var sourceFileList = sourceFile.split('\\');
            if (sourceFileList.length > 0) {
                var source1 = sourceFileList[sourceFileList.length - 1];
                var h1 = source1.indexOf('第');
                var e1 = source1.indexOf('章');
                if (e1 > h1) {
                    ss1 += source1.substring(h1, e1 + 1) + ".doc ";
                }
                //.replace('.txt', '').replace('2014', '').replace('瓯江', '')
                //    .replace('浙财大', '').replace('2011', '').replace('2012', '');
            }
        } catch (e) {
            console.log('getSourceFile函数' + e + '==' + str);
        }
    }
    if (isNotNull(Sourceid)) {
        if (Sourceid.length > 1) {
            var zw = ss1.match(/[\u4e00-\u9fa5]+/g);
            if (zw)
                ss1 += "(第" + zw + '章 ' + Sourceid.replace(zw,'') + '题' + ")";
            else
                ss1 += "(第" + Sourceid[0] + '章 ' + Sourceid.substring(1) + '题' + ")";
        } else {
            ss1 += "(" + Sourceid + ")";
        }
    }
    return ss1;
});
var getLength = function (str) {
    return str.replace(/[^\x00-\xff]/g, "aa").length / 2;
};
template.helper("titleStyle", function (question, QuestionId) {
    var w1 = window.screen.width;//苹果5 320 568   //苹果6 375 667  苹果6 plus 414 736
    var h1 = window.screen.height;
    question = question.trim();
    var length1 = getLength(question);
    var ret1 = 'display:block; height:1.5rem;font-size:.15rem;';
    if (question.contains('<br>') || length1 > 700) {
        ret1 = 'display:block; height:auto;font-size:.15rem;';
        console.log(QuestionId + "=" + length1 + " length777777777有html:" + ret1);
    }
    else if (h1 < 600) {
        if (length1 > 700)
            ret1 = 'display:block; height:5.0rem;font-size:.12rem;';
        else if (length1 > 500)
            ret1 = 'display:block; height:4.0rem;font-size:.13rem;';
        else if (length1 > 400)
            ret1 = 'display:block; height:3.5rem;font-size:.13rem;';
        else if (length1 > 300)
            ret1 = 'display:block; height:3.2rem;font-size:.13rem;';
        else if (length1 > 200)
            ret1 = 'display:block; height:2.5rem;font-size:.13rem;';
        else if (length1 > 150)
            ret1 = 'display:block; height:2.2rem;font-size:.13rem;';
        else if (length1 > 100)
            ret1 = 'display:block; height:1.3rem;font-size:.13rem;';
        else if (length1 > 60)
            ret1 = 'display:block; height:1.1rem;;font-size:.15rem;';
        else
            ret1 = 'display:block; height:0.9rem;;font-size:.15rem;';
        console.log(QuestionId + "=" + length1 + " length777777777小:" + ret1);
    }
    else {
        if (length1 > 700)
            ret1 = 'display:block; height:auto;font-size:.15rem;';
        else if (length1 > 500)
            ret1 = 'display:block; height:5.0rem;font-size:.15rem;';
        else if (length1 > 200)
            ret1 = 'display:flex; height:4.0rem;font-size:.15rem;';
        else if (length1 > 150)
            ret1 = 'display:flex; height:3.0rem;font-size:.15rem;';
        else if (length1 > 100)
            ret1 = 'display:flex; height:2rem;font-size:.15rem;';
        else if (length1 > 60)
            ret1 = 'display:flex; height:1.5rem;;font-size:.15rem;';
        else
            ret1 = 'display:flex; height:1.5rem;;font-size:.15rem;';
        console.log(QuestionId + "=" + length1 + " length7777777777大:" + ret1);
    }
    //mui.toast(w1 + '  ' + h1 + '  ' + length1);
    return ret1;
});
template.helper("question_sum", function () {    
    return params.question_sum;
});
template.helper("getQuestionTypeName", function (id) {
    return getQuestionTypeName1(id);
});
var getQuestionTypeName1 = function (id) {
    var name;
    switch (id) {
        case "0":
            name = '单选题';
            break;
        case "1":
            name = '多选题';
            break;
        case "8":
            name = '辨析论述题';
            break;
        case '4':
            name = '不定项选题';
            break;
        case "2":
            name = '判断题';
            break;
        case '3':
            name = '简答论述题';
            break;
        case '5':
            name = '填空题';
            break;
        case '6':
            name = '词汇题';
            break;
        case '7':
            name = 'PPT课堂';
            break;
        default:
            name = '题库';
            break;
    }
    return name;
};
//过滤标题中的题号
template.helper("getNoQuestionId", function (Question1, SourceFile) {
    //console.log(Question1)
    //Question1 = String.trim(Question1);
    if (Question1.indexOf('(') != -1 || Question1.indexOf('（') != -1) {
        var h1 = Question1.indexOf('(');
        if (h1 == -1)
            h1 = Question1.indexOf('（');
        if (h1 == -1)
            h1 = Question1.indexOf('【');

        var e1 = Question1.indexOf(')');
        if (e1 == -1)
            e1 = Question1.indexOf('）');
        if (e1 == -1)
            e1 = Question1.indexOf('】');
        //console.log(h1 + '==' + e1)
        if (h1 > -1 && e1 > -1) {
            Question1 = Question1.substring(0, h1 + 1) + '' + Question1.substring(e1, Question1.length);
        }
    }
    if (Question1.contains(''))
    var shuzi1 = '1234567890 ';
    var shuzi2 = '、，．。,. ';
    var index1 = -1;
    for (var i = 0; i < Question1.length; i++) {
        if (shuzi1.indexOf(Question1[i]) != -1)
            index1 = i;
	else
        break;
    }
    if (index1 > -1)
        Question1 = Question1.substring(index1 + 1);
    index1 = -1;
    for (var i = 0; i < Question1.length; i++) {
        if (shuzi2.indexOf(Question1[i]) != -1) {
            index1 = i;
        }else
        break;
    }
    if (index1 > -1)
        Question1 = Question1.substring(index1 + 1);
   
    return Question1;
});
//Answer=1234
template.helper("getAnswerResult", function (i, Answer, OptionType) {
    var result = '';
    try{
        if (('01248'.indexOf('' + OptionType) != -1)) {
            if (typeof Answer == 'string') { //都是跑这里的
                //console.log('Answer1====' + OptionType)
                if (Answer.indexOf(i + 1) > -1) { //多选题
                    result = 'answer-did';
                } else
                    result = 'answer-err';
            } else {
                for (var i = 0; i < Answer.length; i++) {
                    //console.log('Answer2====' + Answer)
                    //console.log('Answer2' + Answer)
                    if (Answer[i] == i + 1) {
                        result = 'answer-did'
                        break;
                    }
                }
            }
        } else {
            //console.log('Answer3===' + OptionType)
            if (i == 0)
                result = 'answer-did';
            else
                result = 'answer-err';
        }
    }catch(e)
    {
        console.log('809 getAnswerResult' + e);
    }
	return result;
});
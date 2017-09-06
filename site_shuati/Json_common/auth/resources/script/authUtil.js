function getAjax(url, data) {
	// 添加真是地址
	var realUrl =  url;
	// 移步处理函数
	var p = new promise.Promise();
	data = encodeMap(data);
	// 跨域（可跨所有域名）
	$.getJSON(realUrl, data, function(result) {
		console.log(result);
		p.done(result);
	});
	return p;
}

function searchParam(search) {
	var param = {};
	if (search == null || search == '') {
		return param;
	} else {
		if (search.indexOf("?") != -1) {
			search = search.substring(1, search.length);
		}
		search = search.replace("#", "");
		var array = search.split("&");
		for (var i = 0; i < array.length; i++) {
			var array2 = new Array();
			var ss = array[i].toString();
			array2[0] = ss.substring(0, array[i].indexOf("="));
			array2[1] = array[i].substring(array[i].indexOf("=") + 1,
					array[i].length);
			param[array2[0]] = array2[1];
		}
		return param;
	}
}

function getScore() {
	if (score >= 350 && score < 550) {
		$('.pt2').html("信用较差");
		$('.pt3').html("恭喜您拥有了第一个信用分，现在开始，累积信用财富吧！人而无信，不知其可。");
	} else if (score >= 550 && score < 600) {
		$('.pt2').html("信用中等");
		$('.pt3').html("恭喜您拥有了第一个信用分，现在开始，累积信用财富吧！人而无信，不知其可。");
	} else if (score >= 600 && score < 650) {
		$('.pt2').html("信用良好");
		$('.pt3').html("恭喜您获得了“信用良好”的评级，不错的开始哦，好习惯要保持！");
	} else if (score >= 650 && score < 700) {
		$('.pt2').html("信用优秀");
		$('.pt3').html("恭喜您获得了“信用优秀”的评级，不错的开始哦，好习惯要保持！");
	} else if (score >= 700 && score <= 950) {
		$('.pt2').html("信用极好");
		$('.pt3').html("恭喜您获得了“信用极好”的评级，不错的开始哦，好习惯要保持！");
	}
}

// 多少秒后跳转
function jumpurlTime(url , time) {
	
	setTimeout(function() {
		myhref.href = url;
	},time);
	
}
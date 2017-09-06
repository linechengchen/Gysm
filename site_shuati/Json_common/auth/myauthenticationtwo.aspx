
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>我的芝麻信用</title>
<meta name="viewport"
	content="width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no" />
<script type="text/javascript"
	src="https://7xiyzi.com2.z0.glb.qiniucdn.com/zepto.min.js"></script>
<script type="text/javascript"
	src="https://7xiyzi.com2.z0.glb.qiniucdn.com/promise.min.js"></script>
<script type="text/javascript"
	src="https://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>

<!DOCTYPE html>
<!--[if IE 8]> <html lang="en" class="ie8"> <![endif]-->
<!--[if IE 9]> <html lang="en" class="ie9"> <![endif]-->
<!--[if !IE]><!-->  <!--<![endif]-->
<html>
<head>
	
	<base href="https://auth.qtshe.com:80/"/>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta content="width=device-width, initial-scale=1.0" name="viewport"/>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8">
    <meta name="viewport"
	content="width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no" />
    <meta content="" name="description"/>
    <meta content="" name="author"/>
    <!-- BEGIN GLOBAL MANDATORY STYLES -->
	<script type="text/javascript" src="https://7xiyzi.com2.z0.glb.qiniucdn.com/jquery.min.js"></script>	
	<script type="text/javascript" src="https://7xiyzi.com2.z0.glb.qiniucdn.com/jquery.cookie.js"></script>
	<script type="text/javascript" src="https://7xiyzi.com2.z0.glb.qiniucdn.com/artTemplate.js"></script>
	<script type="text/javascript" src="https://7xiyzi.com2.z0.glb.qiniucdn.com/qtshe-app.js"></script>
	
	<script type="text/javascript" src="/resources/script/authUtil.js" ></script>
	<script type="text/javascript" src="/resources/script/localStorage.js" ></script>
	<link rel = "Shortcut Icon" href="https://7xiyzg.com2.z0.glb.qiniucdn.com/logo.ico">
	<link rel="stylesheet" href="../resources/css/realname.css">
	<link rel="stylesheet" href="../resources/css/qtb.css">
	<script type="text/javascript">
	function displayHead() {		//是否隐藏头部
		if (isAndroid) {
			try { 
				window.android.displayHead(false);
			} catch (e) { }
		} else if(isIos()) {
			connectWebViewJavascriptBridge(function(bridge) {
				bridge.callHandler('displayHead', {display:false}, function(response) {
					console.log(response);
				})
			});
		}
	}
	displayHead();
	</script>
</head>
<body>
</body>
</html>
<style type="text/css">
.bod{
	position: absolute;
	width: 100%;
	overflow-x: hidden;
}
.cb {clear: both;}
.bg {
	/*background: linear-gradient(to top, rgba(59, 191, 184, 1),
		rgba(3, 219, 136, 1));
	border-radius: 0 0 100% 100%;
	width: 165%;
	height: 370px;
	margin-left: -32%;*/
	background:url("https://7xlnm9.com2.z0.glb.qiniucdn.com/A-background%20414px.png");
	background-size:100% 100%;
	width:100%;
	height:350px;
	position: absolute;
	z-index: -1;
}

.header .back{
	position: absolute;
	width:10px;
	height:16.5px;
	color:rgba(255,255,255,0);
	margin-left:5%;
	margin-top: 16px;
	z-index:1;
}
.header {
	position: absolute;
	width: 100%;
	height: 50px;
	line-height: 50px;
	background-color: rgba(255,255,255,0);
}
.header .header-center {
	position: absolute;
	width: 150px;
	height: 100%;
	text-align: center;
	z-index: 1;
	font-size: 19px;
	left: 50%;
	margin-left: -80px;
	color: #fff;
}

.top{
	width:100%;
	margin-top:20px;
	padding-bottom:90px;
	text-align:center;
}
.top .ring {
	width: 200px;
	height: 200px;
	margin-top: 44px;
}
.top .pt1 {
	margin-top: -140px;
	color: rgba(255, 255, 255, 1);
	font-size: 56px;
}

.top .pt2 {
	margin-top: -5px;
	color: rgba(255, 255, 255, 1);
	font-size: 15px;
}

.top .pt3 {
	width:200px;
	margin:0px auto;
	text-align:center;
	color: rgba(255, 255, 255, 1);
	font-size: 12px;
}
.top .pt4{
	margin-top: 70px;
}

.bottom .pic {
	width: 100%;
	text-align:center;
}
.pic ul{
	margin:0 auto;
	width:220px;
}
.pic ul li {
	list-style-type: none;
	font-size: 16px;
	float: left;
}
.pic ul .pic-ul-li-1 {
	width: 130px;
}
.pic ul .pic-ul-li-2 {
	width: 90px;
}
.pic ul li .p1-img {
	 width: 21px;
	 height: 21px;
	 margin-top: -1px;
	 position: absolute;
	 margin-left: -26px;
}
.pic ul li .p2-img {
	 width: 21px;
	 height: 21px;
	 margin-top: -1px;
	 position: absolute;
	 margin-left: -28px;
}

.p1 {
	color: rgba(85, 85, 85, 1);
	font-size: 16px;
	display: inline-block;
}

.p2 {
	color: rgba(85, 85, 85, 1);
	font-size: 16px;
	display: inline-block;
}

.text {
	padding-top: 21px;
	margin-left: 21px;
	margin-right: 22px;
	margin-bottom: 17px;
	color: rgba(122, 122, 122, 1);
	font-size: 12px;
}
</style>

<script type="text/javascript">

// 	function displayHead() {		//是否隐藏头部
// 		if (isAndroid) {
// 			window.android.displayHead(false);	
// 		} else if(isIos()) {
// 			connectWebViewJavascriptBridge(function(bridge) {
// 				bridge.callHandler('disfalseead', {display:false}, function(response) {
// 					console.log(response);
// 				})
// 			});
// 		}
// 	}
// 	displayHead();


	closeWindow();

	function closeWindow() {
		if (isAndroid) {
			try {
				window.android.closeWindow('');
			} catch (e) {}
		} else if(isIos()) {
			connectWebViewJavascriptBridge(function(bridge) {
				 bridge.callHandler('closeWindow',  {}, function(response) { console.log(response);	});	
			});	
		}
	}
	
	function back() {
		
		if (isAndroid) {
			window.android.androidFinish("1");	
		} else if(isIos()) {
			connectWebViewJavascriptBridge(function(bridge) {
				bridge.callHandler('backClickOnIos', {}, function(response) {
					console.log(response);
				})
			});
		}
	
	    //myhref.href = "https://m.qtshe.com";
		myhref.href = "https://localhost:62259/app/jianzhi/m";
	}
	
</script>
</head>

<body style="margin: 0px; padding: 0px; width: 100%;background-color: #fff;height: 100%;">
	<input type="hidden" id="jumpurl" value="">
	<div class="header">
		<div>
<!-- 			<a onclick="back()"><img class="back" src="https://7xlnm9.com2.z0.glb.qiniucdn.com/right@3x.png"></a></a> -->
		</div>
<!--     	<div class="header-center">芝麻信用分数</div> -->
    </div>

	<div class="bod">
	<div class="bg"></div>
	<div class="top">
			<img class="ring"
			src="https://7xlnm9.com2.z0.glb.qiniucdn.com/A-Ring@3x.png">
			<p class="pt1 pt1-score">712</p>
			<p class="pt2"></p>
			<div class="pt4">
				<div class="pt3"></div>
			</div>
	</div>
	<div class="bottom">
		<div class="pic">
			<ul>
				<li class="pic-ul-li-1">
					<img class="p1-img"
					src="https://7xlnm9.com2.z0.glb.qiniucdn.com/zhima@3x.png">
					<p class="p1">芝麻信用</p></li>
				<li class="pic-ul-li-2"><img
					class="p2-img"
					src="https://7xlnm9.com2.z0.glb.qiniucdn.com/B-QTSHE-LOGO@3x.png">
					<p class="p2">爱帮兼职</p></li>
			</ul>
		</div>
		<div class="cb"></div>
		<div class="text">
			<p>
				我们将用心记录您的成长，您在爱帮兼职的每一次良好的兼职情况都会反馈给芝麻信用<br /> · 更高的芝麻信用分将帮助您被企业优先录用<br />
				· 工资线上提现，24小时到账<br />· 有理可依，我们将为您购买最高10w元的兼职保险<br />· 更多“信用达人”专属福利和活动正在进行
			</p>
		</div>
	</div>
	</div>
</body>

<script type="text/javascript">

	var jumpurl = $("#jumpurl").val();
	if(!isEmpty(jumpurl)) {
		jumpurlTime(jumpurl,3000);
	}

	var score = $('.pt1').html();
	getScore();

	zhimaxinyongReturn();
	function zhimaxinyongReturn() {		//是否隐藏头部
		var score = $(".pt1-score").text();
		if (isAndroid) {
			try {
				window.android.zhimaxinyongReturn(score);
			} catch (e) {}	
		} else if(isIos()) {
			connectWebViewJavascriptBridge(function(bridge) {
				 bridge.callHandler('zhimaxinyongReturn',  {score:score}, function(response) {console.log(response);});	
			});
		}
	}
	
</script>
</html>
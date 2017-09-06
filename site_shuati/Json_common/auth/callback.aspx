
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>实名认证</title>
<meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no" />
<script type="text/javascript" src="https://7xiyzi.com2.z0.glb.qiniucdn.com/zepto.min.js"></script>
<script type="text/javascript" src="https://7xiyzi.com2.z0.glb.qiniucdn.com/promise.min.js"></script>
<script type="text/javascript" src="https://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>

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
<script type="text/javascript" src="https://7xiyzi.com2.z0.glb.qiniucdn.com/qtshe-app.js"></script>
<style type="text/css">
.top {
	position: relative;
	width:100%;
	height:100%;
}
.name {
	text-align: center;
	color: rgba(255, 255, 255, 1);
	font-size: 14px;
	margin-top: -32%;
}
.header .back{
	position: absolute;
	width:10px;
	height:16.5px;
	color:rgba(255,255,255,0);
	margin-left:5%;
	margin-top: 17px;
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
	width: 100px;
	height: 100%;
	text-align: center;
	z-index: 1;
	font-size: 19px;
	left: 50%;
	margin-left: -50px;
	color: #fff;
}

.middle{
	margin-top:40px;
	text-align: center;
	font-size: 13px;
}
.pic1 {
	width: 92px;
/* 	height: 82px; */
	margin-top: 25%;
	margin-left: 8px;
}
.text1 {
	color: rgba(132, 132, 132, 1);
	padding-top:8px;
}

.pic2 {
	width: 82px;
	height: 82px;
	margin-top: 23px;
}
.text2 {
	color: rgba(132, 132, 132, 1);
	padding-top:8px;
}

.zhushi {
	color: rgba(102, 102, 102, 1);
	font-size: 12px;
	margin-top: 13.5%;
	margin-left: 21px;
	margin-right: 21px;
	margin-bottom:17px;
}

div:focus {
	outline: none;
}

button:focus {
	outline: none;
}

textarea:focus {
	outline: none;
}
</style>
<script type="text/javascript">
	


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
	
	window.history.back();
	
}

</script>
</head>
<body style="margin: 0px; padding: 0px;width: 100%;height: 100%;background-color: #fff">
	<div class="header">
		<!-- 		<div><img onclick="back()" class="back" src="https://7xlnm9.com2.z0.glb.qiniucdn.com/right@3x.png"></div> -->
		<!--     	<div class="header-center">实名认证</div> -->
    </div>
    
	<div class="part">
		<div class="top">
			<img src="https://7xlnm9.com2.z0.glb.qiniucdn.com/Credit@3x.png"
				style="width: 100%; text-align: center;">
			<p class="name">您可以通过以下两种方式认证您的信息</p>
		</div>
	</div>

	<div class="middle">
		<a id="textZmId" href="auth/zmxy/myauthentication">
			<img class="pic1" src="../../../source_7niu//shiming-zhimaxinyong@3x.png">
		</a>
		<p class="text1">芝麻信用认证</p>
		<a  id="textlocalId" href="local/auth/realNameAuto.html">
		<img class="pic2"src="../../../source_7niu//qtsrz.png">
		</a>	
		<p class="text2">平台认证</p>
	</div>

	<div class="zhushi">
		<p>注：实名认证仅用作帮粉币的工资提现，未经允许我们不会泄露您的私人信息</p>
	</div>
</body>
<script type="text/javascript">
 		</script>
</html>
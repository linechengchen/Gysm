
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>芝麻信用授权</title>
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
	<link rel = "Shortcut Icon" href="../../../../app/shuati/source_7niu/logo.ico">
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
body{
	font-family:"微软雅黑";
}
ul li {list-style-type: none;}
.top {
	margin: 0px;
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
	margin-left: -72px;
	color: #fff;
}

.liucheng {
	position: absolute;
	width: 100%;
	margin-top: -32%;
	text-align: center;
}
.liucheng .liucheng-img {
	width: 80%;
}

.liucheng ul {
	position:absolute;
	width:100%;
}
.liucheng ul li {
	width: 15%;
	height: 30%;
	font-size: 12px;
	float: left;
	text-align: center;
	color: rgba(255, 255, 255, 1);
}
.liucheng ul li span{
	position: absolute;
	margin-top:30px;
	margin-left:-27px;
}
.liucheng ul li img {
	margin-left:-7%;
	width: 38px;
	height: 38px;
}

.liucheng .thro {
	border-style: none none solid none;
	border-bottom-width: 1px;
	border-bottom-color: #DDDDDD;
	width: 15%; 
	margin-top: 6%;
}

.middle{
	margin-top: 22px;
}
.middle .xian {
	border-style: none none solid none;
	border-bottom-width: 1px;
	border-bottom-color: #DDDDDD;
}

.name {
	color: rgba(71, 205, 136, 1);
	font-size: 14px;
	height:40px;
	line-height:40px;
	padding: 0 6.5%;
}
.name .name-label {
	position: absolute;
	width: 70px;
	font-size: 14px;
}
.name .xm {
	margin-left: 70px;
	background-color:rgba(255,255,255,0);
}
.name .xm .xm-input {
	border: 0px;
	border-left: 1px solid #D9D9D9;
	background-color:rgba(255,255,255,0);
	padding: 4px 4px 4px 40px;
	font-size: 14px;
	width: 90%;
}

.text1 {
	color: rgb(245, 193, 5);
	font-size: 10px;
	margin-left: 6%;
	margin-top: 2%;
	margin-right: 5%;
}

.start {
	margin-top: 25px;
	color: rgba(255, 255, 255, 1);
	text-align: center;
	background-color: rgba(71, 205, 136, 1);
	border-radius: 8px;
	border: 0px;
	text-decoration: none;
	height:38px;
	line-height:38px;
	font-size: 16px;
}

.text {
	margin-top: 25px;
	margin-left: 21px;
	margin-right: 25px;
	margin-bottom: 17px;
	color: rgba(102, 102, 102, 1);
}

.text .tit {
	font-size: 15px;
	margin-bottom:11px;
}

.text .pt {
	margin-top: -5px;
	font-size: 12px;
	line-height: 18px;
}

input:focus {
	outline: none;
}

div:focus {
	outline: none;
}

button:focus {
	outline: none;
}
</style>
	<script type="text/javascript">
		
// 	function displayHead() {		//是否隐藏头部
// 		if (isAndroid) {
// 			window.android.displayHead(false);	
// 		} else if(isIos()) {
// 			connectWebViewJavascriptBridge(function(bridge) {
// 				bridge.callHandler('displayHead', {display:false}, function(response) {
// 					console.log(response);
// 				})
// 			});
// 		}
// 	}
// 	displayHead();
		
	</script>
</head>

<body style="margin: 0px; padding: 0px;width: 100%;height: 100%;background-color: #fff;">
	<div class="header">
		<div>
<!-- 			<a onclick="historyBack()" href="https://localhost:8086/auth/zmxy/myauthentication"> -->
<!-- 				<img class="back" src="https://7xlnm9.com2.z0.glb.qiniucdn.com/right@3x.png"> -->
<!-- 			</a> -->
		</div>
<!--     	<div class="header-center">芝麻信用授权</div> -->
    </div>

	<div class="part">
	
		<div class="top">
			<img src="https://7xlnm9.com2.z0.glb.qiniucdn.com/Credit@3x.png"
				style="width: 100%; text-align: center;">
		</div>
		
		    
    	<div class="liucheng">
    		<img class="liucheng-img" src="https://7xlnm9.com2.z0.glb.qiniucdn.com/zhimaxinyongbuzhou-%20copy.png">
<!-- 			<ul > -->
<!-- 				<li class="liucheng-ul-li-left"> -->
<!-- 					<img -->
<!-- 						src="https://7xlnm9.com2.z0.glb.qiniucdn.com/Authorization@3x.png"> -->
<!-- 					<div>开始授权</div> -->
<!-- 				</li> -->
<!-- 				<li class="thro"></li> -->
<!-- 				<li class="liucheng-ul-li-center"> -->
<!-- 					<img -->
<!-- 						src="https://7xlnm9.com2.z0.glb.qiniucdn.com/agrement@3x.png"> -->
<!-- 					<div>协议确认</div> -->
<!-- 				</li> -->
<!-- 				<li class="thro"></li> -->
<!-- 				<li class="liucheng-ul-li-right"> -->
<!-- 					<img -->
<!-- 						src="https://7xlnm9.com2.z0.glb.qiniucdn.com/message@3x.png"> -->
<!-- 						<div>短信验证</div> -->
<!-- 				</li> -->
<!-- 			</ul> -->
		</div>
		
	</div>
	
	<div class="cb"></div>

	<div class="middle">
		<div class="xian"></div>
		<div class="name">
			<div class="name-label">姓名</div>
			<div class="xm">
				<input type="text" class="xm-input xm-name" placeholder="请输入姓名">
			</div>
		</div>
		<div class="xian"></div>
		<div class="name">
			<div class="name-label">身份证号</div>
			<div class="xm">
				<input type="text" class="xm-input xm-iden" maxlength="18" placeholder="请输入身份证号">
			</div>
		</div>
		<div class="xian"></div>
		<p class="text1">以上信息仅用于验证您的身份，请勿输入您父母等非个人的真实信息，以免造成不必要的麻烦。</p>
		<div style="padding: 0 6.5% 0 6.5%;">
			<div class="start" onclick="authorize()">开始授权</div>
		</div>
	</div>

	<div class="text">
		<p class="tit">关于芝麻信用</p>
		<p class="pt">
			· 芝麻信用是独立合法的信用评估及信用管理机构，除法律法规要求或经过您授权的情况下，爱帮兼职和芝麻信用不会透露您的信用相关隐私信息。<br />
			· 我们将用心记录您的成长，您在爱帮兼职的每一次良好的兼职情况都会反馈给芝麻信用。<br />
			· 完成授权后，您将拥有更多私人定制的专项福利和贴心服务。
		</p>
	</div>
</body>

<script type="text/javascript">
	var param = searchParam(window.location.search);
	if (param.name != null && param.name != '') {
		$('.xm').val(decodeURI(param.name));
	}
	if (param.id != null && param.id != '') {
		$('.sfz').val(param.id);
	}

	function authorize() {
		var data = {};
		data.name = $('.xm-name').val();
		data.identityCardNO = $('.xm-iden').val();
		getAjax("auth/zmxy/authorize", data).then(function(data) {
			if (data.success) {
				myhref.href = data.errMsg;
			} else {
				alert(data.errMsg);
			}
		});
	}
	
</script>
</html>
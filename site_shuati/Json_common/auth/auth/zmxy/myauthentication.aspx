
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
	<script type="text/javascript" src="https://7xiyzi.com2.z0.glb.qiniucdn.com/qtshe-app.js"></script>

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
.top {
	position: relative;
	width:100%;
	height:100%;
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
	margin-left: -85px;
	color: #fff;
}

.pic {
	position: absolute;
	width:70px;
	height:70px;
	left:50%;
	margin-left:-35px;
	margin-top: -12%;
}

.name {
	color: rgba(145, 145, 145, 1);
	font-size: 14px;
	margin-top: 32px;
	text-align: center;
	margin-left:-2%;
}

.middle {
	width: 100%;
	margin-top:22px;
	text-align: center;
}
.middle img {
	width: 90%;
}
.m_nav {
	margin-top: 15px;
	width: 100%;
}
.m_nav img {
	height: 44px;
}
			
.m_nav a {
	width: 20%;
	text-decoration: none;
	height: 100px;
	text-align: center;
	float: left;
	margin-top: 0px;
}
.m_nav a span {
	width: 100%;
	float: left;
	line-height: 25px;
	font-size: 10px;
	color: #666666;
	font-family: "Microsoft YaHei", Arial, Helvetica, sans-serif;
}

.shouquan-top {
	
}
.shouquan {
	color: rgba(255, 255, 255, 1);
	text-align: center;
 	line-height: 38px;
	background-color: rgba(71, 205, 136, 1);
	border-radius: 8px;
	border-color: #00CD66;
	border: 0px;
	text-decoration: none;
	font-size: 15px;
	margin:0 16px;
	height:38px;
	margin-top: 21px;
}

.texta {
	bottom:0px;
	margin-left: 20px;
	font-size: 12px;
	margin-right: 21px;
	color: rgba(102, 102, 102, 1);
	margin-bottom:17px;
	margin-top:40px;
}
.t1 {
	margin-top:15%;
}
.t2 {
	margin-top:1%;
}

div:focus {
	outline: none;
}

button:focus {
	outline: none;
}
</style>

<script type="text/javascript">
	var param = searchParam(window.location.search);
	function startshouquan() {
		var data={};
		getAjax("auth/zmxy/authorizeStart",data).then(function(data){
			if(data.success) {
				var url="auth/zmxy/authorization";
				if(data.data.name != null && data.data.name != ''){
					url=url+"?name="+data.data.name+"";
				}
				if(data.data.identityCardNO != null && data.data.identityCardNO != ''){
					if(url.indexOf("?") != -1){
						url=url+"&id="+data.data.identityCardNO+"";
					}else{
						url=url+"?&id="+data.data.identityCardNO+"";
					}
				}
				window.location.href=url;
			}
			else{
				alert(data.errMsg);
			}
		});
	}
	 		
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

<body style="margin: 0px; padding: 0px;background-color: #fff;width: 100%;height: 100%;">
	<input type="hidden" id="jumpurl" value="">
	<div class="header">
<!-- 		<div><img onclick="historyBack()" class="back" src="https://7xlnm9.com2.z0.glb.qiniucdn.com/right@3x.png"></div> -->
<!--     	<div class="header-center">我的芝麻信用</div> -->
    </div>
	
	<div class="part">
		<img style="width: 100%;" src="https://7xlnm9.com2.z0.glb.qiniucdn.com/zhimaxinyong-myauthenticationtwo-backgournd.png">
<!-- 		<div class="top"> -->
<!-- 			<img src="https://7xlnm9.com2.z0.glb.qiniucdn.com/Credit@3x.png" -->
<!-- 				style="width: 100%; text-align: center;"> -->
<!-- 			<div class="pic"> -->
<!-- 				<img -->
<!-- 					src="https://7xlnm9.com2.z0.glb.qiniucdn.com/ZhiMa Credit@2x.png" -->
<!-- 					style="width: 70px; height: 70px;"> -->
<!-- 			</div> -->
<!-- 		</div> -->
<!-- 		<p class="name">芝麻信用</p> -->
	</div>

	<div class="middle">
		<img src="https://7xlnm9.com2.z0.glb.qiniucdn.com/zhimaxinyong-shouquanliebiao.png">
<!-- 		<div class="m_nav" id="allClass"> -->
<!-- 			<a><img src="https://7xlnm9.com2.z0.glb.qiniucdn.com/Oval 345 + Shape@3x.png"><span>信用历史</span></a> -->
<!-- 			<a><img src="https://7xlnm9.com2.z0.glb.qiniucdn.com/Oval 345 Copy + Shape@3x.png"><span>行为偏好</span></a> -->
<!-- 			<a><img src="https://7xlnm9.com2.z0.glb.qiniucdn.com/Oval 345 Copy 2 + Shape@3x.png"><span>履约能力</span></a> -->
<!-- 			<a><img src="https://7xlnm9.com2.z0.glb.qiniucdn.com/Shape + Rectangle 1485 Copy@3x.png"><span>身份特征</span></a> -->
<!-- 			<a><img src="https://7xlnm9.com2.z0.glb.qiniucdn.com/Rectangle 1486@3x.png"><span>人脉关系</span></a> -->
<!-- 		</div> -->

	</div>

	<div class="shouquan-top">
		<div class="shouquan" onclick="startshouquan()">授权芝麻信用</div>
	</div>

	<div class="texta">
		<!-- 		<p class="t1">芝麻分是根据您的“信用历史、行为偏好、履约能力、身份特质、人脉关系”等进行评估分析，计算后得出的信用评分，分值范围在350~950，分值越高代表信用水平约好。</p> -->
		<p class="t2">更高的芝麻信用分将帮助您被企业优先录用，您在爱帮兼职的每一次良好的兼职情况都会反馈给芝麻信用，完成芝麻信用授权可享有更多专属特权和活动。</p>
	</div>
	<script type="text/javascript">
		var jumpurl = $("#jumpurl").val();
		if(!isEmpty(jumpurl)) {
			jumpurlTime(jumpurl,3000);
		}
	
	</script>
</body>
</html>
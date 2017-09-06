<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Xt_task_add.aspx.cs" Inherits="AutoJsonPages_Xt_task_Xt_task_add"  %>


<!DOCTYPE HTML>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>发布作业 - i博导 - 遇见更好的教与学！</title>
    <meta name="viewport" content="initial-scale=1, maximum-scale=1, user-scalable=no, minimal-ui">
    <meta name="description" content="i博导是全国专注于泛商科类专业的在线教育+教学管理平台，致力于教学服务，技能提升！与千万学生一起来成长，遇见更好的自己！" />
    <meta name="keywords" content="i博导，电子商务，市场营销，国际商贸，在线教育，在线学习，视频课程，教学管理，信息化教学，智慧教学，翻转课堂，教学改革" />
    <meta name="apple-mobile-web-app-capable" content="yes">
    <meta name="apple-mobile-web-app-status-bar-style" content="black">
    <meta name="copyright" content="1999-2016 Bjbodao Inc.">
    <link rel="icon" href="/Public/home/images/favicon.ico" type="image/x-ico">
    <link rel="stylesheet" type="text/css" href="/Public/home/css/bootstrap.min.css"/>
    <link rel="stylesheet" type="text/css" href="/Public/home/css/iconfont.css?1702091356"/>
    <link rel="stylesheet" type="text/css" href="/Public/home/css/base.css?1702091356"/>
    <link rel="stylesheet" type="text/css" href="/Public/home/css/module/class_release.css" />
    <script src="/Public/home/js/lib/jquery.min.js"></script>
    <script src="/Public/home/js/lib/bootstrap.min.js"></script>
    <script src="/Public/home/js/lib/layer/layer.min.js"></script>
    <script type="text/javascript">
        (function () {
            var C = window.C = { UID: 560346, ROOT: "", APP: "", PUBLIC: "/Public", STATIC_URL: "https://static.ibodao.com", DEEP: "/", MODEL: ["2", "", "html"], VAR: ["m", "c", "a"] }
        })();
    </script>
    <script src="/Public/home/js/module/core.js?1702091356"></script>
    <script src="/Public/home/js/lib/jquery-ui.min.js"></script>
    <!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
    <script src="/Public/home/js/lib/iesupport/html5shiv.min.js"></script>
    <script src="/Public/home/js/lib/iesupport/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <!-- 头部 -->

    <div class="container-fluid bg-default c-navbar">
        <div class="row center-block left_nav  J_left_nav">
            <div class="navbar-header">
                <a class="navbar-brand logo" href="/">i博导 - 遇见更好的教与学！</a>
            </div>
            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav c-nav">
                    <li><a href="/index.html">首页</a></li>
                    
                    <li><a href="/Course/index.html">课程</a></li>
                    <li class="dropdown">
                        <a href="javascript:;" class="dropdown-toggle" data-toggle="dropdown">技能</a>
                        <ul class="dropdown-menu">
                            <li><a href="/Train/index.html">实训</a></li>
                            <li><a href="/Practical/ls.html">实战</a></li>
                            <li><a href="/Sports/index/status/1.html">竞技</a></li>
                            <li><a href="/Occupation/ls.html">职业</a></li>
                        </ul>
                    </li>
                    <li><a href="/Class/index.html">班级</a></li>
                    <li><a href="https://bbs.ibodao.com/" target="_blank">社区</a></li>
                    <li><a href="/Special/detail/name/scholarship.html">奖学金</a></li>
                    <li><a href="/ds2017.html" target="_blank">电商大赛</a></li>
                    <li class="app-hover">
                        <a class="c-app" href="/App/download.html" target="_blank">
                            <i class="icon icon-shouji"></i>下载
                        </a>
                        <div class="c-down-app">
                            <i></i>
                            <img class="app-logo" src="/Public/home/images/app-logo.png" alt="">
                            <h3>i博导</h3>
                            <p>手机客户端教学助手</p>
                            <img class="app-down" src="/Public/home/images/app-page.png" alt="">
                            <p>- IOS / Android -</p>
                        </div>
                    </li>
                </ul>
                <ul class="nav navbar-nav navbar-right c-nav-right">
                    <li class="J_nav_search">
                        <div class="nav-search">
                            <form action="/Index/search.html" method="GET">
                                <div class="input-group">
                                    <div class="search-type J_search_type">
                                        <input type="hidden" value="1" name="search_type">
                                        <a href="javascript:;"><span class="type-text">课程</span> <i class="icon icon-xiala"></i></a>
                                        <ul>
                                            <li class="active" data-type="1">课程</li>
                                            <li data-type="2">班级</li>
                                            <li data-type="3">实训</li>
                                            <li data-type="4">实战</li>
                                        </ul>
                                    </div>
                                    <input type="text" class="form-control J_keywords" name="kw" placeholder="请输入查找关键字">
                                </div>
                            </form>
                        </div>
                        <a href="javascript:;" class="c-search"><i class="icon icon-sousuochaxun"></i></a>
                    </li>
                                                                    <li>
                            <a href="/User/Message/index.html" class="c-message">
                                <i class="icon icon-youjian orange"></i>
                                <em>97</em>                            </a>
                        </li>
                        <li class="dropdown top-user-info">
                            <a href="javascript:;" onclick="window.location.href ='/Personal/index/uid/560346.html';" class="c-logo dropdown-toggle" data-toggle="dropdown"><img src="/Member/avatar/uid/560346.html"></a>
<div class="dropdown-menu c-member-menu">
    <div class="media">
        <div class="media-left">
            <a href="/User/index.html">
                <img class="media-object img-circle" src="/Member/avatar/uid/560346.html">
            </a>
        </div>
        <div class="media-body">
            <h5 class="media-heading">赵丽央</h5>
            博豆： <strong onclick="window.location.href='/User/Credit.html';">172</strong>
            <p><!---->
                <a href="/User/Bind/index.html" class="wechat active"><i class="icon icon-weixin"></i></a>
                <a href="/User/Bind/index.html" class="weibo "><i class="icon icon-xinlang"></i></a>
                <a href="/User/Bind/index.html" class="email "><i class="icon icon-youjianxinxiicon"></i></a>
                <a href="/User/Bind/index.html" class="mobile active"><i class="icon icon-shouji"></i></a>
            </p>
        </div>
    </div>
    <p>
        <a href="/User/index.html">我的首页</a>
        <a href="/User/Classes/teacherClassIndex.html">我的班级</a>
            
                    <a href="/Practical/ls.html">实战项目</a>    </p>
    <div class="clearfix">
        <div class="pull-left">
            <a href="/User/profile.html">修改资料</a> | <a href="/User/Profile/password.html">密码</a>
        </div>
        <div class="pull-right">
            <a href="/Member/logout.html" class="btn J-ajax-get">退出</a>
        </div>
    </div>
</div> 
                        </li>                </ul>
            </div>
        </div>
    </div>
    <!-- /头部 -->
    <!-- 主体 -->
    <div class="container-fluid clearfix">
		<div class="intro-queer row">
			<span class="queer">
                            <i class="icon icon-shouye"></i>
                            <em>&gt;</em> <a href="/Classes/index/classes_id/11932.html">市场营销1</a>                            <span>
                                <em>&gt;</em>
                                <a href="/Classes/class_task/classes_id/11932.html">作业</a>
                                                            </span>
                            <span class="now-queer">
                                    <em>&gt;</em>发布作业                            </span>
			</span>
		</div>
		<div class="release-cont row">
			<ul class="release-nav">
				<li class="active" data-name="basic"><a href="#">作业发布</a></li>
			<%--	<li data-name="worktype"><a href="#">任务方式</a></li>
			<%--	<li data-name="process"><a href="#">任务流程</a></li>
				<li data-name="target"><a href="#">任务目标</a></li>
				<li data-name="content"><a href="#">任务内容</a></li>--%>
				<%--<li data-name="data"><a href="#">辅导资料</a></li>--%>--%>
			</ul>
			<!-- <form method="POST" data-ajax="ture" data-check=""> -->
			<form method="post" action="/AutoJsonPages/Xt_task/Xt_task_addjson.aspx?classes_id=<%=getCourse_id() %>" name="form" id="form">
			<!--基本设置-->
			<div id="rele-basic" class="rele-tag-body release-c">
				<div class="rele-com-board">
					<span class="rele-com-name size14">标题：</span>
					<input class="rele-com-inp" type="text" name="name" id="name">
				</div>
				<div class="rele-com-board">
					<span class="rele-com-name size14">封面：</span>
                        <div style="display: inline-block;position: relative;top: 17px;">
                          	<link rel="stylesheet" type="text/css" href="/Public/home/css/module/webuploader.css" />
    <script type="text/javascript" src="/Public/home/js/lib/jquery.dragsort.min.js"></script>
    <script type="text/javascript" src="/Public/home/js/lib/webuploader/webuploader.min.js"></script>
    <script type="text/javascript" src="/Public/home/js/module/uploader.js"></script>
<div id="t_41d0e299ca1abeb2094852da042165c7_box" class="uploader-box">
    <div class="uploader-list" id="t_41d0e299ca1abeb2094852da042165c7_list">
            </div>
    <div id="t_41d0e299ca1abeb2094852da042165c7" class="" >上传封面</div>
</div>
<script>
    $(function () { $.webuploader_image('cover', 't_41d0e299ca1abeb2094852da042165c7', false, ''); });</script>                        </div>
					<!-- <input class="rele-com-inp" type="file" name="cover_file"> -->
					<!-- <input type="hidden" name="cover" value="/Public/Uploads/20160713/a.jpg"> -->
				</div>
				<div class="rele-com-board">
					<span class="rele-com-name size14">所属类别：</span>
					<div class="selectOutDiv">
						<script type="text/javascript" src="/Public/home/js/module/select.js"></script><span id="t_4ba01f1b83028205f14edf8fb7895ffd">Loading...</span>
<script>
    $(function () {
        $('#t_4ba01f1b83028205f14edf8fb7895ffd').select({
            table: 'category',
            fields: 'category_id',
            value: '1',
            fields_tip: '',
            size: 10,
            extends: null,
            callback: function (retobj) { (retobj); }
        });
    });
</script>					</div>

				</div>
				<div class="rele-com-board" style="display:none;">
					<span class="rele-com-name size14">奖励设置：</span>
					<div class="selectOutDiv">
						<select class="rele-com-inp selectordie" name="reward" id="reward">
							<option value="0">博豆</option>
													</select>
					</div>
					<input type="text" class="rele-com-inp time-inp" name="numbers" id="numbers">
				</div>
				<div class="rele-com-board">
					<span class="rele-com-name size14">截止时间：</span>
					<input type="text" class="rele-com-inp time-inp"  id="end_times" name="end_time">
				</div>
				<%--<div class="rele-com-board" style="display:none">
					<span class="rele-com-name size14">关联课程：</span>
					<span class="rele-com-inp rele-dis-sp video_list"></span>
					<input type="hidden" name="video_val" value="" id="video_val"/>
					<span class="J-get rela-course rele-com-btn btn-orange all-trans" data-type="video" data-url="/User/Task/add.html">选择课程</span>
				</div>
				<div class="rele-com-board " style="display:none">
					<span class="rele-com-name size14">知识/技能点：</span>
					<span class="rele-com-inp rele-dis-sp knowledge_list">
					</span>
					<input type="hidden" name="knowledge_val" value="" id="knowledge_val"/>
					<span class="J-get rela-course rele-com-btn btn-blue all-trans" data-type="knowledge">选取知识点</span>
				</div>--%>
				<div class="rele-com-board" style="margin-top:10px;">
					<span class="rele-com-name size14">难易程度：</span>
					<div class="selectOutDiv">
						<select class="rele-com-inp selectordie" name="level" id="level">
							<option value="0">初级</option>
							<option value="1">中级</option>
							<option value="2">高级</option>
						</select>
					</div>
				</div>
				<div class="rele-com-board" style="margin-top:20px; display:none ">
					<span class="rele-com-name size14">共享设置：</span>
					<div class="selectOutDiv">
						<select class="rele-com-inp" name="is_private" id="is_private">
							<option value="2">共享班级</option>
							<option value="0">禁止摘录</option>
							<option value="1">完全共享</option>
						</select>
					</div>
                  
					<div class="clas-list-board display">
						<span class="J-getclas rela-course rele-com-btn btn-green all-trans">选择班级</span>
						<span class="rele-com-inp rele-dis-sp class_list">
							<span class="list-group-item all-trans ischeck" data-id="11932">市场营销1</span>
						</span>
					</div>
					<input type="hidden" class="rele-com-inp" name="task_class" value="11932" id="class_val">
				</div>
                 <div class="rele-com-board">
					<span class="rele-com-name size14">作业类型：</span>
					<select class="rele-com-inp" name="type" id="type">
						<option value="matrix">拖拽类</option>
						<option value="weibo">微博类</option>
						<option value="operation">上传提交类</option>
					</select>
				</div>
				<div class="rele-com-board" style="display:none;">
					<span class="rele-com-name size14">是否作业：</span>
										<label class="radio-com"><input type="radio" name="is_task" value="1">是</label>
				</div>
				<div class="rele-com-board is_task" >
					<span class="rele-com-name size14">小组作业：</span>
					<label class="radio-com"><input type="radio" name="is_group" value="0" checked="checked">否</label>
					<label class="radio-com"><input type="radio" name="is_group" value="1">是</label>
					<span class="group-task-info">
						<i></i>
						温馨提示：<br>
						1. 小组作业仅小组成员可参与，未分组班级成员无参与权限<br>
						2. 小组作业，只需小组内一人提交，评级后全组成员统一得分<br>
						3. 成员分组，请在班级-管理中进行分组操作
					</span>
				</div>
				<div class="rele-com-board is_task" style="display:none" >
					<span class="rele-com-name size14">点评设置：</span>
					<label class="radio-com"><input type="radio" name="vay_comment" value="0" checked="checked">默认全站规则</label>
					<label class="radio-com"><input type="radio" name="vay_comment" value="1">只允许班级教师点评</label>
				</div>
       			<script type="text/javascript" src="/Public/home/ueditor/ueditor.config.js"></script>    
     <script type="text/javascript" src="/Public/home/ueditor/ueditor.all.min.js"></script>        
		            <textarea name="content" id="ue_content" style="width:100%;height:200px"></textarea>
           
            <script>$(function () {
window.ue_content_v = UE.getEditor('ue_content', {
serverUrl: "/Sinc/ueditor.html", toolbars: [['source', '|', 'undo', 'redo', '|',
           'bold', 'italic', 'underline', 'strikethrough', 'removeformat', '|', 'justifyleft', 'justifycenter', 'justifyright', '|', 'forecolor', 'backcolor', 'selectall',
           'cleardoc', 'fontfamily', 'fontsize', '|', 'link', '|', 'insertimage', 'insertvideo', 'attachment']], elementPathEnabled: false, wordCount: false, enableAutoSave: false, autoFloatEnabled: false, iframeCssUrl: '/Public/home/ueditor/themes/iframe.css'
});
});</script>

                 <div class="release-c rele-foot ">
				<a href="javascript:;" class="rele-com-btn rele-btn-sub add_submit">提交</a>
			</div>
            			</div>
                

			<!-- / 基本设置-->

			<!--任务方式-->
			<div id="rele-worktype" class="rele-tag-body release-c" style="display:none;">
				<%--<div class="rele-com-board">
					<span class="rele-com-name size14">类型：</span>
					<select class="rele-com-inp" name="type" id="type">
						<option value="matrix">拖拽类</option>
						<option value="weibo">微博类</option>
						<option value="operation">上传提交类</option>
					</select>
				</div>--%>
				<div class="rele-com-board clearfix drag matrix_content">
					<div class="rele-warn">
						<i class="br-radius-half">?</i><span>请在下方填写相应分数值</span>
					</div>
					<div class="rele-level clearfix">
						<div class="rele-lv-b pull-left">
							<div class="rele-lv-t clearfix">
								<span class="lv-line lv-1"></span>
								<span class="lv-msg pull-right br-radius-half lv-1">差</span>
							</div>
							<div class="clearfix">
								<i class="lv-arrow pull-right icon icon-down01"></i>
							</div>
							<div class="lv-inp-b pull-right">
								<input type="text" class="lv-inp rele-com-inp" name="score_level[]">
								<span>%正确率</span>
							</div>
						</div>
						<div class="rele-lv-b pull-left">
							<div class="rele-lv-t clearfix">
								<span class="lv-line lv-2"></span>
								<span class="lv-msg pull-right br-radius-half lv-2">中</span>
							</div>
							<div class="clearfix">
								<i class="lv-arrow pull-right icon icon-down01"></i>
							</div>
							<div class="lv-inp-b pull-right">
								<input type="text" class="lv-inp rele-com-inp" name="score_level[]">
								<span>%正确率</span>
							</div>
						</div>
						<div class="rele-lv-b pull-left">
							<div class="rele-lv-t clearfix">
								<span class="lv-line lv-3"></span>
								<span class="lv-msg pull-right br-radius-half lv-3">良</span>
							</div>
							<div class="clearfix">
								<i class="lv-arrow pull-right icon icon-down01"></i>
							</div>
							<div class="lv-inp-b pull-right">
								<input type="text" class="lv-inp rele-com-inp" name="score_level[]">
								<span>%正确率</span>
							</div>
						</div>
						<div class="rele-lv-b pull-left">
							<div class="rele-lv-t clearfix">
								<span class="lv-line lv-4"></span>
								<span class="lv-msg pull-right br-radius-half lv-4">优</span>
							</div>
							<div class="clearfix">
								<i class="lv-arrow pull-right icon icon-down01"></i>
							</div>
							<div class="lv-inp-b pull-right" style="background-color:#eee;">
								<input type="text" class="lv-inp rele-com-inp" value="100"  name="score_level[]">
								<span>%正确率</span>
							</div>
						</div>
					</div>
				</div>
			    <div class="d-d-c drag matrix_content">
					<a href="javascript:;" class="add-d add-td all-trans">+</a>
					<a href="javascript:;" class="add-d add-tr all-trans">+</a>
					<table class="d-d-table table table-bordered all-trans">
				      	<tbody>
					        <tr>
					          	<td>
					          		<div class="repair-td" style="line-height:140px;">问答</div>
					          	</td>
					          	<td class="anwer-t all-trans">
					          		<div class="repair-td">
						          		<div class="thum-static answer_content1">
						          			<span class="thum-sp">编辑答案</span>
						          		</div>
						          		<div class="hover-anwer">
						          			<span class="J-ans-edit"><i class="icon icon-bianjixiugai"></i>点击编辑答案</span>
						          			<span class="J-ans-del"><i class="icon icon-shanchu"></i>删除</span>
						          		</div>
						          		<input type="hidden" name="answer[]" class="answer1">
					          		</div>
					          	</td>
					        </tr>
					        <tr>
					          	<td class="ques-t">
					          		<div class="repair-td">
										<div class="thum-static">
											<span class="thum-sp">编辑问题</span>
										</div>
						          		<div class="hover-ques">
						          			<span class="J-ques-edit"><i class="icon icon-bianjixiugai"></i>点击编辑问题</span>
						          			<span class="J-ques-del"><i class="icon icon-shanchu"></i>删除</span>
						          		</div>
					          			<input type="hidden" name="question[]" class="question1">
					          		</div>
					          	</td>
					          	<td>
					          		<div class="repair-td">
					          			<input class="thum-radio" type="radio" name="answer1">
					          		</div>
					          	</td>
					        </tr>
				      	</tbody>
				    </table>
			    </div>
			    <!-- 微博内容开始 -->
			    <div class="rele-com-board clearfix drag weibo_content" style="display:none;">
					<div class="rele-warn">
						<i class="br-radius-half">?</i><span>请在下方填写相应转发数</span>
					</div>
					<div class="rele-level clearfix">
						<div class="rele-lv-b pull-left">
							<div class="rele-lv-t clearfix">
								<span class="lv-line lv-1"></span>
								<span class="lv-msg pull-right br-radius-half lv-1">差</span>
							</div>
							<div class="clearfix">
								<i class="lv-arrow pull-right icon icon-down01"></i>
							</div>
							<div class="lv-inp-b pull-right">
								<input type="text" class="lv-inp rele-com-inp" name="forward_num[]">
								<span>转发数</span>
							</div>
						</div>
						<div class="rele-lv-b pull-left">
							<div class="rele-lv-t clearfix">
								<span class="lv-line lv-2"></span>
								<span class="lv-msg pull-right br-radius-half lv-2">中</span>
							</div>
							<div class="clearfix">
								<i class="lv-arrow pull-right icon icon-down01"></i>
							</div>
							<div class="lv-inp-b pull-right">
								<input type="text" class="lv-inp rele-com-inp" name="forward_num[]">
								<span>转发数</span>
							</div>
						</div>
						<div class="rele-lv-b pull-left">
							<div class="rele-lv-t clearfix">
								<span class="lv-line lv-3"></span>
								<span class="lv-msg pull-right br-radius-half lv-3">良</span>
							</div>
							<div class="clearfix">
								<i class="lv-arrow pull-right icon icon-down01"></i>
							</div>
							<div class="lv-inp-b pull-right">
								<input type="text" class="lv-inp rele-com-inp" name="forward_num[]">
								<span>转发数</span>
							</div>
						</div>
						<div class="rele-lv-b pull-left">
							<div class="rele-lv-t clearfix">
								<span class="lv-line lv-4"></span>
								<span class="lv-msg pull-right br-radius-half lv-4">优</span>
							</div>
							<div class="clearfix">
								<i class="lv-arrow pull-right icon icon-down01"></i>
							</div>
							<div class="lv-inp-b pull-right" style="background-color:#eee;">
								<input type="text" class="lv-inp rele-com-inp" value="100" name="forward_num[]">
								<span>转发数</span>
							</div>
						</div>
					</div>
				</div>
				<div class="weibo_content" style="display:none;">
					<textarea class="rele-com-inp" name="weibo_content" placeholder="请填写微博转发主体内容"></textarea>
			    </div>


			<!-- / 辅导资料-->
			
			<input type="hidden" name="actual" id="actual" value="0">
                        <!--<input type="hidden" value="" name="form_token">-->
			</form>

			<input type="hidden" value="/User/Public/get_video.html" id="get_video_url">
			<input type="hidden" value="/User/Public/get_knowledge.html" id="get_knowledge_url">
			<input type="hidden" value="/User/Public/get_class.html" id="get_class_url">
			<input type="hidden" value="/User/Task/check_gold" id="check_gold_url">
			<input type="hidden" value="2017-05-21" id="now_time">
			<input type="hidden" value="task" id="get_chap_type"/>
		</div>
	</div>
  <!-- /主体 -->
    <!-- 底部 -->
    <div class="container-fluid  c-footer">
        <div class="row center-block center">
            <div class="col-md-9">
                <nav>
                    <a href="/Index/index.html">网站首页</a>
                    <a href="/Statics/helpCenter.html">帮助中心</a>
                    <a href="/Statics/aboutUs.html">关于我们</a>
                    <a href="/Statics/contactUs.html">联系我们</a>
                    <a href="/Statics/serviceTerms.html">服务条款</a>
                    <a href="javascript:;" data-container="body" data-toggle="popover" data-trigger="manual" data-placement="top" data-html="true" 
                          data-content="<div style='line-height: 30px;padding:0 5px;'>
                          <a href='/Statics/enterpriseEnter.html' class='text-muted'>合作企业入驻</a><br/>
                          <a href='/Statics/expertTeam.html' class='text-muted'>金牌导师</a>
                        </div>">i+计划</a>
                    <a href="javascript:;" id="suggest">意见反馈</a>
                    <a href="/Statics/friendlyLink.html">合作伙伴</a>
                </nav>
                <p>
                    Copyright &copy; 2013-2017 ibodao.com All Rights Reserved |  <a class="i-beian" href="https://www.beian.gov.cn/portal/registerSystemInfo?recordcode=11010802022973" target="_blank"><i></i>京公网安备11010802022973号</a>
                    | <i></i>京ICP备09019949号-9
                </p>
            </div>
            <div class="col-md-3">
                <div class="text-right c-icon-nav">
                    <a href="javascript:;" data-container="body" data-toggle="popover" data-trigger="manual" data-placement="top" data-html="true" 
                       data-content="<div class='row'>
                            <div class='col-xs-6 text-center'>
                                 订阅号<br/>
                                 <img src='/Public/home/images/ma1.png' width='108' height='108'/>
                            </div>
                            <div class='col-xs-6 text-center'>
                                 服务号<br/>
                                 <img src='/Public/home/images/ma2.png' width='108' height='108'/>
                            </div>
                       </div>"><i class="icon icon-weixin"></i></a>
                    <a href="https://weibo.com/bdibodao" target='_blank'><i class="icon icon-xinlang"></i></a>
                    <a href="https://wpa.qq.com/msgrd?v=3&uin=2918450351&site=qq&menu=yes" target='_blank'><i class="icon icon-qq"></i></a>
                </div>
            </div>
        </div>
    </div>
    <div class="c-right-tool hide">
        <a class="feed-back hide" target="_blank" href="https://wpa.qq.com/msgrd?v=3&uin=2918450351&site=qq&menu=yes" title="请给出您宝贵的意见">
            <i class="icon icon-qq2"></i>
            <p>联&nbsp;系</p>
            <p>客&nbsp;服</p>
        </a>
        <div class="back-top" title="返回顶部">
            <i class="icon icon-fanhuidingbu"></i>
            <p>返&nbsp;回</p>
            <p>顶&nbsp;部</p>
        </div>
    </div>

    <script>
        var rightTool = C.plugin.rightTool({
            show: true,
            pos: {
                bottom: '200px',
                right: '30px'
            },
            backTop: true,
            feedBack: false,
            quickExpt: {
                switch_: false,
                element: 'qk-expt-inclass'
            }
        });
        $("#suggest").click(function () {
            $.page("/Home/Statics/suggest.html", "860px");
        });
    </script>


	<script type="text/javascript" src="/Public/home/js/lib/scroll_bar/jquery.slimscroll.min.js"></script>
	<script type="text/javascript" src="/Public/home/js/module/c-extend.js"></script>
	<script type="text/javascript" src="/Public/home/js/module/release-tags.js"></script>
	<script type="text/javascript" src="/Public/home/js/module/release.js"></script>
	<script type="text/javascript" src="/Public/home/js/module/upd_course_know.js"></script>
	<script>
	    dragDropPopup.init();
	    var nowTime = $('#now_time').val();
	    $("#end_times").datetimepicker({
	        format: 'yyyy-mm-dd hh:ii',
	        minView: 'hour',
	        startDate: nowTime
	    });
	    var getClasUrl = $('#get_class_url').val();
	    var clasListBoard = $('.clas-list-board');
	    var setClass = C.plugin.getClass();
	    var cModal = setClass.modalDom;
	    $('#is_private').selectOrDie({
	        onChange: function () {
	            var val = $(this).val();
	            if (val == 2) {
	                clasListBoard.removeClass('hide');
	            } else {
	                clasListBoard.addClass('hide');
	            }
	        }
	    });
	    //获取班级
	    $(document).on('click', '.J-getclas', function () {
	        var dom = $(this);
	        cModal.addClass('in');
	        cModal.css('display', 'block');
	        setClass.getData(dom, getClasUrl);
	    });
	    cModal.on('click', '.J-save-clas', function () { //保存
	        setClass.save(saveCallb);
	    });
	    function saveCallb(val) { //返回 ids
	        var v = val.toString(),
        		html = cModal.find('.rk-y-list').html();
	        $('.class_list').html(html);
	        $('#class_val').val(v);
	    };
	</script>
    <!-- /底部 -->
   
    <!-- 追加底部块 --><script>var _hmt = _hmt || []; (function () { var hm = document.createElement("script"); hm.src = "https://hm.baidu.com/hm.js?e9f848aa28dd6d622c1e0061ae1d3679"; var s = document.getElementsByTagName("script")[0]; s.parentNode.insertBefore(hm, s); })();</script>    <!-- /追加底部块 -->
</body>
</html>
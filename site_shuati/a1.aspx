<%@ Page Language="C#" AutoEventWireup="true" CodeFile="a1.aspx.cs" Inherits="all" %>
<%@ Import Namespace="AgileFrame.Orm.PersistenceLayer.Model" %>
<%@ Import Namespace="AgileFrame.Orm.PersistenceLayer.BLL.Base" %>
<!DOCTYPE HTML>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="viewport" content="maximum-scale=1.0,minimum-scale=1.0,user-scalable=0,width=device-width,initial-scale=1.0">
       
		<title>大学题库</title>
		<link rel="stylesheet" href="css/index.css">    
		<script type="text/javascript" src="js/list.js"></script>
		<!--<link rel="stylesheet" type="text/css" href="../css/aui.css">-->
        <link rel="stylesheet" type="text/css" href="css/aui.min.css">
		<link rel="stylesheet" href="css\swiper.min.css">
	<style type="text/css">            
			#cover2 {
				position: fixed;
				margin:0px auto;
				width: 100%;
				height: 100%;		    
				display: none;
				z-index: 20000;
				top: 0;
				left: 0;
				background: rgba(0, 0, 0, 0.7) ;
				text-align:center ;
			}
			#cover2 img {
				 margin:0px auto;				 
				 /*height:100%;*/
                 height:30%;
			}
	</style>
	</head>
	<body><form id="form1" runat="server">
        </form>
		<header class="aui-bar aui-bar-nav aui-bar-info" id="aui-header">
			<a href="all2.aspx"><span class="aui-iconfont aui-icon-left"></span> </a>
		</header>		
		<div class="aui-content-padded aui-card">
			<ul class="aui-list-view">                
				<li class="aui-list-view-cell" data-win="sequence">
                       <script type="text/javascript">
                           document.write(navigator.userAgent);
                       </script>
				</li>
                <li class="aui-list-view-cell" data-win="sequence">
                    <%
                        List<string> list2 = MyRedis.Factory().Hash_GetKeys("sc" + sc);
                        foreach (string s1 in list2)
                        {
                            
                        }
                         %>
                </li>
                <% 
                    List<string> list1 = MyRedis.Factory().Hash_GetKeys("sc" + sc);
                    foreach (string s1 in list1)
                    {
                        int i1 = Convert.ToInt32(MyRedis.Factory().Hash_Get<string>("sc" + sc, s1));
                %>
				<li class="aui-list-view-cell" data-win="sequence">
                    <a class="aui-arrow-right" ><i class="aui-iconfont aui-icon-edit aui-text-info"></i> 
                        <%="sc" + sc%><%="源id：(总"+list1.Count+"="+i1+")" + s1 %>
                    </a>
				</li>
                 <% } %>
			</ul>
		</div>
        <p class="aui-text-center">若未能满足需要，请向我们反馈信息</p>

        <div style="display:none"><script language="javascript" type="text/javascript" src="http://js.users.51.la/18900802.js"></script>
<noscript><a href="http://www.51.la/?18900802" target="_blank" width="0" height="0"></a></noscript></div>

	</body>	
</html>

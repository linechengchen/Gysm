<%@ Page Language="C#" AutoEventWireup="true" CodeFile="all2.aspx.cs" Inherits="all" %>
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
			<span class="aui-iconfont aui-icon-left"></span> 
		</header>
        <div class="aui-content-padded aui-card">
            <ul class="aui-list-view">
                <a href="removeRedis1.aspx" target="_self">清空redis缓存</a>
                <a href="removeSession1.aspx" target="_self">清空我的session</a>
            </ul>
		<div class="aui-content-padded aui-card">
			<ul class="aui-list-view">
                <% foreach(string name1 in BLL1.NumDaxue_daxueDic.Keys)
                {
                    string sc = AgileFrame.Core.StringHelper.GetNumeric(name1).Trim();
                    
                    List<string> list1 = MyRedis.Factory().Hash_GetKeys("sc" + sc);
                    int all1 = 0;
                    int feifa1 = 0;
                    if (list1 != null)
                    {
                        foreach (string key1 in list1)
                        {
                            //MyRedis.Factory().Hash_Remove("sc" + sc);
                            int a1 = Convert.ToInt32(MyRedis.Factory().Hash_Get<string>("sc" + sc, key1));
                            all1 += a1;
                            if (a1 > 1)
                            {
                                feifa1 += (a1 - 1);
                                //MyRedis.Factory().Hash_Set("sc" + sc, key1, 1);
                            }
                        }
                    }                       
                       %>
				<li class="aui-list-view-cell" data-win="sequence">
                    <%--<a class="aui-arrow-right" href="ab.aspx?sc=<%=微信运营辅助软件.pinyin.convertShouZiMu(name1).ToLower() %>"><i class="aui-iconfont aui-icon-edit aui-text-info"></i> <%=name1 %></a>--%>
                    <a class="aui-arrow-right" href="app/kemuindex.html?neice=1&sc=<%=sc %>&source1=<%=getSourceId() %>">
                        <i class="aui-iconfont aui-icon-edit aui-text-info"></i> <%=name1 %> </a>   
                        <a href="a1.aspx?neice=1&sc=<%=sc %>">访问记录<%=all1 %> = 重复<%=feifa1 %></a>   
                    <a href="e.aspx?neice=1&sc=<%=sc %>">修改科目与各种排序</a>        
				</li>
                 <% } %>
			</ul>
		</div>
        <p class="aui-text-center">若未能满足需要，请向我们反馈信息</p>

        <div style="display:none"><script language="javascript" type="text/javascript" src="http://js.users.51.la/18900802.js"></script>
<noscript><a href="http://www.51.la/?18900802" target="_blank" width="0" height="0"/></a></noscript></div>

	</body>	
</html>

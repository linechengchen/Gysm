<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wxRedirect.aspx.cs" Inherits="wxRedirectBack" %>
<script>
    var wxUrl = localStorage.getItem("wx_url");
    if (wxUrl && wxUrl != 'undefined' && wxUrl != "null") {
        window.location.href = wxUrl;
    } else {
        alert('暂未找到上一次缓存的刷题记录');
        window.location.href = "http://stbd.aibangxs.com/site_shuati/app/shuati/pages/indexPage1_shuati.html";
    }
</script>
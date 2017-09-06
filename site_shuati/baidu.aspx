<%@ Page Language="C#" AutoEventWireup="true" CodeFile="baidu.aspx.cs" Inherits="baidu1" %>
<html>
<%--<%=info1%>--%>
    <font style="font-size:larger">
    <%=source1 %>|<%=dic2[source1] %>位同批次访问|
    <%=dic1.Count%>总人数|
    <%=dd1%>
        </font>
<script type="text/javascript">
    function tr1() {
        if ("<%=tr1%>" != "") {
            myhref.href = "<%=tr1%>";
        }
    }
    setTimeout("tr1();", 100);//延时3秒 
</script>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Banners.aspx.cs" Inherits="Json_banners" %>

<%if(Request["app_path1"]=="xueba"){ %>
{"code":200,"message":"success","data":{"recommendItem":null,"panicBuyUrl":"../panicbuy/index.html","recommendLists":[{"id":3,"path":"http://image.qess.me/images/2016102014313848765987.jpg","name":"90%的人都领了","type":0},{"id":2,"path":"http://image.qess.me/images/2016102014320173554445.jpg","name":"快人一步的教材","type":0}],
"banners":[{"path":"../../../image/hdt-xueba1.jpg","name":"主banner","url":"#"},
{"path":"../../../image/hdt-xueba2.jpg","name":"爱帮互助平台","url":""}
,{"path":"../../../image/hdt-xueba3.jpg","name":"爱帮互助平台","url":""}]}}

<% }else if(Request["app_path1"]=="zuoye"){ %>
{"code":200,"message":"success","data":{"recommendItem":null,"panicBuyUrl":"../panicbuy/index.html","recommendLists":[{"id":3,"path":"http://image.qess.me/images/2016102014313848765987.jpg","name":"90%的人都领了","type":0},{"id":2,"path":"http://image.qess.me/images/2016102014320173554445.jpg","name":"快人一步的教材","type":0}],
"banners":[{"path":"../../../image/hdt-zuoye1.jpg","name":"主banner","url":"#"},
{"path":"../../../image/hdt-zuoye2.jpg","name":"爱帮互助平台","url":""}
,{"path":"../../../image/hdt-zuoye3.jpg","name":"爱帮互助平台","url":""}]}}

<% }else if(Request["app_path1"]=="shuati"){ %>
{"code":200,"message":"success","data":{"recommendItem":null,"panicBuyUrl":"../panicbuy/index.html","recommendLists":[{"id":3,"path":"http://image.qess.me/images/2016102014313848765987.jpg","name":"90%的人都领了","type":0},{"id":2,"path":"http://image.qess.me/images/2016102014320173554445.jpg","name":"快人一步的教材","type":0}],
"banners":[{"path":"../../../image/hdt-shuati1.jpg","name":"主banner","url":"#"},
{"path":"../../../image/hdt-shuati2.jpg","name":"爱帮互助平台","url":""}
,{"path":"../../../image/hdt-shuati3.jpg","name":"爱帮互助平台","url":""}]}}

<% }else if(Request["app_path1"]=="xianshu"){ %>
{"code":200,"message":"success","data":{"recommendItem":null,"panicBuyUrl":"../panicbuy/index.html","recommendLists":[{"id":3,"path":"http://image.qess.me/images/2016102014313848765987.jpg","name":"90%的人都领了","type":0},{"id":2,"path":"http://image.qess.me/images/2016102014320173554445.jpg","name":"快人一步的教材","type":0}],
"banners":[{"path":"../../../image/hdt-xianshu1.jpg","name":"主banner","url":"#"},
{"path":"../../../image/hdt-xianshu2.jpg","name":"爱帮互助平台","url":""}
,{"path":"../../../image/hdt-xianshu3.jpg","name":"爱帮互助平台","url":""}]}}


<% }else if(Request["app_path1"]=="xueche"){ %>
{"code":200,"message":"success","data":{"recommendItem":null,"panicBuyUrl":"../panicbuy/index.html","recommendLists":[{"id":3,"path":"http://image.qess.me/images/2016102014313848765987.jpg","name":"90%的人都领了","type":0},{"id":2,"path":"http://image.qess.me/images/2016102014320173554445.jpg","name":"快人一步的教材","type":0}],
"banners":[{"path":"../../../image/hdt-xueche1.jpg","name":"主banner","url":"#"},
{"path":"../../../image/hdt-xueche2.jpg","name":"爱帮互助平台","url":""}
,{"path":"../../../image/hdt-xueche3.jpg","name":"爱帮互助平台","url":""}]}}

<% }else{ %>
{"code":200,"message":"success","data":{"recommendItem":null,"panicBuyUrl":"../panicbuy/index.html","recommendLists":[{"id":3,"path":"http://image.qess.me/images/2016102014313848765987.jpg","name":"90%的人都领了","type":0},{"id":2,"path":"http://image.qess.me/images/2016102014320173554445.jpg","name":"快人一步的教材","type":0}],
"banners":[{"path":"../../../image/hdt-<%=Request["app_path1"] %>1.jpg","name":"主banner","url":"#"},
{"path":"../../../image/hdt-<%=Request["app_path1"] %>2.jpg","name":"爱帮互助平台","url":""}
,{"path":"../../../image/hdt-<%=Request["app_path1"] %>3.jpg","name":"爱帮互助平台","url":""}]}}
<%} %>

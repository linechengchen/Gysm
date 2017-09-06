﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="180red.aspx.cs" Inherits="CchIucar_ChouJiang_180red" %>

<!DOCTYPE html>

<html xmlns="https://www.w3.org/1999/xhtml">
<head>
  
    <div id="wx_pic" style='margin:0 auto;display:none;'>

        <img src="img/erweima.jpg" /> >
    </div>
    <meta charset="gb2312"/>
    <!--<meta name="viewport" content="width=device-width,initial-scale=1.0" />-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <title>IU学车优惠券摇一摇</title>
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <link rel="stylesheet" type="text/css" href="css/animate.min.css">

    <script type="text/javascript" src="js/localstorage.js?11"></script>
    <script type="text/javascript" src="js/zepto.min.js"></script>
    <script type="text/javascript" src="js/red.js?111"></script>
    <link rel="stylesheet" type="text/css" href="css/index.css">
    <link rel="stylesheet" type="text/css" href="css/prism.css">
    <script src="https://libs.baidu.com/jquery/2.1.1/jquery.min.js" type="text/javascript"></script>
    <script src="js/jquery-1.11.0.min.js"></script>
    <script src="https://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>
    <script src="js/wx.js"></script>
    <script type="text/javascript" src="js/quietflow.min.js"></script>
    <script type="text/javascript" src="js/index.js"></script>
    <script type="text/javascript" src="js/prism.js"></script>

    <style>
        #shareit {
            -webkit-user-select: none;
            display: none;
            position: absolute;
            width: 100%;
            height: 100%;
            background: rgba(0,0,0,0.85);
            text-align: center;
            top: 0;
            left: 0;
            z-index: 105;
        }

            #shareit img {
                max-width: 60%;
            }

        #shareit2 {
            -webkit-user-select: none;
            display: none;
            position: absolute;
            width: 100%;
            height: 100%;
            background: rgba(0,0,0,0.85);
            text-align: center;
            top: 0;
            left: 0;
            z-index: 105;
        }

        #shareit img2 {
            max-width: 60%;
        }

        .arrow {
            position: absolute;
            right: 10%;
            top: 5%;
        }

        #share-text {
            margin-top: 50%;
        }
    </style>

</head>
<body>
    <div id="ceshi" style="display:none">
        <a href="#" onclick="test1()">测试</a>
        <a href="#" onclick="test2()">清空次数</a>
        <a href="#" id="yichou"></a>

    </div>

    <!-- 红包音乐 -->
    <!--<audio src="music/red-01.mp3" id="shakemusic" style="display: none;"></audio>-->
    <audio id="shakemusic" src="music/red-01.mp3" style="display: none;"></audio>
    <audio id="openmusic" src="music/red-02.mp3" style="display: none;"></audio>
    <!-- End 红包音乐 -->
    <!-- 红包 -->
    <div class="">

        <div class="red-logo">
        </div>
        <div class="red-ts"></div>

        <div id="shareit">
            <img class="arrow" src="img/guide1.png">
            <a href="#" id="follow">
                <img id="share-text" src="img/123.gif">
            </a>
        </div>
        <div id="shareit2">

            <a href="#" id="follow">
                <img id="share-img2" src="img/123.gif">
            </a>
        </div>
        <div class="red-tc">
            <!-- 已中奖 -->
            <div class="red-yzj">

                <div class="red-tc-k">
                    <p>￥<span id="span2"></span>元</p>
                    恭喜你获得<br>IU学车代金券
                </div>
                <div class="red-tc-btn">
                    <button onclick="shuaxin()">查看优惠券</button>

                    <button onclick="shuaxin()">关闭</button>
                </div>
            </div>

        </div>

        <div class="red-tc1">


            <div class="red-yzj">
                <div class="red-tc-k">
                    <img src="img/red-bw.png">
                    哎呀！</br>您的优惠券被风刮走了啊

                </div>
                <div class="red-tc-btn">
                    <button>再摇一次</button>
                    <button onclick="shuaxin()">关闭</button>
                </div>
            </div>
        </div>

        <div class="red-tc2" id="red-tc2id">

            <!-- 机会用光了 -->
            <div class="red-yzj">
                <div class="red-tc-k">
                    <img src="img/erweima.jpg">
                    没有抽中，真遗憾！</br>
                    机会用光了哦！转发并扫描二维码，客服小妹将给你180元代金券

                </div>
                <div class="red-tc-btn">
                    <button id="share_btn">转发朋友圈</button>&nbsp;

                </div>
            </div>
            <!-- End 机会用光了 -->
        </div>


        <div class="red-tc3" id="red-tc3id" style="display:none">

            <!-- 机会用光了 -->
            <div class="red-yzj">
                <div class="red-tc-k">
                    <img src="img/erweima.jpg">
                    请加 客服小妹，可获得平台代金券</br>

                </div>
                <div class="red-tc-btn">
                    <button id="share_btn1">转发朋友圈</button>&nbsp;
                </div>
            </div>
            <!-- End 机会用光了 -->
        </div>

        <script>
            //立即分享到微信朋友圈点击事件
            $("#share_btn").on("click", function () {
                $("#shareit").show();
            });



            $("#shareit").on("click", function () {
                $("#shareit").hide();
            })
            $("#share_btn2").on("click", function () {
                $("#shareit2").show();
            });
            $("#share_btn2").on("click", function () {
                $("#shareit2").hide();
            });
        </script>
        <!-- End 红包 -->
        <br />


        <br />
        <br />
        <br />
        <br />
        <br />
        <div style="width:100%; height:1px; ">
            <span style="margin:20% ; font-size:20px; align-content:center;text-shadow:5px 5px 2px #000;">萌妹客服专属优惠券</span>

        </div>

        <div class="red-yzj" id="red-yzjid" style="width:90%; align-content:center;margin:0 auto;">

            <div class="youhuijuan3" id="youhuijuan3id" style="margin:20% auto; display:block;">
                <p>￥<span>180.00</span>元</p>

                IU学车萌妹客服券</br><span style="font-size:12px;">每次只能用一张</span>
            </div>
            <div class="youhuijuan1" style="margin:0 auto; display:none;float:left">
                <p>￥<span>50.00</span>元</p>

                IU学车代金券</br><span style="font-size:12px;">每次只能用一张</span>
            </div>
            <div class="youhuijuan2" style="margin:0 auto; display:none; float:right">
                <p>￥<span>80.00</span>元</p>

                IU学车代金券</br> <span style="font-size:12px;">每次只能用一张</span>
            </div>

        </div>


    </div>

    <script type="text/javascript">
      var s=<%=con%>;
        wx.ready(function () {
            var   link="http://stbd.aibangxs.com/iu/iu/choujiang/index.aspx";
            wx.onMenuShareTimeline({
                title: 'IU学车，摇一摇', // 分享标题
                link: 'http://stbd.aibangxs.com/iu/iu/choujiang/index.aspx', // 分享链接
                imgUrl: 'http://stbd.aibangxs.com/iu/iu/choujiang/img/erweima.jpg', // 分享图标
                success: function () { 
                    alert("分享成功,可以直接扫二维码。联系萌妹客服领取180优惠卷");
                },
                cancel: function () { 
                    // 用户取消分享后执行的回调函数
                    alert("分享失败，大侠可以从新来过");
                }
            });
            wx.onMenuShareAppMessage({
                title: 'IU学车，摇一摇', // 分享标题
                desc: '一个专注大学生的专业学车平台', // 分享描述
                link: 'http://stbd.aibangxs.com/iu/iu/choujiang/index.aspx', // 分享链接
                imgUrl: 'http://stbd.aibangxs.com/iu/iu/choujiang/img/erweima.jpg', // 分享图标
                type: '', // 分享类型,music、video或link，不填默认为link
                dataUrl: '', // 如果type是music或video，则要提供数据链接，默认为空
                success: function () { 
                    alert("分享成功,可以直接扫二维码。联系萌妹客服领取180优惠卷");
                },
                cancel: function () { 
                    // 用户取消分享后执行的回调函数
                    alert("分享失败，大侠可以从新来过");
                }
            });
            wx.onMenuShareWeibo({
                title: 'IU学车，摇一摇', // 分享标题
                desc: '一个专注大学生的专业学车平台', // 分享描述
                link: 'http://stbd.aibangxs.com/iu/iu/choujiang/index.aspx', // 分享链接
                imgUrl: 'http://stbd.aibangxs.com/iu/iu/choujiang/img/erweima.jpg', // 分享图标
                success: function () { 
                    alert("分享成功,可以直接扫二维码。联系萌妹客服领取180优惠卷");
                },
                cancel: function () { 
                    // 用户取消分享后执行的回调函数
                    alert("分享失败，大侠可以从新来过");
                }
            });
            wx.onMenuShareQZone({
                title: 'IU学车，摇一摇', // 分享标题
                desc: '一个专注大学生的专业学车平台', // 分享描述
                link:'http://stbd.aibangxs.com/iu/iu/choujiang/index.aspx', // 分享链接
                imgUrl: 'http://stbd.aibangxs.com/iu/iu/choujiang/img/erweima.jpg', // 分享图标
                success: function () { 
                    alert("分享成功,可以直接扫二维码。联系萌妹客服领取180优惠卷");
                },
                cancel: function () { 
                    // 用户取消分享后执行的回调函数
                    alert("分享失败，大侠可以从新来过");
                }
            });




        })
        wx.error(function(){
        
            alert("失败");
        })
       
        $("body").quietflow({
            theme: "bouncingBalls",
            specificColors: [
              "rgba(255, 10, 50, .5)",
              "rgba(10, 255, 50, .5)",
              "rgba(10, 50, 255, .5)",
              "rgba(0, 0, 0, .5)"
            ]
        })
    </script>

    <script>
        var cishuKey = "cishu" + new Date().getDate();
        cishu1 = getLocal(cishuKey);
        if (cishu1 == undefined || cishu1 == null || cishu1 == '' || cishu1 < 1) {
            document.getElementById('red-tc3id').style.display = "block";
            document.getElementById('red-yzj').style.display = "none";
        
            document.getElementById('youhuiquan3').style.display = "none";
        }


     
   
    </script>

</body>

</html>
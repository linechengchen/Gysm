<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aes.aspx.cs" Inherits="Json_aes" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="maximum-scale=1.0,minimum-scale=1.0,user-scalable=0,width=device-width,initial-scale=1.0">
    <div id="shareImage" style="display: none;">
        <img src="image/hdt2.jpg" />
    </div>
    <title>刷题宝典（2017新）</title>
    
    <script src="../app/js/common/aes.js"></script>
    <script src="../app/js/common/aes2.js"></script>

</head>
<body>
    <%=data %><br />
    <%=System.Text.Encoding.Default.EncodingName %><br />
    div0<br /><div id="div0">--<%=encryptedData %> 其他  <%=json2%></div><br />
    div1<br /><div id="div1">--</div><br />
    div2<br /><div id="div2">--</div><br />
    div3<br /><div id="div3">--</div><br /><br />
    div4<br /><div id="div4">--</div>
    <!-- Swiper -->
 
</body>
</html>
   
<script type="text/javascript">

    var data = '<%=data %>';
    var encrypted = '<%=encryptedData %>';
    var key1 = '1234567812345678';
    var key = CryptoJS.enc.Latin1.parse('1234567812345678');
    var iv = CryptoJS.enc.Latin1.parse('1234567812345678');

    ////加密
    //var encrypted = CryptoJS.AES.encrypt(data, key, { iv: iv, mode: CryptoJS.mode.CBC, padding: CryptoJS.pad.ZeroPadding });

    //document.write(encrypted.ciphertext);
    //document.write('<br/>');
    //document.write(encrypted.key);
    //document.write('<br/>');
    //document.write(encrypted.iv);
    //document.write('<br/>');
    //document.write(encrypted.salt);
    //document.write('<br/>');
    //document.write(encrypted);
    //document.write('<br/>');

    ////解密
    //var decrypted = CryptoJS.AES.decrypt(encrypted, key, { iv: iv, padding: CryptoJS.pad.ZeroPadding });
    //console.log(decrypted.toString(CryptoJS.enc.Utf8));
    //document.getElementById("div1").innerText = decrypted;

    //var v1 = Aes.Ctr.encrypt("123", key1, 128);
    //console.log('内容====' + v1);
    //document.getElementById("div1").innerText = v1;


    var data1 = '<%=data%>';
    document.getElementById("div4").innerText = unescape(data1);

    var s1 = '<%=json2%>';
    //alert(s1[8])
    if (s1.length > 81111) {
        if (s1[8] == 'z') {
            var s2 = s1.substring(0, 8) + s1.substring(32);
            var v1 = Base64.decode(s2);
            var v2 = unescape(v1);
            document.getElementById("div1").innerText = v2;
        }
    }

    function isLetter(str) {
        if (/^[A-Za-z]+$/.test(str)) {
            return true;
        } else {
            return false;
        }
    }
    function isZi(str) {
        if (/^[\u4e00-\u9fa5]+$/.test(str)) {
            return true;
        } else {
            return false;
        }
    }
    function de1(s1) {
        var reg = new RegExp("^copyright");
        if (!reg.test(s1)) return s1;
        var ret = "";
        for (var i = 9; i < s1.length; i++) {
            var c = s1.charCodeAt(i);
            if (isLetter(s1[i]) || isZi(s1[i])) {
                var newChar = (((c - 3))) & 65535;;//(((c - 3)  0)) & 65535;
                var new2 = String.fromCharCode(newChar);
                if (!isLetter(new2) && !isZi(new2)) {
                    newChar = (newChar + (26)) & 65535;
                }
                ret = ret + String.fromCharCode(newChar);
            }
            else if (s1[i] == '`') {
                ret = ret + '{';
            }
            else if (s1[i] == 'É') {
                ret = ret + '}';
            }
            else if (s1[i] == 'ò') {
                ret = ret + ':';
            }
            else {
                ret = (ret + String.fromCharCode(c));
            }
        }
        return eval("(" + ret + ")");
    }

    document.getElementById("div1").innerText = de1(s1);
    
    document.getElementById("div0").innerText = s1 + "   ---   " + s2;

    var v2 = Aes.Ctr.decrypt(v1, key1, 128);
    console.log(v2);
    document.getElementById("div2").innerText = v2;

    var v3 = 'pGhVchXkBlEdoVsqnk+KzA=='
    var v3 = Aes.Ctr.decrypt(v3, key1, 128);
    console.log(v3);
    document.getElementById("div3").innerText = v3;

    //var v4 = 'pGhVchXkBlEdoVsqnk+KzA=='
    //var decrypted = CryptoJS.AES.decrypt(v4, key1, { iv: iv, padding: CryptoJS.pad.ZeroPadding });
    //console.log(v4);
    //document.getElementById("div4").innerText = v4;

</script>  
    
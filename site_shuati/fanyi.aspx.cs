using AgileFrame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 刷题导入工具;

public partial class app_fanyi : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string q1 = Request["q"];
        string end1 = fanyi(q1);
        //JsonRoot js1 = new JsonRoot();
        //js1.Add("q", end1);
        Response.Write(end1);
        Response.End();
    }
    //https://www.zhihu.com/question/35814484
    //https://sunweiwei.com/1451/
    private string fanyi(string q1)
    {
        if (string.IsNullOrEmpty(q1)) return "";
        string baidu1 = "https://api.fanyi.baidu.com/api/trans/vip/translate?q={q}&from={from}&to={to}&appid={appid}&salt={salt}&sign={sign}";
        baidu1 = baidu1.Replace("{q}", q1);
        baidu1 = baidu1.Replace("{from}", "en");
        baidu1 = baidu1.Replace("{to}", "zh");

        string appid = "20170404000044128";
        int salt = new Random(1000).Next();
        string miyao = "eRN49SpSEXewSZWPKwZM";
        //appid+q+salt+密钥 的MD5值
        string sign = StrToMD5(appid + q1 + salt + miyao);

        baidu1 = baidu1.Replace("{appid}", appid);
        baidu1 = baidu1.Replace("{salt}", salt.ToString());
        baidu1 = baidu1.Replace("{sign}", sign);
        WebGet w1 = new WebGet();
        string json1 = w1.GetUrltoHtml2(baidu1, Encoding.UTF8);
        string trans_result = StringHelper.CutString(json1, "trans_result\":\"", "\"");

        return trans_result;
    }
    public static string StrToMD5(string str)
    {
        byte[] data = Encoding.GetEncoding("GB2312").GetBytes(str);
        MD5 md5 = new MD5CryptoServiceProvider();
        byte[] OutBytes = md5.ComputeHash(data);

        string OutString = "";
        for (int i = 0; i < OutBytes.Length; i++)
        {
            OutString += OutBytes[i].ToString("x2");
        }
        // return OutString.ToUpper();
        return OutString.ToLower();
    }
}
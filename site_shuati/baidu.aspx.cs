using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgileFrame.Core;
using System.ServiceModel;
using System.ServiceModel.Channels;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using Dos.WeChat;
using System.IO;
using RedisService;
using System.Text;
using AgileFrame.Core.RedisService;

public partial class baidu1 : BasePageShuati
{
    protected string tu2wei = "";//zlg
    protected string agent = "";
    protected string name1 = "";

    protected string sc = "999";//zlg
    protected string type1 = "";
    protected string source1 = "";
    protected string neice = "";
    protected string dd1 = "";
    protected void setParams()
    {
        if (!string.IsNullOrEmpty(Request["neice"]))
        {
            neice = Convert.ToString(Request["neice"]);
        }
        if (!string.IsNullOrEmpty(Request["type1"]))
        {
            type1 = Convert.ToString(Request["type1"]);
        }
        if (!string.IsNullOrEmpty(Request["source1"]))
        {
            source1 = Convert.ToString(Request["source1"]);
        }
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        if (!string.IsNullOrEmpty(Request["dd1"]))
        {
            dd1 = Convert.ToString(Request["dd1"]);
        }
    }
    int cache1 = 0;
    protected static AFDictionary<string, string> dic1 = new AFDictionary<string, string>();
    protected static AFDictionary<string, string> dic11 = new AFDictionary<string, string>();
    protected static AFDictionary<string, string> dic111 = new AFDictionary<string, string>();
    protected static AFDictionary<string, int> dic2 = new AFDictionary<string, int>();
    protected string info1 = "";
    protected string tr1 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.Response.Redirect("app/baidu.html", true);
        setParams();
        if (!string.IsNullOrEmpty(source1))
        {
            info1 = getClientInfo(this.Request, this.Response);
            if (string.IsNullOrEmpty(info1))
                info1 = GetClientIp();
            if (!string.IsNullOrEmpty(info1))
            {
                if (!dic2.ContainsKey(source1))
                    dic2.Add(source1, 0);
                else
                    dic2[source1]++;

                if (dic1.ContainsKey(source1))
                {
                    if (dic1[source1] != info1)
                    {
                        if (dic11.ContainsKey(source1))
                        {
                            if (dic11[source1] != info1)
                            {
                                if (string.IsNullOrEmpty(sc))
                                    sc = "1955";
                                //this.Response.Redirect("app/baidu.html?sc=" + sc + "&source1=" + source1 + "&info1=" + info1, true);
                                tr1 = "http://stbd.aibangxs.com/site_shuati/app/shuati/baidu.html?sc=" + sc + "&source1=" + source1;// +"&info1=" + info1;
                                this.Response.Redirect(tr1, true);
                                return;
                            }
                        }
                        else
                            dic11.Add(source1, info1);
                    }
                }
                else
                    dic1.Add(source1, info1);
            }
        }
        if (!string.IsNullOrEmpty(dd1))
        {
            if (!dd1.StartsWith("https://"))
                dd1 = "https://" + dd1;

            tr1 = dd1.Replace("%3D", "_").Replace("eee", "/").Replace("fff", ".");
            //Server.Transfer(tr1);
            this.Response.Redirect(tr1, true);
        }
    }

    /// <summary>  
    /// 获取客户端Ip  
    /// </summary>  
    /// <returns></returns>  
    public String GetClientIp()
    {
        String clientIP = "";
        if (System.Web.HttpContext.Current != null)
        {
            clientIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(clientIP) || (clientIP.ToLower() == "unknown"))
            {
                clientIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_REAL_IP"];
                if (string.IsNullOrEmpty(clientIP))
                {
                    clientIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
            }
            else
            {
                clientIP = clientIP.Split(',')[0];
            }
        }
        return clientIP;
    }
    public string getClientInfo(HttpRequest Request, HttpResponse Response)
    {
        System.Web.HttpBrowserCapabilities browser = Request.Browser;

        string sb1 = new StringBuilder(256).Append(browser.Type).Append(browser.Browser)
            .Append(browser.Version).Append(browser.MajorVersion).Append(browser.MinorVersion).Append(browser.Platform)
            .Append(browser.Beta).Append(browser.Crawler).Append(browser.AOL).Append(browser.Win16)
            .Append(browser.Win32).Append(browser.Frames).Append(browser.Tables).Append(browser.Cookies)
            .Append(browser.VBScript).Append(browser.JavaScript).Append(browser.JavaApplets).Append(browser.ActiveXControls).ToString();
        return sb1;

        string sinfo = "Browser Capabilities\n"
           + "Type = " + browser.Type + "\n"
           + "Name = " + browser.Browser + "\n"
           + "Version = " + browser.Version + "\n"
           + "Major Version = " + browser.MajorVersion + "\n"
           + "Minor Version = " + browser.MinorVersion + "\n"
           + "Platform = " + browser.Platform + "\n"
           + "Is Beta = " + browser.Beta + "\n"
           + "Is Crawler = " + browser.Crawler + "\n"
           + "Is AOL = " + browser.AOL + "\n"
           + "Is Win16 = " + browser.Win16 + "\n"
           + "Is Win32 = " + browser.Win32 + "\n"
           + "Supports Frames = " + browser.Frames + "\n"
           + "Supports Tables = " + browser.Tables + "\n"
           + "Supports Cookies = " + browser.Cookies + "\n"
           + "Supports VBScript = " + browser.VBScript + "\n"
           + "Supports JavaScript = " + browser.JavaScript + "\n"
           + "Supports Java Applets = " + browser.JavaApplets + "\n"
           + "Supports ActiveX Controls = " + browser.ActiveXControls + "\n";

        string sinfo1 = "";
        HttpBrowserCapabilities b = Request.Browser;
        sinfo1 += ("浏览器名称和版本号：" + b.Type + "<br>");
        sinfo1 += ("名称：" + b.Browser + "<br>");
        sinfo1 += ("版本：" + b.Version + "<br>");
        sinfo1 += ("操作平台：" + b.Platform + "<br>");
        sinfo1 += ("是否支持框架：" + b.Frames + "<br>");
        sinfo1 += ("是否支持表格：" + b.Tables + "<br>");
        sinfo1 += ("是否支持cookies：" + b.Cookies + "<br>");

        //浏览器名称和版本号：IE6 
        //名称：IE 
        //版本：6.0 
        //操作平台：WinXP 
        //是否支持框架：True 
        //是否支持表格：True 
        //是否支持cookies：True

        //Page.
        if (Request.Browser.EcmaScriptVersion.Major > 0 && Request.Browser.W3CDomVersion.Major > 0)//判断是否支持脚本    
        {
            sinfo1 += ("浏览器名称与版本号：" + Request.Browser.Type + "<br />");
            sinfo1 += ("浏览器版本号：" + Request.Browser.Version + "<br />");
            sinfo1 += ("浏览器主版本号：" + Request.Browser.MajorVersion + "<br />");
            sinfo1 += ("浏览器名称：" + Request.Browser.Browser);
        }
        return sinfo1;
    }

}
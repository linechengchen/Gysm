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

public partial class wx : BasePageShuati
{
    protected string tu2wei = "";//zlg
    protected string agent = "";
    protected string name1 = "";

    protected string sc = "999";//zlg
    protected string type1 = "";
    protected string source1 = "";
    protected string neice = "";
    protected string openid = "";
    protected string user_id = "";
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
        if (!string.IsNullOrEmpty(Request["openid"]))
        {
            openid = Convert.ToString(Request["openid"]);
        }
        if (!string.IsNullOrEmpty(Request["user_id"]))
        {
            user_id = Convert.ToString(Request["user_id"]);
        }
    }
    int cache1 = 0;
    private static AFDictionary<string, string> dic1 = new AFDictionary<string, string>();
    private static AFDictionary<string, string> dic_source1 = new AFDictionary<string, string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        string url1 = this.Request.Url.ToString().Replace("/site_shuati/Json_shuati/wx.aspx", "/wx/wx.aspx");
        Response.Redirect(url1);
        Response.End();
        return;
        setParams();
        //if (neice=="" && Directory.Exists(@"D:\网站系统\刷题日志\刷题神器\心跳访问日志\"))
        //File.AppendAllText(@"D:\网站系统\刷题日志\刷题神器\心跳访问日志\" + source1 + ".txt", DateTime.Now.ToString() + this.Request.Url.ToString().Replace("http://stbd.aibangxs.com/site_shuati/json_shuati/wx.aspx?", "") + "\r\n");

        try
        {
            #region 防止同学私下转发链接
            //if (string.IsNullOrEmpty(Request["neice"]))// && !BLL1.iplist.ContainsKey(ip1 + agent) && !MyDebugger.IsAttached)
            {
                //if (Convert.ToString(Session["neice"]) != "1")
                {
                    //第一次打开，禁止转发
                    //if (string.IsNullOrEmpty(type1) || type1 == "aibang")
                    {
                        ////检查checkSource

                        info1 = getClientInfo(this.Request, this.Response);
                        if (string.IsNullOrEmpty(info1))
                        {
                            Response.Write("{\"type1\":\"" + "" + "\",\"trans\":\"" + "9" + "\",\"cache\":\"" + cache1 + "\",\"info\":\"" + info1 + "\",\"info2\":\"" + info2 + "\"}");
                            return;
                        }
                        else
                        {
                            if (info1.ToLower().Contains("win"))
                            {
                                //Chrome53Chrome53.0530WinNT
                                //Chrome39Chrome39.0390
                                //Chrome51Chrome51.0510
                                //if (info1.ToLower().Contains("chrome39"))
                                //    source1 = "winw39" + source1;
                                //else
                                    source1 = "winwin" + source1;
                            }
                            else if (info1.ToLower().Contains("iphone"))//苹果手机
                            {
                                source1 = "shouji" + source1;
                            }
                            else if (info1.ToLower().Contains("safari"))
                            {
                                source1 = "safari" + source1;
                            }
                            else if (info1.ToLower().Contains("mozilla"))//苹果手机
                            {
                                if (info1.ToLower().Contains("unknown"))//安卓手机
                                    source1 = "shouji" + source1;
                                else
                                    source1 = "mozill" + source1;
                            }
                            else if (info1.ToLower().Contains("chrome"))
                            {
                                if (info1.ToLower().Contains("unknown"))//安卓手机
                                    source1 = "shouji" + source1;
                                else
                                    source1 = "chrome" + source1;
                            }
                        }
                        
                        if (string.IsNullOrEmpty(neice) && (string.IsNullOrEmpty(source1) || source1 == "4" || !checkSource()))
                        {
                            Response.Write("{\"type1\":\"" + "" + "\",\"trans\":\"" + "3" + "\",\"cache\":\"" + cache1 + "\",\"info\":\"" + info1 + "\",\"info2\":\"" + info2 + "\"}");
                            return;
                        }
                        else
                        {
                            Random r1 = new Random();
                            int key2 = r1.Next();
                            //Session["type1"] = key2; type1 = key2.ToString();
                            Response.Write("{\"type1\":\"" + key2 + "\",\"trans\":\"" + "8" + "\",\"cache\":\"" + cache1 + "\",\"info\":\"" + info1 + "\",\"info2\":\"" + info2 + "\"}");//不用跳转
                            return;
                        }
                        //Server.Transfer("ab.aspx?suiji=" + key1 + "&sc=" + sc);
                    }
                    //else//第二次打开
                    //{
                    //    //string suiji1 = Convert.ToString(Session["type1"]);
                    //    string suiji2 = Convert.ToString(Request["type1"]);
                    //    //if (!string.IsNullOrEmpty(suiji1) && suiji1 != suiji2)//!string.IsNullOrEmpty(suiji1) &&
                    //    //{
                    //    //    Response.Write("{\"type1\":\"" + suiji2 + "\",\"trans\":\"" + "1" + "\"}");
                    //    //    return;
                    //    //    return;
                    //    //}
                    //    //else
                    //    {
                    //        //检查checkSource
                    //        if (checkSource())
                    //        {
                    //            Response.Write("{\"type1\":\"" + suiji2 + "\",\"trans\":\"" + "8" + "\"}");
                    //            return; return;
                    //        }
                    //        else
                    //        {
                    //            Response.Write("{\"type1\":\"" + "" + "\",\"trans\":\"" + "3" + "\"}");
                    //            return;
                    //            return;
                    //        }
                    //    }
                    //}
                }
                //else
                //{
                //    Session["neice"] = "";
                //}
            }

            #endregion 防止同学私下转发链接

            //string ip1 = GetClientIp();
            //agent = Request.Headers["User-Agent"];
            //string key1 = ip1 + agent;

            //#region 截取非微信访问用户
            //agent = Request.Headers["User-Agent"];
            //if (string.IsNullOrEmpty(Request["neice"]) && !choose_net(agent))// && !MyDebugger.IsAttached)// && !AgileFrame.Core.MyDebugger.IsAttached
            //{
            //    if (!"::1|183.245.77.242|183.245.77.245|183.245.77.248|115.159.84.169|stbd.aibangxs.com|115.159.84.169|::1|127.0.0.1|".Contains(ip1) && !ip1.StartsWith("10.30.103"))
            //    {
            //        Response.Write("{\"trans\":\"1\"}");
            //        return;
            //    }
            //}
        }
        catch (Exception e1)
        {
            msg += e1.ToString();
            Response.Write("{\"type1\":\"" + msg + "\",\"trans\":\"" + "8" + "\",\"cache\":\"" + cache1 + "\",\"info\":\"" + info1 + "\",\"info2\":\"" + info2 + "\"}");
        }
    }
    private static AFDictionary<string, string> dicCache1 = new AFDictionary<string, string>();
    string msg = "";
    IdWorker id1 = new IdWorker(0, 0);
    private string info1 = "";
    private string info2 = "";
    private bool checkSource()
    {
        if (!string.IsNullOrEmpty(source1))
        {
            if (source1 == "4")
                return true;
            ClientInfo c1 = new ClientInfo();
            c1.sc = sc;
            //sessionDic.Add(Session.LCID);
            //Session["source1"] = source1;
            try
            {
                ClientInfo c2 = null;
                MyRedis redis = MyRedis.Factory();
                //if (MyRedis.isOK)
                if(false)
                {
                    cache1 = 0;
                    try
                    {
                        MyRedis.Factory().Init();
                        c2 = redis.Hash_Get<ClientInfo>("ClientInfo", source1);
                        if (c2 != null)
                        {
                            cache1 = -1;
                            info2 = c2.Description;
                        }
                        if (string.IsNullOrEmpty(info2))
                        {
                            c1.Id = id1.nextIdUnique().ToString();
                            c1.Description = info1;
                            c1.Source1 = source1;
                            //redis.Add(c1);
                            bool ret1 = redis.Hash_Set<ClientInfo>("ClientInfo", source1, c1);
                            if (ret1)
                            {
                                cache1 = -11;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        msg += (ex.Message);
                    }
                }
                else
                {
                    cache1 = 2;
                    if (dicCache1.TryGetValue(source1, out info2))
                    {
                        if (string.IsNullOrEmpty(info2))
                        {
                            dicCache1.Add(source1, info1);
                            info2 = info1;
                        }
                        cache1 = 21;
                    }
                    else
                    {
                        dicCache1.Add(source1, info1);
                        cache1 = 22;
                    }
                }
                if (!string.IsNullOrEmpty(info2))
                {
                    if (info2 != info1)// && DateTime.Now.Hour > 22
                    {
                        if (MyRedis.isOK)
                        {
                            try
                            {
                                string is1 = MyRedis.Factory().Hash_Get<string>("sc" + sc, source1);
                                if (!string.IsNullOrEmpty(is1))
                                {
                                    int i1 = Convert.ToInt32(is1);
                                    i1++;
                                    MyRedis.Factory().Hash_Set<string>("sc" + sc, source1, i1.ToString());
                                }
                                cache1 = 1;
                            }
                            catch (Exception e1)
                            {
                                Cs.Info(e1.ToString());
                            }
                        }
                        cache1 = 23;
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                msg += (ex.Message);
            }
        }
        return true;
    }
    public void ResponseWarn(string tu2wei, string ip1)
    {
        //string s1 = ("<br><br><br><br><span style='font-size:25px'>刷题宝典 服务器升级，新地址见码：</span><br><img style='height:300px' src='image/分享/完整版本_num/" + tu2wei + "'/>：" + ip1 + "<br><br><br>");
        //BasePage b1 = new BasePage();
        //string sinfo = b1.getClientInfo(this.Request, this.Response);
        Response.Write("{\"trans\":\"1\"}");
        return;
    }
    //对用户访问进行判断 如果是的话返回true，否则返回false  
    public bool choose_net(string userAgent)
    {
        if (userAgent.IndexOf("MicroMessenger") > -1)// Nokia phones and emulators   
        {
            return true;
        }
        else
        {
            return false;
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


    /// <summary>  
    /// 服务器端获取客户端请求IP和客户端机器名称  
    /// </summary>  
    public string GetClientInfo()
    {
        return " ClientIp: " + Request.UserHostAddress + "clientName:" + Request.UserHostName;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgileFrame.Core;
using System.ServiceModel;
using System.ServiceModel.Channels;

/// <summary>
/// BasePage 的摘要说明
/// </summary>
public class BasePage : BasePageShuati
{
	public BasePage()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public string getClientInfo(HttpRequest Request, HttpResponse Response)
    {
        System.Web.HttpBrowserCapabilities browser = Request.Browser;
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
    /// <summary>  
    /// 服务器端获取客户端请求IP和客户端机器名称  
    /// </summary>  
    public static string GetClientInfo()
    {
        OperationContext context = OperationContext.Current;
        MessageProperties messageProperties = context.IncomingMessageProperties;
        RemoteEndpointMessageProperty endpointProperty = messageProperties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
        HttpRequestMessageProperty requestProperty = messageProperties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
        string clientIp = !string.IsNullOrEmpty(requestProperty.Headers["X-Real-IP"]) ? requestProperty.Headers["X-Real-IP"] : endpointProperty.Address;
        string clientName = Environment.MachineName;
        //Console.WriteLine("ClientIp: " + clientIp + "clientName:" + clientName);
        return "ClientIp: " + clientIp + "clientName:" + clientName;
    }
}
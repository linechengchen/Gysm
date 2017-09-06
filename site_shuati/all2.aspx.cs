using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using RedisService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 微信运营辅助软件;

public partial class all : BasePageShuati
{
    protected string agent = "";
    protected string sc = "194";//zlg
    protected string tu2wei = "";//zlg

    IdWorker id1 = new IdWorker(0, 0);

    protected string getSourceId()
    {
        return CRC.getCrcWithString(id1.nextIdUnique().ToString());
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        MyRedis.Ping();
        MyRedis.Factory().Init();
        Session["neice"] = "1";

        BLL1.initDaxue();

        #region 截取非微信访问用户
        //agent = Request.Headers["User-Agent"];
        //string ip1 = GetClientIp();
        //if (!"183.245.77.248|115.159.84.169|stbd.aibangxs.com|115.159.84.169".Contains(ip1) && string.IsNullOrEmpty(Request["neice"]))
        //{
        //    Response.Write("<br><br><br><br><span style='font-size:25px'>刷题宝典 服务器升级，新地址见码：</span><br><img style='height:300px' src='image/分享/完整版本_num/" + tu2wei + "'/>：" + GetClientIp());
        //    Response.End();
        //    return;
        //}
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
    #endregion 截取非微信访问用户
}
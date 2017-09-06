using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using Dos.WeChat;
using Dos.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
public partial class CchIucar_ChouJiang_180red : BasePageShuati
{
    #region 签名算法
    /// <summary>
    /// 签名算法
    ///本代码来自开源微信SDK项目：https://github.com/night-king/weixinSDK
    /// </summary>
    /// <param name="jsapi_ticket">jsapi_ticket</param>
    /// <param name="noncestr">随机字符串(必须与wx.config中的nonceStr相同)</param>
    /// <param name="timestamp">时间戳(必须与wx.config中的timestamp相同)</param>
    /// <param name="url">当前网页的URL，不包含#及其后面部分(必须是调用JS接口页面的完整URL)</param>
    /// <returns></returns>
    //public static string GetSignature(string jsapi_ticket, string noncestr, long timestamp, string url, out string string1)
    //{
    //    var string1Builder = new StringBuilder(256);
    //    string1Builder.Append("jsapi_ticket=").Append(jsapi_ticket).Append("&")
    //                  .Append("noncestr=").Append(noncestr).Append("&")
    //                  .Append("timestamp=").Append(timestamp).Append("&")
    //                  .Append("url=").Append(url.IndexOf("#") >= 0 ? url.Substring(0, url.IndexOf("#")) : url);
    //    string1 = string1Builder.ToString();
    //    return Util.Sha1(string1);
    //}
    #endregion
    #region  GET请求与获取结果
    public string HttpGet(string url, string param)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + (param == "" ? "" : "?") + param);
        request.Method = "GET";
        request.ContentType = "text/html;charset=UTF-8";

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream myResponseStream = response.GetResponseStream();
        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
        string retString = myStreamReader.ReadToEnd();
        myStreamReader.Close();
        myResponseStream.Close();

        return retString;
    }
    #endregion
    //public static string GetTimeStamp()
    //{
    //    TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
    //    return Convert.ToInt64(ts.TotalSeconds).ToString();
    //}
    //public string ticket_url = "https://api.weixin.qq.com/cgi-bin/ticket/getticket";
    //string nonceStr = "chenchenghang";
    //string access_token = "";
    //string code = "";
    //string ticket = "";





    //弹出调试     Response.Write("<script>alert('"+ localPath+"')</script>");
    // 控制台输出调试   Response.Write("<script>console.log('"+"内容为" + localPath + "')</script>");
    //public string getjsapi_ticket
    //{
    //    get
    //    {
    //        return string.Format("access_token={0}&type=jsapi", access_token);
    //    }
    //}



    public static string con = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        //TokenResult Token = new TokenResult();
        //Token = TokenHelper.GetAccessToken();
        //Response.Write("<script>alert('" + Dos.WeChat.TokenHelper.GetAccessToken().IsSuccess + "')</script>");
        JsapiTicketResult Tickte = new JsapiTicketResult();
        object ceshi = CacheHelper.Get("AccessToken" + WeChatConfig.GetAppId());
        Tickte = TokenHelper.GetJsapiTicket();
        //
        WeChatParam param = new WeChatParam();
        param.Debug = false;
        param.Url= Request.Url.ToString();

        BaseResult bs=JsSdkHelper.CreateWxConfig(param);
        con = bs.Data.ToString();
        //Response.Write("<script>alert('" + Tickte.Ticket + "')</script>");

        //Response.Write("<script>alert('" + Dos.WeChat.TokenHelper.GetAccessToken().IsSuccess + "')</script>");
        //Response.Write("<script>alert('" + Dos.WeChat.TokenHelper.GetAccessToken().IsSuccess + "')</script>");
        //    try
        //    {
        //        if (!IsPostBack)
        //        {


        //            Response.Write("timestamp-时间戳");
        //            Response.Write(GetTimeStamp());
        //            Response.Write("nonceStr-签名");
        //            Response.Write(nonceStr);
        //            access_token = xueba.userAccessToken();
        //            Response.Write("token");
        //            access_token = xueba.userAccessToken();
        //            Response.Write(access_token);
        //            Response.Write("signature-签名");
        //            ticket = HttpGet(ticket_url, getjsapi_ticket);
        //            Response.Write(ticket);

        //            if (Session["openid"] == null)
        //            {

        //                Response.Write("token");

        //                Response.Write("0");

        //                return;
        //            }

        //            Response.Write("openid");
        //            Response.Write(Convert.ToString(Session["openid"]));
        //            return;



        //        }

        //    }
        //    catch
        //    {

        //    }
    }
}

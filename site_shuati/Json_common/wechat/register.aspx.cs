using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_wechat_login : BasePageShuati
{
    string code = "";
    string phone_number = "";
    string grant_type = "authorization_code";
    string appid = "wx1f49864edcede162";
    string secret = "397321322f90543dd09719a1aedcb5a5";

    Common com = new Common();

    string fileLog = @"D:\网站系统\刷题日志\刷题神器\wx日志1.txt";

    string redirectUrl = "";
    string baseUrlHtml = "http://stbd.aibangxs.com/site_shuati/xianshu";
    //cch
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write(Request["redirectUrl"]);
        //Response.End();

        com.appid = appid;
        com.secret = secret;
        string localPath = Request.Url.LocalPath;
        if (com.IsGet())
        {
            if (Session["wx_url"] != null)
            {
                redirectUrl = Convert.ToString(Session["wx_url"]);
            }
            if (!string.IsNullOrEmpty(Request["redirectUrl"]))
            {
                redirectUrl = Request["redirectUrl"];
            }
            if (!string.IsNullOrEmpty(Request["code"]))
            {
                code = Request["code"].ToString();
                // 获取OPENID信息
                string url = "https://api.weixin.qq.com/sns/oauth2/access_token";
                string data = string.Format("appid={0}&secret={1}&code={2}&grant_type={3}", com.appid, com.secret, code, grant_type);
                string result = com.HttpGet(url, data);

                string openid = com.GetJsonValue(result, "openid");

                if (!string.IsNullOrEmpty(openid) && openid != "null")
                    Session["openid"] = openid;

                //com.WriteError(" url：" + localPath + "\r\n code:" + code + "\r\n openid:" + openid);
                // 获取access_token
                string access_token = com.userAccessToken();
                url = "https://api.weixin.qq.com/cgi-bin/user/info";
                data = string.Format("access_token={0}&openid={1}&lang=zh_CN", access_token, openid);

            }

        }
    }
}

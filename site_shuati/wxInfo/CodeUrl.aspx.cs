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

public partial class CodeUrl : BasePageShuati
{
    string code = "";
    string grant_type = "authorization_code";
    string appid = null;
    string secret = null;

    Common com = new Common();

    string fileLog = @"D:\网站系统\刷题日志\刷题神器\wx日志1.txt";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string localPath = Request.Url.LocalPath;
            if (com.IsGet())
            {
               
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

                    com.WriteError(" url：" + localPath + "\r\n code:" + code + "\r\n openid:" + openid);


                    // 获取access_token
                    string access_token = com.userAccessToken();

                    // 获取用户信息
                    url = "https://api.weixin.qq.com/cgi-bin/user/info";
                    data = string.Format("access_token={0}&openid={1}&lang=zh_CN", access_token, openid);

                    result = com.HttpGet(url, data);

                    string subscribe, nickname, sex, city, country, head_img_url, subscribe_time, remark, groupid, province, language;

                    subscribe = com.GetJsonValue(result, "subscribe");
                    openid = com.GetJsonValue(result, "openid");
                    nickname = com.GetJsonValue(result, "nickname");
                    sex = com.GetJsonValue(result, "sex");
                    city = com.GetJsonValue(result, "city");
                    country = com.GetJsonValue(result, "country");
                    head_img_url = com.GetJsonValue(result, "head_img_url");
                    subscribe_time = com.GetJsonValue(result, "subscribe_time");
                    remark = com.GetJsonValue(result, "remark");
                    groupid = com.GetJsonValue(result, "groupid");
                    province = com.GetJsonValue(result, "province");
                    language = com.GetJsonValue(result, "language");

                    //File.AppendAllText(fileLog, "\r\n subscribe=" + subscribe);

                    try
                    {
                        if(!string.IsNullOrEmpty(head_img_url))
                            head_img_url = head_img_url.Replace("/", "");

                        string sc = "";
                        if (Session["wx_url"] != null)
                        {
                            sc = StringHelper.CutString(Session["wx_url"].ToString(), "sc=", "&");
                            if(string.IsNullOrEmpty(sc))
                            {
                                sc = StringHelper.CutString(Session["wx_url"].ToString(), "sc=", "");
                            }
                        }
                        WX_USER_INFO us = new WX_USER_INFO();

                        us.Openid = openid;
                        //if (!BLLTable<WX_USER_INFO>.Exists(WX_USER_INFO.Attribute.Openid, openid))
                        if (!string.IsNullOrEmpty(openid) && openid != "null")
                        {
                            us.Subscribe = Int32.Parse(subscribe);
                            us.Openid = openid;
                            us.Nick_name = nickname;
                            if (StringHelper.IsNumeric(sex))
                                us.Sex = Int32.Parse(sex);
                            us.Language = language;
                            us.City = city;
                            us.Province = province;
                            us.Country = country;
                            us.Head_img_url = head_img_url;
                            us.Subscribe_time = subscribe_time;
                            us.Remark = remark;

                            if (StringHelper.IsNumeric(groupid))
                                us.Groupid = Int32.Parse(groupid);
                            us.Sc = sc;

                            if (!String.IsNullOrEmpty(Convert.ToString(Session["wx_url"])))
                                us.RedirectUrl = Convert.ToString(Session["wx_url"]);

                            if (!String.IsNullOrEmpty(Convert.ToString(Session["sc"])))
                                us.Sc = Convert.ToString(Session["sc"]);

                            //为了避免事务风险，建议采用此方法
                            int int1 = BLLTable<WX_USER_INFO>.Factory().SaveOrUpdate(us, WX_USER_INFO.Attribute.Openid);
                        }

                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(@"D:\网站系统\刷题日志\异常.txt", ex.ToString() + "\r\n");
                        //File.AppendAllText(fileLog, "\r\n" + ex.Message);
                        Cs.Error(ex.Message);
                        //Response.Write(ex.Message);
                        //return;
                    }

                    if (Session["wx_url"] != null)
                    {
                        if (!String.IsNullOrEmpty(Convert.ToString(Session["test1"])))
                        {
                            Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/common/pages/findme.html?urlname='" + Session["wx_url"], false); return;
                            //Response.Write("<script>window.location.href='http://stbd.aibangxs.com/site_shuati/app/common/pages/findme.html?urlname='" + Session["wx_url"] + ";</script>");
                        }
                        if (subscribe == "1")
                        {
                            string str = string.Format("?1=1&openid={0}&nickname={1}&head_img_url={2}", openid, nickname, head_img_url);
                            string wx_url = (Convert.ToString(Session["wx_url"]));
                            if (wx_url.Contains("?"))
                                str = "&" + str.Substring(1);

                            //File.AppendAllText(fileLog, "\r\n" + "===" + wx_url + str);

                            File.AppendAllText(@"D:\网站系统\刷题日志\成功.txt", wx_url + str + "\r\n");
                            //Response.Redirect(wx_url + str);
                        }
                        else
                        {
                            File.AppendAllText(@"D:\网站系统\刷题日志\有ID取消关注.txt", openid + "\r\n");
                            Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/common/pages/findme.html?urlname='" + Session["wx_url"], false); return;
                        }
                    }
                    else
                    {
                        File.AppendAllText(@"D:\网站系统\刷题日志\无跳转参数.txt", openid + "\r\n");
                        //Response.Redirect("../OK.aspx");
                        Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/common/pages/findme.html", false); return;
                    }
                }
                else
                {
                    File.AppendAllText(@"D:\网站系统\刷题日志\code为空.txt", "" + "\r\n");
                    com.WriteError(" url：" + localPath + "\r\n 未获得code参数！");
                    Response.Write("NO CODE");
                    Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/common/pages/findme.html?msg=操作失败未获得code参数", false); return;
                }
            }
            else
            {
                com.WriteError(" url：" + localPath + "\r\n Get请求失败！");
                Response.Write("NOT GET SERVICE");
                Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/common/pages/findme.html?msg=操作失败NOTGETSERVICE", false); return;
            }
        }
        catch (Exception e1)
        {
            File.AppendAllText(@"D:\网站系统\刷题日志\CodeUrl异常.txt", e1.ToString() + "\r\n");
            Cs.Error(e1.ToString());
        }
    }
}
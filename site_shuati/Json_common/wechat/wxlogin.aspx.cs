using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_wechat_login : BasePageShuati
{
    private string openid = HttpContext.Current.Request["openid"];
    private new string user_id = HttpContext.Current.Request["user_id"];
    private string user_name = HttpContext.Current.Request["user_name"];

    private string city_id = HttpContext.Current.Request["city_id"];
    private string city_name = HttpContext.Current.Request["city_name"];
    private string latitude = HttpContext.Current.Request["latitude"];
    private string longitude = HttpContext.Current.Request["longitude"];

    private string school_id = HttpContext.Current.Request["school_id"];
    private string school_name = HttpContext.Current.Request["school_name"];
    private string department_id = HttpContext.Current.Request["department_id"];
    private string department_name = HttpContext.Current.Request["department_name"];
    private string grade = HttpContext.Current.Request["grade"];

    string appid = "wx1f49864edcede162";
    string secret = "397321322f90543dd09719a1aedcb5a5";

    string code = "";
    string grant_type = "authorization_code";

    Common com = new Common();

    string fileLog = @"D:\网站系统\刷题日志\刷题神器\wx日志1.txt";

    string redirectUrl = "";
    private string escape(string s)
    {
        StringBuilder sb = new StringBuilder(256);
        byte[] byteArr = System.Text.Encoding.Unicode.GetBytes(s);

        for (int i = 0; i < byteArr.Length; i += 2)
        {
            sb.Append("%u");
            sb.Append(byteArr[i + 1].ToString("X2"));//把字节转换为十六进制的字符串表现形式

            sb.Append(byteArr[i].ToString("X2"));
        }
        return sb.ToString();

    }
    protected bool gotoFollowMe(string logFile, string msg1, string data)
    {
        //zlg 跳转链接
        if (Session["wx_url"] == null)
        {
            Session["wx_url"] = redirectUrl;
        }
        File.AppendAllText(logFile, data + " \r\n");
        setCookie("wx1", "gotoFollowMe");
        Response.Redirect(followMeUrl + "?msg=" + escape(logFile.Replace(@"D:\网站系统\刷题日志\", "")) + msg1
            + "&urlname='" + Session["wx_url"], false);// + "&data=" + escape(data.Replace("\n", "").Replace("\r", ""))
        return false;
    }
    private string followMeUrl = "http://stbd.aibangxs.com/site_shuati/app/shuati/pagesCommon/FollowME.html";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write(Request["redirectUrl"]);
        //Response.End();
        try
        {
            com.appid = appid;
            com.secret = secret;
            string localPath = Request.Url.LocalPath;
            if (com.IsGet())
            {
                //zlg 跳转链接
                if (Session["wx_url"] != null)
                {
                    redirectUrl = Convert.ToString(Session["wx_url"]);
                }
                //zlg 跳转链接
                if (!string.IsNullOrEmpty(Request["redirectUrl"]))
                {
                    redirectUrl = Request["redirectUrl"];
                }
                //转到微信，看是否用户已授权
                if (!string.IsNullOrEmpty(Request["code"]))
                {
                    code = Request["code"].ToString();
                    // 获取OPENID信息
                    string url = "https://api.weixin.qq.com/sns/oauth2/access_token";
                    string data = string.Format("appid={0}&secret={1}&code={2}&grant_type={3}", com.appid, com.secret, code, grant_type);
                    string result1 = com.HttpGet(url, data);

                    string openid = com.GetJsonValue(result1, "openid");
                    //string unionid = com.GetJsonValue(result1, "unionid");

                    if (!string.IsNullOrEmpty(openid) && openid != "null")
                    {
                        Session["openid"] = openid;
                    }
                    else
                    {
                        setCookie("wx1", "openid为空");
                        gotoFollowMe(@"D:\网站系统\刷题日志\openid不能获取.txt", result1, data + " \r\n"); return;
                    }
                    // 获取access_token
                    string access_token = com.userAccessToken();

                    // 获取用户信息
                    url = "https://api.weixin.qq.com/cgi-bin/user/info";
                    data = string.Format("access_token={0}&openid={1}&lang=zh_CN", access_token, openid);

                    //获取微信授权
                    string result2 = com.HttpGet(url, data);

                    //未获得授权，直接返回空
                    if (string.IsNullOrEmpty(result2))
                    {
                        setCookie("wx1", "result2不能获取");
                        gotoFollowMe(@"D:\网站系统\刷题日志\result2不能获取.txt", result2, data + " \r\n"); return;
                    }

                    string subscribe, nickname, sex, city, country, head_img_url, subscribe_time, remark, groupid, province, language;

                    subscribe = com.GetJsonValue(result2, "subscribe");
                    openid = com.GetJsonValue(result2, "openid");
                    nickname = com.GetJsonValue(result2, "nickname");
                    sex = com.GetJsonValue(result2, "sex");
                    city = com.GetJsonValue(result2, "city");
                    country = com.GetJsonValue(result2, "country");
                    head_img_url = com.GetJsonValue(result2, "head_img_url");
                    subscribe_time = com.GetJsonValue(result2, "subscribe_time");
                    remark = com.GetJsonValue(result2, "remark");
                    groupid = com.GetJsonValue(result2, "groupid");
                    province = com.GetJsonValue(result2, "province");
                    language = com.GetJsonValue(result2, "language");

                    //File.AppendAllText(fileLog, "\r\n subscribe=" + subscribe);

                    try
                    {
                        if (!string.IsNullOrEmpty(head_img_url))
                            head_img_url = head_img_url.Replace("/", "");

                        string sc = "";
                        if (!string.IsNullOrEmpty(redirectUrl))
                        {
                            sc = StringHelper.CutString(redirectUrl, "sc=", "&");
                            if (string.IsNullOrEmpty(sc))
                            {
                                sc = StringHelper.CutString(redirectUrl, "sc=", "");
                            }
                        }
                        string user_id = Request["user_id"];

                        if (Session["user_id"] != null && Session["user_id"] != "")
                        {
                            user_id = Convert.ToString(Session["user_id"]);
                        }
                        if (!string.IsNullOrEmpty(user_id))
                        {
                            setCookie("wx1", "记录 user_id为空");
                            File.AppendAllText(@"D:\网站系统\刷题日志\user_id.txt", user_id + " requstion \r\n");
                        }
                        WX_USER_INFO wxUser1 = new WX_USER_INFO();
                        //微信授权信息，保存入WX_USER_INFO
                        try
                        {
                            //us.USER_CODE = user_id;
                            if (!string.IsNullOrEmpty(user_id))//说明是已经手机号登录？
                            {
                                setCookie("user_id", user_id);
                                wxUser1.User_id = Guid.Parse(user_id).ToString();
                            }

                            //if (!BLLTable<WX_USER_INFO>.Exists(WX_USER_INFO.Attribute.Openid, openid))
                            if (!string.IsNullOrEmpty(openid) && openid != "null")
                            {
                                wxUser1.Openid = openid;
                                wxUser1.Subscribe = Int32.Parse(subscribe);
                                wxUser1.Nick_name = nickname;
                                if (StringHelper.IsNumeric(sex))
                                    wxUser1.Sex = Int32.Parse(sex);
                                wxUser1.Language = language;
                                wxUser1.City = city;
                                wxUser1.Province = province;
                                wxUser1.Country = country;
                                wxUser1.Head_img_url = head_img_url;
                                wxUser1.Subscribe_time = subscribe_time;
                                wxUser1.Remark = remark;

                                if (StringHelper.IsNumeric(groupid))
                                    wxUser1.Groupid = Int32.Parse(groupid);
                                wxUser1.Sc = sc;

                                if (!String.IsNullOrEmpty(redirectUrl))
                                    wxUser1.RedirectUrl = redirectUrl;

                                if (!String.IsNullOrEmpty(Convert.ToString(Session["sc"])))
                                    wxUser1.Sc = Convert.ToString(Session["sc"]);

                                int int1 = 0;
                                //为了避免事务风险，建议采用此方法
                                WX_USER_INFO u1 = BLLTable<WX_USER_INFO>.GetRowData(WX_USER_INFO.Attribute.Openid, wxUser1.Openid);
                                if (u1 != null && u1.IsNotNull())
                                {
                                    int1 = BLLTable<WX_USER_INFO>.Update(wxUser1, WX_USER_INFO.Attribute.Openid);
                                    //没有userid的情况，要插入user表                                
                                    if (string.IsNullOrEmpty(u1.User_id))
                                    {
                                        if (!saveUpdateUserInfo(wxUser1)) return;
                                    }
                                }
                                else
                                {
                                    int1 = BLLTable<WX_USER_INFO>.Insert(wxUser1);
                                    if (int1 > 0)
                                    {
                                        if (!saveUpdateUserInfo(wxUser1)) return;
                                    }else
                                        setCookie("wx1", "WX_USER_INFO Insert失败");
                                }
                                if (int1 == 0)
                                {
                                    File.AppendAllText(@"D:\网站系统\刷题日志\WX_USER_INFO_未保存.txt", DateTime.Now.ToString() + "==" + wxUser1.Openid + "=openid\r\n");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            setCookie("wx1", ex.ToString());
                            File.AppendAllText(@"D:\网站系统\刷题日志\WX_USER_INFO_异常.txt", ex.ToString() + "\r\n" + openid + "=openid \r\n");
                            //File.AppendAllText(fileLog, "\r\n" + ex.Message);
                            Cs.Error(ex.Message);
                            //Response.Write(ex.Message);
                            //return;
                        }
                    }
                    catch (Exception ex)
                    {
                        setCookie("wx1", ex.ToString());
                        File.AppendAllText(@"D:\网站系统\刷题日志\异常.txt", ex.ToString() + "222\r\n");
                        //File.AppendAllText(fileLog, "\r\n" + ex.Message);
                        Cs.Error(ex.Message);
                        //Response.Write(ex.Message);
                        //return;
                    }
                    if (!string.IsNullOrEmpty(openid))
                        setCookie("openid", openid);

                    if (redirectUrl != null)
                    {
                        //如果是别人那里获取的链接！
                        if (!String.IsNullOrEmpty(Convert.ToString(Session["test1"])))
                        {
                            Response.Redirect(followMeUrl + "?msg=关注后建立云通道&urlname='" + Session["wx_url"], false);
                            Session.Remove("test1");
                            return;
                        }

                        string str = string.Format("?1=1&openid={0}&nickname={1}&head_img_url={2}", openid, nickname, head_img_url);

                        if (redirectUrl.Contains("?"))
                            str = "&" + str.Substring(1);
                        else
                            str = "?" + str.Substring(1);

                        Response.Cookies.Remove("wx1");
                        //setCookie("wx1", "redirectUrl-"+redirectUrl + str);
                        Response.Redirect(redirectUrl + str, false);
                        return;
                        //Response.End();
                        if (subscribe == "1")
                        {
                            //File.AppendAllText(@"D:\网站系统\刷题日志\成功.txt", redirectUrl + str + "\r\n");
                            //Response.Redirect(wx_url + str);
                        }
                        else
                        {
                            setCookie("wx1", "有ID取消关注");
                            gotoFollowMe(@"D:\网站系统\刷题日志\有ID取消关注.txt", "", openid + "\r\n"); return;
                        }
                    }
                    else
                    {
                        setCookie("wx1", "redirectUrl 为空");
                        Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/shuati/pagesCommon/login.html", false); return;
                        //gotoFollowMe(@"D:\网站系统\刷题日志\无跳转参数.txt", openid + "\r\n"); return;
                    }
                }
                else
                {
                    setCookie("wx1", "code 为空");
                    gotoFollowMe(@"D:\网站系统\刷题日志\code不能获取.txt", "", localPath + " \r\n"); return;
                }
            }
            else
            {
                setCookie("wx1", "Get请求失败");
                gotoFollowMe(@"D:\网站系统\刷题日志\Get请求失败.txt", "", localPath + " \r\n"); return;
            }
        }
        catch (Exception e1)
        {
            setCookie("wx1", e1.ToString());
            gotoFollowMe(@"D:\网站系统\刷题日志\CodeUrl异常.txt", e1.ToString().Replace("\r", "").Replace("\n", ""), e1.ToString() + " \r\n"); return;
        }
    }
    private bool saveUpdateUserInfo(WX_USER_INFO wxUser1)
    {
        TUserInfo user1 = UserHelper.getUserInfo(wxUser1);
        {
            if (wxUser1.Head_img_url != null)
            {
                setCookie("head_img_url", wxUser1.Head_img_url);
            }
            if (Session["phone_number"] != null)
            {
                setCookie("phone_number", Session["phone_number"]);
                user1.Phone_number = Session["phone_number"].ToString();
            }
            if (Session["user_name"] != null)
            {
                setCookie("user_name", Session["user_name"]);
                user1.User_name = Session["user_name"].ToString();
            }
            //setCookie("phone_number", 1);
            setCookie("Token", user1.Token);
            setCookie("isLogin", true);
            if (string.IsNullOrEmpty(city_id))
            {
                user1.City_id = Convert.ToInt32(city_id);
                setCookie("city_id", city_id);
            }
            if (string.IsNullOrEmpty(city_name))
            {
                user1.City = city_name;
                setCookie("city_name", city_name);
            }
            if (string.IsNullOrEmpty(latitude))
            {
                user1.Latitude = Convert.ToInt32(latitude);
                setCookie("latitude", latitude);
            }
            if (string.IsNullOrEmpty(longitude))
            {
                user1.Longitude = Convert.ToInt32(longitude);
                setCookie("longitude", longitude);
            }
            if (string.IsNullOrEmpty(school_id))
            {
                user1.School_id = Convert.ToInt32(school_id);
                setCookie("school_id", school_id);
            }
            if (string.IsNullOrEmpty(school_name))
            {
                user1.School_name = school_name;
                setCookie("school_name", school_name);
                if (string.IsNullOrEmpty(department_id))
                {
                    user1.Department_id = Convert.ToInt32(department_id);
                    setCookie("department_id", department_id);
                }
                if (string.IsNullOrEmpty(department_name))
                {
                    user1.Department_name = department_name;
                    setCookie("department_name", department_name);
                }
            }
        }
        //为了避免事务风险，建议采用此方法
        TUserInfo rUser = BLLTable<TUserInfo>.Factory().GetRowData(TUserInfo.Attribute.Openid, wxUser1.Openid);
        if (rUser != null && rUser.IsNotNull())
        {
            wxUser1.User_id = rUser.User_id.ToString();
            setCookie("user_id", rUser.User_id.ToString());
            int ret3 = BLLTable<WX_USER_INFO>.Update(wxUser1, WX_USER_INFO.Attribute.Openid);
            //更新user表
            int ret1 = BLLTable<TUserInfo>.Factory().Update(user1, TUserInfo.Attribute.User_id);
            if (ret1 < 1)
            {
                setCookie("wx1", "saveUpdateUserInfo TUserInfo Update失败");
                File.AppendAllText(@"D:\网站系统\刷题日志\wxlogin异常.txt",
                    DateTime.Now.ToString() + "保存失败222\r\n");
            }
        }
        else
        {
            user1.User_id = Guid.NewGuid();
            int ret1 = BLLTable<TUserInfo>.Factory().Insert(user1);
            if (ret1 > 0)
            {
                setCookie("user_id", user1.User_id.ToString());
                wxUser1.User_id = user1.User_id.ToString();
                int ret3 = BLLTable<WX_USER_INFO>.Update(wxUser1, WX_USER_INFO.Attribute.Openid);
            }
            else
            {
                setCookie("wx1", "saveUpdateUserInfo TUserInfo Insert失败");
                //没有与授权有关的账户，跳转到注册页
                //Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/shuati/pagesCommon/registerNew.html", false); return false;
            }
        }
        return true;
    }
    private void setCookie(string name, object value)
    {
        if (string.IsNullOrEmpty(Convert.ToString(value)))
        {
        }
        HttpCookie version1 = new HttpCookie(name);
        version1.Value = Convert.ToString(value);
        HttpContext.Current.Response.Cookies.Add(version1);
    }
}
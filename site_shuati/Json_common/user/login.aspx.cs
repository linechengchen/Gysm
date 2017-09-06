using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_user_login : BasePageCookie
{
    /// <summary>
    /// post到页面的参数对象
    /// </summary>
    [Serializable]
    public class PostData
    {
        public static PostData get(System.Web.UI.Page this1)
        {
            return new PostData();
            System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string js1 = ""; PostData PostData = null; try
            {
                js1 = getString(this1); { PostData = javaScriptSerializer.Deserialize<PostData>(js1); return PostData; }
            }
            catch (Exception ex1) { this1.Response.Write(js1 + "\n==" + ex1.Message); this1.Response.End(); }
            return PostData;
        }
        public static string getString(System.Web.UI.Page this1)
        {
            string json1 = (this1.Request.InputStream != null) ? (new System.IO.StreamReader(this1.Request.InputStream).ReadToEnd()) : ""; this1.Request.InputStream.Close();
            return json1;
        }
        public string login_type = HttpContext.Current.Request["login_type"];
        public string phone_number = HttpContext.Current.Request["phone_number"];
        public string password = HttpContext.Current.Request["password"];
        public string user_name = HttpContext.Current.Request["user_name"];
    }

    RootObject r1 = new RootObject();
    protected void Page_Load(object sender, EventArgs e)
    {
        string a1 = Request["phone_number"];
        string a2 = Request["password"];
        //Response.Write("<script language='javascript'>alert('保存成功！');</script>");
        //获取post过来的所有json字符串参数
        PostData p1 = PostData.get(this);
        if (p1 == null) return;
        p1.password = Base64.toString(p1.password);

        TUserInfo user1 = new TUserInfo();
        TUserInfo param1 = new TUserInfo();

        setRequest(param1);
        TUserInfo cond1 = new TUserInfo();

        if (!string.IsNullOrEmpty(p1.phone_number))//手机
        {
            Session["phone_number"] = p1.phone_number;
            cond1.Phone_number = p1.phone_number;
            user1 = BLLTable<TUserInfo>.GetRowData(cond1);
        }
        else if (!string.IsNullOrEmpty(p1.user_name))//用户名
        {
            Session["user_name"] = p1.user_name;
            cond1.User_name = p1.user_name;
            user1 = BLLTable<TUserInfo>.SelectOne(new TUserInfo(), cond1);
        }
        //取值对象不取它的值

        if (user1 == null || user1.IsNull())
        {
            r1.message = "用户不存在";// +p1.password;
            r1.code = 2101;
        }
        else
        {
            login(user1);
            if (user1.PassWord != p1.password)
            {
                r1.message = "用户不存在或密码错误";// +p1.password;
                r1.code = 2101;
            }
        }
        string json1 = r1.ToJsonHeadLower();
        Response.Write(json1);
        Response.End();
    }

    private void login(TUserInfo user1)
    {
        if (string.IsNullOrEmpty(user1.Token))
        {
            user1.Token = "22";//app登陆的时候？
        }
        r1.message = "登入成功";// + p1.password;
        r1.code = 200;
        //r1.data.table = user1;
        r1.data.Add(user1);

        if (user1.Head_img_url != null)
        {
            setCookie("head_img_url", user1.Head_img_url);
            //Session["head_img_url"] = ;
        }
        if (user1.Phone_number != null)
        {
            setCookie("phone_number", user1.Phone_number);
        }
        if (user1.User_name != null)
        {
            setCookie("user_name", user1.User_name);
        }
        setCookie("isLogin", true);
        //setCookie("phone_number", 1);
        if (!string.IsNullOrEmpty(user1.Token))
            setCookie("Token", user1.Token);
        //if (!string.IsNullOrEmpty(user1.Openid))
        //    setCookie("openid", user1.Openid);
        if ((user1.City_id) != 0)
            setCookie("city_id", user1.City_id);
        if ((user1.User_id) != Guid.Empty && null != user1.User_id)
            setCookie("user_id", user1.User_id);
        if (!string.IsNullOrEmpty(user1.Nick_name))
            setCookie("nick_name", user1.Nick_name);
        if (!string.IsNullOrEmpty(user1.City))
            setCookie("city_name", user1.City);
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
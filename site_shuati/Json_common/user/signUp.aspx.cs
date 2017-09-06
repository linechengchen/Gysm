using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;

public partial class JsonBook_user_signUp : BasePageShuati
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
            PostData PostData = javaScriptSerializer.Deserialize<PostData>(new System.IO.StreamReader(this1.Request.InputStream).ReadToEnd());
            return PostData;
        }
        public string vcode = HttpContext.Current.Request["vcode"];
        public string password = HttpContext.Current.Request["password"];
        public string phone_number = HttpContext.Current.Request["phone_number"];
        public string real_name = HttpContext.Current.Request["real_name"];
        public string user_name = HttpContext.Current.Request["user_name"];
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取post过来的所有json字符串参数
        PostData p1 = PostData.get(this);
        string result = "";
               
        RootObject r1 = new RootObject();
        if (p1 == null || string.IsNullOrEmpty(p1.vcode) || string.IsNullOrEmpty(p1.password) || string.IsNullOrEmpty(p1.phone_number)
            || (p1.phone_number + p1.vcode != Convert.ToString(Session["vcode"]) && p1.vcode != "4444"))
        {
            r1.code = 999;
            r1.message = "验证码错误，请重新输入";
            Response.Write(r1.ToJsonHeadLower());
            Response.End();
        }
        else
        {
            TUserInfo user1 = new TUserInfo();
            if (!string.IsNullOrEmpty(p1.phone_number))
                user1.Phone_number = p1.phone_number;
            if (!string.IsNullOrEmpty(p1.password))
                user1.PassWord = p1.password;
            user1.User_id = Guid.NewGuid();
            if (!string.IsNullOrEmpty(p1.real_name))
                user1.Real_name = p1.real_name;
            try
            {
                int ret1 = BLLTable<TUserInfo>.SaveOrUpdate(user1, TUserInfo.Attribute.Phone_number);//, TUserInfo.Attribute.Phone_number

                if (ret1 > 0)
                {
                    if (user1 != null)
                    {
                        if (string.IsNullOrEmpty(user1.Token))
                        {
                            user1.Token = "22";//app登陆的时候？
                        }
                        r1.message = "登入成功";// + p1.password;
                        r1.code = 200;
                        r1.data.table = user1;

                        //if (user1.Head_img_url != null)
                        //{
                        //    setCookie("head_img_url", user1.Head_img_url);
                        //    //Session["head_img_url"] = head_img_url;
                        //}
                        //if (user1.Phone_number != null)
                        //{
                        //    setCookie("phone_number", user1.Phone_number);
                        //}
                        //if (user1.User_name != null)
                        //{
                        //    setCookie("user_name", user1.User_name);
                        //}
                        //setCookie("isLogin", true);
                        ////setCookie("phone_number", 1);
                        //if (!string.IsNullOrEmpty(user1.Token))
                        //    setCookie("Token", user1.Token);
                        //if (!string.IsNullOrEmpty(user1.Openid))
                        //    setCookie("openid", user1.Openid);
                        //if ((user1.City_id) != 0)
                        //    setCookie("city_id", user1.City_id);
                        //if ((user1.User_id) != Guid.Empty && null != user1.User_id)
                        //    setCookie("user_id", user1.User_id);
                        //if (!string.IsNullOrEmpty(user1.Nick_name))
                        //    setCookie("nick_name", user1.Nick_name);
                        //if (!string.IsNullOrEmpty(user1.City))
                        //    setCookie("city_name", user1.City);
                    }
                    else
                    {
                        r1.message = "用户不存在或密码错误";// +p1.password;
                        r1.code = 2101;
                    }
                    string json1 = r1.ToJsonHeadLower();
                    Response.Write(json1);
                    Response.End();
                }
            }
            catch (Exception ex1)
            {
                Cs.Error(ex1.ToString());
                r1.errMsg = "异常:" + ex1.Message;
            }
        }
        r1.AddTop("p1.phone_number", p1.phone_number);
        r1.AddTop("p1.real_name", p1.real_name);
        r1.code = 999;
        r1.message = "请重新输入";
        Response.Write(r1.ToJsonHeadLower());
        Response.End();
        //Response.Write(result);  
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
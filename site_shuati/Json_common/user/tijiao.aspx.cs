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
            PostData PostData = javaScriptSerializer.Deserialize<PostData>(getString(this1));
            return PostData;
        }
        public static string getString(System.Web.UI.Page this1)
        {
            string json1 = (this1.Request.InputStream != null) ? (new System.IO.StreamReader(this1.Request.InputStream).ReadToEnd()) : ""; this1.Request.InputStream.Close();
            return json1;
        }
        //public string login_type;
        //public string phone_number;
        //public string password;
        //public string user_name;
        public string Name = HttpContext.Current.Request["Name"];
        public string Phone = HttpContext.Current.Request["Phone"];
        public string Area = HttpContext.Current.Request["Area"];
        public string Path = HttpContext.Current.Request["Path"];
        public string Gender = HttpContext.Current.Request["Gender"];
        public string XueYuanNianJi = HttpContext.Current.Request["XueYuanNianJi"];
        public string YaoQiuKeCi = HttpContext.Current.Request["YaoQiuKeCi"];
        public string YaoQiukeMu = HttpContext.Current.Request["YaoQiukeMu"];
        public string QinKuang = HttpContext.Current.Request["QinKuang"];
        public string Teachergender = HttpContext.Current.Request["Teachergender"];
        public string TeacherClass = HttpContext.Current.Request["TeacherClass"];
        public string TeacherYaoQiu = HttpContext.Current.Request["TeacherYaoQiu"];
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取post过来的所有json字符串参数
        PostData p1 = PostData.get(this);


        Xb_ParentYaoQiu val = new Xb_ParentYaoQiu()
        {
            Name = p1.Name,
            Phone = p1.Phone,
            Area = p1.Area,
            Path = p1.Path,
            Gender = p1.Gender,
            XueYuanNianJi = p1.XueYuanNianJi,
            YaoQiuKeCi = p1.YaoQiuKeCi,
            YaoQiukeMu = p1.YaoQiukeMu,
            QinKuang = p1.QinKuang,
            Teachergender = p1.Teachergender,
            TeacherClass = p1.TeacherClass

        };

        int cy = BLLTable<Xb_ParentYaoQiu>.Insert(val);
        if (cy > 0)
        {
            RootObject r1 = new RootObject();
            r1.code = 200;
            Response.Write(r1.ToJsonHeadLower());
            Response.End();
        }
        else
        {
            RootObject r1 = new RootObject();

            r1.code = 201;
            Response.Write(r1.ToJsonHeadLower());
            Response.End();

        }

        //    if (!string.IsNullOrEmpty(p1.phone_number))//手机
        //    {
        //        Session["phone_number"] = p1.phone_number;
        //        cond1.Phone_number = p1.phone_number;
        //        user1 = BLLTable<TUserInfo>.GetRowData(cond1);
        //    }
        //    else if (!string.IsNullOrEmpty(p1.user_name))//用户名
        //    {
        //        Session["user_name"] = p1.user_name;
        //        cond1.User_name = p1.user_name;
        //        user1 = BLLTable<TUserInfo>.GetRowData(cond1);
        //    }

        //    RootObject r1 = new RootObject();
        //    if (user1 != null)
        //    {
        //        if (string.IsNullOrEmpty(user1.Token))
        //        {
        //            user1.Token = "22";//app登陆的时候？
        //        }
        //        r1.message = "登入成功" + p1.password;
        //        r1.code = 200;
        //        r1.data.table = user1;


        //        if (user1.Head_img_url != null)
        //        {
        //            setCookie("head_img_url", user1.Head_img_url);
        //            //Session["head_img_url"] = head_img_url;
        //        }
        //        if (user1.Phone_number != null)
        //        {
        //            setCookie("phone_number", user1.Phone_number);
        //        }
        //        if (user1.User_name != null)
        //        {
        //            setCookie("user_name", user1.User_name);
        //        }
        //        //setCookie("phone_number", 1);
        //        setCookie("Token", user1.Token);
        //        setCookie("isLogin", true);
        //        setCookie("openid", user1.Openid);
        //        setCookie("city_id", user1.City_id);
        //        setCookie("user_id", user1.User_id);
        //        setCookie("nick_name", user1.Nick_name);

        //        setCookie("city_name", user1.City);
        //    }
        //    else
        //    {
        //        r1.message = "用户不存在或密码错误" + p1.password;
        //        r1.code = 2101;
        //    }
        //    string json1 = r1.ToJsonHeadLower();
        //    Response.Write(json1);
        //    Response.End();
        //}

        //private void setCookie(string name, object value)
        //{
        //    if (string.IsNullOrEmpty(Convert.ToString(value)))
        //    {
        //    }
        //    HttpCookie version1 = new HttpCookie(name);
        //    version1.Value = Convert.ToString(value);
        //    HttpContext.Current.Response.Cookies.Add(version1);
    }
}
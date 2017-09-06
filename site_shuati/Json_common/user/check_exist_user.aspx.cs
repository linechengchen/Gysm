using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_user_identify_user1 : BasePageShuati
{
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
        public string LoginType = HttpContext.Current.Request["LoginType"];
        public string oper_type = HttpContext.Current.Request["oper_type"];
        public string phone_number = HttpContext.Current.Request["phone_number"];
        public string openid = HttpContext.Current.Request["openid"];
    }

    protected PostData p1 = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        RootObject r1 = new RootObject();
        p1 = new PostData(); //p1 = PostData.get(this);
        if (p1 == null || (string.IsNullOrEmpty(p1.openid) && string.IsNullOrEmpty(p1.phone_number)))
        {
            r1.code = 999;
            Response.Write(r1.ToJsonHeadLower());
            Response.End();
        }
        else if (!string.IsNullOrEmpty(p1.phone_number))
        {
            TUserInfo cond1 = new TUserInfo();
            cond1.Phone_number = p1.phone_number;
            TUserInfo val1=  BLLTable<TUserInfo>.SelectOne(new TUserInfo(), cond1);
            if(val1==null)
            {
                r1.code = 201;   //数据库查询后有手机则，直接返回
                Response.Write(r1.ToJsonHeadLower());
                Response.End();
            }
            r1.code = 200;   //数据库查询后有手机则，直接返回
            Response.Write(r1.ToJsonHeadLower());
            Response.End();
        }
        else
        {
            TUserInfo cond1 = new TUserInfo();
            if (!string.IsNullOrEmpty(p1.phone_number))
                cond1.Phone_number = p1.phone_number;

            if (!string.IsNullOrEmpty(p1.openid))
                cond1.Openid = p1.openid;

            if (p1.oper_type == "201")//注册前检查
            {

            }
            else if (p1.oper_type == "203")//登录后，从首页进来
            {
                //openid
            }
            TUserInfo user1 = BLLTable<TUserInfo>.GetRowData(cond1);
            if (user1 != null && user1.IsNotNull())
            {
                r1.code = 200;   //数据库查询后有手机则，直接返回
                Response.Write(r1.ToJsonHeadLower());
                Response.End();
            }
            else
            {

            }
        }

        p1.LoginType = "2";

        r1.code = 999;
        Response.Write(r1.ToJsonHeadLower());
        Response.End();

    }
}
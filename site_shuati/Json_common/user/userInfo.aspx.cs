using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//{"code":200,"message":"SUCCESS","data":
//{"qq":null,"gender":"1","city":"温州","user_name":"1193658","change":0.0,"wechat_app_openid":null,"point":0,"token"
//:"b8dc2e6e0b7d634bcf67be3e4093ef84","openid":"o0g4tt3rNNXVMfbw6DiEps02Wu6Y","weibo":null,"province":"浙江","user_id":"
//c49ef69b-3a2a-4002-9d1a-996edb402779","province_id":"1","nick_name":"好不","phone_number":"18605887655","city_id":"36"}}

public partial class JsonBook_user_userInfo : BasePageShuati
{

    protected string user_id = "";
    //protected string nick_name = "";


    TUserInfo user1 = null;
    TUserInfo cond1 = new TUserInfo();
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
        public string user_id = HttpContext.Current.Request["user_id"];
        public string nick_name = HttpContext.Current.Request["nick_name"];

    }
    protected void Page_Load(object sender, EventArgs e)
    {

        //获取post过来的所有json字符串参数
        PostData p1 = PostData.get(this);
        if (p1 != null && !string.IsNullOrEmpty(p1.user_id) && !string.IsNullOrEmpty(p1.nick_name))
        {   //不为空修改NAME
            TUserInfo val1 = new TUserInfo();
            TUserInfo cond1 = new TUserInfo();
            cond1.User_id = new Guid(p1.user_id);
            val1.Nick_name = p1.nick_name;
            int ret1 = BLLTable<TUserInfo>.Update(val1, cond1);
            if (ret1 > 0)
            {
                RootObject r2 = new RootObject();
                r2.code = 200;
                Response.Write(r2.ToJsonHeadLower());
                Response.End();
            }
            else
            {
                RootObject r2 = new RootObject();
                r2.code = -1;
                Response.Write(r2.ToJsonHeadLower());
                Response.End();
            }
        }

        RootObject r1 = new RootObject();
        user_id = Request["user_id"].ToString();
        if (!string.IsNullOrEmpty(user_id) && user_id != "null")
        {
            user1 = BLLTable<TUserInfo>.GetRowData(TUserInfo.Attribute.User_id, new Guid(user_id));
            if (user1 != null)
            {
                r1.code = 200;
                r1.message = "SUCCESS";
                r1.data.Add("change", "0.0");
                r1.data.Add("coupon", "0");
                r1.data.Add("point", "0");
                r1.data.table = user1;

                Response.Write(r1.ToJsonHeadLower());
                Response.End();
            }

        }
        else
        {
            //如果数据为空
            r1.code = 300;
            Response.End();
        }
    }
}
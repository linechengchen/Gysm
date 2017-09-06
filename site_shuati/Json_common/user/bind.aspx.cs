using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;

public partial class JsonBook_user_bind : BasePageShuati
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
        public string user_id = HttpContext.Current.Request["user_id"];
        public string type = HttpContext.Current.Request["type"];
        public string openid = HttpContext.Current.Request["openid"];
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取post过来的所有json字符串参数
        PostData PostData = PostData.get(this);

        if (Request["t"] == "1") return; JsonRoot r1 = new JsonRoot();

        if (string.IsNullOrEmpty(PostData.user_id))
            PostData.user_id = Request["user_id"];

        //type=3 //关联登陆 
        if (!string.IsNullOrEmpty(PostData.user_id))
        {
            Session["user_id"] = PostData.user_id;
            r1.code = 200;
            if (!string.IsNullOrEmpty(PostData.openid))
            {
                TUserInfo val1 = new TUserInfo();
                val1.Openid = PostData.openid;
                val1.User_id = new Guid(PostData.user_id);
                int ret1 = BLLTable<TUserInfo>.Update(val1, TUserInfo.Attribute.User_id);
                if (ret1 > 0)
                {
               
                    r1.code = 888;
                    //cookie

                }
            }
        }
        else
        {
            r1.errMsg = "user_id为空";
        }
        Response.Write(r1.ToJsonHeadLower());
        Response.End();
    }
}
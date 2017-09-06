using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _jianzhi_user_account_logout : BasePageShuati
{
    /// <summary>
    /// post到页面的参数对象
    /// </summary>
    [Serializable]
    public class PostData
    {
        public static PostData get(System.Web.UI.Page this1)
        {
            System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            PostData PostData = javaScriptSerializer.Deserialize<PostData>(getString(this1));
            return PostData;
        }
        public static string getString(System.Web.UI.Page this1)
        {
            string json1 = (this1.Request.InputStream != null) ? (new System.IO.StreamReader(this1.Request.InputStream).ReadToEnd()) : ""; this1.Request.InputStream.Close();
            return json1;
        }
        //public string user_id;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["t"] == "1") return; JsonRoot r1 = new JsonRoot();
    }
    private void 例子代码()
    {
        //post获取post过来的所有json字符串参数
        PostData p1 = PostData.get(this);
        if (p1 == null) return;
        //if(p1.user_id == null || p1.user_id == "undefine" || p1.user_id == "null") return;

        //get获取所有json字符串参数
        string user_id = "";
        if (string.IsNullOrEmpty(Request["user_id"]))
            user_id = Convert.ToString(Request["user_id"]);

        if (Request["t"] == "1") return; JsonRoot r1 = new JsonRoot();
        TUserInfo user1 = new TUserInfo();
        user1.Top(100);
        TUserInfo cond1 = new TUserInfo();
        List<TUserInfo> list1 = BLLTable<TUserInfo>.Select(user1, cond1);

        int ret1 = BLLTable<TUserInfo>.Update(user1, TUserInfo.Attribute.User_id);
        if (ret1 > 0)
        {
            r1.code = 200;
            string json1 = r1.ToJsonHeadLower();
            Response.Write(json1);
            Response.End();
        }
    }
}
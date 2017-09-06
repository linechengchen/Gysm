using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_user_coupons : BasePageShuati
{/// <summary>
    /// post到页面的参数对象
    /// </summary>
    [Serializable]
    public class PostData
    {
        public static PostData get(System.Web.UI.Page this1)
        {
            System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            PostData PostData = javaScriptSerializer.Deserialize<PostData>(new System.IO.StreamReader(this1.Request.InputStream).ReadToEnd());
            return PostData;
        }
        public string code;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["t"] == "1") return; JsonRoot r1 = new JsonRoot();
        Xs_TCoupon val1 = new Xs_TCoupon();
        Xs_TCoupon cond1 = new Xs_TCoupon();
        int count = 0;

        //获取post过来的所有json字符串参数
        PostData PostData = PostData.get(this);
        if ("exchange" == (Request["action"]))
        {
            if (!string.IsNullOrEmpty(PostData.code) && !string.IsNullOrEmpty(Request["user_id"]))
            {
                val1.Code = PostData.code;
                val1.User_id = Convert.ToString(Request["user_id"]);
                //if(val1.User_id)
                try
                {
                    int ret1 = BLLTable<Xs_TCoupon>.Insert(val1);//, Xs_TCoupon.Attribute.User_id);
                    if (ret1 > 0)
                    {
                        r1.code = 200;
                        Response.Write(r1.ToJsonHeadLower());
                        Response.End();
                    }
                }catch(Exception ex1)
                {
                    r1.code = 199;
                    r1.message = "已存在";
                    Response.Write(r1.ToJsonHeadLower());
                    Response.End();
                }
            }
        }
        else if ("count" == (Request["action"]))
        {
            if (!string.IsNullOrEmpty(Request["user_id"]))
                cond1.User_id = Convert.ToString(Request["user_id"]);

            int count1 = BLLTable<Xs_TCoupon>.Count(cond1);

            r1.code = 200;
            r1.data.Add("count", count1);
            Response.Write(r1.ToJsonHeadLower());
            Response.End();
        }
        else //查询
        {
            if (!string.IsNullOrEmpty(Request["page"]) && !string.IsNullOrEmpty(Request["type"]) && !string.IsNullOrEmpty(Request["user_id"]))
            {
                if ("expired" == (Request["action"]))
                    cond1.State = -1;
                //else
                //    cond1.State = 0;
                if (Convert.ToString(Request["type"]) != "-1")
                    cond1.Type = Convert.ToString(Request["type"]);
                if (!string.IsNullOrEmpty(Request["user_id"]))
                    cond1.User_id = Convert.ToString(Request["user_id"]);
                int pageIndex = 0;
                if (!string.IsNullOrEmpty(Request["page"]))
                    pageIndex = Convert.ToInt32(Request["page"]);
                List<Xs_TCoupon> list1 = BLLTable<Xs_TCoupon>.SelectByPage(val1, cond1, 10, pageIndex, ref count);
                r1.code = 200;
                r1.Add(list1, "unexpiredCoupons");
                Response.Write(r1.ToJsonHeadLower());
                Response.End();
            }
            else if (!string.IsNullOrEmpty(Request["id"]))
            {
                Xs_TCoupon TCoupon1 = BLLTable<Xs_TCoupon>.GetRowData(Xs_TCoupon.Attribute.Id, Request["id"]);
                r1.code = 200;
                r1.Add(TCoupon1, "coupon");
                Response.Write(r1.ToJsonHeadLower());
                Response.End();
            }
        }
        r1.code = 0;
        Response.Write(r1.ToJsonLower());
        Response.End();
    }
}
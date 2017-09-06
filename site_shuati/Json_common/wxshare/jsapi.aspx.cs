using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_wxshare : BasePageShuati
{
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
        public string url;
    }

    protected PostData p1 = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        //RootObject r1 = new RootObject();
        //p1 = PostData.get(this);
        //if (p1 != null && p1.url != null)
        //{
        //    //检查p1.url是否已微信登陆，否则返回非200
        //    if (false)
        //    {
        //        r1.code = -1;
        //        r1.message = "failed";

        //        Response.Write(r1.ToJsonHeadLower());
        //        Response.End();
        //    }
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_user_loginout : BasePageCookie
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
        public string uid = HttpContext.Current.Request["uid"];
    }

    protected PostData p1 = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        RootObject r1 = new RootObject();
        p1 = new PostData(); //p1 = PostData.get(this); //p1 = PostData.get(this);
        if (p1 != null && p1.uid != null)
        {

        }
        string OriginType = this.Request.Headers["OriginType"];
        string version = this.Request.Headers["version"];
        string contenttype = this.Request.Headers["content-type"];
        if (OriginType=="h5")
        {

        }

        HttpContext.Current.Response.Cookies.Clear();

        this.DelCookeis();

        r1.code = 200;
        Response.Write(r1.ToJsonHeadLower());
        Response.End();
    }
}
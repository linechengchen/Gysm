using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_home_viewHomePage : BasePageShuati
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
        public string channel = HttpContext.Current.Request["channel"];
        public string ip = HttpContext.Current.Request["ip"];
        public string province = HttpContext.Current.Request["province"];
        public string city = HttpContext.Current.Request["city"];
        public string school = HttpContext.Current.Request["school"];
        public string location = HttpContext.Current.Request["location"];
        public string app_type = HttpContext.Current.Request["app_type"];
        public string wifi = HttpContext.Current.Request["wifi"];
        public string app_version = HttpContext.Current.Request["app_version"];
        public string manufacturer = HttpContext.Current.Request["manufacturer"];
        public string model = HttpContext.Current.Request["model"];
        public string os = HttpContext.Current.Request["os"];
        public string os_version = HttpContext.Current.Request["os_version"];
        public string screen_width = HttpContext.Current.Request["screen_width"];
        public string screen_height = HttpContext.Current.Request["screen_height"];
    }

    protected PostData p1 = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        RootObject r1 = new RootObject();
        p1 = new PostData(); //p1 = PostData.get(this); //p1 = PostData.get(this);
        if (p1 != null)
        {
            string openid = this.Request.Headers["openid"];
            if(!string.IsNullOrEmpty(openid))
            {
                r1.code = 200;
                r1.message = "success";

                Response.Write(r1.ToJsonHeadLower());
                Response.End();
            }
        }
        r1.code = -1;
        //r1.message = "您还未登录";

        Response.Write(r1.ToJsonHeadLower());
        Response.End();
    }
}
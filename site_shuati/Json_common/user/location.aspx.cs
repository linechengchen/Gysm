using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_user_location : BasePageShuati
{
    //{"city":"温州","city_id":"36","user_id":"c49ef69b-3a2a-4002-9d1a-996edb402779"}
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
        public string city;
        public string city_id;
        public string user_id;
     
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
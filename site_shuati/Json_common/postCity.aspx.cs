using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_postDepartment : BasePageShuati
{
    protected string openid = "";//zlg
    protected string sc = "194";//zlg

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
        public string openid = HttpContext.Current.Request["openid"];
        public string user_id = HttpContext.Current.Request["user_id"];
        public string user_name = HttpContext.Current.Request["user_name"];

        public string city_id = HttpContext.Current.Request["city_id"];
        public string city_name = HttpContext.Current.Request["city_name"];
        public string latitude = HttpContext.Current.Request["latitude"];
        public string longitude = HttpContext.Current.Request["longitude"];

        public string school_id = HttpContext.Current.Request["school_id"];
        public string school_name = HttpContext.Current.Request["school_name"];
        public string department_id = HttpContext.Current.Request["department_id"];
        public string department_name = HttpContext.Current.Request["department_name"];
        public string grade = HttpContext.Current.Request["grade"];
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        RootObject r2 = new RootObject();
        //try
        //{
        //获取post过来的所有json字符串参数
        PostData p1 = PostData.get(this);
        if (p1 == null || p1.user_id == null || p1.user_id == "undefine" || p1.user_id == "null") return;

        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        TUserInfo userUpdate1 = new TUserInfo();
        TUserInfo user1 = new TUserInfo();
        TCity city1 = new TCity();
        TCity cond1 = new TCity();
        if (!string.IsNullOrEmpty(p1.openid))
        {
            user1.Openid = p1.openid;
            city1.Create_by = p1.openid.ToString();
        }
        if (!string.IsNullOrEmpty(p1.user_id))
        {
            user1.User_id = new Guid(p1.user_id);
            city1.Create_by = user1.User_id.ToString();
        }
        if (!string.IsNullOrEmpty(p1.user_name))
        {
            city1.Create_by_name = p1.user_name.ToString();
        }
        if (!string.IsNullOrEmpty(p1.city_id))
        {
            userUpdate1.City_id = Convert.ToInt32(p1.city_id);
            city1.Id = Convert.ToInt32(p1.city_id);
        }
        if (!string.IsNullOrEmpty(p1.city_name))
        {
            userUpdate1.City = Convert.ToString(p1.city_name);
            city1.Name = Convert.ToString(p1.city_name);
        }
        else
            r2.AddTop("city1", "city_name不存在，异常");

        if (!string.IsNullOrEmpty(city1.Name) && user1.User_id != null)
        {
            TCity td1 = BLLTable<TCity>.GetRowData(TCity.Attribute.Name, city1.Name);
            if (td1 != null && td1.IsNotNull())
            {
                r2.code = 201;
                r2.errMsg = "已存在名称重复";
                Response.Write(r2.ToJsonHeadLower());
                Response.End();

                city1.Id = td1.Id;

                int ret1 = BLLTable<TCity>.Update(city1, TCity.Attribute.Id);
                if (ret1 > 0)
                {
                    r2.code = 200;
                    r2.data.Add("p1.id", city1.Id);
                }
            }
            else
            {
                int ret1 = BLLTable<TCity>.Insert(city1, TCity.Attribute.Id);
                if (ret1 > 0)
                {
                    r2.code = 200;
                    r2.data.Add("p1.id", city1.Id);
                    if (user1.User_id != default(Guid) && !string.IsNullOrEmpty(user1.Openid))
                    {
                        userUpdate1.City_id = city1.Id;
                        userUpdate1.City = city1.Name;

                        int ret2 = BLLTable<TUserInfo>.Update(userUpdate1, user1);
                        if (ret2 > 0)
                        {
                            r2.code = 200;
                            r2.data.Add("p1.User_id", user1.User_id.ToString());
                        }
                    }
                }
            }
        }
        string json1 = r2.ToJsonHeadLower();
        Response.Write(json1);
        Response.End();
    }
}
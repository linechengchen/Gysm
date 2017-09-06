using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Json_b_search : BasePageShuati
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
        public string keyword = HttpContext.Current.Request["keyword"];
        public string city_id = HttpContext.Current.Request["city_id"];
        public string page = HttpContext.Current.Request["page"];
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取post过来的所有json字符串参数
        St_kemuInfo cond1 = new St_kemuInfo();
        PostData p1 = PostData.get(this);
        List<St_kemuInfo> listkemu = new List<St_kemuInfo>();
        #region  科目名称查询
        if (!string.IsNullOrEmpty(p1.keyword))
        {
            string keyword = p1.keyword;
            cond1.Where(string.Format(" KemuName like '%{0}%'", keyword));
            listkemu = BLLTable<St_kemuInfo>.Select(new St_kemuInfo(), cond1);
        }
        RootObject r1 = new RootObject();

        r1.code = 200;
        r1.Add("kemu", listkemu);
        string json1 = r1.ToJson();
        Response.Write(json1);
        Response.End();


        #endregion


        //int pageSize = 10;
        //int pageIndex = 0;
        //int count = -1;
        //Xs_book val1 = new Xs_book();
        //Xs_book cond1 = new Xs_book();
        //if (!string.IsNullOrEmpty(p1.page))
        //{
        //    pageIndex = Convert.ToInt32(p1.page);
        //}
        ////if (!string.IsNullOrEmpty(p1.city_id))
        ////{
        ////    cond1.City_id = Convert.ToInt32(p1.city_id);
        ////}
        //if (!string.IsNullOrEmpty(p1.keyword))
        //{
        //    cond1.Where("Title like '%" + p1.keyword + "%'");
        //}
        //List<Xs_book> list1 = BLLTable<Xs_book>.SelectByPage(val1, cond1, pageSize, pageIndex, ref count);
        //if (Request["t"] == "1") return; JsonRoot r1 = new JsonRoot();
        //r1.code = 200;
        //r1.message = "查询成功";
        //r1.Add(list1,"books");
        //string json1 = r1.ToJsonLower();
        //Response.Write(json1);
        //Response.End();
    }


}
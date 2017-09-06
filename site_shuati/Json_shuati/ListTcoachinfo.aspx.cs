using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/// <summary>
/// https://localhost:62259/json_shuati/jsonzs.aspx?sc=192wz%20cs%E5%AD%A6%E6%A0%A1
/// </summary>
/// 
public partial class Json_TTeacherInfo : BasePageShuati
{
    List<xc_Coach> listTcoach = new List<xc_Coach>();
  

    protected void Page_Load(object sender, EventArgs e)
    {
        xc_Coach val1 = new xc_Coach();
        val1.Top(100);
        listTcoach = BLLTable<xc_Coach>.Select(val1);
        if (Request["t"] == "1") return; JsonRoot r1 = new JsonRoot();
        r1.code = 200;
        r1.Add(listTcoach);
        Response.Write(r1.ToJson());
        Response.End();



        //setParams();
        //string url1 = cacheUrl();
        //string pageCacheKey = "ListTTeacherInfo.aspx";
        ////MyRedis.Factory().Hash_Remove(pageCacheKey);
        //if (MyRedis.Factory().Hash_Exist<string>(pageCacheKey, url1))
        //{
        //    string js1 = MyRedis.Factory().Hash_Get<string>(pageCacheKey, url1); if (!string.IsNullOrEmpty(js1)) { Response.Write(js1.Replace("{", "{\"cache\":\"1\",")); return; }
        //}
        //Xb_TeacherInfo val1 = new Xb_TeacherInfo();
        //Xb_TeacherInfo cond1 = new Xb_TeacherInfo();

        //listTzs = BLLTable<Xb_TeacherInfo>.Select(val1, cond1);
        //RootObject r1 = new RootObject(MyDebugger.IsAttached); r1.isShuati = true;
        //r1.Add(listTzs);

        //string json1 = r1.ToJson();
        //try
        //{
        //    if (listTzs.Count > 0 && !string.IsNullOrEmpty(json1))
        //    {
        //        bool ret1 = MyRedis.Factory().Hash_Set<string>(pageCacheKey, url1, json1);
        //    }
        //}
        //catch (Exception e1)
        //{
        //    Cs.Info(e1.ToString());
        //}
        //Response.Write(json1);
        //return;
    }
}
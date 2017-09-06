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
    List<Xb_TeacherInfo> listTzs = new List<Xb_TeacherInfo>();

    protected static AFDictionary<string, string> dicCache1 = new AFDictionary<string, string>();

    protected string cacheUrl()
    {
        string url2 = StringHelper.CutOutString(this.Request.Url.ToString(), "source1=", "&");
        url2 = StringHelper.CutOutString(url2, "r=", "&");
        //url2 = StringHelper.CutOutString(url2, "neice=", "&");
        url2 = StringHelper.CutOutString(url2, "type1=", "&");

        if (!string.IsNullOrEmpty(Request["openid"]))
            openid = Request["openid"].ToString();
        if (!string.IsNullOrEmpty(Convert.ToString(Session["openid"])))
            openid = Convert.ToString(Session["openid"]);
        if (!string.IsNullOrEmpty(openid) && openid != "null")
            url2 = openid;
        return url2;
    }
    protected string sc = "999";//zlg
    protected string type1 = "";
    protected string source1 = "";
    protected string openid = "";
    protected void setParams()
    {
        if (!string.IsNullOrEmpty(Request["openid"]))
        {
            openid = Convert.ToString(Request["openid"]);
        }
        if (!string.IsNullOrEmpty(Request["type1"]))
        {
            type1 = Convert.ToString(Request["type1"]);
        }
        if (!string.IsNullOrEmpty(Request["source1"]))
        {
            source1 = Convert.ToString(Request["source1"]);
        }
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        setParams();
        string url1 = cacheUrl();
        string pageCacheKey = "ListTTeacherInfo.aspx";
        //MyRedis.Factory().Hash_Remove(pageCacheKey);
        if (MyRedis.Factory().Hash_Exist<string>(pageCacheKey, url1))
        {
            string js1 = MyRedis.Factory().Hash_Get<string>(pageCacheKey, url1); if (!string.IsNullOrEmpty(js1)) { Response.Write(js1.Replace("{", "{\"cache\":\"1\",")); return; }
        }
        Xb_TeacherInfo val1 = new Xb_TeacherInfo();
        Xb_TeacherInfo cond1 = new Xb_TeacherInfo();

        listTzs = BLLTable<Xb_TeacherInfo>.Select(val1, cond1);
        RootObject r1 = new RootObject(MyDebugger.IsAttached); r1.isShuati = true;
        r1.Add(listTzs);

        string json1 = r1.ToJson();
        try
        {
            if (listTzs.Count > 0 && !string.IsNullOrEmpty(json1))
            {
                bool ret1 = MyRedis.Factory().Hash_Set<string>(pageCacheKey, url1, json1);
            }
        }
        catch (Exception e1)
        {
            Cs.Info(e1.ToString());
        }
        Response.Write(json1);
        return;
    }
}
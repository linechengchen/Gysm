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
/// http://localhost:62259/json_shuati/jsonzs.aspx?sc=192wz%20cs%E5%AD%A6%E6%A0%A1
/// </summary>
public partial class Json_jsonzs : BasePageShuati
{
    protected string tu2wei = "";//zlg
    protected string agent = "";
    protected string openid = "";//zlg
    protected string sc_name = "";

    protected List<Xs_book> tbooklist = new List<Xs_book>();

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
            url2 += openid;
        return url2;
    }
    protected string sc = "194";//zlg
    protected string type1 = "";
    protected string source1 = "";
    protected void setParams()
    {
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
        string pageCacheKey = "ListBookSaleIndex.aspx";
        //MyRedis.Factory().Hash_Remove(pageCacheKey);
        if (MyRedis.Factory().Hash_Exist<string>(pageCacheKey, sc + openid))
        {
            if (!string.IsNullOrEmpty(sc) && !string.IsNullOrEmpty(openid))
            {
                string js1 = MyRedis.Factory().Hash_Get<string>(pageCacheKey, sc + openid); if (!string.IsNullOrEmpty(js1)) { Response.Write(js1.Replace("{", "{\"cache\":\"1\",")); return; }
            }
        }

        /////////////////这里
        if (tbooklist.Count == 0)
        {
            Xs_book condkemu = new Xs_book();
            //condkemu.IsShowIndex = true;
            tbooklist = BLLTable<Xs_book>.Select(new Xs_book(), condkemu);
        }        
        if (!string.IsNullOrEmpty(sc))
        {
            sc_name = StringHelper.GetHanZi(BLL1.getDaxueName(sc));
        }
        tu2wei = BLL1.getFile(sc);

        RootObject r1 = new RootObject(MyDebugger.IsAttached); r1.isShuati = true;
        if (!string.IsNullOrEmpty(openid) && openid != "null")
            r1.data.Add("openid", openid);

        r1.Add(tbooklist, "");

        r1.data.Add("tu2wei", "tu2wei");
        r1.data.Add("sc_name", sc_name);

        r1.data.Add("img1", @"image\huadongtu1.jpg");
        r1.data.Add("img2", @"image\hdt2.jpg");
        r1.data.Add("img3", @"image\huadongtu3.jpg");
        r1.data.Add("img4", @"image\滑动图4.jpg");

        r1.Add(tbooklist);

        //取得本页广告
        TggInfo ggcond1 = new TggInfo();
        ggcond1._GgSourceUrl = "kemuIndex.html";
        List<TggInfo> gglist = BLLTable<TggInfo>.Select(new TggInfo(), ggcond1);
        r1.Add(gglist);

        string json1 = r1.ToJson();
        try
        {
            if (tbooklist.Count > 0 && !string.IsNullOrEmpty(json1))
            {
                //MyRedis.Factory().Hash_SetTable<TggInfo>(pageCacheKey, sc + openid, new TggInfo());
                MyRedis.Factory().Hash_Set<string>(pageCacheKey, sc + openid, json1);
            }
        }
        catch (Exception e1)
        {
            Cs.Info(e1.ToString());
        }
        Response.Write(json1);
    }
}
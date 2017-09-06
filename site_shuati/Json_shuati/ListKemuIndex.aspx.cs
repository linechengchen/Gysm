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
    protected string agent = "";
    protected string openid = "";//zlg
    protected string user_id = "";//zlg

    protected List<St_kemuInfo> tkmlist = new List<St_kemuInfo>();

    protected List<St_TzsInfo> tzslist = new List<St_TzsInfo>();

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
    
    protected string defaultSc = "194";//zlg
    protected string sc = "";//zlg
    protected string school_id = "";//zlg
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
        if (!string.IsNullOrEmpty(Request["school_id"]))
        {
            school_id  = Convert.ToString(Request["school_id"]);
        }
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        if (!string.IsNullOrEmpty(Convert.ToString(Session["openid"])))
        {
            openid = Convert.ToString(Session["openid"]);
        }
        if (!string.IsNullOrEmpty(Request["openid"]))
        {
            openid = Convert.ToString(Request["openid"]);
        }
        if (!string.IsNullOrEmpty(Request["user_id"]))
        {
            user_id = Request["user_id"].ToString();
        }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        RootObject r1 = new RootObject(MyDebugger.IsAttached); r1.isShuati = true;

        setParams();
        Cs.Debug("ListKemuIndex1.aspx");
        string url1 = cacheUrl();
        string pageCacheKey = "ListKemuIndex1.aspx";
        //MyRedis.Factory().Hash_Remove(pageCacheKey);
        if (MyRedis.Factory().Hash_Exist<string>(pageCacheKey, sc + openid))
        {
            if (!string.IsNullOrEmpty(sc) && !string.IsNullOrEmpty(openid))
            {
                string js1 = MyRedis.Factory().Hash_Get<string>(pageCacheKey, sc + openid); if (!string.IsNullOrEmpty(js1)) { Response.Write(js1.Replace("{", "{\"cache\":\"1\",")); return; }
            }
        }

        //搜索用户自己配置的数据。包括 选中和未选中的。
        St_TUserZsInfo cond31 = new St_TUserZsInfo();
        if (!string.IsNullOrEmpty(openid) && openid != "null")
        {
            cond31.OpenId = openid;
        }
        if (!string.IsNullOrEmpty(user_id) && user_id != "null")
        {
            cond31.User_id = user_id;
        }
        AFDictionary<string, bool> dicSel1 = new AFDictionary<string, bool>();
        AFDictionary<string, bool> dicSel2 = new AFDictionary<string, bool>();
        if (cond31.IsNotNull())
        {
            St_TUserZsInfo userZs1 = BLLTable<St_TUserZsInfo>.GetRowData(cond31);
            if (userZs1 != null && userZs1.IsNotNull())//
            {
                int count1 = 0;
                if (!string.IsNullOrEmpty(userZs1.KemuInfoJson_no))
                    foreach (string kemuId in userZs1.KemuInfoJson_no.Split(','))
                    {
                        if (string.IsNullOrEmpty(kemuId)) continue;
                        dicSel1.Add(kemuId, false); count1++;
                    }
                int count2 = 0;
                if (!string.IsNullOrEmpty(userZs1.KemuInfoJson_sel))
                    foreach (string kemuId in userZs1.KemuInfoJson_sel.Split(','))
                    {
                        if (string.IsNullOrEmpty(kemuId)) continue;
                        dicSel1.Add(kemuId, true); count2++;
                    }
                int count3 = 0;
                if (!string.IsNullOrEmpty(userZs1.KemuInfoJson_zs_no))
                    foreach (string kemuId in userZs1.KemuInfoJson_zs_no.Split(','))
                    {
                        if (string.IsNullOrEmpty(kemuId)) continue;
                        dicSel2.Add(kemuId, false); count3++;
                    }
                int count4 = 0;
                if (!string.IsNullOrEmpty(userZs1.KemuInfoJson_zs_sel))
                    foreach (string kemuId in userZs1.KemuInfoJson_zs_sel.Split(','))
                    {
                        if (string.IsNullOrEmpty(kemuId)) continue;
                        dicSel2.Add(kemuId, true); count4++;
                    }
                r1.AddTop("msg1", "有用户记录 false = " + count1 + " true = " + count2 + " false= " + count3 + " true=" + count4);
            }
        }
        /////////////////大学科目
        St_kemuInfo condkemu = new St_kemuInfo();
        //condkemu.OrderBy(St_kemuInfo.Attribute.Seq, Order.Desc);
        condkemu.OrderBy(St_kemuInfo.Attribute.KemuId, Order.Asc);
        condkemu.KemuType = 1;

        St_kemuInfo valkemu1 = new St_kemuInfo();
        valkemu1.KemuId = 0;
        valkemu1.KemuName = "";
        valkemu1.ZsId = 0;
        valkemu1.IsShowIndex = false;
        tkmlist = BLLTable<St_kemuInfo>.Select(new St_kemuInfo(), condkemu);
        //赋值：是否显示在页面上
        foreach (St_kemuInfo kemu1 in tkmlist)
        {
            bool sel1 = false;
            if (dicSel1.TryGetValue(kemu1.KemuId.ToString(), out sel1))
            {
                kemu1.IsShowIndex = sel1;
                continue;
            }
        }
        r1.Add(tkmlist);//增加大学课程
        /////////////////这里

        St_TzsInfo val1 = new St_TzsInfo();
        val1.ZsName = "";
        val1.ZsId = 0;
        val1.ZsTypeId = 0;
        val1.Question_sum = 0;
        val1.IsShowIndex = false;

        St_TzsInfo condtsc = new St_TzsInfo();
        condtsc.OrderBy(St_TzsInfo.Attribute.Seq, Order.Desc);

        //考证
        tzslist = BLLTable<St_TzsInfo>.Select(val1, condtsc);
        foreach (St_TzsInfo kemu1 in tzslist)
        {            
            bool sel1 = false;
            if (dicSel2.TryGetValue(kemu1.ZsId.ToString(), out sel1))
            {
                kemu1.IsShowIndex = sel1;
                continue;
            }
        }
        TscWxInfo cond11 = new TscWxInfo();
        /////////////////这里
        if (!string.IsNullOrEmpty(sc) && sc != "999")
        {
            cond11.Sc_id = sc;
        }
        if (!string.IsNullOrEmpty(school_id))
        {
            cond11.School_id = Convert.ToInt32(school_id);
        }
        if (cond11.IsNotNull())
        {
            //通过关联表查询
            TscWxInfo tsc = BLLTable<TscWxInfo>.GetRowData(cond11);
            if (tsc != null && tsc.IsNotNull() && tsc.School_id != 0 )
            {
            }
            else if (cond11.Sc_id != null && cond11.Sc_id.Length > 3)
            {
                cond11.Sc_id = cond11.Sc_id.Substring(0, 3);
                tsc = BLLTable<TscWxInfo>.GetRowData(TscWxInfo.Attribute.Sc_id, cond11.Sc_id);
            }
            if (tsc != null && tsc.IsNotNull() && tsc.School_id != 0)
            {
                r1.data.Add("school_id", tsc.School_id);
                r1.data.Add("school_name", tsc.Sc_name);
                r1.data.Add("sc", tsc.Sc_id);
                r1.data.Add("sc_id", tsc.Sc_id);                
                sc = tsc.Sc_id;
            }
            if (!string.IsNullOrEmpty(sc))
            {
                string sc_name = "";
                //重新加载大学列表
                //BLL1.daxue_NumDic.Clear();
                sc_name = StringHelper.GetHanZi(BLL1.getDaxueName(sc));
                if (sc.Length > 3 && string.IsNullOrEmpty(sc_name))
                    sc_name = StringHelper.GetHanZi(BLL1.getDaxueName(sc.Substring(0, 3)));
                string tu2wei = BLL1.getFile(sc);
                r1.data.Add("sc_name", sc_name);
                r1.data.Add("tu2wei", tu2wei);
                //school_id
            }
        }

        //下面是证书里面包含科目的情况。
        //root1.Add(tsclist);
        //if (!string.IsNullOrEmpty(Request["pid"]))  ///
        ////cond1.Where("pid != 0");
        //cond1.Where("kemuid != '396'");

        //#region  科目名称查询
        //if(!string.IsNullOrEmpty(Request["keyword"]))
        //{
        //    string keyword = Request["keyword"];
        //    cond1.Where(string.Format(" KemuName like '%{0}%'", keyword));
        //}
        //#endregion
        
        //关联证书与 证书内的科目
        //List<St_kemuInfo_zs> tkmlist2 = RootObject.Select(tzslist, new St_kemuInfo_zs(), cond1, St_TzsInfo.Attribute.ZsId, St_kemuInfo_zs.Attribute.ZsId);
        //Dictionary<int, int> ktmuDic = new Dictionary<int, int>();
        //foreach (St_kemuInfo_zs t1 in tkmlist2)
        //{
        //    if (!ktmuDic.ContainsKey(t1.PId))
        //    {
        //        ktmuDic.Add(t1.PId, 0);
        //    }
        //}
        //List<St_kemuInfo_zs> tkmlist31 = new List<St_kemuInfo_zs>();
        //foreach (St_kemuInfo_zs t1 in tkmlist2)
        //{
        //    if (ktmuDic.ContainsKey(t1.KemuId))
        //    {
        //        tkmlist31.Add(t1);
        //    }
        //}
        //foreach (St_kemuInfo_zs t1 in tkmlist31)
        //{
        //    tkmlist2.Remove(t1);
        //}


        //zlg标记！！！
        //St_kemuInfo_zs cond1 = new St_kemuInfo_zs();
        //cond1.Where("Question_sum != 0");
        //List<St_kemuInfo_zs> tkmlist2 = BLLTable<St_kemuInfo_zs>.Select(cond1);
        //string json2 = BLLTable<St_TzsInfo>.JsonTree(tzslist, tkmlist2,
        //    St_TzsInfo.Attribute.ZsId, St_kemuInfo_zs.Attribute.ZsId);
        ////r1.Add(tzslist, tkmlist2, St_TzsInfo.Attribute.ZsId, St_kemuInfo_zs.Attribute.ZsId);
        //r1.data.Add("St_TzsInfo", json2);

        if (!string.IsNullOrEmpty(openid) && openid != "null")
            r1.data.Add("openid", openid);

        if (!string.IsNullOrEmpty(user_id))
            r1.data.Add("user_id", user_id);

        r1.data.Add("img1", @"image\huadongtu1.jpg");
        r1.data.Add("img2", @"image\hdt2.jpg");
        r1.data.Add("img3", @"image\huadongtu3.jpg");
        r1.data.Add("img4", @"image\滑动图4.jpg");

        //取得本页广告
        TggInfo ggcond1 = new TggInfo();
        ggcond1._GgSourceUrl = "kemuIndex.html";
        //List<TggInfo> gglist = BLLTable<TggInfo>.Select(new TggInfo(), ggcond1);
        //r1.Add(gglist);

        bool isJiami = ("1" == Request["jiami"]) || !("1" == Request["neice"] || Request.Url.ToString().Contains("http://localhost"));
        string json1 = r1.ToJson(isJiami);
        
        try
        {
            if (tkmlist.Count > 0 && !string.IsNullOrEmpty(json1))
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
using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/// <summary>
/// http://localhost:62259/json_shuati/jsonzs.aspx?sc=192wz%20cs%E5%AD%A6%E6%A0%A1
/// </summary>
/// 
public partial class Json_jsonzs : BasePageShuati
{
    string openid = null;
    string user_id = null;
    List<St_TzsInfo> listTzs = new List<St_TzsInfo>();
    List<St_TzsTypeInfo> listtzsType = new List<St_TzsTypeInfo>();
    Dictionary<int, string> dic1 = new Dictionary<int, string>();

    protected static AFDictionary<string, string> dicCache1 = new AFDictionary<string, string>();

    protected string cacheUrl()
    {
        string url2 = StringHelper.CutOutString(this.Request.Url.ToString(), "source1=", "&");
        url2 = StringHelper.CutOutString(url2, "r=", "&");
        //url2 = StringHelper.CutOutString(url2, "neice=", "&");
        url2 = StringHelper.CutOutString(url2, "type1=", "&");

        if (!string.IsNullOrEmpty(Request["openid"]))
        {
            openid = Request["openid"].ToString();
        }
        if (string.IsNullOrEmpty(openid))
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["openid"])))
            {
                openid = Convert.ToString(Session["openid"]);
            }
        }
        if (!string.IsNullOrEmpty(Request["user_id"]))
        {
            user_id = Request["user_id"].ToString();
        }
        if (!string.IsNullOrEmpty(openid) && openid != "null")
            url2 = openid;
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
        setParams();
        string url1 = cacheUrl();
        string pageCacheKey = "ListZs.aspx";
        //MyRedis.Factory().Hash_Remove(pageCacheKey);
        if (MyRedis.Factory().Hash_Exist<string>(pageCacheKey, sc + openid))
        {
            if (!string.IsNullOrEmpty(sc) && !string.IsNullOrEmpty(openid))
            {
                string js1 = MyRedis.Factory().Hash_Get<string>(pageCacheKey, sc + openid); if (!string.IsNullOrEmpty(js1)) { Response.Write(js1.Replace("{", "{\"cache\":\"1\",")); return; }
            }
        }

        RootObject r1 = new RootObject(MyDebugger.IsAttached); r1.isShuati = true;
        if (!string.IsNullOrEmpty(sc))
        {
            //重新加载大学列表
            //BLL1.daxue_NumDic.Clear();
            string sc_name = StringHelper.GetHanZi(BLL1.getDaxueName(sc));
            if (sc.Length > 3 && string.IsNullOrEmpty(sc_name))
                sc_name = StringHelper.GetHanZi(BLL1.getDaxueName(sc.Substring(0, 3)));
            string tu2wei = BLL1.getFile(sc);
            r1.data.Add("sc_name", sc_name);
            r1.data.Add("tu2wei", tu2wei);

            //通过关联表查询
            TscWxInfo tsc = BLLTable<TscWxInfo>.GetRowData(TscWxInfo.Attribute.Sc_id, sc);
            if (tsc != null && tsc.IsNotNull())
            {
                r1.data.Add("school_id", tsc.School_id);
                r1.data.Add("school_name", tsc.Sc_name);
            }
        }

        //搜索用户自己配置的数据。包括 选中和未选中的。
        St_TUserZsInfo cond3 = new St_TUserZsInfo();
        if (!string.IsNullOrEmpty(openid) && openid != "null")
        {
            cond3.OpenId = openid;
        }
        if (!string.IsNullOrEmpty(user_id) && user_id != "null")
        {
            cond3.User_id = user_id;
        }
        if (string.IsNullOrEmpty(openid)&&string.IsNullOrEmpty(user_id))
        {
            r1.AddTop("err3","错误：userid openid为空");
        }
        AFDictionary<string, bool> dicSel1 = new AFDictionary<string, bool>();
        AFDictionary<string, bool> dicSel2 = new AFDictionary<string, bool>();
        if (!string.IsNullOrEmpty(Request["admin"]))
        {
            string act = Request["admin"].ToString();
            if (act == "1")
            {
            }
        }
        else
        {
            St_TUserZsInfo userZs1 = BLLTable<St_TUserZsInfo>.GetRowData(cond3);
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
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        //listTzs = BLLTable<St_TzsInfo>.Select();
        //listtzsType = BLLTable<St_TzsTypeInfo>.Select();
        //foreach (St_TzsTypeInfo item in listtzsType)
        //{
        //    dic1.Add(item.Id, item.TypeName);
        //}
        St_TzsInfo val1 = new St_TzsInfo();
        val1.ZsName = "";
        val1.ZsId = 0;
        val1.ZsTypeId = 0;
        val1.Question_sum = 0;
        val1.IsShowIndex = false;

        St_TzsInfo cond1 = new St_TzsInfo();
        cond1.OrderBy(St_TzsInfo.Attribute.Seq, Order.Desc);

        St_TzsTypeInfo val2 = new St_TzsTypeInfo();
        val2.TypeId = 0;
        val2.TypeName = "";

        St_TzsTypeInfo cond2 = new St_TzsTypeInfo();
        cond2.OrderBy(St_TzsTypeInfo.Attribute.Seq, Order.Desc);

        List<St_TzsInfo> zsList = BLLTable<St_TzsInfo>.Select(val1);
        List<St_TzsTypeInfo> zsTypeList = BLLTable<St_TzsTypeInfo>.Select(val2, cond2);

        //赋值：是否显示在页面上
        foreach (St_TzsInfo kemu1 in zsList)
        {
            bool sel1 = false;
            if (dicSel2.TryGetValue(kemu1.ZsId.ToString(), out sel1))
            {
                kemu1.IsShowIndex = sel1;
                continue;
            }
        }

        /////////////////这里
        List<St_kemuInfo> tkmlist = new List<St_kemuInfo>();
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
            if (kemu1.KemuId == 100036)
            { 
            }
            bool sel1 = false;
            if (dicSel1.TryGetValue(kemu1.KemuId.ToString(), out sel1))
            {
                kemu1.IsShowIndex = sel1;
                continue;
            }
        }
        /////////////////这里

        if (!string.IsNullOrEmpty(Convert.ToString(Session["openid"])))
            r1.data.Add("openid", Convert.ToString(Session["openid"]));
        r1.Add(tkmlist);

        AttributeItem relationAttr1 = St_TzsTypeInfo.Attribute.TypeId;
        AttributeItem relationAttr2 = St_TzsInfo.Attribute.ZsTypeId;

        r1.Add(zsTypeList, zsList, relationAttr1, relationAttr2);

        string json1 = r1.ToJson(false);
        try
        {
            if (!string.IsNullOrEmpty(json1))//tkmlist.Count > 0 && listTzs.Count > 0 &&
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
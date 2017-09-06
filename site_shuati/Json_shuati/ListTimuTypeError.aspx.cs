using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Json_ListOptionTypePageError : BasePageShuati
{
    public int pageSize = 10;

    protected string sc = "";
    protected string tmp_sc_sum = "";
    protected string sc_sum = "";
    public string kemuName = "";
    public string kemuId = "";
    public string zsId = "";
    public int questionId = -1;
    public string readType = "1";
    public int top = 50;
    public int pageIndex = 1;
    public string leimu = "";
    public string openid = "";
    public string user_id = "";
    public string deviceId = "";
    string question_sum = "0";
    public string type = "sequence";//顺序出题
    public int id = 0;
    public int errorid = 0;
    public int questionid_max = -1;
    public int questionid_min = 9999;
    public int questionid_big = -1;
    public int questionid_small = -1;

    private void setTitle()
    {
        if (!string.IsNullOrEmpty(Convert.ToString(Session["openid"])))
        {
            openid = Convert.ToString(Session["openid"]);
        }
        if (string.IsNullOrEmpty(openid) || openid == "undefined")
        {
            if (!string.IsNullOrEmpty(Request["openid"]))
            {
                openid = Request["openid"].ToString();
            }
        }
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        if (!string.IsNullOrEmpty(Request["tmp_sc_sum"]))
        {
            tmp_sc_sum = Convert.ToString(Request["tmp_sc_sum"]);
        }
        if (!string.IsNullOrEmpty(Request["sc_sum"]))
        {
            sc_sum = Convert.ToString(Request["sc_sum"]);
        }
        if (!string.IsNullOrEmpty(Request["deviceId"]))
        {
            deviceId = Convert.ToString(Request["deviceId"]);
        }
        if (!string.IsNullOrEmpty(Request["user_id"]))
        {
            user_id = Convert.ToString(Request["user_id"]);
        }
        if (!string.IsNullOrEmpty(Request["zsId"]))
        {
            zsId = Request["zsId"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["kemuId"]))
        {
            kemuId = Request["kemuId"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["questionId"]))
        {
            questionId = Convert.ToInt32(Request["questionId"]);
        }
        if (!string.IsNullOrEmpty(Request["questionid_small"]))
        {
            if (StringHelper.IsNumeric(Request["questionid_small"]))
                questionid_small = Convert.ToInt32(Request["questionid_small"]);
        }
        if (!string.IsNullOrEmpty(Request["questionid_big"]))
        {
            if (StringHelper.IsNumeric(Request["questionid_big"]))
                questionid_big = Convert.ToInt32(Request["questionid_big"]);
        }
        if (!string.IsNullOrEmpty(Request["questionid_max"]))
        {
            if (StringHelper.IsNumeric(Request["questionid_max"]))
                questionid_max = Convert.ToInt32(Request["questionid_max"]);
        }
        if (!string.IsNullOrEmpty(Request["questionid_min"]))
        {
            if (StringHelper.IsNumeric(Request["questionid_min"]))
                questionid_min = Convert.ToInt32(Request["questionid_min"]);
        }
        if (!string.IsNullOrEmpty(Request["top"]))
        {
            top = Convert.ToInt32(Request["top"]);
        }
        if (!string.IsNullOrEmpty(Request["readType"]))
        {
            readType = Request["readType"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["page"]))
        {
            pageIndex = Convert.ToInt32(Request["page"].ToString());
        }
    }
    private Between getBetween(int questionId, out int pageSize1)
    {
        int index1 = (questionId / pageSize - 1) * pageSize + 1;
        //if (index1 < 0) index1 = 0;
        int index2 = (questionId / pageSize + 1) * pageSize + 1;

        if (index1 >= questionId - 1)
            index1 = (questionId / pageSize - 2) * pageSize + 1;

        if (index2 <= questionId + 1)
            index2 = (questionId / pageSize + 2) * pageSize + 1;

        pageSize1 = index2 - index1;
        return new Between(index1, index2);
    }
    protected string defaultSc999 = "999";

    protected static AFDictionary<string, string> dicCache1 = new AFDictionary<string, string>();

    protected string cacheUrl()
    {
        string url2 = StringHelper.CutOutString(this.Request.Url.ToString(), "source1=", "&");
        url2 = StringHelper.CutOutString(url2, "r=", "&");
        url2 = StringHelper.CutOutString(url2, "neice=", "&");
        url2 = StringHelper.CutOutString(url2, "type1=", "&");

        if (!string.IsNullOrEmpty(Request["openid"]))
            openid = Request["openid"].ToString();
        if (!string.IsNullOrEmpty(Convert.ToString(Session["openid"])))
            openid = Convert.ToString(Session["openid"]);

        if (!string.IsNullOrEmpty(openid) && openid != "null")
            url2 += openid;

        return url2;
    }
    public void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["kemuId"]))
        {
            kemuId = Convert.ToString(Request["kemuId"]);
            kemuName = BLL3.getClassZhongWen(kemuId.ToString());
        }
        else
        {
            kemuId = "100001";
            kemuName = BLL3.getClassZhongWen(kemuId.ToString());
        }
        //dicCache1.Clear();
        //string url1 = cacheUrl();
        //if (dicCache1.ContainsKey(url1))
        //{
            //Response.Write(dicCache1[url1]); return;
        //}
        setTitle();

        if (kemuId == "100051")
        {
            defaultSc999 = "310";
        }
        if (kemuId == "300002" || kemuId == "300001")
        {
            defaultSc999 = "195";
        }
        if (sc_sum == "194")
            sc_sum = defaultSc999;

        int count1 = -1;
        int pageSize1 = 0;

        RootObject r1 = new RootObject(MyDebugger.IsAttached); r1.isShuati = true;

        if (!string.IsNullOrEmpty(kemuName))
            r1.data.Add("kemuName", kemuName);

        string question_sum = "0";
        string question_sum0 = "0";
        string question_sum1 = "0";
        string question_sum2 = "0";
        string question_sum3 = "0";
        string question_sum4 = "0";
        string question_sum5 = "0";
        string question_sum6 = "0";
        string question_sum7 = "0";
        string question_sum_cuoti = "-1";
        string kaoshiTime = "2017-1-1";

        string questionid_max = "0";
        string questionid_max0 = "0";
        string questionid_max1 = "0";
        string questionid_max2 = "0";
        string questionid_max3 = "0";
        string questionid_max4 = "0";
        string questionid_max5 = "0";
        string questionid_max6 = "0";
        string questionid_max7 = "0";

        St_TTimuDaXue value1 = new St_TTimuDaXue();
        St_TTimuDaXue cond1 = new St_TTimuDaXue();

        if (!string.IsNullOrEmpty(kemuId))
        {
            cond1.KemuId = Convert.ToInt32(kemuId);
        }
        if (!string.IsNullOrEmpty(sc))
        {
            cond1.Sc = sc;
        }
        else if (!string.IsNullOrEmpty(sc_sum))
        {
            cond1.Sc = sc_sum;
        }
        else
        {
            sc = defaultSc999;
            cond1.Sc = sc;
        }

        string sc_sum0 = cond1.Sc;
        string sc_sum1 = cond1.Sc;
        string sc_sum2 = cond1.Sc;
        string sc_sum3 = cond1.Sc;
        string sc_sum4 = cond1.Sc;
        string sc_sum5 = cond1.Sc;
        string sc_sum6 = cond1.Sc;
        string sc_sum7 = cond1.Sc;

        St_TTimuDaXueErrorInfo val3 = new St_TTimuDaXueErrorInfo();
        St_TTimuDaXueErrorInfo cond3 = new St_TTimuDaXueErrorInfo();
        //if (!string.IsNullOrEmpty(zsId))
        //    cond3.zsId = zsId;
        if (!string.IsNullOrEmpty(openid) && !string.IsNullOrEmpty(kemuId))
        {
            question_sum_cuoti = "0";
            cond3.OpenId = openid;
            cond3.KemuId = kemuId;

            St_TTimuDaXueErrorInfo data3 = BLLTable<St_TTimuDaXueErrorInfo>.GetRowData(cond3);
            if (data3 != null && data3.IsNotNull())
            {
                question_sum_cuoti = data3.ErrorSum.ToString();
            }
        }

        "".ToString();
        r1.data.Add("question_sum", question_sum);
        r1.data.Add("question_sum0", question_sum0);
        r1.data.Add("question_sum1", question_sum1);
        r1.data.Add("question_sum2", question_sum2);
        r1.data.Add("question_sum3", question_sum3);
        r1.data.Add("question_sum4", question_sum4);
        r1.data.Add("question_sum5", question_sum5);
        r1.data.Add("question_sum6", question_sum6);
        r1.data.Add("question_sum7", question_sum7);

        r1.data.Add("question_sum_cuoti", question_sum_cuoti);
        r1.data.Add("kaoshiTime", kaoshiTime);

        r1.data.Add("questionid_max", questionid_max);
        r1.data.Add("questionid_max1", questionid_max0);
        r1.data.Add("questionid_max2", questionid_max1);
        r1.data.Add("questionid_max2", questionid_max2);
        r1.data.Add("questionid_max3", questionid_max3);
        r1.data.Add("questionid_max4", questionid_max4);
        r1.data.Add("questionid_max5", questionid_max5);
        r1.data.Add("questionid_max6", questionid_max6);
        r1.data.Add("questionid_max7", questionid_max7);

        r1.data.Add("sc_sum", sc);
        r1.data.Add("sc_sum0", sc_sum0);
        r1.data.Add("sc_sum1", sc_sum1);
        r1.data.Add("sc_sum2", sc_sum2);
        r1.data.Add("sc_sum3", sc_sum3);
        r1.data.Add("sc_sum4", sc_sum4);
        r1.data.Add("sc_sum5", sc_sum5);
        r1.data.Add("sc_sum6", sc_sum6);
        r1.data.Add("sc_sum7", sc_sum7);

        string tu2wei = BLL1.getFile(sc);
        r1.data.Add("tu2wei", tu2wei);

        //取得本页广告
        TggInfo ggcond1 = new TggInfo();
        ggcond1._GgSourceUrl = "list.html";

        //List<TggInfo> gglist = BLLTable<TggInfo>.Select(new TggInfo(), ggcond1);
        //r1.Add(gglist);

        if (!string.IsNullOrEmpty(openid) && openid != "null")
            r1.data.Add("openid", openid);

        string json1 = r1.ToJson();
        //try
        //{
        //    //if (!dicCache1.ContainsKey(url1))
        //    dicCache1.Add(url1, json1);
        //}
        //catch (Exception e1)
        //{
        //    Cs.Info(e1.ToString());
        //}
        Response.Write(json1);
        return;

        //JsonSerializerSettings settings = new JsonSerializerSettings();
        //settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        //string result = JsonConvert.SerializeObject(timu1List, Formatting.Indented, settings);//需要注意的是，如果返回的是一个集合，那么还要在它的上面再封装一个类。否则客户端收到会出错的。
    }
}
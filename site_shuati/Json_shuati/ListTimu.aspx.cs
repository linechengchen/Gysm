using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using Newtonsoft.Json;
using RedisService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wap_main_query : BasePageShuati
{
    public int pageSize = 50;
    public int top = 100;

    protected string order = "";
    protected string neice = "";
    protected string sc = "";
    protected string source1 = "";
    protected string sc_sum = "";
    public string kemuName = "";
    public string kemuId = "";
    public string paperId = "";
    public string zsId = "";
    public int questionId = -1;
    public string readType = "1";
    public int pageIndex = 1;
    public string optionType = "";
    public string openid = "";
    public string user_id = "";
    public string deviceId = "";
    string num = "1";
    public string type = "sequence";//顺序出题
    public int id = 0;
    public int errorid = 0;
    public int questionid_max = -1;
    public int questionid_min = 99999;
    public int questionid_big = -1;
    public int questionid_small = -1;
    public string cutiType = "";

    private void setParams()
    {
        if (!string.IsNullOrEmpty(Request["order"]))
        {
            order = Convert.ToString(Request["order"]);
        }
        if (!string.IsNullOrEmpty(Request["errorid"]))
        {
            errorid = Convert.ToInt32(Request["errorid"]);
        }
        if (!string.IsNullOrEmpty(Request["id"]))
        {
            id = Convert.ToInt32(Request["id"]);
        }
        if (!string.IsNullOrEmpty(Request["leimu"]))
        {
            optionType = Convert.ToString(Request["leimu"]);
        }
        if (!string.IsNullOrEmpty(Request["optionType"]))
        {
            optionType = Convert.ToString(Request["optionType"]);
        }
        if (!string.IsNullOrEmpty(Request["neice"]))
        {
            pageSize = 3;
            top = 6;
            neice = Convert.ToString(Request["neice"]);
        }
        if (!string.IsNullOrEmpty(Request["sc_sum"]))
        {
            sc_sum = Convert.ToString(Request["sc_sum"]);
        }
        if (!string.IsNullOrEmpty(Request["source1"]))
        {
            source1 = Convert.ToString(Request["source1"]);
        }
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        if (!string.IsNullOrEmpty(Request["deviceId"]))
        {
            deviceId = Convert.ToString(Request["deviceId"]);
        }
        if (!string.IsNullOrEmpty(Request["user_id"]))
        {
            user_id = Convert.ToString(Request["user_id"]);
        }
        if (!string.IsNullOrEmpty(Request["openid"]))
        {
            openid = Convert.ToString(Request["openid"]);
        }
        if (!string.IsNullOrEmpty(Request["zsId"]))
        {
            zsId = Request["zsId"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["paperId"]))
        {
            paperId = Request["paperId"].ToString();
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
        if (!string.IsNullOrEmpty(Request["cutiType"]))
        {
            cutiType = Request["cutiType"].ToString();
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

    protected static AFDictionary<string, string> dicCache1 = new AFDictionary<string, string>();

    protected string cacheUrl()
    {
        string url2 = StringHelper.CutOutString(this.Request.Url.ToString(), "source1=", "&");
        url2 = StringHelper.CutOutString(url2, "r=", "&");
        //url2 = StringHelper.CutOutString(url2, "question_sum=", "&");
        //url2 = StringHelper.CutOutString(url2, "neice=", "&");
        url2 = StringHelper.CutOutString(url2, "type1=", "&");
        url2 = StringHelper.CutOutString(url2, "openid=", "&");

        //if (!string.IsNullOrEmpty(Request["openid"]))
        //    openid = Request["openid"].ToString();
        //if (!string.IsNullOrEmpty(Convert.ToString(Session["openid"])))
        //    openid = Convert.ToString(Session["openid"]);

        //if (!string.IsNullOrEmpty(openid) && openid != "null")
        //    url2 += openid;

        return url2;
    }
    protected string defaultSc999 = "999";

    protected void Page_Load(object sender, EventArgs e)
    {
        setParams();
        string url1 = cacheUrl();
        string pageCacheKey = "ListTimu.aspx";
        if (neice == "" && Directory.Exists(@"D:\网站系统\刷题日志\刷题神器\题目访问日志\"))
            File.AppendAllText(@"D:\网站系统\刷题日志\刷题神器\题目访问日志\" + source1 + ".txt", DateTime.Now.ToString() + this.Request.Url.ToString().Replace("http://stbd.aibangxs.com/site_shuati/json_shuati/ListTimu.aspx?", "") + "\r\n");

        //MyRedis.Factory().Hash_Remove(pageCacheKey);
        if (MyRedis.Factory().Hash_Exist<string>(pageCacheKey, url1))
        {
            string js1 = MyRedis.Factory().Hash_Get<string>(pageCacheKey, url1); if (!string.IsNullOrEmpty(js1)) { Response.Write(js1.Replace("{", "{\"cache\":\"1\",")); return; }
        }
        if (!string.IsNullOrEmpty(kemuId))
        {
            kemuName = BLL3.getClassZhongWen(kemuId.ToString());
        }

        RootObject r1 = new RootObject(MyDebugger.IsAttached); r1.isShuati = true;

        if (!string.IsNullOrEmpty(Convert.ToString(Session["openid"])))
            r1.data.Add("openid", Convert.ToString(Session["openid"]));

        if (!string.IsNullOrEmpty(kemuName))
            r1.data.Add("kemuName", kemuName);

        int count1 = -1;
        int pageSize1 = 0;
        if (string.IsNullOrEmpty(cutiType))
        {
            cutiType = "sequence";
        }
        if (cutiType == "random")
            pageSize = 200;

        int tiCount = 0;
        //获取错题
        if (cutiType == "cuoti")
        {
            #region 错题的处理
            if (!string.IsNullOrEmpty(openid) && !string.IsNullOrEmpty(kemuId))
            {
                //    VTimuDaXueErrorInfo val1 = new VTimuDaXueErrorInfo();
                //    val1.Top(1);
                //    //val1.OrderBy(VTimuDaXueErrorInfo.Attribute.AutoId, Order.Asc);
                //    VTimuDaXueErrorInfo cond1 = new VTimuDaXueErrorInfo();
                //    cond1.OrderBy(VTimuDaXueErrorInfo.Attribute.AutoId, Order.Desc);
                //    cond1.OpenId = openid;
                //    if (!string.IsNullOrEmpty(user_id))
                //        cond1.User_id = user_id;
                //    if (!string.IsNullOrEmpty(deviceId))
                //        cond1.DeviceId = deviceId;
                //    if (!string.IsNullOrEmpty(kemuId))
                //        cond1.KemuId = kemuId;

                //    if (!string.IsNullOrEmpty(sc))
                //    {
                //        cond1.Sc = sc;
                //    }
                //    else if (!string.IsNullOrEmpty(sc_sum))
                //    {
                //        cond1.Sc = sc_sum;
                //    }
                //    else
                //    {
                //        sc = defaultSc999;
                //        cond1.Sc = sc;
                //    }
                //    //if (questionId != -1)
                //    //{
                //    //    Between b1 = getBetween(questionId);
                //    //    cond1.Where(VTimuDaXueErrorInfo.Attribute.QuestionId, b1);
                //    //}
                //    count1 = 1;
                //    List<VTimuDaXueErrorInfo> timuList = BLLTable<VTimuDaXueErrorInfo>.Select(val1, cond1);

                //    root1.Add(timuList, "St_TTimuDaXue");
                //}
            }
            #endregion 错题的处理
        }
        else if (!string.IsNullOrEmpty(zsId))
        {
            BLL233 bll3 = new BLL233();
            St_TiMu233 val1 = new St_TiMu233();
            if (order == "1")
                val1.af_PageBy(St_TiMu233.Attribute.ExamId, Order.Desc);
            else
                val1.af_PageBy(St_TiMu233.Attribute.ExamId, Order.Asc);

            St_TTimuDaXue daxue1 = new St_TTimuDaXue();
            //试卷名
            if (!string.IsNullOrEmpty(paperId))
                daxue1._Sourceid = paperId;
            if (!string.IsNullOrEmpty(kemuId))
                daxue1.KemuId = Convert.ToInt32(kemuId);
            if (!string.IsNullOrEmpty(optionType))
                daxue1.OptionType = optionType;

            St_TiMu233 cond1 = bll3.GetTiMu233Cond(daxue1);
            //cond1.ExamType.ToString();

            //if (cond1.OptionType == "0" || cond1.OptionType == "1" || cond1.OptionType == "4")
            //    cond1.Where(" OptionStr!='' ");

            if (questionid_max <= 0)
            {
                string m1 = BLLTable<St_TiMu233>.Max(St_TiMu233.Attribute.ExamId, cond1);
                if (!string.IsNullOrEmpty(m1))
                    questionid_max = Convert.ToInt32(m1);
            }
            r1.data.Add("questionid_max", questionid_max.ToString());
            if (questionid_min >= 10)
            {
                string m2 = BLLTable<St_TiMu233>.Min(St_TiMu233.Attribute.ExamId, cond1);
                if (!string.IsNullOrEmpty(m2))
                    questionid_min = Convert.ToInt32(m2);
            }
            r1.data.Add("questionid_min", questionid_min.ToString());

            Between b1 = null, b2 = null, b3 = null;
            if (questionId != -1)
            {
                b1 = getBetween(questionId, out pageSize1);
                if (order == "1")
                    cond1.Where("ExamId<=" + b1.MaxData);
                else
                    cond1.Where("ExamId>=" + b1.MinData);
                //top = pageSize1;
            }
            if (questionid_big != -1)
            {
                if (order == "1")
                    cond1.Where("ExamId < " + questionid_big);
                else
                    cond1.Where("ExamId > " + questionid_big);
            }
            if (questionid_small != -1)
            {
                if (order == "1")
                    cond1.Where("ExamId > " + questionid_small);
                else
                    cond1.Where("ExamId < " + questionid_small);
            }
            List<St_TiMu233> timu1List2 = BLLTable<St_TiMu233>.SelectByPage(val1, cond1, top, pageIndex, ref count1);
            List<St_TTimuDaXue> timu1List = new List<St_TTimuDaXue>();
            foreach (St_TiMu233 t233 in timu1List2)
            {
                timu1List.Add(bll3.GetTTimuDaXue(t233));
            }
            tiCount = timu1List.Count;
            r1.Add(timu1List, "", pageIndex, count1);
        }
        else
        {
            //pageIndex
            St_TTimuDaXue val1 = new St_TTimuDaXue(true);
            val1.SetInitialized(St_TTimuDaXue.Attribute.OptionA, false);
            val1.SetInitialized(St_TTimuDaXue.Attribute.OptionB, false);
            val1.SetInitialized(St_TTimuDaXue.Attribute.OptionC, false);
            val1.SetInitialized(St_TTimuDaXue.Attribute.OptionD, false);
            val1.SetInitialized(St_TTimuDaXue.Attribute.OptionE, false);
            val1.SetInitialized(St_TTimuDaXue.Attribute.OptionF, false);
            val1.SetInitialized(St_TTimuDaXue.Attribute.OptionG, false);
            val1.SetInitialized(St_TTimuDaXue.Attribute.OptionH, false);

            if (order == "1")
                val1.af_PageBy(St_TTimuDaXue.Attribute.AutoId, Order.Desc);
            else
                val1.af_PageBy(St_TTimuDaXue.Attribute.AutoId, Order.Asc);

            //val1.OrderBy(St_TTimuDaXue.Attribute.AutoId, Order.Asc);
            St_TTimuDaXue cond1 = new St_TTimuDaXue();
            if (order == "1")
                cond1.af_PageBy(St_TTimuDaXue.Attribute.AutoId, Order.Desc);
            else
                cond1.af_PageBy(St_TTimuDaXue.Attribute.AutoId, Order.Asc);

            if (!string.IsNullOrEmpty(kemuId))
                cond1.KemuId = Convert.ToInt32(kemuId);
            if (!string.IsNullOrEmpty(sc))
            {
                cond1.Sc = sc;
            }
            if (!string.IsNullOrEmpty(sc_sum))
            {
                cond1.Sc = sc_sum;
            }
            else
            {
                cond1.Sc = sc;
            }
            if (!string.IsNullOrEmpty(optionType))
            {
                cond1.OptionType = optionType;
            }

            if (cond1.Sc == "999")
                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);

            if (cond1.OptionType == "0" || cond1.OptionType == "1" || cond1.OptionType == "4")
                cond1.Where(" OptionStr!='' ");

            if (questionid_max <= 0)
            {
                string m1 = BLLTable<St_TTimuDaXue>.Max(St_TTimuDaXue.Attribute.QuestionId, cond1);
                if (!string.IsNullOrEmpty(m1))
                    questionid_max = Convert.ToInt32(m1);
            }
            r1.data.Add("questionid_max", questionid_max.ToString());
            if (questionid_min >= 10)
            {
                string m2 = BLLTable<St_TTimuDaXue>.Min(St_TTimuDaXue.Attribute.QuestionId, cond1);
                if (!string.IsNullOrEmpty(m2))
                    questionid_min = Convert.ToInt32(m2);
            }
            r1.data.Add("questionid_min", questionid_min.ToString());

            Between b1 = null, b2 = null, b3 = null;
            if (questionId != -1)
            {
                b1 = getBetween(questionId, out pageSize1);
                if (order == "1")
                    cond1.Where("QuestionId <= " + b1.MaxData);
                else
                    cond1.Where("QuestionId >= " + b1.MinData);
                //top = pageSize1;
            }
            if (questionid_big != -1)
            {
                if (order == "1")
                    cond1.Where("QuestionId < " + questionid_big);
                else
                    cond1.Where("QuestionId > " + questionid_big);
                //b2 = getBetween(questionid_big + pageSize, out pageSize1);
                //b2.MinData = questionid_big;
                //cond1.Where(St_TTimuDaXue.Attribute.QuestionId, b2);
                //top = pageSize1;
            }
            if (questionid_small != -1)
            {
                if (order == "1")
                    cond1.Where("QuestionId > " + questionid_small);
                else
                    cond1.Where("QuestionId < " + questionid_small);
                //b3 = getBetween(questionid_small - pageSize, out pageSize1);
                //b3.MaxData = questionid_small;
                //if (b2 != null)
                //    cond1.Where_OR(St_TTimuDaXue.Attribute.QuestionId, b3);
                //top = pageSize1;
            }
            // top * 2
            List<St_TTimuDaXue> timu1List = BLLTable<St_TTimuDaXue>.SelectByPage(val1, cond1, top, pageIndex, ref count1);
            if (timu1List.Count > 0)
            {
                timu1List[0].Question.ToString();
                timu1List[timu1List.Count - 1].Question.ToString();
            }
            if (!string.IsNullOrEmpty(neice))
            {
                if (BLLTable<St_TTimuDaXue>.SQL_Test.Count > 0)
                {
                    string sql1 = BLLTable<St_TTimuDaXue>.SQL_Test[0];
                    sql1 = sql1.Replace("@" + cond1.TableName() + "_Sc", "'" + cond1.Sc + "'");
                    sql1 = sql1.Replace("@" + cond1.TableName() + "_KemuId", "'" + cond1.KemuId + "'");
                    r1.data.Add("sql1", sql1);
                    r1.data.Add("sc11", cond1.Sc);
                    r1.data.Add("kemu11", cond1.KemuId);
                    //foreach (St_TTimuDaXue t1 in timu1List)
                    //{
                    //    if (string.IsNullOrEmpty(t1.OptionStr))
                    //    {
                    //    }
                    //}
                }
            }
            tiCount = timu1List.Count;
            r1.Add(timu1List, "", pageIndex, count1);
        }
        St_TArticleComments TArticleComments1 = new St_TArticleComments();
        TArticleComments1.ArticleId = "1";
        TArticleComments1.User_id = "1";
        TArticleComments1._Content = "这道题目我也做错了^_^";
        //root1.Add(TArticleComments1);

        //取得本页广告
        TggInfo ggcond1 = new TggInfo();
        ggcond1._GgSourceUrl = "app.html";

        //List<TggInfo> gglist = BLLTable<TggInfo>.Select(new TggInfo(), ggcond1);
        //r1.Add(gglist);

        bool isJiami = ("1" == Request["jiami"]) || !("1" == Request["neice"] || Request.Url.ToString().Contains("https://localhost"));
        string json1 = r1.ToJson(isJiami);
        try
        {
            if (tiCount > 0 && !string.IsNullOrEmpty(json1))
            {
                bool ret1 = MyRedis.Factory().Hash_Set<string>(pageCacheKey, url1, json1);
            }
        }
        catch (Exception e1)
        {
            Cs.Info(e1.ToString());
        }
        Response.Write(json1);

        //JsonSerializerSettings settings = new JsonSerializerSettings();
        //settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        //string result = JsonConvert.SerializeObject(timu1List, Formatting.Indented, settings);//需要注意的是，如果返回的是一个集合，那么还要在它的上面再封装一个类。否则客户端收到会出错的。
    }
}
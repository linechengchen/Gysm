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

    protected string neice = "";
    protected string sc = "";
    protected string sc_sum = "";
    public string kemuName = "";
    public string kemuId = "";
    public string paperId = "";
    public string zsId = "";
    public int questionId = -1;
    public int commentId = -1;
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
    public int commentid_max = -1;
    public int commentid_min = 9999;
    public int commentid_big = -1;
    public int commentid_small = -1;
    public string cutiType = "";

    private void setTitle()
    {
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
            neice = Convert.ToString(Request["neice"]);
        }
        if (!string.IsNullOrEmpty(Request["sc_sum"]))
        {
            sc_sum = Convert.ToString(Request["sc_sum"]);
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
        if (!string.IsNullOrEmpty(Request["commentId"]))
        {
            commentId = Convert.ToInt32(Request["commentId"]);
        }
        if (!string.IsNullOrEmpty(Request["commentid_small"]))
        {
            if (StringHelper.IsNumeric(Request["commentid_small"]))
                commentid_small = Convert.ToInt32(Request["commentid_small"]);
        }
        if (!string.IsNullOrEmpty(Request["commentid_big"]))
        {
            if (StringHelper.IsNumeric(Request["commentid_big"]))
                commentid_big = Convert.ToInt32(Request["commentid_big"]);
        }
        if (!string.IsNullOrEmpty(Request["commentid_max"]))
        {
            if (StringHelper.IsNumeric(Request["commentid_max"]))
                commentid_max = Convert.ToInt32(Request["commentid_max"]);
        }
        if (!string.IsNullOrEmpty(Request["commentid_min"]))
        {
            if (StringHelper.IsNumeric(Request["commentid_min"]))
                commentid_min = Convert.ToInt32(Request["commentid_min"]);
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
    private Between getBetween(int commentId, out int pageSize1)
    {
        int index1 = (commentId / pageSize - 1) * pageSize + 1;
        //if (index1 < 0) index1 = 0;
        int index2 = (commentId / pageSize + 1) * pageSize + 1;

        if (index1 >= commentId - 1)
            index1 = (commentId / pageSize - 2) * pageSize + 1;

        if (index2 <= commentId + 1)
            index2 = (commentId / pageSize + 2) * pageSize + 1;

        pageSize1 = index2 - index1;
        return new Between(index1, index2);
    }

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
    protected string defaultSc194 = "194";

    protected void Page_Load(object sender, EventArgs e)
    {
        string url1 = cacheUrl();
        string pageCacheKey = "ListComments.aspx";
        //MyRedis.Factory().Hash_Remove(pageCacheKey);
        if (MyRedis.Factory().Hash_Exist<string>(pageCacheKey, url1))
        {
            string js1 = MyRedis.Factory().Hash_Get<string>(pageCacheKey, url1); if (!string.IsNullOrEmpty(js1)) { Response.Write(js1.Replace("{", "{\"cache\":\"1\",")); return; }
        }
        setTitle();
        if (!string.IsNullOrEmpty(Request["kemuId"]))
        {
            kemuId = Convert.ToString(Request["kemuId"]);
            kemuName = BLL3.getClassZhongWen(kemuId.ToString());
        }

        //MyRedis redis = new MyRedis();
        //redis.Get
        //List<St_TArticleComments> timu1List = BLL1.getList(sc, kemuId, leimu, seq, readType, top, ref dic1);

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

        //if (cutiType == "cuoti")
        {
            if (questionId != -1)
            {
                St_TArticleComments val1 = new St_TArticleComments(true);
                //val1.SetInitialized(St_TArticleComments.Attribute.OptionA, false);
                //val1.SetInitialized(St_TArticleComments.Attribute.OptionB, false);
                //val1.SetInitialized(St_TArticleComments.Attribute.OptionC, false);
                //val1.SetInitialized(St_TArticleComments.Attribute.OptionD, false);
                //val1.SetInitialized(St_TArticleComments.Attribute.OptionE, false);
                //val1.SetInitialized(St_TArticleComments.Attribute.OptionF, false);
                //val1.SetInitialized(St_TArticleComments.Attribute.OptionG, false);
                //val1.SetInitialized(St_TArticleComments.Attribute.OptionH, false);

                //val1.OrderBy(St_TArticleComments.Attribute.AutoId, Order.Asc);
                St_TArticleComments cond1 = new St_TArticleComments();
                cond1.OrderBy(St_TArticleComments.Attribute.ID, Order.Asc);

                if (questionId != -1)//!string.IsNullOrEmpty(questionId))
                    cond1.ArticleId = questionId.ToString();
                //if (!string.IsNullOrEmpty(sc))
                //{
                //    cond1.Sc = sc;
                //}
                //if (!string.IsNullOrEmpty(sc_sum))
                //{
                //    cond1.Sc = sc_sum;
                //}
                //else
                //{
                //    sc = "194";
                //    cond1.Sc = sc;
                //}
                //if (!string.IsNullOrEmpty(optionType))
                //{
                //    cond1.OptionType = optionType;
                //}

                //if (cond1.OptionType == "0" || cond1.OptionType == "1" || cond1.OptionType == "4")
                //    cond1.Where(" OptionStr!='' ");

                if (commentid_max <= 0)
                {
                    string m1 = BLLTable<St_TArticleComments>.Max(St_TArticleComments.Attribute.ID, cond1);
                    if (!string.IsNullOrEmpty(m1))
                        commentid_max = Convert.ToInt32(m1);
                }
                r1.data.Add("commentid_max", commentid_max.ToString());
                if (commentid_min >= 10)
                {
                    string m2 = BLLTable<St_TArticleComments>.Min(St_TArticleComments.Attribute.ID, cond1);
                    if (!string.IsNullOrEmpty(m2))
                        commentid_min = Convert.ToInt32(m2);
                }
                r1.data.Add("commentid_min", commentid_min.ToString());

                Between b1 = null, b2 = null, b3 = null;
                if (commentId != -1)
                {
                    b1 = getBetween(commentId, out pageSize1);
                    cond1.Where("id>=" + b1.MinData);
                    //top = pageSize1;
                }
                if (commentid_big != -1)
                {
                    cond1.Where("id > " + commentid_big);
                    //b2 = getBetween(commentid_big + pageSize, out pageSize1);
                    //b2.MinData = commentid_big;
                    //cond1.Where(St_TArticleComments.Attribute.commentId, b2);
                    //top = pageSize1;
                }
                if (commentid_small != -1)
                {
                    cond1.Where("id < " + commentid_small);
                    //b3 = getBetween(commentid_small - pageSize, out pageSize1);
                    //b3.MaxData = commentid_small;
                    //if (b2 != null)
                    //    cond1.Where_OR(St_TArticleComments.Attribute.commentId, b3);
                    //top = pageSize1;
                }
                // top * 2
                List<St_TArticleComments> timu1List = BLLTable<St_TArticleComments>.SelectByPage(val1, cond1, top, pageIndex, ref count1);
                if (!string.IsNullOrEmpty(neice))
                {
                    if (BLLTable<St_TArticleComments>.SQL_Test.Count > 0)
                    {
                        string sql1 = BLLTable<St_TArticleComments>.SQL_Test[0];
                        //sql1 = sql1.Replace("@" + cond1.TableName() + "_Sc", "'" + cond1.Sc + "'");
                        //sql1 = sql1.Replace("@" + cond1.TableName() + "_KemuId", "'" + cond1.KemuId + "'");
                        //root1.Add("sql1", sql1);
                        //root1.Add("sc11", cond1.Sc);
                        //root1.Add("kemu11", cond1.KemuId);

                        //foreach (St_TArticleComments t1 in timu1List)
                        //{
                        //    if (string.IsNullOrEmpty(t1.OptionStr))
                        //    {
                        //    }
                        //}
                    }
                }
                r1.Add(timu1List, "", pageIndex, count1);
            }
        }

        St_TArticleComments TArticleComments1 = new St_TArticleComments();
        TArticleComments1._ID = 2;
        TArticleComments1.ArticleId = questionId.ToString();
        TArticleComments1.User_id = "1";
        TArticleComments1._Content = "这道题目我也做错了^_^";
        TArticleComments1.Voice = "http://t1.noyishu.org/alle_voice/2015/08/24/14/51/c66563a5-4c04-4c9c-8992-f6e61d8db211.arm";
        TArticleComments1._CommentCount = "1";
        TArticleComments1._CommentPId = "1";
        TArticleComments1._ContentHtml = "<font color='red' >这道题目我也做错了@@@</font>";
        TArticleComments1._CreateDate = DateTime.Now.ToShortTimeString();
        TArticleComments1._Images = "http://avatar.csdn.net/3/8/3/2_disheng2014.jpg";

        //取得本页广告
        TggInfo ggcond1 = new TggInfo();
        ggcond1._GgSourceUrl = "app.html";

        List<St_TArticleComments> listComment1 = new List<St_TArticleComments>();
        listComment1.Add(TArticleComments1);
        listComment1.Add(TArticleComments1);
        listComment1.Add(TArticleComments1);
        listComment1.Add(TArticleComments1);

        r1.Add(listComment1);
        //List<TggInfo> gglist = BLLTable<TggInfo>.Select(new TggInfo(), ggcond1);
        //r1.Add(gglist);

        string json1 = r1.ToJson();
        try
        {
            if (listComment1.Count > 0 && !string.IsNullOrEmpty(json1))
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

        //JsonSerializerSettings settings = new JsonSerializerSettings();
        //settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        //string result = JsonConvert.SerializeObject(timu1List, Formatting.Indented, settings);//需要注意的是，如果返回的是一个集合，那么还要在它的上面再封装一个类。否则客户端收到会出错的。
    }
}
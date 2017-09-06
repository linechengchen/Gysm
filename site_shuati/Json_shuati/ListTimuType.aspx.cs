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

public partial class wap_main_query : BasePageShuati
{
    public int pageSize = 10;

    protected string sc = "";
    protected string sc_real = "";
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

    private void setParams()
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
        if (!string.IsNullOrEmpty(Request["sc"]) && StringHelper.IsNumeric(Request["sc"]))
        {
            sc = Request["sc"];
            sc = ScHelper.getSc(this);
            if (sc.Length == 4)
                sc = sc.Substring(0, 3);
        }
        else
            sc = "999";
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
    protected string defaultSc999 = "194";

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
    public void Page_Load(object sender, EventArgs e)
    {
        setParams();
        //Session["openid"] = "";
        string url1 = cacheUrl();
        string pageCacheKey = "ListTimuType";
        //MyRedis.Factory().Hash_Remove(pageCacheKey);
        if (MyRedis.Factory().Hash_Exist<string>(pageCacheKey, sc + openid + kemuId))
        {
            if (!string.IsNullOrEmpty(sc) && !string.IsNullOrEmpty(openid) && !string.IsNullOrEmpty(kemuId))
            {
                string js1 = MyRedis.Factory().Hash_Get<string>(pageCacheKey, sc + openid + kemuId); if (!string.IsNullOrEmpty(js1)) { Response.Write(js1.Replace("{", "{\"cache\":\"1\",")); return; }
            }
        }
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

        int count1 = -1;
        int pageSize1 = 0;

        RootObject r1 = new RootObject(MyDebugger.IsAttached); r1.isShuati = true;

        if (!string.IsNullOrEmpty(kemuName))
            r1.data.Add("kemuName", kemuName);

        int question_sum = 0;
        int question_sum0 = 0;
        int question_sum1 = 0;
        int question_sum2 = 0;
        int question_sum3 = 0;
        int question_sum4 = 0;
        int question_sum5 = 0;
        int question_sum6 = 0;
        int question_sum7 = 0;
        int question_sum8 = 0;
        int question_sum_cuoti = -1;
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
        string questionid_max8 = "0";

        St_TTimuDaXue value1 = new St_TTimuDaXue();
        St_TTimuDaXue cond1 = new St_TTimuDaXue();

        if (!string.IsNullOrEmpty(kemuId))
        {
            cond1.KemuId = Convert.ToInt32(kemuId);
        }

        if (sc_sum == "194")
            sc_sum = defaultSc999;

        if (!string.IsNullOrEmpty(tmp_sc_sum))
        {
            cond1.Sc = tmp_sc_sum;
        }
        else if (!string.IsNullOrEmpty(sc) && sc != "999" && sc != "undefined")
        {
            cond1.Sc = sc;
        }
        else if (!string.IsNullOrEmpty(sc_sum))
        {
            cond1.Sc = sc_sum;
        }
        else
        {
            cond1.Sc = sc;
        }
        if (cond1.Sc == "999")
            cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);

        string sc_sum0 = cond1.Sc;
        string sc_sum1 = cond1.Sc;
        string sc_sum2 = cond1.Sc;
        string sc_sum3 = cond1.Sc;
        string sc_sum4 = cond1.Sc;
        string sc_sum5 = cond1.Sc;
        string sc_sum6 = cond1.Sc;
        string sc_sum7 = cond1.Sc;
        string sc_sum8 = cond1.Sc;

        #region 错题信息
        St_TTimuDaXueErrorInfo val3 = new St_TTimuDaXueErrorInfo();
        St_TTimuDaXueErrorInfo cond3 = new St_TTimuDaXueErrorInfo();
        //if (!string.IsNullOrEmpty(zsId))
        //    cond3.zsId = zsId;
        if (!string.IsNullOrEmpty(openid) && !string.IsNullOrEmpty(kemuId))
        {
            question_sum_cuoti = 0;
            St_TTimuDaXueErrorInfo data3 = null;
            string tableCacheKey1 = "St_TTimuDaXueErrorInfo";
            if (!string.IsNullOrEmpty(openid) && !string.IsNullOrEmpty(kemuId))
            {
                data3 = MyRedis.Factory().Hash_GetTable<St_TTimuDaXueErrorInfo>(tableCacheKey1, openid + kemuId);
            }
            if (data3 == null || data3.IsNull())
            {
                cond3.OpenId = openid;
                cond3.KemuId = kemuId;

                data3 = BLLTable<St_TTimuDaXueErrorInfo>.GetRowData(cond3);
                if (data3 != null && data3.IsNotNull())
                {
                    question_sum_cuoti = data3.ErrorSum;
                    bool ret1 = MyRedis.Factory().Hash_SetTable<St_TTimuDaXueErrorInfo>(tableCacheKey1, openid + kemuId, data3);
                }
            }
        }
        #endregion 错题信息

        #region 证书信息
        //第一步是否需要重新统计
        bool isNeedDoSum = true;
        if (!string.IsNullOrEmpty(zsId))//第一步证书表
        {
            //更新科目表 总题数
            St_kemuInfo_zs cond5 = new St_kemuInfo_zs();
            cond5.KemuId = Convert.ToInt32(kemuId);
            St_kemuInfo_zs ret5 = BLLTable<St_kemuInfo_zs>.GetRowData(St_kemuInfo_zs.Attribute.KemuId, cond5.KemuId);
            if (ret5 != null && ret5.IsNotNull())
            {
                DateTime dt1 = ret5.Question_sum_time;
                if (DateTime.Now.Subtract(dt1).TotalHours < 24)
                {
                    if (ret5.Question_sum >= 0)
                    {
                        isNeedDoSum = false;
                        question_sum = ret5.Question_sum;
                        question_sum0 = ret5.Question_sum0;
                        question_sum1 = ret5.Question_sum1;
                        question_sum2 = ret5.Question_sum2;
                        question_sum3 = ret5.Question_sum3;
                        question_sum4 = ret5.Question_sum4;
                        question_sum5 = ret5.Question_sum5;
                        question_sum6 = ret5.Question_sum6;
                        question_sum7 = ret5.Question_sum7;
                        question_sum8 = ret5.Question_sum8;
                        r1.AddTop("isNeedDoSum", "无需重新统计");
                    }
                }
            }
            if (isNeedDoSum)
            {
                BLL233 bll233 = new BLL233();
                St_TiMu233 cond233 = bll233.GetTiMu233Cond(cond1);
                question_sum = BLLTable<St_TiMu233>.Count(cond233);
                cond233.ExamType = bll233.get233OptionType("0");
                question_sum0 = BLLTable<St_TiMu233>.Count(cond233);
                cond233.ExamType = bll233.get233OptionType("1");
                question_sum1 = BLLTable<St_TiMu233>.Count(cond233);
                cond233.ExamType = bll233.get233OptionType("2");
                question_sum2 = BLLTable<St_TiMu233>.Count(cond233);
                cond233.ExamType = bll233.get233OptionType("3");
                question_sum3 = BLLTable<St_TiMu233>.Count(cond233);
                cond233.ExamType = bll233.get233OptionType("4");
                question_sum4 = BLLTable<St_TiMu233>.Count(cond233);

                #region 证书
                //更新科目表 总题数
                St_kemuInfo_zs cond55 = new St_kemuInfo_zs();
                cond55.KemuId = Convert.ToInt32(kemuId);
                cond55.Question_sum = question_sum;
                cond55.Question_sum0 = question_sum0;
                cond55.Question_sum1 = question_sum1;
                cond55.Question_sum2 = question_sum2;
                cond55.Question_sum3 = question_sum3;
                cond55.Question_sum4 = question_sum4;
                cond55.Question_sum5 = question_sum5;
                cond55.Question_sum6 = question_sum6;
                cond55.Question_sum7 = question_sum7;
                cond55.Question_sum8 = question_sum8;
                cond55.Question_sum_time = DateTime.Now;
                int ret55 = BLLTable<St_kemuInfo_zs>.Update(cond55, St_kemuInfo_zs.Attribute.KemuId);
                if (ret55 == 0)
                    r1.AddTop("err1", "更新题目总数异常" + cond55.Sc + "  kemuId=" + cond55.KemuId + " sc_sum=" + sc_sum);

                #endregion 证书
            }
        }
        #endregion 证书信息
        else//第一步大学科目表
        {
            //更新科目表 总题数
            St_kemuInfo_q_sum cond5 = new St_kemuInfo_q_sum();
            cond5.KemuId = Convert.ToInt32(kemuId);
            if (!string.IsNullOrEmpty(cond1.Sc))
                cond5.Sc = Convert.ToInt32(cond1.Sc);
            
            if (cond5.Sc != 0)
            {
                St_kemuInfo_q_sum ret5 = BLLTable<St_kemuInfo_q_sum>.GetRowData(new St_kemuInfo_q_sum(), cond5);
                if (ret5 != null && ret5.IsNotNull() && ret5.Question_sum > 0)
                {
                    DateTime dt1 = ret5.Question_sum_time;
                    //if (DateTime.Now.Subtract(dt1).TotalHours < 24)
                    {
                        isNeedDoSum = false;

                        question_sum = ret5.Question_sum;
                        question_sum0 = ret5.Question_sum0;
                        question_sum1 = ret5.Question_sum1;
                        question_sum2 = ret5.Question_sum2;
                        question_sum3 = ret5.Question_sum3;
                        question_sum4 = ret5.Question_sum4;
                        question_sum5 = ret5.Question_sum5;
                        question_sum6 = ret5.Question_sum6;
                        question_sum7 = ret5.Question_sum7;
                        question_sum8 = ret5.Question_sum8;

                        sc_sum = Convert.ToString(cond5.Sc);
                        sc_sum0 = Convert.ToString(cond5.Sc);
                        sc_sum1 = Convert.ToString(cond5.Sc);
                        sc_sum2 = Convert.ToString(cond5.Sc);
                        sc_sum3 = Convert.ToString(cond5.Sc);
                        sc_sum4 = Convert.ToString(cond5.Sc);
                        sc_sum5 = Convert.ToString(cond5.Sc);
                        sc_sum6 = Convert.ToString(cond5.Sc);
                        sc_sum7 = Convert.ToString(cond5.Sc);
                        sc_sum8 = Convert.ToString(cond5.Sc);

                        r1.AddTop("isNeedDoSum", "无需重新统计" + cond5.Sc);
                    }
                }
                else if (cond5.Sc != Convert.ToInt32(sc_sum))
                {
                    cond5.Sc_sum = Convert.ToInt32(sc_sum);
                    ret5 = BLLTable<St_kemuInfo_q_sum>.GetRowData(new St_kemuInfo_q_sum(), cond5);
                    if (ret5 != null && ret5.IsNotNull() && ret5.Question_sum > 0)
                    {
                        isNeedDoSum = false;

                        question_sum = ret5.Question_sum;
                        question_sum0 = ret5.Question_sum0;
                        question_sum1 = ret5.Question_sum1;
                        question_sum2 = ret5.Question_sum2;
                        question_sum3 = ret5.Question_sum3;
                        question_sum4 = ret5.Question_sum4;
                        question_sum5 = ret5.Question_sum5;
                        question_sum6 = ret5.Question_sum6;
                        question_sum7 = ret5.Question_sum7;
                        question_sum8 = ret5.Question_sum8;

                        //sc_sum = sc_sum;// Convert.ToString(ret5.Sc_sum);
                        sc_sum0 = sc_sum;// Convert.ToString(ret5.Sc_sum0);
                        sc_sum1 = sc_sum;// Convert.ToString(ret5.Sc_sum1);
                        sc_sum2 = sc_sum;// Convert.ToString(ret5.Sc_sum2);
                        sc_sum3 = sc_sum;// Convert.ToString(ret5.Sc_sum3);
                        sc_sum4 = sc_sum;// Convert.ToString(ret5.Sc_sum4);
                        sc_sum5 = sc_sum;// Convert.ToString(ret5.Sc_sum5);
                        sc_sum6 = sc_sum;// Convert.ToString(ret5.Sc_sum6);
                        sc_sum7 = sc_sum;// Convert.ToString(ret5.Sc_sum7);
                        sc_sum8 = sc_sum;// Convert.ToString(ret5.Sc_sum8);

                        r1.AddTop("isNeedDoSum", "无需重新统计" + sc_sum);
                    }
                }
            }

            if (isNeedDoSum)
            {
                question_sum = BLLTable<St_TTimuDaXue>.Count(cond1);
                cond1.OptionType = "0";
                question_sum0 = BLLTable<St_TTimuDaXue>.Count(cond1);
                cond1.OptionType = "1";
                question_sum1 = BLLTable<St_TTimuDaXue>.Count(cond1);
                cond1.OptionType = "2";
                question_sum2 = BLLTable<St_TTimuDaXue>.Count(cond1);
                cond1.OptionType = "3";
                question_sum3 = BLLTable<St_TTimuDaXue>.Count(cond1);
                cond1.OptionType = "4";
                question_sum4 = BLLTable<St_TTimuDaXue>.Count(cond1);
                cond1.OptionType = "5";
                question_sum5 = BLLTable<St_TTimuDaXue>.Count(cond1);
                cond1.OptionType = "6";
                question_sum6 = BLLTable<St_TTimuDaXue>.Count(cond1);
                cond1.OptionType = "7";
                question_sum7 = BLLTable<St_TTimuDaXue>.Count(cond1);
                cond1.OptionType = "8";
                question_sum8 = BLLTable<St_TTimuDaXue>.Count(cond1);

                //更新科目表 总题数
                St_kemuInfo_q_sum cond55 = new St_kemuInfo_q_sum();
                cond55.KemuId = Convert.ToInt32(kemuId);
                cond55.Sc = Convert.ToInt32(cond1.Sc);

                if (cond55.Sc != 0)
                {
                    cond55.Question_sum = question_sum;
                    cond55.Question_sum0 = question_sum0;
                    cond55.Question_sum1 = question_sum1;
                    cond55.Question_sum2 = question_sum2;
                    cond55.Question_sum3 = question_sum3;
                    cond55.Question_sum4 = question_sum4;
                    cond55.Question_sum5 = question_sum5;
                    cond55.Question_sum6 = question_sum6;
                    cond55.Question_sum7 = question_sum7;
                    cond55.Question_sum8 = question_sum8;
                    cond55.Question_sum_time = DateTime.Now;
                    int ret5 = BLLTable<St_kemuInfo_q_sum>.SaveOrUpdate(cond55, St_kemuInfo_q_sum.Attribute.KemuId,
                        St_kemuInfo_q_sum.Attribute.Sc);
                    if (ret5 == 0)
                        r1.AddTop("err1", "更新题目总数异常" + cond55.Sc + "  kemuId=" + cond55.KemuId + " sc_sum=" + sc_sum);
                    else
                        r1.AddTop("su1", "更新题目 " + cond55.Sc + "  kemuId=" + cond55.KemuId + " sc_sum=" + sc_sum);
                }

                if (Convert.ToInt32(question_sum) < 50)
                {
                    r1.AddTop("smaller", "question_sum小于50");
                    if (!string.IsNullOrEmpty(sc_sum) && sc != sc_sum)
                    {
                        if (sc_sum != "999")
                            cond1.Sc = sc_sum;
                        else
                            cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                        cond1.SetInitialized(St_TTimuDaXue.Attribute.OptionType, false);
                        question_sum = BLLTable<St_TTimuDaXue>.Count(cond1);

                        if (Convert.ToInt32(question_sum0) < 2 && sc != sc_sum)
                        {
                            sc_sum0 = sc_sum;
                            if (sc_sum != "999")
                                cond1.Sc = sc_sum;
                            else
                                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                            cond1.OptionType = "0";
                            question_sum0 = BLLTable<St_TTimuDaXue>.Count(cond1);
                        }
                        if (Convert.ToInt32(question_sum1) < 2 && sc != sc_sum)
                        {
                            sc_sum1 = sc_sum;
                            if (sc_sum != "999")
                                cond1.Sc = sc_sum;
                            else
                                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                            cond1.OptionType = "1";
                            question_sum1 = BLLTable<St_TTimuDaXue>.Count(cond1);
                        }
                        if (Convert.ToInt32(question_sum2) < 2 && sc != sc_sum)
                        {
                            sc_sum2 = sc_sum; if (sc_sum != "999")
                                cond1.Sc = sc_sum;
                            else
                                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                            cond1.OptionType = "2";
                            question_sum2 = BLLTable<St_TTimuDaXue>.Count(cond1);
                        }
                        if (Convert.ToInt32(question_sum3) < 2 && sc != sc_sum)
                        {
                            sc_sum3 = sc_sum; if (sc_sum != "999")
                                cond1.Sc = sc_sum;
                            else
                                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                            cond1.OptionType = "3";
                            question_sum3 = BLLTable<St_TTimuDaXue>.Count(cond1);
                        }
                        if (Convert.ToInt32(question_sum4) < 2 && sc != sc_sum)
                        {
                            sc_sum4 = sc_sum; if (sc_sum != "999")
                                cond1.Sc = sc_sum;
                            else
                                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                            cond1.OptionType = "4";
                            question_sum4 = BLLTable<St_TTimuDaXue>.Count(cond1);
                        }
                        if (Convert.ToInt32(question_sum5) < 2 && sc != sc_sum)
                        {
                            sc_sum5 = sc_sum; if (sc_sum != "999")
                                cond1.Sc = sc_sum;
                            else
                                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                            cond1.OptionType = "5";
                            question_sum5 = BLLTable<St_TTimuDaXue>.Count(cond1);
                        }
                        if (Convert.ToInt32(question_sum6) < 2 && sc != sc_sum)
                        {
                            sc_sum6 = sc_sum; if (sc_sum != "999")
                                cond1.Sc = sc_sum;
                            else
                                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                            cond1.OptionType = "6";
                            question_sum6 = BLLTable<St_TTimuDaXue>.Count(cond1);
                        }
                        if (Convert.ToInt32(question_sum7) < 2 && sc != sc_sum)
                        {
                            sc_sum7 = sc_sum; if (sc_sum != "999")
                                cond1.Sc = sc_sum;
                            else
                                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                            cond1.OptionType = "7";
                            question_sum7 = BLLTable<St_TTimuDaXue>.Count(cond1);
                        }
                        if (Convert.ToInt32(question_sum8) < 2 && sc != sc_sum)
                        {
                            sc_sum8 = sc_sum; if (sc_sum != "999")
                                cond1.Sc = sc_sum;
                            else
                                cond1.SetInitialized(St_TTimuDaXue.Attribute.Sc, false);
                            cond1.OptionType = "8";
                            question_sum8 = BLLTable<St_TTimuDaXue>.Count(cond1);
                        }
                    }

                    St_TTimuDaXue val11 = new St_TTimuDaXue();
                    val11.KemuId = 1; val11.Sc = ""; val11.ChapterId = "";
                    val11.Distinct = true;
                    St_TTimuDaXue cond11 = new St_TTimuDaXue();
                    cond11.Sc = cond1.Sc;
                    cond11.KemuId = cond1.KemuId;
                    cond11.Where("ChapterId is not null"); ;
                    List<St_TTimuDaXue> list11 = BLLTable<St_TTimuDaXue>.Select(val11, cond11);

                    r1.data.Add("St_TTimuDaXue", list11);
                }
            }
        }

        if (sc.StartsWith("312") && kemuId == "100003")
        {
            question_sum0 = 0;
            question_sum2 = 0;
        }

        question_sum = (Convert.ToInt32(question_sum0) + Convert.ToInt32(question_sum1) +
            Convert.ToInt32(question_sum2) + Convert.ToInt32(question_sum3) + Convert.ToInt32(question_sum4) +
            Convert.ToInt32(question_sum5) + Convert.ToInt32(question_sum6) + Convert.ToInt32(question_sum7) +
            Convert.ToInt32(question_sum7) + Convert.ToInt32(question_sum8));

        r1.data.Add("question_sum", question_sum.ToString());
        r1.data.Add("question_sum0", question_sum0.ToString());
        r1.data.Add("question_sum1", question_sum1.ToString());
        r1.data.Add("question_sum2", question_sum2.ToString());
        r1.data.Add("question_sum3", question_sum3.ToString());
        r1.data.Add("question_sum4", question_sum4.ToString());
        r1.data.Add("question_sum5", question_sum5.ToString());
        r1.data.Add("question_sum6", question_sum6.ToString());
        r1.data.Add("question_sum7", question_sum7.ToString());
        r1.data.Add("question_sum8", question_sum8.ToString());
        r1.data.Add("question_sum_cuoti", question_sum_cuoti.ToString());
        r1.data.Add("kaoshiTime", kaoshiTime);

        //r1.data.Add("questionid_max", questionid_max);
        //r1.data.Add("questionid_max1", questionid_max0);
        //r1.data.Add("questionid_max2", questionid_max1);
        //r1.data.Add("questionid_max2", questionid_max2);
        //r1.data.Add("questionid_max3", questionid_max3);
        //r1.data.Add("questionid_max4", questionid_max4);
        //r1.data.Add("questionid_max5", questionid_max5);
        //r1.data.Add("questionid_max6", questionid_max6);
        //r1.data.Add("questionid_max7", questionid_max7);
        //r1.data.Add("questionid_max8", questionid_max8);

        r1.data.Add("sc_sum", sc_sum);

        r1.data.Add("sc_sum0", sc_sum0);
        r1.data.Add("sc_sum1", sc_sum1);
        r1.data.Add("sc_sum2", sc_sum2);
        r1.data.Add("sc_sum3", sc_sum3);
        r1.data.Add("sc_sum4", sc_sum4);
        r1.data.Add("sc_sum5", sc_sum5);
        r1.data.Add("sc_sum6", sc_sum6);
        r1.data.Add("sc_sum7", sc_sum7);
        r1.data.Add("sc_sum8", sc_sum8);

        string tu2wei = BLL1.getFile(sc);
        r1.data.Add("tu2wei", tu2wei);

        ////////////////////////
        St_read_book cond22 = new St_read_book();
        cond22.Sc = Convert.ToInt32(sc);
        List<St_read_book> read1 = BLLTable<St_read_book>.Select(new St_read_book(), cond22);
        if (read1 != null && read1.Count > 0)
        {
            r1.data.Add("St_read_book", read1);
        }
        //取得本页广告
        //TggInfo ggcond1 = new TggInfo();
        //ggcond1._GgSourceUrl = "list.html";

        //List<TggInfo> gglist = BLLTable<TggInfo>.Select(new TggInfo(), ggcond1);
        //r1.data.Add(gglist);

        if (!string.IsNullOrEmpty(openid) && openid != "null")
            r1.data.Add("openid", openid);

        bool isJiami = ("1" == Request["jiami"]) || !("1" == Request["neice"] || Request.Url.ToString().Contains("http://localhost"));
        string json1 = r1.ToJson(isJiami);
        try
        {
            if (Convert.ToInt32(question_sum) > 0 && !string.IsNullOrEmpty(json1))
            {
                bool b1 = MyRedis.Factory().Hash_Set<string>(pageCacheKey, sc + openid + kemuId, json1);
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
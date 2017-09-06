using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wap_main_query : BasePageShuati
{
    protected string sc = "";
    protected string sc2 = "";
    public string title1 = "";
    public string kemuId = "";
    public string KemuInfoJson = "";
    public string kemuName = "";
    public string readType = "";
    public int top = 50;
    public string leimu = "";
    public string openid = "";
    public string user_id = "";
    public string deviceId = "";
    string num = "1";
    public string timuIds = "";

    protected void Page_Load(object sender, EventArgs e)
    {
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
        if (!string.IsNullOrEmpty(Request["kemuId"]))
        {
            kemuId = Request["kemuId"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["kemuInfoJson"]))
        {
            KemuInfoJson = Request["kemuInfoJson"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["timuIds"]))
        {
            timuIds = Request["timuIds"].ToString();
        }
        SaveJson();
    }

    private string path1 = @"D:\网站系统\刷题日志\刷题神器";
    private string file1 = @"D:\网站系统\刷题日志\刷题神器\PostTUserZsInfo日志1.txt";

    public void SaveJson()//HttpContext context
    {
        int num = 0;
        JsonRoot r1 = new JsonRoot();
        try
        {
            string kemuIndexJson1 = "";
            string kemuIndexJson2 = "";
            string jsonZsIndex1 = "";
            string jsonZsIndex2 = "";
            //if (string.IsNullOrEmpty(json1))
            {
                sc = Request["sc"];
                user_id = Request["user_id"];
                openid = Request["openid"];
                //allJson = Request["allJson"];
            }
            r1.AddTop("openid", openid);
            r1.AddTop("user_id", user_id);

            //if (allJson.Contains("&"))
            //    allJson = StringHelper.CutString(json1, "", "&");

            r1.AddTop("IsAttached", MyDebugger.IsAttached.ToString());
            //if (MyDebugger.IsAttached) if (string.IsNullOrEmpty(openid)) 
            //    openid = "oKuzrwKotAddU5Fb81oE - A4fwz5E";

            if (string.IsNullOrEmpty(openid) && string.IsNullOrEmpty(user_id))
            {
                r1.code = -1;
                r1.errMsg = "openid为空 与 user_id为空";
            }
            else
            {
                if (Request["act"] == "down1")
                {
                    string min1 = BLLTable<St_kemuInfo>.Min(St_kemuInfo.Attribute.Seq, new St_kemuInfo());

                    if (!string.IsNullOrEmpty(kemuId))
                    {
                        St_kemuInfo cond1 = new St_kemuInfo();
                        cond1.KemuId = Convert.ToInt32(kemuId);
                        cond1.Seq = Convert.ToInt32(min1) - 1;
                        int ret1 = BLLTable<St_kemuInfo>.Update(cond1, St_kemuInfo.Attribute.KemuId);
                        if (ret1 > 0)
                        {
                            r1.code = 200;
                            r1.AddTop("msg1", "下降到最末尾成功");
                        }
                    }
                    else
                    {
                        r1.errMsg = "科目id不存在";
                    }
                }
                if (Request["act"] == "up1")
                {
                    string max1 = BLLTable<St_kemuInfo>.Max(St_kemuInfo.Attribute.Seq, new St_kemuInfo());
                    if (!string.IsNullOrEmpty(kemuId))
                    {
                        St_kemuInfo cond1 = new St_kemuInfo();
                        cond1.KemuId = Convert.ToInt32(kemuId);
                        cond1.Seq = Convert.ToInt32(max1) + 1;
                        int ret1 = BLLTable<St_kemuInfo>.UpdateAuto(cond1, St_kemuInfo.Attribute.KemuId);
                        if (ret1 > 0)
                        {
                            r1.code = 200;
                            r1.AddTop("msg1","上升1位，成功");
                        }
                    }
                    else
                        r1.errMsg = "科目id不存在";
                }
                if (Request["act"] == "del")
                {
                    int ret1 = -1;
                    if (!string.IsNullOrEmpty(user_id))
                    {
                        ret1 = BLLTable<St_TUserZsInfo>.Delete(St_TUserZsInfo.Attribute.User_id, user_id);
                    }
                    else if (!string.IsNullOrEmpty(openid) && openid != "null")
                    {
                        ret1 = BLLTable<St_TUserZsInfo>.Delete(St_TUserZsInfo.Attribute.OpenId, openid);
                    }
                    r1.code = 200;
                    r1.message = "操作成功";
                }
                else
                {
                    kemuIndexJson1 = Request["kemuIndexJson1"];
                    kemuIndexJson2 = Request["kemuIndexJson2"];
                    jsonZsIndex1 = Request["jsonZsIndex1"];
                    jsonZsIndex2 = Request["jsonZsIndex2"];
                    r1.AddTop("kemuIndexJson1", kemuIndexJson1.Length);
                    r1.AddTop("kemuIndexJson2", kemuIndexJson2.Length);
                    r1.AddTop("jsonZsIndex1", jsonZsIndex1.Length);
                    r1.AddTop("jsonZsIndex2", jsonZsIndex2.Length);
                    //r1.AddTop("allJson", allJson.Length);
                    if (!string.IsNullOrEmpty(Request["admin"]))
                    {
                        if ("1" == Request["admin"].ToString())
                        {
                            AFDictionary<int, St_kemuInfo> dic1 = new AFDictionary<int, St_kemuInfo>();
                            St_kemuInfo val11 = new St_kemuInfo(); val11.KemuId = 0; val11.IsShowIndex = true;
                            List<St_kemuInfo> list1 = BLLTable<St_kemuInfo>.Select(val11);
                            foreach (St_kemuInfo st1 in list1)
                                dic1.Add(st1.KemuId, st1);

                            foreach (string kemuId in kemuIndexJson1.Split(','))
                            {
                                if (string.IsNullOrEmpty(kemuId)) continue;
                                St_kemuInfo val1 = new St_kemuInfo();
                                val1.KemuId = Convert.ToInt32(kemuId);
                                if (dic1.ContainsKey(val1.KemuId) && dic1[val1.KemuId].IsShowIndex != true)
                                {
                                    val1.IsShowIndex = true;
                                    int ret5 = BLLTable<St_kemuInfo>.Update(val1, St_kemuInfo.Attribute.KemuId);
                                }
                            }
                            foreach (string kemuId in kemuIndexJson2.Split(','))
                            {
                                if (string.IsNullOrEmpty(kemuId)) continue;
                                St_kemuInfo val1 = new St_kemuInfo();
                                val1.KemuId = Convert.ToInt32(kemuId);
                                if (dic1.ContainsKey(val1.KemuId) && dic1[val1.KemuId].IsShowIndex != false)
                                {
                                    val1.IsShowIndex = false;
                                    int ret5 = BLLTable<St_kemuInfo>.Update(val1, St_kemuInfo.Attribute.KemuId);
                                }
                            }

                            AFDictionary<int, St_TzsInfo>  dic22 = new AFDictionary<int, St_TzsInfo>();
                            St_TzsInfo val22 = new St_TzsInfo(); val22.ZsId = 0; val22.IsShowIndex = true;
                            List<St_TzsInfo> list22 = BLLTable<St_TzsInfo>.Select(val22);
                            foreach (St_TzsInfo st1 in list22)
                                dic22.Add(st1.ZsId, st1);

                            foreach (string kemuId in jsonZsIndex1.Split(','))
                            {
                                if (string.IsNullOrEmpty(kemuId)) continue;
                                St_TzsInfo val1 = new St_TzsInfo();
                                val1.ZsId = Convert.ToInt32(kemuId);
                                if (dic22.ContainsKey(val1.ZsId) && dic22[val1.ZsId].IsShowIndex != true)
                                {
                                    val1.IsShowIndex = true;
                                    int ret5 = BLLTable<St_TzsInfo>.Update(val1, St_TzsInfo.Attribute.ZsId);
                                }
                            }
                            foreach (string kemuId in jsonZsIndex2.Split(','))
                            {
                                if (string.IsNullOrEmpty(kemuId)) continue;
                                St_TzsInfo val1 = new St_TzsInfo();
                                val1.ZsId = Convert.ToInt32(kemuId);
                                if (dic22.ContainsKey(val1.ZsId) && dic22[val1.ZsId].IsShowIndex != false)
                                {
                                    val1.IsShowIndex = false;
                                    int ret5 = BLLTable<St_TzsInfo>.Update(val1, St_TzsInfo.Attribute.ZsId);
                                }
                            }
                            r1.AddTop("admin", "更新完成");
                            r1.code = 200;
                        }
                    }
                    else
                    {
                        num = -1;
                        St_TUserZsInfo zsUser1 = new St_TUserZsInfo();
                        if (!string.IsNullOrEmpty(user_id) && user_id != "null")
                            zsUser1.User_id = user_id;
                        if (!string.IsNullOrEmpty(openid) && openid != "null")
                            zsUser1.OpenId = openid;

                        if (!string.IsNullOrEmpty(kemuIndexJson1) || !string.IsNullOrEmpty(kemuIndexJson2)
                            || !string.IsNullOrEmpty(jsonZsIndex1) || !string.IsNullOrEmpty(jsonZsIndex2))
                        {
                            num = 0;

                            if (!string.IsNullOrEmpty(kemuIndexJson1))
                            {
                                zsUser1.KemuInfoJson_sel = (kemuIndexJson1);
                            }
                            if (!string.IsNullOrEmpty(kemuIndexJson2))
                            {
                                zsUser1.KemuInfoJson_no = (kemuIndexJson2);
                            }
                            if (!string.IsNullOrEmpty(jsonZsIndex1))
                            {
                                zsUser1.KemuInfoJson_zs_sel = (jsonZsIndex1);
                            }
                            if (!string.IsNullOrEmpty(jsonZsIndex2))
                            {
                                zsUser1.KemuInfoJson_zs_no = (jsonZsIndex2);
                            }
                            //if (!string.IsNullOrEmpty(kemuIndexJson))
                            {
                                //error1.CreateTime = DateTime.Now;

                                int ret1 = -1;
                                if (!string.IsNullOrEmpty(user_id))
                                {
                                    ret1 = BLLTable<St_TUserZsInfo>.SaveOrUpdate(zsUser1, St_TUserZsInfo.Attribute.User_id);
                                }
                                else if (!string.IsNullOrEmpty(openid) && openid != "null")
                                {
                                    ret1 = BLLTable<St_TUserZsInfo>.SaveOrUpdate(zsUser1, St_TUserZsInfo.Attribute.OpenId);
                                }

                                if (ret1 >= 0)
                                {
                                    num = ret1;
                                    r1.code = 200;

                                    if (!string.IsNullOrEmpty(sc) && !string.IsNullOrEmpty(openid))
                                    {
                                        string pageCacheKey = "ListKemuIndex.aspx";
                                        MyRedis.Factory().Hash_Remove(pageCacheKey, sc + openid);
                                        pageCacheKey = "ListZs.aspx";
                                        MyRedis.Factory().Hash_Remove(pageCacheKey, sc + openid);
                                    }
                                }
                                else
                                {
                                    num = ret1;
                                    r1.code = 401;
                                    r1.msg = "更新失败";

                                    if (!string.IsNullOrEmpty(sc) && !string.IsNullOrEmpty(openid))
                                    {
                                        string pageCacheKey = "ListKemuIndex.aspx";
                                        MyRedis.Factory().Hash_Remove(pageCacheKey, sc + openid);
                                        pageCacheKey = "ListZs.aspx";
                                        MyRedis.Factory().Hash_Remove(pageCacheKey, sc + openid);
                                    }
                                }
                            }
                        }
                        else
                        {
                            r1.errMsg = "kemuIndexJson1为空 与 kemuIndexJson2为空";
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            r1.AddTop("num", num.ToString());
            r1.code = 0;
            r1.errMsg = ex.Message;
            //if (!Directory.Exists(path1)) Directory.CreateDirectory(path1);
            Cs.Error("\r\n\r\n" + ex.ToString());
            Response.Write(r1.ToJson());
            return;
        }
        //Response.ContentType = "text/plain";
        r1.AddTop("num", num.ToString());
        Response.Write(r1.ToJson());
        return;
    }
}
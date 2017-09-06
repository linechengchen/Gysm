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
    protected string sc = "";
    public string title1 = "未加载";
    public string kemuId = "";
    public string readType = "1";
    public int top = 50;
    public string leimu = "";
    public string openid = "";
    public string user_id = "";
    public string deviceId = "";
    private void setTitle()
    {
        if (!string.IsNullOrEmpty(Request["leimu"]))
        {
            leimu = Convert.ToString(Request["leimu"]);
        }
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        if (!string.IsNullOrEmpty(Request["openid"]))
        {
            openid = Convert.ToString(Request["openid"]);
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
        if (!string.IsNullOrEmpty(Request["kemuId"]))
        {
            kemuId = Request["kemuId"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["top"]))
        {
            top = Convert.ToInt32(Request["top"].ToString());
        }
    }
    string num = "1";
    public string type = "sequence";//顺序出题
    public string seq = "1";
    protected string jump_num = "";
    public string LastSeq = "";
    public string errorids = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        setTitle();
        AFDictionary<string, int> dic1 = new AFDictionary<string, int>();
        St_TTimuDaXueErrorInfo val1 = new St_TTimuDaXueErrorInfo();

        St_TTimuDaXueErrorInfo cond1 = new St_TTimuDaXueErrorInfo();
        cond1.OrderBy(St_TTimuDaXueErrorInfo.Attribute.Id, Order.Desc);

        if (!string.IsNullOrEmpty(openid) && !string.IsNullOrEmpty(kemuId))
        {
            cond1.OpenId = openid;
            if (!string.IsNullOrEmpty(user_id))
                cond1.User_id = user_id;
            if (!string.IsNullOrEmpty(kemuId))
                cond1.KemuId = kemuId;
            //if (!string.IsNullOrEmpty(sc))
            //    cond1.Sc = sc;
            //else
            {
                //sc = "194";
                //cond1.Sc = sc;
            }
            val1.Top(1);
            List<St_TTimuDaXueErrorInfo> timuList = BLLTable<St_TTimuDaXueErrorInfo>.Factory("conn").Select(val1, cond1);

            RootObject r1 = new RootObject(MyDebugger.IsAttached); r1.isShuati = true;
            r1.Add(timuList);

            if (!string.IsNullOrEmpty(openid) && openid != "null")
                r1.data.Add("openid", openid);

            string json1 = r1.ToJson();
            Response.Write(json1);            
        }
    }
}
using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_jsonKemuName : BasePageShuati
{
    protected string agent = "";
    protected string sc = "404oj";
    protected string sc2 = "404oj";
    public string title1 = "未加载";
    public string kemuId = "100001";
    public string kemuName = "mks";
    public string num = "1";
    public string type = "sequence";
    public string leimu = "";
    protected string name1 = "";
    protected string tu2wei = "";//zlg
    public string subKcName = "";
    public string jump_num = "";
    public string neice = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["neice"]))
        {
            neice = Request["neice"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["jump_num"]))
        {
            jump_num = Request["jump_num"].ToString();
        }
    
        if (!string.IsNullOrEmpty(Request["leimu"]))
        {
            leimu = Convert.ToString(Request["leimu"]);
        }
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        name1 = StringHelper.GetHanZi(BLL1.getDaxueName(sc));

        if (!string.IsNullOrEmpty(Request["type"]))
        {
            type = Request["type"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["kemuName"]))
        {
            kemuName = Request["kemuName"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["kemuId"]))
        {
            kemuId = Request["kemuId"].ToString();
            title1 = BLL3.getClassZhongWen(kemuId.ToString());
        }

        RootObject root1 = new RootObject(MyDebugger.IsAttached);
        root1.data.Add("kemuName", title1);
        Response.Write(root1.ToJson());
    }
}
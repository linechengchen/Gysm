using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_schools : BasePageShuati
{
    protected string openid = "";//zlg
    protected string sc = "194";//zlg

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        RootObject r2 = new RootObject();
        TDepartment td1 = new TDepartment(); td1.Top(100);
        TDepartment cond1 = new TDepartment();
        if (!string.IsNullOrEmpty(Request["school_id"]) && Request["school_id"] != "null")
        {
            cond1.School_id = Convert.ToInt32(Request["school_id"]);
            List<TDepartment> list1 = BLLTable<TDepartment>.Select(td1, cond1);
            r2.code = 200;
            r2.Add(list1, "TDepartments");
            string json1 = r2.ToJsonHeadLower(isJiami);
            Response.Write(json1);
            Response.End();
        }
    }
}
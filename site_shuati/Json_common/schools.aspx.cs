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
        if (Request["t"] == "1") return; JsonRoot r1 = new JsonRoot();
        if (!string.IsNullOrEmpty(Request["city"]))
        {
            VSchool td1 = new VSchool();
            td1.Id = 1;
            td1.Name = "";
            td1._X = 1;
            td1._Y = 1;
            td1.Sc_id = "";
            td1.Sc_name = "";
            VSchool cond1 = new VSchool();
            cond1.City = Convert.ToString(Request["city"]).TrimEnd('市');
            {
                List<VSchool> list1 = BLLTable<VSchool>.Select(td1, cond1);
                foreach (VSchool s1 in list1)
                {
                    if (string.IsNullOrEmpty(s1.Sc_id))
                        s1.Sc_id = "999";
                }
                r1.code = 200;
                r1.data.Add(list1, "schools");
            }
            string json11 = r1.ToJsonHeadLower(true);
            Response.Write(json11);
            Response.End();
        }
    }
}
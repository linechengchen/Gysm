using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_Schools : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TDepartment val1 = new TDepartment();
        TDepartment cond1 = new TDepartment();
        List<TDepartment> tlist = BLLTable<TDepartment>.Select(val1, cond1);
        RootObject r1 = new RootObject();
        r1.Add(tlist);
        string json1 = r1.ToJson();
        Response.Write(json1);
    }
}
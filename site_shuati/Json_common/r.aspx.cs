using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1 : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!MyRedis.isOK)
        {
            bool b1 = MyRedis.Ping();
            Response.Write("{\"redis\":\"" + b1 + "\"}");
            return;
        }
        Response.Write("{\"redis\":\"false\"}"); return;
    }
}
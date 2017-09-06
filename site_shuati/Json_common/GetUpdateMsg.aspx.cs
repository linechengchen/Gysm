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
    protected void Page_Load(object sender, EventArgs e)
    {
        string updateMsg = "";

        string sc = ScHelper.getSc(this);
        if (!string.IsNullOrEmpty(sc))
        {
            if (sc == "1")
            {
                updateMsg = "";
            }
        }
        updateMsg = "通知：学长已修复选题Bug，于" + DateTime.Now.ToShortDateString();

        Response.Write("{\"code\":\"" + "200" + "\",\"updateMsg\":\"" + updateMsg + "\"}");
    }
}
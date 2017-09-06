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
        Session["openid"] = null;
        Session["sc"] = null;
        Session["test1"] = null;
        Session["ceshi"] = null;

        Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/kemuIndex.html?openid=oKuzrwDHM7Rxo1EDeXSSfVpiIOII&sc=312&source1=D06590814890484156596228&type1=&r=121&test1=1&neice=1&gz=1");
    }
}
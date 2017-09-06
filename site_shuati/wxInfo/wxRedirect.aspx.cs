using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wxRedirectBack : BasePageShuati
{
    string url1 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        url1 = Convert.ToString(Session["wx_url"]);
        if (!string.IsNullOrEmpty(url1))
        {
            Response.Redirect(url1);
        }
        //else
        //{
        //    Response.Write("<html><script>alert('未有上一次保存的刷题记录');</script></html>");
        //    Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/shuati/pages/indexPage1_shuati.html");
        //}
        return;
    }
}
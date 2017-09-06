using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test1 : BasePageShuati
{
    Common com = new Common();
    private string addOpenIdToUrl(string url1, string openid)
    {
        if (url1.Contains("?"))
            url1 += "&openid=" + openid;
        else
            url1 += "?openid=" + openid;
        return url1;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                //Session["openid"] = "";
                if (!String.IsNullOrEmpty(Request.Params["test1"]))
                    Session["test1"] = Request.Params["test1"];

                if (!String.IsNullOrEmpty(Request.Params["sc"]))
                    Session["sc"] = Request.Params["sc"];

                string url1 = (Request.Params["urlname"]);
                string app_path1 = (Request.Params["app_path1"]);
                //url没有传递openid，但是可能已经授权登录过了，传递了Session--openid
                if (!String.IsNullOrEmpty(Convert.ToString(Session["openid"])))
                {
                    string openid = Convert.ToString(Session["openid"]);
                    url1 = addOpenIdToUrl(Request.Params["urlname"], openid);

                    WX_USER_INFO cond1 = new WX_USER_INFO();
                    cond1.Openid = openid;
                    WX_USER_INFO w1 = BLLTable<WX_USER_INFO>.GetRowData(cond1);

                    if (w1 != null && w1.IsNotNull() && !string.IsNullOrEmpty(w1.Openid))
                    {
                        //if(string.IsNullOrEmpty(w1.Sc))
                        //if (!String.IsNullOrEmpty(Request.Params["sc"]))
                        //    cond1.Sc = Request.Params["sc"];
                        //int ret = BLLTable<WX_USER_INFO>.Update(cond1, WX_USER_INFO.Attribute.Openid);

                        string url2 = Server.UrlDecode(url1);
                        url2 = HttpUtility.UrlDecode(url1);
                        Response.Redirect(url1, false);
                        return;
                    }
                }
                //openid有错，怎么办，再次跳转微信
                if (!string.IsNullOrEmpty(url1))
                {
                    Session["wx_url"] = (url1);
                    Response.Redirect(com.getwx_url(), false);
                }else
                {
                    if (string.IsNullOrEmpty(app_path1))
                        app_path1 = "shuati";
                    Response.Redirect("http://stbd.aibangxs.com/site_shuati/app/" + app_path1 + "/pagesCommon/followme.html", false);
                }
            }
        }
        catch (Exception e1)
        {
            File.AppendAllText(@"D:\网站系统\刷题日志\test异常.txt", e1.ToString() + "\r\n");
            Cs.Error(e1.ToString());
        }
    }
}
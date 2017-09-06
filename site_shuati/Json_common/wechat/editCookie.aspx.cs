using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_wechat_editCookie : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string city_id = Request["city_id"];
        string token = Request.Headers["token"];
        string version = Request.Headers["version"];

        HttpCookie cityId1 = new HttpCookie("city_id");
        cityId1.Value = city_id;
        HttpContext.Current.Response.Cookies.Add(cityId1);

        HttpCookie token1 = new HttpCookie("token");
        token1.Value = token;
        HttpContext.Current.Response.Cookies.Add(token1);

        HttpCookie version1 = new HttpCookie("version");
        version1.Value = version;
        HttpContext.Current.Response.Cookies.Add(version1); 
    }

    private void setCookie(string name, string value)
    {
        if (string.IsNullOrEmpty(value))
        {
        }
        HttpCookie version1 = new HttpCookie(name);
        version1.Value = value;
        HttpContext.Current.Response.Cookies.Add(version1);
    }

}
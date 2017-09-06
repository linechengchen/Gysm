using AgileFrame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wxReturn : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //signature     微信加密签名，signature结合了开发者填写的token参数和请求中的timestamp参数、nonce参数。
        //timestamp     时间戳
        //nonce     随机数
        //echostr     随机字符串s
        try
        {
            string signature = HttpContext.Current.Request["signature"];
            string timestamp = HttpContext.Current.Request["timestamp"];
            string nonce = HttpContext.Current.Request["nonce"];
            string echostr = HttpContext.Current.Request["echostr"];

            if (string.IsNullOrEmpty(signature))
            {
                Response.Redirect("wxRedirect.aspx", false);
                return;
            }

            string Token = "stbd";

            string[] wxstring = { Token, timestamp, nonce };

            Array.Sort(wxstring);

            string temp2 = string.Join("", wxstring);
            string TEMP3 = FormsAuthentication.HashPasswordForStoringInConfigFile(temp2, "SHA1");

            if (TEMP3.ToLower().Equals(signature))
            {
                Response.Write(echostr);
                return;
            }
        }
        catch (Exception e1)
        {
            Cs.Error(e1.ToString());
        }
    }
}
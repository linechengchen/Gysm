using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.Model;
using Dos.WeChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_jsonKemuName : BasePageShuati
{
    protected string agent = "";
    protected string sc = "404oj";
    protected string sc2 = "404oj";
    public string title1 = "未加载";
    public string kemuId = "100001";
    public string kemuName = "mks";
    public string num = "1";
    public string type = "sequence";
    public string leimu = "";
    protected string name1 = "";
    protected string tu2wei = "";//zlg
    public string subKcName = "";
    public string jump_num = "";
    public string neice = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["neice"]))
        {
            neice = Request["neice"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["jump_num"]))
        {
            jump_num = Request["jump_num"].ToString();
        }
        //if (!AgileFrame.Core.ConsoleService.IsNeedWebConsole)
        //{
        //    AgileFrame.Core.ConsoleService.IsNeedWebConsole = true;
        //    AgileFrame.Core.ConsoleService.Fatal("bs控制台启动");
        //}
        if (!string.IsNullOrEmpty(Request["leimu"]))
        {
            leimu = Convert.ToString(Request["leimu"]);
        }
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
        name1 = StringHelper.GetHanZi(BLL1.getDaxueName(sc));

        if (!string.IsNullOrEmpty(Request["type"]))
        {
            type = Request["type"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["kemuName"]))
        {
            kemuName = Request["kemuName"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["kemuId"]))
        {
            kemuId = Request["kemuId"].ToString();
            title1 = BLL3.getClassZhongWen(kemuId.ToString());
        }
        //判断是否登录微信？
        if (!string.IsNullOrEmpty(Request["code"]))
        {
            string code = Request["code"];
            WeChatParam param = new WeChatParam();
            param.Code = code;
            Dictionary<string, string> authParam = UserHelper.GetOauth2AccessToken(param);
            WeChatParam param2 = new WeChatParam();
            if (authParam.ContainsKey("access_token"))
            {
                param2.AccessToken = authParam["access_token"];
            }
            if (authParam.ContainsKey("openid"))
            {
                param2.OpenId = authParam["openid"];
            }
            UserInfoResult userInfo = UserHelper.GetSnsUserInfo(param2);
        }

        //RootObject r1 = new RootObject(MyDebugger.IsAttached);
        //r1.data.Add("kemuName", title1);
        //Response.Write(root1.ToJson());
    }
}
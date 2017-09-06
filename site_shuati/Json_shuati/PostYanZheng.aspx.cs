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
    protected string sc = "";
    protected string sc2 = "";
    public string title1 = "";
    public string kemuId = "";
    public string errorSum = "";
    public string answerSum = "";
    public string kemuName = "";
    public string readType = "";
    public int top = 50;
    public string leimu = "";
    public string openid = "";
    public string user_id = "";
    public string deviceId = "";
    string num = "1";
    public string timuIds = "";
    public string mobile = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["openid"]))
        {
            openid = Request["openid"].ToString();
        }
        if (string.IsNullOrEmpty(openid))
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["openid"])))
            {
                openid = Convert.ToString(Session["openid"]);
            }
        }
        if (!string.IsNullOrEmpty(Request["user_id"]))
        {
            user_id = Request["user_id"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["kemuId"]))
        {
            kemuId = Request["kemuId"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["answerSum"]))
        {
            answerSum = Request["answerSum"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["errorSum"]))
        {
            errorSum = Request["errorSum"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["timuIds"]))
        {
            timuIds = Request["timuIds"].ToString();
        }
        if (!string.IsNullOrEmpty(Request["mobile"]))
        {
            mobile = Request["mobile"].ToString();
        }
        SaveErr();
    }
    private string path1 = @"D:\网站系统\刷题日志\刷题神器";
    private string file1 = @"D:\网站系统\刷题日志\刷题神器\PostYanZheng日志1.txt";
    string json1 = "";
    public void SaveErr()//HttpContext context
    {
        int num = 0;
        try
        {
            if (!string.IsNullOrEmpty(mobile))
            {
                string code1 = SmsShuati.sendMsgYanZheng(mobile, "");
                Response.Write(code1);
                Response.End();
            }
        }
        catch(Exception ex)
        {
            Cs.Warn("83" + ex.ToString());
            if (!Directory.Exists(path1)) Directory.CreateDirectory(path1);
            Cs.Error("\r\n\r\n" + ex.ToString());
        }
        //Response.ContentType = "text/plain";
        Response.Write("");        
    }
}
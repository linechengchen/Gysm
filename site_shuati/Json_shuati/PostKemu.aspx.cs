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

public partial class wap_main_PostAjax : BasePageShuati
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
        SaveData();
    }
    private string path1 = @"D:\网站系统\刷题日志\刷题神器";
    private string file1 = @"D:\网站系统\刷题日志\刷题神器\PostListTimuError日志1.txt";
    public void SaveData()//HttpContext context
    {
        int num = 0;
        try
        {
            Response.ContentType = "application/json";
            var data = Request;
            var sr = new StreamReader(data.InputStream);
            var stream = sr.ReadToEnd();
            var javaScriptSerializer = new JavaScriptSerializer();
            string json1 = stream;
            sc = StringHelper.CutString(json1, "sc=", "&");
            user_id = StringHelper.CutString(json1, "user_id=", "&");
            kemuId = StringHelper.CutString(json1, "kemuId=", "&");
            errorSum = StringHelper.CutString(json1, "errorSum=", "&");
            answerSum = StringHelper.CutString(json1, "answerSum=", "&");
            openid = StringHelper.CutString(json1, "openid=", "&");
            string errJson = StringHelper.CutString(json1, "errJson=", "");
            
            string kaoshiTime = StringHelper.CutString(json1, "kaoshiTime=", "&");
            if (!string.IsNullOrEmpty(kaoshiTime))
                kaoshiTime = StringHelper.CutString(json1, "", "errJson=");

            string url1 = StringHelper.CutString(json1, "", "errJson=");
            
            if (errJson.Contains("&"))
                errJson = StringHelper.CutString(json1, "", "&");

            if (!string.IsNullOrEmpty(errJson))
            {
                St_TTimuDaXueErrorInfo error1 = new St_TTimuDaXueErrorInfo();
                if (!string.IsNullOrEmpty(user_id))
                    error1._User_id = user_id;
                if (!string.IsNullOrEmpty(openid) && openid != "null")
                    error1.OpenId = openid;
                if (!string.IsNullOrEmpty(kemuId))
                    error1.KemuId = kemuId;
                if (!string.IsNullOrEmpty(errorSum) && StringHelper.IsNumeric(errorSum))
                    error1.ErrorSum = Convert.ToInt32(errorSum);

                if (!string.IsNullOrEmpty(answerSum) && StringHelper.IsNumeric(answerSum))
                    error1.AnswerSum = Convert.ToInt32(answerSum);

                error1.CreateTime = DateTime.Now;
                error1.ErrJson = errJson;

                int ret1 = -1;
                if (!string.IsNullOrEmpty(openid) && openid != "null")
                    ret1 = BLLTable<St_TTimuDaXueErrorInfo>.SaveOrUpdate(error1, St_TTimuDaXueErrorInfo.Attribute.OpenId);

                else if (!string.IsNullOrEmpty(user_id))
                    ret1 = BLLTable<St_TTimuDaXueErrorInfo>.SaveOrUpdate(error1, St_TTimuDaXueErrorInfo.Attribute.User_id);

                if (ret1 >= 0) num = ret1;
            }
        }
        catch(Exception ex)
        {
            Cs.Warn("83" + ex.ToString());
            if (!Directory.Exists(path1)) Directory.CreateDirectory(path1);
            Cs.Error( "\r\n\r\n" + ex.Message);
            Response.Write("{\"code\":\"" + ex.Message + "\",\"num\":\"" + num + "\",\"openid\":\"" + openid + "\"}");
            Response.End();
        }
        //Response.ContentType = "text/plain";
        Response.Write("{\"code\":\"" + "200" + "\",\"num\":\"" + num + "\",\"openid\":\"" + openid +"\"}");
        Response.End();
    }
    private St_TTimuDaXueErrorInfo setvalue(St_TTimuDaXue valObj2)
    {
        St_TTimuDaXueErrorInfo valObj = new St_TTimuDaXueErrorInfo();
        //valObj.AutoId = valObj2.AutoId;
        //valObj.Id = valObj2.Id;
        //valObj.Answer = valObj2.Answer;
        //valObj.ChapterId = valObj2.ChapterId;
        //valObj.Difficulty = valObj2.Difficulty;
        //valObj.Explain = valObj2.Explain;
        //valObj.Label = valObj2.Label;
        //valObj.MediaHeight = valObj2.MediaHeight;
        //valObj.MediaType = valObj2.MediaType;
        //valObj.MediaWidth = valObj2.MediaWidth;
        //valObj.OptionA = valObj2.OptionA;
        //valObj.OptionB = valObj2.OptionB;
        //valObj.OptionC = valObj2.OptionC;
        //valObj.OptionD = valObj2.OptionD;
        //valObj.OptionE = valObj2.OptionE;
        //valObj.OptionF = valObj2.OptionF;
        //valObj.OptionG = valObj2.OptionG;
        //valObj.OptionH = valObj2.OptionH;
        //valObj.OptionType = valObj2.OptionType;
        //valObj.Question = valObj2.Question;
        //valObj.QuestionId = valObj2.QuestionId;
        //valObj.MediaContent = valObj2.MediaContent;
        //valObj.FalseCount = valObj2.FalseCount;
        //valObj.TrueCount = valObj2.TrueCount;
        //valObj.WrongRate = valObj2.WrongRate;
        //valObj.SourceFile = valObj2.SourceFile;
        //valObj.Sourceid = valObj2.Sourceid;
        //valObj.SourceZhangjie = valObj2.SourceZhangjie;
        //valObj.Optionnum = valObj2.Optionnum;
        //valObj.Kemu = valObj2.Kemu;
        //valObj.Url = valObj2.Url;
        //valObj.Sc = valObj2.Sc;
        //valObj.Area = valObj2.Area;
        //valObj.User_id = valObj2.user_id;
        //valObj.DiggUp = valObj2.DiggUp;
        //valObj.DiggDown = valObj2.DiggDown;
        //valObj.IsRepeatTf = valObj2.IsRepeatTf;
        //valObj.ExamType = valObj2.ExamType;
        //valObj.Analysis = valObj2.Analysis;
        //valObj.LinkExam = valObj2.LinkExam;
        //valObj.OrderId = valObj2.OrderId;
        //valObj.Teacher = valObj2.Teacher;
        //valObj.Knowledge = valObj2.Knowledge;
        //valObj.YearId = valObj2.YearId;
        //valObj.PaperShortName = valObj2.PaperShortName;
        //valObj.KemuId = valObj2.KemuId;
        //valObj.OptionStr = valObj2.OptionStr;
        //valObj.AnswerABC = valObj2.AnswerABC;
        //valObj.KaoDian = valObj2.KaoDian; 
        return valObj;
    }
}
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

public partial class wap_postJiuCuo : BasePageShuati
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
        SaveErr();
    }
    private string path1 = @"D:\网站系统\刷题日志\刷题神器";
    private string file1 = @"D:\网站系统\刷题日志\刷题神器\PostListTimuError日志1.txt";
    string json1 = "";
    string answer1 = ""; string Question = ""; string AnswerABC = ""; string Answer = ""; string AutoId1 = "";
    string QuestionId = "";
    JsonRoot r1 = new JsonRoot();
    public void SaveErr()//HttpContext context
    {
        int num = 0;
        try
        {
            Response.ContentType = "application/json";
            var data = Request;
            var sr = new StreamReader(data.InputStream);
            var stream = sr.ReadToEnd();
            json1 = stream;
            sc = StringHelper.CutString(json1, "sc=", "&");
            user_id = StringHelper.CutString(json1, "user_id=", "&");
            kemuId = StringHelper.CutString(json1, "kemuId=", "&");
            openid = StringHelper.CutString(json1, "openid=", "&");

            QuestionId = StringHelper.CutString(json1, "question1=", "&");
            answer1 = StringHelper.CutString(json1, "answer1=", "&");
            AutoId1 = StringHelper.CutString(json1, "AutoId1=", "&");
            string neice = StringHelper.CutString(json1, "neice=", "&");

            Question = StringHelper.CutString(json1, "Question=", "&");
            AnswerABC = StringHelper.CutString(json1, "AnswerABC=", "&");
            Answer = StringHelper.CutString(json1, "Answer=", "&");

            if (string.IsNullOrEmpty(json1))
            {
                sc = Request["sc"];
                user_id = Request["user_id"];
                kemuId = Request["kemuId"];
                openid = Request["openid"];

                QuestionId = Request["question1"];
                answer1 = Request["answer1"];
                AutoId1 = Request["AutoId1"];
                neice = Request["neice"];

                Question = Request["Question"];
                AnswerABC = Request["AnswerABC"];
                Answer = Request["Answer"];
            }

            if (!string.IsNullOrEmpty(QuestionId) && !string.IsNullOrEmpty(answer1))
            {
                if (!string.IsNullOrEmpty(kemuId))//!string.IsNullOrEmpty(openid) && 
                {
                    bool needBak = false;
                    St_TQuestionJiuCuo error1 = new St_TQuestionJiuCuo();
                    //if (!string.IsNullOrEmpty(user_id))
                    //    error1._User_id = user_id;
                    if (!string.IsNullOrEmpty(openid) && openid != "null")
                        error1.OpenId = openid;
                    if (!string.IsNullOrEmpty(neice))
                        error1.OpenId = "内测账户-" + openid;
                    if (!string.IsNullOrEmpty(kemuId))
                        error1.KemuId = kemuId;

                    error1.CreateTime = DateTime.Now;
                    if (!string.IsNullOrEmpty(answer1))
                        error1.Answer = answer1;
                    if (!string.IsNullOrEmpty(AutoId1))
                        error1.QuestionAutoId = Convert.ToInt32(AutoId1);
                    if (!string.IsNullOrEmpty(QuestionId))
                        error1.QuestionId = QuestionId;

                    if (!string.IsNullOrEmpty(Question))
                        error1.Question = Question;
                    if (!string.IsNullOrEmpty(AnswerABC))
                        error1.AnswerABC = AnswerABC;
                    if (!string.IsNullOrEmpty(Answer))
                        error1.Answer = Answer;

                    int ret1 = -1;
                    if (!string.IsNullOrEmpty(error1.Answer) && !string.IsNullOrEmpty(AutoId1))
                    {
                        if (string.IsNullOrEmpty(error1.Question) || string.IsNullOrEmpty(error1.Answer))
                        {
                            St_TTimuDaXue st1 = BLLTable<St_TTimuDaXue>.GetRowData(St_TTimuDaXue.Attribute.AutoId, AutoId1);
                            if (st1 != null && st1.IsNotNull())
                            {
                                error1.Question = st1.Question;
                                error1.AnswerABC = st1.AnswerABC;
                                error1.Answer_old = st1.Answer;

                                if (st1.AnswerABC != error1.Answer)
                                {
                                    st1.AnswerABC = error1.Answer;
                                    BLLTable<St_TTimuDaXue>.Update(st1, St_TTimuDaXue.Attribute.AutoId);
                                }
                            }
                            r1.data.Add("St_TTimuDaXue", st1);
                        }
                        ret1 = BLLTable<St_TQuestionJiuCuo>.Insert(error1);
                        r1.data.Add("St_TQuestionJiuCuo", error1);
                    }
                    if (ret1 >= 0)
                        r1.code = 200;
                    else
                        r1.code = -1;
                    Response.Write(r1.ToJsonHeadLower());
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            Cs.Warn("83" + ex.ToString());
            if (!Directory.Exists(path1)) Directory.CreateDirectory(path1);
            Cs.Error("\r\n\r\n" + ex.ToString());
            Response.Write("{\"code\":-1,\"errMsg\":\"" + ex.ToString() + "\",\"num\":\"" + num + "\",\"errorSum\":\"" + json1 + "\",\"openid\":\"" + openid + "\"}");
        }
        //Response.ContentType = "text/plain";
        Response.Write("{\"code\":" + "200" + ",\"AutoId\":\"" + AutoId1 + "\",\"Question\":\"" + Question + "\",\"AnswerABC\":\"" + AnswerABC + "\",\"answer1\":\"" + answer1 + "\",\"num\":\"" + num + "\",\"errorSum\":\"" + json1 + "\",\"openid\":\"" + openid + "\"}");
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
/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/20 23:47:30
  Description:    数据表St_TTimuDaXue对应的业务逻辑层St_TTimuDaXue
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_TTimuDaXue_Entity:St_TTimuDaXue
 * 
************************************************************/
/************************************************************
SQL代码：
select AutoId,Analysis,Answer,Answer_yiwen,AnswerABC,Area,ChapterId,ChapterName,Difficulty,DiggDown,DiggUp,ExamType,Explain,FalseCount,Id,IsRepeatTf,KaoDian,Kemu,KemuId,Knowledge,Label,LinkExam,MediaContent,MediaHeight,MediaType,MediaWidth,OptionA,OptionB,OptionC,OptionD,OptionE,OptionF,OptionG,OptionH,Optionnum,OptionStr,OptionType,OrderId,PaperShortName,Question,QuestionId,QuestionIndex,Sc,School_id,Score,SourceFile,Sourceid,SourceZhangjie,Teacher,TrueCount,Url,User_id,WrongRate,YearId from St_TTimuDaXue
delete from St_TTimuDaXue
INSERT INTO St_TTimuDaXue (AutoId,Analysis,Answer,Answer_yiwen,AnswerABC,Area,ChapterId,ChapterName,Difficulty,DiggDown,DiggUp,ExamType,Explain,FalseCount,Id,IsRepeatTf,KaoDian,Kemu,KemuId,Knowledge,Label,LinkExam,MediaContent,MediaHeight,MediaType,MediaWidth,OptionA,OptionB,OptionC,OptionD,OptionE,OptionF,OptionG,OptionH,Optionnum,OptionStr,OptionType,OrderId,PaperShortName,Question,QuestionId,QuestionIndex,Sc,School_id,Score,SourceFile,Sourceid,SourceZhangjie,Teacher,TrueCount,Url,User_id,WrongRate,YearId)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE St_TTimuDaXue SET ...
变量赋值代码：
 *         valObj.AutoId = valObj2.AutoId;
        valObj.Analysis = valObj2.Analysis;
        valObj.Answer = valObj2.Answer;
        valObj.Answer_yiwen = valObj2.Answer_yiwen;
        valObj.AnswerABC = valObj2.AnswerABC;
        valObj.Area = valObj2.Area;
        valObj.ChapterId = valObj2.ChapterId;
        valObj.ChapterName = valObj2.ChapterName;
        valObj.Difficulty = valObj2.Difficulty;
        valObj.DiggDown = valObj2.DiggDown;
        valObj.DiggUp = valObj2.DiggUp;
        valObj.ExamType = valObj2.ExamType;
        valObj.Explain = valObj2.Explain;
        valObj.FalseCount = valObj2.FalseCount;
        valObj.Id = valObj2.Id;
        valObj.IsRepeatTf = valObj2.IsRepeatTf;
        valObj.KaoDian = valObj2.KaoDian;
        valObj.Kemu = valObj2.Kemu;
        valObj.KemuId = valObj2.KemuId;
        valObj.Knowledge = valObj2.Knowledge;
        valObj.Label = valObj2.Label;
        valObj.LinkExam = valObj2.LinkExam;
        valObj.MediaContent = valObj2.MediaContent;
        valObj.MediaHeight = valObj2.MediaHeight;
        valObj.MediaType = valObj2.MediaType;
        valObj.MediaWidth = valObj2.MediaWidth;
        valObj.OptionA = valObj2.OptionA;
        valObj.OptionB = valObj2.OptionB;
        valObj.OptionC = valObj2.OptionC;
        valObj.OptionD = valObj2.OptionD;
        valObj.OptionE = valObj2.OptionE;
        valObj.OptionF = valObj2.OptionF;
        valObj.OptionG = valObj2.OptionG;
        valObj.OptionH = valObj2.OptionH;
        valObj.Optionnum = valObj2.Optionnum;
        valObj.OptionStr = valObj2.OptionStr;
        valObj.OptionType = valObj2.OptionType;
        valObj.OrderId = valObj2.OrderId;
        valObj.PaperShortName = valObj2.PaperShortName;
        valObj.Question = valObj2.Question;
        valObj.QuestionId = valObj2.QuestionId;
        valObj.QuestionIndex = valObj2.QuestionIndex;
        valObj.Sc = valObj2.Sc;
        valObj.School_id = valObj2.School_id;
        valObj.Score = valObj2.Score;
        valObj.SourceFile = valObj2.SourceFile;
        valObj.Sourceid = valObj2.Sourceid;
        valObj.SourceZhangjie = valObj2.SourceZhangjie;
        valObj.Teacher = valObj2.Teacher;
        valObj.TrueCount = valObj2.TrueCount;
        valObj.Url = valObj2.Url;
        valObj.User_id = valObj2.User_id;
        valObj.WrongRate = valObj2.WrongRate;
        valObj.YearId = valObj2.YearId; 
        valObj.AutoId = "";
        valObj.Analysis = "";
        valObj.Answer = "";
        valObj.Answer_yiwen = "";
        valObj.AnswerABC = "";
        valObj.Area = "";
        valObj.ChapterId = "";
        valObj.ChapterName = "";
        valObj.Difficulty = "";
        valObj.DiggDown = "";
        valObj.DiggUp = "";
        valObj.ExamType = "";
        valObj.Explain = "";
        valObj.FalseCount = "";
        valObj.Id = "";
        valObj.IsRepeatTf = "";
        valObj.KaoDian = "";
        valObj.Kemu = "";
        valObj.KemuId = "";
        valObj.Knowledge = "";
        valObj.Label = "";
        valObj.LinkExam = "";
        valObj.MediaContent = "";
        valObj.MediaHeight = "";
        valObj.MediaType = "";
        valObj.MediaWidth = "";
        valObj.OptionA = "";
        valObj.OptionB = "";
        valObj.OptionC = "";
        valObj.OptionD = "";
        valObj.OptionE = "";
        valObj.OptionF = "";
        valObj.OptionG = "";
        valObj.OptionH = "";
        valObj.Optionnum = "";
        valObj.OptionStr = "";
        valObj.OptionType = "";
        valObj.OrderId = "";
        valObj.PaperShortName = "";
        valObj.Question = "";
        valObj.QuestionId = "";
        valObj.QuestionIndex = "";
        valObj.Sc = "";
        valObj.School_id = "";
        valObj.Score = "";
        valObj.SourceFile = "";
        valObj.Sourceid = "";
        valObj.SourceZhangjie = "";
        valObj.Teacher = "";
        valObj.TrueCount = "";
        valObj.Url = "";
        valObj.User_id = "";
        valObj.WrongRate = "";
        valObj.YearId = ""; 
        "AutoId": $("#txt_AutoId").val(),
        "Analysis": $("#txt_Analysis").val(),
        "Answer": $("#txt_Answer").val(),
        "Answer_yiwen": $("#txt_Answer_yiwen").val(),
        "AnswerABC": $("#txt_AnswerABC").val(),
        "Area": $("#txt_Area").val(),
        "ChapterId": $("#txt_ChapterId").val(),
        "ChapterName": $("#txt_ChapterName").val(),
        "Difficulty": $("#txt_Difficulty").val(),
        "DiggDown": $("#txt_DiggDown").val(),
        "DiggUp": $("#txt_DiggUp").val(),
        "ExamType": $("#txt_ExamType").val(),
        "Explain": $("#txt_Explain").val(),
        "FalseCount": $("#txt_FalseCount").val(),
        "Id": $("#txt_Id").val(),
        "IsRepeatTf": $("#txt_IsRepeatTf").val(),
        "KaoDian": $("#txt_KaoDian").val(),
        "Kemu": $("#txt_Kemu").val(),
        "KemuId": $("#txt_KemuId").val(),
        "Knowledge": $("#txt_Knowledge").val(),
        "Label": $("#txt_Label").val(),
        "LinkExam": $("#txt_LinkExam").val(),
        "MediaContent": $("#txt_MediaContent").val(),
        "MediaHeight": $("#txt_MediaHeight").val(),
        "MediaType": $("#txt_MediaType").val(),
        "MediaWidth": $("#txt_MediaWidth").val(),
        "OptionA": $("#txt_OptionA").val(),
        "OptionB": $("#txt_OptionB").val(),
        "OptionC": $("#txt_OptionC").val(),
        "OptionD": $("#txt_OptionD").val(),
        "OptionE": $("#txt_OptionE").val(),
        "OptionF": $("#txt_OptionF").val(),
        "OptionG": $("#txt_OptionG").val(),
        "OptionH": $("#txt_OptionH").val(),
        "Optionnum": $("#txt_Optionnum").val(),
        "OptionStr": $("#txt_OptionStr").val(),
        "OptionType": $("#txt_OptionType").val(),
        "OrderId": $("#txt_OrderId").val(),
        "PaperShortName": $("#txt_PaperShortName").val(),
        "Question": $("#txt_Question").val(),
        "QuestionId": $("#txt_QuestionId").val(),
        "QuestionIndex": $("#txt_QuestionIndex").val(),
        "Sc": $("#txt_Sc").val(),
        "School_id": $("#txt_School_id").val(),
        "Score": $("#txt_Score").val(),
        "SourceFile": $("#txt_SourceFile").val(),
        "Sourceid": $("#txt_Sourceid").val(),
        "SourceZhangjie": $("#txt_SourceZhangjie").val(),
        "Teacher": $("#txt_Teacher").val(),
        "TrueCount": $("#txt_TrueCount").val(),
        "Url": $("#txt_Url").val(),
        "User_id": $("#txt_User_id").val(),
        "WrongRate": $("#txt_WrongRate").val(),
        "YearId": $("#txt_YearId").val(), 
 * ************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using AgileFrame.Orm.PersistenceLayer.DAL.Base;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
namespace AgileFrame.Orm.PersistenceLayer.Model
{
    /// <summary>
    /// <para>大学题库:[IDField-{Id:0}]</para>
    /// <para>与St_TTimuDaXue数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_TTimuDaXue : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_TTimuDaXue Factory()
        {
            return new St_TTimuDaXue();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> 考题分析:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Analysis
        {            
            get { return this.Analysis; }
            set { this.Analysis = value; }
        }
        
        /// <summary> 答案:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Answer
        {            
            get { return this.Answer; }
            set { this.Answer = value; }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _Answer_yiwen
        {            
            get { return this.Answer_yiwen; }
            set { this.Answer_yiwen = value; }
        }
        
        /// <summary> 学生提交的纠错答案:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AnswerABC
        {            
            get { return this.AnswerABC; }
            set { this.AnswerABC = value; }
        }
        
        /// <summary> 地区:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Area
        {            
            get { return this.Area; }
            set { this.Area = value; }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ChapterId
        {            
            get { return this.ChapterId; }
            set { this.ChapterId = value; }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ChapterName
        {            
            get { return this.ChapterName; }
            set { this.ChapterName = value; }
        }
        
        /// <summary> 难易程序:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Difficulty
        {            
            get { return this.Difficulty; }
            set { this.Difficulty = value; }
        }
        
        /// <summary> 差评:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DiggDown
        {            
            get { return this.DiggDown; }
            set { this.DiggDown = value; }
        }
        
        /// <summary> 好评:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DiggUp
        {            
            get { return this.DiggUp; }
            set { this.DiggUp = value; }
        }
        
        /// <summary> 试卷类型:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ExamType
        {            
            get { return this.ExamType; }
            set { this.ExamType = value; }
        }
        
        /// <summary> 试题解析:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Explain
        {            
            get { return this.Explain; }
            set { this.Explain = value; }
        }
        
        /// <summary> 错误次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _FalseCount
        {            
            get { return this.FalseCount; }
            set { this.FalseCount = value; }
        }
        
        /// <summary> 采集编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 是否重做(0是1否):[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _IsRepeatTf
        {            
            get { return this.IsRepeatTf; }
            set { this.IsRepeatTf = value; }
        }
        
        /// <summary> 考点:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KaoDian
        {            
            get { return this.KaoDian; }
            set { this.KaoDian = value; }
        }
        
        /// <summary> 科目:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Kemu
        {            
            get { return this.Kemu; }
            set { this.Kemu = value; }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> 考点:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Knowledge
        {            
            get { return this.Knowledge; }
            set { this.Knowledge = value; }
        }
        
        /// <summary> 章节:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Label
        {            
            get { return this.Label; }
            set { this.Label = value; }
        }
        
        /// <summary> 大题题号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _LinkExam
        {            
            get { return this.LinkExam; }
            set { this.LinkExam = value; }
        }
        
        /// <summary> 媒体内容:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaContent
        {            
            get { return this.MediaContent; }
            set { this.MediaContent = value; }
        }
        
        /// <summary> 媒体高度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaHeight
        {            
            get { return this.MediaHeight; }
            set { this.MediaHeight = value; }
        }
        
        /// <summary> 媒体类型:[Enum-{0:"文字"},{1:"图片"},{2:"视频"}][CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaType
        {            
            get { return this.MediaType; }
            set { this.MediaType = value; }
        }
        
        /// <summary> 媒体宽度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MediaWidth
        {            
            get { return this.MediaWidth; }
            set { this.MediaWidth = value; }
        }
        
        /// <summary> A:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionA
        {            
            get { return this.OptionA; }
            set { this.OptionA = value; }
        }
        
        /// <summary> B:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionB
        {            
            get { return this.OptionB; }
            set { this.OptionB = value; }
        }
        
        /// <summary> C:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionC
        {            
            get { return this.OptionC; }
            set { this.OptionC = value; }
        }
        
        /// <summary> D:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionD
        {            
            get { return this.OptionD; }
            set { this.OptionD = value; }
        }
        
        /// <summary> E:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionE
        {            
            get { return this.OptionE; }
            set { this.OptionE = value; }
        }
        
        /// <summary> F:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionF
        {            
            get { return this.OptionF; }
            set { this.OptionF = value; }
        }
        
        /// <summary> G:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionG
        {            
            get { return this.OptionG; }
            set { this.OptionG = value; }
        }
        
        /// <summary> H:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OptionH
        {            
            get { return this.OptionH; }
            set { this.OptionH = value; }
        }
        
        /// <summary> 多选题答案个数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Optionnum
        {            
            get { return this.Optionnum; }
            set { this.Optionnum = value; }
        }
        
        /// <summary> 选项字符串-用竖线分隔符:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _OptionStr
        {            
            get { return this.OptionStr; }
            set { this.OptionStr = value; }
        }
        
        /// <summary> 题型-:[Enum-{0:单选},{1:多选},{2:判断},{3:简答论述},{4:不定项选择},{5:填空},{6:词汇},{7:图文题}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _OptionType
        {            
            get { return this.OptionType; }
            set { this.OptionType = value; }
        }
        
        /// <summary> 顺序号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OrderId
        {            
            get { return this.OrderId; }
            set { this.OrderId = value; }
        }
        
        /// <summary> 试卷简称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperShortName
        {            
            get { return this.PaperShortName; }
            set { this.PaperShortName = value; }
        }
        
        /// <summary> 题目:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Question
        {            
            get { return this.Question; }
            set { this.Question = value; }
        }
        
        /// <summary> 题号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _QuestionId
        {            
            get { return this.QuestionId; }
            set { this.QuestionId = value; }
        }
        
        /// <summary> 题目顺序号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _QuestionIndex
        {            
            get { return this.QuestionIndex; }
            set { this.QuestionIndex = value; }
        }
        
        /// <summary> 源大学微信号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _School_id
        {            
            get { return this.School_id; }
            set { this.School_id = value; }
        }
        
        /// <summary> 分值:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Score
        {            
            get { return this.Score; }
            set { this.Score = value; }
        }
        
        /// <summary> 源文件:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SourceFile
        {            
            get { return this.SourceFile; }
            set { this.SourceFile = value; }
        }
        
        /// <summary> 源ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sourceid
        {            
            get { return this.Sourceid; }
            set { this.Sourceid = value; }
        }
        
        /// <summary> 源章节:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SourceZhangjie
        {            
            get { return this.SourceZhangjie; }
            set { this.SourceZhangjie = value; }
        }
        
        /// <summary> 出题老师:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher
        {            
            get { return this.Teacher; }
            set { this.Teacher = value; }
        }
        
        /// <summary> 正确次数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TrueCount
        {            
            get { return this.TrueCount; }
            set { this.TrueCount = value; }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Url
        {            
            get { return this.Url; }
            set { this.Url = value; }
        }
        
        /// <summary> 用户Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 错误率:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WrongRate
        {            
            get { return this.WrongRate; }
            set { this.WrongRate = value; }
        }
        
        /// <summary> 试卷年份:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _YearId
        {            
            get { return this.YearId; }
            set { this.YearId = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int AutoId
        {
            get { return this.m_autoid; }
            set //private 
            {
                if (!autoid_initialized || m_autoid != value)
                {
                    this.m_autoid = value;
                }
                autoid_initialized = true;
            }
        }
        
        /// <summary> 考题分析:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Analysis
        {
            get { return this.m_analysis; }
            set //
            {
                if (!analysis_initialized || m_analysis != value)
                {
                    this.m_analysis = value;
                }
                analysis_initialized = true;
            }
        }
        
        /// <summary> 答案:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Answer
        {
            get { return this.m_answer; }
            set //
            {
                if (!answer_initialized || m_answer != value)
                {
                    this.m_answer = value;
                }
                answer_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}]，推荐使用 "_"符号开头 </summary>
        public string Answer_yiwen
        {
            get { return this.m_answer_yiwen; }
            set //
            {
                if (!answer_yiwen_initialized || m_answer_yiwen != value)
                {
                    this.m_answer_yiwen = value;
                }
                answer_yiwen_initialized = true;
            }
        }
        
        /// <summary> 学生提交的纠错答案:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string AnswerABC
        {
            get { return this.m_answerabc; }
            set //
            {
                if (!answerabc_initialized || m_answerabc != value)
                {
                    this.m_answerabc = value;
                }
                answerabc_initialized = true;
            }
        }
        
        /// <summary> 地区:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Area
        {
            get { return this.m_area; }
            set //
            {
                if (!area_initialized || m_area != value)
                {
                    this.m_area = value;
                }
                area_initialized = true;
            }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ChapterId
        {
            get { return this.m_chapterid; }
            set //
            {
                if (!chapterid_initialized || m_chapterid != value)
                {
                    this.m_chapterid = value;
                }
                chapterid_initialized = true;
            }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ChapterName
        {
            get { return this.m_chaptername; }
            set //
            {
                if (!chaptername_initialized || m_chaptername != value)
                {
                    this.m_chaptername = value;
                }
                chaptername_initialized = true;
            }
        }
        
        /// <summary> 难易程序:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Difficulty
        {
            get { return this.m_difficulty; }
            set //
            {
                if (!difficulty_initialized || m_difficulty != value)
                {
                    this.m_difficulty = value;
                }
                difficulty_initialized = true;
            }
        }
        
        /// <summary> 差评:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string DiggDown
        {
            get { return this.m_diggdown; }
            set //
            {
                if (!diggdown_initialized || m_diggdown != value)
                {
                    this.m_diggdown = value;
                }
                diggdown_initialized = true;
            }
        }
        
        /// <summary> 好评:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string DiggUp
        {
            get { return this.m_diggup; }
            set //
            {
                if (!diggup_initialized || m_diggup != value)
                {
                    this.m_diggup = value;
                }
                diggup_initialized = true;
            }
        }
        
        /// <summary> 试卷类型:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string ExamType
        {
            get { return this.m_examtype; }
            set //
            {
                if (!examtype_initialized || m_examtype != value)
                {
                    this.m_examtype = value;
                }
                examtype_initialized = true;
            }
        }
        
        /// <summary> 试题解析:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Explain
        {
            get { return this.m_explain; }
            set //
            {
                if (!explain_initialized || m_explain != value)
                {
                    this.m_explain = value;
                }
                explain_initialized = true;
            }
        }
        
        /// <summary> 错误次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string FalseCount
        {
            get { return this.m_falsecount; }
            set //
            {
                if (!falsecount_initialized || m_falsecount != value)
                {
                    this.m_falsecount = value;
                }
                falsecount_initialized = true;
            }
        }
        
        /// <summary> 采集编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Id
        {
            get { return this.m_id; }
            set //
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> 是否重做(0是1否):[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int IsRepeatTf
        {
            get { return this.m_isrepeattf; }
            set //
            {
                if (!isrepeattf_initialized || m_isrepeattf != value)
                {
                    this.m_isrepeattf = value;
                }
                isrepeattf_initialized = true;
            }
        }
        
        /// <summary> 考点:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string KaoDian
        {
            get { return this.m_kaodian; }
            set //
            {
                if (!kaodian_initialized || m_kaodian != value)
                {
                    this.m_kaodian = value;
                }
                kaodian_initialized = true;
            }
        }
        
        /// <summary> 科目:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Kemu
        {
            get { return this.m_kemu; }
            set //
            {
                if (!kemu_initialized || m_kemu != value)
                {
                    this.m_kemu = value;
                }
                kemu_initialized = true;
            }
        }
        
        /// <summary> 科目Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int KemuId
        {
            get { return this.m_kemuid; }
            set //
            {
                if (!kemuid_initialized || m_kemuid != value)
                {
                    this.m_kemuid = value;
                }
                kemuid_initialized = true;
            }
        }
        
        /// <summary> 考点:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Knowledge
        {
            get { return this.m_knowledge; }
            set //
            {
                if (!knowledge_initialized || m_knowledge != value)
                {
                    this.m_knowledge = value;
                }
                knowledge_initialized = true;
            }
        }
        
        /// <summary> 章节:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Label
        {
            get { return this.m_label; }
            set //
            {
                if (!label_initialized || m_label != value)
                {
                    this.m_label = value;
                }
                label_initialized = true;
            }
        }
        
        /// <summary> 大题题号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string LinkExam
        {
            get { return this.m_linkexam; }
            set //
            {
                if (!linkexam_initialized || m_linkexam != value)
                {
                    this.m_linkexam = value;
                }
                linkexam_initialized = true;
            }
        }
        
        /// <summary> 媒体内容:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MediaContent
        {
            get { return this.m_mediacontent; }
            set //
            {
                if (!mediacontent_initialized || m_mediacontent != value)
                {
                    this.m_mediacontent = value;
                }
                mediacontent_initialized = true;
            }
        }
        
        /// <summary> 媒体高度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MediaHeight
        {
            get { return this.m_mediaheight; }
            set //
            {
                if (!mediaheight_initialized || m_mediaheight != value)
                {
                    this.m_mediaheight = value;
                }
                mediaheight_initialized = true;
            }
        }
        
        /// <summary> 媒体类型:[Enum-{0:"文字"},{1:"图片"},{2:"视频"}][CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MediaType
        {
            get { return this.m_mediatype; }
            set //
            {
                if (!mediatype_initialized || m_mediatype != value)
                {
                    this.m_mediatype = value;
                }
                mediatype_initialized = true;
            }
        }
        
        /// <summary> 媒体宽度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string MediaWidth
        {
            get { return this.m_mediawidth; }
            set //
            {
                if (!mediawidth_initialized || m_mediawidth != value)
                {
                    this.m_mediawidth = value;
                }
                mediawidth_initialized = true;
            }
        }
        
        /// <summary> A:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionA
        {
            get { return this.m_optiona; }
            set //
            {
                if (!optiona_initialized || m_optiona != value)
                {
                    this.m_optiona = value;
                }
                optiona_initialized = true;
            }
        }
        
        /// <summary> B:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionB
        {
            get { return this.m_optionb; }
            set //
            {
                if (!optionb_initialized || m_optionb != value)
                {
                    this.m_optionb = value;
                }
                optionb_initialized = true;
            }
        }
        
        /// <summary> C:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionC
        {
            get { return this.m_optionc; }
            set //
            {
                if (!optionc_initialized || m_optionc != value)
                {
                    this.m_optionc = value;
                }
                optionc_initialized = true;
            }
        }
        
        /// <summary> D:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionD
        {
            get { return this.m_optiond; }
            set //
            {
                if (!optiond_initialized || m_optiond != value)
                {
                    this.m_optiond = value;
                }
                optiond_initialized = true;
            }
        }
        
        /// <summary> E:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionE
        {
            get { return this.m_optione; }
            set //
            {
                if (!optione_initialized || m_optione != value)
                {
                    this.m_optione = value;
                }
                optione_initialized = true;
            }
        }
        
        /// <summary> F:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionF
        {
            get { return this.m_optionf; }
            set //
            {
                if (!optionf_initialized || m_optionf != value)
                {
                    this.m_optionf = value;
                }
                optionf_initialized = true;
            }
        }
        
        /// <summary> G:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionG
        {
            get { return this.m_optiong; }
            set //
            {
                if (!optiong_initialized || m_optiong != value)
                {
                    this.m_optiong = value;
                }
                optiong_initialized = true;
            }
        }
        
        /// <summary> H:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OptionH
        {
            get { return this.m_optionh; }
            set //
            {
                if (!optionh_initialized || m_optionh != value)
                {
                    this.m_optionh = value;
                }
                optionh_initialized = true;
            }
        }
        
        /// <summary> 多选题答案个数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Optionnum
        {
            get { return this.m_optionnum; }
            set //
            {
                if (!optionnum_initialized || m_optionnum != value)
                {
                    this.m_optionnum = value;
                }
                optionnum_initialized = true;
            }
        }
        
        /// <summary> 选项字符串-用竖线分隔符:[CtrlTypeDic-{HTML}]，推荐使用 "_"符号开头 </summary>
        public string OptionStr
        {
            get { return this.m_optionstr; }
            set //
            {
                if (!optionstr_initialized || m_optionstr != value)
                {
                    this.m_optionstr = value;
                }
                optionstr_initialized = true;
            }
        }
        
        /// <summary> 题型-:[Enum-{0:单选},{1:多选},{2:判断},{3:简答论述},{4:不定项选择},{5:填空},{6:词汇},{7:图文题}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public string OptionType
        {
            get { return this.m_optiontype; }
            set //
            {
                if (!optiontype_initialized || m_optiontype != value)
                {
                    this.m_optiontype = value;
                }
                optiontype_initialized = true;
            }
        }
        
        /// <summary> 顺序号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string OrderId
        {
            get { return this.m_orderid; }
            set //
            {
                if (!orderid_initialized || m_orderid != value)
                {
                    this.m_orderid = value;
                }
                orderid_initialized = true;
            }
        }
        
        /// <summary> 试卷简称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string PaperShortName
        {
            get { return this.m_papershortname; }
            set //
            {
                if (!papershortname_initialized || m_papershortname != value)
                {
                    this.m_papershortname = value;
                }
                papershortname_initialized = true;
            }
        }
        
        /// <summary> 题目:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Question
        {
            get { return this.m_question; }
            set //
            {
                if (!question_initialized || m_question != value)
                {
                    this.m_question = value;
                }
                question_initialized = true;
            }
        }
        
        /// <summary> 题号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int QuestionId
        {
            get { return this.m_questionid; }
            set //
            {
                if (!questionid_initialized || m_questionid != value)
                {
                    this.m_questionid = value;
                }
                questionid_initialized = true;
            }
        }
        
        /// <summary> 题目顺序号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int QuestionIndex
        {
            get { return this.m_questionindex; }
            set //
            {
                if (!questionindex_initialized || m_questionindex != value)
                {
                    this.m_questionindex = value;
                }
                questionindex_initialized = true;
            }
        }
        
        /// <summary> 源大学微信号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sc
        {
            get { return this.m_sc; }
            set //
            {
                if (!sc_initialized || m_sc != value)
                {
                    this.m_sc = value;
                }
                sc_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int School_id
        {
            get { return this.m_school_id; }
            set //
            {
                if (!school_id_initialized || m_school_id != value)
                {
                    this.m_school_id = value;
                }
                school_id_initialized = true;
            }
        }
        
        /// <summary> 分值:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Score
        {
            get { return this.m_score; }
            set //
            {
                if (!score_initialized || m_score != value)
                {
                    this.m_score = value;
                }
                score_initialized = true;
            }
        }
        
        /// <summary> 源文件:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SourceFile
        {
            get { return this.m_sourcefile; }
            set //
            {
                if (!sourcefile_initialized || m_sourcefile != value)
                {
                    this.m_sourcefile = value;
                }
                sourcefile_initialized = true;
            }
        }
        
        /// <summary> 源ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sourceid
        {
            get { return this.m_sourceid; }
            set //
            {
                if (!sourceid_initialized || m_sourceid != value)
                {
                    this.m_sourceid = value;
                }
                sourceid_initialized = true;
            }
        }
        
        /// <summary> 源章节:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string SourceZhangjie
        {
            get { return this.m_sourcezhangjie; }
            set //
            {
                if (!sourcezhangjie_initialized || m_sourcezhangjie != value)
                {
                    this.m_sourcezhangjie = value;
                }
                sourcezhangjie_initialized = true;
            }
        }
        
        /// <summary> 出题老师:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Teacher
        {
            get { return this.m_teacher; }
            set //
            {
                if (!teacher_initialized || m_teacher != value)
                {
                    this.m_teacher = value;
                }
                teacher_initialized = true;
            }
        }
        
        /// <summary> 正确次数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string TrueCount
        {
            get { return this.m_truecount; }
            set //
            {
                if (!truecount_initialized || m_truecount != value)
                {
                    this.m_truecount = value;
                }
                truecount_initialized = true;
            }
        }
        
        /// <summary> 链接地址:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Url
        {
            get { return this.m_url; }
            set //
            {
                if (!url_initialized || m_url != value)
                {
                    this.m_url = value;
                }
                url_initialized = true;
            }
        }
        
        /// <summary> 用户Id:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string User_id
        {
            get { return this.m_user_id; }
            set //
            {
                if (!user_id_initialized || m_user_id != value)
                {
                    this.m_user_id = value;
                }
                user_id_initialized = true;
            }
        }
        
        /// <summary> 错误率:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string WrongRate
        {
            get { return this.m_wrongrate; }
            set //
            {
                if (!wrongrate_initialized || m_wrongrate != value)
                {
                    this.m_wrongrate = value;
                }
                wrongrate_initialized = true;
            }
        }
        
        /// <summary> 试卷年份:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string YearId
        {
            get { return this.m_yearid; }
            set //
            {
                if (!yearid_initialized || m_yearid != value)
                {
                    this.m_yearid = value;
                }
                yearid_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AutoId =  new AttributeItem("[St_TTimuDaXue].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>考题分析:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Analysis =  new AttributeItem("[St_TTimuDaXue].[Analysis]", typeof(string), 50, default(string));
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Answer =  new AttributeItem("[St_TTimuDaXue].[Answer]", typeof(string), -1, default(string));
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem Answer_yiwen =  new AttributeItem("[St_TTimuDaXue].[Answer_yiwen]", typeof(string), 300, default(string));
            
            /// <summary>学生提交的纠错答案:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AnswerABC =  new AttributeItem("[St_TTimuDaXue].[AnswerABC]", typeof(string), 50, default(string));
            
            /// <summary>地区:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Area =  new AttributeItem("[St_TTimuDaXue].[Area]", typeof(string), 50, default(string));
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ChapterId =  new AttributeItem("[St_TTimuDaXue].[ChapterId]", typeof(string), 30, default(string));
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ChapterName =  new AttributeItem("[St_TTimuDaXue].[ChapterName]", typeof(string), 100, default(string));
            
            /// <summary>难易程序:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Difficulty =  new AttributeItem("[St_TTimuDaXue].[Difficulty]", typeof(string), 200, default(string));
            
            /// <summary>差评:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DiggDown =  new AttributeItem("[St_TTimuDaXue].[DiggDown]", typeof(string), 50, default(string));
            
            /// <summary>好评:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DiggUp =  new AttributeItem("[St_TTimuDaXue].[DiggUp]", typeof(string), 50, default(string));
            
            /// <summary>试卷类型:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ExamType =  new AttributeItem("[St_TTimuDaXue].[ExamType]", typeof(string), 50, default(string));
            
            /// <summary>试题解析:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Explain =  new AttributeItem("[St_TTimuDaXue].[Explain]", typeof(string), 2000, default(string));
            
            /// <summary>错误次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem FalseCount =  new AttributeItem("[St_TTimuDaXue].[FalseCount]", typeof(string), 200, default(string));
            
            /// <summary>采集编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_TTimuDaXue].[Id]", typeof(int), 4, default(int));
            
            /// <summary>是否重做(0是1否):[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsRepeatTf =  new AttributeItem("[St_TTimuDaXue].[IsRepeatTf]", typeof(int), 4, default(int));
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KaoDian =  new AttributeItem("[St_TTimuDaXue].[KaoDian]", typeof(string), 200, default(string));
            
            /// <summary>科目:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu =  new AttributeItem("[St_TTimuDaXue].[Kemu]", typeof(string), 200, default(string));
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[St_TTimuDaXue].[KemuId]", typeof(int), 4, default(int));
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Knowledge =  new AttributeItem("[St_TTimuDaXue].[Knowledge]", typeof(string), 50, default(string));
            
            /// <summary>章节:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Label =  new AttributeItem("[St_TTimuDaXue].[Label]", typeof(string), 100, default(string));
            
            /// <summary>大题题号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem LinkExam =  new AttributeItem("[St_TTimuDaXue].[LinkExam]", typeof(string), 50, default(string));
            
            /// <summary>媒体内容:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaContent =  new AttributeItem("[St_TTimuDaXue].[MediaContent]", typeof(string), 200, default(string));
            
            /// <summary>媒体高度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaHeight =  new AttributeItem("[St_TTimuDaXue].[MediaHeight]", typeof(string), 100, default(string));
            
            /// <summary>媒体类型:[Enum-{0:"文字"},{1:"图片"},{2:"视频"}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaType =  new AttributeItem("[St_TTimuDaXue].[MediaType]", typeof(string), 200, default(string));
            
            /// <summary>媒体宽度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MediaWidth =  new AttributeItem("[St_TTimuDaXue].[MediaWidth]", typeof(string), 200, default(string));
            
            /// <summary>A:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionA =  new AttributeItem("[St_TTimuDaXue].[OptionA]", typeof(string), 200, default(string));
            
            /// <summary>B:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionB =  new AttributeItem("[St_TTimuDaXue].[OptionB]", typeof(string), 200, default(string));
            
            /// <summary>C:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionC =  new AttributeItem("[St_TTimuDaXue].[OptionC]", typeof(string), 200, default(string));
            
            /// <summary>D:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionD =  new AttributeItem("[St_TTimuDaXue].[OptionD]", typeof(string), 200, default(string));
            
            /// <summary>E:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionE =  new AttributeItem("[St_TTimuDaXue].[OptionE]", typeof(string), 200, default(string));
            
            /// <summary>F:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionF =  new AttributeItem("[St_TTimuDaXue].[OptionF]", typeof(string), 200, default(string));
            
            /// <summary>G:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionG =  new AttributeItem("[St_TTimuDaXue].[OptionG]", typeof(string), 200, default(string));
            
            /// <summary>H:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OptionH =  new AttributeItem("[St_TTimuDaXue].[OptionH]", typeof(string), 200, default(string));
            
            /// <summary>多选题答案个数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Optionnum =  new AttributeItem("[St_TTimuDaXue].[Optionnum]", typeof(string), 200, default(string));
            
            /// <summary>选项字符串-用竖线分隔符:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem OptionStr =  new AttributeItem("[St_TTimuDaXue].[OptionStr]", typeof(string), 3000, default(string));
            
            /// <summary>题型-:[Enum-{0:单选},{1:多选},{2:判断},{3:简答论述},{4:不定项选择},{5:填空},{6:词汇},{7:图文题}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem OptionType =  new AttributeItem("[St_TTimuDaXue].[OptionType]", typeof(string), 20, default(string));
            
            /// <summary>顺序号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OrderId =  new AttributeItem("[St_TTimuDaXue].[OrderId]", typeof(string), 50, default(string));
            
            /// <summary>试卷简称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperShortName =  new AttributeItem("[St_TTimuDaXue].[PaperShortName]", typeof(string), 50, default(string));
            
            /// <summary>题目:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Question =  new AttributeItem("[St_TTimuDaXue].[Question]", typeof(string), -1, default(string));
            
            /// <summary>题号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionId =  new AttributeItem("[St_TTimuDaXue].[QuestionId]", typeof(int), 4, default(int));
            
            /// <summary>题目顺序号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QuestionIndex =  new AttributeItem("[St_TTimuDaXue].[QuestionIndex]", typeof(int), 4, default(int));
            
            /// <summary>源大学微信号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[St_TTimuDaXue].[Sc]", typeof(string), 20, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_id =  new AttributeItem("[St_TTimuDaXue].[School_id]", typeof(int), 4, default(int));
            
            /// <summary>分值:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score =  new AttributeItem("[St_TTimuDaXue].[Score]", typeof(string), 10, default(string));
            
            /// <summary>源文件:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SourceFile =  new AttributeItem("[St_TTimuDaXue].[SourceFile]", typeof(string), 200, default(string));
            
            /// <summary>源ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sourceid =  new AttributeItem("[St_TTimuDaXue].[Sourceid]", typeof(string), 200, default(string));
            
            /// <summary>源章节:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SourceZhangjie =  new AttributeItem("[St_TTimuDaXue].[SourceZhangjie]", typeof(string), 200, default(string));
            
            /// <summary>出题老师:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher =  new AttributeItem("[St_TTimuDaXue].[Teacher]", typeof(string), 50, default(string));
            
            /// <summary>正确次数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TrueCount =  new AttributeItem("[St_TTimuDaXue].[TrueCount]", typeof(string), 200, default(string));
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Url =  new AttributeItem("[St_TTimuDaXue].[Url]", typeof(string), 200, default(string));
            
            /// <summary>用户Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[St_TTimuDaXue].[User_id]", typeof(string), 36, default(string));
            
            /// <summary>错误率:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WrongRate =  new AttributeItem("[St_TTimuDaXue].[WrongRate]", typeof(string), 200, default(string));
            
            /// <summary>试卷年份:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem YearId =  new AttributeItem("[St_TTimuDaXue].[YearId]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private string m_analysis;
        /// <summary></summary>
        protected bool analysis_initialized = false;
        
        private string m_answer;
        /// <summary></summary>
        protected bool answer_initialized = false;
        
        private string m_answer_yiwen;
        /// <summary></summary>
        protected bool answer_yiwen_initialized = false;
        
        private string m_answerabc;
        /// <summary></summary>
        protected bool answerabc_initialized = false;
        
        private string m_area;
        /// <summary></summary>
        protected bool area_initialized = false;
        
        private string m_chapterid;
        /// <summary></summary>
        protected bool chapterid_initialized = false;
        
        private string m_chaptername;
        /// <summary></summary>
        protected bool chaptername_initialized = false;
        
        private string m_difficulty;
        /// <summary></summary>
        protected bool difficulty_initialized = false;
        
        private string m_diggdown;
        /// <summary></summary>
        protected bool diggdown_initialized = false;
        
        private string m_diggup;
        /// <summary></summary>
        protected bool diggup_initialized = false;
        
        private string m_examtype;
        /// <summary></summary>
        protected bool examtype_initialized = false;
        
        private string m_explain;
        /// <summary></summary>
        protected bool explain_initialized = false;
        
        private string m_falsecount;
        /// <summary></summary>
        protected bool falsecount_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_isrepeattf;
        /// <summary></summary>
        protected bool isrepeattf_initialized = false;
        
        private string m_kaodian;
        /// <summary></summary>
        protected bool kaodian_initialized = false;
        
        private string m_kemu;
        /// <summary></summary>
        protected bool kemu_initialized = false;
        
        private int m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_knowledge;
        /// <summary></summary>
        protected bool knowledge_initialized = false;
        
        private string m_label;
        /// <summary></summary>
        protected bool label_initialized = false;
        
        private string m_linkexam;
        /// <summary></summary>
        protected bool linkexam_initialized = false;
        
        private string m_mediacontent;
        /// <summary></summary>
        protected bool mediacontent_initialized = false;
        
        private string m_mediaheight;
        /// <summary></summary>
        protected bool mediaheight_initialized = false;
        
        private string m_mediatype;
        /// <summary></summary>
        protected bool mediatype_initialized = false;
        
        private string m_mediawidth;
        /// <summary></summary>
        protected bool mediawidth_initialized = false;
        
        private string m_optiona;
        /// <summary></summary>
        protected bool optiona_initialized = false;
        
        private string m_optionb;
        /// <summary></summary>
        protected bool optionb_initialized = false;
        
        private string m_optionc;
        /// <summary></summary>
        protected bool optionc_initialized = false;
        
        private string m_optiond;
        /// <summary></summary>
        protected bool optiond_initialized = false;
        
        private string m_optione;
        /// <summary></summary>
        protected bool optione_initialized = false;
        
        private string m_optionf;
        /// <summary></summary>
        protected bool optionf_initialized = false;
        
        private string m_optiong;
        /// <summary></summary>
        protected bool optiong_initialized = false;
        
        private string m_optionh;
        /// <summary></summary>
        protected bool optionh_initialized = false;
        
        private string m_optionnum;
        /// <summary></summary>
        protected bool optionnum_initialized = false;
        
        private string m_optionstr;
        /// <summary></summary>
        protected bool optionstr_initialized = false;
        
        private string m_optiontype;
        /// <summary></summary>
        protected bool optiontype_initialized = false;
        
        private string m_orderid;
        /// <summary></summary>
        protected bool orderid_initialized = false;
        
        private string m_papershortname;
        /// <summary></summary>
        protected bool papershortname_initialized = false;
        
        private string m_question;
        /// <summary></summary>
        protected bool question_initialized = false;
        
        private int m_questionid;
        /// <summary></summary>
        protected bool questionid_initialized = false;
        
        private int m_questionindex;
        /// <summary></summary>
        protected bool questionindex_initialized = false;
        
        private string m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private int m_school_id;
        /// <summary></summary>
        protected bool school_id_initialized = false;
        
        private string m_score;
        /// <summary></summary>
        protected bool score_initialized = false;
        
        private string m_sourcefile;
        /// <summary></summary>
        protected bool sourcefile_initialized = false;
        
        private string m_sourceid;
        /// <summary></summary>
        protected bool sourceid_initialized = false;
        
        private string m_sourcezhangjie;
        /// <summary></summary>
        protected bool sourcezhangjie_initialized = false;
        
        private string m_teacher;
        /// <summary></summary>
        protected bool teacher_initialized = false;
        
        private string m_truecount;
        /// <summary></summary>
        protected bool truecount_initialized = false;
        
        private string m_url;
        /// <summary></summary>
        protected bool url_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_wrongrate;
        /// <summary></summary>
        protected bool wrongrate_initialized = false;
        
        private string m_yearid;
        /// <summary></summary>
        protected bool yearid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TTimuDaXue";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.autoid_initialized = IsLoadAllAttributes;this.analysis_initialized = IsLoadAllAttributes;this.answer_initialized = IsLoadAllAttributes;this.answer_yiwen_initialized = IsLoadAllAttributes;this.answerabc_initialized = IsLoadAllAttributes;this.area_initialized = IsLoadAllAttributes;this.chapterid_initialized = IsLoadAllAttributes;this.chaptername_initialized = IsLoadAllAttributes;this.difficulty_initialized = IsLoadAllAttributes;this.diggdown_initialized = IsLoadAllAttributes;this.diggup_initialized = IsLoadAllAttributes;this.examtype_initialized = IsLoadAllAttributes;this.explain_initialized = IsLoadAllAttributes;this.falsecount_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.isrepeattf_initialized = IsLoadAllAttributes;this.kaodian_initialized = IsLoadAllAttributes;this.kemu_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.knowledge_initialized = IsLoadAllAttributes;this.label_initialized = IsLoadAllAttributes;this.linkexam_initialized = IsLoadAllAttributes;this.mediacontent_initialized = IsLoadAllAttributes;this.mediaheight_initialized = IsLoadAllAttributes;this.mediatype_initialized = IsLoadAllAttributes;this.mediawidth_initialized = IsLoadAllAttributes;this.optiona_initialized = IsLoadAllAttributes;this.optionb_initialized = IsLoadAllAttributes;this.optionc_initialized = IsLoadAllAttributes;this.optiond_initialized = IsLoadAllAttributes;this.optione_initialized = IsLoadAllAttributes;this.optionf_initialized = IsLoadAllAttributes;this.optiong_initialized = IsLoadAllAttributes;this.optionh_initialized = IsLoadAllAttributes;this.optionnum_initialized = IsLoadAllAttributes;this.optionstr_initialized = IsLoadAllAttributes;this.optiontype_initialized = IsLoadAllAttributes;this.orderid_initialized = IsLoadAllAttributes;this.papershortname_initialized = IsLoadAllAttributes;this.question_initialized = IsLoadAllAttributes;this.questionid_initialized = IsLoadAllAttributes;this.questionindex_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.school_id_initialized = IsLoadAllAttributes;this.score_initialized = IsLoadAllAttributes;this.sourcefile_initialized = IsLoadAllAttributes;this.sourceid_initialized = IsLoadAllAttributes;this.sourcezhangjie_initialized = IsLoadAllAttributes;this.teacher_initialized = IsLoadAllAttributes;this.truecount_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.wrongrate_initialized = IsLoadAllAttributes;this.yearid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TTimuDaXue value = new St_TTimuDaXue();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Analysis"))
				value.analysis_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Answer"))
				value.answer_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Answer_yiwen"))
				value.answer_yiwen_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AnswerABC"))
				value.answerabc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Area"))
				value.area_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ChapterId"))
				value.chapterid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ChapterName"))
				value.chaptername_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Difficulty"))
				value.difficulty_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DiggDown"))
				value.diggdown_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DiggUp"))
				value.diggup_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ExamType"))
				value.examtype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Explain"))
				value.explain_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"FalseCount"))
				value.falsecount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsRepeatTf"))
				value.isrepeattf_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KaoDian"))
				value.kaodian_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu"))
				value.kemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Knowledge"))
				value.knowledge_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Label"))
				value.label_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"LinkExam"))
				value.linkexam_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MediaContent"))
				value.mediacontent_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MediaHeight"))
				value.mediaheight_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MediaType"))
				value.mediatype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MediaWidth"))
				value.mediawidth_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionA"))
				value.optiona_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionB"))
				value.optionb_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionC"))
				value.optionc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionD"))
				value.optiond_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionE"))
				value.optione_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionF"))
				value.optionf_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionG"))
				value.optiong_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionH"))
				value.optionh_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Optionnum"))
				value.optionnum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionStr"))
				value.optionstr_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OptionType"))
				value.optiontype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OrderId"))
				value.orderid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperShortName"))
				value.papershortname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Question"))
				value.question_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionId"))
				value.questionid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QuestionIndex"))
				value.questionindex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_id"))
				value.school_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score"))
				value.score_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SourceFile"))
				value.sourcefile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sourceid"))
				value.sourceid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SourceZhangjie"))
				value.sourcezhangjie_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher"))
				value.teacher_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TrueCount"))
				value.truecount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Url"))
				value.url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WrongRate"))
				value.wrongrate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"YearId"))
				value.yearid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_TTimuDaXue Clone()
        {
            return (St_TTimuDaXue)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_TTimuDaXue()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_TTimuDaXue() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_TTimuDaXue(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_TTimuDaXue(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_TTimuDaXue(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_TTimuDaXue(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_TTimuDaXue(int autoid1, string analysis1, string answer1, string answer_yiwen1, string answerabc1, string area1, string chapterid1, string chaptername1, string difficulty1, string diggdown1, string diggup1, string examtype1, string explain1, string falsecount1, int id1, int isrepeattf1, string kaodian1, string kemu1, int kemuid1, string knowledge1, string label1, string linkexam1, string mediacontent1, string mediaheight1, string mediatype1, string mediawidth1, string optiona1, string optionb1, string optionc1, string optiond1, string optione1, string optionf1, string optiong1, string optionh1, string optionnum1, string optionstr1, string optiontype1, string orderid1, string papershortname1, string question1, int questionid1, int questionindex1, string sc1, int school_id1, string score1, string sourcefile1, string sourceid1, string sourcezhangjie1, string teacher1, string truecount1, string url1, string user_id1, string wrongrate1, string yearid1)
        {
            
            this.AutoId = autoid1;
            
            this.Analysis = analysis1;
            
            this.Answer = answer1;
            
            this.Answer_yiwen = answer_yiwen1;
            
            this.AnswerABC = answerabc1;
            
            this.Area = area1;
            
            this.ChapterId = chapterid1;
            
            this.ChapterName = chaptername1;
            
            this.Difficulty = difficulty1;
            
            this.DiggDown = diggdown1;
            
            this.DiggUp = diggup1;
            
            this.ExamType = examtype1;
            
            this.Explain = explain1;
            
            this.FalseCount = falsecount1;
            
            this.Id = id1;
            
            this.IsRepeatTf = isrepeattf1;
            
            this.KaoDian = kaodian1;
            
            this.Kemu = kemu1;
            
            this.KemuId = kemuid1;
            
            this.Knowledge = knowledge1;
            
            this.Label = label1;
            
            this.LinkExam = linkexam1;
            
            this.MediaContent = mediacontent1;
            
            this.MediaHeight = mediaheight1;
            
            this.MediaType = mediatype1;
            
            this.MediaWidth = mediawidth1;
            
            this.OptionA = optiona1;
            
            this.OptionB = optionb1;
            
            this.OptionC = optionc1;
            
            this.OptionD = optiond1;
            
            this.OptionE = optione1;
            
            this.OptionF = optionf1;
            
            this.OptionG = optiong1;
            
            this.OptionH = optionh1;
            
            this.Optionnum = optionnum1;
            
            this.OptionStr = optionstr1;
            
            this.OptionType = optiontype1;
            
            this.OrderId = orderid1;
            
            this.PaperShortName = papershortname1;
            
            this.Question = question1;
            
            this.QuestionId = questionid1;
            
            this.QuestionIndex = questionindex1;
            
            this.Sc = sc1;
            
            this.School_id = school_id1;
            
            this.Score = score1;
            
            this.SourceFile = sourcefile1;
            
            this.Sourceid = sourceid1;
            
            this.SourceZhangjie = sourcezhangjie1;
            
            this.Teacher = teacher1;
            
            this.TrueCount = truecount1;
            
            this.Url = url1;
            
            this.User_id = user_id1;
            
            this.WrongRate = wrongrate1;
            
            this.YearId = yearid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_TTimuDaXue FromIView(IView view)
        {
            return (St_TTimuDaXue)IView.GetITable(view, "St_TTimuDaXue");
        }
        /// <summary>获得一个实例  </summary>
        public static St_TTimuDaXue GetOneInstance()
        {
            St_TTimuDaXue value = new St_TTimuDaXue();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_TTimuDaXue Retrieve()
        {
            BLLTable<St_TTimuDaXue>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        return AutoId;
			    			
			    case "Analysis":
			        return Analysis;
			    			
			    case "Answer":
			        return Answer;
			    			
			    case "Answer_yiwen":
			        return Answer_yiwen;
			    			
			    case "AnswerABC":
			        return AnswerABC;
			    			
			    case "Area":
			        return Area;
			    			
			    case "ChapterId":
			        return ChapterId;
			    			
			    case "ChapterName":
			        return ChapterName;
			    			
			    case "Difficulty":
			        return Difficulty;
			    			
			    case "DiggDown":
			        return DiggDown;
			    			
			    case "DiggUp":
			        return DiggUp;
			    			
			    case "ExamType":
			        return ExamType;
			    			
			    case "Explain":
			        return Explain;
			    			
			    case "FalseCount":
			        return FalseCount;
			    			
			    case "Id":
			        return Id;
			    			
			    case "IsRepeatTf":
			        return IsRepeatTf;
			    			
			    case "KaoDian":
			        return KaoDian;
			    			
			    case "Kemu":
			        return Kemu;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "Knowledge":
			        return Knowledge;
			    			
			    case "Label":
			        return Label;
			    			
			    case "LinkExam":
			        return LinkExam;
			    			
			    case "MediaContent":
			        return MediaContent;
			    			
			    case "MediaHeight":
			        return MediaHeight;
			    			
			    case "MediaType":
			        return MediaType;
			    			
			    case "MediaWidth":
			        return MediaWidth;
			    			
			    case "OptionA":
			        return OptionA;
			    			
			    case "OptionB":
			        return OptionB;
			    			
			    case "OptionC":
			        return OptionC;
			    			
			    case "OptionD":
			        return OptionD;
			    			
			    case "OptionE":
			        return OptionE;
			    			
			    case "OptionF":
			        return OptionF;
			    			
			    case "OptionG":
			        return OptionG;
			    			
			    case "OptionH":
			        return OptionH;
			    			
			    case "Optionnum":
			        return Optionnum;
			    			
			    case "OptionStr":
			        return OptionStr;
			    			
			    case "OptionType":
			        return OptionType;
			    			
			    case "OrderId":
			        return OrderId;
			    			
			    case "PaperShortName":
			        return PaperShortName;
			    			
			    case "Question":
			        return Question;
			    			
			    case "QuestionId":
			        return QuestionId;
			    			
			    case "QuestionIndex":
			        return QuestionIndex;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "School_id":
			        return School_id;
			    			
			    case "Score":
			        return Score;
			    			
			    case "SourceFile":
			        return SourceFile;
			    			
			    case "Sourceid":
			        return Sourceid;
			    			
			    case "SourceZhangjie":
			        return SourceZhangjie;
			    			
			    case "Teacher":
			        return Teacher;
			    			
			    case "TrueCount":
			        return TrueCount;
			    			
			    case "Url":
			        return Url;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "WrongRate":
			        return WrongRate;
			    			
			    case "YearId":
			        return YearId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        this.AutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Analysis":
			        this.Analysis = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Answer":
			        this.Answer = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Answer_yiwen":
			        this.Answer_yiwen = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "AnswerABC":
			        this.AnswerABC = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Area":
			        this.Area = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ChapterId":
			        this.ChapterId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ChapterName":
			        this.ChapterName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Difficulty":
			        this.Difficulty = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DiggDown":
			        this.DiggDown = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DiggUp":
			        this.DiggUp = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ExamType":
			        this.ExamType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Explain":
			        this.Explain = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "FalseCount":
			        this.FalseCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "IsRepeatTf":
			        this.IsRepeatTf = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "KaoDian":
			        this.KaoDian = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Kemu":
			        this.Kemu = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Knowledge":
			        this.Knowledge = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Label":
			        this.Label = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "LinkExam":
			        this.LinkExam = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MediaContent":
			        this.MediaContent = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MediaHeight":
			        this.MediaHeight = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MediaType":
			        this.MediaType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MediaWidth":
			        this.MediaWidth = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionA":
			        this.OptionA = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionB":
			        this.OptionB = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionC":
			        this.OptionC = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionD":
			        this.OptionD = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionE":
			        this.OptionE = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionF":
			        this.OptionF = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionG":
			        this.OptionG = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionH":
			        this.OptionH = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Optionnum":
			        this.Optionnum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionStr":
			        this.OptionStr = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OptionType":
			        this.OptionType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OrderId":
			        this.OrderId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperShortName":
			        this.PaperShortName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Question":
			        this.Question = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QuestionId":
			        this.QuestionId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "QuestionIndex":
			        this.QuestionIndex = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "School_id":
			        this.School_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Score":
			        this.Score = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SourceFile":
			        this.SourceFile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sourceid":
			        this.Sourceid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SourceZhangjie":
			        this.SourceZhangjie = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher":
			        this.Teacher = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TrueCount":
			        this.TrueCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Url":
			        this.Url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WrongRate":
			        this.WrongRate = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "YearId":
			        this.YearId = Convert.ToString(AttributeValue);
                    return true;
			
                default:
                    return base.SetValue(AttributeName, AttributeValue);
			}
        }
        
        /// <summary>通过属性 获取该字段是否已被初始化</summary>
        public override bool GetInitialized(AttributeItem AttributeName)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					return autoid_initialized;
				
				case "Analysis":
					return analysis_initialized;
				
				case "Answer":
					return answer_initialized;
				
				case "Answer_yiwen":
					return answer_yiwen_initialized;
				
				case "AnswerABC":
					return answerabc_initialized;
				
				case "Area":
					return area_initialized;
				
				case "ChapterId":
					return chapterid_initialized;
				
				case "ChapterName":
					return chaptername_initialized;
				
				case "Difficulty":
					return difficulty_initialized;
				
				case "DiggDown":
					return diggdown_initialized;
				
				case "DiggUp":
					return diggup_initialized;
				
				case "ExamType":
					return examtype_initialized;
				
				case "Explain":
					return explain_initialized;
				
				case "FalseCount":
					return falsecount_initialized;
				
				case "Id":
					return id_initialized;
				
				case "IsRepeatTf":
					return isrepeattf_initialized;
				
				case "KaoDian":
					return kaodian_initialized;
				
				case "Kemu":
					return kemu_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "Knowledge":
					return knowledge_initialized;
				
				case "Label":
					return label_initialized;
				
				case "LinkExam":
					return linkexam_initialized;
				
				case "MediaContent":
					return mediacontent_initialized;
				
				case "MediaHeight":
					return mediaheight_initialized;
				
				case "MediaType":
					return mediatype_initialized;
				
				case "MediaWidth":
					return mediawidth_initialized;
				
				case "OptionA":
					return optiona_initialized;
				
				case "OptionB":
					return optionb_initialized;
				
				case "OptionC":
					return optionc_initialized;
				
				case "OptionD":
					return optiond_initialized;
				
				case "OptionE":
					return optione_initialized;
				
				case "OptionF":
					return optionf_initialized;
				
				case "OptionG":
					return optiong_initialized;
				
				case "OptionH":
					return optionh_initialized;
				
				case "Optionnum":
					return optionnum_initialized;
				
				case "OptionStr":
					return optionstr_initialized;
				
				case "OptionType":
					return optiontype_initialized;
				
				case "OrderId":
					return orderid_initialized;
				
				case "PaperShortName":
					return papershortname_initialized;
				
				case "Question":
					return question_initialized;
				
				case "QuestionId":
					return questionid_initialized;
				
				case "QuestionIndex":
					return questionindex_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "School_id":
					return school_id_initialized;
				
				case "Score":
					return score_initialized;
				
				case "SourceFile":
					return sourcefile_initialized;
				
				case "Sourceid":
					return sourceid_initialized;
				
				case "SourceZhangjie":
					return sourcezhangjie_initialized;
				
				case "Teacher":
					return teacher_initialized;
				
				case "TrueCount":
					return truecount_initialized;
				
				case "Url":
					return url_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "WrongRate":
					return wrongrate_initialized;
				
				case "YearId":
					return yearid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					autoid_initialized = ret;
					return true;
				
				case "Analysis":
					analysis_initialized = ret;
					return true;
				
				case "Answer":
					answer_initialized = ret;
					return true;
				
				case "Answer_yiwen":
					answer_yiwen_initialized = ret;
					return true;
				
				case "AnswerABC":
					answerabc_initialized = ret;
					return true;
				
				case "Area":
					area_initialized = ret;
					return true;
				
				case "ChapterId":
					chapterid_initialized = ret;
					return true;
				
				case "ChapterName":
					chaptername_initialized = ret;
					return true;
				
				case "Difficulty":
					difficulty_initialized = ret;
					return true;
				
				case "DiggDown":
					diggdown_initialized = ret;
					return true;
				
				case "DiggUp":
					diggup_initialized = ret;
					return true;
				
				case "ExamType":
					examtype_initialized = ret;
					return true;
				
				case "Explain":
					explain_initialized = ret;
					return true;
				
				case "FalseCount":
					falsecount_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "IsRepeatTf":
					isrepeattf_initialized = ret;
					return true;
				
				case "KaoDian":
					kaodian_initialized = ret;
					return true;
				
				case "Kemu":
					kemu_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "Knowledge":
					knowledge_initialized = ret;
					return true;
				
				case "Label":
					label_initialized = ret;
					return true;
				
				case "LinkExam":
					linkexam_initialized = ret;
					return true;
				
				case "MediaContent":
					mediacontent_initialized = ret;
					return true;
				
				case "MediaHeight":
					mediaheight_initialized = ret;
					return true;
				
				case "MediaType":
					mediatype_initialized = ret;
					return true;
				
				case "MediaWidth":
					mediawidth_initialized = ret;
					return true;
				
				case "OptionA":
					optiona_initialized = ret;
					return true;
				
				case "OptionB":
					optionb_initialized = ret;
					return true;
				
				case "OptionC":
					optionc_initialized = ret;
					return true;
				
				case "OptionD":
					optiond_initialized = ret;
					return true;
				
				case "OptionE":
					optione_initialized = ret;
					return true;
				
				case "OptionF":
					optionf_initialized = ret;
					return true;
				
				case "OptionG":
					optiong_initialized = ret;
					return true;
				
				case "OptionH":
					optionh_initialized = ret;
					return true;
				
				case "Optionnum":
					optionnum_initialized = ret;
					return true;
				
				case "OptionStr":
					optionstr_initialized = ret;
					return true;
				
				case "OptionType":
					optiontype_initialized = ret;
					return true;
				
				case "OrderId":
					orderid_initialized = ret;
					return true;
				
				case "PaperShortName":
					papershortname_initialized = ret;
					return true;
				
				case "Question":
					question_initialized = ret;
					return true;
				
				case "QuestionId":
					questionid_initialized = ret;
					return true;
				
				case "QuestionIndex":
					questionindex_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "School_id":
					school_id_initialized = ret;
					return true;
				
				case "Score":
					score_initialized = ret;
					return true;
				
				case "SourceFile":
					sourcefile_initialized = ret;
					return true;
				
				case "Sourceid":
					sourceid_initialized = ret;
					return true;
				
				case "SourceZhangjie":
					sourcezhangjie_initialized = ret;
					return true;
				
				case "Teacher":
					teacher_initialized = ret;
					return true;
				
				case "TrueCount":
					truecount_initialized = ret;
					return true;
				
				case "Url":
					url_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "WrongRate":
					wrongrate_initialized = ret;
					return true;
				
				case "YearId":
					yearid_initialized = ret;
					return true;
				
                default:
                    return base.SetInitialized(AttributeName, ret);
			}
        }
        #endregion

        #region 获取DataParameter PropertyInfo

        /// <summary>
        /// 获取所有被初始化过的值，获取AttributeItem
        /// 目的为获取 System.Windows.Forms.DataGridViewTextBoxColumn[] 在中间数据层采用了 自定义的 MyDataGridViewTextBoxColumn (空类继承自 DataGridViewTextBoxColumn)
        /// 这里采用了两次遍历的方法，是为了避免拆装过程，使用源代码模式的时候，不会依赖于windows.form.dll。
        /// </summary>
        /// <returns></returns>
        public override AttributeItem[] af_GetAvailableAttributeItem(ref List<object> values)
        {
            List<AttributeItem> parametersList = new List<AttributeItem>();

			
			if (autoid_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (analysis_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Analysis;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Analysis);
                }
			}
			
			if (answer_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Answer;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Answer);
                }
			}
			
			if (answer_yiwen_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Answer_yiwen;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Answer_yiwen);
                }
			}
			
			if (answerabc_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.AnswerABC;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AnswerABC);
                }
			}
			
			if (area_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Area;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Area);
                }
			}
			
			if (chapterid_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.ChapterId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ChapterId);
                }
			}
			
			if (chaptername_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.ChapterName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ChapterName);
                }
			}
			
			if (difficulty_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Difficulty;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Difficulty);
                }
			}
			
			if (diggdown_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.DiggDown;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DiggDown);
                }
			}
			
			if (diggup_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.DiggUp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DiggUp);
                }
			}
			
			if (examtype_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.ExamType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ExamType);
                }
			}
			
			if (explain_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Explain;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Explain);
                }
			}
			
			if (falsecount_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.FalseCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(FalseCount);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (isrepeattf_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.IsRepeatTf;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsRepeatTf);
                }
			}
			
			if (kaodian_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.KaoDian;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KaoDian);
                }
			}
			
			if (kemu_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (knowledge_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Knowledge;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Knowledge);
                }
			}
			
			if (label_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Label;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Label);
                }
			}
			
			if (linkexam_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.LinkExam;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(LinkExam);
                }
			}
			
			if (mediacontent_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.MediaContent;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaContent);
                }
			}
			
			if (mediaheight_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.MediaHeight;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaHeight);
                }
			}
			
			if (mediatype_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.MediaType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaType);
                }
			}
			
			if (mediawidth_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.MediaWidth;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MediaWidth);
                }
			}
			
			if (optiona_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionA;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionA);
                }
			}
			
			if (optionb_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionB;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionB);
                }
			}
			
			if (optionc_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionC;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionC);
                }
			}
			
			if (optiond_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionD;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionD);
                }
			}
			
			if (optione_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionE;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionE);
                }
			}
			
			if (optionf_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionF;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionF);
                }
			}
			
			if (optiong_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionG;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionG);
                }
			}
			
			if (optionh_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionH;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionH);
                }
			}
			
			if (optionnum_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Optionnum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Optionnum);
                }
			}
			
			if (optionstr_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionStr;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionStr);
                }
			}
			
			if (optiontype_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OptionType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OptionType);
                }
			}
			
			if (orderid_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.OrderId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OrderId);
                }
			}
			
			if (papershortname_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.PaperShortName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperShortName);
                }
			}
			
			if (question_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Question;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Question);
                }
			}
			
			if (questionid_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.QuestionId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionId);
                }
			}
			
			if (questionindex_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.QuestionIndex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QuestionIndex);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (school_id_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.School_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_id);
                }
			}
			
			if (score_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Score;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score);
                }
			}
			
			if (sourcefile_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.SourceFile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SourceFile);
                }
			}
			
			if (sourceid_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Sourceid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sourceid);
                }
			}
			
			if (sourcezhangjie_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.SourceZhangjie;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SourceZhangjie);
                }
			}
			
			if (teacher_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Teacher;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher);
                }
			}
			
			if (truecount_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.TrueCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TrueCount);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (wrongrate_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.WrongRate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WrongRate);
                }
			}
			
			if (yearid_initialized)
			{
                AttributeItem attr = St_TTimuDaXue.Attribute.YearId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(YearId);
                }
			}
			
            
			parametersList.AddRange(base.af_GetAvailableAttributeItem(ref values));
            return parametersList.ToArray();
        }
        #endregion                

        #region Json对象
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        [Serializable]
        public class St_TTimuDaXueJson
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>考题分析:[CtrlTypeDic-{InputString}]</summary>
            public string Analysis { get; set; }
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public string Answer { get; set; }
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public string Answer_yiwen { get; set; }
            
            /// <summary>学生提交的纠错答案:[CtrlTypeDic-{InputString}]</summary>
            public string AnswerABC { get; set; }
            
            /// <summary>地区:[CtrlTypeDic-{InputString}]</summary>
            public string Area { get; set; }
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public string ChapterId { get; set; }
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public string ChapterName { get; set; }
            
            /// <summary>难易程序:[CtrlTypeDic-{InputString}]</summary>
            public string Difficulty { get; set; }
            
            /// <summary>差评:[CtrlTypeDic-{InputString}]</summary>
            public string DiggDown { get; set; }
            
            /// <summary>好评:[CtrlTypeDic-{InputString}]</summary>
            public string DiggUp { get; set; }
            
            /// <summary>试卷类型:[CtrlTypeDic-{InputString}]</summary>
            public string ExamType { get; set; }
            
            /// <summary>试题解析:[CtrlTypeDic-{InputString}]</summary>
            public string Explain { get; set; }
            
            /// <summary>错误次数:[CtrlTypeDic-{InputString}]</summary>
            public string FalseCount { get; set; }
            
            /// <summary>采集编号:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>是否重做(0是1否):[Enum-{0:是},{1:否}][CtrlTypeDic-{InputString}]</summary>
            public int IsRepeatTf { get; set; }
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public string KaoDian { get; set; }
            
            /// <summary>科目:[CtrlTypeDic-{InputString}]</summary>
            public string Kemu { get; set; }
            
            /// <summary>科目Id:[CtrlTypeDic-{InputString}]</summary>
            public int KemuId { get; set; }
            
            /// <summary>考点:[CtrlTypeDic-{InputString}]</summary>
            public string Knowledge { get; set; }
            
            /// <summary>章节:[CtrlTypeDic-{InputString}]</summary>
            public string Label { get; set; }
            
            /// <summary>大题题号:[CtrlTypeDic-{InputString}]</summary>
            public string LinkExam { get; set; }
            
            /// <summary>媒体内容:[CtrlTypeDic-{InputString}]</summary>
            public string MediaContent { get; set; }
            
            /// <summary>媒体高度:[CtrlTypeDic-{InputString}]</summary>
            public string MediaHeight { get; set; }
            
            /// <summary>媒体类型:[Enum-{0:"文字"},{1:"图片"},{2:"视频"}][CtrlTypeDic-{InputString}]</summary>
            public string MediaType { get; set; }
            
            /// <summary>媒体宽度:[CtrlTypeDic-{InputString}]</summary>
            public string MediaWidth { get; set; }
            
            /// <summary>A:[CtrlTypeDic-{InputString}]</summary>
            public string OptionA { get; set; }
            
            /// <summary>B:[CtrlTypeDic-{InputString}]</summary>
            public string OptionB { get; set; }
            
            /// <summary>C:[CtrlTypeDic-{InputString}]</summary>
            public string OptionC { get; set; }
            
            /// <summary>D:[CtrlTypeDic-{InputString}]</summary>
            public string OptionD { get; set; }
            
            /// <summary>E:[CtrlTypeDic-{InputString}]</summary>
            public string OptionE { get; set; }
            
            /// <summary>F:[CtrlTypeDic-{InputString}]</summary>
            public string OptionF { get; set; }
            
            /// <summary>G:[CtrlTypeDic-{InputString}]</summary>
            public string OptionG { get; set; }
            
            /// <summary>H:[CtrlTypeDic-{InputString}]</summary>
            public string OptionH { get; set; }
            
            /// <summary>多选题答案个数:[CtrlTypeDic-{InputString}]</summary>
            public string Optionnum { get; set; }
            
            /// <summary>选项字符串-用竖线分隔符:[CtrlTypeDic-{HTML}]</summary>
            public string OptionStr { get; set; }
            
            /// <summary>题型-:[Enum-{0:单选},{1:多选},{2:判断},{3:简答论述},{4:不定项选择},{5:填空},{6:词汇},{7:图文题}][CtrlTypeDic-{SelectDrop}]</summary>
            public string OptionType { get; set; }
            
            /// <summary>顺序号:[CtrlTypeDic-{InputString}]</summary>
            public string OrderId { get; set; }
            
            /// <summary>试卷简称:[CtrlTypeDic-{InputString}]</summary>
            public string PaperShortName { get; set; }
            
            /// <summary>题目:[CtrlTypeDic-{InputString}]</summary>
            public string Question { get; set; }
            
            /// <summary>题号:[CtrlTypeDic-{InputString}]</summary>
            public int QuestionId { get; set; }
            
            /// <summary>题目顺序号:[CtrlTypeDic-{InputString}]</summary>
            public int QuestionIndex { get; set; }
            
            /// <summary>源大学微信号:[CtrlTypeDic-{InputString}]</summary>
            public string Sc { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int School_id { get; set; }
            
            /// <summary>分值:[CtrlTypeDic-{InputString}]</summary>
            public string Score { get; set; }
            
            /// <summary>源文件:[CtrlTypeDic-{InputString}]</summary>
            public string SourceFile { get; set; }
            
            /// <summary>源ID:[CtrlTypeDic-{InputString}]</summary>
            public string Sourceid { get; set; }
            
            /// <summary>源章节:[CtrlTypeDic-{InputString}]</summary>
            public string SourceZhangjie { get; set; }
            
            /// <summary>出题老师:[CtrlTypeDic-{InputString}]</summary>
            public string Teacher { get; set; }
            
            /// <summary>正确次数:[CtrlTypeDic-{InputString}]</summary>
            public string TrueCount { get; set; }
            
            /// <summary>链接地址:[CtrlTypeDic-{InputString}]</summary>
            public string Url { get; set; }
            
            /// <summary>用户Id:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>错误率:[CtrlTypeDic-{InputString}]</summary>
            public string WrongRate { get; set; }
            
            /// <summary>试卷年份:[CtrlTypeDic-{InputString}]</summary>
            public string YearId { get; set; }
        }
        #endregion
    }
}
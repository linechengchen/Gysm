/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/8/29 17:03:44
  Description:    数据表Xb_teacher_resume对应的业务逻辑层Xb_teacher_resume
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_teacher_resume_Entity:Xb_teacher_resume
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Born,Catelog,City_id,College,College_major,Create_time,E_wei_ma,English_kemu,Experience,Experience_intro,Experience_year,F26,F27,Good_at,Good_kemu,Good_nianji,Grade,Has_time_match_ids,Has_today_match_ids,High_school,Home_area,Introduce,Introduce_en,IP,Is_done,Is_recommend,Is_show,Jin_experience,Jin_sex,KaixueTime,Ke_jieshou_jiesuTime,Ke_jieshou_kaishiTime,Kemu,On_top,On_top_timeout,OpenID,Other_area,Phone_number,Photo,QQnum,Recommend,Score_high_school,Score_mianshi,Score_mianshi1,Score_mianshi2,Score_mianshi3,Score_seq,Service_type,Sex,ShujiaTime,Teach_exp,Teacher_mode,Teacher_name,Teacher_name_en,Teacher_type,Time_match_ids,Today_match_ids,Type,User_id,Uuid,Voice,Weizhi,Work_area,Work_field,Wx_city,Wx_country,Wx_create_man,Wx_device,Wx_explore,Wx_head_img,Wx_modify_time,Wx_nick_name,Wx_os,Wx_post_time,Wx_province,Wx_sex,Xuebapingyu from Xb_teacher_resume
delete from Xb_teacher_resume
INSERT INTO Xb_teacher_resume (Id,Born,Catelog,City_id,College,College_major,Create_time,E_wei_ma,English_kemu,Experience,Experience_intro,Experience_year,F26,F27,Good_at,Good_kemu,Good_nianji,Grade,Has_time_match_ids,Has_today_match_ids,High_school,Home_area,Introduce,Introduce_en,IP,Is_done,Is_recommend,Is_show,Jin_experience,Jin_sex,KaixueTime,Ke_jieshou_jiesuTime,Ke_jieshou_kaishiTime,Kemu,On_top,On_top_timeout,OpenID,Other_area,Phone_number,Photo,QQnum,Recommend,Score_high_school,Score_mianshi,Score_mianshi1,Score_mianshi2,Score_mianshi3,Score_seq,Service_type,Sex,ShujiaTime,Teach_exp,Teacher_mode,Teacher_name,Teacher_name_en,Teacher_type,Time_match_ids,Today_match_ids,Type,User_id,Uuid,Voice,Weizhi,Work_area,Work_field,Wx_city,Wx_country,Wx_create_man,Wx_device,Wx_explore,Wx_head_img,Wx_modify_time,Wx_nick_name,Wx_os,Wx_post_time,Wx_province,Wx_sex,Xuebapingyu)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xb_teacher_resume SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Born = valObj2.Born;
        valObj.Catelog = valObj2.Catelog;
        valObj.City_id = valObj2.City_id;
        valObj.College = valObj2.College;
        valObj.College_major = valObj2.College_major;
        valObj.Create_time = valObj2.Create_time;
        valObj.E_wei_ma = valObj2.E_wei_ma;
        valObj.English_kemu = valObj2.English_kemu;
        valObj.Experience = valObj2.Experience;
        valObj.Experience_intro = valObj2.Experience_intro;
        valObj.Experience_year = valObj2.Experience_year;
        valObj.F26 = valObj2.F26;
        valObj.F27 = valObj2.F27;
        valObj.Good_at = valObj2.Good_at;
        valObj.Good_kemu = valObj2.Good_kemu;
        valObj.Good_nianji = valObj2.Good_nianji;
        valObj.Grade = valObj2.Grade;
        valObj.Has_time_match_ids = valObj2.Has_time_match_ids;
        valObj.Has_today_match_ids = valObj2.Has_today_match_ids;
        valObj.High_school = valObj2.High_school;
        valObj.Home_area = valObj2.Home_area;
        valObj.Introduce = valObj2.Introduce;
        valObj.Introduce_en = valObj2.Introduce_en;
        valObj.IP = valObj2.IP;
        valObj.Is_done = valObj2.Is_done;
        valObj.Is_recommend = valObj2.Is_recommend;
        valObj.Is_show = valObj2.Is_show;
        valObj.Jin_experience = valObj2.Jin_experience;
        valObj.Jin_sex = valObj2.Jin_sex;
        valObj.KaixueTime = valObj2.KaixueTime;
        valObj.Ke_jieshou_jiesuTime = valObj2.Ke_jieshou_jiesuTime;
        valObj.Ke_jieshou_kaishiTime = valObj2.Ke_jieshou_kaishiTime;
        valObj.Kemu = valObj2.Kemu;
        valObj.On_top = valObj2.On_top;
        valObj.On_top_timeout = valObj2.On_top_timeout;
        valObj.OpenID = valObj2.OpenID;
        valObj.Other_area = valObj2.Other_area;
        valObj.Phone_number = valObj2.Phone_number;
        valObj.Photo = valObj2.Photo;
        valObj.QQnum = valObj2.QQnum;
        valObj.Recommend = valObj2.Recommend;
        valObj.Score_high_school = valObj2.Score_high_school;
        valObj.Score_mianshi = valObj2.Score_mianshi;
        valObj.Score_mianshi1 = valObj2.Score_mianshi1;
        valObj.Score_mianshi2 = valObj2.Score_mianshi2;
        valObj.Score_mianshi3 = valObj2.Score_mianshi3;
        valObj.Score_seq = valObj2.Score_seq;
        valObj.Service_type = valObj2.Service_type;
        valObj.Sex = valObj2.Sex;
        valObj.ShujiaTime = valObj2.ShujiaTime;
        valObj.Teach_exp = valObj2.Teach_exp;
        valObj.Teacher_mode = valObj2.Teacher_mode;
        valObj.Teacher_name = valObj2.Teacher_name;
        valObj.Teacher_name_en = valObj2.Teacher_name_en;
        valObj.Teacher_type = valObj2.Teacher_type;
        valObj.Time_match_ids = valObj2.Time_match_ids;
        valObj.Today_match_ids = valObj2.Today_match_ids;
        valObj.Type = valObj2.Type;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid;
        valObj.Voice = valObj2.Voice;
        valObj.Weizhi = valObj2.Weizhi;
        valObj.Work_area = valObj2.Work_area;
        valObj.Work_field = valObj2.Work_field;
        valObj.Wx_city = valObj2.Wx_city;
        valObj.Wx_country = valObj2.Wx_country;
        valObj.Wx_create_man = valObj2.Wx_create_man;
        valObj.Wx_device = valObj2.Wx_device;
        valObj.Wx_explore = valObj2.Wx_explore;
        valObj.Wx_head_img = valObj2.Wx_head_img;
        valObj.Wx_modify_time = valObj2.Wx_modify_time;
        valObj.Wx_nick_name = valObj2.Wx_nick_name;
        valObj.Wx_os = valObj2.Wx_os;
        valObj.Wx_post_time = valObj2.Wx_post_time;
        valObj.Wx_province = valObj2.Wx_province;
        valObj.Wx_sex = valObj2.Wx_sex;
        valObj.Xuebapingyu = valObj2.Xuebapingyu; 
        valObj.Id = "";
        valObj.Born = "";
        valObj.Catelog = "";
        valObj.City_id = "";
        valObj.College = "";
        valObj.College_major = "";
        valObj.Create_time = "";
        valObj.E_wei_ma = "";
        valObj.English_kemu = "";
        valObj.Experience = "";
        valObj.Experience_intro = "";
        valObj.Experience_year = "";
        valObj.F26 = "";
        valObj.F27 = "";
        valObj.Good_at = "";
        valObj.Good_kemu = "";
        valObj.Good_nianji = "";
        valObj.Grade = "";
        valObj.Has_time_match_ids = "";
        valObj.Has_today_match_ids = "";
        valObj.High_school = "";
        valObj.Home_area = "";
        valObj.Introduce = "";
        valObj.Introduce_en = "";
        valObj.IP = "";
        valObj.Is_done = "";
        valObj.Is_recommend = "";
        valObj.Is_show = "";
        valObj.Jin_experience = "";
        valObj.Jin_sex = "";
        valObj.KaixueTime = "";
        valObj.Ke_jieshou_jiesuTime = "";
        valObj.Ke_jieshou_kaishiTime = "";
        valObj.Kemu = "";
        valObj.On_top = "";
        valObj.On_top_timeout = "";
        valObj.OpenID = "";
        valObj.Other_area = "";
        valObj.Phone_number = "";
        valObj.Photo = "";
        valObj.QQnum = "";
        valObj.Recommend = "";
        valObj.Score_high_school = "";
        valObj.Score_mianshi = "";
        valObj.Score_mianshi1 = "";
        valObj.Score_mianshi2 = "";
        valObj.Score_mianshi3 = "";
        valObj.Score_seq = "";
        valObj.Service_type = "";
        valObj.Sex = "";
        valObj.ShujiaTime = "";
        valObj.Teach_exp = "";
        valObj.Teacher_mode = "";
        valObj.Teacher_name = "";
        valObj.Teacher_name_en = "";
        valObj.Teacher_type = "";
        valObj.Time_match_ids = "";
        valObj.Today_match_ids = "";
        valObj.Type = "";
        valObj.User_id = "";
        valObj.Uuid = "";
        valObj.Voice = "";
        valObj.Weizhi = "";
        valObj.Work_area = "";
        valObj.Work_field = "";
        valObj.Wx_city = "";
        valObj.Wx_country = "";
        valObj.Wx_create_man = "";
        valObj.Wx_device = "";
        valObj.Wx_explore = "";
        valObj.Wx_head_img = "";
        valObj.Wx_modify_time = "";
        valObj.Wx_nick_name = "";
        valObj.Wx_os = "";
        valObj.Wx_post_time = "";
        valObj.Wx_province = "";
        valObj.Wx_sex = "";
        valObj.Xuebapingyu = ""; 
        "Id": $("#txt_Id").val(),
        "Born": $("#txt_Born").val(),
        "Catelog": $("#txt_Catelog").val(),
        "City_id": $("#txt_City_id").val(),
        "College": $("#txt_College").val(),
        "College_major": $("#txt_College_major").val(),
        "Create_time": $("#txt_Create_time").val(),
        "E_wei_ma": $("#txt_E_wei_ma").val(),
        "English_kemu": $("#txt_English_kemu").val(),
        "Experience": $("#txt_Experience").val(),
        "Experience_intro": $("#txt_Experience_intro").val(),
        "Experience_year": $("#txt_Experience_year").val(),
        "F26": $("#txt_F26").val(),
        "F27": $("#txt_F27").val(),
        "Good_at": $("#txt_Good_at").val(),
        "Good_kemu": $("#txt_Good_kemu").val(),
        "Good_nianji": $("#txt_Good_nianji").val(),
        "Grade": $("#txt_Grade").val(),
        "Has_time_match_ids": $("#txt_Has_time_match_ids").val(),
        "Has_today_match_ids": $("#txt_Has_today_match_ids").val(),
        "High_school": $("#txt_High_school").val(),
        "Home_area": $("#txt_Home_area").val(),
        "Introduce": $("#txt_Introduce").val(),
        "Introduce_en": $("#txt_Introduce_en").val(),
        "IP": $("#txt_IP").val(),
        "Is_done": $("#txt_Is_done").val(),
        "Is_recommend": $("#txt_Is_recommend").val(),
        "Is_show": $("#txt_Is_show").val(),
        "Jin_experience": $("#txt_Jin_experience").val(),
        "Jin_sex": $("#txt_Jin_sex").val(),
        "KaixueTime": $("#txt_KaixueTime").val(),
        "Ke_jieshou_jiesuTime": $("#txt_Ke_jieshou_jiesuTime").val(),
        "Ke_jieshou_kaishiTime": $("#txt_Ke_jieshou_kaishiTime").val(),
        "Kemu": $("#txt_Kemu").val(),
        "On_top": $("#txt_On_top").val(),
        "On_top_timeout": $("#txt_On_top_timeout").val(),
        "OpenID": $("#txt_OpenID").val(),
        "Other_area": $("#txt_Other_area").val(),
        "Phone_number": $("#txt_Phone_number").val(),
        "Photo": $("#txt_Photo").val(),
        "QQnum": $("#txt_QQnum").val(),
        "Recommend": $("#txt_Recommend").val(),
        "Score_high_school": $("#txt_Score_high_school").val(),
        "Score_mianshi": $("#txt_Score_mianshi").val(),
        "Score_mianshi1": $("#txt_Score_mianshi1").val(),
        "Score_mianshi2": $("#txt_Score_mianshi2").val(),
        "Score_mianshi3": $("#txt_Score_mianshi3").val(),
        "Score_seq": $("#txt_Score_seq").val(),
        "Service_type": $("#txt_Service_type").val(),
        "Sex": $("#txt_Sex").val(),
        "ShujiaTime": $("#txt_ShujiaTime").val(),
        "Teach_exp": $("#txt_Teach_exp").val(),
        "Teacher_mode": $("#txt_Teacher_mode").val(),
        "Teacher_name": $("#txt_Teacher_name").val(),
        "Teacher_name_en": $("#txt_Teacher_name_en").val(),
        "Teacher_type": $("#txt_Teacher_type").val(),
        "Time_match_ids": $("#txt_Time_match_ids").val(),
        "Today_match_ids": $("#txt_Today_match_ids").val(),
        "Type": $("#txt_Type").val(),
        "User_id": $("#txt_User_id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "Voice": $("#txt_Voice").val(),
        "Weizhi": $("#txt_Weizhi").val(),
        "Work_area": $("#txt_Work_area").val(),
        "Work_field": $("#txt_Work_field").val(),
        "Wx_city": $("#txt_Wx_city").val(),
        "Wx_country": $("#txt_Wx_country").val(),
        "Wx_create_man": $("#txt_Wx_create_man").val(),
        "Wx_device": $("#txt_Wx_device").val(),
        "Wx_explore": $("#txt_Wx_explore").val(),
        "Wx_head_img": $("#txt_Wx_head_img").val(),
        "Wx_modify_time": $("#txt_Wx_modify_time").val(),
        "Wx_nick_name": $("#txt_Wx_nick_name").val(),
        "Wx_os": $("#txt_Wx_os").val(),
        "Wx_post_time": $("#txt_Wx_post_time").val(),
        "Wx_province": $("#txt_Wx_province").val(),
        "Wx_sex": $("#txt_Wx_sex").val(),
        "Xuebapingyu": $("#txt_Xuebapingyu").val(), 
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
    /// <para>爱帮学霸家教-优秀教员履历</para>
    /// <para>与Xb_teacher_resume数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_teacher_resume : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_teacher_resume Factory()
        {
            return new Xb_teacher_resume();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 序号 Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 出生年月:[CtrlTypeDic-{InputDate}] Attribute_IsNotNull </summary>
        public string _Born
        {            
            get { return this.Born; }
            set { this.Born = value; }
        }
        
        /// <summary> 大类:[Enum-{0:优选教员},{1:外教},{2:小班课},{3:暑期课}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public int _Catelog
        {            
            get { return this.Catelog; }
            set { this.Catelog = value; }
        }
        
        /// <summary> [IsVisable-{false}] Attribute_IsNotNull </summary>
        public string _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
        }
        
        /// <summary> 大学 Attribute_IsNotNull </summary>
        public string _College
        {            
            get { return this.College; }
            set { this.College = value; }
        }
        
        /// <summary> 专业:[IsVisable-{false}] Attribute_IsNotNull </summary>
        public string _College_major
        {            
            get { return this.College_major; }
            set { this.College_major = value; }
        }
        
        /// <summary> 填写日期:[CtrlTypeDic-{InputDate}] Attribute_IsNotNull </summary>
        public string _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> 二维码:[IsVisable-{false}][CtrlTypeDic-{FileUpImage}] Attribute_IsNotNull </summary>
        public string _E_wei_ma
        {            
            get { return this.E_wei_ma; }
            set { this.E_wei_ma = value; }
        }
        
        /// <summary> 科目:[Enum-{0:生活口语},{1:自由会话},{2:青少年英语},{3:雅思英语},{4:新托福英语},{5:商务英语},{6:旅游英语},{7:文化话题英语},{8:时事英语},{9:青少全能新概念},{10:综合口语},{11:经典英语（成人版）},{12:经典英语（青少版）}][IsVisable-{false}][CtrlTypeDic-{SelectMultiple}] Attribute_IsNotNull </summary>
        public int _English_kemu
        {            
            get { return this.English_kemu; }
            set { this.English_kemu = value; }
        }
        
        /// <summary> 经验:[Enum-{0:暂无},{1:1V1},{2:小班2人以上},{3:大班6人以上}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public int _Experience
        {            
            get { return this.Experience; }
            set { this.Experience = value; }
        }
        
        /// <summary> 经验:[IsVisable-{false}] Attribute_IsNotNull </summary>
        public string _Experience_intro
        {            
            get { return this.Experience_intro; }
            set { this.Experience_intro = value; }
        }
        
        /// <summary> 教课经验:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public double _Experience_year
        {            
            get { return this.Experience_year; }
            set { this.Experience_year = value; }
        }
        
        /// <summary> [IsVisable-{false}] Attribute_IsNotNull </summary>
        public string _F26
        {            
            get { return this.F26; }
            set { this.F26 = value; }
        }
        
        /// <summary> [IsVisable-{false}] Attribute_IsNotNull </summary>
        public string _F27
        {            
            get { return this.F27; }
            set { this.F27 = value; }
        }
        
        /// <summary> 擅长科目:[IsVisable-{false}][IsReadOnly-{true}][CtrlTypeDic-{SelectMultiple}] Attribute_IsNotNull </summary>
        public string _Good_at
        {            
            get { return this.Good_at; }
            set { this.Good_at = value; }
        }
        
        /// <summary> [IsVisable-{false}] Attribute_IsNotNull </summary>
        public string _Good_kemu
        {            
            get { return this.Good_kemu; }
            set { this.Good_kemu = value; }
        }
        
        /// <summary> [IsVisable-{false}] Attribute_IsNotNull </summary>
        public string _Good_nianji
        {            
            get { return this.Good_nianji; }
            set { this.Good_nianji = value; }
        }
        
        /// <summary> 年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectMultiple}] Attribute_IsNotNull </summary>
        public string _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> 已被预约的课程时间(day_min，返回前端为当前天int值):[IsVisable-{false}][CtrlTypeDic-{InputTime}] Attribute_IsNotNull </summary>
        public string _Has_time_match_ids
        {            
            get { return this.Has_time_match_ids; }
            set { this.Has_time_match_ids = value; }
        }
        
        /// <summary> 今日已预约计算结果int:[IsVisable-{false}] Attribute_IsNotNull </summary>
        public string _Has_today_match_ids
        {            
            get { return this.Has_today_match_ids; }
            set { this.Has_today_match_ids = value; }
        }
        
        /// <summary> 高中:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _High_school
        {            
            get { return this.High_school; }
            set { this.High_school = value; }
        }
        
        /// <summary> 家乡:[CtrlTypeDic-{Address}] Attribute_IsNotNull </summary>
        public string _Home_area
        {            
            get { return this.Home_area; }
            set { this.Home_area = value; }
        }
        
        /// <summary> 自我简介:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Introduce
        {            
            get { return this.Introduce; }
            set { this.Introduce = value; }
        }
        
        /// <summary> 英语自我介绍:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Introduce_en
        {            
            get { return this.Introduce_en; }
            set { this.Introduce_en = value; }
        }
        
        /// <summary> Ip地址 Attribute_IsNotNull </summary>
        public string _IP
        {            
            get { return this.IP; }
            set { this.IP = value; }
        }
        
        /// <summary> 是否有成交:[Enum-{yes:是},{no:否}][CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _Is_done
        {            
            get { return this.Is_done; }
            set { this.Is_done = value; }
        }
        
        /// <summary> 是否推荐:[Enum-{yes:是},{no:否}][CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _Is_recommend
        {            
            get { return this.Is_recommend; }
            set { this.Is_recommend = value; }
        }
        
        /// <summary> 是否显示:[Enum-{yes:是},{not:否}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _Is_show
        {            
            get { return this.Is_show; }
            set { this.Is_show = value; }
        }
        
        /// <summary> 家教经验:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Jin_experience
        {            
            get { return this.Jin_experience; }
            set { this.Jin_experience = value; }
        }
        
        /// <summary> 性别:[Enum-{:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public string _Jin_sex
        {            
            get { return this.Jin_sex; }
            set { this.Jin_sex = value; }
        }
        
        /// <summary> 开学可教学时间:[CtrlTypeDic-{InputTime}] Attribute_IsNotNull </summary>
        public string _KaixueTime
        {            
            get { return this.KaixueTime; }
            set { this.KaixueTime = value; }
        }
        
        /// <summary> 课程结束时间:[CtrlTypeDic-{InputTime}] Attribute_IsNotNull </summary>
        public string _Ke_jieshou_jiesuTime
        {            
            get { return this.Ke_jieshou_jiesuTime; }
            set { this.Ke_jieshou_jiesuTime = value; }
        }
        
        /// <summary> 课程开始时间:[CtrlTypeDic-{InputTime}] Attribute_IsNotNull </summary>
        public string _Ke_jieshou_kaishiTime
        {            
            get { return this.Ke_jieshou_kaishiTime; }
            set { this.Ke_jieshou_kaishiTime = value; }
        }
        
        /// <summary> 科目:[Enum-{:不限},{1:数学},{2:英语},{3:语文},{4:物理},{5:化学},{6:生物},{7:政治},{8:历史},{9:地理},{10:奥数},{11:科学},{12:钢琴},{13:书法},{14:舞蹈},{15:素描},{16:国画}][CtrlTypeDic-{SelectMultiple}] Attribute_IsNotNull </summary>
        public string _Kemu
        {            
            get { return this.Kemu; }
            set { this.Kemu = value; }
        }
        
        /// <summary> 是否置顶:[Enum-{1:是},{2:否}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _On_top
        {            
            get { return this.On_top; }
            set { this.On_top = value; }
        }
        
        /// <summary> 置顶超时日期:[IsVisable-{false}][CtrlTypeDic-{InputDate}] Attribute_IsNotNull </summary>
        public DateTime _On_top_timeout
        {            
            get { return this.On_top_timeout; }
            set { this.On_top_timeout = value; }
        }
        
        /// <summary> [IsVisable-{false}] Attribute_IsNotNull </summary>
        public string _OpenID
        {            
            get { return this.OpenID; }
            set { this.OpenID = value; }
        }
        
        /// <summary> 其他意向区域:[IsVisable-{false}][CtrlTypeDic-{Address}] Attribute_IsNotNull </summary>
        public string _Other_area
        {            
            get { return this.Other_area; }
            set { this.Other_area = value; }
        }
        
        /// <summary> 手机号:[CtrlTypeDic-{InputMobile}] Attribute_IsNotNull </summary>
        public string _Phone_number
        {            
            get { return this.Phone_number; }
            set { this.Phone_number = value; }
        }
        
        /// <summary> 随身照:[CtrlTypeDic-{FileUpImage}] Attribute_IsNotNull </summary>
        public string _Photo
        {            
            get { return this.Photo; }
            set { this.Photo = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputQQ}] Attribute_IsNotNull </summary>
        public string _QQnum
        {            
            get { return this.QQnum; }
            set { this.QQnum = value; }
        }
        
        /// <summary> 适合学员 Attribute_IsNotNull </summary>
        public string _Recommend
        {            
            get { return this.Recommend; }
            set { this.Recommend = value; }
        }
        
        /// <summary> 高考成绩 Attribute_IsNotNull </summary>
        public string _Score_high_school
        {            
            get { return this.Score_high_school; }
            set { this.Score_high_school = value; }
        }
        
        /// <summary> 面试总分 Attribute_IsNotNull </summary>
        public string _Score_mianshi
        {            
            get { return this.Score_mianshi; }
            set { this.Score_mianshi = value; }
        }
        
        /// <summary> 面试评分1-经验:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Score_mianshi1
        {            
            get { return this.Score_mianshi1; }
            set { this.Score_mianshi1 = value; }
        }
        
        /// <summary> 面试评分2-沟通:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Score_mianshi2
        {            
            get { return this.Score_mianshi2; }
            set { this.Score_mianshi2 = value; }
        }
        
        /// <summary> 面试评分3-技能:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Score_mianshi3
        {            
            get { return this.Score_mianshi3; }
            set { this.Score_mianshi3 = value; }
        }
        
        /// <summary> 排序权重 Attribute_IsNotNull </summary>
        public double _Score_seq
        {            
            get { return this.Score_seq; }
            set { this.Score_seq = value; }
        }
        
        /// <summary> 服务方式:[Enum-{:不限},{1:仅首次上门},{2:上门服务},{3:在线答疑},{4:在线课}][CtrlTypeDic-{SelectMultiple}] Attribute_IsNotNull </summary>
        public int _Service_type
        {            
            get { return this.Service_type; }
            set { this.Service_type = value; }
        }
        
        /// <summary> 性别:[Enum-{:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public int _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary> 暑假可教学区域:[CtrlTypeDic-{Address}] Attribute_IsNotNull </summary>
        public string _ShujiaTime
        {            
            get { return this.ShujiaTime; }
            set { this.ShujiaTime = value; }
        }
        
        /// <summary> 教课经验:[Enum-{:不限},{1:1年以下},{2:2-5年},{3:10年以上}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public int _Teach_exp
        {            
            get { return this.Teach_exp; }
            set { this.Teach_exp = value; }
        }
        
        /// <summary> 教学模式:[Enum-{:不限},{1:在线1v1},{2:线下朋友团},{3:1v3小班},{4:1v5小班}][CtrlTypeDic-{SelectMultiple}] Attribute_IsNotNull </summary>
        public int _Teacher_mode
        {            
            get { return this.Teacher_mode; }
            set { this.Teacher_mode = value; }
        }
        
        /// <summary> 讲师姓名 Attribute_IsNotNull </summary>
        public string _Teacher_name
        {            
            get { return this.Teacher_name; }
            set { this.Teacher_name = value; }
        }
        
        /// <summary> 讲师英文名 Attribute_IsNotNull </summary>
        public string _Teacher_name_en
        {            
            get { return this.Teacher_name_en; }
            set { this.Teacher_name_en = value; }
        }
        
        /// <summary> 讲师类型:[Enum-{0:不限},{1:留学生外教},{2:欧美外教}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public int _Teacher_type
        {            
            get { return this.Teacher_type; }
            set { this.Teacher_type = value; }
        }
        
        /// <summary> 课程时间(day_min，返回前端为当前天int值):[CtrlTypeDic-{InputTime}] Attribute_IsNotNull </summary>
        public string _Time_match_ids
        {            
            get { return this.Time_match_ids; }
            set { this.Time_match_ids = value; }
        }
        
        /// <summary> 今日计算结果int Attribute_IsNotNull </summary>
        public string _Today_match_ids
        {            
            get { return this.Today_match_ids; }
            set { this.Today_match_ids = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [IsVisable-{false}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 语音介绍 Attribute_IsNotNull </summary>
        public string _Voice
        {            
            get { return this.Voice; }
            set { this.Voice = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Weizhi
        {            
            get { return this.Weizhi; }
            set { this.Weizhi = value; }
        }
        
        /// <summary> 意向工作区域 Attribute_IsNotNull </summary>
        public string _Work_area
        {            
            get { return this.Work_area; }
            set { this.Work_area = value; }
        }
        
        /// <summary> 工作行业 Attribute_IsNotNull </summary>
        public string _Work_field
        {            
            get { return this.Work_field; }
            set { this.Work_field = value; }
        }
        
        /// <summary> 微信市 Attribute_IsNotNull </summary>
        public string _Wx_city
        {            
            get { return this.Wx_city; }
            set { this.Wx_city = value; }
        }
        
        /// <summary> 微信国家 Attribute_IsNotNull </summary>
        public string _Wx_country
        {            
            get { return this.Wx_country; }
            set { this.Wx_country = value; }
        }
        
        /// <summary> 提交人 Attribute_IsNotNull </summary>
        public string _Wx_create_man
        {            
            get { return this.Wx_create_man; }
            set { this.Wx_create_man = value; }
        }
        
        /// <summary> 填写设备 Attribute_IsNotNull </summary>
        public string _Wx_device
        {            
            get { return this.Wx_device; }
            set { this.Wx_device = value; }
        }
        
        /// <summary> 浏览器 Attribute_IsNotNull </summary>
        public string _Wx_explore
        {            
            get { return this.Wx_explore; }
            set { this.Wx_explore = value; }
        }
        
        /// <summary> 微信头像:[CtrlTypeDic-{FileUpImage}] Attribute_IsNotNull </summary>
        public string _Wx_head_img
        {            
            get { return this.Wx_head_img; }
            set { this.Wx_head_img = value; }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputTime}] Attribute_IsNotNull </summary>
        public string _Wx_modify_time
        {            
            get { return this.Wx_modify_time; }
            set { this.Wx_modify_time = value; }
        }
        
        /// <summary> 微信昵称 Attribute_IsNotNull </summary>
        public string _Wx_nick_name
        {            
            get { return this.Wx_nick_name; }
            set { this.Wx_nick_name = value; }
        }
        
        /// <summary> 操作系统 Attribute_IsNotNull </summary>
        public string _Wx_os
        {            
            get { return this.Wx_os; }
            set { this.Wx_os = value; }
        }
        
        /// <summary> 提交时间:[CtrlTypeDic-{InputTime}] Attribute_IsNotNull </summary>
        public string _Wx_post_time
        {            
            get { return this.Wx_post_time; }
            set { this.Wx_post_time = value; }
        }
        
        /// <summary> 微信省市 Attribute_IsNotNull </summary>
        public string _Wx_province
        {            
            get { return this.Wx_province; }
            set { this.Wx_province = value; }
        }
        
        /// <summary> 微信性别:[Enum-{1:男},{2:女}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public string _Wx_sex
        {            
            get { return this.Wx_sex; }
            set { this.Wx_sex = value; }
        }
        
        /// <summary> 评语:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Xuebapingyu
        {            
            get { return this.Xuebapingyu; }
            set { this.Xuebapingyu = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 序号，推荐使用 "_"符号开头 </summary>
        public int Id
        {
            get { return this.m_id; }
            set //private 
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> 出生年月:[CtrlTypeDic-{InputDate}]，推荐使用 "_"符号开头 </summary>
        public string Born
        {
            get { return this.m_born; }
            set //
            {
                if (!born_initialized || m_born != value)
                {
                    this.m_born = value;
                }
                born_initialized = true;
            }
        }
        
        /// <summary> 大类:[Enum-{0:优选教员},{1:外教},{2:小班课},{3:暑期课}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public int Catelog
        {
            get { return this.m_catelog; }
            set //
            {
                if (!catelog_initialized || m_catelog != value)
                {
                    this.m_catelog = value;
                }
                catelog_initialized = true;
            }
        }
        
        /// <summary> [IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public string City_id
        {
            get { return this.m_city_id; }
            set //
            {
                if (!city_id_initialized || m_city_id != value)
                {
                    this.m_city_id = value;
                }
                city_id_initialized = true;
            }
        }
        
        /// <summary> 大学，推荐使用 "_"符号开头 </summary>
        public string College
        {
            get { return this.m_college; }
            set //
            {
                if (!college_initialized || m_college != value)
                {
                    this.m_college = value;
                }
                college_initialized = true;
            }
        }
        
        /// <summary> 专业:[IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public string College_major
        {
            get { return this.m_college_major; }
            set //
            {
                if (!college_major_initialized || m_college_major != value)
                {
                    this.m_college_major = value;
                }
                college_major_initialized = true;
            }
        }
        
        /// <summary> 填写日期:[CtrlTypeDic-{InputDate}]，推荐使用 "_"符号开头 </summary>
        public string Create_time
        {
            get { return this.m_create_time; }
            set //
            {
                if (!create_time_initialized || m_create_time != value)
                {
                    this.m_create_time = value;
                }
                create_time_initialized = true;
            }
        }
        
        /// <summary> 二维码:[IsVisable-{false}][CtrlTypeDic-{FileUpImage}]，推荐使用 "_"符号开头 </summary>
        public string E_wei_ma
        {
            get { return this.m_e_wei_ma; }
            set //
            {
                if (!e_wei_ma_initialized || m_e_wei_ma != value)
                {
                    this.m_e_wei_ma = value;
                }
                e_wei_ma_initialized = true;
            }
        }
        
        /// <summary> 科目:[Enum-{0:生活口语},{1:自由会话},{2:青少年英语},{3:雅思英语},{4:新托福英语},{5:商务英语},{6:旅游英语},{7:文化话题英语},{8:时事英语},{9:青少全能新概念},{10:综合口语},{11:经典英语（成人版）},{12:经典英语（青少版）}][IsVisable-{false}][CtrlTypeDic-{SelectMultiple}]，推荐使用 "_"符号开头 </summary>
        public int English_kemu
        {
            get { return this.m_english_kemu; }
            set //
            {
                if (!english_kemu_initialized || m_english_kemu != value)
                {
                    this.m_english_kemu = value;
                }
                english_kemu_initialized = true;
            }
        }
        
        /// <summary> 经验:[Enum-{0:暂无},{1:1V1},{2:小班2人以上},{3:大班6人以上}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public int Experience
        {
            get { return this.m_experience; }
            set //
            {
                if (!experience_initialized || m_experience != value)
                {
                    this.m_experience = value;
                }
                experience_initialized = true;
            }
        }
        
        /// <summary> 经验:[IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public string Experience_intro
        {
            get { return this.m_experience_intro; }
            set //
            {
                if (!experience_intro_initialized || m_experience_intro != value)
                {
                    this.m_experience_intro = value;
                }
                experience_intro_initialized = true;
            }
        }
        
        /// <summary> 教课经验:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public double Experience_year
        {
            get { return this.m_experience_year; }
            set //
            {
                if (!experience_year_initialized || m_experience_year != value)
                {
                    this.m_experience_year = value;
                }
                experience_year_initialized = true;
            }
        }
        
        /// <summary> [IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public string F26
        {
            get { return this.m_f26; }
            set //
            {
                if (!f26_initialized || m_f26 != value)
                {
                    this.m_f26 = value;
                }
                f26_initialized = true;
            }
        }
        
        /// <summary> [IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public string F27
        {
            get { return this.m_f27; }
            set //
            {
                if (!f27_initialized || m_f27 != value)
                {
                    this.m_f27 = value;
                }
                f27_initialized = true;
            }
        }
        
        /// <summary> 擅长科目:[IsVisable-{false}][IsReadOnly-{true}][CtrlTypeDic-{SelectMultiple}]，推荐使用 "_"符号开头 </summary>
        public string Good_at
        {
            get { return this.m_good_at; }
            set //
            {
                if (!good_at_initialized || m_good_at != value)
                {
                    this.m_good_at = value;
                }
                good_at_initialized = true;
            }
        }
        
        /// <summary> [IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public string Good_kemu
        {
            get { return this.m_good_kemu; }
            set //
            {
                if (!good_kemu_initialized || m_good_kemu != value)
                {
                    this.m_good_kemu = value;
                }
                good_kemu_initialized = true;
            }
        }
        
        /// <summary> [IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public string Good_nianji
        {
            get { return this.m_good_nianji; }
            set //
            {
                if (!good_nianji_initialized || m_good_nianji != value)
                {
                    this.m_good_nianji = value;
                }
                good_nianji_initialized = true;
            }
        }
        
        /// <summary> 年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectMultiple}]，推荐使用 "_"符号开头 </summary>
        public string Grade
        {
            get { return this.m_grade; }
            set //
            {
                if (!grade_initialized || m_grade != value)
                {
                    this.m_grade = value;
                }
                grade_initialized = true;
            }
        }
        
        /// <summary> 已被预约的课程时间(day_min，返回前端为当前天int值):[IsVisable-{false}][CtrlTypeDic-{InputTime}]，推荐使用 "_"符号开头 </summary>
        public string Has_time_match_ids
        {
            get { return this.m_has_time_match_ids; }
            set //
            {
                if (!has_time_match_ids_initialized || m_has_time_match_ids != value)
                {
                    this.m_has_time_match_ids = value;
                }
                has_time_match_ids_initialized = true;
            }
        }
        
        /// <summary> 今日已预约计算结果int:[IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public string Has_today_match_ids
        {
            get { return this.m_has_today_match_ids; }
            set //
            {
                if (!has_today_match_ids_initialized || m_has_today_match_ids != value)
                {
                    this.m_has_today_match_ids = value;
                }
                has_today_match_ids_initialized = true;
            }
        }
        
        /// <summary> 高中:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string High_school
        {
            get { return this.m_high_school; }
            set //
            {
                if (!high_school_initialized || m_high_school != value)
                {
                    this.m_high_school = value;
                }
                high_school_initialized = true;
            }
        }
        
        /// <summary> 家乡:[CtrlTypeDic-{Address}]，推荐使用 "_"符号开头 </summary>
        public string Home_area
        {
            get { return this.m_home_area; }
            set //
            {
                if (!home_area_initialized || m_home_area != value)
                {
                    this.m_home_area = value;
                }
                home_area_initialized = true;
            }
        }
        
        /// <summary> 自我简介:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Introduce
        {
            get { return this.m_introduce; }
            set //
            {
                if (!introduce_initialized || m_introduce != value)
                {
                    this.m_introduce = value;
                }
                introduce_initialized = true;
            }
        }
        
        /// <summary> 英语自我介绍:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Introduce_en
        {
            get { return this.m_introduce_en; }
            set //
            {
                if (!introduce_en_initialized || m_introduce_en != value)
                {
                    this.m_introduce_en = value;
                }
                introduce_en_initialized = true;
            }
        }
        
        /// <summary> Ip地址，推荐使用 "_"符号开头 </summary>
        public string IP
        {
            get { return this.m_ip; }
            set //
            {
                if (!ip_initialized || m_ip != value)
                {
                    this.m_ip = value;
                }
                ip_initialized = true;
            }
        }
        
        /// <summary> 是否有成交:[Enum-{yes:是},{no:否}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool Is_done
        {
            get { return this.m_is_done; }
            set //
            {
                if (!is_done_initialized || m_is_done != value)
                {
                    this.m_is_done = value;
                }
                is_done_initialized = true;
            }
        }
        
        /// <summary> 是否推荐:[Enum-{yes:是},{no:否}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool Is_recommend
        {
            get { return this.m_is_recommend; }
            set //
            {
                if (!is_recommend_initialized || m_is_recommend != value)
                {
                    this.m_is_recommend = value;
                }
                is_recommend_initialized = true;
            }
        }
        
        /// <summary> 是否显示:[Enum-{yes:是},{not:否}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool Is_show
        {
            get { return this.m_is_show; }
            set //
            {
                if (!is_show_initialized || m_is_show != value)
                {
                    this.m_is_show = value;
                }
                is_show_initialized = true;
            }
        }
        
        /// <summary> 家教经验:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Jin_experience
        {
            get { return this.m_jin_experience; }
            set //
            {
                if (!jin_experience_initialized || m_jin_experience != value)
                {
                    this.m_jin_experience = value;
                }
                jin_experience_initialized = true;
            }
        }
        
        /// <summary> 性别:[Enum-{:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public string Jin_sex
        {
            get { return this.m_jin_sex; }
            set //
            {
                if (!jin_sex_initialized || m_jin_sex != value)
                {
                    this.m_jin_sex = value;
                }
                jin_sex_initialized = true;
            }
        }
        
        /// <summary> 开学可教学时间:[CtrlTypeDic-{InputTime}]，推荐使用 "_"符号开头 </summary>
        public string KaixueTime
        {
            get { return this.m_kaixuetime; }
            set //
            {
                if (!kaixuetime_initialized || m_kaixuetime != value)
                {
                    this.m_kaixuetime = value;
                }
                kaixuetime_initialized = true;
            }
        }
        
        /// <summary> 课程结束时间:[CtrlTypeDic-{InputTime}]，推荐使用 "_"符号开头 </summary>
        public string Ke_jieshou_jiesuTime
        {
            get { return this.m_ke_jieshou_jiesutime; }
            set //
            {
                if (!ke_jieshou_jiesutime_initialized || m_ke_jieshou_jiesutime != value)
                {
                    this.m_ke_jieshou_jiesutime = value;
                }
                ke_jieshou_jiesutime_initialized = true;
            }
        }
        
        /// <summary> 课程开始时间:[CtrlTypeDic-{InputTime}]，推荐使用 "_"符号开头 </summary>
        public string Ke_jieshou_kaishiTime
        {
            get { return this.m_ke_jieshou_kaishitime; }
            set //
            {
                if (!ke_jieshou_kaishitime_initialized || m_ke_jieshou_kaishitime != value)
                {
                    this.m_ke_jieshou_kaishitime = value;
                }
                ke_jieshou_kaishitime_initialized = true;
            }
        }
        
        /// <summary> 科目:[Enum-{:不限},{1:数学},{2:英语},{3:语文},{4:物理},{5:化学},{6:生物},{7:政治},{8:历史},{9:地理},{10:奥数},{11:科学},{12:钢琴},{13:书法},{14:舞蹈},{15:素描},{16:国画}][CtrlTypeDic-{SelectMultiple}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 是否置顶:[Enum-{1:是},{2:否}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool On_top
        {
            get { return this.m_on_top; }
            set //
            {
                if (!on_top_initialized || m_on_top != value)
                {
                    this.m_on_top = value;
                }
                on_top_initialized = true;
            }
        }
        
        /// <summary> 置顶超时日期:[IsVisable-{false}][CtrlTypeDic-{InputDate}]，推荐使用 "_"符号开头 </summary>
        public DateTime On_top_timeout
        {
            get { return this.m_on_top_timeout; }
            set //
            {
                if (!on_top_timeout_initialized || m_on_top_timeout != value)
                {
                    this.m_on_top_timeout = value;
                }
                on_top_timeout_initialized = true;
            }
        }
        
        /// <summary> [IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public string OpenID
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> 其他意向区域:[IsVisable-{false}][CtrlTypeDic-{Address}]，推荐使用 "_"符号开头 </summary>
        public string Other_area
        {
            get { return this.m_other_area; }
            set //
            {
                if (!other_area_initialized || m_other_area != value)
                {
                    this.m_other_area = value;
                }
                other_area_initialized = true;
            }
        }
        
        /// <summary> 手机号:[CtrlTypeDic-{InputMobile}]，推荐使用 "_"符号开头 </summary>
        public string Phone_number
        {
            get { return this.m_phone_number; }
            set //
            {
                if (!phone_number_initialized || m_phone_number != value)
                {
                    this.m_phone_number = value;
                }
                phone_number_initialized = true;
            }
        }
        
        /// <summary> 随身照:[CtrlTypeDic-{FileUpImage}]，推荐使用 "_"符号开头 </summary>
        public string Photo
        {
            get { return this.m_photo; }
            set //
            {
                if (!photo_initialized || m_photo != value)
                {
                    this.m_photo = value;
                }
                photo_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputQQ}]，推荐使用 "_"符号开头 </summary>
        public string QQnum
        {
            get { return this.m_qqnum; }
            set //
            {
                if (!qqnum_initialized || m_qqnum != value)
                {
                    this.m_qqnum = value;
                }
                qqnum_initialized = true;
            }
        }
        
        /// <summary> 适合学员，推荐使用 "_"符号开头 </summary>
        public string Recommend
        {
            get { return this.m_recommend; }
            set //
            {
                if (!recommend_initialized || m_recommend != value)
                {
                    this.m_recommend = value;
                }
                recommend_initialized = true;
            }
        }
        
        /// <summary> 高考成绩，推荐使用 "_"符号开头 </summary>
        public string Score_high_school
        {
            get { return this.m_score_high_school; }
            set //
            {
                if (!score_high_school_initialized || m_score_high_school != value)
                {
                    this.m_score_high_school = value;
                }
                score_high_school_initialized = true;
            }
        }
        
        /// <summary> 面试总分，推荐使用 "_"符号开头 </summary>
        public string Score_mianshi
        {
            get { return this.m_score_mianshi; }
            set //
            {
                if (!score_mianshi_initialized || m_score_mianshi != value)
                {
                    this.m_score_mianshi = value;
                }
                score_mianshi_initialized = true;
            }
        }
        
        /// <summary> 面试评分1-经验:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Score_mianshi1
        {
            get { return this.m_score_mianshi1; }
            set //
            {
                if (!score_mianshi1_initialized || m_score_mianshi1 != value)
                {
                    this.m_score_mianshi1 = value;
                }
                score_mianshi1_initialized = true;
            }
        }
        
        /// <summary> 面试评分2-沟通:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Score_mianshi2
        {
            get { return this.m_score_mianshi2; }
            set //
            {
                if (!score_mianshi2_initialized || m_score_mianshi2 != value)
                {
                    this.m_score_mianshi2 = value;
                }
                score_mianshi2_initialized = true;
            }
        }
        
        /// <summary> 面试评分3-技能:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Score_mianshi3
        {
            get { return this.m_score_mianshi3; }
            set //
            {
                if (!score_mianshi3_initialized || m_score_mianshi3 != value)
                {
                    this.m_score_mianshi3 = value;
                }
                score_mianshi3_initialized = true;
            }
        }
        
        /// <summary> 排序权重，推荐使用 "_"符号开头 </summary>
        public double Score_seq
        {
            get { return this.m_score_seq; }
            set //
            {
                if (!score_seq_initialized || m_score_seq != value)
                {
                    this.m_score_seq = value;
                }
                score_seq_initialized = true;
            }
        }
        
        /// <summary> 服务方式:[Enum-{:不限},{1:仅首次上门},{2:上门服务},{3:在线答疑},{4:在线课}][CtrlTypeDic-{SelectMultiple}]，推荐使用 "_"符号开头 </summary>
        public int Service_type
        {
            get { return this.m_service_type; }
            set //
            {
                if (!service_type_initialized || m_service_type != value)
                {
                    this.m_service_type = value;
                }
                service_type_initialized = true;
            }
        }
        
        /// <summary> 性别:[Enum-{:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public int Sex
        {
            get { return this.m_sex; }
            set //
            {
                if (!sex_initialized || m_sex != value)
                {
                    this.m_sex = value;
                }
                sex_initialized = true;
            }
        }
        
        /// <summary> 暑假可教学区域:[CtrlTypeDic-{Address}]，推荐使用 "_"符号开头 </summary>
        public string ShujiaTime
        {
            get { return this.m_shujiatime; }
            set //
            {
                if (!shujiatime_initialized || m_shujiatime != value)
                {
                    this.m_shujiatime = value;
                }
                shujiatime_initialized = true;
            }
        }
        
        /// <summary> 教课经验:[Enum-{:不限},{1:1年以下},{2:2-5年},{3:10年以上}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public int Teach_exp
        {
            get { return this.m_teach_exp; }
            set //
            {
                if (!teach_exp_initialized || m_teach_exp != value)
                {
                    this.m_teach_exp = value;
                }
                teach_exp_initialized = true;
            }
        }
        
        /// <summary> 教学模式:[Enum-{:不限},{1:在线1v1},{2:线下朋友团},{3:1v3小班},{4:1v5小班}][CtrlTypeDic-{SelectMultiple}]，推荐使用 "_"符号开头 </summary>
        public int Teacher_mode
        {
            get { return this.m_teacher_mode; }
            set //
            {
                if (!teacher_mode_initialized || m_teacher_mode != value)
                {
                    this.m_teacher_mode = value;
                }
                teacher_mode_initialized = true;
            }
        }
        
        /// <summary> 讲师姓名，推荐使用 "_"符号开头 </summary>
        public string Teacher_name
        {
            get { return this.m_teacher_name; }
            set //
            {
                if (!teacher_name_initialized || m_teacher_name != value)
                {
                    this.m_teacher_name = value;
                }
                teacher_name_initialized = true;
            }
        }
        
        /// <summary> 讲师英文名，推荐使用 "_"符号开头 </summary>
        public string Teacher_name_en
        {
            get { return this.m_teacher_name_en; }
            set //
            {
                if (!teacher_name_en_initialized || m_teacher_name_en != value)
                {
                    this.m_teacher_name_en = value;
                }
                teacher_name_en_initialized = true;
            }
        }
        
        /// <summary> 讲师类型:[Enum-{0:不限},{1:留学生外教},{2:欧美外教}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public int Teacher_type
        {
            get { return this.m_teacher_type; }
            set //
            {
                if (!teacher_type_initialized || m_teacher_type != value)
                {
                    this.m_teacher_type = value;
                }
                teacher_type_initialized = true;
            }
        }
        
        /// <summary> 课程时间(day_min，返回前端为当前天int值):[CtrlTypeDic-{InputTime}]，推荐使用 "_"符号开头 </summary>
        public string Time_match_ids
        {
            get { return this.m_time_match_ids; }
            set //
            {
                if (!time_match_ids_initialized || m_time_match_ids != value)
                {
                    this.m_time_match_ids = value;
                }
                time_match_ids_initialized = true;
            }
        }
        
        /// <summary> 今日计算结果int，推荐使用 "_"符号开头 </summary>
        public string Today_match_ids
        {
            get { return this.m_today_match_ids; }
            set //
            {
                if (!today_match_ids_initialized || m_today_match_ids != value)
                {
                    this.m_today_match_ids = value;
                }
                today_match_ids_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public bool Type
        {
            get { return this.m_type; }
            set //
            {
                if (!type_initialized || m_type != value)
                {
                    this.m_type = value;
                }
                type_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public Guid User_id
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
        
        /// <summary> [IsVisable-{false}]，推荐使用 "_"符号开头 </summary>
        public Guid Uuid
        {
            get { return this.m_uuid; }
            set //
            {
                if (!uuid_initialized || m_uuid != value)
                {
                    this.m_uuid = value;
                }
                uuid_initialized = true;
            }
        }
        
        /// <summary> 语音介绍，推荐使用 "_"符号开头 </summary>
        public string Voice
        {
            get { return this.m_voice; }
            set //
            {
                if (!voice_initialized || m_voice != value)
                {
                    this.m_voice = value;
                }
                voice_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Weizhi
        {
            get { return this.m_weizhi; }
            set //
            {
                if (!weizhi_initialized || m_weizhi != value)
                {
                    this.m_weizhi = value;
                }
                weizhi_initialized = true;
            }
        }
        
        /// <summary> 意向工作区域，推荐使用 "_"符号开头 </summary>
        public string Work_area
        {
            get { return this.m_work_area; }
            set //
            {
                if (!work_area_initialized || m_work_area != value)
                {
                    this.m_work_area = value;
                }
                work_area_initialized = true;
            }
        }
        
        /// <summary> 工作行业，推荐使用 "_"符号开头 </summary>
        public string Work_field
        {
            get { return this.m_work_field; }
            set //
            {
                if (!work_field_initialized || m_work_field != value)
                {
                    this.m_work_field = value;
                }
                work_field_initialized = true;
            }
        }
        
        /// <summary> 微信市，推荐使用 "_"符号开头 </summary>
        public string Wx_city
        {
            get { return this.m_wx_city; }
            set //
            {
                if (!wx_city_initialized || m_wx_city != value)
                {
                    this.m_wx_city = value;
                }
                wx_city_initialized = true;
            }
        }
        
        /// <summary> 微信国家，推荐使用 "_"符号开头 </summary>
        public string Wx_country
        {
            get { return this.m_wx_country; }
            set //
            {
                if (!wx_country_initialized || m_wx_country != value)
                {
                    this.m_wx_country = value;
                }
                wx_country_initialized = true;
            }
        }
        
        /// <summary> 提交人，推荐使用 "_"符号开头 </summary>
        public string Wx_create_man
        {
            get { return this.m_wx_create_man; }
            set //
            {
                if (!wx_create_man_initialized || m_wx_create_man != value)
                {
                    this.m_wx_create_man = value;
                }
                wx_create_man_initialized = true;
            }
        }
        
        /// <summary> 填写设备，推荐使用 "_"符号开头 </summary>
        public string Wx_device
        {
            get { return this.m_wx_device; }
            set //
            {
                if (!wx_device_initialized || m_wx_device != value)
                {
                    this.m_wx_device = value;
                }
                wx_device_initialized = true;
            }
        }
        
        /// <summary> 浏览器，推荐使用 "_"符号开头 </summary>
        public string Wx_explore
        {
            get { return this.m_wx_explore; }
            set //
            {
                if (!wx_explore_initialized || m_wx_explore != value)
                {
                    this.m_wx_explore = value;
                }
                wx_explore_initialized = true;
            }
        }
        
        /// <summary> 微信头像:[CtrlTypeDic-{FileUpImage}]，推荐使用 "_"符号开头 </summary>
        public string Wx_head_img
        {
            get { return this.m_wx_head_img; }
            set //
            {
                if (!wx_head_img_initialized || m_wx_head_img != value)
                {
                    this.m_wx_head_img = value;
                }
                wx_head_img_initialized = true;
            }
        }
        
        /// <summary> 修改时间:[CtrlTypeDic-{InputTime}]，推荐使用 "_"符号开头 </summary>
        public string Wx_modify_time
        {
            get { return this.m_wx_modify_time; }
            set //
            {
                if (!wx_modify_time_initialized || m_wx_modify_time != value)
                {
                    this.m_wx_modify_time = value;
                }
                wx_modify_time_initialized = true;
            }
        }
        
        /// <summary> 微信昵称，推荐使用 "_"符号开头 </summary>
        public string Wx_nick_name
        {
            get { return this.m_wx_nick_name; }
            set //
            {
                if (!wx_nick_name_initialized || m_wx_nick_name != value)
                {
                    this.m_wx_nick_name = value;
                }
                wx_nick_name_initialized = true;
            }
        }
        
        /// <summary> 操作系统，推荐使用 "_"符号开头 </summary>
        public string Wx_os
        {
            get { return this.m_wx_os; }
            set //
            {
                if (!wx_os_initialized || m_wx_os != value)
                {
                    this.m_wx_os = value;
                }
                wx_os_initialized = true;
            }
        }
        
        /// <summary> 提交时间:[CtrlTypeDic-{InputTime}]，推荐使用 "_"符号开头 </summary>
        public string Wx_post_time
        {
            get { return this.m_wx_post_time; }
            set //
            {
                if (!wx_post_time_initialized || m_wx_post_time != value)
                {
                    this.m_wx_post_time = value;
                }
                wx_post_time_initialized = true;
            }
        }
        
        /// <summary> 微信省市，推荐使用 "_"符号开头 </summary>
        public string Wx_province
        {
            get { return this.m_wx_province; }
            set //
            {
                if (!wx_province_initialized || m_wx_province != value)
                {
                    this.m_wx_province = value;
                }
                wx_province_initialized = true;
            }
        }
        
        /// <summary> 微信性别:[Enum-{1:男},{2:女}][CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public string Wx_sex
        {
            get { return this.m_wx_sex; }
            set //
            {
                if (!wx_sex_initialized || m_wx_sex != value)
                {
                    this.m_wx_sex = value;
                }
                wx_sex_initialized = true;
            }
        }
        
        /// <summary> 评语:[CtrlTypeDic-{Text}]，推荐使用 "_"符号开头 </summary>
        public string Xuebapingyu
        {
            get { return this.m_xuebapingyu; }
            set //
            {
                if (!xuebapingyu_initialized || m_xuebapingyu != value)
                {
                    this.m_xuebapingyu = value;
                }
                xuebapingyu_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>序号</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_teacher_resume].[Id]", typeof(int), 4, default(int));
            
            /// <summary>出生年月:[CtrlTypeDic-{InputDate}]</summary>
            public static AttributeItem Born =  new AttributeItem("[Xb_teacher_resume].[Born]", typeof(string), 100, default(string));
            
            /// <summary>大类:[Enum-{0:优选教员},{1:外教},{2:小班课},{3:暑期课}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Catelog =  new AttributeItem("[Xb_teacher_resume].[Catelog]", typeof(int), 4, default(int));
            
            /// <summary>[IsVisable-{false}]</summary>
            public static AttributeItem City_id =  new AttributeItem("[Xb_teacher_resume].[City_id]", typeof(string), 50, default(string));
            
            /// <summary>大学</summary>
            public static AttributeItem College =  new AttributeItem("[Xb_teacher_resume].[College]", typeof(string), 100, default(string));
            
            /// <summary>专业:[IsVisable-{false}]</summary>
            public static AttributeItem College_major =  new AttributeItem("[Xb_teacher_resume].[College_major]", typeof(string), 100, default(string));
            
            /// <summary>填写日期:[CtrlTypeDic-{InputDate}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xb_teacher_resume].[Create_time]", typeof(string), 255, default(string));
            
            /// <summary>二维码:[IsVisable-{false}][CtrlTypeDic-{FileUpImage}]</summary>
            public static AttributeItem E_wei_ma =  new AttributeItem("[Xb_teacher_resume].[E_wei_ma]", typeof(string), 200, default(string));
            
            /// <summary>科目:[Enum-{0:生活口语},{1:自由会话},{2:青少年英语},{3:雅思英语},{4:新托福英语},{5:商务英语},{6:旅游英语},{7:文化话题英语},{8:时事英语},{9:青少全能新概念},{10:综合口语},{11:经典英语（成人版）},{12:经典英语（青少版）}][IsVisable-{false}][CtrlTypeDic-{SelectMultiple}]</summary>
            public static AttributeItem English_kemu =  new AttributeItem("[Xb_teacher_resume].[English_kemu]", typeof(int), 4, default(int));
            
            /// <summary>经验:[Enum-{0:暂无},{1:1V1},{2:小班2人以上},{3:大班6人以上}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Experience =  new AttributeItem("[Xb_teacher_resume].[Experience]", typeof(int), 4, default(int));
            
            /// <summary>经验:[IsVisable-{false}]</summary>
            public static AttributeItem Experience_intro =  new AttributeItem("[Xb_teacher_resume].[Experience_intro]", typeof(string), 2000, default(string));
            
            /// <summary>教课经验:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Experience_year =  new AttributeItem("[Xb_teacher_resume].[Experience_year]", typeof(double), 8, default(double));
            
            /// <summary>[IsVisable-{false}]</summary>
            public static AttributeItem F26 =  new AttributeItem("[Xb_teacher_resume].[F26]", typeof(string), 255, default(string));
            
            /// <summary>[IsVisable-{false}]</summary>
            public static AttributeItem F27 =  new AttributeItem("[Xb_teacher_resume].[F27]", typeof(string), 255, default(string));
            
            /// <summary>擅长科目:[IsVisable-{false}][IsReadOnly-{true}][CtrlTypeDic-{SelectMultiple}]</summary>
            public static AttributeItem Good_at =  new AttributeItem("[Xb_teacher_resume].[Good_at]", typeof(string), 2000, default(string));
            
            /// <summary>[IsVisable-{false}]</summary>
            public static AttributeItem Good_kemu =  new AttributeItem("[Xb_teacher_resume].[Good_kemu]", typeof(string), 2000, default(string));
            
            /// <summary>[IsVisable-{false}]</summary>
            public static AttributeItem Good_nianji =  new AttributeItem("[Xb_teacher_resume].[Good_nianji]", typeof(string), 2000, default(string));
            
            /// <summary>年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectMultiple}]</summary>
            public static AttributeItem Grade =  new AttributeItem("[Xb_teacher_resume].[Grade]", typeof(string), 50, default(string));
            
            /// <summary>已被预约的课程时间(day_min，返回前端为当前天int值):[IsVisable-{false}][CtrlTypeDic-{InputTime}]</summary>
            public static AttributeItem Has_time_match_ids =  new AttributeItem("[Xb_teacher_resume].[Has_time_match_ids]", typeof(string), -1, default(string));
            
            /// <summary>今日已预约计算结果int:[IsVisable-{false}]</summary>
            public static AttributeItem Has_today_match_ids =  new AttributeItem("[Xb_teacher_resume].[Has_today_match_ids]", typeof(string), 1000, default(string));
            
            /// <summary>高中:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem High_school =  new AttributeItem("[Xb_teacher_resume].[High_school]", typeof(string), 2000, default(string));
            
            /// <summary>家乡:[CtrlTypeDic-{Address}]</summary>
            public static AttributeItem Home_area =  new AttributeItem("[Xb_teacher_resume].[Home_area]", typeof(string), 2000, default(string));
            
            /// <summary>自我简介:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Introduce =  new AttributeItem("[Xb_teacher_resume].[Introduce]", typeof(string), 1500, default(string));
            
            /// <summary>英语自我介绍:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Introduce_en =  new AttributeItem("[Xb_teacher_resume].[Introduce_en]", typeof(string), 3000, default(string));
            
            /// <summary>Ip地址</summary>
            public static AttributeItem IP =  new AttributeItem("[Xb_teacher_resume].[IP]", typeof(string), 255, default(string));
            
            /// <summary>是否有成交:[Enum-{yes:是},{no:否}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Is_done =  new AttributeItem("[Xb_teacher_resume].[Is_done]", typeof(bool), 1, default(bool));
            
            /// <summary>是否推荐:[Enum-{yes:是},{no:否}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Is_recommend =  new AttributeItem("[Xb_teacher_resume].[Is_recommend]", typeof(bool), 1, default(bool));
            
            /// <summary>是否显示:[Enum-{yes:是},{not:否}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Is_show =  new AttributeItem("[Xb_teacher_resume].[Is_show]", typeof(bool), 1, default(bool));
            
            /// <summary>家教经验:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Jin_experience =  new AttributeItem("[Xb_teacher_resume].[Jin_experience]", typeof(string), 2000, default(string));
            
            /// <summary>性别:[Enum-{:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Jin_sex =  new AttributeItem("[Xb_teacher_resume].[Jin_sex]", typeof(string), 50, default(string));
            
            /// <summary>开学可教学时间:[CtrlTypeDic-{InputTime}]</summary>
            public static AttributeItem KaixueTime =  new AttributeItem("[Xb_teacher_resume].[KaixueTime]", typeof(string), 2000, default(string));
            
            /// <summary>课程结束时间:[CtrlTypeDic-{InputTime}]</summary>
            public static AttributeItem Ke_jieshou_jiesuTime =  new AttributeItem("[Xb_teacher_resume].[Ke_jieshou_jiesuTime]", typeof(string), 2000, default(string));
            
            /// <summary>课程开始时间:[CtrlTypeDic-{InputTime}]</summary>
            public static AttributeItem Ke_jieshou_kaishiTime =  new AttributeItem("[Xb_teacher_resume].[Ke_jieshou_kaishiTime]", typeof(string), 2000, default(string));
            
            /// <summary>科目:[Enum-{:不限},{1:数学},{2:英语},{3:语文},{4:物理},{5:化学},{6:生物},{7:政治},{8:历史},{9:地理},{10:奥数},{11:科学},{12:钢琴},{13:书法},{14:舞蹈},{15:素描},{16:国画}][CtrlTypeDic-{SelectMultiple}]</summary>
            public static AttributeItem Kemu =  new AttributeItem("[Xb_teacher_resume].[Kemu]", typeof(string), 50, default(string));
            
            /// <summary>是否置顶:[Enum-{1:是},{2:否}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem On_top =  new AttributeItem("[Xb_teacher_resume].[On_top]", typeof(bool), 1, default(bool));
            
            /// <summary>置顶超时日期:[IsVisable-{false}][CtrlTypeDic-{InputDate}]</summary>
            public static AttributeItem On_top_timeout =  new AttributeItem("[Xb_teacher_resume].[On_top_timeout]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[IsVisable-{false}]</summary>
            public static AttributeItem OpenID =  new AttributeItem("[Xb_teacher_resume].[OpenID]", typeof(string), 36, default(string));
            
            /// <summary>其他意向区域:[IsVisable-{false}][CtrlTypeDic-{Address}]</summary>
            public static AttributeItem Other_area =  new AttributeItem("[Xb_teacher_resume].[Other_area]", typeof(string), 2000, default(string));
            
            /// <summary>手机号:[CtrlTypeDic-{InputMobile}]</summary>
            public static AttributeItem Phone_number =  new AttributeItem("[Xb_teacher_resume].[Phone_number]", typeof(string), 100, default(string));
            
            /// <summary>随身照:[CtrlTypeDic-{FileUpImage}]</summary>
            public static AttributeItem Photo =  new AttributeItem("[Xb_teacher_resume].[Photo]", typeof(string), 255, default(string));
            
            /// <summary>[CtrlTypeDic-{InputQQ}]</summary>
            public static AttributeItem QQnum =  new AttributeItem("[Xb_teacher_resume].[QQnum]", typeof(string), 2000, default(string));
            
            /// <summary>适合学员</summary>
            public static AttributeItem Recommend =  new AttributeItem("[Xb_teacher_resume].[Recommend]", typeof(string), 100, default(string));
            
            /// <summary>高考成绩</summary>
            public static AttributeItem Score_high_school =  new AttributeItem("[Xb_teacher_resume].[Score_high_school]", typeof(string), 1000, default(string));
            
            /// <summary>面试总分</summary>
            public static AttributeItem Score_mianshi =  new AttributeItem("[Xb_teacher_resume].[Score_mianshi]", typeof(string), 100, default(string));
            
            /// <summary>面试评分1-经验:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Score_mianshi1 =  new AttributeItem("[Xb_teacher_resume].[Score_mianshi1]", typeof(string), 100, default(string));
            
            /// <summary>面试评分2-沟通:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Score_mianshi2 =  new AttributeItem("[Xb_teacher_resume].[Score_mianshi2]", typeof(string), 100, default(string));
            
            /// <summary>面试评分3-技能:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Score_mianshi3 =  new AttributeItem("[Xb_teacher_resume].[Score_mianshi3]", typeof(string), 100, default(string));
            
            /// <summary>排序权重</summary>
            public static AttributeItem Score_seq =  new AttributeItem("[Xb_teacher_resume].[Score_seq]", typeof(double), 8, default(double));
            
            /// <summary>服务方式:[Enum-{:不限},{1:仅首次上门},{2:上门服务},{3:在线答疑},{4:在线课}][CtrlTypeDic-{SelectMultiple}]</summary>
            public static AttributeItem Service_type =  new AttributeItem("[Xb_teacher_resume].[Service_type]", typeof(int), 4, default(int));
            
            /// <summary>性别:[Enum-{:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Sex =  new AttributeItem("[Xb_teacher_resume].[Sex]", typeof(int), 4, default(int));
            
            /// <summary>暑假可教学区域:[CtrlTypeDic-{Address}]</summary>
            public static AttributeItem ShujiaTime =  new AttributeItem("[Xb_teacher_resume].[ShujiaTime]", typeof(string), 2000, default(string));
            
            /// <summary>教课经验:[Enum-{:不限},{1:1年以下},{2:2-5年},{3:10年以上}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Teach_exp =  new AttributeItem("[Xb_teacher_resume].[Teach_exp]", typeof(int), 4, default(int));
            
            /// <summary>教学模式:[Enum-{:不限},{1:在线1v1},{2:线下朋友团},{3:1v3小班},{4:1v5小班}][CtrlTypeDic-{SelectMultiple}]</summary>
            public static AttributeItem Teacher_mode =  new AttributeItem("[Xb_teacher_resume].[Teacher_mode]", typeof(int), 4, default(int));
            
            /// <summary>讲师姓名</summary>
            public static AttributeItem Teacher_name =  new AttributeItem("[Xb_teacher_resume].[Teacher_name]", typeof(string), 100, default(string));
            
            /// <summary>讲师英文名</summary>
            public static AttributeItem Teacher_name_en =  new AttributeItem("[Xb_teacher_resume].[Teacher_name_en]", typeof(string), 100, default(string));
            
            /// <summary>讲师类型:[Enum-{0:不限},{1:留学生外教},{2:欧美外教}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Teacher_type =  new AttributeItem("[Xb_teacher_resume].[Teacher_type]", typeof(int), 4, default(int));
            
            /// <summary>课程时间(day_min，返回前端为当前天int值):[CtrlTypeDic-{InputTime}]</summary>
            public static AttributeItem Time_match_ids =  new AttributeItem("[Xb_teacher_resume].[Time_match_ids]", typeof(string), -1, default(string));
            
            /// <summary>今日计算结果int</summary>
            public static AttributeItem Today_match_ids =  new AttributeItem("[Xb_teacher_resume].[Today_match_ids]", typeof(string), 1000, default(string));
            
            /// <summary></summary>
            public static AttributeItem Type =  new AttributeItem("[Xb_teacher_resume].[Type]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_teacher_resume].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[IsVisable-{false}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_teacher_resume].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>语音介绍</summary>
            public static AttributeItem Voice =  new AttributeItem("[Xb_teacher_resume].[Voice]", typeof(string), 300, default(string));
            
            /// <summary></summary>
            public static AttributeItem Weizhi =  new AttributeItem("[Xb_teacher_resume].[Weizhi]", typeof(string), 2000, default(string));
            
            /// <summary>意向工作区域</summary>
            public static AttributeItem Work_area =  new AttributeItem("[Xb_teacher_resume].[Work_area]", typeof(string), 2000, default(string));
            
            /// <summary>工作行业</summary>
            public static AttributeItem Work_field =  new AttributeItem("[Xb_teacher_resume].[Work_field]", typeof(string), 100, default(string));
            
            /// <summary>微信市</summary>
            public static AttributeItem Wx_city =  new AttributeItem("[Xb_teacher_resume].[Wx_city]", typeof(string), 255, default(string));
            
            /// <summary>微信国家</summary>
            public static AttributeItem Wx_country =  new AttributeItem("[Xb_teacher_resume].[Wx_country]", typeof(string), 255, default(string));
            
            /// <summary>提交人</summary>
            public static AttributeItem Wx_create_man =  new AttributeItem("[Xb_teacher_resume].[Wx_create_man]", typeof(string), 255, default(string));
            
            /// <summary>填写设备</summary>
            public static AttributeItem Wx_device =  new AttributeItem("[Xb_teacher_resume].[Wx_device]", typeof(string), 255, default(string));
            
            /// <summary>浏览器</summary>
            public static AttributeItem Wx_explore =  new AttributeItem("[Xb_teacher_resume].[Wx_explore]", typeof(string), 255, default(string));
            
            /// <summary>微信头像:[CtrlTypeDic-{FileUpImage}]</summary>
            public static AttributeItem Wx_head_img =  new AttributeItem("[Xb_teacher_resume].[Wx_head_img]", typeof(string), 255, default(string));
            
            /// <summary>修改时间:[CtrlTypeDic-{InputTime}]</summary>
            public static AttributeItem Wx_modify_time =  new AttributeItem("[Xb_teacher_resume].[Wx_modify_time]", typeof(string), 255, default(string));
            
            /// <summary>微信昵称</summary>
            public static AttributeItem Wx_nick_name =  new AttributeItem("[Xb_teacher_resume].[Wx_nick_name]", typeof(string), 255, default(string));
            
            /// <summary>操作系统</summary>
            public static AttributeItem Wx_os =  new AttributeItem("[Xb_teacher_resume].[Wx_os]", typeof(string), 255, default(string));
            
            /// <summary>提交时间:[CtrlTypeDic-{InputTime}]</summary>
            public static AttributeItem Wx_post_time =  new AttributeItem("[Xb_teacher_resume].[Wx_post_time]", typeof(string), 255, default(string));
            
            /// <summary>微信省市</summary>
            public static AttributeItem Wx_province =  new AttributeItem("[Xb_teacher_resume].[Wx_province]", typeof(string), 255, default(string));
            
            /// <summary>微信性别:[Enum-{1:男},{2:女}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Wx_sex =  new AttributeItem("[Xb_teacher_resume].[Wx_sex]", typeof(string), 255, default(string));
            
            /// <summary>评语:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Xuebapingyu =  new AttributeItem("[Xb_teacher_resume].[Xuebapingyu]", typeof(string), 2000, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_born;
        /// <summary></summary>
        protected bool born_initialized = false;
        
        private int m_catelog;
        /// <summary></summary>
        protected bool catelog_initialized = false;
        
        private string m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        
        private string m_college;
        /// <summary></summary>
        protected bool college_initialized = false;
        
        private string m_college_major;
        /// <summary></summary>
        protected bool college_major_initialized = false;
        
        private string m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_e_wei_ma;
        /// <summary></summary>
        protected bool e_wei_ma_initialized = false;
        
        private int m_english_kemu;
        /// <summary></summary>
        protected bool english_kemu_initialized = false;
        
        private int m_experience;
        /// <summary></summary>
        protected bool experience_initialized = false;
        
        private string m_experience_intro;
        /// <summary></summary>
        protected bool experience_intro_initialized = false;
        
        private double m_experience_year;
        /// <summary></summary>
        protected bool experience_year_initialized = false;
        
        private string m_f26;
        /// <summary></summary>
        protected bool f26_initialized = false;
        
        private string m_f27;
        /// <summary></summary>
        protected bool f27_initialized = false;
        
        private string m_good_at;
        /// <summary></summary>
        protected bool good_at_initialized = false;
        
        private string m_good_kemu;
        /// <summary></summary>
        protected bool good_kemu_initialized = false;
        
        private string m_good_nianji;
        /// <summary></summary>
        protected bool good_nianji_initialized = false;
        
        private string m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private string m_has_time_match_ids;
        /// <summary></summary>
        protected bool has_time_match_ids_initialized = false;
        
        private string m_has_today_match_ids;
        /// <summary></summary>
        protected bool has_today_match_ids_initialized = false;
        
        private string m_high_school;
        /// <summary></summary>
        protected bool high_school_initialized = false;
        
        private string m_home_area;
        /// <summary></summary>
        protected bool home_area_initialized = false;
        
        private string m_introduce;
        /// <summary></summary>
        protected bool introduce_initialized = false;
        
        private string m_introduce_en;
        /// <summary></summary>
        protected bool introduce_en_initialized = false;
        
        private string m_ip;
        /// <summary></summary>
        protected bool ip_initialized = false;
        
        private bool m_is_done;
        /// <summary></summary>
        protected bool is_done_initialized = false;
        
        private bool m_is_recommend;
        /// <summary></summary>
        protected bool is_recommend_initialized = false;
        
        private bool m_is_show;
        /// <summary></summary>
        protected bool is_show_initialized = false;
        
        private string m_jin_experience;
        /// <summary></summary>
        protected bool jin_experience_initialized = false;
        
        private string m_jin_sex;
        /// <summary></summary>
        protected bool jin_sex_initialized = false;
        
        private string m_kaixuetime;
        /// <summary></summary>
        protected bool kaixuetime_initialized = false;
        
        private string m_ke_jieshou_jiesutime;
        /// <summary></summary>
        protected bool ke_jieshou_jiesutime_initialized = false;
        
        private string m_ke_jieshou_kaishitime;
        /// <summary></summary>
        protected bool ke_jieshou_kaishitime_initialized = false;
        
        private string m_kemu;
        /// <summary></summary>
        protected bool kemu_initialized = false;
        
        private bool m_on_top;
        /// <summary></summary>
        protected bool on_top_initialized = false;
        
        private DateTime m_on_top_timeout;
        /// <summary></summary>
        protected bool on_top_timeout_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_other_area;
        /// <summary></summary>
        protected bool other_area_initialized = false;
        
        private string m_phone_number;
        /// <summary></summary>
        protected bool phone_number_initialized = false;
        
        private string m_photo;
        /// <summary></summary>
        protected bool photo_initialized = false;
        
        private string m_qqnum;
        /// <summary></summary>
        protected bool qqnum_initialized = false;
        
        private string m_recommend;
        /// <summary></summary>
        protected bool recommend_initialized = false;
        
        private string m_score_high_school;
        /// <summary></summary>
        protected bool score_high_school_initialized = false;
        
        private string m_score_mianshi;
        /// <summary></summary>
        protected bool score_mianshi_initialized = false;
        
        private string m_score_mianshi1;
        /// <summary></summary>
        protected bool score_mianshi1_initialized = false;
        
        private string m_score_mianshi2;
        /// <summary></summary>
        protected bool score_mianshi2_initialized = false;
        
        private string m_score_mianshi3;
        /// <summary></summary>
        protected bool score_mianshi3_initialized = false;
        
        private double m_score_seq;
        /// <summary></summary>
        protected bool score_seq_initialized = false;
        
        private int m_service_type;
        /// <summary></summary>
        protected bool service_type_initialized = false;
        
        private int m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private string m_shujiatime;
        /// <summary></summary>
        protected bool shujiatime_initialized = false;
        
        private int m_teach_exp;
        /// <summary></summary>
        protected bool teach_exp_initialized = false;
        
        private int m_teacher_mode;
        /// <summary></summary>
        protected bool teacher_mode_initialized = false;
        
        private string m_teacher_name;
        /// <summary></summary>
        protected bool teacher_name_initialized = false;
        
        private string m_teacher_name_en;
        /// <summary></summary>
        protected bool teacher_name_en_initialized = false;
        
        private int m_teacher_type;
        /// <summary></summary>
        protected bool teacher_type_initialized = false;
        
        private string m_time_match_ids;
        /// <summary></summary>
        protected bool time_match_ids_initialized = false;
        
        private string m_today_match_ids;
        /// <summary></summary>
        protected bool today_match_ids_initialized = false;
        
        private bool m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_voice;
        /// <summary></summary>
        protected bool voice_initialized = false;
        
        private string m_weizhi;
        /// <summary></summary>
        protected bool weizhi_initialized = false;
        
        private string m_work_area;
        /// <summary></summary>
        protected bool work_area_initialized = false;
        
        private string m_work_field;
        /// <summary></summary>
        protected bool work_field_initialized = false;
        
        private string m_wx_city;
        /// <summary></summary>
        protected bool wx_city_initialized = false;
        
        private string m_wx_country;
        /// <summary></summary>
        protected bool wx_country_initialized = false;
        
        private string m_wx_create_man;
        /// <summary></summary>
        protected bool wx_create_man_initialized = false;
        
        private string m_wx_device;
        /// <summary></summary>
        protected bool wx_device_initialized = false;
        
        private string m_wx_explore;
        /// <summary></summary>
        protected bool wx_explore_initialized = false;
        
        private string m_wx_head_img;
        /// <summary></summary>
        protected bool wx_head_img_initialized = false;
        
        private string m_wx_modify_time;
        /// <summary></summary>
        protected bool wx_modify_time_initialized = false;
        
        private string m_wx_nick_name;
        /// <summary></summary>
        protected bool wx_nick_name_initialized = false;
        
        private string m_wx_os;
        /// <summary></summary>
        protected bool wx_os_initialized = false;
        
        private string m_wx_post_time;
        /// <summary></summary>
        protected bool wx_post_time_initialized = false;
        
        private string m_wx_province;
        /// <summary></summary>
        protected bool wx_province_initialized = false;
        
        private string m_wx_sex;
        /// <summary></summary>
        protected bool wx_sex_initialized = false;
        
        private string m_xuebapingyu;
        /// <summary></summary>
        protected bool xuebapingyu_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_teacher_resume";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.born_initialized = IsLoadAllAttributes;this.catelog_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;this.college_initialized = IsLoadAllAttributes;this.college_major_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.e_wei_ma_initialized = IsLoadAllAttributes;this.english_kemu_initialized = IsLoadAllAttributes;this.experience_initialized = IsLoadAllAttributes;this.experience_intro_initialized = IsLoadAllAttributes;this.experience_year_initialized = IsLoadAllAttributes;this.f26_initialized = IsLoadAllAttributes;this.f27_initialized = IsLoadAllAttributes;this.good_at_initialized = IsLoadAllAttributes;this.good_kemu_initialized = IsLoadAllAttributes;this.good_nianji_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.has_time_match_ids_initialized = IsLoadAllAttributes;this.has_today_match_ids_initialized = IsLoadAllAttributes;this.high_school_initialized = IsLoadAllAttributes;this.home_area_initialized = IsLoadAllAttributes;this.introduce_initialized = IsLoadAllAttributes;this.introduce_en_initialized = IsLoadAllAttributes;this.ip_initialized = IsLoadAllAttributes;this.is_done_initialized = IsLoadAllAttributes;this.is_recommend_initialized = IsLoadAllAttributes;this.is_show_initialized = IsLoadAllAttributes;this.jin_experience_initialized = IsLoadAllAttributes;this.jin_sex_initialized = IsLoadAllAttributes;this.kaixuetime_initialized = IsLoadAllAttributes;this.ke_jieshou_jiesutime_initialized = IsLoadAllAttributes;this.ke_jieshou_kaishitime_initialized = IsLoadAllAttributes;this.kemu_initialized = IsLoadAllAttributes;this.on_top_initialized = IsLoadAllAttributes;this.on_top_timeout_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.other_area_initialized = IsLoadAllAttributes;this.phone_number_initialized = IsLoadAllAttributes;this.photo_initialized = IsLoadAllAttributes;this.qqnum_initialized = IsLoadAllAttributes;this.recommend_initialized = IsLoadAllAttributes;this.score_high_school_initialized = IsLoadAllAttributes;this.score_mianshi_initialized = IsLoadAllAttributes;this.score_mianshi1_initialized = IsLoadAllAttributes;this.score_mianshi2_initialized = IsLoadAllAttributes;this.score_mianshi3_initialized = IsLoadAllAttributes;this.score_seq_initialized = IsLoadAllAttributes;this.service_type_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.shujiatime_initialized = IsLoadAllAttributes;this.teach_exp_initialized = IsLoadAllAttributes;this.teacher_mode_initialized = IsLoadAllAttributes;this.teacher_name_initialized = IsLoadAllAttributes;this.teacher_name_en_initialized = IsLoadAllAttributes;this.teacher_type_initialized = IsLoadAllAttributes;this.time_match_ids_initialized = IsLoadAllAttributes;this.today_match_ids_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.voice_initialized = IsLoadAllAttributes;this.weizhi_initialized = IsLoadAllAttributes;this.work_area_initialized = IsLoadAllAttributes;this.work_field_initialized = IsLoadAllAttributes;this.wx_city_initialized = IsLoadAllAttributes;this.wx_country_initialized = IsLoadAllAttributes;this.wx_create_man_initialized = IsLoadAllAttributes;this.wx_device_initialized = IsLoadAllAttributes;this.wx_explore_initialized = IsLoadAllAttributes;this.wx_head_img_initialized = IsLoadAllAttributes;this.wx_modify_time_initialized = IsLoadAllAttributes;this.wx_nick_name_initialized = IsLoadAllAttributes;this.wx_os_initialized = IsLoadAllAttributes;this.wx_post_time_initialized = IsLoadAllAttributes;this.wx_province_initialized = IsLoadAllAttributes;this.wx_sex_initialized = IsLoadAllAttributes;this.xuebapingyu_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_teacher_resume value = new Xb_teacher_resume();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Born"))
				value.born_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Catelog"))
				value.catelog_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College"))
				value.college_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College_major"))
				value.college_major_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"E_wei_ma"))
				value.e_wei_ma_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"English_kemu"))
				value.english_kemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Experience"))
				value.experience_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Experience_intro"))
				value.experience_intro_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Experience_year"))
				value.experience_year_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"F26"))
				value.f26_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"F27"))
				value.f27_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Good_at"))
				value.good_at_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Good_kemu"))
				value.good_kemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Good_nianji"))
				value.good_nianji_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Has_time_match_ids"))
				value.has_time_match_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Has_today_match_ids"))
				value.has_today_match_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"High_school"))
				value.high_school_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Home_area"))
				value.home_area_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Introduce"))
				value.introduce_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Introduce_en"))
				value.introduce_en_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IP"))
				value.ip_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_done"))
				value.is_done_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_recommend"))
				value.is_recommend_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_show"))
				value.is_show_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Jin_experience"))
				value.jin_experience_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Jin_sex"))
				value.jin_sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KaixueTime"))
				value.kaixuetime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Ke_jieshou_jiesuTime"))
				value.ke_jieshou_jiesutime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Ke_jieshou_kaishiTime"))
				value.ke_jieshou_kaishitime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu"))
				value.kemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"On_top"))
				value.on_top_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"On_top_timeout"))
				value.on_top_timeout_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenID"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Other_area"))
				value.other_area_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_number"))
				value.phone_number_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Photo"))
				value.photo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QQnum"))
				value.qqnum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Recommend"))
				value.recommend_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_high_school"))
				value.score_high_school_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_mianshi"))
				value.score_mianshi_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_mianshi1"))
				value.score_mianshi1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_mianshi2"))
				value.score_mianshi2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_mianshi3"))
				value.score_mianshi3_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_seq"))
				value.score_seq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Service_type"))
				value.service_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShujiaTime"))
				value.shujiatime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teach_exp"))
				value.teach_exp_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_mode"))
				value.teacher_mode_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_name"))
				value.teacher_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_name_en"))
				value.teacher_name_en_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_type"))
				value.teacher_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time_match_ids"))
				value.time_match_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Today_match_ids"))
				value.today_match_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Voice"))
				value.voice_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Weizhi"))
				value.weizhi_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Work_area"))
				value.work_area_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Work_field"))
				value.work_field_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_city"))
				value.wx_city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_country"))
				value.wx_country_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_create_man"))
				value.wx_create_man_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_device"))
				value.wx_device_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_explore"))
				value.wx_explore_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_head_img"))
				value.wx_head_img_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_modify_time"))
				value.wx_modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_nick_name"))
				value.wx_nick_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_os"))
				value.wx_os_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_post_time"))
				value.wx_post_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_province"))
				value.wx_province_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wx_sex"))
				value.wx_sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Xuebapingyu"))
				value.xuebapingyu_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_teacher_resume Clone()
        {
            return (Xb_teacher_resume)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_teacher_resume()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_teacher_resume() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_teacher_resume(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_teacher_resume(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_teacher_resume(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_teacher_resume(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_teacher_resume(int id1, string born1, int catelog1, string city_id1, string college1, string college_major1, string create_time1, string e_wei_ma1, int english_kemu1, int experience1, string experience_intro1, double experience_year1, string f261, string f271, string good_at1, string good_kemu1, string good_nianji1, string grade1, string has_time_match_ids1, string has_today_match_ids1, string high_school1, string home_area1, string introduce1, string introduce_en1, string ip1, bool is_done1, bool is_recommend1, bool is_show1, string jin_experience1, string jin_sex1, string kaixuetime1, string ke_jieshou_jiesutime1, string ke_jieshou_kaishitime1, string kemu1, bool on_top1, DateTime on_top_timeout1, string openid1, string other_area1, string phone_number1, string photo1, string qqnum1, string recommend1, string score_high_school1, string score_mianshi1, string score_mianshi11, string score_mianshi21, string score_mianshi31, double score_seq1, int service_type1, int sex1, string shujiatime1, int teach_exp1, int teacher_mode1, string teacher_name1, string teacher_name_en1, int teacher_type1, string time_match_ids1, string today_match_ids1, bool type1, Guid user_id1, Guid uuid1, string voice1, string weizhi1, string work_area1, string work_field1, string wx_city1, string wx_country1, string wx_create_man1, string wx_device1, string wx_explore1, string wx_head_img1, string wx_modify_time1, string wx_nick_name1, string wx_os1, string wx_post_time1, string wx_province1, string wx_sex1, string xuebapingyu1)
        {
            
            this.Id = id1;
            
            this.Born = born1;
            
            this.Catelog = catelog1;
            
            this.City_id = city_id1;
            
            this.College = college1;
            
            this.College_major = college_major1;
            
            this.Create_time = create_time1;
            
            this.E_wei_ma = e_wei_ma1;
            
            this.English_kemu = english_kemu1;
            
            this.Experience = experience1;
            
            this.Experience_intro = experience_intro1;
            
            this.Experience_year = experience_year1;
            
            this.F26 = f261;
            
            this.F27 = f271;
            
            this.Good_at = good_at1;
            
            this.Good_kemu = good_kemu1;
            
            this.Good_nianji = good_nianji1;
            
            this.Grade = grade1;
            
            this.Has_time_match_ids = has_time_match_ids1;
            
            this.Has_today_match_ids = has_today_match_ids1;
            
            this.High_school = high_school1;
            
            this.Home_area = home_area1;
            
            this.Introduce = introduce1;
            
            this.Introduce_en = introduce_en1;
            
            this.IP = ip1;
            
            this.Is_done = is_done1;
            
            this.Is_recommend = is_recommend1;
            
            this.Is_show = is_show1;
            
            this.Jin_experience = jin_experience1;
            
            this.Jin_sex = jin_sex1;
            
            this.KaixueTime = kaixuetime1;
            
            this.Ke_jieshou_jiesuTime = ke_jieshou_jiesutime1;
            
            this.Ke_jieshou_kaishiTime = ke_jieshou_kaishitime1;
            
            this.Kemu = kemu1;
            
            this.On_top = on_top1;
            
            this.On_top_timeout = on_top_timeout1;
            
            this.OpenID = openid1;
            
            this.Other_area = other_area1;
            
            this.Phone_number = phone_number1;
            
            this.Photo = photo1;
            
            this.QQnum = qqnum1;
            
            this.Recommend = recommend1;
            
            this.Score_high_school = score_high_school1;
            
            this.Score_mianshi = score_mianshi1;
            
            this.Score_mianshi1 = score_mianshi11;
            
            this.Score_mianshi2 = score_mianshi21;
            
            this.Score_mianshi3 = score_mianshi31;
            
            this.Score_seq = score_seq1;
            
            this.Service_type = service_type1;
            
            this.Sex = sex1;
            
            this.ShujiaTime = shujiatime1;
            
            this.Teach_exp = teach_exp1;
            
            this.Teacher_mode = teacher_mode1;
            
            this.Teacher_name = teacher_name1;
            
            this.Teacher_name_en = teacher_name_en1;
            
            this.Teacher_type = teacher_type1;
            
            this.Time_match_ids = time_match_ids1;
            
            this.Today_match_ids = today_match_ids1;
            
            this.Type = type1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
            
            this.Voice = voice1;
            
            this.Weizhi = weizhi1;
            
            this.Work_area = work_area1;
            
            this.Work_field = work_field1;
            
            this.Wx_city = wx_city1;
            
            this.Wx_country = wx_country1;
            
            this.Wx_create_man = wx_create_man1;
            
            this.Wx_device = wx_device1;
            
            this.Wx_explore = wx_explore1;
            
            this.Wx_head_img = wx_head_img1;
            
            this.Wx_modify_time = wx_modify_time1;
            
            this.Wx_nick_name = wx_nick_name1;
            
            this.Wx_os = wx_os1;
            
            this.Wx_post_time = wx_post_time1;
            
            this.Wx_province = wx_province1;
            
            this.Wx_sex = wx_sex1;
            
            this.Xuebapingyu = xuebapingyu1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_teacher_resume FromIView(IView view)
        {
            return (Xb_teacher_resume)IView.GetITable(view, "Xb_teacher_resume");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_teacher_resume GetOneInstance()
        {
            Xb_teacher_resume value = new Xb_teacher_resume();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_teacher_resume Retrieve()
        {
            BLLTable<Xb_teacher_resume>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Id":
			        return Id;
			    			
			    case "Born":
			        return Born;
			    			
			    case "Catelog":
			        return Catelog;
			    			
			    case "City_id":
			        return City_id;
			    			
			    case "College":
			        return College;
			    			
			    case "College_major":
			        return College_major;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "E_wei_ma":
			        return E_wei_ma;
			    			
			    case "English_kemu":
			        return English_kemu;
			    			
			    case "Experience":
			        return Experience;
			    			
			    case "Experience_intro":
			        return Experience_intro;
			    			
			    case "Experience_year":
			        return Experience_year;
			    			
			    case "F26":
			        return F26;
			    			
			    case "F27":
			        return F27;
			    			
			    case "Good_at":
			        return Good_at;
			    			
			    case "Good_kemu":
			        return Good_kemu;
			    			
			    case "Good_nianji":
			        return Good_nianji;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Has_time_match_ids":
			        return Has_time_match_ids;
			    			
			    case "Has_today_match_ids":
			        return Has_today_match_ids;
			    			
			    case "High_school":
			        return High_school;
			    			
			    case "Home_area":
			        return Home_area;
			    			
			    case "Introduce":
			        return Introduce;
			    			
			    case "Introduce_en":
			        return Introduce_en;
			    			
			    case "IP":
			        return IP;
			    			
			    case "Is_done":
			        return Is_done;
			    			
			    case "Is_recommend":
			        return Is_recommend;
			    			
			    case "Is_show":
			        return Is_show;
			    			
			    case "Jin_experience":
			        return Jin_experience;
			    			
			    case "Jin_sex":
			        return Jin_sex;
			    			
			    case "KaixueTime":
			        return KaixueTime;
			    			
			    case "Ke_jieshou_jiesuTime":
			        return Ke_jieshou_jiesuTime;
			    			
			    case "Ke_jieshou_kaishiTime":
			        return Ke_jieshou_kaishiTime;
			    			
			    case "Kemu":
			        return Kemu;
			    			
			    case "On_top":
			        return On_top;
			    			
			    case "On_top_timeout":
			        return On_top_timeout;
			    			
			    case "OpenID":
			        return OpenID;
			    			
			    case "Other_area":
			        return Other_area;
			    			
			    case "Phone_number":
			        return Phone_number;
			    			
			    case "Photo":
			        return Photo;
			    			
			    case "QQnum":
			        return QQnum;
			    			
			    case "Recommend":
			        return Recommend;
			    			
			    case "Score_high_school":
			        return Score_high_school;
			    			
			    case "Score_mianshi":
			        return Score_mianshi;
			    			
			    case "Score_mianshi1":
			        return Score_mianshi1;
			    			
			    case "Score_mianshi2":
			        return Score_mianshi2;
			    			
			    case "Score_mianshi3":
			        return Score_mianshi3;
			    			
			    case "Score_seq":
			        return Score_seq;
			    			
			    case "Service_type":
			        return Service_type;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "ShujiaTime":
			        return ShujiaTime;
			    			
			    case "Teach_exp":
			        return Teach_exp;
			    			
			    case "Teacher_mode":
			        return Teacher_mode;
			    			
			    case "Teacher_name":
			        return Teacher_name;
			    			
			    case "Teacher_name_en":
			        return Teacher_name_en;
			    			
			    case "Teacher_type":
			        return Teacher_type;
			    			
			    case "Time_match_ids":
			        return Time_match_ids;
			    			
			    case "Today_match_ids":
			        return Today_match_ids;
			    			
			    case "Type":
			        return Type;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "Voice":
			        return Voice;
			    			
			    case "Weizhi":
			        return Weizhi;
			    			
			    case "Work_area":
			        return Work_area;
			    			
			    case "Work_field":
			        return Work_field;
			    			
			    case "Wx_city":
			        return Wx_city;
			    			
			    case "Wx_country":
			        return Wx_country;
			    			
			    case "Wx_create_man":
			        return Wx_create_man;
			    			
			    case "Wx_device":
			        return Wx_device;
			    			
			    case "Wx_explore":
			        return Wx_explore;
			    			
			    case "Wx_head_img":
			        return Wx_head_img;
			    			
			    case "Wx_modify_time":
			        return Wx_modify_time;
			    			
			    case "Wx_nick_name":
			        return Wx_nick_name;
			    			
			    case "Wx_os":
			        return Wx_os;
			    			
			    case "Wx_post_time":
			        return Wx_post_time;
			    			
			    case "Wx_province":
			        return Wx_province;
			    			
			    case "Wx_sex":
			        return Wx_sex;
			    			
			    case "Xuebapingyu":
			        return Xuebapingyu;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Born":
			        this.Born = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Catelog":
			        this.Catelog = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "City_id":
			        this.City_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "College":
			        this.College = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "College_major":
			        this.College_major = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "E_wei_ma":
			        this.E_wei_ma = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "English_kemu":
			        this.English_kemu = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Experience":
			        this.Experience = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Experience_intro":
			        this.Experience_intro = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Experience_year":
			        this.Experience_year = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "F26":
			        this.F26 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "F27":
			        this.F27 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Good_at":
			        this.Good_at = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Good_kemu":
			        this.Good_kemu = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Good_nianji":
			        this.Good_nianji = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Has_time_match_ids":
			        this.Has_time_match_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Has_today_match_ids":
			        this.Has_today_match_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "High_school":
			        this.High_school = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Home_area":
			        this.Home_area = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Introduce":
			        this.Introduce = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Introduce_en":
			        this.Introduce_en = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IP":
			        this.IP = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_done":
			        this.Is_done = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Is_recommend":
			        this.Is_recommend = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Is_show":
			        this.Is_show = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Jin_experience":
			        this.Jin_experience = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Jin_sex":
			        this.Jin_sex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KaixueTime":
			        this.KaixueTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Ke_jieshou_jiesuTime":
			        this.Ke_jieshou_jiesuTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Ke_jieshou_kaishiTime":
			        this.Ke_jieshou_kaishiTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Kemu":
			        this.Kemu = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "On_top":
			        this.On_top = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "On_top_timeout":
			        this.On_top_timeout = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "OpenID":
			        this.OpenID = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Other_area":
			        this.Other_area = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_number":
			        this.Phone_number = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Photo":
			        this.Photo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QQnum":
			        this.QQnum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Recommend":
			        this.Recommend = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Score_high_school":
			        this.Score_high_school = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Score_mianshi":
			        this.Score_mianshi = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Score_mianshi1":
			        this.Score_mianshi1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Score_mianshi2":
			        this.Score_mianshi2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Score_mianshi3":
			        this.Score_mianshi3 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Score_seq":
			        this.Score_seq = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Service_type":
			        this.Service_type = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ShujiaTime":
			        this.ShujiaTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teach_exp":
			        this.Teach_exp = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Teacher_mode":
			        this.Teacher_mode = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Teacher_name":
			        this.Teacher_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_name_en":
			        this.Teacher_name_en = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_type":
			        this.Teacher_type = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Time_match_ids":
			        this.Time_match_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Today_match_ids":
			        this.Today_match_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Voice":
			        this.Voice = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Weizhi":
			        this.Weizhi = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Work_area":
			        this.Work_area = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Work_field":
			        this.Work_field = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_city":
			        this.Wx_city = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_country":
			        this.Wx_country = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_create_man":
			        this.Wx_create_man = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_device":
			        this.Wx_device = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_explore":
			        this.Wx_explore = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_head_img":
			        this.Wx_head_img = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_modify_time":
			        this.Wx_modify_time = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_nick_name":
			        this.Wx_nick_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_os":
			        this.Wx_os = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_post_time":
			        this.Wx_post_time = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_province":
			        this.Wx_province = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wx_sex":
			        this.Wx_sex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Xuebapingyu":
			        this.Xuebapingyu = Convert.ToString(AttributeValue);
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
				case "Id":
					return id_initialized;
				
				case "Born":
					return born_initialized;
				
				case "Catelog":
					return catelog_initialized;
				
				case "City_id":
					return city_id_initialized;
				
				case "College":
					return college_initialized;
				
				case "College_major":
					return college_major_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "E_wei_ma":
					return e_wei_ma_initialized;
				
				case "English_kemu":
					return english_kemu_initialized;
				
				case "Experience":
					return experience_initialized;
				
				case "Experience_intro":
					return experience_intro_initialized;
				
				case "Experience_year":
					return experience_year_initialized;
				
				case "F26":
					return f26_initialized;
				
				case "F27":
					return f27_initialized;
				
				case "Good_at":
					return good_at_initialized;
				
				case "Good_kemu":
					return good_kemu_initialized;
				
				case "Good_nianji":
					return good_nianji_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Has_time_match_ids":
					return has_time_match_ids_initialized;
				
				case "Has_today_match_ids":
					return has_today_match_ids_initialized;
				
				case "High_school":
					return high_school_initialized;
				
				case "Home_area":
					return home_area_initialized;
				
				case "Introduce":
					return introduce_initialized;
				
				case "Introduce_en":
					return introduce_en_initialized;
				
				case "IP":
					return ip_initialized;
				
				case "Is_done":
					return is_done_initialized;
				
				case "Is_recommend":
					return is_recommend_initialized;
				
				case "Is_show":
					return is_show_initialized;
				
				case "Jin_experience":
					return jin_experience_initialized;
				
				case "Jin_sex":
					return jin_sex_initialized;
				
				case "KaixueTime":
					return kaixuetime_initialized;
				
				case "Ke_jieshou_jiesuTime":
					return ke_jieshou_jiesutime_initialized;
				
				case "Ke_jieshou_kaishiTime":
					return ke_jieshou_kaishitime_initialized;
				
				case "Kemu":
					return kemu_initialized;
				
				case "On_top":
					return on_top_initialized;
				
				case "On_top_timeout":
					return on_top_timeout_initialized;
				
				case "OpenID":
					return openid_initialized;
				
				case "Other_area":
					return other_area_initialized;
				
				case "Phone_number":
					return phone_number_initialized;
				
				case "Photo":
					return photo_initialized;
				
				case "QQnum":
					return qqnum_initialized;
				
				case "Recommend":
					return recommend_initialized;
				
				case "Score_high_school":
					return score_high_school_initialized;
				
				case "Score_mianshi":
					return score_mianshi_initialized;
				
				case "Score_mianshi1":
					return score_mianshi1_initialized;
				
				case "Score_mianshi2":
					return score_mianshi2_initialized;
				
				case "Score_mianshi3":
					return score_mianshi3_initialized;
				
				case "Score_seq":
					return score_seq_initialized;
				
				case "Service_type":
					return service_type_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "ShujiaTime":
					return shujiatime_initialized;
				
				case "Teach_exp":
					return teach_exp_initialized;
				
				case "Teacher_mode":
					return teacher_mode_initialized;
				
				case "Teacher_name":
					return teacher_name_initialized;
				
				case "Teacher_name_en":
					return teacher_name_en_initialized;
				
				case "Teacher_type":
					return teacher_type_initialized;
				
				case "Time_match_ids":
					return time_match_ids_initialized;
				
				case "Today_match_ids":
					return today_match_ids_initialized;
				
				case "Type":
					return type_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "Voice":
					return voice_initialized;
				
				case "Weizhi":
					return weizhi_initialized;
				
				case "Work_area":
					return work_area_initialized;
				
				case "Work_field":
					return work_field_initialized;
				
				case "Wx_city":
					return wx_city_initialized;
				
				case "Wx_country":
					return wx_country_initialized;
				
				case "Wx_create_man":
					return wx_create_man_initialized;
				
				case "Wx_device":
					return wx_device_initialized;
				
				case "Wx_explore":
					return wx_explore_initialized;
				
				case "Wx_head_img":
					return wx_head_img_initialized;
				
				case "Wx_modify_time":
					return wx_modify_time_initialized;
				
				case "Wx_nick_name":
					return wx_nick_name_initialized;
				
				case "Wx_os":
					return wx_os_initialized;
				
				case "Wx_post_time":
					return wx_post_time_initialized;
				
				case "Wx_province":
					return wx_province_initialized;
				
				case "Wx_sex":
					return wx_sex_initialized;
				
				case "Xuebapingyu":
					return xuebapingyu_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Born":
					born_initialized = ret;
					return true;
				
				case "Catelog":
					catelog_initialized = ret;
					return true;
				
				case "City_id":
					city_id_initialized = ret;
					return true;
				
				case "College":
					college_initialized = ret;
					return true;
				
				case "College_major":
					college_major_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "E_wei_ma":
					e_wei_ma_initialized = ret;
					return true;
				
				case "English_kemu":
					english_kemu_initialized = ret;
					return true;
				
				case "Experience":
					experience_initialized = ret;
					return true;
				
				case "Experience_intro":
					experience_intro_initialized = ret;
					return true;
				
				case "Experience_year":
					experience_year_initialized = ret;
					return true;
				
				case "F26":
					f26_initialized = ret;
					return true;
				
				case "F27":
					f27_initialized = ret;
					return true;
				
				case "Good_at":
					good_at_initialized = ret;
					return true;
				
				case "Good_kemu":
					good_kemu_initialized = ret;
					return true;
				
				case "Good_nianji":
					good_nianji_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Has_time_match_ids":
					has_time_match_ids_initialized = ret;
					return true;
				
				case "Has_today_match_ids":
					has_today_match_ids_initialized = ret;
					return true;
				
				case "High_school":
					high_school_initialized = ret;
					return true;
				
				case "Home_area":
					home_area_initialized = ret;
					return true;
				
				case "Introduce":
					introduce_initialized = ret;
					return true;
				
				case "Introduce_en":
					introduce_en_initialized = ret;
					return true;
				
				case "IP":
					ip_initialized = ret;
					return true;
				
				case "Is_done":
					is_done_initialized = ret;
					return true;
				
				case "Is_recommend":
					is_recommend_initialized = ret;
					return true;
				
				case "Is_show":
					is_show_initialized = ret;
					return true;
				
				case "Jin_experience":
					jin_experience_initialized = ret;
					return true;
				
				case "Jin_sex":
					jin_sex_initialized = ret;
					return true;
				
				case "KaixueTime":
					kaixuetime_initialized = ret;
					return true;
				
				case "Ke_jieshou_jiesuTime":
					ke_jieshou_jiesutime_initialized = ret;
					return true;
				
				case "Ke_jieshou_kaishiTime":
					ke_jieshou_kaishitime_initialized = ret;
					return true;
				
				case "Kemu":
					kemu_initialized = ret;
					return true;
				
				case "On_top":
					on_top_initialized = ret;
					return true;
				
				case "On_top_timeout":
					on_top_timeout_initialized = ret;
					return true;
				
				case "OpenID":
					openid_initialized = ret;
					return true;
				
				case "Other_area":
					other_area_initialized = ret;
					return true;
				
				case "Phone_number":
					phone_number_initialized = ret;
					return true;
				
				case "Photo":
					photo_initialized = ret;
					return true;
				
				case "QQnum":
					qqnum_initialized = ret;
					return true;
				
				case "Recommend":
					recommend_initialized = ret;
					return true;
				
				case "Score_high_school":
					score_high_school_initialized = ret;
					return true;
				
				case "Score_mianshi":
					score_mianshi_initialized = ret;
					return true;
				
				case "Score_mianshi1":
					score_mianshi1_initialized = ret;
					return true;
				
				case "Score_mianshi2":
					score_mianshi2_initialized = ret;
					return true;
				
				case "Score_mianshi3":
					score_mianshi3_initialized = ret;
					return true;
				
				case "Score_seq":
					score_seq_initialized = ret;
					return true;
				
				case "Service_type":
					service_type_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "ShujiaTime":
					shujiatime_initialized = ret;
					return true;
				
				case "Teach_exp":
					teach_exp_initialized = ret;
					return true;
				
				case "Teacher_mode":
					teacher_mode_initialized = ret;
					return true;
				
				case "Teacher_name":
					teacher_name_initialized = ret;
					return true;
				
				case "Teacher_name_en":
					teacher_name_en_initialized = ret;
					return true;
				
				case "Teacher_type":
					teacher_type_initialized = ret;
					return true;
				
				case "Time_match_ids":
					time_match_ids_initialized = ret;
					return true;
				
				case "Today_match_ids":
					today_match_ids_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Voice":
					voice_initialized = ret;
					return true;
				
				case "Weizhi":
					weizhi_initialized = ret;
					return true;
				
				case "Work_area":
					work_area_initialized = ret;
					return true;
				
				case "Work_field":
					work_field_initialized = ret;
					return true;
				
				case "Wx_city":
					wx_city_initialized = ret;
					return true;
				
				case "Wx_country":
					wx_country_initialized = ret;
					return true;
				
				case "Wx_create_man":
					wx_create_man_initialized = ret;
					return true;
				
				case "Wx_device":
					wx_device_initialized = ret;
					return true;
				
				case "Wx_explore":
					wx_explore_initialized = ret;
					return true;
				
				case "Wx_head_img":
					wx_head_img_initialized = ret;
					return true;
				
				case "Wx_modify_time":
					wx_modify_time_initialized = ret;
					return true;
				
				case "Wx_nick_name":
					wx_nick_name_initialized = ret;
					return true;
				
				case "Wx_os":
					wx_os_initialized = ret;
					return true;
				
				case "Wx_post_time":
					wx_post_time_initialized = ret;
					return true;
				
				case "Wx_province":
					wx_province_initialized = ret;
					return true;
				
				case "Wx_sex":
					wx_sex_initialized = ret;
					return true;
				
				case "Xuebapingyu":
					xuebapingyu_initialized = ret;
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

			
			if (id_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (born_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Born;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Born);
                }
			}
			
			if (catelog_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Catelog;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Catelog);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
                }
			}
			
			if (college_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.College;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College);
                }
			}
			
			if (college_major_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.College_major;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College_major);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (e_wei_ma_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.E_wei_ma;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(E_wei_ma);
                }
			}
			
			if (english_kemu_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.English_kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(English_kemu);
                }
			}
			
			if (experience_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Experience;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Experience);
                }
			}
			
			if (experience_intro_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Experience_intro;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Experience_intro);
                }
			}
			
			if (experience_year_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Experience_year;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Experience_year);
                }
			}
			
			if (f26_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.F26;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(F26);
                }
			}
			
			if (f27_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.F27;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(F27);
                }
			}
			
			if (good_at_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Good_at;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Good_at);
                }
			}
			
			if (good_kemu_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Good_kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Good_kemu);
                }
			}
			
			if (good_nianji_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Good_nianji;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Good_nianji);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (has_time_match_ids_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Has_time_match_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Has_time_match_ids);
                }
			}
			
			if (has_today_match_ids_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Has_today_match_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Has_today_match_ids);
                }
			}
			
			if (high_school_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.High_school;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(High_school);
                }
			}
			
			if (home_area_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Home_area;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Home_area);
                }
			}
			
			if (introduce_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Introduce;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Introduce);
                }
			}
			
			if (introduce_en_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Introduce_en;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Introduce_en);
                }
			}
			
			if (ip_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.IP;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IP);
                }
			}
			
			if (is_done_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Is_done;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_done);
                }
			}
			
			if (is_recommend_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Is_recommend;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_recommend);
                }
			}
			
			if (is_show_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Is_show;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_show);
                }
			}
			
			if (jin_experience_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Jin_experience;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Jin_experience);
                }
			}
			
			if (jin_sex_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Jin_sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Jin_sex);
                }
			}
			
			if (kaixuetime_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.KaixueTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KaixueTime);
                }
			}
			
			if (ke_jieshou_jiesutime_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Ke_jieshou_jiesuTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Ke_jieshou_jiesuTime);
                }
			}
			
			if (ke_jieshou_kaishitime_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Ke_jieshou_kaishiTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Ke_jieshou_kaishiTime);
                }
			}
			
			if (kemu_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu);
                }
			}
			
			if (on_top_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.On_top;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(On_top);
                }
			}
			
			if (on_top_timeout_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.On_top_timeout;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(On_top_timeout);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.OpenID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenID);
                }
			}
			
			if (other_area_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Other_area;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Other_area);
                }
			}
			
			if (phone_number_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Phone_number;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_number);
                }
			}
			
			if (photo_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Photo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Photo);
                }
			}
			
			if (qqnum_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.QQnum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QQnum);
                }
			}
			
			if (recommend_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Recommend;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Recommend);
                }
			}
			
			if (score_high_school_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Score_high_school;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_high_school);
                }
			}
			
			if (score_mianshi_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Score_mianshi;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_mianshi);
                }
			}
			
			if (score_mianshi1_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Score_mianshi1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_mianshi1);
                }
			}
			
			if (score_mianshi2_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Score_mianshi2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_mianshi2);
                }
			}
			
			if (score_mianshi3_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Score_mianshi3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_mianshi3);
                }
			}
			
			if (score_seq_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Score_seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_seq);
                }
			}
			
			if (service_type_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Service_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Service_type);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (shujiatime_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.ShujiaTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShujiaTime);
                }
			}
			
			if (teach_exp_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Teach_exp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teach_exp);
                }
			}
			
			if (teacher_mode_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Teacher_mode;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_mode);
                }
			}
			
			if (teacher_name_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Teacher_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_name);
                }
			}
			
			if (teacher_name_en_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Teacher_name_en;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_name_en);
                }
			}
			
			if (teacher_type_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Teacher_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_type);
                }
			}
			
			if (time_match_ids_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Time_match_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time_match_ids);
                }
			}
			
			if (today_match_ids_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Today_match_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Today_match_ids);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (voice_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Voice;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Voice);
                }
			}
			
			if (weizhi_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Weizhi;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Weizhi);
                }
			}
			
			if (work_area_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Work_area;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Work_area);
                }
			}
			
			if (work_field_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Work_field;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Work_field);
                }
			}
			
			if (wx_city_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_city;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_city);
                }
			}
			
			if (wx_country_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_country;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_country);
                }
			}
			
			if (wx_create_man_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_create_man;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_create_man);
                }
			}
			
			if (wx_device_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_device;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_device);
                }
			}
			
			if (wx_explore_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_explore;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_explore);
                }
			}
			
			if (wx_head_img_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_head_img;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_head_img);
                }
			}
			
			if (wx_modify_time_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_modify_time);
                }
			}
			
			if (wx_nick_name_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_nick_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_nick_name);
                }
			}
			
			if (wx_os_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_os;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_os);
                }
			}
			
			if (wx_post_time_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_post_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_post_time);
                }
			}
			
			if (wx_province_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_province);
                }
			}
			
			if (wx_sex_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Wx_sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wx_sex);
                }
			}
			
			if (xuebapingyu_initialized)
			{
                AttributeItem attr = Xb_teacher_resume.Attribute.Xuebapingyu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Xuebapingyu);
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
        public class Xb_teacher_resumeJson
        {
            
            /// <summary>序号</summary>
            public int Id { get; set; }
            
            /// <summary>出生年月:[CtrlTypeDic-{InputDate}]</summary>
            public string Born { get; set; }
            
            /// <summary>大类:[Enum-{0:优选教员},{1:外教},{2:小班课},{3:暑期课}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}]</summary>
            public int Catelog { get; set; }
            
            /// <summary>[IsVisable-{false}]</summary>
            public string City_id { get; set; }
            
            /// <summary>大学</summary>
            public string College { get; set; }
            
            /// <summary>专业:[IsVisable-{false}]</summary>
            public string College_major { get; set; }
            
            /// <summary>填写日期:[CtrlTypeDic-{InputDate}]</summary>
            public string Create_time { get; set; }
            
            /// <summary>二维码:[IsVisable-{false}][CtrlTypeDic-{FileUpImage}]</summary>
            public string E_wei_ma { get; set; }
            
            /// <summary>科目:[Enum-{0:生活口语},{1:自由会话},{2:青少年英语},{3:雅思英语},{4:新托福英语},{5:商务英语},{6:旅游英语},{7:文化话题英语},{8:时事英语},{9:青少全能新概念},{10:综合口语},{11:经典英语（成人版）},{12:经典英语（青少版）}][IsVisable-{false}][CtrlTypeDic-{SelectMultiple}]</summary>
            public int English_kemu { get; set; }
            
            /// <summary>经验:[Enum-{0:暂无},{1:1V1},{2:小班2人以上},{3:大班6人以上}][CtrlTypeDic-{CheckBoxList}]</summary>
            public int Experience { get; set; }
            
            /// <summary>经验:[IsVisable-{false}]</summary>
            public string Experience_intro { get; set; }
            
            /// <summary>教课经验:[CtrlTypeDic-{Text}]</summary>
            public double Experience_year { get; set; }
            
            /// <summary>[IsVisable-{false}]</summary>
            public string F26 { get; set; }
            
            /// <summary>[IsVisable-{false}]</summary>
            public string F27 { get; set; }
            
            /// <summary>擅长科目:[IsVisable-{false}][IsReadOnly-{true}][CtrlTypeDic-{SelectMultiple}]</summary>
            public string Good_at { get; set; }
            
            /// <summary>[IsVisable-{false}]</summary>
            public string Good_kemu { get; set; }
            
            /// <summary>[IsVisable-{false}]</summary>
            public string Good_nianji { get; set; }
            
            /// <summary>年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectMultiple}]</summary>
            public string Grade { get; set; }
            
            /// <summary>已被预约的课程时间(day_min，返回前端为当前天int值):[IsVisable-{false}][CtrlTypeDic-{InputTime}]</summary>
            public string Has_time_match_ids { get; set; }
            
            /// <summary>今日已预约计算结果int:[IsVisable-{false}]</summary>
            public string Has_today_match_ids { get; set; }
            
            /// <summary>高中:[CtrlTypeDic-{InputString}]</summary>
            public string High_school { get; set; }
            
            /// <summary>家乡:[CtrlTypeDic-{Address}]</summary>
            public string Home_area { get; set; }
            
            /// <summary>自我简介:[CtrlTypeDic-{Text}]</summary>
            public string Introduce { get; set; }
            
            /// <summary>英语自我介绍:[CtrlTypeDic-{Text}]</summary>
            public string Introduce_en { get; set; }
            
            /// <summary>Ip地址</summary>
            public string IP { get; set; }
            
            /// <summary>是否有成交:[Enum-{yes:是},{no:否}][CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Is_done { get; set; }
            
            /// <summary>是否推荐:[Enum-{yes:是},{no:否}][CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Is_recommend { get; set; }
            
            /// <summary>是否显示:[Enum-{yes:是},{not:否}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Is_show { get; set; }
            
            /// <summary>家教经验:[CtrlTypeDic-{Text}]</summary>
            public string Jin_experience { get; set; }
            
            /// <summary>性别:[Enum-{:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{CheckBoxList}]</summary>
            public string Jin_sex { get; set; }
            
            /// <summary>开学可教学时间:[CtrlTypeDic-{InputTime}]</summary>
            public string KaixueTime { get; set; }
            
            /// <summary>课程结束时间:[CtrlTypeDic-{InputTime}]</summary>
            public string Ke_jieshou_jiesuTime { get; set; }
            
            /// <summary>课程开始时间:[CtrlTypeDic-{InputTime}]</summary>
            public string Ke_jieshou_kaishiTime { get; set; }
            
            /// <summary>科目:[Enum-{:不限},{1:数学},{2:英语},{3:语文},{4:物理},{5:化学},{6:生物},{7:政治},{8:历史},{9:地理},{10:奥数},{11:科学},{12:钢琴},{13:书法},{14:舞蹈},{15:素描},{16:国画}][CtrlTypeDic-{SelectMultiple}]</summary>
            public string Kemu { get; set; }
            
            /// <summary>是否置顶:[Enum-{1:是},{2:否}][IsVisable-{false}][CtrlTypeDic-{CheckBoxList}]</summary>
            public bool On_top { get; set; }
            
            /// <summary>置顶超时日期:[IsVisable-{false}][CtrlTypeDic-{InputDate}]</summary>
            public DateTime On_top_timeout { get; set; }
            
            /// <summary>[IsVisable-{false}]</summary>
            public string OpenID { get; set; }
            
            /// <summary>其他意向区域:[IsVisable-{false}][CtrlTypeDic-{Address}]</summary>
            public string Other_area { get; set; }
            
            /// <summary>手机号:[CtrlTypeDic-{InputMobile}]</summary>
            public string Phone_number { get; set; }
            
            /// <summary>随身照:[CtrlTypeDic-{FileUpImage}]</summary>
            public string Photo { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputQQ}]</summary>
            public string QQnum { get; set; }
            
            /// <summary>适合学员</summary>
            public string Recommend { get; set; }
            
            /// <summary>高考成绩</summary>
            public string Score_high_school { get; set; }
            
            /// <summary>面试总分</summary>
            public string Score_mianshi { get; set; }
            
            /// <summary>面试评分1-经验:[CtrlTypeDic-{Text}]</summary>
            public string Score_mianshi1 { get; set; }
            
            /// <summary>面试评分2-沟通:[CtrlTypeDic-{Text}]</summary>
            public string Score_mianshi2 { get; set; }
            
            /// <summary>面试评分3-技能:[CtrlTypeDic-{Text}]</summary>
            public string Score_mianshi3 { get; set; }
            
            /// <summary>排序权重</summary>
            public double Score_seq { get; set; }
            
            /// <summary>服务方式:[Enum-{:不限},{1:仅首次上门},{2:上门服务},{3:在线答疑},{4:在线课}][CtrlTypeDic-{SelectMultiple}]</summary>
            public int Service_type { get; set; }
            
            /// <summary>性别:[Enum-{:不限},{1:男老师},{2:女老师}][CtrlTypeDic-{CheckBoxList}]</summary>
            public int Sex { get; set; }
            
            /// <summary>暑假可教学区域:[CtrlTypeDic-{Address}]</summary>
            public string ShujiaTime { get; set; }
            
            /// <summary>教课经验:[Enum-{:不限},{1:1年以下},{2:2-5年},{3:10年以上}][CtrlTypeDic-{CheckBoxList}]</summary>
            public int Teach_exp { get; set; }
            
            /// <summary>教学模式:[Enum-{:不限},{1:在线1v1},{2:线下朋友团},{3:1v3小班},{4:1v5小班}][CtrlTypeDic-{SelectMultiple}]</summary>
            public int Teacher_mode { get; set; }
            
            /// <summary>讲师姓名</summary>
            public string Teacher_name { get; set; }
            
            /// <summary>讲师英文名</summary>
            public string Teacher_name_en { get; set; }
            
            /// <summary>讲师类型:[Enum-{0:不限},{1:留学生外教},{2:欧美外教}][CtrlTypeDic-{CheckBoxList}]</summary>
            public int Teacher_type { get; set; }
            
            /// <summary>课程时间(day_min，返回前端为当前天int值):[CtrlTypeDic-{InputTime}]</summary>
            public string Time_match_ids { get; set; }
            
            /// <summary>今日计算结果int</summary>
            public string Today_match_ids { get; set; }
            
            /// <summary></summary>
            public bool Type { get; set; }
            
            /// <summary></summary>
            public Guid User_id { get; set; }
            
            /// <summary>[IsVisable-{false}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>语音介绍</summary>
            public string Voice { get; set; }
            
            /// <summary></summary>
            public string Weizhi { get; set; }
            
            /// <summary>意向工作区域</summary>
            public string Work_area { get; set; }
            
            /// <summary>工作行业</summary>
            public string Work_field { get; set; }
            
            /// <summary>微信市</summary>
            public string Wx_city { get; set; }
            
            /// <summary>微信国家</summary>
            public string Wx_country { get; set; }
            
            /// <summary>提交人</summary>
            public string Wx_create_man { get; set; }
            
            /// <summary>填写设备</summary>
            public string Wx_device { get; set; }
            
            /// <summary>浏览器</summary>
            public string Wx_explore { get; set; }
            
            /// <summary>微信头像:[CtrlTypeDic-{FileUpImage}]</summary>
            public string Wx_head_img { get; set; }
            
            /// <summary>修改时间:[CtrlTypeDic-{InputTime}]</summary>
            public string Wx_modify_time { get; set; }
            
            /// <summary>微信昵称</summary>
            public string Wx_nick_name { get; set; }
            
            /// <summary>操作系统</summary>
            public string Wx_os { get; set; }
            
            /// <summary>提交时间:[CtrlTypeDic-{InputTime}]</summary>
            public string Wx_post_time { get; set; }
            
            /// <summary>微信省市</summary>
            public string Wx_province { get; set; }
            
            /// <summary>微信性别:[Enum-{1:男},{2:女}][CtrlTypeDic-{CheckBoxList}]</summary>
            public string Wx_sex { get; set; }
            
            /// <summary>评语:[CtrlTypeDic-{Text}]</summary>
            public string Xuebapingyu { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:20
  Description:    ���ݱ�Xb_course��Ӧ��ҵ���߼���Xb_course
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_course_Entity:Xb_course
 * 
************************************************************/
/************************************************************
SQL���룺
select ID,ClassEndTime,ClassErWeiMa,ClassHongBao,ClassKeyWord,ClassPicture,ClassRenQun,ClassStartTime,ClassTag,ClassTimeLong,ClassTitle,ClassType,ClassXingShi,ClassYaoDian,ClassZengSong,ClassZhuShouErWeiMa,CountDianZan,CountGuanZhu,CountPingLun,TeacherId,YuYinJieShao from Xb_course
delete from Xb_course
INSERT INTO Xb_course (ID,ClassEndTime,ClassErWeiMa,ClassHongBao,ClassKeyWord,ClassPicture,ClassRenQun,ClassStartTime,ClassTag,ClassTimeLong,ClassTitle,ClassType,ClassXingShi,ClassYaoDian,ClassZengSong,ClassZhuShouErWeiMa,CountDianZan,CountGuanZhu,CountPingLun,TeacherId,YuYinJieShao)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','')
UPDATE Xb_course SET ...
������ֵ���룺
 *         valObj.ID = valObj2.ID;
        valObj.ClassEndTime = valObj2.ClassEndTime;
        valObj.ClassErWeiMa = valObj2.ClassErWeiMa;
        valObj.ClassHongBao = valObj2.ClassHongBao;
        valObj.ClassKeyWord = valObj2.ClassKeyWord;
        valObj.ClassPicture = valObj2.ClassPicture;
        valObj.ClassRenQun = valObj2.ClassRenQun;
        valObj.ClassStartTime = valObj2.ClassStartTime;
        valObj.ClassTag = valObj2.ClassTag;
        valObj.ClassTimeLong = valObj2.ClassTimeLong;
        valObj.ClassTitle = valObj2.ClassTitle;
        valObj.ClassType = valObj2.ClassType;
        valObj.ClassXingShi = valObj2.ClassXingShi;
        valObj.ClassYaoDian = valObj2.ClassYaoDian;
        valObj.ClassZengSong = valObj2.ClassZengSong;
        valObj.ClassZhuShouErWeiMa = valObj2.ClassZhuShouErWeiMa;
        valObj.CountDianZan = valObj2.CountDianZan;
        valObj.CountGuanZhu = valObj2.CountGuanZhu;
        valObj.CountPingLun = valObj2.CountPingLun;
        valObj.TeacherId = valObj2.TeacherId;
        valObj.YuYinJieShao = valObj2.YuYinJieShao; 
        valObj.ID = "";
        valObj.ClassEndTime = "";
        valObj.ClassErWeiMa = "";
        valObj.ClassHongBao = "";
        valObj.ClassKeyWord = "";
        valObj.ClassPicture = "";
        valObj.ClassRenQun = "";
        valObj.ClassStartTime = "";
        valObj.ClassTag = "";
        valObj.ClassTimeLong = "";
        valObj.ClassTitle = "";
        valObj.ClassType = "";
        valObj.ClassXingShi = "";
        valObj.ClassYaoDian = "";
        valObj.ClassZengSong = "";
        valObj.ClassZhuShouErWeiMa = "";
        valObj.CountDianZan = "";
        valObj.CountGuanZhu = "";
        valObj.CountPingLun = "";
        valObj.TeacherId = "";
        valObj.YuYinJieShao = ""; 
        "ID": $("#txt_ID").val(),
        "ClassEndTime": $("#txt_ClassEndTime").val(),
        "ClassErWeiMa": $("#txt_ClassErWeiMa").val(),
        "ClassHongBao": $("#txt_ClassHongBao").val(),
        "ClassKeyWord": $("#txt_ClassKeyWord").val(),
        "ClassPicture": $("#txt_ClassPicture").val(),
        "ClassRenQun": $("#txt_ClassRenQun").val(),
        "ClassStartTime": $("#txt_ClassStartTime").val(),
        "ClassTag": $("#txt_ClassTag").val(),
        "ClassTimeLong": $("#txt_ClassTimeLong").val(),
        "ClassTitle": $("#txt_ClassTitle").val(),
        "ClassType": $("#txt_ClassType").val(),
        "ClassXingShi": $("#txt_ClassXingShi").val(),
        "ClassYaoDian": $("#txt_ClassYaoDian").val(),
        "ClassZengSong": $("#txt_ClassZengSong").val(),
        "ClassZhuShouErWeiMa": $("#txt_ClassZhuShouErWeiMa").val(),
        "CountDianZan": $("#txt_CountDianZan").val(),
        "CountGuanZhu": $("#txt_CountGuanZhu").val(),
        "CountPingLun": $("#txt_CountPingLun").val(),
        "TeacherId": $("#txt_TeacherId").val(),
        "YuYinJieShao": $("#txt_YuYinJieShao").val(), 
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
    /// <para>1v1����:[IDField-{ID:0}]</para>
    /// <para>��Xb_course���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_course : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_course Factory()
        {
            return new Xb_course();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _ID
        {            
            get { return this.ID; }
            set { this.ID = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassEndTime
        {            
            get { return this.ClassEndTime; }
            set { this.ClassEndTime = value; }
        }
        
        /// <summary> ���ö�ά��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassErWeiMa
        {            
            get { return this.ClassErWeiMa; }
            set { this.ClassErWeiMa = value; }
        }
        
        /// <summary> ���ͺ챦:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassHongBao
        {            
            get { return this.ClassHongBao; }
            set { this.ClassHongBao = value; }
        }
        
        /// <summary> ���ùؼ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassKeyWord
        {            
            get { return this.ClassKeyWord; }
            set { this.ClassKeyWord = value; }
        }
        
        /// <summary> ����ͼƬ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassPicture
        {            
            get { return this.ClassPicture; }
            set { this.ClassPicture = value; }
        }
        
        /// <summary> �ʺ���Ⱥ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassRenQun
        {            
            get { return this.ClassRenQun; }
            set { this.ClassRenQun = value; }
        }
        
        /// <summary> ��ʼʱ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassStartTime
        {            
            get { return this.ClassStartTime; }
            set { this.ClassStartTime = value; }
        }
        
        /// <summary> ���ñ�ǩ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassTag
        {            
            get { return this.ClassTag; }
            set { this.ClassTag = value; }
        }
        
        /// <summary> ʱ�䳤��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassTimeLong
        {            
            get { return this.ClassTimeLong; }
            set { this.ClassTimeLong = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassTitle
        {            
            get { return this.ClassTitle; }
            set { this.ClassTitle = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassType
        {            
            get { return this.ClassType; }
            set { this.ClassType = value; }
        }
        
        /// <summary> ������ʽ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassXingShi
        {            
            get { return this.ClassXingShi; }
            set { this.ClassXingShi = value; }
        }
        
        /// <summary> ����Ҫ��:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _ClassYaoDian
        {            
            get { return this.ClassYaoDian; }
            set { this.ClassYaoDian = value; }
        }
        
        /// <summary> ��Ʒ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassZengSong
        {            
            get { return this.ClassZengSong; }
            set { this.ClassZengSong = value; }
        }
        
        /// <summary> ���ֶ�ά��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassZhuShouErWeiMa
        {            
            get { return this.ClassZhuShouErWeiMa; }
            set { this.ClassZhuShouErWeiMa = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CountDianZan
        {            
            get { return this.CountDianZan; }
            set { this.CountDianZan = value; }
        }
        
        /// <summary> ��ע:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CountGuanZhu
        {            
            get { return this.CountGuanZhu; }
            set { this.CountGuanZhu = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CountPingLun
        {            
            get { return this.CountPingLun; }
            set { this.CountPingLun = value; }
        }
        
        /// <summary> ��ʦ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeacherId
        {            
            get { return this.TeacherId; }
            set { this.TeacherId = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _YuYinJieShao
        {            
            get { return this.YuYinJieShao; }
            set { this.YuYinJieShao = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ID
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
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassEndTime
        {
            get { return this.m_classendtime; }
            set //
            {
                if (!classendtime_initialized || m_classendtime != value)
                {
                    this.m_classendtime = value;
                }
                classendtime_initialized = true;
            }
        }
        
        /// <summary> ���ö�ά��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassErWeiMa
        {
            get { return this.m_classerweima; }
            set //
            {
                if (!classerweima_initialized || m_classerweima != value)
                {
                    this.m_classerweima = value;
                }
                classerweima_initialized = true;
            }
        }
        
        /// <summary> ���ͺ챦:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassHongBao
        {
            get { return this.m_classhongbao; }
            set //
            {
                if (!classhongbao_initialized || m_classhongbao != value)
                {
                    this.m_classhongbao = value;
                }
                classhongbao_initialized = true;
            }
        }
        
        /// <summary> ���ùؼ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassKeyWord
        {
            get { return this.m_classkeyword; }
            set //
            {
                if (!classkeyword_initialized || m_classkeyword != value)
                {
                    this.m_classkeyword = value;
                }
                classkeyword_initialized = true;
            }
        }
        
        /// <summary> ����ͼƬ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassPicture
        {
            get { return this.m_classpicture; }
            set //
            {
                if (!classpicture_initialized || m_classpicture != value)
                {
                    this.m_classpicture = value;
                }
                classpicture_initialized = true;
            }
        }
        
        /// <summary> �ʺ���Ⱥ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassRenQun
        {
            get { return this.m_classrenqun; }
            set //
            {
                if (!classrenqun_initialized || m_classrenqun != value)
                {
                    this.m_classrenqun = value;
                }
                classrenqun_initialized = true;
            }
        }
        
        /// <summary> ��ʼʱ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassStartTime
        {
            get { return this.m_classstarttime; }
            set //
            {
                if (!classstarttime_initialized || m_classstarttime != value)
                {
                    this.m_classstarttime = value;
                }
                classstarttime_initialized = true;
            }
        }
        
        /// <summary> ���ñ�ǩ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassTag
        {
            get { return this.m_classtag; }
            set //
            {
                if (!classtag_initialized || m_classtag != value)
                {
                    this.m_classtag = value;
                }
                classtag_initialized = true;
            }
        }
        
        /// <summary> ʱ�䳤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassTimeLong
        {
            get { return this.m_classtimelong; }
            set //
            {
                if (!classtimelong_initialized || m_classtimelong != value)
                {
                    this.m_classtimelong = value;
                }
                classtimelong_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassTitle
        {
            get { return this.m_classtitle; }
            set //
            {
                if (!classtitle_initialized || m_classtitle != value)
                {
                    this.m_classtitle = value;
                }
                classtitle_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassType
        {
            get { return this.m_classtype; }
            set //
            {
                if (!classtype_initialized || m_classtype != value)
                {
                    this.m_classtype = value;
                }
                classtype_initialized = true;
            }
        }
        
        /// <summary> ������ʽ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassXingShi
        {
            get { return this.m_classxingshi; }
            set //
            {
                if (!classxingshi_initialized || m_classxingshi != value)
                {
                    this.m_classxingshi = value;
                }
                classxingshi_initialized = true;
            }
        }
        
        /// <summary> ����Ҫ��:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassYaoDian
        {
            get { return this.m_classyaodian; }
            set //
            {
                if (!classyaodian_initialized || m_classyaodian != value)
                {
                    this.m_classyaodian = value;
                }
                classyaodian_initialized = true;
            }
        }
        
        /// <summary> ��Ʒ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassZengSong
        {
            get { return this.m_classzengsong; }
            set //
            {
                if (!classzengsong_initialized || m_classzengsong != value)
                {
                    this.m_classzengsong = value;
                }
                classzengsong_initialized = true;
            }
        }
        
        /// <summary> ���ֶ�ά��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassZhuShouErWeiMa
        {
            get { return this.m_classzhushouerweima; }
            set //
            {
                if (!classzhushouerweima_initialized || m_classzhushouerweima != value)
                {
                    this.m_classzhushouerweima = value;
                }
                classzhushouerweima_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int CountDianZan
        {
            get { return this.m_countdianzan; }
            set //
            {
                if (!countdianzan_initialized || m_countdianzan != value)
                {
                    this.m_countdianzan = value;
                }
                countdianzan_initialized = true;
            }
        }
        
        /// <summary> ��ע:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int CountGuanZhu
        {
            get { return this.m_countguanzhu; }
            set //
            {
                if (!countguanzhu_initialized || m_countguanzhu != value)
                {
                    this.m_countguanzhu = value;
                }
                countguanzhu_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int CountPingLun
        {
            get { return this.m_countpinglun; }
            set //
            {
                if (!countpinglun_initialized || m_countpinglun != value)
                {
                    this.m_countpinglun = value;
                }
                countpinglun_initialized = true;
            }
        }
        
        /// <summary> ��ʦ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TeacherId
        {
            get { return this.m_teacherid; }
            set //
            {
                if (!teacherid_initialized || m_teacherid != value)
                {
                    this.m_teacherid = value;
                }
                teacherid_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string YuYinJieShao
        {
            get { return this.m_yuyinjieshao; }
            set //
            {
                if (!yuyinjieshao_initialized || m_yuyinjieshao != value)
                {
                    this.m_yuyinjieshao = value;
                }
                yuyinjieshao_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ID =  new AttributeItem("[Xb_course].[ID]", typeof(int), 4, default(int));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassEndTime =  new AttributeItem("[Xb_course].[ClassEndTime]", typeof(string), 150, default(string));
            
            /// <summary>���ö�ά��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassErWeiMa =  new AttributeItem("[Xb_course].[ClassErWeiMa]", typeof(string), 150, default(string));
            
            /// <summary>���ͺ챦:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassHongBao =  new AttributeItem("[Xb_course].[ClassHongBao]", typeof(string), 150, default(string));
            
            /// <summary>���ùؼ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassKeyWord =  new AttributeItem("[Xb_course].[ClassKeyWord]", typeof(string), 200, default(string));
            
            /// <summary>����ͼƬ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassPicture =  new AttributeItem("[Xb_course].[ClassPicture]", typeof(string), 150, default(string));
            
            /// <summary>�ʺ���Ⱥ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassRenQun =  new AttributeItem("[Xb_course].[ClassRenQun]", typeof(string), 150, default(string));
            
            /// <summary>��ʼʱ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassStartTime =  new AttributeItem("[Xb_course].[ClassStartTime]", typeof(string), 150, default(string));
            
            /// <summary>���ñ�ǩ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassTag =  new AttributeItem("[Xb_course].[ClassTag]", typeof(string), 150, default(string));
            
            /// <summary>ʱ�䳤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassTimeLong =  new AttributeItem("[Xb_course].[ClassTimeLong]", typeof(string), 150, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassTitle =  new AttributeItem("[Xb_course].[ClassTitle]", typeof(string), 150, default(string));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassType =  new AttributeItem("[Xb_course].[ClassType]", typeof(string), 50, default(string));
            
            /// <summary>������ʽ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassXingShi =  new AttributeItem("[Xb_course].[ClassXingShi]", typeof(string), 150, default(string));
            
            /// <summary>����Ҫ��:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem ClassYaoDian =  new AttributeItem("[Xb_course].[ClassYaoDian]", typeof(string), 500, default(string));
            
            /// <summary>��Ʒ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassZengSong =  new AttributeItem("[Xb_course].[ClassZengSong]", typeof(string), 150, default(string));
            
            /// <summary>���ֶ�ά��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassZhuShouErWeiMa =  new AttributeItem("[Xb_course].[ClassZhuShouErWeiMa]", typeof(string), 150, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CountDianZan =  new AttributeItem("[Xb_course].[CountDianZan]", typeof(int), 4, default(int));
            
            /// <summary>��ע:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CountGuanZhu =  new AttributeItem("[Xb_course].[CountGuanZhu]", typeof(int), 4, default(int));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CountPingLun =  new AttributeItem("[Xb_course].[CountPingLun]", typeof(int), 4, default(int));
            
            /// <summary>��ʦ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeacherId =  new AttributeItem("[Xb_course].[TeacherId]", typeof(string), 150, default(string));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem YuYinJieShao =  new AttributeItem("[Xb_course].[YuYinJieShao]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_classendtime;
        /// <summary></summary>
        protected bool classendtime_initialized = false;
        
        private string m_classerweima;
        /// <summary></summary>
        protected bool classerweima_initialized = false;
        
        private string m_classhongbao;
        /// <summary></summary>
        protected bool classhongbao_initialized = false;
        
        private string m_classkeyword;
        /// <summary></summary>
        protected bool classkeyword_initialized = false;
        
        private string m_classpicture;
        /// <summary></summary>
        protected bool classpicture_initialized = false;
        
        private string m_classrenqun;
        /// <summary></summary>
        protected bool classrenqun_initialized = false;
        
        private string m_classstarttime;
        /// <summary></summary>
        protected bool classstarttime_initialized = false;
        
        private string m_classtag;
        /// <summary></summary>
        protected bool classtag_initialized = false;
        
        private string m_classtimelong;
        /// <summary></summary>
        protected bool classtimelong_initialized = false;
        
        private string m_classtitle;
        /// <summary></summary>
        protected bool classtitle_initialized = false;
        
        private string m_classtype;
        /// <summary></summary>
        protected bool classtype_initialized = false;
        
        private string m_classxingshi;
        /// <summary></summary>
        protected bool classxingshi_initialized = false;
        
        private string m_classyaodian;
        /// <summary></summary>
        protected bool classyaodian_initialized = false;
        
        private string m_classzengsong;
        /// <summary></summary>
        protected bool classzengsong_initialized = false;
        
        private string m_classzhushouerweima;
        /// <summary></summary>
        protected bool classzhushouerweima_initialized = false;
        
        private int m_countdianzan;
        /// <summary></summary>
        protected bool countdianzan_initialized = false;
        
        private int m_countguanzhu;
        /// <summary></summary>
        protected bool countguanzhu_initialized = false;
        
        private int m_countpinglun;
        /// <summary></summary>
        protected bool countpinglun_initialized = false;
        
        private string m_teacherid;
        /// <summary></summary>
        protected bool teacherid_initialized = false;
        
        private string m_yuyinjieshao;
        /// <summary></summary>
        protected bool yuyinjieshao_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_course";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.classendtime_initialized = IsLoadAllAttributes;this.classerweima_initialized = IsLoadAllAttributes;this.classhongbao_initialized = IsLoadAllAttributes;this.classkeyword_initialized = IsLoadAllAttributes;this.classpicture_initialized = IsLoadAllAttributes;this.classrenqun_initialized = IsLoadAllAttributes;this.classstarttime_initialized = IsLoadAllAttributes;this.classtag_initialized = IsLoadAllAttributes;this.classtimelong_initialized = IsLoadAllAttributes;this.classtitle_initialized = IsLoadAllAttributes;this.classtype_initialized = IsLoadAllAttributes;this.classxingshi_initialized = IsLoadAllAttributes;this.classyaodian_initialized = IsLoadAllAttributes;this.classzengsong_initialized = IsLoadAllAttributes;this.classzhushouerweima_initialized = IsLoadAllAttributes;this.countdianzan_initialized = IsLoadAllAttributes;this.countguanzhu_initialized = IsLoadAllAttributes;this.countpinglun_initialized = IsLoadAllAttributes;this.teacherid_initialized = IsLoadAllAttributes;this.yuyinjieshao_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_course value = new Xb_course();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"ID"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassEndTime"))
				value.classendtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassErWeiMa"))
				value.classerweima_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassHongBao"))
				value.classhongbao_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassKeyWord"))
				value.classkeyword_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassPicture"))
				value.classpicture_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassRenQun"))
				value.classrenqun_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassStartTime"))
				value.classstarttime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassTag"))
				value.classtag_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassTimeLong"))
				value.classtimelong_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassTitle"))
				value.classtitle_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassType"))
				value.classtype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassXingShi"))
				value.classxingshi_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassYaoDian"))
				value.classyaodian_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassZengSong"))
				value.classzengsong_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassZhuShouErWeiMa"))
				value.classzhushouerweima_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CountDianZan"))
				value.countdianzan_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CountGuanZhu"))
				value.countguanzhu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CountPingLun"))
				value.countpinglun_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeacherId"))
				value.teacherid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"YuYinJieShao"))
				value.yuyinjieshao_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_course Clone()
        {
            return (Xb_course)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_course()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_course() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_course(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_course(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_course(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_course(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_course(int id1, string classendtime1, string classerweima1, string classhongbao1, string classkeyword1, string classpicture1, string classrenqun1, string classstarttime1, string classtag1, string classtimelong1, string classtitle1, string classtype1, string classxingshi1, string classyaodian1, string classzengsong1, string classzhushouerweima1, int countdianzan1, int countguanzhu1, int countpinglun1, string teacherid1, string yuyinjieshao1)
        {
            
            this.ID = id1;
            
            this.ClassEndTime = classendtime1;
            
            this.ClassErWeiMa = classerweima1;
            
            this.ClassHongBao = classhongbao1;
            
            this.ClassKeyWord = classkeyword1;
            
            this.ClassPicture = classpicture1;
            
            this.ClassRenQun = classrenqun1;
            
            this.ClassStartTime = classstarttime1;
            
            this.ClassTag = classtag1;
            
            this.ClassTimeLong = classtimelong1;
            
            this.ClassTitle = classtitle1;
            
            this.ClassType = classtype1;
            
            this.ClassXingShi = classxingshi1;
            
            this.ClassYaoDian = classyaodian1;
            
            this.ClassZengSong = classzengsong1;
            
            this.ClassZhuShouErWeiMa = classzhushouerweima1;
            
            this.CountDianZan = countdianzan1;
            
            this.CountGuanZhu = countguanzhu1;
            
            this.CountPingLun = countpinglun1;
            
            this.TeacherId = teacherid1;
            
            this.YuYinJieShao = yuyinjieshao1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_course FromIView(IView view)
        {
            return (Xb_course)IView.GetITable(view, "Xb_course");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_course GetOneInstance()
        {
            Xb_course value = new Xb_course();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_course Retrieve()
        {
            BLLTable<Xb_course>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "ID":
			        return ID;
			    			
			    case "ClassEndTime":
			        return ClassEndTime;
			    			
			    case "ClassErWeiMa":
			        return ClassErWeiMa;
			    			
			    case "ClassHongBao":
			        return ClassHongBao;
			    			
			    case "ClassKeyWord":
			        return ClassKeyWord;
			    			
			    case "ClassPicture":
			        return ClassPicture;
			    			
			    case "ClassRenQun":
			        return ClassRenQun;
			    			
			    case "ClassStartTime":
			        return ClassStartTime;
			    			
			    case "ClassTag":
			        return ClassTag;
			    			
			    case "ClassTimeLong":
			        return ClassTimeLong;
			    			
			    case "ClassTitle":
			        return ClassTitle;
			    			
			    case "ClassType":
			        return ClassType;
			    			
			    case "ClassXingShi":
			        return ClassXingShi;
			    			
			    case "ClassYaoDian":
			        return ClassYaoDian;
			    			
			    case "ClassZengSong":
			        return ClassZengSong;
			    			
			    case "ClassZhuShouErWeiMa":
			        return ClassZhuShouErWeiMa;
			    			
			    case "CountDianZan":
			        return CountDianZan;
			    			
			    case "CountGuanZhu":
			        return CountGuanZhu;
			    			
			    case "CountPingLun":
			        return CountPingLun;
			    			
			    case "TeacherId":
			        return TeacherId;
			    			
			    case "YuYinJieShao":
			        return YuYinJieShao;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "ID":
			        this.ID = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ClassEndTime":
			        this.ClassEndTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassErWeiMa":
			        this.ClassErWeiMa = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassHongBao":
			        this.ClassHongBao = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassKeyWord":
			        this.ClassKeyWord = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassPicture":
			        this.ClassPicture = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassRenQun":
			        this.ClassRenQun = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassStartTime":
			        this.ClassStartTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassTag":
			        this.ClassTag = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassTimeLong":
			        this.ClassTimeLong = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassTitle":
			        this.ClassTitle = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassType":
			        this.ClassType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassXingShi":
			        this.ClassXingShi = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassYaoDian":
			        this.ClassYaoDian = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassZengSong":
			        this.ClassZengSong = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassZhuShouErWeiMa":
			        this.ClassZhuShouErWeiMa = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CountDianZan":
			        this.CountDianZan = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CountGuanZhu":
			        this.CountGuanZhu = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CountPingLun":
			        this.CountPingLun = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TeacherId":
			        this.TeacherId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "YuYinJieShao":
			        this.YuYinJieShao = Convert.ToString(AttributeValue);
                    return true;
			
                default:
                    return base.SetValue(AttributeName, AttributeValue);
			}
        }
        
        /// <summary>ͨ������ ��ȡ���ֶ��Ƿ��ѱ���ʼ��</summary>
        public override bool GetInitialized(AttributeItem AttributeName)
        {
			switch(AttributeName.FieldName)
			{	
				case "ID":
					return id_initialized;
				
				case "ClassEndTime":
					return classendtime_initialized;
				
				case "ClassErWeiMa":
					return classerweima_initialized;
				
				case "ClassHongBao":
					return classhongbao_initialized;
				
				case "ClassKeyWord":
					return classkeyword_initialized;
				
				case "ClassPicture":
					return classpicture_initialized;
				
				case "ClassRenQun":
					return classrenqun_initialized;
				
				case "ClassStartTime":
					return classstarttime_initialized;
				
				case "ClassTag":
					return classtag_initialized;
				
				case "ClassTimeLong":
					return classtimelong_initialized;
				
				case "ClassTitle":
					return classtitle_initialized;
				
				case "ClassType":
					return classtype_initialized;
				
				case "ClassXingShi":
					return classxingshi_initialized;
				
				case "ClassYaoDian":
					return classyaodian_initialized;
				
				case "ClassZengSong":
					return classzengsong_initialized;
				
				case "ClassZhuShouErWeiMa":
					return classzhushouerweima_initialized;
				
				case "CountDianZan":
					return countdianzan_initialized;
				
				case "CountGuanZhu":
					return countguanzhu_initialized;
				
				case "CountPingLun":
					return countpinglun_initialized;
				
				case "TeacherId":
					return teacherid_initialized;
				
				case "YuYinJieShao":
					return yuyinjieshao_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "ID":
					id_initialized = ret;
					return true;
				
				case "ClassEndTime":
					classendtime_initialized = ret;
					return true;
				
				case "ClassErWeiMa":
					classerweima_initialized = ret;
					return true;
				
				case "ClassHongBao":
					classhongbao_initialized = ret;
					return true;
				
				case "ClassKeyWord":
					classkeyword_initialized = ret;
					return true;
				
				case "ClassPicture":
					classpicture_initialized = ret;
					return true;
				
				case "ClassRenQun":
					classrenqun_initialized = ret;
					return true;
				
				case "ClassStartTime":
					classstarttime_initialized = ret;
					return true;
				
				case "ClassTag":
					classtag_initialized = ret;
					return true;
				
				case "ClassTimeLong":
					classtimelong_initialized = ret;
					return true;
				
				case "ClassTitle":
					classtitle_initialized = ret;
					return true;
				
				case "ClassType":
					classtype_initialized = ret;
					return true;
				
				case "ClassXingShi":
					classxingshi_initialized = ret;
					return true;
				
				case "ClassYaoDian":
					classyaodian_initialized = ret;
					return true;
				
				case "ClassZengSong":
					classzengsong_initialized = ret;
					return true;
				
				case "ClassZhuShouErWeiMa":
					classzhushouerweima_initialized = ret;
					return true;
				
				case "CountDianZan":
					countdianzan_initialized = ret;
					return true;
				
				case "CountGuanZhu":
					countguanzhu_initialized = ret;
					return true;
				
				case "CountPingLun":
					countpinglun_initialized = ret;
					return true;
				
				case "TeacherId":
					teacherid_initialized = ret;
					return true;
				
				case "YuYinJieShao":
					yuyinjieshao_initialized = ret;
					return true;
				
                default:
                    return base.SetInitialized(AttributeName, ret);
			}
        }
        #endregion

        #region ��ȡDataParameter PropertyInfo

        /// <summary>
        /// ��ȡ���б���ʼ������ֵ����ȡAttributeItem
        /// Ŀ��Ϊ��ȡ System.Windows.Forms.DataGridViewTextBoxColumn[] ���м����ݲ������ �Զ���� MyDataGridViewTextBoxColumn (����̳��� DataGridViewTextBoxColumn)
        /// ������������α����ķ�������Ϊ�˱����װ���̣�ʹ��Դ����ģʽ��ʱ�򣬲���������windows.form.dll��
        /// </summary>
        /// <returns></returns>
        public override AttributeItem[] af_GetAvailableAttributeItem(ref List<object> values)
        {
            List<AttributeItem> parametersList = new List<AttributeItem>();

			
			if (id_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ID);
                }
			}
			
			if (classendtime_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassEndTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassEndTime);
                }
			}
			
			if (classerweima_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassErWeiMa;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassErWeiMa);
                }
			}
			
			if (classhongbao_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassHongBao;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassHongBao);
                }
			}
			
			if (classkeyword_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassKeyWord;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassKeyWord);
                }
			}
			
			if (classpicture_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassPicture;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassPicture);
                }
			}
			
			if (classrenqun_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassRenQun;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassRenQun);
                }
			}
			
			if (classstarttime_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassStartTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassStartTime);
                }
			}
			
			if (classtag_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassTag;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassTag);
                }
			}
			
			if (classtimelong_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassTimeLong;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassTimeLong);
                }
			}
			
			if (classtitle_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassTitle;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassTitle);
                }
			}
			
			if (classtype_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassType);
                }
			}
			
			if (classxingshi_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassXingShi;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassXingShi);
                }
			}
			
			if (classyaodian_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassYaoDian;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassYaoDian);
                }
			}
			
			if (classzengsong_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassZengSong;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassZengSong);
                }
			}
			
			if (classzhushouerweima_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.ClassZhuShouErWeiMa;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassZhuShouErWeiMa);
                }
			}
			
			if (countdianzan_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.CountDianZan;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CountDianZan);
                }
			}
			
			if (countguanzhu_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.CountGuanZhu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CountGuanZhu);
                }
			}
			
			if (countpinglun_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.CountPingLun;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CountPingLun);
                }
			}
			
			if (teacherid_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.TeacherId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeacherId);
                }
			}
			
			if (yuyinjieshao_initialized)
			{
                AttributeItem attr = Xb_course.Attribute.YuYinJieShao;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(YuYinJieShao);
                }
			}
			
            
			parametersList.AddRange(base.af_GetAvailableAttributeItem(ref values));
            return parametersList.ToArray();
        }
        #endregion                

        #region Json����
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        [Serializable]
        public class Xb_courseJson
        {
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public int ID { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public string ClassEndTime { get; set; }
            
            /// <summary>���ö�ά��:[CtrlTypeDic-{InputString}]</summary>
            public string ClassErWeiMa { get; set; }
            
            /// <summary>���ͺ챦:[CtrlTypeDic-{InputString}]</summary>
            public string ClassHongBao { get; set; }
            
            /// <summary>���ùؼ���:[CtrlTypeDic-{InputString}]</summary>
            public string ClassKeyWord { get; set; }
            
            /// <summary>����ͼƬ:[CtrlTypeDic-{InputString}]</summary>
            public string ClassPicture { get; set; }
            
            /// <summary>�ʺ���Ⱥ:[CtrlTypeDic-{InputString}]</summary>
            public string ClassRenQun { get; set; }
            
            /// <summary>��ʼʱ��:[CtrlTypeDic-{InputString}]</summary>
            public string ClassStartTime { get; set; }
            
            /// <summary>���ñ�ǩ:[CtrlTypeDic-{InputString}]</summary>
            public string ClassTag { get; set; }
            
            /// <summary>ʱ�䳤��:[CtrlTypeDic-{InputString}]</summary>
            public string ClassTimeLong { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string ClassTitle { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string ClassType { get; set; }
            
            /// <summary>������ʽ:[CtrlTypeDic-{InputString}]</summary>
            public string ClassXingShi { get; set; }
            
            /// <summary>����Ҫ��:[CtrlTypeDic-{Text}]</summary>
            public string ClassYaoDian { get; set; }
            
            /// <summary>��Ʒ����:[CtrlTypeDic-{InputString}]</summary>
            public string ClassZengSong { get; set; }
            
            /// <summary>���ֶ�ά��:[CtrlTypeDic-{InputString}]</summary>
            public string ClassZhuShouErWeiMa { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public int CountDianZan { get; set; }
            
            /// <summary>��ע:[CtrlTypeDic-{InputString}]</summary>
            public int CountGuanZhu { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public int CountPingLun { get; set; }
            
            /// <summary>��ʦ���:[CtrlTypeDic-{InputString}]</summary>
            public string TeacherId { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string YuYinJieShao { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:20
  Description:    ���ݱ�Xb_comment_item��Ӧ��ҵ���߼���Xb_comment_item
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_comment_item_Entity:Xb_comment_item
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Course_name,CreateTime,Grade_name,Is_selection,ModifyTime,Qingqing_order_course_id,Student_appraise_time,Student_comment_word,Student_phrases,Teacher_appraise_time,Teacher_comment_word,Total_study_time,User_id,Uuid from Xb_comment_item
delete from Xb_comment_item
INSERT INTO Xb_comment_item (Id,Course_name,CreateTime,Grade_name,Is_selection,ModifyTime,Qingqing_order_course_id,Student_appraise_time,Student_comment_word,Student_phrases,Teacher_appraise_time,Teacher_comment_word,Total_study_time,User_id,Uuid)
     VALUES
           ('','','','','','','','','','','','','','','')
UPDATE Xb_comment_item SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Course_name = valObj2.Course_name;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Grade_name = valObj2.Grade_name;
        valObj.Is_selection = valObj2.Is_selection;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Qingqing_order_course_id = valObj2.Qingqing_order_course_id;
        valObj.Student_appraise_time = valObj2.Student_appraise_time;
        valObj.Student_comment_word = valObj2.Student_comment_word;
        valObj.Student_phrases = valObj2.Student_phrases;
        valObj.Teacher_appraise_time = valObj2.Teacher_appraise_time;
        valObj.Teacher_comment_word = valObj2.Teacher_comment_word;
        valObj.Total_study_time = valObj2.Total_study_time;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.Course_name = "";
        valObj.CreateTime = "";
        valObj.Grade_name = "";
        valObj.Is_selection = "";
        valObj.ModifyTime = "";
        valObj.Qingqing_order_course_id = "";
        valObj.Student_appraise_time = "";
        valObj.Student_comment_word = "";
        valObj.Student_phrases = "";
        valObj.Teacher_appraise_time = "";
        valObj.Teacher_comment_word = "";
        valObj.Total_study_time = "";
        valObj.User_id = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "Course_name": $("#txt_Course_name").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Grade_name": $("#txt_Grade_name").val(),
        "Is_selection": $("#txt_Is_selection").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Qingqing_order_course_id": $("#txt_Qingqing_order_course_id").val(),
        "Student_appraise_time": $("#txt_Student_appraise_time").val(),
        "Student_comment_word": $("#txt_Student_comment_word").val(),
        "Student_phrases": $("#txt_Student_phrases").val(),
        "Teacher_appraise_time": $("#txt_Teacher_appraise_time").val(),
        "Teacher_comment_word": $("#txt_Teacher_comment_word").val(),
        "Total_study_time": $("#txt_Total_study_time").val(),
        "User_id": $("#txt_User_id").val(),
        "Uuid": $("#txt_Uuid").val(), 
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
    /// <para></para>
    /// <para>��Xb_comment_item���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_comment_item : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_comment_item Factory()
        {
            return new Xb_comment_item();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_name
        {            
            get { return this.Course_name; }
            set { this.Course_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Grade_name
        {            
            get { return this.Grade_name; }
            set { this.Grade_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _Is_selection
        {            
            get { return this.Is_selection; }
            set { this.Is_selection = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Qingqing_order_course_id
        {            
            get { return this.Qingqing_order_course_id; }
            set { this.Qingqing_order_course_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Student_appraise_time
        {            
            get { return this.Student_appraise_time; }
            set { this.Student_appraise_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_comment_word
        {            
            get { return this.Student_comment_word; }
            set { this.Student_comment_word = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_phrases
        {            
            get { return this.Student_phrases; }
            set { this.Student_phrases = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Teacher_appraise_time
        {            
            get { return this.Teacher_appraise_time; }
            set { this.Teacher_appraise_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher_comment_word
        {            
            get { return this.Teacher_comment_word; }
            set { this.Teacher_comment_word = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Total_study_time
        {            
            get { return this.Total_study_time; }
            set { this.Total_study_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Course_name
        {
            get { return this.m_course_name; }
            set //
            {
                if (!course_name_initialized || m_course_name != value)
                {
                    this.m_course_name = value;
                }
                course_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime CreateTime
        {
            get { return this.m_createtime; }
            set //
            {
                if (!createtime_initialized || m_createtime != value)
                {
                    this.m_createtime = value;
                }
                createtime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Grade_name
        {
            get { return this.m_grade_name; }
            set //
            {
                if (!grade_name_initialized || m_grade_name != value)
                {
                    this.m_grade_name = value;
                }
                grade_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool Is_selection
        {
            get { return this.m_is_selection; }
            set //
            {
                if (!is_selection_initialized || m_is_selection != value)
                {
                    this.m_is_selection = value;
                }
                is_selection_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime ModifyTime
        {
            get { return this.m_modifytime; }
            set //
            {
                if (!modifytime_initialized || m_modifytime != value)
                {
                    this.m_modifytime = value;
                }
                modifytime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Qingqing_order_course_id
        {
            get { return this.m_qingqing_order_course_id; }
            set //
            {
                if (!qingqing_order_course_id_initialized || m_qingqing_order_course_id != value)
                {
                    this.m_qingqing_order_course_id = value;
                }
                qingqing_order_course_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Student_appraise_time
        {
            get { return this.m_student_appraise_time; }
            set //
            {
                if (!student_appraise_time_initialized || m_student_appraise_time != value)
                {
                    this.m_student_appraise_time = value;
                }
                student_appraise_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Student_comment_word
        {
            get { return this.m_student_comment_word; }
            set //
            {
                if (!student_comment_word_initialized || m_student_comment_word != value)
                {
                    this.m_student_comment_word = value;
                }
                student_comment_word_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Student_phrases
        {
            get { return this.m_student_phrases; }
            set //
            {
                if (!student_phrases_initialized || m_student_phrases != value)
                {
                    this.m_student_phrases = value;
                }
                student_phrases_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Teacher_appraise_time
        {
            get { return this.m_teacher_appraise_time; }
            set //
            {
                if (!teacher_appraise_time_initialized || m_teacher_appraise_time != value)
                {
                    this.m_teacher_appraise_time = value;
                }
                teacher_appraise_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Teacher_comment_word
        {
            get { return this.m_teacher_comment_word; }
            set //
            {
                if (!teacher_comment_word_initialized || m_teacher_comment_word != value)
                {
                    this.m_teacher_comment_word = value;
                }
                teacher_comment_word_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Total_study_time
        {
            get { return this.m_total_study_time; }
            set //
            {
                if (!total_study_time_initialized || m_total_study_time != value)
                {
                    this.m_total_study_time = value;
                }
                total_study_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_comment_item].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_name =  new AttributeItem("[Xb_comment_item].[Course_name]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_comment_item].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Grade_name =  new AttributeItem("[Xb_comment_item].[Grade_name]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Is_selection =  new AttributeItem("[Xb_comment_item].[Is_selection]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_comment_item].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Qingqing_order_course_id =  new AttributeItem("[Xb_comment_item].[Qingqing_order_course_id]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_appraise_time =  new AttributeItem("[Xb_comment_item].[Student_appraise_time]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_comment_word =  new AttributeItem("[Xb_comment_item].[Student_comment_word]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_phrases =  new AttributeItem("[Xb_comment_item].[Student_phrases]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_appraise_time =  new AttributeItem("[Xb_comment_item].[Teacher_appraise_time]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_comment_word =  new AttributeItem("[Xb_comment_item].[Teacher_comment_word]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Total_study_time =  new AttributeItem("[Xb_comment_item].[Total_study_time]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_comment_item].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_comment_item].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_course_name;
        /// <summary></summary>
        protected bool course_name_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_grade_name;
        /// <summary></summary>
        protected bool grade_name_initialized = false;
        
        private bool m_is_selection;
        /// <summary></summary>
        protected bool is_selection_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private decimal m_qingqing_order_course_id;
        /// <summary></summary>
        protected bool qingqing_order_course_id_initialized = false;
        
        private decimal m_student_appraise_time;
        /// <summary></summary>
        protected bool student_appraise_time_initialized = false;
        
        private string m_student_comment_word;
        /// <summary></summary>
        protected bool student_comment_word_initialized = false;
        
        private string m_student_phrases;
        /// <summary></summary>
        protected bool student_phrases_initialized = false;
        
        private decimal m_teacher_appraise_time;
        /// <summary></summary>
        protected bool teacher_appraise_time_initialized = false;
        
        private string m_teacher_comment_word;
        /// <summary></summary>
        protected bool teacher_comment_word_initialized = false;
        
        private string m_total_study_time;
        /// <summary></summary>
        protected bool total_study_time_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_comment_item";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.course_name_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.grade_name_initialized = IsLoadAllAttributes;this.is_selection_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.qingqing_order_course_id_initialized = IsLoadAllAttributes;this.student_appraise_time_initialized = IsLoadAllAttributes;this.student_comment_word_initialized = IsLoadAllAttributes;this.student_phrases_initialized = IsLoadAllAttributes;this.teacher_appraise_time_initialized = IsLoadAllAttributes;this.teacher_comment_word_initialized = IsLoadAllAttributes;this.total_study_time_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_comment_item value = new Xb_comment_item();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_name"))
				value.course_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade_name"))
				value.grade_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_selection"))
				value.is_selection_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Qingqing_order_course_id"))
				value.qingqing_order_course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_appraise_time"))
				value.student_appraise_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_comment_word"))
				value.student_comment_word_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_phrases"))
				value.student_phrases_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_appraise_time"))
				value.teacher_appraise_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_comment_word"))
				value.teacher_comment_word_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Total_study_time"))
				value.total_study_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_comment_item Clone()
        {
            return (Xb_comment_item)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_comment_item()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_comment_item() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_comment_item(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_comment_item(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_comment_item(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_comment_item(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_comment_item(int id1, string course_name1, DateTime createtime1, string grade_name1, bool is_selection1, DateTime modifytime1, decimal qingqing_order_course_id1, decimal student_appraise_time1, string student_comment_word1, string student_phrases1, decimal teacher_appraise_time1, string teacher_comment_word1, string total_study_time1, Guid user_id1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.Course_name = course_name1;
            
            this.CreateTime = createtime1;
            
            this.Grade_name = grade_name1;
            
            this.Is_selection = is_selection1;
            
            this.ModifyTime = modifytime1;
            
            this.Qingqing_order_course_id = qingqing_order_course_id1;
            
            this.Student_appraise_time = student_appraise_time1;
            
            this.Student_comment_word = student_comment_word1;
            
            this.Student_phrases = student_phrases1;
            
            this.Teacher_appraise_time = teacher_appraise_time1;
            
            this.Teacher_comment_word = teacher_comment_word1;
            
            this.Total_study_time = total_study_time1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_comment_item FromIView(IView view)
        {
            return (Xb_comment_item)IView.GetITable(view, "Xb_comment_item");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_comment_item GetOneInstance()
        {
            Xb_comment_item value = new Xb_comment_item();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_comment_item Retrieve()
        {
            BLLTable<Xb_comment_item>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Id":
			        return Id;
			    			
			    case "Course_name":
			        return Course_name;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Grade_name":
			        return Grade_name;
			    			
			    case "Is_selection":
			        return Is_selection;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Qingqing_order_course_id":
			        return Qingqing_order_course_id;
			    			
			    case "Student_appraise_time":
			        return Student_appraise_time;
			    			
			    case "Student_comment_word":
			        return Student_comment_word;
			    			
			    case "Student_phrases":
			        return Student_phrases;
			    			
			    case "Teacher_appraise_time":
			        return Teacher_appraise_time;
			    			
			    case "Teacher_comment_word":
			        return Teacher_comment_word;
			    			
			    case "Total_study_time":
			        return Total_study_time;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Uuid":
			        return Uuid;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Course_name":
			        this.Course_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Grade_name":
			        this.Grade_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_selection":
			        this.Is_selection = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Qingqing_order_course_id":
			        this.Qingqing_order_course_id = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Student_appraise_time":
			        this.Student_appraise_time = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Student_comment_word":
			        this.Student_comment_word = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_phrases":
			        this.Student_phrases = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_appraise_time":
			        this.Teacher_appraise_time = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Teacher_comment_word":
			        this.Teacher_comment_word = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Total_study_time":
			        this.Total_study_time = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
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
				case "Id":
					return id_initialized;
				
				case "Course_name":
					return course_name_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Grade_name":
					return grade_name_initialized;
				
				case "Is_selection":
					return is_selection_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Qingqing_order_course_id":
					return qingqing_order_course_id_initialized;
				
				case "Student_appraise_time":
					return student_appraise_time_initialized;
				
				case "Student_comment_word":
					return student_comment_word_initialized;
				
				case "Student_phrases":
					return student_phrases_initialized;
				
				case "Teacher_appraise_time":
					return teacher_appraise_time_initialized;
				
				case "Teacher_comment_word":
					return teacher_comment_word_initialized;
				
				case "Total_study_time":
					return total_study_time_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Course_name":
					course_name_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Grade_name":
					grade_name_initialized = ret;
					return true;
				
				case "Is_selection":
					is_selection_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Qingqing_order_course_id":
					qingqing_order_course_id_initialized = ret;
					return true;
				
				case "Student_appraise_time":
					student_appraise_time_initialized = ret;
					return true;
				
				case "Student_comment_word":
					student_comment_word_initialized = ret;
					return true;
				
				case "Student_phrases":
					student_phrases_initialized = ret;
					return true;
				
				case "Teacher_appraise_time":
					teacher_appraise_time_initialized = ret;
					return true;
				
				case "Teacher_comment_word":
					teacher_comment_word_initialized = ret;
					return true;
				
				case "Total_study_time":
					total_study_time_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
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
                AttributeItem attr = Xb_comment_item.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (course_name_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Course_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_name);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (grade_name_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Grade_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade_name);
                }
			}
			
			if (is_selection_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Is_selection;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_selection);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (qingqing_order_course_id_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Qingqing_order_course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Qingqing_order_course_id);
                }
			}
			
			if (student_appraise_time_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Student_appraise_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_appraise_time);
                }
			}
			
			if (student_comment_word_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Student_comment_word;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_comment_word);
                }
			}
			
			if (student_phrases_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Student_phrases;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_phrases);
                }
			}
			
			if (teacher_appraise_time_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Teacher_appraise_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_appraise_time);
                }
			}
			
			if (teacher_comment_word_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Teacher_comment_word;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_comment_word);
                }
			}
			
			if (total_study_time_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Total_study_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Total_study_time);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_comment_item.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
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
        public class Xb_comment_itemJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Course_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Grade_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Is_selection { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal Qingqing_order_course_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal Student_appraise_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Student_comment_word { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Student_phrases { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal Teacher_appraise_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_comment_word { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Total_study_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
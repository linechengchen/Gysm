/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    ���ݱ�Xt_student_course��Ӧ��ҵ���߼���Xt_student_course
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_student_course_Entity:Xt_student_course
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Create_time,Modify_time,Course_id,Student_id,Teacher_id,Is_pass,Pass_time,Pass_user_id,Is_manager,Group_id,Group_name from Xt_student_course
delete from Xt_student_course
INSERT INTO Xt_student_course (Id,Create_time,Modify_time,Course_id,Student_id,Teacher_id,Is_pass,Pass_time,Pass_user_id,Is_manager,Group_id,Group_name)
     VALUES
           ('','','','','','','','','','','','')
UPDATE Xt_student_course SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Create_time = valObj2.Create_time;
        valObj.Modify_time = valObj2.Modify_time;
        valObj.Course_id = valObj2.Course_id;
        valObj.Student_id = valObj2.Student_id;
        valObj.Teacher_id = valObj2.Teacher_id;
        valObj.Is_pass = valObj2.Is_pass;
        valObj.Pass_time = valObj2.Pass_time;
        valObj.Pass_user_id = valObj2.Pass_user_id;
        valObj.Is_manager = valObj2.Is_manager;
        valObj.Group_id = valObj2.Group_id;
        valObj.Group_name = valObj2.Group_name; 
        valObj.Id = "";
        valObj.Create_time = "";
        valObj.Modify_time = "";
        valObj.Course_id = "";
        valObj.Student_id = "";
        valObj.Teacher_id = "";
        valObj.Is_pass = "";
        valObj.Pass_time = "";
        valObj.Pass_user_id = "";
        valObj.Is_manager = "";
        valObj.Group_id = "";
        valObj.Group_name = ""; 
        "Id": $("#txt_Id").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Modify_time": $("#txt_Modify_time").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Student_id": $("#txt_Student_id").val(),
        "Teacher_id": $("#txt_Teacher_id").val(),
        "Is_pass": $("#txt_Is_pass").val(),
        "Pass_time": $("#txt_Pass_time").val(),
        "Pass_user_id": $("#txt_Pass_user_id").val(),
        "Is_manager": $("#txt_Is_manager").val(),
        "Group_id": $("#txt_Group_id").val(),
        "Group_name": $("#txt_Group_name").val(), 
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
    /// <para>ѧ���γ̹�ϵ��</para>
    /// <para>��Xt_student_course���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_student_course : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_student_course Factory()
        {
            return new Xt_student_course();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> �޸�ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        
        /// <summary> �γ�id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> ѧ��id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        
        /// <summary> ��ʦid:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher_id
        {            
            get { return this.Teacher_id; }
            set { this.Teacher_id = value; }
        }
        
        /// <summary> �Ƿ�ͨ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_pass
        {            
            get { return this.Is_pass; }
            set { this.Is_pass = value; }
        }
        
        /// <summary> ͨ��ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Pass_time
        {            
            get { return this.Pass_time; }
            set { this.Pass_time = value; }
        }
        
        /// <summary> ͨ���û�id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Pass_user_id
        {            
            get { return this.Pass_user_id; }
            set { this.Pass_user_id = value; }
        }
        
        /// <summary> �Ƿ��ǹ���Ա:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_manager
        {            
            get { return this.Is_manager; }
            set { this.Is_manager = value; }
        }
        
        /// <summary> ����ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Group_id
        {            
            get { return this.Group_id; }
            set { this.Group_id = value; }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Group_name
        {            
            get { return this.Group_name; }
            set { this.Group_name = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid Id
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
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Create_time
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
        
        /// <summary> �޸�ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Modify_time
        {
            get { return this.m_modify_time; }
            set //
            {
                if (!modify_time_initialized || m_modify_time != value)
                {
                    this.m_modify_time = value;
                }
                modify_time_initialized = true;
            }
        }
        
        /// <summary> �γ�id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Course_id
        {
            get { return this.m_course_id; }
            set //
            {
                if (!course_id_initialized || m_course_id != value)
                {
                    this.m_course_id = value;
                }
                course_id_initialized = true;
            }
        }
        
        /// <summary> ѧ��id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Student_id
        {
            get { return this.m_student_id; }
            set //
            {
                if (!student_id_initialized || m_student_id != value)
                {
                    this.m_student_id = value;
                }
                student_id_initialized = true;
            }
        }
        
        /// <summary> ��ʦid:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Teacher_id
        {
            get { return this.m_teacher_id; }
            set //
            {
                if (!teacher_id_initialized || m_teacher_id != value)
                {
                    this.m_teacher_id = value;
                }
                teacher_id_initialized = true;
            }
        }
        
        /// <summary> �Ƿ�ͨ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Is_pass
        {
            get { return this.m_is_pass; }
            set //
            {
                if (!is_pass_initialized || m_is_pass != value)
                {
                    this.m_is_pass = value;
                }
                is_pass_initialized = true;
            }
        }
        
        /// <summary> ͨ��ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Pass_time
        {
            get { return this.m_pass_time; }
            set //
            {
                if (!pass_time_initialized || m_pass_time != value)
                {
                    this.m_pass_time = value;
                }
                pass_time_initialized = true;
            }
        }
        
        /// <summary> ͨ���û�id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Pass_user_id
        {
            get { return this.m_pass_user_id; }
            set //
            {
                if (!pass_user_id_initialized || m_pass_user_id != value)
                {
                    this.m_pass_user_id = value;
                }
                pass_user_id_initialized = true;
            }
        }
        
        /// <summary> �Ƿ��ǹ���Ա:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Is_manager
        {
            get { return this.m_is_manager; }
            set //
            {
                if (!is_manager_initialized || m_is_manager != value)
                {
                    this.m_is_manager = value;
                }
                is_manager_initialized = true;
            }
        }
        
        /// <summary> ����ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Group_id
        {
            get { return this.m_group_id; }
            set //
            {
                if (!group_id_initialized || m_group_id != value)
                {
                    this.m_group_id = value;
                }
                group_id_initialized = true;
            }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Group_name
        {
            get { return this.m_group_name; }
            set //
            {
                if (!group_name_initialized || m_group_name != value)
                {
                    this.m_group_name = value;
                }
                group_name_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xt_student_course].[Id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_student_course].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>�޸�ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xt_student_course].[Modify_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>�γ�id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_student_course].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>ѧ��id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xt_student_course].[Student_id]", typeof(string), 36, default(string));
            
            /// <summary>��ʦid:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_id =  new AttributeItem("[Xt_student_course].[Teacher_id]", typeof(string), 36, default(string));
            
            /// <summary>�Ƿ�ͨ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_pass =  new AttributeItem("[Xt_student_course].[Is_pass]", typeof(string), 1, default(string));
            
            /// <summary>ͨ��ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Pass_time =  new AttributeItem("[Xt_student_course].[Pass_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>ͨ���û�id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pass_user_id =  new AttributeItem("[Xt_student_course].[Pass_user_id]", typeof(string), 36, default(string));
            
            /// <summary>�Ƿ��ǹ���Ա:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_manager =  new AttributeItem("[Xt_student_course].[Is_manager]", typeof(string), 1, default(string));
            
            /// <summary>����ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Group_id =  new AttributeItem("[Xt_student_course].[Group_id]", typeof(string), 36, default(string));
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Group_name =  new AttributeItem("[Xt_student_course].[Group_name]", typeof(string), 100, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        
        private string m_teacher_id;
        /// <summary></summary>
        protected bool teacher_id_initialized = false;
        
        private string m_is_pass;
        /// <summary></summary>
        protected bool is_pass_initialized = false;
        
        private DateTime m_pass_time;
        /// <summary></summary>
        protected bool pass_time_initialized = false;
        
        private string m_pass_user_id;
        /// <summary></summary>
        protected bool pass_user_id_initialized = false;
        
        private string m_is_manager;
        /// <summary></summary>
        protected bool is_manager_initialized = false;
        
        private string m_group_id;
        /// <summary></summary>
        protected bool group_id_initialized = false;
        
        private string m_group_name;
        /// <summary></summary>
        protected bool group_name_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_student_course";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;this.teacher_id_initialized = IsLoadAllAttributes;this.is_pass_initialized = IsLoadAllAttributes;this.pass_time_initialized = IsLoadAllAttributes;this.pass_user_id_initialized = IsLoadAllAttributes;this.is_manager_initialized = IsLoadAllAttributes;this.group_id_initialized = IsLoadAllAttributes;this.group_name_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_student_course value = new Xt_student_course();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_id"))
				value.teacher_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_pass"))
				value.is_pass_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pass_time"))
				value.pass_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pass_user_id"))
				value.pass_user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_manager"))
				value.is_manager_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Group_id"))
				value.group_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Group_name"))
				value.group_name_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_student_course Clone()
        {
            return (Xt_student_course)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_student_course()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_student_course() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_student_course(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_student_course(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_student_course(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_student_course(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_student_course(Guid id1, DateTime create_time1, DateTime modify_time1, string course_id1, string student_id1, string teacher_id1, string is_pass1, DateTime pass_time1, string pass_user_id1, string is_manager1, string group_id1, string group_name1)
        {
            
            this.Id = id1;
            
            this.Create_time = create_time1;
            
            this.Modify_time = modify_time1;
            
            this.Course_id = course_id1;
            
            this.Student_id = student_id1;
            
            this.Teacher_id = teacher_id1;
            
            this.Is_pass = is_pass1;
            
            this.Pass_time = pass_time1;
            
            this.Pass_user_id = pass_user_id1;
            
            this.Is_manager = is_manager1;
            
            this.Group_id = group_id1;
            
            this.Group_name = group_name1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_student_course FromIView(IView view)
        {
            return (Xt_student_course)IView.GetITable(view, "Xt_student_course");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_student_course GetOneInstance()
        {
            Xt_student_course value = new Xt_student_course();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_student_course Retrieve()
        {
            BLLTable<Xt_student_course>.GetRowData(this);
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
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Modify_time":
			        return Modify_time;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Student_id":
			        return Student_id;
			    			
			    case "Teacher_id":
			        return Teacher_id;
			    			
			    case "Is_pass":
			        return Is_pass;
			    			
			    case "Pass_time":
			        return Pass_time;
			    			
			    case "Pass_user_id":
			        return Pass_user_id;
			    			
			    case "Is_manager":
			        return Is_manager;
			    			
			    case "Group_id":
			        return Group_id;
			    			
			    case "Group_name":
			        return Group_name;
			
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
			        this.Id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_id":
			        this.Teacher_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_pass":
			        this.Is_pass = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Pass_time":
			        this.Pass_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Pass_user_id":
			        this.Pass_user_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_manager":
			        this.Is_manager = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Group_id":
			        this.Group_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Group_name":
			        this.Group_name = Convert.ToString(AttributeValue);
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
				
				case "Create_time":
					return create_time_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
				case "Teacher_id":
					return teacher_id_initialized;
				
				case "Is_pass":
					return is_pass_initialized;
				
				case "Pass_time":
					return pass_time_initialized;
				
				case "Pass_user_id":
					return pass_user_id_initialized;
				
				case "Is_manager":
					return is_manager_initialized;
				
				case "Group_id":
					return group_id_initialized;
				
				case "Group_name":
					return group_name_initialized;
				
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
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
					return true;
				
				case "Teacher_id":
					teacher_id_initialized = ret;
					return true;
				
				case "Is_pass":
					is_pass_initialized = ret;
					return true;
				
				case "Pass_time":
					pass_time_initialized = ret;
					return true;
				
				case "Pass_user_id":
					pass_user_id_initialized = ret;
					return true;
				
				case "Is_manager":
					is_manager_initialized = ret;
					return true;
				
				case "Group_id":
					group_id_initialized = ret;
					return true;
				
				case "Group_name":
					group_name_initialized = ret;
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
                AttributeItem attr = Xt_student_course.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
                }
			}
			
			if (teacher_id_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Teacher_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_id);
                }
			}
			
			if (is_pass_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Is_pass;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_pass);
                }
			}
			
			if (pass_time_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Pass_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pass_time);
                }
			}
			
			if (pass_user_id_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Pass_user_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pass_user_id);
                }
			}
			
			if (is_manager_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Is_manager;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_manager);
                }
			}
			
			if (group_id_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Group_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Group_id);
                }
			}
			
			if (group_name_initialized)
			{
                AttributeItem attr = Xt_student_course.Attribute.Group_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Group_name);
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
        public class Xt_student_courseJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Id { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>�޸�ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Modify_time { get; set; }
            
            /// <summary>�γ�id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>ѧ��id:[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
            
            /// <summary>��ʦid:[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_id { get; set; }
            
            /// <summary>�Ƿ�ͨ��:[CtrlTypeDic-{InputString}]</summary>
            public string Is_pass { get; set; }
            
            /// <summary>ͨ��ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Pass_time { get; set; }
            
            /// <summary>ͨ���û�id:[CtrlTypeDic-{InputString}]</summary>
            public string Pass_user_id { get; set; }
            
            /// <summary>�Ƿ��ǹ���Ա:[CtrlTypeDic-{InputString}]</summary>
            public string Is_manager { get; set; }
            
            /// <summary>����ID:[CtrlTypeDic-{InputString}]</summary>
            public string Group_id { get; set; }
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public string Group_name { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:58
  Description:    ���ݱ�V_xt_student_task��Ӧ��ҵ���߼���V_xt_student_task
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� V_xt_student_task_Entity:V_xt_student_task
 * 
************************************************************/
/************************************************************
SQL���룺
select Taskfile,Student_id,Submit,Task_result,Approval,Approval_people,Approval_time,Submit_time,Mark,Grade,Task_id from V_xt_student_task
delete from V_xt_student_task
INSERT INTO V_xt_student_task (Taskfile,Student_id,Submit,Task_result,Approval,Approval_people,Approval_time,Submit_time,Mark,Grade,Task_id)
     VALUES
           ('','','','','','','','','','','')
UPDATE V_xt_student_task SET ...
������ֵ���룺
 *         valObj.Taskfile = valObj2.Taskfile;
        valObj.Student_id = valObj2.Student_id;
        valObj.Submit = valObj2.Submit;
        valObj.Task_result = valObj2.Task_result;
        valObj.Approval = valObj2.Approval;
        valObj.Approval_people = valObj2.Approval_people;
        valObj.Approval_time = valObj2.Approval_time;
        valObj.Submit_time = valObj2.Submit_time;
        valObj.Mark = valObj2.Mark;
        valObj.Grade = valObj2.Grade;
        valObj.Task_id = valObj2.Task_id; 
        valObj.Taskfile = "";
        valObj.Student_id = "";
        valObj.Submit = "";
        valObj.Task_result = "";
        valObj.Approval = "";
        valObj.Approval_people = "";
        valObj.Approval_time = "";
        valObj.Submit_time = "";
        valObj.Mark = "";
        valObj.Grade = "";
        valObj.Task_id = ""; 
        "Taskfile": $("#txt_Taskfile").val(),
        "Student_id": $("#txt_Student_id").val(),
        "Submit": $("#txt_Submit").val(),
        "Task_result": $("#txt_Task_result").val(),
        "Approval": $("#txt_Approval").val(),
        "Approval_people": $("#txt_Approval_people").val(),
        "Approval_time": $("#txt_Approval_time").val(),
        "Submit_time": $("#txt_Submit_time").val(),
        "Mark": $("#txt_Mark").val(),
        "Grade": $("#txt_Grade").val(),
        "Task_id": $("#txt_Task_id").val(), 
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
    /// <para>ѧ����ҵ������__ѧ����ҵ�����:[Inner-{Xt_student_task:0},{Xt_student_task_result:1}]</para>
    /// <para>��V_xt_student_task���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class V_xt_student_task : ITableImplement
    {
        /// <summary>��������  </summary>
        public static V_xt_student_task Factory()
        {
            return new V_xt_student_task();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ��ҵ�ļ� Attribute_IsNotNull </summary>
        public string _Taskfile
        {            
            get { return this.Taskfile; }
            set { this.Taskfile = value; }
        }
        
        /// <summary> ѧ��ID Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        
        /// <summary> �ύʱ�� Attribute_IsNotNull </summary>
        public string _Submit
        {            
            get { return this.Submit; }
            set { this.Submit = value; }
        }
        
        /// <summary> ��ҵ��� Attribute_IsNotNull </summary>
        public string _Task_result
        {            
            get { return this.Task_result; }
            set { this.Task_result = value; }
        }
        
        /// <summary> ����״̬ Attribute_IsNotNull </summary>
        public string _Approval
        {            
            get { return this.Approval; }
            set { this.Approval = value; }
        }
        
        /// <summary> ������ Attribute_IsNotNull </summary>
        public string _Approval_people
        {            
            get { return this.Approval_people; }
            set { this.Approval_people = value; }
        }
        
        /// <summary> ����ʱ�� Attribute_IsNotNull </summary>
        public DateTime _Approval_time
        {            
            get { return this.Approval_time; }
            set { this.Approval_time = value; }
        }
        
        /// <summary> �ύʱ�� Attribute_IsNotNull </summary>
        public DateTime _Submit_time
        {            
            get { return this.Submit_time; }
            set { this.Submit_time = value; }
        }
        
        /// <summary> �ɼ� Attribute_IsNotNull </summary>
        public int _Mark
        {            
            get { return this.Mark; }
            set { this.Mark = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> ��ҵID Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ��ҵ�ļ����Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Taskfile
        {
            get { return this.m_taskfile; }
            set //
            {
                if (!taskfile_initialized || m_taskfile != value)
                {
                    this.m_taskfile = value;
                }
                taskfile_initialized = true;
            }
        }
        
        /// <summary> ѧ��ID���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �ύʱ�䣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Submit
        {
            get { return this.m_submit; }
            set //
            {
                if (!submit_initialized || m_submit != value)
                {
                    this.m_submit = value;
                }
                submit_initialized = true;
            }
        }
        
        /// <summary> ��ҵ������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Task_result
        {
            get { return this.m_task_result; }
            set //
            {
                if (!task_result_initialized || m_task_result != value)
                {
                    this.m_task_result = value;
                }
                task_result_initialized = true;
            }
        }
        
        /// <summary> ����״̬���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Approval
        {
            get { return this.m_approval; }
            set //
            {
                if (!approval_initialized || m_approval != value)
                {
                    this.m_approval = value;
                }
                approval_initialized = true;
            }
        }
        
        /// <summary> �����ˣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Approval_people
        {
            get { return this.m_approval_people; }
            set //
            {
                if (!approval_people_initialized || m_approval_people != value)
                {
                    this.m_approval_people = value;
                }
                approval_people_initialized = true;
            }
        }
        
        /// <summary> ����ʱ�䣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Approval_time
        {
            get { return this.m_approval_time; }
            set //
            {
                if (!approval_time_initialized || m_approval_time != value)
                {
                    this.m_approval_time = value;
                }
                approval_time_initialized = true;
            }
        }
        
        /// <summary> �ύʱ�䣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Submit_time
        {
            get { return this.m_submit_time; }
            set //
            {
                if (!submit_time_initialized || m_submit_time != value)
                {
                    this.m_submit_time = value;
                }
                submit_time_initialized = true;
            }
        }
        
        /// <summary> �ɼ����Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Mark
        {
            get { return this.m_mark; }
            set //
            {
                if (!mark_initialized || m_mark != value)
                {
                    this.m_mark = value;
                }
                mark_initialized = true;
            }
        }
        
        /// <summary> �������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Grade
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
        
        /// <summary> ��ҵID���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Task_id
        {
            get { return this.m_task_id; }
            set //
            {
                if (!task_id_initialized || m_task_id != value)
                {
                    this.m_task_id = value;
                }
                task_id_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>��ҵ�ļ�</summary>
            public static AttributeItem Taskfile =  new AttributeItem("[V_xt_student_task].[Taskfile]", typeof(string), 50, default(string));
            
            /// <summary>ѧ��ID</summary>
            public static AttributeItem Student_id =  new AttributeItem("[V_xt_student_task].[Student_id]", typeof(string), 36, default(string));
            
            /// <summary>�ύʱ��</summary>
            public static AttributeItem Submit =  new AttributeItem("[V_xt_student_task].[Submit]", typeof(string), 36, default(string));
            
            /// <summary>��ҵ���</summary>
            public static AttributeItem Task_result =  new AttributeItem("[V_xt_student_task].[Task_result]", typeof(string), 1, default(string));
            
            /// <summary>����״̬</summary>
            public static AttributeItem Approval =  new AttributeItem("[V_xt_student_task].[Approval]", typeof(string), 1, default(string));
            
            /// <summary>������</summary>
            public static AttributeItem Approval_people =  new AttributeItem("[V_xt_student_task].[Approval_people]", typeof(string), 50, default(string));
            
            /// <summary>����ʱ��</summary>
            public static AttributeItem Approval_time =  new AttributeItem("[V_xt_student_task].[Approval_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>�ύʱ��</summary>
            public static AttributeItem Submit_time =  new AttributeItem("[V_xt_student_task].[Submit_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>�ɼ�</summary>
            public static AttributeItem Mark =  new AttributeItem("[V_xt_student_task].[Mark]", typeof(int), 4, default(int));
            
            /// <summary>����</summary>
            public static AttributeItem Grade =  new AttributeItem("[V_xt_student_task].[Grade]", typeof(int), 4, default(int));
            
            /// <summary>��ҵID</summary>
            public static AttributeItem Task_id =  new AttributeItem("[V_xt_student_task].[Task_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_taskfile;
        /// <summary></summary>
        protected bool taskfile_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        
        private string m_submit;
        /// <summary></summary>
        protected bool submit_initialized = false;
        
        private string m_task_result;
        /// <summary></summary>
        protected bool task_result_initialized = false;
        
        private string m_approval;
        /// <summary></summary>
        protected bool approval_initialized = false;
        
        private string m_approval_people;
        /// <summary></summary>
        protected bool approval_people_initialized = false;
        
        private DateTime m_approval_time;
        /// <summary></summary>
        protected bool approval_time_initialized = false;
        
        private DateTime m_submit_time;
        /// <summary></summary>
        protected bool submit_time_initialized = false;
        
        private int m_mark;
        /// <summary></summary>
        protected bool mark_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_xt_student_task";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.taskfile_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;this.submit_initialized = IsLoadAllAttributes;this.task_result_initialized = IsLoadAllAttributes;this.approval_initialized = IsLoadAllAttributes;this.approval_people_initialized = IsLoadAllAttributes;this.approval_time_initialized = IsLoadAllAttributes;this.submit_time_initialized = IsLoadAllAttributes;this.mark_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_xt_student_task value = new V_xt_student_task();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Taskfile"))
				value.taskfile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit"))
				value.submit_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_result"))
				value.task_result_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval"))
				value.approval_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval_people"))
				value.approval_people_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval_time"))
				value.approval_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit_time"))
				value.submit_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mark"))
				value.mark_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new V_xt_student_task Clone()
        {
            return (V_xt_student_task)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static V_xt_student_task()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public V_xt_student_task() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public V_xt_student_task(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public V_xt_student_task(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public V_xt_student_task(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public V_xt_student_task(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public V_xt_student_task(string taskfile1, string student_id1, string submit1, string task_result1, string approval1, string approval_people1, DateTime approval_time1, DateTime submit_time1, int mark1, int grade1, string task_id1)
        {
            
            this.Taskfile = taskfile1;
            
            this.Student_id = student_id1;
            
            this.Submit = submit1;
            
            this.Task_result = task_result1;
            
            this.Approval = approval1;
            
            this.Approval_people = approval_people1;
            
            this.Approval_time = approval_time1;
            
            this.Submit_time = submit_time1;
            
            this.Mark = mark1;
            
            this.Grade = grade1;
            
            this.Task_id = task_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static V_xt_student_task FromIView(IView view)
        {
            return (V_xt_student_task)IView.GetITable(view, "V_xt_student_task");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static V_xt_student_task GetOneInstance()
        {
            V_xt_student_task value = new V_xt_student_task();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public V_xt_student_task Retrieve()
        {
            BLLTable<V_xt_student_task>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Taskfile":
			        return Taskfile;
			    			
			    case "Student_id":
			        return Student_id;
			    			
			    case "Submit":
			        return Submit;
			    			
			    case "Task_result":
			        return Task_result;
			    			
			    case "Approval":
			        return Approval;
			    			
			    case "Approval_people":
			        return Approval_people;
			    			
			    case "Approval_time":
			        return Approval_time;
			    			
			    case "Submit_time":
			        return Submit_time;
			    			
			    case "Mark":
			        return Mark;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Task_id":
			        return Task_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Taskfile":
			        this.Taskfile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Submit":
			        this.Submit = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Task_result":
			        this.Task_result = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Approval":
			        this.Approval = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Approval_people":
			        this.Approval_people = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Approval_time":
			        this.Approval_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Submit_time":
			        this.Submit_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Mark":
			        this.Mark = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
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
				case "Taskfile":
					return taskfile_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
				case "Submit":
					return submit_initialized;
				
				case "Task_result":
					return task_result_initialized;
				
				case "Approval":
					return approval_initialized;
				
				case "Approval_people":
					return approval_people_initialized;
				
				case "Approval_time":
					return approval_time_initialized;
				
				case "Submit_time":
					return submit_time_initialized;
				
				case "Mark":
					return mark_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Taskfile":
					taskfile_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
					return true;
				
				case "Submit":
					submit_initialized = ret;
					return true;
				
				case "Task_result":
					task_result_initialized = ret;
					return true;
				
				case "Approval":
					approval_initialized = ret;
					return true;
				
				case "Approval_people":
					approval_people_initialized = ret;
					return true;
				
				case "Approval_time":
					approval_time_initialized = ret;
					return true;
				
				case "Submit_time":
					submit_time_initialized = ret;
					return true;
				
				case "Mark":
					mark_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
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

			
			if (taskfile_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Taskfile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Taskfile);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
                }
			}
			
			if (submit_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Submit;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit);
                }
			}
			
			if (task_result_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Task_result;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_result);
                }
			}
			
			if (approval_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Approval;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval);
                }
			}
			
			if (approval_people_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Approval_people;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval_people);
                }
			}
			
			if (approval_time_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Approval_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval_time);
                }
			}
			
			if (submit_time_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Submit_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit_time);
                }
			}
			
			if (mark_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Mark;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mark);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = V_xt_student_task.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
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
        public class V_xt_student_taskJson
        {
            
            /// <summary>��ҵ�ļ�</summary>
            public string Taskfile { get; set; }
            
            /// <summary>ѧ��ID</summary>
            public string Student_id { get; set; }
            
            /// <summary>�ύʱ��</summary>
            public string Submit { get; set; }
            
            /// <summary>��ҵ���</summary>
            public string Task_result { get; set; }
            
            /// <summary>����״̬</summary>
            public string Approval { get; set; }
            
            /// <summary>������</summary>
            public string Approval_people { get; set; }
            
            /// <summary>����ʱ��</summary>
            public DateTime Approval_time { get; set; }
            
            /// <summary>�ύʱ��</summary>
            public DateTime Submit_time { get; set; }
            
            /// <summary>�ɼ�</summary>
            public int Mark { get; set; }
            
            /// <summary>����</summary>
            public int Grade { get; set; }
            
            /// <summary>��ҵID</summary>
            public string Task_id { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    ���ݱ�Xt_student_task��Ӧ��ҵ���߼���Xt_student_task
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_student_task_Entity:Xt_student_task
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Task_id,Submit,Student_id,Taskfile,Task_result,Approval,Approval_people,Approval_time from Xt_student_task
delete from Xt_student_task
INSERT INTO Xt_student_task (Uuid,Task_id,Submit,Student_id,Taskfile,Task_result,Approval,Approval_people,Approval_time)
     VALUES
           ('','','','','','','','','')
UPDATE Xt_student_task SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Task_id = valObj2.Task_id;
        valObj.Submit = valObj2.Submit;
        valObj.Student_id = valObj2.Student_id;
        valObj.Taskfile = valObj2.Taskfile;
        valObj.Task_result = valObj2.Task_result;
        valObj.Approval = valObj2.Approval;
        valObj.Approval_people = valObj2.Approval_people;
        valObj.Approval_time = valObj2.Approval_time; 
        valObj.Uuid = "";
        valObj.Task_id = "";
        valObj.Submit = "";
        valObj.Student_id = "";
        valObj.Taskfile = "";
        valObj.Task_result = "";
        valObj.Approval = "";
        valObj.Approval_people = "";
        valObj.Approval_time = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Task_id": $("#txt_Task_id").val(),
        "Submit": $("#txt_Submit").val(),
        "Student_id": $("#txt_Student_id").val(),
        "Taskfile": $("#txt_Taskfile").val(),
        "Task_result": $("#txt_Task_result").val(),
        "Approval": $("#txt_Approval").val(),
        "Approval_people": $("#txt_Approval_people").val(),
        "Approval_time": $("#txt_Approval_time").val(), 
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
    /// <para>ѧ����ҵ������</para>
    /// <para>��Xt_student_task���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_student_task : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_student_task Factory()
        {
            return new Xt_student_task();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> ��ҵID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        
        /// <summary> �ύʱ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Submit
        {            
            get { return this.Submit; }
            set { this.Submit = value; }
        }
        
        /// <summary> ѧ��ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        
        /// <summary> ��ҵ�ļ�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Taskfile
        {            
            get { return this.Taskfile; }
            set { this.Taskfile = value; }
        }
        
        /// <summary> ��ҵ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Task_result
        {            
            get { return this.Task_result; }
            set { this.Task_result = value; }
        }
        
        /// <summary> ����״̬:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Approval
        {            
            get { return this.Approval; }
            set { this.Approval = value; }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Approval_people
        {            
            get { return this.Approval_people; }
            set { this.Approval_people = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Approval_time
        {            
            get { return this.Approval_time; }
            set { this.Approval_time = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
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
        
        /// <summary> ��ҵID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �ύʱ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ѧ��ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ҵ�ļ�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ҵ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����״̬:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_student_task].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>��ҵID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Task_id =  new AttributeItem("[Xt_student_task].[Task_id]", typeof(string), 36, default(string));
            
            /// <summary>�ύʱ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Submit =  new AttributeItem("[Xt_student_task].[Submit]", typeof(string), 36, default(string));
            
            /// <summary>ѧ��ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xt_student_task].[Student_id]", typeof(string), 36, default(string));
            
            /// <summary>��ҵ�ļ�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Taskfile =  new AttributeItem("[Xt_student_task].[Taskfile]", typeof(string), 50, default(string));
            
            /// <summary>��ҵ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Task_result =  new AttributeItem("[Xt_student_task].[Task_result]", typeof(string), 1, default(string));
            
            /// <summary>����״̬:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Approval =  new AttributeItem("[Xt_student_task].[Approval]", typeof(string), 1, default(string));
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Approval_people =  new AttributeItem("[Xt_student_task].[Approval_people]", typeof(string), 50, default(string));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Approval_time =  new AttributeItem("[Xt_student_task].[Approval_time]", typeof(DateTime), 8, default(DateTime));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        
        private string m_submit;
        /// <summary></summary>
        protected bool submit_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        
        private string m_taskfile;
        /// <summary></summary>
        protected bool taskfile_initialized = false;
        
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
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_student_task";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;this.submit_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;this.taskfile_initialized = IsLoadAllAttributes;this.task_result_initialized = IsLoadAllAttributes;this.approval_initialized = IsLoadAllAttributes;this.approval_people_initialized = IsLoadAllAttributes;this.approval_time_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_student_task value = new Xt_student_task();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit"))
				value.submit_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Taskfile"))
				value.taskfile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_result"))
				value.task_result_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval"))
				value.approval_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval_people"))
				value.approval_people_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Approval_time"))
				value.approval_time_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_student_task Clone()
        {
            return (Xt_student_task)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_student_task()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_student_task() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_student_task(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_student_task(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_student_task(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_student_task(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_student_task(Guid uuid1, string task_id1, string submit1, string student_id1, string taskfile1, string task_result1, string approval1, string approval_people1, DateTime approval_time1)
        {
            
            this.Uuid = uuid1;
            
            this.Task_id = task_id1;
            
            this.Submit = submit1;
            
            this.Student_id = student_id1;
            
            this.Taskfile = taskfile1;
            
            this.Task_result = task_result1;
            
            this.Approval = approval1;
            
            this.Approval_people = approval_people1;
            
            this.Approval_time = approval_time1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_student_task FromIView(IView view)
        {
            return (Xt_student_task)IView.GetITable(view, "Xt_student_task");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_student_task GetOneInstance()
        {
            Xt_student_task value = new Xt_student_task();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_student_task Retrieve()
        {
            BLLTable<Xt_student_task>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        return Uuid;
			    			
			    case "Task_id":
			        return Task_id;
			    			
			    case "Submit":
			        return Submit;
			    			
			    case "Student_id":
			        return Student_id;
			    			
			    case "Taskfile":
			        return Taskfile;
			    			
			    case "Task_result":
			        return Task_result;
			    			
			    case "Approval":
			        return Approval;
			    			
			    case "Approval_people":
			        return Approval_people;
			    			
			    case "Approval_time":
			        return Approval_time;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Submit":
			        this.Submit = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Taskfile":
			        this.Taskfile = Convert.ToString(AttributeValue);
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
			
                default:
                    return base.SetValue(AttributeName, AttributeValue);
			}
        }
        
        /// <summary>ͨ������ ��ȡ���ֶ��Ƿ��ѱ���ʼ��</summary>
        public override bool GetInitialized(AttributeItem AttributeName)
        {
			switch(AttributeName.FieldName)
			{	
				case "Uuid":
					return uuid_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
				case "Submit":
					return submit_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
				case "Taskfile":
					return taskfile_initialized;
				
				case "Task_result":
					return task_result_initialized;
				
				case "Approval":
					return approval_initialized;
				
				case "Approval_people":
					return approval_people_initialized;
				
				case "Approval_time":
					return approval_time_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
					return true;
				
				case "Submit":
					submit_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
					return true;
				
				case "Taskfile":
					taskfile_initialized = ret;
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

			
			if (uuid_initialized)
			{
                AttributeItem attr = Xt_student_task.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = Xt_student_task.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
                }
			}
			
			if (submit_initialized)
			{
                AttributeItem attr = Xt_student_task.Attribute.Submit;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xt_student_task.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
                }
			}
			
			if (taskfile_initialized)
			{
                AttributeItem attr = Xt_student_task.Attribute.Taskfile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Taskfile);
                }
			}
			
			if (task_result_initialized)
			{
                AttributeItem attr = Xt_student_task.Attribute.Task_result;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_result);
                }
			}
			
			if (approval_initialized)
			{
                AttributeItem attr = Xt_student_task.Attribute.Approval;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval);
                }
			}
			
			if (approval_people_initialized)
			{
                AttributeItem attr = Xt_student_task.Attribute.Approval_people;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval_people);
                }
			}
			
			if (approval_time_initialized)
			{
                AttributeItem attr = Xt_student_task.Attribute.Approval_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Approval_time);
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
        public class Xt_student_taskJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>��ҵID:[CtrlTypeDic-{InputString}]</summary>
            public string Task_id { get; set; }
            
            /// <summary>�ύʱ��:[CtrlTypeDic-{InputString}]</summary>
            public string Submit { get; set; }
            
            /// <summary>ѧ��ID:[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
            
            /// <summary>��ҵ�ļ�:[CtrlTypeDic-{InputString}]</summary>
            public string Taskfile { get; set; }
            
            /// <summary>��ҵ���:[CtrlTypeDic-{InputString}]</summary>
            public string Task_result { get; set; }
            
            /// <summary>����״̬:[CtrlTypeDic-{InputString}]</summary>
            public string Approval { get; set; }
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public string Approval_people { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Approval_time { get; set; }
        }
        #endregion
    }
}
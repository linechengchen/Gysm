/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:31
  Description:    ���ݱ�Xt_course_task��Ӧ��ҵ���߼���Xt_course_task
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_course_task_Entity:Xt_course_task
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Course_id,Task_id,Creatime,Correcting_finish,Correcting_unfinish,Submit_unfinsh from Xt_course_task
delete from Xt_course_task
INSERT INTO Xt_course_task (Uuid,Course_id,Task_id,Creatime,Correcting_finish,Correcting_unfinish,Submit_unfinsh)
     VALUES
           ('','','','','','','')
UPDATE Xt_course_task SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Course_id = valObj2.Course_id;
        valObj.Task_id = valObj2.Task_id;
        valObj.Creatime = valObj2.Creatime;
        valObj.Correcting_finish = valObj2.Correcting_finish;
        valObj.Correcting_unfinish = valObj2.Correcting_unfinish;
        valObj.Submit_unfinsh = valObj2.Submit_unfinsh; 
        valObj.Uuid = "";
        valObj.Course_id = "";
        valObj.Task_id = "";
        valObj.Creatime = "";
        valObj.Correcting_finish = "";
        valObj.Correcting_unfinish = "";
        valObj.Submit_unfinsh = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Task_id": $("#txt_Task_id").val(),
        "Creatime": $("#txt_Creatime").val(),
        "Correcting_finish": $("#txt_Correcting_finish").val(),
        "Correcting_unfinish": $("#txt_Correcting_unfinish").val(),
        "Submit_unfinsh": $("#txt_Submit_unfinsh").val(), 
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
    /// <para>�γ���ҵ������</para>
    /// <para>��Xt_course_task���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_course_task : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_course_task Factory()
        {
            return new Xt_course_task();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> �γ�id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> ��ҵid:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Creatime
        {            
            get { return this.Creatime; }
            set { this.Creatime = value; }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Correcting_finish
        {            
            get { return this.Correcting_finish; }
            set { this.Correcting_finish = value; }
        }
        
        /// <summary> δ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Correcting_unfinish
        {            
            get { return this.Correcting_unfinish; }
            set { this.Correcting_unfinish = value; }
        }
        
        /// <summary> δ�ύ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Submit_unfinsh
        {            
            get { return this.Submit_unfinsh; }
            set { this.Submit_unfinsh = value; }
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
        
        /// <summary> ��ҵid:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Creatime
        {
            get { return this.m_creatime; }
            set //
            {
                if (!creatime_initialized || m_creatime != value)
                {
                    this.m_creatime = value;
                }
                creatime_initialized = true;
            }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Correcting_finish
        {
            get { return this.m_correcting_finish; }
            set //
            {
                if (!correcting_finish_initialized || m_correcting_finish != value)
                {
                    this.m_correcting_finish = value;
                }
                correcting_finish_initialized = true;
            }
        }
        
        /// <summary> δ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Correcting_unfinish
        {
            get { return this.m_correcting_unfinish; }
            set //
            {
                if (!correcting_unfinish_initialized || m_correcting_unfinish != value)
                {
                    this.m_correcting_unfinish = value;
                }
                correcting_unfinish_initialized = true;
            }
        }
        
        /// <summary> δ�ύ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Submit_unfinsh
        {
            get { return this.m_submit_unfinsh; }
            set //
            {
                if (!submit_unfinsh_initialized || m_submit_unfinsh != value)
                {
                    this.m_submit_unfinsh = value;
                }
                submit_unfinsh_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_course_task].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>�γ�id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_course_task].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>��ҵid:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Task_id =  new AttributeItem("[Xt_course_task].[Task_id]", typeof(string), 36, default(string));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Creatime =  new AttributeItem("[Xt_course_task].[Creatime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Correcting_finish =  new AttributeItem("[Xt_course_task].[Correcting_finish]", typeof(int), 4, default(int));
            
            /// <summary>δ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Correcting_unfinish =  new AttributeItem("[Xt_course_task].[Correcting_unfinish]", typeof(int), 4, default(int));
            
            /// <summary>δ�ύ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Submit_unfinsh =  new AttributeItem("[Xt_course_task].[Submit_unfinsh]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        
        private DateTime m_creatime;
        /// <summary></summary>
        protected bool creatime_initialized = false;
        
        private int m_correcting_finish;
        /// <summary></summary>
        protected bool correcting_finish_initialized = false;
        
        private int m_correcting_unfinish;
        /// <summary></summary>
        protected bool correcting_unfinish_initialized = false;
        
        private int m_submit_unfinsh;
        /// <summary></summary>
        protected bool submit_unfinsh_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_course_task";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;this.creatime_initialized = IsLoadAllAttributes;this.correcting_finish_initialized = IsLoadAllAttributes;this.correcting_unfinish_initialized = IsLoadAllAttributes;this.submit_unfinsh_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_course_task value = new Xt_course_task();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Creatime"))
				value.creatime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Correcting_finish"))
				value.correcting_finish_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Correcting_unfinish"))
				value.correcting_unfinish_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit_unfinsh"))
				value.submit_unfinsh_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_course_task Clone()
        {
            return (Xt_course_task)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_course_task()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_course_task() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_course_task(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_course_task(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_course_task(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_course_task(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_course_task(Guid uuid1, string course_id1, string task_id1, DateTime creatime1, int correcting_finish1, int correcting_unfinish1, int submit_unfinsh1)
        {
            
            this.Uuid = uuid1;
            
            this.Course_id = course_id1;
            
            this.Task_id = task_id1;
            
            this.Creatime = creatime1;
            
            this.Correcting_finish = correcting_finish1;
            
            this.Correcting_unfinish = correcting_unfinish1;
            
            this.Submit_unfinsh = submit_unfinsh1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_course_task FromIView(IView view)
        {
            return (Xt_course_task)IView.GetITable(view, "Xt_course_task");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_course_task GetOneInstance()
        {
            Xt_course_task value = new Xt_course_task();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_course_task Retrieve()
        {
            BLLTable<Xt_course_task>.GetRowData(this);
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
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Task_id":
			        return Task_id;
			    			
			    case "Creatime":
			        return Creatime;
			    			
			    case "Correcting_finish":
			        return Correcting_finish;
			    			
			    case "Correcting_unfinish":
			        return Correcting_unfinish;
			    			
			    case "Submit_unfinsh":
			        return Submit_unfinsh;
			
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
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Creatime":
			        this.Creatime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Correcting_finish":
			        this.Correcting_finish = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Correcting_unfinish":
			        this.Correcting_unfinish = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Submit_unfinsh":
			        this.Submit_unfinsh = Convert.ToInt32(AttributeValue);
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
				
				case "Course_id":
					return course_id_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
				case "Creatime":
					return creatime_initialized;
				
				case "Correcting_finish":
					return correcting_finish_initialized;
				
				case "Correcting_unfinish":
					return correcting_unfinish_initialized;
				
				case "Submit_unfinsh":
					return submit_unfinsh_initialized;
				
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
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
					return true;
				
				case "Creatime":
					creatime_initialized = ret;
					return true;
				
				case "Correcting_finish":
					correcting_finish_initialized = ret;
					return true;
				
				case "Correcting_unfinish":
					correcting_unfinish_initialized = ret;
					return true;
				
				case "Submit_unfinsh":
					submit_unfinsh_initialized = ret;
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
                AttributeItem attr = Xt_course_task.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_course_task.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = Xt_course_task.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
                }
			}
			
			if (creatime_initialized)
			{
                AttributeItem attr = Xt_course_task.Attribute.Creatime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Creatime);
                }
			}
			
			if (correcting_finish_initialized)
			{
                AttributeItem attr = Xt_course_task.Attribute.Correcting_finish;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Correcting_finish);
                }
			}
			
			if (correcting_unfinish_initialized)
			{
                AttributeItem attr = Xt_course_task.Attribute.Correcting_unfinish;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Correcting_unfinish);
                }
			}
			
			if (submit_unfinsh_initialized)
			{
                AttributeItem attr = Xt_course_task.Attribute.Submit_unfinsh;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit_unfinsh);
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
        public class Xt_course_taskJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>�γ�id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>��ҵid:[CtrlTypeDic-{InputString}]</summary>
            public string Task_id { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Creatime { get; set; }
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public int Correcting_finish { get; set; }
            
            /// <summary>δ����:[CtrlTypeDic-{InputString}]</summary>
            public int Correcting_unfinish { get; set; }
            
            /// <summary>δ�ύ:[CtrlTypeDic-{InputString}]</summary>
            public int Submit_unfinsh { get; set; }
        }
        #endregion
    }
}
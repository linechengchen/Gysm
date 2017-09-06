/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:58
  Description:    ���ݱ�V_xt_courseTask��Ӧ��ҵ���߼���V_xt_courseTask
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� V_xt_courseTask_Entity:V_xt_courseTask
 * 
************************************************************/
/************************************************************
SQL���룺
select Title,Create_time,Endtime,Cover,Task_id,Correcting_finish,Correcting_unfinish,Submit_unfinsh,Creatime,Course_id from V_xt_courseTask
delete from V_xt_courseTask
INSERT INTO V_xt_courseTask (Title,Create_time,Endtime,Cover,Task_id,Correcting_finish,Correcting_unfinish,Submit_unfinsh,Creatime,Course_id)
     VALUES
           ('','','','','','','','','','')
UPDATE V_xt_courseTask SET ...
������ֵ���룺
 *         valObj.Title = valObj2.Title;
        valObj.Create_time = valObj2.Create_time;
        valObj.Endtime = valObj2.Endtime;
        valObj.Cover = valObj2.Cover;
        valObj.Task_id = valObj2.Task_id;
        valObj.Correcting_finish = valObj2.Correcting_finish;
        valObj.Correcting_unfinish = valObj2.Correcting_unfinish;
        valObj.Submit_unfinsh = valObj2.Submit_unfinsh;
        valObj.Creatime = valObj2.Creatime;
        valObj.Course_id = valObj2.Course_id; 
        valObj.Title = "";
        valObj.Create_time = "";
        valObj.Endtime = "";
        valObj.Cover = "";
        valObj.Task_id = "";
        valObj.Correcting_finish = "";
        valObj.Correcting_unfinish = "";
        valObj.Submit_unfinsh = "";
        valObj.Creatime = "";
        valObj.Course_id = ""; 
        "Title": $("#txt_Title").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Endtime": $("#txt_Endtime").val(),
        "Cover": $("#txt_Cover").val(),
        "Task_id": $("#txt_Task_id").val(),
        "Correcting_finish": $("#txt_Correcting_finish").val(),
        "Correcting_unfinish": $("#txt_Correcting_unfinish").val(),
        "Submit_unfinsh": $("#txt_Submit_unfinsh").val(),
        "Creatime": $("#txt_Creatime").val(),
        "Course_id": $("#txt_Course_id").val(), 
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
    /// <para>�γ���ҵ������__��ҵ��:[Inner-{Xt_course_task:0},{Xt_task:1}]</para>
    /// <para>��V_xt_courseTask���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class V_xt_courseTask : ITableImplement
    {
        /// <summary>��������  </summary>
        public static V_xt_courseTask Factory()
        {
            return new V_xt_courseTask();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> ��ֹʱ�� Attribute_IsNotNull </summary>
        public DateTime _Endtime
        {            
            get { return this.Endtime; }
            set { this.Endtime = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public string _Cover
        {            
            get { return this.Cover; }
            set { this.Cover = value; }
        }
        
        /// <summary> ��ҵid Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        
        /// <summary> ������ Attribute_IsNotNull </summary>
        public int _Correcting_finish
        {            
            get { return this.Correcting_finish; }
            set { this.Correcting_finish = value; }
        }
        
        /// <summary> δ���� Attribute_IsNotNull </summary>
        public int _Correcting_unfinish
        {            
            get { return this.Correcting_unfinish; }
            set { this.Correcting_unfinish = value; }
        }
        
        /// <summary> δ�ύ Attribute_IsNotNull </summary>
        public int _Submit_unfinsh
        {            
            get { return this.Submit_unfinsh; }
            set { this.Submit_unfinsh = value; }
        }
        
        /// <summary> ����ʱ�� Attribute_IsNotNull </summary>
        public DateTime _Creatime
        {            
            get { return this.Creatime; }
            set { this.Creatime = value; }
        }
        
        /// <summary> �γ�id Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���⣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Title
        {
            get { return this.m_title; }
            set //
            {
                if (!title_initialized || m_title != value)
                {
                    this.m_title = value;
                }
                title_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ֹʱ�䣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Endtime
        {
            get { return this.m_endtime; }
            set //
            {
                if (!endtime_initialized || m_endtime != value)
                {
                    this.m_endtime = value;
                }
                endtime_initialized = true;
            }
        }
        
        /// <summary> ���棬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Cover
        {
            get { return this.m_cover; }
            set //
            {
                if (!cover_initialized || m_cover != value)
                {
                    this.m_cover = value;
                }
                cover_initialized = true;
            }
        }
        
        /// <summary> ��ҵid���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �����ģ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> δ���ģ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> δ�ύ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����ʱ�䣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �γ�id���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>����</summary>
            public static AttributeItem Title =  new AttributeItem("[V_xt_courseTask].[Title]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Create_time =  new AttributeItem("[V_xt_courseTask].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>��ֹʱ��</summary>
            public static AttributeItem Endtime =  new AttributeItem("[V_xt_courseTask].[Endtime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����</summary>
            public static AttributeItem Cover =  new AttributeItem("[V_xt_courseTask].[Cover]", typeof(string), 100, default(string));
            
            /// <summary>��ҵid</summary>
            public static AttributeItem Task_id =  new AttributeItem("[V_xt_courseTask].[Task_id]", typeof(string), 36, default(string));
            
            /// <summary>������</summary>
            public static AttributeItem Correcting_finish =  new AttributeItem("[V_xt_courseTask].[Correcting_finish]", typeof(int), 4, default(int));
            
            /// <summary>δ����</summary>
            public static AttributeItem Correcting_unfinish =  new AttributeItem("[V_xt_courseTask].[Correcting_unfinish]", typeof(int), 4, default(int));
            
            /// <summary>δ�ύ</summary>
            public static AttributeItem Submit_unfinsh =  new AttributeItem("[V_xt_courseTask].[Submit_unfinsh]", typeof(int), 4, default(int));
            
            /// <summary>����ʱ��</summary>
            public static AttributeItem Creatime =  new AttributeItem("[V_xt_courseTask].[Creatime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>�γ�id</summary>
            public static AttributeItem Course_id =  new AttributeItem("[V_xt_courseTask].[Course_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private DateTime m_endtime;
        /// <summary></summary>
        protected bool endtime_initialized = false;
        
        private string m_cover;
        /// <summary></summary>
        protected bool cover_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        
        private int m_correcting_finish;
        /// <summary></summary>
        protected bool correcting_finish_initialized = false;
        
        private int m_correcting_unfinish;
        /// <summary></summary>
        protected bool correcting_unfinish_initialized = false;
        
        private int m_submit_unfinsh;
        /// <summary></summary>
        protected bool submit_unfinsh_initialized = false;
        
        private DateTime m_creatime;
        /// <summary></summary>
        protected bool creatime_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_xt_courseTask";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.title_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.endtime_initialized = IsLoadAllAttributes;this.cover_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;this.correcting_finish_initialized = IsLoadAllAttributes;this.correcting_unfinish_initialized = IsLoadAllAttributes;this.submit_unfinsh_initialized = IsLoadAllAttributes;this.creatime_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_xt_courseTask value = new V_xt_courseTask();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Endtime"))
				value.endtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Cover"))
				value.cover_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Correcting_finish"))
				value.correcting_finish_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Correcting_unfinish"))
				value.correcting_unfinish_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit_unfinsh"))
				value.submit_unfinsh_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Creatime"))
				value.creatime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new V_xt_courseTask Clone()
        {
            return (V_xt_courseTask)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static V_xt_courseTask()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public V_xt_courseTask() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public V_xt_courseTask(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public V_xt_courseTask(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public V_xt_courseTask(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public V_xt_courseTask(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public V_xt_courseTask(string title1, DateTime create_time1, DateTime endtime1, string cover1, string task_id1, int correcting_finish1, int correcting_unfinish1, int submit_unfinsh1, DateTime creatime1, string course_id1)
        {
            
            this.Title = title1;
            
            this.Create_time = create_time1;
            
            this.Endtime = endtime1;
            
            this.Cover = cover1;
            
            this.Task_id = task_id1;
            
            this.Correcting_finish = correcting_finish1;
            
            this.Correcting_unfinish = correcting_unfinish1;
            
            this.Submit_unfinsh = submit_unfinsh1;
            
            this.Creatime = creatime1;
            
            this.Course_id = course_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static V_xt_courseTask FromIView(IView view)
        {
            return (V_xt_courseTask)IView.GetITable(view, "V_xt_courseTask");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static V_xt_courseTask GetOneInstance()
        {
            V_xt_courseTask value = new V_xt_courseTask();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public V_xt_courseTask Retrieve()
        {
            BLLTable<V_xt_courseTask>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Title":
			        return Title;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Endtime":
			        return Endtime;
			    			
			    case "Cover":
			        return Cover;
			    			
			    case "Task_id":
			        return Task_id;
			    			
			    case "Correcting_finish":
			        return Correcting_finish;
			    			
			    case "Correcting_unfinish":
			        return Correcting_unfinish;
			    			
			    case "Submit_unfinsh":
			        return Submit_unfinsh;
			    			
			    case "Creatime":
			        return Creatime;
			    			
			    case "Course_id":
			        return Course_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Endtime":
			        this.Endtime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Cover":
			        this.Cover = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
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
			    			
			    case "Creatime":
			        this.Creatime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
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
				case "Title":
					return title_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Endtime":
					return endtime_initialized;
				
				case "Cover":
					return cover_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
				case "Correcting_finish":
					return correcting_finish_initialized;
				
				case "Correcting_unfinish":
					return correcting_unfinish_initialized;
				
				case "Submit_unfinsh":
					return submit_unfinsh_initialized;
				
				case "Creatime":
					return creatime_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Endtime":
					endtime_initialized = ret;
					return true;
				
				case "Cover":
					cover_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
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
				
				case "Creatime":
					creatime_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
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

			
			if (title_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (endtime_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Endtime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Endtime);
                }
			}
			
			if (cover_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Cover;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Cover);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
                }
			}
			
			if (correcting_finish_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Correcting_finish;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Correcting_finish);
                }
			}
			
			if (correcting_unfinish_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Correcting_unfinish;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Correcting_unfinish);
                }
			}
			
			if (submit_unfinsh_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Submit_unfinsh;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit_unfinsh);
                }
			}
			
			if (creatime_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Creatime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Creatime);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = V_xt_courseTask.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
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
        public class V_xt_courseTaskJson
        {
            
            /// <summary>����</summary>
            public string Title { get; set; }
            
            /// <summary></summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>��ֹʱ��</summary>
            public DateTime Endtime { get; set; }
            
            /// <summary>����</summary>
            public string Cover { get; set; }
            
            /// <summary>��ҵid</summary>
            public string Task_id { get; set; }
            
            /// <summary>������</summary>
            public int Correcting_finish { get; set; }
            
            /// <summary>δ����</summary>
            public int Correcting_unfinish { get; set; }
            
            /// <summary>δ�ύ</summary>
            public int Submit_unfinsh { get; set; }
            
            /// <summary>����ʱ��</summary>
            public DateTime Creatime { get; set; }
            
            /// <summary>�γ�id</summary>
            public string Course_id { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/8/17 16:59:04
  Description:    ���ݱ�Jd_task_detail_jz��Ӧ��ҵ���߼���Jd_task_detail_jz
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jd_task_detail_jz_Entity:Jd_task_detail_jz
 * 
************************************************************/
/************************************************************
SQL���룺
select Task_detail_id,Apply_count,Grade,Introduce,Mobile,Task_id,Work_time from Jd_task_detail_jz
delete from Jd_task_detail_jz
INSERT INTO Jd_task_detail_jz (Task_detail_id,Apply_count,Grade,Introduce,Mobile,Task_id,Work_time)
     VALUES
           ('','','','','','','')
UPDATE Jd_task_detail_jz SET ...
������ֵ���룺
 *         valObj.Task_detail_id = valObj2.Task_detail_id;
        valObj.Apply_count = valObj2.Apply_count;
        valObj.Grade = valObj2.Grade;
        valObj.Introduce = valObj2.Introduce;
        valObj.Mobile = valObj2.Mobile;
        valObj.Task_id = valObj2.Task_id;
        valObj.Work_time = valObj2.Work_time; 
        valObj.Task_detail_id = "";
        valObj.Apply_count = "";
        valObj.Grade = "";
        valObj.Introduce = "";
        valObj.Mobile = "";
        valObj.Task_id = "";
        valObj.Work_time = ""; 
        "Task_detail_id": $("#txt_Task_detail_id").val(),
        "Apply_count": $("#txt_Apply_count").val(),
        "Grade": $("#txt_Grade").val(),
        "Introduce": $("#txt_Introduce").val(),
        "Mobile": $("#txt_Mobile").val(),
        "Task_id": $("#txt_Task_id").val(),
        "Work_time": $("#txt_Work_time").val(), 
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
    /// <para>������ϸ��ְ��</para>
    /// <para>��Jd_task_detail_jz���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jd_task_detail_jz : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jd_task_detail_jz Factory()
        {
            return new Jd_task_detail_jz();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���� Attribute_IsPrimary </summary>
        public Guid _Task_detail_id
        {            
            get { return this.Task_detail_id; }
            set { this.Task_detail_id = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public int _Apply_count
        {            
            get { return this.Apply_count; }
            set { this.Apply_count = value; }
        }
        
        /// <summary> �꼶 Attribute_IsNotNull </summary>
        public string _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public string _Introduce
        {            
            get { return this.Introduce; }
            set { this.Introduce = value; }
        }
        
        /// <summary> �ֻ��� Attribute_IsNotNull </summary>
        public string _Mobile
        {            
            get { return this.Mobile; }
            set { this.Mobile = value; }
        }
        
        /// <summary> ����ID Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        
        /// <summary> ��ְʱ�� Attribute_IsNotNull </summary>
        public string _Work_time
        {            
            get { return this.Work_time; }
            set { this.Work_time = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> �������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid Task_detail_id
        {
            get { return this.m_task_detail_id; }
            set //
            {
                if (!task_detail_id_initialized || m_task_detail_id != value)
                {
                    this.m_task_detail_id = value;
                }
                task_detail_id_initialized = true;
            }
        }
        
        /// <summary> �������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Apply_count
        {
            get { return this.m_apply_count; }
            set //
            {
                if (!apply_count_initialized || m_apply_count != value)
                {
                    this.m_apply_count = value;
                }
                apply_count_initialized = true;
            }
        }
        
        /// <summary> �꼶���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���ܣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �ֻ��ţ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Mobile
        {
            get { return this.m_mobile; }
            set //
            {
                if (!mobile_initialized || m_mobile != value)
                {
                    this.m_mobile = value;
                }
                mobile_initialized = true;
            }
        }
        
        /// <summary> ����ID���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ְʱ�䣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Work_time
        {
            get { return this.m_work_time; }
            set //
            {
                if (!work_time_initialized || m_work_time != value)
                {
                    this.m_work_time = value;
                }
                work_time_initialized = true;
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
            public static AttributeItem Task_detail_id =  new AttributeItem("[Jd_task_detail_jz].[Task_detail_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����</summary>
            public static AttributeItem Apply_count =  new AttributeItem("[Jd_task_detail_jz].[Apply_count]", typeof(int), 4, default(int));
            
            /// <summary>�꼶</summary>
            public static AttributeItem Grade =  new AttributeItem("[Jd_task_detail_jz].[Grade]", typeof(string), 300, default(string));
            
            /// <summary>����</summary>
            public static AttributeItem Introduce =  new AttributeItem("[Jd_task_detail_jz].[Introduce]", typeof(string), 500, default(string));
            
            /// <summary>�ֻ���</summary>
            public static AttributeItem Mobile =  new AttributeItem("[Jd_task_detail_jz].[Mobile]", typeof(string), 300, default(string));
            
            /// <summary>����ID</summary>
            public static AttributeItem Task_id =  new AttributeItem("[Jd_task_detail_jz].[Task_id]", typeof(string), 36, default(string));
            
            /// <summary>��ְʱ��</summary>
            public static AttributeItem Work_time =  new AttributeItem("[Jd_task_detail_jz].[Work_time]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_task_detail_id;
        /// <summary></summary>
        protected bool task_detail_id_initialized = false;
        
        private int m_apply_count;
        /// <summary></summary>
        protected bool apply_count_initialized = false;
        
        private string m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private string m_introduce;
        /// <summary></summary>
        protected bool introduce_initialized = false;
        
        private string m_mobile;
        /// <summary></summary>
        protected bool mobile_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        
        private string m_work_time;
        /// <summary></summary>
        protected bool work_time_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jd_task_detail_jz";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.task_detail_id_initialized = IsLoadAllAttributes;this.apply_count_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.introduce_initialized = IsLoadAllAttributes;this.mobile_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;this.work_time_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jd_task_detail_jz value = new Jd_task_detail_jz();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_detail_id"))
				value.task_detail_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Apply_count"))
				value.apply_count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Introduce"))
				value.introduce_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mobile"))
				value.mobile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Work_time"))
				value.work_time_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jd_task_detail_jz Clone()
        {
            return (Jd_task_detail_jz)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jd_task_detail_jz()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jd_task_detail_jz() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jd_task_detail_jz(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jd_task_detail_jz(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jd_task_detail_jz(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jd_task_detail_jz(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jd_task_detail_jz(Guid task_detail_id1, int apply_count1, string grade1, string introduce1, string mobile1, string task_id1, string work_time1)
        {
            
            this.Task_detail_id = task_detail_id1;
            
            this.Apply_count = apply_count1;
            
            this.Grade = grade1;
            
            this.Introduce = introduce1;
            
            this.Mobile = mobile1;
            
            this.Task_id = task_id1;
            
            this.Work_time = work_time1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jd_task_detail_jz FromIView(IView view)
        {
            return (Jd_task_detail_jz)IView.GetITable(view, "Jd_task_detail_jz");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jd_task_detail_jz GetOneInstance()
        {
            Jd_task_detail_jz value = new Jd_task_detail_jz();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jd_task_detail_jz Retrieve()
        {
            BLLTable<Jd_task_detail_jz>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Task_detail_id":
			        return Task_detail_id;
			    			
			    case "Apply_count":
			        return Apply_count;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Introduce":
			        return Introduce;
			    			
			    case "Mobile":
			        return Mobile;
			    			
			    case "Task_id":
			        return Task_id;
			    			
			    case "Work_time":
			        return Work_time;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Task_detail_id":
			        this.Task_detail_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Apply_count":
			        this.Apply_count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Introduce":
			        this.Introduce = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Mobile":
			        this.Mobile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Work_time":
			        this.Work_time = Convert.ToString(AttributeValue);
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
				case "Task_detail_id":
					return task_detail_id_initialized;
				
				case "Apply_count":
					return apply_count_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Introduce":
					return introduce_initialized;
				
				case "Mobile":
					return mobile_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
				case "Work_time":
					return work_time_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Task_detail_id":
					task_detail_id_initialized = ret;
					return true;
				
				case "Apply_count":
					apply_count_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Introduce":
					introduce_initialized = ret;
					return true;
				
				case "Mobile":
					mobile_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
					return true;
				
				case "Work_time":
					work_time_initialized = ret;
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

			
			if (task_detail_id_initialized)
			{
                AttributeItem attr = Jd_task_detail_jz.Attribute.Task_detail_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_detail_id);
                }
			}
			
			if (apply_count_initialized)
			{
                AttributeItem attr = Jd_task_detail_jz.Attribute.Apply_count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Apply_count);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Jd_task_detail_jz.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (introduce_initialized)
			{
                AttributeItem attr = Jd_task_detail_jz.Attribute.Introduce;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Introduce);
                }
			}
			
			if (mobile_initialized)
			{
                AttributeItem attr = Jd_task_detail_jz.Attribute.Mobile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mobile);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = Jd_task_detail_jz.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
                }
			}
			
			if (work_time_initialized)
			{
                AttributeItem attr = Jd_task_detail_jz.Attribute.Work_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Work_time);
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
        public class Jd_task_detail_jzJson
        {
            
            /// <summary>����</summary>
            public Guid Task_detail_id { get; set; }
            
            /// <summary>����</summary>
            public int Apply_count { get; set; }
            
            /// <summary>�꼶</summary>
            public string Grade { get; set; }
            
            /// <summary>����</summary>
            public string Introduce { get; set; }
            
            /// <summary>�ֻ���</summary>
            public string Mobile { get; set; }
            
            /// <summary>����ID</summary>
            public string Task_id { get; set; }
            
            /// <summary>��ְʱ��</summary>
            public string Work_time { get; set; }
        }
        #endregion
    }
}
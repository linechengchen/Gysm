/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/8/17 17:01:44
  Description:    ���ݱ�Jd_task_detail_jj��Ӧ��ҵ���߼���Jd_task_detail_jj
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jd_task_detail_jj_Entity:Jd_task_detail_jj
 * 
************************************************************/
/************************************************************
SQL���룺
select Task_detail_id,Grade,Introduce,Manydays,Subject,Task_id from Jd_task_detail_jj
delete from Jd_task_detail_jj
INSERT INTO Jd_task_detail_jj (Task_detail_id,Grade,Introduce,Manydays,Subject,Task_id)
     VALUES
           ('','','','','','')
UPDATE Jd_task_detail_jj SET ...
������ֵ���룺
 *         valObj.Task_detail_id = valObj2.Task_detail_id;
        valObj.Grade = valObj2.Grade;
        valObj.Introduce = valObj2.Introduce;
        valObj.Manydays = valObj2.Manydays;
        valObj.Subject = valObj2.Subject;
        valObj.Task_id = valObj2.Task_id; 
        valObj.Task_detail_id = "";
        valObj.Grade = "";
        valObj.Introduce = "";
        valObj.Manydays = "";
        valObj.Subject = "";
        valObj.Task_id = ""; 
        "Task_detail_id": $("#txt_Task_detail_id").val(),
        "Grade": $("#txt_Grade").val(),
        "Introduce": $("#txt_Introduce").val(),
        "Manydays": $("#txt_Manydays").val(),
        "Subject": $("#txt_Subject").val(),
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
    /// <para>������ϸ�ҽ̱�</para>
    /// <para>��Jd_task_detail_jj���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jd_task_detail_jj : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jd_task_detail_jj Factory()
        {
            return new Jd_task_detail_jj();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���� Attribute_IsPrimary </summary>
        public Guid _Task_detail_id
        {            
            get { return this.Task_detail_id; }
            set { this.Task_detail_id = value; }
        }
        
        /// <summary> �꼶(�����,�ֿ��� Attribute_IsNotNull </summary>
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
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public int _Manydays
        {            
            get { return this.Manydays; }
            set { this.Manydays = value; }
        }
        
        /// <summary> ��Ŀ(�����,�ֿ��� Attribute_IsNotNull </summary>
        public string _Subject
        {            
            get { return this.Subject; }
            set { this.Subject = value; }
        }
        
        /// <summary> ����ID Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
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
        
        /// <summary> �꼶(�����,�ֿ������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���죬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Manydays
        {
            get { return this.m_manydays; }
            set //
            {
                if (!manydays_initialized || m_manydays != value)
                {
                    this.m_manydays = value;
                }
                manydays_initialized = true;
            }
        }
        
        /// <summary> ��Ŀ(�����,�ֿ������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Subject
        {
            get { return this.m_subject; }
            set //
            {
                if (!subject_initialized || m_subject != value)
                {
                    this.m_subject = value;
                }
                subject_initialized = true;
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>����</summary>
            public static AttributeItem Task_detail_id =  new AttributeItem("[Jd_task_detail_jj].[Task_detail_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>�꼶(�����,�ֿ���</summary>
            public static AttributeItem Grade =  new AttributeItem("[Jd_task_detail_jj].[Grade]", typeof(string), 300, default(string));
            
            /// <summary>����</summary>
            public static AttributeItem Introduce =  new AttributeItem("[Jd_task_detail_jj].[Introduce]", typeof(string), 500, default(string));
            
            /// <summary>����</summary>
            public static AttributeItem Manydays =  new AttributeItem("[Jd_task_detail_jj].[Manydays]", typeof(int), 4, default(int));
            
            /// <summary>��Ŀ(�����,�ֿ���</summary>
            public static AttributeItem Subject =  new AttributeItem("[Jd_task_detail_jj].[Subject]", typeof(string), 300, default(string));
            
            /// <summary>����ID</summary>
            public static AttributeItem Task_id =  new AttributeItem("[Jd_task_detail_jj].[Task_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_task_detail_id;
        /// <summary></summary>
        protected bool task_detail_id_initialized = false;
        
        private string m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private string m_introduce;
        /// <summary></summary>
        protected bool introduce_initialized = false;
        
        private int m_manydays;
        /// <summary></summary>
        protected bool manydays_initialized = false;
        
        private string m_subject;
        /// <summary></summary>
        protected bool subject_initialized = false;
        
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
            return "Jd_task_detail_jj";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.task_detail_id_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.introduce_initialized = IsLoadAllAttributes;this.manydays_initialized = IsLoadAllAttributes;this.subject_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jd_task_detail_jj value = new Jd_task_detail_jj();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_detail_id"))
				value.task_detail_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Introduce"))
				value.introduce_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Manydays"))
				value.manydays_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Subject"))
				value.subject_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jd_task_detail_jj Clone()
        {
            return (Jd_task_detail_jj)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jd_task_detail_jj()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jd_task_detail_jj() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jd_task_detail_jj(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jd_task_detail_jj(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jd_task_detail_jj(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jd_task_detail_jj(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jd_task_detail_jj(Guid task_detail_id1, string grade1, string introduce1, int manydays1, string subject1, string task_id1)
        {
            
            this.Task_detail_id = task_detail_id1;
            
            this.Grade = grade1;
            
            this.Introduce = introduce1;
            
            this.Manydays = manydays1;
            
            this.Subject = subject1;
            
            this.Task_id = task_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jd_task_detail_jj FromIView(IView view)
        {
            return (Jd_task_detail_jj)IView.GetITable(view, "Jd_task_detail_jj");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jd_task_detail_jj GetOneInstance()
        {
            Jd_task_detail_jj value = new Jd_task_detail_jj();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jd_task_detail_jj Retrieve()
        {
            BLLTable<Jd_task_detail_jj>.GetRowData(this);
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
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Introduce":
			        return Introduce;
			    			
			    case "Manydays":
			        return Manydays;
			    			
			    case "Subject":
			        return Subject;
			    			
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
			    case "Task_detail_id":
			        this.Task_detail_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Introduce":
			        this.Introduce = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Manydays":
			        this.Manydays = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Subject":
			        this.Subject = Convert.ToString(AttributeValue);
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
				case "Task_detail_id":
					return task_detail_id_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Introduce":
					return introduce_initialized;
				
				case "Manydays":
					return manydays_initialized;
				
				case "Subject":
					return subject_initialized;
				
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
				case "Task_detail_id":
					task_detail_id_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Introduce":
					introduce_initialized = ret;
					return true;
				
				case "Manydays":
					manydays_initialized = ret;
					return true;
				
				case "Subject":
					subject_initialized = ret;
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

			
			if (task_detail_id_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Task_detail_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_detail_id);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (introduce_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Introduce;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Introduce);
                }
			}
			
			if (manydays_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Manydays;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Manydays);
                }
			}
			
			if (subject_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Subject;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Subject);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Task_id;
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
        public class Jd_task_detail_jjJson
        {
            
            /// <summary>����</summary>
            public Guid Task_detail_id { get; set; }
            
            /// <summary>�꼶(�����,�ֿ���</summary>
            public string Grade { get; set; }
            
            /// <summary>����</summary>
            public string Introduce { get; set; }
            
            /// <summary>����</summary>
            public int Manydays { get; set; }
            
            /// <summary>��Ŀ(�����,�ֿ���</summary>
            public string Subject { get; set; }
            
            /// <summary>����ID</summary>
            public string Task_id { get; set; }
        }
        #endregion
    }
}
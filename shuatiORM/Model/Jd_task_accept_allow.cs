/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/8/15 23:04:43
  Description:    ���ݱ�Jd_task_accept_allow��Ӧ��ҵ���߼���Jd_task_accept_allow
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jd_task_accept_allow_Entity:Jd_task_accept_allow
 * 
************************************************************/
/************************************************************
SQL���룺
select Accept_allow_id,State,Task_id,Update_time,User_id from Jd_task_accept_allow
delete from Jd_task_accept_allow
INSERT INTO Jd_task_accept_allow (Accept_allow_id,State,Task_id,Update_time,User_id)
     VALUES
           ('','','','','')
UPDATE Jd_task_accept_allow SET ...
������ֵ���룺
 *         valObj.Accept_allow_id = valObj2.Accept_allow_id;
        valObj.State = valObj2.State;
        valObj.Task_id = valObj2.Task_id;
        valObj.Update_time = valObj2.Update_time;
        valObj.User_id = valObj2.User_id; 
        valObj.Accept_allow_id = "";
        valObj.State = "";
        valObj.Task_id = "";
        valObj.Update_time = "";
        valObj.User_id = ""; 
        "Accept_allow_id": $("#txt_Accept_allow_id").val(),
        "State": $("#txt_State").val(),
        "Task_id": $("#txt_Task_id").val(),
        "Update_time": $("#txt_Update_time").val(),
        "User_id": $("#txt_User_id").val(), 
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
    /// <para>��������ӵ���</para>
    /// <para>��Jd_task_accept_allow���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jd_task_accept_allow : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jd_task_accept_allow Factory()
        {
            return new Jd_task_accept_allow();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���� Attribute_IsPrimary </summary>
        public Guid _Accept_allow_id
        {            
            get { return this.Accept_allow_id; }
            set { this.Accept_allow_id = value; }
        }
        
        /// <summary> ״̬:[Enum-{0:��Ч},{1:��Ч}] Attribute_IsNotNull </summary>
        public string _State
        {            
            get { return this.State; }
            set { this.State = value; }
        }
        
        /// <summary> ����ID Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        
        /// <summary> ����ʱ�� Attribute_IsNotNull </summary>
        public DateTime _Update_time
        {            
            get { return this.Update_time; }
            set { this.Update_time = value; }
        }
        
        /// <summary> ����ӵ����û�ID Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> �������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid Accept_allow_id
        {
            get { return this.m_accept_allow_id; }
            set //
            {
                if (!accept_allow_id_initialized || m_accept_allow_id != value)
                {
                    this.m_accept_allow_id = value;
                }
                accept_allow_id_initialized = true;
            }
        }
        
        /// <summary> ״̬:[Enum-{0:��Ч},{1:��Ч}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string State
        {
            get { return this.m_state; }
            set //
            {
                if (!state_initialized || m_state != value)
                {
                    this.m_state = value;
                }
                state_initialized = true;
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
        
        /// <summary> ����ʱ�䣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Update_time
        {
            get { return this.m_update_time; }
            set //
            {
                if (!update_time_initialized || m_update_time != value)
                {
                    this.m_update_time = value;
                }
                update_time_initialized = true;
            }
        }
        
        /// <summary> ����ӵ����û�ID���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string User_id
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>����</summary>
            public static AttributeItem Accept_allow_id =  new AttributeItem("[Jd_task_accept_allow].[Accept_allow_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>״̬:[Enum-{0:��Ч},{1:��Ч}]</summary>
            public static AttributeItem State =  new AttributeItem("[Jd_task_accept_allow].[State]", typeof(string), 10, default(string));
            
            /// <summary>����ID</summary>
            public static AttributeItem Task_id =  new AttributeItem("[Jd_task_accept_allow].[Task_id]", typeof(string), 36, default(string));
            
            /// <summary>����ʱ��</summary>
            public static AttributeItem Update_time =  new AttributeItem("[Jd_task_accept_allow].[Update_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����ӵ����û�ID</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jd_task_accept_allow].[User_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_accept_allow_id;
        /// <summary></summary>
        protected bool accept_allow_id_initialized = false;
        
        private string m_state;
        /// <summary></summary>
        protected bool state_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        
        private DateTime m_update_time;
        /// <summary></summary>
        protected bool update_time_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jd_task_accept_allow";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.accept_allow_id_initialized = IsLoadAllAttributes;this.state_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;this.update_time_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jd_task_accept_allow value = new Jd_task_accept_allow();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Accept_allow_id"))
				value.accept_allow_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"State"))
				value.state_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Update_time"))
				value.update_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jd_task_accept_allow Clone()
        {
            return (Jd_task_accept_allow)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jd_task_accept_allow()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jd_task_accept_allow() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jd_task_accept_allow(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jd_task_accept_allow(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jd_task_accept_allow(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jd_task_accept_allow(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jd_task_accept_allow(Guid accept_allow_id1, string state1, string task_id1, DateTime update_time1, string user_id1)
        {
            
            this.Accept_allow_id = accept_allow_id1;
            
            this.State = state1;
            
            this.Task_id = task_id1;
            
            this.Update_time = update_time1;
            
            this.User_id = user_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jd_task_accept_allow FromIView(IView view)
        {
            return (Jd_task_accept_allow)IView.GetITable(view, "Jd_task_accept_allow");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jd_task_accept_allow GetOneInstance()
        {
            Jd_task_accept_allow value = new Jd_task_accept_allow();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jd_task_accept_allow Retrieve()
        {
            BLLTable<Jd_task_accept_allow>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Accept_allow_id":
			        return Accept_allow_id;
			    			
			    case "State":
			        return State;
			    			
			    case "Task_id":
			        return Task_id;
			    			
			    case "Update_time":
			        return Update_time;
			    			
			    case "User_id":
			        return User_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Accept_allow_id":
			        this.Accept_allow_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "State":
			        this.State = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Update_time":
			        this.Update_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
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
				case "Accept_allow_id":
					return accept_allow_id_initialized;
				
				case "State":
					return state_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
				case "Update_time":
					return update_time_initialized;
				
				case "User_id":
					return user_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Accept_allow_id":
					accept_allow_id_initialized = ret;
					return true;
				
				case "State":
					state_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
					return true;
				
				case "Update_time":
					update_time_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
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

			
			if (accept_allow_id_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.Accept_allow_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Accept_allow_id);
                }
			}
			
			if (state_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.State;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(State);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
                }
			}
			
			if (update_time_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.Update_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Update_time);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
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
        public class Jd_task_accept_allowJson
        {
            
            /// <summary>����</summary>
            public Guid Accept_allow_id { get; set; }
            
            /// <summary>״̬:[Enum-{0:��Ч},{1:��Ч}]</summary>
            public string State { get; set; }
            
            /// <summary>����ID</summary>
            public string Task_id { get; set; }
            
            /// <summary>����ʱ��</summary>
            public DateTime Update_time { get; set; }
            
            /// <summary>����ӵ����û�ID</summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}
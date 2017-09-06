/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    ���ݱ�Tapply��Ӧ��ҵ���߼���Tapply
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Tapply_Entity:Tapply
 * 
************************************************************/
/************************************************************
SQL���룺
select Timestamp,Status,Exception,Message,Path from Tapply
delete from Tapply
INSERT INTO Tapply (Timestamp,Status,Exception,Message,Path)
     VALUES
           ('','','','','')
UPDATE Tapply SET ...
������ֵ���룺
 *         valObj.Timestamp = valObj2.Timestamp;
        valObj.Status = valObj2.Status;
        valObj.Exception = valObj2.Exception;
        valObj.Message = valObj2.Message;
        valObj.Path = valObj2.Path; 
        valObj.Timestamp = "";
        valObj.Status = "";
        valObj.Exception = "";
        valObj.Message = "";
        valObj.Path = ""; 
        "Timestamp": $("#txt_Timestamp").val(),
        "Status": $("#txt_Status").val(),
        "Exception": $("#txt_Exception").val(),
        "Message": $("#txt_Message").val(),
        "Path": $("#txt_Path").val(), 
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
    /// <para>����</para>
    /// <para>��Tapply���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Tapply : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Tapply Factory()
        {
            return new Tapply();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Timestamp
        {            
            get { return this.Timestamp; }
            set { this.Timestamp = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Exception
        {            
            get { return this.Exception; }
            set { this.Exception = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Message
        {            
            get { return this.Message; }
            set { this.Message = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Timestamp
        {
            get { return this.m_timestamp; }
            set //
            {
                if (!timestamp_initialized || m_timestamp != value)
                {
                    this.m_timestamp = value;
                }
                timestamp_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Status
        {
            get { return this.m_status; }
            set //
            {
                if (!status_initialized || m_status != value)
                {
                    this.m_status = value;
                }
                status_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Exception
        {
            get { return this.m_exception; }
            set //
            {
                if (!exception_initialized || m_exception != value)
                {
                    this.m_exception = value;
                }
                exception_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Message
        {
            get { return this.m_message; }
            set //
            {
                if (!message_initialized || m_message != value)
                {
                    this.m_message = value;
                }
                message_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Path
        {
            get { return this.m_path; }
            set //
            {
                if (!path_initialized || m_path != value)
                {
                    this.m_path = value;
                }
                path_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Timestamp =  new AttributeItem("[Tapply].[Timestamp]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Tapply].[Status]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Exception =  new AttributeItem("[Tapply].[Exception]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Message =  new AttributeItem("[Tapply].[Message]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Tapply].[Path]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_timestamp;
        /// <summary></summary>
        protected bool timestamp_initialized = false;
        
        private string m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_exception;
        /// <summary></summary>
        protected bool exception_initialized = false;
        
        private string m_message;
        /// <summary></summary>
        protected bool message_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Tapply";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.timestamp_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.exception_initialized = IsLoadAllAttributes;this.message_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Tapply value = new Tapply();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Timestamp"))
				value.timestamp_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Exception"))
				value.exception_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Message"))
				value.message_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Tapply Clone()
        {
            return (Tapply)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Tapply()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Tapply() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Tapply(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Tapply(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Tapply(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Tapply(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Tapply(string timestamp1, string status1, string exception1, string message1, string path1)
        {
            
            this.Timestamp = timestamp1;
            
            this.Status = status1;
            
            this.Exception = exception1;
            
            this.Message = message1;
            
            this.Path = path1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Tapply FromIView(IView view)
        {
            return (Tapply)IView.GetITable(view, "Tapply");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Tapply GetOneInstance()
        {
            Tapply value = new Tapply();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Tapply Retrieve()
        {
            BLLTable<Tapply>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Timestamp":
			        return Timestamp;
			    			
			    case "Status":
			        return Status;
			    			
			    case "Exception":
			        return Exception;
			    			
			    case "Message":
			        return Message;
			    			
			    case "Path":
			        return Path;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Timestamp":
			        this.Timestamp = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Exception":
			        this.Exception = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Message":
			        this.Message = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
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
				case "Timestamp":
					return timestamp_initialized;
				
				case "Status":
					return status_initialized;
				
				case "Exception":
					return exception_initialized;
				
				case "Message":
					return message_initialized;
				
				case "Path":
					return path_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Timestamp":
					timestamp_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "Exception":
					exception_initialized = ret;
					return true;
				
				case "Message":
					message_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
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

			
			if (timestamp_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Timestamp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Timestamp);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (exception_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Exception;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Exception);
                }
			}
			
			if (message_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Message;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Message);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Tapply.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
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
        public class TapplyJson
        {
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Timestamp { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Status { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Exception { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Message { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Path { get; set; }
        }
        #endregion
    }
}
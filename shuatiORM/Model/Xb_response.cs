/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:22
  Description:    ���ݱ�Xb_response��Ӧ��ҵ���߼���Xb_response
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_response_Entity:Xb_response
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,CreateTime,Error_code,Error_message,Hint_message,ModifyTime,User_id,Uuid from Xb_response
delete from Xb_response
INSERT INTO Xb_response (Id,CreateTime,Error_code,Error_message,Hint_message,ModifyTime,User_id,Uuid)
     VALUES
           ('','','','','','','','')
UPDATE Xb_response SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Error_code = valObj2.Error_code;
        valObj.Error_message = valObj2.Error_message;
        valObj.Hint_message = valObj2.Hint_message;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.CreateTime = "";
        valObj.Error_code = "";
        valObj.Error_message = "";
        valObj.Hint_message = "";
        valObj.ModifyTime = "";
        valObj.User_id = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Error_code": $("#txt_Error_code").val(),
        "Error_message": $("#txt_Error_message").val(),
        "Hint_message": $("#txt_Hint_message").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
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
    /// <para>��Xb_response���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_response : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_response Factory()
        {
            return new Xb_response();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Error_code
        {            
            get { return this.Error_code; }
            set { this.Error_code = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Error_message
        {            
            get { return this.Error_message; }
            set { this.Error_message = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Hint_message
        {            
            get { return this.Hint_message; }
            set { this.Hint_message = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
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
        public int Error_code
        {
            get { return this.m_error_code; }
            set //
            {
                if (!error_code_initialized || m_error_code != value)
                {
                    this.m_error_code = value;
                }
                error_code_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Error_message
        {
            get { return this.m_error_message; }
            set //
            {
                if (!error_message_initialized || m_error_message != value)
                {
                    this.m_error_message = value;
                }
                error_message_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Hint_message
        {
            get { return this.m_hint_message; }
            set //
            {
                if (!hint_message_initialized || m_hint_message != value)
                {
                    this.m_hint_message = value;
                }
                hint_message_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_response].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_response].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Error_code =  new AttributeItem("[Xb_response].[Error_code]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Error_message =  new AttributeItem("[Xb_response].[Error_message]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Hint_message =  new AttributeItem("[Xb_response].[Hint_message]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_response].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_response].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_response].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_error_code;
        /// <summary></summary>
        protected bool error_code_initialized = false;
        
        private string m_error_message;
        /// <summary></summary>
        protected bool error_message_initialized = false;
        
        private string m_hint_message;
        /// <summary></summary>
        protected bool hint_message_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
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
            return "Xb_response";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.error_code_initialized = IsLoadAllAttributes;this.error_message_initialized = IsLoadAllAttributes;this.hint_message_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_response value = new Xb_response();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Error_code"))
				value.error_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Error_message"))
				value.error_message_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Hint_message"))
				value.hint_message_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_response Clone()
        {
            return (Xb_response)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_response()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_response() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_response(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_response(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_response(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_response(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_response(int id1, DateTime createtime1, int error_code1, string error_message1, string hint_message1, DateTime modifytime1, Guid user_id1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.CreateTime = createtime1;
            
            this.Error_code = error_code1;
            
            this.Error_message = error_message1;
            
            this.Hint_message = hint_message1;
            
            this.ModifyTime = modifytime1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_response FromIView(IView view)
        {
            return (Xb_response)IView.GetITable(view, "Xb_response");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_response GetOneInstance()
        {
            Xb_response value = new Xb_response();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_response Retrieve()
        {
            BLLTable<Xb_response>.GetRowData(this);
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
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Error_code":
			        return Error_code;
			    			
			    case "Error_message":
			        return Error_message;
			    			
			    case "Hint_message":
			        return Hint_message;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
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
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Error_code":
			        this.Error_code = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Error_message":
			        this.Error_message = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Hint_message":
			        this.Hint_message = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
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
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Error_code":
					return error_code_initialized;
				
				case "Error_message":
					return error_message_initialized;
				
				case "Hint_message":
					return hint_message_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
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
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Error_code":
					error_code_initialized = ret;
					return true;
				
				case "Error_message":
					error_message_initialized = ret;
					return true;
				
				case "Hint_message":
					hint_message_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
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
                AttributeItem attr = Xb_response.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_response.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (error_code_initialized)
			{
                AttributeItem attr = Xb_response.Attribute.Error_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Error_code);
                }
			}
			
			if (error_message_initialized)
			{
                AttributeItem attr = Xb_response.Attribute.Error_message;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Error_message);
                }
			}
			
			if (hint_message_initialized)
			{
                AttributeItem attr = Xb_response.Attribute.Hint_message;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Hint_message);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_response.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_response.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_response.Attribute.Uuid;
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
        public class Xb_responseJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Error_code { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Error_message { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Hint_message { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
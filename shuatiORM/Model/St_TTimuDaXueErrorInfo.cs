/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:39
  Description:    ���ݱ�St_TTimuDaXueErrorInfo��Ӧ��ҵ���߼���St_TTimuDaXueErrorInfo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� St_TTimuDaXueErrorInfo_Entity:St_TTimuDaXueErrorInfo
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,AnswerSum,CreateTime,ErrJson,ErrorSum,KemuId,OpenId,TimuIds,User_id from St_TTimuDaXueErrorInfo
delete from St_TTimuDaXueErrorInfo
INSERT INTO St_TTimuDaXueErrorInfo (Id,AnswerSum,CreateTime,ErrJson,ErrorSum,KemuId,OpenId,TimuIds,User_id)
     VALUES
           ('','','','','','','','','')
UPDATE St_TTimuDaXueErrorInfo SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.AnswerSum = valObj2.AnswerSum;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ErrJson = valObj2.ErrJson;
        valObj.ErrorSum = valObj2.ErrorSum;
        valObj.KemuId = valObj2.KemuId;
        valObj.OpenId = valObj2.OpenId;
        valObj.TimuIds = valObj2.TimuIds;
        valObj.User_id = valObj2.User_id; 
        valObj.Id = "";
        valObj.AnswerSum = "";
        valObj.CreateTime = "";
        valObj.ErrJson = "";
        valObj.ErrorSum = "";
        valObj.KemuId = "";
        valObj.OpenId = "";
        valObj.TimuIds = "";
        valObj.User_id = ""; 
        "Id": $("#txt_Id").val(),
        "AnswerSum": $("#txt_AnswerSum").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "ErrJson": $("#txt_ErrJson").val(),
        "ErrorSum": $("#txt_ErrorSum").val(),
        "KemuId": $("#txt_KemuId").val(),
        "OpenId": $("#txt_OpenId").val(),
        "TimuIds": $("#txt_TimuIds").val(),
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
    /// <para>[IDField-{Id:0}]</para>
    /// <para>��St_TTimuDaXueErrorInfo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class St_TTimuDaXueErrorInfo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static St_TTimuDaXueErrorInfo Factory()
        {
            return new St_TTimuDaXueErrorInfo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _AnswerSum
        {            
            get { return this.AnswerSum; }
            set { this.AnswerSum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ErrJson
        {            
            get { return this.ErrJson; }
            set { this.ErrJson = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ErrorSum
        {            
            get { return this.ErrorSum; }
            set { this.ErrorSum = value; }
        }
        
        /// <summary> ��ĿId:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> ��Ŀ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TimuIds
        {            
            get { return this.TimuIds; }
            set { this.TimuIds = value; }
        }
        
        /// <summary> �û����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
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
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int AnswerSum
        {
            get { return this.m_answersum; }
            set //
            {
                if (!answersum_initialized || m_answersum != value)
                {
                    this.m_answersum = value;
                }
                answersum_initialized = true;
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
        public string ErrJson
        {
            get { return this.m_errjson; }
            set //
            {
                if (!errjson_initialized || m_errjson != value)
                {
                    this.m_errjson = value;
                }
                errjson_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ErrorSum
        {
            get { return this.m_errorsum; }
            set //
            {
                if (!errorsum_initialized || m_errorsum != value)
                {
                    this.m_errorsum = value;
                }
                errorsum_initialized = true;
            }
        }
        
        /// <summary> ��ĿId:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string KemuId
        {
            get { return this.m_kemuid; }
            set //
            {
                if (!kemuid_initialized || m_kemuid != value)
                {
                    this.m_kemuid = value;
                }
                kemuid_initialized = true;
            }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string OpenId
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> ��Ŀ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TimuIds
        {
            get { return this.m_timuids; }
            set //
            {
                if (!timuids_initialized || m_timuids != value)
                {
                    this.m_timuids = value;
                }
                timuids_initialized = true;
            }
        }
        
        /// <summary> �û����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_TTimuDaXueErrorInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AnswerSum =  new AttributeItem("[St_TTimuDaXueErrorInfo].[AnswerSum]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[St_TTimuDaXueErrorInfo].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ErrJson =  new AttributeItem("[St_TTimuDaXueErrorInfo].[ErrJson]", typeof(string), -1, default(string));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ErrorSum =  new AttributeItem("[St_TTimuDaXueErrorInfo].[ErrorSum]", typeof(int), 4, default(int));
            
            /// <summary>��ĿId:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[St_TTimuDaXueErrorInfo].[KemuId]", typeof(string), 50, default(string));
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[St_TTimuDaXueErrorInfo].[OpenId]", typeof(string), 50, default(string));
            
            /// <summary>��Ŀ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TimuIds =  new AttributeItem("[St_TTimuDaXueErrorInfo].[TimuIds]", typeof(string), 500, default(string));
            
            /// <summary>�û����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[St_TTimuDaXueErrorInfo].[User_id]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_answersum;
        /// <summary></summary>
        protected bool answersum_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_errjson;
        /// <summary></summary>
        protected bool errjson_initialized = false;
        
        private int m_errorsum;
        /// <summary></summary>
        protected bool errorsum_initialized = false;
        
        private string m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_timuids;
        /// <summary></summary>
        protected bool timuids_initialized = false;
        
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
            return "St_TTimuDaXueErrorInfo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.answersum_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.errjson_initialized = IsLoadAllAttributes;this.errorsum_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.timuids_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TTimuDaXueErrorInfo value = new St_TTimuDaXueErrorInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AnswerSum"))
				value.answersum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ErrJson"))
				value.errjson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ErrorSum"))
				value.errorsum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TimuIds"))
				value.timuids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new St_TTimuDaXueErrorInfo Clone()
        {
            return (St_TTimuDaXueErrorInfo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static St_TTimuDaXueErrorInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public St_TTimuDaXueErrorInfo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public St_TTimuDaXueErrorInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public St_TTimuDaXueErrorInfo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public St_TTimuDaXueErrorInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public St_TTimuDaXueErrorInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public St_TTimuDaXueErrorInfo(int id1, int answersum1, DateTime createtime1, string errjson1, int errorsum1, string kemuid1, string openid1, string timuids1, string user_id1)
        {
            
            this.Id = id1;
            
            this.AnswerSum = answersum1;
            
            this.CreateTime = createtime1;
            
            this.ErrJson = errjson1;
            
            this.ErrorSum = errorsum1;
            
            this.KemuId = kemuid1;
            
            this.OpenId = openid1;
            
            this.TimuIds = timuids1;
            
            this.User_id = user_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static St_TTimuDaXueErrorInfo FromIView(IView view)
        {
            return (St_TTimuDaXueErrorInfo)IView.GetITable(view, "St_TTimuDaXueErrorInfo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static St_TTimuDaXueErrorInfo GetOneInstance()
        {
            St_TTimuDaXueErrorInfo value = new St_TTimuDaXueErrorInfo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public St_TTimuDaXueErrorInfo Retrieve()
        {
            BLLTable<St_TTimuDaXueErrorInfo>.GetRowData(this);
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
			    			
			    case "AnswerSum":
			        return AnswerSum;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "ErrJson":
			        return ErrJson;
			    			
			    case "ErrorSum":
			        return ErrorSum;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "TimuIds":
			        return TimuIds;
			    			
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
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AnswerSum":
			        this.AnswerSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "ErrJson":
			        this.ErrJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ErrorSum":
			        this.ErrorSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TimuIds":
			        this.TimuIds = Convert.ToString(AttributeValue);
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
				case "Id":
					return id_initialized;
				
				case "AnswerSum":
					return answersum_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "ErrJson":
					return errjson_initialized;
				
				case "ErrorSum":
					return errorsum_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "TimuIds":
					return timuids_initialized;
				
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
				case "Id":
					id_initialized = ret;
					return true;
				
				case "AnswerSum":
					answersum_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "ErrJson":
					errjson_initialized = ret;
					return true;
				
				case "ErrorSum":
					errorsum_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "TimuIds":
					timuids_initialized = ret;
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

			
			if (id_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (answersum_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfo.Attribute.AnswerSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AnswerSum);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfo.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (errjson_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfo.Attribute.ErrJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ErrJson);
                }
			}
			
			if (errorsum_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfo.Attribute.ErrorSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ErrorSum);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfo.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfo.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (timuids_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfo.Attribute.TimuIds;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TimuIds);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = St_TTimuDaXueErrorInfo.Attribute.User_id;
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
        public class St_TTimuDaXueErrorInfoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public int AnswerSum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ErrJson { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public int ErrorSum { get; set; }
            
            /// <summary>��ĿId:[CtrlTypeDic-{InputString}]</summary>
            public string KemuId { get; set; }
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>��Ŀ���:[CtrlTypeDic-{InputString}]</summary>
            public string TimuIds { get; set; }
            
            /// <summary>�û����:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}
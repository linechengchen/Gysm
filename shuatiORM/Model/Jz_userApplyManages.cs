/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:21
  Description:    ���ݱ�Jz_userApplyManages��Ӧ��ҵ���߼���Jz_userApplyManages
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jz_userApplyManages_Entity:Jz_userApplyManages
 * 
************************************************************/
/************************************************************
SQL���룺
select PartJobApplyId,BusinessType,PartJobUuid,CreateTime,Status,SecondStatus,User_id from Jz_userApplyManages
delete from Jz_userApplyManages
INSERT INTO Jz_userApplyManages (PartJobApplyId,BusinessType,PartJobUuid,CreateTime,Status,SecondStatus,User_id)
     VALUES
           ('','','','','','','')
UPDATE Jz_userApplyManages SET ...
������ֵ���룺
 *         valObj.PartJobApplyId = valObj2.PartJobApplyId;
        valObj.BusinessType = valObj2.BusinessType;
        valObj.PartJobUuid = valObj2.PartJobUuid;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Status = valObj2.Status;
        valObj.SecondStatus = valObj2.SecondStatus;
        valObj.User_id = valObj2.User_id; 
        valObj.PartJobApplyId = "";
        valObj.BusinessType = "";
        valObj.PartJobUuid = "";
        valObj.CreateTime = "";
        valObj.Status = "";
        valObj.SecondStatus = "";
        valObj.User_id = ""; 
        "PartJobApplyId": $("#txt_PartJobApplyId").val(),
        "BusinessType": $("#txt_BusinessType").val(),
        "PartJobUuid": $("#txt_PartJobUuid").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Status": $("#txt_Status").val(),
        "SecondStatus": $("#txt_SecondStatus").val(),
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
    /// <para>�û����������</para>
    /// <para>��Jz_userApplyManages���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jz_userApplyManages : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jz_userApplyManages Factory()
        {
            return new Jz_userApplyManages();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _PartJobApplyId
        {            
            get { return this.PartJobApplyId; }
            set { this.PartJobApplyId = value; }
        }
        
        /// <summary> ��λ����:[Enum-{PRACTICE:ʵϰ},{PART_JOB:��ְ}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _BusinessType
        {            
            get { return this.BusinessType; }
            set { this.BusinessType = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _PartJobUuid
        {            
            get { return this.PartJobUuid; }
            set { this.PartJobUuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> ״̬:[Enum-{TO_ACCEPT:�����ɹ�����ȴ��̼�¼ȡ},{CANCEL:��ȡ������},{REMIND_COMPANY:�������̼�¼ȡ�������ĵȴ�},{REFUSE_ADMIT:���̼�ȡ��¼ȡ}][CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SecondStatus
        {            
            get { return this.SecondStatus; }
            set { this.SecondStatus = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int PartJobApplyId
        {
            get { return this.m_partjobapplyid; }
            set //private 
            {
                if (!partjobapplyid_initialized || m_partjobapplyid != value)
                {
                    this.m_partjobapplyid = value;
                }
                partjobapplyid_initialized = true;
            }
        }
        
        /// <summary> ��λ����:[Enum-{PRACTICE:ʵϰ},{PART_JOB:��ְ}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string BusinessType
        {
            get { return this.m_businesstype; }
            set //
            {
                if (!businesstype_initialized || m_businesstype != value)
                {
                    this.m_businesstype = value;
                }
                businesstype_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid PartJobUuid
        {
            get { return this.m_partjobuuid; }
            set //
            {
                if (!partjobuuid_initialized || m_partjobuuid != value)
                {
                    this.m_partjobuuid = value;
                }
                partjobuuid_initialized = true;
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
        
        /// <summary> ״̬:[Enum-{TO_ACCEPT:�����ɹ�����ȴ��̼�¼ȡ},{CANCEL:��ȡ������},{REMIND_COMPANY:�������̼�¼ȡ�������ĵȴ�},{REFUSE_ADMIT:���̼�ȡ��¼ȡ}][CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SecondStatus
        {
            get { return this.m_secondstatus; }
            set //
            {
                if (!secondstatus_initialized || m_secondstatus != value)
                {
                    this.m_secondstatus = value;
                }
                secondstatus_initialized = true;
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobApplyId =  new AttributeItem("[Jz_userApplyManages].[PartJobApplyId]", typeof(int), 4, default(int));
            
            /// <summary>��λ����:[Enum-{PRACTICE:ʵϰ},{PART_JOB:��ְ}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem BusinessType =  new AttributeItem("[Jz_userApplyManages].[BusinessType]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobUuid =  new AttributeItem("[Jz_userApplyManages].[PartJobUuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jz_userApplyManages].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>״̬:[Enum-{TO_ACCEPT:�����ɹ�����ȴ��̼�¼ȡ},{CANCEL:��ȡ������},{REMIND_COMPANY:�������̼�¼ȡ�������ĵȴ�},{REFUSE_ADMIT:���̼�ȡ��¼ȡ}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Jz_userApplyManages].[Status]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SecondStatus =  new AttributeItem("[Jz_userApplyManages].[SecondStatus]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jz_userApplyManages].[User_id]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_partjobapplyid;
        /// <summary></summary>
        protected bool partjobapplyid_initialized = false;
        
        private string m_businesstype;
        /// <summary></summary>
        protected bool businesstype_initialized = false;
        
        private Guid m_partjobuuid;
        /// <summary></summary>
        protected bool partjobuuid_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_secondstatus;
        /// <summary></summary>
        protected bool secondstatus_initialized = false;
        
        private Guid m_user_id;
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
            return "Jz_userApplyManages";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.partjobapplyid_initialized = IsLoadAllAttributes;this.businesstype_initialized = IsLoadAllAttributes;this.partjobuuid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.secondstatus_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_userApplyManages value = new Jz_userApplyManages();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobApplyId"))
				value.partjobapplyid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BusinessType"))
				value.businesstype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobUuid"))
				value.partjobuuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SecondStatus"))
				value.secondstatus_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jz_userApplyManages Clone()
        {
            return (Jz_userApplyManages)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jz_userApplyManages()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jz_userApplyManages() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jz_userApplyManages(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jz_userApplyManages(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jz_userApplyManages(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jz_userApplyManages(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jz_userApplyManages(int partjobapplyid1, string businesstype1, Guid partjobuuid1, DateTime createtime1, string status1, string secondstatus1, Guid user_id1)
        {
            
            this.PartJobApplyId = partjobapplyid1;
            
            this.BusinessType = businesstype1;
            
            this.PartJobUuid = partjobuuid1;
            
            this.CreateTime = createtime1;
            
            this.Status = status1;
            
            this.SecondStatus = secondstatus1;
            
            this.User_id = user_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jz_userApplyManages FromIView(IView view)
        {
            return (Jz_userApplyManages)IView.GetITable(view, "Jz_userApplyManages");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jz_userApplyManages GetOneInstance()
        {
            Jz_userApplyManages value = new Jz_userApplyManages();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jz_userApplyManages Retrieve()
        {
            BLLTable<Jz_userApplyManages>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "PartJobApplyId":
			        return PartJobApplyId;
			    			
			    case "BusinessType":
			        return BusinessType;
			    			
			    case "PartJobUuid":
			        return PartJobUuid;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Status":
			        return Status;
			    			
			    case "SecondStatus":
			        return SecondStatus;
			    			
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
			    case "PartJobApplyId":
			        this.PartJobApplyId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "BusinessType":
			        this.BusinessType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobUuid":
			        this.PartJobUuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SecondStatus":
			        this.SecondStatus = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
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
				case "PartJobApplyId":
					return partjobapplyid_initialized;
				
				case "BusinessType":
					return businesstype_initialized;
				
				case "PartJobUuid":
					return partjobuuid_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Status":
					return status_initialized;
				
				case "SecondStatus":
					return secondstatus_initialized;
				
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
				case "PartJobApplyId":
					partjobapplyid_initialized = ret;
					return true;
				
				case "BusinessType":
					businesstype_initialized = ret;
					return true;
				
				case "PartJobUuid":
					partjobuuid_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "SecondStatus":
					secondstatus_initialized = ret;
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

			
			if (partjobapplyid_initialized)
			{
                AttributeItem attr = Jz_userApplyManages.Attribute.PartJobApplyId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobApplyId);
                }
			}
			
			if (businesstype_initialized)
			{
                AttributeItem attr = Jz_userApplyManages.Attribute.BusinessType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BusinessType);
                }
			}
			
			if (partjobuuid_initialized)
			{
                AttributeItem attr = Jz_userApplyManages.Attribute.PartJobUuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobUuid);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jz_userApplyManages.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Jz_userApplyManages.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (secondstatus_initialized)
			{
                AttributeItem attr = Jz_userApplyManages.Attribute.SecondStatus;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SecondStatus);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jz_userApplyManages.Attribute.User_id;
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
        public class Jz_userApplyManagesJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int PartJobApplyId { get; set; }
            
            /// <summary>��λ����:[Enum-{PRACTICE:ʵϰ},{PART_JOB:��ְ}][CtrlTypeDic-{SelectDrop}]</summary>
            public string BusinessType { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid PartJobUuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>״̬:[Enum-{TO_ACCEPT:�����ɹ�����ȴ��̼�¼ȡ},{CANCEL:��ȡ������},{REMIND_COMPANY:�������̼�¼ȡ�������ĵȴ�},{REFUSE_ADMIT:���̼�ȡ��¼ȡ}][CtrlTypeDic-{InputString}]</summary>
            public string Status { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string SecondStatus { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
        }
        #endregion
    }
}
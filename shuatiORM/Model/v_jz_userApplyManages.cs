/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:58
  Description:    ���ݱ�V_jz_userApplyManages��Ӧ��ҵ���߼���V_jz_userApplyManages
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� V_jz_userApplyManages_Entity:V_jz_userApplyManages
 * 
************************************************************/
/************************************************************
SQL���룺
select Status,SecondStatus,User_id,PartJobId,AddressDetail,JobTimeStandard,PartJobLogo,PartJobTitle,Salary,CompanyName,CompanyType,Email,CompanyId,CompanyUuid,CompanyMobile,CompanyAccountId,AddressBuilding,BusinessType,PartJobApplyId from V_jz_userApplyManages
delete from V_jz_userApplyManages
INSERT INTO V_jz_userApplyManages (Status,SecondStatus,User_id,PartJobId,AddressDetail,JobTimeStandard,PartJobLogo,PartJobTitle,Salary,CompanyName,CompanyType,Email,CompanyId,CompanyUuid,CompanyMobile,CompanyAccountId,AddressBuilding,BusinessType,PartJobApplyId)
     VALUES
           ('','','','','','','','','','','','','','','','','','','')
UPDATE V_jz_userApplyManages SET ...
������ֵ���룺
 *         valObj.Status = valObj2.Status;
        valObj.SecondStatus = valObj2.SecondStatus;
        valObj.User_id = valObj2.User_id;
        valObj.PartJobId = valObj2.PartJobId;
        valObj.AddressDetail = valObj2.AddressDetail;
        valObj.JobTimeStandard = valObj2.JobTimeStandard;
        valObj.PartJobLogo = valObj2.PartJobLogo;
        valObj.PartJobTitle = valObj2.PartJobTitle;
        valObj.Salary = valObj2.Salary;
        valObj.CompanyName = valObj2.CompanyName;
        valObj.CompanyType = valObj2.CompanyType;
        valObj.Email = valObj2.Email;
        valObj.CompanyId = valObj2.CompanyId;
        valObj.CompanyUuid = valObj2.CompanyUuid;
        valObj.CompanyMobile = valObj2.CompanyMobile;
        valObj.CompanyAccountId = valObj2.CompanyAccountId;
        valObj.AddressBuilding = valObj2.AddressBuilding;
        valObj.BusinessType = valObj2.BusinessType;
        valObj.PartJobApplyId = valObj2.PartJobApplyId; 
        valObj.Status = "";
        valObj.SecondStatus = "";
        valObj.User_id = "";
        valObj.PartJobId = "";
        valObj.AddressDetail = "";
        valObj.JobTimeStandard = "";
        valObj.PartJobLogo = "";
        valObj.PartJobTitle = "";
        valObj.Salary = "";
        valObj.CompanyName = "";
        valObj.CompanyType = "";
        valObj.Email = "";
        valObj.CompanyId = "";
        valObj.CompanyUuid = "";
        valObj.CompanyMobile = "";
        valObj.CompanyAccountId = "";
        valObj.AddressBuilding = "";
        valObj.BusinessType = "";
        valObj.PartJobApplyId = ""; 
        "Status": $("#txt_Status").val(),
        "SecondStatus": $("#txt_SecondStatus").val(),
        "User_id": $("#txt_User_id").val(),
        "PartJobId": $("#txt_PartJobId").val(),
        "AddressDetail": $("#txt_AddressDetail").val(),
        "JobTimeStandard": $("#txt_JobTimeStandard").val(),
        "PartJobLogo": $("#txt_PartJobLogo").val(),
        "PartJobTitle": $("#txt_PartJobTitle").val(),
        "Salary": $("#txt_Salary").val(),
        "CompanyName": $("#txt_CompanyName").val(),
        "CompanyType": $("#txt_CompanyType").val(),
        "Email": $("#txt_Email").val(),
        "CompanyId": $("#txt_CompanyId").val(),
        "CompanyUuid": $("#txt_CompanyUuid").val(),
        "CompanyMobile": $("#txt_CompanyMobile").val(),
        "CompanyAccountId": $("#txt_CompanyAccountId").val(),
        "AddressBuilding": $("#txt_AddressBuilding").val(),
        "BusinessType": $("#txt_BusinessType").val(),
        "PartJobApplyId": $("#txt_PartJobApplyId").val(), 
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
    /// <para>JZ��˾__��ְ��__�û����������:[Inner-{Jz_company:0},{Jz_partJobs:1},{Jz_userApplyManages:2}]</para>
    /// <para>��V_jz_userApplyManages���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class V_jz_userApplyManages : ITableImplement
    {
        /// <summary>��������  </summary>
        public static V_jz_userApplyManages Factory()
        {
            return new V_jz_userApplyManages();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ��״ Attribute_IsNotNull </summary>
        public string _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _SecondStatus
        {            
            get { return this.SecondStatus; }
            set { this.SecondStatus = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> ����ְλ��� Attribute_IsNotNull </summary>
        public int _PartJobId
        {            
            get { return this.PartJobId; }
            set { this.PartJobId = value; }
        }
        
        /// <summary> ��ϸ��ַ Attribute_IsNotNull </summary>
        public string _AddressDetail
        {            
            get { return this.AddressDetail; }
            set { this.AddressDetail = value; }
        }
        
        /// <summary> ����ʱ���׼ Attribute_IsNotNull </summary>
        public string _JobTimeStandard
        {            
            get { return this.JobTimeStandard; }
            set { this.JobTimeStandard = value; }
        }
        
        /// <summary> ���ֹ����ı�־ Attribute_IsNotNull </summary>
        public string _PartJobLogo
        {            
            get { return this.PartJobLogo; }
            set { this.PartJobLogo = value; }
        }
        
        /// <summary> ���ֹ������� Attribute_IsNotNull </summary>
        public string _PartJobTitle
        {            
            get { return this.PartJobTitle; }
            set { this.PartJobTitle = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public string _Salary
        {            
            get { return this.Salary; }
            set { this.Salary = value; }
        }
        
        /// <summary> ��˾����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CompanyName
        {            
            get { return this.CompanyName; }
            set { this.CompanyName = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _CompanyType
        {            
            get { return this.CompanyType; }
            set { this.CompanyType = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Email
        {            
            get { return this.Email; }
            set { this.Email = value; }
        }
        
        /// <summary> ��˾ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CompanyId
        {            
            get { return this.CompanyId; }
            set { this.CompanyId = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _CompanyUuid
        {            
            get { return this.CompanyUuid; }
            set { this.CompanyUuid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _CompanyMobile
        {            
            get { return this.CompanyMobile; }
            set { this.CompanyMobile = value; }
        }
        
        /// <summary> ��˾�ʻ�ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CompanyAccountId
        {            
            get { return this.CompanyAccountId; }
            set { this.CompanyAccountId = value; }
        }
        
        /// <summary> ��ַ���� Attribute_IsNotNull </summary>
        public string _AddressBuilding
        {            
            get { return this.AddressBuilding; }
            set { this.AddressBuilding = value; }
        }
        
        /// <summary> ��λ����:[Enum-{PRACTICE:ʵϰ},{PART_JOB:��ְ}] Attribute_IsNotNull </summary>
        public string _BusinessType
        {            
            get { return this.BusinessType; }
            set { this.BusinessType = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _PartJobApplyId
        {            
            get { return this.PartJobApplyId; }
            set { this.PartJobApplyId = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ��״���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����ְλ��ţ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int PartJobId
        {
            get { return this.m_partjobid; }
            set //
            {
                if (!partjobid_initialized || m_partjobid != value)
                {
                    this.m_partjobid = value;
                }
                partjobid_initialized = true;
            }
        }
        
        /// <summary> ��ϸ��ַ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string AddressDetail
        {
            get { return this.m_addressdetail; }
            set //
            {
                if (!addressdetail_initialized || m_addressdetail != value)
                {
                    this.m_addressdetail = value;
                }
                addressdetail_initialized = true;
            }
        }
        
        /// <summary> ����ʱ���׼���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string JobTimeStandard
        {
            get { return this.m_jobtimestandard; }
            set //
            {
                if (!jobtimestandard_initialized || m_jobtimestandard != value)
                {
                    this.m_jobtimestandard = value;
                }
                jobtimestandard_initialized = true;
            }
        }
        
        /// <summary> ���ֹ����ı�־���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PartJobLogo
        {
            get { return this.m_partjoblogo; }
            set //
            {
                if (!partjoblogo_initialized || m_partjoblogo != value)
                {
                    this.m_partjoblogo = value;
                }
                partjoblogo_initialized = true;
            }
        }
        
        /// <summary> ���ֹ������⣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PartJobTitle
        {
            get { return this.m_partjobtitle; }
            set //
            {
                if (!partjobtitle_initialized || m_partjobtitle != value)
                {
                    this.m_partjobtitle = value;
                }
                partjobtitle_initialized = true;
            }
        }
        
        /// <summary> ���ʣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Salary
        {
            get { return this.m_salary; }
            set //
            {
                if (!salary_initialized || m_salary != value)
                {
                    this.m_salary = value;
                }
                salary_initialized = true;
            }
        }
        
        /// <summary> ��˾����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string CompanyName
        {
            get { return this.m_companyname; }
            set //
            {
                if (!companyname_initialized || m_companyname != value)
                {
                    this.m_companyname = value;
                }
                companyname_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string CompanyType
        {
            get { return this.m_companytype; }
            set //
            {
                if (!companytype_initialized || m_companytype != value)
                {
                    this.m_companytype = value;
                }
                companytype_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Email
        {
            get { return this.m_email; }
            set //
            {
                if (!email_initialized || m_email != value)
                {
                    this.m_email = value;
                }
                email_initialized = true;
            }
        }
        
        /// <summary> ��˾ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int CompanyId
        {
            get { return this.m_companyid; }
            set //
            {
                if (!companyid_initialized || m_companyid != value)
                {
                    this.m_companyid = value;
                }
                companyid_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid CompanyUuid
        {
            get { return this.m_companyuuid; }
            set //
            {
                if (!companyuuid_initialized || m_companyuuid != value)
                {
                    this.m_companyuuid = value;
                }
                companyuuid_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string CompanyMobile
        {
            get { return this.m_companymobile; }
            set //
            {
                if (!companymobile_initialized || m_companymobile != value)
                {
                    this.m_companymobile = value;
                }
                companymobile_initialized = true;
            }
        }
        
        /// <summary> ��˾�ʻ�ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int CompanyAccountId
        {
            get { return this.m_companyaccountid; }
            set //
            {
                if (!companyaccountid_initialized || m_companyaccountid != value)
                {
                    this.m_companyaccountid = value;
                }
                companyaccountid_initialized = true;
            }
        }
        
        /// <summary> ��ַ�������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string AddressBuilding
        {
            get { return this.m_addressbuilding; }
            set //
            {
                if (!addressbuilding_initialized || m_addressbuilding != value)
                {
                    this.m_addressbuilding = value;
                }
                addressbuilding_initialized = true;
            }
        }
        
        /// <summary> ��λ����:[Enum-{PRACTICE:ʵϰ},{PART_JOB:��ְ}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int PartJobApplyId
        {
            get { return this.m_partjobapplyid; }
            set //
            {
                if (!partjobapplyid_initialized || m_partjobapplyid != value)
                {
                    this.m_partjobapplyid = value;
                }
                partjobapplyid_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>��״</summary>
            public static AttributeItem Status =  new AttributeItem("[V_jz_userApplyManages].[Status]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem SecondStatus =  new AttributeItem("[V_jz_userApplyManages].[SecondStatus]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[V_jz_userApplyManages].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����ְλ���</summary>
            public static AttributeItem PartJobId =  new AttributeItem("[V_jz_userApplyManages].[PartJobId]", typeof(int), 4, default(int));
            
            /// <summary>��ϸ��ַ</summary>
            public static AttributeItem AddressDetail =  new AttributeItem("[V_jz_userApplyManages].[AddressDetail]", typeof(string), 100, default(string));
            
            /// <summary>����ʱ���׼</summary>
            public static AttributeItem JobTimeStandard =  new AttributeItem("[V_jz_userApplyManages].[JobTimeStandard]", typeof(string), 100, default(string));
            
            /// <summary>���ֹ����ı�־</summary>
            public static AttributeItem PartJobLogo =  new AttributeItem("[V_jz_userApplyManages].[PartJobLogo]", typeof(string), 200, default(string));
            
            /// <summary>���ֹ�������</summary>
            public static AttributeItem PartJobTitle =  new AttributeItem("[V_jz_userApplyManages].[PartJobTitle]", typeof(string), 100, default(string));
            
            /// <summary>����</summary>
            public static AttributeItem Salary =  new AttributeItem("[V_jz_userApplyManages].[Salary]", typeof(string), 100, default(string));
            
            /// <summary>��˾����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyName =  new AttributeItem("[V_jz_userApplyManages].[CompanyName]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem CompanyType =  new AttributeItem("[V_jz_userApplyManages].[CompanyType]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Email =  new AttributeItem("[V_jz_userApplyManages].[Email]", typeof(string), 100, default(string));
            
            /// <summary>��˾ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyId =  new AttributeItem("[V_jz_userApplyManages].[CompanyId]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem CompanyUuid =  new AttributeItem("[V_jz_userApplyManages].[CompanyUuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem CompanyMobile =  new AttributeItem("[V_jz_userApplyManages].[CompanyMobile]", typeof(string), 20, default(string));
            
            /// <summary>��˾�ʻ�ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CompanyAccountId =  new AttributeItem("[V_jz_userApplyManages].[CompanyAccountId]", typeof(int), 4, default(int));
            
            /// <summary>��ַ����</summary>
            public static AttributeItem AddressBuilding =  new AttributeItem("[V_jz_userApplyManages].[AddressBuilding]", typeof(string), 100, default(string));
            
            /// <summary>��λ����:[Enum-{PRACTICE:ʵϰ},{PART_JOB:��ְ}]</summary>
            public static AttributeItem BusinessType =  new AttributeItem("[V_jz_userApplyManages].[BusinessType]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem PartJobApplyId =  new AttributeItem("[V_jz_userApplyManages].[PartJobApplyId]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_secondstatus;
        /// <summary></summary>
        protected bool secondstatus_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private int m_partjobid;
        /// <summary></summary>
        protected bool partjobid_initialized = false;
        
        private string m_addressdetail;
        /// <summary></summary>
        protected bool addressdetail_initialized = false;
        
        private string m_jobtimestandard;
        /// <summary></summary>
        protected bool jobtimestandard_initialized = false;
        
        private string m_partjoblogo;
        /// <summary></summary>
        protected bool partjoblogo_initialized = false;
        
        private string m_partjobtitle;
        /// <summary></summary>
        protected bool partjobtitle_initialized = false;
        
        private string m_salary;
        /// <summary></summary>
        protected bool salary_initialized = false;
        
        private string m_companyname;
        /// <summary></summary>
        protected bool companyname_initialized = false;
        
        private string m_companytype;
        /// <summary></summary>
        protected bool companytype_initialized = false;
        
        private string m_email;
        /// <summary></summary>
        protected bool email_initialized = false;
        
        private int m_companyid;
        /// <summary></summary>
        protected bool companyid_initialized = false;
        
        private Guid m_companyuuid;
        /// <summary></summary>
        protected bool companyuuid_initialized = false;
        
        private string m_companymobile;
        /// <summary></summary>
        protected bool companymobile_initialized = false;
        
        private int m_companyaccountid;
        /// <summary></summary>
        protected bool companyaccountid_initialized = false;
        
        private string m_addressbuilding;
        /// <summary></summary>
        protected bool addressbuilding_initialized = false;
        
        private string m_businesstype;
        /// <summary></summary>
        protected bool businesstype_initialized = false;
        
        private int m_partjobapplyid;
        /// <summary></summary>
        protected bool partjobapplyid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_jz_userApplyManages";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.status_initialized = IsLoadAllAttributes;this.secondstatus_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.partjobid_initialized = IsLoadAllAttributes;this.addressdetail_initialized = IsLoadAllAttributes;this.jobtimestandard_initialized = IsLoadAllAttributes;this.partjoblogo_initialized = IsLoadAllAttributes;this.partjobtitle_initialized = IsLoadAllAttributes;this.salary_initialized = IsLoadAllAttributes;this.companyname_initialized = IsLoadAllAttributes;this.companytype_initialized = IsLoadAllAttributes;this.email_initialized = IsLoadAllAttributes;this.companyid_initialized = IsLoadAllAttributes;this.companyuuid_initialized = IsLoadAllAttributes;this.companymobile_initialized = IsLoadAllAttributes;this.companyaccountid_initialized = IsLoadAllAttributes;this.addressbuilding_initialized = IsLoadAllAttributes;this.businesstype_initialized = IsLoadAllAttributes;this.partjobapplyid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_jz_userApplyManages value = new V_jz_userApplyManages();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SecondStatus"))
				value.secondstatus_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobId"))
				value.partjobid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AddressDetail"))
				value.addressdetail_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"JobTimeStandard"))
				value.jobtimestandard_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobLogo"))
				value.partjoblogo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobTitle"))
				value.partjobtitle_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Salary"))
				value.salary_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyName"))
				value.companyname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyType"))
				value.companytype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Email"))
				value.email_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyId"))
				value.companyid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyUuid"))
				value.companyuuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyMobile"))
				value.companymobile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CompanyAccountId"))
				value.companyaccountid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AddressBuilding"))
				value.addressbuilding_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BusinessType"))
				value.businesstype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobApplyId"))
				value.partjobapplyid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new V_jz_userApplyManages Clone()
        {
            return (V_jz_userApplyManages)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static V_jz_userApplyManages()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public V_jz_userApplyManages() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public V_jz_userApplyManages(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public V_jz_userApplyManages(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public V_jz_userApplyManages(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public V_jz_userApplyManages(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public V_jz_userApplyManages(string status1, string secondstatus1, Guid user_id1, int partjobid1, string addressdetail1, string jobtimestandard1, string partjoblogo1, string partjobtitle1, string salary1, string companyname1, string companytype1, string email1, int companyid1, Guid companyuuid1, string companymobile1, int companyaccountid1, string addressbuilding1, string businesstype1, int partjobapplyid1)
        {
            
            this.Status = status1;
            
            this.SecondStatus = secondstatus1;
            
            this.User_id = user_id1;
            
            this.PartJobId = partjobid1;
            
            this.AddressDetail = addressdetail1;
            
            this.JobTimeStandard = jobtimestandard1;
            
            this.PartJobLogo = partjoblogo1;
            
            this.PartJobTitle = partjobtitle1;
            
            this.Salary = salary1;
            
            this.CompanyName = companyname1;
            
            this.CompanyType = companytype1;
            
            this.Email = email1;
            
            this.CompanyId = companyid1;
            
            this.CompanyUuid = companyuuid1;
            
            this.CompanyMobile = companymobile1;
            
            this.CompanyAccountId = companyaccountid1;
            
            this.AddressBuilding = addressbuilding1;
            
            this.BusinessType = businesstype1;
            
            this.PartJobApplyId = partjobapplyid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static V_jz_userApplyManages FromIView(IView view)
        {
            return (V_jz_userApplyManages)IView.GetITable(view, "V_jz_userApplyManages");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static V_jz_userApplyManages GetOneInstance()
        {
            V_jz_userApplyManages value = new V_jz_userApplyManages();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public V_jz_userApplyManages Retrieve()
        {
            BLLTable<V_jz_userApplyManages>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Status":
			        return Status;
			    			
			    case "SecondStatus":
			        return SecondStatus;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "PartJobId":
			        return PartJobId;
			    			
			    case "AddressDetail":
			        return AddressDetail;
			    			
			    case "JobTimeStandard":
			        return JobTimeStandard;
			    			
			    case "PartJobLogo":
			        return PartJobLogo;
			    			
			    case "PartJobTitle":
			        return PartJobTitle;
			    			
			    case "Salary":
			        return Salary;
			    			
			    case "CompanyName":
			        return CompanyName;
			    			
			    case "CompanyType":
			        return CompanyType;
			    			
			    case "Email":
			        return Email;
			    			
			    case "CompanyId":
			        return CompanyId;
			    			
			    case "CompanyUuid":
			        return CompanyUuid;
			    			
			    case "CompanyMobile":
			        return CompanyMobile;
			    			
			    case "CompanyAccountId":
			        return CompanyAccountId;
			    			
			    case "AddressBuilding":
			        return AddressBuilding;
			    			
			    case "BusinessType":
			        return BusinessType;
			    			
			    case "PartJobApplyId":
			        return PartJobApplyId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Status":
			        this.Status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SecondStatus":
			        this.SecondStatus = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "PartJobId":
			        this.PartJobId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AddressDetail":
			        this.AddressDetail = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "JobTimeStandard":
			        this.JobTimeStandard = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobLogo":
			        this.PartJobLogo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobTitle":
			        this.PartJobTitle = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Salary":
			        this.Salary = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyName":
			        this.CompanyName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyType":
			        this.CompanyType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Email":
			        this.Email = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyId":
			        this.CompanyId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CompanyUuid":
			        this.CompanyUuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "CompanyMobile":
			        this.CompanyMobile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CompanyAccountId":
			        this.CompanyAccountId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AddressBuilding":
			        this.AddressBuilding = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "BusinessType":
			        this.BusinessType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobApplyId":
			        this.PartJobApplyId = Convert.ToInt32(AttributeValue);
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
				case "Status":
					return status_initialized;
				
				case "SecondStatus":
					return secondstatus_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "PartJobId":
					return partjobid_initialized;
				
				case "AddressDetail":
					return addressdetail_initialized;
				
				case "JobTimeStandard":
					return jobtimestandard_initialized;
				
				case "PartJobLogo":
					return partjoblogo_initialized;
				
				case "PartJobTitle":
					return partjobtitle_initialized;
				
				case "Salary":
					return salary_initialized;
				
				case "CompanyName":
					return companyname_initialized;
				
				case "CompanyType":
					return companytype_initialized;
				
				case "Email":
					return email_initialized;
				
				case "CompanyId":
					return companyid_initialized;
				
				case "CompanyUuid":
					return companyuuid_initialized;
				
				case "CompanyMobile":
					return companymobile_initialized;
				
				case "CompanyAccountId":
					return companyaccountid_initialized;
				
				case "AddressBuilding":
					return addressbuilding_initialized;
				
				case "BusinessType":
					return businesstype_initialized;
				
				case "PartJobApplyId":
					return partjobapplyid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Status":
					status_initialized = ret;
					return true;
				
				case "SecondStatus":
					secondstatus_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "PartJobId":
					partjobid_initialized = ret;
					return true;
				
				case "AddressDetail":
					addressdetail_initialized = ret;
					return true;
				
				case "JobTimeStandard":
					jobtimestandard_initialized = ret;
					return true;
				
				case "PartJobLogo":
					partjoblogo_initialized = ret;
					return true;
				
				case "PartJobTitle":
					partjobtitle_initialized = ret;
					return true;
				
				case "Salary":
					salary_initialized = ret;
					return true;
				
				case "CompanyName":
					companyname_initialized = ret;
					return true;
				
				case "CompanyType":
					companytype_initialized = ret;
					return true;
				
				case "Email":
					email_initialized = ret;
					return true;
				
				case "CompanyId":
					companyid_initialized = ret;
					return true;
				
				case "CompanyUuid":
					companyuuid_initialized = ret;
					return true;
				
				case "CompanyMobile":
					companymobile_initialized = ret;
					return true;
				
				case "CompanyAccountId":
					companyaccountid_initialized = ret;
					return true;
				
				case "AddressBuilding":
					addressbuilding_initialized = ret;
					return true;
				
				case "BusinessType":
					businesstype_initialized = ret;
					return true;
				
				case "PartJobApplyId":
					partjobapplyid_initialized = ret;
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

			
			if (status_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (secondstatus_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.SecondStatus;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SecondStatus);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (partjobid_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.PartJobId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobId);
                }
			}
			
			if (addressdetail_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.AddressDetail;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AddressDetail);
                }
			}
			
			if (jobtimestandard_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.JobTimeStandard;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(JobTimeStandard);
                }
			}
			
			if (partjoblogo_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.PartJobLogo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobLogo);
                }
			}
			
			if (partjobtitle_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.PartJobTitle;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobTitle);
                }
			}
			
			if (salary_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.Salary;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Salary);
                }
			}
			
			if (companyname_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.CompanyName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyName);
                }
			}
			
			if (companytype_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.CompanyType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyType);
                }
			}
			
			if (email_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.Email;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Email);
                }
			}
			
			if (companyid_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.CompanyId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyId);
                }
			}
			
			if (companyuuid_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.CompanyUuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyUuid);
                }
			}
			
			if (companymobile_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.CompanyMobile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyMobile);
                }
			}
			
			if (companyaccountid_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.CompanyAccountId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CompanyAccountId);
                }
			}
			
			if (addressbuilding_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.AddressBuilding;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AddressBuilding);
                }
			}
			
			if (businesstype_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.BusinessType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BusinessType);
                }
			}
			
			if (partjobapplyid_initialized)
			{
                AttributeItem attr = V_jz_userApplyManages.Attribute.PartJobApplyId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobApplyId);
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
        public class V_jz_userApplyManagesJson
        {
            
            /// <summary>��״</summary>
            public string Status { get; set; }
            
            /// <summary></summary>
            public string SecondStatus { get; set; }
            
            /// <summary></summary>
            public Guid User_id { get; set; }
            
            /// <summary>����ְλ���</summary>
            public int PartJobId { get; set; }
            
            /// <summary>��ϸ��ַ</summary>
            public string AddressDetail { get; set; }
            
            /// <summary>����ʱ���׼</summary>
            public string JobTimeStandard { get; set; }
            
            /// <summary>���ֹ����ı�־</summary>
            public string PartJobLogo { get; set; }
            
            /// <summary>���ֹ�������</summary>
            public string PartJobTitle { get; set; }
            
            /// <summary>����</summary>
            public string Salary { get; set; }
            
            /// <summary>��˾����:[CtrlTypeDic-{InputString}]</summary>
            public string CompanyName { get; set; }
            
            /// <summary></summary>
            public string CompanyType { get; set; }
            
            /// <summary></summary>
            public string Email { get; set; }
            
            /// <summary>��˾ID:[CtrlTypeDic-{InputString}]</summary>
            public int CompanyId { get; set; }
            
            /// <summary></summary>
            public Guid CompanyUuid { get; set; }
            
            /// <summary></summary>
            public string CompanyMobile { get; set; }
            
            /// <summary>��˾�ʻ�ID:[CtrlTypeDic-{InputString}]</summary>
            public int CompanyAccountId { get; set; }
            
            /// <summary>��ַ����</summary>
            public string AddressBuilding { get; set; }
            
            /// <summary>��λ����:[Enum-{PRACTICE:ʵϰ},{PART_JOB:��ְ}]</summary>
            public string BusinessType { get; set; }
            
            /// <summary></summary>
            public int PartJobApplyId { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:21
  Description:    ���ݱ�Jz_resume��Ӧ��ҵ���߼���Jz_resume
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jz_resume_Entity:Jz_resume
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,ApplyCount,EvaluationStar,AuthenticateStatus,Mobile,HasAuthenticate,Sex,Name,Email,HeadImg,Introduction,UserFreeTimeMatchIds,Tags,User_id from Jz_resume
delete from Jz_resume
INSERT INTO Jz_resume (Id,ApplyCount,EvaluationStar,AuthenticateStatus,Mobile,HasAuthenticate,Sex,Name,Email,HeadImg,Introduction,UserFreeTimeMatchIds,Tags,User_id)
     VALUES
           ('','','','','','','','','','','','','','')
UPDATE Jz_resume SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.ApplyCount = valObj2.ApplyCount;
        valObj.EvaluationStar = valObj2.EvaluationStar;
        valObj.AuthenticateStatus = valObj2.AuthenticateStatus;
        valObj.Mobile = valObj2.Mobile;
        valObj.HasAuthenticate = valObj2.HasAuthenticate;
        valObj.Sex = valObj2.Sex;
        valObj.Name = valObj2.Name;
        valObj.Email = valObj2.Email;
        valObj.HeadImg = valObj2.HeadImg;
        valObj.Introduction = valObj2.Introduction;
        valObj.UserFreeTimeMatchIds = valObj2.UserFreeTimeMatchIds;
        valObj.Tags = valObj2.Tags;
        valObj.User_id = valObj2.User_id; 
        valObj.Id = "";
        valObj.ApplyCount = "";
        valObj.EvaluationStar = "";
        valObj.AuthenticateStatus = "";
        valObj.Mobile = "";
        valObj.HasAuthenticate = "";
        valObj.Sex = "";
        valObj.Name = "";
        valObj.Email = "";
        valObj.HeadImg = "";
        valObj.Introduction = "";
        valObj.UserFreeTimeMatchIds = "";
        valObj.Tags = "";
        valObj.User_id = ""; 
        "Id": $("#txt_Id").val(),
        "ApplyCount": $("#txt_ApplyCount").val(),
        "EvaluationStar": $("#txt_EvaluationStar").val(),
        "AuthenticateStatus": $("#txt_AuthenticateStatus").val(),
        "Mobile": $("#txt_Mobile").val(),
        "HasAuthenticate": $("#txt_HasAuthenticate").val(),
        "Sex": $("#txt_Sex").val(),
        "Name": $("#txt_Name").val(),
        "Email": $("#txt_Email").val(),
        "HeadImg": $("#txt_HeadImg").val(),
        "Introduction": $("#txt_Introduction").val(),
        "UserFreeTimeMatchIds": $("#txt_UserFreeTimeMatchIds").val(),
        "Tags": $("#txt_Tags").val(),
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
    /// <para>��ְ������</para>
    /// <para>��Jz_resume���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jz_resume : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jz_resume Factory()
        {
            return new Jz_resume();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ��ְ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ApplyCount
        {            
            get { return this.ApplyCount; }
            set { this.ApplyCount = value; }
        }
        
        /// <summary> ��ְ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _EvaluationStar
        {            
            get { return this.EvaluationStar; }
            set { this.EvaluationStar = value; }
        }
        
        /// <summary> �����֤״̬:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AuthenticateStatus
        {            
            get { return this.AuthenticateStatus; }
            set { this.AuthenticateStatus = value; }
        }
        
        /// <summary> �ֻ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Mobile
        {            
            get { return this.Mobile; }
            set { this.Mobile = value; }
        }
        
        /// <summary> �����֤�ɹ���:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _HasAuthenticate
        {            
            get { return this.HasAuthenticate; }
            set { this.HasAuthenticate = value; }
        }
        
        /// <summary> �Ա�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public string _Email
        {            
            get { return this.Email; }
            set { this.Email = value; }
        }
        
        /// <summary> ͷ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _HeadImg
        {            
            get { return this.HeadImg; }
            set { this.HeadImg = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Introduction
        {            
            get { return this.Introduction; }
            set { this.Introduction = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UserFreeTimeMatchIds
        {            
            get { return this.UserFreeTimeMatchIds; }
            set { this.UserFreeTimeMatchIds = value; }
        }
        
        /// <summary> ��ǩ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Tags
        {            
            get { return this.Tags; }
            set { this.Tags = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ְ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ApplyCount
        {
            get { return this.m_applycount; }
            set //
            {
                if (!applycount_initialized || m_applycount != value)
                {
                    this.m_applycount = value;
                }
                applycount_initialized = true;
            }
        }
        
        /// <summary> ��ְ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal EvaluationStar
        {
            get { return this.m_evaluationstar; }
            set //
            {
                if (!evaluationstar_initialized || m_evaluationstar != value)
                {
                    this.m_evaluationstar = value;
                }
                evaluationstar_initialized = true;
            }
        }
        
        /// <summary> �����֤״̬:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string AuthenticateStatus
        {
            get { return this.m_authenticatestatus; }
            set //
            {
                if (!authenticatestatus_initialized || m_authenticatestatus != value)
                {
                    this.m_authenticatestatus = value;
                }
                authenticatestatus_initialized = true;
            }
        }
        
        /// <summary> �ֻ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �����֤�ɹ���:[CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool HasAuthenticate
        {
            get { return this.m_hasauthenticate; }
            set //
            {
                if (!hasauthenticate_initialized || m_hasauthenticate != value)
                {
                    this.m_hasauthenticate = value;
                }
                hasauthenticate_initialized = true;
            }
        }
        
        /// <summary> �Ա�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sex
        {
            get { return this.m_sex; }
            set //
            {
                if (!sex_initialized || m_sex != value)
                {
                    this.m_sex = value;
                }
                sex_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Name
        {
            get { return this.m_name; }
            set //
            {
                if (!name_initialized || m_name != value)
                {
                    this.m_name = value;
                }
                name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ͷ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string HeadImg
        {
            get { return this.m_headimg; }
            set //
            {
                if (!headimg_initialized || m_headimg != value)
                {
                    this.m_headimg = value;
                }
                headimg_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Introduction
        {
            get { return this.m_introduction; }
            set //
            {
                if (!introduction_initialized || m_introduction != value)
                {
                    this.m_introduction = value;
                }
                introduction_initialized = true;
            }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string UserFreeTimeMatchIds
        {
            get { return this.m_userfreetimematchids; }
            set //
            {
                if (!userfreetimematchids_initialized || m_userfreetimematchids != value)
                {
                    this.m_userfreetimematchids = value;
                }
                userfreetimematchids_initialized = true;
            }
        }
        
        /// <summary> ��ǩ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Tags
        {
            get { return this.m_tags; }
            set //
            {
                if (!tags_initialized || m_tags != value)
                {
                    this.m_tags = value;
                }
                tags_initialized = true;
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
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Jz_resume].[Id]", typeof(int), 4, default(int));
            
            /// <summary>��ְ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ApplyCount =  new AttributeItem("[Jz_resume].[ApplyCount]", typeof(int), 4, default(int));
            
            /// <summary>��ְ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem EvaluationStar =  new AttributeItem("[Jz_resume].[EvaluationStar]", typeof(decimal), 18, default(decimal));
            
            /// <summary>�����֤״̬:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AuthenticateStatus =  new AttributeItem("[Jz_resume].[AuthenticateStatus]", typeof(string), 50, default(string));
            
            /// <summary>�ֻ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Mobile =  new AttributeItem("[Jz_resume].[Mobile]", typeof(string), 50, default(string));
            
            /// <summary>�����֤�ɹ���:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem HasAuthenticate =  new AttributeItem("[Jz_resume].[HasAuthenticate]", typeof(bool), 1, default(bool));
            
            /// <summary>�Ա�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sex =  new AttributeItem("[Jz_resume].[Sex]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Jz_resume].[Name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Email =  new AttributeItem("[Jz_resume].[Email]", typeof(string), 50, default(string));
            
            /// <summary>ͷ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem HeadImg =  new AttributeItem("[Jz_resume].[HeadImg]", typeof(string), 200, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Introduction =  new AttributeItem("[Jz_resume].[Introduction]", typeof(string), 200, default(string));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserFreeTimeMatchIds =  new AttributeItem("[Jz_resume].[UserFreeTimeMatchIds]", typeof(string), 200, default(string));
            
            /// <summary>��ǩ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Tags =  new AttributeItem("[Jz_resume].[Tags]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jz_resume].[User_id]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_applycount;
        /// <summary></summary>
        protected bool applycount_initialized = false;
        
        private decimal m_evaluationstar;
        /// <summary></summary>
        protected bool evaluationstar_initialized = false;
        
        private string m_authenticatestatus;
        /// <summary></summary>
        protected bool authenticatestatus_initialized = false;
        
        private string m_mobile;
        /// <summary></summary>
        protected bool mobile_initialized = false;
        
        private bool m_hasauthenticate;
        /// <summary></summary>
        protected bool hasauthenticate_initialized = false;
        
        private string m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_email;
        /// <summary></summary>
        protected bool email_initialized = false;
        
        private string m_headimg;
        /// <summary></summary>
        protected bool headimg_initialized = false;
        
        private string m_introduction;
        /// <summary></summary>
        protected bool introduction_initialized = false;
        
        private string m_userfreetimematchids;
        /// <summary></summary>
        protected bool userfreetimematchids_initialized = false;
        
        private string m_tags;
        /// <summary></summary>
        protected bool tags_initialized = false;
        
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
            return "Jz_resume";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.applycount_initialized = IsLoadAllAttributes;this.evaluationstar_initialized = IsLoadAllAttributes;this.authenticatestatus_initialized = IsLoadAllAttributes;this.mobile_initialized = IsLoadAllAttributes;this.hasauthenticate_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.email_initialized = IsLoadAllAttributes;this.headimg_initialized = IsLoadAllAttributes;this.introduction_initialized = IsLoadAllAttributes;this.userfreetimematchids_initialized = IsLoadAllAttributes;this.tags_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_resume value = new Jz_resume();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ApplyCount"))
				value.applycount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"EvaluationStar"))
				value.evaluationstar_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AuthenticateStatus"))
				value.authenticatestatus_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mobile"))
				value.mobile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HasAuthenticate"))
				value.hasauthenticate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Email"))
				value.email_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"HeadImg"))
				value.headimg_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Introduction"))
				value.introduction_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserFreeTimeMatchIds"))
				value.userfreetimematchids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Tags"))
				value.tags_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jz_resume Clone()
        {
            return (Jz_resume)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jz_resume()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jz_resume() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jz_resume(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jz_resume(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jz_resume(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jz_resume(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jz_resume(int id1, int applycount1, decimal evaluationstar1, string authenticatestatus1, string mobile1, bool hasauthenticate1, string sex1, string name1, string email1, string headimg1, string introduction1, string userfreetimematchids1, string tags1, Guid user_id1)
        {
            
            this.Id = id1;
            
            this.ApplyCount = applycount1;
            
            this.EvaluationStar = evaluationstar1;
            
            this.AuthenticateStatus = authenticatestatus1;
            
            this.Mobile = mobile1;
            
            this.HasAuthenticate = hasauthenticate1;
            
            this.Sex = sex1;
            
            this.Name = name1;
            
            this.Email = email1;
            
            this.HeadImg = headimg1;
            
            this.Introduction = introduction1;
            
            this.UserFreeTimeMatchIds = userfreetimematchids1;
            
            this.Tags = tags1;
            
            this.User_id = user_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jz_resume FromIView(IView view)
        {
            return (Jz_resume)IView.GetITable(view, "Jz_resume");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jz_resume GetOneInstance()
        {
            Jz_resume value = new Jz_resume();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jz_resume Retrieve()
        {
            BLLTable<Jz_resume>.GetRowData(this);
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
			    			
			    case "ApplyCount":
			        return ApplyCount;
			    			
			    case "EvaluationStar":
			        return EvaluationStar;
			    			
			    case "AuthenticateStatus":
			        return AuthenticateStatus;
			    			
			    case "Mobile":
			        return Mobile;
			    			
			    case "HasAuthenticate":
			        return HasAuthenticate;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Email":
			        return Email;
			    			
			    case "HeadImg":
			        return HeadImg;
			    			
			    case "Introduction":
			        return Introduction;
			    			
			    case "UserFreeTimeMatchIds":
			        return UserFreeTimeMatchIds;
			    			
			    case "Tags":
			        return Tags;
			    			
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
			    			
			    case "ApplyCount":
			        this.ApplyCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "EvaluationStar":
			        this.EvaluationStar = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "AuthenticateStatus":
			        this.AuthenticateStatus = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Mobile":
			        this.Mobile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HasAuthenticate":
			        this.HasAuthenticate = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Email":
			        this.Email = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "HeadImg":
			        this.HeadImg = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Introduction":
			        this.Introduction = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UserFreeTimeMatchIds":
			        this.UserFreeTimeMatchIds = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Tags":
			        this.Tags = Convert.ToString(AttributeValue);
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
				case "Id":
					return id_initialized;
				
				case "ApplyCount":
					return applycount_initialized;
				
				case "EvaluationStar":
					return evaluationstar_initialized;
				
				case "AuthenticateStatus":
					return authenticatestatus_initialized;
				
				case "Mobile":
					return mobile_initialized;
				
				case "HasAuthenticate":
					return hasauthenticate_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Email":
					return email_initialized;
				
				case "HeadImg":
					return headimg_initialized;
				
				case "Introduction":
					return introduction_initialized;
				
				case "UserFreeTimeMatchIds":
					return userfreetimematchids_initialized;
				
				case "Tags":
					return tags_initialized;
				
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
				
				case "ApplyCount":
					applycount_initialized = ret;
					return true;
				
				case "EvaluationStar":
					evaluationstar_initialized = ret;
					return true;
				
				case "AuthenticateStatus":
					authenticatestatus_initialized = ret;
					return true;
				
				case "Mobile":
					mobile_initialized = ret;
					return true;
				
				case "HasAuthenticate":
					hasauthenticate_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Email":
					email_initialized = ret;
					return true;
				
				case "HeadImg":
					headimg_initialized = ret;
					return true;
				
				case "Introduction":
					introduction_initialized = ret;
					return true;
				
				case "UserFreeTimeMatchIds":
					userfreetimematchids_initialized = ret;
					return true;
				
				case "Tags":
					tags_initialized = ret;
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
                AttributeItem attr = Jz_resume.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (applycount_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.ApplyCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ApplyCount);
                }
			}
			
			if (evaluationstar_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.EvaluationStar;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(EvaluationStar);
                }
			}
			
			if (authenticatestatus_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.AuthenticateStatus;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AuthenticateStatus);
                }
			}
			
			if (mobile_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.Mobile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mobile);
                }
			}
			
			if (hasauthenticate_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.HasAuthenticate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HasAuthenticate);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (email_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.Email;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Email);
                }
			}
			
			if (headimg_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.HeadImg;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(HeadImg);
                }
			}
			
			if (introduction_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.Introduction;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Introduction);
                }
			}
			
			if (userfreetimematchids_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.UserFreeTimeMatchIds;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserFreeTimeMatchIds);
                }
			}
			
			if (tags_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.Tags;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Tags);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jz_resume.Attribute.User_id;
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
        public class Jz_resumeJson
        {
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public int Id { get; set; }
            
            /// <summary>��ְ����:[CtrlTypeDic-{InputString}]</summary>
            public int ApplyCount { get; set; }
            
            /// <summary>��ְ����:[CtrlTypeDic-{InputString}]</summary>
            public decimal EvaluationStar { get; set; }
            
            /// <summary>�����֤״̬:[CtrlTypeDic-{InputString}]</summary>
            public string AuthenticateStatus { get; set; }
            
            /// <summary>�ֻ���:[CtrlTypeDic-{InputString}]</summary>
            public string Mobile { get; set; }
            
            /// <summary>�����֤�ɹ���:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool HasAuthenticate { get; set; }
            
            /// <summary>�Ա�:[CtrlTypeDic-{InputString}]</summary>
            public string Sex { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public string Name { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public string Email { get; set; }
            
            /// <summary>ͷ��:[CtrlTypeDic-{InputString}]</summary>
            public string HeadImg { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Introduction { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public string UserFreeTimeMatchIds { get; set; }
            
            /// <summary>��ǩ:[CtrlTypeDic-{InputString}]</summary>
            public string Tags { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
        }
        #endregion
    }
}
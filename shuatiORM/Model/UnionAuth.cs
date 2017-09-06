/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/7/8 0:23:56
  Description:    ���ݱ�UnionAuth��Ӧ��ҵ���߼���UnionAuth
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� UnionAuth_Entity:UnionAuth
 * 
************************************************************/
/************************************************************
SQL���룺
select ID,Appid,CreateTime,Nick_name,Openid,Phone_num,Qq,SourceId,Unionid,User_id from UnionAuth
delete from UnionAuth
INSERT INTO UnionAuth (ID,Appid,CreateTime,Nick_name,Openid,Phone_num,Qq,SourceId,Unionid,User_id)
     VALUES
           ('','','','','','','','','','')
UPDATE UnionAuth SET ...
������ֵ���룺
 *         valObj.ID = valObj2.ID;
        valObj.Appid = valObj2.Appid;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Nick_name = valObj2.Nick_name;
        valObj.Openid = valObj2.Openid;
        valObj.Phone_num = valObj2.Phone_num;
        valObj.Qq = valObj2.Qq;
        valObj.SourceId = valObj2.SourceId;
        valObj.Unionid = valObj2.Unionid;
        valObj.User_id = valObj2.User_id; 
        valObj.ID = "";
        valObj.Appid = "";
        valObj.CreateTime = "";
        valObj.Nick_name = "";
        valObj.Openid = "";
        valObj.Phone_num = "";
        valObj.Qq = "";
        valObj.SourceId = "";
        valObj.Unionid = "";
        valObj.User_id = ""; 
        "ID": $("#txt_ID").val(),
        "Appid": $("#txt_Appid").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Nick_name": $("#txt_Nick_name").val(),
        "Openid": $("#txt_Openid").val(),
        "Phone_num": $("#txt_Phone_num").val(),
        "Qq": $("#txt_Qq").val(),
        "SourceId": $("#txt_SourceId").val(),
        "Unionid": $("#txt_Unionid").val(),
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
    /// <para>����Ȩ�ޱ�-�û���Ϣ����-unionid</para>
    /// <para>��UnionAuth���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class UnionAuth : ITableImplement
    {
        /// <summary>��������  </summary>
        public static UnionAuth Factory()
        {
            return new UnionAuth();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _ID
        {            
            get { return this.ID; }
            set { this.ID = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Appid
        {            
            get { return this.Appid; }
            set { this.Appid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Nick_name
        {            
            get { return this.Nick_name; }
            set { this.Nick_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Openid
        {            
            get { return this.Openid; }
            set { this.Openid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_num
        {            
            get { return this.Phone_num; }
            set { this.Phone_num = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Qq
        {            
            get { return this.Qq; }
            set { this.Qq = value; }
        }
        
        /// <summary> ��Դ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _SourceId
        {            
            get { return this.SourceId; }
            set { this.SourceId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Unionid
        {            
            get { return this.Unionid; }
            set { this.Unionid = value; }
        }
        
        /// <summary> �û����:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ID
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Appid
        {
            get { return this.m_appid; }
            set //
            {
                if (!appid_initialized || m_appid != value)
                {
                    this.m_appid = value;
                }
                appid_initialized = true;
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
        public string Nick_name
        {
            get { return this.m_nick_name; }
            set //
            {
                if (!nick_name_initialized || m_nick_name != value)
                {
                    this.m_nick_name = value;
                }
                nick_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Openid
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Phone_num
        {
            get { return this.m_phone_num; }
            set //
            {
                if (!phone_num_initialized || m_phone_num != value)
                {
                    this.m_phone_num = value;
                }
                phone_num_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Qq
        {
            get { return this.m_qq; }
            set //
            {
                if (!qq_initialized || m_qq != value)
                {
                    this.m_qq = value;
                }
                qq_initialized = true;
            }
        }
        
        /// <summary> ��Դ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int SourceId
        {
            get { return this.m_sourceid; }
            set //
            {
                if (!sourceid_initialized || m_sourceid != value)
                {
                    this.m_sourceid = value;
                }
                sourceid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Unionid
        {
            get { return this.m_unionid; }
            set //
            {
                if (!unionid_initialized || m_unionid != value)
                {
                    this.m_unionid = value;
                }
                unionid_initialized = true;
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
            public static AttributeItem ID =  new AttributeItem("[UnionAuth].[ID]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Appid =  new AttributeItem("[UnionAuth].[Appid]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[UnionAuth].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Nick_name =  new AttributeItem("[UnionAuth].[Nick_name]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Openid =  new AttributeItem("[UnionAuth].[Openid]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_num =  new AttributeItem("[UnionAuth].[Phone_num]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Qq =  new AttributeItem("[UnionAuth].[Qq]", typeof(string), 36, default(string));
            
            /// <summary>��Դ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SourceId =  new AttributeItem("[UnionAuth].[SourceId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Unionid =  new AttributeItem("[UnionAuth].[Unionid]", typeof(string), 36, default(string));
            
            /// <summary>�û����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[UnionAuth].[User_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_appid;
        /// <summary></summary>
        protected bool appid_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_nick_name;
        /// <summary></summary>
        protected bool nick_name_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_phone_num;
        /// <summary></summary>
        protected bool phone_num_initialized = false;
        
        private string m_qq;
        /// <summary></summary>
        protected bool qq_initialized = false;
        
        private int m_sourceid;
        /// <summary></summary>
        protected bool sourceid_initialized = false;
        
        private string m_unionid;
        /// <summary></summary>
        protected bool unionid_initialized = false;
        
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
            return "UnionAuth";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.appid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.nick_name_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.phone_num_initialized = IsLoadAllAttributes;this.qq_initialized = IsLoadAllAttributes;this.sourceid_initialized = IsLoadAllAttributes;this.unionid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			UnionAuth value = new UnionAuth();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"ID"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Appid"))
				value.appid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Nick_name"))
				value.nick_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Openid"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_num"))
				value.phone_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Qq"))
				value.qq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SourceId"))
				value.sourceid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Unionid"))
				value.unionid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new UnionAuth Clone()
        {
            return (UnionAuth)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static UnionAuth()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public UnionAuth() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public UnionAuth(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public UnionAuth(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public UnionAuth(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public UnionAuth(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public UnionAuth(int id1, string appid1, DateTime createtime1, string nick_name1, string openid1, string phone_num1, string qq1, int sourceid1, string unionid1, string user_id1)
        {
            
            this.ID = id1;
            
            this.Appid = appid1;
            
            this.CreateTime = createtime1;
            
            this.Nick_name = nick_name1;
            
            this.Openid = openid1;
            
            this.Phone_num = phone_num1;
            
            this.Qq = qq1;
            
            this.SourceId = sourceid1;
            
            this.Unionid = unionid1;
            
            this.User_id = user_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static UnionAuth FromIView(IView view)
        {
            return (UnionAuth)IView.GetITable(view, "UnionAuth");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static UnionAuth GetOneInstance()
        {
            UnionAuth value = new UnionAuth();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public UnionAuth Retrieve()
        {
            BLLTable<UnionAuth>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "ID":
			        return ID;
			    			
			    case "Appid":
			        return Appid;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Nick_name":
			        return Nick_name;
			    			
			    case "Openid":
			        return Openid;
			    			
			    case "Phone_num":
			        return Phone_num;
			    			
			    case "Qq":
			        return Qq;
			    			
			    case "SourceId":
			        return SourceId;
			    			
			    case "Unionid":
			        return Unionid;
			    			
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
			    case "ID":
			        this.ID = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Appid":
			        this.Appid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Nick_name":
			        this.Nick_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Openid":
			        this.Openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_num":
			        this.Phone_num = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Qq":
			        this.Qq = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SourceId":
			        this.SourceId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Unionid":
			        this.Unionid = Convert.ToString(AttributeValue);
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
				case "ID":
					return id_initialized;
				
				case "Appid":
					return appid_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Nick_name":
					return nick_name_initialized;
				
				case "Openid":
					return openid_initialized;
				
				case "Phone_num":
					return phone_num_initialized;
				
				case "Qq":
					return qq_initialized;
				
				case "SourceId":
					return sourceid_initialized;
				
				case "Unionid":
					return unionid_initialized;
				
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
				case "ID":
					id_initialized = ret;
					return true;
				
				case "Appid":
					appid_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Nick_name":
					nick_name_initialized = ret;
					return true;
				
				case "Openid":
					openid_initialized = ret;
					return true;
				
				case "Phone_num":
					phone_num_initialized = ret;
					return true;
				
				case "Qq":
					qq_initialized = ret;
					return true;
				
				case "SourceId":
					sourceid_initialized = ret;
					return true;
				
				case "Unionid":
					unionid_initialized = ret;
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
                AttributeItem attr = UnionAuth.Attribute.ID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ID);
                }
			}
			
			if (appid_initialized)
			{
                AttributeItem attr = UnionAuth.Attribute.Appid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Appid);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = UnionAuth.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (nick_name_initialized)
			{
                AttributeItem attr = UnionAuth.Attribute.Nick_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Nick_name);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = UnionAuth.Attribute.Openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Openid);
                }
			}
			
			if (phone_num_initialized)
			{
                AttributeItem attr = UnionAuth.Attribute.Phone_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_num);
                }
			}
			
			if (qq_initialized)
			{
                AttributeItem attr = UnionAuth.Attribute.Qq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Qq);
                }
			}
			
			if (sourceid_initialized)
			{
                AttributeItem attr = UnionAuth.Attribute.SourceId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SourceId);
                }
			}
			
			if (unionid_initialized)
			{
                AttributeItem attr = UnionAuth.Attribute.Unionid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Unionid);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = UnionAuth.Attribute.User_id;
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
        public class UnionAuthJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int ID { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Appid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Nick_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Openid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_num { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Qq { get; set; }
            
            /// <summary>��Դ����:[CtrlTypeDic-{InputString}]</summary>
            public int SourceId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Unionid { get; set; }
            
            /// <summary>�û����:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}
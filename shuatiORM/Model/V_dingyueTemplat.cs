/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/9/1 19:06:06
  Description:    ���ݱ�V_dingyueTemplat��Ӧ��ҵ���߼���V_dingyueTemplat
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� V_dingyueTemplat_Entity:V_dingyueTemplat
 * 
************************************************************/
/************************************************************
SQL���룺
select Appid,User_id,Dingyue_type,Dingyue_cond,Dingyue_appid,Is_delete,Createtime,Id,Openid from V_dingyueTemplat
delete from V_dingyueTemplat
INSERT INTO V_dingyueTemplat (Appid,User_id,Dingyue_type,Dingyue_cond,Dingyue_appid,Is_delete,Createtime,Id,Openid)
     VALUES
           ('','','','','','','','','')
UPDATE V_dingyueTemplat SET ...
������ֵ���룺
 *         valObj.Appid = valObj2.Appid;
        valObj.User_id = valObj2.User_id;
        valObj.Dingyue_type = valObj2.Dingyue_type;
        valObj.Dingyue_cond = valObj2.Dingyue_cond;
        valObj.Dingyue_appid = valObj2.Dingyue_appid;
        valObj.Is_delete = valObj2.Is_delete;
        valObj.Createtime = valObj2.Createtime;
        valObj.Id = valObj2.Id;
        valObj.Openid = valObj2.Openid; 
        valObj.Appid = "";
        valObj.User_id = "";
        valObj.Dingyue_type = "";
        valObj.Dingyue_cond = "";
        valObj.Dingyue_appid = "";
        valObj.Is_delete = "";
        valObj.Createtime = "";
        valObj.Id = "";
        valObj.Openid = ""; 
        "Appid": $("#txt_Appid").val(),
        "User_id": $("#txt_User_id").val(),
        "Dingyue_type": $("#txt_Dingyue_type").val(),
        "Dingyue_cond": $("#txt_Dingyue_cond").val(),
        "Dingyue_appid": $("#txt_Dingyue_appid").val(),
        "Is_delete": $("#txt_Is_delete").val(),
        "Createtime": $("#txt_Createtime").val(),
        "Id": $("#txt_Id").val(),
        "Openid": $("#txt_Openid").val(), 
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
    /// <para>������Ϣ__����Ȩ�ޱ�-�û���Ϣ����-unionid:[Inner-{TUser_dingyue:0},{UnionAuth:1}]</para>
    /// <para>��V_dingyueTemplat���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class V_dingyueTemplat : ITableImplement
    {
        /// <summary>��������  </summary>
        public static V_dingyueTemplat Factory()
        {
            return new V_dingyueTemplat();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Appid
        {            
            get { return this.Appid; }
            set { this.Appid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> ��������:[Enum-{Xb_teacher_resume:�ҽ�},{1:����}] Attribute_IsNotNull </summary>
        public string _Dingyue_type
        {            
            get { return this.Dingyue_type; }
            set { this.Dingyue_type = value; }
        }
        
        /// <summary> �������� sql��� Attribute_IsNotNull </summary>
        public string _Dingyue_cond
        {            
            get { return this.Dingyue_cond; }
            set { this.Dingyue_cond = value; }
        }
        
        /// <summary> ����APPID Attribute_IsNotNull </summary>
        public string _Dingyue_appid
        {            
            get { return this.Dingyue_appid; }
            set { this.Dingyue_appid = value; }
        }
        
        /// <summary> �Ƿ���,0û���� 1���� Attribute_IsNotNull </summary>
        public bool _Is_delete
        {            
            get { return this.Is_delete; }
            set { this.Is_delete = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Createtime
        {            
            get { return this.Createtime; }
            set { this.Createtime = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Openid
        {            
            get { return this.Openid; }
            set { this.Openid = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��������:[Enum-{Xb_teacher_resume:�ҽ�},{1:����}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Dingyue_type
        {
            get { return this.m_dingyue_type; }
            set //
            {
                if (!dingyue_type_initialized || m_dingyue_type != value)
                {
                    this.m_dingyue_type = value;
                }
                dingyue_type_initialized = true;
            }
        }
        
        /// <summary> �������� sql��䣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Dingyue_cond
        {
            get { return this.m_dingyue_cond; }
            set //
            {
                if (!dingyue_cond_initialized || m_dingyue_cond != value)
                {
                    this.m_dingyue_cond = value;
                }
                dingyue_cond_initialized = true;
            }
        }
        
        /// <summary> ����APPID���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Dingyue_appid
        {
            get { return this.m_dingyue_appid; }
            set //
            {
                if (!dingyue_appid_initialized || m_dingyue_appid != value)
                {
                    this.m_dingyue_appid = value;
                }
                dingyue_appid_initialized = true;
            }
        }
        
        /// <summary> �Ƿ���,0û���� 1���ģ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool Is_delete
        {
            get { return this.m_is_delete; }
            set //
            {
                if (!is_delete_initialized || m_is_delete != value)
                {
                    this.m_is_delete = value;
                }
                is_delete_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Createtime
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Id
        {
            get { return this.m_id; }
            set //
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary></summary>
            public static AttributeItem Appid =  new AttributeItem("[V_dingyueTemplat].[Appid]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[V_dingyueTemplat].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>��������:[Enum-{Xb_teacher_resume:�ҽ�},{1:����}]</summary>
            public static AttributeItem Dingyue_type =  new AttributeItem("[V_dingyueTemplat].[Dingyue_type]", typeof(string), 50, default(string));
            
            /// <summary>�������� sql���</summary>
            public static AttributeItem Dingyue_cond =  new AttributeItem("[V_dingyueTemplat].[Dingyue_cond]", typeof(string), 50, default(string));
            
            /// <summary>����APPID</summary>
            public static AttributeItem Dingyue_appid =  new AttributeItem("[V_dingyueTemplat].[Dingyue_appid]", typeof(string), 50, default(string));
            
            /// <summary>�Ƿ���,0û���� 1����</summary>
            public static AttributeItem Is_delete =  new AttributeItem("[V_dingyueTemplat].[Is_delete]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Createtime =  new AttributeItem("[V_dingyueTemplat].[Createtime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[V_dingyueTemplat].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Openid =  new AttributeItem("[V_dingyueTemplat].[Openid]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_appid;
        /// <summary></summary>
        protected bool appid_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_dingyue_type;
        /// <summary></summary>
        protected bool dingyue_type_initialized = false;
        
        private string m_dingyue_cond;
        /// <summary></summary>
        protected bool dingyue_cond_initialized = false;
        
        private string m_dingyue_appid;
        /// <summary></summary>
        protected bool dingyue_appid_initialized = false;
        
        private bool m_is_delete;
        /// <summary></summary>
        protected bool is_delete_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_dingyueTemplat";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.appid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.dingyue_type_initialized = IsLoadAllAttributes;this.dingyue_cond_initialized = IsLoadAllAttributes;this.dingyue_appid_initialized = IsLoadAllAttributes;this.is_delete_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_dingyueTemplat value = new V_dingyueTemplat();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Appid"))
				value.appid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dingyue_type"))
				value.dingyue_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dingyue_cond"))
				value.dingyue_cond_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dingyue_appid"))
				value.dingyue_appid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_delete"))
				value.is_delete_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Createtime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Openid"))
				value.openid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new V_dingyueTemplat Clone()
        {
            return (V_dingyueTemplat)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static V_dingyueTemplat()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public V_dingyueTemplat() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public V_dingyueTemplat(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public V_dingyueTemplat(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public V_dingyueTemplat(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public V_dingyueTemplat(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public V_dingyueTemplat(string appid1, Guid user_id1, string dingyue_type1, string dingyue_cond1, string dingyue_appid1, bool is_delete1, DateTime createtime1, int id1, string openid1)
        {
            
            this.Appid = appid1;
            
            this.User_id = user_id1;
            
            this.Dingyue_type = dingyue_type1;
            
            this.Dingyue_cond = dingyue_cond1;
            
            this.Dingyue_appid = dingyue_appid1;
            
            this.Is_delete = is_delete1;
            
            this.Createtime = createtime1;
            
            this.Id = id1;
            
            this.Openid = openid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static V_dingyueTemplat FromIView(IView view)
        {
            return (V_dingyueTemplat)IView.GetITable(view, "V_dingyueTemplat");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static V_dingyueTemplat GetOneInstance()
        {
            V_dingyueTemplat value = new V_dingyueTemplat();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public V_dingyueTemplat Retrieve()
        {
            BLLTable<V_dingyueTemplat>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Appid":
			        return Appid;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Dingyue_type":
			        return Dingyue_type;
			    			
			    case "Dingyue_cond":
			        return Dingyue_cond;
			    			
			    case "Dingyue_appid":
			        return Dingyue_appid;
			    			
			    case "Is_delete":
			        return Is_delete;
			    			
			    case "Createtime":
			        return Createtime;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Openid":
			        return Openid;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Appid":
			        this.Appid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Dingyue_type":
			        this.Dingyue_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dingyue_cond":
			        this.Dingyue_cond = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dingyue_appid":
			        this.Dingyue_appid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_delete":
			        this.Is_delete = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Createtime":
			        this.Createtime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Openid":
			        this.Openid = Convert.ToString(AttributeValue);
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
				case "Appid":
					return appid_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Dingyue_type":
					return dingyue_type_initialized;
				
				case "Dingyue_cond":
					return dingyue_cond_initialized;
				
				case "Dingyue_appid":
					return dingyue_appid_initialized;
				
				case "Is_delete":
					return is_delete_initialized;
				
				case "Createtime":
					return createtime_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Openid":
					return openid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Appid":
					appid_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Dingyue_type":
					dingyue_type_initialized = ret;
					return true;
				
				case "Dingyue_cond":
					dingyue_cond_initialized = ret;
					return true;
				
				case "Dingyue_appid":
					dingyue_appid_initialized = ret;
					return true;
				
				case "Is_delete":
					is_delete_initialized = ret;
					return true;
				
				case "Createtime":
					createtime_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Openid":
					openid_initialized = ret;
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

			
			if (appid_initialized)
			{
                AttributeItem attr = V_dingyueTemplat.Attribute.Appid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Appid);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = V_dingyueTemplat.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (dingyue_type_initialized)
			{
                AttributeItem attr = V_dingyueTemplat.Attribute.Dingyue_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dingyue_type);
                }
			}
			
			if (dingyue_cond_initialized)
			{
                AttributeItem attr = V_dingyueTemplat.Attribute.Dingyue_cond;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dingyue_cond);
                }
			}
			
			if (dingyue_appid_initialized)
			{
                AttributeItem attr = V_dingyueTemplat.Attribute.Dingyue_appid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dingyue_appid);
                }
			}
			
			if (is_delete_initialized)
			{
                AttributeItem attr = V_dingyueTemplat.Attribute.Is_delete;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_delete);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = V_dingyueTemplat.Attribute.Createtime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Createtime);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = V_dingyueTemplat.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = V_dingyueTemplat.Attribute.Openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Openid);
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
        public class V_dingyueTemplatJson
        {
            
            /// <summary></summary>
            public string Appid { get; set; }
            
            /// <summary></summary>
            public Guid User_id { get; set; }
            
            /// <summary>��������:[Enum-{Xb_teacher_resume:�ҽ�},{1:����}]</summary>
            public string Dingyue_type { get; set; }
            
            /// <summary>�������� sql���</summary>
            public string Dingyue_cond { get; set; }
            
            /// <summary>����APPID</summary>
            public string Dingyue_appid { get; set; }
            
            /// <summary>�Ƿ���,0û���� 1����</summary>
            public bool Is_delete { get; set; }
            
            /// <summary></summary>
            public DateTime Createtime { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public string Openid { get; set; }
        }
        #endregion
    }
}
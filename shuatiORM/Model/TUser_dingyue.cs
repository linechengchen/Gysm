/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/8/31 15:27:54
  Description:    ���ݱ�TUser_dingyue��Ӧ��ҵ���߼���TUser_dingyue
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TUser_dingyue_Entity:TUser_dingyue
 * 
************************************************************/
/************************************************************
SQL���룺
select Createtime,Dingyue_appid,Dingyue_cond,Dingyue_type,Id,Is_delete,User_id,Uuid from TUser_dingyue
delete from TUser_dingyue
INSERT INTO TUser_dingyue (Createtime,Dingyue_appid,Dingyue_cond,Dingyue_type,Id,Is_delete,User_id,Uuid)
     VALUES
           ('','','','','','','','')
UPDATE TUser_dingyue SET ...
������ֵ���룺
 *         valObj.Createtime = valObj2.Createtime;
        valObj.Dingyue_appid = valObj2.Dingyue_appid;
        valObj.Dingyue_cond = valObj2.Dingyue_cond;
        valObj.Dingyue_type = valObj2.Dingyue_type;
        valObj.Id = valObj2.Id;
        valObj.Is_delete = valObj2.Is_delete;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Createtime = "";
        valObj.Dingyue_appid = "";
        valObj.Dingyue_cond = "";
        valObj.Dingyue_type = "";
        valObj.Id = "";
        valObj.Is_delete = "";
        valObj.User_id = "";
        valObj.Uuid = ""; 
        "Createtime": $("#txt_Createtime").val(),
        "Dingyue_appid": $("#txt_Dingyue_appid").val(),
        "Dingyue_cond": $("#txt_Dingyue_cond").val(),
        "Dingyue_type": $("#txt_Dingyue_type").val(),
        "Id": $("#txt_Id").val(),
        "Is_delete": $("#txt_Is_delete").val(),
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
    /// <para>������Ϣ</para>
    /// <para>��TUser_dingyue���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TUser_dingyue : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TUser_dingyue Factory()
        {
            return new TUser_dingyue();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Createtime
        {            
            get { return this.Createtime; }
            set { this.Createtime = value; }
        }
        
        /// <summary> ����APPID Attribute_IsNotNull </summary>
        public string _Dingyue_appid
        {            
            get { return this.Dingyue_appid; }
            set { this.Dingyue_appid = value; }
        }
        
        /// <summary> �������� sql��� Attribute_IsNotNull </summary>
        public string _Dingyue_cond
        {            
            get { return this.Dingyue_cond; }
            set { this.Dingyue_cond = value; }
        }
        
        /// <summary> ��������:[Enum-{Xb_teacher_resume:�ҽ�},{1:����}] Attribute_IsNotNull </summary>
        public string _Dingyue_type
        {            
            get { return this.Dingyue_type; }
            set { this.Dingyue_type = value; }
        }
        
        /// <summary>  Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �Ƿ�ɾ����0ɾ�� 1���� Attribute_IsNotNull </summary>
        public bool _Is_delete
        {            
            get { return this.Is_delete; }
            set { this.Is_delete = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ�ɾ����0ɾ�� 1���ڣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
            
            /// <summary></summary>
            public static AttributeItem Createtime =  new AttributeItem("[TUser_dingyue].[Createtime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����APPID</summary>
            public static AttributeItem Dingyue_appid =  new AttributeItem("[TUser_dingyue].[Dingyue_appid]", typeof(string), 50, default(string));
            
            /// <summary>�������� sql���</summary>
            public static AttributeItem Dingyue_cond =  new AttributeItem("[TUser_dingyue].[Dingyue_cond]", typeof(string), 50, default(string));
            
            /// <summary>��������:[Enum-{Xb_teacher_resume:�ҽ�},{1:����}]</summary>
            public static AttributeItem Dingyue_type =  new AttributeItem("[TUser_dingyue].[Dingyue_type]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[TUser_dingyue].[Id]", typeof(int), 4, default(int));
            
            /// <summary>�Ƿ�ɾ����0ɾ�� 1����</summary>
            public static AttributeItem Is_delete =  new AttributeItem("[TUser_dingyue].[Is_delete]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[TUser_dingyue].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[TUser_dingyue].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_dingyue_appid;
        /// <summary></summary>
        protected bool dingyue_appid_initialized = false;
        
        private string m_dingyue_cond;
        /// <summary></summary>
        protected bool dingyue_cond_initialized = false;
        
        private string m_dingyue_type;
        /// <summary></summary>
        protected bool dingyue_type_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private bool m_is_delete;
        /// <summary></summary>
        protected bool is_delete_initialized = false;
        
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
            return "TUser_dingyue";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.createtime_initialized = IsLoadAllAttributes;this.dingyue_appid_initialized = IsLoadAllAttributes;this.dingyue_cond_initialized = IsLoadAllAttributes;this.dingyue_type_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.is_delete_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TUser_dingyue value = new TUser_dingyue();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Createtime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dingyue_appid"))
				value.dingyue_appid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dingyue_cond"))
				value.dingyue_cond_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dingyue_type"))
				value.dingyue_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_delete"))
				value.is_delete_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TUser_dingyue Clone()
        {
            return (TUser_dingyue)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TUser_dingyue()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TUser_dingyue() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TUser_dingyue(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TUser_dingyue(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TUser_dingyue(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TUser_dingyue(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TUser_dingyue(DateTime createtime1, string dingyue_appid1, string dingyue_cond1, string dingyue_type1, int id1, bool is_delete1, Guid user_id1, Guid uuid1)
        {
            
            this.Createtime = createtime1;
            
            this.Dingyue_appid = dingyue_appid1;
            
            this.Dingyue_cond = dingyue_cond1;
            
            this.Dingyue_type = dingyue_type1;
            
            this.Id = id1;
            
            this.Is_delete = is_delete1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TUser_dingyue FromIView(IView view)
        {
            return (TUser_dingyue)IView.GetITable(view, "TUser_dingyue");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TUser_dingyue GetOneInstance()
        {
            TUser_dingyue value = new TUser_dingyue();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TUser_dingyue Retrieve()
        {
            BLLTable<TUser_dingyue>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Createtime":
			        return Createtime;
			    			
			    case "Dingyue_appid":
			        return Dingyue_appid;
			    			
			    case "Dingyue_cond":
			        return Dingyue_cond;
			    			
			    case "Dingyue_type":
			        return Dingyue_type;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Is_delete":
			        return Is_delete;
			    			
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
			    case "Createtime":
			        this.Createtime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Dingyue_appid":
			        this.Dingyue_appid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dingyue_cond":
			        this.Dingyue_cond = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dingyue_type":
			        this.Dingyue_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Is_delete":
			        this.Is_delete = Convert.ToBoolean(AttributeValue);
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
				case "Createtime":
					return createtime_initialized;
				
				case "Dingyue_appid":
					return dingyue_appid_initialized;
				
				case "Dingyue_cond":
					return dingyue_cond_initialized;
				
				case "Dingyue_type":
					return dingyue_type_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Is_delete":
					return is_delete_initialized;
				
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
				case "Createtime":
					createtime_initialized = ret;
					return true;
				
				case "Dingyue_appid":
					dingyue_appid_initialized = ret;
					return true;
				
				case "Dingyue_cond":
					dingyue_cond_initialized = ret;
					return true;
				
				case "Dingyue_type":
					dingyue_type_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Is_delete":
					is_delete_initialized = ret;
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

			
			if (createtime_initialized)
			{
                AttributeItem attr = TUser_dingyue.Attribute.Createtime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Createtime);
                }
			}
			
			if (dingyue_appid_initialized)
			{
                AttributeItem attr = TUser_dingyue.Attribute.Dingyue_appid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dingyue_appid);
                }
			}
			
			if (dingyue_cond_initialized)
			{
                AttributeItem attr = TUser_dingyue.Attribute.Dingyue_cond;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dingyue_cond);
                }
			}
			
			if (dingyue_type_initialized)
			{
                AttributeItem attr = TUser_dingyue.Attribute.Dingyue_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dingyue_type);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = TUser_dingyue.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (is_delete_initialized)
			{
                AttributeItem attr = TUser_dingyue.Attribute.Is_delete;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_delete);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = TUser_dingyue.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = TUser_dingyue.Attribute.Uuid;
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
        public class TUser_dingyueJson
        {
            
            /// <summary></summary>
            public DateTime Createtime { get; set; }
            
            /// <summary>����APPID</summary>
            public string Dingyue_appid { get; set; }
            
            /// <summary>�������� sql���</summary>
            public string Dingyue_cond { get; set; }
            
            /// <summary>��������:[Enum-{Xb_teacher_resume:�ҽ�},{1:����}]</summary>
            public string Dingyue_type { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary>�Ƿ�ɾ����0ɾ�� 1����</summary>
            public bool Is_delete { get; set; }
            
            /// <summary></summary>
            public Guid User_id { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:40
  Description:    ���ݱ�St_TUserZsInfo2��Ӧ��ҵ���߼���St_TUserZsInfo2
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� St_TUserZsInfo2_Entity:St_TUserZsInfo2
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,CreateTime,KemuInfoJson,OpenId,UserId,ZsInfoJson from St_TUserZsInfo2
delete from St_TUserZsInfo2
INSERT INTO St_TUserZsInfo2 (Id,CreateTime,KemuInfoJson,OpenId,UserId,ZsInfoJson)
     VALUES
           ('','','','','','')
UPDATE St_TUserZsInfo2 SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.KemuInfoJson = valObj2.KemuInfoJson;
        valObj.OpenId = valObj2.OpenId;
        valObj.UserId = valObj2.UserId;
        valObj.ZsInfoJson = valObj2.ZsInfoJson; 
        valObj.Id = "";
        valObj.CreateTime = "";
        valObj.KemuInfoJson = "";
        valObj.OpenId = "";
        valObj.UserId = "";
        valObj.ZsInfoJson = ""; 
        "Id": $("#txt_Id").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "KemuInfoJson": $("#txt_KemuInfoJson").val(),
        "OpenId": $("#txt_OpenId").val(),
        "UserId": $("#txt_UserId").val(),
        "ZsInfoJson": $("#txt_ZsInfoJson").val(), 
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
    /// <para>ZST�û���Ϣ</para>
    /// <para>��St_TUserZsInfo2���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class St_TUserZsInfo2 : ITableImplement
    {
        /// <summary>��������  </summary>
        public static St_TUserZsInfo2 Factory()
        {
            return new St_TUserZsInfo2();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> ��Ŀ��ϢJSON:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KemuInfoJson
        {            
            get { return this.KemuInfoJson; }
            set { this.KemuInfoJson = value; }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UserId
        {            
            get { return this.UserId; }
            set { this.UserId = value; }
        }
        
        /// <summary> ZS��ϢJSON:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsInfoJson
        {            
            get { return this.ZsInfoJson; }
            set { this.ZsInfoJson = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��Ŀ��ϢJSON:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string KemuInfoJson
        {
            get { return this.m_kemuinfojson; }
            set //
            {
                if (!kemuinfojson_initialized || m_kemuinfojson != value)
                {
                    this.m_kemuinfojson = value;
                }
                kemuinfojson_initialized = true;
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
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string UserId
        {
            get { return this.m_userid; }
            set //
            {
                if (!userid_initialized || m_userid != value)
                {
                    this.m_userid = value;
                }
                userid_initialized = true;
            }
        }
        
        /// <summary> ZS��ϢJSON:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ZsInfoJson
        {
            get { return this.m_zsinfojson; }
            set //
            {
                if (!zsinfojson_initialized || m_zsinfojson != value)
                {
                    this.m_zsinfojson = value;
                }
                zsinfojson_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_TUserZsInfo2].[Id]", typeof(int), 4, default(int));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[St_TUserZsInfo2].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>��Ŀ��ϢJSON:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuInfoJson =  new AttributeItem("[St_TUserZsInfo2].[KemuInfoJson]", typeof(string), -1, default(string));
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[St_TUserZsInfo2].[OpenId]", typeof(string), 50, default(string));
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserId =  new AttributeItem("[St_TUserZsInfo2].[UserId]", typeof(string), 50, default(string));
            
            /// <summary>ZS��ϢJSON:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsInfoJson =  new AttributeItem("[St_TUserZsInfo2].[ZsInfoJson]", typeof(string), -1, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_kemuinfojson;
        /// <summary></summary>
        protected bool kemuinfojson_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_userid;
        /// <summary></summary>
        protected bool userid_initialized = false;
        
        private string m_zsinfojson;
        /// <summary></summary>
        protected bool zsinfojson_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TUserZsInfo2";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.kemuinfojson_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.userid_initialized = IsLoadAllAttributes;this.zsinfojson_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TUserZsInfo2 value = new St_TUserZsInfo2();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuInfoJson"))
				value.kemuinfojson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserId"))
				value.userid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsInfoJson"))
				value.zsinfojson_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new St_TUserZsInfo2 Clone()
        {
            return (St_TUserZsInfo2)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static St_TUserZsInfo2()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public St_TUserZsInfo2() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public St_TUserZsInfo2(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public St_TUserZsInfo2(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public St_TUserZsInfo2(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public St_TUserZsInfo2(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public St_TUserZsInfo2(int id1, DateTime createtime1, string kemuinfojson1, string openid1, string userid1, string zsinfojson1)
        {
            
            this.Id = id1;
            
            this.CreateTime = createtime1;
            
            this.KemuInfoJson = kemuinfojson1;
            
            this.OpenId = openid1;
            
            this.UserId = userid1;
            
            this.ZsInfoJson = zsinfojson1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static St_TUserZsInfo2 FromIView(IView view)
        {
            return (St_TUserZsInfo2)IView.GetITable(view, "St_TUserZsInfo2");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static St_TUserZsInfo2 GetOneInstance()
        {
            St_TUserZsInfo2 value = new St_TUserZsInfo2();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public St_TUserZsInfo2 Retrieve()
        {
            BLLTable<St_TUserZsInfo2>.GetRowData(this);
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
			    			
			    case "KemuInfoJson":
			        return KemuInfoJson;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "UserId":
			        return UserId;
			    			
			    case "ZsInfoJson":
			        return ZsInfoJson;
			
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
			    			
			    case "KemuInfoJson":
			        this.KemuInfoJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UserId":
			        this.UserId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsInfoJson":
			        this.ZsInfoJson = Convert.ToString(AttributeValue);
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
				
				case "KemuInfoJson":
					return kemuinfojson_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "UserId":
					return userid_initialized;
				
				case "ZsInfoJson":
					return zsinfojson_initialized;
				
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
				
				case "KemuInfoJson":
					kemuinfojson_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "UserId":
					userid_initialized = ret;
					return true;
				
				case "ZsInfoJson":
					zsinfojson_initialized = ret;
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
                AttributeItem attr = St_TUserZsInfo2.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (kemuinfojson_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.KemuInfoJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuInfoJson);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (userid_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.UserId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserId);
                }
			}
			
			if (zsinfojson_initialized)
			{
                AttributeItem attr = St_TUserZsInfo2.Attribute.ZsInfoJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsInfoJson);
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
        public class St_TUserZsInfo2Json
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>��Ŀ��ϢJSON:[CtrlTypeDic-{InputString}]</summary>
            public string KemuInfoJson { get; set; }
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public string UserId { get; set; }
            
            /// <summary>ZS��ϢJSON:[CtrlTypeDic-{InputString}]</summary>
            public string ZsInfoJson { get; set; }
        }
        #endregion
    }
}
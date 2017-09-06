/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:22
  Description:    ���ݱ�Xb_product_type_feature��Ӧ��ҵ���߼���Xb_product_type_feature
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_product_type_feature_Entity:Xb_product_type_feature
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,CreateTime,Items,ModifyTime,Subject,Uuid,Xb_product_type_id from Xb_product_type_feature
delete from Xb_product_type_feature
INSERT INTO Xb_product_type_feature (Id,CreateTime,Items,ModifyTime,Subject,Uuid,Xb_product_type_id)
     VALUES
           ('','','','','','','')
UPDATE Xb_product_type_feature SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Items = valObj2.Items;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Subject = valObj2.Subject;
        valObj.Uuid = valObj2.Uuid;
        valObj.Xb_product_type_id = valObj2.Xb_product_type_id; 
        valObj.Id = "";
        valObj.CreateTime = "";
        valObj.Items = "";
        valObj.ModifyTime = "";
        valObj.Subject = "";
        valObj.Uuid = "";
        valObj.Xb_product_type_id = ""; 
        "Id": $("#txt_Id").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Items": $("#txt_Items").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Subject": $("#txt_Subject").val(),
        "Uuid": $("#txt_Uuid").val(),
        "Xb_product_type_id": $("#txt_Xb_product_type_id").val(), 
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
    /// <para>�ײ���ɫ�������֣��������</para>
    /// <para>��Xb_product_type_feature���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_product_type_feature : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_product_type_feature Factory()
        {
            return new Xb_product_type_feature();
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
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Items
        {            
            get { return this.Items; }
            set { this.Items = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Subject
        {            
            get { return this.Subject; }
            set { this.Subject = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> �ײ�����id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Xb_product_type_id
        {            
            get { return this.Xb_product_type_id; }
            set { this.Xb_product_type_id = value; }
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
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Items
        {
            get { return this.m_items; }
            set //
            {
                if (!items_initialized || m_items != value)
                {
                    this.m_items = value;
                }
                items_initialized = true;
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
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Subject
        {
            get { return this.m_subject; }
            set //
            {
                if (!subject_initialized || m_subject != value)
                {
                    this.m_subject = value;
                }
                subject_initialized = true;
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
        
        /// <summary> �ײ�����id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Xb_product_type_id
        {
            get { return this.m_xb_product_type_id; }
            set //
            {
                if (!xb_product_type_id_initialized || m_xb_product_type_id != value)
                {
                    this.m_xb_product_type_id = value;
                }
                xb_product_type_id_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_product_type_feature].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_product_type_feature].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Items =  new AttributeItem("[Xb_product_type_feature].[Items]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_product_type_feature].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Subject =  new AttributeItem("[Xb_product_type_feature].[Subject]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_product_type_feature].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>�ײ�����id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Xb_product_type_id =  new AttributeItem("[Xb_product_type_feature].[Xb_product_type_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_items;
        /// <summary></summary>
        protected bool items_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_subject;
        /// <summary></summary>
        protected bool subject_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_xb_product_type_id;
        /// <summary></summary>
        protected bool xb_product_type_id_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_product_type_feature";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.items_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.subject_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.xb_product_type_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_product_type_feature value = new Xb_product_type_feature();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Items"))
				value.items_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Subject"))
				value.subject_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Xb_product_type_id"))
				value.xb_product_type_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_product_type_feature Clone()
        {
            return (Xb_product_type_feature)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_product_type_feature()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_product_type_feature() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_product_type_feature(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_product_type_feature(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_product_type_feature(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_product_type_feature(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_product_type_feature(int id1, DateTime createtime1, string items1, DateTime modifytime1, string subject1, Guid uuid1, string xb_product_type_id1)
        {
            
            this.Id = id1;
            
            this.CreateTime = createtime1;
            
            this.Items = items1;
            
            this.ModifyTime = modifytime1;
            
            this.Subject = subject1;
            
            this.Uuid = uuid1;
            
            this.Xb_product_type_id = xb_product_type_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_product_type_feature FromIView(IView view)
        {
            return (Xb_product_type_feature)IView.GetITable(view, "Xb_product_type_feature");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_product_type_feature GetOneInstance()
        {
            Xb_product_type_feature value = new Xb_product_type_feature();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_product_type_feature Retrieve()
        {
            BLLTable<Xb_product_type_feature>.GetRowData(this);
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
			    			
			    case "Items":
			        return Items;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Subject":
			        return Subject;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "Xb_product_type_id":
			        return Xb_product_type_id;
			
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
			    			
			    case "Items":
			        this.Items = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Subject":
			        this.Subject = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Xb_product_type_id":
			        this.Xb_product_type_id = Convert.ToString(AttributeValue);
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
				
				case "Items":
					return items_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Subject":
					return subject_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "Xb_product_type_id":
					return xb_product_type_id_initialized;
				
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
				
				case "Items":
					items_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Subject":
					subject_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Xb_product_type_id":
					xb_product_type_id_initialized = ret;
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
                AttributeItem attr = Xb_product_type_feature.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_product_type_feature.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (items_initialized)
			{
                AttributeItem attr = Xb_product_type_feature.Attribute.Items;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Items);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_product_type_feature.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (subject_initialized)
			{
                AttributeItem attr = Xb_product_type_feature.Attribute.Subject;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Subject);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_product_type_feature.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (xb_product_type_id_initialized)
			{
                AttributeItem attr = Xb_product_type_feature.Attribute.Xb_product_type_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Xb_product_type_id);
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
        public class Xb_product_type_featureJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string Items { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string Subject { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>�ײ�����id:[CtrlTypeDic-{InputString}]</summary>
            public string Xb_product_type_id { get; set; }
        }
        #endregion
    }
}
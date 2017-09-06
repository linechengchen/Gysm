/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/7/14 11:53:08
  Description:    ���ݱ�Xb_product_type��Ӧ��ҵ���߼���Xb_product_type
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_product_type_Entity:Xb_product_type
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Code,CreateTime,Desc,Feature_title,ModifyTime,Title,Type,Uuid from Xb_product_type
delete from Xb_product_type
INSERT INTO Xb_product_type (Id,Code,CreateTime,Desc,Feature_title,ModifyTime,Title,Type,Uuid)
     VALUES
           ('','','','','','','','','')
UPDATE Xb_product_type SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Code = valObj2.Code;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Desc = valObj2.Desc;
        valObj.Feature_title = valObj2.Feature_title;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Title = valObj2.Title;
        valObj.Type = valObj2.Type;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.Code = "";
        valObj.CreateTime = "";
        valObj.Desc = "";
        valObj.Feature_title = "";
        valObj.ModifyTime = "";
        valObj.Title = "";
        valObj.Type = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "Code": $("#txt_Code").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Desc": $("#txt_Desc").val(),
        "Feature_title": $("#txt_Feature_title").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Title": $("#txt_Title").val(),
        "Type": $("#txt_Type").val(),
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
    /// <para>��Xb_product_type���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_product_type : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_product_type Factory()
        {
            return new Xb_product_type();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ���루û�ã�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Code
        {            
            get { return this.Code; }
            set { this.Code = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Desc
        {            
            get { return this.Desc; }
            set { this.Desc = value; }
        }
        
        /// <summary> ��ɫ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Feature_title
        {            
            get { return this.Feature_title; }
            set { this.Feature_title = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> �༶����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
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
        
        /// <summary> ���루û�ã�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Code
        {
            get { return this.m_code; }
            set //
            {
                if (!code_initialized || m_code != value)
                {
                    this.m_code = value;
                }
                code_initialized = true;
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
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Desc
        {
            get { return this.m_desc; }
            set //
            {
                if (!desc_initialized || m_desc != value)
                {
                    this.m_desc = value;
                }
                desc_initialized = true;
            }
        }
        
        /// <summary> ��ɫ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Feature_title
        {
            get { return this.m_feature_title; }
            set //
            {
                if (!feature_title_initialized || m_feature_title != value)
                {
                    this.m_feature_title = value;
                }
                feature_title_initialized = true;
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
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Title
        {
            get { return this.m_title; }
            set //
            {
                if (!title_initialized || m_title != value)
                {
                    this.m_title = value;
                }
                title_initialized = true;
            }
        }
        
        /// <summary> �༶����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Type
        {
            get { return this.m_type; }
            set //
            {
                if (!type_initialized || m_type != value)
                {
                    this.m_type = value;
                }
                type_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_product_type].[Id]", typeof(int), 4, default(int));
            
            /// <summary>���루û�ã�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Code =  new AttributeItem("[Xb_product_type].[Code]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_product_type].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Desc =  new AttributeItem("[Xb_product_type].[Desc]", typeof(string), 100, default(string));
            
            /// <summary>��ɫ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Feature_title =  new AttributeItem("[Xb_product_type].[Feature_title]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_product_type].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xb_product_type].[Title]", typeof(string), 100, default(string));
            
            /// <summary>�༶����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xb_product_type].[Type]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_product_type].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_code;
        /// <summary></summary>
        protected bool code_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_desc;
        /// <summary></summary>
        protected bool desc_initialized = false;
        
        private string m_feature_title;
        /// <summary></summary>
        protected bool feature_title_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private string m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        
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
            return "Xb_product_type";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.code_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.desc_initialized = IsLoadAllAttributes;this.feature_title_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_product_type value = new Xb_product_type();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Code"))
				value.code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Desc"))
				value.desc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Feature_title"))
				value.feature_title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_product_type Clone()
        {
            return (Xb_product_type)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_product_type()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_product_type() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_product_type(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_product_type(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_product_type(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_product_type(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_product_type(int id1, int code1, DateTime createtime1, string desc1, string feature_title1, DateTime modifytime1, string title1, string type1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.Code = code1;
            
            this.CreateTime = createtime1;
            
            this.Desc = desc1;
            
            this.Feature_title = feature_title1;
            
            this.ModifyTime = modifytime1;
            
            this.Title = title1;
            
            this.Type = type1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_product_type FromIView(IView view)
        {
            return (Xb_product_type)IView.GetITable(view, "Xb_product_type");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_product_type GetOneInstance()
        {
            Xb_product_type value = new Xb_product_type();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_product_type Retrieve()
        {
            BLLTable<Xb_product_type>.GetRowData(this);
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
			    			
			    case "Code":
			        return Code;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Desc":
			        return Desc;
			    			
			    case "Feature_title":
			        return Feature_title;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Title":
			        return Title;
			    			
			    case "Type":
			        return Type;
			    			
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
			    			
			    case "Code":
			        this.Code = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Desc":
			        this.Desc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Feature_title":
			        this.Feature_title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToString(AttributeValue);
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
				
				case "Code":
					return code_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Desc":
					return desc_initialized;
				
				case "Feature_title":
					return feature_title_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Title":
					return title_initialized;
				
				case "Type":
					return type_initialized;
				
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
				
				case "Code":
					code_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Desc":
					desc_initialized = ret;
					return true;
				
				case "Feature_title":
					feature_title_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
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
                AttributeItem attr = Xb_product_type.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (code_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Code);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (desc_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Desc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Desc);
                }
			}
			
			if (feature_title_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Feature_title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Feature_title);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_product_type.Attribute.Uuid;
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
        public class Xb_product_typeJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>���루û�ã�:[CtrlTypeDic-{InputString}]</summary>
            public int Code { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Desc { get; set; }
            
            /// <summary>��ɫ����:[CtrlTypeDic-{InputString}]</summary>
            public string Feature_title { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>�༶����:[CtrlTypeDic-{InputString}]</summary>
            public string Type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
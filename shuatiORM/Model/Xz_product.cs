/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/22 18:01:02
  Description:    ���ݱ�Xz_product��Ӧ��ҵ���߼���Xz_product
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xz_product_Entity:Xz_product
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,City_id,College_area_id,Create_by,E_wei_ma,Is_one_price,Is_saled,Look_sum,Pics,School_id,Tags,Title,Uuid from Xz_product
delete from Xz_product
INSERT INTO Xz_product (Id,City_id,College_area_id,Create_by,E_wei_ma,Is_one_price,Is_saled,Look_sum,Pics,School_id,Tags,Title,Uuid)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE Xz_product SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.City_id = valObj2.City_id;
        valObj.College_area_id = valObj2.College_area_id;
        valObj.Create_by = valObj2.Create_by;
        valObj.E_wei_ma = valObj2.E_wei_ma;
        valObj.Is_one_price = valObj2.Is_one_price;
        valObj.Is_saled = valObj2.Is_saled;
        valObj.Look_sum = valObj2.Look_sum;
        valObj.Pics = valObj2.Pics;
        valObj.School_id = valObj2.School_id;
        valObj.Tags = valObj2.Tags;
        valObj.Title = valObj2.Title;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.City_id = "";
        valObj.College_area_id = "";
        valObj.Create_by = "";
        valObj.E_wei_ma = "";
        valObj.Is_one_price = "";
        valObj.Is_saled = "";
        valObj.Look_sum = "";
        valObj.Pics = "";
        valObj.School_id = "";
        valObj.Tags = "";
        valObj.Title = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "City_id": $("#txt_City_id").val(),
        "College_area_id": $("#txt_College_area_id").val(),
        "Create_by": $("#txt_Create_by").val(),
        "E_wei_ma": $("#txt_E_wei_ma").val(),
        "Is_one_price": $("#txt_Is_one_price").val(),
        "Is_saled": $("#txt_Is_saled").val(),
        "Look_sum": $("#txt_Look_sum").val(),
        "Pics": $("#txt_Pics").val(),
        "School_id": $("#txt_School_id").val(),
        "Tags": $("#txt_Tags").val(),
        "Title": $("#txt_Title").val(),
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
    /// <para>��Xz_product���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xz_product : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xz_product Factory()
        {
            return new Xz_product();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
        }
        
        /// <summary> ��ѧ��id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _College_area_id
        {            
            get { return this.College_area_id; }
            set { this.College_area_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by
        {            
            get { return this.Create_by; }
            set { this.Create_by = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _E_wei_ma
        {            
            get { return this.E_wei_ma; }
            set { this.E_wei_ma = value; }
        }
        
        /// <summary> �Ƿ�һ�ڼ�:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _Is_one_price
        {            
            get { return this.Is_one_price; }
            set { this.Is_one_price = value; }
        }
        
        /// <summary> ����״̬:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Is_saled
        {            
            get { return this.Is_saled; }
            set { this.Is_saled = value; }
        }
        
        /// <summary> �������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Look_sum
        {            
            get { return this.Look_sum; }
            set { this.Look_sum = value; }
        }
        
        /// <summary> ������ƷͼƬ:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _Pics
        {            
            get { return this.Pics; }
            set { this.Pics = value; }
        }
        
        /// <summary> ѧУid:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _School_id
        {            
            get { return this.School_id; }
            set { this.School_id = value; }
        }
        
        /// <summary> ��ǩ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Tags
        {            
            get { return this.Tags; }
            set { this.Tags = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
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
        
        /// <summary> ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string City_id
        {
            get { return this.m_city_id; }
            set //
            {
                if (!city_id_initialized || m_city_id != value)
                {
                    this.m_city_id = value;
                }
                city_id_initialized = true;
            }
        }
        
        /// <summary> ��ѧ��id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string College_area_id
        {
            get { return this.m_college_area_id; }
            set //
            {
                if (!college_area_id_initialized || m_college_area_id != value)
                {
                    this.m_college_area_id = value;
                }
                college_area_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Create_by
        {
            get { return this.m_create_by; }
            set //
            {
                if (!create_by_initialized || m_create_by != value)
                {
                    this.m_create_by = value;
                }
                create_by_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string E_wei_ma
        {
            get { return this.m_e_wei_ma; }
            set //
            {
                if (!e_wei_ma_initialized || m_e_wei_ma != value)
                {
                    this.m_e_wei_ma = value;
                }
                e_wei_ma_initialized = true;
            }
        }
        
        /// <summary> �Ƿ�һ�ڼ�:[CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool Is_one_price
        {
            get { return this.m_is_one_price; }
            set //
            {
                if (!is_one_price_initialized || m_is_one_price != value)
                {
                    this.m_is_one_price = value;
                }
                is_one_price_initialized = true;
            }
        }
        
        /// <summary> ����״̬:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Is_saled
        {
            get { return this.m_is_saled; }
            set //
            {
                if (!is_saled_initialized || m_is_saled != value)
                {
                    this.m_is_saled = value;
                }
                is_saled_initialized = true;
            }
        }
        
        /// <summary> �������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Look_sum
        {
            get { return this.m_look_sum; }
            set //
            {
                if (!look_sum_initialized || m_look_sum != value)
                {
                    this.m_look_sum = value;
                }
                look_sum_initialized = true;
            }
        }
        
        /// <summary> ������ƷͼƬ:[CtrlTypeDic-{HTML}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Pics
        {
            get { return this.m_pics; }
            set //
            {
                if (!pics_initialized || m_pics != value)
                {
                    this.m_pics = value;
                }
                pics_initialized = true;
            }
        }
        
        /// <summary> ѧУid:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string School_id
        {
            get { return this.m_school_id; }
            set //
            {
                if (!school_id_initialized || m_school_id != value)
                {
                    this.m_school_id = value;
                }
                school_id_initialized = true;
            }
        }
        
        /// <summary> ��ǩ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Tags
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
        
        /// <summary> ����:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
            public static AttributeItem Id =  new AttributeItem("[Xz_product].[Id]", typeof(int), 4, default(int));
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_id =  new AttributeItem("[Xz_product].[City_id]", typeof(string), 50, default(string));
            
            /// <summary>��ѧ��id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem College_area_id =  new AttributeItem("[Xz_product].[College_area_id]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by =  new AttributeItem("[Xz_product].[Create_by]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem E_wei_ma =  new AttributeItem("[Xz_product].[E_wei_ma]", typeof(string), 200, default(string));
            
            /// <summary>�Ƿ�һ�ڼ�:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Is_one_price =  new AttributeItem("[Xz_product].[Is_one_price]", typeof(bool), 1, default(bool));
            
            /// <summary>����״̬:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_saled =  new AttributeItem("[Xz_product].[Is_saled]", typeof(int), 4, default(int));
            
            /// <summary>�������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Look_sum =  new AttributeItem("[Xz_product].[Look_sum]", typeof(int), 4, default(int));
            
            /// <summary>������ƷͼƬ:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem Pics =  new AttributeItem("[Xz_product].[Pics]", typeof(string), 2000, default(string));
            
            /// <summary>ѧУid:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_id =  new AttributeItem("[Xz_product].[School_id]", typeof(string), 50, default(string));
            
            /// <summary>��ǩ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Tags =  new AttributeItem("[Xz_product].[Tags]", typeof(int), 4, default(int));
            
            /// <summary>����:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xz_product].[Title]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xz_product].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        
        private string m_college_area_id;
        /// <summary></summary>
        protected bool college_area_id_initialized = false;
        
        private string m_create_by;
        /// <summary></summary>
        protected bool create_by_initialized = false;
        
        private string m_e_wei_ma;
        /// <summary></summary>
        protected bool e_wei_ma_initialized = false;
        
        private bool m_is_one_price;
        /// <summary></summary>
        protected bool is_one_price_initialized = false;
        
        private int m_is_saled;
        /// <summary></summary>
        protected bool is_saled_initialized = false;
        
        private int m_look_sum;
        /// <summary></summary>
        protected bool look_sum_initialized = false;
        
        private string m_pics;
        /// <summary></summary>
        protected bool pics_initialized = false;
        
        private string m_school_id;
        /// <summary></summary>
        protected bool school_id_initialized = false;
        
        private int m_tags;
        /// <summary></summary>
        protected bool tags_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
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
            return "Xz_product";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;this.college_area_id_initialized = IsLoadAllAttributes;this.create_by_initialized = IsLoadAllAttributes;this.e_wei_ma_initialized = IsLoadAllAttributes;this.is_one_price_initialized = IsLoadAllAttributes;this.is_saled_initialized = IsLoadAllAttributes;this.look_sum_initialized = IsLoadAllAttributes;this.pics_initialized = IsLoadAllAttributes;this.school_id_initialized = IsLoadAllAttributes;this.tags_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xz_product value = new Xz_product();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College_area_id"))
				value.college_area_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by"))
				value.create_by_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"E_wei_ma"))
				value.e_wei_ma_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_one_price"))
				value.is_one_price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_saled"))
				value.is_saled_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Look_sum"))
				value.look_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pics"))
				value.pics_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_id"))
				value.school_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Tags"))
				value.tags_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xz_product Clone()
        {
            return (Xz_product)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xz_product()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xz_product() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xz_product(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xz_product(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xz_product(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xz_product(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xz_product(int id1, string city_id1, string college_area_id1, string create_by1, string e_wei_ma1, bool is_one_price1, int is_saled1, int look_sum1, string pics1, string school_id1, int tags1, string title1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.City_id = city_id1;
            
            this.College_area_id = college_area_id1;
            
            this.Create_by = create_by1;
            
            this.E_wei_ma = e_wei_ma1;
            
            this.Is_one_price = is_one_price1;
            
            this.Is_saled = is_saled1;
            
            this.Look_sum = look_sum1;
            
            this.Pics = pics1;
            
            this.School_id = school_id1;
            
            this.Tags = tags1;
            
            this.Title = title1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xz_product FromIView(IView view)
        {
            return (Xz_product)IView.GetITable(view, "Xz_product");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xz_product GetOneInstance()
        {
            Xz_product value = new Xz_product();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xz_product Retrieve()
        {
            BLLTable<Xz_product>.GetRowData(this);
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
			    			
			    case "City_id":
			        return City_id;
			    			
			    case "College_area_id":
			        return College_area_id;
			    			
			    case "Create_by":
			        return Create_by;
			    			
			    case "E_wei_ma":
			        return E_wei_ma;
			    			
			    case "Is_one_price":
			        return Is_one_price;
			    			
			    case "Is_saled":
			        return Is_saled;
			    			
			    case "Look_sum":
			        return Look_sum;
			    			
			    case "Pics":
			        return Pics;
			    			
			    case "School_id":
			        return School_id;
			    			
			    case "Tags":
			        return Tags;
			    			
			    case "Title":
			        return Title;
			    			
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
			    			
			    case "City_id":
			        this.City_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "College_area_id":
			        this.College_area_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by":
			        this.Create_by = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "E_wei_ma":
			        this.E_wei_ma = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_one_price":
			        this.Is_one_price = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Is_saled":
			        this.Is_saled = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Look_sum":
			        this.Look_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Pics":
			        this.Pics = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "School_id":
			        this.School_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Tags":
			        this.Tags = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
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
				
				case "City_id":
					return city_id_initialized;
				
				case "College_area_id":
					return college_area_id_initialized;
				
				case "Create_by":
					return create_by_initialized;
				
				case "E_wei_ma":
					return e_wei_ma_initialized;
				
				case "Is_one_price":
					return is_one_price_initialized;
				
				case "Is_saled":
					return is_saled_initialized;
				
				case "Look_sum":
					return look_sum_initialized;
				
				case "Pics":
					return pics_initialized;
				
				case "School_id":
					return school_id_initialized;
				
				case "Tags":
					return tags_initialized;
				
				case "Title":
					return title_initialized;
				
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
				
				case "City_id":
					city_id_initialized = ret;
					return true;
				
				case "College_area_id":
					college_area_id_initialized = ret;
					return true;
				
				case "Create_by":
					create_by_initialized = ret;
					return true;
				
				case "E_wei_ma":
					e_wei_ma_initialized = ret;
					return true;
				
				case "Is_one_price":
					is_one_price_initialized = ret;
					return true;
				
				case "Is_saled":
					is_saled_initialized = ret;
					return true;
				
				case "Look_sum":
					look_sum_initialized = ret;
					return true;
				
				case "Pics":
					pics_initialized = ret;
					return true;
				
				case "School_id":
					school_id_initialized = ret;
					return true;
				
				case "Tags":
					tags_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
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
                AttributeItem attr = Xz_product.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
                }
			}
			
			if (college_area_id_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.College_area_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College_area_id);
                }
			}
			
			if (create_by_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.Create_by;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by);
                }
			}
			
			if (e_wei_ma_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.E_wei_ma;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(E_wei_ma);
                }
			}
			
			if (is_one_price_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.Is_one_price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_one_price);
                }
			}
			
			if (is_saled_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.Is_saled;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_saled);
                }
			}
			
			if (look_sum_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.Look_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Look_sum);
                }
			}
			
			if (pics_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.Pics;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pics);
                }
			}
			
			if (school_id_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.School_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_id);
                }
			}
			
			if (tags_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.Tags;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Tags);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xz_product.Attribute.Uuid;
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
        public class Xz_productJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public string City_id { get; set; }
            
            /// <summary>��ѧ��id:[CtrlTypeDic-{InputString}]</summary>
            public string College_area_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string E_wei_ma { get; set; }
            
            /// <summary>�Ƿ�һ�ڼ�:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Is_one_price { get; set; }
            
            /// <summary>����״̬:[CtrlTypeDic-{InputString}]</summary>
            public int Is_saled { get; set; }
            
            /// <summary>�������:[CtrlTypeDic-{InputString}]</summary>
            public int Look_sum { get; set; }
            
            /// <summary>������ƷͼƬ:[CtrlTypeDic-{HTML}]</summary>
            public string Pics { get; set; }
            
            /// <summary>ѧУid:[CtrlTypeDic-{InputString}]</summary>
            public string School_id { get; set; }
            
            /// <summary>��ǩ:[CtrlTypeDic-{InputString}]</summary>
            public int Tags { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{Text}]</summary>
            public string Title { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
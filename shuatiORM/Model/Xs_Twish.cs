/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:30
  Description:    ���ݱ�Xs_Twish��Ӧ��ҵ���߼���Xs_Twish
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xs_Twish_Entity:Xs_Twish
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Wish_id,User_id,City_id,Wish_type,Title,Product_specification,Path,MarketPrice,Publisher,Author,Is_realised,Is_deleted,Supply,Create_time from Xs_Twish
delete from Xs_Twish
INSERT INTO Xs_Twish (Id,Wish_id,User_id,City_id,Wish_type,Title,Product_specification,Path,MarketPrice,Publisher,Author,Is_realised,Is_deleted,Supply,Create_time)
     VALUES
           ('','','','','','','','','','','','','','','')
UPDATE Xs_Twish SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Wish_id = valObj2.Wish_id;
        valObj.User_id = valObj2.User_id;
        valObj.City_id = valObj2.City_id;
        valObj.Wish_type = valObj2.Wish_type;
        valObj.Title = valObj2.Title;
        valObj.Product_specification = valObj2.Product_specification;
        valObj.Path = valObj2.Path;
        valObj.MarketPrice = valObj2.MarketPrice;
        valObj.Publisher = valObj2.Publisher;
        valObj.Author = valObj2.Author;
        valObj.Is_realised = valObj2.Is_realised;
        valObj.Is_deleted = valObj2.Is_deleted;
        valObj.Supply = valObj2.Supply;
        valObj.Create_time = valObj2.Create_time; 
        valObj.Id = "";
        valObj.Wish_id = "";
        valObj.User_id = "";
        valObj.City_id = "";
        valObj.Wish_type = "";
        valObj.Title = "";
        valObj.Product_specification = "";
        valObj.Path = "";
        valObj.MarketPrice = "";
        valObj.Publisher = "";
        valObj.Author = "";
        valObj.Is_realised = "";
        valObj.Is_deleted = "";
        valObj.Supply = "";
        valObj.Create_time = ""; 
        "Id": $("#txt_Id").val(),
        "Wish_id": $("#txt_Wish_id").val(),
        "User_id": $("#txt_User_id").val(),
        "City_id": $("#txt_City_id").val(),
        "Wish_type": $("#txt_Wish_type").val(),
        "Title": $("#txt_Title").val(),
        "Product_specification": $("#txt_Product_specification").val(),
        "Path": $("#txt_Path").val(),
        "MarketPrice": $("#txt_MarketPrice").val(),
        "Publisher": $("#txt_Publisher").val(),
        "Author": $("#txt_Author").val(),
        "Is_realised": $("#txt_Is_realised").val(),
        "Is_deleted": $("#txt_Is_deleted").val(),
        "Supply": $("#txt_Supply").val(),
        "Create_time": $("#txt_Create_time").val(), 
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
    /// <para>ϣ��</para>
    /// <para>��Xs_Twish���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xs_Twish : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xs_Twish Factory()
        {
            return new Xs_Twish();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ϣ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Wish_id
        {            
            get { return this.Wish_id; }
            set { this.Wish_id = value; }
        }
        
        /// <summary> �û�ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> ����ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
        }
        
        /// <summary> ϣ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Wish_type
        {            
            get { return this.Wish_type; }
            set { this.Wish_type = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> ��Ʒ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Product_specification
        {            
            get { return this.Product_specification; }
            set { this.Product_specification = value; }
        }
        
        /// <summary> ·��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        
        /// <summary> �г��۸�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _MarketPrice
        {            
            get { return this.MarketPrice; }
            set { this.MarketPrice = value; }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Publisher
        {            
            get { return this.Publisher; }
            set { this.Publisher = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Author
        {            
            get { return this.Author; }
            set { this.Author = value; }
        }
        
        /// <summary> ����ʶ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_realised
        {            
            get { return this.Is_realised; }
            set { this.Is_realised = value; }
        }
        
        /// <summary> ɾ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Is_deleted
        {            
            get { return this.Is_deleted; }
            set { this.Is_deleted = value; }
        }
        
        /// <summary> ��Ӧ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Supply
        {            
            get { return this.Supply; }
            set { this.Supply = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ϣ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Wish_id
        {
            get { return this.m_wish_id; }
            set //
            {
                if (!wish_id_initialized || m_wish_id != value)
                {
                    this.m_wish_id = value;
                }
                wish_id_initialized = true;
            }
        }
        
        /// <summary> �û�ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ϣ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Wish_type
        {
            get { return this.m_wish_type; }
            set //
            {
                if (!wish_type_initialized || m_wish_type != value)
                {
                    this.m_wish_type = value;
                }
                wish_type_initialized = true;
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
        
        /// <summary> ��Ʒ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Product_specification
        {
            get { return this.m_product_specification; }
            set //
            {
                if (!product_specification_initialized || m_product_specification != value)
                {
                    this.m_product_specification = value;
                }
                product_specification_initialized = true;
            }
        }
        
        /// <summary> ·��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Path
        {
            get { return this.m_path; }
            set //
            {
                if (!path_initialized || m_path != value)
                {
                    this.m_path = value;
                }
                path_initialized = true;
            }
        }
        
        /// <summary> �г��۸�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string MarketPrice
        {
            get { return this.m_marketprice; }
            set //
            {
                if (!marketprice_initialized || m_marketprice != value)
                {
                    this.m_marketprice = value;
                }
                marketprice_initialized = true;
            }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Publisher
        {
            get { return this.m_publisher; }
            set //
            {
                if (!publisher_initialized || m_publisher != value)
                {
                    this.m_publisher = value;
                }
                publisher_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Author
        {
            get { return this.m_author; }
            set //
            {
                if (!author_initialized || m_author != value)
                {
                    this.m_author = value;
                }
                author_initialized = true;
            }
        }
        
        /// <summary> ����ʶ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Is_realised
        {
            get { return this.m_is_realised; }
            set //
            {
                if (!is_realised_initialized || m_is_realised != value)
                {
                    this.m_is_realised = value;
                }
                is_realised_initialized = true;
            }
        }
        
        /// <summary> ɾ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Is_deleted
        {
            get { return this.m_is_deleted; }
            set //
            {
                if (!is_deleted_initialized || m_is_deleted != value)
                {
                    this.m_is_deleted = value;
                }
                is_deleted_initialized = true;
            }
        }
        
        /// <summary> ��Ӧ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Supply
        {
            get { return this.m_supply; }
            set //
            {
                if (!supply_initialized || m_supply != value)
                {
                    this.m_supply = value;
                }
                supply_initialized = true;
            }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Create_time
        {
            get { return this.m_create_time; }
            set //
            {
                if (!create_time_initialized || m_create_time != value)
                {
                    this.m_create_time = value;
                }
                create_time_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xs_Twish].[Id]", typeof(int), 4, default(int));
            
            /// <summary>ϣ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Wish_id =  new AttributeItem("[Xs_Twish].[Wish_id]", typeof(string), 50, default(string));
            
            /// <summary>�û�ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xs_Twish].[User_id]", typeof(string), 50, default(string));
            
            /// <summary>����ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_id =  new AttributeItem("[Xs_Twish].[City_id]", typeof(string), 50, default(string));
            
            /// <summary>ϣ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Wish_type =  new AttributeItem("[Xs_Twish].[Wish_type]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xs_Twish].[Title]", typeof(string), 50, default(string));
            
            /// <summary>��Ʒ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Product_specification =  new AttributeItem("[Xs_Twish].[Product_specification]", typeof(string), 50, default(string));
            
            /// <summary>·��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Xs_Twish].[Path]", typeof(string), 50, default(string));
            
            /// <summary>�г��۸�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem MarketPrice =  new AttributeItem("[Xs_Twish].[MarketPrice]", typeof(string), 50, default(string));
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Publisher =  new AttributeItem("[Xs_Twish].[Publisher]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Author =  new AttributeItem("[Xs_Twish].[Author]", typeof(string), 50, default(string));
            
            /// <summary>����ʶ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_realised =  new AttributeItem("[Xs_Twish].[Is_realised]", typeof(string), 50, default(string));
            
            /// <summary>ɾ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Is_deleted =  new AttributeItem("[Xs_Twish].[Is_deleted]", typeof(DateTime), 4, default(DateTime));
            
            /// <summary>��Ӧ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Supply =  new AttributeItem("[Xs_Twish].[Supply]", typeof(int), 4, default(int));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xs_Twish].[Create_time]", typeof(DateTime), 8, default(DateTime));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_wish_id;
        /// <summary></summary>
        protected bool wish_id_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        
        private string m_wish_type;
        /// <summary></summary>
        protected bool wish_type_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private string m_product_specification;
        /// <summary></summary>
        protected bool product_specification_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        
        private string m_marketprice;
        /// <summary></summary>
        protected bool marketprice_initialized = false;
        
        private string m_publisher;
        /// <summary></summary>
        protected bool publisher_initialized = false;
        
        private string m_author;
        /// <summary></summary>
        protected bool author_initialized = false;
        
        private string m_is_realised;
        /// <summary></summary>
        protected bool is_realised_initialized = false;
        
        private DateTime m_is_deleted;
        /// <summary></summary>
        protected bool is_deleted_initialized = false;
        
        private int m_supply;
        /// <summary></summary>
        protected bool supply_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xs_Twish";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.wish_id_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;this.wish_type_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.product_specification_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;this.marketprice_initialized = IsLoadAllAttributes;this.publisher_initialized = IsLoadAllAttributes;this.author_initialized = IsLoadAllAttributes;this.is_realised_initialized = IsLoadAllAttributes;this.is_deleted_initialized = IsLoadAllAttributes;this.supply_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xs_Twish value = new Xs_Twish();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wish_id"))
				value.wish_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wish_type"))
				value.wish_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Product_specification"))
				value.product_specification_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"MarketPrice"))
				value.marketprice_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Publisher"))
				value.publisher_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Author"))
				value.author_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_realised"))
				value.is_realised_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_deleted"))
				value.is_deleted_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Supply"))
				value.supply_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xs_Twish Clone()
        {
            return (Xs_Twish)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xs_Twish()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xs_Twish() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xs_Twish(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xs_Twish(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xs_Twish(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xs_Twish(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xs_Twish(int id1, string wish_id1, string user_id1, string city_id1, string wish_type1, string title1, string product_specification1, string path1, string marketprice1, string publisher1, string author1, string is_realised1, DateTime is_deleted1, int supply1, DateTime create_time1)
        {
            
            this.Id = id1;
            
            this.Wish_id = wish_id1;
            
            this.User_id = user_id1;
            
            this.City_id = city_id1;
            
            this.Wish_type = wish_type1;
            
            this.Title = title1;
            
            this.Product_specification = product_specification1;
            
            this.Path = path1;
            
            this.MarketPrice = marketprice1;
            
            this.Publisher = publisher1;
            
            this.Author = author1;
            
            this.Is_realised = is_realised1;
            
            this.Is_deleted = is_deleted1;
            
            this.Supply = supply1;
            
            this.Create_time = create_time1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xs_Twish FromIView(IView view)
        {
            return (Xs_Twish)IView.GetITable(view, "Xs_Twish");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xs_Twish GetOneInstance()
        {
            Xs_Twish value = new Xs_Twish();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xs_Twish Retrieve()
        {
            BLLTable<Xs_Twish>.GetRowData(this);
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
			    			
			    case "Wish_id":
			        return Wish_id;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "City_id":
			        return City_id;
			    			
			    case "Wish_type":
			        return Wish_type;
			    			
			    case "Title":
			        return Title;
			    			
			    case "Product_specification":
			        return Product_specification;
			    			
			    case "Path":
			        return Path;
			    			
			    case "MarketPrice":
			        return MarketPrice;
			    			
			    case "Publisher":
			        return Publisher;
			    			
			    case "Author":
			        return Author;
			    			
			    case "Is_realised":
			        return Is_realised;
			    			
			    case "Is_deleted":
			        return Is_deleted;
			    			
			    case "Supply":
			        return Supply;
			    			
			    case "Create_time":
			        return Create_time;
			
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
			    			
			    case "Wish_id":
			        this.Wish_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City_id":
			        this.City_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wish_type":
			        this.Wish_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Product_specification":
			        this.Product_specification = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "MarketPrice":
			        this.MarketPrice = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Publisher":
			        this.Publisher = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Author":
			        this.Author = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_realised":
			        this.Is_realised = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_deleted":
			        this.Is_deleted = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Supply":
			        this.Supply = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
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
				
				case "Wish_id":
					return wish_id_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "City_id":
					return city_id_initialized;
				
				case "Wish_type":
					return wish_type_initialized;
				
				case "Title":
					return title_initialized;
				
				case "Product_specification":
					return product_specification_initialized;
				
				case "Path":
					return path_initialized;
				
				case "MarketPrice":
					return marketprice_initialized;
				
				case "Publisher":
					return publisher_initialized;
				
				case "Author":
					return author_initialized;
				
				case "Is_realised":
					return is_realised_initialized;
				
				case "Is_deleted":
					return is_deleted_initialized;
				
				case "Supply":
					return supply_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
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
				
				case "Wish_id":
					wish_id_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "City_id":
					city_id_initialized = ret;
					return true;
				
				case "Wish_type":
					wish_type_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Product_specification":
					product_specification_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
					return true;
				
				case "MarketPrice":
					marketprice_initialized = ret;
					return true;
				
				case "Publisher":
					publisher_initialized = ret;
					return true;
				
				case "Author":
					author_initialized = ret;
					return true;
				
				case "Is_realised":
					is_realised_initialized = ret;
					return true;
				
				case "Is_deleted":
					is_deleted_initialized = ret;
					return true;
				
				case "Supply":
					supply_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
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
                AttributeItem attr = Xs_Twish.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (wish_id_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Wish_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wish_id);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
                }
			}
			
			if (wish_type_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Wish_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wish_type);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (product_specification_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Product_specification;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Product_specification);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
                }
			}
			
			if (marketprice_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.MarketPrice;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(MarketPrice);
                }
			}
			
			if (publisher_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Publisher;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Publisher);
                }
			}
			
			if (author_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Author;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Author);
                }
			}
			
			if (is_realised_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Is_realised;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_realised);
                }
			}
			
			if (is_deleted_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Is_deleted;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_deleted);
                }
			}
			
			if (supply_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Supply;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Supply);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xs_Twish.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
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
        public class Xs_TwishJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>ϣ����:[CtrlTypeDic-{InputString}]</summary>
            public string Wish_id { get; set; }
            
            /// <summary>�û�ID:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>����ID:[CtrlTypeDic-{InputString}]</summary>
            public string City_id { get; set; }
            
            /// <summary>ϣ����:[CtrlTypeDic-{InputString}]</summary>
            public string Wish_type { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>��Ʒ���:[CtrlTypeDic-{InputString}]</summary>
            public string Product_specification { get; set; }
            
            /// <summary>·��:[CtrlTypeDic-{InputString}]</summary>
            public string Path { get; set; }
            
            /// <summary>�г��۸�:[CtrlTypeDic-{InputString}]</summary>
            public string MarketPrice { get; set; }
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public string Publisher { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Author { get; set; }
            
            /// <summary>����ʶ��:[CtrlTypeDic-{InputString}]</summary>
            public string Is_realised { get; set; }
            
            /// <summary>ɾ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Is_deleted { get; set; }
            
            /// <summary>��Ӧ:[CtrlTypeDic-{InputString}]</summary>
            public int Supply { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
        }
        #endregion
    }
}
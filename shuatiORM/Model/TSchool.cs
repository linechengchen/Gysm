/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/22 18:01:00
  Description:    ���ݱ�TSchool��Ӧ��ҵ���߼���TSchool
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TSchool_Entity:TSchool
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Address,City,City_id,Create_by,Create_by_name,Intro,Is985,IsHot,Name,Pinche_area,Province,SchoolUrl,Seq,Tel,X,Y from TSchool
delete from TSchool
INSERT INTO TSchool (Id,Address,City,City_id,Create_by,Create_by_name,Intro,Is985,IsHot,Name,Pinche_area,Province,SchoolUrl,Seq,Tel,X,Y)
     VALUES
           ('','','','','','','','','','','','','','','','','')
UPDATE TSchool SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Address = valObj2.Address;
        valObj.City = valObj2.City;
        valObj.City_id = valObj2.City_id;
        valObj.Create_by = valObj2.Create_by;
        valObj.Create_by_name = valObj2.Create_by_name;
        valObj.Intro = valObj2.Intro;
        valObj.Is985 = valObj2.Is985;
        valObj.IsHot = valObj2.IsHot;
        valObj.Name = valObj2.Name;
        valObj.Pinche_area = valObj2.Pinche_area;
        valObj.Province = valObj2.Province;
        valObj.SchoolUrl = valObj2.SchoolUrl;
        valObj.Seq = valObj2.Seq;
        valObj.Tel = valObj2.Tel;
        valObj.X = valObj2.X;
        valObj.Y = valObj2.Y; 
        valObj.Id = "";
        valObj.Address = "";
        valObj.City = "";
        valObj.City_id = "";
        valObj.Create_by = "";
        valObj.Create_by_name = "";
        valObj.Intro = "";
        valObj.Is985 = "";
        valObj.IsHot = "";
        valObj.Name = "";
        valObj.Pinche_area = "";
        valObj.Province = "";
        valObj.SchoolUrl = "";
        valObj.Seq = "";
        valObj.Tel = "";
        valObj.X = "";
        valObj.Y = ""; 
        "Id": $("#txt_Id").val(),
        "Address": $("#txt_Address").val(),
        "City": $("#txt_City").val(),
        "City_id": $("#txt_City_id").val(),
        "Create_by": $("#txt_Create_by").val(),
        "Create_by_name": $("#txt_Create_by_name").val(),
        "Intro": $("#txt_Intro").val(),
        "Is985": $("#txt_Is985").val(),
        "IsHot": $("#txt_IsHot").val(),
        "Name": $("#txt_Name").val(),
        "Pinche_area": $("#txt_Pinche_area").val(),
        "Province": $("#txt_Province").val(),
        "SchoolUrl": $("#txt_SchoolUrl").val(),
        "Seq": $("#txt_Seq").val(),
        "Tel": $("#txt_Tel").val(),
        "X": $("#txt_X").val(),
        "Y": $("#txt_Y").val(), 
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
    /// <para>ѧУ��Ϣ</para>
    /// <para>��TSchool���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TSchool : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TSchool Factory()
        {
            return new TSchool();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by
        {            
            get { return this.Create_by; }
            set { this.Create_by = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by_name
        {            
            get { return this.Create_by_name; }
            set { this.Create_by_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Intro
        {            
            get { return this.Intro; }
            set { this.Intro = value; }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _Is985
        {            
            get { return this.Is985; }
            set { this.Is985 = value; }
        }
        
        /// <summary> �Ƿ�����:[Enum-{0:��},{1:��}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsHot
        {            
            get { return this.IsHot; }
            set { this.IsHot = value; }
        }
        
        /// <summary> ѧУ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Pinche_area
        {            
            get { return this.Pinche_area; }
            set { this.Pinche_area = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Province
        {            
            get { return this.Province; }
            set { this.Province = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _SchoolUrl
        {            
            get { return this.SchoolUrl; }
            set { this.SchoolUrl = value; }
        }
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        
        /// <summary> [CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Tel
        {            
            get { return this.Tel; }
            set { this.Tel = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _X
        {            
            get { return this.X; }
            set { this.X = value; }
        }
        
        /// <summary> γ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Y
        {            
            get { return this.Y; }
            set { this.Y = value; }
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
        
        /// <summary> [CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Address
        {
            get { return this.m_address; }
            set //
            {
                if (!address_initialized || m_address != value)
                {
                    this.m_address = value;
                }
                address_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string City
        {
            get { return this.m_city; }
            set //
            {
                if (!city_initialized || m_city != value)
                {
                    this.m_city = value;
                }
                city_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        public string Create_by_name
        {
            get { return this.m_create_by_name; }
            set //
            {
                if (!create_by_name_initialized || m_create_by_name != value)
                {
                    this.m_create_by_name = value;
                }
                create_by_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Intro
        {
            get { return this.m_intro; }
            set //
            {
                if (!intro_initialized || m_intro != value)
                {
                    this.m_intro = value;
                }
                intro_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Is985
        {
            get { return this.m_is985; }
            set //
            {
                if (!is985_initialized || m_is985 != value)
                {
                    this.m_is985 = value;
                }
                is985_initialized = true;
            }
        }
        
        /// <summary> �Ƿ�����:[Enum-{0:��},{1:��}][CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool IsHot
        {
            get { return this.m_ishot; }
            set //
            {
                if (!ishot_initialized || m_ishot != value)
                {
                    this.m_ishot = value;
                }
                ishot_initialized = true;
            }
        }
        
        /// <summary> ѧУ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Pinche_area
        {
            get { return this.m_pinche_area; }
            set //
            {
                if (!pinche_area_initialized || m_pinche_area != value)
                {
                    this.m_pinche_area = value;
                }
                pinche_area_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Province
        {
            get { return this.m_province; }
            set //
            {
                if (!province_initialized || m_province != value)
                {
                    this.m_province = value;
                }
                province_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SchoolUrl
        {
            get { return this.m_schoolurl; }
            set //
            {
                if (!schoolurl_initialized || m_schoolurl != value)
                {
                    this.m_schoolurl = value;
                }
                schoolurl_initialized = true;
            }
        }
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Seq
        {
            get { return this.m_seq; }
            set //
            {
                if (!seq_initialized || m_seq != value)
                {
                    this.m_seq = value;
                }
                seq_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Tel
        {
            get { return this.m_tel; }
            set //
            {
                if (!tel_initialized || m_tel != value)
                {
                    this.m_tel = value;
                }
                tel_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal X
        {
            get { return this.m_x; }
            set //
            {
                if (!x_initialized || m_x != value)
                {
                    this.m_x = value;
                }
                x_initialized = true;
            }
        }
        
        /// <summary> γ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Y
        {
            get { return this.m_y; }
            set //
            {
                if (!y_initialized || m_y != value)
                {
                    this.m_y = value;
                }
                y_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TSchool].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Address =  new AttributeItem("[TSchool].[Address]", typeof(string), 500, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[TSchool].[City]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_id =  new AttributeItem("[TSchool].[City_id]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by =  new AttributeItem("[TSchool].[Create_by]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by_name =  new AttributeItem("[TSchool].[Create_by_name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Intro =  new AttributeItem("[TSchool].[Intro]", typeof(string), -1, default(string));
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem Is985 =  new AttributeItem("[TSchool].[Is985]", typeof(string), 300, default(string));
            
            /// <summary>�Ƿ�����:[Enum-{0:��},{1:��}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsHot =  new AttributeItem("[TSchool].[IsHot]", typeof(bool), 1, default(bool));
            
            /// <summary>ѧУ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[TSchool].[Name]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pinche_area =  new AttributeItem("[TSchool].[Pinche_area]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Province =  new AttributeItem("[TSchool].[Province]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem SchoolUrl =  new AttributeItem("[TSchool].[SchoolUrl]", typeof(string), 550, default(string));
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[TSchool].[Seq]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Tel =  new AttributeItem("[TSchool].[Tel]", typeof(string), 500, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem X =  new AttributeItem("[TSchool].[X]", typeof(decimal), 10, default(decimal));
            
            /// <summary>γ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Y =  new AttributeItem("[TSchool].[Y]", typeof(decimal), 10, default(decimal));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        
        private string m_create_by;
        /// <summary></summary>
        protected bool create_by_initialized = false;
        
        private string m_create_by_name;
        /// <summary></summary>
        protected bool create_by_name_initialized = false;
        
        private string m_intro;
        /// <summary></summary>
        protected bool intro_initialized = false;
        
        private string m_is985;
        /// <summary></summary>
        protected bool is985_initialized = false;
        
        private bool m_ishot;
        /// <summary></summary>
        protected bool ishot_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_pinche_area;
        /// <summary></summary>
        protected bool pinche_area_initialized = false;
        
        private string m_province;
        /// <summary></summary>
        protected bool province_initialized = false;
        
        private string m_schoolurl;
        /// <summary></summary>
        protected bool schoolurl_initialized = false;
        
        private int m_seq;
        /// <summary></summary>
        protected bool seq_initialized = false;
        
        private string m_tel;
        /// <summary></summary>
        protected bool tel_initialized = false;
        
        private decimal m_x;
        /// <summary></summary>
        protected bool x_initialized = false;
        
        private decimal m_y;
        /// <summary></summary>
        protected bool y_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TSchool";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;this.create_by_initialized = IsLoadAllAttributes;this.create_by_name_initialized = IsLoadAllAttributes;this.intro_initialized = IsLoadAllAttributes;this.is985_initialized = IsLoadAllAttributes;this.ishot_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.pinche_area_initialized = IsLoadAllAttributes;this.province_initialized = IsLoadAllAttributes;this.schoolurl_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;this.tel_initialized = IsLoadAllAttributes;this.x_initialized = IsLoadAllAttributes;this.y_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TSchool value = new TSchool();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by"))
				value.create_by_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by_name"))
				value.create_by_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Intro"))
				value.intro_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is985"))
				value.is985_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHot"))
				value.ishot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pinche_area"))
				value.pinche_area_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province"))
				value.province_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SchoolUrl"))
				value.schoolurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Tel"))
				value.tel_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"X"))
				value.x_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Y"))
				value.y_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TSchool Clone()
        {
            return (TSchool)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TSchool()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TSchool() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TSchool(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TSchool(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TSchool(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TSchool(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TSchool(int id1, string address1, string city1, string city_id1, string create_by1, string create_by_name1, string intro1, string is9851, bool ishot1, string name1, string pinche_area1, string province1, string schoolurl1, int seq1, string tel1, decimal x1, decimal y1)
        {
            
            this.Id = id1;
            
            this.Address = address1;
            
            this.City = city1;
            
            this.City_id = city_id1;
            
            this.Create_by = create_by1;
            
            this.Create_by_name = create_by_name1;
            
            this.Intro = intro1;
            
            this.Is985 = is9851;
            
            this.IsHot = ishot1;
            
            this.Name = name1;
            
            this.Pinche_area = pinche_area1;
            
            this.Province = province1;
            
            this.SchoolUrl = schoolurl1;
            
            this.Seq = seq1;
            
            this.Tel = tel1;
            
            this.X = x1;
            
            this.Y = y1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TSchool FromIView(IView view)
        {
            return (TSchool)IView.GetITable(view, "TSchool");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TSchool GetOneInstance()
        {
            TSchool value = new TSchool();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TSchool Retrieve()
        {
            BLLTable<TSchool>.GetRowData(this);
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
			    			
			    case "Address":
			        return Address;
			    			
			    case "City":
			        return City;
			    			
			    case "City_id":
			        return City_id;
			    			
			    case "Create_by":
			        return Create_by;
			    			
			    case "Create_by_name":
			        return Create_by_name;
			    			
			    case "Intro":
			        return Intro;
			    			
			    case "Is985":
			        return Is985;
			    			
			    case "IsHot":
			        return IsHot;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Pinche_area":
			        return Pinche_area;
			    			
			    case "Province":
			        return Province;
			    			
			    case "SchoolUrl":
			        return SchoolUrl;
			    			
			    case "Seq":
			        return Seq;
			    			
			    case "Tel":
			        return Tel;
			    			
			    case "X":
			        return X;
			    			
			    case "Y":
			        return Y;
			
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
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City_id":
			        this.City_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by":
			        this.Create_by = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by_name":
			        this.Create_by_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Intro":
			        this.Intro = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is985":
			        this.Is985 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsHot":
			        this.IsHot = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Pinche_area":
			        this.Pinche_area = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Province":
			        this.Province = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SchoolUrl":
			        this.SchoolUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Seq":
			        this.Seq = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Tel":
			        this.Tel = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "X":
			        this.X = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Y":
			        this.Y = Convert.ToDecimal(AttributeValue);
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
				
				case "Address":
					return address_initialized;
				
				case "City":
					return city_initialized;
				
				case "City_id":
					return city_id_initialized;
				
				case "Create_by":
					return create_by_initialized;
				
				case "Create_by_name":
					return create_by_name_initialized;
				
				case "Intro":
					return intro_initialized;
				
				case "Is985":
					return is985_initialized;
				
				case "IsHot":
					return ishot_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Pinche_area":
					return pinche_area_initialized;
				
				case "Province":
					return province_initialized;
				
				case "SchoolUrl":
					return schoolurl_initialized;
				
				case "Seq":
					return seq_initialized;
				
				case "Tel":
					return tel_initialized;
				
				case "X":
					return x_initialized;
				
				case "Y":
					return y_initialized;
				
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
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "City_id":
					city_id_initialized = ret;
					return true;
				
				case "Create_by":
					create_by_initialized = ret;
					return true;
				
				case "Create_by_name":
					create_by_name_initialized = ret;
					return true;
				
				case "Intro":
					intro_initialized = ret;
					return true;
				
				case "Is985":
					is985_initialized = ret;
					return true;
				
				case "IsHot":
					ishot_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Pinche_area":
					pinche_area_initialized = ret;
					return true;
				
				case "Province":
					province_initialized = ret;
					return true;
				
				case "SchoolUrl":
					schoolurl_initialized = ret;
					return true;
				
				case "Seq":
					seq_initialized = ret;
					return true;
				
				case "Tel":
					tel_initialized = ret;
					return true;
				
				case "X":
					x_initialized = ret;
					return true;
				
				case "Y":
					y_initialized = ret;
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
                AttributeItem attr = TSchool.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = TSchool.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = TSchool.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
                }
			}
			
			if (create_by_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Create_by;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by);
                }
			}
			
			if (create_by_name_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Create_by_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by_name);
                }
			}
			
			if (intro_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Intro;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Intro);
                }
			}
			
			if (is985_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Is985;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is985);
                }
			}
			
			if (ishot_initialized)
			{
                AttributeItem attr = TSchool.Attribute.IsHot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHot);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (pinche_area_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Pinche_area;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pinche_area);
                }
			}
			
			if (province_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province);
                }
			}
			
			if (schoolurl_initialized)
			{
                AttributeItem attr = TSchool.Attribute.SchoolUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SchoolUrl);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
                }
			}
			
			if (tel_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Tel;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Tel);
                }
			}
			
			if (x_initialized)
			{
                AttributeItem attr = TSchool.Attribute.X;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(X);
                }
			}
			
			if (y_initialized)
			{
                AttributeItem attr = TSchool.Attribute.Y;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Y);
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
        public class TSchoolJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Address { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string City_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Intro { get; set; }
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public string Is985 { get; set; }
            
            /// <summary>�Ƿ�����:[Enum-{0:��},{1:��}][CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsHot { get; set; }
            
            /// <summary>ѧУ����:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Pinche_area { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Province { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string SchoolUrl { get; set; }
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
            
            /// <summary>[CtrlTypeDic-{Text}]</summary>
            public string Tel { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public decimal X { get; set; }
            
            /// <summary>γ��:[CtrlTypeDic-{InputString}]</summary>
            public decimal Y { get; set; }
        }
        #endregion
    }
}
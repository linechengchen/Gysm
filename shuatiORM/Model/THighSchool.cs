/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    ���ݱ�THighSchool��Ӧ��ҵ���߼���THighSchool
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� THighSchool_Entity:THighSchool
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Name,City_id,Intro,IsZhongDian,Province,Address,IsSchool,GradeJson,ClassJson,Create_by,Create_by_name from THighSchool
delete from THighSchool
INSERT INTO THighSchool (Id,Name,City_id,Intro,IsZhongDian,Province,Address,IsSchool,GradeJson,ClassJson,Create_by,Create_by_name)
     VALUES
           ('','','','','','','','','','','','')
UPDATE THighSchool SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.City_id = valObj2.City_id;
        valObj.Intro = valObj2.Intro;
        valObj.IsZhongDian = valObj2.IsZhongDian;
        valObj.Province = valObj2.Province;
        valObj.Address = valObj2.Address;
        valObj.IsSchool = valObj2.IsSchool;
        valObj.GradeJson = valObj2.GradeJson;
        valObj.ClassJson = valObj2.ClassJson;
        valObj.Create_by = valObj2.Create_by;
        valObj.Create_by_name = valObj2.Create_by_name; 
        valObj.Id = "";
        valObj.Name = "";
        valObj.City_id = "";
        valObj.Intro = "";
        valObj.IsZhongDian = "";
        valObj.Province = "";
        valObj.Address = "";
        valObj.IsSchool = "";
        valObj.GradeJson = "";
        valObj.ClassJson = "";
        valObj.Create_by = "";
        valObj.Create_by_name = ""; 
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "City_id": $("#txt_City_id").val(),
        "Intro": $("#txt_Intro").val(),
        "IsZhongDian": $("#txt_IsZhongDian").val(),
        "Province": $("#txt_Province").val(),
        "Address": $("#txt_Address").val(),
        "IsSchool": $("#txt_IsSchool").val(),
        "GradeJson": $("#txt_GradeJson").val(),
        "ClassJson": $("#txt_ClassJson").val(),
        "Create_by": $("#txt_Create_by").val(),
        "Create_by_name": $("#txt_Create_by_name").val(), 
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
    /// <para>����</para>
    /// <para>��THighSchool���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class THighSchool : ITableImplement
    {
        /// <summary>��������  </summary>
        public static THighSchool Factory()
        {
            return new THighSchool();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> ���б�ʶ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
        }
        
        /// <summary> ���:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Intro
        {            
            get { return this.Intro; }
            set { this.Intro = value; }
        }
        
        /// <summary> ����·��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _IsZhongDian
        {            
            get { return this.IsZhongDian; }
            set { this.IsZhongDian = value; }
        }
        
        /// <summary> ʡ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Province
        {            
            get { return this.Province; }
            set { this.Province = value; }
        }
        
        /// <summary> ��ַ:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> ��ѧԺ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _IsSchool
        {            
            get { return this.IsSchool; }
            set { this.IsSchool = value; }
        }
        
        /// <summary> �̶ȵ�JSON:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GradeJson
        {            
            get { return this.GradeJson; }
            set { this.GradeJson = value; }
        }
        
        /// <summary> һ����JSON:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _ClassJson
        {            
            get { return this.ClassJson; }
            set { this.ClassJson = value; }
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
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���б�ʶ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����·��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int IsZhongDian
        {
            get { return this.m_iszhongdian; }
            set //
            {
                if (!iszhongdian_initialized || m_iszhongdian != value)
                {
                    this.m_iszhongdian = value;
                }
                iszhongdian_initialized = true;
            }
        }
        
        /// <summary> ʡ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ַ:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ѧԺ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int IsSchool
        {
            get { return this.m_isschool; }
            set //
            {
                if (!isschool_initialized || m_isschool != value)
                {
                    this.m_isschool = value;
                }
                isschool_initialized = true;
            }
        }
        
        /// <summary> �̶ȵ�JSON:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string GradeJson
        {
            get { return this.m_gradejson; }
            set //
            {
                if (!gradejson_initialized || m_gradejson != value)
                {
                    this.m_gradejson = value;
                }
                gradejson_initialized = true;
            }
        }
        
        /// <summary> һ����JSON:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassJson
        {
            get { return this.m_classjson; }
            set //
            {
                if (!classjson_initialized || m_classjson != value)
                {
                    this.m_classjson = value;
                }
                classjson_initialized = true;
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[THighSchool].[Id]", typeof(int), 4, default(int));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[THighSchool].[Name]", typeof(string), 50, default(string));
            
            /// <summary>���б�ʶ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_id =  new AttributeItem("[THighSchool].[City_id]", typeof(string), 50, default(string));
            
            /// <summary>���:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Intro =  new AttributeItem("[THighSchool].[Intro]", typeof(string), 1000, default(string));
            
            /// <summary>����·��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsZhongDian =  new AttributeItem("[THighSchool].[IsZhongDian]", typeof(int), 4, default(int));
            
            /// <summary>ʡ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Province =  new AttributeItem("[THighSchool].[Province]", typeof(string), 50, default(string));
            
            /// <summary>��ַ:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Address =  new AttributeItem("[THighSchool].[Address]", typeof(string), 500, default(string));
            
            /// <summary>��ѧԺ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsSchool =  new AttributeItem("[THighSchool].[IsSchool]", typeof(int), 4, default(int));
            
            /// <summary>�̶ȵ�JSON:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GradeJson =  new AttributeItem("[THighSchool].[GradeJson]", typeof(string), 50, default(string));
            
            /// <summary>һ����JSON:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem ClassJson =  new AttributeItem("[THighSchool].[ClassJson]", typeof(string), 500, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by =  new AttributeItem("[THighSchool].[Create_by]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by_name =  new AttributeItem("[THighSchool].[Create_by_name]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        
        private string m_intro;
        /// <summary></summary>
        protected bool intro_initialized = false;
        
        private int m_iszhongdian;
        /// <summary></summary>
        protected bool iszhongdian_initialized = false;
        
        private string m_province;
        /// <summary></summary>
        protected bool province_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private int m_isschool;
        /// <summary></summary>
        protected bool isschool_initialized = false;
        
        private string m_gradejson;
        /// <summary></summary>
        protected bool gradejson_initialized = false;
        
        private string m_classjson;
        /// <summary></summary>
        protected bool classjson_initialized = false;
        
        private string m_create_by;
        /// <summary></summary>
        protected bool create_by_initialized = false;
        
        private string m_create_by_name;
        /// <summary></summary>
        protected bool create_by_name_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "THighSchool";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;this.intro_initialized = IsLoadAllAttributes;this.iszhongdian_initialized = IsLoadAllAttributes;this.province_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.isschool_initialized = IsLoadAllAttributes;this.gradejson_initialized = IsLoadAllAttributes;this.classjson_initialized = IsLoadAllAttributes;this.create_by_initialized = IsLoadAllAttributes;this.create_by_name_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			THighSchool value = new THighSchool();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Intro"))
				value.intro_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsZhongDian"))
				value.iszhongdian_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province"))
				value.province_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsSchool"))
				value.isschool_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GradeJson"))
				value.gradejson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassJson"))
				value.classjson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by"))
				value.create_by_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by_name"))
				value.create_by_name_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new THighSchool Clone()
        {
            return (THighSchool)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static THighSchool()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public THighSchool() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public THighSchool(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public THighSchool(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public THighSchool(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public THighSchool(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public THighSchool(int id1, string name1, string city_id1, string intro1, int iszhongdian1, string province1, string address1, int isschool1, string gradejson1, string classjson1, string create_by1, string create_by_name1)
        {
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.City_id = city_id1;
            
            this.Intro = intro1;
            
            this.IsZhongDian = iszhongdian1;
            
            this.Province = province1;
            
            this.Address = address1;
            
            this.IsSchool = isschool1;
            
            this.GradeJson = gradejson1;
            
            this.ClassJson = classjson1;
            
            this.Create_by = create_by1;
            
            this.Create_by_name = create_by_name1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static THighSchool FromIView(IView view)
        {
            return (THighSchool)IView.GetITable(view, "THighSchool");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static THighSchool GetOneInstance()
        {
            THighSchool value = new THighSchool();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public THighSchool Retrieve()
        {
            BLLTable<THighSchool>.GetRowData(this);
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
			    			
			    case "Name":
			        return Name;
			    			
			    case "City_id":
			        return City_id;
			    			
			    case "Intro":
			        return Intro;
			    			
			    case "IsZhongDian":
			        return IsZhongDian;
			    			
			    case "Province":
			        return Province;
			    			
			    case "Address":
			        return Address;
			    			
			    case "IsSchool":
			        return IsSchool;
			    			
			    case "GradeJson":
			        return GradeJson;
			    			
			    case "ClassJson":
			        return ClassJson;
			    			
			    case "Create_by":
			        return Create_by;
			    			
			    case "Create_by_name":
			        return Create_by_name;
			
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
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City_id":
			        this.City_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Intro":
			        this.Intro = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsZhongDian":
			        this.IsZhongDian = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Province":
			        this.Province = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsSchool":
			        this.IsSchool = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "GradeJson":
			        this.GradeJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassJson":
			        this.ClassJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by":
			        this.Create_by = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by_name":
			        this.Create_by_name = Convert.ToString(AttributeValue);
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
				
				case "Name":
					return name_initialized;
				
				case "City_id":
					return city_id_initialized;
				
				case "Intro":
					return intro_initialized;
				
				case "IsZhongDian":
					return iszhongdian_initialized;
				
				case "Province":
					return province_initialized;
				
				case "Address":
					return address_initialized;
				
				case "IsSchool":
					return isschool_initialized;
				
				case "GradeJson":
					return gradejson_initialized;
				
				case "ClassJson":
					return classjson_initialized;
				
				case "Create_by":
					return create_by_initialized;
				
				case "Create_by_name":
					return create_by_name_initialized;
				
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
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "City_id":
					city_id_initialized = ret;
					return true;
				
				case "Intro":
					intro_initialized = ret;
					return true;
				
				case "IsZhongDian":
					iszhongdian_initialized = ret;
					return true;
				
				case "Province":
					province_initialized = ret;
					return true;
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "IsSchool":
					isschool_initialized = ret;
					return true;
				
				case "GradeJson":
					gradejson_initialized = ret;
					return true;
				
				case "ClassJson":
					classjson_initialized = ret;
					return true;
				
				case "Create_by":
					create_by_initialized = ret;
					return true;
				
				case "Create_by_name":
					create_by_name_initialized = ret;
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
                AttributeItem attr = THighSchool.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
                }
			}
			
			if (intro_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Intro;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Intro);
                }
			}
			
			if (iszhongdian_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.IsZhongDian;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsZhongDian);
                }
			}
			
			if (province_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (isschool_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.IsSchool;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsSchool);
                }
			}
			
			if (gradejson_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.GradeJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GradeJson);
                }
			}
			
			if (classjson_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.ClassJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassJson);
                }
			}
			
			if (create_by_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Create_by;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by);
                }
			}
			
			if (create_by_name_initialized)
			{
                AttributeItem attr = THighSchool.Attribute.Create_by_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by_name);
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
        public class THighSchoolJson
        {
            
            /// <summary>ID:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>���б�ʶ:[CtrlTypeDic-{InputString}]</summary>
            public string City_id { get; set; }
            
            /// <summary>���:[CtrlTypeDic-{Text}]</summary>
            public string Intro { get; set; }
            
            /// <summary>����·��:[CtrlTypeDic-{InputString}]</summary>
            public int IsZhongDian { get; set; }
            
            /// <summary>ʡ:[CtrlTypeDic-{InputString}]</summary>
            public string Province { get; set; }
            
            /// <summary>��ַ:[CtrlTypeDic-{Text}]</summary>
            public string Address { get; set; }
            
            /// <summary>��ѧԺ:[CtrlTypeDic-{InputString}]</summary>
            public int IsSchool { get; set; }
            
            /// <summary>�̶ȵ�JSON:[CtrlTypeDic-{InputString}]</summary>
            public string GradeJson { get; set; }
            
            /// <summary>һ����JSON:[CtrlTypeDic-{Text}]</summary>
            public string ClassJson { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by_name { get; set; }
        }
        #endregion
    }
}
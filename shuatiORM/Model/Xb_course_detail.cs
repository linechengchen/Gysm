/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:20
  Description:    ���ݱ�Xb_course_detail��Ӧ��ҵ���߼���Xb_course_detail
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_course_detail_Entity:Xb_course_detail
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,CourseId,Create_time,Name,Price,Price2,Type from Xb_course_detail
delete from Xb_course_detail
INSERT INTO Xb_course_detail (Id,CourseId,Create_time,Name,Price,Price2,Type)
     VALUES
           ('','','','','','','')
UPDATE Xb_course_detail SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.CourseId = valObj2.CourseId;
        valObj.Create_time = valObj2.Create_time;
        valObj.Name = valObj2.Name;
        valObj.Price = valObj2.Price;
        valObj.Price2 = valObj2.Price2;
        valObj.Type = valObj2.Type; 
        valObj.Id = "";
        valObj.CourseId = "";
        valObj.Create_time = "";
        valObj.Name = "";
        valObj.Price = "";
        valObj.Price2 = "";
        valObj.Type = ""; 
        "Id": $("#txt_Id").val(),
        "CourseId": $("#txt_CourseId").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Name": $("#txt_Name").val(),
        "Price": $("#txt_Price").val(),
        "Price2": $("#txt_Price2").val(),
        "Type": $("#txt_Type").val(), 
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
    /// <para>�γ�ϸ��</para>
    /// <para>��Xb_course_detail���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_course_detail : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_course_detail Factory()
        {
            return new Xb_course_detail();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �γ̱��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _CourseId
        {            
            get { return this.CourseId; }
            set { this.CourseId = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> �۸�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Price
        {            
            get { return this.Price; }
            set { this.Price = value; }
        }
        
        /// <summary> �۸�2:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Price2
        {            
            get { return this.Price2; }
            set { this.Price2 = value; }
        }
        
        /// <summary> ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
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
        
        /// <summary> �γ̱��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int CourseId
        {
            get { return this.m_courseid; }
            set //
            {
                if (!courseid_initialized || m_courseid != value)
                {
                    this.m_courseid = value;
                }
                courseid_initialized = true;
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
        
        /// <summary> �۸�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Price
        {
            get { return this.m_price; }
            set //
            {
                if (!price_initialized || m_price != value)
                {
                    this.m_price = value;
                }
                price_initialized = true;
            }
        }
        
        /// <summary> �۸�2:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Price2
        {
            get { return this.m_price2; }
            set //
            {
                if (!price2_initialized || m_price2 != value)
                {
                    this.m_price2 = value;
                }
                price2_initialized = true;
            }
        }
        
        /// <summary> ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_course_detail].[Id]", typeof(int), 4, default(int));
            
            /// <summary>�γ̱��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CourseId =  new AttributeItem("[Xb_course_detail].[CourseId]", typeof(int), 4, default(int));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xb_course_detail].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xb_course_detail].[Name]", typeof(string), 50, default(string));
            
            /// <summary>�۸�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Price =  new AttributeItem("[Xb_course_detail].[Price]", typeof(string), 10, default(string));
            
            /// <summary>�۸�2:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Price2 =  new AttributeItem("[Xb_course_detail].[Price2]", typeof(string), 10, default(string));
            
            /// <summary>��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xb_course_detail].[Type]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_courseid;
        /// <summary></summary>
        protected bool courseid_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_price;
        /// <summary></summary>
        protected bool price_initialized = false;
        
        private string m_price2;
        /// <summary></summary>
        protected bool price2_initialized = false;
        
        private string m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_course_detail";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.courseid_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.price_initialized = IsLoadAllAttributes;this.price2_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_course_detail value = new Xb_course_detail();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CourseId"))
				value.courseid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Price"))
				value.price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Price2"))
				value.price2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_course_detail Clone()
        {
            return (Xb_course_detail)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_course_detail()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_course_detail() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_course_detail(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_course_detail(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_course_detail(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_course_detail(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_course_detail(int id1, int courseid1, DateTime create_time1, string name1, string price1, string price21, string type1)
        {
            
            this.Id = id1;
            
            this.CourseId = courseid1;
            
            this.Create_time = create_time1;
            
            this.Name = name1;
            
            this.Price = price1;
            
            this.Price2 = price21;
            
            this.Type = type1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_course_detail FromIView(IView view)
        {
            return (Xb_course_detail)IView.GetITable(view, "Xb_course_detail");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_course_detail GetOneInstance()
        {
            Xb_course_detail value = new Xb_course_detail();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_course_detail Retrieve()
        {
            BLLTable<Xb_course_detail>.GetRowData(this);
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
			    			
			    case "CourseId":
			        return CourseId;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Price":
			        return Price;
			    			
			    case "Price2":
			        return Price2;
			    			
			    case "Type":
			        return Type;
			
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
			    			
			    case "CourseId":
			        this.CourseId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Price":
			        this.Price = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Price2":
			        this.Price2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToString(AttributeValue);
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
				
				case "CourseId":
					return courseid_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Price":
					return price_initialized;
				
				case "Price2":
					return price2_initialized;
				
				case "Type":
					return type_initialized;
				
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
				
				case "CourseId":
					courseid_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Price":
					price_initialized = ret;
					return true;
				
				case "Price2":
					price2_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
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
                AttributeItem attr = Xb_course_detail.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (courseid_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.CourseId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CourseId);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (price_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Price);
                }
			}
			
			if (price2_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Price2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Price2);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xb_course_detail.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
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
        public class Xb_course_detailJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>�γ̱��:[CtrlTypeDic-{InputString}]</summary>
            public int CourseId { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>�۸�:[CtrlTypeDic-{InputString}]</summary>
            public string Price { get; set; }
            
            /// <summary>�۸�2:[CtrlTypeDic-{InputString}]</summary>
            public string Price2 { get; set; }
            
            /// <summary>��:[CtrlTypeDic-{InputString}]</summary>
            public string Type { get; set; }
        }
        #endregion
    }
}
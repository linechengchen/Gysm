/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/22 18:01:00
  Description:    ���ݱ�Pc_end��Ӧ��ҵ���߼���Pc_end
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Pc_end_Entity:Pc_end
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,City_name,Create_by,End_name,Lat,Lng,Uuid from Pc_end
delete from Pc_end
INSERT INTO Pc_end (Id,City_name,Create_by,End_name,Lat,Lng,Uuid)
     VALUES
           ('','','','','','','')
UPDATE Pc_end SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.City_name = valObj2.City_name;
        valObj.Create_by = valObj2.Create_by;
        valObj.End_name = valObj2.End_name;
        valObj.Lat = valObj2.Lat;
        valObj.Lng = valObj2.Lng;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.City_name = "";
        valObj.Create_by = "";
        valObj.End_name = "";
        valObj.Lat = "";
        valObj.Lng = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "City_name": $("#txt_City_name").val(),
        "Create_by": $("#txt_Create_by").val(),
        "End_name": $("#txt_End_name").val(),
        "Lat": $("#txt_Lat").val(),
        "Lng": $("#txt_Lng").val(),
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
    /// <para>��Pc_end���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Pc_end : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Pc_end Factory()
        {
            return new Pc_end();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City_name
        {            
            get { return this.City_name; }
            set { this.City_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by
        {            
            get { return this.Create_by; }
            set { this.Create_by = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _End_name
        {            
            get { return this.End_name; }
            set { this.End_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Lat
        {            
            get { return this.Lat; }
            set { this.Lat = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Lng
        {            
            get { return this.Lng; }
            set { this.Lng = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string City_name
        {
            get { return this.m_city_name; }
            set //
            {
                if (!city_name_initialized || m_city_name != value)
                {
                    this.m_city_name = value;
                }
                city_name_initialized = true;
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
        public string End_name
        {
            get { return this.m_end_name; }
            set //
            {
                if (!end_name_initialized || m_end_name != value)
                {
                    this.m_end_name = value;
                }
                end_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public double Lat
        {
            get { return this.m_lat; }
            set //
            {
                if (!lat_initialized || m_lat != value)
                {
                    this.m_lat = value;
                }
                lat_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public double Lng
        {
            get { return this.m_lng; }
            set //
            {
                if (!lng_initialized || m_lng != value)
                {
                    this.m_lng = value;
                }
                lng_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Pc_end].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_name =  new AttributeItem("[Pc_end].[City_name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by =  new AttributeItem("[Pc_end].[Create_by]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem End_name =  new AttributeItem("[Pc_end].[End_name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lat =  new AttributeItem("[Pc_end].[Lat]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lng =  new AttributeItem("[Pc_end].[Lng]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Pc_end].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_city_name;
        /// <summary></summary>
        protected bool city_name_initialized = false;
        
        private string m_create_by;
        /// <summary></summary>
        protected bool create_by_initialized = false;
        
        private string m_end_name;
        /// <summary></summary>
        protected bool end_name_initialized = false;
        
        private double m_lat;
        /// <summary></summary>
        protected bool lat_initialized = false;
        
        private double m_lng;
        /// <summary></summary>
        protected bool lng_initialized = false;
        
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
            return "Pc_end";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.city_name_initialized = IsLoadAllAttributes;this.create_by_initialized = IsLoadAllAttributes;this.end_name_initialized = IsLoadAllAttributes;this.lat_initialized = IsLoadAllAttributes;this.lng_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Pc_end value = new Pc_end();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_name"))
				value.city_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by"))
				value.create_by_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"End_name"))
				value.end_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lat"))
				value.lat_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lng"))
				value.lng_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Pc_end Clone()
        {
            return (Pc_end)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Pc_end()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Pc_end() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Pc_end(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Pc_end(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Pc_end(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Pc_end(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Pc_end(int id1, string city_name1, string create_by1, string end_name1, double lat1, double lng1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.City_name = city_name1;
            
            this.Create_by = create_by1;
            
            this.End_name = end_name1;
            
            this.Lat = lat1;
            
            this.Lng = lng1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Pc_end FromIView(IView view)
        {
            return (Pc_end)IView.GetITable(view, "Pc_end");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Pc_end GetOneInstance()
        {
            Pc_end value = new Pc_end();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Pc_end Retrieve()
        {
            BLLTable<Pc_end>.GetRowData(this);
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
			    			
			    case "City_name":
			        return City_name;
			    			
			    case "Create_by":
			        return Create_by;
			    			
			    case "End_name":
			        return End_name;
			    			
			    case "Lat":
			        return Lat;
			    			
			    case "Lng":
			        return Lng;
			    			
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
			    			
			    case "City_name":
			        this.City_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by":
			        this.Create_by = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "End_name":
			        this.End_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Lat":
			        this.Lat = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Lng":
			        this.Lng = Convert.ToDouble(AttributeValue);
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
				
				case "City_name":
					return city_name_initialized;
				
				case "Create_by":
					return create_by_initialized;
				
				case "End_name":
					return end_name_initialized;
				
				case "Lat":
					return lat_initialized;
				
				case "Lng":
					return lng_initialized;
				
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
				
				case "City_name":
					city_name_initialized = ret;
					return true;
				
				case "Create_by":
					create_by_initialized = ret;
					return true;
				
				case "End_name":
					end_name_initialized = ret;
					return true;
				
				case "Lat":
					lat_initialized = ret;
					return true;
				
				case "Lng":
					lng_initialized = ret;
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
                AttributeItem attr = Pc_end.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (city_name_initialized)
			{
                AttributeItem attr = Pc_end.Attribute.City_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_name);
                }
			}
			
			if (create_by_initialized)
			{
                AttributeItem attr = Pc_end.Attribute.Create_by;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by);
                }
			}
			
			if (end_name_initialized)
			{
                AttributeItem attr = Pc_end.Attribute.End_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(End_name);
                }
			}
			
			if (lat_initialized)
			{
                AttributeItem attr = Pc_end.Attribute.Lat;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lat);
                }
			}
			
			if (lng_initialized)
			{
                AttributeItem attr = Pc_end.Attribute.Lng;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lng);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Pc_end.Attribute.Uuid;
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
        public class Pc_endJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string City_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string End_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Lat { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Lng { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
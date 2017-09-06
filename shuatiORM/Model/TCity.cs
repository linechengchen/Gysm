/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/22 18:01:00
  Description:    数据表TCity对应的业务逻辑层TCity
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TCity_Entity:TCity
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,City,Create_by,IsHot,Lat,Lng,Province from TCity
delete from TCity
INSERT INTO TCity (Id,City,Create_by,IsHot,Lat,Lng,Province)
     VALUES
           ('','','','','','','')
UPDATE TCity SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.City = valObj2.City;
        valObj.Create_by = valObj2.Create_by;
        valObj.IsHot = valObj2.IsHot;
        valObj.Lat = valObj2.Lat;
        valObj.Lng = valObj2.Lng;
        valObj.Province = valObj2.Province; 
        valObj.Id = "";
        valObj.City = "";
        valObj.Create_by = "";
        valObj.IsHot = "";
        valObj.Lat = "";
        valObj.Lng = "";
        valObj.Province = ""; 
        "Id": $("#txt_Id").val(),
        "City": $("#txt_City").val(),
        "Create_by": $("#txt_Create_by").val(),
        "IsHot": $("#txt_IsHot").val(),
        "Lat": $("#txt_Lat").val(),
        "Lng": $("#txt_Lng").val(),
        "Province": $("#txt_Province").val(), 
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
    /// <para>与TCity数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TCity : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TCity Factory()
        {
            return new TCity();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by
        {            
            get { return this.Create_by; }
            set { this.Create_by = value; }
        }
        
        /// <summary> 是否热搜:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsHot
        {            
            get { return this.IsHot; }
            set { this.IsHot = value; }
        }
        
        /// <summary> 经度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Lat
        {            
            get { return this.Lat; }
            set { this.Lat = value; }
        }
        
        /// <summary> 纬度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Lng
        {            
            get { return this.Lng; }
            set { this.Lng = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Province
        {            
            get { return this.Province; }
            set { this.Province = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 是否热搜:[CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 经度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Lat
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
        
        /// <summary> 纬度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public decimal Lng
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[TCity].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[TCity].[City]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by =  new AttributeItem("[TCity].[Create_by]", typeof(string), 50, default(string));
            
            /// <summary>是否热搜:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsHot =  new AttributeItem("[TCity].[IsHot]", typeof(bool), 1, default(bool));
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lat =  new AttributeItem("[TCity].[Lat]", typeof(decimal), 18, default(decimal));
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lng =  new AttributeItem("[TCity].[Lng]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Province =  new AttributeItem("[TCity].[Province]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_create_by;
        /// <summary></summary>
        protected bool create_by_initialized = false;
        
        private bool m_ishot;
        /// <summary></summary>
        protected bool ishot_initialized = false;
        
        private decimal m_lat;
        /// <summary></summary>
        protected bool lat_initialized = false;
        
        private decimal m_lng;
        /// <summary></summary>
        protected bool lng_initialized = false;
        
        private string m_province;
        /// <summary></summary>
        protected bool province_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TCity";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.create_by_initialized = IsLoadAllAttributes;this.ishot_initialized = IsLoadAllAttributes;this.lat_initialized = IsLoadAllAttributes;this.lng_initialized = IsLoadAllAttributes;this.province_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TCity value = new TCity();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by"))
				value.create_by_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHot"))
				value.ishot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lat"))
				value.lat_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lng"))
				value.lng_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province"))
				value.province_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TCity Clone()
        {
            return (TCity)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TCity()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TCity() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TCity(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TCity(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TCity(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TCity(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TCity(int id1, string city1, string create_by1, bool ishot1, decimal lat1, decimal lng1, string province1)
        {
            
            this.Id = id1;
            
            this.City = city1;
            
            this.Create_by = create_by1;
            
            this.IsHot = ishot1;
            
            this.Lat = lat1;
            
            this.Lng = lng1;
            
            this.Province = province1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TCity FromIView(IView view)
        {
            return (TCity)IView.GetITable(view, "TCity");
        }
        /// <summary>获得一个实例  </summary>
        public static TCity GetOneInstance()
        {
            TCity value = new TCity();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TCity Retrieve()
        {
            BLLTable<TCity>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Id":
			        return Id;
			    			
			    case "City":
			        return City;
			    			
			    case "Create_by":
			        return Create_by;
			    			
			    case "IsHot":
			        return IsHot;
			    			
			    case "Lat":
			        return Lat;
			    			
			    case "Lng":
			        return Lng;
			    			
			    case "Province":
			        return Province;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_by":
			        this.Create_by = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsHot":
			        this.IsHot = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Lat":
			        this.Lat = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Lng":
			        this.Lng = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Province":
			        this.Province = Convert.ToString(AttributeValue);
                    return true;
			
                default:
                    return base.SetValue(AttributeName, AttributeValue);
			}
        }
        
        /// <summary>通过属性 获取该字段是否已被初始化</summary>
        public override bool GetInitialized(AttributeItem AttributeName)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					return id_initialized;
				
				case "City":
					return city_initialized;
				
				case "Create_by":
					return create_by_initialized;
				
				case "IsHot":
					return ishot_initialized;
				
				case "Lat":
					return lat_initialized;
				
				case "Lng":
					return lng_initialized;
				
				case "Province":
					return province_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					id_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "Create_by":
					create_by_initialized = ret;
					return true;
				
				case "IsHot":
					ishot_initialized = ret;
					return true;
				
				case "Lat":
					lat_initialized = ret;
					return true;
				
				case "Lng":
					lng_initialized = ret;
					return true;
				
				case "Province":
					province_initialized = ret;
					return true;
				
                default:
                    return base.SetInitialized(AttributeName, ret);
			}
        }
        #endregion

        #region 获取DataParameter PropertyInfo

        /// <summary>
        /// 获取所有被初始化过的值，获取AttributeItem
        /// 目的为获取 System.Windows.Forms.DataGridViewTextBoxColumn[] 在中间数据层采用了 自定义的 MyDataGridViewTextBoxColumn (空类继承自 DataGridViewTextBoxColumn)
        /// 这里采用了两次遍历的方法，是为了避免拆装过程，使用源代码模式的时候，不会依赖于windows.form.dll。
        /// </summary>
        /// <returns></returns>
        public override AttributeItem[] af_GetAvailableAttributeItem(ref List<object> values)
        {
            List<AttributeItem> parametersList = new List<AttributeItem>();

			
			if (id_initialized)
			{
                AttributeItem attr = TCity.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = TCity.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (create_by_initialized)
			{
                AttributeItem attr = TCity.Attribute.Create_by;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by);
                }
			}
			
			if (ishot_initialized)
			{
                AttributeItem attr = TCity.Attribute.IsHot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHot);
                }
			}
			
			if (lat_initialized)
			{
                AttributeItem attr = TCity.Attribute.Lat;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lat);
                }
			}
			
			if (lng_initialized)
			{
                AttributeItem attr = TCity.Attribute.Lng;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lng);
                }
			}
			
			if (province_initialized)
			{
                AttributeItem attr = TCity.Attribute.Province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province);
                }
			}
			
            
			parametersList.AddRange(base.af_GetAvailableAttributeItem(ref values));
            return parametersList.ToArray();
        }
        #endregion                

        #region Json对象
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        [Serializable]
        public class TCityJson
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Create_by { get; set; }
            
            /// <summary>是否热搜:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsHot { get; set; }
            
            /// <summary>经度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Lat { get; set; }
            
            /// <summary>纬度:[CtrlTypeDic-{InputString}]</summary>
            public decimal Lng { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Province { get; set; }
        }
        #endregion
    }
}
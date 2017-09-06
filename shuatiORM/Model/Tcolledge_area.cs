/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/27 14:21:33
  Description:    数据表TColledge_area对应的业务逻辑层TColledge_area
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TColledge_area_Entity:TColledge_area
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Area_name,City_id,City_name from TColledge_area
delete from TColledge_area
INSERT INTO TColledge_area (Id,Area_name,City_id,City_name)
     VALUES
           ('','','','')
UPDATE TColledge_area SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Area_name = valObj2.Area_name;
        valObj.City_id = valObj2.City_id;
        valObj.City_name = valObj2.City_name; 
        valObj.Id = "";
        valObj.Area_name = "";
        valObj.City_id = "";
        valObj.City_name = ""; 
        "Id": $("#txt_Id").val(),
        "Area_name": $("#txt_Area_name").val(),
        "City_id": $("#txt_City_id").val(),
        "City_name": $("#txt_City_name").val(), 
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
    /// <para>大学城信息</para>
    /// <para>与TColledge_area数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TColledge_area : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TColledge_area Factory()
        {
            return new TColledge_area();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 大学城名字:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Area_name
        {            
            get { return this.Area_name; }
            set { this.Area_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
        }
        
        /// <summary> 城市名字:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City_name
        {            
            get { return this.City_name; }
            set { this.City_name = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 大学城名字:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Area_name
        {
            get { return this.m_area_name; }
            set //
            {
                if (!area_name_initialized || m_area_name != value)
                {
                    this.m_area_name = value;
                }
                area_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int City_id
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
        
        /// <summary> 城市名字:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[TColledge_area].[Id]", typeof(int), 4, default(int));
            
            /// <summary>大学城名字:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Area_name =  new AttributeItem("[TColledge_area].[Area_name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_id =  new AttributeItem("[TColledge_area].[City_id]", typeof(int), 4, default(int));
            
            /// <summary>城市名字:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_name =  new AttributeItem("[TColledge_area].[City_name]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_area_name;
        /// <summary></summary>
        protected bool area_name_initialized = false;
        
        private int m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        
        private string m_city_name;
        /// <summary></summary>
        protected bool city_name_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TColledge_area";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.area_name_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;this.city_name_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TColledge_area value = new TColledge_area();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Area_name"))
				value.area_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_name"))
				value.city_name_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TColledge_area Clone()
        {
            return (TColledge_area)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TColledge_area()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TColledge_area() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TColledge_area(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TColledge_area(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TColledge_area(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TColledge_area(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TColledge_area(int id1, string area_name1, int city_id1, string city_name1)
        {
            
            this.Id = id1;
            
            this.Area_name = area_name1;
            
            this.City_id = city_id1;
            
            this.City_name = city_name1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TColledge_area FromIView(IView view)
        {
            return (TColledge_area)IView.GetITable(view, "TColledge_area");
        }
        /// <summary>获得一个实例  </summary>
        public static TColledge_area GetOneInstance()
        {
            TColledge_area value = new TColledge_area();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TColledge_area Retrieve()
        {
            BLLTable<TColledge_area>.GetRowData(this);
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
			    			
			    case "Area_name":
			        return Area_name;
			    			
			    case "City_id":
			        return City_id;
			    			
			    case "City_name":
			        return City_name;
			
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
			    			
			    case "Area_name":
			        this.Area_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City_id":
			        this.City_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "City_name":
			        this.City_name = Convert.ToString(AttributeValue);
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
				
				case "Area_name":
					return area_name_initialized;
				
				case "City_id":
					return city_id_initialized;
				
				case "City_name":
					return city_name_initialized;
				
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
				
				case "Area_name":
					area_name_initialized = ret;
					return true;
				
				case "City_id":
					city_id_initialized = ret;
					return true;
				
				case "City_name":
					city_name_initialized = ret;
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
                AttributeItem attr = TColledge_area.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (area_name_initialized)
			{
                AttributeItem attr = TColledge_area.Attribute.Area_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Area_name);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = TColledge_area.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
                }
			}
			
			if (city_name_initialized)
			{
                AttributeItem attr = TColledge_area.Attribute.City_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_name);
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
        public class TColledge_areaJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>大学城名字:[CtrlTypeDic-{InputString}]</summary>
            public string Area_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int City_id { get; set; }
            
            /// <summary>城市名字:[CtrlTypeDic-{InputString}]</summary>
            public string City_name { get; set; }
        }
        #endregion
    }
}
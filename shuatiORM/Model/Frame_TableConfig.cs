/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/8/30 20:02:12
  Description:    数据表Frame_TableConfig对应的业务逻辑层Frame_TableConfig
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Frame_TableConfig_Entity:Frame_TableConfig
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Notes,Table_desc,Table_name,Uuid from Frame_TableConfig
delete from Frame_TableConfig
INSERT INTO Frame_TableConfig (Id,Notes,Table_desc,Table_name,Uuid)
     VALUES
           ('','','','','')
UPDATE Frame_TableConfig SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Notes = valObj2.Notes;
        valObj.Table_desc = valObj2.Table_desc;
        valObj.Table_name = valObj2.Table_name;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.Notes = "";
        valObj.Table_desc = "";
        valObj.Table_name = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "Notes": $("#txt_Notes").val(),
        "Table_desc": $("#txt_Table_desc").val(),
        "Table_name": $("#txt_Table_name").val(),
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
    /// <para>与Frame_TableConfig数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Frame_TableConfig : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Frame_TableConfig Factory()
        {
            return new Frame_TableConfig();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsPrimary </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Notes
        {            
            get { return this.Notes; }
            set { this.Notes = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Table_desc
        {            
            get { return this.Table_desc; }
            set { this.Table_desc = value; }
        }
        
        /// <summary> 字段名 Attribute_IsNotNull </summary>
        public string _Table_name
        {            
            get { return this.Table_name; }
            set { this.Table_name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Notes
        {
            get { return this.m_notes; }
            set //
            {
                if (!notes_initialized || m_notes != value)
                {
                    this.m_notes = value;
                }
                notes_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Table_desc
        {
            get { return this.m_table_desc; }
            set //
            {
                if (!table_desc_initialized || m_table_desc != value)
                {
                    this.m_table_desc = value;
                }
                table_desc_initialized = true;
            }
        }
        
        /// <summary> 字段名，推荐使用 "_"符号开头 </summary>
        public string Table_name
        {
            get { return this.m_table_name; }
            set //
            {
                if (!table_name_initialized || m_table_name != value)
                {
                    this.m_table_name = value;
                }
                table_name_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[Frame_TableConfig].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Notes =  new AttributeItem("[Frame_TableConfig].[Notes]", typeof(string), 2000, default(string));
            
            /// <summary></summary>
            public static AttributeItem Table_desc =  new AttributeItem("[Frame_TableConfig].[Table_desc]", typeof(string), 200, default(string));
            
            /// <summary>字段名</summary>
            public static AttributeItem Table_name =  new AttributeItem("[Frame_TableConfig].[Table_name]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[Frame_TableConfig].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_notes;
        /// <summary></summary>
        protected bool notes_initialized = false;
        
        private string m_table_desc;
        /// <summary></summary>
        protected bool table_desc_initialized = false;
        
        private string m_table_name;
        /// <summary></summary>
        protected bool table_name_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Frame_TableConfig";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.notes_initialized = IsLoadAllAttributes;this.table_desc_initialized = IsLoadAllAttributes;this.table_name_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Frame_TableConfig value = new Frame_TableConfig();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Notes"))
				value.notes_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Table_desc"))
				value.table_desc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Table_name"))
				value.table_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Frame_TableConfig Clone()
        {
            return (Frame_TableConfig)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Frame_TableConfig()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Frame_TableConfig() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Frame_TableConfig(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Frame_TableConfig(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Frame_TableConfig(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Frame_TableConfig(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Frame_TableConfig(int id1, string notes1, string table_desc1, string table_name1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.Notes = notes1;
            
            this.Table_desc = table_desc1;
            
            this.Table_name = table_name1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Frame_TableConfig FromIView(IView view)
        {
            return (Frame_TableConfig)IView.GetITable(view, "Frame_TableConfig");
        }
        /// <summary>获得一个实例  </summary>
        public static Frame_TableConfig GetOneInstance()
        {
            Frame_TableConfig value = new Frame_TableConfig();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Frame_TableConfig Retrieve()
        {
            BLLTable<Frame_TableConfig>.GetRowData(this);
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
			    			
			    case "Notes":
			        return Notes;
			    			
			    case "Table_desc":
			        return Table_desc;
			    			
			    case "Table_name":
			        return Table_name;
			    			
			    case "Uuid":
			        return Uuid;
			
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
			    			
			    case "Notes":
			        this.Notes = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Table_desc":
			        this.Table_desc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Table_name":
			        this.Table_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
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
				
				case "Notes":
					return notes_initialized;
				
				case "Table_desc":
					return table_desc_initialized;
				
				case "Table_name":
					return table_name_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
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
				
				case "Notes":
					notes_initialized = ret;
					return true;
				
				case "Table_desc":
					table_desc_initialized = ret;
					return true;
				
				case "Table_name":
					table_name_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
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
                AttributeItem attr = Frame_TableConfig.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (notes_initialized)
			{
                AttributeItem attr = Frame_TableConfig.Attribute.Notes;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Notes);
                }
			}
			
			if (table_desc_initialized)
			{
                AttributeItem attr = Frame_TableConfig.Attribute.Table_desc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Table_desc);
                }
			}
			
			if (table_name_initialized)
			{
                AttributeItem attr = Frame_TableConfig.Attribute.Table_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Table_name);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Frame_TableConfig.Attribute.Uuid;
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

        #region Json对象
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        [Serializable]
        public class Frame_TableConfigJson
        {
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public string Notes { get; set; }
            
            /// <summary></summary>
            public string Table_desc { get; set; }
            
            /// <summary>字段名</summary>
            public string Table_name { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
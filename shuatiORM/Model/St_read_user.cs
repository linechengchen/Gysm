/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/13 16:45:08
  Description:    数据表St_read_user对应的业务逻辑层St_read_user
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_read_user_Entity:St_read_user
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Chapter_id,Line_id,Line_index,Openid,Read_time,User_id from St_read_user
delete from St_read_user
INSERT INTO St_read_user (Id,Chapter_id,Line_id,Line_index,Openid,Read_time,User_id)
     VALUES
           ('','','','','','','')
UPDATE St_read_user SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Chapter_id = valObj2.Chapter_id;
        valObj.Line_id = valObj2.Line_id;
        valObj.Line_index = valObj2.Line_index;
        valObj.Openid = valObj2.Openid;
        valObj.Read_time = valObj2.Read_time;
        valObj.User_id = valObj2.User_id; 
        valObj.Id = "";
        valObj.Chapter_id = "";
        valObj.Line_id = "";
        valObj.Line_index = "";
        valObj.Openid = "";
        valObj.Read_time = "";
        valObj.User_id = ""; 
        "Id": $("#txt_Id").val(),
        "Chapter_id": $("#txt_Chapter_id").val(),
        "Line_id": $("#txt_Line_id").val(),
        "Line_index": $("#txt_Line_index").val(),
        "Openid": $("#txt_Openid").val(),
        "Read_time": $("#txt_Read_time").val(),
        "User_id": $("#txt_User_id").val(), 
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
    /// <para>与St_read_user数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_read_user : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_read_user Factory()
        {
            return new St_read_user();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Chapter_id
        {            
            get { return this.Chapter_id; }
            set { this.Chapter_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Line_id
        {            
            get { return this.Line_id; }
            set { this.Line_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Line_index
        {            
            get { return this.Line_index; }
            set { this.Line_index = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Openid
        {            
            get { return this.Openid; }
            set { this.Openid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Read_time
        {            
            get { return this.Read_time; }
            set { this.Read_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Chapter_id
        {
            get { return this.m_chapter_id; }
            set //
            {
                if (!chapter_id_initialized || m_chapter_id != value)
                {
                    this.m_chapter_id = value;
                }
                chapter_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Line_id
        {
            get { return this.m_line_id; }
            set //
            {
                if (!line_id_initialized || m_line_id != value)
                {
                    this.m_line_id = value;
                }
                line_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Line_index
        {
            get { return this.m_line_index; }
            set //
            {
                if (!line_index_initialized || m_line_index != value)
                {
                    this.m_line_index = value;
                }
                line_index_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Openid
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Read_time
        {
            get { return this.m_read_time; }
            set //
            {
                if (!read_time_initialized || m_read_time != value)
                {
                    this.m_read_time = value;
                }
                read_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_read_user].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Chapter_id =  new AttributeItem("[St_read_user].[Chapter_id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Line_id =  new AttributeItem("[St_read_user].[Line_id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Line_index =  new AttributeItem("[St_read_user].[Line_index]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Openid =  new AttributeItem("[St_read_user].[Openid]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Read_time =  new AttributeItem("[St_read_user].[Read_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[St_read_user].[User_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_chapter_id;
        /// <summary></summary>
        protected bool chapter_id_initialized = false;
        
        private int m_line_id;
        /// <summary></summary>
        protected bool line_id_initialized = false;
        
        private int m_line_index;
        /// <summary></summary>
        protected bool line_index_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private DateTime m_read_time;
        /// <summary></summary>
        protected bool read_time_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_read_user";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.chapter_id_initialized = IsLoadAllAttributes;this.line_id_initialized = IsLoadAllAttributes;this.line_index_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.read_time_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_read_user value = new St_read_user();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Chapter_id"))
				value.chapter_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Line_id"))
				value.line_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Line_index"))
				value.line_index_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Openid"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Read_time"))
				value.read_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_read_user Clone()
        {
            return (St_read_user)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_read_user()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_read_user() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_read_user(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_read_user(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_read_user(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_read_user(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_read_user(int id1, int chapter_id1, int line_id1, int line_index1, string openid1, DateTime read_time1, string user_id1)
        {
            
            this.Id = id1;
            
            this.Chapter_id = chapter_id1;
            
            this.Line_id = line_id1;
            
            this.Line_index = line_index1;
            
            this.Openid = openid1;
            
            this.Read_time = read_time1;
            
            this.User_id = user_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_read_user FromIView(IView view)
        {
            return (St_read_user)IView.GetITable(view, "St_read_user");
        }
        /// <summary>获得一个实例  </summary>
        public static St_read_user GetOneInstance()
        {
            St_read_user value = new St_read_user();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_read_user Retrieve()
        {
            BLLTable<St_read_user>.GetRowData(this);
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
			    			
			    case "Chapter_id":
			        return Chapter_id;
			    			
			    case "Line_id":
			        return Line_id;
			    			
			    case "Line_index":
			        return Line_index;
			    			
			    case "Openid":
			        return Openid;
			    			
			    case "Read_time":
			        return Read_time;
			    			
			    case "User_id":
			        return User_id;
			
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
			    			
			    case "Chapter_id":
			        this.Chapter_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Line_id":
			        this.Line_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Line_index":
			        this.Line_index = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Openid":
			        this.Openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Read_time":
			        this.Read_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
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
				
				case "Chapter_id":
					return chapter_id_initialized;
				
				case "Line_id":
					return line_id_initialized;
				
				case "Line_index":
					return line_index_initialized;
				
				case "Openid":
					return openid_initialized;
				
				case "Read_time":
					return read_time_initialized;
				
				case "User_id":
					return user_id_initialized;
				
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
				
				case "Chapter_id":
					chapter_id_initialized = ret;
					return true;
				
				case "Line_id":
					line_id_initialized = ret;
					return true;
				
				case "Line_index":
					line_index_initialized = ret;
					return true;
				
				case "Openid":
					openid_initialized = ret;
					return true;
				
				case "Read_time":
					read_time_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
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
                AttributeItem attr = St_read_user.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (chapter_id_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Chapter_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Chapter_id);
                }
			}
			
			if (line_id_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Line_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Line_id);
                }
			}
			
			if (line_index_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Line_index;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Line_index);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Openid);
                }
			}
			
			if (read_time_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Read_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Read_time);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
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
        public class St_read_userJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Chapter_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Line_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Line_index { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Openid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Read_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}
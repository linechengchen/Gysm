/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/20 23:47:30
  Description:    数据表St_read_book对应的业务逻辑层St_read_book
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_read_book_Entity:St_read_book
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Book_name,File_name,Kemu_id,Sc,School_id from St_read_book
delete from St_read_book
INSERT INTO St_read_book (Id,Book_name,File_name,Kemu_id,Sc,School_id)
     VALUES
           ('','','','','','')
UPDATE St_read_book SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Book_name = valObj2.Book_name;
        valObj.File_name = valObj2.File_name;
        valObj.Kemu_id = valObj2.Kemu_id;
        valObj.Sc = valObj2.Sc;
        valObj.School_id = valObj2.School_id; 
        valObj.Id = "";
        valObj.Book_name = "";
        valObj.File_name = "";
        valObj.Kemu_id = "";
        valObj.Sc = "";
        valObj.School_id = ""; 
        "Id": $("#txt_Id").val(),
        "Book_name": $("#txt_Book_name").val(),
        "File_name": $("#txt_File_name").val(),
        "Kemu_id": $("#txt_Kemu_id").val(),
        "Sc": $("#txt_Sc").val(),
        "School_id": $("#txt_School_id").val(), 
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
    /// <para>与St_read_book数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_read_book : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_read_book Factory()
        {
            return new St_read_book();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Book_name
        {            
            get { return this.Book_name; }
            set { this.Book_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _File_name
        {            
            get { return this.File_name; }
            set { this.File_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Kemu_id
        {            
            get { return this.Kemu_id; }
            set { this.Kemu_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _School_id
        {            
            get { return this.School_id; }
            set { this.School_id = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Book_name
        {
            get { return this.m_book_name; }
            set //
            {
                if (!book_name_initialized || m_book_name != value)
                {
                    this.m_book_name = value;
                }
                book_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}]，推荐使用 "_"符号开头 </summary>
        public string File_name
        {
            get { return this.m_file_name; }
            set //
            {
                if (!file_name_initialized || m_file_name != value)
                {
                    this.m_file_name = value;
                }
                file_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Kemu_id
        {
            get { return this.m_kemu_id; }
            set //
            {
                if (!kemu_id_initialized || m_kemu_id != value)
                {
                    this.m_kemu_id = value;
                }
                kemu_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Sc
        {
            get { return this.m_sc; }
            set //
            {
                if (!sc_initialized || m_sc != value)
                {
                    this.m_sc = value;
                }
                sc_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int School_id
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_read_book].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Book_name =  new AttributeItem("[St_read_book].[Book_name]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem File_name =  new AttributeItem("[St_read_book].[File_name]", typeof(string), 300, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu_id =  new AttributeItem("[St_read_book].[Kemu_id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[St_read_book].[Sc]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_id =  new AttributeItem("[St_read_book].[School_id]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_book_name;
        /// <summary></summary>
        protected bool book_name_initialized = false;
        
        private string m_file_name;
        /// <summary></summary>
        protected bool file_name_initialized = false;
        
        private int m_kemu_id;
        /// <summary></summary>
        protected bool kemu_id_initialized = false;
        
        private int m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private int m_school_id;
        /// <summary></summary>
        protected bool school_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_read_book";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.book_name_initialized = IsLoadAllAttributes;this.file_name_initialized = IsLoadAllAttributes;this.kemu_id_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.school_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_read_book value = new St_read_book();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Book_name"))
				value.book_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"File_name"))
				value.file_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_id"))
				value.kemu_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_id"))
				value.school_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_read_book Clone()
        {
            return (St_read_book)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_read_book()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_read_book() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_read_book(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_read_book(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_read_book(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_read_book(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_read_book(int id1, string book_name1, string file_name1, int kemu_id1, int sc1, int school_id1)
        {
            
            this.Id = id1;
            
            this.Book_name = book_name1;
            
            this.File_name = file_name1;
            
            this.Kemu_id = kemu_id1;
            
            this.Sc = sc1;
            
            this.School_id = school_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_read_book FromIView(IView view)
        {
            return (St_read_book)IView.GetITable(view, "St_read_book");
        }
        /// <summary>获得一个实例  </summary>
        public static St_read_book GetOneInstance()
        {
            St_read_book value = new St_read_book();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_read_book Retrieve()
        {
            BLLTable<St_read_book>.GetRowData(this);
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
			    			
			    case "Book_name":
			        return Book_name;
			    			
			    case "File_name":
			        return File_name;
			    			
			    case "Kemu_id":
			        return Kemu_id;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "School_id":
			        return School_id;
			
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
			    			
			    case "Book_name":
			        this.Book_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "File_name":
			        this.File_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Kemu_id":
			        this.Kemu_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "School_id":
			        this.School_id = Convert.ToInt32(AttributeValue);
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
				
				case "Book_name":
					return book_name_initialized;
				
				case "File_name":
					return file_name_initialized;
				
				case "Kemu_id":
					return kemu_id_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "School_id":
					return school_id_initialized;
				
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
				
				case "Book_name":
					book_name_initialized = ret;
					return true;
				
				case "File_name":
					file_name_initialized = ret;
					return true;
				
				case "Kemu_id":
					kemu_id_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "School_id":
					school_id_initialized = ret;
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
                AttributeItem attr = St_read_book.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (book_name_initialized)
			{
                AttributeItem attr = St_read_book.Attribute.Book_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Book_name);
                }
			}
			
			if (file_name_initialized)
			{
                AttributeItem attr = St_read_book.Attribute.File_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(File_name);
                }
			}
			
			if (kemu_id_initialized)
			{
                AttributeItem attr = St_read_book.Attribute.Kemu_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_id);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = St_read_book.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (school_id_initialized)
			{
                AttributeItem attr = St_read_book.Attribute.School_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_id);
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
        public class St_read_bookJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Book_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public string File_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Kemu_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Sc { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int School_id { get; set; }
        }
        #endregion
    }
}
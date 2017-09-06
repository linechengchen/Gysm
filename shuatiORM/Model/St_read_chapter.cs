/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/13 16:45:08
  Description:    数据表St_read_chapter对应的业务逻辑层St_read_chapter
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_read_chapter_Entity:St_read_chapter
 * 
************************************************************/
/************************************************************
SQL代码：
select Book_id,Chapter_name,File_name,Id from St_read_chapter
delete from St_read_chapter
INSERT INTO St_read_chapter (Book_id,Chapter_name,File_name,Id)
     VALUES
           ('','','','')
UPDATE St_read_chapter SET ...
变量赋值代码：
 *         valObj.Book_id = valObj2.Book_id;
        valObj.Chapter_name = valObj2.Chapter_name;
        valObj.File_name = valObj2.File_name;
        valObj.Id = valObj2.Id; 
        valObj.Book_id = "";
        valObj.Chapter_name = "";
        valObj.File_name = "";
        valObj.Id = ""; 
        "Book_id": $("#txt_Book_id").val(),
        "Chapter_name": $("#txt_Chapter_name").val(),
        "File_name": $("#txt_File_name").val(),
        "Id": $("#txt_Id").val(), 
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
    /// <para>与St_read_chapter数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_read_chapter : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_read_chapter Factory()
        {
            return new St_read_chapter();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Book_id
        {            
            get { return this.Book_id; }
            set { this.Book_id = value; }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Chapter_name
        {            
            get { return this.Chapter_name; }
            set { this.Chapter_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _File_name
        {            
            get { return this.File_name; }
            set { this.File_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Book_id
        {
            get { return this.m_book_id; }
            set //
            {
                if (!book_id_initialized || m_book_id != value)
                {
                    this.m_book_id = value;
                }
                book_id_initialized = true;
            }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Chapter_name
        {
            get { return this.m_chapter_name; }
            set //
            {
                if (!chapter_name_initialized || m_chapter_name != value)
                {
                    this.m_chapter_name = value;
                }
                chapter_name_initialized = true;
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Book_id =  new AttributeItem("[St_read_chapter].[Book_id]", typeof(int), 4, default(int));
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Chapter_name =  new AttributeItem("[St_read_chapter].[Chapter_name]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem File_name =  new AttributeItem("[St_read_chapter].[File_name]", typeof(string), 300, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_read_chapter].[Id]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_book_id;
        /// <summary></summary>
        protected bool book_id_initialized = false;
        
        private string m_chapter_name;
        /// <summary></summary>
        protected bool chapter_name_initialized = false;
        
        private string m_file_name;
        /// <summary></summary>
        protected bool file_name_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_read_chapter";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.book_id_initialized = IsLoadAllAttributes;this.chapter_name_initialized = IsLoadAllAttributes;this.file_name_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_read_chapter value = new St_read_chapter();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Book_id"))
				value.book_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Chapter_name"))
				value.chapter_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"File_name"))
				value.file_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_read_chapter Clone()
        {
            return (St_read_chapter)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_read_chapter()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_read_chapter() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_read_chapter(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_read_chapter(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_read_chapter(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_read_chapter(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_read_chapter(int book_id1, string chapter_name1, string file_name1, int id1)
        {
            
            this.Book_id = book_id1;
            
            this.Chapter_name = chapter_name1;
            
            this.File_name = file_name1;
            
            this.Id = id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_read_chapter FromIView(IView view)
        {
            return (St_read_chapter)IView.GetITable(view, "St_read_chapter");
        }
        /// <summary>获得一个实例  </summary>
        public static St_read_chapter GetOneInstance()
        {
            St_read_chapter value = new St_read_chapter();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_read_chapter Retrieve()
        {
            BLLTable<St_read_chapter>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Book_id":
			        return Book_id;
			    			
			    case "Chapter_name":
			        return Chapter_name;
			    			
			    case "File_name":
			        return File_name;
			    			
			    case "Id":
			        return Id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Book_id":
			        this.Book_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Chapter_name":
			        this.Chapter_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "File_name":
			        this.File_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
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
				case "Book_id":
					return book_id_initialized;
				
				case "Chapter_name":
					return chapter_name_initialized;
				
				case "File_name":
					return file_name_initialized;
				
				case "Id":
					return id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Book_id":
					book_id_initialized = ret;
					return true;
				
				case "Chapter_name":
					chapter_name_initialized = ret;
					return true;
				
				case "File_name":
					file_name_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
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

			
			if (book_id_initialized)
			{
                AttributeItem attr = St_read_chapter.Attribute.Book_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Book_id);
                }
			}
			
			if (chapter_name_initialized)
			{
                AttributeItem attr = St_read_chapter.Attribute.Chapter_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Chapter_name);
                }
			}
			
			if (file_name_initialized)
			{
                AttributeItem attr = St_read_chapter.Attribute.File_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(File_name);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = St_read_chapter.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
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
        public class St_read_chapterJson
        {
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public int Book_id { get; set; }
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public string Chapter_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public string File_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
        }
        #endregion
    }
}
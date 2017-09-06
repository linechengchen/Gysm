/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/13 16:45:08
  Description:    数据表St_read_line对应的业务逻辑层St_read_line
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 St_read_line_Entity:St_read_line
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Book_id,Chapter_id,Content,File_name,Has_img,Has_table,Index,Is_title,Kemu_id,Pager_num from St_read_line
delete from St_read_line
INSERT INTO St_read_line (Id,Book_id,Chapter_id,Content,File_name,Has_img,Has_table,Index,Is_title,Kemu_id,Pager_num)
     VALUES
           ('','','','','','','','','','','')
UPDATE St_read_line SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Book_id = valObj2.Book_id;
        valObj.Chapter_id = valObj2.Chapter_id;
        valObj.Content = valObj2.Content;
        valObj.File_name = valObj2.File_name;
        valObj.Has_img = valObj2.Has_img;
        valObj.Has_table = valObj2.Has_table;
        valObj.Index = valObj2.Index;
        valObj.Is_title = valObj2.Is_title;
        valObj.Kemu_id = valObj2.Kemu_id;
        valObj.Pager_num = valObj2.Pager_num; 
        valObj.Id = "";
        valObj.Book_id = "";
        valObj.Chapter_id = "";
        valObj.Content = "";
        valObj.File_name = "";
        valObj.Has_img = "";
        valObj.Has_table = "";
        valObj.Index = "";
        valObj.Is_title = "";
        valObj.Kemu_id = "";
        valObj.Pager_num = ""; 
        "Id": $("#txt_Id").val(),
        "Book_id": $("#txt_Book_id").val(),
        "Chapter_id": $("#txt_Chapter_id").val(),
        "Content": $("#txt_Content").val(),
        "File_name": $("#txt_File_name").val(),
        "Has_img": $("#txt_Has_img").val(),
        "Has_table": $("#txt_Has_table").val(),
        "Index": $("#txt_Index").val(),
        "Is_title": $("#txt_Is_title").val(),
        "Kemu_id": $("#txt_Kemu_id").val(),
        "Pager_num": $("#txt_Pager_num").val(), 
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
    /// <para>大学题库:[IDField-{Id:0}]</para>
    /// <para>与St_read_line数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class St_read_line : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static St_read_line Factory()
        {
            return new St_read_line();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 自动ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Book_id
        {            
            get { return this.Book_id; }
            set { this.Book_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Chapter_id
        {            
            get { return this.Chapter_id; }
            set { this.Chapter_id = value; }
        }
        
        /// <summary> 答案:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Content
        {            
            get { return this.Content; }
            set { this.Content = value; }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}] Attribute </summary>
        public string _File_name
        {            
            get { return this.File_name; }
            set { this.File_name = value; }
        }
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}] Attribute </summary>
        public bool _Has_img
        {            
            get { return this.Has_img; }
            set { this.Has_img = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _Has_table
        {            
            get { return this.Has_table; }
            set { this.Has_table = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Index
        {            
            get { return this.Index; }
            set { this.Index = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _Is_title
        {            
            get { return this.Is_title; }
            set { this.Is_title = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Kemu_id
        {            
            get { return this.Kemu_id; }
            set { this.Kemu_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Pager_num
        {            
            get { return this.Pager_num; }
            set { this.Pager_num = value; }
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
        
        /// <summary> 答案:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Content
        {
            get { return this.m_content; }
            set //
            {
                if (!content_initialized || m_content != value)
                {
                    this.m_content = value;
                }
                content_initialized = true;
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
        
        /// <summary> 章节编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public bool Has_img
        {
            get { return this.m_has_img; }
            set //
            {
                if (!has_img_initialized || m_has_img != value)
                {
                    this.m_has_img = value;
                }
                has_img_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool Has_table
        {
            get { return this.m_has_table; }
            set //
            {
                if (!has_table_initialized || m_has_table != value)
                {
                    this.m_has_table = value;
                }
                has_table_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Index
        {
            get { return this.m_index; }
            set //
            {
                if (!index_initialized || m_index != value)
                {
                    this.m_index = value;
                }
                index_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
        public bool Is_title
        {
            get { return this.m_is_title; }
            set //
            {
                if (!is_title_initialized || m_is_title != value)
                {
                    this.m_is_title = value;
                }
                is_title_initialized = true;
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
        public int Pager_num
        {
            get { return this.m_pager_num; }
            set //
            {
                if (!pager_num_initialized || m_pager_num != value)
                {
                    this.m_pager_num = value;
                }
                pager_num_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[St_read_line].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Book_id =  new AttributeItem("[St_read_line].[Book_id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Chapter_id =  new AttributeItem("[St_read_line].[Chapter_id]", typeof(int), 4, default(int));
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Content =  new AttributeItem("[St_read_line].[Content]", typeof(string), -1, default(string));
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem File_name =  new AttributeItem("[St_read_line].[File_name]", typeof(string), 300, default(string));
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Has_img =  new AttributeItem("[St_read_line].[Has_img]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Has_table =  new AttributeItem("[St_read_line].[Has_table]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Index =  new AttributeItem("[St_read_line].[Index]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Is_title =  new AttributeItem("[St_read_line].[Is_title]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu_id =  new AttributeItem("[St_read_line].[Kemu_id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pager_num =  new AttributeItem("[St_read_line].[Pager_num]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_book_id;
        /// <summary></summary>
        protected bool book_id_initialized = false;
        
        private int m_chapter_id;
        /// <summary></summary>
        protected bool chapter_id_initialized = false;
        
        private string m_content;
        /// <summary></summary>
        protected bool content_initialized = false;
        
        private string m_file_name;
        /// <summary></summary>
        protected bool file_name_initialized = false;
        
        private bool m_has_img;
        /// <summary></summary>
        protected bool has_img_initialized = false;
        
        private bool m_has_table;
        /// <summary></summary>
        protected bool has_table_initialized = false;
        
        private int m_index;
        /// <summary></summary>
        protected bool index_initialized = false;
        
        private bool m_is_title;
        /// <summary></summary>
        protected bool is_title_initialized = false;
        
        private int m_kemu_id;
        /// <summary></summary>
        protected bool kemu_id_initialized = false;
        
        private int m_pager_num;
        /// <summary></summary>
        protected bool pager_num_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_read_line";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.book_id_initialized = IsLoadAllAttributes;this.chapter_id_initialized = IsLoadAllAttributes;this.content_initialized = IsLoadAllAttributes;this.file_name_initialized = IsLoadAllAttributes;this.has_img_initialized = IsLoadAllAttributes;this.has_table_initialized = IsLoadAllAttributes;this.index_initialized = IsLoadAllAttributes;this.is_title_initialized = IsLoadAllAttributes;this.kemu_id_initialized = IsLoadAllAttributes;this.pager_num_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_read_line value = new St_read_line();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Book_id"))
				value.book_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Chapter_id"))
				value.chapter_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content"))
				value.content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"File_name"))
				value.file_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Has_img"))
				value.has_img_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Has_table"))
				value.has_table_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Index"))
				value.index_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_title"))
				value.is_title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_id"))
				value.kemu_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pager_num"))
				value.pager_num_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new St_read_line Clone()
        {
            return (St_read_line)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static St_read_line()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public St_read_line() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public St_read_line(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public St_read_line(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public St_read_line(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public St_read_line(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public St_read_line(int id1, int book_id1, int chapter_id1, string content1, string file_name1, bool has_img1, bool has_table1, int index1, bool is_title1, int kemu_id1, int pager_num1)
        {
            
            this.Id = id1;
            
            this.Book_id = book_id1;
            
            this.Chapter_id = chapter_id1;
            
            this.Content = content1;
            
            this.File_name = file_name1;
            
            this.Has_img = has_img1;
            
            this.Has_table = has_table1;
            
            this.Index = index1;
            
            this.Is_title = is_title1;
            
            this.Kemu_id = kemu_id1;
            
            this.Pager_num = pager_num1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static St_read_line FromIView(IView view)
        {
            return (St_read_line)IView.GetITable(view, "St_read_line");
        }
        /// <summary>获得一个实例  </summary>
        public static St_read_line GetOneInstance()
        {
            St_read_line value = new St_read_line();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public St_read_line Retrieve()
        {
            BLLTable<St_read_line>.GetRowData(this);
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
			    			
			    case "Book_id":
			        return Book_id;
			    			
			    case "Chapter_id":
			        return Chapter_id;
			    			
			    case "Content":
			        return Content;
			    			
			    case "File_name":
			        return File_name;
			    			
			    case "Has_img":
			        return Has_img;
			    			
			    case "Has_table":
			        return Has_table;
			    			
			    case "Index":
			        return Index;
			    			
			    case "Is_title":
			        return Is_title;
			    			
			    case "Kemu_id":
			        return Kemu_id;
			    			
			    case "Pager_num":
			        return Pager_num;
			
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
			    			
			    case "Book_id":
			        this.Book_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Chapter_id":
			        this.Chapter_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Content":
			        this.Content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "File_name":
			        this.File_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Has_img":
			        this.Has_img = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Has_table":
			        this.Has_table = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Index":
			        this.Index = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Is_title":
			        this.Is_title = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Kemu_id":
			        this.Kemu_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Pager_num":
			        this.Pager_num = Convert.ToInt32(AttributeValue);
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
				
				case "Book_id":
					return book_id_initialized;
				
				case "Chapter_id":
					return chapter_id_initialized;
				
				case "Content":
					return content_initialized;
				
				case "File_name":
					return file_name_initialized;
				
				case "Has_img":
					return has_img_initialized;
				
				case "Has_table":
					return has_table_initialized;
				
				case "Index":
					return index_initialized;
				
				case "Is_title":
					return is_title_initialized;
				
				case "Kemu_id":
					return kemu_id_initialized;
				
				case "Pager_num":
					return pager_num_initialized;
				
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
				
				case "Book_id":
					book_id_initialized = ret;
					return true;
				
				case "Chapter_id":
					chapter_id_initialized = ret;
					return true;
				
				case "Content":
					content_initialized = ret;
					return true;
				
				case "File_name":
					file_name_initialized = ret;
					return true;
				
				case "Has_img":
					has_img_initialized = ret;
					return true;
				
				case "Has_table":
					has_table_initialized = ret;
					return true;
				
				case "Index":
					index_initialized = ret;
					return true;
				
				case "Is_title":
					is_title_initialized = ret;
					return true;
				
				case "Kemu_id":
					kemu_id_initialized = ret;
					return true;
				
				case "Pager_num":
					pager_num_initialized = ret;
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
                AttributeItem attr = St_read_line.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (book_id_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.Book_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Book_id);
                }
			}
			
			if (chapter_id_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.Chapter_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Chapter_id);
                }
			}
			
			if (content_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.Content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content);
                }
			}
			
			if (file_name_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.File_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(File_name);
                }
			}
			
			if (has_img_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.Has_img;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Has_img);
                }
			}
			
			if (has_table_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.Has_table;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Has_table);
                }
			}
			
			if (index_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.Index;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Index);
                }
			}
			
			if (is_title_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.Is_title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_title);
                }
			}
			
			if (kemu_id_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.Kemu_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_id);
                }
			}
			
			if (pager_num_initialized)
			{
                AttributeItem attr = St_read_line.Attribute.Pager_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pager_num);
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
        public class St_read_lineJson
        {
            
            /// <summary>自动ID:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Book_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Chapter_id { get; set; }
            
            /// <summary>答案:[CtrlTypeDic-{InputString}]</summary>
            public string Content { get; set; }
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public string File_name { get; set; }
            
            /// <summary>章节编号:[CtrlTypeDic-{InputString}]</summary>
            public bool Has_img { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Has_table { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Index { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Is_title { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Kemu_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Pager_num { get; set; }
        }
        #endregion
    }
}
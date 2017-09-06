/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/8/17 17:02:13
  Description:    数据表Jd_task_comment对应的业务逻辑层Jd_task_comment
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jd_task_comment_Entity:Jd_task_comment
 * 
************************************************************/
/************************************************************
SQL代码：
select Task_comment_id,Comment_content,Comment_time,Commentator,Star_num,Task_id from Jd_task_comment
delete from Jd_task_comment
INSERT INTO Jd_task_comment (Task_comment_id,Comment_content,Comment_time,Commentator,Star_num,Task_id)
     VALUES
           ('','','','','','')
UPDATE Jd_task_comment SET ...
变量赋值代码：
 *         valObj.Task_comment_id = valObj2.Task_comment_id;
        valObj.Comment_content = valObj2.Comment_content;
        valObj.Comment_time = valObj2.Comment_time;
        valObj.Commentator = valObj2.Commentator;
        valObj.Star_num = valObj2.Star_num;
        valObj.Task_id = valObj2.Task_id; 
        valObj.Task_comment_id = "";
        valObj.Comment_content = "";
        valObj.Comment_time = "";
        valObj.Commentator = "";
        valObj.Star_num = "";
        valObj.Task_id = ""; 
        "Task_comment_id": $("#txt_Task_comment_id").val(),
        "Comment_content": $("#txt_Comment_content").val(),
        "Comment_time": $("#txt_Comment_time").val(),
        "Commentator": $("#txt_Commentator").val(),
        "Star_num": $("#txt_Star_num").val(),
        "Task_id": $("#txt_Task_id").val(), 
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
    /// <para>任务评论表</para>
    /// <para>与Jd_task_comment数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jd_task_comment : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jd_task_comment Factory()
        {
            return new Jd_task_comment();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 主键 Attribute_IsPrimary </summary>
        public Guid _Task_comment_id
        {            
            get { return this.Task_comment_id; }
            set { this.Task_comment_id = value; }
        }
        
        /// <summary> 评论内容 Attribute_IsNotNull </summary>
        public string _Comment_content
        {            
            get { return this.Comment_content; }
            set { this.Comment_content = value; }
        }
        
        /// <summary> 评论时间 Attribute_IsNotNull </summary>
        public DateTime _Comment_time
        {            
            get { return this.Comment_time; }
            set { this.Comment_time = value; }
        }
        
        /// <summary> 评论人 Attribute_IsNotNull </summary>
        public string _Commentator
        {            
            get { return this.Commentator; }
            set { this.Commentator = value; }
        }
        
        /// <summary> 星数(10-50表示1-5星) Attribute_IsNotNull </summary>
        public int _Star_num
        {            
            get { return this.Star_num; }
            set { this.Star_num = value; }
        }
        
        /// <summary> 任务ID Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 主键，推荐使用 "_"符号开头 </summary>
        public Guid Task_comment_id
        {
            get { return this.m_task_comment_id; }
            set //
            {
                if (!task_comment_id_initialized || m_task_comment_id != value)
                {
                    this.m_task_comment_id = value;
                }
                task_comment_id_initialized = true;
            }
        }
        
        /// <summary> 评论内容，推荐使用 "_"符号开头 </summary>
        public string Comment_content
        {
            get { return this.m_comment_content; }
            set //
            {
                if (!comment_content_initialized || m_comment_content != value)
                {
                    this.m_comment_content = value;
                }
                comment_content_initialized = true;
            }
        }
        
        /// <summary> 评论时间，推荐使用 "_"符号开头 </summary>
        public DateTime Comment_time
        {
            get { return this.m_comment_time; }
            set //
            {
                if (!comment_time_initialized || m_comment_time != value)
                {
                    this.m_comment_time = value;
                }
                comment_time_initialized = true;
            }
        }
        
        /// <summary> 评论人，推荐使用 "_"符号开头 </summary>
        public string Commentator
        {
            get { return this.m_commentator; }
            set //
            {
                if (!commentator_initialized || m_commentator != value)
                {
                    this.m_commentator = value;
                }
                commentator_initialized = true;
            }
        }
        
        /// <summary> 星数(10-50表示1-5星)，推荐使用 "_"符号开头 </summary>
        public int Star_num
        {
            get { return this.m_star_num; }
            set //
            {
                if (!star_num_initialized || m_star_num != value)
                {
                    this.m_star_num = value;
                }
                star_num_initialized = true;
            }
        }
        
        /// <summary> 任务ID，推荐使用 "_"符号开头 </summary>
        public string Task_id
        {
            get { return this.m_task_id; }
            set //
            {
                if (!task_id_initialized || m_task_id != value)
                {
                    this.m_task_id = value;
                }
                task_id_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>主键</summary>
            public static AttributeItem Task_comment_id =  new AttributeItem("[Jd_task_comment].[Task_comment_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>评论内容</summary>
            public static AttributeItem Comment_content =  new AttributeItem("[Jd_task_comment].[Comment_content]", typeof(string), 500, default(string));
            
            /// <summary>评论时间</summary>
            public static AttributeItem Comment_time =  new AttributeItem("[Jd_task_comment].[Comment_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>评论人</summary>
            public static AttributeItem Commentator =  new AttributeItem("[Jd_task_comment].[Commentator]", typeof(string), 50, default(string));
            
            /// <summary>星数(10-50表示1-5星)</summary>
            public static AttributeItem Star_num =  new AttributeItem("[Jd_task_comment].[Star_num]", typeof(int), 4, default(int));
            
            /// <summary>任务ID</summary>
            public static AttributeItem Task_id =  new AttributeItem("[Jd_task_comment].[Task_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_task_comment_id;
        /// <summary></summary>
        protected bool task_comment_id_initialized = false;
        
        private string m_comment_content;
        /// <summary></summary>
        protected bool comment_content_initialized = false;
        
        private DateTime m_comment_time;
        /// <summary></summary>
        protected bool comment_time_initialized = false;
        
        private string m_commentator;
        /// <summary></summary>
        protected bool commentator_initialized = false;
        
        private int m_star_num;
        /// <summary></summary>
        protected bool star_num_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jd_task_comment";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.task_comment_id_initialized = IsLoadAllAttributes;this.comment_content_initialized = IsLoadAllAttributes;this.comment_time_initialized = IsLoadAllAttributes;this.commentator_initialized = IsLoadAllAttributes;this.star_num_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jd_task_comment value = new Jd_task_comment();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_comment_id"))
				value.task_comment_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Comment_content"))
				value.comment_content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Comment_time"))
				value.comment_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Commentator"))
				value.commentator_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Star_num"))
				value.star_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jd_task_comment Clone()
        {
            return (Jd_task_comment)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jd_task_comment()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jd_task_comment() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jd_task_comment(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jd_task_comment(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jd_task_comment(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jd_task_comment(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jd_task_comment(Guid task_comment_id1, string comment_content1, DateTime comment_time1, string commentator1, int star_num1, string task_id1)
        {
            
            this.Task_comment_id = task_comment_id1;
            
            this.Comment_content = comment_content1;
            
            this.Comment_time = comment_time1;
            
            this.Commentator = commentator1;
            
            this.Star_num = star_num1;
            
            this.Task_id = task_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jd_task_comment FromIView(IView view)
        {
            return (Jd_task_comment)IView.GetITable(view, "Jd_task_comment");
        }
        /// <summary>获得一个实例  </summary>
        public static Jd_task_comment GetOneInstance()
        {
            Jd_task_comment value = new Jd_task_comment();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jd_task_comment Retrieve()
        {
            BLLTable<Jd_task_comment>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Task_comment_id":
			        return Task_comment_id;
			    			
			    case "Comment_content":
			        return Comment_content;
			    			
			    case "Comment_time":
			        return Comment_time;
			    			
			    case "Commentator":
			        return Commentator;
			    			
			    case "Star_num":
			        return Star_num;
			    			
			    case "Task_id":
			        return Task_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Task_comment_id":
			        this.Task_comment_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Comment_content":
			        this.Comment_content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Comment_time":
			        this.Comment_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Commentator":
			        this.Commentator = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Star_num":
			        this.Star_num = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
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
				case "Task_comment_id":
					return task_comment_id_initialized;
				
				case "Comment_content":
					return comment_content_initialized;
				
				case "Comment_time":
					return comment_time_initialized;
				
				case "Commentator":
					return commentator_initialized;
				
				case "Star_num":
					return star_num_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Task_comment_id":
					task_comment_id_initialized = ret;
					return true;
				
				case "Comment_content":
					comment_content_initialized = ret;
					return true;
				
				case "Comment_time":
					comment_time_initialized = ret;
					return true;
				
				case "Commentator":
					commentator_initialized = ret;
					return true;
				
				case "Star_num":
					star_num_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
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

			
			if (task_comment_id_initialized)
			{
                AttributeItem attr = Jd_task_comment.Attribute.Task_comment_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_comment_id);
                }
			}
			
			if (comment_content_initialized)
			{
                AttributeItem attr = Jd_task_comment.Attribute.Comment_content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Comment_content);
                }
			}
			
			if (comment_time_initialized)
			{
                AttributeItem attr = Jd_task_comment.Attribute.Comment_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Comment_time);
                }
			}
			
			if (commentator_initialized)
			{
                AttributeItem attr = Jd_task_comment.Attribute.Commentator;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Commentator);
                }
			}
			
			if (star_num_initialized)
			{
                AttributeItem attr = Jd_task_comment.Attribute.Star_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Star_num);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = Jd_task_comment.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
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
        public class Jd_task_commentJson
        {
            
            /// <summary>主键</summary>
            public Guid Task_comment_id { get; set; }
            
            /// <summary>评论内容</summary>
            public string Comment_content { get; set; }
            
            /// <summary>评论时间</summary>
            public DateTime Comment_time { get; set; }
            
            /// <summary>评论人</summary>
            public string Commentator { get; set; }
            
            /// <summary>星数(10-50表示1-5星)</summary>
            public int Star_num { get; set; }
            
            /// <summary>任务ID</summary>
            public string Task_id { get; set; }
        }
        #endregion
    }
}
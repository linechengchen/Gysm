/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/8/15 23:04:43
  Description:    数据表Jd_task_accept_allow对应的业务逻辑层Jd_task_accept_allow
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jd_task_accept_allow_Entity:Jd_task_accept_allow
 * 
************************************************************/
/************************************************************
SQL代码：
select Accept_allow_id,State,Task_id,Update_time,User_id from Jd_task_accept_allow
delete from Jd_task_accept_allow
INSERT INTO Jd_task_accept_allow (Accept_allow_id,State,Task_id,Update_time,User_id)
     VALUES
           ('','','','','')
UPDATE Jd_task_accept_allow SET ...
变量赋值代码：
 *         valObj.Accept_allow_id = valObj2.Accept_allow_id;
        valObj.State = valObj2.State;
        valObj.Task_id = valObj2.Task_id;
        valObj.Update_time = valObj2.Update_time;
        valObj.User_id = valObj2.User_id; 
        valObj.Accept_allow_id = "";
        valObj.State = "";
        valObj.Task_id = "";
        valObj.Update_time = "";
        valObj.User_id = ""; 
        "Accept_allow_id": $("#txt_Accept_allow_id").val(),
        "State": $("#txt_State").val(),
        "Task_id": $("#txt_Task_id").val(),
        "Update_time": $("#txt_Update_time").val(),
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
    /// <para>任务允许接单表</para>
    /// <para>与Jd_task_accept_allow数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jd_task_accept_allow : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jd_task_accept_allow Factory()
        {
            return new Jd_task_accept_allow();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 主键 Attribute_IsPrimary </summary>
        public Guid _Accept_allow_id
        {            
            get { return this.Accept_allow_id; }
            set { this.Accept_allow_id = value; }
        }
        
        /// <summary> 状态:[Enum-{0:无效},{1:有效}] Attribute_IsNotNull </summary>
        public string _State
        {            
            get { return this.State; }
            set { this.State = value; }
        }
        
        /// <summary> 任务ID Attribute_IsNotNull </summary>
        public string _Task_id
        {            
            get { return this.Task_id; }
            set { this.Task_id = value; }
        }
        
        /// <summary> 更新时间 Attribute_IsNotNull </summary>
        public DateTime _Update_time
        {            
            get { return this.Update_time; }
            set { this.Update_time = value; }
        }
        
        /// <summary> 允许接单的用户ID Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 主键，推荐使用 "_"符号开头 </summary>
        public Guid Accept_allow_id
        {
            get { return this.m_accept_allow_id; }
            set //
            {
                if (!accept_allow_id_initialized || m_accept_allow_id != value)
                {
                    this.m_accept_allow_id = value;
                }
                accept_allow_id_initialized = true;
            }
        }
        
        /// <summary> 状态:[Enum-{0:无效},{1:有效}]，推荐使用 "_"符号开头 </summary>
        public string State
        {
            get { return this.m_state; }
            set //
            {
                if (!state_initialized || m_state != value)
                {
                    this.m_state = value;
                }
                state_initialized = true;
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
        
        /// <summary> 更新时间，推荐使用 "_"符号开头 </summary>
        public DateTime Update_time
        {
            get { return this.m_update_time; }
            set //
            {
                if (!update_time_initialized || m_update_time != value)
                {
                    this.m_update_time = value;
                }
                update_time_initialized = true;
            }
        }
        
        /// <summary> 允许接单的用户ID，推荐使用 "_"符号开头 </summary>
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
            
            /// <summary>主键</summary>
            public static AttributeItem Accept_allow_id =  new AttributeItem("[Jd_task_accept_allow].[Accept_allow_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>状态:[Enum-{0:无效},{1:有效}]</summary>
            public static AttributeItem State =  new AttributeItem("[Jd_task_accept_allow].[State]", typeof(string), 10, default(string));
            
            /// <summary>任务ID</summary>
            public static AttributeItem Task_id =  new AttributeItem("[Jd_task_accept_allow].[Task_id]", typeof(string), 36, default(string));
            
            /// <summary>更新时间</summary>
            public static AttributeItem Update_time =  new AttributeItem("[Jd_task_accept_allow].[Update_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>允许接单的用户ID</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jd_task_accept_allow].[User_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_accept_allow_id;
        /// <summary></summary>
        protected bool accept_allow_id_initialized = false;
        
        private string m_state;
        /// <summary></summary>
        protected bool state_initialized = false;
        
        private string m_task_id;
        /// <summary></summary>
        protected bool task_id_initialized = false;
        
        private DateTime m_update_time;
        /// <summary></summary>
        protected bool update_time_initialized = false;
        
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
            return "Jd_task_accept_allow";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.accept_allow_id_initialized = IsLoadAllAttributes;this.state_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;this.update_time_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jd_task_accept_allow value = new Jd_task_accept_allow();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Accept_allow_id"))
				value.accept_allow_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"State"))
				value.state_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Update_time"))
				value.update_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jd_task_accept_allow Clone()
        {
            return (Jd_task_accept_allow)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jd_task_accept_allow()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jd_task_accept_allow() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jd_task_accept_allow(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jd_task_accept_allow(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jd_task_accept_allow(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jd_task_accept_allow(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jd_task_accept_allow(Guid accept_allow_id1, string state1, string task_id1, DateTime update_time1, string user_id1)
        {
            
            this.Accept_allow_id = accept_allow_id1;
            
            this.State = state1;
            
            this.Task_id = task_id1;
            
            this.Update_time = update_time1;
            
            this.User_id = user_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jd_task_accept_allow FromIView(IView view)
        {
            return (Jd_task_accept_allow)IView.GetITable(view, "Jd_task_accept_allow");
        }
        /// <summary>获得一个实例  </summary>
        public static Jd_task_accept_allow GetOneInstance()
        {
            Jd_task_accept_allow value = new Jd_task_accept_allow();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jd_task_accept_allow Retrieve()
        {
            BLLTable<Jd_task_accept_allow>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Accept_allow_id":
			        return Accept_allow_id;
			    			
			    case "State":
			        return State;
			    			
			    case "Task_id":
			        return Task_id;
			    			
			    case "Update_time":
			        return Update_time;
			    			
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
			    case "Accept_allow_id":
			        this.Accept_allow_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "State":
			        this.State = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Task_id":
			        this.Task_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Update_time":
			        this.Update_time = Convert.ToDateTime(AttributeValue);
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
				case "Accept_allow_id":
					return accept_allow_id_initialized;
				
				case "State":
					return state_initialized;
				
				case "Task_id":
					return task_id_initialized;
				
				case "Update_time":
					return update_time_initialized;
				
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
				case "Accept_allow_id":
					accept_allow_id_initialized = ret;
					return true;
				
				case "State":
					state_initialized = ret;
					return true;
				
				case "Task_id":
					task_id_initialized = ret;
					return true;
				
				case "Update_time":
					update_time_initialized = ret;
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

			
			if (accept_allow_id_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.Accept_allow_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Accept_allow_id);
                }
			}
			
			if (state_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.State;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(State);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.Task_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_id);
                }
			}
			
			if (update_time_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.Update_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Update_time);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jd_task_accept_allow.Attribute.User_id;
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
        public class Jd_task_accept_allowJson
        {
            
            /// <summary>主键</summary>
            public Guid Accept_allow_id { get; set; }
            
            /// <summary>状态:[Enum-{0:无效},{1:有效}]</summary>
            public string State { get; set; }
            
            /// <summary>任务ID</summary>
            public string Task_id { get; set; }
            
            /// <summary>更新时间</summary>
            public DateTime Update_time { get; set; }
            
            /// <summary>允许接单的用户ID</summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}
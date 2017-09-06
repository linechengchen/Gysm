/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/9/1 18:20:36
  Description:    数据表Xb_job_apply对应的业务逻辑层Xb_job_apply
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_job_apply_Entity:Xb_job_apply
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,_title,Create_time,Job_uuid,User_id,Uuid from Xb_job_apply
delete from Xb_job_apply
INSERT INTO Xb_job_apply (Id,_title,Create_time,Job_uuid,User_id,Uuid)
     VALUES
           ('','','','','','')
UPDATE Xb_job_apply SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj._title = valObj2._title;
        valObj.Create_time = valObj2.Create_time;
        valObj.Job_uuid = valObj2.Job_uuid;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj._title = "";
        valObj.Create_time = "";
        valObj.Job_uuid = "";
        valObj.User_id = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "_title": $("#txt__title").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Job_uuid": $("#txt_Job_uuid").val(),
        "User_id": $("#txt_User_id").val(),
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
    /// <para>与Xb_job_apply数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_job_apply : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_job_apply Factory()
        {
            return new Xb_job_apply();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string __title
        {            
            get { return this._title; }
            set { this._title = value; }
        }
        
        /// <summary>  Attribute </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Job_uuid
        {            
            get { return this.Job_uuid; }
            set { this.Job_uuid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
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
            set //private 
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string _title
        {
            get { return this.m__title; }
            set //
            {
                if (!_title_initialized || m__title != value)
                {
                    this.m__title = value;
                }
                _title_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public DateTime Create_time
        {
            get { return this.m_create_time; }
            set //
            {
                if (!create_time_initialized || m_create_time != value)
                {
                    this.m_create_time = value;
                }
                create_time_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public Guid Job_uuid
        {
            get { return this.m_job_uuid; }
            set //
            {
                if (!job_uuid_initialized || m_job_uuid != value)
                {
                    this.m_job_uuid = value;
                }
                job_uuid_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public Guid User_id
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
            public static AttributeItem Id =  new AttributeItem("[Xb_job_apply].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem _title =  new AttributeItem("[Xb_job_apply].[_title]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xb_job_apply].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Job_uuid =  new AttributeItem("[Xb_job_apply].[Job_uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_job_apply].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_job_apply].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m__title;
        /// <summary></summary>
        protected bool _title_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private Guid m_job_uuid;
        /// <summary></summary>
        protected bool job_uuid_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
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
            return "Xb_job_apply";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this._title_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.job_uuid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_job_apply value = new Xb_job_apply();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"_title"))
				value._title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Job_uuid"))
				value.job_uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_job_apply Clone()
        {
            return (Xb_job_apply)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_job_apply()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_job_apply() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_job_apply(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_job_apply(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_job_apply(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_job_apply(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_job_apply(int id1, string _title1, DateTime create_time1, Guid job_uuid1, Guid user_id1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this._title = _title1;
            
            this.Create_time = create_time1;
            
            this.Job_uuid = job_uuid1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_job_apply FromIView(IView view)
        {
            return (Xb_job_apply)IView.GetITable(view, "Xb_job_apply");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_job_apply GetOneInstance()
        {
            Xb_job_apply value = new Xb_job_apply();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_job_apply Retrieve()
        {
            BLLTable<Xb_job_apply>.GetRowData(this);
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
			    			
			    case "_title":
			        return _title;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Job_uuid":
			        return Job_uuid;
			    			
			    case "User_id":
			        return User_id;
			    			
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
			    			
			    case "_title":
			        this._title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Job_uuid":
			        this.Job_uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
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
				
				case "_title":
					return _title_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Job_uuid":
					return job_uuid_initialized;
				
				case "User_id":
					return user_id_initialized;
				
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
				
				case "_title":
					_title_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Job_uuid":
					job_uuid_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
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
                AttributeItem attr = Xb_job_apply.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (_title_initialized)
			{
                AttributeItem attr = Xb_job_apply.Attribute._title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(_title);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xb_job_apply.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (job_uuid_initialized)
			{
                AttributeItem attr = Xb_job_apply.Attribute.Job_uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Job_uuid);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_job_apply.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_job_apply.Attribute.Uuid;
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
        public class Xb_job_applyJson
        {
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public string _title { get; set; }
            
            /// <summary></summary>
            public DateTime Create_time { get; set; }
            
            /// <summary></summary>
            public Guid Job_uuid { get; set; }
            
            /// <summary></summary>
            public Guid User_id { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
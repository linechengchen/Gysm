/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/9/1 16:09:22
  Description:    数据表Xb_job对应的业务逻辑层Xb_job
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_job_Entity:Xb_job
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,_title,Address,Is_complete,Job_code,Salary,Salary_unit,Uuid from Xb_job
delete from Xb_job
INSERT INTO Xb_job (Id,_title,Address,Is_complete,Job_code,Salary,Salary_unit,Uuid)
     VALUES
           ('','','','','','','','')
UPDATE Xb_job SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj._title = valObj2._title;
        valObj.Address = valObj2.Address;
        valObj.Is_complete = valObj2.Is_complete;
        valObj.Job_code = valObj2.Job_code;
        valObj.Salary = valObj2.Salary;
        valObj.Salary_unit = valObj2.Salary_unit;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj._title = "";
        valObj.Address = "";
        valObj.Is_complete = "";
        valObj.Job_code = "";
        valObj.Salary = "";
        valObj.Salary_unit = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "_title": $("#txt__title").val(),
        "Address": $("#txt_Address").val(),
        "Is_complete": $("#txt_Is_complete").val(),
        "Job_code": $("#txt_Job_code").val(),
        "Salary": $("#txt_Salary").val(),
        "Salary_unit": $("#txt_Salary_unit").val(),
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
    /// <para>学霸家教订单信息</para>
    /// <para>与Xb_job数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_job : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_job Factory()
        {
            return new Xb_job();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 家教工作内容 Attribute </summary>
        public string __title
        {            
            get { return this._title; }
            set { this._title = value; }
        }
        
        /// <summary> 详细地址 Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> 是否已完成 Attribute </summary>
        public bool _Is_complete
        {            
            get { return this.Is_complete; }
            set { this.Is_complete = value; }
        }
        
        /// <summary> 家教编号 Attribute_IsNotNull </summary>
        public int _Job_code
        {            
            get { return this.Job_code; }
            set { this.Job_code = value; }
        }
        
        /// <summary> 薪资 Attribute_IsNotNull </summary>
        public string _Salary
        {            
            get { return this.Salary; }
            set { this.Salary = value; }
        }
        
        /// <summary> 薪资单位1 Attribute_IsNotNull </summary>
        public string _Salary_unit
        {            
            get { return this.Salary_unit; }
            set { this.Salary_unit = value; }
        }
        
        /// <summary> 家教uuid Attribute </summary>
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
        
        /// <summary> 家教工作内容，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 详细地址，推荐使用 "_"符号开头 </summary>
        public string Address
        {
            get { return this.m_address; }
            set //
            {
                if (!address_initialized || m_address != value)
                {
                    this.m_address = value;
                }
                address_initialized = true;
            }
        }
        
        /// <summary> 是否已完成，推荐使用 "_"符号开头 </summary>
        public bool Is_complete
        {
            get { return this.m_is_complete; }
            set //
            {
                if (!is_complete_initialized || m_is_complete != value)
                {
                    this.m_is_complete = value;
                }
                is_complete_initialized = true;
            }
        }
        
        /// <summary> 家教编号，推荐使用 "_"符号开头 </summary>
        public int Job_code
        {
            get { return this.m_job_code; }
            set //
            {
                if (!job_code_initialized || m_job_code != value)
                {
                    this.m_job_code = value;
                }
                job_code_initialized = true;
            }
        }
        
        /// <summary> 薪资，推荐使用 "_"符号开头 </summary>
        public string Salary
        {
            get { return this.m_salary; }
            set //
            {
                if (!salary_initialized || m_salary != value)
                {
                    this.m_salary = value;
                }
                salary_initialized = true;
            }
        }
        
        /// <summary> 薪资单位1，推荐使用 "_"符号开头 </summary>
        public string Salary_unit
        {
            get { return this.m_salary_unit; }
            set //
            {
                if (!salary_unit_initialized || m_salary_unit != value)
                {
                    this.m_salary_unit = value;
                }
                salary_unit_initialized = true;
            }
        }
        
        /// <summary> 家教uuid，推荐使用 "_"符号开头 </summary>
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
            public static AttributeItem Id =  new AttributeItem("[Xb_job].[Id]", typeof(int), 4, default(int));
            
            /// <summary>家教工作内容</summary>
            public static AttributeItem _title =  new AttributeItem("[Xb_job].[_title]", typeof(string), 2000, default(string));
            
            /// <summary>详细地址</summary>
            public static AttributeItem Address =  new AttributeItem("[Xb_job].[Address]", typeof(string), 100, default(string));
            
            /// <summary>是否已完成</summary>
            public static AttributeItem Is_complete =  new AttributeItem("[Xb_job].[Is_complete]", typeof(bool), 1, default(bool));
            
            /// <summary>家教编号</summary>
            public static AttributeItem Job_code =  new AttributeItem("[Xb_job].[Job_code]", typeof(int), 4, default(int));
            
            /// <summary>薪资</summary>
            public static AttributeItem Salary =  new AttributeItem("[Xb_job].[Salary]", typeof(string), 100, default(string));
            
            /// <summary>薪资单位1</summary>
            public static AttributeItem Salary_unit =  new AttributeItem("[Xb_job].[Salary_unit]", typeof(string), 50, default(string));
            
            /// <summary>家教uuid</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_job].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m__title;
        /// <summary></summary>
        protected bool _title_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private bool m_is_complete;
        /// <summary></summary>
        protected bool is_complete_initialized = false;
        
        private int m_job_code;
        /// <summary></summary>
        protected bool job_code_initialized = false;
        
        private string m_salary;
        /// <summary></summary>
        protected bool salary_initialized = false;
        
        private string m_salary_unit;
        /// <summary></summary>
        protected bool salary_unit_initialized = false;
        
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
            return "Xb_job";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this._title_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.is_complete_initialized = IsLoadAllAttributes;this.job_code_initialized = IsLoadAllAttributes;this.salary_initialized = IsLoadAllAttributes;this.salary_unit_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_job value = new Xb_job();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"_title"))
				value._title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_complete"))
				value.is_complete_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Job_code"))
				value.job_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Salary"))
				value.salary_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Salary_unit"))
				value.salary_unit_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_job Clone()
        {
            return (Xb_job)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_job()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_job() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_job(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_job(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_job(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_job(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_job(int id1, string _title1, string address1, bool is_complete1, int job_code1, string salary1, string salary_unit1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this._title = _title1;
            
            this.Address = address1;
            
            this.Is_complete = is_complete1;
            
            this.Job_code = job_code1;
            
            this.Salary = salary1;
            
            this.Salary_unit = salary_unit1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_job FromIView(IView view)
        {
            return (Xb_job)IView.GetITable(view, "Xb_job");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_job GetOneInstance()
        {
            Xb_job value = new Xb_job();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_job Retrieve()
        {
            BLLTable<Xb_job>.GetRowData(this);
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
			    			
			    case "Address":
			        return Address;
			    			
			    case "Is_complete":
			        return Is_complete;
			    			
			    case "Job_code":
			        return Job_code;
			    			
			    case "Salary":
			        return Salary;
			    			
			    case "Salary_unit":
			        return Salary_unit;
			    			
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
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_complete":
			        this.Is_complete = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Job_code":
			        this.Job_code = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Salary":
			        this.Salary = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Salary_unit":
			        this.Salary_unit = Convert.ToString(AttributeValue);
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
				
				case "Address":
					return address_initialized;
				
				case "Is_complete":
					return is_complete_initialized;
				
				case "Job_code":
					return job_code_initialized;
				
				case "Salary":
					return salary_initialized;
				
				case "Salary_unit":
					return salary_unit_initialized;
				
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
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "Is_complete":
					is_complete_initialized = ret;
					return true;
				
				case "Job_code":
					job_code_initialized = ret;
					return true;
				
				case "Salary":
					salary_initialized = ret;
					return true;
				
				case "Salary_unit":
					salary_unit_initialized = ret;
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
                AttributeItem attr = Xb_job.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (_title_initialized)
			{
                AttributeItem attr = Xb_job.Attribute._title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(_title);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = Xb_job.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (is_complete_initialized)
			{
                AttributeItem attr = Xb_job.Attribute.Is_complete;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_complete);
                }
			}
			
			if (job_code_initialized)
			{
                AttributeItem attr = Xb_job.Attribute.Job_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Job_code);
                }
			}
			
			if (salary_initialized)
			{
                AttributeItem attr = Xb_job.Attribute.Salary;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Salary);
                }
			}
			
			if (salary_unit_initialized)
			{
                AttributeItem attr = Xb_job.Attribute.Salary_unit;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Salary_unit);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_job.Attribute.Uuid;
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
        public class Xb_jobJson
        {
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary>家教工作内容</summary>
            public string _title { get; set; }
            
            /// <summary>详细地址</summary>
            public string Address { get; set; }
            
            /// <summary>是否已完成</summary>
            public bool Is_complete { get; set; }
            
            /// <summary>家教编号</summary>
            public int Job_code { get; set; }
            
            /// <summary>薪资</summary>
            public string Salary { get; set; }
            
            /// <summary>薪资单位1</summary>
            public string Salary_unit { get; set; }
            
            /// <summary>家教uuid</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
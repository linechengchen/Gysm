/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/8/17 17:01:44
  Description:    数据表Jd_task_detail_jj对应的业务逻辑层Jd_task_detail_jj
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Jd_task_detail_jj_Entity:Jd_task_detail_jj
 * 
************************************************************/
/************************************************************
SQL代码：
select Task_detail_id,Grade,Introduce,Manydays,Subject,Task_id from Jd_task_detail_jj
delete from Jd_task_detail_jj
INSERT INTO Jd_task_detail_jj (Task_detail_id,Grade,Introduce,Manydays,Subject,Task_id)
     VALUES
           ('','','','','','')
UPDATE Jd_task_detail_jj SET ...
变量赋值代码：
 *         valObj.Task_detail_id = valObj2.Task_detail_id;
        valObj.Grade = valObj2.Grade;
        valObj.Introduce = valObj2.Introduce;
        valObj.Manydays = valObj2.Manydays;
        valObj.Subject = valObj2.Subject;
        valObj.Task_id = valObj2.Task_id; 
        valObj.Task_detail_id = "";
        valObj.Grade = "";
        valObj.Introduce = "";
        valObj.Manydays = "";
        valObj.Subject = "";
        valObj.Task_id = ""; 
        "Task_detail_id": $("#txt_Task_detail_id").val(),
        "Grade": $("#txt_Grade").val(),
        "Introduce": $("#txt_Introduce").val(),
        "Manydays": $("#txt_Manydays").val(),
        "Subject": $("#txt_Subject").val(),
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
    /// <para>任务明细家教表</para>
    /// <para>与Jd_task_detail_jj数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Jd_task_detail_jj : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Jd_task_detail_jj Factory()
        {
            return new Jd_task_detail_jj();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 主键 Attribute_IsPrimary </summary>
        public Guid _Task_detail_id
        {            
            get { return this.Task_detail_id; }
            set { this.Task_detail_id = value; }
        }
        
        /// <summary> 年级(多个用,分开） Attribute_IsNotNull </summary>
        public string _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> 介绍 Attribute_IsNotNull </summary>
        public string _Introduce
        {            
            get { return this.Introduce; }
            set { this.Introduce = value; }
        }
        
        /// <summary> 几天 Attribute_IsNotNull </summary>
        public int _Manydays
        {            
            get { return this.Manydays; }
            set { this.Manydays = value; }
        }
        
        /// <summary> 科目(多个用,分开） Attribute_IsNotNull </summary>
        public string _Subject
        {            
            get { return this.Subject; }
            set { this.Subject = value; }
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
        public Guid Task_detail_id
        {
            get { return this.m_task_detail_id; }
            set //
            {
                if (!task_detail_id_initialized || m_task_detail_id != value)
                {
                    this.m_task_detail_id = value;
                }
                task_detail_id_initialized = true;
            }
        }
        
        /// <summary> 年级(多个用,分开），推荐使用 "_"符号开头 </summary>
        public string Grade
        {
            get { return this.m_grade; }
            set //
            {
                if (!grade_initialized || m_grade != value)
                {
                    this.m_grade = value;
                }
                grade_initialized = true;
            }
        }
        
        /// <summary> 介绍，推荐使用 "_"符号开头 </summary>
        public string Introduce
        {
            get { return this.m_introduce; }
            set //
            {
                if (!introduce_initialized || m_introduce != value)
                {
                    this.m_introduce = value;
                }
                introduce_initialized = true;
            }
        }
        
        /// <summary> 几天，推荐使用 "_"符号开头 </summary>
        public int Manydays
        {
            get { return this.m_manydays; }
            set //
            {
                if (!manydays_initialized || m_manydays != value)
                {
                    this.m_manydays = value;
                }
                manydays_initialized = true;
            }
        }
        
        /// <summary> 科目(多个用,分开），推荐使用 "_"符号开头 </summary>
        public string Subject
        {
            get { return this.m_subject; }
            set //
            {
                if (!subject_initialized || m_subject != value)
                {
                    this.m_subject = value;
                }
                subject_initialized = true;
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
            public static AttributeItem Task_detail_id =  new AttributeItem("[Jd_task_detail_jj].[Task_detail_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>年级(多个用,分开）</summary>
            public static AttributeItem Grade =  new AttributeItem("[Jd_task_detail_jj].[Grade]", typeof(string), 300, default(string));
            
            /// <summary>介绍</summary>
            public static AttributeItem Introduce =  new AttributeItem("[Jd_task_detail_jj].[Introduce]", typeof(string), 500, default(string));
            
            /// <summary>几天</summary>
            public static AttributeItem Manydays =  new AttributeItem("[Jd_task_detail_jj].[Manydays]", typeof(int), 4, default(int));
            
            /// <summary>科目(多个用,分开）</summary>
            public static AttributeItem Subject =  new AttributeItem("[Jd_task_detail_jj].[Subject]", typeof(string), 300, default(string));
            
            /// <summary>任务ID</summary>
            public static AttributeItem Task_id =  new AttributeItem("[Jd_task_detail_jj].[Task_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private Guid m_task_detail_id;
        /// <summary></summary>
        protected bool task_detail_id_initialized = false;
        
        private string m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private string m_introduce;
        /// <summary></summary>
        protected bool introduce_initialized = false;
        
        private int m_manydays;
        /// <summary></summary>
        protected bool manydays_initialized = false;
        
        private string m_subject;
        /// <summary></summary>
        protected bool subject_initialized = false;
        
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
            return "Jd_task_detail_jj";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.task_detail_id_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.introduce_initialized = IsLoadAllAttributes;this.manydays_initialized = IsLoadAllAttributes;this.subject_initialized = IsLoadAllAttributes;this.task_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jd_task_detail_jj value = new Jd_task_detail_jj();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_detail_id"))
				value.task_detail_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Introduce"))
				value.introduce_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Manydays"))
				value.manydays_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Subject"))
				value.subject_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Task_id"))
				value.task_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Jd_task_detail_jj Clone()
        {
            return (Jd_task_detail_jj)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Jd_task_detail_jj()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Jd_task_detail_jj() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Jd_task_detail_jj(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Jd_task_detail_jj(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Jd_task_detail_jj(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Jd_task_detail_jj(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Jd_task_detail_jj(Guid task_detail_id1, string grade1, string introduce1, int manydays1, string subject1, string task_id1)
        {
            
            this.Task_detail_id = task_detail_id1;
            
            this.Grade = grade1;
            
            this.Introduce = introduce1;
            
            this.Manydays = manydays1;
            
            this.Subject = subject1;
            
            this.Task_id = task_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Jd_task_detail_jj FromIView(IView view)
        {
            return (Jd_task_detail_jj)IView.GetITable(view, "Jd_task_detail_jj");
        }
        /// <summary>获得一个实例  </summary>
        public static Jd_task_detail_jj GetOneInstance()
        {
            Jd_task_detail_jj value = new Jd_task_detail_jj();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Jd_task_detail_jj Retrieve()
        {
            BLLTable<Jd_task_detail_jj>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Task_detail_id":
			        return Task_detail_id;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Introduce":
			        return Introduce;
			    			
			    case "Manydays":
			        return Manydays;
			    			
			    case "Subject":
			        return Subject;
			    			
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
			    case "Task_detail_id":
			        this.Task_detail_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Introduce":
			        this.Introduce = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Manydays":
			        this.Manydays = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Subject":
			        this.Subject = Convert.ToString(AttributeValue);
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
				case "Task_detail_id":
					return task_detail_id_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Introduce":
					return introduce_initialized;
				
				case "Manydays":
					return manydays_initialized;
				
				case "Subject":
					return subject_initialized;
				
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
				case "Task_detail_id":
					task_detail_id_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Introduce":
					introduce_initialized = ret;
					return true;
				
				case "Manydays":
					manydays_initialized = ret;
					return true;
				
				case "Subject":
					subject_initialized = ret;
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

			
			if (task_detail_id_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Task_detail_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Task_detail_id);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (introduce_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Introduce;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Introduce);
                }
			}
			
			if (manydays_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Manydays;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Manydays);
                }
			}
			
			if (subject_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Subject;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Subject);
                }
			}
			
			if (task_id_initialized)
			{
                AttributeItem attr = Jd_task_detail_jj.Attribute.Task_id;
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
        public class Jd_task_detail_jjJson
        {
            
            /// <summary>主键</summary>
            public Guid Task_detail_id { get; set; }
            
            /// <summary>年级(多个用,分开）</summary>
            public string Grade { get; set; }
            
            /// <summary>介绍</summary>
            public string Introduce { get; set; }
            
            /// <summary>几天</summary>
            public int Manydays { get; set; }
            
            /// <summary>科目(多个用,分开）</summary>
            public string Subject { get; set; }
            
            /// <summary>任务ID</summary>
            public string Task_id { get; set; }
        }
        #endregion
    }
}
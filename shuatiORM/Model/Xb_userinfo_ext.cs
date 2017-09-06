/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/7/19 19:22:58
  Description:    数据表Xb_userinfo_ext对应的业务逻辑层Xb_userinfo_ext
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_userinfo_ext_Entity:Xb_userinfo_ext
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Children,City,Employee_id,Err_timu_sum,Grade,Int_complete,Is_complete,Kemu_ids,Paper_sum,Phone,Request_info,User_id,User_type from Xb_userinfo_ext
delete from Xb_userinfo_ext
INSERT INTO Xb_userinfo_ext (Id,Children,City,Employee_id,Err_timu_sum,Grade,Int_complete,Is_complete,Kemu_ids,Paper_sum,Phone,Request_info,User_id,User_type)
     VALUES
           ('','','','','','','','','','','','','','')
UPDATE Xb_userinfo_ext SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Children = valObj2.Children;
        valObj.City = valObj2.City;
        valObj.Employee_id = valObj2.Employee_id;
        valObj.Err_timu_sum = valObj2.Err_timu_sum;
        valObj.Grade = valObj2.Grade;
        valObj.Int_complete = valObj2.Int_complete;
        valObj.Is_complete = valObj2.Is_complete;
        valObj.Kemu_ids = valObj2.Kemu_ids;
        valObj.Paper_sum = valObj2.Paper_sum;
        valObj.Phone = valObj2.Phone;
        valObj.Request_info = valObj2.Request_info;
        valObj.User_id = valObj2.User_id;
        valObj.User_type = valObj2.User_type; 
        valObj.Id = "";
        valObj.Children = "";
        valObj.City = "";
        valObj.Employee_id = "";
        valObj.Err_timu_sum = "";
        valObj.Grade = "";
        valObj.Int_complete = "";
        valObj.Is_complete = "";
        valObj.Kemu_ids = "";
        valObj.Paper_sum = "";
        valObj.Phone = "";
        valObj.Request_info = "";
        valObj.User_id = "";
        valObj.User_type = ""; 
        "Id": $("#txt_Id").val(),
        "Children": $("#txt_Children").val(),
        "City": $("#txt_City").val(),
        "Employee_id": $("#txt_Employee_id").val(),
        "Err_timu_sum": $("#txt_Err_timu_sum").val(),
        "Grade": $("#txt_Grade").val(),
        "Int_complete": $("#txt_Int_complete").val(),
        "Is_complete": $("#txt_Is_complete").val(),
        "Kemu_ids": $("#txt_Kemu_ids").val(),
        "Paper_sum": $("#txt_Paper_sum").val(),
        "Phone": $("#txt_Phone").val(),
        "Request_info": $("#txt_Request_info").val(),
        "User_id": $("#txt_User_id").val(),
        "User_type": $("#txt_User_type").val(), 
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
    /// <para>与Xb_userinfo_ext数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_userinfo_ext : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_userinfo_ext Factory()
        {
            return new Xb_userinfo_ext();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Children
        {            
            get { return this.Children; }
            set { this.Children = value; }
        }
        
        /// <summary> 城市:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary> 公司对应客服:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Employee_id
        {            
            get { return this.Employee_id; }
            set { this.Employee_id = value; }
        }
        
        /// <summary> 错题总数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Err_timu_sum
        {            
            get { return this.Err_timu_sum; }
            set { this.Err_timu_sum = value; }
        }
        
        /// <summary> 年级:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> 完善度:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Int_complete
        {            
            get { return this.Int_complete; }
            set { this.Int_complete = value; }
        }
        
        /// <summary> 用户信息是否完整:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _Is_complete
        {            
            get { return this.Is_complete; }
            set { this.Is_complete = value; }
        }
        
        /// <summary> 所需要的科目ids:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Kemu_ids
        {            
            get { return this.Kemu_ids; }
            set { this.Kemu_ids = value; }
        }
        
        /// <summary> 模拟卷数:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Paper_sum
        {            
            get { return this.Paper_sum; }
            set { this.Paper_sum = value; }
        }
        
        /// <summary> 手机号码:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone
        {            
            get { return this.Phone; }
            set { this.Phone = value; }
        }
        
        /// <summary> 需求信息:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Request_info
        {            
            get { return this.Request_info; }
            set { this.Request_info = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> 用户类型:[Enum-{1:学员},{2:老师},{3:公司员工}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _User_type
        {            
            get { return this.User_type; }
            set { this.User_type = value; }
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
        public string Children
        {
            get { return this.m_children; }
            set //
            {
                if (!children_initialized || m_children != value)
                {
                    this.m_children = value;
                }
                children_initialized = true;
            }
        }
        
        /// <summary> 城市:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string City
        {
            get { return this.m_city; }
            set //
            {
                if (!city_initialized || m_city != value)
                {
                    this.m_city = value;
                }
                city_initialized = true;
            }
        }
        
        /// <summary> 公司对应客服:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Employee_id
        {
            get { return this.m_employee_id; }
            set //
            {
                if (!employee_id_initialized || m_employee_id != value)
                {
                    this.m_employee_id = value;
                }
                employee_id_initialized = true;
            }
        }
        
        /// <summary> 错题总数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Err_timu_sum
        {
            get { return this.m_err_timu_sum; }
            set //
            {
                if (!err_timu_sum_initialized || m_err_timu_sum != value)
                {
                    this.m_err_timu_sum = value;
                }
                err_timu_sum_initialized = true;
            }
        }
        
        /// <summary> 年级:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Grade
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
        
        /// <summary> 完善度:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public double Int_complete
        {
            get { return this.m_int_complete; }
            set //
            {
                if (!int_complete_initialized || m_int_complete != value)
                {
                    this.m_int_complete = value;
                }
                int_complete_initialized = true;
            }
        }
        
        /// <summary> 用户信息是否完整:[CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 所需要的科目ids:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Kemu_ids
        {
            get { return this.m_kemu_ids; }
            set //
            {
                if (!kemu_ids_initialized || m_kemu_ids != value)
                {
                    this.m_kemu_ids = value;
                }
                kemu_ids_initialized = true;
            }
        }
        
        /// <summary> 模拟卷数:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Paper_sum
        {
            get { return this.m_paper_sum; }
            set //
            {
                if (!paper_sum_initialized || m_paper_sum != value)
                {
                    this.m_paper_sum = value;
                }
                paper_sum_initialized = true;
            }
        }
        
        /// <summary> 手机号码:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Phone
        {
            get { return this.m_phone; }
            set //
            {
                if (!phone_initialized || m_phone != value)
                {
                    this.m_phone = value;
                }
                phone_initialized = true;
            }
        }
        
        /// <summary> 需求信息:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Request_info
        {
            get { return this.m_request_info; }
            set //
            {
                if (!request_info_initialized || m_request_info != value)
                {
                    this.m_request_info = value;
                }
                request_info_initialized = true;
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
        
        /// <summary> 用户类型:[Enum-{1:学员},{2:老师},{3:公司员工}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
        public int User_type
        {
            get { return this.m_user_type; }
            set //
            {
                if (!user_type_initialized || m_user_type != value)
                {
                    this.m_user_type = value;
                }
                user_type_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_userinfo_ext].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Children =  new AttributeItem("[Xb_userinfo_ext].[Children]", typeof(string), 50, default(string));
            
            /// <summary>城市:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[Xb_userinfo_ext].[City]", typeof(string), 50, default(string));
            
            /// <summary>公司对应客服:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Employee_id =  new AttributeItem("[Xb_userinfo_ext].[Employee_id]", typeof(string), 36, default(string));
            
            /// <summary>错题总数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Err_timu_sum =  new AttributeItem("[Xb_userinfo_ext].[Err_timu_sum]", typeof(int), 4, default(int));
            
            /// <summary>年级:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Grade =  new AttributeItem("[Xb_userinfo_ext].[Grade]", typeof(int), 4, default(int));
            
            /// <summary>完善度:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Int_complete =  new AttributeItem("[Xb_userinfo_ext].[Int_complete]", typeof(double), 8, default(double));
            
            /// <summary>用户信息是否完整:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Is_complete =  new AttributeItem("[Xb_userinfo_ext].[Is_complete]", typeof(bool), 1, default(bool));
            
            /// <summary>所需要的科目ids:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu_ids =  new AttributeItem("[Xb_userinfo_ext].[Kemu_ids]", typeof(string), 50, default(string));
            
            /// <summary>模拟卷数:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Paper_sum =  new AttributeItem("[Xb_userinfo_ext].[Paper_sum]", typeof(int), 4, default(int));
            
            /// <summary>手机号码:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone =  new AttributeItem("[Xb_userinfo_ext].[Phone]", typeof(string), 50, default(string));
            
            /// <summary>需求信息:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Request_info =  new AttributeItem("[Xb_userinfo_ext].[Request_info]", typeof(string), -1, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_userinfo_ext].[User_id]", typeof(string), 36, default(string));
            
            /// <summary>用户类型:[Enum-{1:学员},{2:老师},{3:公司员工}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem User_type =  new AttributeItem("[Xb_userinfo_ext].[User_type]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_children;
        /// <summary></summary>
        protected bool children_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_employee_id;
        /// <summary></summary>
        protected bool employee_id_initialized = false;
        
        private int m_err_timu_sum;
        /// <summary></summary>
        protected bool err_timu_sum_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private double m_int_complete;
        /// <summary></summary>
        protected bool int_complete_initialized = false;
        
        private bool m_is_complete;
        /// <summary></summary>
        protected bool is_complete_initialized = false;
        
        private string m_kemu_ids;
        /// <summary></summary>
        protected bool kemu_ids_initialized = false;
        
        private int m_paper_sum;
        /// <summary></summary>
        protected bool paper_sum_initialized = false;
        
        private string m_phone;
        /// <summary></summary>
        protected bool phone_initialized = false;
        
        private string m_request_info;
        /// <summary></summary>
        protected bool request_info_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private int m_user_type;
        /// <summary></summary>
        protected bool user_type_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_userinfo_ext";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.children_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.employee_id_initialized = IsLoadAllAttributes;this.err_timu_sum_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.int_complete_initialized = IsLoadAllAttributes;this.is_complete_initialized = IsLoadAllAttributes;this.kemu_ids_initialized = IsLoadAllAttributes;this.paper_sum_initialized = IsLoadAllAttributes;this.phone_initialized = IsLoadAllAttributes;this.request_info_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.user_type_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_userinfo_ext value = new Xb_userinfo_ext();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Children"))
				value.children_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Employee_id"))
				value.employee_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Err_timu_sum"))
				value.err_timu_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Int_complete"))
				value.int_complete_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_complete"))
				value.is_complete_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_ids"))
				value.kemu_ids_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Paper_sum"))
				value.paper_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone"))
				value.phone_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Request_info"))
				value.request_info_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_type"))
				value.user_type_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_userinfo_ext Clone()
        {
            return (Xb_userinfo_ext)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_userinfo_ext()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_userinfo_ext() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_userinfo_ext(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_userinfo_ext(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_userinfo_ext(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_userinfo_ext(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_userinfo_ext(int id1, string children1, string city1, string employee_id1, int err_timu_sum1, int grade1, double int_complete1, bool is_complete1, string kemu_ids1, int paper_sum1, string phone1, string request_info1, string user_id1, int user_type1)
        {
            
            this.Id = id1;
            
            this.Children = children1;
            
            this.City = city1;
            
            this.Employee_id = employee_id1;
            
            this.Err_timu_sum = err_timu_sum1;
            
            this.Grade = grade1;
            
            this.Int_complete = int_complete1;
            
            this.Is_complete = is_complete1;
            
            this.Kemu_ids = kemu_ids1;
            
            this.Paper_sum = paper_sum1;
            
            this.Phone = phone1;
            
            this.Request_info = request_info1;
            
            this.User_id = user_id1;
            
            this.User_type = user_type1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_userinfo_ext FromIView(IView view)
        {
            return (Xb_userinfo_ext)IView.GetITable(view, "Xb_userinfo_ext");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_userinfo_ext GetOneInstance()
        {
            Xb_userinfo_ext value = new Xb_userinfo_ext();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_userinfo_ext Retrieve()
        {
            BLLTable<Xb_userinfo_ext>.GetRowData(this);
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
			    			
			    case "Children":
			        return Children;
			    			
			    case "City":
			        return City;
			    			
			    case "Employee_id":
			        return Employee_id;
			    			
			    case "Err_timu_sum":
			        return Err_timu_sum;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Int_complete":
			        return Int_complete;
			    			
			    case "Is_complete":
			        return Is_complete;
			    			
			    case "Kemu_ids":
			        return Kemu_ids;
			    			
			    case "Paper_sum":
			        return Paper_sum;
			    			
			    case "Phone":
			        return Phone;
			    			
			    case "Request_info":
			        return Request_info;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "User_type":
			        return User_type;
			
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
			    			
			    case "Children":
			        this.Children = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Employee_id":
			        this.Employee_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Err_timu_sum":
			        this.Err_timu_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Int_complete":
			        this.Int_complete = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Is_complete":
			        this.Is_complete = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Kemu_ids":
			        this.Kemu_ids = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Paper_sum":
			        this.Paper_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Phone":
			        this.Phone = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Request_info":
			        this.Request_info = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_type":
			        this.User_type = Convert.ToInt32(AttributeValue);
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
				
				case "Children":
					return children_initialized;
				
				case "City":
					return city_initialized;
				
				case "Employee_id":
					return employee_id_initialized;
				
				case "Err_timu_sum":
					return err_timu_sum_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Int_complete":
					return int_complete_initialized;
				
				case "Is_complete":
					return is_complete_initialized;
				
				case "Kemu_ids":
					return kemu_ids_initialized;
				
				case "Paper_sum":
					return paper_sum_initialized;
				
				case "Phone":
					return phone_initialized;
				
				case "Request_info":
					return request_info_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "User_type":
					return user_type_initialized;
				
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
				
				case "Children":
					children_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "Employee_id":
					employee_id_initialized = ret;
					return true;
				
				case "Err_timu_sum":
					err_timu_sum_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Int_complete":
					int_complete_initialized = ret;
					return true;
				
				case "Is_complete":
					is_complete_initialized = ret;
					return true;
				
				case "Kemu_ids":
					kemu_ids_initialized = ret;
					return true;
				
				case "Paper_sum":
					paper_sum_initialized = ret;
					return true;
				
				case "Phone":
					phone_initialized = ret;
					return true;
				
				case "Request_info":
					request_info_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "User_type":
					user_type_initialized = ret;
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
                AttributeItem attr = Xb_userinfo_ext.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (children_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Children;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Children);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (employee_id_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Employee_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Employee_id);
                }
			}
			
			if (err_timu_sum_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Err_timu_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Err_timu_sum);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (int_complete_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Int_complete;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Int_complete);
                }
			}
			
			if (is_complete_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Is_complete;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_complete);
                }
			}
			
			if (kemu_ids_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Kemu_ids;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_ids);
                }
			}
			
			if (paper_sum_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Paper_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Paper_sum);
                }
			}
			
			if (phone_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Phone;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone);
                }
			}
			
			if (request_info_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.Request_info;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Request_info);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (user_type_initialized)
			{
                AttributeItem attr = Xb_userinfo_ext.Attribute.User_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_type);
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
        public class Xb_userinfo_extJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Children { get; set; }
            
            /// <summary>城市:[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary>公司对应客服:[CtrlTypeDic-{InputString}]</summary>
            public string Employee_id { get; set; }
            
            /// <summary>错题总数:[CtrlTypeDic-{InputString}]</summary>
            public int Err_timu_sum { get; set; }
            
            /// <summary>年级:[CtrlTypeDic-{InputString}]</summary>
            public int Grade { get; set; }
            
            /// <summary>完善度:[CtrlTypeDic-{InputString}]</summary>
            public double Int_complete { get; set; }
            
            /// <summary>用户信息是否完整:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Is_complete { get; set; }
            
            /// <summary>所需要的科目ids:[CtrlTypeDic-{InputString}]</summary>
            public string Kemu_ids { get; set; }
            
            /// <summary>模拟卷数:[CtrlTypeDic-{InputString}]</summary>
            public int Paper_sum { get; set; }
            
            /// <summary>手机号码:[CtrlTypeDic-{InputString}]</summary>
            public string Phone { get; set; }
            
            /// <summary>需求信息:[CtrlTypeDic-{InputString}]</summary>
            public string Request_info { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>用户类型:[Enum-{1:学员},{2:老师},{3:公司员工}][CtrlTypeDic-{SelectDrop}]</summary>
            public int User_type { get; set; }
        }
        #endregion
    }
}
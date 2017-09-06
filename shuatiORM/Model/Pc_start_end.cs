/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/7/2 14:23:24
  Description:    数据表Pc_start_end对应的业务逻辑层Pc_start_end
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Pc_start_end_Entity:Pc_start_end
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Create_by,E_wei_ma,End_address_name,End_city,Phone_num,Pinchemessage,Real_name,Start_address_name,Start_city,Start_time,User_id,Uuid from Pc_start_end
delete from Pc_start_end
INSERT INTO Pc_start_end (Id,Create_by,E_wei_ma,End_address_name,End_city,Phone_num,Pinchemessage,Real_name,Start_address_name,Start_city,Start_time,User_id,Uuid)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE Pc_start_end SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Create_by = valObj2.Create_by;
        valObj.E_wei_ma = valObj2.E_wei_ma;
        valObj.End_address_name = valObj2.End_address_name;
        valObj.End_city = valObj2.End_city;
        valObj.Phone_num = valObj2.Phone_num;
        valObj.Pinchemessage = valObj2.Pinchemessage;
        valObj.Real_name = valObj2.Real_name;
        valObj.Start_address_name = valObj2.Start_address_name;
        valObj.Start_city = valObj2.Start_city;
        valObj.Start_time = valObj2.Start_time;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.Create_by = "";
        valObj.E_wei_ma = "";
        valObj.End_address_name = "";
        valObj.End_city = "";
        valObj.Phone_num = "";
        valObj.Pinchemessage = "";
        valObj.Real_name = "";
        valObj.Start_address_name = "";
        valObj.Start_city = "";
        valObj.Start_time = "";
        valObj.User_id = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "Create_by": $("#txt_Create_by").val(),
        "E_wei_ma": $("#txt_E_wei_ma").val(),
        "End_address_name": $("#txt_End_address_name").val(),
        "End_city": $("#txt_End_city").val(),
        "Phone_num": $("#txt_Phone_num").val(),
        "Pinchemessage": $("#txt_Pinchemessage").val(),
        "Real_name": $("#txt_Real_name").val(),
        "Start_address_name": $("#txt_Start_address_name").val(),
        "Start_city": $("#txt_Start_city").val(),
        "Start_time": $("#txt_Start_time").val(),
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
    /// <para>与Pc_start_end数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Pc_start_end : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Pc_start_end Factory()
        {
            return new Pc_start_end();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 创建人(发起人):[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Create_by
        {            
            get { return this.Create_by; }
            set { this.Create_by = value; }
        }
        
        /// <summary> 二维码:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _E_wei_ma
        {            
            get { return this.E_wei_ma; }
            set { this.E_wei_ma = value; }
        }
        
        /// <summary> 终点地址名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _End_address_name
        {            
            get { return this.End_address_name; }
            set { this.End_address_name = value; }
        }
        
        /// <summary> 终点城市:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _End_city
        {            
            get { return this.End_city; }
            set { this.End_city = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_num
        {            
            get { return this.Phone_num; }
            set { this.Phone_num = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Pinchemessage
        {            
            get { return this.Pinchemessage; }
            set { this.Pinchemessage = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Real_name
        {            
            get { return this.Real_name; }
            set { this.Real_name = value; }
        }
        
        /// <summary> 起点地址名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Start_address_name
        {            
            get { return this.Start_address_name; }
            set { this.Start_address_name = value; }
        }
        
        /// <summary> 起点城市:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Start_city
        {            
            get { return this.Start_city; }
            set { this.Start_city = value; }
        }
        
        /// <summary> 出发时间:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Start_time
        {            
            get { return this.Start_time; }
            set { this.Start_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
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
        
        /// <summary> 创建人(发起人):[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Create_by
        {
            get { return this.m_create_by; }
            set //
            {
                if (!create_by_initialized || m_create_by != value)
                {
                    this.m_create_by = value;
                }
                create_by_initialized = true;
            }
        }
        
        /// <summary> 二维码:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string E_wei_ma
        {
            get { return this.m_e_wei_ma; }
            set //
            {
                if (!e_wei_ma_initialized || m_e_wei_ma != value)
                {
                    this.m_e_wei_ma = value;
                }
                e_wei_ma_initialized = true;
            }
        }
        
        /// <summary> 终点地址名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string End_address_name
        {
            get { return this.m_end_address_name; }
            set //
            {
                if (!end_address_name_initialized || m_end_address_name != value)
                {
                    this.m_end_address_name = value;
                }
                end_address_name_initialized = true;
            }
        }
        
        /// <summary> 终点城市:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string End_city
        {
            get { return this.m_end_city; }
            set //
            {
                if (!end_city_initialized || m_end_city != value)
                {
                    this.m_end_city = value;
                }
                end_city_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Phone_num
        {
            get { return this.m_phone_num; }
            set //
            {
                if (!phone_num_initialized || m_phone_num != value)
                {
                    this.m_phone_num = value;
                }
                phone_num_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Pinchemessage
        {
            get { return this.m_pinchemessage; }
            set //
            {
                if (!pinchemessage_initialized || m_pinchemessage != value)
                {
                    this.m_pinchemessage = value;
                }
                pinchemessage_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Real_name
        {
            get { return this.m_real_name; }
            set //
            {
                if (!real_name_initialized || m_real_name != value)
                {
                    this.m_real_name = value;
                }
                real_name_initialized = true;
            }
        }
        
        /// <summary> 起点地址名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Start_address_name
        {
            get { return this.m_start_address_name; }
            set //
            {
                if (!start_address_name_initialized || m_start_address_name != value)
                {
                    this.m_start_address_name = value;
                }
                start_address_name_initialized = true;
            }
        }
        
        /// <summary> 起点城市:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Start_city
        {
            get { return this.m_start_city; }
            set //
            {
                if (!start_city_initialized || m_start_city != value)
                {
                    this.m_start_city = value;
                }
                start_city_initialized = true;
            }
        }
        
        /// <summary> 出发时间:[CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
        public DateTime Start_time
        {
            get { return this.m_start_time; }
            set //
            {
                if (!start_time_initialized || m_start_time != value)
                {
                    this.m_start_time = value;
                }
                start_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Pc_start_end].[Id]", typeof(int), 4, default(int));
            
            /// <summary>创建人(发起人):[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Create_by =  new AttributeItem("[Pc_start_end].[Create_by]", typeof(string), 36, default(string));
            
            /// <summary>二维码:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem E_wei_ma =  new AttributeItem("[Pc_start_end].[E_wei_ma]", typeof(string), 200, default(string));
            
            /// <summary>终点地址名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem End_address_name =  new AttributeItem("[Pc_start_end].[End_address_name]", typeof(string), 50, default(string));
            
            /// <summary>终点城市:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem End_city =  new AttributeItem("[Pc_start_end].[End_city]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_num =  new AttributeItem("[Pc_start_end].[Phone_num]", typeof(string), 20, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pinchemessage =  new AttributeItem("[Pc_start_end].[Pinchemessage]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Real_name =  new AttributeItem("[Pc_start_end].[Real_name]", typeof(string), 50, default(string));
            
            /// <summary>起点地址名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Start_address_name =  new AttributeItem("[Pc_start_end].[Start_address_name]", typeof(string), 50, default(string));
            
            /// <summary>起点城市:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Start_city =  new AttributeItem("[Pc_start_end].[Start_city]", typeof(string), 50, default(string));
            
            /// <summary>出发时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Start_time =  new AttributeItem("[Pc_start_end].[Start_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Pc_start_end].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Pc_start_end].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_create_by;
        /// <summary></summary>
        protected bool create_by_initialized = false;
        
        private string m_e_wei_ma;
        /// <summary></summary>
        protected bool e_wei_ma_initialized = false;
        
        private string m_end_address_name;
        /// <summary></summary>
        protected bool end_address_name_initialized = false;
        
        private string m_end_city;
        /// <summary></summary>
        protected bool end_city_initialized = false;
        
        private string m_phone_num;
        /// <summary></summary>
        protected bool phone_num_initialized = false;
        
        private string m_pinchemessage;
        /// <summary></summary>
        protected bool pinchemessage_initialized = false;
        
        private string m_real_name;
        /// <summary></summary>
        protected bool real_name_initialized = false;
        
        private string m_start_address_name;
        /// <summary></summary>
        protected bool start_address_name_initialized = false;
        
        private string m_start_city;
        /// <summary></summary>
        protected bool start_city_initialized = false;
        
        private DateTime m_start_time;
        /// <summary></summary>
        protected bool start_time_initialized = false;
        
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
            return "Pc_start_end";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.create_by_initialized = IsLoadAllAttributes;this.e_wei_ma_initialized = IsLoadAllAttributes;this.end_address_name_initialized = IsLoadAllAttributes;this.end_city_initialized = IsLoadAllAttributes;this.phone_num_initialized = IsLoadAllAttributes;this.pinchemessage_initialized = IsLoadAllAttributes;this.real_name_initialized = IsLoadAllAttributes;this.start_address_name_initialized = IsLoadAllAttributes;this.start_city_initialized = IsLoadAllAttributes;this.start_time_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Pc_start_end value = new Pc_start_end();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_by"))
				value.create_by_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"E_wei_ma"))
				value.e_wei_ma_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"End_address_name"))
				value.end_address_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"End_city"))
				value.end_city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_num"))
				value.phone_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pinchemessage"))
				value.pinchemessage_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Real_name"))
				value.real_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Start_address_name"))
				value.start_address_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Start_city"))
				value.start_city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Start_time"))
				value.start_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Pc_start_end Clone()
        {
            return (Pc_start_end)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Pc_start_end()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Pc_start_end() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Pc_start_end(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Pc_start_end(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Pc_start_end(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Pc_start_end(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Pc_start_end(int id1, string create_by1, string e_wei_ma1, string end_address_name1, string end_city1, string phone_num1, string pinchemessage1, string real_name1, string start_address_name1, string start_city1, DateTime start_time1, Guid user_id1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.Create_by = create_by1;
            
            this.E_wei_ma = e_wei_ma1;
            
            this.End_address_name = end_address_name1;
            
            this.End_city = end_city1;
            
            this.Phone_num = phone_num1;
            
            this.Pinchemessage = pinchemessage1;
            
            this.Real_name = real_name1;
            
            this.Start_address_name = start_address_name1;
            
            this.Start_city = start_city1;
            
            this.Start_time = start_time1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Pc_start_end FromIView(IView view)
        {
            return (Pc_start_end)IView.GetITable(view, "Pc_start_end");
        }
        /// <summary>获得一个实例  </summary>
        public static Pc_start_end GetOneInstance()
        {
            Pc_start_end value = new Pc_start_end();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Pc_start_end Retrieve()
        {
            BLLTable<Pc_start_end>.GetRowData(this);
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
			    			
			    case "Create_by":
			        return Create_by;
			    			
			    case "E_wei_ma":
			        return E_wei_ma;
			    			
			    case "End_address_name":
			        return End_address_name;
			    			
			    case "End_city":
			        return End_city;
			    			
			    case "Phone_num":
			        return Phone_num;
			    			
			    case "Pinchemessage":
			        return Pinchemessage;
			    			
			    case "Real_name":
			        return Real_name;
			    			
			    case "Start_address_name":
			        return Start_address_name;
			    			
			    case "Start_city":
			        return Start_city;
			    			
			    case "Start_time":
			        return Start_time;
			    			
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
			    			
			    case "Create_by":
			        this.Create_by = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "E_wei_ma":
			        this.E_wei_ma = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "End_address_name":
			        this.End_address_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "End_city":
			        this.End_city = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_num":
			        this.Phone_num = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Pinchemessage":
			        this.Pinchemessage = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Real_name":
			        this.Real_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Start_address_name":
			        this.Start_address_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Start_city":
			        this.Start_city = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Start_time":
			        this.Start_time = Convert.ToDateTime(AttributeValue);
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
				
				case "Create_by":
					return create_by_initialized;
				
				case "E_wei_ma":
					return e_wei_ma_initialized;
				
				case "End_address_name":
					return end_address_name_initialized;
				
				case "End_city":
					return end_city_initialized;
				
				case "Phone_num":
					return phone_num_initialized;
				
				case "Pinchemessage":
					return pinchemessage_initialized;
				
				case "Real_name":
					return real_name_initialized;
				
				case "Start_address_name":
					return start_address_name_initialized;
				
				case "Start_city":
					return start_city_initialized;
				
				case "Start_time":
					return start_time_initialized;
				
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
				
				case "Create_by":
					create_by_initialized = ret;
					return true;
				
				case "E_wei_ma":
					e_wei_ma_initialized = ret;
					return true;
				
				case "End_address_name":
					end_address_name_initialized = ret;
					return true;
				
				case "End_city":
					end_city_initialized = ret;
					return true;
				
				case "Phone_num":
					phone_num_initialized = ret;
					return true;
				
				case "Pinchemessage":
					pinchemessage_initialized = ret;
					return true;
				
				case "Real_name":
					real_name_initialized = ret;
					return true;
				
				case "Start_address_name":
					start_address_name_initialized = ret;
					return true;
				
				case "Start_city":
					start_city_initialized = ret;
					return true;
				
				case "Start_time":
					start_time_initialized = ret;
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
                AttributeItem attr = Pc_start_end.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (create_by_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.Create_by;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_by);
                }
			}
			
			if (e_wei_ma_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.E_wei_ma;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(E_wei_ma);
                }
			}
			
			if (end_address_name_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.End_address_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(End_address_name);
                }
			}
			
			if (end_city_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.End_city;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(End_city);
                }
			}
			
			if (phone_num_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.Phone_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_num);
                }
			}
			
			if (pinchemessage_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.Pinchemessage;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pinchemessage);
                }
			}
			
			if (real_name_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.Real_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Real_name);
                }
			}
			
			if (start_address_name_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.Start_address_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Start_address_name);
                }
			}
			
			if (start_city_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.Start_city;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Start_city);
                }
			}
			
			if (start_time_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.Start_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Start_time);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Pc_start_end.Attribute.Uuid;
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
        public class Pc_start_endJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>创建人(发起人):[CtrlTypeDic-{InputString}]</summary>
            public string Create_by { get; set; }
            
            /// <summary>二维码:[CtrlTypeDic-{InputString}]</summary>
            public string E_wei_ma { get; set; }
            
            /// <summary>终点地址名称:[CtrlTypeDic-{InputString}]</summary>
            public string End_address_name { get; set; }
            
            /// <summary>终点城市:[CtrlTypeDic-{InputString}]</summary>
            public string End_city { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_num { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Pinchemessage { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Real_name { get; set; }
            
            /// <summary>起点地址名称:[CtrlTypeDic-{InputString}]</summary>
            public string Start_address_name { get; set; }
            
            /// <summary>起点城市:[CtrlTypeDic-{InputString}]</summary>
            public string Start_city { get; set; }
            
            /// <summary>出发时间:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Start_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
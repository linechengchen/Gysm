/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/9 1:12:17
  Description:    数据表TLogSource对应的业务逻辑层TLogSource
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 TLogSource_Entity:TLogSource
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Info1,Num,Openid,Sc,Sc_name,Source1,User_id from TLogSource
delete from TLogSource
INSERT INTO TLogSource (Id,Info1,Num,Openid,Sc,Sc_name,Source1,User_id)
     VALUES
           ('','','','','','','','')
UPDATE TLogSource SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Info1 = valObj2.Info1;
        valObj.Num = valObj2.Num;
        valObj.Openid = valObj2.Openid;
        valObj.Sc = valObj2.Sc;
        valObj.Sc_name = valObj2.Sc_name;
        valObj.Source1 = valObj2.Source1;
        valObj.User_id = valObj2.User_id; 
        valObj.Id = "";
        valObj.Info1 = "";
        valObj.Num = "";
        valObj.Openid = "";
        valObj.Sc = "";
        valObj.Sc_name = "";
        valObj.Source1 = "";
        valObj.User_id = ""; 
        "Id": $("#txt_Id").val(),
        "Info1": $("#txt_Info1").val(),
        "Num": $("#txt_Num").val(),
        "Openid": $("#txt_Openid").val(),
        "Sc": $("#txt_Sc").val(),
        "Sc_name": $("#txt_Sc_name").val(),
        "Source1": $("#txt_Source1").val(),
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
    /// <para></para>
    /// <para>与TLogSource数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class TLogSource : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static TLogSource Factory()
        {
            return new TLogSource();
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
        public string _Info1
        {            
            get { return this.Info1; }
            set { this.Info1 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Num
        {            
            get { return this.Num; }
            set { this.Num = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Openid
        {            
            get { return this.Openid; }
            set { this.Openid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc_name
        {            
            get { return this.Sc_name; }
            set { this.Sc_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Source1
        {            
            get { return this.Source1; }
            set { this.Source1 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
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
        public string Info1
        {
            get { return this.m_info1; }
            set //
            {
                if (!info1_initialized || m_info1 != value)
                {
                    this.m_info1 = value;
                }
                info1_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Num
        {
            get { return this.m_num; }
            set //
            {
                if (!num_initialized || m_num != value)
                {
                    this.m_num = value;
                }
                num_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Openid
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Sc
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
        public string Sc_name
        {
            get { return this.m_sc_name; }
            set //
            {
                if (!sc_name_initialized || m_sc_name != value)
                {
                    this.m_sc_name = value;
                }
                sc_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Source1
        {
            get { return this.m_source1; }
            set //
            {
                if (!source1_initialized || m_source1 != value)
                {
                    this.m_source1 = value;
                }
                source1_initialized = true;
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
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[TLogSource].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Info1 =  new AttributeItem("[TLogSource].[Info1]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Num =  new AttributeItem("[TLogSource].[Num]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Openid =  new AttributeItem("[TLogSource].[Openid]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[TLogSource].[Sc]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc_name =  new AttributeItem("[TLogSource].[Sc_name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Source1 =  new AttributeItem("[TLogSource].[Source1]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[TLogSource].[User_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_info1;
        /// <summary></summary>
        protected bool info1_initialized = false;
        
        private int m_num;
        /// <summary></summary>
        protected bool num_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private string m_sc_name;
        /// <summary></summary>
        protected bool sc_name_initialized = false;
        
        private string m_source1;
        /// <summary></summary>
        protected bool source1_initialized = false;
        
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
            return "TLogSource";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.info1_initialized = IsLoadAllAttributes;this.num_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.sc_name_initialized = IsLoadAllAttributes;this.source1_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TLogSource value = new TLogSource();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Info1"))
				value.info1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Num"))
				value.num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Openid"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc_name"))
				value.sc_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Source1"))
				value.source1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new TLogSource Clone()
        {
            return (TLogSource)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static TLogSource()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public TLogSource() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public TLogSource(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public TLogSource(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public TLogSource(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public TLogSource(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public TLogSource(int id1, string info11, int num1, string openid1, string sc1, string sc_name1, string source11, string user_id1)
        {
            
            this.Id = id1;
            
            this.Info1 = info11;
            
            this.Num = num1;
            
            this.Openid = openid1;
            
            this.Sc = sc1;
            
            this.Sc_name = sc_name1;
            
            this.Source1 = source11;
            
            this.User_id = user_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static TLogSource FromIView(IView view)
        {
            return (TLogSource)IView.GetITable(view, "TLogSource");
        }
        /// <summary>获得一个实例  </summary>
        public static TLogSource GetOneInstance()
        {
            TLogSource value = new TLogSource();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public TLogSource Retrieve()
        {
            BLLTable<TLogSource>.GetRowData(this);
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
			    			
			    case "Info1":
			        return Info1;
			    			
			    case "Num":
			        return Num;
			    			
			    case "Openid":
			        return Openid;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "Sc_name":
			        return Sc_name;
			    			
			    case "Source1":
			        return Source1;
			    			
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
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Info1":
			        this.Info1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Num":
			        this.Num = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Openid":
			        this.Openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc_name":
			        this.Sc_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Source1":
			        this.Source1 = Convert.ToString(AttributeValue);
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
				case "Id":
					return id_initialized;
				
				case "Info1":
					return info1_initialized;
				
				case "Num":
					return num_initialized;
				
				case "Openid":
					return openid_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "Sc_name":
					return sc_name_initialized;
				
				case "Source1":
					return source1_initialized;
				
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
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Info1":
					info1_initialized = ret;
					return true;
				
				case "Num":
					num_initialized = ret;
					return true;
				
				case "Openid":
					openid_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "Sc_name":
					sc_name_initialized = ret;
					return true;
				
				case "Source1":
					source1_initialized = ret;
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

			
			if (id_initialized)
			{
                AttributeItem attr = TLogSource.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (info1_initialized)
			{
                AttributeItem attr = TLogSource.Attribute.Info1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Info1);
                }
			}
			
			if (num_initialized)
			{
                AttributeItem attr = TLogSource.Attribute.Num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Num);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = TLogSource.Attribute.Openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Openid);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = TLogSource.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (sc_name_initialized)
			{
                AttributeItem attr = TLogSource.Attribute.Sc_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc_name);
                }
			}
			
			if (source1_initialized)
			{
                AttributeItem attr = TLogSource.Attribute.Source1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Source1);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = TLogSource.Attribute.User_id;
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
        public class TLogSourceJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Info1 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Num { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Openid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Sc { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Sc_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Source1 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}
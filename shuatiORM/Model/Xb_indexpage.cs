/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:21
  Description:    数据表Xb_indexpage对应的业务逻辑层Xb_indexpage
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_indexpage_Entity:Xb_indexpage
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Btn_dayi,Btn_tiku,Phone_title,Phone_title_small,Phone_title_small_sum,Phone_title_sum,Title_big,Title_head,Title_small from Xb_indexpage
delete from Xb_indexpage
INSERT INTO Xb_indexpage (Id,Btn_dayi,Btn_tiku,Phone_title,Phone_title_small,Phone_title_small_sum,Phone_title_sum,Title_big,Title_head,Title_small)
     VALUES
           ('','','','','','','','','','')
UPDATE Xb_indexpage SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Btn_dayi = valObj2.Btn_dayi;
        valObj.Btn_tiku = valObj2.Btn_tiku;
        valObj.Phone_title = valObj2.Phone_title;
        valObj.Phone_title_small = valObj2.Phone_title_small;
        valObj.Phone_title_small_sum = valObj2.Phone_title_small_sum;
        valObj.Phone_title_sum = valObj2.Phone_title_sum;
        valObj.Title_big = valObj2.Title_big;
        valObj.Title_head = valObj2.Title_head;
        valObj.Title_small = valObj2.Title_small; 
        valObj.Id = "";
        valObj.Btn_dayi = "";
        valObj.Btn_tiku = "";
        valObj.Phone_title = "";
        valObj.Phone_title_small = "";
        valObj.Phone_title_small_sum = "";
        valObj.Phone_title_sum = "";
        valObj.Title_big = "";
        valObj.Title_head = "";
        valObj.Title_small = ""; 
        "Id": $("#txt_Id").val(),
        "Btn_dayi": $("#txt_Btn_dayi").val(),
        "Btn_tiku": $("#txt_Btn_tiku").val(),
        "Phone_title": $("#txt_Phone_title").val(),
        "Phone_title_small": $("#txt_Phone_title_small").val(),
        "Phone_title_small_sum": $("#txt_Phone_title_small_sum").val(),
        "Phone_title_sum": $("#txt_Phone_title_sum").val(),
        "Title_big": $("#txt_Title_big").val(),
        "Title_head": $("#txt_Title_head").val(),
        "Title_small": $("#txt_Title_small").val(), 
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
    /// <para>与Xb_indexpage数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_indexpage : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_indexpage Factory()
        {
            return new Xb_indexpage();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Btn_dayi
        {            
            get { return this.Btn_dayi; }
            set { this.Btn_dayi = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Btn_tiku
        {            
            get { return this.Btn_tiku; }
            set { this.Btn_tiku = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_title
        {            
            get { return this.Phone_title; }
            set { this.Phone_title = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_title_small
        {            
            get { return this.Phone_title_small; }
            set { this.Phone_title_small = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_title_small_sum
        {            
            get { return this.Phone_title_small_sum; }
            set { this.Phone_title_small_sum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_title_sum
        {            
            get { return this.Phone_title_sum; }
            set { this.Phone_title_sum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title_big
        {            
            get { return this.Title_big; }
            set { this.Title_big = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title_head
        {            
            get { return this.Title_head; }
            set { this.Title_head = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title_small
        {            
            get { return this.Title_small; }
            set { this.Title_small = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public int Id
        {
            get { return this.m_id; }
            set //
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Btn_dayi
        {
            get { return this.m_btn_dayi; }
            set //
            {
                if (!btn_dayi_initialized || m_btn_dayi != value)
                {
                    this.m_btn_dayi = value;
                }
                btn_dayi_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Btn_tiku
        {
            get { return this.m_btn_tiku; }
            set //
            {
                if (!btn_tiku_initialized || m_btn_tiku != value)
                {
                    this.m_btn_tiku = value;
                }
                btn_tiku_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Phone_title
        {
            get { return this.m_phone_title; }
            set //
            {
                if (!phone_title_initialized || m_phone_title != value)
                {
                    this.m_phone_title = value;
                }
                phone_title_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Phone_title_small
        {
            get { return this.m_phone_title_small; }
            set //
            {
                if (!phone_title_small_initialized || m_phone_title_small != value)
                {
                    this.m_phone_title_small = value;
                }
                phone_title_small_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Phone_title_small_sum
        {
            get { return this.m_phone_title_small_sum; }
            set //
            {
                if (!phone_title_small_sum_initialized || m_phone_title_small_sum != value)
                {
                    this.m_phone_title_small_sum = value;
                }
                phone_title_small_sum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Phone_title_sum
        {
            get { return this.m_phone_title_sum; }
            set //
            {
                if (!phone_title_sum_initialized || m_phone_title_sum != value)
                {
                    this.m_phone_title_sum = value;
                }
                phone_title_sum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Title_big
        {
            get { return this.m_title_big; }
            set //
            {
                if (!title_big_initialized || m_title_big != value)
                {
                    this.m_title_big = value;
                }
                title_big_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Title_head
        {
            get { return this.m_title_head; }
            set //
            {
                if (!title_head_initialized || m_title_head != value)
                {
                    this.m_title_head = value;
                }
                title_head_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Title_small
        {
            get { return this.m_title_small; }
            set //
            {
                if (!title_small_initialized || m_title_small != value)
                {
                    this.m_title_small = value;
                }
                title_small_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_indexpage].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Btn_dayi =  new AttributeItem("[Xb_indexpage].[Btn_dayi]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Btn_tiku =  new AttributeItem("[Xb_indexpage].[Btn_tiku]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_title =  new AttributeItem("[Xb_indexpage].[Phone_title]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_title_small =  new AttributeItem("[Xb_indexpage].[Phone_title_small]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_title_small_sum =  new AttributeItem("[Xb_indexpage].[Phone_title_small_sum]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_title_sum =  new AttributeItem("[Xb_indexpage].[Phone_title_sum]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title_big =  new AttributeItem("[Xb_indexpage].[Title_big]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title_head =  new AttributeItem("[Xb_indexpage].[Title_head]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title_small =  new AttributeItem("[Xb_indexpage].[Title_small]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_btn_dayi;
        /// <summary></summary>
        protected bool btn_dayi_initialized = false;
        
        private string m_btn_tiku;
        /// <summary></summary>
        protected bool btn_tiku_initialized = false;
        
        private string m_phone_title;
        /// <summary></summary>
        protected bool phone_title_initialized = false;
        
        private string m_phone_title_small;
        /// <summary></summary>
        protected bool phone_title_small_initialized = false;
        
        private string m_phone_title_small_sum;
        /// <summary></summary>
        protected bool phone_title_small_sum_initialized = false;
        
        private string m_phone_title_sum;
        /// <summary></summary>
        protected bool phone_title_sum_initialized = false;
        
        private string m_title_big;
        /// <summary></summary>
        protected bool title_big_initialized = false;
        
        private string m_title_head;
        /// <summary></summary>
        protected bool title_head_initialized = false;
        
        private string m_title_small;
        /// <summary></summary>
        protected bool title_small_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_indexpage";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.btn_dayi_initialized = IsLoadAllAttributes;this.btn_tiku_initialized = IsLoadAllAttributes;this.phone_title_initialized = IsLoadAllAttributes;this.phone_title_small_initialized = IsLoadAllAttributes;this.phone_title_small_sum_initialized = IsLoadAllAttributes;this.phone_title_sum_initialized = IsLoadAllAttributes;this.title_big_initialized = IsLoadAllAttributes;this.title_head_initialized = IsLoadAllAttributes;this.title_small_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_indexpage value = new Xb_indexpage();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Btn_dayi"))
				value.btn_dayi_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Btn_tiku"))
				value.btn_tiku_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_title"))
				value.phone_title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_title_small"))
				value.phone_title_small_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_title_small_sum"))
				value.phone_title_small_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_title_sum"))
				value.phone_title_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title_big"))
				value.title_big_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title_head"))
				value.title_head_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title_small"))
				value.title_small_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_indexpage Clone()
        {
            return (Xb_indexpage)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_indexpage()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_indexpage() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_indexpage(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_indexpage(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_indexpage(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_indexpage(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_indexpage(int id1, string btn_dayi1, string btn_tiku1, string phone_title1, string phone_title_small1, string phone_title_small_sum1, string phone_title_sum1, string title_big1, string title_head1, string title_small1)
        {
            
            this.Id = id1;
            
            this.Btn_dayi = btn_dayi1;
            
            this.Btn_tiku = btn_tiku1;
            
            this.Phone_title = phone_title1;
            
            this.Phone_title_small = phone_title_small1;
            
            this.Phone_title_small_sum = phone_title_small_sum1;
            
            this.Phone_title_sum = phone_title_sum1;
            
            this.Title_big = title_big1;
            
            this.Title_head = title_head1;
            
            this.Title_small = title_small1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_indexpage FromIView(IView view)
        {
            return (Xb_indexpage)IView.GetITable(view, "Xb_indexpage");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_indexpage GetOneInstance()
        {
            Xb_indexpage value = new Xb_indexpage();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_indexpage Retrieve()
        {
            BLLTable<Xb_indexpage>.GetRowData(this);
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
			    			
			    case "Btn_dayi":
			        return Btn_dayi;
			    			
			    case "Btn_tiku":
			        return Btn_tiku;
			    			
			    case "Phone_title":
			        return Phone_title;
			    			
			    case "Phone_title_small":
			        return Phone_title_small;
			    			
			    case "Phone_title_small_sum":
			        return Phone_title_small_sum;
			    			
			    case "Phone_title_sum":
			        return Phone_title_sum;
			    			
			    case "Title_big":
			        return Title_big;
			    			
			    case "Title_head":
			        return Title_head;
			    			
			    case "Title_small":
			        return Title_small;
			
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
			    			
			    case "Btn_dayi":
			        this.Btn_dayi = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Btn_tiku":
			        this.Btn_tiku = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_title":
			        this.Phone_title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_title_small":
			        this.Phone_title_small = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_title_small_sum":
			        this.Phone_title_small_sum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_title_sum":
			        this.Phone_title_sum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title_big":
			        this.Title_big = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title_head":
			        this.Title_head = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title_small":
			        this.Title_small = Convert.ToString(AttributeValue);
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
				
				case "Btn_dayi":
					return btn_dayi_initialized;
				
				case "Btn_tiku":
					return btn_tiku_initialized;
				
				case "Phone_title":
					return phone_title_initialized;
				
				case "Phone_title_small":
					return phone_title_small_initialized;
				
				case "Phone_title_small_sum":
					return phone_title_small_sum_initialized;
				
				case "Phone_title_sum":
					return phone_title_sum_initialized;
				
				case "Title_big":
					return title_big_initialized;
				
				case "Title_head":
					return title_head_initialized;
				
				case "Title_small":
					return title_small_initialized;
				
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
				
				case "Btn_dayi":
					btn_dayi_initialized = ret;
					return true;
				
				case "Btn_tiku":
					btn_tiku_initialized = ret;
					return true;
				
				case "Phone_title":
					phone_title_initialized = ret;
					return true;
				
				case "Phone_title_small":
					phone_title_small_initialized = ret;
					return true;
				
				case "Phone_title_small_sum":
					phone_title_small_sum_initialized = ret;
					return true;
				
				case "Phone_title_sum":
					phone_title_sum_initialized = ret;
					return true;
				
				case "Title_big":
					title_big_initialized = ret;
					return true;
				
				case "Title_head":
					title_head_initialized = ret;
					return true;
				
				case "Title_small":
					title_small_initialized = ret;
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
                AttributeItem attr = Xb_indexpage.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (btn_dayi_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Btn_dayi;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Btn_dayi);
                }
			}
			
			if (btn_tiku_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Btn_tiku;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Btn_tiku);
                }
			}
			
			if (phone_title_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Phone_title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_title);
                }
			}
			
			if (phone_title_small_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Phone_title_small;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_title_small);
                }
			}
			
			if (phone_title_small_sum_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Phone_title_small_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_title_small_sum);
                }
			}
			
			if (phone_title_sum_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Phone_title_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_title_sum);
                }
			}
			
			if (title_big_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Title_big;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title_big);
                }
			}
			
			if (title_head_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Title_head;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title_head);
                }
			}
			
			if (title_small_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Title_small;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title_small);
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
        public class Xb_indexpageJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Btn_dayi { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Btn_tiku { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_title { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_title_small { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_title_small_sum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_title_sum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Title_big { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Title_head { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Title_small { get; set; }
        }
        #endregion
    }
}
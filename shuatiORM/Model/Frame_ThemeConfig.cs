/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/8/30 20:15:20
  Description:    数据表Frame_ThemeConfig对应的业务逻辑层Frame_ThemeConfig
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Frame_ThemeConfig_Entity:Frame_ThemeConfig
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Background_image_attachment_id,Background_image_url,Form_shadow,Form_style,Header,Header_image_attachment_id,Header_image_url,Indent_on_large_phone,Is_default,Submit_btn_shadow,Submit_btn_style,Submit_field_style,Theme_name,Typography,Wallpaper from Frame_ThemeConfig
delete from Frame_ThemeConfig
INSERT INTO Frame_ThemeConfig (Id,Background_image_attachment_id,Background_image_url,Form_shadow,Form_style,Header,Header_image_attachment_id,Header_image_url,Indent_on_large_phone,Is_default,Submit_btn_shadow,Submit_btn_style,Submit_field_style,Theme_name,Typography,Wallpaper)
     VALUES
           ('','','','','','','','','','','','','','','','')
UPDATE Frame_ThemeConfig SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Background_image_attachment_id = valObj2.Background_image_attachment_id;
        valObj.Background_image_url = valObj2.Background_image_url;
        valObj.Form_shadow = valObj2.Form_shadow;
        valObj.Form_style = valObj2.Form_style;
        valObj.Header = valObj2.Header;
        valObj.Header_image_attachment_id = valObj2.Header_image_attachment_id;
        valObj.Header_image_url = valObj2.Header_image_url;
        valObj.Indent_on_large_phone = valObj2.Indent_on_large_phone;
        valObj.Is_default = valObj2.Is_default;
        valObj.Submit_btn_shadow = valObj2.Submit_btn_shadow;
        valObj.Submit_btn_style = valObj2.Submit_btn_style;
        valObj.Submit_field_style = valObj2.Submit_field_style;
        valObj.Theme_name = valObj2.Theme_name;
        valObj.Typography = valObj2.Typography;
        valObj.Wallpaper = valObj2.Wallpaper; 
        valObj.Id = "";
        valObj.Background_image_attachment_id = "";
        valObj.Background_image_url = "";
        valObj.Form_shadow = "";
        valObj.Form_style = "";
        valObj.Header = "";
        valObj.Header_image_attachment_id = "";
        valObj.Header_image_url = "";
        valObj.Indent_on_large_phone = "";
        valObj.Is_default = "";
        valObj.Submit_btn_shadow = "";
        valObj.Submit_btn_style = "";
        valObj.Submit_field_style = "";
        valObj.Theme_name = "";
        valObj.Typography = "";
        valObj.Wallpaper = ""; 
        "Id": $("#txt_Id").val(),
        "Background_image_attachment_id": $("#txt_Background_image_attachment_id").val(),
        "Background_image_url": $("#txt_Background_image_url").val(),
        "Form_shadow": $("#txt_Form_shadow").val(),
        "Form_style": $("#txt_Form_style").val(),
        "Header": $("#txt_Header").val(),
        "Header_image_attachment_id": $("#txt_Header_image_attachment_id").val(),
        "Header_image_url": $("#txt_Header_image_url").val(),
        "Indent_on_large_phone": $("#txt_Indent_on_large_phone").val(),
        "Is_default": $("#txt_Is_default").val(),
        "Submit_btn_shadow": $("#txt_Submit_btn_shadow").val(),
        "Submit_btn_style": $("#txt_Submit_btn_style").val(),
        "Submit_field_style": $("#txt_Submit_field_style").val(),
        "Theme_name": $("#txt_Theme_name").val(),
        "Typography": $("#txt_Typography").val(),
        "Wallpaper": $("#txt_Wallpaper").val(), 
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
    /// <para>表单样式配置管理</para>
    /// <para>与Frame_ThemeConfig数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Frame_ThemeConfig : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Frame_ThemeConfig Factory()
        {
            return new Frame_ThemeConfig();
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
        public string _Background_image_attachment_id
        {            
            get { return this.Background_image_attachment_id; }
            set { this.Background_image_attachment_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Background_image_url
        {            
            get { return this.Background_image_url; }
            set { this.Background_image_url = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Form_shadow
        {            
            get { return this.Form_shadow; }
            set { this.Form_shadow = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Form_style
        {            
            get { return this.Form_style; }
            set { this.Form_style = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Header
        {            
            get { return this.Header; }
            set { this.Header = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Header_image_attachment_id
        {            
            get { return this.Header_image_attachment_id; }
            set { this.Header_image_attachment_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Header_image_url
        {            
            get { return this.Header_image_url; }
            set { this.Header_image_url = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Indent_on_large_phone
        {            
            get { return this.Indent_on_large_phone; }
            set { this.Indent_on_large_phone = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Is_default
        {            
            get { return this.Is_default; }
            set { this.Is_default = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Submit_btn_shadow
        {            
            get { return this.Submit_btn_shadow; }
            set { this.Submit_btn_shadow = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Submit_btn_style
        {            
            get { return this.Submit_btn_style; }
            set { this.Submit_btn_style = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Submit_field_style
        {            
            get { return this.Submit_field_style; }
            set { this.Submit_field_style = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Theme_name
        {            
            get { return this.Theme_name; }
            set { this.Theme_name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Typography
        {            
            get { return this.Typography; }
            set { this.Typography = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Wallpaper
        {            
            get { return this.Wallpaper; }
            set { this.Wallpaper = value; }
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
        public string Background_image_attachment_id
        {
            get { return this.m_background_image_attachment_id; }
            set //
            {
                if (!background_image_attachment_id_initialized || m_background_image_attachment_id != value)
                {
                    this.m_background_image_attachment_id = value;
                }
                background_image_attachment_id_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Background_image_url
        {
            get { return this.m_background_image_url; }
            set //
            {
                if (!background_image_url_initialized || m_background_image_url != value)
                {
                    this.m_background_image_url = value;
                }
                background_image_url_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Form_shadow
        {
            get { return this.m_form_shadow; }
            set //
            {
                if (!form_shadow_initialized || m_form_shadow != value)
                {
                    this.m_form_shadow = value;
                }
                form_shadow_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Form_style
        {
            get { return this.m_form_style; }
            set //
            {
                if (!form_style_initialized || m_form_style != value)
                {
                    this.m_form_style = value;
                }
                form_style_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Header
        {
            get { return this.m_header; }
            set //
            {
                if (!header_initialized || m_header != value)
                {
                    this.m_header = value;
                }
                header_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Header_image_attachment_id
        {
            get { return this.m_header_image_attachment_id; }
            set //
            {
                if (!header_image_attachment_id_initialized || m_header_image_attachment_id != value)
                {
                    this.m_header_image_attachment_id = value;
                }
                header_image_attachment_id_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Header_image_url
        {
            get { return this.m_header_image_url; }
            set //
            {
                if (!header_image_url_initialized || m_header_image_url != value)
                {
                    this.m_header_image_url = value;
                }
                header_image_url_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Indent_on_large_phone
        {
            get { return this.m_indent_on_large_phone; }
            set //
            {
                if (!indent_on_large_phone_initialized || m_indent_on_large_phone != value)
                {
                    this.m_indent_on_large_phone = value;
                }
                indent_on_large_phone_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Is_default
        {
            get { return this.m_is_default; }
            set //
            {
                if (!is_default_initialized || m_is_default != value)
                {
                    this.m_is_default = value;
                }
                is_default_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Submit_btn_shadow
        {
            get { return this.m_submit_btn_shadow; }
            set //
            {
                if (!submit_btn_shadow_initialized || m_submit_btn_shadow != value)
                {
                    this.m_submit_btn_shadow = value;
                }
                submit_btn_shadow_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Submit_btn_style
        {
            get { return this.m_submit_btn_style; }
            set //
            {
                if (!submit_btn_style_initialized || m_submit_btn_style != value)
                {
                    this.m_submit_btn_style = value;
                }
                submit_btn_style_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Submit_field_style
        {
            get { return this.m_submit_field_style; }
            set //
            {
                if (!submit_field_style_initialized || m_submit_field_style != value)
                {
                    this.m_submit_field_style = value;
                }
                submit_field_style_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Theme_name
        {
            get { return this.m_theme_name; }
            set //
            {
                if (!theme_name_initialized || m_theme_name != value)
                {
                    this.m_theme_name = value;
                }
                theme_name_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Typography
        {
            get { return this.m_typography; }
            set //
            {
                if (!typography_initialized || m_typography != value)
                {
                    this.m_typography = value;
                }
                typography_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Wallpaper
        {
            get { return this.m_wallpaper; }
            set //
            {
                if (!wallpaper_initialized || m_wallpaper != value)
                {
                    this.m_wallpaper = value;
                }
                wallpaper_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Frame_ThemeConfig].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Background_image_attachment_id =  new AttributeItem("[Frame_ThemeConfig].[Background_image_attachment_id]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Background_image_url =  new AttributeItem("[Frame_ThemeConfig].[Background_image_url]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Form_shadow =  new AttributeItem("[Frame_ThemeConfig].[Form_shadow]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Form_style =  new AttributeItem("[Frame_ThemeConfig].[Form_style]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Header =  new AttributeItem("[Frame_ThemeConfig].[Header]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Header_image_attachment_id =  new AttributeItem("[Frame_ThemeConfig].[Header_image_attachment_id]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Header_image_url =  new AttributeItem("[Frame_ThemeConfig].[Header_image_url]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Indent_on_large_phone =  new AttributeItem("[Frame_ThemeConfig].[Indent_on_large_phone]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Is_default =  new AttributeItem("[Frame_ThemeConfig].[Is_default]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Submit_btn_shadow =  new AttributeItem("[Frame_ThemeConfig].[Submit_btn_shadow]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Submit_btn_style =  new AttributeItem("[Frame_ThemeConfig].[Submit_btn_style]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Submit_field_style =  new AttributeItem("[Frame_ThemeConfig].[Submit_field_style]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Theme_name =  new AttributeItem("[Frame_ThemeConfig].[Theme_name]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Typography =  new AttributeItem("[Frame_ThemeConfig].[Typography]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Wallpaper =  new AttributeItem("[Frame_ThemeConfig].[Wallpaper]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_background_image_attachment_id;
        /// <summary></summary>
        protected bool background_image_attachment_id_initialized = false;
        
        private string m_background_image_url;
        /// <summary></summary>
        protected bool background_image_url_initialized = false;
        
        private string m_form_shadow;
        /// <summary></summary>
        protected bool form_shadow_initialized = false;
        
        private string m_form_style;
        /// <summary></summary>
        protected bool form_style_initialized = false;
        
        private string m_header;
        /// <summary></summary>
        protected bool header_initialized = false;
        
        private string m_header_image_attachment_id;
        /// <summary></summary>
        protected bool header_image_attachment_id_initialized = false;
        
        private string m_header_image_url;
        /// <summary></summary>
        protected bool header_image_url_initialized = false;
        
        private string m_indent_on_large_phone;
        /// <summary></summary>
        protected bool indent_on_large_phone_initialized = false;
        
        private string m_is_default;
        /// <summary></summary>
        protected bool is_default_initialized = false;
        
        private string m_submit_btn_shadow;
        /// <summary></summary>
        protected bool submit_btn_shadow_initialized = false;
        
        private string m_submit_btn_style;
        /// <summary></summary>
        protected bool submit_btn_style_initialized = false;
        
        private string m_submit_field_style;
        /// <summary></summary>
        protected bool submit_field_style_initialized = false;
        
        private string m_theme_name;
        /// <summary></summary>
        protected bool theme_name_initialized = false;
        
        private string m_typography;
        /// <summary></summary>
        protected bool typography_initialized = false;
        
        private string m_wallpaper;
        /// <summary></summary>
        protected bool wallpaper_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Frame_ThemeConfig";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.background_image_attachment_id_initialized = IsLoadAllAttributes;this.background_image_url_initialized = IsLoadAllAttributes;this.form_shadow_initialized = IsLoadAllAttributes;this.form_style_initialized = IsLoadAllAttributes;this.header_initialized = IsLoadAllAttributes;this.header_image_attachment_id_initialized = IsLoadAllAttributes;this.header_image_url_initialized = IsLoadAllAttributes;this.indent_on_large_phone_initialized = IsLoadAllAttributes;this.is_default_initialized = IsLoadAllAttributes;this.submit_btn_shadow_initialized = IsLoadAllAttributes;this.submit_btn_style_initialized = IsLoadAllAttributes;this.submit_field_style_initialized = IsLoadAllAttributes;this.theme_name_initialized = IsLoadAllAttributes;this.typography_initialized = IsLoadAllAttributes;this.wallpaper_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Frame_ThemeConfig value = new Frame_ThemeConfig();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Background_image_attachment_id"))
				value.background_image_attachment_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Background_image_url"))
				value.background_image_url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Form_shadow"))
				value.form_shadow_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Form_style"))
				value.form_style_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Header"))
				value.header_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Header_image_attachment_id"))
				value.header_image_attachment_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Header_image_url"))
				value.header_image_url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Indent_on_large_phone"))
				value.indent_on_large_phone_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_default"))
				value.is_default_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit_btn_shadow"))
				value.submit_btn_shadow_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit_btn_style"))
				value.submit_btn_style_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Submit_field_style"))
				value.submit_field_style_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Theme_name"))
				value.theme_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Typography"))
				value.typography_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wallpaper"))
				value.wallpaper_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Frame_ThemeConfig Clone()
        {
            return (Frame_ThemeConfig)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Frame_ThemeConfig()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Frame_ThemeConfig() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Frame_ThemeConfig(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Frame_ThemeConfig(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Frame_ThemeConfig(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Frame_ThemeConfig(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Frame_ThemeConfig(int id1, string background_image_attachment_id1, string background_image_url1, string form_shadow1, string form_style1, string header1, string header_image_attachment_id1, string header_image_url1, string indent_on_large_phone1, string is_default1, string submit_btn_shadow1, string submit_btn_style1, string submit_field_style1, string theme_name1, string typography1, string wallpaper1)
        {
            
            this.Id = id1;
            
            this.Background_image_attachment_id = background_image_attachment_id1;
            
            this.Background_image_url = background_image_url1;
            
            this.Form_shadow = form_shadow1;
            
            this.Form_style = form_style1;
            
            this.Header = header1;
            
            this.Header_image_attachment_id = header_image_attachment_id1;
            
            this.Header_image_url = header_image_url1;
            
            this.Indent_on_large_phone = indent_on_large_phone1;
            
            this.Is_default = is_default1;
            
            this.Submit_btn_shadow = submit_btn_shadow1;
            
            this.Submit_btn_style = submit_btn_style1;
            
            this.Submit_field_style = submit_field_style1;
            
            this.Theme_name = theme_name1;
            
            this.Typography = typography1;
            
            this.Wallpaper = wallpaper1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Frame_ThemeConfig FromIView(IView view)
        {
            return (Frame_ThemeConfig)IView.GetITable(view, "Frame_ThemeConfig");
        }
        /// <summary>获得一个实例  </summary>
        public static Frame_ThemeConfig GetOneInstance()
        {
            Frame_ThemeConfig value = new Frame_ThemeConfig();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Frame_ThemeConfig Retrieve()
        {
            BLLTable<Frame_ThemeConfig>.GetRowData(this);
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
			    			
			    case "Background_image_attachment_id":
			        return Background_image_attachment_id;
			    			
			    case "Background_image_url":
			        return Background_image_url;
			    			
			    case "Form_shadow":
			        return Form_shadow;
			    			
			    case "Form_style":
			        return Form_style;
			    			
			    case "Header":
			        return Header;
			    			
			    case "Header_image_attachment_id":
			        return Header_image_attachment_id;
			    			
			    case "Header_image_url":
			        return Header_image_url;
			    			
			    case "Indent_on_large_phone":
			        return Indent_on_large_phone;
			    			
			    case "Is_default":
			        return Is_default;
			    			
			    case "Submit_btn_shadow":
			        return Submit_btn_shadow;
			    			
			    case "Submit_btn_style":
			        return Submit_btn_style;
			    			
			    case "Submit_field_style":
			        return Submit_field_style;
			    			
			    case "Theme_name":
			        return Theme_name;
			    			
			    case "Typography":
			        return Typography;
			    			
			    case "Wallpaper":
			        return Wallpaper;
			
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
			    			
			    case "Background_image_attachment_id":
			        this.Background_image_attachment_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Background_image_url":
			        this.Background_image_url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Form_shadow":
			        this.Form_shadow = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Form_style":
			        this.Form_style = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Header":
			        this.Header = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Header_image_attachment_id":
			        this.Header_image_attachment_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Header_image_url":
			        this.Header_image_url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Indent_on_large_phone":
			        this.Indent_on_large_phone = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_default":
			        this.Is_default = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Submit_btn_shadow":
			        this.Submit_btn_shadow = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Submit_btn_style":
			        this.Submit_btn_style = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Submit_field_style":
			        this.Submit_field_style = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Theme_name":
			        this.Theme_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Typography":
			        this.Typography = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wallpaper":
			        this.Wallpaper = Convert.ToString(AttributeValue);
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
				
				case "Background_image_attachment_id":
					return background_image_attachment_id_initialized;
				
				case "Background_image_url":
					return background_image_url_initialized;
				
				case "Form_shadow":
					return form_shadow_initialized;
				
				case "Form_style":
					return form_style_initialized;
				
				case "Header":
					return header_initialized;
				
				case "Header_image_attachment_id":
					return header_image_attachment_id_initialized;
				
				case "Header_image_url":
					return header_image_url_initialized;
				
				case "Indent_on_large_phone":
					return indent_on_large_phone_initialized;
				
				case "Is_default":
					return is_default_initialized;
				
				case "Submit_btn_shadow":
					return submit_btn_shadow_initialized;
				
				case "Submit_btn_style":
					return submit_btn_style_initialized;
				
				case "Submit_field_style":
					return submit_field_style_initialized;
				
				case "Theme_name":
					return theme_name_initialized;
				
				case "Typography":
					return typography_initialized;
				
				case "Wallpaper":
					return wallpaper_initialized;
				
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
				
				case "Background_image_attachment_id":
					background_image_attachment_id_initialized = ret;
					return true;
				
				case "Background_image_url":
					background_image_url_initialized = ret;
					return true;
				
				case "Form_shadow":
					form_shadow_initialized = ret;
					return true;
				
				case "Form_style":
					form_style_initialized = ret;
					return true;
				
				case "Header":
					header_initialized = ret;
					return true;
				
				case "Header_image_attachment_id":
					header_image_attachment_id_initialized = ret;
					return true;
				
				case "Header_image_url":
					header_image_url_initialized = ret;
					return true;
				
				case "Indent_on_large_phone":
					indent_on_large_phone_initialized = ret;
					return true;
				
				case "Is_default":
					is_default_initialized = ret;
					return true;
				
				case "Submit_btn_shadow":
					submit_btn_shadow_initialized = ret;
					return true;
				
				case "Submit_btn_style":
					submit_btn_style_initialized = ret;
					return true;
				
				case "Submit_field_style":
					submit_field_style_initialized = ret;
					return true;
				
				case "Theme_name":
					theme_name_initialized = ret;
					return true;
				
				case "Typography":
					typography_initialized = ret;
					return true;
				
				case "Wallpaper":
					wallpaper_initialized = ret;
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
                AttributeItem attr = Frame_ThemeConfig.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (background_image_attachment_id_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Background_image_attachment_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Background_image_attachment_id);
                }
			}
			
			if (background_image_url_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Background_image_url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Background_image_url);
                }
			}
			
			if (form_shadow_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Form_shadow;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Form_shadow);
                }
			}
			
			if (form_style_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Form_style;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Form_style);
                }
			}
			
			if (header_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Header;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Header);
                }
			}
			
			if (header_image_attachment_id_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Header_image_attachment_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Header_image_attachment_id);
                }
			}
			
			if (header_image_url_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Header_image_url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Header_image_url);
                }
			}
			
			if (indent_on_large_phone_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Indent_on_large_phone;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Indent_on_large_phone);
                }
			}
			
			if (is_default_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Is_default;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_default);
                }
			}
			
			if (submit_btn_shadow_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Submit_btn_shadow;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit_btn_shadow);
                }
			}
			
			if (submit_btn_style_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Submit_btn_style;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit_btn_style);
                }
			}
			
			if (submit_field_style_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Submit_field_style;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Submit_field_style);
                }
			}
			
			if (theme_name_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Theme_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Theme_name);
                }
			}
			
			if (typography_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Typography;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Typography);
                }
			}
			
			if (wallpaper_initialized)
			{
                AttributeItem attr = Frame_ThemeConfig.Attribute.Wallpaper;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wallpaper);
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
        public class Frame_ThemeConfigJson
        {
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public string Background_image_attachment_id { get; set; }
            
            /// <summary></summary>
            public string Background_image_url { get; set; }
            
            /// <summary></summary>
            public string Form_shadow { get; set; }
            
            /// <summary></summary>
            public string Form_style { get; set; }
            
            /// <summary></summary>
            public string Header { get; set; }
            
            /// <summary></summary>
            public string Header_image_attachment_id { get; set; }
            
            /// <summary></summary>
            public string Header_image_url { get; set; }
            
            /// <summary></summary>
            public string Indent_on_large_phone { get; set; }
            
            /// <summary></summary>
            public string Is_default { get; set; }
            
            /// <summary></summary>
            public string Submit_btn_shadow { get; set; }
            
            /// <summary></summary>
            public string Submit_btn_style { get; set; }
            
            /// <summary></summary>
            public string Submit_field_style { get; set; }
            
            /// <summary></summary>
            public string Theme_name { get; set; }
            
            /// <summary></summary>
            public string Typography { get; set; }
            
            /// <summary></summary>
            public string Wallpaper { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/9/1 14:20:08
  Description:    数据表Frame_FieldConfig对应的业务逻辑层Frame_FieldConfig
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Frame_FieldConfig_Entity:Frame_FieldConfig
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Api_code,Associated,Ctrl,Customized_validation_message,Field_inability_info,Fname,Grids_to_occupy,Is_cache,IsEnable,IsListVisable,IsReadOnly,IsVisable,ListPosition,Maximum_length,Minimum_length,Notes,Position,Predefined_value,Private,Quota_blank_warning,Random_choices,Range_max,Range_min,Start_new_row,Table_name,Title,Uuid,Validations,Zh from Frame_FieldConfig
delete from Frame_FieldConfig
INSERT INTO Frame_FieldConfig (Id,Api_code,Associated,Ctrl,Customized_validation_message,Field_inability_info,Fname,Grids_to_occupy,Is_cache,IsEnable,IsListVisable,IsReadOnly,IsVisable,ListPosition,Maximum_length,Minimum_length,Notes,Position,Predefined_value,Private,Quota_blank_warning,Random_choices,Range_max,Range_min,Start_new_row,Table_name,Title,Uuid,Validations,Zh)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Frame_FieldConfig SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Api_code = valObj2.Api_code;
        valObj.Associated = valObj2.Associated;
        valObj.Ctrl = valObj2.Ctrl;
        valObj.Customized_validation_message = valObj2.Customized_validation_message;
        valObj.Field_inability_info = valObj2.Field_inability_info;
        valObj.Fname = valObj2.Fname;
        valObj.Grids_to_occupy = valObj2.Grids_to_occupy;
        valObj.Is_cache = valObj2.Is_cache;
        valObj.IsEnable = valObj2.IsEnable;
        valObj.IsListVisable = valObj2.IsListVisable;
        valObj.IsReadOnly = valObj2.IsReadOnly;
        valObj.IsVisable = valObj2.IsVisable;
        valObj.ListPosition = valObj2.ListPosition;
        valObj.Maximum_length = valObj2.Maximum_length;
        valObj.Minimum_length = valObj2.Minimum_length;
        valObj.Notes = valObj2.Notes;
        valObj.Position = valObj2.Position;
        valObj.Predefined_value = valObj2.Predefined_value;
        valObj.Private = valObj2.Private;
        valObj.Quota_blank_warning = valObj2.Quota_blank_warning;
        valObj.Random_choices = valObj2.Random_choices;
        valObj.Range_max = valObj2.Range_max;
        valObj.Range_min = valObj2.Range_min;
        valObj.Start_new_row = valObj2.Start_new_row;
        valObj.Table_name = valObj2.Table_name;
        valObj.Title = valObj2.Title;
        valObj.Uuid = valObj2.Uuid;
        valObj.Validations = valObj2.Validations;
        valObj.Zh = valObj2.Zh; 
        valObj.Id = "";
        valObj.Api_code = "";
        valObj.Associated = "";
        valObj.Ctrl = "";
        valObj.Customized_validation_message = "";
        valObj.Field_inability_info = "";
        valObj.Fname = "";
        valObj.Grids_to_occupy = "";
        valObj.Is_cache = "";
        valObj.IsEnable = "";
        valObj.IsListVisable = "";
        valObj.IsReadOnly = "";
        valObj.IsVisable = "";
        valObj.ListPosition = "";
        valObj.Maximum_length = "";
        valObj.Minimum_length = "";
        valObj.Notes = "";
        valObj.Position = "";
        valObj.Predefined_value = "";
        valObj.Private = "";
        valObj.Quota_blank_warning = "";
        valObj.Random_choices = "";
        valObj.Range_max = "";
        valObj.Range_min = "";
        valObj.Start_new_row = "";
        valObj.Table_name = "";
        valObj.Title = "";
        valObj.Uuid = "";
        valObj.Validations = "";
        valObj.Zh = ""; 
        "Id": $("#txt_Id").val(),
        "Api_code": $("#txt_Api_code").val(),
        "Associated": $("#txt_Associated").val(),
        "Ctrl": $("#txt_Ctrl").val(),
        "Customized_validation_message": $("#txt_Customized_validation_message").val(),
        "Field_inability_info": $("#txt_Field_inability_info").val(),
        "Fname": $("#txt_Fname").val(),
        "Grids_to_occupy": $("#txt_Grids_to_occupy").val(),
        "Is_cache": $("#txt_Is_cache").val(),
        "IsEnable": $("#txt_IsEnable").val(),
        "IsListVisable": $("#txt_IsListVisable").val(),
        "IsReadOnly": $("#txt_IsReadOnly").val(),
        "IsVisable": $("#txt_IsVisable").val(),
        "ListPosition": $("#txt_ListPosition").val(),
        "Maximum_length": $("#txt_Maximum_length").val(),
        "Minimum_length": $("#txt_Minimum_length").val(),
        "Notes": $("#txt_Notes").val(),
        "Position": $("#txt_Position").val(),
        "Predefined_value": $("#txt_Predefined_value").val(),
        "Private": $("#txt_Private").val(),
        "Quota_blank_warning": $("#txt_Quota_blank_warning").val(),
        "Random_choices": $("#txt_Random_choices").val(),
        "Range_max": $("#txt_Range_max").val(),
        "Range_min": $("#txt_Range_min").val(),
        "Start_new_row": $("#txt_Start_new_row").val(),
        "Table_name": $("#txt_Table_name").val(),
        "Title": $("#txt_Title").val(),
        "Uuid": $("#txt_Uuid").val(),
        "Validations": $("#txt_Validations").val(),
        "Zh": $("#txt_Zh").val(), 
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
    /// <para>数据字段配置管理</para>
    /// <para>与Frame_FieldConfig数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Frame_FieldConfig : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Frame_FieldConfig Factory()
        {
            return new Frame_FieldConfig();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> 编号 Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> 开放平台编码 Attribute_IsNotNull </summary>
        public string _Api_code
        {            
            get { return this.Api_code; }
            set { this.Api_code = value; }
        }
        
        /// <summary> 是否关联字段 Attribute_IsNotNull </summary>
        public bool _Associated
        {            
            get { return this.Associated; }
            set { this.Associated = value; }
        }
        
        /// <summary> 控件类型:[Enum-{InputString:单行文本},{SmallText:小文本200字},{Text:大文本内容},{HTML:HTML内容},{Geo:地理位置},{InputDate:日期},{InputDecimal:数字},{InputNumber:整数},{InputTime:时间},{InputDateTime:日期时间},{InputPassWord:密码},{InputEmail:Email},{InputIDCard:ID卡},{InputIPAddr:IP地址},{InputMobile:手机号码},{InputTel:电话},{InputPostCode:邮编},{SelectDrop:下拉框},{SelectSingle:单选框},{SelectMulti:多选框},{FileUpUpDoc:上传文档},{FileUpImage:上传图片},{OpenSelStaff:选择职员},{OpenSelDept:选择部门},{OpenSelExistsRec:选择存在的记录},{Select_RelationUser:选择关联用户},{Select_RelationFK:选择相关对象}][CtrlTypeDic-{SelectSingle}] Attribute_IsNotNull </summary>
        public string _Ctrl
        {            
            get { return this.Ctrl; }
            set { this.Ctrl = value; }
        }
        
        /// <summary> 自定义校验错误信息 Attribute_IsNotNull </summary>
        public string _Customized_validation_message
        {            
            get { return this.Customized_validation_message; }
            set { this.Customized_validation_message = value; }
        }
        
        /// <summary> 禁用 Attribute_IsNotNull </summary>
        public string _Field_inability_info
        {            
            get { return this.Field_inability_info; }
            set { this.Field_inability_info = value; }
        }
        
        /// <summary> 字段名 Attribute_IsNotNull </summary>
        public string _Fname
        {            
            get { return this.Fname; }
            set { this.Fname = value; }
        }
        
        /// <summary> 矩阵填充 Attribute_IsNotNull </summary>
        public string _Grids_to_occupy
        {            
            get { return this.Grids_to_occupy; }
            set { this.Grids_to_occupy = value; }
        }
        
        /// <summary> 是否缓存 Attribute_IsNotNull </summary>
        public bool _Is_cache
        {            
            get { return this.Is_cache; }
            set { this.Is_cache = value; }
        }
        
        /// <summary> 是否可用 Attribute_IsNotNull </summary>
        public bool _IsEnable
        {            
            get { return this.IsEnable; }
            set { this.IsEnable = value; }
        }
        
        /// <summary> 是否列表页显示 Attribute_IsNotNull </summary>
        public bool _IsListVisable
        {            
            get { return this.IsListVisable; }
            set { this.IsListVisable = value; }
        }
        
        /// <summary> 是否只读 Attribute_IsNotNull </summary>
        public bool _IsReadOnly
        {            
            get { return this.IsReadOnly; }
            set { this.IsReadOnly = value; }
        }
        
        /// <summary> 是否详情页显示 Attribute_IsNotNull </summary>
        public bool _IsVisable
        {            
            get { return this.IsVisable; }
            set { this.IsVisable = value; }
        }
        
        /// <summary> 列表页位置 Attribute_IsNotNull </summary>
        public int _ListPosition
        {            
            get { return this.ListPosition; }
            set { this.ListPosition = value; }
        }
        
        /// <summary> 最大长度 Attribute_IsNotNull </summary>
        public int _Maximum_length
        {            
            get { return this.Maximum_length; }
            set { this.Maximum_length = value; }
        }
        
        /// <summary> 最小长度 Attribute_IsNotNull </summary>
        public int _Minimum_length
        {            
            get { return this.Minimum_length; }
            set { this.Minimum_length = value; }
        }
        
        /// <summary> 描述信息 Attribute_IsNotNull </summary>
        public string _Notes
        {            
            get { return this.Notes; }
            set { this.Notes = value; }
        }
        
        /// <summary> 编辑页顺序号 Attribute_IsNotNull </summary>
        public int _Position
        {            
            get { return this.Position; }
            set { this.Position = value; }
        }
        
        /// <summary> 默认值 Attribute_IsNotNull </summary>
        public string _Predefined_value
        {            
            get { return this.Predefined_value; }
            set { this.Predefined_value = value; }
        }
        
        /// <summary> 是否私有 Attribute_IsNotNull </summary>
        public bool _Private
        {            
            get { return this.Private; }
            set { this.Private = value; }
        }
        
        /// <summary> 未输入空白提醒:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public bool _Quota_blank_warning
        {            
            get { return this.Quota_blank_warning; }
            set { this.Quota_blank_warning = value; }
        }
        
        /// <summary> 选择项是否随机 Attribute_IsNotNull </summary>
        public bool _Random_choices
        {            
            get { return this.Random_choices; }
            set { this.Random_choices = value; }
        }
        
        /// <summary> 最大值 Attribute_IsNotNull </summary>
        public int _Range_max
        {            
            get { return this.Range_max; }
            set { this.Range_max = value; }
        }
        
        /// <summary> 最小值 Attribute_IsNotNull </summary>
        public int _Range_min
        {            
            get { return this.Range_min; }
            set { this.Range_min = value; }
        }
        
        /// <summary> 是否另起一行:[CtrlTypeDic-{SelectSingle}] Attribute_IsNotNull </summary>
        public bool _Start_new_row
        {            
            get { return this.Start_new_row; }
            set { this.Start_new_row = value; }
        }
        
        /// <summary> 表名 Attribute_IsNotNull </summary>
        public string _Table_name
        {            
            get { return this.Table_name; }
            set { this.Table_name = value; }
        }
        
        /// <summary> 标题 Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> Uuid Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> 是否校验:[CtrlTypeDic-{SelectSingle}] Attribute_IsNotNull </summary>
        public string _Validations
        {            
            get { return this.Validations; }
            set { this.Validations = value; }
        }
        
        /// <summary> 中文注释 Attribute_IsNotNull </summary>
        public string _Zh
        {            
            get { return this.Zh; }
            set { this.Zh = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> 编号，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 开放平台编码，推荐使用 "_"符号开头 </summary>
        public string Api_code
        {
            get { return this.m_api_code; }
            set //
            {
                if (!api_code_initialized || m_api_code != value)
                {
                    this.m_api_code = value;
                }
                api_code_initialized = true;
            }
        }
        
        /// <summary> 是否关联字段，推荐使用 "_"符号开头 </summary>
        public bool Associated
        {
            get { return this.m_associated; }
            set //
            {
                if (!associated_initialized || m_associated != value)
                {
                    this.m_associated = value;
                }
                associated_initialized = true;
            }
        }
        
        /// <summary> 控件类型:[Enum-{InputString:单行文本},{SmallText:小文本200字},{Text:大文本内容},{HTML:HTML内容},{Geo:地理位置},{InputDate:日期},{InputDecimal:数字},{InputNumber:整数},{InputTime:时间},{InputDateTime:日期时间},{InputPassWord:密码},{InputEmail:Email},{InputIDCard:ID卡},{InputIPAddr:IP地址},{InputMobile:手机号码},{InputTel:电话},{InputPostCode:邮编},{SelectDrop:下拉框},{SelectSingle:单选框},{SelectMulti:多选框},{FileUpUpDoc:上传文档},{FileUpImage:上传图片},{OpenSelStaff:选择职员},{OpenSelDept:选择部门},{OpenSelExistsRec:选择存在的记录},{Select_RelationUser:选择关联用户},{Select_RelationFK:选择相关对象}][CtrlTypeDic-{SelectSingle}]，推荐使用 "_"符号开头 </summary>
        public string Ctrl
        {
            get { return this.m_ctrl; }
            set //
            {
                if (!ctrl_initialized || m_ctrl != value)
                {
                    this.m_ctrl = value;
                }
                ctrl_initialized = true;
            }
        }
        
        /// <summary> 自定义校验错误信息，推荐使用 "_"符号开头 </summary>
        public string Customized_validation_message
        {
            get { return this.m_customized_validation_message; }
            set //
            {
                if (!customized_validation_message_initialized || m_customized_validation_message != value)
                {
                    this.m_customized_validation_message = value;
                }
                customized_validation_message_initialized = true;
            }
        }
        
        /// <summary> 禁用，推荐使用 "_"符号开头 </summary>
        public string Field_inability_info
        {
            get { return this.m_field_inability_info; }
            set //
            {
                if (!field_inability_info_initialized || m_field_inability_info != value)
                {
                    this.m_field_inability_info = value;
                }
                field_inability_info_initialized = true;
            }
        }
        
        /// <summary> 字段名，推荐使用 "_"符号开头 </summary>
        public string Fname
        {
            get { return this.m_fname; }
            set //
            {
                if (!fname_initialized || m_fname != value)
                {
                    this.m_fname = value;
                }
                fname_initialized = true;
            }
        }
        
        /// <summary> 矩阵填充，推荐使用 "_"符号开头 </summary>
        public string Grids_to_occupy
        {
            get { return this.m_grids_to_occupy; }
            set //
            {
                if (!grids_to_occupy_initialized || m_grids_to_occupy != value)
                {
                    this.m_grids_to_occupy = value;
                }
                grids_to_occupy_initialized = true;
            }
        }
        
        /// <summary> 是否缓存，推荐使用 "_"符号开头 </summary>
        public bool Is_cache
        {
            get { return this.m_is_cache; }
            set //
            {
                if (!is_cache_initialized || m_is_cache != value)
                {
                    this.m_is_cache = value;
                }
                is_cache_initialized = true;
            }
        }
        
        /// <summary> 是否可用，推荐使用 "_"符号开头 </summary>
        public bool IsEnable
        {
            get { return this.m_isenable; }
            set //
            {
                if (!isenable_initialized || m_isenable != value)
                {
                    this.m_isenable = value;
                }
                isenable_initialized = true;
            }
        }
        
        /// <summary> 是否列表页显示，推荐使用 "_"符号开头 </summary>
        public bool IsListVisable
        {
            get { return this.m_islistvisable; }
            set //
            {
                if (!islistvisable_initialized || m_islistvisable != value)
                {
                    this.m_islistvisable = value;
                }
                islistvisable_initialized = true;
            }
        }
        
        /// <summary> 是否只读，推荐使用 "_"符号开头 </summary>
        public bool IsReadOnly
        {
            get { return this.m_isreadonly; }
            set //
            {
                if (!isreadonly_initialized || m_isreadonly != value)
                {
                    this.m_isreadonly = value;
                }
                isreadonly_initialized = true;
            }
        }
        
        /// <summary> 是否详情页显示，推荐使用 "_"符号开头 </summary>
        public bool IsVisable
        {
            get { return this.m_isvisable; }
            set //
            {
                if (!isvisable_initialized || m_isvisable != value)
                {
                    this.m_isvisable = value;
                }
                isvisable_initialized = true;
            }
        }
        
        /// <summary> 列表页位置，推荐使用 "_"符号开头 </summary>
        public int ListPosition
        {
            get { return this.m_listposition; }
            set //
            {
                if (!listposition_initialized || m_listposition != value)
                {
                    this.m_listposition = value;
                }
                listposition_initialized = true;
            }
        }
        
        /// <summary> 最大长度，推荐使用 "_"符号开头 </summary>
        public int Maximum_length
        {
            get { return this.m_maximum_length; }
            set //
            {
                if (!maximum_length_initialized || m_maximum_length != value)
                {
                    this.m_maximum_length = value;
                }
                maximum_length_initialized = true;
            }
        }
        
        /// <summary> 最小长度，推荐使用 "_"符号开头 </summary>
        public int Minimum_length
        {
            get { return this.m_minimum_length; }
            set //
            {
                if (!minimum_length_initialized || m_minimum_length != value)
                {
                    this.m_minimum_length = value;
                }
                minimum_length_initialized = true;
            }
        }
        
        /// <summary> 描述信息，推荐使用 "_"符号开头 </summary>
        public string Notes
        {
            get { return this.m_notes; }
            set //
            {
                if (!notes_initialized || m_notes != value)
                {
                    this.m_notes = value;
                }
                notes_initialized = true;
            }
        }
        
        /// <summary> 编辑页顺序号，推荐使用 "_"符号开头 </summary>
        public int Position
        {
            get { return this.m_position; }
            set //
            {
                if (!position_initialized || m_position != value)
                {
                    this.m_position = value;
                }
                position_initialized = true;
            }
        }
        
        /// <summary> 默认值，推荐使用 "_"符号开头 </summary>
        public string Predefined_value
        {
            get { return this.m_predefined_value; }
            set //
            {
                if (!predefined_value_initialized || m_predefined_value != value)
                {
                    this.m_predefined_value = value;
                }
                predefined_value_initialized = true;
            }
        }
        
        /// <summary> 是否私有，推荐使用 "_"符号开头 </summary>
        public bool Private
        {
            get { return this.m_private; }
            set //
            {
                if (!private_initialized || m_private != value)
                {
                    this.m_private = value;
                }
                private_initialized = true;
            }
        }
        
        /// <summary> 未输入空白提醒:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public bool Quota_blank_warning
        {
            get { return this.m_quota_blank_warning; }
            set //
            {
                if (!quota_blank_warning_initialized || m_quota_blank_warning != value)
                {
                    this.m_quota_blank_warning = value;
                }
                quota_blank_warning_initialized = true;
            }
        }
        
        /// <summary> 选择项是否随机，推荐使用 "_"符号开头 </summary>
        public bool Random_choices
        {
            get { return this.m_random_choices; }
            set //
            {
                if (!random_choices_initialized || m_random_choices != value)
                {
                    this.m_random_choices = value;
                }
                random_choices_initialized = true;
            }
        }
        
        /// <summary> 最大值，推荐使用 "_"符号开头 </summary>
        public int Range_max
        {
            get { return this.m_range_max; }
            set //
            {
                if (!range_max_initialized || m_range_max != value)
                {
                    this.m_range_max = value;
                }
                range_max_initialized = true;
            }
        }
        
        /// <summary> 最小值，推荐使用 "_"符号开头 </summary>
        public int Range_min
        {
            get { return this.m_range_min; }
            set //
            {
                if (!range_min_initialized || m_range_min != value)
                {
                    this.m_range_min = value;
                }
                range_min_initialized = true;
            }
        }
        
        /// <summary> 是否另起一行:[CtrlTypeDic-{SelectSingle}]，推荐使用 "_"符号开头 </summary>
        public bool Start_new_row
        {
            get { return this.m_start_new_row; }
            set //
            {
                if (!start_new_row_initialized || m_start_new_row != value)
                {
                    this.m_start_new_row = value;
                }
                start_new_row_initialized = true;
            }
        }
        
        /// <summary> 表名，推荐使用 "_"符号开头 </summary>
        public string Table_name
        {
            get { return this.m_table_name; }
            set //
            {
                if (!table_name_initialized || m_table_name != value)
                {
                    this.m_table_name = value;
                }
                table_name_initialized = true;
            }
        }
        
        /// <summary> 标题，推荐使用 "_"符号开头 </summary>
        public string Title
        {
            get { return this.m_title; }
            set //
            {
                if (!title_initialized || m_title != value)
                {
                    this.m_title = value;
                }
                title_initialized = true;
            }
        }
        
        /// <summary> Uuid，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 是否校验:[CtrlTypeDic-{SelectSingle}]，推荐使用 "_"符号开头 </summary>
        public string Validations
        {
            get { return this.m_validations; }
            set //
            {
                if (!validations_initialized || m_validations != value)
                {
                    this.m_validations = value;
                }
                validations_initialized = true;
            }
        }
        
        /// <summary> 中文注释，推荐使用 "_"符号开头 </summary>
        public string Zh
        {
            get { return this.m_zh; }
            set //
            {
                if (!zh_initialized || m_zh != value)
                {
                    this.m_zh = value;
                }
                zh_initialized = true;
            }
        }    
        #endregion
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>编号</summary>
            public static AttributeItem Id =  new AttributeItem("[Frame_FieldConfig].[Id]", typeof(int), 4, default(int));
            
            /// <summary>开放平台编码</summary>
            public static AttributeItem Api_code =  new AttributeItem("[Frame_FieldConfig].[Api_code]", typeof(string), 200, default(string));
            
            /// <summary>是否关联字段</summary>
            public static AttributeItem Associated =  new AttributeItem("[Frame_FieldConfig].[Associated]", typeof(bool), 1, default(bool));
            
            /// <summary>控件类型:[Enum-{InputString:单行文本},{SmallText:小文本200字},{Text:大文本内容},{HTML:HTML内容},{Geo:地理位置},{InputDate:日期},{InputDecimal:数字},{InputNumber:整数},{InputTime:时间},{InputDateTime:日期时间},{InputPassWord:密码},{InputEmail:Email},{InputIDCard:ID卡},{InputIPAddr:IP地址},{InputMobile:手机号码},{InputTel:电话},{InputPostCode:邮编},{SelectDrop:下拉框},{SelectSingle:单选框},{SelectMulti:多选框},{FileUpUpDoc:上传文档},{FileUpImage:上传图片},{OpenSelStaff:选择职员},{OpenSelDept:选择部门},{OpenSelExistsRec:选择存在的记录},{Select_RelationUser:选择关联用户},{Select_RelationFK:选择相关对象}][CtrlTypeDic-{SelectSingle}]</summary>
            public static AttributeItem Ctrl =  new AttributeItem("[Frame_FieldConfig].[Ctrl]", typeof(string), 50, default(string));
            
            /// <summary>自定义校验错误信息</summary>
            public static AttributeItem Customized_validation_message =  new AttributeItem("[Frame_FieldConfig].[Customized_validation_message]", typeof(string), 200, default(string));
            
            /// <summary>禁用</summary>
            public static AttributeItem Field_inability_info =  new AttributeItem("[Frame_FieldConfig].[Field_inability_info]", typeof(string), 200, default(string));
            
            /// <summary>字段名</summary>
            public static AttributeItem Fname =  new AttributeItem("[Frame_FieldConfig].[Fname]", typeof(string), 200, default(string));
            
            /// <summary>矩阵填充</summary>
            public static AttributeItem Grids_to_occupy =  new AttributeItem("[Frame_FieldConfig].[Grids_to_occupy]", typeof(string), 200, default(string));
            
            /// <summary>是否缓存</summary>
            public static AttributeItem Is_cache =  new AttributeItem("[Frame_FieldConfig].[Is_cache]", typeof(bool), 1, default(bool));
            
            /// <summary>是否可用</summary>
            public static AttributeItem IsEnable =  new AttributeItem("[Frame_FieldConfig].[IsEnable]", typeof(bool), 1, default(bool));
            
            /// <summary>是否列表页显示</summary>
            public static AttributeItem IsListVisable =  new AttributeItem("[Frame_FieldConfig].[IsListVisable]", typeof(bool), 1, default(bool));
            
            /// <summary>是否只读</summary>
            public static AttributeItem IsReadOnly =  new AttributeItem("[Frame_FieldConfig].[IsReadOnly]", typeof(bool), 1, default(bool));
            
            /// <summary>是否详情页显示</summary>
            public static AttributeItem IsVisable =  new AttributeItem("[Frame_FieldConfig].[IsVisable]", typeof(bool), 1, default(bool));
            
            /// <summary>列表页位置</summary>
            public static AttributeItem ListPosition =  new AttributeItem("[Frame_FieldConfig].[ListPosition]", typeof(int), 4, default(int));
            
            /// <summary>最大长度</summary>
            public static AttributeItem Maximum_length =  new AttributeItem("[Frame_FieldConfig].[Maximum_length]", typeof(int), 4, default(int));
            
            /// <summary>最小长度</summary>
            public static AttributeItem Minimum_length =  new AttributeItem("[Frame_FieldConfig].[Minimum_length]", typeof(int), 4, default(int));
            
            /// <summary>描述信息</summary>
            public static AttributeItem Notes =  new AttributeItem("[Frame_FieldConfig].[Notes]", typeof(string), 200, default(string));
            
            /// <summary>编辑页顺序号</summary>
            public static AttributeItem Position =  new AttributeItem("[Frame_FieldConfig].[Position]", typeof(int), 4, default(int));
            
            /// <summary>默认值</summary>
            public static AttributeItem Predefined_value =  new AttributeItem("[Frame_FieldConfig].[Predefined_value]", typeof(string), 200, default(string));
            
            /// <summary>是否私有</summary>
            public static AttributeItem Private =  new AttributeItem("[Frame_FieldConfig].[Private]", typeof(bool), 1, default(bool));
            
            /// <summary>未输入空白提醒:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Quota_blank_warning =  new AttributeItem("[Frame_FieldConfig].[Quota_blank_warning]", typeof(bool), 1, default(bool));
            
            /// <summary>选择项是否随机</summary>
            public static AttributeItem Random_choices =  new AttributeItem("[Frame_FieldConfig].[Random_choices]", typeof(bool), 1, default(bool));
            
            /// <summary>最大值</summary>
            public static AttributeItem Range_max =  new AttributeItem("[Frame_FieldConfig].[Range_max]", typeof(int), 4, default(int));
            
            /// <summary>最小值</summary>
            public static AttributeItem Range_min =  new AttributeItem("[Frame_FieldConfig].[Range_min]", typeof(int), 4, default(int));
            
            /// <summary>是否另起一行:[CtrlTypeDic-{SelectSingle}]</summary>
            public static AttributeItem Start_new_row =  new AttributeItem("[Frame_FieldConfig].[Start_new_row]", typeof(bool), 1, default(bool));
            
            /// <summary>表名</summary>
            public static AttributeItem Table_name =  new AttributeItem("[Frame_FieldConfig].[Table_name]", typeof(string), 200, default(string));
            
            /// <summary>标题</summary>
            public static AttributeItem Title =  new AttributeItem("[Frame_FieldConfig].[Title]", typeof(string), 200, default(string));
            
            /// <summary>Uuid</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Frame_FieldConfig].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>是否校验:[CtrlTypeDic-{SelectSingle}]</summary>
            public static AttributeItem Validations =  new AttributeItem("[Frame_FieldConfig].[Validations]", typeof(string), 200, default(string));
            
            /// <summary>中文注释</summary>
            public static AttributeItem Zh =  new AttributeItem("[Frame_FieldConfig].[Zh]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_api_code;
        /// <summary></summary>
        protected bool api_code_initialized = false;
        
        private bool m_associated;
        /// <summary></summary>
        protected bool associated_initialized = false;
        
        private string m_ctrl;
        /// <summary></summary>
        protected bool ctrl_initialized = false;
        
        private string m_customized_validation_message;
        /// <summary></summary>
        protected bool customized_validation_message_initialized = false;
        
        private string m_field_inability_info;
        /// <summary></summary>
        protected bool field_inability_info_initialized = false;
        
        private string m_fname;
        /// <summary></summary>
        protected bool fname_initialized = false;
        
        private string m_grids_to_occupy;
        /// <summary></summary>
        protected bool grids_to_occupy_initialized = false;
        
        private bool m_is_cache;
        /// <summary></summary>
        protected bool is_cache_initialized = false;
        
        private bool m_isenable;
        /// <summary></summary>
        protected bool isenable_initialized = false;
        
        private bool m_islistvisable;
        /// <summary></summary>
        protected bool islistvisable_initialized = false;
        
        private bool m_isreadonly;
        /// <summary></summary>
        protected bool isreadonly_initialized = false;
        
        private bool m_isvisable;
        /// <summary></summary>
        protected bool isvisable_initialized = false;
        
        private int m_listposition;
        /// <summary></summary>
        protected bool listposition_initialized = false;
        
        private int m_maximum_length;
        /// <summary></summary>
        protected bool maximum_length_initialized = false;
        
        private int m_minimum_length;
        /// <summary></summary>
        protected bool minimum_length_initialized = false;
        
        private string m_notes;
        /// <summary></summary>
        protected bool notes_initialized = false;
        
        private int m_position;
        /// <summary></summary>
        protected bool position_initialized = false;
        
        private string m_predefined_value;
        /// <summary></summary>
        protected bool predefined_value_initialized = false;
        
        private bool m_private;
        /// <summary></summary>
        protected bool private_initialized = false;
        
        private bool m_quota_blank_warning;
        /// <summary></summary>
        protected bool quota_blank_warning_initialized = false;
        
        private bool m_random_choices;
        /// <summary></summary>
        protected bool random_choices_initialized = false;
        
        private int m_range_max;
        /// <summary></summary>
        protected bool range_max_initialized = false;
        
        private int m_range_min;
        /// <summary></summary>
        protected bool range_min_initialized = false;
        
        private bool m_start_new_row;
        /// <summary></summary>
        protected bool start_new_row_initialized = false;
        
        private string m_table_name;
        /// <summary></summary>
        protected bool table_name_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_validations;
        /// <summary></summary>
        protected bool validations_initialized = false;
        
        private string m_zh;
        /// <summary></summary>
        protected bool zh_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Frame_FieldConfig";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.api_code_initialized = IsLoadAllAttributes;this.associated_initialized = IsLoadAllAttributes;this.ctrl_initialized = IsLoadAllAttributes;this.customized_validation_message_initialized = IsLoadAllAttributes;this.field_inability_info_initialized = IsLoadAllAttributes;this.fname_initialized = IsLoadAllAttributes;this.grids_to_occupy_initialized = IsLoadAllAttributes;this.is_cache_initialized = IsLoadAllAttributes;this.isenable_initialized = IsLoadAllAttributes;this.islistvisable_initialized = IsLoadAllAttributes;this.isreadonly_initialized = IsLoadAllAttributes;this.isvisable_initialized = IsLoadAllAttributes;this.listposition_initialized = IsLoadAllAttributes;this.maximum_length_initialized = IsLoadAllAttributes;this.minimum_length_initialized = IsLoadAllAttributes;this.notes_initialized = IsLoadAllAttributes;this.position_initialized = IsLoadAllAttributes;this.predefined_value_initialized = IsLoadAllAttributes;this.private_initialized = IsLoadAllAttributes;this.quota_blank_warning_initialized = IsLoadAllAttributes;this.random_choices_initialized = IsLoadAllAttributes;this.range_max_initialized = IsLoadAllAttributes;this.range_min_initialized = IsLoadAllAttributes;this.start_new_row_initialized = IsLoadAllAttributes;this.table_name_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.validations_initialized = IsLoadAllAttributes;this.zh_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Frame_FieldConfig value = new Frame_FieldConfig();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Api_code"))
				value.api_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Associated"))
				value.associated_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Ctrl"))
				value.ctrl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Customized_validation_message"))
				value.customized_validation_message_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Field_inability_info"))
				value.field_inability_info_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Fname"))
				value.fname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grids_to_occupy"))
				value.grids_to_occupy_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_cache"))
				value.is_cache_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsEnable"))
				value.isenable_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsListVisable"))
				value.islistvisable_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsReadOnly"))
				value.isreadonly_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsVisable"))
				value.isvisable_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ListPosition"))
				value.listposition_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Maximum_length"))
				value.maximum_length_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Minimum_length"))
				value.minimum_length_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Notes"))
				value.notes_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Position"))
				value.position_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Predefined_value"))
				value.predefined_value_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Private"))
				value.private_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Quota_blank_warning"))
				value.quota_blank_warning_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Random_choices"))
				value.random_choices_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Range_max"))
				value.range_max_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Range_min"))
				value.range_min_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Start_new_row"))
				value.start_new_row_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Table_name"))
				value.table_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Validations"))
				value.validations_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Zh"))
				value.zh_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Frame_FieldConfig Clone()
        {
            return (Frame_FieldConfig)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Frame_FieldConfig()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Frame_FieldConfig() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Frame_FieldConfig(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Frame_FieldConfig(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Frame_FieldConfig(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Frame_FieldConfig(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Frame_FieldConfig(int id1, string api_code1, bool associated1, string ctrl1, string customized_validation_message1, string field_inability_info1, string fname1, string grids_to_occupy1, bool is_cache1, bool isenable1, bool islistvisable1, bool isreadonly1, bool isvisable1, int listposition1, int maximum_length1, int minimum_length1, string notes1, int position1, string predefined_value1, bool private1, bool quota_blank_warning1, bool random_choices1, int range_max1, int range_min1, bool start_new_row1, string table_name1, string title1, Guid uuid1, string validations1, string zh1)
        {
            
            this.Id = id1;
            
            this.Api_code = api_code1;
            
            this.Associated = associated1;
            
            this.Ctrl = ctrl1;
            
            this.Customized_validation_message = customized_validation_message1;
            
            this.Field_inability_info = field_inability_info1;
            
            this.Fname = fname1;
            
            this.Grids_to_occupy = grids_to_occupy1;
            
            this.Is_cache = is_cache1;
            
            this.IsEnable = isenable1;
            
            this.IsListVisable = islistvisable1;
            
            this.IsReadOnly = isreadonly1;
            
            this.IsVisable = isvisable1;
            
            this.ListPosition = listposition1;
            
            this.Maximum_length = maximum_length1;
            
            this.Minimum_length = minimum_length1;
            
            this.Notes = notes1;
            
            this.Position = position1;
            
            this.Predefined_value = predefined_value1;
            
            this.Private = private1;
            
            this.Quota_blank_warning = quota_blank_warning1;
            
            this.Random_choices = random_choices1;
            
            this.Range_max = range_max1;
            
            this.Range_min = range_min1;
            
            this.Start_new_row = start_new_row1;
            
            this.Table_name = table_name1;
            
            this.Title = title1;
            
            this.Uuid = uuid1;
            
            this.Validations = validations1;
            
            this.Zh = zh1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Frame_FieldConfig FromIView(IView view)
        {
            return (Frame_FieldConfig)IView.GetITable(view, "Frame_FieldConfig");
        }
        /// <summary>获得一个实例  </summary>
        public static Frame_FieldConfig GetOneInstance()
        {
            Frame_FieldConfig value = new Frame_FieldConfig();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Frame_FieldConfig Retrieve()
        {
            BLLTable<Frame_FieldConfig>.GetRowData(this);
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
			    			
			    case "Api_code":
			        return Api_code;
			    			
			    case "Associated":
			        return Associated;
			    			
			    case "Ctrl":
			        return Ctrl;
			    			
			    case "Customized_validation_message":
			        return Customized_validation_message;
			    			
			    case "Field_inability_info":
			        return Field_inability_info;
			    			
			    case "Fname":
			        return Fname;
			    			
			    case "Grids_to_occupy":
			        return Grids_to_occupy;
			    			
			    case "Is_cache":
			        return Is_cache;
			    			
			    case "IsEnable":
			        return IsEnable;
			    			
			    case "IsListVisable":
			        return IsListVisable;
			    			
			    case "IsReadOnly":
			        return IsReadOnly;
			    			
			    case "IsVisable":
			        return IsVisable;
			    			
			    case "ListPosition":
			        return ListPosition;
			    			
			    case "Maximum_length":
			        return Maximum_length;
			    			
			    case "Minimum_length":
			        return Minimum_length;
			    			
			    case "Notes":
			        return Notes;
			    			
			    case "Position":
			        return Position;
			    			
			    case "Predefined_value":
			        return Predefined_value;
			    			
			    case "Private":
			        return Private;
			    			
			    case "Quota_blank_warning":
			        return Quota_blank_warning;
			    			
			    case "Random_choices":
			        return Random_choices;
			    			
			    case "Range_max":
			        return Range_max;
			    			
			    case "Range_min":
			        return Range_min;
			    			
			    case "Start_new_row":
			        return Start_new_row;
			    			
			    case "Table_name":
			        return Table_name;
			    			
			    case "Title":
			        return Title;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "Validations":
			        return Validations;
			    			
			    case "Zh":
			        return Zh;
			
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
			    			
			    case "Api_code":
			        this.Api_code = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Associated":
			        this.Associated = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Ctrl":
			        this.Ctrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Customized_validation_message":
			        this.Customized_validation_message = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Field_inability_info":
			        this.Field_inability_info = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Fname":
			        this.Fname = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Grids_to_occupy":
			        this.Grids_to_occupy = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_cache":
			        this.Is_cache = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "IsEnable":
			        this.IsEnable = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "IsListVisable":
			        this.IsListVisable = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "IsReadOnly":
			        this.IsReadOnly = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "IsVisable":
			        this.IsVisable = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "ListPosition":
			        this.ListPosition = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Maximum_length":
			        this.Maximum_length = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Minimum_length":
			        this.Minimum_length = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Notes":
			        this.Notes = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Position":
			        this.Position = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Predefined_value":
			        this.Predefined_value = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Private":
			        this.Private = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Quota_blank_warning":
			        this.Quota_blank_warning = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Random_choices":
			        this.Random_choices = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Range_max":
			        this.Range_max = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Range_min":
			        this.Range_min = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Start_new_row":
			        this.Start_new_row = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Table_name":
			        this.Table_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Validations":
			        this.Validations = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Zh":
			        this.Zh = Convert.ToString(AttributeValue);
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
				
				case "Api_code":
					return api_code_initialized;
				
				case "Associated":
					return associated_initialized;
				
				case "Ctrl":
					return ctrl_initialized;
				
				case "Customized_validation_message":
					return customized_validation_message_initialized;
				
				case "Field_inability_info":
					return field_inability_info_initialized;
				
				case "Fname":
					return fname_initialized;
				
				case "Grids_to_occupy":
					return grids_to_occupy_initialized;
				
				case "Is_cache":
					return is_cache_initialized;
				
				case "IsEnable":
					return isenable_initialized;
				
				case "IsListVisable":
					return islistvisable_initialized;
				
				case "IsReadOnly":
					return isreadonly_initialized;
				
				case "IsVisable":
					return isvisable_initialized;
				
				case "ListPosition":
					return listposition_initialized;
				
				case "Maximum_length":
					return maximum_length_initialized;
				
				case "Minimum_length":
					return minimum_length_initialized;
				
				case "Notes":
					return notes_initialized;
				
				case "Position":
					return position_initialized;
				
				case "Predefined_value":
					return predefined_value_initialized;
				
				case "Private":
					return private_initialized;
				
				case "Quota_blank_warning":
					return quota_blank_warning_initialized;
				
				case "Random_choices":
					return random_choices_initialized;
				
				case "Range_max":
					return range_max_initialized;
				
				case "Range_min":
					return range_min_initialized;
				
				case "Start_new_row":
					return start_new_row_initialized;
				
				case "Table_name":
					return table_name_initialized;
				
				case "Title":
					return title_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "Validations":
					return validations_initialized;
				
				case "Zh":
					return zh_initialized;
				
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
				
				case "Api_code":
					api_code_initialized = ret;
					return true;
				
				case "Associated":
					associated_initialized = ret;
					return true;
				
				case "Ctrl":
					ctrl_initialized = ret;
					return true;
				
				case "Customized_validation_message":
					customized_validation_message_initialized = ret;
					return true;
				
				case "Field_inability_info":
					field_inability_info_initialized = ret;
					return true;
				
				case "Fname":
					fname_initialized = ret;
					return true;
				
				case "Grids_to_occupy":
					grids_to_occupy_initialized = ret;
					return true;
				
				case "Is_cache":
					is_cache_initialized = ret;
					return true;
				
				case "IsEnable":
					isenable_initialized = ret;
					return true;
				
				case "IsListVisable":
					islistvisable_initialized = ret;
					return true;
				
				case "IsReadOnly":
					isreadonly_initialized = ret;
					return true;
				
				case "IsVisable":
					isvisable_initialized = ret;
					return true;
				
				case "ListPosition":
					listposition_initialized = ret;
					return true;
				
				case "Maximum_length":
					maximum_length_initialized = ret;
					return true;
				
				case "Minimum_length":
					minimum_length_initialized = ret;
					return true;
				
				case "Notes":
					notes_initialized = ret;
					return true;
				
				case "Position":
					position_initialized = ret;
					return true;
				
				case "Predefined_value":
					predefined_value_initialized = ret;
					return true;
				
				case "Private":
					private_initialized = ret;
					return true;
				
				case "Quota_blank_warning":
					quota_blank_warning_initialized = ret;
					return true;
				
				case "Random_choices":
					random_choices_initialized = ret;
					return true;
				
				case "Range_max":
					range_max_initialized = ret;
					return true;
				
				case "Range_min":
					range_min_initialized = ret;
					return true;
				
				case "Start_new_row":
					start_new_row_initialized = ret;
					return true;
				
				case "Table_name":
					table_name_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Validations":
					validations_initialized = ret;
					return true;
				
				case "Zh":
					zh_initialized = ret;
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
                AttributeItem attr = Frame_FieldConfig.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (api_code_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Api_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Api_code);
                }
			}
			
			if (associated_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Associated;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Associated);
                }
			}
			
			if (ctrl_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Ctrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Ctrl);
                }
			}
			
			if (customized_validation_message_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Customized_validation_message;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Customized_validation_message);
                }
			}
			
			if (field_inability_info_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Field_inability_info;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Field_inability_info);
                }
			}
			
			if (fname_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Fname;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Fname);
                }
			}
			
			if (grids_to_occupy_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Grids_to_occupy;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grids_to_occupy);
                }
			}
			
			if (is_cache_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Is_cache;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_cache);
                }
			}
			
			if (isenable_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.IsEnable;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsEnable);
                }
			}
			
			if (islistvisable_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.IsListVisable;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsListVisable);
                }
			}
			
			if (isreadonly_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.IsReadOnly;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsReadOnly);
                }
			}
			
			if (isvisable_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.IsVisable;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsVisable);
                }
			}
			
			if (listposition_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.ListPosition;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ListPosition);
                }
			}
			
			if (maximum_length_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Maximum_length;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Maximum_length);
                }
			}
			
			if (minimum_length_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Minimum_length;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Minimum_length);
                }
			}
			
			if (notes_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Notes;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Notes);
                }
			}
			
			if (position_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Position;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Position);
                }
			}
			
			if (predefined_value_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Predefined_value;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Predefined_value);
                }
			}
			
			if (private_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Private;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Private);
                }
			}
			
			if (quota_blank_warning_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Quota_blank_warning;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Quota_blank_warning);
                }
			}
			
			if (random_choices_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Random_choices;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Random_choices);
                }
			}
			
			if (range_max_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Range_max;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Range_max);
                }
			}
			
			if (range_min_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Range_min;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Range_min);
                }
			}
			
			if (start_new_row_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Start_new_row;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Start_new_row);
                }
			}
			
			if (table_name_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Table_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Table_name);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (validations_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Validations;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Validations);
                }
			}
			
			if (zh_initialized)
			{
                AttributeItem attr = Frame_FieldConfig.Attribute.Zh;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Zh);
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
        public class Frame_FieldConfigJson
        {
            
            /// <summary>编号</summary>
            public int Id { get; set; }
            
            /// <summary>开放平台编码</summary>
            public string Api_code { get; set; }
            
            /// <summary>是否关联字段</summary>
            public bool Associated { get; set; }
            
            /// <summary>控件类型:[Enum-{InputString:单行文本},{SmallText:小文本200字},{Text:大文本内容},{HTML:HTML内容},{Geo:地理位置},{InputDate:日期},{InputDecimal:数字},{InputNumber:整数},{InputTime:时间},{InputDateTime:日期时间},{InputPassWord:密码},{InputEmail:Email},{InputIDCard:ID卡},{InputIPAddr:IP地址},{InputMobile:手机号码},{InputTel:电话},{InputPostCode:邮编},{SelectDrop:下拉框},{SelectSingle:单选框},{SelectMulti:多选框},{FileUpUpDoc:上传文档},{FileUpImage:上传图片},{OpenSelStaff:选择职员},{OpenSelDept:选择部门},{OpenSelExistsRec:选择存在的记录},{Select_RelationUser:选择关联用户},{Select_RelationFK:选择相关对象}][CtrlTypeDic-{SelectSingle}]</summary>
            public string Ctrl { get; set; }
            
            /// <summary>自定义校验错误信息</summary>
            public string Customized_validation_message { get; set; }
            
            /// <summary>禁用</summary>
            public string Field_inability_info { get; set; }
            
            /// <summary>字段名</summary>
            public string Fname { get; set; }
            
            /// <summary>矩阵填充</summary>
            public string Grids_to_occupy { get; set; }
            
            /// <summary>是否缓存</summary>
            public bool Is_cache { get; set; }
            
            /// <summary>是否可用</summary>
            public bool IsEnable { get; set; }
            
            /// <summary>是否列表页显示</summary>
            public bool IsListVisable { get; set; }
            
            /// <summary>是否只读</summary>
            public bool IsReadOnly { get; set; }
            
            /// <summary>是否详情页显示</summary>
            public bool IsVisable { get; set; }
            
            /// <summary>列表页位置</summary>
            public int ListPosition { get; set; }
            
            /// <summary>最大长度</summary>
            public int Maximum_length { get; set; }
            
            /// <summary>最小长度</summary>
            public int Minimum_length { get; set; }
            
            /// <summary>描述信息</summary>
            public string Notes { get; set; }
            
            /// <summary>编辑页顺序号</summary>
            public int Position { get; set; }
            
            /// <summary>默认值</summary>
            public string Predefined_value { get; set; }
            
            /// <summary>是否私有</summary>
            public bool Private { get; set; }
            
            /// <summary>未输入空白提醒:[CtrlTypeDic-{InputString}]</summary>
            public bool Quota_blank_warning { get; set; }
            
            /// <summary>选择项是否随机</summary>
            public bool Random_choices { get; set; }
            
            /// <summary>最大值</summary>
            public int Range_max { get; set; }
            
            /// <summary>最小值</summary>
            public int Range_min { get; set; }
            
            /// <summary>是否另起一行:[CtrlTypeDic-{SelectSingle}]</summary>
            public bool Start_new_row { get; set; }
            
            /// <summary>表名</summary>
            public string Table_name { get; set; }
            
            /// <summary>标题</summary>
            public string Title { get; set; }
            
            /// <summary>Uuid</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>是否校验:[CtrlTypeDic-{SelectSingle}]</summary>
            public string Validations { get; set; }
            
            /// <summary>中文注释</summary>
            public string Zh { get; set; }
        }
        #endregion
    }
}
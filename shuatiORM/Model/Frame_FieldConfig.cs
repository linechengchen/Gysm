/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/9/1 14:20:08
  Description:    ���ݱ�Frame_FieldConfig��Ӧ��ҵ���߼���Frame_FieldConfig
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Frame_FieldConfig_Entity:Frame_FieldConfig
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Api_code,Associated,Ctrl,Customized_validation_message,Field_inability_info,Fname,Grids_to_occupy,Is_cache,IsEnable,IsListVisable,IsReadOnly,IsVisable,ListPosition,Maximum_length,Minimum_length,Notes,Position,Predefined_value,Private,Quota_blank_warning,Random_choices,Range_max,Range_min,Start_new_row,Table_name,Title,Uuid,Validations,Zh from Frame_FieldConfig
delete from Frame_FieldConfig
INSERT INTO Frame_FieldConfig (Id,Api_code,Associated,Ctrl,Customized_validation_message,Field_inability_info,Fname,Grids_to_occupy,Is_cache,IsEnable,IsListVisable,IsReadOnly,IsVisable,ListPosition,Maximum_length,Minimum_length,Notes,Position,Predefined_value,Private,Quota_blank_warning,Random_choices,Range_max,Range_min,Start_new_row,Table_name,Title,Uuid,Validations,Zh)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Frame_FieldConfig SET ...
������ֵ���룺
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
    /// <para>�����ֶ����ù���</para>
    /// <para>��Frame_FieldConfig���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Frame_FieldConfig : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Frame_FieldConfig Factory()
        {
            return new Frame_FieldConfig();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ��� Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ����ƽ̨���� Attribute_IsNotNull </summary>
        public string _Api_code
        {            
            get { return this.Api_code; }
            set { this.Api_code = value; }
        }
        
        /// <summary> �Ƿ�����ֶ� Attribute_IsNotNull </summary>
        public bool _Associated
        {            
            get { return this.Associated; }
            set { this.Associated = value; }
        }
        
        /// <summary> �ؼ�����:[Enum-{InputString:�����ı�},{SmallText:С�ı�200��},{Text:���ı�����},{HTML:HTML����},{Geo:����λ��},{InputDate:����},{InputDecimal:����},{InputNumber:����},{InputTime:ʱ��},{InputDateTime:����ʱ��},{InputPassWord:����},{InputEmail:Email},{InputIDCard:ID��},{InputIPAddr:IP��ַ},{InputMobile:�ֻ�����},{InputTel:�绰},{InputPostCode:�ʱ�},{SelectDrop:������},{SelectSingle:��ѡ��},{SelectMulti:��ѡ��},{FileUpUpDoc:�ϴ��ĵ�},{FileUpImage:�ϴ�ͼƬ},{OpenSelStaff:ѡ��ְԱ},{OpenSelDept:ѡ����},{OpenSelExistsRec:ѡ����ڵļ�¼},{Select_RelationUser:ѡ������û�},{Select_RelationFK:ѡ����ض���}][CtrlTypeDic-{SelectSingle}] Attribute_IsNotNull </summary>
        public string _Ctrl
        {            
            get { return this.Ctrl; }
            set { this.Ctrl = value; }
        }
        
        /// <summary> �Զ���У�������Ϣ Attribute_IsNotNull </summary>
        public string _Customized_validation_message
        {            
            get { return this.Customized_validation_message; }
            set { this.Customized_validation_message = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public string _Field_inability_info
        {            
            get { return this.Field_inability_info; }
            set { this.Field_inability_info = value; }
        }
        
        /// <summary> �ֶ��� Attribute_IsNotNull </summary>
        public string _Fname
        {            
            get { return this.Fname; }
            set { this.Fname = value; }
        }
        
        /// <summary> ������� Attribute_IsNotNull </summary>
        public string _Grids_to_occupy
        {            
            get { return this.Grids_to_occupy; }
            set { this.Grids_to_occupy = value; }
        }
        
        /// <summary> �Ƿ񻺴� Attribute_IsNotNull </summary>
        public bool _Is_cache
        {            
            get { return this.Is_cache; }
            set { this.Is_cache = value; }
        }
        
        /// <summary> �Ƿ���� Attribute_IsNotNull </summary>
        public bool _IsEnable
        {            
            get { return this.IsEnable; }
            set { this.IsEnable = value; }
        }
        
        /// <summary> �Ƿ��б�ҳ��ʾ Attribute_IsNotNull </summary>
        public bool _IsListVisable
        {            
            get { return this.IsListVisable; }
            set { this.IsListVisable = value; }
        }
        
        /// <summary> �Ƿ�ֻ�� Attribute_IsNotNull </summary>
        public bool _IsReadOnly
        {            
            get { return this.IsReadOnly; }
            set { this.IsReadOnly = value; }
        }
        
        /// <summary> �Ƿ�����ҳ��ʾ Attribute_IsNotNull </summary>
        public bool _IsVisable
        {            
            get { return this.IsVisable; }
            set { this.IsVisable = value; }
        }
        
        /// <summary> �б�ҳλ�� Attribute_IsNotNull </summary>
        public int _ListPosition
        {            
            get { return this.ListPosition; }
            set { this.ListPosition = value; }
        }
        
        /// <summary> ��󳤶� Attribute_IsNotNull </summary>
        public int _Maximum_length
        {            
            get { return this.Maximum_length; }
            set { this.Maximum_length = value; }
        }
        
        /// <summary> ��С���� Attribute_IsNotNull </summary>
        public int _Minimum_length
        {            
            get { return this.Minimum_length; }
            set { this.Minimum_length = value; }
        }
        
        /// <summary> ������Ϣ Attribute_IsNotNull </summary>
        public string _Notes
        {            
            get { return this.Notes; }
            set { this.Notes = value; }
        }
        
        /// <summary> �༭ҳ˳��� Attribute_IsNotNull </summary>
        public int _Position
        {            
            get { return this.Position; }
            set { this.Position = value; }
        }
        
        /// <summary> Ĭ��ֵ Attribute_IsNotNull </summary>
        public string _Predefined_value
        {            
            get { return this.Predefined_value; }
            set { this.Predefined_value = value; }
        }
        
        /// <summary> �Ƿ�˽�� Attribute_IsNotNull </summary>
        public bool _Private
        {            
            get { return this.Private; }
            set { this.Private = value; }
        }
        
        /// <summary> δ����հ�����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public bool _Quota_blank_warning
        {            
            get { return this.Quota_blank_warning; }
            set { this.Quota_blank_warning = value; }
        }
        
        /// <summary> ѡ�����Ƿ���� Attribute_IsNotNull </summary>
        public bool _Random_choices
        {            
            get { return this.Random_choices; }
            set { this.Random_choices = value; }
        }
        
        /// <summary> ���ֵ Attribute_IsNotNull </summary>
        public int _Range_max
        {            
            get { return this.Range_max; }
            set { this.Range_max = value; }
        }
        
        /// <summary> ��Сֵ Attribute_IsNotNull </summary>
        public int _Range_min
        {            
            get { return this.Range_min; }
            set { this.Range_min = value; }
        }
        
        /// <summary> �Ƿ�����һ��:[CtrlTypeDic-{SelectSingle}] Attribute_IsNotNull </summary>
        public bool _Start_new_row
        {            
            get { return this.Start_new_row; }
            set { this.Start_new_row = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public string _Table_name
        {            
            get { return this.Table_name; }
            set { this.Table_name = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
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
        
        /// <summary> �Ƿ�У��:[CtrlTypeDic-{SelectSingle}] Attribute_IsNotNull </summary>
        public string _Validations
        {            
            get { return this.Validations; }
            set { this.Validations = value; }
        }
        
        /// <summary> ����ע�� Attribute_IsNotNull </summary>
        public string _Zh
        {            
            get { return this.Zh; }
            set { this.Zh = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ��ţ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����ƽ̨���룬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ�����ֶΣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �ؼ�����:[Enum-{InputString:�����ı�},{SmallText:С�ı�200��},{Text:���ı�����},{HTML:HTML����},{Geo:����λ��},{InputDate:����},{InputDecimal:����},{InputNumber:����},{InputTime:ʱ��},{InputDateTime:����ʱ��},{InputPassWord:����},{InputEmail:Email},{InputIDCard:ID��},{InputIPAddr:IP��ַ},{InputMobile:�ֻ�����},{InputTel:�绰},{InputPostCode:�ʱ�},{SelectDrop:������},{SelectSingle:��ѡ��},{SelectMulti:��ѡ��},{FileUpUpDoc:�ϴ��ĵ�},{FileUpImage:�ϴ�ͼƬ},{OpenSelStaff:ѡ��ְԱ},{OpenSelDept:ѡ����},{OpenSelExistsRec:ѡ����ڵļ�¼},{Select_RelationUser:ѡ������û�},{Select_RelationFK:ѡ����ض���}][CtrlTypeDic-{SelectSingle}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Զ���У�������Ϣ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���ã��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �ֶ������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ������䣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ񻺴棬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ���ã��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ��б�ҳ��ʾ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ�ֻ�����Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ�����ҳ��ʾ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �б�ҳλ�ã��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��󳤶ȣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��С���ȣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ������Ϣ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �༭ҳ˳��ţ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> Ĭ��ֵ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ�˽�У��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> δ����հ�����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ѡ�����Ƿ�������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���ֵ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��Сֵ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ�����һ��:[CtrlTypeDic-{SelectSingle}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���⣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> Uuid���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ�У��:[CtrlTypeDic-{SelectSingle}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����ע�ͣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>���</summary>
            public static AttributeItem Id =  new AttributeItem("[Frame_FieldConfig].[Id]", typeof(int), 4, default(int));
            
            /// <summary>����ƽ̨����</summary>
            public static AttributeItem Api_code =  new AttributeItem("[Frame_FieldConfig].[Api_code]", typeof(string), 200, default(string));
            
            /// <summary>�Ƿ�����ֶ�</summary>
            public static AttributeItem Associated =  new AttributeItem("[Frame_FieldConfig].[Associated]", typeof(bool), 1, default(bool));
            
            /// <summary>�ؼ�����:[Enum-{InputString:�����ı�},{SmallText:С�ı�200��},{Text:���ı�����},{HTML:HTML����},{Geo:����λ��},{InputDate:����},{InputDecimal:����},{InputNumber:����},{InputTime:ʱ��},{InputDateTime:����ʱ��},{InputPassWord:����},{InputEmail:Email},{InputIDCard:ID��},{InputIPAddr:IP��ַ},{InputMobile:�ֻ�����},{InputTel:�绰},{InputPostCode:�ʱ�},{SelectDrop:������},{SelectSingle:��ѡ��},{SelectMulti:��ѡ��},{FileUpUpDoc:�ϴ��ĵ�},{FileUpImage:�ϴ�ͼƬ},{OpenSelStaff:ѡ��ְԱ},{OpenSelDept:ѡ����},{OpenSelExistsRec:ѡ����ڵļ�¼},{Select_RelationUser:ѡ������û�},{Select_RelationFK:ѡ����ض���}][CtrlTypeDic-{SelectSingle}]</summary>
            public static AttributeItem Ctrl =  new AttributeItem("[Frame_FieldConfig].[Ctrl]", typeof(string), 50, default(string));
            
            /// <summary>�Զ���У�������Ϣ</summary>
            public static AttributeItem Customized_validation_message =  new AttributeItem("[Frame_FieldConfig].[Customized_validation_message]", typeof(string), 200, default(string));
            
            /// <summary>����</summary>
            public static AttributeItem Field_inability_info =  new AttributeItem("[Frame_FieldConfig].[Field_inability_info]", typeof(string), 200, default(string));
            
            /// <summary>�ֶ���</summary>
            public static AttributeItem Fname =  new AttributeItem("[Frame_FieldConfig].[Fname]", typeof(string), 200, default(string));
            
            /// <summary>�������</summary>
            public static AttributeItem Grids_to_occupy =  new AttributeItem("[Frame_FieldConfig].[Grids_to_occupy]", typeof(string), 200, default(string));
            
            /// <summary>�Ƿ񻺴�</summary>
            public static AttributeItem Is_cache =  new AttributeItem("[Frame_FieldConfig].[Is_cache]", typeof(bool), 1, default(bool));
            
            /// <summary>�Ƿ����</summary>
            public static AttributeItem IsEnable =  new AttributeItem("[Frame_FieldConfig].[IsEnable]", typeof(bool), 1, default(bool));
            
            /// <summary>�Ƿ��б�ҳ��ʾ</summary>
            public static AttributeItem IsListVisable =  new AttributeItem("[Frame_FieldConfig].[IsListVisable]", typeof(bool), 1, default(bool));
            
            /// <summary>�Ƿ�ֻ��</summary>
            public static AttributeItem IsReadOnly =  new AttributeItem("[Frame_FieldConfig].[IsReadOnly]", typeof(bool), 1, default(bool));
            
            /// <summary>�Ƿ�����ҳ��ʾ</summary>
            public static AttributeItem IsVisable =  new AttributeItem("[Frame_FieldConfig].[IsVisable]", typeof(bool), 1, default(bool));
            
            /// <summary>�б�ҳλ��</summary>
            public static AttributeItem ListPosition =  new AttributeItem("[Frame_FieldConfig].[ListPosition]", typeof(int), 4, default(int));
            
            /// <summary>��󳤶�</summary>
            public static AttributeItem Maximum_length =  new AttributeItem("[Frame_FieldConfig].[Maximum_length]", typeof(int), 4, default(int));
            
            /// <summary>��С����</summary>
            public static AttributeItem Minimum_length =  new AttributeItem("[Frame_FieldConfig].[Minimum_length]", typeof(int), 4, default(int));
            
            /// <summary>������Ϣ</summary>
            public static AttributeItem Notes =  new AttributeItem("[Frame_FieldConfig].[Notes]", typeof(string), 200, default(string));
            
            /// <summary>�༭ҳ˳���</summary>
            public static AttributeItem Position =  new AttributeItem("[Frame_FieldConfig].[Position]", typeof(int), 4, default(int));
            
            /// <summary>Ĭ��ֵ</summary>
            public static AttributeItem Predefined_value =  new AttributeItem("[Frame_FieldConfig].[Predefined_value]", typeof(string), 200, default(string));
            
            /// <summary>�Ƿ�˽��</summary>
            public static AttributeItem Private =  new AttributeItem("[Frame_FieldConfig].[Private]", typeof(bool), 1, default(bool));
            
            /// <summary>δ����հ�����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Quota_blank_warning =  new AttributeItem("[Frame_FieldConfig].[Quota_blank_warning]", typeof(bool), 1, default(bool));
            
            /// <summary>ѡ�����Ƿ����</summary>
            public static AttributeItem Random_choices =  new AttributeItem("[Frame_FieldConfig].[Random_choices]", typeof(bool), 1, default(bool));
            
            /// <summary>���ֵ</summary>
            public static AttributeItem Range_max =  new AttributeItem("[Frame_FieldConfig].[Range_max]", typeof(int), 4, default(int));
            
            /// <summary>��Сֵ</summary>
            public static AttributeItem Range_min =  new AttributeItem("[Frame_FieldConfig].[Range_min]", typeof(int), 4, default(int));
            
            /// <summary>�Ƿ�����һ��:[CtrlTypeDic-{SelectSingle}]</summary>
            public static AttributeItem Start_new_row =  new AttributeItem("[Frame_FieldConfig].[Start_new_row]", typeof(bool), 1, default(bool));
            
            /// <summary>����</summary>
            public static AttributeItem Table_name =  new AttributeItem("[Frame_FieldConfig].[Table_name]", typeof(string), 200, default(string));
            
            /// <summary>����</summary>
            public static AttributeItem Title =  new AttributeItem("[Frame_FieldConfig].[Title]", typeof(string), 200, default(string));
            
            /// <summary>Uuid</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Frame_FieldConfig].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>�Ƿ�У��:[CtrlTypeDic-{SelectSingle}]</summary>
            public static AttributeItem Validations =  new AttributeItem("[Frame_FieldConfig].[Validations]", typeof(string), 200, default(string));
            
            /// <summary>����ע��</summary>
            public static AttributeItem Zh =  new AttributeItem("[Frame_FieldConfig].[Zh]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
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

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Frame_FieldConfig";
        }
        
        /// <summary>
        /// �����Զ�����������
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
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Frame_FieldConfig Clone()
        {
            return (Frame_FieldConfig)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Frame_FieldConfig()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Frame_FieldConfig() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Frame_FieldConfig(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Frame_FieldConfig(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Frame_FieldConfig(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Frame_FieldConfig(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
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
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Frame_FieldConfig FromIView(IView view)
        {
            return (Frame_FieldConfig)IView.GetITable(view, "Frame_FieldConfig");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Frame_FieldConfig GetOneInstance()
        {
            Frame_FieldConfig value = new Frame_FieldConfig();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Frame_FieldConfig Retrieve()
        {
            BLLTable<Frame_FieldConfig>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
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
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
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
        
        /// <summary>ͨ������ ��ȡ���ֶ��Ƿ��ѱ���ʼ��</summary>
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

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
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

        #region ��ȡDataParameter PropertyInfo

        /// <summary>
        /// ��ȡ���б���ʼ������ֵ����ȡAttributeItem
        /// Ŀ��Ϊ��ȡ System.Windows.Forms.DataGridViewTextBoxColumn[] ���м����ݲ������ �Զ���� MyDataGridViewTextBoxColumn (����̳��� DataGridViewTextBoxColumn)
        /// ������������α����ķ�������Ϊ�˱����װ���̣�ʹ��Դ����ģʽ��ʱ�򣬲���������windows.form.dll��
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

        #region Json����
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        [Serializable]
        public class Frame_FieldConfigJson
        {
            
            /// <summary>���</summary>
            public int Id { get; set; }
            
            /// <summary>����ƽ̨����</summary>
            public string Api_code { get; set; }
            
            /// <summary>�Ƿ�����ֶ�</summary>
            public bool Associated { get; set; }
            
            /// <summary>�ؼ�����:[Enum-{InputString:�����ı�},{SmallText:С�ı�200��},{Text:���ı�����},{HTML:HTML����},{Geo:����λ��},{InputDate:����},{InputDecimal:����},{InputNumber:����},{InputTime:ʱ��},{InputDateTime:����ʱ��},{InputPassWord:����},{InputEmail:Email},{InputIDCard:ID��},{InputIPAddr:IP��ַ},{InputMobile:�ֻ�����},{InputTel:�绰},{InputPostCode:�ʱ�},{SelectDrop:������},{SelectSingle:��ѡ��},{SelectMulti:��ѡ��},{FileUpUpDoc:�ϴ��ĵ�},{FileUpImage:�ϴ�ͼƬ},{OpenSelStaff:ѡ��ְԱ},{OpenSelDept:ѡ����},{OpenSelExistsRec:ѡ����ڵļ�¼},{Select_RelationUser:ѡ������û�},{Select_RelationFK:ѡ����ض���}][CtrlTypeDic-{SelectSingle}]</summary>
            public string Ctrl { get; set; }
            
            /// <summary>�Զ���У�������Ϣ</summary>
            public string Customized_validation_message { get; set; }
            
            /// <summary>����</summary>
            public string Field_inability_info { get; set; }
            
            /// <summary>�ֶ���</summary>
            public string Fname { get; set; }
            
            /// <summary>�������</summary>
            public string Grids_to_occupy { get; set; }
            
            /// <summary>�Ƿ񻺴�</summary>
            public bool Is_cache { get; set; }
            
            /// <summary>�Ƿ����</summary>
            public bool IsEnable { get; set; }
            
            /// <summary>�Ƿ��б�ҳ��ʾ</summary>
            public bool IsListVisable { get; set; }
            
            /// <summary>�Ƿ�ֻ��</summary>
            public bool IsReadOnly { get; set; }
            
            /// <summary>�Ƿ�����ҳ��ʾ</summary>
            public bool IsVisable { get; set; }
            
            /// <summary>�б�ҳλ��</summary>
            public int ListPosition { get; set; }
            
            /// <summary>��󳤶�</summary>
            public int Maximum_length { get; set; }
            
            /// <summary>��С����</summary>
            public int Minimum_length { get; set; }
            
            /// <summary>������Ϣ</summary>
            public string Notes { get; set; }
            
            /// <summary>�༭ҳ˳���</summary>
            public int Position { get; set; }
            
            /// <summary>Ĭ��ֵ</summary>
            public string Predefined_value { get; set; }
            
            /// <summary>�Ƿ�˽��</summary>
            public bool Private { get; set; }
            
            /// <summary>δ����հ�����:[CtrlTypeDic-{InputString}]</summary>
            public bool Quota_blank_warning { get; set; }
            
            /// <summary>ѡ�����Ƿ����</summary>
            public bool Random_choices { get; set; }
            
            /// <summary>���ֵ</summary>
            public int Range_max { get; set; }
            
            /// <summary>��Сֵ</summary>
            public int Range_min { get; set; }
            
            /// <summary>�Ƿ�����һ��:[CtrlTypeDic-{SelectSingle}]</summary>
            public bool Start_new_row { get; set; }
            
            /// <summary>����</summary>
            public string Table_name { get; set; }
            
            /// <summary>����</summary>
            public string Title { get; set; }
            
            /// <summary>Uuid</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>�Ƿ�У��:[CtrlTypeDic-{SelectSingle}]</summary>
            public string Validations { get; set; }
            
            /// <summary>����ע��</summary>
            public string Zh { get; set; }
        }
        #endregion
    }
}
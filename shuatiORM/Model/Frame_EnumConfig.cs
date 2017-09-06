/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/8/31 17:14:35
  Description:    ���ݱ�Frame_EnumConfig��Ӧ��ҵ���߼���Frame_EnumConfig
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Frame_EnumConfig_Entity:Frame_EnumConfig
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,_type,Api_code,Chinese,Fname,Hidden,Key,Position,Quota,Quota_setting,Quota_setting_temp,Quota_temp,Selected,Table_name,Uuid from Frame_EnumConfig
delete from Frame_EnumConfig
INSERT INTO Frame_EnumConfig (Id,_type,Api_code,Chinese,Fname,Hidden,Key,Position,Quota,Quota_setting,Quota_setting_temp,Quota_temp,Selected,Table_name,Uuid)
     VALUES
           ('','','','','','','','','','','','','','','')
UPDATE Frame_EnumConfig SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj._type = valObj2._type;
        valObj.Api_code = valObj2.Api_code;
        valObj.Chinese = valObj2.Chinese;
        valObj.Fname = valObj2.Fname;
        valObj.Hidden = valObj2.Hidden;
        valObj.Key = valObj2.Key;
        valObj.Position = valObj2.Position;
        valObj.Quota = valObj2.Quota;
        valObj.Quota_setting = valObj2.Quota_setting;
        valObj.Quota_setting_temp = valObj2.Quota_setting_temp;
        valObj.Quota_temp = valObj2.Quota_temp;
        valObj.Selected = valObj2.Selected;
        valObj.Table_name = valObj2.Table_name;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj._type = "";
        valObj.Api_code = "";
        valObj.Chinese = "";
        valObj.Fname = "";
        valObj.Hidden = "";
        valObj.Key = "";
        valObj.Position = "";
        valObj.Quota = "";
        valObj.Quota_setting = "";
        valObj.Quota_setting_temp = "";
        valObj.Quota_temp = "";
        valObj.Selected = "";
        valObj.Table_name = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "_type": $("#txt__type").val(),
        "Api_code": $("#txt_Api_code").val(),
        "Chinese": $("#txt_Chinese").val(),
        "Fname": $("#txt_Fname").val(),
        "Hidden": $("#txt_Hidden").val(),
        "Key": $("#txt_Key").val(),
        "Position": $("#txt_Position").val(),
        "Quota": $("#txt_Quota").val(),
        "Quota_setting": $("#txt_Quota_setting").val(),
        "Quota_setting_temp": $("#txt_Quota_setting_temp").val(),
        "Quota_temp": $("#txt_Quota_temp").val(),
        "Selected": $("#txt_Selected").val(),
        "Table_name": $("#txt_Table_name").val(),
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
    /// <para>��ѡ�����ù���</para>
    /// <para>��Frame_EnumConfig���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Frame_EnumConfig : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Frame_EnumConfig Factory()
        {
            return new Frame_EnumConfig();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary>  Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �ؼ�����:[CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string __type
        {            
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary> ����API���� Attribute_IsNotNull </summary>
        public string _Api_code
        {            
            get { return this.Api_code; }
            set { this.Api_code = value; }
        }
        
        /// <summary> ������ Attribute_IsNotNull </summary>
        public string _Chinese
        {            
            get { return this.Chinese; }
            set { this.Chinese = value; }
        }
        
        /// <summary> �ֶ��� Attribute_IsNotNull </summary>
        public string _Fname
        {            
            get { return this.Fname; }
            set { this.Fname = value; }
        }
        
        /// <summary> �Ƿ����� Attribute_IsNotNull </summary>
        public bool _Hidden
        {            
            get { return this.Hidden; }
            set { this.Hidden = value; }
        }
        
        /// <summary> ��ֵ Attribute_IsNotNull </summary>
        public string _Key
        {            
            get { return this.Key; }
            set { this.Key = value; }
        }
        
        /// <summary> λ�� Attribute_IsNotNull </summary>
        public int _Position
        {            
            get { return this.Position; }
            set { this.Position = value; }
        }
        
        /// <summary> �޶� Attribute_IsNotNull </summary>
        public string _Quota
        {            
            get { return this.Quota; }
            set { this.Quota = value; }
        }
        
        /// <summary> �޶����� Attribute_IsNotNull </summary>
        public string _Quota_setting
        {            
            get { return this.Quota_setting; }
            set { this.Quota_setting = value; }
        }
        
        /// <summary> ��ʱ�޶����� Attribute_IsNotNull </summary>
        public string _Quota_setting_temp
        {            
            get { return this.Quota_setting_temp; }
            set { this.Quota_setting_temp = value; }
        }
        
        /// <summary> ��ʱ�޶� Attribute_IsNotNull </summary>
        public string _Quota_temp
        {            
            get { return this.Quota_temp; }
            set { this.Quota_temp = value; }
        }
        
        /// <summary> �Ƿ�ѡ��:[CtrlTypeDic-{SelectSingle}] Attribute_IsNotNull </summary>
        public bool _Selected
        {            
            get { return this.Selected; }
            set { this.Selected = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public string _Table_name
        {            
            get { return this.Table_name; }
            set { this.Table_name = value; }
        }
        
        /// <summary>  Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �ؼ�����:[CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string _type
        {
            get { return this.m__type; }
            set //
            {
                if (!_type_initialized || m__type != value)
                {
                    this.m__type = value;
                }
                _type_initialized = true;
            }
        }
        
        /// <summary> ����API���룬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Chinese
        {
            get { return this.m_chinese; }
            set //
            {
                if (!chinese_initialized || m_chinese != value)
                {
                    this.m_chinese = value;
                }
                chinese_initialized = true;
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
        
        /// <summary> �Ƿ����أ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool Hidden
        {
            get { return this.m_hidden; }
            set //
            {
                if (!hidden_initialized || m_hidden != value)
                {
                    this.m_hidden = value;
                }
                hidden_initialized = true;
            }
        }
        
        /// <summary> ��ֵ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Key
        {
            get { return this.m_key; }
            set //
            {
                if (!key_initialized || m_key != value)
                {
                    this.m_key = value;
                }
                key_initialized = true;
            }
        }
        
        /// <summary> λ�ã��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �޶�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Quota
        {
            get { return this.m_quota; }
            set //
            {
                if (!quota_initialized || m_quota != value)
                {
                    this.m_quota = value;
                }
                quota_initialized = true;
            }
        }
        
        /// <summary> �޶����ã��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Quota_setting
        {
            get { return this.m_quota_setting; }
            set //
            {
                if (!quota_setting_initialized || m_quota_setting != value)
                {
                    this.m_quota_setting = value;
                }
                quota_setting_initialized = true;
            }
        }
        
        /// <summary> ��ʱ�޶����ã��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Quota_setting_temp
        {
            get { return this.m_quota_setting_temp; }
            set //
            {
                if (!quota_setting_temp_initialized || m_quota_setting_temp != value)
                {
                    this.m_quota_setting_temp = value;
                }
                quota_setting_temp_initialized = true;
            }
        }
        
        /// <summary> ��ʱ�޶�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Quota_temp
        {
            get { return this.m_quota_temp; }
            set //
            {
                if (!quota_temp_initialized || m_quota_temp != value)
                {
                    this.m_quota_temp = value;
                }
                quota_temp_initialized = true;
            }
        }
        
        /// <summary> �Ƿ�ѡ��:[CtrlTypeDic-{SelectSingle}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool Selected
        {
            get { return this.m_selected; }
            set //
            {
                if (!selected_initialized || m_selected != value)
                {
                    this.m_selected = value;
                }
                selected_initialized = true;
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[Frame_EnumConfig].[Id]", typeof(int), 4, default(int));
            
            /// <summary>�ؼ�����:[CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem _type =  new AttributeItem("[Frame_EnumConfig].[_type]", typeof(string), 50, default(string));
            
            /// <summary>����API����</summary>
            public static AttributeItem Api_code =  new AttributeItem("[Frame_EnumConfig].[Api_code]", typeof(string), 50, default(string));
            
            /// <summary>������</summary>
            public static AttributeItem Chinese =  new AttributeItem("[Frame_EnumConfig].[Chinese]", typeof(string), 200, default(string));
            
            /// <summary>�ֶ���</summary>
            public static AttributeItem Fname =  new AttributeItem("[Frame_EnumConfig].[Fname]", typeof(string), 200, default(string));
            
            /// <summary>�Ƿ�����</summary>
            public static AttributeItem Hidden =  new AttributeItem("[Frame_EnumConfig].[Hidden]", typeof(bool), 1, default(bool));
            
            /// <summary>��ֵ</summary>
            public static AttributeItem Key =  new AttributeItem("[Frame_EnumConfig].[Key]", typeof(string), 50, default(string));
            
            /// <summary>λ��</summary>
            public static AttributeItem Position =  new AttributeItem("[Frame_EnumConfig].[Position]", typeof(int), 4, default(int));
            
            /// <summary>�޶�</summary>
            public static AttributeItem Quota =  new AttributeItem("[Frame_EnumConfig].[Quota]", typeof(string), 200, default(string));
            
            /// <summary>�޶�����</summary>
            public static AttributeItem Quota_setting =  new AttributeItem("[Frame_EnumConfig].[Quota_setting]", typeof(string), 200, default(string));
            
            /// <summary>��ʱ�޶�����</summary>
            public static AttributeItem Quota_setting_temp =  new AttributeItem("[Frame_EnumConfig].[Quota_setting_temp]", typeof(string), 200, default(string));
            
            /// <summary>��ʱ�޶�</summary>
            public static AttributeItem Quota_temp =  new AttributeItem("[Frame_EnumConfig].[Quota_temp]", typeof(string), 200, default(string));
            
            /// <summary>�Ƿ�ѡ��:[CtrlTypeDic-{SelectSingle}]</summary>
            public static AttributeItem Selected =  new AttributeItem("[Frame_EnumConfig].[Selected]", typeof(bool), 1, default(bool));
            
            /// <summary>����</summary>
            public static AttributeItem Table_name =  new AttributeItem("[Frame_EnumConfig].[Table_name]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[Frame_EnumConfig].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m__type;
        /// <summary></summary>
        protected bool _type_initialized = false;
        
        private string m_api_code;
        /// <summary></summary>
        protected bool api_code_initialized = false;
        
        private string m_chinese;
        /// <summary></summary>
        protected bool chinese_initialized = false;
        
        private string m_fname;
        /// <summary></summary>
        protected bool fname_initialized = false;
        
        private bool m_hidden;
        /// <summary></summary>
        protected bool hidden_initialized = false;
        
        private string m_key;
        /// <summary></summary>
        protected bool key_initialized = false;
        
        private int m_position;
        /// <summary></summary>
        protected bool position_initialized = false;
        
        private string m_quota;
        /// <summary></summary>
        protected bool quota_initialized = false;
        
        private string m_quota_setting;
        /// <summary></summary>
        protected bool quota_setting_initialized = false;
        
        private string m_quota_setting_temp;
        /// <summary></summary>
        protected bool quota_setting_temp_initialized = false;
        
        private string m_quota_temp;
        /// <summary></summary>
        protected bool quota_temp_initialized = false;
        
        private bool m_selected;
        /// <summary></summary>
        protected bool selected_initialized = false;
        
        private string m_table_name;
        /// <summary></summary>
        protected bool table_name_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Frame_EnumConfig";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this._type_initialized = IsLoadAllAttributes;this.api_code_initialized = IsLoadAllAttributes;this.chinese_initialized = IsLoadAllAttributes;this.fname_initialized = IsLoadAllAttributes;this.hidden_initialized = IsLoadAllAttributes;this.key_initialized = IsLoadAllAttributes;this.position_initialized = IsLoadAllAttributes;this.quota_initialized = IsLoadAllAttributes;this.quota_setting_initialized = IsLoadAllAttributes;this.quota_setting_temp_initialized = IsLoadAllAttributes;this.quota_temp_initialized = IsLoadAllAttributes;this.selected_initialized = IsLoadAllAttributes;this.table_name_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Frame_EnumConfig value = new Frame_EnumConfig();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"_type"))
				value._type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Api_code"))
				value.api_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Chinese"))
				value.chinese_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Fname"))
				value.fname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Hidden"))
				value.hidden_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Key"))
				value.key_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Position"))
				value.position_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Quota"))
				value.quota_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Quota_setting"))
				value.quota_setting_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Quota_setting_temp"))
				value.quota_setting_temp_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Quota_temp"))
				value.quota_temp_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Selected"))
				value.selected_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Table_name"))
				value.table_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Frame_EnumConfig Clone()
        {
            return (Frame_EnumConfig)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Frame_EnumConfig()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Frame_EnumConfig() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Frame_EnumConfig(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Frame_EnumConfig(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Frame_EnumConfig(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Frame_EnumConfig(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Frame_EnumConfig(int id1, string _type1, string api_code1, string chinese1, string fname1, bool hidden1, string key1, int position1, string quota1, string quota_setting1, string quota_setting_temp1, string quota_temp1, bool selected1, string table_name1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this._type = _type1;
            
            this.Api_code = api_code1;
            
            this.Chinese = chinese1;
            
            this.Fname = fname1;
            
            this.Hidden = hidden1;
            
            this.Key = key1;
            
            this.Position = position1;
            
            this.Quota = quota1;
            
            this.Quota_setting = quota_setting1;
            
            this.Quota_setting_temp = quota_setting_temp1;
            
            this.Quota_temp = quota_temp1;
            
            this.Selected = selected1;
            
            this.Table_name = table_name1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Frame_EnumConfig FromIView(IView view)
        {
            return (Frame_EnumConfig)IView.GetITable(view, "Frame_EnumConfig");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Frame_EnumConfig GetOneInstance()
        {
            Frame_EnumConfig value = new Frame_EnumConfig();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Frame_EnumConfig Retrieve()
        {
            BLLTable<Frame_EnumConfig>.GetRowData(this);
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
			    			
			    case "_type":
			        return _type;
			    			
			    case "Api_code":
			        return Api_code;
			    			
			    case "Chinese":
			        return Chinese;
			    			
			    case "Fname":
			        return Fname;
			    			
			    case "Hidden":
			        return Hidden;
			    			
			    case "Key":
			        return Key;
			    			
			    case "Position":
			        return Position;
			    			
			    case "Quota":
			        return Quota;
			    			
			    case "Quota_setting":
			        return Quota_setting;
			    			
			    case "Quota_setting_temp":
			        return Quota_setting_temp;
			    			
			    case "Quota_temp":
			        return Quota_temp;
			    			
			    case "Selected":
			        return Selected;
			    			
			    case "Table_name":
			        return Table_name;
			    			
			    case "Uuid":
			        return Uuid;
			
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
			    			
			    case "_type":
			        this._type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Api_code":
			        this.Api_code = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Chinese":
			        this.Chinese = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Fname":
			        this.Fname = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Hidden":
			        this.Hidden = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Key":
			        this.Key = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Position":
			        this.Position = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Quota":
			        this.Quota = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Quota_setting":
			        this.Quota_setting = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Quota_setting_temp":
			        this.Quota_setting_temp = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Quota_temp":
			        this.Quota_temp = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Selected":
			        this.Selected = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Table_name":
			        this.Table_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
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
				
				case "_type":
					return _type_initialized;
				
				case "Api_code":
					return api_code_initialized;
				
				case "Chinese":
					return chinese_initialized;
				
				case "Fname":
					return fname_initialized;
				
				case "Hidden":
					return hidden_initialized;
				
				case "Key":
					return key_initialized;
				
				case "Position":
					return position_initialized;
				
				case "Quota":
					return quota_initialized;
				
				case "Quota_setting":
					return quota_setting_initialized;
				
				case "Quota_setting_temp":
					return quota_setting_temp_initialized;
				
				case "Quota_temp":
					return quota_temp_initialized;
				
				case "Selected":
					return selected_initialized;
				
				case "Table_name":
					return table_name_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
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
				
				case "_type":
					_type_initialized = ret;
					return true;
				
				case "Api_code":
					api_code_initialized = ret;
					return true;
				
				case "Chinese":
					chinese_initialized = ret;
					return true;
				
				case "Fname":
					fname_initialized = ret;
					return true;
				
				case "Hidden":
					hidden_initialized = ret;
					return true;
				
				case "Key":
					key_initialized = ret;
					return true;
				
				case "Position":
					position_initialized = ret;
					return true;
				
				case "Quota":
					quota_initialized = ret;
					return true;
				
				case "Quota_setting":
					quota_setting_initialized = ret;
					return true;
				
				case "Quota_setting_temp":
					quota_setting_temp_initialized = ret;
					return true;
				
				case "Quota_temp":
					quota_temp_initialized = ret;
					return true;
				
				case "Selected":
					selected_initialized = ret;
					return true;
				
				case "Table_name":
					table_name_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
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
                AttributeItem attr = Frame_EnumConfig.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (_type_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute._type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(_type);
                }
			}
			
			if (api_code_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Api_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Api_code);
                }
			}
			
			if (chinese_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Chinese;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Chinese);
                }
			}
			
			if (fname_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Fname;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Fname);
                }
			}
			
			if (hidden_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Hidden;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Hidden);
                }
			}
			
			if (key_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Key;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Key);
                }
			}
			
			if (position_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Position;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Position);
                }
			}
			
			if (quota_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Quota;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Quota);
                }
			}
			
			if (quota_setting_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Quota_setting;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Quota_setting);
                }
			}
			
			if (quota_setting_temp_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Quota_setting_temp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Quota_setting_temp);
                }
			}
			
			if (quota_temp_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Quota_temp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Quota_temp);
                }
			}
			
			if (selected_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Selected;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Selected);
                }
			}
			
			if (table_name_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Table_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Table_name);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Frame_EnumConfig.Attribute.Uuid;
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

        #region Json����
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        [Serializable]
        public class Frame_EnumConfigJson
        {
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary>�ؼ�����:[CtrlTypeDic-{SelectDrop}]</summary>
            public string _type { get; set; }
            
            /// <summary>����API����</summary>
            public string Api_code { get; set; }
            
            /// <summary>������</summary>
            public string Chinese { get; set; }
            
            /// <summary>�ֶ���</summary>
            public string Fname { get; set; }
            
            /// <summary>�Ƿ�����</summary>
            public bool Hidden { get; set; }
            
            /// <summary>��ֵ</summary>
            public string Key { get; set; }
            
            /// <summary>λ��</summary>
            public int Position { get; set; }
            
            /// <summary>�޶�</summary>
            public string Quota { get; set; }
            
            /// <summary>�޶�����</summary>
            public string Quota_setting { get; set; }
            
            /// <summary>��ʱ�޶�����</summary>
            public string Quota_setting_temp { get; set; }
            
            /// <summary>��ʱ�޶�</summary>
            public string Quota_temp { get; set; }
            
            /// <summary>�Ƿ�ѡ��:[CtrlTypeDic-{SelectSingle}]</summary>
            public bool Selected { get; set; }
            
            /// <summary>����</summary>
            public string Table_name { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
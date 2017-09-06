/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/8/30 20:02:12
  Description:    ���ݱ�Frame_TableConfig��Ӧ��ҵ���߼���Frame_TableConfig
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Frame_TableConfig_Entity:Frame_TableConfig
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Notes,Table_desc,Table_name,Uuid from Frame_TableConfig
delete from Frame_TableConfig
INSERT INTO Frame_TableConfig (Id,Notes,Table_desc,Table_name,Uuid)
     VALUES
           ('','','','','')
UPDATE Frame_TableConfig SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Notes = valObj2.Notes;
        valObj.Table_desc = valObj2.Table_desc;
        valObj.Table_name = valObj2.Table_name;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.Notes = "";
        valObj.Table_desc = "";
        valObj.Table_name = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "Notes": $("#txt_Notes").val(),
        "Table_desc": $("#txt_Table_desc").val(),
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
    /// <para></para>
    /// <para>��Frame_TableConfig���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Frame_TableConfig : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Frame_TableConfig Factory()
        {
            return new Frame_TableConfig();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary>  Attribute_IsPrimary </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Notes
        {            
            get { return this.Notes; }
            set { this.Notes = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Table_desc
        {            
            get { return this.Table_desc; }
            set { this.Table_desc = value; }
        }
        
        /// <summary> �ֶ��� Attribute_IsNotNull </summary>
        public string _Table_name
        {            
            get { return this.Table_name; }
            set { this.Table_name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
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
            set //
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Table_desc
        {
            get { return this.m_table_desc; }
            set //
            {
                if (!table_desc_initialized || m_table_desc != value)
                {
                    this.m_table_desc = value;
                }
                table_desc_initialized = true;
            }
        }
        
        /// <summary> �ֶ������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
            public static AttributeItem Id =  new AttributeItem("[Frame_TableConfig].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Notes =  new AttributeItem("[Frame_TableConfig].[Notes]", typeof(string), 2000, default(string));
            
            /// <summary></summary>
            public static AttributeItem Table_desc =  new AttributeItem("[Frame_TableConfig].[Table_desc]", typeof(string), 200, default(string));
            
            /// <summary>�ֶ���</summary>
            public static AttributeItem Table_name =  new AttributeItem("[Frame_TableConfig].[Table_name]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[Frame_TableConfig].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_notes;
        /// <summary></summary>
        protected bool notes_initialized = false;
        
        private string m_table_desc;
        /// <summary></summary>
        protected bool table_desc_initialized = false;
        
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
            return "Frame_TableConfig";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.notes_initialized = IsLoadAllAttributes;this.table_desc_initialized = IsLoadAllAttributes;this.table_name_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Frame_TableConfig value = new Frame_TableConfig();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Notes"))
				value.notes_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Table_desc"))
				value.table_desc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Table_name"))
				value.table_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Frame_TableConfig Clone()
        {
            return (Frame_TableConfig)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Frame_TableConfig()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Frame_TableConfig() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Frame_TableConfig(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Frame_TableConfig(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Frame_TableConfig(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Frame_TableConfig(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Frame_TableConfig(int id1, string notes1, string table_desc1, string table_name1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.Notes = notes1;
            
            this.Table_desc = table_desc1;
            
            this.Table_name = table_name1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Frame_TableConfig FromIView(IView view)
        {
            return (Frame_TableConfig)IView.GetITable(view, "Frame_TableConfig");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Frame_TableConfig GetOneInstance()
        {
            Frame_TableConfig value = new Frame_TableConfig();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Frame_TableConfig Retrieve()
        {
            BLLTable<Frame_TableConfig>.GetRowData(this);
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
			    			
			    case "Notes":
			        return Notes;
			    			
			    case "Table_desc":
			        return Table_desc;
			    			
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
			    			
			    case "Notes":
			        this.Notes = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Table_desc":
			        this.Table_desc = Convert.ToString(AttributeValue);
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
				
				case "Notes":
					return notes_initialized;
				
				case "Table_desc":
					return table_desc_initialized;
				
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
				
				case "Notes":
					notes_initialized = ret;
					return true;
				
				case "Table_desc":
					table_desc_initialized = ret;
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
                AttributeItem attr = Frame_TableConfig.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (notes_initialized)
			{
                AttributeItem attr = Frame_TableConfig.Attribute.Notes;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Notes);
                }
			}
			
			if (table_desc_initialized)
			{
                AttributeItem attr = Frame_TableConfig.Attribute.Table_desc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Table_desc);
                }
			}
			
			if (table_name_initialized)
			{
                AttributeItem attr = Frame_TableConfig.Attribute.Table_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Table_name);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Frame_TableConfig.Attribute.Uuid;
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
        public class Frame_TableConfigJson
        {
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public string Notes { get; set; }
            
            /// <summary></summary>
            public string Table_desc { get; set; }
            
            /// <summary>�ֶ���</summary>
            public string Table_name { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
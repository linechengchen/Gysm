/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:34
  Description:    ���ݱ�Zy_bookKeywordTips��Ӧ��ҵ���߼���Zy_bookKeywordTips
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Zy_bookKeywordTips_Entity:Zy_bookKeywordTips
 * 
************************************************************/
/************************************************************
SQL���룺
select Name,Id,TableId from Zy_bookKeywordTips
delete from Zy_bookKeywordTips
INSERT INTO Zy_bookKeywordTips (Name,Id,TableId)
     VALUES
           ('','','')
UPDATE Zy_bookKeywordTips SET ...
������ֵ���룺
 *         valObj.Name = valObj2.Name;
        valObj.Id = valObj2.Id;
        valObj.TableId = valObj2.TableId; 
        valObj.Name = "";
        valObj.Id = "";
        valObj.TableId = ""; 
        "Name": $("#txt_Name").val(),
        "Id": $("#txt_Id").val(),
        "TableId": $("#txt_TableId").val(), 
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
    /// <para>�ؼ���TZY��ͼ��</para>
    /// <para>��Zy_bookKeywordTips���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Zy_bookKeywordTips : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Zy_bookKeywordTips Factory()
        {
            return new Zy_bookKeywordTips();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> ���:[CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ���ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TableId
        {            
            get { return this.TableId; }
            set { this.TableId = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Name
        {
            get { return this.m_name; }
            set //
            {
                if (!name_initialized || m_name != value)
                {
                    this.m_name = value;
                }
                name_initialized = true;
            }
        }
        
        /// <summary> ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int TableId
        {
            get { return this.m_tableid; }
            set //
            {
                if (!tableid_initialized || m_tableid != value)
                {
                    this.m_tableid = value;
                }
                tableid_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Zy_bookKeywordTips].[Name]", typeof(string), 200, default(string));
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Zy_bookKeywordTips].[Id]", typeof(int), 4, default(int));
            
            /// <summary>���ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TableId =  new AttributeItem("[Zy_bookKeywordTips].[TableId]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_tableid;
        /// <summary></summary>
        protected bool tableid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Zy_bookKeywordTips";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.name_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.tableid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Zy_bookKeywordTips value = new Zy_bookKeywordTips();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TableId"))
				value.tableid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Zy_bookKeywordTips Clone()
        {
            return (Zy_bookKeywordTips)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Zy_bookKeywordTips()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Zy_bookKeywordTips() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Zy_bookKeywordTips(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Zy_bookKeywordTips(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Zy_bookKeywordTips(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Zy_bookKeywordTips(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Zy_bookKeywordTips(string name1, int id1, int tableid1)
        {
            
            this.Name = name1;
            
            this.Id = id1;
            
            this.TableId = tableid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Zy_bookKeywordTips FromIView(IView view)
        {
            return (Zy_bookKeywordTips)IView.GetITable(view, "Zy_bookKeywordTips");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Zy_bookKeywordTips GetOneInstance()
        {
            Zy_bookKeywordTips value = new Zy_bookKeywordTips();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Zy_bookKeywordTips Retrieve()
        {
            BLLTable<Zy_bookKeywordTips>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Name":
			        return Name;
			    			
			    case "Id":
			        return Id;
			    			
			    case "TableId":
			        return TableId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TableId":
			        this.TableId = Convert.ToInt32(AttributeValue);
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
				case "Name":
					return name_initialized;
				
				case "Id":
					return id_initialized;
				
				case "TableId":
					return tableid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "TableId":
					tableid_initialized = ret;
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

			
			if (name_initialized)
			{
                AttributeItem attr = Zy_bookKeywordTips.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Zy_bookKeywordTips.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (tableid_initialized)
			{
                AttributeItem attr = Zy_bookKeywordTips.Attribute.TableId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TableId);
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
        public class Zy_bookKeywordTipsJson
        {
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>���ID:[CtrlTypeDic-{InputString}]</summary>
            public int TableId { get; set; }
        }
        #endregion
    }
}
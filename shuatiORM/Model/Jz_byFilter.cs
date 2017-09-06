/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:19
  Description:    ���ݱ�Jz_byFilter��Ӧ��ҵ���߼���Jz_byFilter
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jz_byFilter_Entity:Jz_byFilter
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,SortRules from Jz_byFilter
delete from Jz_byFilter
INSERT INTO Jz_byFilter (Id,SortRules)
     VALUES
           ('','')
UPDATE Jz_byFilter SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.SortRules = valObj2.SortRules; 
        valObj.Id = "";
        valObj.SortRules = ""; 
        "Id": $("#txt_Id").val(),
        "SortRules": $("#txt_SortRules").val(), 
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
    /// <para>��Jz_byFilter���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jz_byFilter : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jz_byFilter Factory()
        {
            return new Jz_byFilter();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [Enum-{INTELLIGENCE:��ͨ����},{NEAREST:�������},{LATEST_RELEASE:���·���},{POPULAR_JOB:���ż�ְ},{HIGH_SALARY:н�����},{APPLY_COUNT:��Ƹ����}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _SortRules
        {            
            get { return this.SortRules; }
            set { this.SortRules = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [Enum-{INTELLIGENCE:��ͨ����},{NEAREST:�������},{LATEST_RELEASE:���·���},{POPULAR_JOB:���ż�ְ},{HIGH_SALARY:н�����},{APPLY_COUNT:��Ƹ����}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SortRules
        {
            get { return this.m_sortrules; }
            set //
            {
                if (!sortrules_initialized || m_sortrules != value)
                {
                    this.m_sortrules = value;
                }
                sortrules_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Jz_byFilter].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[Enum-{INTELLIGENCE:��ͨ����},{NEAREST:�������},{LATEST_RELEASE:���·���},{POPULAR_JOB:���ż�ְ},{HIGH_SALARY:н�����},{APPLY_COUNT:��Ƹ����}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem SortRules =  new AttributeItem("[Jz_byFilter].[SortRules]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_sortrules;
        /// <summary></summary>
        protected bool sortrules_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_byFilter";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.sortrules_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_byFilter value = new Jz_byFilter();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SortRules"))
				value.sortrules_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jz_byFilter Clone()
        {
            return (Jz_byFilter)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jz_byFilter()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jz_byFilter() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jz_byFilter(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jz_byFilter(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jz_byFilter(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jz_byFilter(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jz_byFilter(int id1, string sortrules1)
        {
            
            this.Id = id1;
            
            this.SortRules = sortrules1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jz_byFilter FromIView(IView view)
        {
            return (Jz_byFilter)IView.GetITable(view, "Jz_byFilter");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jz_byFilter GetOneInstance()
        {
            Jz_byFilter value = new Jz_byFilter();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jz_byFilter Retrieve()
        {
            BLLTable<Jz_byFilter>.GetRowData(this);
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
			    			
			    case "SortRules":
			        return SortRules;
			
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
			    			
			    case "SortRules":
			        this.SortRules = Convert.ToString(AttributeValue);
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
				
				case "SortRules":
					return sortrules_initialized;
				
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
				
				case "SortRules":
					sortrules_initialized = ret;
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
                AttributeItem attr = Jz_byFilter.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (sortrules_initialized)
			{
                AttributeItem attr = Jz_byFilter.Attribute.SortRules;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SortRules);
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
        public class Jz_byFilterJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[Enum-{INTELLIGENCE:��ͨ����},{NEAREST:�������},{LATEST_RELEASE:���·���},{POPULAR_JOB:���ż�ְ},{HIGH_SALARY:н�����},{APPLY_COUNT:��Ƹ����}][CtrlTypeDic-{SelectDrop}]</summary>
            public string SortRules { get; set; }
        }
        #endregion
    }
}
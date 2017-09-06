/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    ���ݱ�TSearchKeyword��Ӧ��ҵ���߼���TSearchKeyword
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TSearchKeyword_Entity:TSearchKeyword
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Keyword,Count,Form from TSearchKeyword
delete from TSearchKeyword
INSERT INTO TSearchKeyword (Id,Keyword,Count,Form)
     VALUES
           ('','','','')
UPDATE TSearchKeyword SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Keyword = valObj2.Keyword;
        valObj.Count = valObj2.Count;
        valObj.Form = valObj2.Form; 
        valObj.Id = "";
        valObj.Keyword = "";
        valObj.Count = "";
        valObj.Form = ""; 
        "Id": $("#txt_Id").val(),
        "Keyword": $("#txt_Keyword").val(),
        "Count": $("#txt_Count").val(),
        "Form": $("#txt_Form").val(), 
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
    /// <para>�����ؼ���</para>
    /// <para>��TSearchKeyword���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TSearchKeyword : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TSearchKeyword Factory()
        {
            return new TSearchKeyword();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �ؼ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Keyword
        {            
            get { return this.Keyword; }
            set { this.Keyword = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Count
        {            
            get { return this.Count; }
            set { this.Count = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Form
        {            
            get { return this.Form; }
            set { this.Form = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �ؼ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Keyword
        {
            get { return this.m_keyword; }
            set //
            {
                if (!keyword_initialized || m_keyword != value)
                {
                    this.m_keyword = value;
                }
                keyword_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Count
        {
            get { return this.m_count; }
            set //
            {
                if (!count_initialized || m_count != value)
                {
                    this.m_count = value;
                }
                count_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Form
        {
            get { return this.m_form; }
            set //
            {
                if (!form_initialized || m_form != value)
                {
                    this.m_form = value;
                }
                form_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[TSearchKeyword].[Id]", typeof(int), 4, default(int));
            
            /// <summary>�ؼ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Keyword =  new AttributeItem("[TSearchKeyword].[Keyword]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Count =  new AttributeItem("[TSearchKeyword].[Count]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Form =  new AttributeItem("[TSearchKeyword].[Form]", typeof(string), 100, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_keyword;
        /// <summary></summary>
        protected bool keyword_initialized = false;
        
        private int m_count;
        /// <summary></summary>
        protected bool count_initialized = false;
        
        private string m_form;
        /// <summary></summary>
        protected bool form_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TSearchKeyword";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.keyword_initialized = IsLoadAllAttributes;this.count_initialized = IsLoadAllAttributes;this.form_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TSearchKeyword value = new TSearchKeyword();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Keyword"))
				value.keyword_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Count"))
				value.count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Form"))
				value.form_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TSearchKeyword Clone()
        {
            return (TSearchKeyword)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TSearchKeyword()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TSearchKeyword() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TSearchKeyword(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TSearchKeyword(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TSearchKeyword(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TSearchKeyword(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TSearchKeyword(int id1, string keyword1, int count1, string form1)
        {
            
            this.Id = id1;
            
            this.Keyword = keyword1;
            
            this.Count = count1;
            
            this.Form = form1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TSearchKeyword FromIView(IView view)
        {
            return (TSearchKeyword)IView.GetITable(view, "TSearchKeyword");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TSearchKeyword GetOneInstance()
        {
            TSearchKeyword value = new TSearchKeyword();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TSearchKeyword Retrieve()
        {
            BLLTable<TSearchKeyword>.GetRowData(this);
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
			    			
			    case "Keyword":
			        return Keyword;
			    			
			    case "Count":
			        return Count;
			    			
			    case "Form":
			        return Form;
			
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
			    			
			    case "Keyword":
			        this.Keyword = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Count":
			        this.Count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Form":
			        this.Form = Convert.ToString(AttributeValue);
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
				
				case "Keyword":
					return keyword_initialized;
				
				case "Count":
					return count_initialized;
				
				case "Form":
					return form_initialized;
				
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
				
				case "Keyword":
					keyword_initialized = ret;
					return true;
				
				case "Count":
					count_initialized = ret;
					return true;
				
				case "Form":
					form_initialized = ret;
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
                AttributeItem attr = TSearchKeyword.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (keyword_initialized)
			{
                AttributeItem attr = TSearchKeyword.Attribute.Keyword;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Keyword);
                }
			}
			
			if (count_initialized)
			{
                AttributeItem attr = TSearchKeyword.Attribute.Count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Count);
                }
			}
			
			if (form_initialized)
			{
                AttributeItem attr = TSearchKeyword.Attribute.Form;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Form);
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
        public class TSearchKeywordJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>�ؼ���:[CtrlTypeDic-{InputString}]</summary>
            public string Keyword { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public int Count { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Form { get; set; }
        }
        #endregion
    }
}
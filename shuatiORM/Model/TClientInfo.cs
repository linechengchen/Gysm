/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    ���ݱ�TClientInfo��Ӧ��ҵ���߼���TClientInfo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TClientInfo_Entity:TClientInfo
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Source1,Description,Sc,PidSource1 from TClientInfo
delete from TClientInfo
INSERT INTO TClientInfo (Id,Source1,Description,Sc,PidSource1)
     VALUES
           ('','','','','')
UPDATE TClientInfo SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Source1 = valObj2.Source1;
        valObj.Description = valObj2.Description;
        valObj.Sc = valObj2.Sc;
        valObj.PidSource1 = valObj2.PidSource1; 
        valObj.Id = "";
        valObj.Source1 = "";
        valObj.Description = "";
        valObj.Sc = "";
        valObj.PidSource1 = ""; 
        "Id": $("#txt_Id").val(),
        "Source1": $("#txt_Source1").val(),
        "Description": $("#txt_Description").val(),
        "Sc": $("#txt_Sc").val(),
        "PidSource1": $("#txt_PidSource1").val(), 
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
    /// <para>��Ŀͻ���Ϣ</para>
    /// <para>��TClientInfo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TClientInfo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TClientInfo Factory()
        {
            return new TClientInfo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> Դ1:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Source1
        {            
            get { return this.Source1; }
            set { this.Source1 = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Description
        {            
            get { return this.Description; }
            set { this.Description = value; }
        }
        
        /// <summary> Դ��ѧУ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> PIDԴ1:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PidSource1
        {            
            get { return this.PidSource1; }
            set { this.PidSource1 = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> Դ1:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Description
        {
            get { return this.m_description; }
            set //
            {
                if (!description_initialized || m_description != value)
                {
                    this.m_description = value;
                }
                description_initialized = true;
            }
        }
        
        /// <summary> Դ��ѧУ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> PIDԴ1:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PidSource1
        {
            get { return this.m_pidsource1; }
            set //
            {
                if (!pidsource1_initialized || m_pidsource1 != value)
                {
                    this.m_pidsource1 = value;
                }
                pidsource1_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[TClientInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>Դ1:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Source1 =  new AttributeItem("[TClientInfo].[Source1]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Description =  new AttributeItem("[TClientInfo].[Description]", typeof(string), 500, default(string));
            
            /// <summary>Դ��ѧУ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[TClientInfo].[Sc]", typeof(string), 50, default(string));
            
            /// <summary>PIDԴ1:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PidSource1 =  new AttributeItem("[TClientInfo].[PidSource1]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_source1;
        /// <summary></summary>
        protected bool source1_initialized = false;
        
        private string m_description;
        /// <summary></summary>
        protected bool description_initialized = false;
        
        private string m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private string m_pidsource1;
        /// <summary></summary>
        protected bool pidsource1_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TClientInfo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.source1_initialized = IsLoadAllAttributes;this.description_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.pidsource1_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TClientInfo value = new TClientInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Source1"))
				value.source1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Description"))
				value.description_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PidSource1"))
				value.pidsource1_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TClientInfo Clone()
        {
            return (TClientInfo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TClientInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TClientInfo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TClientInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TClientInfo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TClientInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TClientInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TClientInfo(int id1, string source11, string description1, string sc1, string pidsource11)
        {
            
            this.Id = id1;
            
            this.Source1 = source11;
            
            this.Description = description1;
            
            this.Sc = sc1;
            
            this.PidSource1 = pidsource11;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TClientInfo FromIView(IView view)
        {
            return (TClientInfo)IView.GetITable(view, "TClientInfo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TClientInfo GetOneInstance()
        {
            TClientInfo value = new TClientInfo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TClientInfo Retrieve()
        {
            BLLTable<TClientInfo>.GetRowData(this);
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
			    			
			    case "Source1":
			        return Source1;
			    			
			    case "Description":
			        return Description;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "PidSource1":
			        return PidSource1;
			
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
			    			
			    case "Source1":
			        this.Source1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Description":
			        this.Description = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PidSource1":
			        this.PidSource1 = Convert.ToString(AttributeValue);
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
				
				case "Source1":
					return source1_initialized;
				
				case "Description":
					return description_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "PidSource1":
					return pidsource1_initialized;
				
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
				
				case "Source1":
					source1_initialized = ret;
					return true;
				
				case "Description":
					description_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "PidSource1":
					pidsource1_initialized = ret;
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
                AttributeItem attr = TClientInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (source1_initialized)
			{
                AttributeItem attr = TClientInfo.Attribute.Source1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Source1);
                }
			}
			
			if (description_initialized)
			{
                AttributeItem attr = TClientInfo.Attribute.Description;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Description);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = TClientInfo.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (pidsource1_initialized)
			{
                AttributeItem attr = TClientInfo.Attribute.PidSource1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PidSource1);
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
        public class TClientInfoJson
        {
            
            /// <summary>ID:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>Դ1:[CtrlTypeDic-{InputString}]</summary>
            public string Source1 { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{Text}]</summary>
            public string Description { get; set; }
            
            /// <summary>Դ��ѧУ��:[CtrlTypeDic-{InputString}]</summary>
            public string Sc { get; set; }
            
            /// <summary>PIDԴ1:[CtrlTypeDic-{InputString}]</summary>
            public string PidSource1 { get; set; }
        }
        #endregion
    }
}
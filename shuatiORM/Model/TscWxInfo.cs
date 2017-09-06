/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    ���ݱ�TscWxInfo��Ӧ��ҵ���߼���TscWxInfo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TscWxInfo_Entity:TscWxInfo
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Sc_id,Sc_name,Sc_description,School_id,Seq from TscWxInfo
delete from TscWxInfo
INSERT INTO TscWxInfo (Id,Sc_id,Sc_name,Sc_description,School_id,Seq)
     VALUES
           ('','','','','','')
UPDATE TscWxInfo SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Sc_id = valObj2.Sc_id;
        valObj.Sc_name = valObj2.Sc_name;
        valObj.Sc_description = valObj2.Sc_description;
        valObj.School_id = valObj2.School_id;
        valObj.Seq = valObj2.Seq; 
        valObj.Id = "";
        valObj.Sc_id = "";
        valObj.Sc_name = "";
        valObj.Sc_description = "";
        valObj.School_id = "";
        valObj.Seq = ""; 
        "Id": $("#txt_Id").val(),
        "Sc_id": $("#txt_Sc_id").val(),
        "Sc_name": $("#txt_Sc_name").val(),
        "Sc_description": $("#txt_Sc_description").val(),
        "School_id": $("#txt_School_id").val(),
        "Seq": $("#txt_Seq").val(), 
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
    /// <para>Դ��Ϣ//��ѧ��Ż�ҽ�ѧ��</para>
    /// <para>��TscWxInfo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TscWxInfo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TscWxInfo Factory()
        {
            return new TscWxInfo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc_id
        {            
            get { return this.Sc_id; }
            set { this.Sc_id = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc_name
        {            
            get { return this.Sc_name; }
            set { this.Sc_name = value; }
        }
        
        /// <summary> ע��:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Sc_description
        {            
            get { return this.Sc_description; }
            set { this.Sc_description = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _School_id
        {            
            get { return this.School_id; }
            set { this.School_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
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
        
        /// <summary> ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sc_id
        {
            get { return this.m_sc_id; }
            set //
            {
                if (!sc_id_initialized || m_sc_id != value)
                {
                    this.m_sc_id = value;
                }
                sc_id_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sc_name
        {
            get { return this.m_sc_name; }
            set //
            {
                if (!sc_name_initialized || m_sc_name != value)
                {
                    this.m_sc_name = value;
                }
                sc_name_initialized = true;
            }
        }
        
        /// <summary> ע��:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sc_description
        {
            get { return this.m_sc_description; }
            set //
            {
                if (!sc_description_initialized || m_sc_description != value)
                {
                    this.m_sc_description = value;
                }
                sc_description_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int School_id
        {
            get { return this.m_school_id; }
            set //
            {
                if (!school_id_initialized || m_school_id != value)
                {
                    this.m_school_id = value;
                }
                school_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Seq
        {
            get { return this.m_seq; }
            set //
            {
                if (!seq_initialized || m_seq != value)
                {
                    this.m_seq = value;
                }
                seq_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TscWxInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc_id =  new AttributeItem("[TscWxInfo].[Sc_id]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc_name =  new AttributeItem("[TscWxInfo].[Sc_name]", typeof(string), 50, default(string));
            
            /// <summary>ע��:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Sc_description =  new AttributeItem("[TscWxInfo].[Sc_description]", typeof(string), 1000, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_id =  new AttributeItem("[TscWxInfo].[School_id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[TscWxInfo].[Seq]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_sc_id;
        /// <summary></summary>
        protected bool sc_id_initialized = false;
        
        private string m_sc_name;
        /// <summary></summary>
        protected bool sc_name_initialized = false;
        
        private string m_sc_description;
        /// <summary></summary>
        protected bool sc_description_initialized = false;
        
        private int m_school_id;
        /// <summary></summary>
        protected bool school_id_initialized = false;
        
        private int m_seq;
        /// <summary></summary>
        protected bool seq_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TscWxInfo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.sc_id_initialized = IsLoadAllAttributes;this.sc_name_initialized = IsLoadAllAttributes;this.sc_description_initialized = IsLoadAllAttributes;this.school_id_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TscWxInfo value = new TscWxInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc_id"))
				value.sc_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc_name"))
				value.sc_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc_description"))
				value.sc_description_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_id"))
				value.school_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TscWxInfo Clone()
        {
            return (TscWxInfo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TscWxInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TscWxInfo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TscWxInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TscWxInfo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TscWxInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TscWxInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TscWxInfo(int id1, string sc_id1, string sc_name1, string sc_description1, int school_id1, int seq1)
        {
            
            this.Id = id1;
            
            this.Sc_id = sc_id1;
            
            this.Sc_name = sc_name1;
            
            this.Sc_description = sc_description1;
            
            this.School_id = school_id1;
            
            this.Seq = seq1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TscWxInfo FromIView(IView view)
        {
            return (TscWxInfo)IView.GetITable(view, "TscWxInfo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TscWxInfo GetOneInstance()
        {
            TscWxInfo value = new TscWxInfo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TscWxInfo Retrieve()
        {
            BLLTable<TscWxInfo>.GetRowData(this);
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
			    			
			    case "Sc_id":
			        return Sc_id;
			    			
			    case "Sc_name":
			        return Sc_name;
			    			
			    case "Sc_description":
			        return Sc_description;
			    			
			    case "School_id":
			        return School_id;
			    			
			    case "Seq":
			        return Seq;
			
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
			    			
			    case "Sc_id":
			        this.Sc_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc_name":
			        this.Sc_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc_description":
			        this.Sc_description = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "School_id":
			        this.School_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Seq":
			        this.Seq = Convert.ToInt32(AttributeValue);
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
				
				case "Sc_id":
					return sc_id_initialized;
				
				case "Sc_name":
					return sc_name_initialized;
				
				case "Sc_description":
					return sc_description_initialized;
				
				case "School_id":
					return school_id_initialized;
				
				case "Seq":
					return seq_initialized;
				
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
				
				case "Sc_id":
					sc_id_initialized = ret;
					return true;
				
				case "Sc_name":
					sc_name_initialized = ret;
					return true;
				
				case "Sc_description":
					sc_description_initialized = ret;
					return true;
				
				case "School_id":
					school_id_initialized = ret;
					return true;
				
				case "Seq":
					seq_initialized = ret;
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
                AttributeItem attr = TscWxInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (sc_id_initialized)
			{
                AttributeItem attr = TscWxInfo.Attribute.Sc_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc_id);
                }
			}
			
			if (sc_name_initialized)
			{
                AttributeItem attr = TscWxInfo.Attribute.Sc_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc_name);
                }
			}
			
			if (sc_description_initialized)
			{
                AttributeItem attr = TscWxInfo.Attribute.Sc_description;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc_description);
                }
			}
			
			if (school_id_initialized)
			{
                AttributeItem attr = TscWxInfo.Attribute.School_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_id);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = TscWxInfo.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
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
        public class TscWxInfoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public string Sc_id { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Sc_name { get; set; }
            
            /// <summary>ע��:[CtrlTypeDic-{Text}]</summary>
            public string Sc_description { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int School_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
        }
        #endregion
    }
}
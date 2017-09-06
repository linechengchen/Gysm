/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:40
  Description:    ���ݱ�St_TzsTypeInfo��Ӧ��ҵ���߼���St_TzsTypeInfo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� St_TzsTypeInfo_Entity:St_TzsTypeInfo
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,IsHot,Seq,TypeId,TypeName from St_TzsTypeInfo
delete from St_TzsTypeInfo
INSERT INTO St_TzsTypeInfo (Id,IsHot,Seq,TypeId,TypeName)
     VALUES
           ('','','','','')
UPDATE St_TzsTypeInfo SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.IsHot = valObj2.IsHot;
        valObj.Seq = valObj2.Seq;
        valObj.TypeId = valObj2.TypeId;
        valObj.TypeName = valObj2.TypeName; 
        valObj.Id = "";
        valObj.IsHot = "";
        valObj.Seq = "";
        valObj.TypeId = "";
        valObj.TypeName = ""; 
        "Id": $("#txt_Id").val(),
        "IsHot": $("#txt_IsHot").val(),
        "Seq": $("#txt_Seq").val(),
        "TypeId": $("#txt_TypeId").val(),
        "TypeName": $("#txt_TypeName").val(), 
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
    /// <para>֤������:[IDField-{Id:0}]</para>
    /// <para>��St_TzsTypeInfo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class St_TzsTypeInfo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static St_TzsTypeInfo Factory()
        {
            return new St_TzsTypeInfo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsHot
        {            
            get { return this.IsHot; }
            set { this.IsHot = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TypeId
        {            
            get { return this.TypeId; }
            set { this.TypeId = value; }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TypeName
        {            
            get { return this.TypeName; }
            set { this.TypeName = value; }
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
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool IsHot
        {
            get { return this.m_ishot; }
            set //
            {
                if (!ishot_initialized || m_ishot != value)
                {
                    this.m_ishot = value;
                }
                ishot_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int TypeId
        {
            get { return this.m_typeid; }
            set //
            {
                if (!typeid_initialized || m_typeid != value)
                {
                    this.m_typeid = value;
                }
                typeid_initialized = true;
            }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TypeName
        {
            get { return this.m_typename; }
            set //
            {
                if (!typename_initialized || m_typename != value)
                {
                    this.m_typename = value;
                }
                typename_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[St_TzsTypeInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsHot =  new AttributeItem("[St_TzsTypeInfo].[IsHot]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[St_TzsTypeInfo].[Seq]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TypeId =  new AttributeItem("[St_TzsTypeInfo].[TypeId]", typeof(int), 4, default(int));
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TypeName =  new AttributeItem("[St_TzsTypeInfo].[TypeName]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private bool m_ishot;
        /// <summary></summary>
        protected bool ishot_initialized = false;
        
        private int m_seq;
        /// <summary></summary>
        protected bool seq_initialized = false;
        
        private int m_typeid;
        /// <summary></summary>
        protected bool typeid_initialized = false;
        
        private string m_typename;
        /// <summary></summary>
        protected bool typename_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TzsTypeInfo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.ishot_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;this.typeid_initialized = IsLoadAllAttributes;this.typename_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TzsTypeInfo value = new St_TzsTypeInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHot"))
				value.ishot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TypeId"))
				value.typeid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TypeName"))
				value.typename_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new St_TzsTypeInfo Clone()
        {
            return (St_TzsTypeInfo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static St_TzsTypeInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public St_TzsTypeInfo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public St_TzsTypeInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public St_TzsTypeInfo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public St_TzsTypeInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public St_TzsTypeInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public St_TzsTypeInfo(int id1, bool ishot1, int seq1, int typeid1, string typename1)
        {
            
            this.Id = id1;
            
            this.IsHot = ishot1;
            
            this.Seq = seq1;
            
            this.TypeId = typeid1;
            
            this.TypeName = typename1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static St_TzsTypeInfo FromIView(IView view)
        {
            return (St_TzsTypeInfo)IView.GetITable(view, "St_TzsTypeInfo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static St_TzsTypeInfo GetOneInstance()
        {
            St_TzsTypeInfo value = new St_TzsTypeInfo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public St_TzsTypeInfo Retrieve()
        {
            BLLTable<St_TzsTypeInfo>.GetRowData(this);
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
			    			
			    case "IsHot":
			        return IsHot;
			    			
			    case "Seq":
			        return Seq;
			    			
			    case "TypeId":
			        return TypeId;
			    			
			    case "TypeName":
			        return TypeName;
			
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
			    			
			    case "IsHot":
			        this.IsHot = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Seq":
			        this.Seq = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TypeId":
			        this.TypeId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TypeName":
			        this.TypeName = Convert.ToString(AttributeValue);
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
				
				case "IsHot":
					return ishot_initialized;
				
				case "Seq":
					return seq_initialized;
				
				case "TypeId":
					return typeid_initialized;
				
				case "TypeName":
					return typename_initialized;
				
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
				
				case "IsHot":
					ishot_initialized = ret;
					return true;
				
				case "Seq":
					seq_initialized = ret;
					return true;
				
				case "TypeId":
					typeid_initialized = ret;
					return true;
				
				case "TypeName":
					typename_initialized = ret;
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
                AttributeItem attr = St_TzsTypeInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (ishot_initialized)
			{
                AttributeItem attr = St_TzsTypeInfo.Attribute.IsHot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHot);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = St_TzsTypeInfo.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
                }
			}
			
			if (typeid_initialized)
			{
                AttributeItem attr = St_TzsTypeInfo.Attribute.TypeId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TypeId);
                }
			}
			
			if (typename_initialized)
			{
                AttributeItem attr = St_TzsTypeInfo.Attribute.TypeName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TypeName);
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
        public class St_TzsTypeInfoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsHot { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int TypeId { get; set; }
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public string TypeName { get; set; }
        }
        #endregion
    }
}
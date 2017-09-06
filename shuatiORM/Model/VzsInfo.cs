/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:59
  Description:    ���ݱ�VzsInfo��Ӧ��ҵ���߼���VzsInfo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� VzsInfo_Entity:VzsInfo
 * 
************************************************************/
/************************************************************
SQL���룺
select TypeName,Id,ZsName from VzsInfo
delete from VzsInfo
INSERT INTO VzsInfo (TypeName,Id,ZsName)
     VALUES
           ('','','')
UPDATE VzsInfo SET ...
������ֵ���룺
 *         valObj.TypeName = valObj2.TypeName;
        valObj.Id = valObj2.Id;
        valObj.ZsName = valObj2.ZsName; 
        valObj.TypeName = "";
        valObj.Id = "";
        valObj.ZsName = ""; 
        "TypeName": $("#txt_TypeName").val(),
        "Id": $("#txt_Id").val(),
        "ZsName": $("#txt_ZsName").val(), 
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
    /// <para>֤���__֤������:[Inner-{St_TzsInfo:0},{St_TzsTypeInfo:1}]</para>
    /// <para>��VzsInfo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class VzsInfo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static VzsInfo Factory()
        {
            return new VzsInfo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TypeName
        {            
            get { return this.TypeName; }
            set { this.TypeName = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ֤����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsName
        {            
            get { return this.ZsName; }
            set { this.ZsName = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
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
        
        /// <summary> ֤����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ZsName
        {
            get { return this.m_zsname; }
            set //
            {
                if (!zsname_initialized || m_zsname != value)
                {
                    this.m_zsname = value;
                }
                zsname_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TypeName =  new AttributeItem("[VzsInfo].[TypeName]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[VzsInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>֤����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsName =  new AttributeItem("[VzsInfo].[ZsName]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_typename;
        /// <summary></summary>
        protected bool typename_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_zsname;
        /// <summary></summary>
        protected bool zsname_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "VzsInfo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.typename_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.zsname_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			VzsInfo value = new VzsInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"TypeName"))
				value.typename_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsName"))
				value.zsname_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new VzsInfo Clone()
        {
            return (VzsInfo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static VzsInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public VzsInfo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public VzsInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public VzsInfo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public VzsInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public VzsInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public VzsInfo(string typename1, int id1, string zsname1)
        {
            
            this.TypeName = typename1;
            
            this.Id = id1;
            
            this.ZsName = zsname1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static VzsInfo FromIView(IView view)
        {
            return (VzsInfo)IView.GetITable(view, "VzsInfo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static VzsInfo GetOneInstance()
        {
            VzsInfo value = new VzsInfo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public VzsInfo Retrieve()
        {
            BLLTable<VzsInfo>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "TypeName":
			        return TypeName;
			    			
			    case "Id":
			        return Id;
			    			
			    case "ZsName":
			        return ZsName;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "TypeName":
			        this.TypeName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ZsName":
			        this.ZsName = Convert.ToString(AttributeValue);
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
				case "TypeName":
					return typename_initialized;
				
				case "Id":
					return id_initialized;
				
				case "ZsName":
					return zsname_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "TypeName":
					typename_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "ZsName":
					zsname_initialized = ret;
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

			
			if (typename_initialized)
			{
                AttributeItem attr = VzsInfo.Attribute.TypeName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TypeName);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = VzsInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (zsname_initialized)
			{
                AttributeItem attr = VzsInfo.Attribute.ZsName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsName);
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
        public class VzsInfoJson
        {
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public string TypeName { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary>֤����:[CtrlTypeDic-{InputString}]</summary>
            public string ZsName { get; set; }
        }
        #endregion
    }
}
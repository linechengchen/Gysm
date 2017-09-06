/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:30
  Description:    ���ݱ�Xs_bookCategoryRelation��Ӧ��ҵ���߼���Xs_bookCategoryRelation
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xs_bookCategoryRelation_Entity:Xs_bookCategoryRelation
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,TBookSaleCategoryId,Seq from Xs_bookCategoryRelation
delete from Xs_bookCategoryRelation
INSERT INTO Xs_bookCategoryRelation (Id,TBookSaleCategoryId,Seq)
     VALUES
           ('','','')
UPDATE Xs_bookCategoryRelation SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.TBookSaleCategoryId = valObj2.TBookSaleCategoryId;
        valObj.Seq = valObj2.Seq; 
        valObj.Id = "";
        valObj.TBookSaleCategoryId = "";
        valObj.Seq = ""; 
        "Id": $("#txt_Id").val(),
        "TBookSaleCategoryId": $("#txt_TBookSaleCategoryId").val(),
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
    /// <para>ͼ������Ʒ���ϵ</para>
    /// <para>��Xs_bookCategoryRelation���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xs_bookCategoryRelation : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xs_bookCategoryRelation Factory()
        {
            return new Xs_bookCategoryRelation();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ͼ����������ʶ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TBookSaleCategoryId
        {            
            get { return this.TBookSaleCategoryId; }
            set { this.TBookSaleCategoryId = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ͼ����������ʶ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int TBookSaleCategoryId
        {
            get { return this.m_tbooksalecategoryid; }
            set //
            {
                if (!tbooksalecategoryid_initialized || m_tbooksalecategoryid != value)
                {
                    this.m_tbooksalecategoryid = value;
                }
                tbooksalecategoryid_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xs_bookCategoryRelation].[Id]", typeof(int), 4, default(int));
            
            /// <summary>ͼ����������ʶ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TBookSaleCategoryId =  new AttributeItem("[Xs_bookCategoryRelation].[TBookSaleCategoryId]", typeof(int), 4, default(int));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[Xs_bookCategoryRelation].[Seq]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_tbooksalecategoryid;
        /// <summary></summary>
        protected bool tbooksalecategoryid_initialized = false;
        
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
            return "Xs_bookCategoryRelation";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.tbooksalecategoryid_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xs_bookCategoryRelation value = new Xs_bookCategoryRelation();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TBookSaleCategoryId"))
				value.tbooksalecategoryid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xs_bookCategoryRelation Clone()
        {
            return (Xs_bookCategoryRelation)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xs_bookCategoryRelation()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xs_bookCategoryRelation() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xs_bookCategoryRelation(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xs_bookCategoryRelation(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xs_bookCategoryRelation(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xs_bookCategoryRelation(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xs_bookCategoryRelation(int id1, int tbooksalecategoryid1, int seq1)
        {
            
            this.Id = id1;
            
            this.TBookSaleCategoryId = tbooksalecategoryid1;
            
            this.Seq = seq1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xs_bookCategoryRelation FromIView(IView view)
        {
            return (Xs_bookCategoryRelation)IView.GetITable(view, "Xs_bookCategoryRelation");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xs_bookCategoryRelation GetOneInstance()
        {
            Xs_bookCategoryRelation value = new Xs_bookCategoryRelation();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xs_bookCategoryRelation Retrieve()
        {
            BLLTable<Xs_bookCategoryRelation>.GetRowData(this);
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
			    			
			    case "TBookSaleCategoryId":
			        return TBookSaleCategoryId;
			    			
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
			    			
			    case "TBookSaleCategoryId":
			        this.TBookSaleCategoryId = Convert.ToInt32(AttributeValue);
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
				
				case "TBookSaleCategoryId":
					return tbooksalecategoryid_initialized;
				
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
				
				case "TBookSaleCategoryId":
					tbooksalecategoryid_initialized = ret;
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
                AttributeItem attr = Xs_bookCategoryRelation.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (tbooksalecategoryid_initialized)
			{
                AttributeItem attr = Xs_bookCategoryRelation.Attribute.TBookSaleCategoryId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TBookSaleCategoryId);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = Xs_bookCategoryRelation.Attribute.Seq;
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
        public class Xs_bookCategoryRelationJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>ͼ����������ʶ:[CtrlTypeDic-{InputString}]</summary>
            public int TBookSaleCategoryId { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
        }
        #endregion
    }
}
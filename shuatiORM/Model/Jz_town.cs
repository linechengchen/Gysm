/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:21
  Description:    ���ݱ�Jz_town��Ӧ��ҵ���߼���Jz_town
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jz_town_Entity:Jz_town
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Opened,ProviceId,SpellCode,TownId,TownName,ClassificationId from Jz_town
delete from Jz_town
INSERT INTO Jz_town (Id,Opened,ProviceId,SpellCode,TownId,TownName,ClassificationId)
     VALUES
           ('','','','','','','')
UPDATE Jz_town SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Opened = valObj2.Opened;
        valObj.ProviceId = valObj2.ProviceId;
        valObj.SpellCode = valObj2.SpellCode;
        valObj.TownId = valObj2.TownId;
        valObj.TownName = valObj2.TownName;
        valObj.ClassificationId = valObj2.ClassificationId; 
        valObj.Id = "";
        valObj.Opened = "";
        valObj.ProviceId = "";
        valObj.SpellCode = "";
        valObj.TownId = "";
        valObj.TownName = "";
        valObj.ClassificationId = ""; 
        "Id": $("#txt_Id").val(),
        "Opened": $("#txt_Opened").val(),
        "ProviceId": $("#txt_ProviceId").val(),
        "SpellCode": $("#txt_SpellCode").val(),
        "TownId": $("#txt_TownId").val(),
        "TownName": $("#txt_TownName").val(),
        "ClassificationId": $("#txt_ClassificationId").val(), 
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
    /// <para>��</para>
    /// <para>��Jz_town���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jz_town : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jz_town Factory()
        {
            return new Jz_town();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _Opened
        {            
            get { return this.Opened; }
            set { this.Opened = value; }
        }
        
        /// <summary> ʡ��ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ProviceId
        {            
            get { return this.ProviceId; }
            set { this.ProviceId = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SpellCode
        {            
            get { return this.SpellCode; }
            set { this.SpellCode = value; }
        }
        
        /// <summary> ���ϵ�ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TownId
        {            
            get { return this.TownId; }
            set { this.TownId = value; }
        }
        
        /// <summary> С�������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TownName
        {            
            get { return this.TownName; }
            set { this.TownName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ClassificationId
        {            
            get { return this.ClassificationId; }
            set { this.ClassificationId = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid Id
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
        
        /// <summary> ����:[CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool Opened
        {
            get { return this.m_opened; }
            set //
            {
                if (!opened_initialized || m_opened != value)
                {
                    this.m_opened = value;
                }
                opened_initialized = true;
            }
        }
        
        /// <summary> ʡ��ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ProviceId
        {
            get { return this.m_proviceid; }
            set //
            {
                if (!proviceid_initialized || m_proviceid != value)
                {
                    this.m_proviceid = value;
                }
                proviceid_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SpellCode
        {
            get { return this.m_spellcode; }
            set //
            {
                if (!spellcode_initialized || m_spellcode != value)
                {
                    this.m_spellcode = value;
                }
                spellcode_initialized = true;
            }
        }
        
        /// <summary> ���ϵ�ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int TownId
        {
            get { return this.m_townid; }
            set //
            {
                if (!townid_initialized || m_townid != value)
                {
                    this.m_townid = value;
                }
                townid_initialized = true;
            }
        }
        
        /// <summary> С�������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TownName
        {
            get { return this.m_townname; }
            set //
            {
                if (!townname_initialized || m_townname != value)
                {
                    this.m_townname = value;
                }
                townname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ClassificationId
        {
            get { return this.m_classificationid; }
            set //
            {
                if (!classificationid_initialized || m_classificationid != value)
                {
                    this.m_classificationid = value;
                }
                classificationid_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Jz_town].[Id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Opened =  new AttributeItem("[Jz_town].[Opened]", typeof(bool), 1, default(bool));
            
            /// <summary>ʡ��ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ProviceId =  new AttributeItem("[Jz_town].[ProviceId]", typeof(int), 4, default(int));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SpellCode =  new AttributeItem("[Jz_town].[SpellCode]", typeof(string), 50, default(string));
            
            /// <summary>���ϵ�ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TownId =  new AttributeItem("[Jz_town].[TownId]", typeof(int), 4, default(int));
            
            /// <summary>С�������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TownName =  new AttributeItem("[Jz_town].[TownName]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassificationId =  new AttributeItem("[Jz_town].[ClassificationId]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private bool m_opened;
        /// <summary></summary>
        protected bool opened_initialized = false;
        
        private int m_proviceid;
        /// <summary></summary>
        protected bool proviceid_initialized = false;
        
        private string m_spellcode;
        /// <summary></summary>
        protected bool spellcode_initialized = false;
        
        private int m_townid;
        /// <summary></summary>
        protected bool townid_initialized = false;
        
        private string m_townname;
        /// <summary></summary>
        protected bool townname_initialized = false;
        
        private int m_classificationid;
        /// <summary></summary>
        protected bool classificationid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_town";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.opened_initialized = IsLoadAllAttributes;this.proviceid_initialized = IsLoadAllAttributes;this.spellcode_initialized = IsLoadAllAttributes;this.townid_initialized = IsLoadAllAttributes;this.townname_initialized = IsLoadAllAttributes;this.classificationid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_town value = new Jz_town();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Opened"))
				value.opened_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ProviceId"))
				value.proviceid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SpellCode"))
				value.spellcode_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TownId"))
				value.townid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TownName"))
				value.townname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassificationId"))
				value.classificationid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jz_town Clone()
        {
            return (Jz_town)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jz_town()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jz_town() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jz_town(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jz_town(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jz_town(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jz_town(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jz_town(Guid id1, bool opened1, int proviceid1, string spellcode1, int townid1, string townname1, int classificationid1)
        {
            
            this.Id = id1;
            
            this.Opened = opened1;
            
            this.ProviceId = proviceid1;
            
            this.SpellCode = spellcode1;
            
            this.TownId = townid1;
            
            this.TownName = townname1;
            
            this.ClassificationId = classificationid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jz_town FromIView(IView view)
        {
            return (Jz_town)IView.GetITable(view, "Jz_town");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jz_town GetOneInstance()
        {
            Jz_town value = new Jz_town();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jz_town Retrieve()
        {
            BLLTable<Jz_town>.GetRowData(this);
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
			    			
			    case "Opened":
			        return Opened;
			    			
			    case "ProviceId":
			        return ProviceId;
			    			
			    case "SpellCode":
			        return SpellCode;
			    			
			    case "TownId":
			        return TownId;
			    			
			    case "TownName":
			        return TownName;
			    			
			    case "ClassificationId":
			        return ClassificationId;
			
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
			        this.Id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Opened":
			        this.Opened = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "ProviceId":
			        this.ProviceId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "SpellCode":
			        this.SpellCode = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TownId":
			        this.TownId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TownName":
			        this.TownName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassificationId":
			        this.ClassificationId = Convert.ToInt32(AttributeValue);
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
				
				case "Opened":
					return opened_initialized;
				
				case "ProviceId":
					return proviceid_initialized;
				
				case "SpellCode":
					return spellcode_initialized;
				
				case "TownId":
					return townid_initialized;
				
				case "TownName":
					return townname_initialized;
				
				case "ClassificationId":
					return classificationid_initialized;
				
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
				
				case "Opened":
					opened_initialized = ret;
					return true;
				
				case "ProviceId":
					proviceid_initialized = ret;
					return true;
				
				case "SpellCode":
					spellcode_initialized = ret;
					return true;
				
				case "TownId":
					townid_initialized = ret;
					return true;
				
				case "TownName":
					townname_initialized = ret;
					return true;
				
				case "ClassificationId":
					classificationid_initialized = ret;
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
                AttributeItem attr = Jz_town.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (opened_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.Opened;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Opened);
                }
			}
			
			if (proviceid_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.ProviceId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ProviceId);
                }
			}
			
			if (spellcode_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.SpellCode;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SpellCode);
                }
			}
			
			if (townid_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.TownId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TownId);
                }
			}
			
			if (townname_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.TownName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TownName);
                }
			}
			
			if (classificationid_initialized)
			{
                AttributeItem attr = Jz_town.Attribute.ClassificationId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationId);
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
        public class Jz_townJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public Guid Id { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Opened { get; set; }
            
            /// <summary>ʡ��ID:[CtrlTypeDic-{InputString}]</summary>
            public int ProviceId { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string SpellCode { get; set; }
            
            /// <summary>���ϵ�ID:[CtrlTypeDic-{InputString}]</summary>
            public int TownId { get; set; }
            
            /// <summary>С�������:[CtrlTypeDic-{InputString}]</summary>
            public string TownName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int ClassificationId { get; set; }
        }
        #endregion
    }
}
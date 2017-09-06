/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:19
  Description:    ���ݱ�Jsj_form��Ӧ��ҵ���߼���Jsj_form
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jsj_form_Entity:Jsj_form
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Uuid,ModifyTime,CreateTime,Form,Form_name from Jsj_form
delete from Jsj_form
INSERT INTO Jsj_form (Id,Uuid,ModifyTime,CreateTime,Form,Form_name)
     VALUES
           ('','','','','','')
UPDATE Jsj_form SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Uuid = valObj2.Uuid;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Form = valObj2.Form;
        valObj.Form_name = valObj2.Form_name; 
        valObj.Id = "";
        valObj.Uuid = "";
        valObj.ModifyTime = "";
        valObj.CreateTime = "";
        valObj.Form = "";
        valObj.Form_name = ""; 
        "Id": $("#txt_Id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Form": $("#txt_Form").val(),
        "Form_name": $("#txt_Form_name").val(), 
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
    /// <para>��Jsj_form���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jsj_form : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jsj_form Factory()
        {
            return new Jsj_form();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Form
        {            
            get { return this.Form; }
            set { this.Form = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Form_name
        {            
            get { return this.Form_name; }
            set { this.Form_name = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime ModifyTime
        {
            get { return this.m_modifytime; }
            set //
            {
                if (!modifytime_initialized || m_modifytime != value)
                {
                    this.m_modifytime = value;
                }
                modifytime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime CreateTime
        {
            get { return this.m_createtime; }
            set //
            {
                if (!createtime_initialized || m_createtime != value)
                {
                    this.m_createtime = value;
                }
                createtime_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Form_name
        {
            get { return this.m_form_name; }
            set //
            {
                if (!form_name_initialized || m_form_name != value)
                {
                    this.m_form_name = value;
                }
                form_name_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Jsj_form].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Jsj_form].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Jsj_form].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jsj_form].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Form =  new AttributeItem("[Jsj_form].[Form]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Form_name =  new AttributeItem("[Jsj_form].[Form_name]", typeof(string), 100, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_form;
        /// <summary></summary>
        protected bool form_initialized = false;
        
        private string m_form_name;
        /// <summary></summary>
        protected bool form_name_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jsj_form";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.form_initialized = IsLoadAllAttributes;this.form_name_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jsj_form value = new Jsj_form();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Form"))
				value.form_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Form_name"))
				value.form_name_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jsj_form Clone()
        {
            return (Jsj_form)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jsj_form()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jsj_form() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jsj_form(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jsj_form(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jsj_form(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jsj_form(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jsj_form(int id1, Guid uuid1, DateTime modifytime1, DateTime createtime1, string form1, string form_name1)
        {
            
            this.Id = id1;
            
            this.Uuid = uuid1;
            
            this.ModifyTime = modifytime1;
            
            this.CreateTime = createtime1;
            
            this.Form = form1;
            
            this.Form_name = form_name1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jsj_form FromIView(IView view)
        {
            return (Jsj_form)IView.GetITable(view, "Jsj_form");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jsj_form GetOneInstance()
        {
            Jsj_form value = new Jsj_form();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jsj_form Retrieve()
        {
            BLLTable<Jsj_form>.GetRowData(this);
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
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Form":
			        return Form;
			    			
			    case "Form_name":
			        return Form_name;
			
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
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Form":
			        this.Form = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Form_name":
			        this.Form_name = Convert.ToString(AttributeValue);
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
				
				case "Uuid":
					return uuid_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Form":
					return form_initialized;
				
				case "Form_name":
					return form_name_initialized;
				
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
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Form":
					form_initialized = ret;
					return true;
				
				case "Form_name":
					form_name_initialized = ret;
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
                AttributeItem attr = Jsj_form.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Jsj_form.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Jsj_form.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jsj_form.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (form_initialized)
			{
                AttributeItem attr = Jsj_form.Attribute.Form;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Form);
                }
			}
			
			if (form_name_initialized)
			{
                AttributeItem attr = Jsj_form.Attribute.Form_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Form_name);
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
        public class Jsj_formJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Form { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Form_name { get; set; }
        }
        #endregion
    }
}
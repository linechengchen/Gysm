/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:21
  Description:    ���ݱ�Xb_indexpage��Ӧ��ҵ���߼���Xb_indexpage
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_indexpage_Entity:Xb_indexpage
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Btn_dayi,Btn_tiku,Phone_title,Phone_title_small,Phone_title_small_sum,Phone_title_sum,Title_big,Title_head,Title_small from Xb_indexpage
delete from Xb_indexpage
INSERT INTO Xb_indexpage (Id,Btn_dayi,Btn_tiku,Phone_title,Phone_title_small,Phone_title_small_sum,Phone_title_sum,Title_big,Title_head,Title_small)
     VALUES
           ('','','','','','','','','','')
UPDATE Xb_indexpage SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Btn_dayi = valObj2.Btn_dayi;
        valObj.Btn_tiku = valObj2.Btn_tiku;
        valObj.Phone_title = valObj2.Phone_title;
        valObj.Phone_title_small = valObj2.Phone_title_small;
        valObj.Phone_title_small_sum = valObj2.Phone_title_small_sum;
        valObj.Phone_title_sum = valObj2.Phone_title_sum;
        valObj.Title_big = valObj2.Title_big;
        valObj.Title_head = valObj2.Title_head;
        valObj.Title_small = valObj2.Title_small; 
        valObj.Id = "";
        valObj.Btn_dayi = "";
        valObj.Btn_tiku = "";
        valObj.Phone_title = "";
        valObj.Phone_title_small = "";
        valObj.Phone_title_small_sum = "";
        valObj.Phone_title_sum = "";
        valObj.Title_big = "";
        valObj.Title_head = "";
        valObj.Title_small = ""; 
        "Id": $("#txt_Id").val(),
        "Btn_dayi": $("#txt_Btn_dayi").val(),
        "Btn_tiku": $("#txt_Btn_tiku").val(),
        "Phone_title": $("#txt_Phone_title").val(),
        "Phone_title_small": $("#txt_Phone_title_small").val(),
        "Phone_title_small_sum": $("#txt_Phone_title_small_sum").val(),
        "Phone_title_sum": $("#txt_Phone_title_sum").val(),
        "Title_big": $("#txt_Title_big").val(),
        "Title_head": $("#txt_Title_head").val(),
        "Title_small": $("#txt_Title_small").val(), 
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
    /// <para>��Xb_indexpage���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_indexpage : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_indexpage Factory()
        {
            return new Xb_indexpage();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Btn_dayi
        {            
            get { return this.Btn_dayi; }
            set { this.Btn_dayi = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Btn_tiku
        {            
            get { return this.Btn_tiku; }
            set { this.Btn_tiku = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_title
        {            
            get { return this.Phone_title; }
            set { this.Phone_title = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_title_small
        {            
            get { return this.Phone_title_small; }
            set { this.Phone_title_small = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_title_small_sum
        {            
            get { return this.Phone_title_small_sum; }
            set { this.Phone_title_small_sum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_title_sum
        {            
            get { return this.Phone_title_sum; }
            set { this.Phone_title_sum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title_big
        {            
            get { return this.Title_big; }
            set { this.Title_big = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title_head
        {            
            get { return this.Title_head; }
            set { this.Title_head = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title_small
        {            
            get { return this.Title_small; }
            set { this.Title_small = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Btn_dayi
        {
            get { return this.m_btn_dayi; }
            set //
            {
                if (!btn_dayi_initialized || m_btn_dayi != value)
                {
                    this.m_btn_dayi = value;
                }
                btn_dayi_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Btn_tiku
        {
            get { return this.m_btn_tiku; }
            set //
            {
                if (!btn_tiku_initialized || m_btn_tiku != value)
                {
                    this.m_btn_tiku = value;
                }
                btn_tiku_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Phone_title
        {
            get { return this.m_phone_title; }
            set //
            {
                if (!phone_title_initialized || m_phone_title != value)
                {
                    this.m_phone_title = value;
                }
                phone_title_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Phone_title_small
        {
            get { return this.m_phone_title_small; }
            set //
            {
                if (!phone_title_small_initialized || m_phone_title_small != value)
                {
                    this.m_phone_title_small = value;
                }
                phone_title_small_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Phone_title_small_sum
        {
            get { return this.m_phone_title_small_sum; }
            set //
            {
                if (!phone_title_small_sum_initialized || m_phone_title_small_sum != value)
                {
                    this.m_phone_title_small_sum = value;
                }
                phone_title_small_sum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Phone_title_sum
        {
            get { return this.m_phone_title_sum; }
            set //
            {
                if (!phone_title_sum_initialized || m_phone_title_sum != value)
                {
                    this.m_phone_title_sum = value;
                }
                phone_title_sum_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Title_big
        {
            get { return this.m_title_big; }
            set //
            {
                if (!title_big_initialized || m_title_big != value)
                {
                    this.m_title_big = value;
                }
                title_big_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Title_head
        {
            get { return this.m_title_head; }
            set //
            {
                if (!title_head_initialized || m_title_head != value)
                {
                    this.m_title_head = value;
                }
                title_head_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Title_small
        {
            get { return this.m_title_small; }
            set //
            {
                if (!title_small_initialized || m_title_small != value)
                {
                    this.m_title_small = value;
                }
                title_small_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_indexpage].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Btn_dayi =  new AttributeItem("[Xb_indexpage].[Btn_dayi]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Btn_tiku =  new AttributeItem("[Xb_indexpage].[Btn_tiku]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_title =  new AttributeItem("[Xb_indexpage].[Phone_title]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_title_small =  new AttributeItem("[Xb_indexpage].[Phone_title_small]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_title_small_sum =  new AttributeItem("[Xb_indexpage].[Phone_title_small_sum]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_title_sum =  new AttributeItem("[Xb_indexpage].[Phone_title_sum]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title_big =  new AttributeItem("[Xb_indexpage].[Title_big]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title_head =  new AttributeItem("[Xb_indexpage].[Title_head]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title_small =  new AttributeItem("[Xb_indexpage].[Title_small]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_btn_dayi;
        /// <summary></summary>
        protected bool btn_dayi_initialized = false;
        
        private string m_btn_tiku;
        /// <summary></summary>
        protected bool btn_tiku_initialized = false;
        
        private string m_phone_title;
        /// <summary></summary>
        protected bool phone_title_initialized = false;
        
        private string m_phone_title_small;
        /// <summary></summary>
        protected bool phone_title_small_initialized = false;
        
        private string m_phone_title_small_sum;
        /// <summary></summary>
        protected bool phone_title_small_sum_initialized = false;
        
        private string m_phone_title_sum;
        /// <summary></summary>
        protected bool phone_title_sum_initialized = false;
        
        private string m_title_big;
        /// <summary></summary>
        protected bool title_big_initialized = false;
        
        private string m_title_head;
        /// <summary></summary>
        protected bool title_head_initialized = false;
        
        private string m_title_small;
        /// <summary></summary>
        protected bool title_small_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_indexpage";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.btn_dayi_initialized = IsLoadAllAttributes;this.btn_tiku_initialized = IsLoadAllAttributes;this.phone_title_initialized = IsLoadAllAttributes;this.phone_title_small_initialized = IsLoadAllAttributes;this.phone_title_small_sum_initialized = IsLoadAllAttributes;this.phone_title_sum_initialized = IsLoadAllAttributes;this.title_big_initialized = IsLoadAllAttributes;this.title_head_initialized = IsLoadAllAttributes;this.title_small_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_indexpage value = new Xb_indexpage();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Btn_dayi"))
				value.btn_dayi_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Btn_tiku"))
				value.btn_tiku_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_title"))
				value.phone_title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_title_small"))
				value.phone_title_small_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_title_small_sum"))
				value.phone_title_small_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_title_sum"))
				value.phone_title_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title_big"))
				value.title_big_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title_head"))
				value.title_head_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title_small"))
				value.title_small_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_indexpage Clone()
        {
            return (Xb_indexpage)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_indexpage()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_indexpage() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_indexpage(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_indexpage(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_indexpage(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_indexpage(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_indexpage(int id1, string btn_dayi1, string btn_tiku1, string phone_title1, string phone_title_small1, string phone_title_small_sum1, string phone_title_sum1, string title_big1, string title_head1, string title_small1)
        {
            
            this.Id = id1;
            
            this.Btn_dayi = btn_dayi1;
            
            this.Btn_tiku = btn_tiku1;
            
            this.Phone_title = phone_title1;
            
            this.Phone_title_small = phone_title_small1;
            
            this.Phone_title_small_sum = phone_title_small_sum1;
            
            this.Phone_title_sum = phone_title_sum1;
            
            this.Title_big = title_big1;
            
            this.Title_head = title_head1;
            
            this.Title_small = title_small1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_indexpage FromIView(IView view)
        {
            return (Xb_indexpage)IView.GetITable(view, "Xb_indexpage");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_indexpage GetOneInstance()
        {
            Xb_indexpage value = new Xb_indexpage();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_indexpage Retrieve()
        {
            BLLTable<Xb_indexpage>.GetRowData(this);
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
			    			
			    case "Btn_dayi":
			        return Btn_dayi;
			    			
			    case "Btn_tiku":
			        return Btn_tiku;
			    			
			    case "Phone_title":
			        return Phone_title;
			    			
			    case "Phone_title_small":
			        return Phone_title_small;
			    			
			    case "Phone_title_small_sum":
			        return Phone_title_small_sum;
			    			
			    case "Phone_title_sum":
			        return Phone_title_sum;
			    			
			    case "Title_big":
			        return Title_big;
			    			
			    case "Title_head":
			        return Title_head;
			    			
			    case "Title_small":
			        return Title_small;
			
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
			    			
			    case "Btn_dayi":
			        this.Btn_dayi = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Btn_tiku":
			        this.Btn_tiku = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_title":
			        this.Phone_title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_title_small":
			        this.Phone_title_small = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_title_small_sum":
			        this.Phone_title_small_sum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_title_sum":
			        this.Phone_title_sum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title_big":
			        this.Title_big = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title_head":
			        this.Title_head = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title_small":
			        this.Title_small = Convert.ToString(AttributeValue);
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
				
				case "Btn_dayi":
					return btn_dayi_initialized;
				
				case "Btn_tiku":
					return btn_tiku_initialized;
				
				case "Phone_title":
					return phone_title_initialized;
				
				case "Phone_title_small":
					return phone_title_small_initialized;
				
				case "Phone_title_small_sum":
					return phone_title_small_sum_initialized;
				
				case "Phone_title_sum":
					return phone_title_sum_initialized;
				
				case "Title_big":
					return title_big_initialized;
				
				case "Title_head":
					return title_head_initialized;
				
				case "Title_small":
					return title_small_initialized;
				
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
				
				case "Btn_dayi":
					btn_dayi_initialized = ret;
					return true;
				
				case "Btn_tiku":
					btn_tiku_initialized = ret;
					return true;
				
				case "Phone_title":
					phone_title_initialized = ret;
					return true;
				
				case "Phone_title_small":
					phone_title_small_initialized = ret;
					return true;
				
				case "Phone_title_small_sum":
					phone_title_small_sum_initialized = ret;
					return true;
				
				case "Phone_title_sum":
					phone_title_sum_initialized = ret;
					return true;
				
				case "Title_big":
					title_big_initialized = ret;
					return true;
				
				case "Title_head":
					title_head_initialized = ret;
					return true;
				
				case "Title_small":
					title_small_initialized = ret;
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
                AttributeItem attr = Xb_indexpage.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (btn_dayi_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Btn_dayi;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Btn_dayi);
                }
			}
			
			if (btn_tiku_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Btn_tiku;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Btn_tiku);
                }
			}
			
			if (phone_title_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Phone_title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_title);
                }
			}
			
			if (phone_title_small_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Phone_title_small;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_title_small);
                }
			}
			
			if (phone_title_small_sum_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Phone_title_small_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_title_small_sum);
                }
			}
			
			if (phone_title_sum_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Phone_title_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_title_sum);
                }
			}
			
			if (title_big_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Title_big;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title_big);
                }
			}
			
			if (title_head_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Title_head;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title_head);
                }
			}
			
			if (title_small_initialized)
			{
                AttributeItem attr = Xb_indexpage.Attribute.Title_small;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title_small);
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
        public class Xb_indexpageJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Btn_dayi { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Btn_tiku { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_title { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_title_small { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_title_small_sum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Phone_title_sum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Title_big { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Title_head { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Title_small { get; set; }
        }
        #endregion
    }
}
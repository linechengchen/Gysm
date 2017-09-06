/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:30
  Description:    ���ݱ�Xt_article��Ӧ��ҵ���߼���Xt_article
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_article_Entity:Xt_article
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,CreateTime,Article_name,Subtitle,Category_id,Category_name,Auther,Knowledge_id,Article_class,Describe,Content from Xt_article
delete from Xt_article
INSERT INTO Xt_article (Uuid,CreateTime,Article_name,Subtitle,Category_id,Category_name,Auther,Knowledge_id,Article_class,Describe,Content)
     VALUES
           ('','','','','','','','','','','')
UPDATE Xt_article SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Article_name = valObj2.Article_name;
        valObj.Subtitle = valObj2.Subtitle;
        valObj.Category_id = valObj2.Category_id;
        valObj.Category_name = valObj2.Category_name;
        valObj.Auther = valObj2.Auther;
        valObj.Knowledge_id = valObj2.Knowledge_id;
        valObj.Article_class = valObj2.Article_class;
        valObj.Describe = valObj2.Describe;
        valObj.Content = valObj2.Content; 
        valObj.Uuid = "";
        valObj.CreateTime = "";
        valObj.Article_name = "";
        valObj.Subtitle = "";
        valObj.Category_id = "";
        valObj.Category_name = "";
        valObj.Auther = "";
        valObj.Knowledge_id = "";
        valObj.Article_class = "";
        valObj.Describe = "";
        valObj.Content = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Article_name": $("#txt_Article_name").val(),
        "Subtitle": $("#txt_Subtitle").val(),
        "Category_id": $("#txt_Category_id").val(),
        "Category_name": $("#txt_Category_name").val(),
        "Auther": $("#txt_Auther").val(),
        "Knowledge_id": $("#txt_Knowledge_id").val(),
        "Article_class": $("#txt_Article_class").val(),
        "Describe": $("#txt_Describe").val(),
        "Content": $("#txt_Content").val(), 
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
    /// <para>���ϱ�</para>
    /// <para>��Xt_article���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_article : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_article Factory()
        {
            return new Xt_article();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Article_name
        {            
            get { return this.Article_name; }
            set { this.Article_name = value; }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Subtitle
        {            
            get { return this.Subtitle; }
            set { this.Subtitle = value; }
        }
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_id
        {            
            get { return this.Category_id; }
            set { this.Category_id = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_name
        {            
            get { return this.Category_name; }
            set { this.Category_name = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Auther
        {            
            get { return this.Auther; }
            set { this.Auther = value; }
        }
        
        /// <summary> ֪ʶid:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Knowledge_id
        {            
            get { return this.Knowledge_id; }
            set { this.Knowledge_id = value; }
        }
        
        /// <summary> ����༶:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Article_class
        {            
            get { return this.Article_class; }
            set { this.Article_class = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Describe
        {            
            get { return this.Describe; }
            set { this.Describe = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Content
        {            
            get { return this.Content; }
            set { this.Content = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
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
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Article_name
        {
            get { return this.m_article_name; }
            set //
            {
                if (!article_name_initialized || m_article_name != value)
                {
                    this.m_article_name = value;
                }
                article_name_initialized = true;
            }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Subtitle
        {
            get { return this.m_subtitle; }
            set //
            {
                if (!subtitle_initialized || m_subtitle != value)
                {
                    this.m_subtitle = value;
                }
                subtitle_initialized = true;
            }
        }
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Category_id
        {
            get { return this.m_category_id; }
            set //
            {
                if (!category_id_initialized || m_category_id != value)
                {
                    this.m_category_id = value;
                }
                category_id_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Category_name
        {
            get { return this.m_category_name; }
            set //
            {
                if (!category_name_initialized || m_category_name != value)
                {
                    this.m_category_name = value;
                }
                category_name_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Auther
        {
            get { return this.m_auther; }
            set //
            {
                if (!auther_initialized || m_auther != value)
                {
                    this.m_auther = value;
                }
                auther_initialized = true;
            }
        }
        
        /// <summary> ֪ʶid:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Knowledge_id
        {
            get { return this.m_knowledge_id; }
            set //
            {
                if (!knowledge_id_initialized || m_knowledge_id != value)
                {
                    this.m_knowledge_id = value;
                }
                knowledge_id_initialized = true;
            }
        }
        
        /// <summary> ����༶:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Article_class
        {
            get { return this.m_article_class; }
            set //
            {
                if (!article_class_initialized || m_article_class != value)
                {
                    this.m_article_class = value;
                }
                article_class_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Describe
        {
            get { return this.m_describe; }
            set //
            {
                if (!describe_initialized || m_describe != value)
                {
                    this.m_describe = value;
                }
                describe_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Content
        {
            get { return this.m_content; }
            set //
            {
                if (!content_initialized || m_content != value)
                {
                    this.m_content = value;
                }
                content_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_article].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xt_article].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Article_name =  new AttributeItem("[Xt_article].[Article_name]", typeof(string), 100, default(string));
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Subtitle =  new AttributeItem("[Xt_article].[Subtitle]", typeof(string), 100, default(string));
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_id =  new AttributeItem("[Xt_article].[Category_id]", typeof(string), 36, default(string));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_name =  new AttributeItem("[Xt_article].[Category_name]", typeof(string), 100, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Auther =  new AttributeItem("[Xt_article].[Auther]", typeof(string), 100, default(string));
            
            /// <summary>֪ʶid:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Knowledge_id =  new AttributeItem("[Xt_article].[Knowledge_id]", typeof(string), 36, default(string));
            
            /// <summary>����༶:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Article_class =  new AttributeItem("[Xt_article].[Article_class]", typeof(string), 10, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Describe =  new AttributeItem("[Xt_article].[Describe]", typeof(string), 100, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Content =  new AttributeItem("[Xt_article].[Content]", typeof(string), -1, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_article_name;
        /// <summary></summary>
        protected bool article_name_initialized = false;
        
        private string m_subtitle;
        /// <summary></summary>
        protected bool subtitle_initialized = false;
        
        private string m_category_id;
        /// <summary></summary>
        protected bool category_id_initialized = false;
        
        private string m_category_name;
        /// <summary></summary>
        protected bool category_name_initialized = false;
        
        private string m_auther;
        /// <summary></summary>
        protected bool auther_initialized = false;
        
        private string m_knowledge_id;
        /// <summary></summary>
        protected bool knowledge_id_initialized = false;
        
        private string m_article_class;
        /// <summary></summary>
        protected bool article_class_initialized = false;
        
        private string m_describe;
        /// <summary></summary>
        protected bool describe_initialized = false;
        
        private string m_content;
        /// <summary></summary>
        protected bool content_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_article";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.article_name_initialized = IsLoadAllAttributes;this.subtitle_initialized = IsLoadAllAttributes;this.category_id_initialized = IsLoadAllAttributes;this.category_name_initialized = IsLoadAllAttributes;this.auther_initialized = IsLoadAllAttributes;this.knowledge_id_initialized = IsLoadAllAttributes;this.article_class_initialized = IsLoadAllAttributes;this.describe_initialized = IsLoadAllAttributes;this.content_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_article value = new Xt_article();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Article_name"))
				value.article_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Subtitle"))
				value.subtitle_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_id"))
				value.category_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_name"))
				value.category_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Auther"))
				value.auther_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Knowledge_id"))
				value.knowledge_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Article_class"))
				value.article_class_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Describe"))
				value.describe_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content"))
				value.content_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_article Clone()
        {
            return (Xt_article)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_article()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_article() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_article(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_article(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_article(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_article(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_article(Guid uuid1, DateTime createtime1, string article_name1, string subtitle1, string category_id1, string category_name1, string auther1, string knowledge_id1, string article_class1, string describe1, string content1)
        {
            
            this.Uuid = uuid1;
            
            this.CreateTime = createtime1;
            
            this.Article_name = article_name1;
            
            this.Subtitle = subtitle1;
            
            this.Category_id = category_id1;
            
            this.Category_name = category_name1;
            
            this.Auther = auther1;
            
            this.Knowledge_id = knowledge_id1;
            
            this.Article_class = article_class1;
            
            this.Describe = describe1;
            
            this.Content = content1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_article FromIView(IView view)
        {
            return (Xt_article)IView.GetITable(view, "Xt_article");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_article GetOneInstance()
        {
            Xt_article value = new Xt_article();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_article Retrieve()
        {
            BLLTable<Xt_article>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        return Uuid;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Article_name":
			        return Article_name;
			    			
			    case "Subtitle":
			        return Subtitle;
			    			
			    case "Category_id":
			        return Category_id;
			    			
			    case "Category_name":
			        return Category_name;
			    			
			    case "Auther":
			        return Auther;
			    			
			    case "Knowledge_id":
			        return Knowledge_id;
			    			
			    case "Article_class":
			        return Article_class;
			    			
			    case "Describe":
			        return Describe;
			    			
			    case "Content":
			        return Content;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Article_name":
			        this.Article_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Subtitle":
			        this.Subtitle = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_id":
			        this.Category_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_name":
			        this.Category_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Auther":
			        this.Auther = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Knowledge_id":
			        this.Knowledge_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Article_class":
			        this.Article_class = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Describe":
			        this.Describe = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Content":
			        this.Content = Convert.ToString(AttributeValue);
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
				case "Uuid":
					return uuid_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Article_name":
					return article_name_initialized;
				
				case "Subtitle":
					return subtitle_initialized;
				
				case "Category_id":
					return category_id_initialized;
				
				case "Category_name":
					return category_name_initialized;
				
				case "Auther":
					return auther_initialized;
				
				case "Knowledge_id":
					return knowledge_id_initialized;
				
				case "Article_class":
					return article_class_initialized;
				
				case "Describe":
					return describe_initialized;
				
				case "Content":
					return content_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Article_name":
					article_name_initialized = ret;
					return true;
				
				case "Subtitle":
					subtitle_initialized = ret;
					return true;
				
				case "Category_id":
					category_id_initialized = ret;
					return true;
				
				case "Category_name":
					category_name_initialized = ret;
					return true;
				
				case "Auther":
					auther_initialized = ret;
					return true;
				
				case "Knowledge_id":
					knowledge_id_initialized = ret;
					return true;
				
				case "Article_class":
					article_class_initialized = ret;
					return true;
				
				case "Describe":
					describe_initialized = ret;
					return true;
				
				case "Content":
					content_initialized = ret;
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

			
			if (uuid_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (article_name_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Article_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Article_name);
                }
			}
			
			if (subtitle_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Subtitle;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Subtitle);
                }
			}
			
			if (category_id_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Category_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_id);
                }
			}
			
			if (category_name_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Category_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_name);
                }
			}
			
			if (auther_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Auther;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Auther);
                }
			}
			
			if (knowledge_id_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Knowledge_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Knowledge_id);
                }
			}
			
			if (article_class_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Article_class;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Article_class);
                }
			}
			
			if (describe_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Describe;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Describe);
                }
			}
			
			if (content_initialized)
			{
                AttributeItem attr = Xt_article.Attribute.Content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content);
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
        public class Xt_articleJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Article_name { get; set; }
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public string Subtitle { get; set; }
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public string Category_id { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string Category_name { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Auther { get; set; }
            
            /// <summary>֪ʶid:[CtrlTypeDic-{InputString}]</summary>
            public string Knowledge_id { get; set; }
            
            /// <summary>����༶:[CtrlTypeDic-{InputString}]</summary>
            public string Article_class { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Describe { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Content { get; set; }
        }
        #endregion
    }
}
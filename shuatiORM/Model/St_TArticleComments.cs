/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:37
  Description:    ���ݱ�St_TArticleComments��Ӧ��ҵ���߼���St_TArticleComments
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� St_TArticleComments_Entity:St_TArticleComments
 * 
************************************************************/
/************************************************************
SQL���룺
select ArticleId,CommentCount,CommentPId,Content,ContentHtml,CreateDate,ID,Images,IsShowBest,TeacherId,User_id,Voice from St_TArticleComments
delete from St_TArticleComments
INSERT INTO St_TArticleComments (ArticleId,CommentCount,CommentPId,Content,ContentHtml,CreateDate,ID,Images,IsShowBest,TeacherId,User_id,Voice)
     VALUES
           ('','','','','','','','','','','','')
UPDATE St_TArticleComments SET ...
������ֵ���룺
 *         valObj.ArticleId = valObj2.ArticleId;
        valObj.CommentCount = valObj2.CommentCount;
        valObj.CommentPId = valObj2.CommentPId;
        valObj.Content = valObj2.Content;
        valObj.ContentHtml = valObj2.ContentHtml;
        valObj.CreateDate = valObj2.CreateDate;
        valObj.ID = valObj2.ID;
        valObj.Images = valObj2.Images;
        valObj.IsShowBest = valObj2.IsShowBest;
        valObj.TeacherId = valObj2.TeacherId;
        valObj.User_id = valObj2.User_id;
        valObj.Voice = valObj2.Voice; 
        valObj.ArticleId = "";
        valObj.CommentCount = "";
        valObj.CommentPId = "";
        valObj.Content = "";
        valObj.ContentHtml = "";
        valObj.CreateDate = "";
        valObj.ID = "";
        valObj.Images = "";
        valObj.IsShowBest = "";
        valObj.TeacherId = "";
        valObj.User_id = "";
        valObj.Voice = ""; 
        "ArticleId": $("#txt_ArticleId").val(),
        "CommentCount": $("#txt_CommentCount").val(),
        "CommentPId": $("#txt_CommentPId").val(),
        "Content": $("#txt_Content").val(),
        "ContentHtml": $("#txt_ContentHtml").val(),
        "CreateDate": $("#txt_CreateDate").val(),
        "ID": $("#txt_ID").val(),
        "Images": $("#txt_Images").val(),
        "IsShowBest": $("#txt_IsShowBest").val(),
        "TeacherId": $("#txt_TeacherId").val(),
        "User_id": $("#txt_User_id").val(),
        "Voice": $("#txt_Voice").val(), 
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
    /// <para>���۱�:[IDField-{ID:0}]</para>
    /// <para>��St_TArticleComments���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class St_TArticleComments : ITableImplement
    {
        /// <summary>��������  </summary>
        public static St_TArticleComments Factory()
        {
            return new St_TArticleComments();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ��������ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ArticleId
        {            
            get { return this.ArticleId; }
            set { this.ArticleId = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CommentCount
        {            
            get { return this.CommentCount; }
            set { this.CommentCount = value; }
        }
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CommentPId
        {            
            get { return this.CommentPId; }
            set { this.CommentPId = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _Content
        {            
            get { return this.Content; }
            set { this.Content = value; }
        }
        
        /// <summary> ������ַ:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _ContentHtml
        {            
            get { return this.ContentHtml; }
            set { this.ContentHtml = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _CreateDate
        {            
            get { return this.CreateDate; }
            set { this.CreateDate = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _ID
        {            
            get { return this.ID; }
            set { this.ID = value; }
        }
        
        /// <summary> ����ͼƬ:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _Images
        {            
            get { return this.Images; }
            set { this.Images = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IsShowBest
        {            
            get { return this.IsShowBest; }
            set { this.IsShowBest = value; }
        }
        
        /// <summary> ��ʦID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeacherId
        {            
            get { return this.TeacherId; }
            set { this.TeacherId = value; }
        }
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Voice
        {            
            get { return this.Voice; }
            set { this.Voice = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ��������ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ArticleId
        {
            get { return this.m_articleid; }
            set //
            {
                if (!articleid_initialized || m_articleid != value)
                {
                    this.m_articleid = value;
                }
                articleid_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string CommentCount
        {
            get { return this.m_commentcount; }
            set //
            {
                if (!commentcount_initialized || m_commentcount != value)
                {
                    this.m_commentcount = value;
                }
                commentcount_initialized = true;
            }
        }
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string CommentPId
        {
            get { return this.m_commentpid; }
            set //
            {
                if (!commentpid_initialized || m_commentpid != value)
                {
                    this.m_commentpid = value;
                }
                commentpid_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{HTML}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ������ַ:[CtrlTypeDic-{HTML}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ContentHtml
        {
            get { return this.m_contenthtml; }
            set //
            {
                if (!contenthtml_initialized || m_contenthtml != value)
                {
                    this.m_contenthtml = value;
                }
                contenthtml_initialized = true;
            }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string CreateDate
        {
            get { return this.m_createdate; }
            set //
            {
                if (!createdate_initialized || m_createdate != value)
                {
                    this.m_createdate = value;
                }
                createdate_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ID
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
        
        /// <summary> ����ͼƬ:[CtrlTypeDic-{HTML}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Images
        {
            get { return this.m_images; }
            set //
            {
                if (!images_initialized || m_images != value)
                {
                    this.m_images = value;
                }
                images_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string IsShowBest
        {
            get { return this.m_isshowbest; }
            set //
            {
                if (!isshowbest_initialized || m_isshowbest != value)
                {
                    this.m_isshowbest = value;
                }
                isshowbest_initialized = true;
            }
        }
        
        /// <summary> ��ʦID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TeacherId
        {
            get { return this.m_teacherid; }
            set //
            {
                if (!teacherid_initialized || m_teacherid != value)
                {
                    this.m_teacherid = value;
                }
                teacherid_initialized = true;
            }
        }
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string User_id
        {
            get { return this.m_user_id; }
            set //
            {
                if (!user_id_initialized || m_user_id != value)
                {
                    this.m_user_id = value;
                }
                user_id_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Voice
        {
            get { return this.m_voice; }
            set //
            {
                if (!voice_initialized || m_voice != value)
                {
                    this.m_voice = value;
                }
                voice_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>��������ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ArticleId =  new AttributeItem("[St_TArticleComments].[ArticleId]", typeof(string), 50, default(string));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CommentCount =  new AttributeItem("[St_TArticleComments].[CommentCount]", typeof(string), 50, default(string));
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CommentPId =  new AttributeItem("[St_TArticleComments].[CommentPId]", typeof(string), 50, default(string));
            
            /// <summary>��������:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem Content =  new AttributeItem("[St_TArticleComments].[Content]", typeof(string), 2000, default(string));
            
            /// <summary>������ַ:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem ContentHtml =  new AttributeItem("[St_TArticleComments].[ContentHtml]", typeof(string), 2000, default(string));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CreateDate =  new AttributeItem("[St_TArticleComments].[CreateDate]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ID =  new AttributeItem("[St_TArticleComments].[ID]", typeof(int), 4, default(int));
            
            /// <summary>����ͼƬ:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem Images =  new AttributeItem("[St_TArticleComments].[Images]", typeof(string), 2000, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IsShowBest =  new AttributeItem("[St_TArticleComments].[IsShowBest]", typeof(string), 50, default(string));
            
            /// <summary>��ʦID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeacherId =  new AttributeItem("[St_TArticleComments].[TeacherId]", typeof(string), 50, default(string));
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[St_TArticleComments].[User_id]", typeof(string), 50, default(string));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Voice =  new AttributeItem("[St_TArticleComments].[Voice]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_articleid;
        /// <summary></summary>
        protected bool articleid_initialized = false;
        
        private string m_commentcount;
        /// <summary></summary>
        protected bool commentcount_initialized = false;
        
        private string m_commentpid;
        /// <summary></summary>
        protected bool commentpid_initialized = false;
        
        private string m_content;
        /// <summary></summary>
        protected bool content_initialized = false;
        
        private string m_contenthtml;
        /// <summary></summary>
        protected bool contenthtml_initialized = false;
        
        private string m_createdate;
        /// <summary></summary>
        protected bool createdate_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_images;
        /// <summary></summary>
        protected bool images_initialized = false;
        
        private string m_isshowbest;
        /// <summary></summary>
        protected bool isshowbest_initialized = false;
        
        private string m_teacherid;
        /// <summary></summary>
        protected bool teacherid_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_voice;
        /// <summary></summary>
        protected bool voice_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TArticleComments";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.articleid_initialized = IsLoadAllAttributes;this.commentcount_initialized = IsLoadAllAttributes;this.commentpid_initialized = IsLoadAllAttributes;this.content_initialized = IsLoadAllAttributes;this.contenthtml_initialized = IsLoadAllAttributes;this.createdate_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.images_initialized = IsLoadAllAttributes;this.isshowbest_initialized = IsLoadAllAttributes;this.teacherid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.voice_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TArticleComments value = new St_TArticleComments();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"ArticleId"))
				value.articleid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CommentCount"))
				value.commentcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CommentPId"))
				value.commentpid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content"))
				value.content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ContentHtml"))
				value.contenthtml_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateDate"))
				value.createdate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ID"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Images"))
				value.images_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsShowBest"))
				value.isshowbest_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeacherId"))
				value.teacherid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Voice"))
				value.voice_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new St_TArticleComments Clone()
        {
            return (St_TArticleComments)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static St_TArticleComments()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public St_TArticleComments() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public St_TArticleComments(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public St_TArticleComments(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public St_TArticleComments(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public St_TArticleComments(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public St_TArticleComments(string articleid1, string commentcount1, string commentpid1, string content1, string contenthtml1, string createdate1, int id1, string images1, string isshowbest1, string teacherid1, string user_id1, string voice1)
        {
            
            this.ArticleId = articleid1;
            
            this.CommentCount = commentcount1;
            
            this.CommentPId = commentpid1;
            
            this.Content = content1;
            
            this.ContentHtml = contenthtml1;
            
            this.CreateDate = createdate1;
            
            this.ID = id1;
            
            this.Images = images1;
            
            this.IsShowBest = isshowbest1;
            
            this.TeacherId = teacherid1;
            
            this.User_id = user_id1;
            
            this.Voice = voice1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static St_TArticleComments FromIView(IView view)
        {
            return (St_TArticleComments)IView.GetITable(view, "St_TArticleComments");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static St_TArticleComments GetOneInstance()
        {
            St_TArticleComments value = new St_TArticleComments();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public St_TArticleComments Retrieve()
        {
            BLLTable<St_TArticleComments>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "ArticleId":
			        return ArticleId;
			    			
			    case "CommentCount":
			        return CommentCount;
			    			
			    case "CommentPId":
			        return CommentPId;
			    			
			    case "Content":
			        return Content;
			    			
			    case "ContentHtml":
			        return ContentHtml;
			    			
			    case "CreateDate":
			        return CreateDate;
			    			
			    case "ID":
			        return ID;
			    			
			    case "Images":
			        return Images;
			    			
			    case "IsShowBest":
			        return IsShowBest;
			    			
			    case "TeacherId":
			        return TeacherId;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Voice":
			        return Voice;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "ArticleId":
			        this.ArticleId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CommentCount":
			        this.CommentCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CommentPId":
			        this.CommentPId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Content":
			        this.Content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ContentHtml":
			        this.ContentHtml = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "CreateDate":
			        this.CreateDate = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ID":
			        this.ID = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Images":
			        this.Images = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsShowBest":
			        this.IsShowBest = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeacherId":
			        this.TeacherId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Voice":
			        this.Voice = Convert.ToString(AttributeValue);
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
				case "ArticleId":
					return articleid_initialized;
				
				case "CommentCount":
					return commentcount_initialized;
				
				case "CommentPId":
					return commentpid_initialized;
				
				case "Content":
					return content_initialized;
				
				case "ContentHtml":
					return contenthtml_initialized;
				
				case "CreateDate":
					return createdate_initialized;
				
				case "ID":
					return id_initialized;
				
				case "Images":
					return images_initialized;
				
				case "IsShowBest":
					return isshowbest_initialized;
				
				case "TeacherId":
					return teacherid_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Voice":
					return voice_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "ArticleId":
					articleid_initialized = ret;
					return true;
				
				case "CommentCount":
					commentcount_initialized = ret;
					return true;
				
				case "CommentPId":
					commentpid_initialized = ret;
					return true;
				
				case "Content":
					content_initialized = ret;
					return true;
				
				case "ContentHtml":
					contenthtml_initialized = ret;
					return true;
				
				case "CreateDate":
					createdate_initialized = ret;
					return true;
				
				case "ID":
					id_initialized = ret;
					return true;
				
				case "Images":
					images_initialized = ret;
					return true;
				
				case "IsShowBest":
					isshowbest_initialized = ret;
					return true;
				
				case "TeacherId":
					teacherid_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Voice":
					voice_initialized = ret;
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

			
			if (articleid_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.ArticleId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ArticleId);
                }
			}
			
			if (commentcount_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.CommentCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CommentCount);
                }
			}
			
			if (commentpid_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.CommentPId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CommentPId);
                }
			}
			
			if (content_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.Content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content);
                }
			}
			
			if (contenthtml_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.ContentHtml;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ContentHtml);
                }
			}
			
			if (createdate_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.CreateDate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateDate);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.ID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ID);
                }
			}
			
			if (images_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.Images;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Images);
                }
			}
			
			if (isshowbest_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.IsShowBest;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsShowBest);
                }
			}
			
			if (teacherid_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.TeacherId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeacherId);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (voice_initialized)
			{
                AttributeItem attr = St_TArticleComments.Attribute.Voice;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Voice);
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
        public class St_TArticleCommentsJson
        {
            
            /// <summary>��������ID:[CtrlTypeDic-{InputString}]</summary>
            public string ArticleId { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string CommentCount { get; set; }
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public string CommentPId { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{HTML}]</summary>
            public string Content { get; set; }
            
            /// <summary>������ַ:[CtrlTypeDic-{HTML}]</summary>
            public string ContentHtml { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public string CreateDate { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int ID { get; set; }
            
            /// <summary>����ͼƬ:[CtrlTypeDic-{HTML}]</summary>
            public string Images { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string IsShowBest { get; set; }
            
            /// <summary>��ʦID:[CtrlTypeDic-{InputString}]</summary>
            public string TeacherId { get; set; }
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string Voice { get; set; }
        }
        #endregion
    }
}
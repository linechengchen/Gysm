/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:31
  Description:    ���ݱ�Xt_discuss_comment��Ӧ��ҵ���߼���Xt_discuss_comment
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_discuss_comment_Entity:Xt_discuss_comment
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Discuss_id,Content,Creatime,Author,Parent_id,User_id,Person_id from Xt_discuss_comment
delete from Xt_discuss_comment
INSERT INTO Xt_discuss_comment (Uuid,Discuss_id,Content,Creatime,Author,Parent_id,User_id,Person_id)
     VALUES
           ('','','','','','','','')
UPDATE Xt_discuss_comment SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Discuss_id = valObj2.Discuss_id;
        valObj.Content = valObj2.Content;
        valObj.Creatime = valObj2.Creatime;
        valObj.Author = valObj2.Author;
        valObj.Parent_id = valObj2.Parent_id;
        valObj.User_id = valObj2.User_id;
        valObj.Person_id = valObj2.Person_id; 
        valObj.Uuid = "";
        valObj.Discuss_id = "";
        valObj.Content = "";
        valObj.Creatime = "";
        valObj.Author = "";
        valObj.Parent_id = "";
        valObj.User_id = "";
        valObj.Person_id = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Discuss_id": $("#txt_Discuss_id").val(),
        "Content": $("#txt_Content").val(),
        "Creatime": $("#txt_Creatime").val(),
        "Author": $("#txt_Author").val(),
        "Parent_id": $("#txt_Parent_id").val(),
        "User_id": $("#txt_User_id").val(),
        "Person_id": $("#txt_Person_id").val(), 
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
    /// <para>���ۻظ���</para>
    /// <para>��Xt_discuss_comment���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_discuss_comment : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_discuss_comment Factory()
        {
            return new Xt_discuss_comment();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Discuss_id
        {            
            get { return this.Discuss_id; }
            set { this.Discuss_id = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Content
        {            
            get { return this.Content; }
            set { this.Content = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Creatime
        {            
            get { return this.Creatime; }
            set { this.Creatime = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Author
        {            
            get { return this.Author; }
            set { this.Author = value; }
        }
        
        /// <summary> ��id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Parent_id
        {            
            get { return this.Parent_id; }
            set { this.Parent_id = value; }
        }
        
        /// <summary> �û�id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> ��id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Person_id
        {            
            get { return this.Person_id; }
            set { this.Person_id = value; }
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
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Discuss_id
        {
            get { return this.m_discuss_id; }
            set //
            {
                if (!discuss_id_initialized || m_discuss_id != value)
                {
                    this.m_discuss_id = value;
                }
                discuss_id_initialized = true;
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
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Creatime
        {
            get { return this.m_creatime; }
            set //
            {
                if (!creatime_initialized || m_creatime != value)
                {
                    this.m_creatime = value;
                }
                creatime_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Author
        {
            get { return this.m_author; }
            set //
            {
                if (!author_initialized || m_author != value)
                {
                    this.m_author = value;
                }
                author_initialized = true;
            }
        }
        
        /// <summary> ��id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Parent_id
        {
            get { return this.m_parent_id; }
            set //
            {
                if (!parent_id_initialized || m_parent_id != value)
                {
                    this.m_parent_id = value;
                }
                parent_id_initialized = true;
            }
        }
        
        /// <summary> �û�id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Person_id
        {
            get { return this.m_person_id; }
            set //
            {
                if (!person_id_initialized || m_person_id != value)
                {
                    this.m_person_id = value;
                }
                person_id_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_discuss_comment].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Discuss_id =  new AttributeItem("[Xt_discuss_comment].[Discuss_id]", typeof(string), 36, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Content =  new AttributeItem("[Xt_discuss_comment].[Content]", typeof(string), 200, default(string));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Creatime =  new AttributeItem("[Xt_discuss_comment].[Creatime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Author =  new AttributeItem("[Xt_discuss_comment].[Author]", typeof(string), 50, default(string));
            
            /// <summary>��id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Parent_id =  new AttributeItem("[Xt_discuss_comment].[Parent_id]", typeof(string), 36, default(string));
            
            /// <summary>�û�id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xt_discuss_comment].[User_id]", typeof(string), 36, default(string));
            
            /// <summary>��id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Person_id =  new AttributeItem("[Xt_discuss_comment].[Person_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_discuss_id;
        /// <summary></summary>
        protected bool discuss_id_initialized = false;
        
        private string m_content;
        /// <summary></summary>
        protected bool content_initialized = false;
        
        private DateTime m_creatime;
        /// <summary></summary>
        protected bool creatime_initialized = false;
        
        private string m_author;
        /// <summary></summary>
        protected bool author_initialized = false;
        
        private string m_parent_id;
        /// <summary></summary>
        protected bool parent_id_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_person_id;
        /// <summary></summary>
        protected bool person_id_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_discuss_comment";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.discuss_id_initialized = IsLoadAllAttributes;this.content_initialized = IsLoadAllAttributes;this.creatime_initialized = IsLoadAllAttributes;this.author_initialized = IsLoadAllAttributes;this.parent_id_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.person_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_discuss_comment value = new Xt_discuss_comment();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Discuss_id"))
				value.discuss_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Content"))
				value.content_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Creatime"))
				value.creatime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Author"))
				value.author_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Parent_id"))
				value.parent_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Person_id"))
				value.person_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_discuss_comment Clone()
        {
            return (Xt_discuss_comment)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_discuss_comment()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_discuss_comment() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_discuss_comment(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_discuss_comment(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_discuss_comment(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_discuss_comment(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_discuss_comment(Guid uuid1, string discuss_id1, string content1, DateTime creatime1, string author1, string parent_id1, string user_id1, string person_id1)
        {
            
            this.Uuid = uuid1;
            
            this.Discuss_id = discuss_id1;
            
            this.Content = content1;
            
            this.Creatime = creatime1;
            
            this.Author = author1;
            
            this.Parent_id = parent_id1;
            
            this.User_id = user_id1;
            
            this.Person_id = person_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_discuss_comment FromIView(IView view)
        {
            return (Xt_discuss_comment)IView.GetITable(view, "Xt_discuss_comment");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_discuss_comment GetOneInstance()
        {
            Xt_discuss_comment value = new Xt_discuss_comment();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_discuss_comment Retrieve()
        {
            BLLTable<Xt_discuss_comment>.GetRowData(this);
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
			    			
			    case "Discuss_id":
			        return Discuss_id;
			    			
			    case "Content":
			        return Content;
			    			
			    case "Creatime":
			        return Creatime;
			    			
			    case "Author":
			        return Author;
			    			
			    case "Parent_id":
			        return Parent_id;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Person_id":
			        return Person_id;
			
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
			    			
			    case "Discuss_id":
			        this.Discuss_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Content":
			        this.Content = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Creatime":
			        this.Creatime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Author":
			        this.Author = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Parent_id":
			        this.Parent_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Person_id":
			        this.Person_id = Convert.ToString(AttributeValue);
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
				
				case "Discuss_id":
					return discuss_id_initialized;
				
				case "Content":
					return content_initialized;
				
				case "Creatime":
					return creatime_initialized;
				
				case "Author":
					return author_initialized;
				
				case "Parent_id":
					return parent_id_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Person_id":
					return person_id_initialized;
				
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
				
				case "Discuss_id":
					discuss_id_initialized = ret;
					return true;
				
				case "Content":
					content_initialized = ret;
					return true;
				
				case "Creatime":
					creatime_initialized = ret;
					return true;
				
				case "Author":
					author_initialized = ret;
					return true;
				
				case "Parent_id":
					parent_id_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Person_id":
					person_id_initialized = ret;
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
                AttributeItem attr = Xt_discuss_comment.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (discuss_id_initialized)
			{
                AttributeItem attr = Xt_discuss_comment.Attribute.Discuss_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Discuss_id);
                }
			}
			
			if (content_initialized)
			{
                AttributeItem attr = Xt_discuss_comment.Attribute.Content;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Content);
                }
			}
			
			if (creatime_initialized)
			{
                AttributeItem attr = Xt_discuss_comment.Attribute.Creatime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Creatime);
                }
			}
			
			if (author_initialized)
			{
                AttributeItem attr = Xt_discuss_comment.Attribute.Author;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Author);
                }
			}
			
			if (parent_id_initialized)
			{
                AttributeItem attr = Xt_discuss_comment.Attribute.Parent_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Parent_id);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xt_discuss_comment.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (person_id_initialized)
			{
                AttributeItem attr = Xt_discuss_comment.Attribute.Person_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Person_id);
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
        public class Xt_discuss_commentJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public string Discuss_id { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Content { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Creatime { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Author { get; set; }
            
            /// <summary>��id:[CtrlTypeDic-{InputString}]</summary>
            public string Parent_id { get; set; }
            
            /// <summary>�û�id:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>��id:[CtrlTypeDic-{InputString}]</summary>
            public string Person_id { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    ���ݱ�Xt_notice��Ӧ��ҵ���߼���Xt_notice
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_notice_Entity:Xt_notice
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Title,Context,From_user,To_user,Type,Type_name,Notice_ref_id,Create_time,Course_id,Status,Is_deal,Modify_time from Xt_notice
delete from Xt_notice
INSERT INTO Xt_notice (Uuid,Title,Context,From_user,To_user,Type,Type_name,Notice_ref_id,Create_time,Course_id,Status,Is_deal,Modify_time)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE Xt_notice SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Title = valObj2.Title;
        valObj.Context = valObj2.Context;
        valObj.From_user = valObj2.From_user;
        valObj.To_user = valObj2.To_user;
        valObj.Type = valObj2.Type;
        valObj.Type_name = valObj2.Type_name;
        valObj.Notice_ref_id = valObj2.Notice_ref_id;
        valObj.Create_time = valObj2.Create_time;
        valObj.Course_id = valObj2.Course_id;
        valObj.Status = valObj2.Status;
        valObj.Is_deal = valObj2.Is_deal;
        valObj.Modify_time = valObj2.Modify_time; 
        valObj.Uuid = "";
        valObj.Title = "";
        valObj.Context = "";
        valObj.From_user = "";
        valObj.To_user = "";
        valObj.Type = "";
        valObj.Type_name = "";
        valObj.Notice_ref_id = "";
        valObj.Create_time = "";
        valObj.Course_id = "";
        valObj.Status = "";
        valObj.Is_deal = "";
        valObj.Modify_time = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Title": $("#txt_Title").val(),
        "Context": $("#txt_Context").val(),
        "From_user": $("#txt_From_user").val(),
        "To_user": $("#txt_To_user").val(),
        "Type": $("#txt_Type").val(),
        "Type_name": $("#txt_Type_name").val(),
        "Notice_ref_id": $("#txt_Notice_ref_id").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Status": $("#txt_Status").val(),
        "Is_deal": $("#txt_Is_deal").val(),
        "Modify_time": $("#txt_Modify_time").val(), 
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
    /// <para>��Ϣ</para>
    /// <para>��Xt_notice���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_notice : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_notice Factory()
        {
            return new Xt_notice();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Context
        {            
            get { return this.Context; }
            set { this.Context = value; }
        }
        
        /// <summary> �����ĸ��û�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _From_user
        {            
            get { return this.From_user; }
            set { this.From_user = value; }
        }
        
        /// <summary> ���ĸ��û�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _To_user
        {            
            get { return this.To_user; }
            set { this.To_user = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type_name
        {            
            get { return this.Type_name; }
            set { this.Type_name = value; }
        }
        
        /// <summary> ֪ͨ����ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Notice_ref_id
        {            
            get { return this.Notice_ref_id; }
            set { this.Notice_ref_id = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> �༶id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> ״̬����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> �Ƿ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_deal
        {            
            get { return this.Is_deal; }
            set { this.Is_deal = value; }
        }
        
        /// <summary> �޸�ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
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
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Title
        {
            get { return this.m_title; }
            set //
            {
                if (!title_initialized || m_title != value)
                {
                    this.m_title = value;
                }
                title_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Context
        {
            get { return this.m_context; }
            set //
            {
                if (!context_initialized || m_context != value)
                {
                    this.m_context = value;
                }
                context_initialized = true;
            }
        }
        
        /// <summary> �����ĸ��û�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string From_user
        {
            get { return this.m_from_user; }
            set //
            {
                if (!from_user_initialized || m_from_user != value)
                {
                    this.m_from_user = value;
                }
                from_user_initialized = true;
            }
        }
        
        /// <summary> ���ĸ��û�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string To_user
        {
            get { return this.m_to_user; }
            set //
            {
                if (!to_user_initialized || m_to_user != value)
                {
                    this.m_to_user = value;
                }
                to_user_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Type
        {
            get { return this.m_type; }
            set //
            {
                if (!type_initialized || m_type != value)
                {
                    this.m_type = value;
                }
                type_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Type_name
        {
            get { return this.m_type_name; }
            set //
            {
                if (!type_name_initialized || m_type_name != value)
                {
                    this.m_type_name = value;
                }
                type_name_initialized = true;
            }
        }
        
        /// <summary> ֪ͨ����ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Notice_ref_id
        {
            get { return this.m_notice_ref_id; }
            set //
            {
                if (!notice_ref_id_initialized || m_notice_ref_id != value)
                {
                    this.m_notice_ref_id = value;
                }
                notice_ref_id_initialized = true;
            }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Create_time
        {
            get { return this.m_create_time; }
            set //
            {
                if (!create_time_initialized || m_create_time != value)
                {
                    this.m_create_time = value;
                }
                create_time_initialized = true;
            }
        }
        
        /// <summary> �༶id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Course_id
        {
            get { return this.m_course_id; }
            set //
            {
                if (!course_id_initialized || m_course_id != value)
                {
                    this.m_course_id = value;
                }
                course_id_initialized = true;
            }
        }
        
        /// <summary> ״̬����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Status
        {
            get { return this.m_status; }
            set //
            {
                if (!status_initialized || m_status != value)
                {
                    this.m_status = value;
                }
                status_initialized = true;
            }
        }
        
        /// <summary> �Ƿ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Is_deal
        {
            get { return this.m_is_deal; }
            set //
            {
                if (!is_deal_initialized || m_is_deal != value)
                {
                    this.m_is_deal = value;
                }
                is_deal_initialized = true;
            }
        }
        
        /// <summary> �޸�ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Modify_time
        {
            get { return this.m_modify_time; }
            set //
            {
                if (!modify_time_initialized || m_modify_time != value)
                {
                    this.m_modify_time = value;
                }
                modify_time_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_notice].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xt_notice].[Title]", typeof(string), 100, default(string));
            
            /// <summary>����:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Context =  new AttributeItem("[Xt_notice].[Context]", typeof(string), 500, default(string));
            
            /// <summary>�����ĸ��û�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem From_user =  new AttributeItem("[Xt_notice].[From_user]", typeof(string), 36, default(string));
            
            /// <summary>���ĸ��û�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem To_user =  new AttributeItem("[Xt_notice].[To_user]", typeof(string), 36, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xt_notice].[Type]", typeof(string), 1, default(string));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type_name =  new AttributeItem("[Xt_notice].[Type_name]", typeof(string), 20, default(string));
            
            /// <summary>֪ͨ����ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Notice_ref_id =  new AttributeItem("[Xt_notice].[Notice_ref_id]", typeof(string), 36, default(string));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_notice].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>�༶id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_notice].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>״̬����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Xt_notice].[Status]", typeof(string), 20, default(string));
            
            /// <summary>�Ƿ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_deal =  new AttributeItem("[Xt_notice].[Is_deal]", typeof(string), 1, default(string));
            
            /// <summary>�޸�ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xt_notice].[Modify_time]", typeof(DateTime), 8, default(DateTime));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private string m_context;
        /// <summary></summary>
        protected bool context_initialized = false;
        
        private string m_from_user;
        /// <summary></summary>
        protected bool from_user_initialized = false;
        
        private string m_to_user;
        /// <summary></summary>
        protected bool to_user_initialized = false;
        
        private string m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        
        private string m_type_name;
        /// <summary></summary>
        protected bool type_name_initialized = false;
        
        private string m_notice_ref_id;
        /// <summary></summary>
        protected bool notice_ref_id_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_is_deal;
        /// <summary></summary>
        protected bool is_deal_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_notice";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.context_initialized = IsLoadAllAttributes;this.from_user_initialized = IsLoadAllAttributes;this.to_user_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;this.type_name_initialized = IsLoadAllAttributes;this.notice_ref_id_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.is_deal_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_notice value = new Xt_notice();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Context"))
				value.context_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"From_user"))
				value.from_user_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"To_user"))
				value.to_user_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type_name"))
				value.type_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Notice_ref_id"))
				value.notice_ref_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_deal"))
				value.is_deal_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_notice Clone()
        {
            return (Xt_notice)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_notice()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_notice() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_notice(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_notice(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_notice(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_notice(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_notice(Guid uuid1, string title1, string context1, string from_user1, string to_user1, string type1, string type_name1, string notice_ref_id1, DateTime create_time1, string course_id1, string status1, string is_deal1, DateTime modify_time1)
        {
            
            this.Uuid = uuid1;
            
            this.Title = title1;
            
            this.Context = context1;
            
            this.From_user = from_user1;
            
            this.To_user = to_user1;
            
            this.Type = type1;
            
            this.Type_name = type_name1;
            
            this.Notice_ref_id = notice_ref_id1;
            
            this.Create_time = create_time1;
            
            this.Course_id = course_id1;
            
            this.Status = status1;
            
            this.Is_deal = is_deal1;
            
            this.Modify_time = modify_time1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_notice FromIView(IView view)
        {
            return (Xt_notice)IView.GetITable(view, "Xt_notice");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_notice GetOneInstance()
        {
            Xt_notice value = new Xt_notice();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_notice Retrieve()
        {
            BLLTable<Xt_notice>.GetRowData(this);
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
			    			
			    case "Title":
			        return Title;
			    			
			    case "Context":
			        return Context;
			    			
			    case "From_user":
			        return From_user;
			    			
			    case "To_user":
			        return To_user;
			    			
			    case "Type":
			        return Type;
			    			
			    case "Type_name":
			        return Type_name;
			    			
			    case "Notice_ref_id":
			        return Notice_ref_id;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Status":
			        return Status;
			    			
			    case "Is_deal":
			        return Is_deal;
			    			
			    case "Modify_time":
			        return Modify_time;
			
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
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Context":
			        this.Context = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "From_user":
			        this.From_user = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "To_user":
			        this.To_user = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type_name":
			        this.Type_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Notice_ref_id":
			        this.Notice_ref_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Status":
			        this.Status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_deal":
			        this.Is_deal = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
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
				
				case "Title":
					return title_initialized;
				
				case "Context":
					return context_initialized;
				
				case "From_user":
					return from_user_initialized;
				
				case "To_user":
					return to_user_initialized;
				
				case "Type":
					return type_initialized;
				
				case "Type_name":
					return type_name_initialized;
				
				case "Notice_ref_id":
					return notice_ref_id_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Status":
					return status_initialized;
				
				case "Is_deal":
					return is_deal_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
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
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Context":
					context_initialized = ret;
					return true;
				
				case "From_user":
					from_user_initialized = ret;
					return true;
				
				case "To_user":
					to_user_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
					return true;
				
				case "Type_name":
					type_name_initialized = ret;
					return true;
				
				case "Notice_ref_id":
					notice_ref_id_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "Is_deal":
					is_deal_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
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
                AttributeItem attr = Xt_notice.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (context_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Context;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Context);
                }
			}
			
			if (from_user_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.From_user;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(From_user);
                }
			}
			
			if (to_user_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.To_user;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(To_user);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
                }
			}
			
			if (type_name_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Type_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type_name);
                }
			}
			
			if (notice_ref_id_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Notice_ref_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Notice_ref_id);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (is_deal_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Is_deal;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_deal);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xt_notice.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
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
        public class Xt_noticeJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{Text}]</summary>
            public string Context { get; set; }
            
            /// <summary>�����ĸ��û�:[CtrlTypeDic-{InputString}]</summary>
            public string From_user { get; set; }
            
            /// <summary>���ĸ��û�:[CtrlTypeDic-{InputString}]</summary>
            public string To_user { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Type { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string Type_name { get; set; }
            
            /// <summary>֪ͨ����ID:[CtrlTypeDic-{InputString}]</summary>
            public string Notice_ref_id { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>�༶id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>״̬����:[CtrlTypeDic-{InputString}]</summary>
            public string Status { get; set; }
            
            /// <summary>�Ƿ���:[CtrlTypeDic-{InputString}]</summary>
            public string Is_deal { get; set; }
            
            /// <summary>�޸�ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Modify_time { get; set; }
        }
        #endregion
    }
}
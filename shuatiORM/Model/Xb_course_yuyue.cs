/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:20
  Description:    ���ݱ�Xb_course_yuyue��Ӧ��ҵ���߼���Xb_course_yuyue
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_course_yuyue_Entity:Xb_course_yuyue
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,ClassHtml,ClassTimerId,ClassTitle,ClassUrl,IsNeedZhiFu,IsYuYue,IsZhiFu,OpenId,TearchId,UserId from Xb_course_yuyue
delete from Xb_course_yuyue
INSERT INTO Xb_course_yuyue (Id,ClassHtml,ClassTimerId,ClassTitle,ClassUrl,IsNeedZhiFu,IsYuYue,IsZhiFu,OpenId,TearchId,UserId)
     VALUES
           ('','','','','','','','','','','')
UPDATE Xb_course_yuyue SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.ClassHtml = valObj2.ClassHtml;
        valObj.ClassTimerId = valObj2.ClassTimerId;
        valObj.ClassTitle = valObj2.ClassTitle;
        valObj.ClassUrl = valObj2.ClassUrl;
        valObj.IsNeedZhiFu = valObj2.IsNeedZhiFu;
        valObj.IsYuYue = valObj2.IsYuYue;
        valObj.IsZhiFu = valObj2.IsZhiFu;
        valObj.OpenId = valObj2.OpenId;
        valObj.TearchId = valObj2.TearchId;
        valObj.UserId = valObj2.UserId; 
        valObj.Id = "";
        valObj.ClassHtml = "";
        valObj.ClassTimerId = "";
        valObj.ClassTitle = "";
        valObj.ClassUrl = "";
        valObj.IsNeedZhiFu = "";
        valObj.IsYuYue = "";
        valObj.IsZhiFu = "";
        valObj.OpenId = "";
        valObj.TearchId = "";
        valObj.UserId = ""; 
        "Id": $("#txt_Id").val(),
        "ClassHtml": $("#txt_ClassHtml").val(),
        "ClassTimerId": $("#txt_ClassTimerId").val(),
        "ClassTitle": $("#txt_ClassTitle").val(),
        "ClassUrl": $("#txt_ClassUrl").val(),
        "IsNeedZhiFu": $("#txt_IsNeedZhiFu").val(),
        "IsYuYue": $("#txt_IsYuYue").val(),
        "IsZhiFu": $("#txt_IsZhiFu").val(),
        "OpenId": $("#txt_OpenId").val(),
        "TearchId": $("#txt_TearchId").val(),
        "UserId": $("#txt_UserId").val(), 
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
    /// <para>�û��ɹ�ԤԼ��:[IDField-{Id:0}]</para>
    /// <para>��Xb_course_yuyue���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_course_yuyue : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_course_yuyue Factory()
        {
            return new Xb_course_yuyue();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �γ�����Html:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassHtml
        {            
            get { return this.ClassHtml; }
            set { this.ClassHtml = value; }
        }
        
        /// <summary> �γ�ʱ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ClassTimerId
        {            
            get { return this.ClassTimerId; }
            set { this.ClassTimerId = value; }
        }
        
        /// <summary> �γ�����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassTitle
        {            
            get { return this.ClassTitle; }
            set { this.ClassTitle = value; }
        }
        
        /// <summary> ��������ⲿ�γ̣����ӵ�ַ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassUrl
        {            
            get { return this.ClassUrl; }
            set { this.ClassUrl = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsNeedZhiFu
        {            
            get { return this.IsNeedZhiFu; }
            set { this.IsNeedZhiFu = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsYuYue
        {            
            get { return this.IsYuYue; }
            set { this.IsYuYue = value; }
        }
        
        /// <summary> �Ƿ�֧��:[Enum-{0:��},{1:��}][CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsZhiFu
        {            
            get { return this.IsZhiFu; }
            set { this.IsZhiFu = value; }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> ��ʦId:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TearchId
        {            
            get { return this.TearchId; }
            set { this.TearchId = value; }
        }
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UserId
        {            
            get { return this.UserId; }
            set { this.UserId = value; }
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
        
        /// <summary> �γ�����Html:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassHtml
        {
            get { return this.m_classhtml; }
            set //
            {
                if (!classhtml_initialized || m_classhtml != value)
                {
                    this.m_classhtml = value;
                }
                classhtml_initialized = true;
            }
        }
        
        /// <summary> �γ�ʱ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ClassTimerId
        {
            get { return this.m_classtimerid; }
            set //
            {
                if (!classtimerid_initialized || m_classtimerid != value)
                {
                    this.m_classtimerid = value;
                }
                classtimerid_initialized = true;
            }
        }
        
        /// <summary> �γ�����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassTitle
        {
            get { return this.m_classtitle; }
            set //
            {
                if (!classtitle_initialized || m_classtitle != value)
                {
                    this.m_classtitle = value;
                }
                classtitle_initialized = true;
            }
        }
        
        /// <summary> ��������ⲿ�γ̣����ӵ�ַ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassUrl
        {
            get { return this.m_classurl; }
            set //
            {
                if (!classurl_initialized || m_classurl != value)
                {
                    this.m_classurl = value;
                }
                classurl_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool IsNeedZhiFu
        {
            get { return this.m_isneedzhifu; }
            set //
            {
                if (!isneedzhifu_initialized || m_isneedzhifu != value)
                {
                    this.m_isneedzhifu = value;
                }
                isneedzhifu_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool IsYuYue
        {
            get { return this.m_isyuyue; }
            set //
            {
                if (!isyuyue_initialized || m_isyuyue != value)
                {
                    this.m_isyuyue = value;
                }
                isyuyue_initialized = true;
            }
        }
        
        /// <summary> �Ƿ�֧��:[Enum-{0:��},{1:��}][CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool IsZhiFu
        {
            get { return this.m_iszhifu; }
            set //
            {
                if (!iszhifu_initialized || m_iszhifu != value)
                {
                    this.m_iszhifu = value;
                }
                iszhifu_initialized = true;
            }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string OpenId
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> ��ʦId:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TearchId
        {
            get { return this.m_tearchid; }
            set //
            {
                if (!tearchid_initialized || m_tearchid != value)
                {
                    this.m_tearchid = value;
                }
                tearchid_initialized = true;
            }
        }
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string UserId
        {
            get { return this.m_userid; }
            set //
            {
                if (!userid_initialized || m_userid != value)
                {
                    this.m_userid = value;
                }
                userid_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_course_yuyue].[Id]", typeof(int), 4, default(int));
            
            /// <summary>�γ�����Html:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassHtml =  new AttributeItem("[Xb_course_yuyue].[ClassHtml]", typeof(string), -1, default(string));
            
            /// <summary>�γ�ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassTimerId =  new AttributeItem("[Xb_course_yuyue].[ClassTimerId]", typeof(int), 4, default(int));
            
            /// <summary>�γ�����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassTitle =  new AttributeItem("[Xb_course_yuyue].[ClassTitle]", typeof(string), 200, default(string));
            
            /// <summary>��������ⲿ�γ̣����ӵ�ַ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassUrl =  new AttributeItem("[Xb_course_yuyue].[ClassUrl]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsNeedZhiFu =  new AttributeItem("[Xb_course_yuyue].[IsNeedZhiFu]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsYuYue =  new AttributeItem("[Xb_course_yuyue].[IsYuYue]", typeof(bool), 1, default(bool));
            
            /// <summary>�Ƿ�֧��:[Enum-{0:��},{1:��}][CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsZhiFu =  new AttributeItem("[Xb_course_yuyue].[IsZhiFu]", typeof(bool), 1, default(bool));
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[Xb_course_yuyue].[OpenId]", typeof(string), 200, default(string));
            
            /// <summary>��ʦId:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TearchId =  new AttributeItem("[Xb_course_yuyue].[TearchId]", typeof(string), 50, default(string));
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UserId =  new AttributeItem("[Xb_course_yuyue].[UserId]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_classhtml;
        /// <summary></summary>
        protected bool classhtml_initialized = false;
        
        private int m_classtimerid;
        /// <summary></summary>
        protected bool classtimerid_initialized = false;
        
        private string m_classtitle;
        /// <summary></summary>
        protected bool classtitle_initialized = false;
        
        private string m_classurl;
        /// <summary></summary>
        protected bool classurl_initialized = false;
        
        private bool m_isneedzhifu;
        /// <summary></summary>
        protected bool isneedzhifu_initialized = false;
        
        private bool m_isyuyue;
        /// <summary></summary>
        protected bool isyuyue_initialized = false;
        
        private bool m_iszhifu;
        /// <summary></summary>
        protected bool iszhifu_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_tearchid;
        /// <summary></summary>
        protected bool tearchid_initialized = false;
        
        private string m_userid;
        /// <summary></summary>
        protected bool userid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_course_yuyue";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.classhtml_initialized = IsLoadAllAttributes;this.classtimerid_initialized = IsLoadAllAttributes;this.classtitle_initialized = IsLoadAllAttributes;this.classurl_initialized = IsLoadAllAttributes;this.isneedzhifu_initialized = IsLoadAllAttributes;this.isyuyue_initialized = IsLoadAllAttributes;this.iszhifu_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.tearchid_initialized = IsLoadAllAttributes;this.userid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_course_yuyue value = new Xb_course_yuyue();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassHtml"))
				value.classhtml_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassTimerId"))
				value.classtimerid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassTitle"))
				value.classtitle_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassUrl"))
				value.classurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsNeedZhiFu"))
				value.isneedzhifu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsYuYue"))
				value.isyuyue_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsZhiFu"))
				value.iszhifu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TearchId"))
				value.tearchid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserId"))
				value.userid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_course_yuyue Clone()
        {
            return (Xb_course_yuyue)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_course_yuyue()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_course_yuyue() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_course_yuyue(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_course_yuyue(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_course_yuyue(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_course_yuyue(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_course_yuyue(int id1, string classhtml1, int classtimerid1, string classtitle1, string classurl1, bool isneedzhifu1, bool isyuyue1, bool iszhifu1, string openid1, string tearchid1, string userid1)
        {
            
            this.Id = id1;
            
            this.ClassHtml = classhtml1;
            
            this.ClassTimerId = classtimerid1;
            
            this.ClassTitle = classtitle1;
            
            this.ClassUrl = classurl1;
            
            this.IsNeedZhiFu = isneedzhifu1;
            
            this.IsYuYue = isyuyue1;
            
            this.IsZhiFu = iszhifu1;
            
            this.OpenId = openid1;
            
            this.TearchId = tearchid1;
            
            this.UserId = userid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_course_yuyue FromIView(IView view)
        {
            return (Xb_course_yuyue)IView.GetITable(view, "Xb_course_yuyue");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_course_yuyue GetOneInstance()
        {
            Xb_course_yuyue value = new Xb_course_yuyue();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_course_yuyue Retrieve()
        {
            BLLTable<Xb_course_yuyue>.GetRowData(this);
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
			    			
			    case "ClassHtml":
			        return ClassHtml;
			    			
			    case "ClassTimerId":
			        return ClassTimerId;
			    			
			    case "ClassTitle":
			        return ClassTitle;
			    			
			    case "ClassUrl":
			        return ClassUrl;
			    			
			    case "IsNeedZhiFu":
			        return IsNeedZhiFu;
			    			
			    case "IsYuYue":
			        return IsYuYue;
			    			
			    case "IsZhiFu":
			        return IsZhiFu;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "TearchId":
			        return TearchId;
			    			
			    case "UserId":
			        return UserId;
			
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
			    			
			    case "ClassHtml":
			        this.ClassHtml = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassTimerId":
			        this.ClassTimerId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ClassTitle":
			        this.ClassTitle = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassUrl":
			        this.ClassUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsNeedZhiFu":
			        this.IsNeedZhiFu = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "IsYuYue":
			        this.IsYuYue = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "IsZhiFu":
			        this.IsZhiFu = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TearchId":
			        this.TearchId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "UserId":
			        this.UserId = Convert.ToString(AttributeValue);
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
				
				case "ClassHtml":
					return classhtml_initialized;
				
				case "ClassTimerId":
					return classtimerid_initialized;
				
				case "ClassTitle":
					return classtitle_initialized;
				
				case "ClassUrl":
					return classurl_initialized;
				
				case "IsNeedZhiFu":
					return isneedzhifu_initialized;
				
				case "IsYuYue":
					return isyuyue_initialized;
				
				case "IsZhiFu":
					return iszhifu_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "TearchId":
					return tearchid_initialized;
				
				case "UserId":
					return userid_initialized;
				
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
				
				case "ClassHtml":
					classhtml_initialized = ret;
					return true;
				
				case "ClassTimerId":
					classtimerid_initialized = ret;
					return true;
				
				case "ClassTitle":
					classtitle_initialized = ret;
					return true;
				
				case "ClassUrl":
					classurl_initialized = ret;
					return true;
				
				case "IsNeedZhiFu":
					isneedzhifu_initialized = ret;
					return true;
				
				case "IsYuYue":
					isyuyue_initialized = ret;
					return true;
				
				case "IsZhiFu":
					iszhifu_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "TearchId":
					tearchid_initialized = ret;
					return true;
				
				case "UserId":
					userid_initialized = ret;
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
                AttributeItem attr = Xb_course_yuyue.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (classhtml_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.ClassHtml;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassHtml);
                }
			}
			
			if (classtimerid_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.ClassTimerId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassTimerId);
                }
			}
			
			if (classtitle_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.ClassTitle;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassTitle);
                }
			}
			
			if (classurl_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.ClassUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassUrl);
                }
			}
			
			if (isneedzhifu_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.IsNeedZhiFu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsNeedZhiFu);
                }
			}
			
			if (isyuyue_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.IsYuYue;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsYuYue);
                }
			}
			
			if (iszhifu_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.IsZhiFu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsZhiFu);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (tearchid_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.TearchId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TearchId);
                }
			}
			
			if (userid_initialized)
			{
                AttributeItem attr = Xb_course_yuyue.Attribute.UserId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserId);
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
        public class Xb_course_yuyueJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>�γ�����Html:[CtrlTypeDic-{InputString}]</summary>
            public string ClassHtml { get; set; }
            
            /// <summary>�γ�ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public int ClassTimerId { get; set; }
            
            /// <summary>�γ�����:[CtrlTypeDic-{InputString}]</summary>
            public string ClassTitle { get; set; }
            
            /// <summary>��������ⲿ�γ̣����ӵ�ַ:[CtrlTypeDic-{InputString}]</summary>
            public string ClassUrl { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsNeedZhiFu { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsYuYue { get; set; }
            
            /// <summary>�Ƿ�֧��:[Enum-{0:��},{1:��}][CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsZhiFu { get; set; }
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>��ʦId:[CtrlTypeDic-{InputString}]</summary>
            public string TearchId { get; set; }
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public string UserId { get; set; }
        }
        #endregion
    }
}
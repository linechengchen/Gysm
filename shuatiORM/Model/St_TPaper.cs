/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/6 19:20:38
  Description:    ���ݱ�St_TPaper��Ӧ��ҵ���߼���St_TPaper
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� St_TPaper_Entity:St_TPaper
 * 
************************************************************/
/************************************************************
SQL���룺
select AutoId,AddTime,ClassId,ClickNum,Id,PaperName,PaperStatus,ProblemCount,RecTf,RightProblemCount,Url from St_TPaper
delete from St_TPaper
INSERT INTO St_TPaper (AutoId,AddTime,ClassId,ClickNum,Id,PaperName,PaperStatus,ProblemCount,RecTf,RightProblemCount,Url)
     VALUES
           ('','','','','','','','','','','')
UPDATE St_TPaper SET ...
������ֵ���룺
 *         valObj.AutoId = valObj2.AutoId;
        valObj.AddTime = valObj2.AddTime;
        valObj.ClassId = valObj2.ClassId;
        valObj.ClickNum = valObj2.ClickNum;
        valObj.Id = valObj2.Id;
        valObj.PaperName = valObj2.PaperName;
        valObj.PaperStatus = valObj2.PaperStatus;
        valObj.ProblemCount = valObj2.ProblemCount;
        valObj.RecTf = valObj2.RecTf;
        valObj.RightProblemCount = valObj2.RightProblemCount;
        valObj.Url = valObj2.Url; 
        valObj.AutoId = "";
        valObj.AddTime = "";
        valObj.ClassId = "";
        valObj.ClickNum = "";
        valObj.Id = "";
        valObj.PaperName = "";
        valObj.PaperStatus = "";
        valObj.ProblemCount = "";
        valObj.RecTf = "";
        valObj.RightProblemCount = "";
        valObj.Url = ""; 
        "AutoId": $("#txt_AutoId").val(),
        "AddTime": $("#txt_AddTime").val(),
        "ClassId": $("#txt_ClassId").val(),
        "ClickNum": $("#txt_ClickNum").val(),
        "Id": $("#txt_Id").val(),
        "PaperName": $("#txt_PaperName").val(),
        "PaperStatus": $("#txt_PaperStatus").val(),
        "ProblemCount": $("#txt_ProblemCount").val(),
        "RecTf": $("#txt_RecTf").val(),
        "RightProblemCount": $("#txt_RightProblemCount").val(),
        "Url": $("#txt_Url").val(), 
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
    /// <para>ֽ��</para>
    /// <para>��St_TPaper���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class St_TPaper : ITableImplement
    {
        /// <summary>��������  </summary>
        public static St_TPaper Factory()
        {
            return new St_TPaper();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> �Զ�ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> ���ʱ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _AddTime
        {            
            get { return this.AddTime; }
            set { this.AddTime = value; }
        }
        
        /// <summary> ��ĿID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassId
        {            
            get { return this.ClassId; }
            set { this.ClassId = value; }
        }
        
        /// <summary> �������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClickNum
        {            
            get { return this.ClickNum; }
            set { this.ClickNum = value; }
        }
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �Ծ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperName
        {            
            get { return this.PaperName; }
            set { this.PaperName = value; }
        }
        
        /// <summary> ����״̬:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PaperStatus
        {            
            get { return this.PaperStatus; }
            set { this.PaperStatus = value; }
        }
        
        /// <summary> ��Ŀ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ProblemCount
        {            
            get { return this.ProblemCount; }
            set { this.ProblemCount = value; }
        }
        
        /// <summary> �Ƿ�ع�:[Enum-{0:��},{1:��}][CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _RecTf
        {            
            get { return this.RecTf; }
            set { this.RecTf = value; }
        }
        
        /// <summary> �ж�������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _RightProblemCount
        {            
            get { return this.RightProblemCount; }
            set { this.RightProblemCount = value; }
        }
        
        /// <summary> ���ӵ�ַ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Url
        {            
            get { return this.Url; }
            set { this.Url = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> �Զ�ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int AutoId
        {
            get { return this.m_autoid; }
            set //private 
            {
                if (!autoid_initialized || m_autoid != value)
                {
                    this.m_autoid = value;
                }
                autoid_initialized = true;
            }
        }
        
        /// <summary> ���ʱ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string AddTime
        {
            get { return this.m_addtime; }
            set //
            {
                if (!addtime_initialized || m_addtime != value)
                {
                    this.m_addtime = value;
                }
                addtime_initialized = true;
            }
        }
        
        /// <summary> ��ĿID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassId
        {
            get { return this.m_classid; }
            set //
            {
                if (!classid_initialized || m_classid != value)
                {
                    this.m_classid = value;
                }
                classid_initialized = true;
            }
        }
        
        /// <summary> �������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClickNum
        {
            get { return this.m_clicknum; }
            set //
            {
                if (!clicknum_initialized || m_clicknum != value)
                {
                    this.m_clicknum = value;
                }
                clicknum_initialized = true;
            }
        }
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Id
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
        
        /// <summary> �Ծ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PaperName
        {
            get { return this.m_papername; }
            set //
            {
                if (!papername_initialized || m_papername != value)
                {
                    this.m_papername = value;
                }
                papername_initialized = true;
            }
        }
        
        /// <summary> ����״̬:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PaperStatus
        {
            get { return this.m_paperstatus; }
            set //
            {
                if (!paperstatus_initialized || m_paperstatus != value)
                {
                    this.m_paperstatus = value;
                }
                paperstatus_initialized = true;
            }
        }
        
        /// <summary> ��Ŀ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ProblemCount
        {
            get { return this.m_problemcount; }
            set //
            {
                if (!problemcount_initialized || m_problemcount != value)
                {
                    this.m_problemcount = value;
                }
                problemcount_initialized = true;
            }
        }
        
        /// <summary> �Ƿ�ع�:[Enum-{0:��},{1:��}][CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string RecTf
        {
            get { return this.m_rectf; }
            set //
            {
                if (!rectf_initialized || m_rectf != value)
                {
                    this.m_rectf = value;
                }
                rectf_initialized = true;
            }
        }
        
        /// <summary> �ж�������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string RightProblemCount
        {
            get { return this.m_rightproblemcount; }
            set //
            {
                if (!rightproblemcount_initialized || m_rightproblemcount != value)
                {
                    this.m_rightproblemcount = value;
                }
                rightproblemcount_initialized = true;
            }
        }
        
        /// <summary> ���ӵ�ַ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Url
        {
            get { return this.m_url; }
            set //
            {
                if (!url_initialized || m_url != value)
                {
                    this.m_url = value;
                }
                url_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>�Զ�ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AutoId =  new AttributeItem("[St_TPaper].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>���ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AddTime =  new AttributeItem("[St_TPaper].[AddTime]", typeof(string), 200, default(string));
            
            /// <summary>��ĿID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassId =  new AttributeItem("[St_TPaper].[ClassId]", typeof(string), 200, default(string));
            
            /// <summary>�������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClickNum =  new AttributeItem("[St_TPaper].[ClickNum]", typeof(string), 200, default(string));
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_TPaper].[Id]", typeof(string), 200, default(string));
            
            /// <summary>�Ծ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperName =  new AttributeItem("[St_TPaper].[PaperName]", typeof(string), 200, default(string));
            
            /// <summary>����״̬:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaperStatus =  new AttributeItem("[St_TPaper].[PaperStatus]", typeof(string), 200, default(string));
            
            /// <summary>��Ŀ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ProblemCount =  new AttributeItem("[St_TPaper].[ProblemCount]", typeof(string), 200, default(string));
            
            /// <summary>�Ƿ�ع�:[Enum-{0:��},{1:��}][CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem RecTf =  new AttributeItem("[St_TPaper].[RecTf]", typeof(string), 200, default(string));
            
            /// <summary>�ж�������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem RightProblemCount =  new AttributeItem("[St_TPaper].[RightProblemCount]", typeof(string), 200, default(string));
            
            /// <summary>���ӵ�ַ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Url =  new AttributeItem("[St_TPaper].[Url]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private string m_addtime;
        /// <summary></summary>
        protected bool addtime_initialized = false;
        
        private string m_classid;
        /// <summary></summary>
        protected bool classid_initialized = false;
        
        private string m_clicknum;
        /// <summary></summary>
        protected bool clicknum_initialized = false;
        
        private string m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_papername;
        /// <summary></summary>
        protected bool papername_initialized = false;
        
        private string m_paperstatus;
        /// <summary></summary>
        protected bool paperstatus_initialized = false;
        
        private string m_problemcount;
        /// <summary></summary>
        protected bool problemcount_initialized = false;
        
        private string m_rectf;
        /// <summary></summary>
        protected bool rectf_initialized = false;
        
        private string m_rightproblemcount;
        /// <summary></summary>
        protected bool rightproblemcount_initialized = false;
        
        private string m_url;
        /// <summary></summary>
        protected bool url_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_TPaper";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.autoid_initialized = IsLoadAllAttributes;this.addtime_initialized = IsLoadAllAttributes;this.classid_initialized = IsLoadAllAttributes;this.clicknum_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.papername_initialized = IsLoadAllAttributes;this.paperstatus_initialized = IsLoadAllAttributes;this.problemcount_initialized = IsLoadAllAttributes;this.rectf_initialized = IsLoadAllAttributes;this.rightproblemcount_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_TPaper value = new St_TPaper();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AddTime"))
				value.addtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassId"))
				value.classid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClickNum"))
				value.clicknum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperName"))
				value.papername_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaperStatus"))
				value.paperstatus_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ProblemCount"))
				value.problemcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RecTf"))
				value.rectf_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"RightProblemCount"))
				value.rightproblemcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Url"))
				value.url_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new St_TPaper Clone()
        {
            return (St_TPaper)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static St_TPaper()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public St_TPaper() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public St_TPaper(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public St_TPaper(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public St_TPaper(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public St_TPaper(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public St_TPaper(int autoid1, string addtime1, string classid1, string clicknum1, string id1, string papername1, string paperstatus1, string problemcount1, string rectf1, string rightproblemcount1, string url1)
        {
            
            this.AutoId = autoid1;
            
            this.AddTime = addtime1;
            
            this.ClassId = classid1;
            
            this.ClickNum = clicknum1;
            
            this.Id = id1;
            
            this.PaperName = papername1;
            
            this.PaperStatus = paperstatus1;
            
            this.ProblemCount = problemcount1;
            
            this.RecTf = rectf1;
            
            this.RightProblemCount = rightproblemcount1;
            
            this.Url = url1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static St_TPaper FromIView(IView view)
        {
            return (St_TPaper)IView.GetITable(view, "St_TPaper");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static St_TPaper GetOneInstance()
        {
            St_TPaper value = new St_TPaper();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public St_TPaper Retrieve()
        {
            BLLTable<St_TPaper>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        return AutoId;
			    			
			    case "AddTime":
			        return AddTime;
			    			
			    case "ClassId":
			        return ClassId;
			    			
			    case "ClickNum":
			        return ClickNum;
			    			
			    case "Id":
			        return Id;
			    			
			    case "PaperName":
			        return PaperName;
			    			
			    case "PaperStatus":
			        return PaperStatus;
			    			
			    case "ProblemCount":
			        return ProblemCount;
			    			
			    case "RecTf":
			        return RecTf;
			    			
			    case "RightProblemCount":
			        return RightProblemCount;
			    			
			    case "Url":
			        return Url;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        this.AutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AddTime":
			        this.AddTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassId":
			        this.ClassId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClickNum":
			        this.ClickNum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperName":
			        this.PaperName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PaperStatus":
			        this.PaperStatus = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ProblemCount":
			        this.ProblemCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "RecTf":
			        this.RecTf = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "RightProblemCount":
			        this.RightProblemCount = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Url":
			        this.Url = Convert.ToString(AttributeValue);
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
				case "AutoId":
					return autoid_initialized;
				
				case "AddTime":
					return addtime_initialized;
				
				case "ClassId":
					return classid_initialized;
				
				case "ClickNum":
					return clicknum_initialized;
				
				case "Id":
					return id_initialized;
				
				case "PaperName":
					return papername_initialized;
				
				case "PaperStatus":
					return paperstatus_initialized;
				
				case "ProblemCount":
					return problemcount_initialized;
				
				case "RecTf":
					return rectf_initialized;
				
				case "RightProblemCount":
					return rightproblemcount_initialized;
				
				case "Url":
					return url_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					autoid_initialized = ret;
					return true;
				
				case "AddTime":
					addtime_initialized = ret;
					return true;
				
				case "ClassId":
					classid_initialized = ret;
					return true;
				
				case "ClickNum":
					clicknum_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "PaperName":
					papername_initialized = ret;
					return true;
				
				case "PaperStatus":
					paperstatus_initialized = ret;
					return true;
				
				case "ProblemCount":
					problemcount_initialized = ret;
					return true;
				
				case "RecTf":
					rectf_initialized = ret;
					return true;
				
				case "RightProblemCount":
					rightproblemcount_initialized = ret;
					return true;
				
				case "Url":
					url_initialized = ret;
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

			
			if (autoid_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (addtime_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.AddTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AddTime);
                }
			}
			
			if (classid_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.ClassId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassId);
                }
			}
			
			if (clicknum_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.ClickNum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClickNum);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (papername_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.PaperName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperName);
                }
			}
			
			if (paperstatus_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.PaperStatus;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaperStatus);
                }
			}
			
			if (problemcount_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.ProblemCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ProblemCount);
                }
			}
			
			if (rectf_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.RecTf;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RecTf);
                }
			}
			
			if (rightproblemcount_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.RightProblemCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(RightProblemCount);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = St_TPaper.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
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
        public class St_TPaperJson
        {
            
            /// <summary>�Զ�ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>���ʱ��:[CtrlTypeDic-{InputString}]</summary>
            public string AddTime { get; set; }
            
            /// <summary>��ĿID:[CtrlTypeDic-{InputString}]</summary>
            public string ClassId { get; set; }
            
            /// <summary>�������:[CtrlTypeDic-{InputString}]</summary>
            public string ClickNum { get; set; }
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public string Id { get; set; }
            
            /// <summary>�Ծ���:[CtrlTypeDic-{InputString}]</summary>
            public string PaperName { get; set; }
            
            /// <summary>����״̬:[CtrlTypeDic-{InputString}]</summary>
            public string PaperStatus { get; set; }
            
            /// <summary>��Ŀ����:[CtrlTypeDic-{InputString}]</summary>
            public string ProblemCount { get; set; }
            
            /// <summary>�Ƿ�ع�:[Enum-{0:��},{1:��}][CtrlTypeDic-{InputString}]</summary>
            public string RecTf { get; set; }
            
            /// <summary>�ж�������:[CtrlTypeDic-{InputString}]</summary>
            public string RightProblemCount { get; set; }
            
            /// <summary>���ӵ�ַ:[CtrlTypeDic-{InputString}]</summary>
            public string Url { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    ���ݱ�TggInfo��Ӧ��ҵ���߼���TggInfo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TggInfo_Entity:TggInfo
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,GgSourceUrl,GgName,GgImage,GgUrl,Sc,KemuId,ZsId,ZsTypeId,GgShowCount,GgShowMax,GgOnePay,GgSumPay from TggInfo
delete from TggInfo
INSERT INTO TggInfo (Id,GgSourceUrl,GgName,GgImage,GgUrl,Sc,KemuId,ZsId,ZsTypeId,GgShowCount,GgShowMax,GgOnePay,GgSumPay)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE TggInfo SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.GgSourceUrl = valObj2.GgSourceUrl;
        valObj.GgName = valObj2.GgName;
        valObj.GgImage = valObj2.GgImage;
        valObj.GgUrl = valObj2.GgUrl;
        valObj.Sc = valObj2.Sc;
        valObj.KemuId = valObj2.KemuId;
        valObj.ZsId = valObj2.ZsId;
        valObj.ZsTypeId = valObj2.ZsTypeId;
        valObj.GgShowCount = valObj2.GgShowCount;
        valObj.GgShowMax = valObj2.GgShowMax;
        valObj.GgOnePay = valObj2.GgOnePay;
        valObj.GgSumPay = valObj2.GgSumPay; 
        valObj.Id = "";
        valObj.GgSourceUrl = "";
        valObj.GgName = "";
        valObj.GgImage = "";
        valObj.GgUrl = "";
        valObj.Sc = "";
        valObj.KemuId = "";
        valObj.ZsId = "";
        valObj.ZsTypeId = "";
        valObj.GgShowCount = "";
        valObj.GgShowMax = "";
        valObj.GgOnePay = "";
        valObj.GgSumPay = ""; 
        "Id": $("#txt_Id").val(),
        "GgSourceUrl": $("#txt_GgSourceUrl").val(),
        "GgName": $("#txt_GgName").val(),
        "GgImage": $("#txt_GgImage").val(),
        "GgUrl": $("#txt_GgUrl").val(),
        "Sc": $("#txt_Sc").val(),
        "KemuId": $("#txt_KemuId").val(),
        "ZsId": $("#txt_ZsId").val(),
        "ZsTypeId": $("#txt_ZsTypeId").val(),
        "GgShowCount": $("#txt_GgShowCount").val(),
        "GgShowMax": $("#txt_GgShowMax").val(),
        "GgOnePay": $("#txt_GgOnePay").val(),
        "GgSumPay": $("#txt_GgSumPay").val(), 
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
    /// <para>�����Ϣ:[IDField-{Id:0}]</para>
    /// <para>��TggInfo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TggInfo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TggInfo Factory()
        {
            return new TggInfo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ���ƥ��ԴUrl:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GgSourceUrl
        {            
            get { return this.GgSourceUrl; }
            set { this.GgSourceUrl = value; }
        }
        
        /// <summary> �����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GgName
        {            
            get { return this.GgName; }
            set { this.GgName = value; }
        }
        
        /// <summary> ���ͼƬ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GgImage
        {            
            get { return this.GgImage; }
            set { this.GgImage = value; }
        }
        
        /// <summary> �������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GgUrl
        {            
            get { return this.GgUrl; }
            set { this.GgUrl = value; }
        }
        
        /// <summary> Դ��ѧУ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> ��ĿId:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> ֤��Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsId
        {            
            get { return this.ZsId; }
            set { this.ZsId = value; }
        }
        
        /// <summary> ֤������Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ZsTypeId
        {            
            get { return this.ZsTypeId; }
            set { this.ZsTypeId = value; }
        }
        
        /// <summary> �����ʾ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _GgShowCount
        {            
            get { return this.GgShowCount; }
            set { this.GgShowCount = value; }
        }
        
        /// <summary> �����ʾ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _GgShowMax
        {            
            get { return this.GgShowMax; }
            set { this.GgShowMax = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _GgOnePay
        {            
            get { return this.GgOnePay; }
            set { this.GgOnePay = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _GgSumPay
        {            
            get { return this.GgSumPay; }
            set { this.GgSumPay = value; }
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
        
        /// <summary> ���ƥ��ԴUrl:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string GgSourceUrl
        {
            get { return this.m_ggsourceurl; }
            set //
            {
                if (!ggsourceurl_initialized || m_ggsourceurl != value)
                {
                    this.m_ggsourceurl = value;
                }
                ggsourceurl_initialized = true;
            }
        }
        
        /// <summary> �����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string GgName
        {
            get { return this.m_ggname; }
            set //
            {
                if (!ggname_initialized || m_ggname != value)
                {
                    this.m_ggname = value;
                }
                ggname_initialized = true;
            }
        }
        
        /// <summary> ���ͼƬ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string GgImage
        {
            get { return this.m_ggimage; }
            set //
            {
                if (!ggimage_initialized || m_ggimage != value)
                {
                    this.m_ggimage = value;
                }
                ggimage_initialized = true;
            }
        }
        
        /// <summary> �������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string GgUrl
        {
            get { return this.m_ggurl; }
            set //
            {
                if (!ggurl_initialized || m_ggurl != value)
                {
                    this.m_ggurl = value;
                }
                ggurl_initialized = true;
            }
        }
        
        /// <summary> Դ��ѧУ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sc
        {
            get { return this.m_sc; }
            set //
            {
                if (!sc_initialized || m_sc != value)
                {
                    this.m_sc = value;
                }
                sc_initialized = true;
            }
        }
        
        /// <summary> ��ĿId:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string KemuId
        {
            get { return this.m_kemuid; }
            set //
            {
                if (!kemuid_initialized || m_kemuid != value)
                {
                    this.m_kemuid = value;
                }
                kemuid_initialized = true;
            }
        }
        
        /// <summary> ֤��Id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ZsId
        {
            get { return this.m_zsid; }
            set //
            {
                if (!zsid_initialized || m_zsid != value)
                {
                    this.m_zsid = value;
                }
                zsid_initialized = true;
            }
        }
        
        /// <summary> ֤������Id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ZsTypeId
        {
            get { return this.m_zstypeid; }
            set //
            {
                if (!zstypeid_initialized || m_zstypeid != value)
                {
                    this.m_zstypeid = value;
                }
                zstypeid_initialized = true;
            }
        }
        
        /// <summary> �����ʾ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int GgShowCount
        {
            get { return this.m_ggshowcount; }
            set //
            {
                if (!ggshowcount_initialized || m_ggshowcount != value)
                {
                    this.m_ggshowcount = value;
                }
                ggshowcount_initialized = true;
            }
        }
        
        /// <summary> �����ʾ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int GgShowMax
        {
            get { return this.m_ggshowmax; }
            set //
            {
                if (!ggshowmax_initialized || m_ggshowmax != value)
                {
                    this.m_ggshowmax = value;
                }
                ggshowmax_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public double GgOnePay
        {
            get { return this.m_ggonepay; }
            set //
            {
                if (!ggonepay_initialized || m_ggonepay != value)
                {
                    this.m_ggonepay = value;
                }
                ggonepay_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public double GgSumPay
        {
            get { return this.m_ggsumpay; }
            set //
            {
                if (!ggsumpay_initialized || m_ggsumpay != value)
                {
                    this.m_ggsumpay = value;
                }
                ggsumpay_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TggInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>���ƥ��ԴUrl:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgSourceUrl =  new AttributeItem("[TggInfo].[GgSourceUrl]", typeof(string), 200, default(string));
            
            /// <summary>�����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgName =  new AttributeItem("[TggInfo].[GgName]", typeof(string), 50, default(string));
            
            /// <summary>���ͼƬ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgImage =  new AttributeItem("[TggInfo].[GgImage]", typeof(string), 50, default(string));
            
            /// <summary>�������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgUrl =  new AttributeItem("[TggInfo].[GgUrl]", typeof(string), 200, default(string));
            
            /// <summary>Դ��ѧУ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[TggInfo].[Sc]", typeof(string), 50, default(string));
            
            /// <summary>��ĿId:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[TggInfo].[KemuId]", typeof(string), 50, default(string));
            
            /// <summary>֤��Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsId =  new AttributeItem("[TggInfo].[ZsId]", typeof(string), 50, default(string));
            
            /// <summary>֤������Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsTypeId =  new AttributeItem("[TggInfo].[ZsTypeId]", typeof(string), 50, default(string));
            
            /// <summary>�����ʾ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgShowCount =  new AttributeItem("[TggInfo].[GgShowCount]", typeof(int), 4, default(int));
            
            /// <summary>�����ʾ������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgShowMax =  new AttributeItem("[TggInfo].[GgShowMax]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgOnePay =  new AttributeItem("[TggInfo].[GgOnePay]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GgSumPay =  new AttributeItem("[TggInfo].[GgSumPay]", typeof(double), 8, default(double));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_ggsourceurl;
        /// <summary></summary>
        protected bool ggsourceurl_initialized = false;
        
        private string m_ggname;
        /// <summary></summary>
        protected bool ggname_initialized = false;
        
        private string m_ggimage;
        /// <summary></summary>
        protected bool ggimage_initialized = false;
        
        private string m_ggurl;
        /// <summary></summary>
        protected bool ggurl_initialized = false;
        
        private string m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private string m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_zsid;
        /// <summary></summary>
        protected bool zsid_initialized = false;
        
        private string m_zstypeid;
        /// <summary></summary>
        protected bool zstypeid_initialized = false;
        
        private int m_ggshowcount;
        /// <summary></summary>
        protected bool ggshowcount_initialized = false;
        
        private int m_ggshowmax;
        /// <summary></summary>
        protected bool ggshowmax_initialized = false;
        
        private double m_ggonepay;
        /// <summary></summary>
        protected bool ggonepay_initialized = false;
        
        private double m_ggsumpay;
        /// <summary></summary>
        protected bool ggsumpay_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TggInfo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.ggsourceurl_initialized = IsLoadAllAttributes;this.ggname_initialized = IsLoadAllAttributes;this.ggimage_initialized = IsLoadAllAttributes;this.ggurl_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.zsid_initialized = IsLoadAllAttributes;this.zstypeid_initialized = IsLoadAllAttributes;this.ggshowcount_initialized = IsLoadAllAttributes;this.ggshowmax_initialized = IsLoadAllAttributes;this.ggonepay_initialized = IsLoadAllAttributes;this.ggsumpay_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TggInfo value = new TggInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgSourceUrl"))
				value.ggsourceurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgName"))
				value.ggname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgImage"))
				value.ggimage_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgUrl"))
				value.ggurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsId"))
				value.zsid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsTypeId"))
				value.zstypeid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgShowCount"))
				value.ggshowcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgShowMax"))
				value.ggshowmax_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgOnePay"))
				value.ggonepay_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GgSumPay"))
				value.ggsumpay_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TggInfo Clone()
        {
            return (TggInfo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TggInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TggInfo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TggInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TggInfo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TggInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TggInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TggInfo(int id1, string ggsourceurl1, string ggname1, string ggimage1, string ggurl1, string sc1, string kemuid1, string zsid1, string zstypeid1, int ggshowcount1, int ggshowmax1, double ggonepay1, double ggsumpay1)
        {
            
            this.Id = id1;
            
            this.GgSourceUrl = ggsourceurl1;
            
            this.GgName = ggname1;
            
            this.GgImage = ggimage1;
            
            this.GgUrl = ggurl1;
            
            this.Sc = sc1;
            
            this.KemuId = kemuid1;
            
            this.ZsId = zsid1;
            
            this.ZsTypeId = zstypeid1;
            
            this.GgShowCount = ggshowcount1;
            
            this.GgShowMax = ggshowmax1;
            
            this.GgOnePay = ggonepay1;
            
            this.GgSumPay = ggsumpay1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TggInfo FromIView(IView view)
        {
            return (TggInfo)IView.GetITable(view, "TggInfo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TggInfo GetOneInstance()
        {
            TggInfo value = new TggInfo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TggInfo Retrieve()
        {
            BLLTable<TggInfo>.GetRowData(this);
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
			    			
			    case "GgSourceUrl":
			        return GgSourceUrl;
			    			
			    case "GgName":
			        return GgName;
			    			
			    case "GgImage":
			        return GgImage;
			    			
			    case "GgUrl":
			        return GgUrl;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "ZsId":
			        return ZsId;
			    			
			    case "ZsTypeId":
			        return ZsTypeId;
			    			
			    case "GgShowCount":
			        return GgShowCount;
			    			
			    case "GgShowMax":
			        return GgShowMax;
			    			
			    case "GgOnePay":
			        return GgOnePay;
			    			
			    case "GgSumPay":
			        return GgSumPay;
			
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
			    			
			    case "GgSourceUrl":
			        this.GgSourceUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GgName":
			        this.GgName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GgImage":
			        this.GgImage = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GgUrl":
			        this.GgUrl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsId":
			        this.ZsId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsTypeId":
			        this.ZsTypeId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GgShowCount":
			        this.GgShowCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "GgShowMax":
			        this.GgShowMax = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "GgOnePay":
			        this.GgOnePay = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "GgSumPay":
			        this.GgSumPay = Convert.ToDouble(AttributeValue);
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
				
				case "GgSourceUrl":
					return ggsourceurl_initialized;
				
				case "GgName":
					return ggname_initialized;
				
				case "GgImage":
					return ggimage_initialized;
				
				case "GgUrl":
					return ggurl_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "ZsId":
					return zsid_initialized;
				
				case "ZsTypeId":
					return zstypeid_initialized;
				
				case "GgShowCount":
					return ggshowcount_initialized;
				
				case "GgShowMax":
					return ggshowmax_initialized;
				
				case "GgOnePay":
					return ggonepay_initialized;
				
				case "GgSumPay":
					return ggsumpay_initialized;
				
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
				
				case "GgSourceUrl":
					ggsourceurl_initialized = ret;
					return true;
				
				case "GgName":
					ggname_initialized = ret;
					return true;
				
				case "GgImage":
					ggimage_initialized = ret;
					return true;
				
				case "GgUrl":
					ggurl_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "ZsId":
					zsid_initialized = ret;
					return true;
				
				case "ZsTypeId":
					zstypeid_initialized = ret;
					return true;
				
				case "GgShowCount":
					ggshowcount_initialized = ret;
					return true;
				
				case "GgShowMax":
					ggshowmax_initialized = ret;
					return true;
				
				case "GgOnePay":
					ggonepay_initialized = ret;
					return true;
				
				case "GgSumPay":
					ggsumpay_initialized = ret;
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
                AttributeItem attr = TggInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (ggsourceurl_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgSourceUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgSourceUrl);
                }
			}
			
			if (ggname_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgName);
                }
			}
			
			if (ggimage_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgImage;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgImage);
                }
			}
			
			if (ggurl_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgUrl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgUrl);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (zsid_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.ZsId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsId);
                }
			}
			
			if (zstypeid_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.ZsTypeId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsTypeId);
                }
			}
			
			if (ggshowcount_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgShowCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgShowCount);
                }
			}
			
			if (ggshowmax_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgShowMax;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgShowMax);
                }
			}
			
			if (ggonepay_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgOnePay;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgOnePay);
                }
			}
			
			if (ggsumpay_initialized)
			{
                AttributeItem attr = TggInfo.Attribute.GgSumPay;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GgSumPay);
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
        public class TggInfoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>���ƥ��ԴUrl:[CtrlTypeDic-{InputString}]</summary>
            public string GgSourceUrl { get; set; }
            
            /// <summary>�����:[CtrlTypeDic-{InputString}]</summary>
            public string GgName { get; set; }
            
            /// <summary>���ͼƬ:[CtrlTypeDic-{InputString}]</summary>
            public string GgImage { get; set; }
            
            /// <summary>�������:[CtrlTypeDic-{InputString}]</summary>
            public string GgUrl { get; set; }
            
            /// <summary>Դ��ѧУ��:[CtrlTypeDic-{InputString}]</summary>
            public string Sc { get; set; }
            
            /// <summary>��ĿId:[CtrlTypeDic-{InputString}]</summary>
            public string KemuId { get; set; }
            
            /// <summary>֤��Id:[CtrlTypeDic-{InputString}]</summary>
            public string ZsId { get; set; }
            
            /// <summary>֤������Id:[CtrlTypeDic-{InputString}]</summary>
            public string ZsTypeId { get; set; }
            
            /// <summary>�����ʾ����:[CtrlTypeDic-{InputString}]</summary>
            public int GgShowCount { get; set; }
            
            /// <summary>�����ʾ������:[CtrlTypeDic-{InputString}]</summary>
            public int GgShowMax { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double GgOnePay { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double GgSumPay { get; set; }
        }
        #endregion
    }
}
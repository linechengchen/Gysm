/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:21
  Description:    ���ݱ�Jz_shareContentClassifys��Ӧ��ҵ���߼���Jz_shareContentClassifys
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jz_shareContentClassifys_Entity:Jz_shareContentClassifys
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,ShareContentClassifysUuid,ModifyTime,CreateTime,QQShare,QQTalk,SinaWb,WeixinFriend,WeixinTalk,PartJobId,PartJobUuid from Jz_shareContentClassifys
delete from Jz_shareContentClassifys
INSERT INTO Jz_shareContentClassifys (Id,ShareContentClassifysUuid,ModifyTime,CreateTime,QQShare,QQTalk,SinaWb,WeixinFriend,WeixinTalk,PartJobId,PartJobUuid)
     VALUES
           ('','','','','','','','','','','')
UPDATE Jz_shareContentClassifys SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.ShareContentClassifysUuid = valObj2.ShareContentClassifysUuid;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.QQShare = valObj2.QQShare;
        valObj.QQTalk = valObj2.QQTalk;
        valObj.SinaWb = valObj2.SinaWb;
        valObj.WeixinFriend = valObj2.WeixinFriend;
        valObj.WeixinTalk = valObj2.WeixinTalk;
        valObj.PartJobId = valObj2.PartJobId;
        valObj.PartJobUuid = valObj2.PartJobUuid; 
        valObj.Id = "";
        valObj.ShareContentClassifysUuid = "";
        valObj.ModifyTime = "";
        valObj.CreateTime = "";
        valObj.QQShare = "";
        valObj.QQTalk = "";
        valObj.SinaWb = "";
        valObj.WeixinFriend = "";
        valObj.WeixinTalk = "";
        valObj.PartJobId = "";
        valObj.PartJobUuid = ""; 
        "Id": $("#txt_Id").val(),
        "ShareContentClassifysUuid": $("#txt_ShareContentClassifysUuid").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "QQShare": $("#txt_QQShare").val(),
        "QQTalk": $("#txt_QQTalk").val(),
        "SinaWb": $("#txt_SinaWb").val(),
        "WeixinFriend": $("#txt_WeixinFriend").val(),
        "WeixinTalk": $("#txt_WeixinTalk").val(),
        "PartJobId": $("#txt_PartJobId").val(),
        "PartJobUuid": $("#txt_PartJobUuid").val(), 
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
    /// <para>���������</para>
    /// <para>��Jz_shareContentClassifys���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jz_shareContentClassifys : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jz_shareContentClassifys Factory()
        {
            return new Jz_shareContentClassifys();
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
        public Guid _ShareContentClassifysUuid
        {            
            get { return this.ShareContentClassifysUuid; }
            set { this.ShareContentClassifysUuid = value; }
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
        public string _QQShare
        {            
            get { return this.QQShare; }
            set { this.QQShare = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _QQTalk
        {            
            get { return this.QQTalk; }
            set { this.QQTalk = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SinaWb
        {            
            get { return this.SinaWb; }
            set { this.SinaWb = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WeixinFriend
        {            
            get { return this.WeixinFriend; }
            set { this.WeixinFriend = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _WeixinTalk
        {            
            get { return this.WeixinTalk; }
            set { this.WeixinTalk = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PartJobId
        {            
            get { return this.PartJobId; }
            set { this.PartJobId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _PartJobUuid
        {            
            get { return this.PartJobUuid; }
            set { this.PartJobUuid = value; }
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
        public Guid ShareContentClassifysUuid
        {
            get { return this.m_sharecontentclassifysuuid; }
            set //
            {
                if (!sharecontentclassifysuuid_initialized || m_sharecontentclassifysuuid != value)
                {
                    this.m_sharecontentclassifysuuid = value;
                }
                sharecontentclassifysuuid_initialized = true;
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
        public string QQShare
        {
            get { return this.m_qqshare; }
            set //
            {
                if (!qqshare_initialized || m_qqshare != value)
                {
                    this.m_qqshare = value;
                }
                qqshare_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string QQTalk
        {
            get { return this.m_qqtalk; }
            set //
            {
                if (!qqtalk_initialized || m_qqtalk != value)
                {
                    this.m_qqtalk = value;
                }
                qqtalk_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SinaWb
        {
            get { return this.m_sinawb; }
            set //
            {
                if (!sinawb_initialized || m_sinawb != value)
                {
                    this.m_sinawb = value;
                }
                sinawb_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string WeixinFriend
        {
            get { return this.m_weixinfriend; }
            set //
            {
                if (!weixinfriend_initialized || m_weixinfriend != value)
                {
                    this.m_weixinfriend = value;
                }
                weixinfriend_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string WeixinTalk
        {
            get { return this.m_weixintalk; }
            set //
            {
                if (!weixintalk_initialized || m_weixintalk != value)
                {
                    this.m_weixintalk = value;
                }
                weixintalk_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int PartJobId
        {
            get { return this.m_partjobid; }
            set //
            {
                if (!partjobid_initialized || m_partjobid != value)
                {
                    this.m_partjobid = value;
                }
                partjobid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid PartJobUuid
        {
            get { return this.m_partjobuuid; }
            set //
            {
                if (!partjobuuid_initialized || m_partjobuuid != value)
                {
                    this.m_partjobuuid = value;
                }
                partjobuuid_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Jz_shareContentClassifys].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ShareContentClassifysUuid =  new AttributeItem("[Jz_shareContentClassifys].[ShareContentClassifysUuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Jz_shareContentClassifys].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jz_shareContentClassifys].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QQShare =  new AttributeItem("[Jz_shareContentClassifys].[QQShare]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem QQTalk =  new AttributeItem("[Jz_shareContentClassifys].[QQTalk]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SinaWb =  new AttributeItem("[Jz_shareContentClassifys].[SinaWb]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WeixinFriend =  new AttributeItem("[Jz_shareContentClassifys].[WeixinFriend]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem WeixinTalk =  new AttributeItem("[Jz_shareContentClassifys].[WeixinTalk]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobId =  new AttributeItem("[Jz_shareContentClassifys].[PartJobId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobUuid =  new AttributeItem("[Jz_shareContentClassifys].[PartJobUuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_sharecontentclassifysuuid;
        /// <summary></summary>
        protected bool sharecontentclassifysuuid_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_qqshare;
        /// <summary></summary>
        protected bool qqshare_initialized = false;
        
        private string m_qqtalk;
        /// <summary></summary>
        protected bool qqtalk_initialized = false;
        
        private string m_sinawb;
        /// <summary></summary>
        protected bool sinawb_initialized = false;
        
        private string m_weixinfriend;
        /// <summary></summary>
        protected bool weixinfriend_initialized = false;
        
        private string m_weixintalk;
        /// <summary></summary>
        protected bool weixintalk_initialized = false;
        
        private int m_partjobid;
        /// <summary></summary>
        protected bool partjobid_initialized = false;
        
        private Guid m_partjobuuid;
        /// <summary></summary>
        protected bool partjobuuid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_shareContentClassifys";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.sharecontentclassifysuuid_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.qqshare_initialized = IsLoadAllAttributes;this.qqtalk_initialized = IsLoadAllAttributes;this.sinawb_initialized = IsLoadAllAttributes;this.weixinfriend_initialized = IsLoadAllAttributes;this.weixintalk_initialized = IsLoadAllAttributes;this.partjobid_initialized = IsLoadAllAttributes;this.partjobuuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_shareContentClassifys value = new Jz_shareContentClassifys();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShareContentClassifysUuid"))
				value.sharecontentclassifysuuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QQShare"))
				value.qqshare_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"QQTalk"))
				value.qqtalk_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SinaWb"))
				value.sinawb_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WeixinFriend"))
				value.weixinfriend_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"WeixinTalk"))
				value.weixintalk_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobId"))
				value.partjobid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobUuid"))
				value.partjobuuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jz_shareContentClassifys Clone()
        {
            return (Jz_shareContentClassifys)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jz_shareContentClassifys()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jz_shareContentClassifys() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jz_shareContentClassifys(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jz_shareContentClassifys(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jz_shareContentClassifys(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jz_shareContentClassifys(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jz_shareContentClassifys(int id1, Guid sharecontentclassifysuuid1, DateTime modifytime1, DateTime createtime1, string qqshare1, string qqtalk1, string sinawb1, string weixinfriend1, string weixintalk1, int partjobid1, Guid partjobuuid1)
        {
            
            this.Id = id1;
            
            this.ShareContentClassifysUuid = sharecontentclassifysuuid1;
            
            this.ModifyTime = modifytime1;
            
            this.CreateTime = createtime1;
            
            this.QQShare = qqshare1;
            
            this.QQTalk = qqtalk1;
            
            this.SinaWb = sinawb1;
            
            this.WeixinFriend = weixinfriend1;
            
            this.WeixinTalk = weixintalk1;
            
            this.PartJobId = partjobid1;
            
            this.PartJobUuid = partjobuuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jz_shareContentClassifys FromIView(IView view)
        {
            return (Jz_shareContentClassifys)IView.GetITable(view, "Jz_shareContentClassifys");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jz_shareContentClassifys GetOneInstance()
        {
            Jz_shareContentClassifys value = new Jz_shareContentClassifys();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jz_shareContentClassifys Retrieve()
        {
            BLLTable<Jz_shareContentClassifys>.GetRowData(this);
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
			    			
			    case "ShareContentClassifysUuid":
			        return ShareContentClassifysUuid;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "QQShare":
			        return QQShare;
			    			
			    case "QQTalk":
			        return QQTalk;
			    			
			    case "SinaWb":
			        return SinaWb;
			    			
			    case "WeixinFriend":
			        return WeixinFriend;
			    			
			    case "WeixinTalk":
			        return WeixinTalk;
			    			
			    case "PartJobId":
			        return PartJobId;
			    			
			    case "PartJobUuid":
			        return PartJobUuid;
			
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
			    			
			    case "ShareContentClassifysUuid":
			        this.ShareContentClassifysUuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "QQShare":
			        this.QQShare = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "QQTalk":
			        this.QQTalk = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SinaWb":
			        this.SinaWb = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WeixinFriend":
			        this.WeixinFriend = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "WeixinTalk":
			        this.WeixinTalk = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobId":
			        this.PartJobId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "PartJobUuid":
			        this.PartJobUuid = StringHelper.GuidParse(AttributeValue);
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
				
				case "ShareContentClassifysUuid":
					return sharecontentclassifysuuid_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "QQShare":
					return qqshare_initialized;
				
				case "QQTalk":
					return qqtalk_initialized;
				
				case "SinaWb":
					return sinawb_initialized;
				
				case "WeixinFriend":
					return weixinfriend_initialized;
				
				case "WeixinTalk":
					return weixintalk_initialized;
				
				case "PartJobId":
					return partjobid_initialized;
				
				case "PartJobUuid":
					return partjobuuid_initialized;
				
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
				
				case "ShareContentClassifysUuid":
					sharecontentclassifysuuid_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "QQShare":
					qqshare_initialized = ret;
					return true;
				
				case "QQTalk":
					qqtalk_initialized = ret;
					return true;
				
				case "SinaWb":
					sinawb_initialized = ret;
					return true;
				
				case "WeixinFriend":
					weixinfriend_initialized = ret;
					return true;
				
				case "WeixinTalk":
					weixintalk_initialized = ret;
					return true;
				
				case "PartJobId":
					partjobid_initialized = ret;
					return true;
				
				case "PartJobUuid":
					partjobuuid_initialized = ret;
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
                AttributeItem attr = Jz_shareContentClassifys.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (sharecontentclassifysuuid_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.ShareContentClassifysUuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShareContentClassifysUuid);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (qqshare_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.QQShare;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QQShare);
                }
			}
			
			if (qqtalk_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.QQTalk;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(QQTalk);
                }
			}
			
			if (sinawb_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.SinaWb;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SinaWb);
                }
			}
			
			if (weixinfriend_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.WeixinFriend;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WeixinFriend);
                }
			}
			
			if (weixintalk_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.WeixinTalk;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(WeixinTalk);
                }
			}
			
			if (partjobid_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.PartJobId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobId);
                }
			}
			
			if (partjobuuid_initialized)
			{
                AttributeItem attr = Jz_shareContentClassifys.Attribute.PartJobUuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobUuid);
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
        public class Jz_shareContentClassifysJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid ShareContentClassifysUuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string QQShare { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string QQTalk { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string SinaWb { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string WeixinFriend { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string WeixinTalk { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int PartJobId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid PartJobUuid { get; set; }
        }
        #endregion
    }
}
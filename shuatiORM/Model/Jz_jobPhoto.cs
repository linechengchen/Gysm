/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:20
  Description:    ���ݱ�Jz_jobPhoto��Ӧ��ҵ���߼���Jz_jobPhoto
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jz_jobPhoto_Entity:Jz_jobPhoto
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Uuid,CreateTime,BigImage,SmallImage,ModifyTime,User_id,PartJobId,PartJobUuid from Jz_jobPhoto
delete from Jz_jobPhoto
INSERT INTO Jz_jobPhoto (Id,Uuid,CreateTime,BigImage,SmallImage,ModifyTime,User_id,PartJobId,PartJobUuid)
     VALUES
           ('','','','','','','','','')
UPDATE Jz_jobPhoto SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Uuid = valObj2.Uuid;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.BigImage = valObj2.BigImage;
        valObj.SmallImage = valObj2.SmallImage;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.User_id = valObj2.User_id;
        valObj.PartJobId = valObj2.PartJobId;
        valObj.PartJobUuid = valObj2.PartJobUuid; 
        valObj.Id = "";
        valObj.Uuid = "";
        valObj.CreateTime = "";
        valObj.BigImage = "";
        valObj.SmallImage = "";
        valObj.ModifyTime = "";
        valObj.User_id = "";
        valObj.PartJobId = "";
        valObj.PartJobUuid = ""; 
        "Id": $("#txt_Id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "BigImage": $("#txt_BigImage").val(),
        "SmallImage": $("#txt_SmallImage").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "User_id": $("#txt_User_id").val(),
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
    /// <para>����������Ƭ</para>
    /// <para>��Jz_jobPhoto���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jz_jobPhoto : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jz_jobPhoto Factory()
        {
            return new Jz_jobPhoto();
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
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _BigImage
        {            
            get { return this.BigImage; }
            set { this.BigImage = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SmallImage
        {            
            get { return this.SmallImage; }
            set { this.SmallImage = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string BigImage
        {
            get { return this.m_bigimage; }
            set //
            {
                if (!bigimage_initialized || m_bigimage != value)
                {
                    this.m_bigimage = value;
                }
                bigimage_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SmallImage
        {
            get { return this.m_smallimage; }
            set //
            {
                if (!smallimage_initialized || m_smallimage != value)
                {
                    this.m_smallimage = value;
                }
                smallimage_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid User_id
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
            public static AttributeItem Id =  new AttributeItem("[Jz_jobPhoto].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Jz_jobPhoto].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jz_jobPhoto].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BigImage =  new AttributeItem("[Jz_jobPhoto].[BigImage]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SmallImage =  new AttributeItem("[Jz_jobPhoto].[SmallImage]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Jz_jobPhoto].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jz_jobPhoto].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobId =  new AttributeItem("[Jz_jobPhoto].[PartJobId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobUuid =  new AttributeItem("[Jz_jobPhoto].[PartJobUuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_bigimage;
        /// <summary></summary>
        protected bool bigimage_initialized = false;
        
        private string m_smallimage;
        /// <summary></summary>
        protected bool smallimage_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
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
            return "Jz_jobPhoto";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.bigimage_initialized = IsLoadAllAttributes;this.smallimage_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.partjobid_initialized = IsLoadAllAttributes;this.partjobuuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_jobPhoto value = new Jz_jobPhoto();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BigImage"))
				value.bigimage_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SmallImage"))
				value.smallimage_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobId"))
				value.partjobid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobUuid"))
				value.partjobuuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jz_jobPhoto Clone()
        {
            return (Jz_jobPhoto)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jz_jobPhoto()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jz_jobPhoto() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jz_jobPhoto(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jz_jobPhoto(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jz_jobPhoto(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jz_jobPhoto(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jz_jobPhoto(int id1, Guid uuid1, DateTime createtime1, string bigimage1, string smallimage1, DateTime modifytime1, Guid user_id1, int partjobid1, Guid partjobuuid1)
        {
            
            this.Id = id1;
            
            this.Uuid = uuid1;
            
            this.CreateTime = createtime1;
            
            this.BigImage = bigimage1;
            
            this.SmallImage = smallimage1;
            
            this.ModifyTime = modifytime1;
            
            this.User_id = user_id1;
            
            this.PartJobId = partjobid1;
            
            this.PartJobUuid = partjobuuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jz_jobPhoto FromIView(IView view)
        {
            return (Jz_jobPhoto)IView.GetITable(view, "Jz_jobPhoto");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jz_jobPhoto GetOneInstance()
        {
            Jz_jobPhoto value = new Jz_jobPhoto();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jz_jobPhoto Retrieve()
        {
            BLLTable<Jz_jobPhoto>.GetRowData(this);
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
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "BigImage":
			        return BigImage;
			    			
			    case "SmallImage":
			        return SmallImage;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "User_id":
			        return User_id;
			    			
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
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "BigImage":
			        this.BigImage = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SmallImage":
			        this.SmallImage = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
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
				
				case "Uuid":
					return uuid_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "BigImage":
					return bigimage_initialized;
				
				case "SmallImage":
					return smallimage_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "User_id":
					return user_id_initialized;
				
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
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "BigImage":
					bigimage_initialized = ret;
					return true;
				
				case "SmallImage":
					smallimage_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
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
                AttributeItem attr = Jz_jobPhoto.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Jz_jobPhoto.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jz_jobPhoto.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (bigimage_initialized)
			{
                AttributeItem attr = Jz_jobPhoto.Attribute.BigImage;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BigImage);
                }
			}
			
			if (smallimage_initialized)
			{
                AttributeItem attr = Jz_jobPhoto.Attribute.SmallImage;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SmallImage);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Jz_jobPhoto.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jz_jobPhoto.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (partjobid_initialized)
			{
                AttributeItem attr = Jz_jobPhoto.Attribute.PartJobId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobId);
                }
			}
			
			if (partjobuuid_initialized)
			{
                AttributeItem attr = Jz_jobPhoto.Attribute.PartJobUuid;
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
        public class Jz_jobPhotoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string BigImage { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string SmallImage { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int PartJobId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid PartJobUuid { get; set; }
        }
        #endregion
    }
}
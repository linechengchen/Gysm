/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:19
  Description:    ���ݱ�Jz_childrenPartJobClassifications��Ӧ��ҵ���߼���Jz_childrenPartJobClassifications
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jz_childrenPartJobClassifications_Entity:Jz_childrenPartJobClassifications
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Uuid,CreateTime,ClassificationEnum,ClassificationId,ClassificationName,PartJobCount,ParentId,ModifyTime,User_id from Jz_childrenPartJobClassifications
delete from Jz_childrenPartJobClassifications
INSERT INTO Jz_childrenPartJobClassifications (Id,Uuid,CreateTime,ClassificationEnum,ClassificationId,ClassificationName,PartJobCount,ParentId,ModifyTime,User_id)
     VALUES
           ('','','','','','','','','','')
UPDATE Jz_childrenPartJobClassifications SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Uuid = valObj2.Uuid;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ClassificationEnum = valObj2.ClassificationEnum;
        valObj.ClassificationId = valObj2.ClassificationId;
        valObj.ClassificationName = valObj2.ClassificationName;
        valObj.PartJobCount = valObj2.PartJobCount;
        valObj.ParentId = valObj2.ParentId;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.User_id = valObj2.User_id; 
        valObj.Id = "";
        valObj.Uuid = "";
        valObj.CreateTime = "";
        valObj.ClassificationEnum = "";
        valObj.ClassificationId = "";
        valObj.ClassificationName = "";
        valObj.PartJobCount = "";
        valObj.ParentId = "";
        valObj.ModifyTime = "";
        valObj.User_id = ""; 
        "Id": $("#txt_Id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "ClassificationEnum": $("#txt_ClassificationEnum").val(),
        "ClassificationId": $("#txt_ClassificationId").val(),
        "ClassificationName": $("#txt_ClassificationName").val(),
        "PartJobCount": $("#txt_PartJobCount").val(),
        "ParentId": $("#txt_ParentId").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "User_id": $("#txt_User_id").val(), 
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
    /// <para>��ְ����</para>
    /// <para>��Jz_childrenPartJobClassifications���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jz_childrenPartJobClassifications : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jz_childrenPartJobClassifications Factory()
        {
            return new Jz_childrenPartJobClassifications();
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
        
        /// <summary> ����ö��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassificationEnum
        {            
            get { return this.ClassificationEnum; }
            set { this.ClassificationEnum = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute </summary>
        public int _ClassificationId
        {            
            get { return this.ClassificationId; }
            set { this.ClassificationId = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassificationName
        {            
            get { return this.ClassificationName; }
            set { this.ClassificationName = value; }
        }
        
        /// <summary> ���ֹ�����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PartJobCount
        {            
            get { return this.PartJobCount; }
            set { this.PartJobCount = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public int _ParentId
        {            
            get { return this.ParentId; }
            set { this.ParentId = value; }
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
        
        /// <summary> ����ö��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassificationEnum
        {
            get { return this.m_classificationenum; }
            set //
            {
                if (!classificationenum_initialized || m_classificationenum != value)
                {
                    this.m_classificationenum = value;
                }
                classificationenum_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ClassificationId
        {
            get { return this.m_classificationid; }
            set //
            {
                if (!classificationid_initialized || m_classificationid != value)
                {
                    this.m_classificationid = value;
                }
                classificationid_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassificationName
        {
            get { return this.m_classificationname; }
            set //
            {
                if (!classificationname_initialized || m_classificationname != value)
                {
                    this.m_classificationname = value;
                }
                classificationname_initialized = true;
            }
        }
        
        /// <summary> ���ֹ�����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int PartJobCount
        {
            get { return this.m_partjobcount; }
            set //
            {
                if (!partjobcount_initialized || m_partjobcount != value)
                {
                    this.m_partjobcount = value;
                }
                partjobcount_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ParentId
        {
            get { return this.m_parentid; }
            set //
            {
                if (!parentid_initialized || m_parentid != value)
                {
                    this.m_parentid = value;
                }
                parentid_initialized = true;
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Jz_childrenPartJobClassifications].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Jz_childrenPartJobClassifications].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jz_childrenPartJobClassifications].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����ö��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassificationEnum =  new AttributeItem("[Jz_childrenPartJobClassifications].[ClassificationEnum]", typeof(string), 100, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassificationId =  new AttributeItem("[Jz_childrenPartJobClassifications].[ClassificationId]", typeof(int), 4, default(int));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassificationName =  new AttributeItem("[Jz_childrenPartJobClassifications].[ClassificationName]", typeof(string), 100, default(string));
            
            /// <summary>���ֹ�����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PartJobCount =  new AttributeItem("[Jz_childrenPartJobClassifications].[PartJobCount]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ParentId =  new AttributeItem("[Jz_childrenPartJobClassifications].[ParentId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Jz_childrenPartJobClassifications].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jz_childrenPartJobClassifications].[User_id]", typeof(Guid), 16, default(Guid));
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
        
        private string m_classificationenum;
        /// <summary></summary>
        protected bool classificationenum_initialized = false;
        
        private int m_classificationid;
        /// <summary></summary>
        protected bool classificationid_initialized = false;
        
        private string m_classificationname;
        /// <summary></summary>
        protected bool classificationname_initialized = false;
        
        private int m_partjobcount;
        /// <summary></summary>
        protected bool partjobcount_initialized = false;
        
        private int m_parentid;
        /// <summary></summary>
        protected bool parentid_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_childrenPartJobClassifications";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.classificationenum_initialized = IsLoadAllAttributes;this.classificationid_initialized = IsLoadAllAttributes;this.classificationname_initialized = IsLoadAllAttributes;this.partjobcount_initialized = IsLoadAllAttributes;this.parentid_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_childrenPartJobClassifications value = new Jz_childrenPartJobClassifications();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassificationEnum"))
				value.classificationenum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassificationId"))
				value.classificationid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassificationName"))
				value.classificationname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PartJobCount"))
				value.partjobcount_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ParentId"))
				value.parentid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jz_childrenPartJobClassifications Clone()
        {
            return (Jz_childrenPartJobClassifications)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jz_childrenPartJobClassifications()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jz_childrenPartJobClassifications() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jz_childrenPartJobClassifications(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jz_childrenPartJobClassifications(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jz_childrenPartJobClassifications(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jz_childrenPartJobClassifications(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jz_childrenPartJobClassifications(int id1, Guid uuid1, DateTime createtime1, string classificationenum1, int classificationid1, string classificationname1, int partjobcount1, int parentid1, DateTime modifytime1, Guid user_id1)
        {
            
            this.Id = id1;
            
            this.Uuid = uuid1;
            
            this.CreateTime = createtime1;
            
            this.ClassificationEnum = classificationenum1;
            
            this.ClassificationId = classificationid1;
            
            this.ClassificationName = classificationname1;
            
            this.PartJobCount = partjobcount1;
            
            this.ParentId = parentid1;
            
            this.ModifyTime = modifytime1;
            
            this.User_id = user_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jz_childrenPartJobClassifications FromIView(IView view)
        {
            return (Jz_childrenPartJobClassifications)IView.GetITable(view, "Jz_childrenPartJobClassifications");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jz_childrenPartJobClassifications GetOneInstance()
        {
            Jz_childrenPartJobClassifications value = new Jz_childrenPartJobClassifications();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jz_childrenPartJobClassifications Retrieve()
        {
            BLLTable<Jz_childrenPartJobClassifications>.GetRowData(this);
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
			    			
			    case "ClassificationEnum":
			        return ClassificationEnum;
			    			
			    case "ClassificationId":
			        return ClassificationId;
			    			
			    case "ClassificationName":
			        return ClassificationName;
			    			
			    case "PartJobCount":
			        return PartJobCount;
			    			
			    case "ParentId":
			        return ParentId;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "User_id":
			        return User_id;
			
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
			    			
			    case "ClassificationEnum":
			        this.ClassificationEnum = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassificationId":
			        this.ClassificationId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ClassificationName":
			        this.ClassificationName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PartJobCount":
			        this.PartJobCount = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ParentId":
			        this.ParentId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
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
				
				case "ClassificationEnum":
					return classificationenum_initialized;
				
				case "ClassificationId":
					return classificationid_initialized;
				
				case "ClassificationName":
					return classificationname_initialized;
				
				case "PartJobCount":
					return partjobcount_initialized;
				
				case "ParentId":
					return parentid_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "User_id":
					return user_id_initialized;
				
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
				
				case "ClassificationEnum":
					classificationenum_initialized = ret;
					return true;
				
				case "ClassificationId":
					classificationid_initialized = ret;
					return true;
				
				case "ClassificationName":
					classificationname_initialized = ret;
					return true;
				
				case "PartJobCount":
					partjobcount_initialized = ret;
					return true;
				
				case "ParentId":
					parentid_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
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
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (classificationenum_initialized)
			{
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.ClassificationEnum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationEnum);
                }
			}
			
			if (classificationid_initialized)
			{
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.ClassificationId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationId);
                }
			}
			
			if (classificationname_initialized)
			{
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.ClassificationName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationName);
                }
			}
			
			if (partjobcount_initialized)
			{
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.PartJobCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobCount);
                }
			}
			
			if (parentid_initialized)
			{
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.ParentId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ParentId);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jz_childrenPartJobClassifications.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
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
        public class Jz_childrenPartJobClassificationsJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>����ö��:[CtrlTypeDic-{InputString}]</summary>
            public string ClassificationEnum { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public int ClassificationId { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public string ClassificationName { get; set; }
            
            /// <summary>���ֹ�����:[CtrlTypeDic-{InputString}]</summary>
            public int PartJobCount { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int ParentId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:58
  Description:    ���ݱ�V_Jz_childrenPartJobClassifications��Ӧ��ҵ���߼���V_Jz_childrenPartJobClassifications
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� V_Jz_childrenPartJobClassifications_Entity:V_Jz_childrenPartJobClassifications
 * 
************************************************************/
/************************************************************
SQL���룺
select Pname1,Pname2,Id,Uuid,CreateTime,ClassificationEnum,ClassificationId,ClassificationName,PartJobCount,ParentId,ModifyTime,User_id,Root from V_Jz_childrenPartJobClassifications
delete from V_Jz_childrenPartJobClassifications
INSERT INTO V_Jz_childrenPartJobClassifications (Pname1,Pname2,Id,Uuid,CreateTime,ClassificationEnum,ClassificationId,ClassificationName,PartJobCount,ParentId,ModifyTime,User_id,Root)
     VALUES
           ('','','','','','','','','','','','','')
UPDATE V_Jz_childrenPartJobClassifications SET ...
������ֵ���룺
 *         valObj.Pname1 = valObj2.Pname1;
        valObj.Pname2 = valObj2.Pname2;
        valObj.Id = valObj2.Id;
        valObj.Uuid = valObj2.Uuid;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ClassificationEnum = valObj2.ClassificationEnum;
        valObj.ClassificationId = valObj2.ClassificationId;
        valObj.ClassificationName = valObj2.ClassificationName;
        valObj.PartJobCount = valObj2.PartJobCount;
        valObj.ParentId = valObj2.ParentId;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.User_id = valObj2.User_id;
        valObj.Root = valObj2.Root; 
        valObj.Pname1 = "";
        valObj.Pname2 = "";
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
        valObj.Root = ""; 
        "Pname1": $("#txt_Pname1").val(),
        "Pname2": $("#txt_Pname2").val(),
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
        "Root": $("#txt_Root").val(), 
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
    /// <para>��ְ����:[Inner-{Jz_childrenPartJobClassifications:0}]</para>
    /// <para>��V_Jz_childrenPartJobClassifications���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class V_Jz_childrenPartJobClassifications : ITableImplement
    {
        /// <summary>��������  </summary>
        public static V_Jz_childrenPartJobClassifications Factory()
        {
            return new V_Jz_childrenPartJobClassifications();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Pname1
        {            
            get { return this.Pname1; }
            set { this.Pname1 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Pname2
        {            
            get { return this.Pname2; }
            set { this.Pname2 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> ����ö�� Attribute_IsNotNull </summary>
        public string _ClassificationEnum
        {            
            get { return this.ClassificationEnum; }
            set { this.ClassificationEnum = value; }
        }
        
        /// <summary> ���� Attribute_IsNotNull </summary>
        public int _ClassificationId
        {            
            get { return this.ClassificationId; }
            set { this.ClassificationId = value; }
        }
        
        /// <summary> �������� Attribute_IsNotNull </summary>
        public string _ClassificationName
        {            
            get { return this.ClassificationName; }
            set { this.ClassificationName = value; }
        }
        
        /// <summary> ���ֹ����� Attribute_IsNotNull </summary>
        public int _PartJobCount
        {            
            get { return this.PartJobCount; }
            set { this.PartJobCount = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _ParentId
        {            
            get { return this.ParentId; }
            set { this.ParentId = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Root
        {            
            get { return this.Root; }
            set { this.Root = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Pname1
        {
            get { return this.m_pname1; }
            set //
            {
                if (!pname1_initialized || m_pname1 != value)
                {
                    this.m_pname1 = value;
                }
                pname1_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Pname2
        {
            get { return this.m_pname2; }
            set //
            {
                if (!pname2_initialized || m_pname2 != value)
                {
                    this.m_pname2 = value;
                }
                pname2_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Id
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����ö�٣��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���࣬�Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �������ƣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���ֹ��������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Root
        {
            get { return this.m_root; }
            set //
            {
                if (!root_initialized || m_root != value)
                {
                    this.m_root = value;
                }
                root_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary></summary>
            public static AttributeItem Pname1 =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Pname1]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Pname2 =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Pname2]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem CreateTime =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����ö��</summary>
            public static AttributeItem ClassificationEnum =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ClassificationEnum]", typeof(string), 100, default(string));
            
            /// <summary>����</summary>
            public static AttributeItem ClassificationId =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ClassificationId]", typeof(int), 4, default(int));
            
            /// <summary>��������</summary>
            public static AttributeItem ClassificationName =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ClassificationName]", typeof(string), 100, default(string));
            
            /// <summary>���ֹ�����</summary>
            public static AttributeItem PartJobCount =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[PartJobCount]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem ParentId =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ParentId]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Root =  new AttributeItem("[V_Jz_childrenPartJobClassifications].[Root]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_pname1;
        /// <summary></summary>
        protected bool pname1_initialized = false;
        
        private string m_pname2;
        /// <summary></summary>
        protected bool pname2_initialized = false;
        
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
        
        private int m_root;
        /// <summary></summary>
        protected bool root_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_Jz_childrenPartJobClassifications";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.pname1_initialized = IsLoadAllAttributes;this.pname2_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.classificationenum_initialized = IsLoadAllAttributes;this.classificationid_initialized = IsLoadAllAttributes;this.classificationname_initialized = IsLoadAllAttributes;this.partjobcount_initialized = IsLoadAllAttributes;this.parentid_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.root_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_Jz_childrenPartJobClassifications value = new V_Jz_childrenPartJobClassifications();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pname1"))
				value.pname1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pname2"))
				value.pname2_initialized = true;
            
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
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Root"))
				value.root_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new V_Jz_childrenPartJobClassifications Clone()
        {
            return (V_Jz_childrenPartJobClassifications)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static V_Jz_childrenPartJobClassifications()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public V_Jz_childrenPartJobClassifications() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public V_Jz_childrenPartJobClassifications(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public V_Jz_childrenPartJobClassifications(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public V_Jz_childrenPartJobClassifications(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public V_Jz_childrenPartJobClassifications(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public V_Jz_childrenPartJobClassifications(string pname11, string pname21, int id1, Guid uuid1, DateTime createtime1, string classificationenum1, int classificationid1, string classificationname1, int partjobcount1, int parentid1, DateTime modifytime1, Guid user_id1, int root1)
        {
            
            this.Pname1 = pname11;
            
            this.Pname2 = pname21;
            
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
            
            this.Root = root1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static V_Jz_childrenPartJobClassifications FromIView(IView view)
        {
            return (V_Jz_childrenPartJobClassifications)IView.GetITable(view, "V_Jz_childrenPartJobClassifications");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static V_Jz_childrenPartJobClassifications GetOneInstance()
        {
            V_Jz_childrenPartJobClassifications value = new V_Jz_childrenPartJobClassifications();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public V_Jz_childrenPartJobClassifications Retrieve()
        {
            BLLTable<V_Jz_childrenPartJobClassifications>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Pname1":
			        return Pname1;
			    			
			    case "Pname2":
			        return Pname2;
			    			
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
			    			
			    case "Root":
			        return Root;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Pname1":
			        this.Pname1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Pname2":
			        this.Pname2 = Convert.ToString(AttributeValue);
                    return true;
			    			
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
			    			
			    case "Root":
			        this.Root = Convert.ToInt32(AttributeValue);
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
				case "Pname1":
					return pname1_initialized;
				
				case "Pname2":
					return pname2_initialized;
				
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
				
				case "Root":
					return root_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Pname1":
					pname1_initialized = ret;
					return true;
				
				case "Pname2":
					pname2_initialized = ret;
					return true;
				
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
				
				case "Root":
					root_initialized = ret;
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

			
			if (pname1_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Pname1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pname1);
                }
			}
			
			if (pname2_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Pname2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pname2);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (classificationenum_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ClassificationEnum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationEnum);
                }
			}
			
			if (classificationid_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ClassificationId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationId);
                }
			}
			
			if (classificationname_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ClassificationName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassificationName);
                }
			}
			
			if (partjobcount_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.PartJobCount;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PartJobCount);
                }
			}
			
			if (parentid_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ParentId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ParentId);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (root_initialized)
			{
                AttributeItem attr = V_Jz_childrenPartJobClassifications.Attribute.Root;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Root);
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
        public class V_Jz_childrenPartJobClassificationsJson
        {
            
            /// <summary></summary>
            public string Pname1 { get; set; }
            
            /// <summary></summary>
            public string Pname2 { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
            
            /// <summary></summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>����ö��</summary>
            public string ClassificationEnum { get; set; }
            
            /// <summary>����</summary>
            public int ClassificationId { get; set; }
            
            /// <summary>��������</summary>
            public string ClassificationName { get; set; }
            
            /// <summary>���ֹ�����</summary>
            public int PartJobCount { get; set; }
            
            /// <summary></summary>
            public int ParentId { get; set; }
            
            /// <summary></summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary></summary>
            public Guid User_id { get; set; }
            
            /// <summary></summary>
            public int Root { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:23
  Description:    ���ݱ�Xb_student_info��Ӧ��ҵ���߼���Xb_student_info
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_student_info_Entity:Xb_student_info
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,CreateTime,Fff,Head_image,ModifyTime,New_head_image,Nick,Qingqing_user_id,Sex,User_id,User_type,Uuid from Xb_student_info
delete from Xb_student_info
INSERT INTO Xb_student_info (Id,CreateTime,Fff,Head_image,ModifyTime,New_head_image,Nick,Qingqing_user_id,Sex,User_id,User_type,Uuid)
     VALUES
           ('','','','','','','','','','','','')
UPDATE Xb_student_info SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Fff = valObj2.Fff;
        valObj.Head_image = valObj2.Head_image;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.New_head_image = valObj2.New_head_image;
        valObj.Nick = valObj2.Nick;
        valObj.Qingqing_user_id = valObj2.Qingqing_user_id;
        valObj.Sex = valObj2.Sex;
        valObj.User_id = valObj2.User_id;
        valObj.User_type = valObj2.User_type;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.CreateTime = "";
        valObj.Fff = "";
        valObj.Head_image = "";
        valObj.ModifyTime = "";
        valObj.New_head_image = "";
        valObj.Nick = "";
        valObj.Qingqing_user_id = "";
        valObj.Sex = "";
        valObj.User_id = "";
        valObj.User_type = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Fff": $("#txt_Fff").val(),
        "Head_image": $("#txt_Head_image").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "New_head_image": $("#txt_New_head_image").val(),
        "Nick": $("#txt_Nick").val(),
        "Qingqing_user_id": $("#txt_Qingqing_user_id").val(),
        "Sex": $("#txt_Sex").val(),
        "User_id": $("#txt_User_id").val(),
        "User_type": $("#txt_User_type").val(),
        "Uuid": $("#txt_Uuid").val(), 
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
    /// <para></para>
    /// <para>��Xb_student_info���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_student_info : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_student_info Factory()
        {
            return new Xb_student_info();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public double _Fff
        {            
            get { return this.Fff; }
            set { this.Fff = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Head_image
        {            
            get { return this.Head_image; }
            set { this.Head_image = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _New_head_image
        {            
            get { return this.New_head_image; }
            set { this.New_head_image = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Nick
        {            
            get { return this.Nick; }
            set { this.Nick = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Qingqing_user_id
        {            
            get { return this.Qingqing_user_id; }
            set { this.Qingqing_user_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_type
        {            
            get { return this.User_type; }
            set { this.User_type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
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
        public double Fff
        {
            get { return this.m_fff; }
            set //
            {
                if (!fff_initialized || m_fff != value)
                {
                    this.m_fff = value;
                }
                fff_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Head_image
        {
            get { return this.m_head_image; }
            set //
            {
                if (!head_image_initialized || m_head_image != value)
                {
                    this.m_head_image = value;
                }
                head_image_initialized = true;
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
        public string New_head_image
        {
            get { return this.m_new_head_image; }
            set //
            {
                if (!new_head_image_initialized || m_new_head_image != value)
                {
                    this.m_new_head_image = value;
                }
                new_head_image_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Nick
        {
            get { return this.m_nick; }
            set //
            {
                if (!nick_initialized || m_nick != value)
                {
                    this.m_nick = value;
                }
                nick_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Qingqing_user_id
        {
            get { return this.m_qingqing_user_id; }
            set //
            {
                if (!qingqing_user_id_initialized || m_qingqing_user_id != value)
                {
                    this.m_qingqing_user_id = value;
                }
                qingqing_user_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sex
        {
            get { return this.m_sex; }
            set //
            {
                if (!sex_initialized || m_sex != value)
                {
                    this.m_sex = value;
                }
                sex_initialized = true;
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
        public string User_type
        {
            get { return this.m_user_type; }
            set //
            {
                if (!user_type_initialized || m_user_type != value)
                {
                    this.m_user_type = value;
                }
                user_type_initialized = true;
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_student_info].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_student_info].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Fff =  new AttributeItem("[Xb_student_info].[Fff]", typeof(double), 8, default(double));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Head_image =  new AttributeItem("[Xb_student_info].[Head_image]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_student_info].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem New_head_image =  new AttributeItem("[Xb_student_info].[New_head_image]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Nick =  new AttributeItem("[Xb_student_info].[Nick]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Qingqing_user_id =  new AttributeItem("[Xb_student_info].[Qingqing_user_id]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sex =  new AttributeItem("[Xb_student_info].[Sex]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_student_info].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_type =  new AttributeItem("[Xb_student_info].[User_type]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_student_info].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private double m_fff;
        /// <summary></summary>
        protected bool fff_initialized = false;
        
        private string m_head_image;
        /// <summary></summary>
        protected bool head_image_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_new_head_image;
        /// <summary></summary>
        protected bool new_head_image_initialized = false;
        
        private string m_nick;
        /// <summary></summary>
        protected bool nick_initialized = false;
        
        private decimal m_qingqing_user_id;
        /// <summary></summary>
        protected bool qingqing_user_id_initialized = false;
        
        private string m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_user_type;
        /// <summary></summary>
        protected bool user_type_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_student_info";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.fff_initialized = IsLoadAllAttributes;this.head_image_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.new_head_image_initialized = IsLoadAllAttributes;this.nick_initialized = IsLoadAllAttributes;this.qingqing_user_id_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.user_type_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_student_info value = new Xb_student_info();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Fff"))
				value.fff_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Head_image"))
				value.head_image_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"New_head_image"))
				value.new_head_image_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Nick"))
				value.nick_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Qingqing_user_id"))
				value.qingqing_user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_type"))
				value.user_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_student_info Clone()
        {
            return (Xb_student_info)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_student_info()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_student_info() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_student_info(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_student_info(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_student_info(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_student_info(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_student_info(int id1, DateTime createtime1, double fff1, string head_image1, DateTime modifytime1, string new_head_image1, string nick1, decimal qingqing_user_id1, string sex1, Guid user_id1, string user_type1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.CreateTime = createtime1;
            
            this.Fff = fff1;
            
            this.Head_image = head_image1;
            
            this.ModifyTime = modifytime1;
            
            this.New_head_image = new_head_image1;
            
            this.Nick = nick1;
            
            this.Qingqing_user_id = qingqing_user_id1;
            
            this.Sex = sex1;
            
            this.User_id = user_id1;
            
            this.User_type = user_type1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_student_info FromIView(IView view)
        {
            return (Xb_student_info)IView.GetITable(view, "Xb_student_info");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_student_info GetOneInstance()
        {
            Xb_student_info value = new Xb_student_info();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_student_info Retrieve()
        {
            BLLTable<Xb_student_info>.GetRowData(this);
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
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Fff":
			        return Fff;
			    			
			    case "Head_image":
			        return Head_image;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "New_head_image":
			        return New_head_image;
			    			
			    case "Nick":
			        return Nick;
			    			
			    case "Qingqing_user_id":
			        return Qingqing_user_id;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "User_type":
			        return User_type;
			    			
			    case "Uuid":
			        return Uuid;
			
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
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Fff":
			        this.Fff = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Head_image":
			        this.Head_image = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "New_head_image":
			        this.New_head_image = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Nick":
			        this.Nick = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Qingqing_user_id":
			        this.Qingqing_user_id = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "User_type":
			        this.User_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
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
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Fff":
					return fff_initialized;
				
				case "Head_image":
					return head_image_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "New_head_image":
					return new_head_image_initialized;
				
				case "Nick":
					return nick_initialized;
				
				case "Qingqing_user_id":
					return qingqing_user_id_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "User_type":
					return user_type_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
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
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Fff":
					fff_initialized = ret;
					return true;
				
				case "Head_image":
					head_image_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "New_head_image":
					new_head_image_initialized = ret;
					return true;
				
				case "Nick":
					nick_initialized = ret;
					return true;
				
				case "Qingqing_user_id":
					qingqing_user_id_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "User_type":
					user_type_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
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
                AttributeItem attr = Xb_student_info.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (fff_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.Fff;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Fff);
                }
			}
			
			if (head_image_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.Head_image;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Head_image);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (new_head_image_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.New_head_image;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(New_head_image);
                }
			}
			
			if (nick_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.Nick;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Nick);
                }
			}
			
			if (qingqing_user_id_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.Qingqing_user_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Qingqing_user_id);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (user_type_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.User_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_type);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_student_info.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
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
        public class Xb_student_infoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public double Fff { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Head_image { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string New_head_image { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Nick { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal Qingqing_user_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Sex { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string User_type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
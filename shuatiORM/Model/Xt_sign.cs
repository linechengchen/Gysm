/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    ���ݱ�Xt_sign��Ӧ��ҵ���߼���Xt_sign
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_sign_Entity:Xt_sign
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Status,Info,Creator,Course_id,Title,Lng,Lat,City,Address,Checkin_number,Create_time,Finish_status,Finish_time,Sign_count from Xt_sign
delete from Xt_sign
INSERT INTO Xt_sign (Uuid,Status,Info,Creator,Course_id,Title,Lng,Lat,City,Address,Checkin_number,Create_time,Finish_status,Finish_time,Sign_count)
     VALUES
           ('','','','','','','','','','','','','','','')
UPDATE Xt_sign SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Status = valObj2.Status;
        valObj.Info = valObj2.Info;
        valObj.Creator = valObj2.Creator;
        valObj.Course_id = valObj2.Course_id;
        valObj.Title = valObj2.Title;
        valObj.Lng = valObj2.Lng;
        valObj.Lat = valObj2.Lat;
        valObj.City = valObj2.City;
        valObj.Address = valObj2.Address;
        valObj.Checkin_number = valObj2.Checkin_number;
        valObj.Create_time = valObj2.Create_time;
        valObj.Finish_status = valObj2.Finish_status;
        valObj.Finish_time = valObj2.Finish_time;
        valObj.Sign_count = valObj2.Sign_count; 
        valObj.Uuid = "";
        valObj.Status = "";
        valObj.Info = "";
        valObj.Creator = "";
        valObj.Course_id = "";
        valObj.Title = "";
        valObj.Lng = "";
        valObj.Lat = "";
        valObj.City = "";
        valObj.Address = "";
        valObj.Checkin_number = "";
        valObj.Create_time = "";
        valObj.Finish_status = "";
        valObj.Finish_time = "";
        valObj.Sign_count = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Status": $("#txt_Status").val(),
        "Info": $("#txt_Info").val(),
        "Creator": $("#txt_Creator").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Title": $("#txt_Title").val(),
        "Lng": $("#txt_Lng").val(),
        "Lat": $("#txt_Lat").val(),
        "City": $("#txt_City").val(),
        "Address": $("#txt_Address").val(),
        "Checkin_number": $("#txt_Checkin_number").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Finish_status": $("#txt_Finish_status").val(),
        "Finish_time": $("#txt_Finish_time").val(),
        "Sign_count": $("#txt_Sign_count").val(), 
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
    /// <para>ǩ������ʦ�ˣ�</para>
    /// <para>��Xt_sign���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_sign : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_sign Factory()
        {
            return new Xt_sign();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> ״̬:[CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _Status
        {            
            get { return this.Status; }
            set { this.Status = value; }
        }
        
        /// <summary> ��Ϣ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Info
        {            
            get { return this.Info; }
            set { this.Info = value; }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Creator
        {            
            get { return this.Creator; }
            set { this.Creator = value; }
        }
        
        /// <summary> �༶id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Lng
        {            
            get { return this.Lng; }
            set { this.Lng = value; }
        }
        
        /// <summary> γ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Lat
        {            
            get { return this.Lat; }
            set { this.Lat = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> ��ǩ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Checkin_number
        {            
            get { return this.Checkin_number; }
            set { this.Checkin_number = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> ���״̬:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Finish_status
        {            
            get { return this.Finish_status; }
            set { this.Finish_status = value; }
        }
        
        /// <summary> ���ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Finish_time
        {            
            get { return this.Finish_time; }
            set { this.Finish_time = value; }
        }
        
        /// <summary> ��Ҫǩ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Sign_count
        {            
            get { return this.Sign_count; }
            set { this.Sign_count = value; }
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
        
        /// <summary> ״̬:[CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool Status
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
        
        /// <summary> ��Ϣ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Info
        {
            get { return this.m_info; }
            set //
            {
                if (!info_initialized || m_info != value)
                {
                    this.m_info = value;
                }
                info_initialized = true;
            }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Creator
        {
            get { return this.m_creator; }
            set //
            {
                if (!creator_initialized || m_creator != value)
                {
                    this.m_creator = value;
                }
                creator_initialized = true;
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
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Lng
        {
            get { return this.m_lng; }
            set //
            {
                if (!lng_initialized || m_lng != value)
                {
                    this.m_lng = value;
                }
                lng_initialized = true;
            }
        }
        
        /// <summary> γ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Lat
        {
            get { return this.m_lat; }
            set //
            {
                if (!lat_initialized || m_lat != value)
                {
                    this.m_lat = value;
                }
                lat_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string City
        {
            get { return this.m_city; }
            set //
            {
                if (!city_initialized || m_city != value)
                {
                    this.m_city = value;
                }
                city_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Address
        {
            get { return this.m_address; }
            set //
            {
                if (!address_initialized || m_address != value)
                {
                    this.m_address = value;
                }
                address_initialized = true;
            }
        }
        
        /// <summary> ��ǩ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Checkin_number
        {
            get { return this.m_checkin_number; }
            set //
            {
                if (!checkin_number_initialized || m_checkin_number != value)
                {
                    this.m_checkin_number = value;
                }
                checkin_number_initialized = true;
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
        
        /// <summary> ���״̬:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Finish_status
        {
            get { return this.m_finish_status; }
            set //
            {
                if (!finish_status_initialized || m_finish_status != value)
                {
                    this.m_finish_status = value;
                }
                finish_status_initialized = true;
            }
        }
        
        /// <summary> ���ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Finish_time
        {
            get { return this.m_finish_time; }
            set //
            {
                if (!finish_time_initialized || m_finish_time != value)
                {
                    this.m_finish_time = value;
                }
                finish_time_initialized = true;
            }
        }
        
        /// <summary> ��Ҫǩ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Sign_count
        {
            get { return this.m_sign_count; }
            set //
            {
                if (!sign_count_initialized || m_sign_count != value)
                {
                    this.m_sign_count = value;
                }
                sign_count_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_sign].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>״̬:[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Status =  new AttributeItem("[Xt_sign].[Status]", typeof(bool), 1, default(bool));
            
            /// <summary>��Ϣ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Info =  new AttributeItem("[Xt_sign].[Info]", typeof(string), 100, default(string));
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Creator =  new AttributeItem("[Xt_sign].[Creator]", typeof(string), 36, default(string));
            
            /// <summary>�༶id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_sign].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xt_sign].[Title]", typeof(string), 100, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lng =  new AttributeItem("[Xt_sign].[Lng]", typeof(decimal), 18, default(decimal));
            
            /// <summary>γ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Lat =  new AttributeItem("[Xt_sign].[Lat]", typeof(decimal), 18, default(decimal));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[Xt_sign].[City]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Address =  new AttributeItem("[Xt_sign].[Address]", typeof(string), 200, default(string));
            
            /// <summary>��ǩ��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Checkin_number =  new AttributeItem("[Xt_sign].[Checkin_number]", typeof(int), 4, default(int));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_sign].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>���״̬:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Finish_status =  new AttributeItem("[Xt_sign].[Finish_status]", typeof(string), 1, default(string));
            
            /// <summary>���ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Finish_time =  new AttributeItem("[Xt_sign].[Finish_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>��Ҫǩ��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sign_count =  new AttributeItem("[Xt_sign].[Sign_count]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private bool m_status;
        /// <summary></summary>
        protected bool status_initialized = false;
        
        private string m_info;
        /// <summary></summary>
        protected bool info_initialized = false;
        
        private string m_creator;
        /// <summary></summary>
        protected bool creator_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private decimal m_lng;
        /// <summary></summary>
        protected bool lng_initialized = false;
        
        private decimal m_lat;
        /// <summary></summary>
        protected bool lat_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private int m_checkin_number;
        /// <summary></summary>
        protected bool checkin_number_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_finish_status;
        /// <summary></summary>
        protected bool finish_status_initialized = false;
        
        private DateTime m_finish_time;
        /// <summary></summary>
        protected bool finish_time_initialized = false;
        
        private int m_sign_count;
        /// <summary></summary>
        protected bool sign_count_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_sign";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.status_initialized = IsLoadAllAttributes;this.info_initialized = IsLoadAllAttributes;this.creator_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.lng_initialized = IsLoadAllAttributes;this.lat_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.checkin_number_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.finish_status_initialized = IsLoadAllAttributes;this.finish_time_initialized = IsLoadAllAttributes;this.sign_count_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_sign value = new Xt_sign();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Status"))
				value.status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Info"))
				value.info_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Creator"))
				value.creator_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lng"))
				value.lng_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Lat"))
				value.lat_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Checkin_number"))
				value.checkin_number_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Finish_status"))
				value.finish_status_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Finish_time"))
				value.finish_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sign_count"))
				value.sign_count_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_sign Clone()
        {
            return (Xt_sign)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_sign()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_sign() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_sign(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_sign(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_sign(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_sign(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_sign(Guid uuid1, bool status1, string info1, string creator1, string course_id1, string title1, decimal lng1, decimal lat1, string city1, string address1, int checkin_number1, DateTime create_time1, string finish_status1, DateTime finish_time1, int sign_count1)
        {
            
            this.Uuid = uuid1;
            
            this.Status = status1;
            
            this.Info = info1;
            
            this.Creator = creator1;
            
            this.Course_id = course_id1;
            
            this.Title = title1;
            
            this.Lng = lng1;
            
            this.Lat = lat1;
            
            this.City = city1;
            
            this.Address = address1;
            
            this.Checkin_number = checkin_number1;
            
            this.Create_time = create_time1;
            
            this.Finish_status = finish_status1;
            
            this.Finish_time = finish_time1;
            
            this.Sign_count = sign_count1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_sign FromIView(IView view)
        {
            return (Xt_sign)IView.GetITable(view, "Xt_sign");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_sign GetOneInstance()
        {
            Xt_sign value = new Xt_sign();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_sign Retrieve()
        {
            BLLTable<Xt_sign>.GetRowData(this);
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
			    			
			    case "Status":
			        return Status;
			    			
			    case "Info":
			        return Info;
			    			
			    case "Creator":
			        return Creator;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Title":
			        return Title;
			    			
			    case "Lng":
			        return Lng;
			    			
			    case "Lat":
			        return Lat;
			    			
			    case "City":
			        return City;
			    			
			    case "Address":
			        return Address;
			    			
			    case "Checkin_number":
			        return Checkin_number;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Finish_status":
			        return Finish_status;
			    			
			    case "Finish_time":
			        return Finish_time;
			    			
			    case "Sign_count":
			        return Sign_count;
			
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
			    			
			    case "Status":
			        this.Status = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Info":
			        this.Info = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Creator":
			        this.Creator = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Lng":
			        this.Lng = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Lat":
			        this.Lat = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Checkin_number":
			        this.Checkin_number = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Finish_status":
			        this.Finish_status = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Finish_time":
			        this.Finish_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Sign_count":
			        this.Sign_count = Convert.ToInt32(AttributeValue);
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
				
				case "Status":
					return status_initialized;
				
				case "Info":
					return info_initialized;
				
				case "Creator":
					return creator_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Title":
					return title_initialized;
				
				case "Lng":
					return lng_initialized;
				
				case "Lat":
					return lat_initialized;
				
				case "City":
					return city_initialized;
				
				case "Address":
					return address_initialized;
				
				case "Checkin_number":
					return checkin_number_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Finish_status":
					return finish_status_initialized;
				
				case "Finish_time":
					return finish_time_initialized;
				
				case "Sign_count":
					return sign_count_initialized;
				
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
				
				case "Status":
					status_initialized = ret;
					return true;
				
				case "Info":
					info_initialized = ret;
					return true;
				
				case "Creator":
					creator_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Lng":
					lng_initialized = ret;
					return true;
				
				case "Lat":
					lat_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "Checkin_number":
					checkin_number_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Finish_status":
					finish_status_initialized = ret;
					return true;
				
				case "Finish_time":
					finish_time_initialized = ret;
					return true;
				
				case "Sign_count":
					sign_count_initialized = ret;
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
                AttributeItem attr = Xt_sign.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (status_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Status);
                }
			}
			
			if (info_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Info;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Info);
                }
			}
			
			if (creator_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Creator;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Creator);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (lng_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Lng;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lng);
                }
			}
			
			if (lat_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Lat;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Lat);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (checkin_number_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Checkin_number;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Checkin_number);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (finish_status_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Finish_status;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Finish_status);
                }
			}
			
			if (finish_time_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Finish_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Finish_time);
                }
			}
			
			if (sign_count_initialized)
			{
                AttributeItem attr = Xt_sign.Attribute.Sign_count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sign_count);
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
        public class Xt_signJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>״̬:[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Status { get; set; }
            
            /// <summary>��Ϣ:[CtrlTypeDic-{InputString}]</summary>
            public string Info { get; set; }
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public string Creator { get; set; }
            
            /// <summary>�༶id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public decimal Lng { get; set; }
            
            /// <summary>γ��:[CtrlTypeDic-{InputString}]</summary>
            public decimal Lat { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Address { get; set; }
            
            /// <summary>��ǩ��������:[CtrlTypeDic-{InputString}]</summary>
            public int Checkin_number { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>���״̬:[CtrlTypeDic-{InputString}]</summary>
            public string Finish_status { get; set; }
            
            /// <summary>���ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Finish_time { get; set; }
            
            /// <summary>��Ҫǩ��������:[CtrlTypeDic-{InputString}]</summary>
            public int Sign_count { get; set; }
        }
        #endregion
    }
}
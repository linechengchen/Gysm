/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/8/29 23:15:45
  Description:    ���ݱ�V_xb_job_apply��Ӧ��ҵ���߼���V_xb_job_apply
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� V_xb_job_apply_Entity:V_xb_job_apply
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Job_code,Address,Salary,Salary_unit,Teacher_name,College,Create_time,User_id,Job_uuid,Id,_title from V_xb_job_apply
delete from V_xb_job_apply
INSERT INTO V_xb_job_apply (Uuid,Job_code,Address,Salary,Salary_unit,Teacher_name,College,Create_time,User_id,Job_uuid,Id,_title)
     VALUES
           ('','','','','','','','','','','','')
UPDATE V_xb_job_apply SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Job_code = valObj2.Job_code;
        valObj.Address = valObj2.Address;
        valObj.Salary = valObj2.Salary;
        valObj.Salary_unit = valObj2.Salary_unit;
        valObj.Teacher_name = valObj2.Teacher_name;
        valObj.College = valObj2.College;
        valObj.Create_time = valObj2.Create_time;
        valObj.User_id = valObj2.User_id;
        valObj.Job_uuid = valObj2.Job_uuid;
        valObj.Id = valObj2.Id;
        valObj._title = valObj2._title; 
        valObj.Uuid = "";
        valObj.Job_code = "";
        valObj.Address = "";
        valObj.Salary = "";
        valObj.Salary_unit = "";
        valObj.Teacher_name = "";
        valObj.College = "";
        valObj.Create_time = "";
        valObj.User_id = "";
        valObj.Job_uuid = "";
        valObj.Id = "";
        valObj._title = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Job_code": $("#txt_Job_code").val(),
        "Address": $("#txt_Address").val(),
        "Salary": $("#txt_Salary").val(),
        "Salary_unit": $("#txt_Salary_unit").val(),
        "Teacher_name": $("#txt_Teacher_name").val(),
        "College": $("#txt_College").val(),
        "Create_time": $("#txt_Create_time").val(),
        "User_id": $("#txt_User_id").val(),
        "Job_uuid": $("#txt_Job_uuid").val(),
        "Id": $("#txt_Id").val(),
        "_title": $("#txt__title").val(), 
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
    /// <para>ѧ�Լҽ̶�����Ϣ__�ҽ̱�����__����ѧ�Լҽ�-�����Ա����:[Inner-{Xb_job:0},{Xb_job_apply:1},{Xb_teacher_resume:2}]</para>
    /// <para>��V_xb_job_apply���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class V_xb_job_apply : ITableImplement
    {
        /// <summary>��������  </summary>
        public static V_xb_job_apply Factory()
        {
            return new V_xb_job_apply();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> �ҽ�uuid Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> �ҽ̱�� Attribute_IsNotNull </summary>
        public int _Job_code
        {            
            get { return this.Job_code; }
            set { this.Job_code = value; }
        }
        
        /// <summary> ��ϸ��ַ Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> н�� Attribute_IsNotNull </summary>
        public string _Salary
        {            
            get { return this.Salary; }
            set { this.Salary = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Salary_unit
        {            
            get { return this.Salary_unit; }
            set { this.Salary_unit = value; }
        }
        
        /// <summary> ��ʦ���� Attribute_IsNotNull </summary>
        public string _Teacher_name
        {            
            get { return this.Teacher_name; }
            set { this.Teacher_name = value; }
        }
        
        /// <summary> ��ѧ Attribute_IsNotNull </summary>
        public string _College
        {            
            get { return this.College; }
            set { this.College = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Job_uuid
        {            
            get { return this.Job_uuid; }
            set { this.Job_uuid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �ҽ̹������� Attribute_IsNotNull </summary>
        public string __title
        {            
            get { return this._title; }
            set { this._title = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> �ҽ�uuid���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �ҽ̱�ţ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Job_code
        {
            get { return this.m_job_code; }
            set //
            {
                if (!job_code_initialized || m_job_code != value)
                {
                    this.m_job_code = value;
                }
                job_code_initialized = true;
            }
        }
        
        /// <summary> ��ϸ��ַ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> н�ʣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Salary
        {
            get { return this.m_salary; }
            set //
            {
                if (!salary_initialized || m_salary != value)
                {
                    this.m_salary = value;
                }
                salary_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Salary_unit
        {
            get { return this.m_salary_unit; }
            set //
            {
                if (!salary_unit_initialized || m_salary_unit != value)
                {
                    this.m_salary_unit = value;
                }
                salary_unit_initialized = true;
            }
        }
        
        /// <summary> ��ʦ�������Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Teacher_name
        {
            get { return this.m_teacher_name; }
            set //
            {
                if (!teacher_name_initialized || m_teacher_name != value)
                {
                    this.m_teacher_name = value;
                }
                teacher_name_initialized = true;
            }
        }
        
        /// <summary> ��ѧ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string College
        {
            get { return this.m_college; }
            set //
            {
                if (!college_initialized || m_college != value)
                {
                    this.m_college = value;
                }
                college_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        public Guid Job_uuid
        {
            get { return this.m_job_uuid; }
            set //
            {
                if (!job_uuid_initialized || m_job_uuid != value)
                {
                    this.m_job_uuid = value;
                }
                job_uuid_initialized = true;
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
        
        /// <summary> �ҽ̹������ݣ��Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string _title
        {
            get { return this.m__title; }
            set //
            {
                if (!_title_initialized || m__title != value)
                {
                    this.m__title = value;
                }
                _title_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>�ҽ�uuid</summary>
            public static AttributeItem Uuid =  new AttributeItem("[V_xb_job_apply].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>�ҽ̱��</summary>
            public static AttributeItem Job_code =  new AttributeItem("[V_xb_job_apply].[Job_code]", typeof(int), 4, default(int));
            
            /// <summary>��ϸ��ַ</summary>
            public static AttributeItem Address =  new AttributeItem("[V_xb_job_apply].[Address]", typeof(string), 100, default(string));
            
            /// <summary>н��</summary>
            public static AttributeItem Salary =  new AttributeItem("[V_xb_job_apply].[Salary]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Salary_unit =  new AttributeItem("[V_xb_job_apply].[Salary_unit]", typeof(string), 50, default(string));
            
            /// <summary>��ʦ����</summary>
            public static AttributeItem Teacher_name =  new AttributeItem("[V_xb_job_apply].[Teacher_name]", typeof(string), 100, default(string));
            
            /// <summary>��ѧ</summary>
            public static AttributeItem College =  new AttributeItem("[V_xb_job_apply].[College]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Create_time =  new AttributeItem("[V_xb_job_apply].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[V_xb_job_apply].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Job_uuid =  new AttributeItem("[V_xb_job_apply].[Job_uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[V_xb_job_apply].[Id]", typeof(int), 4, default(int));
            
            /// <summary>�ҽ̹�������</summary>
            public static AttributeItem _title =  new AttributeItem("[V_xb_job_apply].[_title]", typeof(string), 1000, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private int m_job_code;
        /// <summary></summary>
        protected bool job_code_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private string m_salary;
        /// <summary></summary>
        protected bool salary_initialized = false;
        
        private string m_salary_unit;
        /// <summary></summary>
        protected bool salary_unit_initialized = false;
        
        private string m_teacher_name;
        /// <summary></summary>
        protected bool teacher_name_initialized = false;
        
        private string m_college;
        /// <summary></summary>
        protected bool college_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private Guid m_job_uuid;
        /// <summary></summary>
        protected bool job_uuid_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m__title;
        /// <summary></summary>
        protected bool _title_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "V_xb_job_apply";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.job_code_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.salary_initialized = IsLoadAllAttributes;this.salary_unit_initialized = IsLoadAllAttributes;this.teacher_name_initialized = IsLoadAllAttributes;this.college_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.job_uuid_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this._title_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			V_xb_job_apply value = new V_xb_job_apply();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Job_code"))
				value.job_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Salary"))
				value.salary_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Salary_unit"))
				value.salary_unit_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_name"))
				value.teacher_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College"))
				value.college_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Job_uuid"))
				value.job_uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"_title"))
				value._title_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new V_xb_job_apply Clone()
        {
            return (V_xb_job_apply)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static V_xb_job_apply()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public V_xb_job_apply() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public V_xb_job_apply(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public V_xb_job_apply(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public V_xb_job_apply(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public V_xb_job_apply(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public V_xb_job_apply(Guid uuid1, int job_code1, string address1, string salary1, string salary_unit1, string teacher_name1, string college1, DateTime create_time1, Guid user_id1, Guid job_uuid1, int id1, string _title1)
        {
            
            this.Uuid = uuid1;
            
            this.Job_code = job_code1;
            
            this.Address = address1;
            
            this.Salary = salary1;
            
            this.Salary_unit = salary_unit1;
            
            this.Teacher_name = teacher_name1;
            
            this.College = college1;
            
            this.Create_time = create_time1;
            
            this.User_id = user_id1;
            
            this.Job_uuid = job_uuid1;
            
            this.Id = id1;
            
            this._title = _title1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static V_xb_job_apply FromIView(IView view)
        {
            return (V_xb_job_apply)IView.GetITable(view, "V_xb_job_apply");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static V_xb_job_apply GetOneInstance()
        {
            V_xb_job_apply value = new V_xb_job_apply();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public V_xb_job_apply Retrieve()
        {
            BLLTable<V_xb_job_apply>.GetRowData(this);
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
			    			
			    case "Job_code":
			        return Job_code;
			    			
			    case "Address":
			        return Address;
			    			
			    case "Salary":
			        return Salary;
			    			
			    case "Salary_unit":
			        return Salary_unit;
			    			
			    case "Teacher_name":
			        return Teacher_name;
			    			
			    case "College":
			        return College;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Job_uuid":
			        return Job_uuid;
			    			
			    case "Id":
			        return Id;
			    			
			    case "_title":
			        return _title;
			
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
			    			
			    case "Job_code":
			        this.Job_code = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Salary":
			        this.Salary = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Salary_unit":
			        this.Salary_unit = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_name":
			        this.Teacher_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "College":
			        this.College = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Job_uuid":
			        this.Job_uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "_title":
			        this._title = Convert.ToString(AttributeValue);
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
				
				case "Job_code":
					return job_code_initialized;
				
				case "Address":
					return address_initialized;
				
				case "Salary":
					return salary_initialized;
				
				case "Salary_unit":
					return salary_unit_initialized;
				
				case "Teacher_name":
					return teacher_name_initialized;
				
				case "College":
					return college_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Job_uuid":
					return job_uuid_initialized;
				
				case "Id":
					return id_initialized;
				
				case "_title":
					return _title_initialized;
				
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
				
				case "Job_code":
					job_code_initialized = ret;
					return true;
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "Salary":
					salary_initialized = ret;
					return true;
				
				case "Salary_unit":
					salary_unit_initialized = ret;
					return true;
				
				case "Teacher_name":
					teacher_name_initialized = ret;
					return true;
				
				case "College":
					college_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Job_uuid":
					job_uuid_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "_title":
					_title_initialized = ret;
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
                AttributeItem attr = V_xb_job_apply.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (job_code_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.Job_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Job_code);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (salary_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.Salary;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Salary);
                }
			}
			
			if (salary_unit_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.Salary_unit;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Salary_unit);
                }
			}
			
			if (teacher_name_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.Teacher_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_name);
                }
			}
			
			if (college_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.College;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (job_uuid_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.Job_uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Job_uuid);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (_title_initialized)
			{
                AttributeItem attr = V_xb_job_apply.Attribute._title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(_title);
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
        public class V_xb_job_applyJson
        {
            
            /// <summary>�ҽ�uuid</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>�ҽ̱��</summary>
            public int Job_code { get; set; }
            
            /// <summary>��ϸ��ַ</summary>
            public string Address { get; set; }
            
            /// <summary>н��</summary>
            public string Salary { get; set; }
            
            /// <summary></summary>
            public string Salary_unit { get; set; }
            
            /// <summary>��ʦ����</summary>
            public string Teacher_name { get; set; }
            
            /// <summary>��ѧ</summary>
            public string College { get; set; }
            
            /// <summary></summary>
            public DateTime Create_time { get; set; }
            
            /// <summary></summary>
            public Guid User_id { get; set; }
            
            /// <summary></summary>
            public Guid Job_uuid { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary>�ҽ̹�������</summary>
            public string _title { get; set; }
        }
        #endregion
    }
}
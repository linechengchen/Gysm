/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:33
  Description:    ���ݱ�Xt_subject_photo��Ӧ��ҵ���߼���Xt_subject_photo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_subject_photo_Entity:Xt_subject_photo
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Create_time,Modify_time,Course_id,Student_id,Teacher_id,Photo_url,Remark,Is_ready,Category from Xt_subject_photo
delete from Xt_subject_photo
INSERT INTO Xt_subject_photo (Uuid,Create_time,Modify_time,Course_id,Student_id,Teacher_id,Photo_url,Remark,Is_ready,Category)
     VALUES
           ('','','','','','','','','','')
UPDATE Xt_subject_photo SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Create_time = valObj2.Create_time;
        valObj.Modify_time = valObj2.Modify_time;
        valObj.Course_id = valObj2.Course_id;
        valObj.Student_id = valObj2.Student_id;
        valObj.Teacher_id = valObj2.Teacher_id;
        valObj.Photo_url = valObj2.Photo_url;
        valObj.Remark = valObj2.Remark;
        valObj.Is_ready = valObj2.Is_ready;
        valObj.Category = valObj2.Category; 
        valObj.Uuid = "";
        valObj.Create_time = "";
        valObj.Modify_time = "";
        valObj.Course_id = "";
        valObj.Student_id = "";
        valObj.Teacher_id = "";
        valObj.Photo_url = "";
        valObj.Remark = "";
        valObj.Is_ready = "";
        valObj.Category = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Modify_time": $("#txt_Modify_time").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Student_id": $("#txt_Student_id").val(),
        "Teacher_id": $("#txt_Teacher_id").val(),
        "Photo_url": $("#txt_Photo_url").val(),
        "Remark": $("#txt_Remark").val(),
        "Is_ready": $("#txt_Is_ready").val(),
        "Category": $("#txt_Category").val(), 
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
    /// <para>��Xt_subject_photo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_subject_photo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_subject_photo Factory()
        {
            return new Xt_subject_photo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Teacher_id
        {            
            get { return this.Teacher_id; }
            set { this.Teacher_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Photo_url
        {            
            get { return this.Photo_url; }
            set { this.Photo_url = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Remark
        {            
            get { return this.Remark; }
            set { this.Remark = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_ready
        {            
            get { return this.Is_ready; }
            set { this.Is_ready = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category
        {            
            get { return this.Category; }
            set { this.Category = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Modify_time
        {
            get { return this.m_modify_time; }
            set //
            {
                if (!modify_time_initialized || m_modify_time != value)
                {
                    this.m_modify_time = value;
                }
                modify_time_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Student_id
        {
            get { return this.m_student_id; }
            set //
            {
                if (!student_id_initialized || m_student_id != value)
                {
                    this.m_student_id = value;
                }
                student_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Teacher_id
        {
            get { return this.m_teacher_id; }
            set //
            {
                if (!teacher_id_initialized || m_teacher_id != value)
                {
                    this.m_teacher_id = value;
                }
                teacher_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Photo_url
        {
            get { return this.m_photo_url; }
            set //
            {
                if (!photo_url_initialized || m_photo_url != value)
                {
                    this.m_photo_url = value;
                }
                photo_url_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Remark
        {
            get { return this.m_remark; }
            set //
            {
                if (!remark_initialized || m_remark != value)
                {
                    this.m_remark = value;
                }
                remark_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Is_ready
        {
            get { return this.m_is_ready; }
            set //
            {
                if (!is_ready_initialized || m_is_ready != value)
                {
                    this.m_is_ready = value;
                }
                is_ready_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Category
        {
            get { return this.m_category; }
            set //
            {
                if (!category_initialized || m_category != value)
                {
                    this.m_category = value;
                }
                category_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_subject_photo].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_subject_photo].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xt_subject_photo].[Modify_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_subject_photo].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xt_subject_photo].[Student_id]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_id =  new AttributeItem("[Xt_subject_photo].[Teacher_id]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Photo_url =  new AttributeItem("[Xt_subject_photo].[Photo_url]", typeof(string), 150, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Remark =  new AttributeItem("[Xt_subject_photo].[Remark]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_ready =  new AttributeItem("[Xt_subject_photo].[Is_ready]", typeof(string), 1, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category =  new AttributeItem("[Xt_subject_photo].[Category]", typeof(string), 100, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        
        private string m_teacher_id;
        /// <summary></summary>
        protected bool teacher_id_initialized = false;
        
        private string m_photo_url;
        /// <summary></summary>
        protected bool photo_url_initialized = false;
        
        private string m_remark;
        /// <summary></summary>
        protected bool remark_initialized = false;
        
        private string m_is_ready;
        /// <summary></summary>
        protected bool is_ready_initialized = false;
        
        private string m_category;
        /// <summary></summary>
        protected bool category_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_subject_photo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;this.teacher_id_initialized = IsLoadAllAttributes;this.photo_url_initialized = IsLoadAllAttributes;this.remark_initialized = IsLoadAllAttributes;this.is_ready_initialized = IsLoadAllAttributes;this.category_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_subject_photo value = new Xt_subject_photo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_id"))
				value.teacher_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Photo_url"))
				value.photo_url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Remark"))
				value.remark_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_ready"))
				value.is_ready_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category"))
				value.category_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_subject_photo Clone()
        {
            return (Xt_subject_photo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_subject_photo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_subject_photo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_subject_photo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_subject_photo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_subject_photo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_subject_photo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_subject_photo(Guid uuid1, DateTime create_time1, DateTime modify_time1, string course_id1, string student_id1, string teacher_id1, string photo_url1, string remark1, string is_ready1, string category1)
        {
            
            this.Uuid = uuid1;
            
            this.Create_time = create_time1;
            
            this.Modify_time = modify_time1;
            
            this.Course_id = course_id1;
            
            this.Student_id = student_id1;
            
            this.Teacher_id = teacher_id1;
            
            this.Photo_url = photo_url1;
            
            this.Remark = remark1;
            
            this.Is_ready = is_ready1;
            
            this.Category = category1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_subject_photo FromIView(IView view)
        {
            return (Xt_subject_photo)IView.GetITable(view, "Xt_subject_photo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_subject_photo GetOneInstance()
        {
            Xt_subject_photo value = new Xt_subject_photo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_subject_photo Retrieve()
        {
            BLLTable<Xt_subject_photo>.GetRowData(this);
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
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Modify_time":
			        return Modify_time;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Student_id":
			        return Student_id;
			    			
			    case "Teacher_id":
			        return Teacher_id;
			    			
			    case "Photo_url":
			        return Photo_url;
			    			
			    case "Remark":
			        return Remark;
			    			
			    case "Is_ready":
			        return Is_ready;
			    			
			    case "Category":
			        return Category;
			
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
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teacher_id":
			        this.Teacher_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Photo_url":
			        this.Photo_url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Remark":
			        this.Remark = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_ready":
			        this.Is_ready = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category":
			        this.Category = Convert.ToString(AttributeValue);
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
				
				case "Create_time":
					return create_time_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
				case "Teacher_id":
					return teacher_id_initialized;
				
				case "Photo_url":
					return photo_url_initialized;
				
				case "Remark":
					return remark_initialized;
				
				case "Is_ready":
					return is_ready_initialized;
				
				case "Category":
					return category_initialized;
				
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
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
					return true;
				
				case "Teacher_id":
					teacher_id_initialized = ret;
					return true;
				
				case "Photo_url":
					photo_url_initialized = ret;
					return true;
				
				case "Remark":
					remark_initialized = ret;
					return true;
				
				case "Is_ready":
					is_ready_initialized = ret;
					return true;
				
				case "Category":
					category_initialized = ret;
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
                AttributeItem attr = Xt_subject_photo.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_subject_photo.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xt_subject_photo.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_subject_photo.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xt_subject_photo.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
                }
			}
			
			if (teacher_id_initialized)
			{
                AttributeItem attr = Xt_subject_photo.Attribute.Teacher_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_id);
                }
			}
			
			if (photo_url_initialized)
			{
                AttributeItem attr = Xt_subject_photo.Attribute.Photo_url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Photo_url);
                }
			}
			
			if (remark_initialized)
			{
                AttributeItem attr = Xt_subject_photo.Attribute.Remark;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Remark);
                }
			}
			
			if (is_ready_initialized)
			{
                AttributeItem attr = Xt_subject_photo.Attribute.Is_ready;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_ready);
                }
			}
			
			if (category_initialized)
			{
                AttributeItem attr = Xt_subject_photo.Attribute.Category;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category);
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
        public class Xt_subject_photoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Modify_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Photo_url { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Remark { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Is_ready { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Category { get; set; }
        }
        #endregion
    }
}
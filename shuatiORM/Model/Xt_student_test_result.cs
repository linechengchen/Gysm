/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:33
  Description:    ���ݱ�Xt_student_test_result��Ӧ��ҵ���߼���Xt_student_test_result
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_student_test_result_Entity:Xt_student_test_result
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Test_id,Course_id,Mark,Grade,Time,Student_id from Xt_student_test_result
delete from Xt_student_test_result
INSERT INTO Xt_student_test_result (Uuid,Test_id,Course_id,Mark,Grade,Time,Student_id)
     VALUES
           ('','','','','','','')
UPDATE Xt_student_test_result SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Test_id = valObj2.Test_id;
        valObj.Course_id = valObj2.Course_id;
        valObj.Mark = valObj2.Mark;
        valObj.Grade = valObj2.Grade;
        valObj.Time = valObj2.Time;
        valObj.Student_id = valObj2.Student_id; 
        valObj.Uuid = "";
        valObj.Test_id = "";
        valObj.Course_id = "";
        valObj.Mark = "";
        valObj.Grade = "";
        valObj.Time = "";
        valObj.Student_id = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Test_id": $("#txt_Test_id").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Mark": $("#txt_Mark").val(),
        "Grade": $("#txt_Grade").val(),
        "Time": $("#txt_Time").val(),
        "Student_id": $("#txt_Student_id").val(), 
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
    /// <para>ѧ����������</para>
    /// <para>��Xt_student_test_result���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_student_test_result : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_student_test_result Factory()
        {
            return new Xt_student_test_result();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Test_id
        {            
            get { return this.Test_id; }
            set { this.Test_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> �ɼ�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Mark
        {            
            get { return this.Mark; }
            set { this.Mark = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Time
        {            
            get { return this.Time; }
            set { this.Time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
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
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Test_id
        {
            get { return this.m_test_id; }
            set //
            {
                if (!test_id_initialized || m_test_id != value)
                {
                    this.m_test_id = value;
                }
                test_id_initialized = true;
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
        
        /// <summary> �ɼ�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Mark
        {
            get { return this.m_mark; }
            set //
            {
                if (!mark_initialized || m_mark != value)
                {
                    this.m_mark = value;
                }
                mark_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Grade
        {
            get { return this.m_grade; }
            set //
            {
                if (!grade_initialized || m_grade != value)
                {
                    this.m_grade = value;
                }
                grade_initialized = true;
            }
        }
        
        /// <summary> ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Time
        {
            get { return this.m_time; }
            set //
            {
                if (!time_initialized || m_time != value)
                {
                    this.m_time = value;
                }
                time_initialized = true;
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xt_student_test_result].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Test_id =  new AttributeItem("[Xt_student_test_result].[Test_id]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_student_test_result].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>�ɼ�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Mark =  new AttributeItem("[Xt_student_test_result].[Mark]", typeof(int), 4, default(int));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Grade =  new AttributeItem("[Xt_student_test_result].[Grade]", typeof(int), 4, default(int));
            
            /// <summary>ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Time =  new AttributeItem("[Xt_student_test_result].[Time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xt_student_test_result].[Student_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_test_id;
        /// <summary></summary>
        protected bool test_id_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private int m_mark;
        /// <summary></summary>
        protected bool mark_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private DateTime m_time;
        /// <summary></summary>
        protected bool time_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_student_test_result";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.test_id_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.mark_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.time_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_student_test_result value = new Xt_student_test_result();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Test_id"))
				value.test_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mark"))
				value.mark_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time"))
				value.time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_student_test_result Clone()
        {
            return (Xt_student_test_result)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_student_test_result()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_student_test_result() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_student_test_result(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_student_test_result(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_student_test_result(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_student_test_result(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_student_test_result(Guid uuid1, string test_id1, string course_id1, int mark1, int grade1, DateTime time1, string student_id1)
        {
            
            this.Uuid = uuid1;
            
            this.Test_id = test_id1;
            
            this.Course_id = course_id1;
            
            this.Mark = mark1;
            
            this.Grade = grade1;
            
            this.Time = time1;
            
            this.Student_id = student_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_student_test_result FromIView(IView view)
        {
            return (Xt_student_test_result)IView.GetITable(view, "Xt_student_test_result");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_student_test_result GetOneInstance()
        {
            Xt_student_test_result value = new Xt_student_test_result();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_student_test_result Retrieve()
        {
            BLLTable<Xt_student_test_result>.GetRowData(this);
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
			    			
			    case "Test_id":
			        return Test_id;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Mark":
			        return Mark;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Time":
			        return Time;
			    			
			    case "Student_id":
			        return Student_id;
			
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
			    			
			    case "Test_id":
			        this.Test_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Mark":
			        this.Mark = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Time":
			        this.Time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
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
				
				case "Test_id":
					return test_id_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Mark":
					return mark_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Time":
					return time_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
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
				
				case "Test_id":
					test_id_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Mark":
					mark_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Time":
					time_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
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
                AttributeItem attr = Xt_student_test_result.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (test_id_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Test_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Test_id);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (mark_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Mark;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mark);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (time_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xt_student_test_result.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
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
        public class Xt_student_test_resultJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public string Test_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>�ɼ�:[CtrlTypeDic-{InputString}]</summary>
            public int Mark { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public int Grade { get; set; }
            
            /// <summary>ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
        }
        #endregion
    }
}
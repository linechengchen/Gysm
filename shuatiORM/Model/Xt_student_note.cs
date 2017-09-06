/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    ���ݱ�Xt_student_note��Ӧ��ҵ���߼���Xt_student_note
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_student_note_Entity:Xt_student_note
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Create_time,Modify_time,Note_id,Student_id,Is_read from Xt_student_note
delete from Xt_student_note
INSERT INTO Xt_student_note (Id,Create_time,Modify_time,Note_id,Student_id,Is_read)
     VALUES
           ('','','','','','')
UPDATE Xt_student_note SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Create_time = valObj2.Create_time;
        valObj.Modify_time = valObj2.Modify_time;
        valObj.Note_id = valObj2.Note_id;
        valObj.Student_id = valObj2.Student_id;
        valObj.Is_read = valObj2.Is_read; 
        valObj.Id = "";
        valObj.Create_time = "";
        valObj.Modify_time = "";
        valObj.Note_id = "";
        valObj.Student_id = "";
        valObj.Is_read = ""; 
        "Id": $("#txt_Id").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Modify_time": $("#txt_Modify_time").val(),
        "Note_id": $("#txt_Note_id").val(),
        "Student_id": $("#txt_Student_id").val(),
        "Is_read": $("#txt_Is_read").val(), 
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
    /// <para>ѧ��֪ͨ�Ƿ��Ѷ���</para>
    /// <para>��Xt_student_note���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_student_note : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_student_note Factory()
        {
            return new Xt_student_note();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> �޸�ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        
        /// <summary> ����id (char(36)):[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Note_id
        {            
            get { return this.Note_id; }
            set { this.Note_id = value; }
        }
        
        /// <summary> ѧ��id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        
        /// <summary> �Ƿ��Ѷ�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Is_read
        {            
            get { return this.Is_read; }
            set { this.Is_read = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid Id
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
        
        /// <summary> �޸�ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����id (char(36)):[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Note_id
        {
            get { return this.m_note_id; }
            set //
            {
                if (!note_id_initialized || m_note_id != value)
                {
                    this.m_note_id = value;
                }
                note_id_initialized = true;
            }
        }
        
        /// <summary> ѧ��id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ƿ��Ѷ�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Is_read
        {
            get { return this.m_is_read; }
            set //
            {
                if (!is_read_initialized || m_is_read != value)
                {
                    this.m_is_read = value;
                }
                is_read_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xt_student_note].[Id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_student_note].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>�޸�ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xt_student_note].[Modify_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����id (char(36)):[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Note_id =  new AttributeItem("[Xt_student_note].[Note_id]", typeof(string), 36, default(string));
            
            /// <summary>ѧ��id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xt_student_note].[Student_id]", typeof(string), 36, default(string));
            
            /// <summary>�Ƿ��Ѷ�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Is_read =  new AttributeItem("[Xt_student_note].[Is_read]", typeof(string), 1, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        
        private string m_note_id;
        /// <summary></summary>
        protected bool note_id_initialized = false;
        
        private string m_student_id;
        /// <summary></summary>
        protected bool student_id_initialized = false;
        
        private string m_is_read;
        /// <summary></summary>
        protected bool is_read_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_student_note";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;this.note_id_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;this.is_read_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_student_note value = new Xt_student_note();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Note_id"))
				value.note_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_read"))
				value.is_read_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_student_note Clone()
        {
            return (Xt_student_note)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_student_note()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_student_note() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_student_note(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_student_note(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_student_note(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_student_note(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_student_note(Guid id1, DateTime create_time1, DateTime modify_time1, string note_id1, string student_id1, string is_read1)
        {
            
            this.Id = id1;
            
            this.Create_time = create_time1;
            
            this.Modify_time = modify_time1;
            
            this.Note_id = note_id1;
            
            this.Student_id = student_id1;
            
            this.Is_read = is_read1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_student_note FromIView(IView view)
        {
            return (Xt_student_note)IView.GetITable(view, "Xt_student_note");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_student_note GetOneInstance()
        {
            Xt_student_note value = new Xt_student_note();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_student_note Retrieve()
        {
            BLLTable<Xt_student_note>.GetRowData(this);
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
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Modify_time":
			        return Modify_time;
			    			
			    case "Note_id":
			        return Note_id;
			    			
			    case "Student_id":
			        return Student_id;
			    			
			    case "Is_read":
			        return Is_read;
			
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
			        this.Id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Note_id":
			        this.Note_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Student_id":
			        this.Student_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Is_read":
			        this.Is_read = Convert.ToString(AttributeValue);
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
				
				case "Create_time":
					return create_time_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
				case "Note_id":
					return note_id_initialized;
				
				case "Student_id":
					return student_id_initialized;
				
				case "Is_read":
					return is_read_initialized;
				
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
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
					return true;
				
				case "Note_id":
					note_id_initialized = ret;
					return true;
				
				case "Student_id":
					student_id_initialized = ret;
					return true;
				
				case "Is_read":
					is_read_initialized = ret;
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
                AttributeItem attr = Xt_student_note.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_student_note.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xt_student_note.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
                }
			}
			
			if (note_id_initialized)
			{
                AttributeItem attr = Xt_student_note.Attribute.Note_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Note_id);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xt_student_note.Attribute.Student_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student_id);
                }
			}
			
			if (is_read_initialized)
			{
                AttributeItem attr = Xt_student_note.Attribute.Is_read;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_read);
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
        public class Xt_student_noteJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Id { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>�޸�ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Modify_time { get; set; }
            
            /// <summary>����id (char(36)):[CtrlTypeDic-{InputString}]</summary>
            public string Note_id { get; set; }
            
            /// <summary>ѧ��id:[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
            
            /// <summary>�Ƿ��Ѷ�:[CtrlTypeDic-{InputString}]</summary>
            public string Is_read { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:20
  Description:    ���ݱ�Xb_byFilter��Ӧ��ҵ���߼���Xb_byFilter
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_byFilter_Entity:Xb_byFilter
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Catelog,Grade,Kemu,Service_type,Sex,SortRules,Teach_exp,Teacher_mode,Teacher_type from Xb_byFilter
delete from Xb_byFilter
INSERT INTO Xb_byFilter (Id,Catelog,Grade,Kemu,Service_type,Sex,SortRules,Teach_exp,Teacher_mode,Teacher_type)
     VALUES
           ('','','','','','','','','','')
UPDATE Xb_byFilter SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Catelog = valObj2.Catelog;
        valObj.Grade = valObj2.Grade;
        valObj.Kemu = valObj2.Kemu;
        valObj.Service_type = valObj2.Service_type;
        valObj.Sex = valObj2.Sex;
        valObj.SortRules = valObj2.SortRules;
        valObj.Teach_exp = valObj2.Teach_exp;
        valObj.Teacher_mode = valObj2.Teacher_mode;
        valObj.Teacher_type = valObj2.Teacher_type; 
        valObj.Id = "";
        valObj.Catelog = "";
        valObj.Grade = "";
        valObj.Kemu = "";
        valObj.Service_type = "";
        valObj.Sex = "";
        valObj.SortRules = "";
        valObj.Teach_exp = "";
        valObj.Teacher_mode = "";
        valObj.Teacher_type = ""; 
        "Id": $("#txt_Id").val(),
        "Catelog": $("#txt_Catelog").val(),
        "Grade": $("#txt_Grade").val(),
        "Kemu": $("#txt_Kemu").val(),
        "Service_type": $("#txt_Service_type").val(),
        "Sex": $("#txt_Sex").val(),
        "SortRules": $("#txt_SortRules").val(),
        "Teach_exp": $("#txt_Teach_exp").val(),
        "Teacher_mode": $("#txt_Teacher_mode").val(),
        "Teacher_type": $("#txt_Teacher_type").val(), 
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
    /// <para>��������</para>
    /// <para>��Xb_byFilter���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_byFilter : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_byFilter Factory()
        {
            return new Xb_byFilter();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> Tab����:[Enum-{0:�ҽ�},{1:���},{2:С���},{3:���ڿ�}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Catelog
        {            
            get { return this.Catelog; }
            set { this.Catelog = value; }
        }
        
        /// <summary> �꼶:[Enum-{0:����},{1:һ�꼶},{2:���꼶},{3:���꼶},{4:���꼶},{5:���꼶},{6:���꼶},{7:���꼶},{8:���꼶},{9:���꼶},{10:��һ},{11:�߶�},{12:����},{13:��һ},{14:���},{15:����}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> ��Ŀ:[Enum-{0:�������},{1:���ɻỰ},{2:������Ӣ��},{3:��˼Ӣ��},{4:���и�Ӣ��},{5:����Ӣ��},{6:����Ӣ��},{7:�Ļ�����Ӣ��},{8:ʱ��Ӣ��},{9:����ȫ���¸���},{10:�ۺϿ���},{11:����Ӣ����˰棩},{12:����Ӣ����ٰ棩}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Kemu
        {            
            get { return this.Kemu; }
            set { this.Kemu = value; }
        }
        
        /// <summary> ����ʽ:[Enum-{0:����},{1:���״�����},{2:���ŷ���},{3:���ߴ���},{4:���߿�}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Service_type
        {            
            get { return this.Service_type; }
            set { this.Service_type = value; }
        }
        
        /// <summary> �Ա�:[Enum-{0:����},{1:����ʦ},{2:Ů��ʦ}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary> ����ʽ:[Enum-{0:����},{1:�ڱ����},{2:�ڿ����},{3:�������},{4:��������}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _SortRules
        {            
            get { return this.SortRules; }
            set { this.SortRules = value; }
        }
        
        /// <summary> �̿ξ���:[Enum-{0:����},{1:1������},{2:2-5��},{3:10������}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Teach_exp
        {            
            get { return this.Teach_exp; }
            set { this.Teach_exp = value; }
        }
        
        /// <summary> ��ѧģʽ:[Enum-{0:����},{1:����1v1},{2:����������},{3:1v3С��},{4:1v5С��}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Teacher_mode
        {            
            get { return this.Teacher_mode; }
            set { this.Teacher_mode = value; }
        }
        
        /// <summary> ��ʦ����:[Enum-{0:����},{1:��ѧ�����},{2:ŷ�����}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Teacher_type
        {            
            get { return this.Teacher_type; }
            set { this.Teacher_type = value; }
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
        
        /// <summary> Tab����:[Enum-{0:�ҽ�},{1:���},{2:С���},{3:���ڿ�}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Catelog
        {
            get { return this.m_catelog; }
            set //
            {
                if (!catelog_initialized || m_catelog != value)
                {
                    this.m_catelog = value;
                }
                catelog_initialized = true;
            }
        }
        
        /// <summary> �꼶:[Enum-{0:����},{1:һ�꼶},{2:���꼶},{3:���꼶},{4:���꼶},{5:���꼶},{6:���꼶},{7:���꼶},{8:���꼶},{9:���꼶},{10:��һ},{11:�߶�},{12:����},{13:��һ},{14:���},{15:����}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��Ŀ:[Enum-{0:�������},{1:���ɻỰ},{2:������Ӣ��},{3:��˼Ӣ��},{4:���и�Ӣ��},{5:����Ӣ��},{6:����Ӣ��},{7:�Ļ�����Ӣ��},{8:ʱ��Ӣ��},{9:����ȫ���¸���},{10:�ۺϿ���},{11:����Ӣ����˰棩},{12:����Ӣ����ٰ棩}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Kemu
        {
            get { return this.m_kemu; }
            set //
            {
                if (!kemu_initialized || m_kemu != value)
                {
                    this.m_kemu = value;
                }
                kemu_initialized = true;
            }
        }
        
        /// <summary> ����ʽ:[Enum-{0:����},{1:���״�����},{2:���ŷ���},{3:���ߴ���},{4:���߿�}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Service_type
        {
            get { return this.m_service_type; }
            set //
            {
                if (!service_type_initialized || m_service_type != value)
                {
                    this.m_service_type = value;
                }
                service_type_initialized = true;
            }
        }
        
        /// <summary> �Ա�:[Enum-{0:����},{1:����ʦ},{2:Ů��ʦ}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Sex
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
        
        /// <summary> ����ʽ:[Enum-{0:����},{1:�ڱ����},{2:�ڿ����},{3:�������},{4:��������}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SortRules
        {
            get { return this.m_sortrules; }
            set //
            {
                if (!sortrules_initialized || m_sortrules != value)
                {
                    this.m_sortrules = value;
                }
                sortrules_initialized = true;
            }
        }
        
        /// <summary> �̿ξ���:[Enum-{0:����},{1:1������},{2:2-5��},{3:10������}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Teach_exp
        {
            get { return this.m_teach_exp; }
            set //
            {
                if (!teach_exp_initialized || m_teach_exp != value)
                {
                    this.m_teach_exp = value;
                }
                teach_exp_initialized = true;
            }
        }
        
        /// <summary> ��ѧģʽ:[Enum-{0:����},{1:����1v1},{2:����������},{3:1v3С��},{4:1v5С��}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Teacher_mode
        {
            get { return this.m_teacher_mode; }
            set //
            {
                if (!teacher_mode_initialized || m_teacher_mode != value)
                {
                    this.m_teacher_mode = value;
                }
                teacher_mode_initialized = true;
            }
        }
        
        /// <summary> ��ʦ����:[Enum-{0:����},{1:��ѧ�����},{2:ŷ�����}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Teacher_type
        {
            get { return this.m_teacher_type; }
            set //
            {
                if (!teacher_type_initialized || m_teacher_type != value)
                {
                    this.m_teacher_type = value;
                }
                teacher_type_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_byFilter].[Id]", typeof(int), 4, default(int));
            
            /// <summary>Tab����:[Enum-{0:�ҽ�},{1:���},{2:С���},{3:���ڿ�}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Catelog =  new AttributeItem("[Xb_byFilter].[Catelog]", typeof(int), 4, default(int));
            
            /// <summary>�꼶:[Enum-{0:����},{1:һ�꼶},{2:���꼶},{3:���꼶},{4:���꼶},{5:���꼶},{6:���꼶},{7:���꼶},{8:���꼶},{9:���꼶},{10:��һ},{11:�߶�},{12:����},{13:��һ},{14:���},{15:����}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Grade =  new AttributeItem("[Xb_byFilter].[Grade]", typeof(int), 4, default(int));
            
            /// <summary>��Ŀ:[Enum-{0:�������},{1:���ɻỰ},{2:������Ӣ��},{3:��˼Ӣ��},{4:���и�Ӣ��},{5:����Ӣ��},{6:����Ӣ��},{7:�Ļ�����Ӣ��},{8:ʱ��Ӣ��},{9:����ȫ���¸���},{10:�ۺϿ���},{11:����Ӣ����˰棩},{12:����Ӣ����ٰ棩}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Kemu =  new AttributeItem("[Xb_byFilter].[Kemu]", typeof(int), 4, default(int));
            
            /// <summary>����ʽ:[Enum-{0:����},{1:���״�����},{2:���ŷ���},{3:���ߴ���},{4:���߿�}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Service_type =  new AttributeItem("[Xb_byFilter].[Service_type]", typeof(int), 4, default(int));
            
            /// <summary>�Ա�:[Enum-{0:����},{1:����ʦ},{2:Ů��ʦ}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Sex =  new AttributeItem("[Xb_byFilter].[Sex]", typeof(int), 4, default(int));
            
            /// <summary>����ʽ:[Enum-{0:����},{1:�ڱ����},{2:�ڿ����},{3:�������},{4:��������}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem SortRules =  new AttributeItem("[Xb_byFilter].[SortRules]", typeof(string), 50, default(string));
            
            /// <summary>�̿ξ���:[Enum-{0:����},{1:1������},{2:2-5��},{3:10������}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Teach_exp =  new AttributeItem("[Xb_byFilter].[Teach_exp]", typeof(int), 4, default(int));
            
            /// <summary>��ѧģʽ:[Enum-{0:����},{1:����1v1},{2:����������},{3:1v3С��},{4:1v5С��}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Teacher_mode =  new AttributeItem("[Xb_byFilter].[Teacher_mode]", typeof(int), 4, default(int));
            
            /// <summary>��ʦ����:[Enum-{0:����},{1:��ѧ�����},{2:ŷ�����}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Teacher_type =  new AttributeItem("[Xb_byFilter].[Teacher_type]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_catelog;
        /// <summary></summary>
        protected bool catelog_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private int m_kemu;
        /// <summary></summary>
        protected bool kemu_initialized = false;
        
        private int m_service_type;
        /// <summary></summary>
        protected bool service_type_initialized = false;
        
        private int m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private string m_sortrules;
        /// <summary></summary>
        protected bool sortrules_initialized = false;
        
        private int m_teach_exp;
        /// <summary></summary>
        protected bool teach_exp_initialized = false;
        
        private int m_teacher_mode;
        /// <summary></summary>
        protected bool teacher_mode_initialized = false;
        
        private int m_teacher_type;
        /// <summary></summary>
        protected bool teacher_type_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_byFilter";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.catelog_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.kemu_initialized = IsLoadAllAttributes;this.service_type_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.sortrules_initialized = IsLoadAllAttributes;this.teach_exp_initialized = IsLoadAllAttributes;this.teacher_mode_initialized = IsLoadAllAttributes;this.teacher_type_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_byFilter value = new Xb_byFilter();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Catelog"))
				value.catelog_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu"))
				value.kemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Service_type"))
				value.service_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SortRules"))
				value.sortrules_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teach_exp"))
				value.teach_exp_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_mode"))
				value.teacher_mode_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_type"))
				value.teacher_type_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_byFilter Clone()
        {
            return (Xb_byFilter)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_byFilter()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_byFilter() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_byFilter(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_byFilter(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_byFilter(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_byFilter(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_byFilter(int id1, int catelog1, int grade1, int kemu1, int service_type1, int sex1, string sortrules1, int teach_exp1, int teacher_mode1, int teacher_type1)
        {
            
            this.Id = id1;
            
            this.Catelog = catelog1;
            
            this.Grade = grade1;
            
            this.Kemu = kemu1;
            
            this.Service_type = service_type1;
            
            this.Sex = sex1;
            
            this.SortRules = sortrules1;
            
            this.Teach_exp = teach_exp1;
            
            this.Teacher_mode = teacher_mode1;
            
            this.Teacher_type = teacher_type1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_byFilter FromIView(IView view)
        {
            return (Xb_byFilter)IView.GetITable(view, "Xb_byFilter");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_byFilter GetOneInstance()
        {
            Xb_byFilter value = new Xb_byFilter();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_byFilter Retrieve()
        {
            BLLTable<Xb_byFilter>.GetRowData(this);
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
			    			
			    case "Catelog":
			        return Catelog;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Kemu":
			        return Kemu;
			    			
			    case "Service_type":
			        return Service_type;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "SortRules":
			        return SortRules;
			    			
			    case "Teach_exp":
			        return Teach_exp;
			    			
			    case "Teacher_mode":
			        return Teacher_mode;
			    			
			    case "Teacher_type":
			        return Teacher_type;
			
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
			    			
			    case "Catelog":
			        this.Catelog = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Kemu":
			        this.Kemu = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Service_type":
			        this.Service_type = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "SortRules":
			        this.SortRules = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Teach_exp":
			        this.Teach_exp = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Teacher_mode":
			        this.Teacher_mode = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Teacher_type":
			        this.Teacher_type = Convert.ToInt32(AttributeValue);
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
				
				case "Catelog":
					return catelog_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Kemu":
					return kemu_initialized;
				
				case "Service_type":
					return service_type_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "SortRules":
					return sortrules_initialized;
				
				case "Teach_exp":
					return teach_exp_initialized;
				
				case "Teacher_mode":
					return teacher_mode_initialized;
				
				case "Teacher_type":
					return teacher_type_initialized;
				
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
				
				case "Catelog":
					catelog_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Kemu":
					kemu_initialized = ret;
					return true;
				
				case "Service_type":
					service_type_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "SortRules":
					sortrules_initialized = ret;
					return true;
				
				case "Teach_exp":
					teach_exp_initialized = ret;
					return true;
				
				case "Teacher_mode":
					teacher_mode_initialized = ret;
					return true;
				
				case "Teacher_type":
					teacher_type_initialized = ret;
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
                AttributeItem attr = Xb_byFilter.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (catelog_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Catelog;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Catelog);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (kemu_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu);
                }
			}
			
			if (service_type_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Service_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Service_type);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (sortrules_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.SortRules;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SortRules);
                }
			}
			
			if (teach_exp_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Teach_exp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teach_exp);
                }
			}
			
			if (teacher_mode_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Teacher_mode;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_mode);
                }
			}
			
			if (teacher_type_initialized)
			{
                AttributeItem attr = Xb_byFilter.Attribute.Teacher_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_type);
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
        public class Xb_byFilterJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>Tab����:[Enum-{0:�ҽ�},{1:���},{2:С���},{3:���ڿ�}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Catelog { get; set; }
            
            /// <summary>�꼶:[Enum-{0:����},{1:һ�꼶},{2:���꼶},{3:���꼶},{4:���꼶},{5:���꼶},{6:���꼶},{7:���꼶},{8:���꼶},{9:���꼶},{10:��һ},{11:�߶�},{12:����},{13:��һ},{14:���},{15:����}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Grade { get; set; }
            
            /// <summary>��Ŀ:[Enum-{0:�������},{1:���ɻỰ},{2:������Ӣ��},{3:��˼Ӣ��},{4:���и�Ӣ��},{5:����Ӣ��},{6:����Ӣ��},{7:�Ļ�����Ӣ��},{8:ʱ��Ӣ��},{9:����ȫ���¸���},{10:�ۺϿ���},{11:����Ӣ����˰棩},{12:����Ӣ����ٰ棩}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Kemu { get; set; }
            
            /// <summary>����ʽ:[Enum-{0:����},{1:���״�����},{2:���ŷ���},{3:���ߴ���},{4:���߿�}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Service_type { get; set; }
            
            /// <summary>�Ա�:[Enum-{0:����},{1:����ʦ},{2:Ů��ʦ}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Sex { get; set; }
            
            /// <summary>����ʽ:[Enum-{0:����},{1:�ڱ����},{2:�ڿ����},{3:�������},{4:��������}][CtrlTypeDic-{SelectDrop}]</summary>
            public string SortRules { get; set; }
            
            /// <summary>�̿ξ���:[Enum-{0:����},{1:1������},{2:2-5��},{3:10������}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Teach_exp { get; set; }
            
            /// <summary>��ѧģʽ:[Enum-{0:����},{1:����1v1},{2:����������},{3:1v3С��},{4:1v5С��}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Teacher_mode { get; set; }
            
            /// <summary>��ʦ����:[Enum-{0:����},{1:��ѧ�����},{2:ŷ�����}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Teacher_type { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/7/22 20:55:18
  Description:    ���ݱ�Xb_dayiorder��Ӧ��ҵ���߼���Xb_dayiorder
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_dayiorder_Entity:Xb_dayiorder
 * 
************************************************************/
/************************************************************
SQL���룺
select Create_time,DayiOrderId,Grade,Id,Kemu,TearcharId,User_id from Xb_dayiorder
delete from Xb_dayiorder
INSERT INTO Xb_dayiorder (Create_time,DayiOrderId,Grade,Id,Kemu,TearcharId,User_id)
     VALUES
           ('','','','','','','')
UPDATE Xb_dayiorder SET ...
������ֵ���룺
 *         valObj.Create_time = valObj2.Create_time;
        valObj.DayiOrderId = valObj2.DayiOrderId;
        valObj.Grade = valObj2.Grade;
        valObj.Id = valObj2.Id;
        valObj.Kemu = valObj2.Kemu;
        valObj.TearcharId = valObj2.TearcharId;
        valObj.User_id = valObj2.User_id; 
        valObj.Create_time = "";
        valObj.DayiOrderId = "";
        valObj.Grade = "";
        valObj.Id = "";
        valObj.Kemu = "";
        valObj.TearcharId = "";
        valObj.User_id = ""; 
        "Create_time": $("#txt_Create_time").val(),
        "DayiOrderId": $("#txt_DayiOrderId").val(),
        "Grade": $("#txt_Grade").val(),
        "Id": $("#txt_Id").val(),
        "Kemu": $("#txt_Kemu").val(),
        "TearcharId": $("#txt_TearcharId").val(),
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
    /// <para></para>
    /// <para>��Xb_dayiorder���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_dayiorder : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_dayiorder Factory()
        {
            return new Xb_dayiorder();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _DayiOrderId
        {            
            get { return this.DayiOrderId; }
            set { this.DayiOrderId = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary>  Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Kemu
        {            
            get { return this.Kemu; }
            set { this.Kemu = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _TearcharId
        {            
            get { return this.TearcharId; }
            set { this.TearcharId = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
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
        public string DayiOrderId
        {
            get { return this.m_dayiorderid; }
            set //
            {
                if (!dayiorderid_initialized || m_dayiorderid != value)
                {
                    this.m_dayiorderid = value;
                }
                dayiorderid_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Kemu
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TearcharId
        {
            get { return this.m_tearcharid; }
            set //
            {
                if (!tearcharid_initialized || m_tearcharid != value)
                {
                    this.m_tearcharid = value;
                }
                tearcharid_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string User_id
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
            
            /// <summary></summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xb_dayiorder].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem DayiOrderId =  new AttributeItem("[Xb_dayiorder].[DayiOrderId]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Grade =  new AttributeItem("[Xb_dayiorder].[Grade]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_dayiorder].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Kemu =  new AttributeItem("[Xb_dayiorder].[Kemu]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem TearcharId =  new AttributeItem("[Xb_dayiorder].[TearcharId]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_dayiorder].[User_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_dayiorderid;
        /// <summary></summary>
        protected bool dayiorderid_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_kemu;
        /// <summary></summary>
        protected bool kemu_initialized = false;
        
        private string m_tearcharid;
        /// <summary></summary>
        protected bool tearcharid_initialized = false;
        
        private string m_user_id;
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
            return "Xb_dayiorder";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.create_time_initialized = IsLoadAllAttributes;this.dayiorderid_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.kemu_initialized = IsLoadAllAttributes;this.tearcharid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_dayiorder value = new Xb_dayiorder();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DayiOrderId"))
				value.dayiorderid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu"))
				value.kemu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TearcharId"))
				value.tearcharid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_dayiorder Clone()
        {
            return (Xb_dayiorder)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_dayiorder()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_dayiorder() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_dayiorder(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_dayiorder(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_dayiorder(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_dayiorder(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_dayiorder(DateTime create_time1, string dayiorderid1, int grade1, int id1, string kemu1, string tearcharid1, string user_id1)
        {
            
            this.Create_time = create_time1;
            
            this.DayiOrderId = dayiorderid1;
            
            this.Grade = grade1;
            
            this.Id = id1;
            
            this.Kemu = kemu1;
            
            this.TearcharId = tearcharid1;
            
            this.User_id = user_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_dayiorder FromIView(IView view)
        {
            return (Xb_dayiorder)IView.GetITable(view, "Xb_dayiorder");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_dayiorder GetOneInstance()
        {
            Xb_dayiorder value = new Xb_dayiorder();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_dayiorder Retrieve()
        {
            BLLTable<Xb_dayiorder>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Create_time":
			        return Create_time;
			    			
			    case "DayiOrderId":
			        return DayiOrderId;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Kemu":
			        return Kemu;
			    			
			    case "TearcharId":
			        return TearcharId;
			    			
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
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "DayiOrderId":
			        this.DayiOrderId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Kemu":
			        this.Kemu = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TearcharId":
			        this.TearcharId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
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
				case "Create_time":
					return create_time_initialized;
				
				case "DayiOrderId":
					return dayiorderid_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Kemu":
					return kemu_initialized;
				
				case "TearcharId":
					return tearcharid_initialized;
				
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
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "DayiOrderId":
					dayiorderid_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Kemu":
					kemu_initialized = ret;
					return true;
				
				case "TearcharId":
					tearcharid_initialized = ret;
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

			
			if (create_time_initialized)
			{
                AttributeItem attr = Xb_dayiorder.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (dayiorderid_initialized)
			{
                AttributeItem attr = Xb_dayiorder.Attribute.DayiOrderId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DayiOrderId);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xb_dayiorder.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xb_dayiorder.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (kemu_initialized)
			{
                AttributeItem attr = Xb_dayiorder.Attribute.Kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu);
                }
			}
			
			if (tearcharid_initialized)
			{
                AttributeItem attr = Xb_dayiorder.Attribute.TearcharId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TearcharId);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_dayiorder.Attribute.User_id;
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
        public class Xb_dayiorderJson
        {
            
            /// <summary></summary>
            public DateTime Create_time { get; set; }
            
            /// <summary></summary>
            public string DayiOrderId { get; set; }
            
            /// <summary></summary>
            public int Grade { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public string Kemu { get; set; }
            
            /// <summary></summary>
            public string TearcharId { get; set; }
            
            /// <summary></summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:23
  Description:    ���ݱ�Xb_teacher_schedule��Ӧ��ҵ���߼���Xb_teacher_schedule
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_teacher_schedule_Entity:Xb_teacher_schedule
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,CreateTime,Date,IsPay,ModifyTime,Teacher_id,Time,Uuid from Xb_teacher_schedule
delete from Xb_teacher_schedule
INSERT INTO Xb_teacher_schedule (Id,CreateTime,Date,IsPay,ModifyTime,Teacher_id,Time,Uuid)
     VALUES
           ('','','','','','','','')
UPDATE Xb_teacher_schedule SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Date = valObj2.Date;
        valObj.IsPay = valObj2.IsPay;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Teacher_id = valObj2.Teacher_id;
        valObj.Time = valObj2.Time;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.CreateTime = "";
        valObj.Date = "";
        valObj.IsPay = "";
        valObj.ModifyTime = "";
        valObj.Teacher_id = "";
        valObj.Time = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Date": $("#txt_Date").val(),
        "IsPay": $("#txt_IsPay").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Teacher_id": $("#txt_Teacher_id").val(),
        "Time": $("#txt_Time").val(),
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
    /// <para>��Xb_teacher_schedule���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_teacher_schedule : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_teacher_schedule Factory()
        {
            return new Xb_teacher_schedule();
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
        public string _Date
        {            
            get { return this.Date; }
            set { this.Date = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsPay
        {            
            get { return this.IsPay; }
            set { this.IsPay = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher_id
        {            
            get { return this.Teacher_id; }
            set { this.Teacher_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Time
        {            
            get { return this.Time; }
            set { this.Time = value; }
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
        public string Date
        {
            get { return this.m_date; }
            set //
            {
                if (!date_initialized || m_date != value)
                {
                    this.m_date = value;
                }
                date_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool IsPay
        {
            get { return this.m_ispay; }
            set //
            {
                if (!ispay_initialized || m_ispay != value)
                {
                    this.m_ispay = value;
                }
                ispay_initialized = true;
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
        public string Time
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
            public static AttributeItem Id =  new AttributeItem("[Xb_teacher_schedule].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_teacher_schedule].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Date =  new AttributeItem("[Xb_teacher_schedule].[Date]", typeof(string), 10, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsPay =  new AttributeItem("[Xb_teacher_schedule].[IsPay]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_teacher_schedule].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_id =  new AttributeItem("[Xb_teacher_schedule].[Teacher_id]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Time =  new AttributeItem("[Xb_teacher_schedule].[Time]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_teacher_schedule].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_date;
        /// <summary></summary>
        protected bool date_initialized = false;
        
        private bool m_ispay;
        /// <summary></summary>
        protected bool ispay_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_teacher_id;
        /// <summary></summary>
        protected bool teacher_id_initialized = false;
        
        private string m_time;
        /// <summary></summary>
        protected bool time_initialized = false;
        
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
            return "Xb_teacher_schedule";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.date_initialized = IsLoadAllAttributes;this.ispay_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.teacher_id_initialized = IsLoadAllAttributes;this.time_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_teacher_schedule value = new Xb_teacher_schedule();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Date"))
				value.date_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsPay"))
				value.ispay_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_id"))
				value.teacher_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time"))
				value.time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_teacher_schedule Clone()
        {
            return (Xb_teacher_schedule)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_teacher_schedule()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_teacher_schedule() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_teacher_schedule(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_teacher_schedule(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_teacher_schedule(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_teacher_schedule(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_teacher_schedule(int id1, DateTime createtime1, string date1, bool ispay1, DateTime modifytime1, string teacher_id1, string time1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.CreateTime = createtime1;
            
            this.Date = date1;
            
            this.IsPay = ispay1;
            
            this.ModifyTime = modifytime1;
            
            this.Teacher_id = teacher_id1;
            
            this.Time = time1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_teacher_schedule FromIView(IView view)
        {
            return (Xb_teacher_schedule)IView.GetITable(view, "Xb_teacher_schedule");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_teacher_schedule GetOneInstance()
        {
            Xb_teacher_schedule value = new Xb_teacher_schedule();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_teacher_schedule Retrieve()
        {
            BLLTable<Xb_teacher_schedule>.GetRowData(this);
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
			    			
			    case "Date":
			        return Date;
			    			
			    case "IsPay":
			        return IsPay;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Teacher_id":
			        return Teacher_id;
			    			
			    case "Time":
			        return Time;
			    			
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
			    			
			    case "Date":
			        this.Date = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsPay":
			        this.IsPay = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Teacher_id":
			        this.Teacher_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Time":
			        this.Time = Convert.ToString(AttributeValue);
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
				
				case "Date":
					return date_initialized;
				
				case "IsPay":
					return ispay_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Teacher_id":
					return teacher_id_initialized;
				
				case "Time":
					return time_initialized;
				
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
				
				case "Date":
					date_initialized = ret;
					return true;
				
				case "IsPay":
					ispay_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Teacher_id":
					teacher_id_initialized = ret;
					return true;
				
				case "Time":
					time_initialized = ret;
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
                AttributeItem attr = Xb_teacher_schedule.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_teacher_schedule.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (date_initialized)
			{
                AttributeItem attr = Xb_teacher_schedule.Attribute.Date;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Date);
                }
			}
			
			if (ispay_initialized)
			{
                AttributeItem attr = Xb_teacher_schedule.Attribute.IsPay;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsPay);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_teacher_schedule.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (teacher_id_initialized)
			{
                AttributeItem attr = Xb_teacher_schedule.Attribute.Teacher_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_id);
                }
			}
			
			if (time_initialized)
			{
                AttributeItem attr = Xb_teacher_schedule.Attribute.Time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_teacher_schedule.Attribute.Uuid;
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
        public class Xb_teacher_scheduleJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Date { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsPay { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
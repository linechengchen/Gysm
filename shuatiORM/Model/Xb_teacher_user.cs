/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/8/4 16:32:44
  Description:    ���ݱ�Xb_teacher_user��Ӧ��ҵ���߼���Xb_teacher_user
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_teacher_user_Entity:Xb_teacher_user
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Jiaoyuan_category,Pay_category,Pay_jine,Pay_keshi,Teacher_uuid,User_id from Xb_teacher_user
delete from Xb_teacher_user
INSERT INTO Xb_teacher_user (Id,Jiaoyuan_category,Pay_category,Pay_jine,Pay_keshi,Teacher_uuid,User_id)
     VALUES
           ('','','','','','','')
UPDATE Xb_teacher_user SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Jiaoyuan_category = valObj2.Jiaoyuan_category;
        valObj.Pay_category = valObj2.Pay_category;
        valObj.Pay_jine = valObj2.Pay_jine;
        valObj.Pay_keshi = valObj2.Pay_keshi;
        valObj.Teacher_uuid = valObj2.Teacher_uuid;
        valObj.User_id = valObj2.User_id; 
        valObj.Id = "";
        valObj.Jiaoyuan_category = "";
        valObj.Pay_category = "";
        valObj.Pay_jine = "";
        valObj.Pay_keshi = "";
        valObj.Teacher_uuid = "";
        valObj.User_id = ""; 
        "Id": $("#txt_Id").val(),
        "Jiaoyuan_category": $("#txt_Jiaoyuan_category").val(),
        "Pay_category": $("#txt_Pay_category").val(),
        "Pay_jine": $("#txt_Pay_jine").val(),
        "Pay_keshi": $("#txt_Pay_keshi").val(),
        "Teacher_uuid": $("#txt_Teacher_uuid").val(),
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
    /// <para>��Xb_teacher_user���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_teacher_user : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_teacher_user Factory()
        {
            return new Xb_teacher_user();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �������:[Enum-{0:������},{1:��ǩԼ}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Jiaoyuan_category
        {            
            get { return this.Jiaoyuan_category; }
            set { this.Jiaoyuan_category = value; }
        }
        
        /// <summary> �������:[Enum-{0:�¸�},{1:����},{2:ѧ�ڸ�},{3:�긶}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Pay_category
        {            
            get { return this.Pay_category; }
            set { this.Pay_category = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Pay_jine
        {            
            get { return this.Pay_jine; }
            set { this.Pay_jine = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Pay_keshi
        {            
            get { return this.Pay_keshi; }
            set { this.Pay_keshi = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Teacher_uuid
        {            
            get { return this.Teacher_uuid; }
            set { this.Teacher_uuid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
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
        
        /// <summary> �������:[Enum-{0:������},{1:��ǩԼ}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Jiaoyuan_category
        {
            get { return this.m_jiaoyuan_category; }
            set //
            {
                if (!jiaoyuan_category_initialized || m_jiaoyuan_category != value)
                {
                    this.m_jiaoyuan_category = value;
                }
                jiaoyuan_category_initialized = true;
            }
        }
        
        /// <summary> �������:[Enum-{0:�¸�},{1:����},{2:ѧ�ڸ�},{3:�긶}][CtrlTypeDic-{SelectDrop}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Pay_category
        {
            get { return this.m_pay_category; }
            set //
            {
                if (!pay_category_initialized || m_pay_category != value)
                {
                    this.m_pay_category = value;
                }
                pay_category_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Pay_jine
        {
            get { return this.m_pay_jine; }
            set //
            {
                if (!pay_jine_initialized || m_pay_jine != value)
                {
                    this.m_pay_jine = value;
                }
                pay_jine_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Pay_keshi
        {
            get { return this.m_pay_keshi; }
            set //
            {
                if (!pay_keshi_initialized || m_pay_keshi != value)
                {
                    this.m_pay_keshi = value;
                }
                pay_keshi_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Teacher_uuid
        {
            get { return this.m_teacher_uuid; }
            set //
            {
                if (!teacher_uuid_initialized || m_teacher_uuid != value)
                {
                    this.m_teacher_uuid = value;
                }
                teacher_uuid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_teacher_user].[Id]", typeof(int), 4, default(int));
            
            /// <summary>�������:[Enum-{0:������},{1:��ǩԼ}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Jiaoyuan_category =  new AttributeItem("[Xb_teacher_user].[Jiaoyuan_category]", typeof(int), 4, default(int));
            
            /// <summary>�������:[Enum-{0:�¸�},{1:����},{2:ѧ�ڸ�},{3:�긶}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Pay_category =  new AttributeItem("[Xb_teacher_user].[Pay_category]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pay_jine =  new AttributeItem("[Xb_teacher_user].[Pay_jine]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pay_keshi =  new AttributeItem("[Xb_teacher_user].[Pay_keshi]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Teacher_uuid =  new AttributeItem("[Xb_teacher_user].[Teacher_uuid]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_teacher_user].[User_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_jiaoyuan_category;
        /// <summary></summary>
        protected bool jiaoyuan_category_initialized = false;
        
        private int m_pay_category;
        /// <summary></summary>
        protected bool pay_category_initialized = false;
        
        private int m_pay_jine;
        /// <summary></summary>
        protected bool pay_jine_initialized = false;
        
        private int m_pay_keshi;
        /// <summary></summary>
        protected bool pay_keshi_initialized = false;
        
        private string m_teacher_uuid;
        /// <summary></summary>
        protected bool teacher_uuid_initialized = false;
        
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
            return "Xb_teacher_user";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.jiaoyuan_category_initialized = IsLoadAllAttributes;this.pay_category_initialized = IsLoadAllAttributes;this.pay_jine_initialized = IsLoadAllAttributes;this.pay_keshi_initialized = IsLoadAllAttributes;this.teacher_uuid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_teacher_user value = new Xb_teacher_user();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Jiaoyuan_category"))
				value.jiaoyuan_category_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pay_category"))
				value.pay_category_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pay_jine"))
				value.pay_jine_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pay_keshi"))
				value.pay_keshi_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Teacher_uuid"))
				value.teacher_uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_teacher_user Clone()
        {
            return (Xb_teacher_user)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_teacher_user()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_teacher_user() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_teacher_user(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_teacher_user(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_teacher_user(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_teacher_user(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_teacher_user(int id1, int jiaoyuan_category1, int pay_category1, int pay_jine1, int pay_keshi1, string teacher_uuid1, string user_id1)
        {
            
            this.Id = id1;
            
            this.Jiaoyuan_category = jiaoyuan_category1;
            
            this.Pay_category = pay_category1;
            
            this.Pay_jine = pay_jine1;
            
            this.Pay_keshi = pay_keshi1;
            
            this.Teacher_uuid = teacher_uuid1;
            
            this.User_id = user_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_teacher_user FromIView(IView view)
        {
            return (Xb_teacher_user)IView.GetITable(view, "Xb_teacher_user");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_teacher_user GetOneInstance()
        {
            Xb_teacher_user value = new Xb_teacher_user();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_teacher_user Retrieve()
        {
            BLLTable<Xb_teacher_user>.GetRowData(this);
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
			    			
			    case "Jiaoyuan_category":
			        return Jiaoyuan_category;
			    			
			    case "Pay_category":
			        return Pay_category;
			    			
			    case "Pay_jine":
			        return Pay_jine;
			    			
			    case "Pay_keshi":
			        return Pay_keshi;
			    			
			    case "Teacher_uuid":
			        return Teacher_uuid;
			    			
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
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Jiaoyuan_category":
			        this.Jiaoyuan_category = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Pay_category":
			        this.Pay_category = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Pay_jine":
			        this.Pay_jine = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Pay_keshi":
			        this.Pay_keshi = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Teacher_uuid":
			        this.Teacher_uuid = Convert.ToString(AttributeValue);
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
				case "Id":
					return id_initialized;
				
				case "Jiaoyuan_category":
					return jiaoyuan_category_initialized;
				
				case "Pay_category":
					return pay_category_initialized;
				
				case "Pay_jine":
					return pay_jine_initialized;
				
				case "Pay_keshi":
					return pay_keshi_initialized;
				
				case "Teacher_uuid":
					return teacher_uuid_initialized;
				
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
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Jiaoyuan_category":
					jiaoyuan_category_initialized = ret;
					return true;
				
				case "Pay_category":
					pay_category_initialized = ret;
					return true;
				
				case "Pay_jine":
					pay_jine_initialized = ret;
					return true;
				
				case "Pay_keshi":
					pay_keshi_initialized = ret;
					return true;
				
				case "Teacher_uuid":
					teacher_uuid_initialized = ret;
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

			
			if (id_initialized)
			{
                AttributeItem attr = Xb_teacher_user.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (jiaoyuan_category_initialized)
			{
                AttributeItem attr = Xb_teacher_user.Attribute.Jiaoyuan_category;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Jiaoyuan_category);
                }
			}
			
			if (pay_category_initialized)
			{
                AttributeItem attr = Xb_teacher_user.Attribute.Pay_category;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pay_category);
                }
			}
			
			if (pay_jine_initialized)
			{
                AttributeItem attr = Xb_teacher_user.Attribute.Pay_jine;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pay_jine);
                }
			}
			
			if (pay_keshi_initialized)
			{
                AttributeItem attr = Xb_teacher_user.Attribute.Pay_keshi;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pay_keshi);
                }
			}
			
			if (teacher_uuid_initialized)
			{
                AttributeItem attr = Xb_teacher_user.Attribute.Teacher_uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Teacher_uuid);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_teacher_user.Attribute.User_id;
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
        public class Xb_teacher_userJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>�������:[Enum-{0:������},{1:��ǩԼ}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Jiaoyuan_category { get; set; }
            
            /// <summary>�������:[Enum-{0:�¸�},{1:����},{2:ѧ�ڸ�},{3:�긶}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Pay_category { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Pay_jine { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Pay_keshi { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Teacher_uuid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}
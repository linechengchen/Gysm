/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/14 21:42:55
  Description:    ���ݱ�Xb_kemuinfo_fav��Ӧ��ҵ���߼���Xb_kemuinfo_fav
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_kemuinfo_fav_Entity:Xb_kemuinfo_fav
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Is_fav,Kemu_id,Kemu_name,Student_id from Xb_kemuinfo_fav
delete from Xb_kemuinfo_fav
INSERT INTO Xb_kemuinfo_fav (Id,Is_fav,Kemu_id,Kemu_name,Student_id)
     VALUES
           ('','','','','')
UPDATE Xb_kemuinfo_fav SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Is_fav = valObj2.Is_fav;
        valObj.Kemu_id = valObj2.Kemu_id;
        valObj.Kemu_name = valObj2.Kemu_name;
        valObj.Student_id = valObj2.Student_id; 
        valObj.Id = "";
        valObj.Is_fav = "";
        valObj.Kemu_id = "";
        valObj.Kemu_name = "";
        valObj.Student_id = ""; 
        "Id": $("#txt_Id").val(),
        "Is_fav": $("#txt_Is_fav").val(),
        "Kemu_id": $("#txt_Kemu_id").val(),
        "Kemu_name": $("#txt_Kemu_name").val(),
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
    /// <para></para>
    /// <para>��Xb_kemuinfo_fav���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_kemuinfo_fav : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_kemuinfo_fav Factory()
        {
            return new Xb_kemuinfo_fav();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _Is_fav
        {            
            get { return this.Is_fav; }
            set { this.Is_fav = value; }
        }
        
        /// <summary> ��Ŀ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Kemu_id
        {            
            get { return this.Kemu_id; }
            set { this.Kemu_id = value; }
        }
        
        /// <summary> ��Ŀ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Kemu_name
        {            
            get { return this.Kemu_name; }
            set { this.Kemu_name = value; }
        }
        
        /// <summary> ѧ��֤:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Student_id
        {            
            get { return this.Student_id; }
            set { this.Student_id = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool Is_fav
        {
            get { return this.m_is_fav; }
            set //
            {
                if (!is_fav_initialized || m_is_fav != value)
                {
                    this.m_is_fav = value;
                }
                is_fav_initialized = true;
            }
        }
        
        /// <summary> ��Ŀ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Kemu_id
        {
            get { return this.m_kemu_id; }
            set //
            {
                if (!kemu_id_initialized || m_kemu_id != value)
                {
                    this.m_kemu_id = value;
                }
                kemu_id_initialized = true;
            }
        }
        
        /// <summary> ��Ŀ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Kemu_name
        {
            get { return this.m_kemu_name; }
            set //
            {
                if (!kemu_name_initialized || m_kemu_name != value)
                {
                    this.m_kemu_name = value;
                }
                kemu_name_initialized = true;
            }
        }
        
        /// <summary> ѧ��֤:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_kemuinfo_fav].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Is_fav =  new AttributeItem("[Xb_kemuinfo_fav].[Is_fav]", typeof(bool), 1, default(bool));
            
            /// <summary>��Ŀ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu_id =  new AttributeItem("[Xb_kemuinfo_fav].[Kemu_id]", typeof(int), 4, default(int));
            
            /// <summary>��Ŀ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu_name =  new AttributeItem("[Xb_kemuinfo_fav].[Kemu_name]", typeof(string), 50, default(string));
            
            /// <summary>ѧ��֤:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student_id =  new AttributeItem("[Xb_kemuinfo_fav].[Student_id]", typeof(string), 32, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private bool m_is_fav;
        /// <summary></summary>
        protected bool is_fav_initialized = false;
        
        private int m_kemu_id;
        /// <summary></summary>
        protected bool kemu_id_initialized = false;
        
        private string m_kemu_name;
        /// <summary></summary>
        protected bool kemu_name_initialized = false;
        
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
            return "Xb_kemuinfo_fav";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.is_fav_initialized = IsLoadAllAttributes;this.kemu_id_initialized = IsLoadAllAttributes;this.kemu_name_initialized = IsLoadAllAttributes;this.student_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_kemuinfo_fav value = new Xb_kemuinfo_fav();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_fav"))
				value.is_fav_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_id"))
				value.kemu_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_name"))
				value.kemu_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student_id"))
				value.student_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_kemuinfo_fav Clone()
        {
            return (Xb_kemuinfo_fav)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_kemuinfo_fav()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_kemuinfo_fav() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_kemuinfo_fav(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_kemuinfo_fav(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_kemuinfo_fav(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_kemuinfo_fav(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_kemuinfo_fav(int id1, bool is_fav1, int kemu_id1, string kemu_name1, string student_id1)
        {
            
            this.Id = id1;
            
            this.Is_fav = is_fav1;
            
            this.Kemu_id = kemu_id1;
            
            this.Kemu_name = kemu_name1;
            
            this.Student_id = student_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_kemuinfo_fav FromIView(IView view)
        {
            return (Xb_kemuinfo_fav)IView.GetITable(view, "Xb_kemuinfo_fav");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_kemuinfo_fav GetOneInstance()
        {
            Xb_kemuinfo_fav value = new Xb_kemuinfo_fav();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_kemuinfo_fav Retrieve()
        {
            BLLTable<Xb_kemuinfo_fav>.GetRowData(this);
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
			    			
			    case "Is_fav":
			        return Is_fav;
			    			
			    case "Kemu_id":
			        return Kemu_id;
			    			
			    case "Kemu_name":
			        return Kemu_name;
			    			
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
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Is_fav":
			        this.Is_fav = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Kemu_id":
			        this.Kemu_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Kemu_name":
			        this.Kemu_name = Convert.ToString(AttributeValue);
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
				case "Id":
					return id_initialized;
				
				case "Is_fav":
					return is_fav_initialized;
				
				case "Kemu_id":
					return kemu_id_initialized;
				
				case "Kemu_name":
					return kemu_name_initialized;
				
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
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Is_fav":
					is_fav_initialized = ret;
					return true;
				
				case "Kemu_id":
					kemu_id_initialized = ret;
					return true;
				
				case "Kemu_name":
					kemu_name_initialized = ret;
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

			
			if (id_initialized)
			{
                AttributeItem attr = Xb_kemuinfo_fav.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (is_fav_initialized)
			{
                AttributeItem attr = Xb_kemuinfo_fav.Attribute.Is_fav;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_fav);
                }
			}
			
			if (kemu_id_initialized)
			{
                AttributeItem attr = Xb_kemuinfo_fav.Attribute.Kemu_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_id);
                }
			}
			
			if (kemu_name_initialized)
			{
                AttributeItem attr = Xb_kemuinfo_fav.Attribute.Kemu_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_name);
                }
			}
			
			if (student_id_initialized)
			{
                AttributeItem attr = Xb_kemuinfo_fav.Attribute.Student_id;
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
        public class Xb_kemuinfo_favJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Is_fav { get; set; }
            
            /// <summary>��Ŀ���:[CtrlTypeDic-{InputString}]</summary>
            public int Kemu_id { get; set; }
            
            /// <summary>��Ŀ����:[CtrlTypeDic-{InputString}]</summary>
            public string Kemu_name { get; set; }
            
            /// <summary>ѧ��֤:[CtrlTypeDic-{InputString}]</summary>
            public string Student_id { get; set; }
        }
        #endregion
    }
}
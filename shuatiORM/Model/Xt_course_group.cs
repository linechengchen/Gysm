/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:31
  Description:    ���ݱ�Xt_course_group��Ӧ��ҵ���߼���Xt_course_group
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_course_group_Entity:Xt_course_group
 * 
************************************************************/
/************************************************************
SQL���룺
select Group_id,Course_id,Group_name,User_count from Xt_course_group
delete from Xt_course_group
INSERT INTO Xt_course_group (Group_id,Course_id,Group_name,User_count)
     VALUES
           ('','','','')
UPDATE Xt_course_group SET ...
������ֵ���룺
 *         valObj.Group_id = valObj2.Group_id;
        valObj.Course_id = valObj2.Course_id;
        valObj.Group_name = valObj2.Group_name;
        valObj.User_count = valObj2.User_count; 
        valObj.Group_id = "";
        valObj.Course_id = "";
        valObj.Group_name = "";
        valObj.User_count = ""; 
        "Group_id": $("#txt_Group_id").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Group_name": $("#txt_Group_name").val(),
        "User_count": $("#txt_User_count").val(), 
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
    /// <para>����</para>
    /// <para>��Xt_course_group���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_course_group : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_course_group Factory()
        {
            return new Xt_course_group();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ����ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Group_id
        {            
            get { return this.Group_id; }
            set { this.Group_id = value; }
        }
        
        /// <summary> �γ�ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Group_name
        {            
            get { return this.Group_name; }
            set { this.Group_name = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _User_count
        {            
            get { return this.User_count; }
            set { this.User_count = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ����ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid Group_id
        {
            get { return this.m_group_id; }
            set //
            {
                if (!group_id_initialized || m_group_id != value)
                {
                    this.m_group_id = value;
                }
                group_id_initialized = true;
            }
        }
        
        /// <summary> �γ�ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Group_name
        {
            get { return this.m_group_name; }
            set //
            {
                if (!group_name_initialized || m_group_name != value)
                {
                    this.m_group_name = value;
                }
                group_name_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int User_count
        {
            get { return this.m_user_count; }
            set //
            {
                if (!user_count_initialized || m_user_count != value)
                {
                    this.m_user_count = value;
                }
                user_count_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>����ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Group_id =  new AttributeItem("[Xt_course_group].[Group_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>�γ�ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_course_group].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Group_name =  new AttributeItem("[Xt_course_group].[Group_name]", typeof(string), 100, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_count =  new AttributeItem("[Xt_course_group].[User_count]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_group_id;
        /// <summary></summary>
        protected bool group_id_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_group_name;
        /// <summary></summary>
        protected bool group_name_initialized = false;
        
        private int m_user_count;
        /// <summary></summary>
        protected bool user_count_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_course_group";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.group_id_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.group_name_initialized = IsLoadAllAttributes;this.user_count_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_course_group value = new Xt_course_group();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Group_id"))
				value.group_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Group_name"))
				value.group_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_count"))
				value.user_count_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_course_group Clone()
        {
            return (Xt_course_group)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_course_group()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_course_group() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_course_group(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_course_group(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_course_group(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_course_group(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_course_group(Guid group_id1, string course_id1, string group_name1, int user_count1)
        {
            
            this.Group_id = group_id1;
            
            this.Course_id = course_id1;
            
            this.Group_name = group_name1;
            
            this.User_count = user_count1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_course_group FromIView(IView view)
        {
            return (Xt_course_group)IView.GetITable(view, "Xt_course_group");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_course_group GetOneInstance()
        {
            Xt_course_group value = new Xt_course_group();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_course_group Retrieve()
        {
            BLLTable<Xt_course_group>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Group_id":
			        return Group_id;
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Group_name":
			        return Group_name;
			    			
			    case "User_count":
			        return User_count;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Group_id":
			        this.Group_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Group_name":
			        this.Group_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_count":
			        this.User_count = Convert.ToInt32(AttributeValue);
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
				case "Group_id":
					return group_id_initialized;
				
				case "Course_id":
					return course_id_initialized;
				
				case "Group_name":
					return group_name_initialized;
				
				case "User_count":
					return user_count_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Group_id":
					group_id_initialized = ret;
					return true;
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Group_name":
					group_name_initialized = ret;
					return true;
				
				case "User_count":
					user_count_initialized = ret;
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

			
			if (group_id_initialized)
			{
                AttributeItem attr = Xt_course_group.Attribute.Group_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Group_id);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_course_group.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (group_name_initialized)
			{
                AttributeItem attr = Xt_course_group.Attribute.Group_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Group_name);
                }
			}
			
			if (user_count_initialized)
			{
                AttributeItem attr = Xt_course_group.Attribute.User_count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_count);
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
        public class Xt_course_groupJson
        {
            
            /// <summary>����ID:[CtrlTypeDic-{InputString}]</summary>
            public Guid Group_id { get; set; }
            
            /// <summary>�γ�ID:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>������:[CtrlTypeDic-{InputString}]</summary>
            public string Group_name { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public int User_count { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/13 16:45:08
  Description:    ���ݱ�St_read_user��Ӧ��ҵ���߼���St_read_user
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� St_read_user_Entity:St_read_user
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Chapter_id,Line_id,Line_index,Openid,Read_time,User_id from St_read_user
delete from St_read_user
INSERT INTO St_read_user (Id,Chapter_id,Line_id,Line_index,Openid,Read_time,User_id)
     VALUES
           ('','','','','','','')
UPDATE St_read_user SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Chapter_id = valObj2.Chapter_id;
        valObj.Line_id = valObj2.Line_id;
        valObj.Line_index = valObj2.Line_index;
        valObj.Openid = valObj2.Openid;
        valObj.Read_time = valObj2.Read_time;
        valObj.User_id = valObj2.User_id; 
        valObj.Id = "";
        valObj.Chapter_id = "";
        valObj.Line_id = "";
        valObj.Line_index = "";
        valObj.Openid = "";
        valObj.Read_time = "";
        valObj.User_id = ""; 
        "Id": $("#txt_Id").val(),
        "Chapter_id": $("#txt_Chapter_id").val(),
        "Line_id": $("#txt_Line_id").val(),
        "Line_index": $("#txt_Line_index").val(),
        "Openid": $("#txt_Openid").val(),
        "Read_time": $("#txt_Read_time").val(),
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
    /// <para>��St_read_user���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class St_read_user : ITableImplement
    {
        /// <summary>��������  </summary>
        public static St_read_user Factory()
        {
            return new St_read_user();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Chapter_id
        {            
            get { return this.Chapter_id; }
            set { this.Chapter_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Line_id
        {            
            get { return this.Line_id; }
            set { this.Line_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Line_index
        {            
            get { return this.Line_index; }
            set { this.Line_index = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Openid
        {            
            get { return this.Openid; }
            set { this.Openid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Read_time
        {            
            get { return this.Read_time; }
            set { this.Read_time = value; }
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
            set //
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Chapter_id
        {
            get { return this.m_chapter_id; }
            set //
            {
                if (!chapter_id_initialized || m_chapter_id != value)
                {
                    this.m_chapter_id = value;
                }
                chapter_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Line_id
        {
            get { return this.m_line_id; }
            set //
            {
                if (!line_id_initialized || m_line_id != value)
                {
                    this.m_line_id = value;
                }
                line_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Line_index
        {
            get { return this.m_line_index; }
            set //
            {
                if (!line_index_initialized || m_line_index != value)
                {
                    this.m_line_index = value;
                }
                line_index_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Openid
        {
            get { return this.m_openid; }
            set //
            {
                if (!openid_initialized || m_openid != value)
                {
                    this.m_openid = value;
                }
                openid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Read_time
        {
            get { return this.m_read_time; }
            set //
            {
                if (!read_time_initialized || m_read_time != value)
                {
                    this.m_read_time = value;
                }
                read_time_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[St_read_user].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Chapter_id =  new AttributeItem("[St_read_user].[Chapter_id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Line_id =  new AttributeItem("[St_read_user].[Line_id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Line_index =  new AttributeItem("[St_read_user].[Line_index]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Openid =  new AttributeItem("[St_read_user].[Openid]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Read_time =  new AttributeItem("[St_read_user].[Read_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[St_read_user].[User_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_chapter_id;
        /// <summary></summary>
        protected bool chapter_id_initialized = false;
        
        private int m_line_id;
        /// <summary></summary>
        protected bool line_id_initialized = false;
        
        private int m_line_index;
        /// <summary></summary>
        protected bool line_index_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private DateTime m_read_time;
        /// <summary></summary>
        protected bool read_time_initialized = false;
        
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
            return "St_read_user";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.chapter_id_initialized = IsLoadAllAttributes;this.line_id_initialized = IsLoadAllAttributes;this.line_index_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.read_time_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_read_user value = new St_read_user();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Chapter_id"))
				value.chapter_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Line_id"))
				value.line_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Line_index"))
				value.line_index_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Openid"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Read_time"))
				value.read_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new St_read_user Clone()
        {
            return (St_read_user)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static St_read_user()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public St_read_user() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public St_read_user(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public St_read_user(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public St_read_user(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public St_read_user(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public St_read_user(int id1, int chapter_id1, int line_id1, int line_index1, string openid1, DateTime read_time1, string user_id1)
        {
            
            this.Id = id1;
            
            this.Chapter_id = chapter_id1;
            
            this.Line_id = line_id1;
            
            this.Line_index = line_index1;
            
            this.Openid = openid1;
            
            this.Read_time = read_time1;
            
            this.User_id = user_id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static St_read_user FromIView(IView view)
        {
            return (St_read_user)IView.GetITable(view, "St_read_user");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static St_read_user GetOneInstance()
        {
            St_read_user value = new St_read_user();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public St_read_user Retrieve()
        {
            BLLTable<St_read_user>.GetRowData(this);
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
			    			
			    case "Chapter_id":
			        return Chapter_id;
			    			
			    case "Line_id":
			        return Line_id;
			    			
			    case "Line_index":
			        return Line_index;
			    			
			    case "Openid":
			        return Openid;
			    			
			    case "Read_time":
			        return Read_time;
			    			
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
			    			
			    case "Chapter_id":
			        this.Chapter_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Line_id":
			        this.Line_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Line_index":
			        this.Line_index = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Openid":
			        this.Openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Read_time":
			        this.Read_time = Convert.ToDateTime(AttributeValue);
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
				
				case "Chapter_id":
					return chapter_id_initialized;
				
				case "Line_id":
					return line_id_initialized;
				
				case "Line_index":
					return line_index_initialized;
				
				case "Openid":
					return openid_initialized;
				
				case "Read_time":
					return read_time_initialized;
				
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
				
				case "Chapter_id":
					chapter_id_initialized = ret;
					return true;
				
				case "Line_id":
					line_id_initialized = ret;
					return true;
				
				case "Line_index":
					line_index_initialized = ret;
					return true;
				
				case "Openid":
					openid_initialized = ret;
					return true;
				
				case "Read_time":
					read_time_initialized = ret;
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
                AttributeItem attr = St_read_user.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (chapter_id_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Chapter_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Chapter_id);
                }
			}
			
			if (line_id_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Line_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Line_id);
                }
			}
			
			if (line_index_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Line_index;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Line_index);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Openid);
                }
			}
			
			if (read_time_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.Read_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Read_time);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = St_read_user.Attribute.User_id;
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
        public class St_read_userJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Chapter_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Line_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Line_index { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Openid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Read_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
        }
        #endregion
    }
}
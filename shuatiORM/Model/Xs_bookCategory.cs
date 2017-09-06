/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:30
  Description:    ���ݱ�Xs_bookCategory��Ӧ��ҵ���߼���Xs_bookCategory
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xs_bookCategory_Entity:Xs_bookCategory
 * 
************************************************************/
/************************************************************
SQL���룺
select AutoId,Id,Name,Path,PId,IdPath,NamePath,SubCategoryJson,Level,Count,Type from Xs_bookCategory
delete from Xs_bookCategory
INSERT INTO Xs_bookCategory (AutoId,Id,Name,Path,PId,IdPath,NamePath,SubCategoryJson,Level,Count,Type)
     VALUES
           ('','','','','','','','','','','')
UPDATE Xs_bookCategory SET ...
������ֵ���룺
 *         valObj.AutoId = valObj2.AutoId;
        valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.Path = valObj2.Path;
        valObj.PId = valObj2.PId;
        valObj.IdPath = valObj2.IdPath;
        valObj.NamePath = valObj2.NamePath;
        valObj.SubCategoryJson = valObj2.SubCategoryJson;
        valObj.Level = valObj2.Level;
        valObj.Count = valObj2.Count;
        valObj.Type = valObj2.Type; 
        valObj.AutoId = "";
        valObj.Id = "";
        valObj.Name = "";
        valObj.Path = "";
        valObj.PId = "";
        valObj.IdPath = "";
        valObj.NamePath = "";
        valObj.SubCategoryJson = "";
        valObj.Level = "";
        valObj.Count = "";
        valObj.Type = ""; 
        "AutoId": $("#txt_AutoId").val(),
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "Path": $("#txt_Path").val(),
        "PId": $("#txt_PId").val(),
        "IdPath": $("#txt_IdPath").val(),
        "NamePath": $("#txt_NamePath").val(),
        "SubCategoryJson": $("#txt_SubCategoryJson").val(),
        "Level": $("#txt_Level").val(),
        "Count": $("#txt_Count").val(),
        "Type": $("#txt_Type").val(), 
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
    /// <para>ͼ���������</para>
    /// <para>��Xs_bookCategory���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xs_bookCategory : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xs_bookCategory Factory()
        {
            return new Xs_bookCategory();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> �Զ�ID:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _AutoId
        {            
            get { return this.AutoId; }
            set { this.AutoId = value; }
        }
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> ·��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Path
        {            
            get { return this.Path; }
            set { this.Path = value; }
        }
        
        /// <summary> ����ĿId:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PId
        {            
            get { return this.PId; }
            set { this.PId = value; }
        }
        
        /// <summary> �ҵ�·��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _IdPath
        {            
            get { return this.IdPath; }
            set { this.IdPath = value; }
        }
        
        /// <summary> ����·��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _NamePath
        {            
            get { return this.NamePath; }
            set { this.NamePath = value; }
        }
        
        /// <summary> ����JSON:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _SubCategoryJson
        {            
            get { return this.SubCategoryJson; }
            set { this.SubCategoryJson = value; }
        }
        
        /// <summary> �����û��ȼ�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Level
        {            
            get { return this.Level; }
            set { this.Level = value; }
        }
        
        /// <summary> ����ͳ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Count
        {            
            get { return this.Count; }
            set { this.Count = value; }
        }
        
        /// <summary> ���෽��category0-post_tag1:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> �Զ�ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int AutoId
        {
            get { return this.m_autoid; }
            set //private 
            {
                if (!autoid_initialized || m_autoid != value)
                {
                    this.m_autoid = value;
                }
                autoid_initialized = true;
            }
        }
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Name
        {
            get { return this.m_name; }
            set //
            {
                if (!name_initialized || m_name != value)
                {
                    this.m_name = value;
                }
                name_initialized = true;
            }
        }
        
        /// <summary> ·��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Path
        {
            get { return this.m_path; }
            set //
            {
                if (!path_initialized || m_path != value)
                {
                    this.m_path = value;
                }
                path_initialized = true;
            }
        }
        
        /// <summary> ����ĿId:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int PId
        {
            get { return this.m_pid; }
            set //
            {
                if (!pid_initialized || m_pid != value)
                {
                    this.m_pid = value;
                }
                pid_initialized = true;
            }
        }
        
        /// <summary> �ҵ�·��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string IdPath
        {
            get { return this.m_idpath; }
            set //
            {
                if (!idpath_initialized || m_idpath != value)
                {
                    this.m_idpath = value;
                }
                idpath_initialized = true;
            }
        }
        
        /// <summary> ����·��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string NamePath
        {
            get { return this.m_namepath; }
            set //
            {
                if (!namepath_initialized || m_namepath != value)
                {
                    this.m_namepath = value;
                }
                namepath_initialized = true;
            }
        }
        
        /// <summary> ����JSON:[CtrlTypeDic-{HTML}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SubCategoryJson
        {
            get { return this.m_subcategoryjson; }
            set //
            {
                if (!subcategoryjson_initialized || m_subcategoryjson != value)
                {
                    this.m_subcategoryjson = value;
                }
                subcategoryjson_initialized = true;
            }
        }
        
        /// <summary> �����û��ȼ�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Level
        {
            get { return this.m_level; }
            set //
            {
                if (!level_initialized || m_level != value)
                {
                    this.m_level = value;
                }
                level_initialized = true;
            }
        }
        
        /// <summary> ����ͳ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Count
        {
            get { return this.m_count; }
            set //
            {
                if (!count_initialized || m_count != value)
                {
                    this.m_count = value;
                }
                count_initialized = true;
            }
        }
        
        /// <summary> ���෽��category0-post_tag1:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Type
        {
            get { return this.m_type; }
            set //
            {
                if (!type_initialized || m_type != value)
                {
                    this.m_type = value;
                }
                type_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>�Զ�ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AutoId =  new AttributeItem("[Xs_bookCategory].[AutoId]", typeof(int), 4, default(int));
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xs_bookCategory].[Id]", typeof(int), 4, default(int));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xs_bookCategory].[Name]", typeof(string), 50, default(string));
            
            /// <summary>·��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Path =  new AttributeItem("[Xs_bookCategory].[Path]", typeof(string), 200, default(string));
            
            /// <summary>����ĿId:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PId =  new AttributeItem("[Xs_bookCategory].[PId]", typeof(int), 4, default(int));
            
            /// <summary>�ҵ�·��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem IdPath =  new AttributeItem("[Xs_bookCategory].[IdPath]", typeof(string), 200, default(string));
            
            /// <summary>����·��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem NamePath =  new AttributeItem("[Xs_bookCategory].[NamePath]", typeof(string), 200, default(string));
            
            /// <summary>����JSON:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem SubCategoryJson =  new AttributeItem("[Xs_bookCategory].[SubCategoryJson]", typeof(string), 2000, default(string));
            
            /// <summary>�����û��ȼ�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Level =  new AttributeItem("[Xs_bookCategory].[Level]", typeof(int), 4, default(int));
            
            /// <summary>����ͳ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Count =  new AttributeItem("[Xs_bookCategory].[Count]", typeof(int), 4, default(int));
            
            /// <summary>���෽��category0-post_tag1:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xs_bookCategory].[Type]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_autoid;
        /// <summary></summary>
        protected bool autoid_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_path;
        /// <summary></summary>
        protected bool path_initialized = false;
        
        private int m_pid;
        /// <summary></summary>
        protected bool pid_initialized = false;
        
        private string m_idpath;
        /// <summary></summary>
        protected bool idpath_initialized = false;
        
        private string m_namepath;
        /// <summary></summary>
        protected bool namepath_initialized = false;
        
        private string m_subcategoryjson;
        /// <summary></summary>
        protected bool subcategoryjson_initialized = false;
        
        private int m_level;
        /// <summary></summary>
        protected bool level_initialized = false;
        
        private int m_count;
        /// <summary></summary>
        protected bool count_initialized = false;
        
        private int m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xs_bookCategory";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.autoid_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.path_initialized = IsLoadAllAttributes;this.pid_initialized = IsLoadAllAttributes;this.idpath_initialized = IsLoadAllAttributes;this.namepath_initialized = IsLoadAllAttributes;this.subcategoryjson_initialized = IsLoadAllAttributes;this.level_initialized = IsLoadAllAttributes;this.count_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xs_bookCategory value = new Xs_bookCategory();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"AutoId"))
				value.autoid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Path"))
				value.path_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PId"))
				value.pid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IdPath"))
				value.idpath_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NamePath"))
				value.namepath_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SubCategoryJson"))
				value.subcategoryjson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Level"))
				value.level_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Count"))
				value.count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xs_bookCategory Clone()
        {
            return (Xs_bookCategory)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xs_bookCategory()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xs_bookCategory() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xs_bookCategory(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xs_bookCategory(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xs_bookCategory(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xs_bookCategory(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xs_bookCategory(int autoid1, int id1, string name1, string path1, int pid1, string idpath1, string namepath1, string subcategoryjson1, int level1, int count1, int type1)
        {
            
            this.AutoId = autoid1;
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.Path = path1;
            
            this.PId = pid1;
            
            this.IdPath = idpath1;
            
            this.NamePath = namepath1;
            
            this.SubCategoryJson = subcategoryjson1;
            
            this.Level = level1;
            
            this.Count = count1;
            
            this.Type = type1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xs_bookCategory FromIView(IView view)
        {
            return (Xs_bookCategory)IView.GetITable(view, "Xs_bookCategory");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xs_bookCategory GetOneInstance()
        {
            Xs_bookCategory value = new Xs_bookCategory();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xs_bookCategory Retrieve()
        {
            BLLTable<Xs_bookCategory>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        return AutoId;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Path":
			        return Path;
			    			
			    case "PId":
			        return PId;
			    			
			    case "IdPath":
			        return IdPath;
			    			
			    case "NamePath":
			        return NamePath;
			    			
			    case "SubCategoryJson":
			        return SubCategoryJson;
			    			
			    case "Level":
			        return Level;
			    			
			    case "Count":
			        return Count;
			    			
			    case "Type":
			        return Type;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "AutoId":
			        this.AutoId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Path":
			        this.Path = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PId":
			        this.PId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "IdPath":
			        this.IdPath = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "NamePath":
			        this.NamePath = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SubCategoryJson":
			        this.SubCategoryJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Level":
			        this.Level = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Count":
			        this.Count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToInt32(AttributeValue);
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
				case "AutoId":
					return autoid_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Path":
					return path_initialized;
				
				case "PId":
					return pid_initialized;
				
				case "IdPath":
					return idpath_initialized;
				
				case "NamePath":
					return namepath_initialized;
				
				case "SubCategoryJson":
					return subcategoryjson_initialized;
				
				case "Level":
					return level_initialized;
				
				case "Count":
					return count_initialized;
				
				case "Type":
					return type_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "AutoId":
					autoid_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Path":
					path_initialized = ret;
					return true;
				
				case "PId":
					pid_initialized = ret;
					return true;
				
				case "IdPath":
					idpath_initialized = ret;
					return true;
				
				case "NamePath":
					namepath_initialized = ret;
					return true;
				
				case "SubCategoryJson":
					subcategoryjson_initialized = ret;
					return true;
				
				case "Level":
					level_initialized = ret;
					return true;
				
				case "Count":
					count_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
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

			
			if (autoid_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.AutoId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AutoId);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (path_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Path;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Path);
                }
			}
			
			if (pid_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.PId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PId);
                }
			}
			
			if (idpath_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.IdPath;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IdPath);
                }
			}
			
			if (namepath_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.NamePath;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NamePath);
                }
			}
			
			if (subcategoryjson_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.SubCategoryJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SubCategoryJson);
                }
			}
			
			if (level_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Level;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Level);
                }
			}
			
			if (count_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Count);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xs_bookCategory.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
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
        public class Xs_bookCategoryJson
        {
            
            /// <summary>�Զ�ID:[CtrlTypeDic-{InputString}]</summary>
            public int AutoId { get; set; }
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>·��:[CtrlTypeDic-{InputString}]</summary>
            public string Path { get; set; }
            
            /// <summary>����ĿId:[CtrlTypeDic-{InputString}]</summary>
            public int PId { get; set; }
            
            /// <summary>�ҵ�·��:[CtrlTypeDic-{InputString}]</summary>
            public string IdPath { get; set; }
            
            /// <summary>����·��:[CtrlTypeDic-{InputString}]</summary>
            public string NamePath { get; set; }
            
            /// <summary>����JSON:[CtrlTypeDic-{HTML}]</summary>
            public string SubCategoryJson { get; set; }
            
            /// <summary>�����û��ȼ�:[CtrlTypeDic-{InputString}]</summary>
            public int Level { get; set; }
            
            /// <summary>����ͳ��:[CtrlTypeDic-{InputString}]</summary>
            public int Count { get; set; }
            
            /// <summary>���෽��category0-post_tag1:[CtrlTypeDic-{InputString}]</summary>
            public int Type { get; set; }
        }
        #endregion
    }
}
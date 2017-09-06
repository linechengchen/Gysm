/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/13 16:45:08
  Description:    ���ݱ�St_read_chapter��Ӧ��ҵ���߼���St_read_chapter
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� St_read_chapter_Entity:St_read_chapter
 * 
************************************************************/
/************************************************************
SQL���룺
select Book_id,Chapter_name,File_name,Id from St_read_chapter
delete from St_read_chapter
INSERT INTO St_read_chapter (Book_id,Chapter_name,File_name,Id)
     VALUES
           ('','','','')
UPDATE St_read_chapter SET ...
������ֵ���룺
 *         valObj.Book_id = valObj2.Book_id;
        valObj.Chapter_name = valObj2.Chapter_name;
        valObj.File_name = valObj2.File_name;
        valObj.Id = valObj2.Id; 
        valObj.Book_id = "";
        valObj.Chapter_name = "";
        valObj.File_name = "";
        valObj.Id = ""; 
        "Book_id": $("#txt_Book_id").val(),
        "Chapter_name": $("#txt_Chapter_name").val(),
        "File_name": $("#txt_File_name").val(),
        "Id": $("#txt_Id").val(), 
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
    /// <para>��St_read_chapter���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class St_read_chapter : ITableImplement
    {
        /// <summary>��������  </summary>
        public static St_read_chapter Factory()
        {
            return new St_read_chapter();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> �½ڱ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Book_id
        {            
            get { return this.Book_id; }
            set { this.Book_id = value; }
        }
        
        /// <summary> �½ڱ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Chapter_name
        {            
            get { return this.Chapter_name; }
            set { this.Chapter_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _File_name
        {            
            get { return this.File_name; }
            set { this.File_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> �½ڱ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Book_id
        {
            get { return this.m_book_id; }
            set //
            {
                if (!book_id_initialized || m_book_id != value)
                {
                    this.m_book_id = value;
                }
                book_id_initialized = true;
            }
        }
        
        /// <summary> �½ڱ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Chapter_name
        {
            get { return this.m_chapter_name; }
            set //
            {
                if (!chapter_name_initialized || m_chapter_name != value)
                {
                    this.m_chapter_name = value;
                }
                chapter_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{SmallText}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string File_name
        {
            get { return this.m_file_name; }
            set //
            {
                if (!file_name_initialized || m_file_name != value)
                {
                    this.m_file_name = value;
                }
                file_name_initialized = true;
            }
        }
        
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>�½ڱ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Book_id =  new AttributeItem("[St_read_chapter].[Book_id]", typeof(int), 4, default(int));
            
            /// <summary>�½ڱ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Chapter_name =  new AttributeItem("[St_read_chapter].[Chapter_name]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem File_name =  new AttributeItem("[St_read_chapter].[File_name]", typeof(string), 300, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_read_chapter].[Id]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_book_id;
        /// <summary></summary>
        protected bool book_id_initialized = false;
        
        private string m_chapter_name;
        /// <summary></summary>
        protected bool chapter_name_initialized = false;
        
        private string m_file_name;
        /// <summary></summary>
        protected bool file_name_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_read_chapter";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.book_id_initialized = IsLoadAllAttributes;this.chapter_name_initialized = IsLoadAllAttributes;this.file_name_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_read_chapter value = new St_read_chapter();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Book_id"))
				value.book_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Chapter_name"))
				value.chapter_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"File_name"))
				value.file_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new St_read_chapter Clone()
        {
            return (St_read_chapter)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static St_read_chapter()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public St_read_chapter() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public St_read_chapter(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public St_read_chapter(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public St_read_chapter(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public St_read_chapter(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public St_read_chapter(int book_id1, string chapter_name1, string file_name1, int id1)
        {
            
            this.Book_id = book_id1;
            
            this.Chapter_name = chapter_name1;
            
            this.File_name = file_name1;
            
            this.Id = id1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static St_read_chapter FromIView(IView view)
        {
            return (St_read_chapter)IView.GetITable(view, "St_read_chapter");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static St_read_chapter GetOneInstance()
        {
            St_read_chapter value = new St_read_chapter();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public St_read_chapter Retrieve()
        {
            BLLTable<St_read_chapter>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Book_id":
			        return Book_id;
			    			
			    case "Chapter_name":
			        return Chapter_name;
			    			
			    case "File_name":
			        return File_name;
			    			
			    case "Id":
			        return Id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Book_id":
			        this.Book_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Chapter_name":
			        this.Chapter_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "File_name":
			        this.File_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
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
				case "Book_id":
					return book_id_initialized;
				
				case "Chapter_name":
					return chapter_name_initialized;
				
				case "File_name":
					return file_name_initialized;
				
				case "Id":
					return id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Book_id":
					book_id_initialized = ret;
					return true;
				
				case "Chapter_name":
					chapter_name_initialized = ret;
					return true;
				
				case "File_name":
					file_name_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
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

			
			if (book_id_initialized)
			{
                AttributeItem attr = St_read_chapter.Attribute.Book_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Book_id);
                }
			}
			
			if (chapter_name_initialized)
			{
                AttributeItem attr = St_read_chapter.Attribute.Chapter_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Chapter_name);
                }
			}
			
			if (file_name_initialized)
			{
                AttributeItem attr = St_read_chapter.Attribute.File_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(File_name);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = St_read_chapter.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
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
        public class St_read_chapterJson
        {
            
            /// <summary>�½ڱ��:[CtrlTypeDic-{InputString}]</summary>
            public int Book_id { get; set; }
            
            /// <summary>�½ڱ��:[CtrlTypeDic-{InputString}]</summary>
            public string Chapter_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{SmallText}]</summary>
            public string File_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    ���ݱ�TErrQestionPhoto��Ӧ��ҵ���߼���TErrQestionPhoto
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TErrQestionPhoto_Entity:TErrQestionPhoto
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,PhotoImg,StudentId,Kemu from TErrQestionPhoto
delete from TErrQestionPhoto
INSERT INTO TErrQestionPhoto (Id,PhotoImg,StudentId,Kemu)
     VALUES
           ('','','','')
UPDATE TErrQestionPhoto SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.PhotoImg = valObj2.PhotoImg;
        valObj.StudentId = valObj2.StudentId;
        valObj.Kemu = valObj2.Kemu; 
        valObj.Id = "";
        valObj.PhotoImg = "";
        valObj.StudentId = "";
        valObj.Kemu = ""; 
        "Id": $("#txt_Id").val(),
        "PhotoImg": $("#txt_PhotoImg").val(),
        "StudentId": $("#txt_StudentId").val(),
        "Kemu": $("#txt_Kemu").val(), 
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
    /// <para>�����������Ƭ</para>
    /// <para>��TErrQestionPhoto���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TErrQestionPhoto : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TErrQestionPhoto Factory()
        {
            return new TErrQestionPhoto();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ��ƬIMG:[CtrlTypeDic-{SmallText}] Attribute_IsNotNull </summary>
        public string _PhotoImg
        {            
            get { return this.PhotoImg; }
            set { this.PhotoImg = value; }
        }
        
        /// <summary> ѧ��֤:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _StudentId
        {            
            get { return this.StudentId; }
            set { this.StudentId = value; }
        }
        
        /// <summary> ��ľ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Kemu
        {            
            get { return this.Kemu; }
            set { this.Kemu = value; }
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
        
        /// <summary> ��ƬIMG:[CtrlTypeDic-{SmallText}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PhotoImg
        {
            get { return this.m_photoimg; }
            set //
            {
                if (!photoimg_initialized || m_photoimg != value)
                {
                    this.m_photoimg = value;
                }
                photoimg_initialized = true;
            }
        }
        
        /// <summary> ѧ��֤:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int StudentId
        {
            get { return this.m_studentid; }
            set //
            {
                if (!studentid_initialized || m_studentid != value)
                {
                    this.m_studentid = value;
                }
                studentid_initialized = true;
            }
        }
        
        /// <summary> ��ľ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[TErrQestionPhoto].[Id]", typeof(int), 4, default(int));
            
            /// <summary>��ƬIMG:[CtrlTypeDic-{SmallText}]</summary>
            public static AttributeItem PhotoImg =  new AttributeItem("[TErrQestionPhoto].[PhotoImg]", typeof(string), 300, default(string));
            
            /// <summary>ѧ��֤:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem StudentId =  new AttributeItem("[TErrQestionPhoto].[StudentId]", typeof(int), 4, default(int));
            
            /// <summary>��ľ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu =  new AttributeItem("[TErrQestionPhoto].[Kemu]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_photoimg;
        /// <summary></summary>
        protected bool photoimg_initialized = false;
        
        private int m_studentid;
        /// <summary></summary>
        protected bool studentid_initialized = false;
        
        private string m_kemu;
        /// <summary></summary>
        protected bool kemu_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TErrQestionPhoto";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.photoimg_initialized = IsLoadAllAttributes;this.studentid_initialized = IsLoadAllAttributes;this.kemu_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TErrQestionPhoto value = new TErrQestionPhoto();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PhotoImg"))
				value.photoimg_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"StudentId"))
				value.studentid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu"))
				value.kemu_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TErrQestionPhoto Clone()
        {
            return (TErrQestionPhoto)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TErrQestionPhoto()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TErrQestionPhoto() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TErrQestionPhoto(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TErrQestionPhoto(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TErrQestionPhoto(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TErrQestionPhoto(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TErrQestionPhoto(int id1, string photoimg1, int studentid1, string kemu1)
        {
            
            this.Id = id1;
            
            this.PhotoImg = photoimg1;
            
            this.StudentId = studentid1;
            
            this.Kemu = kemu1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TErrQestionPhoto FromIView(IView view)
        {
            return (TErrQestionPhoto)IView.GetITable(view, "TErrQestionPhoto");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TErrQestionPhoto GetOneInstance()
        {
            TErrQestionPhoto value = new TErrQestionPhoto();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TErrQestionPhoto Retrieve()
        {
            BLLTable<TErrQestionPhoto>.GetRowData(this);
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
			    			
			    case "PhotoImg":
			        return PhotoImg;
			    			
			    case "StudentId":
			        return StudentId;
			    			
			    case "Kemu":
			        return Kemu;
			
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
			    			
			    case "PhotoImg":
			        this.PhotoImg = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "StudentId":
			        this.StudentId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Kemu":
			        this.Kemu = Convert.ToString(AttributeValue);
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
				
				case "PhotoImg":
					return photoimg_initialized;
				
				case "StudentId":
					return studentid_initialized;
				
				case "Kemu":
					return kemu_initialized;
				
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
				
				case "PhotoImg":
					photoimg_initialized = ret;
					return true;
				
				case "StudentId":
					studentid_initialized = ret;
					return true;
				
				case "Kemu":
					kemu_initialized = ret;
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
                AttributeItem attr = TErrQestionPhoto.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (photoimg_initialized)
			{
                AttributeItem attr = TErrQestionPhoto.Attribute.PhotoImg;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PhotoImg);
                }
			}
			
			if (studentid_initialized)
			{
                AttributeItem attr = TErrQestionPhoto.Attribute.StudentId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(StudentId);
                }
			}
			
			if (kemu_initialized)
			{
                AttributeItem attr = TErrQestionPhoto.Attribute.Kemu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu);
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
        public class TErrQestionPhotoJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>��ƬIMG:[CtrlTypeDic-{SmallText}]</summary>
            public string PhotoImg { get; set; }
            
            /// <summary>ѧ��֤:[CtrlTypeDic-{InputString}]</summary>
            public int StudentId { get; set; }
            
            /// <summary>��ľ:[CtrlTypeDic-{InputString}]</summary>
            public string Kemu { get; set; }
        }
        #endregion
    }
}
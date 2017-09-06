/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:21
  Description:    ���ݱ�Jz_userImages��Ӧ��ҵ���߼���Jz_userImages
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Jz_userImages_Entity:Jz_userImages
 * 
************************************************************/
/************************************************************
SQL���룺
select UserImageId,User_id,CreateTime,ImageMax,ImageMin from Jz_userImages
delete from Jz_userImages
INSERT INTO Jz_userImages (UserImageId,User_id,CreateTime,ImageMax,ImageMin)
     VALUES
           ('','','','','')
UPDATE Jz_userImages SET ...
������ֵ���룺
 *         valObj.UserImageId = valObj2.UserImageId;
        valObj.User_id = valObj2.User_id;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.ImageMax = valObj2.ImageMax;
        valObj.ImageMin = valObj2.ImageMin; 
        valObj.UserImageId = "";
        valObj.User_id = "";
        valObj.CreateTime = "";
        valObj.ImageMax = "";
        valObj.ImageMin = ""; 
        "UserImageId": $("#txt_UserImageId").val(),
        "User_id": $("#txt_User_id").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "ImageMax": $("#txt_ImageMax").val(),
        "ImageMin": $("#txt_ImageMin").val(), 
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
    /// <para>��Jz_userImages���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Jz_userImages : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Jz_userImages Factory()
        {
            return new Jz_userImages();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _UserImageId
        {            
            get { return this.UserImageId; }
            set { this.UserImageId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ImageMax
        {            
            get { return this.ImageMax; }
            set { this.ImageMax = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ImageMin
        {            
            get { return this.ImageMin; }
            set { this.ImageMin = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int UserImageId
        {
            get { return this.m_userimageid; }
            set //private 
            {
                if (!userimageid_initialized || m_userimageid != value)
                {
                    this.m_userimageid = value;
                }
                userimageid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid User_id
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
        public string ImageMax
        {
            get { return this.m_imagemax; }
            set //
            {
                if (!imagemax_initialized || m_imagemax != value)
                {
                    this.m_imagemax = value;
                }
                imagemax_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ImageMin
        {
            get { return this.m_imagemin; }
            set //
            {
                if (!imagemin_initialized || m_imagemin != value)
                {
                    this.m_imagemin = value;
                }
                imagemin_initialized = true;
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
            public static AttributeItem UserImageId =  new AttributeItem("[Jz_userImages].[UserImageId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Jz_userImages].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Jz_userImages].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ImageMax =  new AttributeItem("[Jz_userImages].[ImageMax]", typeof(string), 200, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ImageMin =  new AttributeItem("[Jz_userImages].[ImageMin]", typeof(string), 200, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_userimageid;
        /// <summary></summary>
        protected bool userimageid_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_imagemax;
        /// <summary></summary>
        protected bool imagemax_initialized = false;
        
        private string m_imagemin;
        /// <summary></summary>
        protected bool imagemin_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Jz_userImages";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.userimageid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.imagemax_initialized = IsLoadAllAttributes;this.imagemin_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Jz_userImages value = new Jz_userImages();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"UserImageId"))
				value.userimageid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ImageMax"))
				value.imagemax_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ImageMin"))
				value.imagemin_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Jz_userImages Clone()
        {
            return (Jz_userImages)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Jz_userImages()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Jz_userImages() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Jz_userImages(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Jz_userImages(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Jz_userImages(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Jz_userImages(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Jz_userImages(int userimageid1, Guid user_id1, DateTime createtime1, string imagemax1, string imagemin1)
        {
            
            this.UserImageId = userimageid1;
            
            this.User_id = user_id1;
            
            this.CreateTime = createtime1;
            
            this.ImageMax = imagemax1;
            
            this.ImageMin = imagemin1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Jz_userImages FromIView(IView view)
        {
            return (Jz_userImages)IView.GetITable(view, "Jz_userImages");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Jz_userImages GetOneInstance()
        {
            Jz_userImages value = new Jz_userImages();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Jz_userImages Retrieve()
        {
            BLLTable<Jz_userImages>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "UserImageId":
			        return UserImageId;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "ImageMax":
			        return ImageMax;
			    			
			    case "ImageMin":
			        return ImageMin;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "UserImageId":
			        this.UserImageId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "ImageMax":
			        this.ImageMax = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ImageMin":
			        this.ImageMin = Convert.ToString(AttributeValue);
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
				case "UserImageId":
					return userimageid_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "CreateTime":
					return createtime_initialized;
				
				case "ImageMax":
					return imagemax_initialized;
				
				case "ImageMin":
					return imagemin_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "UserImageId":
					userimageid_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "ImageMax":
					imagemax_initialized = ret;
					return true;
				
				case "ImageMin":
					imagemin_initialized = ret;
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

			
			if (userimageid_initialized)
			{
                AttributeItem attr = Jz_userImages.Attribute.UserImageId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UserImageId);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Jz_userImages.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = Jz_userImages.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (imagemax_initialized)
			{
                AttributeItem attr = Jz_userImages.Attribute.ImageMax;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ImageMax);
                }
			}
			
			if (imagemin_initialized)
			{
                AttributeItem attr = Jz_userImages.Attribute.ImageMin;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ImageMin);
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
        public class Jz_userImagesJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int UserImageId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ImageMax { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ImageMin { get; set; }
        }
        #endregion
    }
}
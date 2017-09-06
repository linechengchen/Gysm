/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 9:44:26
  Description:    ���ݱ�Image��Ӧ��ҵ���߼���Image
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Image_Entity:Image
 * 
************************************************************/
/************************************************************
SQL���룺
select Goods_img,Id,Is_index,Uuid from Image
delete from Image
INSERT INTO Image (Goods_img,Id,Is_index,Uuid)
     VALUES
           ('','','','')
UPDATE Image SET ...
������ֵ���룺
 *         valObj.Goods_img = valObj2.Goods_img;
        valObj.Id = valObj2.Id;
        valObj.Is_index = valObj2.Is_index;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Goods_img = "";
        valObj.Id = "";
        valObj.Is_index = "";
        valObj.Uuid = ""; 
        "Goods_img": $("#txt_Goods_img").val(),
        "Id": $("#txt_Id").val(),
        "Is_index": $("#txt_Is_index").val(),
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
    /// <para>��Image���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Image : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Image Factory()
        {
            return new Image();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Goods_img
        {            
            get { return this.Goods_img; }
            set { this.Goods_img = value; }
        }
        
        /// <summary>  Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _Is_index
        {            
            get { return this.Is_index; }
            set { this.Is_index = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Goods_img
        {
            get { return this.m_goods_img; }
            set //
            {
                if (!goods_img_initialized || m_goods_img != value)
                {
                    this.m_goods_img = value;
                }
                goods_img_initialized = true;
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
        public bool Is_index
        {
            get { return this.m_is_index; }
            set //
            {
                if (!is_index_initialized || m_is_index != value)
                {
                    this.m_is_index = value;
                }
                is_index_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
            
            /// <summary></summary>
            public static AttributeItem Goods_img =  new AttributeItem("[Image].[Goods_img]", typeof(string), 500, default(string));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[Image].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Is_index =  new AttributeItem("[Image].[Is_index]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[Image].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_goods_img;
        /// <summary></summary>
        protected bool goods_img_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private bool m_is_index;
        /// <summary></summary>
        protected bool is_index_initialized = false;
        
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
            return "Image";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.goods_img_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.is_index_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Image value = new Image();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Goods_img"))
				value.goods_img_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_index"))
				value.is_index_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Image Clone()
        {
            return (Image)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Image()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Image() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Image(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Image(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Image(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Image(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Image(string goods_img1, int id1, bool is_index1, Guid uuid1)
        {
            
            this.Goods_img = goods_img1;
            
            this.Id = id1;
            
            this.Is_index = is_index1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Image FromIView(IView view)
        {
            return (Image)IView.GetITable(view, "Image");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Image GetOneInstance()
        {
            Image value = new Image();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Image Retrieve()
        {
            BLLTable<Image>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Goods_img":
			        return Goods_img;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Is_index":
			        return Is_index;
			    			
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
			    case "Goods_img":
			        this.Goods_img = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Is_index":
			        this.Is_index = Convert.ToBoolean(AttributeValue);
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
				case "Goods_img":
					return goods_img_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Is_index":
					return is_index_initialized;
				
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
				case "Goods_img":
					goods_img_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Is_index":
					is_index_initialized = ret;
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

			
			if (goods_img_initialized)
			{
                AttributeItem attr = Image.Attribute.Goods_img;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Goods_img);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Image.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (is_index_initialized)
			{
                AttributeItem attr = Image.Attribute.Is_index;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_index);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Image.Attribute.Uuid;
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
        public class ImageJson
        {
            
            /// <summary></summary>
            public string Goods_img { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public bool Is_index { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
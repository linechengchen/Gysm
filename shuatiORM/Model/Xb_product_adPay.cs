/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/10 14:29:22
  Description:    ���ݱ�Xb_product_adPay��Ӧ��ҵ���߼���Xb_product_adPay
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_product_adPay_Entity:Xb_product_adPay
 * 
************************************************************/
/************************************************************
SQL���룺
select CreateTime,Id,Link,ModifyTime,Pic,SnsPic,SnsTitle,Title,Uuid from Xb_product_adPay
delete from Xb_product_adPay
INSERT INTO Xb_product_adPay (CreateTime,Id,Link,ModifyTime,Pic,SnsPic,SnsTitle,Title,Uuid)
     VALUES
           ('','','','','','','','','')
UPDATE Xb_product_adPay SET ...
������ֵ���룺
 *         valObj.CreateTime = valObj2.CreateTime;
        valObj.Id = valObj2.Id;
        valObj.Link = valObj2.Link;
        valObj.ModifyTime = valObj2.ModifyTime;
        valObj.Pic = valObj2.Pic;
        valObj.SnsPic = valObj2.SnsPic;
        valObj.SnsTitle = valObj2.SnsTitle;
        valObj.Title = valObj2.Title;
        valObj.Uuid = valObj2.Uuid; 
        valObj.CreateTime = "";
        valObj.Id = "";
        valObj.Link = "";
        valObj.ModifyTime = "";
        valObj.Pic = "";
        valObj.SnsPic = "";
        valObj.SnsTitle = "";
        valObj.Title = "";
        valObj.Uuid = ""; 
        "CreateTime": $("#txt_CreateTime").val(),
        "Id": $("#txt_Id").val(),
        "Link": $("#txt_Link").val(),
        "ModifyTime": $("#txt_ModifyTime").val(),
        "Pic": $("#txt_Pic").val(),
        "SnsPic": $("#txt_SnsPic").val(),
        "SnsTitle": $("#txt_SnsTitle").val(),
        "Title": $("#txt_Title").val(),
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
    /// <para>�ײ�ҳ���ö����</para>
    /// <para>��Xb_product_adPay���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_product_adPay : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_product_adPay Factory()
        {
            return new Xb_product_adPay();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Link
        {            
            get { return this.Link; }
            set { this.Link = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _ModifyTime
        {            
            get { return this.ModifyTime; }
            set { this.ModifyTime = value; }
        }
        
        /// <summary> ��������ͼƬ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Pic
        {            
            get { return this.Pic; }
            set { this.Pic = value; }
        }
        
        /// <summary> Сͼ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SnsPic
        {            
            get { return this.SnsPic; }
            set { this.SnsPic = value; }
        }
        
        /// <summary> С����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _SnsTitle
        {            
            get { return this.SnsTitle; }
            set { this.SnsTitle = value; }
        }
        
        /// <summary> ����������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
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
        public string Link
        {
            get { return this.m_link; }
            set //
            {
                if (!link_initialized || m_link != value)
                {
                    this.m_link = value;
                }
                link_initialized = true;
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
        
        /// <summary> ��������ͼƬ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Pic
        {
            get { return this.m_pic; }
            set //
            {
                if (!pic_initialized || m_pic != value)
                {
                    this.m_pic = value;
                }
                pic_initialized = true;
            }
        }
        
        /// <summary> Сͼ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SnsPic
        {
            get { return this.m_snspic; }
            set //
            {
                if (!snspic_initialized || m_snspic != value)
                {
                    this.m_snspic = value;
                }
                snspic_initialized = true;
            }
        }
        
        /// <summary> С����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string SnsTitle
        {
            get { return this.m_snstitle; }
            set //
            {
                if (!snstitle_initialized || m_snstitle != value)
                {
                    this.m_snstitle = value;
                }
                snstitle_initialized = true;
            }
        }
        
        /// <summary> ����������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Title
        {
            get { return this.m_title; }
            set //
            {
                if (!title_initialized || m_title != value)
                {
                    this.m_title = value;
                }
                title_initialized = true;
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
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_product_adPay].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_product_adPay].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Link =  new AttributeItem("[Xb_product_adPay].[Link]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem ModifyTime =  new AttributeItem("[Xb_product_adPay].[ModifyTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>��������ͼƬ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pic =  new AttributeItem("[Xb_product_adPay].[Pic]", typeof(string), 200, default(string));
            
            /// <summary>Сͼ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SnsPic =  new AttributeItem("[Xb_product_adPay].[SnsPic]", typeof(string), 200, default(string));
            
            /// <summary>С����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem SnsTitle =  new AttributeItem("[Xb_product_adPay].[SnsTitle]", typeof(string), 100, default(string));
            
            /// <summary>����������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Title =  new AttributeItem("[Xb_product_adPay].[Title]", typeof(string), 100, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_product_adPay].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool�嵥 �������
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_link;
        /// <summary></summary>
        protected bool link_initialized = false;
        
        private DateTime m_modifytime;
        /// <summary></summary>
        protected bool modifytime_initialized = false;
        
        private string m_pic;
        /// <summary></summary>
        protected bool pic_initialized = false;
        
        private string m_snspic;
        /// <summary></summary>
        protected bool snspic_initialized = false;
        
        private string m_snstitle;
        /// <summary></summary>
        protected bool snstitle_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
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
            return "Xb_product_adPay";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.createtime_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.link_initialized = IsLoadAllAttributes;this.modifytime_initialized = IsLoadAllAttributes;this.pic_initialized = IsLoadAllAttributes;this.snspic_initialized = IsLoadAllAttributes;this.snstitle_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_product_adPay value = new Xb_product_adPay();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Link"))
				value.link_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ModifyTime"))
				value.modifytime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pic"))
				value.pic_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SnsPic"))
				value.snspic_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SnsTitle"))
				value.snstitle_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_product_adPay Clone()
        {
            return (Xb_product_adPay)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_product_adPay()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_product_adPay() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_product_adPay(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_product_adPay(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_product_adPay(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_product_adPay(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_product_adPay(DateTime createtime1, int id1, string link1, DateTime modifytime1, string pic1, string snspic1, string snstitle1, string title1, Guid uuid1)
        {
            
            this.CreateTime = createtime1;
            
            this.Id = id1;
            
            this.Link = link1;
            
            this.ModifyTime = modifytime1;
            
            this.Pic = pic1;
            
            this.SnsPic = snspic1;
            
            this.SnsTitle = snstitle1;
            
            this.Title = title1;
            
            this.Uuid = uuid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_product_adPay FromIView(IView view)
        {
            return (Xb_product_adPay)IView.GetITable(view, "Xb_product_adPay");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_product_adPay GetOneInstance()
        {
            Xb_product_adPay value = new Xb_product_adPay();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_product_adPay Retrieve()
        {
            BLLTable<Xb_product_adPay>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Link":
			        return Link;
			    			
			    case "ModifyTime":
			        return ModifyTime;
			    			
			    case "Pic":
			        return Pic;
			    			
			    case "SnsPic":
			        return SnsPic;
			    			
			    case "SnsTitle":
			        return SnsTitle;
			    			
			    case "Title":
			        return Title;
			    			
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
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Link":
			        this.Link = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ModifyTime":
			        this.ModifyTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Pic":
			        this.Pic = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SnsPic":
			        this.SnsPic = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SnsTitle":
			        this.SnsTitle = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
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
				case "CreateTime":
					return createtime_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Link":
					return link_initialized;
				
				case "ModifyTime":
					return modifytime_initialized;
				
				case "Pic":
					return pic_initialized;
				
				case "SnsPic":
					return snspic_initialized;
				
				case "SnsTitle":
					return snstitle_initialized;
				
				case "Title":
					return title_initialized;
				
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
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Link":
					link_initialized = ret;
					return true;
				
				case "ModifyTime":
					modifytime_initialized = ret;
					return true;
				
				case "Pic":
					pic_initialized = ret;
					return true;
				
				case "SnsPic":
					snspic_initialized = ret;
					return true;
				
				case "SnsTitle":
					snstitle_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
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

			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_product_adPay.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xb_product_adPay.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (link_initialized)
			{
                AttributeItem attr = Xb_product_adPay.Attribute.Link;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Link);
                }
			}
			
			if (modifytime_initialized)
			{
                AttributeItem attr = Xb_product_adPay.Attribute.ModifyTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ModifyTime);
                }
			}
			
			if (pic_initialized)
			{
                AttributeItem attr = Xb_product_adPay.Attribute.Pic;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pic);
                }
			}
			
			if (snspic_initialized)
			{
                AttributeItem attr = Xb_product_adPay.Attribute.SnsPic;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SnsPic);
                }
			}
			
			if (snstitle_initialized)
			{
                AttributeItem attr = Xb_product_adPay.Attribute.SnsTitle;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SnsTitle);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xb_product_adPay.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_product_adPay.Attribute.Uuid;
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
        public class Xb_product_adPayJson
        {
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Link { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime ModifyTime { get; set; }
            
            /// <summary>��������ͼƬ:[CtrlTypeDic-{InputString}]</summary>
            public string Pic { get; set; }
            
            /// <summary>Сͼ��:[CtrlTypeDic-{InputString}]</summary>
            public string SnsPic { get; set; }
            
            /// <summary>С����:[CtrlTypeDic-{InputString}]</summary>
            public string SnsTitle { get; set; }
            
            /// <summary>����������:[CtrlTypeDic-{InputString}]</summary>
            public string Title { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
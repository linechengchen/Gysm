/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:30
  Description:    ���ݱ�Xs_TCoupon��Ӧ��ҵ���߼���Xs_TCoupon
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xs_TCoupon_Entity:Xs_TCoupon
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,CouponId,Code,User_id,Type,State,UseTime,PowerValue,ShopName,BackgroundImg,BackgroundColor,Logo from Xs_TCoupon
delete from Xs_TCoupon
INSERT INTO Xs_TCoupon (Id,CouponId,Code,User_id,Type,State,UseTime,PowerValue,ShopName,BackgroundImg,BackgroundColor,Logo)
     VALUES
           ('','','','','','','','','','','','')
UPDATE Xs_TCoupon SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.CouponId = valObj2.CouponId;
        valObj.Code = valObj2.Code;
        valObj.User_id = valObj2.User_id;
        valObj.Type = valObj2.Type;
        valObj.State = valObj2.State;
        valObj.UseTime = valObj2.UseTime;
        valObj.PowerValue = valObj2.PowerValue;
        valObj.ShopName = valObj2.ShopName;
        valObj.BackgroundImg = valObj2.BackgroundImg;
        valObj.BackgroundColor = valObj2.BackgroundColor;
        valObj.Logo = valObj2.Logo; 
        valObj.Id = "";
        valObj.CouponId = "";
        valObj.Code = "";
        valObj.User_id = "";
        valObj.Type = "";
        valObj.State = "";
        valObj.UseTime = "";
        valObj.PowerValue = "";
        valObj.ShopName = "";
        valObj.BackgroundImg = "";
        valObj.BackgroundColor = "";
        valObj.Logo = ""; 
        "Id": $("#txt_Id").val(),
        "CouponId": $("#txt_CouponId").val(),
        "Code": $("#txt_Code").val(),
        "User_id": $("#txt_User_id").val(),
        "Type": $("#txt_Type").val(),
        "State": $("#txt_State").val(),
        "UseTime": $("#txt_UseTime").val(),
        "PowerValue": $("#txt_PowerValue").val(),
        "ShopName": $("#txt_ShopName").val(),
        "BackgroundImg": $("#txt_BackgroundImg").val(),
        "BackgroundColor": $("#txt_BackgroundColor").val(),
        "Logo": $("#txt_Logo").val(), 
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
    /// <para>�Ż�ȯ:[IDField-{Id:0}]</para>
    /// <para>��Xs_TCoupon���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xs_TCoupon : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xs_TCoupon Factory()
        {
            return new Xs_TCoupon();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _CouponId
        {            
            get { return this.CouponId; }
            set { this.CouponId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Code
        {            
            get { return this.Code; }
            set { this.Code = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Type
        {            
            get { return this.Type; }
            set { this.Type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _State
        {            
            get { return this.State; }
            set { this.State = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _UseTime
        {            
            get { return this.UseTime; }
            set { this.UseTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PowerValue
        {            
            get { return this.PowerValue; }
            set { this.PowerValue = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ShopName
        {            
            get { return this.ShopName; }
            set { this.ShopName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _BackgroundImg
        {            
            get { return this.BackgroundImg; }
            set { this.BackgroundImg = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _BackgroundColor
        {            
            get { return this.BackgroundColor; }
            set { this.BackgroundColor = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Logo
        {            
            get { return this.Logo; }
            set { this.Logo = value; }
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid CouponId
        {
            get { return this.m_couponid; }
            set //
            {
                if (!couponid_initialized || m_couponid != value)
                {
                    this.m_couponid = value;
                }
                couponid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Code
        {
            get { return this.m_code; }
            set //
            {
                if (!code_initialized || m_code != value)
                {
                    this.m_code = value;
                }
                code_initialized = true;
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Type
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int State
        {
            get { return this.m_state; }
            set //
            {
                if (!state_initialized || m_state != value)
                {
                    this.m_state = value;
                }
                state_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string UseTime
        {
            get { return this.m_usetime; }
            set //
            {
                if (!usetime_initialized || m_usetime != value)
                {
                    this.m_usetime = value;
                }
                usetime_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PowerValue
        {
            get { return this.m_powervalue; }
            set //
            {
                if (!powervalue_initialized || m_powervalue != value)
                {
                    this.m_powervalue = value;
                }
                powervalue_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ShopName
        {
            get { return this.m_shopname; }
            set //
            {
                if (!shopname_initialized || m_shopname != value)
                {
                    this.m_shopname = value;
                }
                shopname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string BackgroundImg
        {
            get { return this.m_backgroundimg; }
            set //
            {
                if (!backgroundimg_initialized || m_backgroundimg != value)
                {
                    this.m_backgroundimg = value;
                }
                backgroundimg_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string BackgroundColor
        {
            get { return this.m_backgroundcolor; }
            set //
            {
                if (!backgroundcolor_initialized || m_backgroundcolor != value)
                {
                    this.m_backgroundcolor = value;
                }
                backgroundcolor_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Logo
        {
            get { return this.m_logo; }
            set //
            {
                if (!logo_initialized || m_logo != value)
                {
                    this.m_logo = value;
                }
                logo_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xs_TCoupon].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem CouponId =  new AttributeItem("[Xs_TCoupon].[CouponId]", typeof(Guid), 16, default(Guid));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Code =  new AttributeItem("[Xs_TCoupon].[Code]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xs_TCoupon].[User_id]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Type =  new AttributeItem("[Xs_TCoupon].[Type]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem State =  new AttributeItem("[Xs_TCoupon].[State]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem UseTime =  new AttributeItem("[Xs_TCoupon].[UseTime]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PowerValue =  new AttributeItem("[Xs_TCoupon].[PowerValue]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ShopName =  new AttributeItem("[Xs_TCoupon].[ShopName]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BackgroundImg =  new AttributeItem("[Xs_TCoupon].[BackgroundImg]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem BackgroundColor =  new AttributeItem("[Xs_TCoupon].[BackgroundColor]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Logo =  new AttributeItem("[Xs_TCoupon].[Logo]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_couponid;
        /// <summary></summary>
        protected bool couponid_initialized = false;
        
        private string m_code;
        /// <summary></summary>
        protected bool code_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_type;
        /// <summary></summary>
        protected bool type_initialized = false;
        
        private int m_state;
        /// <summary></summary>
        protected bool state_initialized = false;
        
        private string m_usetime;
        /// <summary></summary>
        protected bool usetime_initialized = false;
        
        private string m_powervalue;
        /// <summary></summary>
        protected bool powervalue_initialized = false;
        
        private string m_shopname;
        /// <summary></summary>
        protected bool shopname_initialized = false;
        
        private string m_backgroundimg;
        /// <summary></summary>
        protected bool backgroundimg_initialized = false;
        
        private string m_backgroundcolor;
        /// <summary></summary>
        protected bool backgroundcolor_initialized = false;
        
        private string m_logo;
        /// <summary></summary>
        protected bool logo_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xs_TCoupon";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.couponid_initialized = IsLoadAllAttributes;this.code_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.type_initialized = IsLoadAllAttributes;this.state_initialized = IsLoadAllAttributes;this.usetime_initialized = IsLoadAllAttributes;this.powervalue_initialized = IsLoadAllAttributes;this.shopname_initialized = IsLoadAllAttributes;this.backgroundimg_initialized = IsLoadAllAttributes;this.backgroundcolor_initialized = IsLoadAllAttributes;this.logo_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xs_TCoupon value = new Xs_TCoupon();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CouponId"))
				value.couponid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Code"))
				value.code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Type"))
				value.type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"State"))
				value.state_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"UseTime"))
				value.usetime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PowerValue"))
				value.powervalue_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShopName"))
				value.shopname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BackgroundImg"))
				value.backgroundimg_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"BackgroundColor"))
				value.backgroundcolor_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Logo"))
				value.logo_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xs_TCoupon Clone()
        {
            return (Xs_TCoupon)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xs_TCoupon()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xs_TCoupon() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xs_TCoupon(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xs_TCoupon(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xs_TCoupon(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xs_TCoupon(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xs_TCoupon(int id1, Guid couponid1, string code1, string user_id1, string type1, int state1, string usetime1, string powervalue1, string shopname1, string backgroundimg1, string backgroundcolor1, string logo1)
        {
            
            this.Id = id1;
            
            this.CouponId = couponid1;
            
            this.Code = code1;
            
            this.User_id = user_id1;
            
            this.Type = type1;
            
            this.State = state1;
            
            this.UseTime = usetime1;
            
            this.PowerValue = powervalue1;
            
            this.ShopName = shopname1;
            
            this.BackgroundImg = backgroundimg1;
            
            this.BackgroundColor = backgroundcolor1;
            
            this.Logo = logo1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xs_TCoupon FromIView(IView view)
        {
            return (Xs_TCoupon)IView.GetITable(view, "Xs_TCoupon");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xs_TCoupon GetOneInstance()
        {
            Xs_TCoupon value = new Xs_TCoupon();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xs_TCoupon Retrieve()
        {
            BLLTable<Xs_TCoupon>.GetRowData(this);
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
			    			
			    case "CouponId":
			        return CouponId;
			    			
			    case "Code":
			        return Code;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Type":
			        return Type;
			    			
			    case "State":
			        return State;
			    			
			    case "UseTime":
			        return UseTime;
			    			
			    case "PowerValue":
			        return PowerValue;
			    			
			    case "ShopName":
			        return ShopName;
			    			
			    case "BackgroundImg":
			        return BackgroundImg;
			    			
			    case "BackgroundColor":
			        return BackgroundColor;
			    			
			    case "Logo":
			        return Logo;
			
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
			    			
			    case "CouponId":
			        this.CouponId = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Code":
			        this.Code = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Type":
			        this.Type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "State":
			        this.State = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "UseTime":
			        this.UseTime = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PowerValue":
			        this.PowerValue = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ShopName":
			        this.ShopName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "BackgroundImg":
			        this.BackgroundImg = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "BackgroundColor":
			        this.BackgroundColor = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Logo":
			        this.Logo = Convert.ToString(AttributeValue);
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
				
				case "CouponId":
					return couponid_initialized;
				
				case "Code":
					return code_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Type":
					return type_initialized;
				
				case "State":
					return state_initialized;
				
				case "UseTime":
					return usetime_initialized;
				
				case "PowerValue":
					return powervalue_initialized;
				
				case "ShopName":
					return shopname_initialized;
				
				case "BackgroundImg":
					return backgroundimg_initialized;
				
				case "BackgroundColor":
					return backgroundcolor_initialized;
				
				case "Logo":
					return logo_initialized;
				
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
				
				case "CouponId":
					couponid_initialized = ret;
					return true;
				
				case "Code":
					code_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Type":
					type_initialized = ret;
					return true;
				
				case "State":
					state_initialized = ret;
					return true;
				
				case "UseTime":
					usetime_initialized = ret;
					return true;
				
				case "PowerValue":
					powervalue_initialized = ret;
					return true;
				
				case "ShopName":
					shopname_initialized = ret;
					return true;
				
				case "BackgroundImg":
					backgroundimg_initialized = ret;
					return true;
				
				case "BackgroundColor":
					backgroundcolor_initialized = ret;
					return true;
				
				case "Logo":
					logo_initialized = ret;
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
                AttributeItem attr = Xs_TCoupon.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (couponid_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.CouponId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CouponId);
                }
			}
			
			if (code_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.Code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Code);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (type_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.Type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Type);
                }
			}
			
			if (state_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.State;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(State);
                }
			}
			
			if (usetime_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.UseTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(UseTime);
                }
			}
			
			if (powervalue_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.PowerValue;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PowerValue);
                }
			}
			
			if (shopname_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.ShopName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShopName);
                }
			}
			
			if (backgroundimg_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.BackgroundImg;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BackgroundImg);
                }
			}
			
			if (backgroundcolor_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.BackgroundColor;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(BackgroundColor);
                }
			}
			
			if (logo_initialized)
			{
                AttributeItem attr = Xs_TCoupon.Attribute.Logo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Logo);
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
        public class Xs_TCouponJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid CouponId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Code { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int State { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string UseTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string PowerValue { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ShopName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string BackgroundImg { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string BackgroundColor { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Logo { get; set; }
        }
        #endregion
    }
}
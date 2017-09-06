/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/7/11 11:44:45
  Description:    数据表Xb_order对应的业务逻辑层Xb_order
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_order_Entity:Xb_order
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Appid,Attach,Body,Create_time,Detail,DeviceInfo,Employee_id,Fee_type,GoodsTag,Mch_id,Modify_time,Nonce_str,Notify_url,OpenId,OrderType,Out_trade_no,Package,ProductId,Sign,Sign_type,SpbillCreateIp,Time_expire,Time_start,TimeStamp,Total_fee,TradeType,User_id,Uuid from Xb_order
delete from Xb_order
INSERT INTO Xb_order (Id,Appid,Attach,Body,Create_time,Detail,DeviceInfo,Employee_id,Fee_type,GoodsTag,Mch_id,Modify_time,Nonce_str,Notify_url,OpenId,OrderType,Out_trade_no,Package,ProductId,Sign,Sign_type,SpbillCreateIp,Time_expire,Time_start,TimeStamp,Total_fee,TradeType,User_id,Uuid)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xb_order SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Appid = valObj2.Appid;
        valObj.Attach = valObj2.Attach;
        valObj.Body = valObj2.Body;
        valObj.Create_time = valObj2.Create_time;
        valObj.Detail = valObj2.Detail;
        valObj.DeviceInfo = valObj2.DeviceInfo;
        valObj.Employee_id = valObj2.Employee_id;
        valObj.Fee_type = valObj2.Fee_type;
        valObj.GoodsTag = valObj2.GoodsTag;
        valObj.Mch_id = valObj2.Mch_id;
        valObj.Modify_time = valObj2.Modify_time;
        valObj.Nonce_str = valObj2.Nonce_str;
        valObj.Notify_url = valObj2.Notify_url;
        valObj.OpenId = valObj2.OpenId;
        valObj.OrderType = valObj2.OrderType;
        valObj.Out_trade_no = valObj2.Out_trade_no;
        valObj.Package = valObj2.Package;
        valObj.ProductId = valObj2.ProductId;
        valObj.Sign = valObj2.Sign;
        valObj.Sign_type = valObj2.Sign_type;
        valObj.SpbillCreateIp = valObj2.SpbillCreateIp;
        valObj.Time_expire = valObj2.Time_expire;
        valObj.Time_start = valObj2.Time_start;
        valObj.TimeStamp = valObj2.TimeStamp;
        valObj.Total_fee = valObj2.Total_fee;
        valObj.TradeType = valObj2.TradeType;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid; 
        valObj.Id = "";
        valObj.Appid = "";
        valObj.Attach = "";
        valObj.Body = "";
        valObj.Create_time = "";
        valObj.Detail = "";
        valObj.DeviceInfo = "";
        valObj.Employee_id = "";
        valObj.Fee_type = "";
        valObj.GoodsTag = "";
        valObj.Mch_id = "";
        valObj.Modify_time = "";
        valObj.Nonce_str = "";
        valObj.Notify_url = "";
        valObj.OpenId = "";
        valObj.OrderType = "";
        valObj.Out_trade_no = "";
        valObj.Package = "";
        valObj.ProductId = "";
        valObj.Sign = "";
        valObj.Sign_type = "";
        valObj.SpbillCreateIp = "";
        valObj.Time_expire = "";
        valObj.Time_start = "";
        valObj.TimeStamp = "";
        valObj.Total_fee = "";
        valObj.TradeType = "";
        valObj.User_id = "";
        valObj.Uuid = ""; 
        "Id": $("#txt_Id").val(),
        "Appid": $("#txt_Appid").val(),
        "Attach": $("#txt_Attach").val(),
        "Body": $("#txt_Body").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Detail": $("#txt_Detail").val(),
        "DeviceInfo": $("#txt_DeviceInfo").val(),
        "Employee_id": $("#txt_Employee_id").val(),
        "Fee_type": $("#txt_Fee_type").val(),
        "GoodsTag": $("#txt_GoodsTag").val(),
        "Mch_id": $("#txt_Mch_id").val(),
        "Modify_time": $("#txt_Modify_time").val(),
        "Nonce_str": $("#txt_Nonce_str").val(),
        "Notify_url": $("#txt_Notify_url").val(),
        "OpenId": $("#txt_OpenId").val(),
        "OrderType": $("#txt_OrderType").val(),
        "Out_trade_no": $("#txt_Out_trade_no").val(),
        "Package": $("#txt_Package").val(),
        "ProductId": $("#txt_ProductId").val(),
        "Sign": $("#txt_Sign").val(),
        "Sign_type": $("#txt_Sign_type").val(),
        "SpbillCreateIp": $("#txt_SpbillCreateIp").val(),
        "Time_expire": $("#txt_Time_expire").val(),
        "Time_start": $("#txt_Time_start").val(),
        "TimeStamp": $("#txt_TimeStamp").val(),
        "Total_fee": $("#txt_Total_fee").val(),
        "TradeType": $("#txt_TradeType").val(),
        "User_id": $("#txt_User_id").val(),
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
    /// <para>学霸家教订单表</para>
    /// <para>与Xb_order数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_order : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_order Factory()
        {
            return new Xb_order();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Appid
        {            
            get { return this.Appid; }
            set { this.Appid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Attach
        {            
            get { return this.Attach; }
            set { this.Attach = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Body
        {            
            get { return this.Body; }
            set { this.Body = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Detail
        {            
            get { return this.Detail; }
            set { this.Detail = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _DeviceInfo
        {            
            get { return this.DeviceInfo; }
            set { this.DeviceInfo = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Employee_id
        {            
            get { return this.Employee_id; }
            set { this.Employee_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Fee_type
        {            
            get { return this.Fee_type; }
            set { this.Fee_type = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _GoodsTag
        {            
            get { return this.GoodsTag; }
            set { this.GoodsTag = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Mch_id
        {            
            get { return this.Mch_id; }
            set { this.Mch_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Nonce_str
        {            
            get { return this.Nonce_str; }
            set { this.Nonce_str = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Notify_url
        {            
            get { return this.Notify_url; }
            set { this.Notify_url = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> 订单类型 Attribute_IsNotNull </summary>
        public string _OrderType
        {            
            get { return this.OrderType; }
            set { this.OrderType = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Out_trade_no
        {            
            get { return this.Out_trade_no; }
            set { this.Out_trade_no = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Package
        {            
            get { return this.Package; }
            set { this.Package = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _ProductId
        {            
            get { return this.ProductId; }
            set { this.ProductId = value; }
        }
        
        /// <summary> 支付标记 Attribute_IsNotNull </summary>
        public string _Sign
        {            
            get { return this.Sign; }
            set { this.Sign = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Sign_type
        {            
            get { return this.Sign_type; }
            set { this.Sign_type = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _SpbillCreateIp
        {            
            get { return this.SpbillCreateIp; }
            set { this.SpbillCreateIp = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Time_expire
        {            
            get { return this.Time_expire; }
            set { this.Time_expire = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Time_start
        {            
            get { return this.Time_start; }
            set { this.Time_start = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _TimeStamp
        {            
            get { return this.TimeStamp; }
            set { this.TimeStamp = value; }
        }
        
        /// <summary> 总费用 Attribute_IsNotNull </summary>
        public double _Total_fee
        {            
            get { return this.Total_fee; }
            set { this.Total_fee = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _TradeType
        {            
            get { return this.TradeType; }
            set { this.TradeType = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Appid
        {
            get { return this.m_appid; }
            set //
            {
                if (!appid_initialized || m_appid != value)
                {
                    this.m_appid = value;
                }
                appid_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Attach
        {
            get { return this.m_attach; }
            set //
            {
                if (!attach_initialized || m_attach != value)
                {
                    this.m_attach = value;
                }
                attach_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Body
        {
            get { return this.m_body; }
            set //
            {
                if (!body_initialized || m_body != value)
                {
                    this.m_body = value;
                }
                body_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public DateTime Create_time
        {
            get { return this.m_create_time; }
            set //
            {
                if (!create_time_initialized || m_create_time != value)
                {
                    this.m_create_time = value;
                }
                create_time_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Detail
        {
            get { return this.m_detail; }
            set //
            {
                if (!detail_initialized || m_detail != value)
                {
                    this.m_detail = value;
                }
                detail_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string DeviceInfo
        {
            get { return this.m_deviceinfo; }
            set //
            {
                if (!deviceinfo_initialized || m_deviceinfo != value)
                {
                    this.m_deviceinfo = value;
                }
                deviceinfo_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Employee_id
        {
            get { return this.m_employee_id; }
            set //
            {
                if (!employee_id_initialized || m_employee_id != value)
                {
                    this.m_employee_id = value;
                }
                employee_id_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Fee_type
        {
            get { return this.m_fee_type; }
            set //
            {
                if (!fee_type_initialized || m_fee_type != value)
                {
                    this.m_fee_type = value;
                }
                fee_type_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string GoodsTag
        {
            get { return this.m_goodstag; }
            set //
            {
                if (!goodstag_initialized || m_goodstag != value)
                {
                    this.m_goodstag = value;
                }
                goodstag_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Mch_id
        {
            get { return this.m_mch_id; }
            set //
            {
                if (!mch_id_initialized || m_mch_id != value)
                {
                    this.m_mch_id = value;
                }
                mch_id_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public DateTime Modify_time
        {
            get { return this.m_modify_time; }
            set //
            {
                if (!modify_time_initialized || m_modify_time != value)
                {
                    this.m_modify_time = value;
                }
                modify_time_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Nonce_str
        {
            get { return this.m_nonce_str; }
            set //
            {
                if (!nonce_str_initialized || m_nonce_str != value)
                {
                    this.m_nonce_str = value;
                }
                nonce_str_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Notify_url
        {
            get { return this.m_notify_url; }
            set //
            {
                if (!notify_url_initialized || m_notify_url != value)
                {
                    this.m_notify_url = value;
                }
                notify_url_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string OpenId
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
        
        /// <summary> 订单类型，推荐使用 "_"符号开头 </summary>
        public string OrderType
        {
            get { return this.m_ordertype; }
            set //
            {
                if (!ordertype_initialized || m_ordertype != value)
                {
                    this.m_ordertype = value;
                }
                ordertype_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Out_trade_no
        {
            get { return this.m_out_trade_no; }
            set //
            {
                if (!out_trade_no_initialized || m_out_trade_no != value)
                {
                    this.m_out_trade_no = value;
                }
                out_trade_no_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Package
        {
            get { return this.m_package; }
            set //
            {
                if (!package_initialized || m_package != value)
                {
                    this.m_package = value;
                }
                package_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string ProductId
        {
            get { return this.m_productid; }
            set //
            {
                if (!productid_initialized || m_productid != value)
                {
                    this.m_productid = value;
                }
                productid_initialized = true;
            }
        }
        
        /// <summary> 支付标记，推荐使用 "_"符号开头 </summary>
        public string Sign
        {
            get { return this.m_sign; }
            set //
            {
                if (!sign_initialized || m_sign != value)
                {
                    this.m_sign = value;
                }
                sign_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Sign_type
        {
            get { return this.m_sign_type; }
            set //
            {
                if (!sign_type_initialized || m_sign_type != value)
                {
                    this.m_sign_type = value;
                }
                sign_type_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string SpbillCreateIp
        {
            get { return this.m_spbillcreateip; }
            set //
            {
                if (!spbillcreateip_initialized || m_spbillcreateip != value)
                {
                    this.m_spbillcreateip = value;
                }
                spbillcreateip_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Time_expire
        {
            get { return this.m_time_expire; }
            set //
            {
                if (!time_expire_initialized || m_time_expire != value)
                {
                    this.m_time_expire = value;
                }
                time_expire_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Time_start
        {
            get { return this.m_time_start; }
            set //
            {
                if (!time_start_initialized || m_time_start != value)
                {
                    this.m_time_start = value;
                }
                time_start_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string TimeStamp
        {
            get { return this.m_timestamp; }
            set //
            {
                if (!timestamp_initialized || m_timestamp != value)
                {
                    this.m_timestamp = value;
                }
                timestamp_initialized = true;
            }
        }
        
        /// <summary> 总费用，推荐使用 "_"符号开头 </summary>
        public double Total_fee
        {
            get { return this.m_total_fee; }
            set //
            {
                if (!total_fee_initialized || m_total_fee != value)
                {
                    this.m_total_fee = value;
                }
                total_fee_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string TradeType
        {
            get { return this.m_tradetype; }
            set //
            {
                if (!tradetype_initialized || m_tradetype != value)
                {
                    this.m_tradetype = value;
                }
                tradetype_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_order].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Appid =  new AttributeItem("[Xb_order].[Appid]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem Attach =  new AttributeItem("[Xb_order].[Attach]", typeof(string), 127, default(string));
            
            /// <summary></summary>
            public static AttributeItem Body =  new AttributeItem("[Xb_order].[Body]", typeof(string), 128, default(string));
            
            /// <summary></summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xb_order].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Detail =  new AttributeItem("[Xb_order].[Detail]", typeof(string), 128, default(string));
            
            /// <summary></summary>
            public static AttributeItem DeviceInfo =  new AttributeItem("[Xb_order].[DeviceInfo]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem Employee_id =  new AttributeItem("[Xb_order].[Employee_id]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Fee_type =  new AttributeItem("[Xb_order].[Fee_type]", typeof(string), 16, default(string));
            
            /// <summary></summary>
            public static AttributeItem GoodsTag =  new AttributeItem("[Xb_order].[GoodsTag]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem Mch_id =  new AttributeItem("[Xb_order].[Mch_id]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xb_order].[Modify_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Nonce_str =  new AttributeItem("[Xb_order].[Nonce_str]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem Notify_url =  new AttributeItem("[Xb_order].[Notify_url]", typeof(string), 256, default(string));
            
            /// <summary></summary>
            public static AttributeItem OpenId =  new AttributeItem("[Xb_order].[OpenId]", typeof(string), 128, default(string));
            
            /// <summary>订单类型</summary>
            public static AttributeItem OrderType =  new AttributeItem("[Xb_order].[OrderType]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Out_trade_no =  new AttributeItem("[Xb_order].[Out_trade_no]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem Package =  new AttributeItem("[Xb_order].[Package]", typeof(string), 80, default(string));
            
            /// <summary></summary>
            public static AttributeItem ProductId =  new AttributeItem("[Xb_order].[ProductId]", typeof(string), 32, default(string));
            
            /// <summary>支付标记</summary>
            public static AttributeItem Sign =  new AttributeItem("[Xb_order].[Sign]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem Sign_type =  new AttributeItem("[Xb_order].[Sign_type]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem SpbillCreateIp =  new AttributeItem("[Xb_order].[SpbillCreateIp]", typeof(string), 16, default(string));
            
            /// <summary></summary>
            public static AttributeItem Time_expire =  new AttributeItem("[Xb_order].[Time_expire]", typeof(string), 14, default(string));
            
            /// <summary></summary>
            public static AttributeItem Time_start =  new AttributeItem("[Xb_order].[Time_start]", typeof(string), 14, default(string));
            
            /// <summary></summary>
            public static AttributeItem TimeStamp =  new AttributeItem("[Xb_order].[TimeStamp]", typeof(string), 50, default(string));
            
            /// <summary>总费用</summary>
            public static AttributeItem Total_fee =  new AttributeItem("[Xb_order].[Total_fee]", typeof(double), 8, default(double));
            
            /// <summary></summary>
            public static AttributeItem TradeType =  new AttributeItem("[Xb_order].[TradeType]", typeof(string), 32, default(string));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_order].[User_id]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_order].[Uuid]", typeof(Guid), 16, default(Guid));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_appid;
        /// <summary></summary>
        protected bool appid_initialized = false;
        
        private string m_attach;
        /// <summary></summary>
        protected bool attach_initialized = false;
        
        private string m_body;
        /// <summary></summary>
        protected bool body_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_detail;
        /// <summary></summary>
        protected bool detail_initialized = false;
        
        private string m_deviceinfo;
        /// <summary></summary>
        protected bool deviceinfo_initialized = false;
        
        private string m_employee_id;
        /// <summary></summary>
        protected bool employee_id_initialized = false;
        
        private string m_fee_type;
        /// <summary></summary>
        protected bool fee_type_initialized = false;
        
        private string m_goodstag;
        /// <summary></summary>
        protected bool goodstag_initialized = false;
        
        private string m_mch_id;
        /// <summary></summary>
        protected bool mch_id_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        
        private string m_nonce_str;
        /// <summary></summary>
        protected bool nonce_str_initialized = false;
        
        private string m_notify_url;
        /// <summary></summary>
        protected bool notify_url_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_ordertype;
        /// <summary></summary>
        protected bool ordertype_initialized = false;
        
        private string m_out_trade_no;
        /// <summary></summary>
        protected bool out_trade_no_initialized = false;
        
        private string m_package;
        /// <summary></summary>
        protected bool package_initialized = false;
        
        private string m_productid;
        /// <summary></summary>
        protected bool productid_initialized = false;
        
        private string m_sign;
        /// <summary></summary>
        protected bool sign_initialized = false;
        
        private string m_sign_type;
        /// <summary></summary>
        protected bool sign_type_initialized = false;
        
        private string m_spbillcreateip;
        /// <summary></summary>
        protected bool spbillcreateip_initialized = false;
        
        private string m_time_expire;
        /// <summary></summary>
        protected bool time_expire_initialized = false;
        
        private string m_time_start;
        /// <summary></summary>
        protected bool time_start_initialized = false;
        
        private string m_timestamp;
        /// <summary></summary>
        protected bool timestamp_initialized = false;
        
        private double m_total_fee;
        /// <summary></summary>
        protected bool total_fee_initialized = false;
        
        private string m_tradetype;
        /// <summary></summary>
        protected bool tradetype_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_order";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.appid_initialized = IsLoadAllAttributes;this.attach_initialized = IsLoadAllAttributes;this.body_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.detail_initialized = IsLoadAllAttributes;this.deviceinfo_initialized = IsLoadAllAttributes;this.employee_id_initialized = IsLoadAllAttributes;this.fee_type_initialized = IsLoadAllAttributes;this.goodstag_initialized = IsLoadAllAttributes;this.mch_id_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;this.nonce_str_initialized = IsLoadAllAttributes;this.notify_url_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.ordertype_initialized = IsLoadAllAttributes;this.out_trade_no_initialized = IsLoadAllAttributes;this.package_initialized = IsLoadAllAttributes;this.productid_initialized = IsLoadAllAttributes;this.sign_initialized = IsLoadAllAttributes;this.sign_type_initialized = IsLoadAllAttributes;this.spbillcreateip_initialized = IsLoadAllAttributes;this.time_expire_initialized = IsLoadAllAttributes;this.time_start_initialized = IsLoadAllAttributes;this.timestamp_initialized = IsLoadAllAttributes;this.total_fee_initialized = IsLoadAllAttributes;this.tradetype_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_order value = new Xb_order();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Appid"))
				value.appid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Attach"))
				value.attach_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Body"))
				value.body_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Detail"))
				value.detail_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DeviceInfo"))
				value.deviceinfo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Employee_id"))
				value.employee_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Fee_type"))
				value.fee_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GoodsTag"))
				value.goodstag_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mch_id"))
				value.mch_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Nonce_str"))
				value.nonce_str_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Notify_url"))
				value.notify_url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OrderType"))
				value.ordertype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Out_trade_no"))
				value.out_trade_no_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Package"))
				value.package_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ProductId"))
				value.productid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sign"))
				value.sign_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sign_type"))
				value.sign_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"SpbillCreateIp"))
				value.spbillcreateip_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time_expire"))
				value.time_expire_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Time_start"))
				value.time_start_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TimeStamp"))
				value.timestamp_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Total_fee"))
				value.total_fee_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TradeType"))
				value.tradetype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_order Clone()
        {
            return (Xb_order)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_order()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_order() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_order(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_order(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_order(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_order(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_order(int id1, string appid1, string attach1, string body1, DateTime create_time1, string detail1, string deviceinfo1, string employee_id1, string fee_type1, string goodstag1, string mch_id1, DateTime modify_time1, string nonce_str1, string notify_url1, string openid1, string ordertype1, string out_trade_no1, string package1, string productid1, string sign1, string sign_type1, string spbillcreateip1, string time_expire1, string time_start1, string timestamp1, double total_fee1, string tradetype1, string user_id1, Guid uuid1)
        {
            
            this.Id = id1;
            
            this.Appid = appid1;
            
            this.Attach = attach1;
            
            this.Body = body1;
            
            this.Create_time = create_time1;
            
            this.Detail = detail1;
            
            this.DeviceInfo = deviceinfo1;
            
            this.Employee_id = employee_id1;
            
            this.Fee_type = fee_type1;
            
            this.GoodsTag = goodstag1;
            
            this.Mch_id = mch_id1;
            
            this.Modify_time = modify_time1;
            
            this.Nonce_str = nonce_str1;
            
            this.Notify_url = notify_url1;
            
            this.OpenId = openid1;
            
            this.OrderType = ordertype1;
            
            this.Out_trade_no = out_trade_no1;
            
            this.Package = package1;
            
            this.ProductId = productid1;
            
            this.Sign = sign1;
            
            this.Sign_type = sign_type1;
            
            this.SpbillCreateIp = spbillcreateip1;
            
            this.Time_expire = time_expire1;
            
            this.Time_start = time_start1;
            
            this.TimeStamp = timestamp1;
            
            this.Total_fee = total_fee1;
            
            this.TradeType = tradetype1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_order FromIView(IView view)
        {
            return (Xb_order)IView.GetITable(view, "Xb_order");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_order GetOneInstance()
        {
            Xb_order value = new Xb_order();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_order Retrieve()
        {
            BLLTable<Xb_order>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Id":
			        return Id;
			    			
			    case "Appid":
			        return Appid;
			    			
			    case "Attach":
			        return Attach;
			    			
			    case "Body":
			        return Body;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Detail":
			        return Detail;
			    			
			    case "DeviceInfo":
			        return DeviceInfo;
			    			
			    case "Employee_id":
			        return Employee_id;
			    			
			    case "Fee_type":
			        return Fee_type;
			    			
			    case "GoodsTag":
			        return GoodsTag;
			    			
			    case "Mch_id":
			        return Mch_id;
			    			
			    case "Modify_time":
			        return Modify_time;
			    			
			    case "Nonce_str":
			        return Nonce_str;
			    			
			    case "Notify_url":
			        return Notify_url;
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "OrderType":
			        return OrderType;
			    			
			    case "Out_trade_no":
			        return Out_trade_no;
			    			
			    case "Package":
			        return Package;
			    			
			    case "ProductId":
			        return ProductId;
			    			
			    case "Sign":
			        return Sign;
			    			
			    case "Sign_type":
			        return Sign_type;
			    			
			    case "SpbillCreateIp":
			        return SpbillCreateIp;
			    			
			    case "Time_expire":
			        return Time_expire;
			    			
			    case "Time_start":
			        return Time_start;
			    			
			    case "TimeStamp":
			        return TimeStamp;
			    			
			    case "Total_fee":
			        return Total_fee;
			    			
			    case "TradeType":
			        return TradeType;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Uuid":
			        return Uuid;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Appid":
			        this.Appid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Attach":
			        this.Attach = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Body":
			        this.Body = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Detail":
			        this.Detail = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DeviceInfo":
			        this.DeviceInfo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Employee_id":
			        this.Employee_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Fee_type":
			        this.Fee_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GoodsTag":
			        this.GoodsTag = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Mch_id":
			        this.Mch_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Nonce_str":
			        this.Nonce_str = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Notify_url":
			        this.Notify_url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "OrderType":
			        this.OrderType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Out_trade_no":
			        this.Out_trade_no = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Package":
			        this.Package = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ProductId":
			        this.ProductId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sign":
			        this.Sign = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sign_type":
			        this.Sign_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "SpbillCreateIp":
			        this.SpbillCreateIp = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Time_expire":
			        this.Time_expire = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Time_start":
			        this.Time_start = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TimeStamp":
			        this.TimeStamp = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Total_fee":
			        this.Total_fee = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "TradeType":
			        this.TradeType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			
                default:
                    return base.SetValue(AttributeName, AttributeValue);
			}
        }
        
        /// <summary>通过属性 获取该字段是否已被初始化</summary>
        public override bool GetInitialized(AttributeItem AttributeName)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					return id_initialized;
				
				case "Appid":
					return appid_initialized;
				
				case "Attach":
					return attach_initialized;
				
				case "Body":
					return body_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Detail":
					return detail_initialized;
				
				case "DeviceInfo":
					return deviceinfo_initialized;
				
				case "Employee_id":
					return employee_id_initialized;
				
				case "Fee_type":
					return fee_type_initialized;
				
				case "GoodsTag":
					return goodstag_initialized;
				
				case "Mch_id":
					return mch_id_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
				case "Nonce_str":
					return nonce_str_initialized;
				
				case "Notify_url":
					return notify_url_initialized;
				
				case "OpenId":
					return openid_initialized;
				
				case "OrderType":
					return ordertype_initialized;
				
				case "Out_trade_no":
					return out_trade_no_initialized;
				
				case "Package":
					return package_initialized;
				
				case "ProductId":
					return productid_initialized;
				
				case "Sign":
					return sign_initialized;
				
				case "Sign_type":
					return sign_type_initialized;
				
				case "SpbillCreateIp":
					return spbillcreateip_initialized;
				
				case "Time_expire":
					return time_expire_initialized;
				
				case "Time_start":
					return time_start_initialized;
				
				case "TimeStamp":
					return timestamp_initialized;
				
				case "Total_fee":
					return total_fee_initialized;
				
				case "TradeType":
					return tradetype_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Appid":
					appid_initialized = ret;
					return true;
				
				case "Attach":
					attach_initialized = ret;
					return true;
				
				case "Body":
					body_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Detail":
					detail_initialized = ret;
					return true;
				
				case "DeviceInfo":
					deviceinfo_initialized = ret;
					return true;
				
				case "Employee_id":
					employee_id_initialized = ret;
					return true;
				
				case "Fee_type":
					fee_type_initialized = ret;
					return true;
				
				case "GoodsTag":
					goodstag_initialized = ret;
					return true;
				
				case "Mch_id":
					mch_id_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
					return true;
				
				case "Nonce_str":
					nonce_str_initialized = ret;
					return true;
				
				case "Notify_url":
					notify_url_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "OrderType":
					ordertype_initialized = ret;
					return true;
				
				case "Out_trade_no":
					out_trade_no_initialized = ret;
					return true;
				
				case "Package":
					package_initialized = ret;
					return true;
				
				case "ProductId":
					productid_initialized = ret;
					return true;
				
				case "Sign":
					sign_initialized = ret;
					return true;
				
				case "Sign_type":
					sign_type_initialized = ret;
					return true;
				
				case "SpbillCreateIp":
					spbillcreateip_initialized = ret;
					return true;
				
				case "Time_expire":
					time_expire_initialized = ret;
					return true;
				
				case "Time_start":
					time_start_initialized = ret;
					return true;
				
				case "TimeStamp":
					timestamp_initialized = ret;
					return true;
				
				case "Total_fee":
					total_fee_initialized = ret;
					return true;
				
				case "TradeType":
					tradetype_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
                default:
                    return base.SetInitialized(AttributeName, ret);
			}
        }
        #endregion

        #region 获取DataParameter PropertyInfo

        /// <summary>
        /// 获取所有被初始化过的值，获取AttributeItem
        /// 目的为获取 System.Windows.Forms.DataGridViewTextBoxColumn[] 在中间数据层采用了 自定义的 MyDataGridViewTextBoxColumn (空类继承自 DataGridViewTextBoxColumn)
        /// 这里采用了两次遍历的方法，是为了避免拆装过程，使用源代码模式的时候，不会依赖于windows.form.dll。
        /// </summary>
        /// <returns></returns>
        public override AttributeItem[] af_GetAvailableAttributeItem(ref List<object> values)
        {
            List<AttributeItem> parametersList = new List<AttributeItem>();

			
			if (id_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (appid_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Appid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Appid);
                }
			}
			
			if (attach_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Attach;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Attach);
                }
			}
			
			if (body_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Body;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Body);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (detail_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Detail;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Detail);
                }
			}
			
			if (deviceinfo_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.DeviceInfo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DeviceInfo);
                }
			}
			
			if (employee_id_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Employee_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Employee_id);
                }
			}
			
			if (fee_type_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Fee_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Fee_type);
                }
			}
			
			if (goodstag_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.GoodsTag;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GoodsTag);
                }
			}
			
			if (mch_id_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Mch_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mch_id);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
                }
			}
			
			if (nonce_str_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Nonce_str;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Nonce_str);
                }
			}
			
			if (notify_url_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Notify_url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Notify_url);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (ordertype_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.OrderType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OrderType);
                }
			}
			
			if (out_trade_no_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Out_trade_no;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Out_trade_no);
                }
			}
			
			if (package_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Package;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Package);
                }
			}
			
			if (productid_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.ProductId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ProductId);
                }
			}
			
			if (sign_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Sign;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sign);
                }
			}
			
			if (sign_type_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Sign_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sign_type);
                }
			}
			
			if (spbillcreateip_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.SpbillCreateIp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(SpbillCreateIp);
                }
			}
			
			if (time_expire_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Time_expire;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time_expire);
                }
			}
			
			if (time_start_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Time_start;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Time_start);
                }
			}
			
			if (timestamp_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.TimeStamp;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TimeStamp);
                }
			}
			
			if (total_fee_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Total_fee;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Total_fee);
                }
			}
			
			if (tradetype_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.TradeType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TradeType);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_order.Attribute.Uuid;
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

        #region Json对象
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        [Serializable]
        public class Xb_orderJson
        {
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public string Appid { get; set; }
            
            /// <summary></summary>
            public string Attach { get; set; }
            
            /// <summary></summary>
            public string Body { get; set; }
            
            /// <summary></summary>
            public DateTime Create_time { get; set; }
            
            /// <summary></summary>
            public string Detail { get; set; }
            
            /// <summary></summary>
            public string DeviceInfo { get; set; }
            
            /// <summary></summary>
            public string Employee_id { get; set; }
            
            /// <summary></summary>
            public string Fee_type { get; set; }
            
            /// <summary></summary>
            public string GoodsTag { get; set; }
            
            /// <summary></summary>
            public string Mch_id { get; set; }
            
            /// <summary></summary>
            public DateTime Modify_time { get; set; }
            
            /// <summary></summary>
            public string Nonce_str { get; set; }
            
            /// <summary></summary>
            public string Notify_url { get; set; }
            
            /// <summary></summary>
            public string OpenId { get; set; }
            
            /// <summary>订单类型</summary>
            public string OrderType { get; set; }
            
            /// <summary></summary>
            public string Out_trade_no { get; set; }
            
            /// <summary></summary>
            public string Package { get; set; }
            
            /// <summary></summary>
            public string ProductId { get; set; }
            
            /// <summary>支付标记</summary>
            public string Sign { get; set; }
            
            /// <summary></summary>
            public string Sign_type { get; set; }
            
            /// <summary></summary>
            public string SpbillCreateIp { get; set; }
            
            /// <summary></summary>
            public string Time_expire { get; set; }
            
            /// <summary></summary>
            public string Time_start { get; set; }
            
            /// <summary></summary>
            public string TimeStamp { get; set; }
            
            /// <summary>总费用</summary>
            public double Total_fee { get; set; }
            
            /// <summary></summary>
            public string TradeType { get; set; }
            
            /// <summary></summary>
            public string User_id { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
        }
        #endregion
    }
}
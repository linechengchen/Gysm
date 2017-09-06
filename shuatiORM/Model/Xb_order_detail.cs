/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/7/14 11:53:07
  Description:    数据表Xb_order_detail对应的业务逻辑层Xb_order_detail
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_order_detail_Entity:Xb_order_detail
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Create_time,Create1,Date_desc,Dayi_time_sum,Expire_days,Grade,Grade_max,Grade_min,Grade_name,Have_buy_num,Home_sum,Home_time_once,Is_delete,Is_promotion,Kemu_id,Modify_time,Name,Online_sum,Online_sum_once,Order_id,Out_trade_on,Page_type,Per_price,Pic,Price,Product_id,Product_sum,Promotion_expire_date,Promotion_price,Short_name,Tese_lesson_num,Title,Total_buy_num,Un_buy_num,User_id,Uuid,Xb_product_type_id from Xb_order_detail
delete from Xb_order_detail
INSERT INTO Xb_order_detail (Id,Create_time,Create1,Date_desc,Dayi_time_sum,Expire_days,Grade,Grade_max,Grade_min,Grade_name,Have_buy_num,Home_sum,Home_time_once,Is_delete,Is_promotion,Kemu_id,Modify_time,Name,Online_sum,Online_sum_once,Order_id,Out_trade_on,Page_type,Per_price,Pic,Price,Product_id,Product_sum,Promotion_expire_date,Promotion_price,Short_name,Tese_lesson_num,Title,Total_buy_num,Un_buy_num,User_id,Uuid,Xb_product_type_id)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xb_order_detail SET ...
变量赋值代码：
 *         valObj.Id = valObj2.Id;
        valObj.Create_time = valObj2.Create_time;
        valObj.Create1 = valObj2.Create1;
        valObj.Date_desc = valObj2.Date_desc;
        valObj.Dayi_time_sum = valObj2.Dayi_time_sum;
        valObj.Expire_days = valObj2.Expire_days;
        valObj.Grade = valObj2.Grade;
        valObj.Grade_max = valObj2.Grade_max;
        valObj.Grade_min = valObj2.Grade_min;
        valObj.Grade_name = valObj2.Grade_name;
        valObj.Have_buy_num = valObj2.Have_buy_num;
        valObj.Home_sum = valObj2.Home_sum;
        valObj.Home_time_once = valObj2.Home_time_once;
        valObj.Is_delete = valObj2.Is_delete;
        valObj.Is_promotion = valObj2.Is_promotion;
        valObj.Kemu_id = valObj2.Kemu_id;
        valObj.Modify_time = valObj2.Modify_time;
        valObj.Name = valObj2.Name;
        valObj.Online_sum = valObj2.Online_sum;
        valObj.Online_sum_once = valObj2.Online_sum_once;
        valObj.Order_id = valObj2.Order_id;
        valObj.Out_trade_on = valObj2.Out_trade_on;
        valObj.Page_type = valObj2.Page_type;
        valObj.Per_price = valObj2.Per_price;
        valObj.Pic = valObj2.Pic;
        valObj.Price = valObj2.Price;
        valObj.Product_id = valObj2.Product_id;
        valObj.Product_sum = valObj2.Product_sum;
        valObj.Promotion_expire_date = valObj2.Promotion_expire_date;
        valObj.Promotion_price = valObj2.Promotion_price;
        valObj.Short_name = valObj2.Short_name;
        valObj.Tese_lesson_num = valObj2.Tese_lesson_num;
        valObj.Title = valObj2.Title;
        valObj.Total_buy_num = valObj2.Total_buy_num;
        valObj.Un_buy_num = valObj2.Un_buy_num;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid;
        valObj.Xb_product_type_id = valObj2.Xb_product_type_id; 
        valObj.Id = "";
        valObj.Create_time = "";
        valObj.Create1 = "";
        valObj.Date_desc = "";
        valObj.Dayi_time_sum = "";
        valObj.Expire_days = "";
        valObj.Grade = "";
        valObj.Grade_max = "";
        valObj.Grade_min = "";
        valObj.Grade_name = "";
        valObj.Have_buy_num = "";
        valObj.Home_sum = "";
        valObj.Home_time_once = "";
        valObj.Is_delete = "";
        valObj.Is_promotion = "";
        valObj.Kemu_id = "";
        valObj.Modify_time = "";
        valObj.Name = "";
        valObj.Online_sum = "";
        valObj.Online_sum_once = "";
        valObj.Order_id = "";
        valObj.Out_trade_on = "";
        valObj.Page_type = "";
        valObj.Per_price = "";
        valObj.Pic = "";
        valObj.Price = "";
        valObj.Product_id = "";
        valObj.Product_sum = "";
        valObj.Promotion_expire_date = "";
        valObj.Promotion_price = "";
        valObj.Short_name = "";
        valObj.Tese_lesson_num = "";
        valObj.Title = "";
        valObj.Total_buy_num = "";
        valObj.Un_buy_num = "";
        valObj.User_id = "";
        valObj.Uuid = "";
        valObj.Xb_product_type_id = ""; 
        "Id": $("#txt_Id").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Create1": $("#txt_Create1").val(),
        "Date_desc": $("#txt_Date_desc").val(),
        "Dayi_time_sum": $("#txt_Dayi_time_sum").val(),
        "Expire_days": $("#txt_Expire_days").val(),
        "Grade": $("#txt_Grade").val(),
        "Grade_max": $("#txt_Grade_max").val(),
        "Grade_min": $("#txt_Grade_min").val(),
        "Grade_name": $("#txt_Grade_name").val(),
        "Have_buy_num": $("#txt_Have_buy_num").val(),
        "Home_sum": $("#txt_Home_sum").val(),
        "Home_time_once": $("#txt_Home_time_once").val(),
        "Is_delete": $("#txt_Is_delete").val(),
        "Is_promotion": $("#txt_Is_promotion").val(),
        "Kemu_id": $("#txt_Kemu_id").val(),
        "Modify_time": $("#txt_Modify_time").val(),
        "Name": $("#txt_Name").val(),
        "Online_sum": $("#txt_Online_sum").val(),
        "Online_sum_once": $("#txt_Online_sum_once").val(),
        "Order_id": $("#txt_Order_id").val(),
        "Out_trade_on": $("#txt_Out_trade_on").val(),
        "Page_type": $("#txt_Page_type").val(),
        "Per_price": $("#txt_Per_price").val(),
        "Pic": $("#txt_Pic").val(),
        "Price": $("#txt_Price").val(),
        "Product_id": $("#txt_Product_id").val(),
        "Product_sum": $("#txt_Product_sum").val(),
        "Promotion_expire_date": $("#txt_Promotion_expire_date").val(),
        "Promotion_price": $("#txt_Promotion_price").val(),
        "Short_name": $("#txt_Short_name").val(),
        "Tese_lesson_num": $("#txt_Tese_lesson_num").val(),
        "Title": $("#txt_Title").val(),
        "Total_buy_num": $("#txt_Total_buy_num").val(),
        "Un_buy_num": $("#txt_Un_buy_num").val(),
        "User_id": $("#txt_User_id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "Xb_product_type_id": $("#txt_Xb_product_type_id").val(), 
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
    /// <para>家教订单详情页</para>
    /// <para>与Xb_order_detail数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_order_detail : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_order_detail Factory()
        {
            return new Xb_order_detail();
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
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Create1
        {            
            get { return this.Create1; }
            set { this.Create1 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Date_desc
        {            
            get { return this.Date_desc; }
            set { this.Date_desc = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Dayi_time_sum
        {            
            get { return this.Dayi_time_sum; }
            set { this.Dayi_time_sum = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Expire_days
        {            
            get { return this.Expire_days; }
            set { this.Expire_days = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Grade_max
        {            
            get { return this.Grade_max; }
            set { this.Grade_max = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Grade_min
        {            
            get { return this.Grade_min; }
            set { this.Grade_min = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Grade_name
        {            
            get { return this.Grade_name; }
            set { this.Grade_name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Have_buy_num
        {            
            get { return this.Have_buy_num; }
            set { this.Have_buy_num = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Home_sum
        {            
            get { return this.Home_sum; }
            set { this.Home_sum = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Home_time_once
        {            
            get { return this.Home_time_once; }
            set { this.Home_time_once = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _Is_delete
        {            
            get { return this.Is_delete; }
            set { this.Is_delete = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public bool _Is_promotion
        {            
            get { return this.Is_promotion; }
            set { this.Is_promotion = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Kemu_id
        {            
            get { return this.Kemu_id; }
            set { this.Kemu_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Online_sum
        {            
            get { return this.Online_sum; }
            set { this.Online_sum = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Online_sum_once
        {            
            get { return this.Online_sum_once; }
            set { this.Online_sum_once = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Order_id
        {            
            get { return this.Order_id; }
            set { this.Order_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Out_trade_on
        {            
            get { return this.Out_trade_on; }
            set { this.Out_trade_on = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Page_type
        {            
            get { return this.Page_type; }
            set { this.Page_type = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public double _Per_price
        {            
            get { return this.Per_price; }
            set { this.Per_price = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Pic
        {            
            get { return this.Pic; }
            set { this.Pic = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public double _Price
        {            
            get { return this.Price; }
            set { this.Price = value; }
        }
        
        /// <summary> 产品id Attribute_IsNotNull </summary>
        public string _Product_id
        {            
            get { return this.Product_id; }
            set { this.Product_id = value; }
        }
        
        /// <summary> 产品数量 Attribute_IsNotNull </summary>
        public int _Product_sum
        {            
            get { return this.Product_sum; }
            set { this.Product_sum = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Promotion_expire_date
        {            
            get { return this.Promotion_expire_date; }
            set { this.Promotion_expire_date = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Promotion_price
        {            
            get { return this.Promotion_price; }
            set { this.Promotion_price = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Short_name
        {            
            get { return this.Short_name; }
            set { this.Short_name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Tese_lesson_num
        {            
            get { return this.Tese_lesson_num; }
            set { this.Tese_lesson_num = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Title
        {            
            get { return this.Title; }
            set { this.Title = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Total_buy_num
        {            
            get { return this.Total_buy_num; }
            set { this.Total_buy_num = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Un_buy_num
        {            
            get { return this.Un_buy_num; }
            set { this.Un_buy_num = value; }
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
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Xb_product_type_id
        {            
            get { return this.Xb_product_type_id; }
            set { this.Xb_product_type_id = value; }
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
        public string Create1
        {
            get { return this.m_create1; }
            set //
            {
                if (!create1_initialized || m_create1 != value)
                {
                    this.m_create1 = value;
                }
                create1_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Date_desc
        {
            get { return this.m_date_desc; }
            set //
            {
                if (!date_desc_initialized || m_date_desc != value)
                {
                    this.m_date_desc = value;
                }
                date_desc_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Dayi_time_sum
        {
            get { return this.m_dayi_time_sum; }
            set //
            {
                if (!dayi_time_sum_initialized || m_dayi_time_sum != value)
                {
                    this.m_dayi_time_sum = value;
                }
                dayi_time_sum_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Expire_days
        {
            get { return this.m_expire_days; }
            set //
            {
                if (!expire_days_initialized || m_expire_days != value)
                {
                    this.m_expire_days = value;
                }
                expire_days_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Grade
        {
            get { return this.m_grade; }
            set //
            {
                if (!grade_initialized || m_grade != value)
                {
                    this.m_grade = value;
                }
                grade_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Grade_max
        {
            get { return this.m_grade_max; }
            set //
            {
                if (!grade_max_initialized || m_grade_max != value)
                {
                    this.m_grade_max = value;
                }
                grade_max_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Grade_min
        {
            get { return this.m_grade_min; }
            set //
            {
                if (!grade_min_initialized || m_grade_min != value)
                {
                    this.m_grade_min = value;
                }
                grade_min_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Grade_name
        {
            get { return this.m_grade_name; }
            set //
            {
                if (!grade_name_initialized || m_grade_name != value)
                {
                    this.m_grade_name = value;
                }
                grade_name_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Have_buy_num
        {
            get { return this.m_have_buy_num; }
            set //
            {
                if (!have_buy_num_initialized || m_have_buy_num != value)
                {
                    this.m_have_buy_num = value;
                }
                have_buy_num_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Home_sum
        {
            get { return this.m_home_sum; }
            set //
            {
                if (!home_sum_initialized || m_home_sum != value)
                {
                    this.m_home_sum = value;
                }
                home_sum_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Home_time_once
        {
            get { return this.m_home_time_once; }
            set //
            {
                if (!home_time_once_initialized || m_home_time_once != value)
                {
                    this.m_home_time_once = value;
                }
                home_time_once_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public bool Is_delete
        {
            get { return this.m_is_delete; }
            set //
            {
                if (!is_delete_initialized || m_is_delete != value)
                {
                    this.m_is_delete = value;
                }
                is_delete_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public bool Is_promotion
        {
            get { return this.m_is_promotion; }
            set //
            {
                if (!is_promotion_initialized || m_is_promotion != value)
                {
                    this.m_is_promotion = value;
                }
                is_promotion_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Kemu_id
        {
            get { return this.m_kemu_id; }
            set //
            {
                if (!kemu_id_initialized || m_kemu_id != value)
                {
                    this.m_kemu_id = value;
                }
                kemu_id_initialized = true;
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Online_sum
        {
            get { return this.m_online_sum; }
            set //
            {
                if (!online_sum_initialized || m_online_sum != value)
                {
                    this.m_online_sum = value;
                }
                online_sum_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Online_sum_once
        {
            get { return this.m_online_sum_once; }
            set //
            {
                if (!online_sum_once_initialized || m_online_sum_once != value)
                {
                    this.m_online_sum_once = value;
                }
                online_sum_once_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Order_id
        {
            get { return this.m_order_id; }
            set //
            {
                if (!order_id_initialized || m_order_id != value)
                {
                    this.m_order_id = value;
                }
                order_id_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Out_trade_on
        {
            get { return this.m_out_trade_on; }
            set //
            {
                if (!out_trade_on_initialized || m_out_trade_on != value)
                {
                    this.m_out_trade_on = value;
                }
                out_trade_on_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Page_type
        {
            get { return this.m_page_type; }
            set //
            {
                if (!page_type_initialized || m_page_type != value)
                {
                    this.m_page_type = value;
                }
                page_type_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public double Per_price
        {
            get { return this.m_per_price; }
            set //
            {
                if (!per_price_initialized || m_per_price != value)
                {
                    this.m_per_price = value;
                }
                per_price_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public double Price
        {
            get { return this.m_price; }
            set //
            {
                if (!price_initialized || m_price != value)
                {
                    this.m_price = value;
                }
                price_initialized = true;
            }
        }
        
        /// <summary> 产品id，推荐使用 "_"符号开头 </summary>
        public string Product_id
        {
            get { return this.m_product_id; }
            set //
            {
                if (!product_id_initialized || m_product_id != value)
                {
                    this.m_product_id = value;
                }
                product_id_initialized = true;
            }
        }
        
        /// <summary> 产品数量，推荐使用 "_"符号开头 </summary>
        public int Product_sum
        {
            get { return this.m_product_sum; }
            set //
            {
                if (!product_sum_initialized || m_product_sum != value)
                {
                    this.m_product_sum = value;
                }
                product_sum_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public DateTime Promotion_expire_date
        {
            get { return this.m_promotion_expire_date; }
            set //
            {
                if (!promotion_expire_date_initialized || m_promotion_expire_date != value)
                {
                    this.m_promotion_expire_date = value;
                }
                promotion_expire_date_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Promotion_price
        {
            get { return this.m_promotion_price; }
            set //
            {
                if (!promotion_price_initialized || m_promotion_price != value)
                {
                    this.m_promotion_price = value;
                }
                promotion_price_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Short_name
        {
            get { return this.m_short_name; }
            set //
            {
                if (!short_name_initialized || m_short_name != value)
                {
                    this.m_short_name = value;
                }
                short_name_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Tese_lesson_num
        {
            get { return this.m_tese_lesson_num; }
            set //
            {
                if (!tese_lesson_num_initialized || m_tese_lesson_num != value)
                {
                    this.m_tese_lesson_num = value;
                }
                tese_lesson_num_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Total_buy_num
        {
            get { return this.m_total_buy_num; }
            set //
            {
                if (!total_buy_num_initialized || m_total_buy_num != value)
                {
                    this.m_total_buy_num = value;
                }
                total_buy_num_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public int Un_buy_num
        {
            get { return this.m_un_buy_num; }
            set //
            {
                if (!un_buy_num_initialized || m_un_buy_num != value)
                {
                    this.m_un_buy_num = value;
                }
                un_buy_num_initialized = true;
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Xb_product_type_id
        {
            get { return this.m_xb_product_type_id; }
            set //
            {
                if (!xb_product_type_id_initialized || m_xb_product_type_id != value)
                {
                    this.m_xb_product_type_id = value;
                }
                xb_product_type_id_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_order_detail].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xb_order_detail].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Create1 =  new AttributeItem("[Xb_order_detail].[Create1]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Date_desc =  new AttributeItem("[Xb_order_detail].[Date_desc]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dayi_time_sum =  new AttributeItem("[Xb_order_detail].[Dayi_time_sum]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Expire_days =  new AttributeItem("[Xb_order_detail].[Expire_days]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Grade =  new AttributeItem("[Xb_order_detail].[Grade]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Grade_max =  new AttributeItem("[Xb_order_detail].[Grade_max]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Grade_min =  new AttributeItem("[Xb_order_detail].[Grade_min]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Grade_name =  new AttributeItem("[Xb_order_detail].[Grade_name]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Have_buy_num =  new AttributeItem("[Xb_order_detail].[Have_buy_num]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Home_sum =  new AttributeItem("[Xb_order_detail].[Home_sum]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Home_time_once =  new AttributeItem("[Xb_order_detail].[Home_time_once]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Is_delete =  new AttributeItem("[Xb_order_detail].[Is_delete]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Is_promotion =  new AttributeItem("[Xb_order_detail].[Is_promotion]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Kemu_id =  new AttributeItem("[Xb_order_detail].[Kemu_id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xb_order_detail].[Modify_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Name =  new AttributeItem("[Xb_order_detail].[Name]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Online_sum =  new AttributeItem("[Xb_order_detail].[Online_sum]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Online_sum_once =  new AttributeItem("[Xb_order_detail].[Online_sum_once]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Order_id =  new AttributeItem("[Xb_order_detail].[Order_id]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Out_trade_on =  new AttributeItem("[Xb_order_detail].[Out_trade_on]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Page_type =  new AttributeItem("[Xb_order_detail].[Page_type]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Per_price =  new AttributeItem("[Xb_order_detail].[Per_price]", typeof(double), 8, default(double));
            
            /// <summary></summary>
            public static AttributeItem Pic =  new AttributeItem("[Xb_order_detail].[Pic]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Price =  new AttributeItem("[Xb_order_detail].[Price]", typeof(double), 8, default(double));
            
            /// <summary>产品id</summary>
            public static AttributeItem Product_id =  new AttributeItem("[Xb_order_detail].[Product_id]", typeof(string), 36, default(string));
            
            /// <summary>产品数量</summary>
            public static AttributeItem Product_sum =  new AttributeItem("[Xb_order_detail].[Product_sum]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Promotion_expire_date =  new AttributeItem("[Xb_order_detail].[Promotion_expire_date]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Promotion_price =  new AttributeItem("[Xb_order_detail].[Promotion_price]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Short_name =  new AttributeItem("[Xb_order_detail].[Short_name]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Tese_lesson_num =  new AttributeItem("[Xb_order_detail].[Tese_lesson_num]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Title =  new AttributeItem("[Xb_order_detail].[Title]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Total_buy_num =  new AttributeItem("[Xb_order_detail].[Total_buy_num]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Un_buy_num =  new AttributeItem("[Xb_order_detail].[Un_buy_num]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_order_detail].[User_id]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_order_detail].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Xb_product_type_id =  new AttributeItem("[Xb_order_detail].[Xb_product_type_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private string m_create1;
        /// <summary></summary>
        protected bool create1_initialized = false;
        
        private string m_date_desc;
        /// <summary></summary>
        protected bool date_desc_initialized = false;
        
        private int m_dayi_time_sum;
        /// <summary></summary>
        protected bool dayi_time_sum_initialized = false;
        
        private int m_expire_days;
        /// <summary></summary>
        protected bool expire_days_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private int m_grade_max;
        /// <summary></summary>
        protected bool grade_max_initialized = false;
        
        private int m_grade_min;
        /// <summary></summary>
        protected bool grade_min_initialized = false;
        
        private string m_grade_name;
        /// <summary></summary>
        protected bool grade_name_initialized = false;
        
        private int m_have_buy_num;
        /// <summary></summary>
        protected bool have_buy_num_initialized = false;
        
        private int m_home_sum;
        /// <summary></summary>
        protected bool home_sum_initialized = false;
        
        private int m_home_time_once;
        /// <summary></summary>
        protected bool home_time_once_initialized = false;
        
        private bool m_is_delete;
        /// <summary></summary>
        protected bool is_delete_initialized = false;
        
        private bool m_is_promotion;
        /// <summary></summary>
        protected bool is_promotion_initialized = false;
        
        private int m_kemu_id;
        /// <summary></summary>
        protected bool kemu_id_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private int m_online_sum;
        /// <summary></summary>
        protected bool online_sum_initialized = false;
        
        private int m_online_sum_once;
        /// <summary></summary>
        protected bool online_sum_once_initialized = false;
        
        private string m_order_id;
        /// <summary></summary>
        protected bool order_id_initialized = false;
        
        private string m_out_trade_on;
        /// <summary></summary>
        protected bool out_trade_on_initialized = false;
        
        private int m_page_type;
        /// <summary></summary>
        protected bool page_type_initialized = false;
        
        private double m_per_price;
        /// <summary></summary>
        protected bool per_price_initialized = false;
        
        private string m_pic;
        /// <summary></summary>
        protected bool pic_initialized = false;
        
        private double m_price;
        /// <summary></summary>
        protected bool price_initialized = false;
        
        private string m_product_id;
        /// <summary></summary>
        protected bool product_id_initialized = false;
        
        private int m_product_sum;
        /// <summary></summary>
        protected bool product_sum_initialized = false;
        
        private DateTime m_promotion_expire_date;
        /// <summary></summary>
        protected bool promotion_expire_date_initialized = false;
        
        private int m_promotion_price;
        /// <summary></summary>
        protected bool promotion_price_initialized = false;
        
        private string m_short_name;
        /// <summary></summary>
        protected bool short_name_initialized = false;
        
        private int m_tese_lesson_num;
        /// <summary></summary>
        protected bool tese_lesson_num_initialized = false;
        
        private string m_title;
        /// <summary></summary>
        protected bool title_initialized = false;
        
        private int m_total_buy_num;
        /// <summary></summary>
        protected bool total_buy_num_initialized = false;
        
        private int m_un_buy_num;
        /// <summary></summary>
        protected bool un_buy_num_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_xb_product_type_id;
        /// <summary></summary>
        protected bool xb_product_type_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_order_detail";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.create1_initialized = IsLoadAllAttributes;this.date_desc_initialized = IsLoadAllAttributes;this.dayi_time_sum_initialized = IsLoadAllAttributes;this.expire_days_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.grade_max_initialized = IsLoadAllAttributes;this.grade_min_initialized = IsLoadAllAttributes;this.grade_name_initialized = IsLoadAllAttributes;this.have_buy_num_initialized = IsLoadAllAttributes;this.home_sum_initialized = IsLoadAllAttributes;this.home_time_once_initialized = IsLoadAllAttributes;this.is_delete_initialized = IsLoadAllAttributes;this.is_promotion_initialized = IsLoadAllAttributes;this.kemu_id_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.online_sum_initialized = IsLoadAllAttributes;this.online_sum_once_initialized = IsLoadAllAttributes;this.order_id_initialized = IsLoadAllAttributes;this.out_trade_on_initialized = IsLoadAllAttributes;this.page_type_initialized = IsLoadAllAttributes;this.per_price_initialized = IsLoadAllAttributes;this.pic_initialized = IsLoadAllAttributes;this.price_initialized = IsLoadAllAttributes;this.product_id_initialized = IsLoadAllAttributes;this.product_sum_initialized = IsLoadAllAttributes;this.promotion_expire_date_initialized = IsLoadAllAttributes;this.promotion_price_initialized = IsLoadAllAttributes;this.short_name_initialized = IsLoadAllAttributes;this.tese_lesson_num_initialized = IsLoadAllAttributes;this.title_initialized = IsLoadAllAttributes;this.total_buy_num_initialized = IsLoadAllAttributes;this.un_buy_num_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.xb_product_type_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_order_detail value = new Xb_order_detail();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create1"))
				value.create1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Date_desc"))
				value.date_desc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dayi_time_sum"))
				value.dayi_time_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Expire_days"))
				value.expire_days_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade_max"))
				value.grade_max_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade_min"))
				value.grade_min_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade_name"))
				value.grade_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Have_buy_num"))
				value.have_buy_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Home_sum"))
				value.home_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Home_time_once"))
				value.home_time_once_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_delete"))
				value.is_delete_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_promotion"))
				value.is_promotion_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_id"))
				value.kemu_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Online_sum"))
				value.online_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Online_sum_once"))
				value.online_sum_once_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Order_id"))
				value.order_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Out_trade_on"))
				value.out_trade_on_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Page_type"))
				value.page_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Per_price"))
				value.per_price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pic"))
				value.pic_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Price"))
				value.price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Product_id"))
				value.product_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Product_sum"))
				value.product_sum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Promotion_expire_date"))
				value.promotion_expire_date_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Promotion_price"))
				value.promotion_price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Short_name"))
				value.short_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Tese_lesson_num"))
				value.tese_lesson_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Title"))
				value.title_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Total_buy_num"))
				value.total_buy_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Un_buy_num"))
				value.un_buy_num_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Xb_product_type_id"))
				value.xb_product_type_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_order_detail Clone()
        {
            return (Xb_order_detail)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_order_detail()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_order_detail() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_order_detail(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_order_detail(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_order_detail(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_order_detail(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_order_detail(int id1, DateTime create_time1, string create11, string date_desc1, int dayi_time_sum1, int expire_days1, int grade1, int grade_max1, int grade_min1, string grade_name1, int have_buy_num1, int home_sum1, int home_time_once1, bool is_delete1, bool is_promotion1, int kemu_id1, DateTime modify_time1, string name1, int online_sum1, int online_sum_once1, string order_id1, string out_trade_on1, int page_type1, double per_price1, string pic1, double price1, string product_id1, int product_sum1, DateTime promotion_expire_date1, int promotion_price1, string short_name1, int tese_lesson_num1, string title1, int total_buy_num1, int un_buy_num1, string user_id1, Guid uuid1, string xb_product_type_id1)
        {
            
            this.Id = id1;
            
            this.Create_time = create_time1;
            
            this.Create1 = create11;
            
            this.Date_desc = date_desc1;
            
            this.Dayi_time_sum = dayi_time_sum1;
            
            this.Expire_days = expire_days1;
            
            this.Grade = grade1;
            
            this.Grade_max = grade_max1;
            
            this.Grade_min = grade_min1;
            
            this.Grade_name = grade_name1;
            
            this.Have_buy_num = have_buy_num1;
            
            this.Home_sum = home_sum1;
            
            this.Home_time_once = home_time_once1;
            
            this.Is_delete = is_delete1;
            
            this.Is_promotion = is_promotion1;
            
            this.Kemu_id = kemu_id1;
            
            this.Modify_time = modify_time1;
            
            this.Name = name1;
            
            this.Online_sum = online_sum1;
            
            this.Online_sum_once = online_sum_once1;
            
            this.Order_id = order_id1;
            
            this.Out_trade_on = out_trade_on1;
            
            this.Page_type = page_type1;
            
            this.Per_price = per_price1;
            
            this.Pic = pic1;
            
            this.Price = price1;
            
            this.Product_id = product_id1;
            
            this.Product_sum = product_sum1;
            
            this.Promotion_expire_date = promotion_expire_date1;
            
            this.Promotion_price = promotion_price1;
            
            this.Short_name = short_name1;
            
            this.Tese_lesson_num = tese_lesson_num1;
            
            this.Title = title1;
            
            this.Total_buy_num = total_buy_num1;
            
            this.Un_buy_num = un_buy_num1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
            
            this.Xb_product_type_id = xb_product_type_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_order_detail FromIView(IView view)
        {
            return (Xb_order_detail)IView.GetITable(view, "Xb_order_detail");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_order_detail GetOneInstance()
        {
            Xb_order_detail value = new Xb_order_detail();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_order_detail Retrieve()
        {
            BLLTable<Xb_order_detail>.GetRowData(this);
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
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Create1":
			        return Create1;
			    			
			    case "Date_desc":
			        return Date_desc;
			    			
			    case "Dayi_time_sum":
			        return Dayi_time_sum;
			    			
			    case "Expire_days":
			        return Expire_days;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Grade_max":
			        return Grade_max;
			    			
			    case "Grade_min":
			        return Grade_min;
			    			
			    case "Grade_name":
			        return Grade_name;
			    			
			    case "Have_buy_num":
			        return Have_buy_num;
			    			
			    case "Home_sum":
			        return Home_sum;
			    			
			    case "Home_time_once":
			        return Home_time_once;
			    			
			    case "Is_delete":
			        return Is_delete;
			    			
			    case "Is_promotion":
			        return Is_promotion;
			    			
			    case "Kemu_id":
			        return Kemu_id;
			    			
			    case "Modify_time":
			        return Modify_time;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Online_sum":
			        return Online_sum;
			    			
			    case "Online_sum_once":
			        return Online_sum_once;
			    			
			    case "Order_id":
			        return Order_id;
			    			
			    case "Out_trade_on":
			        return Out_trade_on;
			    			
			    case "Page_type":
			        return Page_type;
			    			
			    case "Per_price":
			        return Per_price;
			    			
			    case "Pic":
			        return Pic;
			    			
			    case "Price":
			        return Price;
			    			
			    case "Product_id":
			        return Product_id;
			    			
			    case "Product_sum":
			        return Product_sum;
			    			
			    case "Promotion_expire_date":
			        return Promotion_expire_date;
			    			
			    case "Promotion_price":
			        return Promotion_price;
			    			
			    case "Short_name":
			        return Short_name;
			    			
			    case "Tese_lesson_num":
			        return Tese_lesson_num;
			    			
			    case "Title":
			        return Title;
			    			
			    case "Total_buy_num":
			        return Total_buy_num;
			    			
			    case "Un_buy_num":
			        return Un_buy_num;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "Xb_product_type_id":
			        return Xb_product_type_id;
			
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
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Create1":
			        this.Create1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Date_desc":
			        this.Date_desc = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dayi_time_sum":
			        this.Dayi_time_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Expire_days":
			        this.Expire_days = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade_max":
			        this.Grade_max = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade_min":
			        this.Grade_min = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Grade_name":
			        this.Grade_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Have_buy_num":
			        this.Have_buy_num = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Home_sum":
			        this.Home_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Home_time_once":
			        this.Home_time_once = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Is_delete":
			        this.Is_delete = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Is_promotion":
			        this.Is_promotion = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Kemu_id":
			        this.Kemu_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Online_sum":
			        this.Online_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Online_sum_once":
			        this.Online_sum_once = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Order_id":
			        this.Order_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Out_trade_on":
			        this.Out_trade_on = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Page_type":
			        this.Page_type = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Per_price":
			        this.Per_price = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Pic":
			        this.Pic = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Price":
			        this.Price = Convert.ToDouble(AttributeValue);
                    return true;
			    			
			    case "Product_id":
			        this.Product_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Product_sum":
			        this.Product_sum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Promotion_expire_date":
			        this.Promotion_expire_date = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Promotion_price":
			        this.Promotion_price = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Short_name":
			        this.Short_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Tese_lesson_num":
			        this.Tese_lesson_num = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Title":
			        this.Title = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Total_buy_num":
			        this.Total_buy_num = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Un_buy_num":
			        this.Un_buy_num = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Xb_product_type_id":
			        this.Xb_product_type_id = Convert.ToString(AttributeValue);
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
				
				case "Create_time":
					return create_time_initialized;
				
				case "Create1":
					return create1_initialized;
				
				case "Date_desc":
					return date_desc_initialized;
				
				case "Dayi_time_sum":
					return dayi_time_sum_initialized;
				
				case "Expire_days":
					return expire_days_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Grade_max":
					return grade_max_initialized;
				
				case "Grade_min":
					return grade_min_initialized;
				
				case "Grade_name":
					return grade_name_initialized;
				
				case "Have_buy_num":
					return have_buy_num_initialized;
				
				case "Home_sum":
					return home_sum_initialized;
				
				case "Home_time_once":
					return home_time_once_initialized;
				
				case "Is_delete":
					return is_delete_initialized;
				
				case "Is_promotion":
					return is_promotion_initialized;
				
				case "Kemu_id":
					return kemu_id_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Online_sum":
					return online_sum_initialized;
				
				case "Online_sum_once":
					return online_sum_once_initialized;
				
				case "Order_id":
					return order_id_initialized;
				
				case "Out_trade_on":
					return out_trade_on_initialized;
				
				case "Page_type":
					return page_type_initialized;
				
				case "Per_price":
					return per_price_initialized;
				
				case "Pic":
					return pic_initialized;
				
				case "Price":
					return price_initialized;
				
				case "Product_id":
					return product_id_initialized;
				
				case "Product_sum":
					return product_sum_initialized;
				
				case "Promotion_expire_date":
					return promotion_expire_date_initialized;
				
				case "Promotion_price":
					return promotion_price_initialized;
				
				case "Short_name":
					return short_name_initialized;
				
				case "Tese_lesson_num":
					return tese_lesson_num_initialized;
				
				case "Title":
					return title_initialized;
				
				case "Total_buy_num":
					return total_buy_num_initialized;
				
				case "Un_buy_num":
					return un_buy_num_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "Xb_product_type_id":
					return xb_product_type_id_initialized;
				
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
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Create1":
					create1_initialized = ret;
					return true;
				
				case "Date_desc":
					date_desc_initialized = ret;
					return true;
				
				case "Dayi_time_sum":
					dayi_time_sum_initialized = ret;
					return true;
				
				case "Expire_days":
					expire_days_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Grade_max":
					grade_max_initialized = ret;
					return true;
				
				case "Grade_min":
					grade_min_initialized = ret;
					return true;
				
				case "Grade_name":
					grade_name_initialized = ret;
					return true;
				
				case "Have_buy_num":
					have_buy_num_initialized = ret;
					return true;
				
				case "Home_sum":
					home_sum_initialized = ret;
					return true;
				
				case "Home_time_once":
					home_time_once_initialized = ret;
					return true;
				
				case "Is_delete":
					is_delete_initialized = ret;
					return true;
				
				case "Is_promotion":
					is_promotion_initialized = ret;
					return true;
				
				case "Kemu_id":
					kemu_id_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Online_sum":
					online_sum_initialized = ret;
					return true;
				
				case "Online_sum_once":
					online_sum_once_initialized = ret;
					return true;
				
				case "Order_id":
					order_id_initialized = ret;
					return true;
				
				case "Out_trade_on":
					out_trade_on_initialized = ret;
					return true;
				
				case "Page_type":
					page_type_initialized = ret;
					return true;
				
				case "Per_price":
					per_price_initialized = ret;
					return true;
				
				case "Pic":
					pic_initialized = ret;
					return true;
				
				case "Price":
					price_initialized = ret;
					return true;
				
				case "Product_id":
					product_id_initialized = ret;
					return true;
				
				case "Product_sum":
					product_sum_initialized = ret;
					return true;
				
				case "Promotion_expire_date":
					promotion_expire_date_initialized = ret;
					return true;
				
				case "Promotion_price":
					promotion_price_initialized = ret;
					return true;
				
				case "Short_name":
					short_name_initialized = ret;
					return true;
				
				case "Tese_lesson_num":
					tese_lesson_num_initialized = ret;
					return true;
				
				case "Title":
					title_initialized = ret;
					return true;
				
				case "Total_buy_num":
					total_buy_num_initialized = ret;
					return true;
				
				case "Un_buy_num":
					un_buy_num_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Xb_product_type_id":
					xb_product_type_id_initialized = ret;
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
                AttributeItem attr = Xb_order_detail.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (create1_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Create1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create1);
                }
			}
			
			if (date_desc_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Date_desc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Date_desc);
                }
			}
			
			if (dayi_time_sum_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Dayi_time_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dayi_time_sum);
                }
			}
			
			if (expire_days_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Expire_days;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Expire_days);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (grade_max_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Grade_max;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade_max);
                }
			}
			
			if (grade_min_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Grade_min;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade_min);
                }
			}
			
			if (grade_name_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Grade_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade_name);
                }
			}
			
			if (have_buy_num_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Have_buy_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Have_buy_num);
                }
			}
			
			if (home_sum_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Home_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Home_sum);
                }
			}
			
			if (home_time_once_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Home_time_once;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Home_time_once);
                }
			}
			
			if (is_delete_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Is_delete;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_delete);
                }
			}
			
			if (is_promotion_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Is_promotion;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_promotion);
                }
			}
			
			if (kemu_id_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Kemu_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_id);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (online_sum_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Online_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Online_sum);
                }
			}
			
			if (online_sum_once_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Online_sum_once;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Online_sum_once);
                }
			}
			
			if (order_id_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Order_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Order_id);
                }
			}
			
			if (out_trade_on_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Out_trade_on;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Out_trade_on);
                }
			}
			
			if (page_type_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Page_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Page_type);
                }
			}
			
			if (per_price_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Per_price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Per_price);
                }
			}
			
			if (pic_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Pic;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pic);
                }
			}
			
			if (price_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Price);
                }
			}
			
			if (product_id_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Product_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Product_id);
                }
			}
			
			if (product_sum_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Product_sum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Product_sum);
                }
			}
			
			if (promotion_expire_date_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Promotion_expire_date;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Promotion_expire_date);
                }
			}
			
			if (promotion_price_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Promotion_price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Promotion_price);
                }
			}
			
			if (short_name_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Short_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Short_name);
                }
			}
			
			if (tese_lesson_num_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Tese_lesson_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Tese_lesson_num);
                }
			}
			
			if (title_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Title;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Title);
                }
			}
			
			if (total_buy_num_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Total_buy_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Total_buy_num);
                }
			}
			
			if (un_buy_num_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Un_buy_num;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Un_buy_num);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (xb_product_type_id_initialized)
			{
                AttributeItem attr = Xb_order_detail.Attribute.Xb_product_type_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Xb_product_type_id);
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
        public class Xb_order_detailJson
        {
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public DateTime Create_time { get; set; }
            
            /// <summary></summary>
            public string Create1 { get; set; }
            
            /// <summary></summary>
            public string Date_desc { get; set; }
            
            /// <summary></summary>
            public int Dayi_time_sum { get; set; }
            
            /// <summary></summary>
            public int Expire_days { get; set; }
            
            /// <summary></summary>
            public int Grade { get; set; }
            
            /// <summary></summary>
            public int Grade_max { get; set; }
            
            /// <summary></summary>
            public int Grade_min { get; set; }
            
            /// <summary></summary>
            public string Grade_name { get; set; }
            
            /// <summary></summary>
            public int Have_buy_num { get; set; }
            
            /// <summary></summary>
            public int Home_sum { get; set; }
            
            /// <summary></summary>
            public int Home_time_once { get; set; }
            
            /// <summary></summary>
            public bool Is_delete { get; set; }
            
            /// <summary></summary>
            public bool Is_promotion { get; set; }
            
            /// <summary></summary>
            public int Kemu_id { get; set; }
            
            /// <summary></summary>
            public DateTime Modify_time { get; set; }
            
            /// <summary></summary>
            public string Name { get; set; }
            
            /// <summary></summary>
            public int Online_sum { get; set; }
            
            /// <summary></summary>
            public int Online_sum_once { get; set; }
            
            /// <summary></summary>
            public string Order_id { get; set; }
            
            /// <summary></summary>
            public string Out_trade_on { get; set; }
            
            /// <summary></summary>
            public int Page_type { get; set; }
            
            /// <summary></summary>
            public double Per_price { get; set; }
            
            /// <summary></summary>
            public string Pic { get; set; }
            
            /// <summary></summary>
            public double Price { get; set; }
            
            /// <summary>产品id</summary>
            public string Product_id { get; set; }
            
            /// <summary>产品数量</summary>
            public int Product_sum { get; set; }
            
            /// <summary></summary>
            public DateTime Promotion_expire_date { get; set; }
            
            /// <summary></summary>
            public int Promotion_price { get; set; }
            
            /// <summary></summary>
            public string Short_name { get; set; }
            
            /// <summary></summary>
            public int Tese_lesson_num { get; set; }
            
            /// <summary></summary>
            public string Title { get; set; }
            
            /// <summary></summary>
            public int Total_buy_num { get; set; }
            
            /// <summary></summary>
            public int Un_buy_num { get; set; }
            
            /// <summary></summary>
            public string User_id { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
            
            /// <summary></summary>
            public string Xb_product_type_id { get; set; }
        }
        #endregion
    }
}
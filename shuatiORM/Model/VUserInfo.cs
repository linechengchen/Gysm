/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/8 14:54:48
  Description:    ���ݱ�VUserInfo��Ӧ��ҵ���߼���VUserInfo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� VUserInfo_Entity:VUserInfo
 * 
************************************************************/
/************************************************************
SQL���룺
select ID,User_id,Nick_name,Headimgurl,Phone_number,PassWord,Real_name,User_name,DeviceId,Gender,City,Province,Qq,Change,Wechat_app_openid,Token,Point,Wechat_openid,Weibo,Province_id,City_id,Show_name,School_id,Department_id,Latitude,Longitude,School_name,Department_name,Grade,Email,User_type,Ref_id,Sc_id,School_name2,Department_name2 from VUserInfo
delete from VUserInfo
INSERT INTO VUserInfo (ID,User_id,Nick_name,Headimgurl,Phone_number,PassWord,Real_name,User_name,DeviceId,Gender,City,Province,Qq,Change,Wechat_app_openid,Token,Point,Wechat_openid,Weibo,Province_id,City_id,Show_name,School_id,Department_id,Latitude,Longitude,School_name,Department_name,Grade,Email,User_type,Ref_id,Sc_id,School_name2,Department_name2)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','')
UPDATE VUserInfo SET ...
������ֵ���룺
 *         valObj.ID = valObj2.ID;
        valObj.User_id = valObj2.User_id;
        valObj.Nick_name = valObj2.Nick_name;
        valObj.Headimgurl = valObj2.Headimgurl;
        valObj.Phone_number = valObj2.Phone_number;
        valObj.PassWord = valObj2.PassWord;
        valObj.Real_name = valObj2.Real_name;
        valObj.User_name = valObj2.User_name;
        valObj.DeviceId = valObj2.DeviceId;
        valObj.Gender = valObj2.Gender;
        valObj.City = valObj2.City;
        valObj.Province = valObj2.Province;
        valObj.Qq = valObj2.Qq;
        valObj.Change = valObj2.Change;
        valObj.Wechat_app_openid = valObj2.Wechat_app_openid;
        valObj.Token = valObj2.Token;
        valObj.Point = valObj2.Point;
        valObj.Wechat_openid = valObj2.Wechat_openid;
        valObj.Weibo = valObj2.Weibo;
        valObj.Province_id = valObj2.Province_id;
        valObj.City_id = valObj2.City_id;
        valObj.Show_name = valObj2.Show_name;
        valObj.School_id = valObj2.School_id;
        valObj.Department_id = valObj2.Department_id;
        valObj.Latitude = valObj2.Latitude;
        valObj.Longitude = valObj2.Longitude;
        valObj.School_name = valObj2.School_name;
        valObj.Department_name = valObj2.Department_name;
        valObj.Grade = valObj2.Grade;
        valObj.Email = valObj2.Email;
        valObj.User_type = valObj2.User_type;
        valObj.Ref_id = valObj2.Ref_id;
        valObj.Sc_id = valObj2.Sc_id;
        valObj.School_name2 = valObj2.School_name2;
        valObj.Department_name2 = valObj2.Department_name2; 
        valObj.ID = "";
        valObj.User_id = "";
        valObj.Nick_name = "";
        valObj.Headimgurl = "";
        valObj.Phone_number = "";
        valObj.PassWord = "";
        valObj.Real_name = "";
        valObj.User_name = "";
        valObj.DeviceId = "";
        valObj.Gender = "";
        valObj.City = "";
        valObj.Province = "";
        valObj.Qq = "";
        valObj.Change = "";
        valObj.Wechat_app_openid = "";
        valObj.Token = "";
        valObj.Point = "";
        valObj.Wechat_openid = "";
        valObj.Weibo = "";
        valObj.Province_id = "";
        valObj.City_id = "";
        valObj.Show_name = "";
        valObj.School_id = "";
        valObj.Department_id = "";
        valObj.Latitude = "";
        valObj.Longitude = "";
        valObj.School_name = "";
        valObj.Department_name = "";
        valObj.Grade = "";
        valObj.Email = "";
        valObj.User_type = "";
        valObj.Ref_id = "";
        valObj.Sc_id = "";
        valObj.School_name2 = "";
        valObj.Department_name2 = ""; 
        "ID": $("#txt_ID").val(),
        "User_id": $("#txt_User_id").val(),
        "Nick_name": $("#txt_Nick_name").val(),
        "Headimgurl": $("#txt_Headimgurl").val(),
        "Phone_number": $("#txt_Phone_number").val(),
        "PassWord": $("#txt_PassWord").val(),
        "Real_name": $("#txt_Real_name").val(),
        "User_name": $("#txt_User_name").val(),
        "DeviceId": $("#txt_DeviceId").val(),
        "Gender": $("#txt_Gender").val(),
        "City": $("#txt_City").val(),
        "Province": $("#txt_Province").val(),
        "Qq": $("#txt_Qq").val(),
        "Change": $("#txt_Change").val(),
        "Wechat_app_openid": $("#txt_Wechat_app_openid").val(),
        "Token": $("#txt_Token").val(),
        "Point": $("#txt_Point").val(),
        "Wechat_openid": $("#txt_Wechat_openid").val(),
        "Weibo": $("#txt_Weibo").val(),
        "Province_id": $("#txt_Province_id").val(),
        "City_id": $("#txt_City_id").val(),
        "Show_name": $("#txt_Show_name").val(),
        "School_id": $("#txt_School_id").val(),
        "Department_id": $("#txt_Department_id").val(),
        "Latitude": $("#txt_Latitude").val(),
        "Longitude": $("#txt_Longitude").val(),
        "School_name": $("#txt_School_name").val(),
        "Department_name": $("#txt_Department_name").val(),
        "Grade": $("#txt_Grade").val(),
        "Email": $("#txt_Email").val(),
        "User_type": $("#txt_User_type").val(),
        "Ref_id": $("#txt_Ref_id").val(),
        "Sc_id": $("#txt_Sc_id").val(),
        "School_name2": $("#txt_School_name2").val(),
        "Department_name2": $("#txt_Department_name2").val(), 
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
    /// <para>Ժϵ��Ϣ__ѧУ��Ϣ__Դ��Ϣ//��ѧ��Ż�ҽ�ѧ��__�û���Ϣ:[Inner-{TDepartment:0},{TSchool:1},{TscWxInfo:2},{TUserInfo:3}]</para>
    /// <para>��VUserInfo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class VUserInfo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static VUserInfo Factory()
        {
            return new VUserInfo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _ID
        {            
            get { return this.ID; }
            set { this.ID = value; }
        }
        
        /// <summary> �û����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public Guid _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Nick_name
        {            
            get { return this.Nick_name; }
            set { this.Nick_name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Headimgurl
        {            
            get { return this.Headimgurl; }
            set { this.Headimgurl = value; }
        }
        
        /// <summary> �ֻ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Phone_number
        {            
            get { return this.Phone_number; }
            set { this.Phone_number = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PassWord
        {            
            get { return this.PassWord; }
            set { this.PassWord = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Real_name
        {            
            get { return this.Real_name; }
            set { this.Real_name = value; }
        }
        
        /// <summary> �û���ʵ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_name
        {            
            get { return this.User_name; }
            set { this.User_name = value; }
        }
        
        /// <summary> �豸Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _DeviceId
        {            
            get { return this.DeviceId; }
            set { this.DeviceId = value; }
        }
        
        /// <summary> �û����Ա�ֵΪ1ʱ�����ԣ�ֵΪ2ʱ��Ů�ԣ�ֵΪ0ʱ��δ֪:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Gender
        {            
            get { return this.Gender; }
            set { this.Gender = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _City
        {            
            get { return this.City; }
            set { this.City = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Province
        {            
            get { return this.Province; }
            set { this.Province = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Qq
        {            
            get { return this.Qq; }
            set { this.Qq = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public decimal _Change
        {            
            get { return this.Change; }
            set { this.Change = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Wechat_app_openid
        {            
            get { return this.Wechat_app_openid; }
            set { this.Wechat_app_openid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Token
        {            
            get { return this.Token; }
            set { this.Token = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Point
        {            
            get { return this.Point; }
            set { this.Point = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Wechat_openid
        {            
            get { return this.Wechat_openid; }
            set { this.Wechat_openid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Weibo
        {            
            get { return this.Weibo; }
            set { this.Weibo = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Province_id
        {            
            get { return this.Province_id; }
            set { this.Province_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _City_id
        {            
            get { return this.City_id; }
            set { this.City_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Show_name
        {            
            get { return this.Show_name; }
            set { this.Show_name = value; }
        }
        
        /// <summary> ѧУid:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _School_id
        {            
            get { return this.School_id; }
            set { this.School_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Department_id
        {            
            get { return this.Department_id; }
            set { this.Department_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public decimal _Latitude
        {            
            get { return this.Latitude; }
            set { this.Latitude = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public decimal _Longitude
        {            
            get { return this.Longitude; }
            set { this.Longitude = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _School_name
        {            
            get { return this.School_name; }
            set { this.School_name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Department_name
        {            
            get { return this.Department_name; }
            set { this.Department_name = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Email
        {            
            get { return this.Email; }
            set { this.Email = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _User_type
        {            
            get { return this.User_type; }
            set { this.User_type = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Ref_id
        {            
            get { return this.Ref_id; }
            set { this.Ref_id = value; }
        }
        
        /// <summary> ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc_id
        {            
            get { return this.Sc_id; }
            set { this.Sc_id = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _School_name2
        {            
            get { return this.School_name2; }
            set { this.School_name2 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Department_name2
        {            
            get { return this.Department_name2; }
            set { this.Department_name2 = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ID
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
        
        /// <summary> �û����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Nick_name
        {
            get { return this.m_nick_name; }
            set //
            {
                if (!nick_name_initialized || m_nick_name != value)
                {
                    this.m_nick_name = value;
                }
                nick_name_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Headimgurl
        {
            get { return this.m_headimgurl; }
            set //
            {
                if (!headimgurl_initialized || m_headimgurl != value)
                {
                    this.m_headimgurl = value;
                }
                headimgurl_initialized = true;
            }
        }
        
        /// <summary> �ֻ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Phone_number
        {
            get { return this.m_phone_number; }
            set //
            {
                if (!phone_number_initialized || m_phone_number != value)
                {
                    this.m_phone_number = value;
                }
                phone_number_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PassWord
        {
            get { return this.m_password; }
            set //
            {
                if (!password_initialized || m_password != value)
                {
                    this.m_password = value;
                }
                password_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Real_name
        {
            get { return this.m_real_name; }
            set //
            {
                if (!real_name_initialized || m_real_name != value)
                {
                    this.m_real_name = value;
                }
                real_name_initialized = true;
            }
        }
        
        /// <summary> �û���ʵ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string User_name
        {
            get { return this.m_user_name; }
            set //
            {
                if (!user_name_initialized || m_user_name != value)
                {
                    this.m_user_name = value;
                }
                user_name_initialized = true;
            }
        }
        
        /// <summary> �豸Id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string DeviceId
        {
            get { return this.m_deviceid; }
            set //
            {
                if (!deviceid_initialized || m_deviceid != value)
                {
                    this.m_deviceid = value;
                }
                deviceid_initialized = true;
            }
        }
        
        /// <summary> �û����Ա�ֵΪ1ʱ�����ԣ�ֵΪ2ʱ��Ů�ԣ�ֵΪ0ʱ��δ֪:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Gender
        {
            get { return this.m_gender; }
            set //
            {
                if (!gender_initialized || m_gender != value)
                {
                    this.m_gender = value;
                }
                gender_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string City
        {
            get { return this.m_city; }
            set //
            {
                if (!city_initialized || m_city != value)
                {
                    this.m_city = value;
                }
                city_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Province
        {
            get { return this.m_province; }
            set //
            {
                if (!province_initialized || m_province != value)
                {
                    this.m_province = value;
                }
                province_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Qq
        {
            get { return this.m_qq; }
            set //
            {
                if (!qq_initialized || m_qq != value)
                {
                    this.m_qq = value;
                }
                qq_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Change
        {
            get { return this.m_change; }
            set //
            {
                if (!change_initialized || m_change != value)
                {
                    this.m_change = value;
                }
                change_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Wechat_app_openid
        {
            get { return this.m_wechat_app_openid; }
            set //
            {
                if (!wechat_app_openid_initialized || m_wechat_app_openid != value)
                {
                    this.m_wechat_app_openid = value;
                }
                wechat_app_openid_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Token
        {
            get { return this.m_token; }
            set //
            {
                if (!token_initialized || m_token != value)
                {
                    this.m_token = value;
                }
                token_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Point
        {
            get { return this.m_point; }
            set //
            {
                if (!point_initialized || m_point != value)
                {
                    this.m_point = value;
                }
                point_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Wechat_openid
        {
            get { return this.m_wechat_openid; }
            set //
            {
                if (!wechat_openid_initialized || m_wechat_openid != value)
                {
                    this.m_wechat_openid = value;
                }
                wechat_openid_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Weibo
        {
            get { return this.m_weibo; }
            set //
            {
                if (!weibo_initialized || m_weibo != value)
                {
                    this.m_weibo = value;
                }
                weibo_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Province_id
        {
            get { return this.m_province_id; }
            set //
            {
                if (!province_id_initialized || m_province_id != value)
                {
                    this.m_province_id = value;
                }
                province_id_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int City_id
        {
            get { return this.m_city_id; }
            set //
            {
                if (!city_id_initialized || m_city_id != value)
                {
                    this.m_city_id = value;
                }
                city_id_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Show_name
        {
            get { return this.m_show_name; }
            set //
            {
                if (!show_name_initialized || m_show_name != value)
                {
                    this.m_show_name = value;
                }
                show_name_initialized = true;
            }
        }
        
        /// <summary> ѧУid:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int School_id
        {
            get { return this.m_school_id; }
            set //
            {
                if (!school_id_initialized || m_school_id != value)
                {
                    this.m_school_id = value;
                }
                school_id_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Department_id
        {
            get { return this.m_department_id; }
            set //
            {
                if (!department_id_initialized || m_department_id != value)
                {
                    this.m_department_id = value;
                }
                department_id_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Latitude
        {
            get { return this.m_latitude; }
            set //
            {
                if (!latitude_initialized || m_latitude != value)
                {
                    this.m_latitude = value;
                }
                latitude_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Longitude
        {
            get { return this.m_longitude; }
            set //
            {
                if (!longitude_initialized || m_longitude != value)
                {
                    this.m_longitude = value;
                }
                longitude_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string School_name
        {
            get { return this.m_school_name; }
            set //
            {
                if (!school_name_initialized || m_school_name != value)
                {
                    this.m_school_name = value;
                }
                school_name_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Department_name
        {
            get { return this.m_department_name; }
            set //
            {
                if (!department_name_initialized || m_department_name != value)
                {
                    this.m_department_name = value;
                }
                department_name_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Email
        {
            get { return this.m_email; }
            set //
            {
                if (!email_initialized || m_email != value)
                {
                    this.m_email = value;
                }
                email_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string User_type
        {
            get { return this.m_user_type; }
            set //
            {
                if (!user_type_initialized || m_user_type != value)
                {
                    this.m_user_type = value;
                }
                user_type_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Ref_id
        {
            get { return this.m_ref_id; }
            set //
            {
                if (!ref_id_initialized || m_ref_id != value)
                {
                    this.m_ref_id = value;
                }
                ref_id_initialized = true;
            }
        }
        
        /// <summary> ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sc_id
        {
            get { return this.m_sc_id; }
            set //
            {
                if (!sc_id_initialized || m_sc_id != value)
                {
                    this.m_sc_id = value;
                }
                sc_id_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string School_name2
        {
            get { return this.m_school_name2; }
            set //
            {
                if (!school_name2_initialized || m_school_name2 != value)
                {
                    this.m_school_name2 = value;
                }
                school_name2_initialized = true;
            }
        }
        
        /// <summary> ���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Department_name2
        {
            get { return this.m_department_name2; }
            set //
            {
                if (!department_name2_initialized || m_department_name2 != value)
                {
                    this.m_department_name2 = value;
                }
                department_name2_initialized = true;
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
            public static AttributeItem ID =  new AttributeItem("[VUserInfo].[ID]", typeof(int), 4, default(int));
            
            /// <summary>�û����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[VUserInfo].[User_id]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Nick_name =  new AttributeItem("[VUserInfo].[Nick_name]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Headimgurl =  new AttributeItem("[VUserInfo].[Headimgurl]", typeof(string), 200, default(string));
            
            /// <summary>�ֻ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Phone_number =  new AttributeItem("[VUserInfo].[Phone_number]", typeof(string), 20, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PassWord =  new AttributeItem("[VUserInfo].[PassWord]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Real_name =  new AttributeItem("[VUserInfo].[Real_name]", typeof(string), 10, default(string));
            
            /// <summary>�û���ʵ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_name =  new AttributeItem("[VUserInfo].[User_name]", typeof(string), 20, default(string));
            
            /// <summary>�豸Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem DeviceId =  new AttributeItem("[VUserInfo].[DeviceId]", typeof(string), 50, default(string));
            
            /// <summary>�û����Ա�ֵΪ1ʱ�����ԣ�ֵΪ2ʱ��Ů�ԣ�ֵΪ0ʱ��δ֪:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Gender =  new AttributeItem("[VUserInfo].[Gender]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City =  new AttributeItem("[VUserInfo].[City]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Province =  new AttributeItem("[VUserInfo].[Province]", typeof(string), 200, default(string));
            
            /// <summary></summary>
            public static AttributeItem Qq =  new AttributeItem("[VUserInfo].[Qq]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Change =  new AttributeItem("[VUserInfo].[Change]", typeof(decimal), 18, default(decimal));
            
            /// <summary></summary>
            public static AttributeItem Wechat_app_openid =  new AttributeItem("[VUserInfo].[Wechat_app_openid]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Token =  new AttributeItem("[VUserInfo].[Token]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Point =  new AttributeItem("[VUserInfo].[Point]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Wechat_openid =  new AttributeItem("[VUserInfo].[Wechat_openid]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Weibo =  new AttributeItem("[VUserInfo].[Weibo]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Province_id =  new AttributeItem("[VUserInfo].[Province_id]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem City_id =  new AttributeItem("[VUserInfo].[City_id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Show_name =  new AttributeItem("[VUserInfo].[Show_name]", typeof(string), 50, default(string));
            
            /// <summary>ѧУid:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_id =  new AttributeItem("[VUserInfo].[School_id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Department_id =  new AttributeItem("[VUserInfo].[Department_id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Latitude =  new AttributeItem("[VUserInfo].[Latitude]", typeof(decimal), 18, default(decimal));
            
            /// <summary></summary>
            public static AttributeItem Longitude =  new AttributeItem("[VUserInfo].[Longitude]", typeof(decimal), 18, default(decimal));
            
            /// <summary></summary>
            public static AttributeItem School_name =  new AttributeItem("[VUserInfo].[School_name]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Department_name =  new AttributeItem("[VUserInfo].[Department_name]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Grade =  new AttributeItem("[VUserInfo].[Grade]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Email =  new AttributeItem("[VUserInfo].[Email]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem User_type =  new AttributeItem("[VUserInfo].[User_type]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Ref_id =  new AttributeItem("[VUserInfo].[Ref_id]", typeof(string), 36, default(string));
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc_id =  new AttributeItem("[VUserInfo].[Sc_id]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem School_name2 =  new AttributeItem("[VUserInfo].[School_name2]", typeof(string), 100, default(string));
            
            /// <summary></summary>
            public static AttributeItem Department_name2 =  new AttributeItem("[VUserInfo].[Department_name2]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_nick_name;
        /// <summary></summary>
        protected bool nick_name_initialized = false;
        
        private string m_headimgurl;
        /// <summary></summary>
        protected bool headimgurl_initialized = false;
        
        private string m_phone_number;
        /// <summary></summary>
        protected bool phone_number_initialized = false;
        
        private string m_password;
        /// <summary></summary>
        protected bool password_initialized = false;
        
        private string m_real_name;
        /// <summary></summary>
        protected bool real_name_initialized = false;
        
        private string m_user_name;
        /// <summary></summary>
        protected bool user_name_initialized = false;
        
        private string m_deviceid;
        /// <summary></summary>
        protected bool deviceid_initialized = false;
        
        private string m_gender;
        /// <summary></summary>
        protected bool gender_initialized = false;
        
        private string m_city;
        /// <summary></summary>
        protected bool city_initialized = false;
        
        private string m_province;
        /// <summary></summary>
        protected bool province_initialized = false;
        
        private string m_qq;
        /// <summary></summary>
        protected bool qq_initialized = false;
        
        private decimal m_change;
        /// <summary></summary>
        protected bool change_initialized = false;
        
        private string m_wechat_app_openid;
        /// <summary></summary>
        protected bool wechat_app_openid_initialized = false;
        
        private string m_token;
        /// <summary></summary>
        protected bool token_initialized = false;
        
        private string m_point;
        /// <summary></summary>
        protected bool point_initialized = false;
        
        private string m_wechat_openid;
        /// <summary></summary>
        protected bool wechat_openid_initialized = false;
        
        private string m_weibo;
        /// <summary></summary>
        protected bool weibo_initialized = false;
        
        private string m_province_id;
        /// <summary></summary>
        protected bool province_id_initialized = false;
        
        private int m_city_id;
        /// <summary></summary>
        protected bool city_id_initialized = false;
        
        private string m_show_name;
        /// <summary></summary>
        protected bool show_name_initialized = false;
        
        private int m_school_id;
        /// <summary></summary>
        protected bool school_id_initialized = false;
        
        private int m_department_id;
        /// <summary></summary>
        protected bool department_id_initialized = false;
        
        private decimal m_latitude;
        /// <summary></summary>
        protected bool latitude_initialized = false;
        
        private decimal m_longitude;
        /// <summary></summary>
        protected bool longitude_initialized = false;
        
        private string m_school_name;
        /// <summary></summary>
        protected bool school_name_initialized = false;
        
        private string m_department_name;
        /// <summary></summary>
        protected bool department_name_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private string m_email;
        /// <summary></summary>
        protected bool email_initialized = false;
        
        private string m_user_type;
        /// <summary></summary>
        protected bool user_type_initialized = false;
        
        private string m_ref_id;
        /// <summary></summary>
        protected bool ref_id_initialized = false;
        
        private string m_sc_id;
        /// <summary></summary>
        protected bool sc_id_initialized = false;
        
        private string m_school_name2;
        /// <summary></summary>
        protected bool school_name2_initialized = false;
        
        private string m_department_name2;
        /// <summary></summary>
        protected bool department_name2_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "VUserInfo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.nick_name_initialized = IsLoadAllAttributes;this.headimgurl_initialized = IsLoadAllAttributes;this.phone_number_initialized = IsLoadAllAttributes;this.password_initialized = IsLoadAllAttributes;this.real_name_initialized = IsLoadAllAttributes;this.user_name_initialized = IsLoadAllAttributes;this.deviceid_initialized = IsLoadAllAttributes;this.gender_initialized = IsLoadAllAttributes;this.city_initialized = IsLoadAllAttributes;this.province_initialized = IsLoadAllAttributes;this.qq_initialized = IsLoadAllAttributes;this.change_initialized = IsLoadAllAttributes;this.wechat_app_openid_initialized = IsLoadAllAttributes;this.token_initialized = IsLoadAllAttributes;this.point_initialized = IsLoadAllAttributes;this.wechat_openid_initialized = IsLoadAllAttributes;this.weibo_initialized = IsLoadAllAttributes;this.province_id_initialized = IsLoadAllAttributes;this.city_id_initialized = IsLoadAllAttributes;this.show_name_initialized = IsLoadAllAttributes;this.school_id_initialized = IsLoadAllAttributes;this.department_id_initialized = IsLoadAllAttributes;this.latitude_initialized = IsLoadAllAttributes;this.longitude_initialized = IsLoadAllAttributes;this.school_name_initialized = IsLoadAllAttributes;this.department_name_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.email_initialized = IsLoadAllAttributes;this.user_type_initialized = IsLoadAllAttributes;this.ref_id_initialized = IsLoadAllAttributes;this.sc_id_initialized = IsLoadAllAttributes;this.school_name2_initialized = IsLoadAllAttributes;this.department_name2_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			VUserInfo value = new VUserInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"ID"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Nick_name"))
				value.nick_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Headimgurl"))
				value.headimgurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Phone_number"))
				value.phone_number_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PassWord"))
				value.password_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Real_name"))
				value.real_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_name"))
				value.user_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"DeviceId"))
				value.deviceid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Gender"))
				value.gender_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City"))
				value.city_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province"))
				value.province_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Qq"))
				value.qq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Change"))
				value.change_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wechat_app_openid"))
				value.wechat_app_openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Token"))
				value.token_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Point"))
				value.point_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Wechat_openid"))
				value.wechat_openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Weibo"))
				value.weibo_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Province_id"))
				value.province_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_id"))
				value.city_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Show_name"))
				value.show_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_id"))
				value.school_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Department_id"))
				value.department_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Latitude"))
				value.latitude_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Longitude"))
				value.longitude_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_name"))
				value.school_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Department_name"))
				value.department_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Email"))
				value.email_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_type"))
				value.user_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Ref_id"))
				value.ref_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc_id"))
				value.sc_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_name2"))
				value.school_name2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Department_name2"))
				value.department_name2_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new VUserInfo Clone()
        {
            return (VUserInfo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static VUserInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public VUserInfo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public VUserInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public VUserInfo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public VUserInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public VUserInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public VUserInfo(int id1, Guid user_id1, string nick_name1, string headimgurl1, string phone_number1, string password1, string real_name1, string user_name1, string deviceid1, string gender1, string city1, string province1, string qq1, decimal change1, string wechat_app_openid1, string token1, string point1, string wechat_openid1, string weibo1, string province_id1, int city_id1, string show_name1, int school_id1, int department_id1, decimal latitude1, decimal longitude1, string school_name1, string department_name1, int grade1, string email1, string user_type1, string ref_id1, string sc_id1, string school_name21, string department_name21)
        {
            
            this.ID = id1;
            
            this.User_id = user_id1;
            
            this.Nick_name = nick_name1;
            
            this.Headimgurl = headimgurl1;
            
            this.Phone_number = phone_number1;
            
            this.PassWord = password1;
            
            this.Real_name = real_name1;
            
            this.User_name = user_name1;
            
            this.DeviceId = deviceid1;
            
            this.Gender = gender1;
            
            this.City = city1;
            
            this.Province = province1;
            
            this.Qq = qq1;
            
            this.Change = change1;
            
            this.Wechat_app_openid = wechat_app_openid1;
            
            this.Token = token1;
            
            this.Point = point1;
            
            this.Wechat_openid = wechat_openid1;
            
            this.Weibo = weibo1;
            
            this.Province_id = province_id1;
            
            this.City_id = city_id1;
            
            this.Show_name = show_name1;
            
            this.School_id = school_id1;
            
            this.Department_id = department_id1;
            
            this.Latitude = latitude1;
            
            this.Longitude = longitude1;
            
            this.School_name = school_name1;
            
            this.Department_name = department_name1;
            
            this.Grade = grade1;
            
            this.Email = email1;
            
            this.User_type = user_type1;
            
            this.Ref_id = ref_id1;
            
            this.Sc_id = sc_id1;
            
            this.School_name2 = school_name21;
            
            this.Department_name2 = department_name21;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static VUserInfo FromIView(IView view)
        {
            return (VUserInfo)IView.GetITable(view, "VUserInfo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static VUserInfo GetOneInstance()
        {
            VUserInfo value = new VUserInfo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public VUserInfo Retrieve()
        {
            BLLTable<VUserInfo>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "ID":
			        return ID;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Nick_name":
			        return Nick_name;
			    			
			    case "Headimgurl":
			        return Headimgurl;
			    			
			    case "Phone_number":
			        return Phone_number;
			    			
			    case "PassWord":
			        return PassWord;
			    			
			    case "Real_name":
			        return Real_name;
			    			
			    case "User_name":
			        return User_name;
			    			
			    case "DeviceId":
			        return DeviceId;
			    			
			    case "Gender":
			        return Gender;
			    			
			    case "City":
			        return City;
			    			
			    case "Province":
			        return Province;
			    			
			    case "Qq":
			        return Qq;
			    			
			    case "Change":
			        return Change;
			    			
			    case "Wechat_app_openid":
			        return Wechat_app_openid;
			    			
			    case "Token":
			        return Token;
			    			
			    case "Point":
			        return Point;
			    			
			    case "Wechat_openid":
			        return Wechat_openid;
			    			
			    case "Weibo":
			        return Weibo;
			    			
			    case "Province_id":
			        return Province_id;
			    			
			    case "City_id":
			        return City_id;
			    			
			    case "Show_name":
			        return Show_name;
			    			
			    case "School_id":
			        return School_id;
			    			
			    case "Department_id":
			        return Department_id;
			    			
			    case "Latitude":
			        return Latitude;
			    			
			    case "Longitude":
			        return Longitude;
			    			
			    case "School_name":
			        return School_name;
			    			
			    case "Department_name":
			        return Department_name;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Email":
			        return Email;
			    			
			    case "User_type":
			        return User_type;
			    			
			    case "Ref_id":
			        return Ref_id;
			    			
			    case "Sc_id":
			        return Sc_id;
			    			
			    case "School_name2":
			        return School_name2;
			    			
			    case "Department_name2":
			        return Department_name2;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "ID":
			        this.ID = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Nick_name":
			        this.Nick_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Headimgurl":
			        this.Headimgurl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Phone_number":
			        this.Phone_number = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PassWord":
			        this.PassWord = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Real_name":
			        this.Real_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_name":
			        this.User_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "DeviceId":
			        this.DeviceId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Gender":
			        this.Gender = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City":
			        this.City = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Province":
			        this.Province = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Qq":
			        this.Qq = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Change":
			        this.Change = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Wechat_app_openid":
			        this.Wechat_app_openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Token":
			        this.Token = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Point":
			        this.Point = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Wechat_openid":
			        this.Wechat_openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Weibo":
			        this.Weibo = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Province_id":
			        this.Province_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "City_id":
			        this.City_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Show_name":
			        this.Show_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "School_id":
			        this.School_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Department_id":
			        this.Department_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Latitude":
			        this.Latitude = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Longitude":
			        this.Longitude = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "School_name":
			        this.School_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Department_name":
			        this.Department_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Email":
			        this.Email = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_type":
			        this.User_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Ref_id":
			        this.Ref_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc_id":
			        this.Sc_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "School_name2":
			        this.School_name2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Department_name2":
			        this.Department_name2 = Convert.ToString(AttributeValue);
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
				case "ID":
					return id_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Nick_name":
					return nick_name_initialized;
				
				case "Headimgurl":
					return headimgurl_initialized;
				
				case "Phone_number":
					return phone_number_initialized;
				
				case "PassWord":
					return password_initialized;
				
				case "Real_name":
					return real_name_initialized;
				
				case "User_name":
					return user_name_initialized;
				
				case "DeviceId":
					return deviceid_initialized;
				
				case "Gender":
					return gender_initialized;
				
				case "City":
					return city_initialized;
				
				case "Province":
					return province_initialized;
				
				case "Qq":
					return qq_initialized;
				
				case "Change":
					return change_initialized;
				
				case "Wechat_app_openid":
					return wechat_app_openid_initialized;
				
				case "Token":
					return token_initialized;
				
				case "Point":
					return point_initialized;
				
				case "Wechat_openid":
					return wechat_openid_initialized;
				
				case "Weibo":
					return weibo_initialized;
				
				case "Province_id":
					return province_id_initialized;
				
				case "City_id":
					return city_id_initialized;
				
				case "Show_name":
					return show_name_initialized;
				
				case "School_id":
					return school_id_initialized;
				
				case "Department_id":
					return department_id_initialized;
				
				case "Latitude":
					return latitude_initialized;
				
				case "Longitude":
					return longitude_initialized;
				
				case "School_name":
					return school_name_initialized;
				
				case "Department_name":
					return department_name_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Email":
					return email_initialized;
				
				case "User_type":
					return user_type_initialized;
				
				case "Ref_id":
					return ref_id_initialized;
				
				case "Sc_id":
					return sc_id_initialized;
				
				case "School_name2":
					return school_name2_initialized;
				
				case "Department_name2":
					return department_name2_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "ID":
					id_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Nick_name":
					nick_name_initialized = ret;
					return true;
				
				case "Headimgurl":
					headimgurl_initialized = ret;
					return true;
				
				case "Phone_number":
					phone_number_initialized = ret;
					return true;
				
				case "PassWord":
					password_initialized = ret;
					return true;
				
				case "Real_name":
					real_name_initialized = ret;
					return true;
				
				case "User_name":
					user_name_initialized = ret;
					return true;
				
				case "DeviceId":
					deviceid_initialized = ret;
					return true;
				
				case "Gender":
					gender_initialized = ret;
					return true;
				
				case "City":
					city_initialized = ret;
					return true;
				
				case "Province":
					province_initialized = ret;
					return true;
				
				case "Qq":
					qq_initialized = ret;
					return true;
				
				case "Change":
					change_initialized = ret;
					return true;
				
				case "Wechat_app_openid":
					wechat_app_openid_initialized = ret;
					return true;
				
				case "Token":
					token_initialized = ret;
					return true;
				
				case "Point":
					point_initialized = ret;
					return true;
				
				case "Wechat_openid":
					wechat_openid_initialized = ret;
					return true;
				
				case "Weibo":
					weibo_initialized = ret;
					return true;
				
				case "Province_id":
					province_id_initialized = ret;
					return true;
				
				case "City_id":
					city_id_initialized = ret;
					return true;
				
				case "Show_name":
					show_name_initialized = ret;
					return true;
				
				case "School_id":
					school_id_initialized = ret;
					return true;
				
				case "Department_id":
					department_id_initialized = ret;
					return true;
				
				case "Latitude":
					latitude_initialized = ret;
					return true;
				
				case "Longitude":
					longitude_initialized = ret;
					return true;
				
				case "School_name":
					school_name_initialized = ret;
					return true;
				
				case "Department_name":
					department_name_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Email":
					email_initialized = ret;
					return true;
				
				case "User_type":
					user_type_initialized = ret;
					return true;
				
				case "Ref_id":
					ref_id_initialized = ret;
					return true;
				
				case "Sc_id":
					sc_id_initialized = ret;
					return true;
				
				case "School_name2":
					school_name2_initialized = ret;
					return true;
				
				case "Department_name2":
					department_name2_initialized = ret;
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
                AttributeItem attr = VUserInfo.Attribute.ID;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ID);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (nick_name_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Nick_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Nick_name);
                }
			}
			
			if (headimgurl_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Headimgurl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Headimgurl);
                }
			}
			
			if (phone_number_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Phone_number;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Phone_number);
                }
			}
			
			if (password_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.PassWord;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PassWord);
                }
			}
			
			if (real_name_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Real_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Real_name);
                }
			}
			
			if (user_name_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.User_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_name);
                }
			}
			
			if (deviceid_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.DeviceId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(DeviceId);
                }
			}
			
			if (gender_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Gender;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Gender);
                }
			}
			
			if (city_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.City;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City);
                }
			}
			
			if (province_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Province;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province);
                }
			}
			
			if (qq_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Qq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Qq);
                }
			}
			
			if (change_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Change;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Change);
                }
			}
			
			if (wechat_app_openid_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Wechat_app_openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wechat_app_openid);
                }
			}
			
			if (token_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Token;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Token);
                }
			}
			
			if (point_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Point;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Point);
                }
			}
			
			if (wechat_openid_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Wechat_openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Wechat_openid);
                }
			}
			
			if (weibo_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Weibo;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Weibo);
                }
			}
			
			if (province_id_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Province_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Province_id);
                }
			}
			
			if (city_id_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.City_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_id);
                }
			}
			
			if (show_name_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Show_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Show_name);
                }
			}
			
			if (school_id_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.School_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_id);
                }
			}
			
			if (department_id_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Department_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Department_id);
                }
			}
			
			if (latitude_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Latitude;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Latitude);
                }
			}
			
			if (longitude_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Longitude;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Longitude);
                }
			}
			
			if (school_name_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.School_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_name);
                }
			}
			
			if (department_name_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Department_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Department_name);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (email_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Email;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Email);
                }
			}
			
			if (user_type_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.User_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_type);
                }
			}
			
			if (ref_id_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Ref_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Ref_id);
                }
			}
			
			if (sc_id_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Sc_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc_id);
                }
			}
			
			if (school_name2_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.School_name2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_name2);
                }
			}
			
			if (department_name2_initialized)
			{
                AttributeItem attr = VUserInfo.Attribute.Department_name2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Department_name2);
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
        public class VUserInfoJson
        {
            
            /// <summary></summary>
            public int ID { get; set; }
            
            /// <summary>�û����:[CtrlTypeDic-{InputString}]</summary>
            public Guid User_id { get; set; }
            
            /// <summary></summary>
            public string Nick_name { get; set; }
            
            /// <summary></summary>
            public string Headimgurl { get; set; }
            
            /// <summary>�ֻ���:[CtrlTypeDic-{InputString}]</summary>
            public string Phone_number { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string PassWord { get; set; }
            
            /// <summary></summary>
            public string Real_name { get; set; }
            
            /// <summary>�û���ʵ����:[CtrlTypeDic-{InputString}]</summary>
            public string User_name { get; set; }
            
            /// <summary>�豸Id:[CtrlTypeDic-{InputString}]</summary>
            public string DeviceId { get; set; }
            
            /// <summary>�û����Ա�ֵΪ1ʱ�����ԣ�ֵΪ2ʱ��Ů�ԣ�ֵΪ0ʱ��δ֪:[CtrlTypeDic-{InputString}]</summary>
            public string Gender { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string City { get; set; }
            
            /// <summary></summary>
            public string Province { get; set; }
            
            /// <summary></summary>
            public string Qq { get; set; }
            
            /// <summary></summary>
            public decimal Change { get; set; }
            
            /// <summary></summary>
            public string Wechat_app_openid { get; set; }
            
            /// <summary></summary>
            public string Token { get; set; }
            
            /// <summary></summary>
            public string Point { get; set; }
            
            /// <summary></summary>
            public string Wechat_openid { get; set; }
            
            /// <summary></summary>
            public string Weibo { get; set; }
            
            /// <summary></summary>
            public string Province_id { get; set; }
            
            /// <summary></summary>
            public int City_id { get; set; }
            
            /// <summary></summary>
            public string Show_name { get; set; }
            
            /// <summary>ѧУid:[CtrlTypeDic-{InputString}]</summary>
            public int School_id { get; set; }
            
            /// <summary></summary>
            public int Department_id { get; set; }
            
            /// <summary></summary>
            public decimal Latitude { get; set; }
            
            /// <summary></summary>
            public decimal Longitude { get; set; }
            
            /// <summary></summary>
            public string School_name { get; set; }
            
            /// <summary></summary>
            public string Department_name { get; set; }
            
            /// <summary></summary>
            public int Grade { get; set; }
            
            /// <summary></summary>
            public string Email { get; set; }
            
            /// <summary></summary>
            public string User_type { get; set; }
            
            /// <summary></summary>
            public string Ref_id { get; set; }
            
            /// <summary>���:[CtrlTypeDic-{InputString}]</summary>
            public string Sc_id { get; set; }
            
            /// <summary></summary>
            public string School_name2 { get; set; }
            
            /// <summary></summary>
            public string Department_name2 { get; set; }
        }
        #endregion
    }
}
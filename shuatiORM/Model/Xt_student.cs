/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:32
  Description:    ���ݱ�Xt_student��Ӧ��ҵ���߼���Xt_student
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_student_Entity:Xt_student
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Create_time,Id,Name,Email,Mobile,Last_login_type,Last_login_time,Modify_time,Sex,Major,College_id,Weixin_id,Real_name,Address,Head,Active,College_name,User_id,Del_tag from Xt_student
delete from Xt_student
INSERT INTO Xt_student (Uuid,Create_time,Id,Name,Email,Mobile,Last_login_type,Last_login_time,Modify_time,Sex,Major,College_id,Weixin_id,Real_name,Address,Head,Active,College_name,User_id,Del_tag)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','')
UPDATE Xt_student SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Create_time = valObj2.Create_time;
        valObj.Id = valObj2.Id;
        valObj.Name = valObj2.Name;
        valObj.Email = valObj2.Email;
        valObj.Mobile = valObj2.Mobile;
        valObj.Last_login_type = valObj2.Last_login_type;
        valObj.Last_login_time = valObj2.Last_login_time;
        valObj.Modify_time = valObj2.Modify_time;
        valObj.Sex = valObj2.Sex;
        valObj.Major = valObj2.Major;
        valObj.College_id = valObj2.College_id;
        valObj.Weixin_id = valObj2.Weixin_id;
        valObj.Real_name = valObj2.Real_name;
        valObj.Address = valObj2.Address;
        valObj.Head = valObj2.Head;
        valObj.Active = valObj2.Active;
        valObj.College_name = valObj2.College_name;
        valObj.User_id = valObj2.User_id;
        valObj.Del_tag = valObj2.Del_tag; 
        valObj.Uuid = "";
        valObj.Create_time = "";
        valObj.Id = "";
        valObj.Name = "";
        valObj.Email = "";
        valObj.Mobile = "";
        valObj.Last_login_type = "";
        valObj.Last_login_time = "";
        valObj.Modify_time = "";
        valObj.Sex = "";
        valObj.Major = "";
        valObj.College_id = "";
        valObj.Weixin_id = "";
        valObj.Real_name = "";
        valObj.Address = "";
        valObj.Head = "";
        valObj.Active = "";
        valObj.College_name = "";
        valObj.User_id = "";
        valObj.Del_tag = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Id": $("#txt_Id").val(),
        "Name": $("#txt_Name").val(),
        "Email": $("#txt_Email").val(),
        "Mobile": $("#txt_Mobile").val(),
        "Last_login_type": $("#txt_Last_login_type").val(),
        "Last_login_time": $("#txt_Last_login_time").val(),
        "Modify_time": $("#txt_Modify_time").val(),
        "Sex": $("#txt_Sex").val(),
        "Major": $("#txt_Major").val(),
        "College_id": $("#txt_College_id").val(),
        "Weixin_id": $("#txt_Weixin_id").val(),
        "Real_name": $("#txt_Real_name").val(),
        "Address": $("#txt_Address").val(),
        "Head": $("#txt_Head").val(),
        "Active": $("#txt_Active").val(),
        "College_name": $("#txt_College_name").val(),
        "User_id": $("#txt_User_id").val(),
        "Del_tag": $("#txt_Del_tag").val(), 
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
    /// <para>ѧ���û���Ϣ��</para>
    /// <para>��Xt_student���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_student : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_student Factory()
        {
            return new Xt_student();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �ǳ�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Email
        {            
            get { return this.Email; }
            set { this.Email = value; }
        }
        
        /// <summary> �ֻ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Mobile
        {            
            get { return this.Mobile; }
            set { this.Mobile = value; }
        }
        
        /// <summary> ����¼����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Last_login_type
        {            
            get { return this.Last_login_type; }
            set { this.Last_login_type = value; }
        }
        
        /// <summary> ����¼ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Last_login_time
        {            
            get { return this.Last_login_time; }
            set { this.Last_login_time = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _Modify_time
        {            
            get { return this.Modify_time; }
            set { this.Modify_time = value; }
        }
        
        /// <summary> �Ա�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sex
        {            
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        
        /// <summary> רҵ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Major
        {            
            get { return this.Major; }
            set { this.Major = value; }
        }
        
        /// <summary> ��ѧid:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _College_id
        {            
            get { return this.College_id; }
            set { this.College_id = value; }
        }
        
        /// <summary> ΢��id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Weixin_id
        {            
            get { return this.Weixin_id; }
            set { this.Weixin_id = value; }
        }
        
        /// <summary> ��ʵ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Real_name
        {            
            get { return this.Real_name; }
            set { this.Real_name = value; }
        }
        
        /// <summary> ��ַ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Address
        {            
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        /// <summary> ͷ��·��:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Head
        {            
            get { return this.Head; }
            set { this.Head = value; }
        }
        
        /// <summary> ��Ծ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Active
        {            
            get { return this.Active; }
            set { this.Active = value; }
        }
        
        /// <summary> ��ѧ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _College_name
        {            
            get { return this.College_name; }
            set { this.College_name = value; }
        }
        
        /// <summary> �û�id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> ɾ����ǩ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Del_tag
        {            
            get { return this.Del_tag; }
            set { this.Del_tag = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
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
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Id
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
        
        /// <summary> �ǳ�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �ֻ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Mobile
        {
            get { return this.m_mobile; }
            set //
            {
                if (!mobile_initialized || m_mobile != value)
                {
                    this.m_mobile = value;
                }
                mobile_initialized = true;
            }
        }
        
        /// <summary> ����¼����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Last_login_type
        {
            get { return this.m_last_login_type; }
            set //
            {
                if (!last_login_type_initialized || m_last_login_type != value)
                {
                    this.m_last_login_type = value;
                }
                last_login_type_initialized = true;
            }
        }
        
        /// <summary> ����¼ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Last_login_time
        {
            get { return this.m_last_login_time; }
            set //
            {
                if (!last_login_time_initialized || m_last_login_time != value)
                {
                    this.m_last_login_time = value;
                }
                last_login_time_initialized = true;
            }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �Ա�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sex
        {
            get { return this.m_sex; }
            set //
            {
                if (!sex_initialized || m_sex != value)
                {
                    this.m_sex = value;
                }
                sex_initialized = true;
            }
        }
        
        /// <summary> רҵ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Major
        {
            get { return this.m_major; }
            set //
            {
                if (!major_initialized || m_major != value)
                {
                    this.m_major = value;
                }
                major_initialized = true;
            }
        }
        
        /// <summary> ��ѧid:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string College_id
        {
            get { return this.m_college_id; }
            set //
            {
                if (!college_id_initialized || m_college_id != value)
                {
                    this.m_college_id = value;
                }
                college_id_initialized = true;
            }
        }
        
        /// <summary> ΢��id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Weixin_id
        {
            get { return this.m_weixin_id; }
            set //
            {
                if (!weixin_id_initialized || m_weixin_id != value)
                {
                    this.m_weixin_id = value;
                }
                weixin_id_initialized = true;
            }
        }
        
        /// <summary> ��ʵ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ַ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Address
        {
            get { return this.m_address; }
            set //
            {
                if (!address_initialized || m_address != value)
                {
                    this.m_address = value;
                }
                address_initialized = true;
            }
        }
        
        /// <summary> ͷ��·��:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Head
        {
            get { return this.m_head; }
            set //
            {
                if (!head_initialized || m_head != value)
                {
                    this.m_head = value;
                }
                head_initialized = true;
            }
        }
        
        /// <summary> ��Ծ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Active
        {
            get { return this.m_active; }
            set //
            {
                if (!active_initialized || m_active != value)
                {
                    this.m_active = value;
                }
                active_initialized = true;
            }
        }
        
        /// <summary> ��ѧ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string College_name
        {
            get { return this.m_college_name; }
            set //
            {
                if (!college_name_initialized || m_college_name != value)
                {
                    this.m_college_name = value;
                }
                college_name_initialized = true;
            }
        }
        
        /// <summary> �û�id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ɾ����ǩ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Del_tag
        {
            get { return this.m_del_tag; }
            set //
            {
                if (!del_tag_initialized || m_del_tag != value)
                {
                    this.m_del_tag = value;
                }
                del_tag_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_student].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xt_student].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xt_student].[Id]", typeof(decimal), 18, default(decimal));
            
            /// <summary>�ǳ�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xt_student].[Name]", typeof(string), 100, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Email =  new AttributeItem("[Xt_student].[Email]", typeof(string), 100, default(string));
            
            /// <summary>�ֻ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Mobile =  new AttributeItem("[Xt_student].[Mobile]", typeof(string), 15, default(string));
            
            /// <summary>����¼����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Last_login_type =  new AttributeItem("[Xt_student].[Last_login_type]", typeof(string), 1, default(string));
            
            /// <summary>����¼ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Last_login_time =  new AttributeItem("[Xt_student].[Last_login_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Modify_time =  new AttributeItem("[Xt_student].[Modify_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>�Ա�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sex =  new AttributeItem("[Xt_student].[Sex]", typeof(string), 1, default(string));
            
            /// <summary>רҵ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Major =  new AttributeItem("[Xt_student].[Major]", typeof(string), 100, default(string));
            
            /// <summary>��ѧid:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem College_id =  new AttributeItem("[Xt_student].[College_id]", typeof(string), 36, default(string));
            
            /// <summary>΢��id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Weixin_id =  new AttributeItem("[Xt_student].[Weixin_id]", typeof(string), 36, default(string));
            
            /// <summary>��ʵ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Real_name =  new AttributeItem("[Xt_student].[Real_name]", typeof(string), 100, default(string));
            
            /// <summary>��ַ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Address =  new AttributeItem("[Xt_student].[Address]", typeof(string), 100, default(string));
            
            /// <summary>ͷ��·��:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Head =  new AttributeItem("[Xt_student].[Head]", typeof(string), 1000, default(string));
            
            /// <summary>��Ծ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Active =  new AttributeItem("[Xt_student].[Active]", typeof(string), 100, default(string));
            
            /// <summary>��ѧ����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem College_name =  new AttributeItem("[Xt_student].[College_name]", typeof(string), 100, default(string));
            
            /// <summary>�û�id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xt_student].[User_id]", typeof(string), 36, default(string));
            
            /// <summary>ɾ����ǩ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Del_tag =  new AttributeItem("[Xt_student].[Del_tag]", typeof(string), 1, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private decimal m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private string m_email;
        /// <summary></summary>
        protected bool email_initialized = false;
        
        private string m_mobile;
        /// <summary></summary>
        protected bool mobile_initialized = false;
        
        private string m_last_login_type;
        /// <summary></summary>
        protected bool last_login_type_initialized = false;
        
        private DateTime m_last_login_time;
        /// <summary></summary>
        protected bool last_login_time_initialized = false;
        
        private DateTime m_modify_time;
        /// <summary></summary>
        protected bool modify_time_initialized = false;
        
        private string m_sex;
        /// <summary></summary>
        protected bool sex_initialized = false;
        
        private string m_major;
        /// <summary></summary>
        protected bool major_initialized = false;
        
        private string m_college_id;
        /// <summary></summary>
        protected bool college_id_initialized = false;
        
        private string m_weixin_id;
        /// <summary></summary>
        protected bool weixin_id_initialized = false;
        
        private string m_real_name;
        /// <summary></summary>
        protected bool real_name_initialized = false;
        
        private string m_address;
        /// <summary></summary>
        protected bool address_initialized = false;
        
        private string m_head;
        /// <summary></summary>
        protected bool head_initialized = false;
        
        private string m_active;
        /// <summary></summary>
        protected bool active_initialized = false;
        
        private string m_college_name;
        /// <summary></summary>
        protected bool college_name_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_del_tag;
        /// <summary></summary>
        protected bool del_tag_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_student";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.email_initialized = IsLoadAllAttributes;this.mobile_initialized = IsLoadAllAttributes;this.last_login_type_initialized = IsLoadAllAttributes;this.last_login_time_initialized = IsLoadAllAttributes;this.modify_time_initialized = IsLoadAllAttributes;this.sex_initialized = IsLoadAllAttributes;this.major_initialized = IsLoadAllAttributes;this.college_id_initialized = IsLoadAllAttributes;this.weixin_id_initialized = IsLoadAllAttributes;this.real_name_initialized = IsLoadAllAttributes;this.address_initialized = IsLoadAllAttributes;this.head_initialized = IsLoadAllAttributes;this.active_initialized = IsLoadAllAttributes;this.college_name_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.del_tag_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_student value = new Xt_student();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Email"))
				value.email_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Mobile"))
				value.mobile_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Last_login_type"))
				value.last_login_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Last_login_time"))
				value.last_login_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Modify_time"))
				value.modify_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sex"))
				value.sex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Major"))
				value.major_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College_id"))
				value.college_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Weixin_id"))
				value.weixin_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Real_name"))
				value.real_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Address"))
				value.address_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Head"))
				value.head_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Active"))
				value.active_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"College_name"))
				value.college_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Del_tag"))
				value.del_tag_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_student Clone()
        {
            return (Xt_student)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_student()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_student() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_student(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_student(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_student(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_student(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_student(Guid uuid1, DateTime create_time1, decimal id1, string name1, string email1, string mobile1, string last_login_type1, DateTime last_login_time1, DateTime modify_time1, string sex1, string major1, string college_id1, string weixin_id1, string real_name1, string address1, string head1, string active1, string college_name1, string user_id1, string del_tag1)
        {
            
            this.Uuid = uuid1;
            
            this.Create_time = create_time1;
            
            this.Id = id1;
            
            this.Name = name1;
            
            this.Email = email1;
            
            this.Mobile = mobile1;
            
            this.Last_login_type = last_login_type1;
            
            this.Last_login_time = last_login_time1;
            
            this.Modify_time = modify_time1;
            
            this.Sex = sex1;
            
            this.Major = major1;
            
            this.College_id = college_id1;
            
            this.Weixin_id = weixin_id1;
            
            this.Real_name = real_name1;
            
            this.Address = address1;
            
            this.Head = head1;
            
            this.Active = active1;
            
            this.College_name = college_name1;
            
            this.User_id = user_id1;
            
            this.Del_tag = del_tag1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_student FromIView(IView view)
        {
            return (Xt_student)IView.GetITable(view, "Xt_student");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_student GetOneInstance()
        {
            Xt_student value = new Xt_student();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_student Retrieve()
        {
            BLLTable<Xt_student>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        return Uuid;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Email":
			        return Email;
			    			
			    case "Mobile":
			        return Mobile;
			    			
			    case "Last_login_type":
			        return Last_login_type;
			    			
			    case "Last_login_time":
			        return Last_login_time;
			    			
			    case "Modify_time":
			        return Modify_time;
			    			
			    case "Sex":
			        return Sex;
			    			
			    case "Major":
			        return Major;
			    			
			    case "College_id":
			        return College_id;
			    			
			    case "Weixin_id":
			        return Weixin_id;
			    			
			    case "Real_name":
			        return Real_name;
			    			
			    case "Address":
			        return Address;
			    			
			    case "Head":
			        return Head;
			    			
			    case "Active":
			        return Active;
			    			
			    case "College_name":
			        return College_name;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Del_tag":
			        return Del_tag;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Email":
			        this.Email = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Mobile":
			        this.Mobile = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Last_login_type":
			        this.Last_login_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Last_login_time":
			        this.Last_login_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Modify_time":
			        this.Modify_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Sex":
			        this.Sex = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Major":
			        this.Major = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "College_id":
			        this.College_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Weixin_id":
			        this.Weixin_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Real_name":
			        this.Real_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Address":
			        this.Address = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Head":
			        this.Head = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Active":
			        this.Active = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "College_name":
			        this.College_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Del_tag":
			        this.Del_tag = Convert.ToString(AttributeValue);
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
				case "Uuid":
					return uuid_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Email":
					return email_initialized;
				
				case "Mobile":
					return mobile_initialized;
				
				case "Last_login_type":
					return last_login_type_initialized;
				
				case "Last_login_time":
					return last_login_time_initialized;
				
				case "Modify_time":
					return modify_time_initialized;
				
				case "Sex":
					return sex_initialized;
				
				case "Major":
					return major_initialized;
				
				case "College_id":
					return college_id_initialized;
				
				case "Weixin_id":
					return weixin_id_initialized;
				
				case "Real_name":
					return real_name_initialized;
				
				case "Address":
					return address_initialized;
				
				case "Head":
					return head_initialized;
				
				case "Active":
					return active_initialized;
				
				case "College_name":
					return college_name_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Del_tag":
					return del_tag_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Email":
					email_initialized = ret;
					return true;
				
				case "Mobile":
					mobile_initialized = ret;
					return true;
				
				case "Last_login_type":
					last_login_type_initialized = ret;
					return true;
				
				case "Last_login_time":
					last_login_time_initialized = ret;
					return true;
				
				case "Modify_time":
					modify_time_initialized = ret;
					return true;
				
				case "Sex":
					sex_initialized = ret;
					return true;
				
				case "Major":
					major_initialized = ret;
					return true;
				
				case "College_id":
					college_id_initialized = ret;
					return true;
				
				case "Weixin_id":
					weixin_id_initialized = ret;
					return true;
				
				case "Real_name":
					real_name_initialized = ret;
					return true;
				
				case "Address":
					address_initialized = ret;
					return true;
				
				case "Head":
					head_initialized = ret;
					return true;
				
				case "Active":
					active_initialized = ret;
					return true;
				
				case "College_name":
					college_name_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Del_tag":
					del_tag_initialized = ret;
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

			
			if (uuid_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (email_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Email;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Email);
                }
			}
			
			if (mobile_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Mobile;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Mobile);
                }
			}
			
			if (last_login_type_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Last_login_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Last_login_type);
                }
			}
			
			if (last_login_time_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Last_login_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Last_login_time);
                }
			}
			
			if (modify_time_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Modify_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Modify_time);
                }
			}
			
			if (sex_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Sex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sex);
                }
			}
			
			if (major_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Major;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Major);
                }
			}
			
			if (college_id_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.College_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College_id);
                }
			}
			
			if (weixin_id_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Weixin_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Weixin_id);
                }
			}
			
			if (real_name_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Real_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Real_name);
                }
			}
			
			if (address_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Address;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Address);
                }
			}
			
			if (head_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Head;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Head);
                }
			}
			
			if (active_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Active;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Active);
                }
			}
			
			if (college_name_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.College_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(College_name);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (del_tag_initialized)
			{
                AttributeItem attr = Xt_student.Attribute.Del_tag;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Del_tag);
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
        public class Xt_studentJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public decimal Id { get; set; }
            
            /// <summary>�ǳ�:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Email { get; set; }
            
            /// <summary>�ֻ���:[CtrlTypeDic-{InputString}]</summary>
            public string Mobile { get; set; }
            
            /// <summary>����¼����:[CtrlTypeDic-{InputString}]</summary>
            public string Last_login_type { get; set; }
            
            /// <summary>����¼ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Last_login_time { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Modify_time { get; set; }
            
            /// <summary>�Ա�:[CtrlTypeDic-{InputString}]</summary>
            public string Sex { get; set; }
            
            /// <summary>רҵ:[CtrlTypeDic-{InputString}]</summary>
            public string Major { get; set; }
            
            /// <summary>��ѧid:[CtrlTypeDic-{InputString}]</summary>
            public string College_id { get; set; }
            
            /// <summary>΢��id:[CtrlTypeDic-{InputString}]</summary>
            public string Weixin_id { get; set; }
            
            /// <summary>��ʵ����:[CtrlTypeDic-{InputString}]</summary>
            public string Real_name { get; set; }
            
            /// <summary>��ַ:[CtrlTypeDic-{InputString}]</summary>
            public string Address { get; set; }
            
            /// <summary>ͷ��·��:[CtrlTypeDic-{Text}]</summary>
            public string Head { get; set; }
            
            /// <summary>��Ծ:[CtrlTypeDic-{InputString}]</summary>
            public string Active { get; set; }
            
            /// <summary>��ѧ����:[CtrlTypeDic-{InputString}]</summary>
            public string College_name { get; set; }
            
            /// <summary>�û�id:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>ɾ����ǩ:[CtrlTypeDic-{InputString}]</summary>
            public string Del_tag { get; set; }
        }
        #endregion
    }
}
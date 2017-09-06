/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/9/1 19:04:54
  Description:    数据表Xb_job_user_dingyue对应的业务逻辑层Xb_job_user_dingyue
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_job_user_dingyue_Entity:Xb_job_user_dingyue
 * 
************************************************************/
/************************************************************
SQL代码：
select Appid,Dy_first,Dy_keyword1,Dy_keyword2,Dy_keyword3,Dy_keyword4,Dy_keyword5,Dy_keyword6,Dy_remark,Dy_time1,Dy_time2,Id,Is_send,Job_code,Msgid,Send_time,Url,User_id,Uuid,Xb_job_id from Xb_job_user_dingyue
delete from Xb_job_user_dingyue
INSERT INTO Xb_job_user_dingyue (Appid,Dy_first,Dy_keyword1,Dy_keyword2,Dy_keyword3,Dy_keyword4,Dy_keyword5,Dy_keyword6,Dy_remark,Dy_time1,Dy_time2,Id,Is_send,Job_code,Msgid,Send_time,Url,User_id,Uuid,Xb_job_id)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','')
UPDATE Xb_job_user_dingyue SET ...
变量赋值代码：
 *         valObj.Appid = valObj2.Appid;
        valObj.Dy_first = valObj2.Dy_first;
        valObj.Dy_keyword1 = valObj2.Dy_keyword1;
        valObj.Dy_keyword2 = valObj2.Dy_keyword2;
        valObj.Dy_keyword3 = valObj2.Dy_keyword3;
        valObj.Dy_keyword4 = valObj2.Dy_keyword4;
        valObj.Dy_keyword5 = valObj2.Dy_keyword5;
        valObj.Dy_keyword6 = valObj2.Dy_keyword6;
        valObj.Dy_remark = valObj2.Dy_remark;
        valObj.Dy_time1 = valObj2.Dy_time1;
        valObj.Dy_time2 = valObj2.Dy_time2;
        valObj.Id = valObj2.Id;
        valObj.Is_send = valObj2.Is_send;
        valObj.Job_code = valObj2.Job_code;
        valObj.Msgid = valObj2.Msgid;
        valObj.Send_time = valObj2.Send_time;
        valObj.Url = valObj2.Url;
        valObj.User_id = valObj2.User_id;
        valObj.Uuid = valObj2.Uuid;
        valObj.Xb_job_id = valObj2.Xb_job_id; 
        valObj.Appid = "";
        valObj.Dy_first = "";
        valObj.Dy_keyword1 = "";
        valObj.Dy_keyword2 = "";
        valObj.Dy_keyword3 = "";
        valObj.Dy_keyword4 = "";
        valObj.Dy_keyword5 = "";
        valObj.Dy_keyword6 = "";
        valObj.Dy_remark = "";
        valObj.Dy_time1 = "";
        valObj.Dy_time2 = "";
        valObj.Id = "";
        valObj.Is_send = "";
        valObj.Job_code = "";
        valObj.Msgid = "";
        valObj.Send_time = "";
        valObj.Url = "";
        valObj.User_id = "";
        valObj.Uuid = "";
        valObj.Xb_job_id = ""; 
        "Appid": $("#txt_Appid").val(),
        "Dy_first": $("#txt_Dy_first").val(),
        "Dy_keyword1": $("#txt_Dy_keyword1").val(),
        "Dy_keyword2": $("#txt_Dy_keyword2").val(),
        "Dy_keyword3": $("#txt_Dy_keyword3").val(),
        "Dy_keyword4": $("#txt_Dy_keyword4").val(),
        "Dy_keyword5": $("#txt_Dy_keyword5").val(),
        "Dy_keyword6": $("#txt_Dy_keyword6").val(),
        "Dy_remark": $("#txt_Dy_remark").val(),
        "Dy_time1": $("#txt_Dy_time1").val(),
        "Dy_time2": $("#txt_Dy_time2").val(),
        "Id": $("#txt_Id").val(),
        "Is_send": $("#txt_Is_send").val(),
        "Job_code": $("#txt_Job_code").val(),
        "Msgid": $("#txt_Msgid").val(),
        "Send_time": $("#txt_Send_time").val(),
        "Url": $("#txt_Url").val(),
        "User_id": $("#txt_User_id").val(),
        "Uuid": $("#txt_Uuid").val(),
        "Xb_job_id": $("#txt_Xb_job_id").val(), 
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
    /// <para>与Xb_job_user_dingyue数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_job_user_dingyue : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_job_user_dingyue Factory()
        {
            return new Xb_job_user_dingyue();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary>  Attribute </summary>
        public string _Appid
        {            
            get { return this.Appid; }
            set { this.Appid = value; }
        }
        
        /// <summary>  Attribute </summary>
        public string _Dy_first
        {            
            get { return this.Dy_first; }
            set { this.Dy_first = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Dy_keyword1
        {            
            get { return this.Dy_keyword1; }
            set { this.Dy_keyword1 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Dy_keyword2
        {            
            get { return this.Dy_keyword2; }
            set { this.Dy_keyword2 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Dy_keyword3
        {            
            get { return this.Dy_keyword3; }
            set { this.Dy_keyword3 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Dy_keyword4
        {            
            get { return this.Dy_keyword4; }
            set { this.Dy_keyword4 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Dy_keyword5
        {            
            get { return this.Dy_keyword5; }
            set { this.Dy_keyword5 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Dy_keyword6
        {            
            get { return this.Dy_keyword6; }
            set { this.Dy_keyword6 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Dy_remark
        {            
            get { return this.Dy_remark; }
            set { this.Dy_remark = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Dy_time1
        {            
            get { return this.Dy_time1; }
            set { this.Dy_time1 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Dy_time2
        {            
            get { return this.Dy_time2; }
            set { this.Dy_time2 = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary>  Attribute </summary>
        public bool _Is_send
        {            
            get { return this.Is_send; }
            set { this.Is_send = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Job_code
        {            
            get { return this.Job_code; }
            set { this.Job_code = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Msgid
        {            
            get { return this.Msgid; }
            set { this.Msgid = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public DateTime _Send_time
        {            
            get { return this.Send_time; }
            set { this.Send_time = value; }
        }
        
        /// <summary>  Attribute_IsNotNull </summary>
        public string _Url
        {            
            get { return this.Url; }
            set { this.Url = value; }
        }
        
        /// <summary>  Attribute </summary>
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
        
        /// <summary>  Attribute </summary>
        public string _Xb_job_id
        {            
            get { return this.Xb_job_id; }
            set { this.Xb_job_id = value; }
        }
        #endregion
        #region 类字段清单2
        
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
        public string Dy_first
        {
            get { return this.m_dy_first; }
            set //
            {
                if (!dy_first_initialized || m_dy_first != value)
                {
                    this.m_dy_first = value;
                }
                dy_first_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Dy_keyword1
        {
            get { return this.m_dy_keyword1; }
            set //
            {
                if (!dy_keyword1_initialized || m_dy_keyword1 != value)
                {
                    this.m_dy_keyword1 = value;
                }
                dy_keyword1_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Dy_keyword2
        {
            get { return this.m_dy_keyword2; }
            set //
            {
                if (!dy_keyword2_initialized || m_dy_keyword2 != value)
                {
                    this.m_dy_keyword2 = value;
                }
                dy_keyword2_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Dy_keyword3
        {
            get { return this.m_dy_keyword3; }
            set //
            {
                if (!dy_keyword3_initialized || m_dy_keyword3 != value)
                {
                    this.m_dy_keyword3 = value;
                }
                dy_keyword3_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Dy_keyword4
        {
            get { return this.m_dy_keyword4; }
            set //
            {
                if (!dy_keyword4_initialized || m_dy_keyword4 != value)
                {
                    this.m_dy_keyword4 = value;
                }
                dy_keyword4_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Dy_keyword5
        {
            get { return this.m_dy_keyword5; }
            set //
            {
                if (!dy_keyword5_initialized || m_dy_keyword5 != value)
                {
                    this.m_dy_keyword5 = value;
                }
                dy_keyword5_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Dy_keyword6
        {
            get { return this.m_dy_keyword6; }
            set //
            {
                if (!dy_keyword6_initialized || m_dy_keyword6 != value)
                {
                    this.m_dy_keyword6 = value;
                }
                dy_keyword6_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Dy_remark
        {
            get { return this.m_dy_remark; }
            set //
            {
                if (!dy_remark_initialized || m_dy_remark != value)
                {
                    this.m_dy_remark = value;
                }
                dy_remark_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public DateTime Dy_time1
        {
            get { return this.m_dy_time1; }
            set //
            {
                if (!dy_time1_initialized || m_dy_time1 != value)
                {
                    this.m_dy_time1 = value;
                }
                dy_time1_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public DateTime Dy_time2
        {
            get { return this.m_dy_time2; }
            set //
            {
                if (!dy_time2_initialized || m_dy_time2 != value)
                {
                    this.m_dy_time2 = value;
                }
                dy_time2_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public bool Is_send
        {
            get { return this.m_is_send; }
            set //
            {
                if (!is_send_initialized || m_is_send != value)
                {
                    this.m_is_send = value;
                }
                is_send_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Job_code
        {
            get { return this.m_job_code; }
            set //
            {
                if (!job_code_initialized || m_job_code != value)
                {
                    this.m_job_code = value;
                }
                job_code_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Msgid
        {
            get { return this.m_msgid; }
            set //
            {
                if (!msgid_initialized || m_msgid != value)
                {
                    this.m_msgid = value;
                }
                msgid_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public DateTime Send_time
        {
            get { return this.m_send_time; }
            set //
            {
                if (!send_time_initialized || m_send_time != value)
                {
                    this.m_send_time = value;
                }
                send_time_initialized = true;
            }
        }
        
        /// <summary> ，推荐使用 "_"符号开头 </summary>
        public string Url
        {
            get { return this.m_url; }
            set //
            {
                if (!url_initialized || m_url != value)
                {
                    this.m_url = value;
                }
                url_initialized = true;
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
        public string Xb_job_id
        {
            get { return this.m_xb_job_id; }
            set //
            {
                if (!xb_job_id_initialized || m_xb_job_id != value)
                {
                    this.m_xb_job_id = value;
                }
                xb_job_id_initialized = true;
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
            public static AttributeItem Appid =  new AttributeItem("[Xb_job_user_dingyue].[Appid]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dy_first =  new AttributeItem("[Xb_job_user_dingyue].[Dy_first]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dy_keyword1 =  new AttributeItem("[Xb_job_user_dingyue].[Dy_keyword1]", typeof(string), 300, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dy_keyword2 =  new AttributeItem("[Xb_job_user_dingyue].[Dy_keyword2]", typeof(string), 300, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dy_keyword3 =  new AttributeItem("[Xb_job_user_dingyue].[Dy_keyword3]", typeof(string), 300, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dy_keyword4 =  new AttributeItem("[Xb_job_user_dingyue].[Dy_keyword4]", typeof(string), 300, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dy_keyword5 =  new AttributeItem("[Xb_job_user_dingyue].[Dy_keyword5]", typeof(string), 300, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dy_keyword6 =  new AttributeItem("[Xb_job_user_dingyue].[Dy_keyword6]", typeof(string), 300, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dy_remark =  new AttributeItem("[Xb_job_user_dingyue].[Dy_remark]", typeof(string), 300, default(string));
            
            /// <summary></summary>
            public static AttributeItem Dy_time1 =  new AttributeItem("[Xb_job_user_dingyue].[Dy_time1]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Dy_time2 =  new AttributeItem("[Xb_job_user_dingyue].[Dy_time2]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_job_user_dingyue].[Id]", typeof(int), 4, default(int));
            
            /// <summary></summary>
            public static AttributeItem Is_send =  new AttributeItem("[Xb_job_user_dingyue].[Is_send]", typeof(bool), 1, default(bool));
            
            /// <summary></summary>
            public static AttributeItem Job_code =  new AttributeItem("[Xb_job_user_dingyue].[Job_code]", typeof(string), 10, default(string));
            
            /// <summary></summary>
            public static AttributeItem Msgid =  new AttributeItem("[Xb_job_user_dingyue].[Msgid]", typeof(string), 50, default(string));
            
            /// <summary></summary>
            public static AttributeItem Send_time =  new AttributeItem("[Xb_job_user_dingyue].[Send_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary></summary>
            public static AttributeItem Url =  new AttributeItem("[Xb_job_user_dingyue].[Url]", typeof(string), 150, default(string));
            
            /// <summary></summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_job_user_dingyue].[User_id]", typeof(string), 36, default(string));
            
            /// <summary></summary>
            public static AttributeItem Uuid =  new AttributeItem("[Xb_job_user_dingyue].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary></summary>
            public static AttributeItem Xb_job_id =  new AttributeItem("[Xb_job_user_dingyue].[Xb_job_id]", typeof(string), 36, default(string));
        }
        #endregion
        #region bool清单 辅助设计
        
        private string m_appid;
        /// <summary></summary>
        protected bool appid_initialized = false;
        
        private string m_dy_first;
        /// <summary></summary>
        protected bool dy_first_initialized = false;
        
        private string m_dy_keyword1;
        /// <summary></summary>
        protected bool dy_keyword1_initialized = false;
        
        private string m_dy_keyword2;
        /// <summary></summary>
        protected bool dy_keyword2_initialized = false;
        
        private string m_dy_keyword3;
        /// <summary></summary>
        protected bool dy_keyword3_initialized = false;
        
        private string m_dy_keyword4;
        /// <summary></summary>
        protected bool dy_keyword4_initialized = false;
        
        private string m_dy_keyword5;
        /// <summary></summary>
        protected bool dy_keyword5_initialized = false;
        
        private string m_dy_keyword6;
        /// <summary></summary>
        protected bool dy_keyword6_initialized = false;
        
        private string m_dy_remark;
        /// <summary></summary>
        protected bool dy_remark_initialized = false;
        
        private DateTime m_dy_time1;
        /// <summary></summary>
        protected bool dy_time1_initialized = false;
        
        private DateTime m_dy_time2;
        /// <summary></summary>
        protected bool dy_time2_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private bool m_is_send;
        /// <summary></summary>
        protected bool is_send_initialized = false;
        
        private string m_job_code;
        /// <summary></summary>
        protected bool job_code_initialized = false;
        
        private string m_msgid;
        /// <summary></summary>
        protected bool msgid_initialized = false;
        
        private DateTime m_send_time;
        /// <summary></summary>
        protected bool send_time_initialized = false;
        
        private string m_url;
        /// <summary></summary>
        protected bool url_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_xb_job_id;
        /// <summary></summary>
        protected bool xb_job_id_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_job_user_dingyue";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.appid_initialized = IsLoadAllAttributes;this.dy_first_initialized = IsLoadAllAttributes;this.dy_keyword1_initialized = IsLoadAllAttributes;this.dy_keyword2_initialized = IsLoadAllAttributes;this.dy_keyword3_initialized = IsLoadAllAttributes;this.dy_keyword4_initialized = IsLoadAllAttributes;this.dy_keyword5_initialized = IsLoadAllAttributes;this.dy_keyword6_initialized = IsLoadAllAttributes;this.dy_remark_initialized = IsLoadAllAttributes;this.dy_time1_initialized = IsLoadAllAttributes;this.dy_time2_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.is_send_initialized = IsLoadAllAttributes;this.job_code_initialized = IsLoadAllAttributes;this.msgid_initialized = IsLoadAllAttributes;this.send_time_initialized = IsLoadAllAttributes;this.url_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.uuid_initialized = IsLoadAllAttributes;this.xb_job_id_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_job_user_dingyue value = new Xb_job_user_dingyue();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Appid"))
				value.appid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_first"))
				value.dy_first_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_keyword1"))
				value.dy_keyword1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_keyword2"))
				value.dy_keyword2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_keyword3"))
				value.dy_keyword3_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_keyword4"))
				value.dy_keyword4_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_keyword5"))
				value.dy_keyword5_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_keyword6"))
				value.dy_keyword6_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_remark"))
				value.dy_remark_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_time1"))
				value.dy_time1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Dy_time2"))
				value.dy_time2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Is_send"))
				value.is_send_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Job_code"))
				value.job_code_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Msgid"))
				value.msgid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Send_time"))
				value.send_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Url"))
				value.url_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Xb_job_id"))
				value.xb_job_id_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_job_user_dingyue Clone()
        {
            return (Xb_job_user_dingyue)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_job_user_dingyue()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_job_user_dingyue() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_job_user_dingyue(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_job_user_dingyue(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_job_user_dingyue(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_job_user_dingyue(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_job_user_dingyue(string appid1, string dy_first1, string dy_keyword11, string dy_keyword21, string dy_keyword31, string dy_keyword41, string dy_keyword51, string dy_keyword61, string dy_remark1, DateTime dy_time11, DateTime dy_time21, int id1, bool is_send1, string job_code1, string msgid1, DateTime send_time1, string url1, string user_id1, Guid uuid1, string xb_job_id1)
        {
            
            this.Appid = appid1;
            
            this.Dy_first = dy_first1;
            
            this.Dy_keyword1 = dy_keyword11;
            
            this.Dy_keyword2 = dy_keyword21;
            
            this.Dy_keyword3 = dy_keyword31;
            
            this.Dy_keyword4 = dy_keyword41;
            
            this.Dy_keyword5 = dy_keyword51;
            
            this.Dy_keyword6 = dy_keyword61;
            
            this.Dy_remark = dy_remark1;
            
            this.Dy_time1 = dy_time11;
            
            this.Dy_time2 = dy_time21;
            
            this.Id = id1;
            
            this.Is_send = is_send1;
            
            this.Job_code = job_code1;
            
            this.Msgid = msgid1;
            
            this.Send_time = send_time1;
            
            this.Url = url1;
            
            this.User_id = user_id1;
            
            this.Uuid = uuid1;
            
            this.Xb_job_id = xb_job_id1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_job_user_dingyue FromIView(IView view)
        {
            return (Xb_job_user_dingyue)IView.GetITable(view, "Xb_job_user_dingyue");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_job_user_dingyue GetOneInstance()
        {
            Xb_job_user_dingyue value = new Xb_job_user_dingyue();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_job_user_dingyue Retrieve()
        {
            BLLTable<Xb_job_user_dingyue>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Appid":
			        return Appid;
			    			
			    case "Dy_first":
			        return Dy_first;
			    			
			    case "Dy_keyword1":
			        return Dy_keyword1;
			    			
			    case "Dy_keyword2":
			        return Dy_keyword2;
			    			
			    case "Dy_keyword3":
			        return Dy_keyword3;
			    			
			    case "Dy_keyword4":
			        return Dy_keyword4;
			    			
			    case "Dy_keyword5":
			        return Dy_keyword5;
			    			
			    case "Dy_keyword6":
			        return Dy_keyword6;
			    			
			    case "Dy_remark":
			        return Dy_remark;
			    			
			    case "Dy_time1":
			        return Dy_time1;
			    			
			    case "Dy_time2":
			        return Dy_time2;
			    			
			    case "Id":
			        return Id;
			    			
			    case "Is_send":
			        return Is_send;
			    			
			    case "Job_code":
			        return Job_code;
			    			
			    case "Msgid":
			        return Msgid;
			    			
			    case "Send_time":
			        return Send_time;
			    			
			    case "Url":
			        return Url;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "Uuid":
			        return Uuid;
			    			
			    case "Xb_job_id":
			        return Xb_job_id;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Appid":
			        this.Appid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dy_first":
			        this.Dy_first = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dy_keyword1":
			        this.Dy_keyword1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dy_keyword2":
			        this.Dy_keyword2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dy_keyword3":
			        this.Dy_keyword3 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dy_keyword4":
			        this.Dy_keyword4 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dy_keyword5":
			        this.Dy_keyword5 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dy_keyword6":
			        this.Dy_keyword6 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dy_remark":
			        this.Dy_remark = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Dy_time1":
			        this.Dy_time1 = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Dy_time2":
			        this.Dy_time2 = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Is_send":
			        this.Is_send = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Job_code":
			        this.Job_code = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Msgid":
			        this.Msgid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Send_time":
			        this.Send_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Url":
			        this.Url = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Uuid":
			        this.Uuid = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Xb_job_id":
			        this.Xb_job_id = Convert.ToString(AttributeValue);
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
				case "Appid":
					return appid_initialized;
				
				case "Dy_first":
					return dy_first_initialized;
				
				case "Dy_keyword1":
					return dy_keyword1_initialized;
				
				case "Dy_keyword2":
					return dy_keyword2_initialized;
				
				case "Dy_keyword3":
					return dy_keyword3_initialized;
				
				case "Dy_keyword4":
					return dy_keyword4_initialized;
				
				case "Dy_keyword5":
					return dy_keyword5_initialized;
				
				case "Dy_keyword6":
					return dy_keyword6_initialized;
				
				case "Dy_remark":
					return dy_remark_initialized;
				
				case "Dy_time1":
					return dy_time1_initialized;
				
				case "Dy_time2":
					return dy_time2_initialized;
				
				case "Id":
					return id_initialized;
				
				case "Is_send":
					return is_send_initialized;
				
				case "Job_code":
					return job_code_initialized;
				
				case "Msgid":
					return msgid_initialized;
				
				case "Send_time":
					return send_time_initialized;
				
				case "Url":
					return url_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "Uuid":
					return uuid_initialized;
				
				case "Xb_job_id":
					return xb_job_id_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Appid":
					appid_initialized = ret;
					return true;
				
				case "Dy_first":
					dy_first_initialized = ret;
					return true;
				
				case "Dy_keyword1":
					dy_keyword1_initialized = ret;
					return true;
				
				case "Dy_keyword2":
					dy_keyword2_initialized = ret;
					return true;
				
				case "Dy_keyword3":
					dy_keyword3_initialized = ret;
					return true;
				
				case "Dy_keyword4":
					dy_keyword4_initialized = ret;
					return true;
				
				case "Dy_keyword5":
					dy_keyword5_initialized = ret;
					return true;
				
				case "Dy_keyword6":
					dy_keyword6_initialized = ret;
					return true;
				
				case "Dy_remark":
					dy_remark_initialized = ret;
					return true;
				
				case "Dy_time1":
					dy_time1_initialized = ret;
					return true;
				
				case "Dy_time2":
					dy_time2_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Is_send":
					is_send_initialized = ret;
					return true;
				
				case "Job_code":
					job_code_initialized = ret;
					return true;
				
				case "Msgid":
					msgid_initialized = ret;
					return true;
				
				case "Send_time":
					send_time_initialized = ret;
					return true;
				
				case "Url":
					url_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "Uuid":
					uuid_initialized = ret;
					return true;
				
				case "Xb_job_id":
					xb_job_id_initialized = ret;
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

			
			if (appid_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Appid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Appid);
                }
			}
			
			if (dy_first_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_first;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_first);
                }
			}
			
			if (dy_keyword1_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_keyword1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_keyword1);
                }
			}
			
			if (dy_keyword2_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_keyword2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_keyword2);
                }
			}
			
			if (dy_keyword3_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_keyword3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_keyword3);
                }
			}
			
			if (dy_keyword4_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_keyword4;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_keyword4);
                }
			}
			
			if (dy_keyword5_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_keyword5;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_keyword5);
                }
			}
			
			if (dy_keyword6_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_keyword6;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_keyword6);
                }
			}
			
			if (dy_remark_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_remark;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_remark);
                }
			}
			
			if (dy_time1_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_time1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_time1);
                }
			}
			
			if (dy_time2_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Dy_time2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Dy_time2);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (is_send_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Is_send;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Is_send);
                }
			}
			
			if (job_code_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Job_code;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Job_code);
                }
			}
			
			if (msgid_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Msgid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Msgid);
                }
			}
			
			if (send_time_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Send_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Send_time);
                }
			}
			
			if (url_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Url;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Url);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (uuid_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (xb_job_id_initialized)
			{
                AttributeItem attr = Xb_job_user_dingyue.Attribute.Xb_job_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Xb_job_id);
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
        public class Xb_job_user_dingyueJson
        {
            
            /// <summary></summary>
            public string Appid { get; set; }
            
            /// <summary></summary>
            public string Dy_first { get; set; }
            
            /// <summary></summary>
            public string Dy_keyword1 { get; set; }
            
            /// <summary></summary>
            public string Dy_keyword2 { get; set; }
            
            /// <summary></summary>
            public string Dy_keyword3 { get; set; }
            
            /// <summary></summary>
            public string Dy_keyword4 { get; set; }
            
            /// <summary></summary>
            public string Dy_keyword5 { get; set; }
            
            /// <summary></summary>
            public string Dy_keyword6 { get; set; }
            
            /// <summary></summary>
            public string Dy_remark { get; set; }
            
            /// <summary></summary>
            public DateTime Dy_time1 { get; set; }
            
            /// <summary></summary>
            public DateTime Dy_time2 { get; set; }
            
            /// <summary></summary>
            public int Id { get; set; }
            
            /// <summary></summary>
            public bool Is_send { get; set; }
            
            /// <summary></summary>
            public string Job_code { get; set; }
            
            /// <summary></summary>
            public string Msgid { get; set; }
            
            /// <summary></summary>
            public DateTime Send_time { get; set; }
            
            /// <summary></summary>
            public string Url { get; set; }
            
            /// <summary></summary>
            public string User_id { get; set; }
            
            /// <summary></summary>
            public Guid Uuid { get; set; }
            
            /// <summary></summary>
            public string Xb_job_id { get; set; }
        }
        #endregion
    }
}
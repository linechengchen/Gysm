/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/13 16:45:07
  Description:    ���ݱ�St_kemuInfo��Ӧ��ҵ���߼���St_kemuInfo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� St_kemuInfo_Entity:St_kemuInfo
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,CreateTime,Icon,IsHot,IsShowIndex,Kemu_type,KemuId,KemuName,KemuType,Openid,PId,Sc,Sc1,Sc2,Sc3,School_id,ScType,Seq,ShortKemuName,TimuSum,ZsId from St_kemuInfo
delete from St_kemuInfo
INSERT INTO St_kemuInfo (Id,CreateTime,Icon,IsHot,IsShowIndex,Kemu_type,KemuId,KemuName,KemuType,Openid,PId,Sc,Sc1,Sc2,Sc3,School_id,ScType,Seq,ShortKemuName,TimuSum,ZsId)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','')
UPDATE St_kemuInfo SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.CreateTime = valObj2.CreateTime;
        valObj.Icon = valObj2.Icon;
        valObj.IsHot = valObj2.IsHot;
        valObj.IsShowIndex = valObj2.IsShowIndex;
        valObj.Kemu_type = valObj2.Kemu_type;
        valObj.KemuId = valObj2.KemuId;
        valObj.KemuName = valObj2.KemuName;
        valObj.KemuType = valObj2.KemuType;
        valObj.Openid = valObj2.Openid;
        valObj.PId = valObj2.PId;
        valObj.Sc = valObj2.Sc;
        valObj.Sc1 = valObj2.Sc1;
        valObj.Sc2 = valObj2.Sc2;
        valObj.Sc3 = valObj2.Sc3;
        valObj.School_id = valObj2.School_id;
        valObj.ScType = valObj2.ScType;
        valObj.Seq = valObj2.Seq;
        valObj.ShortKemuName = valObj2.ShortKemuName;
        valObj.TimuSum = valObj2.TimuSum;
        valObj.ZsId = valObj2.ZsId; 
        valObj.Id = "";
        valObj.CreateTime = "";
        valObj.Icon = "";
        valObj.IsHot = "";
        valObj.IsShowIndex = "";
        valObj.Kemu_type = "";
        valObj.KemuId = "";
        valObj.KemuName = "";
        valObj.KemuType = "";
        valObj.Openid = "";
        valObj.PId = "";
        valObj.Sc = "";
        valObj.Sc1 = "";
        valObj.Sc2 = "";
        valObj.Sc3 = "";
        valObj.School_id = "";
        valObj.ScType = "";
        valObj.Seq = "";
        valObj.ShortKemuName = "";
        valObj.TimuSum = "";
        valObj.ZsId = ""; 
        "Id": $("#txt_Id").val(),
        "CreateTime": $("#txt_CreateTime").val(),
        "Icon": $("#txt_Icon").val(),
        "IsHot": $("#txt_IsHot").val(),
        "IsShowIndex": $("#txt_IsShowIndex").val(),
        "Kemu_type": $("#txt_Kemu_type").val(),
        "KemuId": $("#txt_KemuId").val(),
        "KemuName": $("#txt_KemuName").val(),
        "KemuType": $("#txt_KemuType").val(),
        "Openid": $("#txt_Openid").val(),
        "PId": $("#txt_PId").val(),
        "Sc": $("#txt_Sc").val(),
        "Sc1": $("#txt_Sc1").val(),
        "Sc2": $("#txt_Sc2").val(),
        "Sc3": $("#txt_Sc3").val(),
        "School_id": $("#txt_School_id").val(),
        "ScType": $("#txt_ScType").val(),
        "Seq": $("#txt_Seq").val(),
        "ShortKemuName": $("#txt_ShortKemuName").val(),
        "TimuSum": $("#txt_TimuSum").val(),
        "ZsId": $("#txt_ZsId").val(), 
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
    /// <para>��Ŀ��(��ѧ�ķֿ�Ŀ):[IDField-{Id:0}]</para>
    /// <para>��St_kemuInfo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class St_kemuInfo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static St_kemuInfo Factory()
        {
            return new St_kemuInfo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> �Զ�Id:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Icon
        {            
            get { return this.Icon; }
            set { this.Icon = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsHot
        {            
            get { return this.IsHot; }
            set { this.IsHot = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _IsShowIndex
        {            
            get { return this.IsShowIndex; }
            set { this.IsShowIndex = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Kemu_type
        {            
            get { return this.Kemu_type; }
            set { this.Kemu_type = value; }
        }
        
        /// <summary> ��ĿId:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _KemuId
        {            
            get { return this.KemuId; }
            set { this.KemuId = value; }
        }
        
        /// <summary> ��Ŀ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _KemuName
        {            
            get { return this.KemuName; }
            set { this.KemuName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _KemuType
        {            
            get { return this.KemuType; }
            set { this.KemuType = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Openid
        {            
            get { return this.Openid; }
            set { this.Openid = value; }
        }
        
        /// <summary> ����ĿId:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PId
        {            
            get { return this.PId; }
            set { this.PId = value; }
        }
        
        /// <summary> Դ��ѧУ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Sc
        {            
            get { return this.Sc; }
            set { this.Sc = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc1
        {            
            get { return this.Sc1; }
            set { this.Sc1 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc2
        {            
            get { return this.Sc2; }
            set { this.Sc2 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Sc3
        {            
            get { return this.Sc3; }
            set { this.Sc3 = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _School_id
        {            
            get { return this.School_id; }
            set { this.School_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ScType
        {            
            get { return this.ScType; }
            set { this.ScType = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Seq
        {            
            get { return this.Seq; }
            set { this.Seq = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ShortKemuName
        {            
            get { return this.ShortKemuName; }
            set { this.ShortKemuName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TimuSum
        {            
            get { return this.TimuSum; }
            set { this.TimuSum = value; }
        }
        
        /// <summary> ֤��Id:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ZsId
        {            
            get { return this.ZsId; }
            set { this.ZsId = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> �Զ�Id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        public string Icon
        {
            get { return this.m_icon; }
            set //
            {
                if (!icon_initialized || m_icon != value)
                {
                    this.m_icon = value;
                }
                icon_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool IsHot
        {
            get { return this.m_ishot; }
            set //
            {
                if (!ishot_initialized || m_ishot != value)
                {
                    this.m_ishot = value;
                }
                ishot_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool IsShowIndex
        {
            get { return this.m_isshowindex; }
            set //
            {
                if (!isshowindex_initialized || m_isshowindex != value)
                {
                    this.m_isshowindex = value;
                }
                isshowindex_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Kemu_type
        {
            get { return this.m_kemu_type; }
            set //
            {
                if (!kemu_type_initialized || m_kemu_type != value)
                {
                    this.m_kemu_type = value;
                }
                kemu_type_initialized = true;
            }
        }
        
        /// <summary> ��ĿId:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int KemuId
        {
            get { return this.m_kemuid; }
            set //
            {
                if (!kemuid_initialized || m_kemuid != value)
                {
                    this.m_kemuid = value;
                }
                kemuid_initialized = true;
            }
        }
        
        /// <summary> ��Ŀ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string KemuName
        {
            get { return this.m_kemuname; }
            set //
            {
                if (!kemuname_initialized || m_kemuname != value)
                {
                    this.m_kemuname = value;
                }
                kemuname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int KemuType
        {
            get { return this.m_kemutype; }
            set //
            {
                if (!kemutype_initialized || m_kemutype != value)
                {
                    this.m_kemutype = value;
                }
                kemutype_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Openid
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
        
        /// <summary> ����ĿId:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int PId
        {
            get { return this.m_pid; }
            set //
            {
                if (!pid_initialized || m_pid != value)
                {
                    this.m_pid = value;
                }
                pid_initialized = true;
            }
        }
        
        /// <summary> Դ��ѧУ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Sc
        {
            get { return this.m_sc; }
            set //
            {
                if (!sc_initialized || m_sc != value)
                {
                    this.m_sc = value;
                }
                sc_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sc1
        {
            get { return this.m_sc1; }
            set //
            {
                if (!sc1_initialized || m_sc1 != value)
                {
                    this.m_sc1 = value;
                }
                sc1_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sc2
        {
            get { return this.m_sc2; }
            set //
            {
                if (!sc2_initialized || m_sc2 != value)
                {
                    this.m_sc2 = value;
                }
                sc2_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Sc3
        {
            get { return this.m_sc3; }
            set //
            {
                if (!sc3_initialized || m_sc3 != value)
                {
                    this.m_sc3 = value;
                }
                sc3_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string School_id
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
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ScType
        {
            get { return this.m_sctype; }
            set //
            {
                if (!sctype_initialized || m_sctype != value)
                {
                    this.m_sctype = value;
                }
                sctype_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Seq
        {
            get { return this.m_seq; }
            set //
            {
                if (!seq_initialized || m_seq != value)
                {
                    this.m_seq = value;
                }
                seq_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ShortKemuName
        {
            get { return this.m_shortkemuname; }
            set //
            {
                if (!shortkemuname_initialized || m_shortkemuname != value)
                {
                    this.m_shortkemuname = value;
                }
                shortkemuname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int TimuSum
        {
            get { return this.m_timusum; }
            set //
            {
                if (!timusum_initialized || m_timusum != value)
                {
                    this.m_timusum = value;
                }
                timusum_initialized = true;
            }
        }
        
        /// <summary> ֤��Id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ZsId
        {
            get { return this.m_zsid; }
            set //
            {
                if (!zsid_initialized || m_zsid != value)
                {
                    this.m_zsid = value;
                }
                zsid_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>�Զ�Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[St_kemuInfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[St_kemuInfo].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Icon =  new AttributeItem("[St_kemuInfo].[Icon]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsHot =  new AttributeItem("[St_kemuInfo].[IsHot]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsShowIndex =  new AttributeItem("[St_kemuInfo].[IsShowIndex]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu_type =  new AttributeItem("[St_kemuInfo].[Kemu_type]", typeof(string), 50, default(string));
            
            /// <summary>��ĿId:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuId =  new AttributeItem("[St_kemuInfo].[KemuId]", typeof(int), 4, default(int));
            
            /// <summary>��Ŀ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuName =  new AttributeItem("[St_kemuInfo].[KemuName]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuType =  new AttributeItem("[St_kemuInfo].[KemuType]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Openid =  new AttributeItem("[St_kemuInfo].[Openid]", typeof(string), 50, default(string));
            
            /// <summary>����ĿId:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PId =  new AttributeItem("[St_kemuInfo].[PId]", typeof(int), 4, default(int));
            
            /// <summary>Դ��ѧУ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[St_kemuInfo].[Sc]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc1 =  new AttributeItem("[St_kemuInfo].[Sc1]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc2 =  new AttributeItem("[St_kemuInfo].[Sc2]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc3 =  new AttributeItem("[St_kemuInfo].[Sc3]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_id =  new AttributeItem("[St_kemuInfo].[School_id]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ScType =  new AttributeItem("[St_kemuInfo].[ScType]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[St_kemuInfo].[Seq]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ShortKemuName =  new AttributeItem("[St_kemuInfo].[ShortKemuName]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TimuSum =  new AttributeItem("[St_kemuInfo].[TimuSum]", typeof(int), 4, default(int));
            
            /// <summary>֤��Id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsId =  new AttributeItem("[St_kemuInfo].[ZsId]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private string m_icon;
        /// <summary></summary>
        protected bool icon_initialized = false;
        
        private bool m_ishot;
        /// <summary></summary>
        protected bool ishot_initialized = false;
        
        private bool m_isshowindex;
        /// <summary></summary>
        protected bool isshowindex_initialized = false;
        
        private string m_kemu_type;
        /// <summary></summary>
        protected bool kemu_type_initialized = false;
        
        private int m_kemuid;
        /// <summary></summary>
        protected bool kemuid_initialized = false;
        
        private string m_kemuname;
        /// <summary></summary>
        protected bool kemuname_initialized = false;
        
        private int m_kemutype;
        /// <summary></summary>
        protected bool kemutype_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private int m_pid;
        /// <summary></summary>
        protected bool pid_initialized = false;
        
        private int m_sc;
        /// <summary></summary>
        protected bool sc_initialized = false;
        
        private string m_sc1;
        /// <summary></summary>
        protected bool sc1_initialized = false;
        
        private string m_sc2;
        /// <summary></summary>
        protected bool sc2_initialized = false;
        
        private string m_sc3;
        /// <summary></summary>
        protected bool sc3_initialized = false;
        
        private string m_school_id;
        /// <summary></summary>
        protected bool school_id_initialized = false;
        
        private string m_sctype;
        /// <summary></summary>
        protected bool sctype_initialized = false;
        
        private int m_seq;
        /// <summary></summary>
        protected bool seq_initialized = false;
        
        private string m_shortkemuname;
        /// <summary></summary>
        protected bool shortkemuname_initialized = false;
        
        private int m_timusum;
        /// <summary></summary>
        protected bool timusum_initialized = false;
        
        private int m_zsid;
        /// <summary></summary>
        protected bool zsid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "St_kemuInfo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.createtime_initialized = IsLoadAllAttributes;this.icon_initialized = IsLoadAllAttributes;this.ishot_initialized = IsLoadAllAttributes;this.isshowindex_initialized = IsLoadAllAttributes;this.kemu_type_initialized = IsLoadAllAttributes;this.kemuid_initialized = IsLoadAllAttributes;this.kemuname_initialized = IsLoadAllAttributes;this.kemutype_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.pid_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.sc1_initialized = IsLoadAllAttributes;this.sc2_initialized = IsLoadAllAttributes;this.sc3_initialized = IsLoadAllAttributes;this.school_id_initialized = IsLoadAllAttributes;this.sctype_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;this.shortkemuname_initialized = IsLoadAllAttributes;this.timusum_initialized = IsLoadAllAttributes;this.zsid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			St_kemuInfo value = new St_kemuInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Icon"))
				value.icon_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHot"))
				value.ishot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsShowIndex"))
				value.isshowindex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_type"))
				value.kemu_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuId"))
				value.kemuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuName"))
				value.kemuname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuType"))
				value.kemutype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Openid"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PId"))
				value.pid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc"))
				value.sc_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc1"))
				value.sc1_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc2"))
				value.sc2_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Sc3"))
				value.sc3_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"School_id"))
				value.school_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ScType"))
				value.sctype_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Seq"))
				value.seq_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ShortKemuName"))
				value.shortkemuname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TimuSum"))
				value.timusum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsId"))
				value.zsid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new St_kemuInfo Clone()
        {
            return (St_kemuInfo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static St_kemuInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public St_kemuInfo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public St_kemuInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public St_kemuInfo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public St_kemuInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public St_kemuInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public St_kemuInfo(int id1, DateTime createtime1, string icon1, bool ishot1, bool isshowindex1, string kemu_type1, int kemuid1, string kemuname1, int kemutype1, string openid1, int pid1, int sc1, string sc11, string sc21, string sc31, string school_id1, string sctype1, int seq1, string shortkemuname1, int timusum1, int zsid1)
        {
            
            this.Id = id1;
            
            this.CreateTime = createtime1;
            
            this.Icon = icon1;
            
            this.IsHot = ishot1;
            
            this.IsShowIndex = isshowindex1;
            
            this.Kemu_type = kemu_type1;
            
            this.KemuId = kemuid1;
            
            this.KemuName = kemuname1;
            
            this.KemuType = kemutype1;
            
            this.Openid = openid1;
            
            this.PId = pid1;
            
            this.Sc = sc1;
            
            this.Sc1 = sc11;
            
            this.Sc2 = sc21;
            
            this.Sc3 = sc31;
            
            this.School_id = school_id1;
            
            this.ScType = sctype1;
            
            this.Seq = seq1;
            
            this.ShortKemuName = shortkemuname1;
            
            this.TimuSum = timusum1;
            
            this.ZsId = zsid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static St_kemuInfo FromIView(IView view)
        {
            return (St_kemuInfo)IView.GetITable(view, "St_kemuInfo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static St_kemuInfo GetOneInstance()
        {
            St_kemuInfo value = new St_kemuInfo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public St_kemuInfo Retrieve()
        {
            BLLTable<St_kemuInfo>.GetRowData(this);
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
			    			
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Icon":
			        return Icon;
			    			
			    case "IsHot":
			        return IsHot;
			    			
			    case "IsShowIndex":
			        return IsShowIndex;
			    			
			    case "Kemu_type":
			        return Kemu_type;
			    			
			    case "KemuId":
			        return KemuId;
			    			
			    case "KemuName":
			        return KemuName;
			    			
			    case "KemuType":
			        return KemuType;
			    			
			    case "Openid":
			        return Openid;
			    			
			    case "PId":
			        return PId;
			    			
			    case "Sc":
			        return Sc;
			    			
			    case "Sc1":
			        return Sc1;
			    			
			    case "Sc2":
			        return Sc2;
			    			
			    case "Sc3":
			        return Sc3;
			    			
			    case "School_id":
			        return School_id;
			    			
			    case "ScType":
			        return ScType;
			    			
			    case "Seq":
			        return Seq;
			    			
			    case "ShortKemuName":
			        return ShortKemuName;
			    			
			    case "TimuSum":
			        return TimuSum;
			    			
			    case "ZsId":
			        return ZsId;
			
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
			    			
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Icon":
			        this.Icon = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "IsHot":
			        this.IsHot = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "IsShowIndex":
			        this.IsShowIndex = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Kemu_type":
			        this.Kemu_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KemuId":
			        this.KemuId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "KemuName":
			        this.KemuName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KemuType":
			        this.KemuType = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Openid":
			        this.Openid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PId":
			        this.PId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Sc":
			        this.Sc = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Sc1":
			        this.Sc1 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc2":
			        this.Sc2 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Sc3":
			        this.Sc3 = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "School_id":
			        this.School_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ScType":
			        this.ScType = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Seq":
			        this.Seq = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ShortKemuName":
			        this.ShortKemuName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TimuSum":
			        this.TimuSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ZsId":
			        this.ZsId = Convert.ToInt32(AttributeValue);
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
				
				case "CreateTime":
					return createtime_initialized;
				
				case "Icon":
					return icon_initialized;
				
				case "IsHot":
					return ishot_initialized;
				
				case "IsShowIndex":
					return isshowindex_initialized;
				
				case "Kemu_type":
					return kemu_type_initialized;
				
				case "KemuId":
					return kemuid_initialized;
				
				case "KemuName":
					return kemuname_initialized;
				
				case "KemuType":
					return kemutype_initialized;
				
				case "Openid":
					return openid_initialized;
				
				case "PId":
					return pid_initialized;
				
				case "Sc":
					return sc_initialized;
				
				case "Sc1":
					return sc1_initialized;
				
				case "Sc2":
					return sc2_initialized;
				
				case "Sc3":
					return sc3_initialized;
				
				case "School_id":
					return school_id_initialized;
				
				case "ScType":
					return sctype_initialized;
				
				case "Seq":
					return seq_initialized;
				
				case "ShortKemuName":
					return shortkemuname_initialized;
				
				case "TimuSum":
					return timusum_initialized;
				
				case "ZsId":
					return zsid_initialized;
				
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
				
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Icon":
					icon_initialized = ret;
					return true;
				
				case "IsHot":
					ishot_initialized = ret;
					return true;
				
				case "IsShowIndex":
					isshowindex_initialized = ret;
					return true;
				
				case "Kemu_type":
					kemu_type_initialized = ret;
					return true;
				
				case "KemuId":
					kemuid_initialized = ret;
					return true;
				
				case "KemuName":
					kemuname_initialized = ret;
					return true;
				
				case "KemuType":
					kemutype_initialized = ret;
					return true;
				
				case "Openid":
					openid_initialized = ret;
					return true;
				
				case "PId":
					pid_initialized = ret;
					return true;
				
				case "Sc":
					sc_initialized = ret;
					return true;
				
				case "Sc1":
					sc1_initialized = ret;
					return true;
				
				case "Sc2":
					sc2_initialized = ret;
					return true;
				
				case "Sc3":
					sc3_initialized = ret;
					return true;
				
				case "School_id":
					school_id_initialized = ret;
					return true;
				
				case "ScType":
					sctype_initialized = ret;
					return true;
				
				case "Seq":
					seq_initialized = ret;
					return true;
				
				case "ShortKemuName":
					shortkemuname_initialized = ret;
					return true;
				
				case "TimuSum":
					timusum_initialized = ret;
					return true;
				
				case "ZsId":
					zsid_initialized = ret;
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
                AttributeItem attr = St_kemuInfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (createtime_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (icon_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.Icon;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Icon);
                }
			}
			
			if (ishot_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.IsHot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHot);
                }
			}
			
			if (isshowindex_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.IsShowIndex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsShowIndex);
                }
			}
			
			if (kemu_type_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.Kemu_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_type);
                }
			}
			
			if (kemuid_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.KemuId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuId);
                }
			}
			
			if (kemuname_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.KemuName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuName);
                }
			}
			
			if (kemutype_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.KemuType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuType);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.Openid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Openid);
                }
			}
			
			if (pid_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.PId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PId);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (sc1_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.Sc1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc1);
                }
			}
			
			if (sc2_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.Sc2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc2);
                }
			}
			
			if (sc3_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.Sc3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc3);
                }
			}
			
			if (school_id_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.School_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_id);
                }
			}
			
			if (sctype_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.ScType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ScType);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
                }
			}
			
			if (shortkemuname_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.ShortKemuName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ShortKemuName);
                }
			}
			
			if (timusum_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.TimuSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TimuSum);
                }
			}
			
			if (zsid_initialized)
			{
                AttributeItem attr = St_kemuInfo.Attribute.ZsId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ZsId);
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
        public class St_kemuInfoJson
        {
            
            /// <summary>�Զ�Id:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Icon { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsHot { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsShowIndex { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Kemu_type { get; set; }
            
            /// <summary>��ĿId:[CtrlTypeDic-{InputString}]</summary>
            public int KemuId { get; set; }
            
            /// <summary>��Ŀ��:[CtrlTypeDic-{InputString}]</summary>
            public string KemuName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int KemuType { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Openid { get; set; }
            
            /// <summary>����ĿId:[CtrlTypeDic-{InputString}]</summary>
            public int PId { get; set; }
            
            /// <summary>Դ��ѧУ��:[CtrlTypeDic-{InputString}]</summary>
            public int Sc { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Sc1 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Sc2 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Sc3 { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string School_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ScType { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Seq { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string ShortKemuName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int TimuSum { get; set; }
            
            /// <summary>֤��Id:[CtrlTypeDic-{InputString}]</summary>
            public int ZsId { get; set; }
        }
        #endregion
    }
}
/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2017/6/17 15:37:01
  Description:    数据表Xb_kemuinfo对应的业务逻辑层Xb_kemuinfo
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 Xb_kemuinfo_Entity:Xb_kemuinfo
 * 
************************************************************/
/************************************************************
SQL代码：
select CreateTime,Grade,Icon,Id,IsHot,IsShowIndex,Kemu_id,Kemu_name,Kemu_type,KemuType,PId,Sc,Sc1,Sc2,Sc3,School_id,ScType,Seq,Short_kemu_name,TimuSum,User_id,ZsId from Xb_kemuinfo
delete from Xb_kemuinfo
INSERT INTO Xb_kemuinfo (CreateTime,Grade,Icon,Id,IsHot,IsShowIndex,Kemu_id,Kemu_name,Kemu_type,KemuType,PId,Sc,Sc1,Sc2,Sc3,School_id,ScType,Seq,Short_kemu_name,TimuSum,User_id,ZsId)
     VALUES
           ('','','','','','','','','','','','','','','','','','','','','','')
UPDATE Xb_kemuinfo SET ...
变量赋值代码：
 *         valObj.CreateTime = valObj2.CreateTime;
        valObj.Grade = valObj2.Grade;
        valObj.Icon = valObj2.Icon;
        valObj.Id = valObj2.Id;
        valObj.IsHot = valObj2.IsHot;
        valObj.IsShowIndex = valObj2.IsShowIndex;
        valObj.Kemu_id = valObj2.Kemu_id;
        valObj.Kemu_name = valObj2.Kemu_name;
        valObj.Kemu_type = valObj2.Kemu_type;
        valObj.KemuType = valObj2.KemuType;
        valObj.PId = valObj2.PId;
        valObj.Sc = valObj2.Sc;
        valObj.Sc1 = valObj2.Sc1;
        valObj.Sc2 = valObj2.Sc2;
        valObj.Sc3 = valObj2.Sc3;
        valObj.School_id = valObj2.School_id;
        valObj.ScType = valObj2.ScType;
        valObj.Seq = valObj2.Seq;
        valObj.Short_kemu_name = valObj2.Short_kemu_name;
        valObj.TimuSum = valObj2.TimuSum;
        valObj.User_id = valObj2.User_id;
        valObj.ZsId = valObj2.ZsId; 
        valObj.CreateTime = "";
        valObj.Grade = "";
        valObj.Icon = "";
        valObj.Id = "";
        valObj.IsHot = "";
        valObj.IsShowIndex = "";
        valObj.Kemu_id = "";
        valObj.Kemu_name = "";
        valObj.Kemu_type = "";
        valObj.KemuType = "";
        valObj.PId = "";
        valObj.Sc = "";
        valObj.Sc1 = "";
        valObj.Sc2 = "";
        valObj.Sc3 = "";
        valObj.School_id = "";
        valObj.ScType = "";
        valObj.Seq = "";
        valObj.Short_kemu_name = "";
        valObj.TimuSum = "";
        valObj.User_id = "";
        valObj.ZsId = ""; 
        "CreateTime": $("#txt_CreateTime").val(),
        "Grade": $("#txt_Grade").val(),
        "Icon": $("#txt_Icon").val(),
        "Id": $("#txt_Id").val(),
        "IsHot": $("#txt_IsHot").val(),
        "IsShowIndex": $("#txt_IsShowIndex").val(),
        "Kemu_id": $("#txt_Kemu_id").val(),
        "Kemu_name": $("#txt_Kemu_name").val(),
        "Kemu_type": $("#txt_Kemu_type").val(),
        "KemuType": $("#txt_KemuType").val(),
        "PId": $("#txt_PId").val(),
        "Sc": $("#txt_Sc").val(),
        "Sc1": $("#txt_Sc1").val(),
        "Sc2": $("#txt_Sc2").val(),
        "Sc3": $("#txt_Sc3").val(),
        "School_id": $("#txt_School_id").val(),
        "ScType": $("#txt_ScType").val(),
        "Seq": $("#txt_Seq").val(),
        "Short_kemu_name": $("#txt_Short_kemu_name").val(),
        "TimuSum": $("#txt_TimuSum").val(),
        "User_id": $("#txt_User_id").val(),
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
    /// <para>科目信息</para>
    /// <para>与Xb_kemuinfo数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class Xb_kemuinfo : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static Xb_kemuinfo Factory()
        {
            return new Xb_kemuinfo();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
        /// <summary> [CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _CreateTime
        {            
            get { return this.CreateTime; }
            set { this.CreateTime = value; }
        }
        
        /// <summary> 年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public int _Grade
        {            
            get { return this.Grade; }
            set { this.Grade = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Icon
        {            
            get { return this.Icon; }
            set { this.Icon = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsHot
        {            
            get { return this.IsHot; }
            set { this.IsHot = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute_IsNotNull </summary>
        public bool _IsShowIndex
        {            
            get { return this.IsShowIndex; }
            set { this.IsShowIndex = value; }
        }
        
        /// <summary> 科目编号:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Kemu_id
        {            
            get { return this.Kemu_id; }
            set { this.Kemu_id = value; }
        }
        
        /// <summary> 科目名称:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Kemu_name
        {            
            get { return this.Kemu_name; }
            set { this.Kemu_name = value; }
        }
        
        /// <summary> 科目:[Enum-{0:不限},{1:数学},{2:英语},{3:语文},{4:物理},{5:化学},{6:生物},{7:政治},{8:历史},{9:地理},{10:奥数},{11:科学},{12:钢琴},{13:书法},{14:舞蹈},{15:素描},{16:国画}][CtrlTypeDic-{SelectDrop}] Attribute_IsNotNull </summary>
        public string _Kemu_type
        {            
            get { return this.Kemu_type; }
            set { this.Kemu_type = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _KemuType
        {            
            get { return this.KemuType; }
            set { this.KemuType = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _PId
        {            
            get { return this.PId; }
            set { this.PId = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
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
        public string _Short_kemu_name
        {            
            get { return this.Short_kemu_name; }
            set { this.Short_kemu_name = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TimuSum
        {            
            get { return this.TimuSum; }
            set { this.TimuSum = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ZsId
        {            
            get { return this.ZsId; }
            set { this.ZsId = value; }
        }
        #endregion
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputDateTime}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 科目编号:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> 科目名称:[CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Kemu_name
        {
            get { return this.m_kemu_name; }
            set //
            {
                if (!kemu_name_initialized || m_kemu_name != value)
                {
                    this.m_kemu_name = value;
                }
                kemu_name_initialized = true;
            }
        }
        
        /// <summary> 科目:[Enum-{0:不限},{1:数学},{2:英语},{3:语文},{4:物理},{5:化学},{6:生物},{7:政治},{8:历史},{9:地理},{10:奥数},{11:科学},{12:钢琴},{13:书法},{14:舞蹈},{15:素描},{16:国画}][CtrlTypeDic-{SelectDrop}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
        public string Short_kemu_name
        {
            get { return this.m_short_kemu_name; }
            set //
            {
                if (!short_kemu_name_initialized || m_short_kemu_name != value)
                {
                    this.m_short_kemu_name = value;
                }
                short_kemu_name_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem CreateTime =  new AttributeItem("[Xb_kemuinfo].[CreateTime]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Grade =  new AttributeItem("[Xb_kemuinfo].[Grade]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Icon =  new AttributeItem("[Xb_kemuinfo].[Icon]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xb_kemuinfo].[Id]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsHot =  new AttributeItem("[Xb_kemuinfo].[IsHot]", typeof(bool), 1, default(bool));
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem IsShowIndex =  new AttributeItem("[Xb_kemuinfo].[IsShowIndex]", typeof(bool), 1, default(bool));
            
            /// <summary>科目编号:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu_id =  new AttributeItem("[Xb_kemuinfo].[Kemu_id]", typeof(int), 4, default(int));
            
            /// <summary>科目名称:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Kemu_name =  new AttributeItem("[Xb_kemuinfo].[Kemu_name]", typeof(string), 50, default(string));
            
            /// <summary>科目:[Enum-{0:不限},{1:数学},{2:英语},{3:语文},{4:物理},{5:化学},{6:生物},{7:政治},{8:历史},{9:地理},{10:奥数},{11:科学},{12:钢琴},{13:书法},{14:舞蹈},{15:素描},{16:国画}][CtrlTypeDic-{SelectDrop}]</summary>
            public static AttributeItem Kemu_type =  new AttributeItem("[Xb_kemuinfo].[Kemu_type]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem KemuType =  new AttributeItem("[Xb_kemuinfo].[KemuType]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PId =  new AttributeItem("[Xb_kemuinfo].[PId]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc =  new AttributeItem("[Xb_kemuinfo].[Sc]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc1 =  new AttributeItem("[Xb_kemuinfo].[Sc1]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc2 =  new AttributeItem("[Xb_kemuinfo].[Sc2]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Sc3 =  new AttributeItem("[Xb_kemuinfo].[Sc3]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem School_id =  new AttributeItem("[Xb_kemuinfo].[School_id]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ScType =  new AttributeItem("[Xb_kemuinfo].[ScType]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Seq =  new AttributeItem("[Xb_kemuinfo].[Seq]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Short_kemu_name =  new AttributeItem("[Xb_kemuinfo].[Short_kemu_name]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TimuSum =  new AttributeItem("[Xb_kemuinfo].[TimuSum]", typeof(int), 4, default(int));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[Xb_kemuinfo].[User_id]", typeof(string), 36, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ZsId =  new AttributeItem("[Xb_kemuinfo].[ZsId]", typeof(int), 4, default(int));
        }
        #endregion
        #region bool清单 辅助设计
        
        private DateTime m_createtime;
        /// <summary></summary>
        protected bool createtime_initialized = false;
        
        private int m_grade;
        /// <summary></summary>
        protected bool grade_initialized = false;
        
        private string m_icon;
        /// <summary></summary>
        protected bool icon_initialized = false;
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private bool m_ishot;
        /// <summary></summary>
        protected bool ishot_initialized = false;
        
        private bool m_isshowindex;
        /// <summary></summary>
        protected bool isshowindex_initialized = false;
        
        private int m_kemu_id;
        /// <summary></summary>
        protected bool kemu_id_initialized = false;
        
        private string m_kemu_name;
        /// <summary></summary>
        protected bool kemu_name_initialized = false;
        
        private string m_kemu_type;
        /// <summary></summary>
        protected bool kemu_type_initialized = false;
        
        private int m_kemutype;
        /// <summary></summary>
        protected bool kemutype_initialized = false;
        
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
        
        private string m_short_kemu_name;
        /// <summary></summary>
        protected bool short_kemu_name_initialized = false;
        
        private int m_timusum;
        /// <summary></summary>
        protected bool timusum_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private int m_zsid;
        /// <summary></summary>
        protected bool zsid_initialized = false;
        #endregion

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_kemuinfo";
        }
        
        /// <summary>
        /// 设置自动载入所有列
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.createtime_initialized = IsLoadAllAttributes;this.grade_initialized = IsLoadAllAttributes;this.icon_initialized = IsLoadAllAttributes;this.id_initialized = IsLoadAllAttributes;this.ishot_initialized = IsLoadAllAttributes;this.isshowindex_initialized = IsLoadAllAttributes;this.kemu_id_initialized = IsLoadAllAttributes;this.kemu_name_initialized = IsLoadAllAttributes;this.kemu_type_initialized = IsLoadAllAttributes;this.kemutype_initialized = IsLoadAllAttributes;this.pid_initialized = IsLoadAllAttributes;this.sc_initialized = IsLoadAllAttributes;this.sc1_initialized = IsLoadAllAttributes;this.sc2_initialized = IsLoadAllAttributes;this.sc3_initialized = IsLoadAllAttributes;this.school_id_initialized = IsLoadAllAttributes;this.sctype_initialized = IsLoadAllAttributes;this.seq_initialized = IsLoadAllAttributes;this.short_kemu_name_initialized = IsLoadAllAttributes;this.timusum_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.zsid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_kemuinfo value = new Xb_kemuinfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"CreateTime"))
				value.createtime_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Grade"))
				value.grade_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Icon"))
				value.icon_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsHot"))
				value.ishot_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"IsShowIndex"))
				value.isshowindex_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_id"))
				value.kemu_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_name"))
				value.kemu_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Kemu_type"))
				value.kemu_type_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"KemuType"))
				value.kemutype_initialized = true;
            
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
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Short_kemu_name"))
				value.short_kemu_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TimuSum"))
				value.timusum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ZsId"))
				value.zsid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new Xb_kemuinfo Clone()
        {
            return (Xb_kemuinfo)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static Xb_kemuinfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public Xb_kemuinfo() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public Xb_kemuinfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public Xb_kemuinfo(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public Xb_kemuinfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public Xb_kemuinfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public Xb_kemuinfo(DateTime createtime1, int grade1, string icon1, int id1, bool ishot1, bool isshowindex1, int kemu_id1, string kemu_name1, string kemu_type1, int kemutype1, int pid1, int sc1, string sc11, string sc21, string sc31, string school_id1, string sctype1, int seq1, string short_kemu_name1, int timusum1, string user_id1, int zsid1)
        {
            
            this.CreateTime = createtime1;
            
            this.Grade = grade1;
            
            this.Icon = icon1;
            
            this.Id = id1;
            
            this.IsHot = ishot1;
            
            this.IsShowIndex = isshowindex1;
            
            this.Kemu_id = kemu_id1;
            
            this.Kemu_name = kemu_name1;
            
            this.Kemu_type = kemu_type1;
            
            this.KemuType = kemutype1;
            
            this.PId = pid1;
            
            this.Sc = sc1;
            
            this.Sc1 = sc11;
            
            this.Sc2 = sc21;
            
            this.Sc3 = sc31;
            
            this.School_id = school_id1;
            
            this.ScType = sctype1;
            
            this.Seq = seq1;
            
            this.Short_kemu_name = short_kemu_name1;
            
            this.TimuSum = timusum1;
            
            this.User_id = user_id1;
            
            this.ZsId = zsid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static Xb_kemuinfo FromIView(IView view)
        {
            return (Xb_kemuinfo)IView.GetITable(view, "Xb_kemuinfo");
        }
        /// <summary>获得一个实例  </summary>
        public static Xb_kemuinfo GetOneInstance()
        {
            Xb_kemuinfo value = new Xb_kemuinfo();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public Xb_kemuinfo Retrieve()
        {
            BLLTable<Xb_kemuinfo>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "CreateTime":
			        return CreateTime;
			    			
			    case "Grade":
			        return Grade;
			    			
			    case "Icon":
			        return Icon;
			    			
			    case "Id":
			        return Id;
			    			
			    case "IsHot":
			        return IsHot;
			    			
			    case "IsShowIndex":
			        return IsShowIndex;
			    			
			    case "Kemu_id":
			        return Kemu_id;
			    			
			    case "Kemu_name":
			        return Kemu_name;
			    			
			    case "Kemu_type":
			        return Kemu_type;
			    			
			    case "KemuType":
			        return KemuType;
			    			
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
			    			
			    case "Short_kemu_name":
			        return Short_kemu_name;
			    			
			    case "TimuSum":
			        return TimuSum;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "ZsId":
			        return ZsId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>通过属性 设置字段值</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "CreateTime":
			        this.CreateTime = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Grade":
			        this.Grade = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Icon":
			        this.Icon = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "IsHot":
			        this.IsHot = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "IsShowIndex":
			        this.IsShowIndex = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Kemu_id":
			        this.Kemu_id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Kemu_name":
			        this.Kemu_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Kemu_type":
			        this.Kemu_type = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "KemuType":
			        this.KemuType = Convert.ToInt32(AttributeValue);
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
			    			
			    case "Short_kemu_name":
			        this.Short_kemu_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TimuSum":
			        this.TimuSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ZsId":
			        this.ZsId = Convert.ToInt32(AttributeValue);
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
				case "CreateTime":
					return createtime_initialized;
				
				case "Grade":
					return grade_initialized;
				
				case "Icon":
					return icon_initialized;
				
				case "Id":
					return id_initialized;
				
				case "IsHot":
					return ishot_initialized;
				
				case "IsShowIndex":
					return isshowindex_initialized;
				
				case "Kemu_id":
					return kemu_id_initialized;
				
				case "Kemu_name":
					return kemu_name_initialized;
				
				case "Kemu_type":
					return kemu_type_initialized;
				
				case "KemuType":
					return kemutype_initialized;
				
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
				
				case "Short_kemu_name":
					return short_kemu_name_initialized;
				
				case "TimuSum":
					return timusum_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "ZsId":
					return zsid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "CreateTime":
					createtime_initialized = ret;
					return true;
				
				case "Grade":
					grade_initialized = ret;
					return true;
				
				case "Icon":
					icon_initialized = ret;
					return true;
				
				case "Id":
					id_initialized = ret;
					return true;
				
				case "IsHot":
					ishot_initialized = ret;
					return true;
				
				case "IsShowIndex":
					isshowindex_initialized = ret;
					return true;
				
				case "Kemu_id":
					kemu_id_initialized = ret;
					return true;
				
				case "Kemu_name":
					kemu_name_initialized = ret;
					return true;
				
				case "Kemu_type":
					kemu_type_initialized = ret;
					return true;
				
				case "KemuType":
					kemutype_initialized = ret;
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
				
				case "Short_kemu_name":
					short_kemu_name_initialized = ret;
					return true;
				
				case "TimuSum":
					timusum_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "ZsId":
					zsid_initialized = ret;
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

			
			if (createtime_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.CreateTime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(CreateTime);
                }
			}
			
			if (grade_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Grade;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Grade);
                }
			}
			
			if (icon_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Icon;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Icon);
                }
			}
			
			if (id_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (ishot_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.IsHot;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsHot);
                }
			}
			
			if (isshowindex_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.IsShowIndex;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(IsShowIndex);
                }
			}
			
			if (kemu_id_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Kemu_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_id);
                }
			}
			
			if (kemu_name_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Kemu_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_name);
                }
			}
			
			if (kemu_type_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Kemu_type;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Kemu_type);
                }
			}
			
			if (kemutype_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.KemuType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(KemuType);
                }
			}
			
			if (pid_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.PId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PId);
                }
			}
			
			if (sc_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Sc;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc);
                }
			}
			
			if (sc1_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Sc1;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc1);
                }
			}
			
			if (sc2_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Sc2;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc2);
                }
			}
			
			if (sc3_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Sc3;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Sc3);
                }
			}
			
			if (school_id_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.School_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(School_id);
                }
			}
			
			if (sctype_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.ScType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ScType);
                }
			}
			
			if (seq_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Seq;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Seq);
                }
			}
			
			if (short_kemu_name_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.Short_kemu_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Short_kemu_name);
                }
			}
			
			if (timusum_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.TimuSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TimuSum);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (zsid_initialized)
			{
                AttributeItem attr = Xb_kemuinfo.Attribute.ZsId;
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

        #region Json对象
        /// <summary>
        /// {字段属性-结构属性}
        /// </summary>
        [Serializable]
        public class Xb_kemuinfoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime CreateTime { get; set; }
            
            /// <summary>年级:[Enum-{0:不限},{1:一年级},{2:二年级},{3:三年级},{4:四年级},{5:五年级},{6:六年级},{7:七年级},{8:八年级},{9:九年级},{10:高一},{11:高二},{12:高三},{13:大一},{14:大二},{15:大三}][CtrlTypeDic-{SelectDrop}]</summary>
            public int Grade { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Icon { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsHot { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool IsShowIndex { get; set; }
            
            /// <summary>科目编号:[CtrlTypeDic-{InputString}]</summary>
            public int Kemu_id { get; set; }
            
            /// <summary>科目名称:[CtrlTypeDic-{InputString}]</summary>
            public string Kemu_name { get; set; }
            
            /// <summary>科目:[Enum-{0:不限},{1:数学},{2:英语},{3:语文},{4:物理},{5:化学},{6:生物},{7:政治},{8:历史},{9:地理},{10:奥数},{11:科学},{12:钢琴},{13:书法},{14:舞蹈},{15:素描},{16:国画}][CtrlTypeDic-{SelectDrop}]</summary>
            public string Kemu_type { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int KemuType { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int PId { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
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
            public string Short_kemu_name { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int TimuSum { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int ZsId { get; set; }
        }
        #endregion
    }
}
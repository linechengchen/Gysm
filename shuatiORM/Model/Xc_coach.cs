/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:29
  Description:    ���ݱ�Xc_coach��Ӧ��ҵ���߼���Xc_coach
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xc_coach_Entity:Xc_coach
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,GId,Name,Score,Student,Gift,City_rank,Jiaxiao_name,Intro,Peilian,Img,Create_time,Score_count,Score_taidu,Score_shoufei,Score_jishu from Xc_coach
delete from Xc_coach
INSERT INTO Xc_coach (Id,GId,Name,Score,Student,Gift,City_rank,Jiaxiao_name,Intro,Peilian,Img,Create_time,Score_count,Score_taidu,Score_shoufei,Score_jishu)
     VALUES
           ('','','','','','','','','','','','','','','','')
UPDATE Xc_coach SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.GId = valObj2.GId;
        valObj.Name = valObj2.Name;
        valObj.Score = valObj2.Score;
        valObj.Student = valObj2.Student;
        valObj.Gift = valObj2.Gift;
        valObj.City_rank = valObj2.City_rank;
        valObj.Jiaxiao_name = valObj2.Jiaxiao_name;
        valObj.Intro = valObj2.Intro;
        valObj.Peilian = valObj2.Peilian;
        valObj.Img = valObj2.Img;
        valObj.Create_time = valObj2.Create_time;
        valObj.Score_count = valObj2.Score_count;
        valObj.Score_taidu = valObj2.Score_taidu;
        valObj.Score_shoufei = valObj2.Score_shoufei;
        valObj.Score_jishu = valObj2.Score_jishu; 
        valObj.Id = "";
        valObj.GId = "";
        valObj.Name = "";
        valObj.Score = "";
        valObj.Student = "";
        valObj.Gift = "";
        valObj.City_rank = "";
        valObj.Jiaxiao_name = "";
        valObj.Intro = "";
        valObj.Peilian = "";
        valObj.Img = "";
        valObj.Create_time = "";
        valObj.Score_count = "";
        valObj.Score_taidu = "";
        valObj.Score_shoufei = "";
        valObj.Score_jishu = ""; 
        "Id": $("#txt_Id").val(),
        "GId": $("#txt_GId").val(),
        "Name": $("#txt_Name").val(),
        "Score": $("#txt_Score").val(),
        "Student": $("#txt_Student").val(),
        "Gift": $("#txt_Gift").val(),
        "City_rank": $("#txt_City_rank").val(),
        "Jiaxiao_name": $("#txt_Jiaxiao_name").val(),
        "Intro": $("#txt_Intro").val(),
        "Peilian": $("#txt_Peilian").val(),
        "Img": $("#txt_Img").val(),
        "Create_time": $("#txt_Create_time").val(),
        "Score_count": $("#txt_Score_count").val(),
        "Score_taidu": $("#txt_Score_taidu").val(),
        "Score_shoufei": $("#txt_Score_shoufei").val(),
        "Score_jishu": $("#txt_Score_jishu").val(), 
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
    /// <para>����</para>
    /// <para>��Xc_coach���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xc_coach : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xc_coach Factory()
        {
            return new Xc_coach();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> GID:[CtrlTypeDic-{InputString}] Attribute </summary>
        public Guid _GId
        {            
            get { return this.GId; }
            set { this.GId = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Name
        {            
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Score
        {            
            get { return this.Score; }
            set { this.Score = value; }
        }
        
        /// <summary> ѧ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Student
        {            
            get { return this.Student; }
            set { this.Student = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Gift
        {            
            get { return this.Gift; }
            set { this.Gift = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _City_rank
        {            
            get { return this.City_rank; }
            set { this.City_rank = value; }
        }
        
        /// <summary> Jiaxiao������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Jiaxiao_name
        {            
            get { return this.Jiaxiao_name; }
            set { this.Jiaxiao_name = value; }
        }
        
        /// <summary> ���:[CtrlTypeDic-{Text}] Attribute_IsNotNull </summary>
        public string _Intro
        {            
            get { return this.Intro; }
            set { this.Intro = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Peilian
        {            
            get { return this.Peilian; }
            set { this.Peilian = value; }
        }
        
        /// <summary> IMG:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Img
        {            
            get { return this.Img; }
            set { this.Img = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute </summary>
        public DateTime _Create_time
        {            
            get { return this.Create_time; }
            set { this.Create_time = value; }
        }
        
        /// <summary> �÷�ͳ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _Score_count
        {            
            get { return this.Score_count; }
            set { this.Score_count = value; }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Score_taidu
        {            
            get { return this.Score_taidu; }
            set { this.Score_taidu = value; }
        }
        
        /// <summary> �����շ�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Score_shoufei
        {            
            get { return this.Score_shoufei; }
            set { this.Score_shoufei = value; }
        }
        
        /// <summary> ���ּ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _Score_jishu
        {            
            get { return this.Score_jishu; }
            set { this.Score_jishu = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> GID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public Guid GId
        {
            get { return this.m_gid; }
            set //
            {
                if (!gid_initialized || m_gid != value)
                {
                    this.m_gid = value;
                }
                gid_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        public decimal Score
        {
            get { return this.m_score; }
            set //
            {
                if (!score_initialized || m_score != value)
                {
                    this.m_score = value;
                }
                score_initialized = true;
            }
        }
        
        /// <summary> ѧ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Student
        {
            get { return this.m_student; }
            set //
            {
                if (!student_initialized || m_student != value)
                {
                    this.m_student = value;
                }
                student_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Gift
        {
            get { return this.m_gift; }
            set //
            {
                if (!gift_initialized || m_gift != value)
                {
                    this.m_gift = value;
                }
                gift_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int City_rank
        {
            get { return this.m_city_rank; }
            set //
            {
                if (!city_rank_initialized || m_city_rank != value)
                {
                    this.m_city_rank = value;
                }
                city_rank_initialized = true;
            }
        }
        
        /// <summary> Jiaxiao������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Jiaxiao_name
        {
            get { return this.m_jiaxiao_name; }
            set //
            {
                if (!jiaxiao_name_initialized || m_jiaxiao_name != value)
                {
                    this.m_jiaxiao_name = value;
                }
                jiaxiao_name_initialized = true;
            }
        }
        
        /// <summary> ���:[CtrlTypeDic-{Text}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Intro
        {
            get { return this.m_intro; }
            set //
            {
                if (!intro_initialized || m_intro != value)
                {
                    this.m_intro = value;
                }
                intro_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Peilian
        {
            get { return this.m_peilian; }
            set //
            {
                if (!peilian_initialized || m_peilian != value)
                {
                    this.m_peilian = value;
                }
                peilian_initialized = true;
            }
        }
        
        /// <summary> IMG:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Img
        {
            get { return this.m_img; }
            set //
            {
                if (!img_initialized || m_img != value)
                {
                    this.m_img = value;
                }
                img_initialized = true;
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
        
        /// <summary> �÷�ͳ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Score_count
        {
            get { return this.m_score_count; }
            set //
            {
                if (!score_count_initialized || m_score_count != value)
                {
                    this.m_score_count = value;
                }
                score_count_initialized = true;
            }
        }
        
        /// <summary> ����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Score_taidu
        {
            get { return this.m_score_taidu; }
            set //
            {
                if (!score_taidu_initialized || m_score_taidu != value)
                {
                    this.m_score_taidu = value;
                }
                score_taidu_initialized = true;
            }
        }
        
        /// <summary> �����շ�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Score_shoufei
        {
            get { return this.m_score_shoufei; }
            set //
            {
                if (!score_shoufei_initialized || m_score_shoufei != value)
                {
                    this.m_score_shoufei = value;
                }
                score_shoufei_initialized = true;
            }
        }
        
        /// <summary> ���ּ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal Score_jishu
        {
            get { return this.m_score_jishu; }
            set //
            {
                if (!score_jishu_initialized || m_score_jishu != value)
                {
                    this.m_score_jishu = value;
                }
                score_jishu_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[Xc_coach].[Id]", typeof(int), 4, default(int));
            
            /// <summary>GID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GId =  new AttributeItem("[Xc_coach].[GId]", typeof(Guid), 16, default(Guid));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Name =  new AttributeItem("[Xc_coach].[Name]", typeof(string), 50, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score =  new AttributeItem("[Xc_coach].[Score]", typeof(decimal), 18, default(decimal));
            
            /// <summary>ѧ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Student =  new AttributeItem("[Xc_coach].[Student]", typeof(int), 4, default(int));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Gift =  new AttributeItem("[Xc_coach].[Gift]", typeof(int), 4, default(int));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem City_rank =  new AttributeItem("[Xc_coach].[City_rank]", typeof(int), 4, default(int));
            
            /// <summary>Jiaxiao������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Jiaxiao_name =  new AttributeItem("[Xc_coach].[Jiaxiao_name]", typeof(string), 50, default(string));
            
            /// <summary>���:[CtrlTypeDic-{Text}]</summary>
            public static AttributeItem Intro =  new AttributeItem("[Xc_coach].[Intro]", typeof(string), 1000, default(string));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Peilian =  new AttributeItem("[Xc_coach].[Peilian]", typeof(int), 4, default(int));
            
            /// <summary>IMG:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Img =  new AttributeItem("[Xc_coach].[Img]", typeof(string), 200, default(string));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Create_time =  new AttributeItem("[Xc_coach].[Create_time]", typeof(DateTime), 8, default(DateTime));
            
            /// <summary>�÷�ͳ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score_count =  new AttributeItem("[Xc_coach].[Score_count]", typeof(int), 4, default(int));
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score_taidu =  new AttributeItem("[Xc_coach].[Score_taidu]", typeof(decimal), 18, default(decimal));
            
            /// <summary>�����շ�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score_shoufei =  new AttributeItem("[Xc_coach].[Score_shoufei]", typeof(decimal), 18, default(decimal));
            
            /// <summary>���ּ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Score_jishu =  new AttributeItem("[Xc_coach].[Score_jishu]", typeof(decimal), 18, default(decimal));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private Guid m_gid;
        /// <summary></summary>
        protected bool gid_initialized = false;
        
        private string m_name;
        /// <summary></summary>
        protected bool name_initialized = false;
        
        private decimal m_score;
        /// <summary></summary>
        protected bool score_initialized = false;
        
        private int m_student;
        /// <summary></summary>
        protected bool student_initialized = false;
        
        private int m_gift;
        /// <summary></summary>
        protected bool gift_initialized = false;
        
        private int m_city_rank;
        /// <summary></summary>
        protected bool city_rank_initialized = false;
        
        private string m_jiaxiao_name;
        /// <summary></summary>
        protected bool jiaxiao_name_initialized = false;
        
        private string m_intro;
        /// <summary></summary>
        protected bool intro_initialized = false;
        
        private int m_peilian;
        /// <summary></summary>
        protected bool peilian_initialized = false;
        
        private string m_img;
        /// <summary></summary>
        protected bool img_initialized = false;
        
        private DateTime m_create_time;
        /// <summary></summary>
        protected bool create_time_initialized = false;
        
        private int m_score_count;
        /// <summary></summary>
        protected bool score_count_initialized = false;
        
        private decimal m_score_taidu;
        /// <summary></summary>
        protected bool score_taidu_initialized = false;
        
        private decimal m_score_shoufei;
        /// <summary></summary>
        protected bool score_shoufei_initialized = false;
        
        private decimal m_score_jishu;
        /// <summary></summary>
        protected bool score_jishu_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xc_coach";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.gid_initialized = IsLoadAllAttributes;this.name_initialized = IsLoadAllAttributes;this.score_initialized = IsLoadAllAttributes;this.student_initialized = IsLoadAllAttributes;this.gift_initialized = IsLoadAllAttributes;this.city_rank_initialized = IsLoadAllAttributes;this.jiaxiao_name_initialized = IsLoadAllAttributes;this.intro_initialized = IsLoadAllAttributes;this.peilian_initialized = IsLoadAllAttributes;this.img_initialized = IsLoadAllAttributes;this.create_time_initialized = IsLoadAllAttributes;this.score_count_initialized = IsLoadAllAttributes;this.score_taidu_initialized = IsLoadAllAttributes;this.score_shoufei_initialized = IsLoadAllAttributes;this.score_jishu_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xc_coach value = new Xc_coach();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GId"))
				value.gid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Name"))
				value.name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score"))
				value.score_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Student"))
				value.student_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Gift"))
				value.gift_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"City_rank"))
				value.city_rank_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Jiaxiao_name"))
				value.jiaxiao_name_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Intro"))
				value.intro_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Peilian"))
				value.peilian_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Img"))
				value.img_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Create_time"))
				value.create_time_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_count"))
				value.score_count_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_taidu"))
				value.score_taidu_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_shoufei"))
				value.score_shoufei_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Score_jishu"))
				value.score_jishu_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xc_coach Clone()
        {
            return (Xc_coach)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xc_coach()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xc_coach() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xc_coach(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xc_coach(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xc_coach(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xc_coach(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xc_coach(int id1, Guid gid1, string name1, decimal score1, int student1, int gift1, int city_rank1, string jiaxiao_name1, string intro1, int peilian1, string img1, DateTime create_time1, int score_count1, decimal score_taidu1, decimal score_shoufei1, decimal score_jishu1)
        {
            
            this.Id = id1;
            
            this.GId = gid1;
            
            this.Name = name1;
            
            this.Score = score1;
            
            this.Student = student1;
            
            this.Gift = gift1;
            
            this.City_rank = city_rank1;
            
            this.Jiaxiao_name = jiaxiao_name1;
            
            this.Intro = intro1;
            
            this.Peilian = peilian1;
            
            this.Img = img1;
            
            this.Create_time = create_time1;
            
            this.Score_count = score_count1;
            
            this.Score_taidu = score_taidu1;
            
            this.Score_shoufei = score_shoufei1;
            
            this.Score_jishu = score_jishu1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xc_coach FromIView(IView view)
        {
            return (Xc_coach)IView.GetITable(view, "Xc_coach");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xc_coach GetOneInstance()
        {
            Xc_coach value = new Xc_coach();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xc_coach Retrieve()
        {
            BLLTable<Xc_coach>.GetRowData(this);
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
			    			
			    case "GId":
			        return GId;
			    			
			    case "Name":
			        return Name;
			    			
			    case "Score":
			        return Score;
			    			
			    case "Student":
			        return Student;
			    			
			    case "Gift":
			        return Gift;
			    			
			    case "City_rank":
			        return City_rank;
			    			
			    case "Jiaxiao_name":
			        return Jiaxiao_name;
			    			
			    case "Intro":
			        return Intro;
			    			
			    case "Peilian":
			        return Peilian;
			    			
			    case "Img":
			        return Img;
			    			
			    case "Create_time":
			        return Create_time;
			    			
			    case "Score_count":
			        return Score_count;
			    			
			    case "Score_taidu":
			        return Score_taidu;
			    			
			    case "Score_shoufei":
			        return Score_shoufei;
			    			
			    case "Score_jishu":
			        return Score_jishu;
			
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
			    			
			    case "GId":
			        this.GId = StringHelper.GuidParse(AttributeValue);
                    return true;
			    			
			    case "Name":
			        this.Name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Score":
			        this.Score = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Student":
			        this.Student = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Gift":
			        this.Gift = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "City_rank":
			        this.City_rank = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Jiaxiao_name":
			        this.Jiaxiao_name = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Intro":
			        this.Intro = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Peilian":
			        this.Peilian = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Img":
			        this.Img = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Create_time":
			        this.Create_time = Convert.ToDateTime(AttributeValue);
                    return true;
			    			
			    case "Score_count":
			        this.Score_count = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Score_taidu":
			        this.Score_taidu = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Score_shoufei":
			        this.Score_shoufei = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "Score_jishu":
			        this.Score_jishu = Convert.ToDecimal(AttributeValue);
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
				
				case "GId":
					return gid_initialized;
				
				case "Name":
					return name_initialized;
				
				case "Score":
					return score_initialized;
				
				case "Student":
					return student_initialized;
				
				case "Gift":
					return gift_initialized;
				
				case "City_rank":
					return city_rank_initialized;
				
				case "Jiaxiao_name":
					return jiaxiao_name_initialized;
				
				case "Intro":
					return intro_initialized;
				
				case "Peilian":
					return peilian_initialized;
				
				case "Img":
					return img_initialized;
				
				case "Create_time":
					return create_time_initialized;
				
				case "Score_count":
					return score_count_initialized;
				
				case "Score_taidu":
					return score_taidu_initialized;
				
				case "Score_shoufei":
					return score_shoufei_initialized;
				
				case "Score_jishu":
					return score_jishu_initialized;
				
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
				
				case "GId":
					gid_initialized = ret;
					return true;
				
				case "Name":
					name_initialized = ret;
					return true;
				
				case "Score":
					score_initialized = ret;
					return true;
				
				case "Student":
					student_initialized = ret;
					return true;
				
				case "Gift":
					gift_initialized = ret;
					return true;
				
				case "City_rank":
					city_rank_initialized = ret;
					return true;
				
				case "Jiaxiao_name":
					jiaxiao_name_initialized = ret;
					return true;
				
				case "Intro":
					intro_initialized = ret;
					return true;
				
				case "Peilian":
					peilian_initialized = ret;
					return true;
				
				case "Img":
					img_initialized = ret;
					return true;
				
				case "Create_time":
					create_time_initialized = ret;
					return true;
				
				case "Score_count":
					score_count_initialized = ret;
					return true;
				
				case "Score_taidu":
					score_taidu_initialized = ret;
					return true;
				
				case "Score_shoufei":
					score_shoufei_initialized = ret;
					return true;
				
				case "Score_jishu":
					score_jishu_initialized = ret;
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
                AttributeItem attr = Xc_coach.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (gid_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.GId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GId);
                }
			}
			
			if (name_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Name);
                }
			}
			
			if (score_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Score;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score);
                }
			}
			
			if (student_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Student;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Student);
                }
			}
			
			if (gift_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Gift;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Gift);
                }
			}
			
			if (city_rank_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.City_rank;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(City_rank);
                }
			}
			
			if (jiaxiao_name_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Jiaxiao_name;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Jiaxiao_name);
                }
			}
			
			if (intro_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Intro;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Intro);
                }
			}
			
			if (peilian_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Peilian;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Peilian);
                }
			}
			
			if (img_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Img;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Img);
                }
			}
			
			if (create_time_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Create_time;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Create_time);
                }
			}
			
			if (score_count_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Score_count;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_count);
                }
			}
			
			if (score_taidu_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Score_taidu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_taidu);
                }
			}
			
			if (score_shoufei_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Score_shoufei;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_shoufei);
                }
			}
			
			if (score_jishu_initialized)
			{
                AttributeItem attr = Xc_coach.Attribute.Score_jishu;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Score_jishu);
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
        public class Xc_coachJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>GID:[CtrlTypeDic-{InputString}]</summary>
            public Guid GId { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public string Name { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public decimal Score { get; set; }
            
            /// <summary>ѧ��:[CtrlTypeDic-{InputString}]</summary>
            public int Student { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public int Gift { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public int City_rank { get; set; }
            
            /// <summary>Jiaxiao������:[CtrlTypeDic-{InputString}]</summary>
            public string Jiaxiao_name { get; set; }
            
            /// <summary>���:[CtrlTypeDic-{Text}]</summary>
            public string Intro { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public int Peilian { get; set; }
            
            /// <summary>IMG:[CtrlTypeDic-{InputString}]</summary>
            public string Img { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Create_time { get; set; }
            
            /// <summary>�÷�ͳ��:[CtrlTypeDic-{InputString}]</summary>
            public int Score_count { get; set; }
            
            /// <summary>����:[CtrlTypeDic-{InputString}]</summary>
            public decimal Score_taidu { get; set; }
            
            /// <summary>�����շ�:[CtrlTypeDic-{InputString}]</summary>
            public decimal Score_shoufei { get; set; }
            
            /// <summary>���ּ���:[CtrlTypeDic-{InputString}]</summary>
            public decimal Score_jishu { get; set; }
        }
        #endregion
    }
}
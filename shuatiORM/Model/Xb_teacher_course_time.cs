/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/6/2 20:30:47
  Description:    ���ݱ�Xb_teacher_course_time��Ӧ��ҵ���߼���Xb_teacher_course_time
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xb_teacher_course_time_Entity:Xb_teacher_course_time
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,FavSum,ArticleCommentsSum,TearcherId,ClassTimerJson,TimerTemplate,TemplateType from Xb_teacher_course_time
delete from Xb_teacher_course_time
INSERT INTO Xb_teacher_course_time (Id,FavSum,ArticleCommentsSum,TearcherId,ClassTimerJson,TimerTemplate,TemplateType)
     VALUES
           ('','','','','','','')
UPDATE Xb_teacher_course_time SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.FavSum = valObj2.FavSum;
        valObj.ArticleCommentsSum = valObj2.ArticleCommentsSum;
        valObj.TearcherId = valObj2.TearcherId;
        valObj.ClassTimerJson = valObj2.ClassTimerJson;
        valObj.TimerTemplate = valObj2.TimerTemplate;
        valObj.TemplateType = valObj2.TemplateType; 
        valObj.Id = "";
        valObj.FavSum = "";
        valObj.ArticleCommentsSum = "";
        valObj.TearcherId = "";
        valObj.ClassTimerJson = "";
        valObj.TimerTemplate = "";
        valObj.TemplateType = ""; 
        "Id": $("#txt_Id").val(),
        "FavSum": $("#txt_FavSum").val(),
        "ArticleCommentsSum": $("#txt_ArticleCommentsSum").val(),
        "TearcherId": $("#txt_TearcherId").val(),
        "ClassTimerJson": $("#txt_ClassTimerJson").val(),
        "TimerTemplate": $("#txt_TimerTemplate").val(),
        "TemplateType": $("#txt_TemplateType").val(), 
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
    /// <para>��ʦ�������Ϣ</para>
    /// <para>��Xb_teacher_course_time���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xb_teacher_course_time : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xb_teacher_course_time Factory()
        {
            return new Xb_teacher_course_time();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> ��ϲ���ı�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _FavSum
        {            
            get { return this.FavSum; }
            set { this.FavSum = value; }
        }
        
        /// <summary> �������ۺ�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ArticleCommentsSum
        {            
            get { return this.ArticleCommentsSum; }
            set { this.ArticleCommentsSum = value; }
        }
        
        /// <summary> ��ʦ���:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _TearcherId
        {            
            get { return this.TearcherId; }
            set { this.TearcherId = value; }
        }
        
        /// <summary> JSON���ʱ��:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _ClassTimerJson
        {            
            get { return this.ClassTimerJson; }
            set { this.ClassTimerJson = value; }
        }
        
        /// <summary> ��ʱ��ģ��:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _TimerTemplate
        {            
            get { return this.TimerTemplate; }
            set { this.TimerTemplate = value; }
        }
        
        /// <summary> ģ������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TemplateType
        {            
            get { return this.TemplateType; }
            set { this.TemplateType = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ϲ���ı�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int FavSum
        {
            get { return this.m_favsum; }
            set //
            {
                if (!favsum_initialized || m_favsum != value)
                {
                    this.m_favsum = value;
                }
                favsum_initialized = true;
            }
        }
        
        /// <summary> �������ۺ�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ArticleCommentsSum
        {
            get { return this.m_articlecommentssum; }
            set //
            {
                if (!articlecommentssum_initialized || m_articlecommentssum != value)
                {
                    this.m_articlecommentssum = value;
                }
                articlecommentssum_initialized = true;
            }
        }
        
        /// <summary> ��ʦ���:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int TearcherId
        {
            get { return this.m_tearcherid; }
            set //
            {
                if (!tearcherid_initialized || m_tearcherid != value)
                {
                    this.m_tearcherid = value;
                }
                tearcherid_initialized = true;
            }
        }
        
        /// <summary> JSON���ʱ��:[CtrlTypeDic-{HTML}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassTimerJson
        {
            get { return this.m_classtimerjson; }
            set //
            {
                if (!classtimerjson_initialized || m_classtimerjson != value)
                {
                    this.m_classtimerjson = value;
                }
                classtimerjson_initialized = true;
            }
        }
        
        /// <summary> ��ʱ��ģ��:[CtrlTypeDic-{HTML}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TimerTemplate
        {
            get { return this.m_timertemplate; }
            set //
            {
                if (!timertemplate_initialized || m_timertemplate != value)
                {
                    this.m_timertemplate = value;
                }
                timertemplate_initialized = true;
            }
        }
        
        /// <summary> ģ������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TemplateType
        {
            get { return this.m_templatetype; }
            set //
            {
                if (!templatetype_initialized || m_templatetype != value)
                {
                    this.m_templatetype = value;
                }
                templatetype_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[Xb_teacher_course_time].[Id]", typeof(int), 4, default(int));
            
            /// <summary>��ϲ���ı�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem FavSum =  new AttributeItem("[Xb_teacher_course_time].[FavSum]", typeof(int), 4, default(int));
            
            /// <summary>�������ۺ�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ArticleCommentsSum =  new AttributeItem("[Xb_teacher_course_time].[ArticleCommentsSum]", typeof(int), 4, default(int));
            
            /// <summary>��ʦ���:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TearcherId =  new AttributeItem("[Xb_teacher_course_time].[TearcherId]", typeof(int), 4, default(int));
            
            /// <summary>JSON���ʱ��:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem ClassTimerJson =  new AttributeItem("[Xb_teacher_course_time].[ClassTimerJson]", typeof(string), 2000, default(string));
            
            /// <summary>��ʱ��ģ��:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem TimerTemplate =  new AttributeItem("[Xb_teacher_course_time].[TimerTemplate]", typeof(string), 2000, default(string));
            
            /// <summary>ģ������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TemplateType =  new AttributeItem("[Xb_teacher_course_time].[TemplateType]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private int m_favsum;
        /// <summary></summary>
        protected bool favsum_initialized = false;
        
        private int m_articlecommentssum;
        /// <summary></summary>
        protected bool articlecommentssum_initialized = false;
        
        private int m_tearcherid;
        /// <summary></summary>
        protected bool tearcherid_initialized = false;
        
        private string m_classtimerjson;
        /// <summary></summary>
        protected bool classtimerjson_initialized = false;
        
        private string m_timertemplate;
        /// <summary></summary>
        protected bool timertemplate_initialized = false;
        
        private string m_templatetype;
        /// <summary></summary>
        protected bool templatetype_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xb_teacher_course_time";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.favsum_initialized = IsLoadAllAttributes;this.articlecommentssum_initialized = IsLoadAllAttributes;this.tearcherid_initialized = IsLoadAllAttributes;this.classtimerjson_initialized = IsLoadAllAttributes;this.timertemplate_initialized = IsLoadAllAttributes;this.templatetype_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xb_teacher_course_time value = new Xb_teacher_course_time();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"FavSum"))
				value.favsum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ArticleCommentsSum"))
				value.articlecommentssum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TearcherId"))
				value.tearcherid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassTimerJson"))
				value.classtimerjson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TimerTemplate"))
				value.timertemplate_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TemplateType"))
				value.templatetype_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xb_teacher_course_time Clone()
        {
            return (Xb_teacher_course_time)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xb_teacher_course_time()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xb_teacher_course_time() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xb_teacher_course_time(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xb_teacher_course_time(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xb_teacher_course_time(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xb_teacher_course_time(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xb_teacher_course_time(int id1, int favsum1, int articlecommentssum1, int tearcherid1, string classtimerjson1, string timertemplate1, string templatetype1)
        {
            
            this.Id = id1;
            
            this.FavSum = favsum1;
            
            this.ArticleCommentsSum = articlecommentssum1;
            
            this.TearcherId = tearcherid1;
            
            this.ClassTimerJson = classtimerjson1;
            
            this.TimerTemplate = timertemplate1;
            
            this.TemplateType = templatetype1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xb_teacher_course_time FromIView(IView view)
        {
            return (Xb_teacher_course_time)IView.GetITable(view, "Xb_teacher_course_time");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xb_teacher_course_time GetOneInstance()
        {
            Xb_teacher_course_time value = new Xb_teacher_course_time();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xb_teacher_course_time Retrieve()
        {
            BLLTable<Xb_teacher_course_time>.GetRowData(this);
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
			    			
			    case "FavSum":
			        return FavSum;
			    			
			    case "ArticleCommentsSum":
			        return ArticleCommentsSum;
			    			
			    case "TearcherId":
			        return TearcherId;
			    			
			    case "ClassTimerJson":
			        return ClassTimerJson;
			    			
			    case "TimerTemplate":
			        return TimerTemplate;
			    			
			    case "TemplateType":
			        return TemplateType;
			
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
			    			
			    case "FavSum":
			        this.FavSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ArticleCommentsSum":
			        this.ArticleCommentsSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "TearcherId":
			        this.TearcherId = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "ClassTimerJson":
			        this.ClassTimerJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TimerTemplate":
			        this.TimerTemplate = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TemplateType":
			        this.TemplateType = Convert.ToString(AttributeValue);
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
				
				case "FavSum":
					return favsum_initialized;
				
				case "ArticleCommentsSum":
					return articlecommentssum_initialized;
				
				case "TearcherId":
					return tearcherid_initialized;
				
				case "ClassTimerJson":
					return classtimerjson_initialized;
				
				case "TimerTemplate":
					return timertemplate_initialized;
				
				case "TemplateType":
					return templatetype_initialized;
				
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
				
				case "FavSum":
					favsum_initialized = ret;
					return true;
				
				case "ArticleCommentsSum":
					articlecommentssum_initialized = ret;
					return true;
				
				case "TearcherId":
					tearcherid_initialized = ret;
					return true;
				
				case "ClassTimerJson":
					classtimerjson_initialized = ret;
					return true;
				
				case "TimerTemplate":
					timertemplate_initialized = ret;
					return true;
				
				case "TemplateType":
					templatetype_initialized = ret;
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
                AttributeItem attr = Xb_teacher_course_time.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (favsum_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.FavSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(FavSum);
                }
			}
			
			if (articlecommentssum_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.ArticleCommentsSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ArticleCommentsSum);
                }
			}
			
			if (tearcherid_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.TearcherId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TearcherId);
                }
			}
			
			if (classtimerjson_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.ClassTimerJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassTimerJson);
                }
			}
			
			if (timertemplate_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.TimerTemplate;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TimerTemplate);
                }
			}
			
			if (templatetype_initialized)
			{
                AttributeItem attr = Xb_teacher_course_time.Attribute.TemplateType;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TemplateType);
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
        public class Xb_teacher_course_timeJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>��ϲ���ı�:[CtrlTypeDic-{InputString}]</summary>
            public int FavSum { get; set; }
            
            /// <summary>�������ۺ�:[CtrlTypeDic-{InputString}]</summary>
            public int ArticleCommentsSum { get; set; }
            
            /// <summary>��ʦ���:[CtrlTypeDic-{InputString}]</summary>
            public int TearcherId { get; set; }
            
            /// <summary>JSON���ʱ��:[CtrlTypeDic-{HTML}]</summary>
            public string ClassTimerJson { get; set; }
            
            /// <summary>��ʱ��ģ��:[CtrlTypeDic-{HTML}]</summary>
            public string TimerTemplate { get; set; }
            
            /// <summary>ģ������:[CtrlTypeDic-{InputString}]</summary>
            public string TemplateType { get; set; }
        }
        #endregion
    }
}
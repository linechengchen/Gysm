/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:31
  Description:    ���ݱ�Xt_course_video��Ӧ��ҵ���߼���Xt_course_video
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Xt_course_video_Entity:Xt_course_video
 * 
************************************************************/
/************************************************************
SQL���룺
select Uuid,Course_id,Video_id,Creatime from Xt_course_video
delete from Xt_course_video
INSERT INTO Xt_course_video (Uuid,Course_id,Video_id,Creatime)
     VALUES
           ('','','','')
UPDATE Xt_course_video SET ...
������ֵ���룺
 *         valObj.Uuid = valObj2.Uuid;
        valObj.Course_id = valObj2.Course_id;
        valObj.Video_id = valObj2.Video_id;
        valObj.Creatime = valObj2.Creatime; 
        valObj.Uuid = "";
        valObj.Course_id = "";
        valObj.Video_id = "";
        valObj.Creatime = ""; 
        "Uuid": $("#txt_Uuid").val(),
        "Course_id": $("#txt_Course_id").val(),
        "Video_id": $("#txt_Video_id").val(),
        "Creatime": $("#txt_Creatime").val(), 
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
    /// <para>��Xt_course_video���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Xt_course_video : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Xt_course_video Factory()
        {
            return new Xt_course_video();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public Guid _Uuid
        {            
            get { return this.Uuid; }
            set { this.Uuid = value; }
        }
        
        /// <summary> �γ�id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Course_id
        {            
            get { return this.Course_id; }
            set { this.Course_id = value; }
        }
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}] Attribute </summary>
        public string _Video_id
        {            
            get { return this.Video_id; }
            set { this.Video_id = value; }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}] Attribute_IsNotNull </summary>
        public DateTime _Creatime
        {            
            get { return this.Creatime; }
            set { this.Creatime = value; }
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
        
        /// <summary> �γ�id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Course_id
        {
            get { return this.m_course_id; }
            set //
            {
                if (!course_id_initialized || m_course_id != value)
                {
                    this.m_course_id = value;
                }
                course_id_initialized = true;
            }
        }
        
        /// <summary> ����id:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Video_id
        {
            get { return this.m_video_id; }
            set //
            {
                if (!video_id_initialized || m_video_id != value)
                {
                    this.m_video_id = value;
                }
                video_id_initialized = true;
            }
        }
        
        /// <summary> ����ʱ��:[CtrlTypeDic-{InputDateTime}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public DateTime Creatime
        {
            get { return this.m_creatime; }
            set //
            {
                if (!creatime_initialized || m_creatime != value)
                {
                    this.m_creatime = value;
                }
                creatime_initialized = true;
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
            public static AttributeItem Uuid =  new AttributeItem("[Xt_course_video].[Uuid]", typeof(Guid), 16, default(Guid));
            
            /// <summary>�γ�id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Course_id =  new AttributeItem("[Xt_course_video].[Course_id]", typeof(string), 36, default(string));
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Video_id =  new AttributeItem("[Xt_course_video].[Video_id]", typeof(string), 36, default(string));
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public static AttributeItem Creatime =  new AttributeItem("[Xt_course_video].[Creatime]", typeof(DateTime), 8, default(DateTime));
        }
        #endregion
        #region bool�嵥 �������
        
        private Guid m_uuid;
        /// <summary></summary>
        protected bool uuid_initialized = false;
        
        private string m_course_id;
        /// <summary></summary>
        protected bool course_id_initialized = false;
        
        private string m_video_id;
        /// <summary></summary>
        protected bool video_id_initialized = false;
        
        private DateTime m_creatime;
        /// <summary></summary>
        protected bool creatime_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Xt_course_video";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.uuid_initialized = IsLoadAllAttributes;this.course_id_initialized = IsLoadAllAttributes;this.video_id_initialized = IsLoadAllAttributes;this.creatime_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Xt_course_video value = new Xt_course_video();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Uuid"))
				value.uuid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Course_id"))
				value.course_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Video_id"))
				value.video_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Creatime"))
				value.creatime_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Xt_course_video Clone()
        {
            return (Xt_course_video)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Xt_course_video()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Xt_course_video() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Xt_course_video(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Xt_course_video(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Xt_course_video(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Xt_course_video(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Xt_course_video(Guid uuid1, string course_id1, string video_id1, DateTime creatime1)
        {
            
            this.Uuid = uuid1;
            
            this.Course_id = course_id1;
            
            this.Video_id = video_id1;
            
            this.Creatime = creatime1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Xt_course_video FromIView(IView view)
        {
            return (Xt_course_video)IView.GetITable(view, "Xt_course_video");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Xt_course_video GetOneInstance()
        {
            Xt_course_video value = new Xt_course_video();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Xt_course_video Retrieve()
        {
            BLLTable<Xt_course_video>.GetRowData(this);
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
			    			
			    case "Course_id":
			        return Course_id;
			    			
			    case "Video_id":
			        return Video_id;
			    			
			    case "Creatime":
			        return Creatime;
			
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
			    			
			    case "Course_id":
			        this.Course_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Video_id":
			        this.Video_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Creatime":
			        this.Creatime = Convert.ToDateTime(AttributeValue);
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
				
				case "Course_id":
					return course_id_initialized;
				
				case "Video_id":
					return video_id_initialized;
				
				case "Creatime":
					return creatime_initialized;
				
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
				
				case "Course_id":
					course_id_initialized = ret;
					return true;
				
				case "Video_id":
					video_id_initialized = ret;
					return true;
				
				case "Creatime":
					creatime_initialized = ret;
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
                AttributeItem attr = Xt_course_video.Attribute.Uuid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Uuid);
                }
			}
			
			if (course_id_initialized)
			{
                AttributeItem attr = Xt_course_video.Attribute.Course_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Course_id);
                }
			}
			
			if (video_id_initialized)
			{
                AttributeItem attr = Xt_course_video.Attribute.Video_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Video_id);
                }
			}
			
			if (creatime_initialized)
			{
                AttributeItem attr = Xt_course_video.Attribute.Creatime;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Creatime);
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
        public class Xt_course_videoJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public Guid Uuid { get; set; }
            
            /// <summary>�γ�id:[CtrlTypeDic-{InputString}]</summary>
            public string Course_id { get; set; }
            
            /// <summary>����id:[CtrlTypeDic-{InputString}]</summary>
            public string Video_id { get; set; }
            
            /// <summary>����ʱ��:[CtrlTypeDic-{InputDateTime}]</summary>
            public DateTime Creatime { get; set; }
        }
        #endregion
    }
}
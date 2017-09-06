/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:57
  Description:    ���ݱ�Del_VTimuDaXueErrorInfo��Ӧ��ҵ���߼���Del_VTimuDaXueErrorInfo
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� Del_VTimuDaXueErrorInfo_Entity:Del_VTimuDaXueErrorInfo
 * 
************************************************************/
/************************************************************
SQL���룺
select ErrorSum,AnswerSum,OpenId from Del_VTimuDaXueErrorInfo
delete from Del_VTimuDaXueErrorInfo
INSERT INTO Del_VTimuDaXueErrorInfo (ErrorSum,AnswerSum,OpenId)
     VALUES
           ('','','')
UPDATE Del_VTimuDaXueErrorInfo SET ...
������ֵ���룺
 *         valObj.ErrorSum = valObj2.ErrorSum;
        valObj.AnswerSum = valObj2.AnswerSum;
        valObj.OpenId = valObj2.OpenId; 
        valObj.ErrorSum = "";
        valObj.AnswerSum = "";
        valObj.OpenId = ""; 
        "ErrorSum": $("#txt_ErrorSum").val(),
        "AnswerSum": $("#txt_AnswerSum").val(),
        "OpenId": $("#txt_OpenId").val(), 
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
    /// <para>[Inner-{St_TTimuDaXueErrorInfo:0}]</para>
    /// <para>��Del_VTimuDaXueErrorInfo���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class Del_VTimuDaXueErrorInfo : ITableImplement
    {
        /// <summary>��������  </summary>
        public static Del_VTimuDaXueErrorInfo Factory()
        {
            return new Del_VTimuDaXueErrorInfo();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _ErrorSum
        {            
            get { return this.ErrorSum; }
            set { this.ErrorSum = value; }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public int _AnswerSum
        {            
            get { return this.AnswerSum; }
            set { this.AnswerSum = value; }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int ErrorSum
        {
            get { return this.m_errorsum; }
            set //
            {
                if (!errorsum_initialized || m_errorsum != value)
                {
                    this.m_errorsum = value;
                }
                errorsum_initialized = true;
            }
        }
        
        /// <summary> ��������:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int AnswerSum
        {
            get { return this.m_answersum; }
            set //
            {
                if (!answersum_initialized || m_answersum != value)
                {
                    this.m_answersum = value;
                }
                answersum_initialized = true;
            }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ErrorSum =  new AttributeItem("[Del_VTimuDaXueErrorInfo].[ErrorSum]", typeof(int), 4, default(int));
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem AnswerSum =  new AttributeItem("[Del_VTimuDaXueErrorInfo].[AnswerSum]", typeof(int), 4, default(int));
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[Del_VTimuDaXueErrorInfo].[OpenId]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_errorsum;
        /// <summary></summary>
        protected bool errorsum_initialized = false;
        
        private int m_answersum;
        /// <summary></summary>
        protected bool answersum_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "Del_VTimuDaXueErrorInfo";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.errorsum_initialized = IsLoadAllAttributes;this.answersum_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			Del_VTimuDaXueErrorInfo value = new Del_VTimuDaXueErrorInfo();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"ErrorSum"))
				value.errorsum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"AnswerSum"))
				value.answersum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new Del_VTimuDaXueErrorInfo Clone()
        {
            return (Del_VTimuDaXueErrorInfo)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static Del_VTimuDaXueErrorInfo()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public Del_VTimuDaXueErrorInfo() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public Del_VTimuDaXueErrorInfo(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public Del_VTimuDaXueErrorInfo(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public Del_VTimuDaXueErrorInfo(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public Del_VTimuDaXueErrorInfo(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public Del_VTimuDaXueErrorInfo(int errorsum1, int answersum1, string openid1)
        {
            
            this.ErrorSum = errorsum1;
            
            this.AnswerSum = answersum1;
            
            this.OpenId = openid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static Del_VTimuDaXueErrorInfo FromIView(IView view)
        {
            return (Del_VTimuDaXueErrorInfo)IView.GetITable(view, "Del_VTimuDaXueErrorInfo");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static Del_VTimuDaXueErrorInfo GetOneInstance()
        {
            Del_VTimuDaXueErrorInfo value = new Del_VTimuDaXueErrorInfo();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public Del_VTimuDaXueErrorInfo Retrieve()
        {
            BLLTable<Del_VTimuDaXueErrorInfo>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "ErrorSum":
			        return ErrorSum;
			    			
			    case "AnswerSum":
			        return AnswerSum;
			    			
			    case "OpenId":
			        return OpenId;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "ErrorSum":
			        this.ErrorSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "AnswerSum":
			        this.AnswerSum = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
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
				case "ErrorSum":
					return errorsum_initialized;
				
				case "AnswerSum":
					return answersum_initialized;
				
				case "OpenId":
					return openid_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "ErrorSum":
					errorsum_initialized = ret;
					return true;
				
				case "AnswerSum":
					answersum_initialized = ret;
					return true;
				
				case "OpenId":
					openid_initialized = ret;
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

			
			if (errorsum_initialized)
			{
                AttributeItem attr = Del_VTimuDaXueErrorInfo.Attribute.ErrorSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ErrorSum);
                }
			}
			
			if (answersum_initialized)
			{
                AttributeItem attr = Del_VTimuDaXueErrorInfo.Attribute.AnswerSum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(AnswerSum);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = Del_VTimuDaXueErrorInfo.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
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
        public class Del_VTimuDaXueErrorInfoJson
        {
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public int ErrorSum { get; set; }
            
            /// <summary>��������:[CtrlTypeDic-{InputString}]</summary>
            public int AnswerSum { get; set; }
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
        }
        #endregion
    }
}
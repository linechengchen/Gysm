/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:25
  Description:    ���ݱ�TComUser��Ӧ��ҵ���߼���TComUser
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TComUser_Entity:TComUser
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Headimgurl,Level,NickName,PayMoney from TComUser
delete from TComUser
INSERT INTO TComUser (Id,Headimgurl,Level,NickName,PayMoney)
     VALUES
           ('','','','','')
UPDATE TComUser SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Headimgurl = valObj2.Headimgurl;
        valObj.Level = valObj2.Level;
        valObj.NickName = valObj2.NickName;
        valObj.PayMoney = valObj2.PayMoney; 
        valObj.Id = "";
        valObj.Headimgurl = "";
        valObj.Level = "";
        valObj.NickName = "";
        valObj.PayMoney = ""; 
        "Id": $("#txt_Id").val(),
        "Headimgurl": $("#txt_Headimgurl").val(),
        "Level": $("#txt_Level").val(),
        "NickName": $("#txt_NickName").val(),
        "PayMoney": $("#txt_PayMoney").val(), 
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
    /// <para>�����û���:[IDField-{Id:0}]</para>
    /// <para>��TComUser���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TComUser : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TComUser Factory()
        {
            return new TComUser();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsPrimary </summary>
        public string _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �����û�ͷ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Headimgurl
        {            
            get { return this.Headimgurl; }
            set { this.Headimgurl = value; }
        }
        
        /// <summary> �����û��ȼ�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Level
        {            
            get { return this.Level; }
            set { this.Level = value; }
        }
        
        /// <summary> �����û��ǳ�:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _NickName
        {            
            get { return this.NickName; }
            set { this.NickName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PayMoney
        {            
            get { return this.PayMoney; }
            set { this.PayMoney = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Id
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
        
        /// <summary> �����û�ͷ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> �����û��ȼ�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Level
        {
            get { return this.m_level; }
            set //
            {
                if (!level_initialized || m_level != value)
                {
                    this.m_level = value;
                }
                level_initialized = true;
            }
        }
        
        /// <summary> �����û��ǳ�:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string NickName
        {
            get { return this.m_nickname; }
            set //
            {
                if (!nickname_initialized || m_nickname != value)
                {
                    this.m_nickname = value;
                }
                nickname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PayMoney
        {
            get { return this.m_paymoney; }
            set //
            {
                if (!paymoney_initialized || m_paymoney != value)
                {
                    this.m_paymoney = value;
                }
                paymoney_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TComUser].[Id]", typeof(string), 50, default(string));
            
            /// <summary>�����û�ͷ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Headimgurl =  new AttributeItem("[TComUser].[Headimgurl]", typeof(string), 50, default(string));
            
            /// <summary>�����û��ȼ�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Level =  new AttributeItem("[TComUser].[Level]", typeof(string), 50, default(string));
            
            /// <summary>�����û��ǳ�:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem NickName =  new AttributeItem("[TComUser].[NickName]", typeof(string), 50, default(string));
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PayMoney =  new AttributeItem("[TComUser].[PayMoney]", typeof(string), 50, default(string));
        }
        #endregion
        #region bool�嵥 �������
        
        private string m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_headimgurl;
        /// <summary></summary>
        protected bool headimgurl_initialized = false;
        
        private string m_level;
        /// <summary></summary>
        protected bool level_initialized = false;
        
        private string m_nickname;
        /// <summary></summary>
        protected bool nickname_initialized = false;
        
        private string m_paymoney;
        /// <summary></summary>
        protected bool paymoney_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TComUser";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.headimgurl_initialized = IsLoadAllAttributes;this.level_initialized = IsLoadAllAttributes;this.nickname_initialized = IsLoadAllAttributes;this.paymoney_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TComUser value = new TComUser();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Headimgurl"))
				value.headimgurl_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Level"))
				value.level_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"NickName"))
				value.nickname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PayMoney"))
				value.paymoney_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TComUser Clone()
        {
            return (TComUser)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TComUser()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TComUser() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TComUser(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TComUser(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TComUser(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TComUser(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TComUser(string id1, string headimgurl1, string level1, string nickname1, string paymoney1)
        {
            
            this.Id = id1;
            
            this.Headimgurl = headimgurl1;
            
            this.Level = level1;
            
            this.NickName = nickname1;
            
            this.PayMoney = paymoney1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TComUser FromIView(IView view)
        {
            return (TComUser)IView.GetITable(view, "TComUser");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TComUser GetOneInstance()
        {
            TComUser value = new TComUser();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TComUser Retrieve()
        {
            BLLTable<TComUser>.GetRowData(this);
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
			    			
			    case "Headimgurl":
			        return Headimgurl;
			    			
			    case "Level":
			        return Level;
			    			
			    case "NickName":
			        return NickName;
			    			
			    case "PayMoney":
			        return PayMoney;
			
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
			        this.Id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Headimgurl":
			        this.Headimgurl = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Level":
			        this.Level = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "NickName":
			        this.NickName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PayMoney":
			        this.PayMoney = Convert.ToString(AttributeValue);
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
				
				case "Headimgurl":
					return headimgurl_initialized;
				
				case "Level":
					return level_initialized;
				
				case "NickName":
					return nickname_initialized;
				
				case "PayMoney":
					return paymoney_initialized;
				
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
				
				case "Headimgurl":
					headimgurl_initialized = ret;
					return true;
				
				case "Level":
					level_initialized = ret;
					return true;
				
				case "NickName":
					nickname_initialized = ret;
					return true;
				
				case "PayMoney":
					paymoney_initialized = ret;
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
                AttributeItem attr = TComUser.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (headimgurl_initialized)
			{
                AttributeItem attr = TComUser.Attribute.Headimgurl;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Headimgurl);
                }
			}
			
			if (level_initialized)
			{
                AttributeItem attr = TComUser.Attribute.Level;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Level);
                }
			}
			
			if (nickname_initialized)
			{
                AttributeItem attr = TComUser.Attribute.NickName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(NickName);
                }
			}
			
			if (paymoney_initialized)
			{
                AttributeItem attr = TComUser.Attribute.PayMoney;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PayMoney);
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
        public class TComUserJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Id { get; set; }
            
            /// <summary>�����û�ͷ��:[CtrlTypeDic-{InputString}]</summary>
            public string Headimgurl { get; set; }
            
            /// <summary>�����û��ȼ�:[CtrlTypeDic-{InputString}]</summary>
            public string Level { get; set; }
            
            /// <summary>�����û��ǳ�:[CtrlTypeDic-{InputString}]</summary>
            public string NickName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string PayMoney { get; set; }
        }
        #endregion
    }
}
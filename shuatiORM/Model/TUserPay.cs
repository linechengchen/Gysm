/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2017/5/31 17:54:26
  Description:    ���ݱ�TUserPay��Ӧ��ҵ���߼���TUserPay
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� TUserPay_Entity:TUserPay
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,OpenId,User_id,TeacherId,ClassId,ClassInfoJson,PayInt,PaySum,PayUsed from TUserPay
delete from TUserPay
INSERT INTO TUserPay (Id,OpenId,User_id,TeacherId,ClassId,ClassInfoJson,PayInt,PaySum,PayUsed)
     VALUES
           ('','','','','','','','','')
UPDATE TUserPay SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.OpenId = valObj2.OpenId;
        valObj.User_id = valObj2.User_id;
        valObj.TeacherId = valObj2.TeacherId;
        valObj.ClassId = valObj2.ClassId;
        valObj.ClassInfoJson = valObj2.ClassInfoJson;
        valObj.PayInt = valObj2.PayInt;
        valObj.PaySum = valObj2.PaySum;
        valObj.PayUsed = valObj2.PayUsed; 
        valObj.Id = "";
        valObj.OpenId = "";
        valObj.User_id = "";
        valObj.TeacherId = "";
        valObj.ClassId = "";
        valObj.ClassInfoJson = "";
        valObj.PayInt = "";
        valObj.PaySum = "";
        valObj.PayUsed = ""; 
        "Id": $("#txt_Id").val(),
        "OpenId": $("#txt_OpenId").val(),
        "User_id": $("#txt_User_id").val(),
        "TeacherId": $("#txt_TeacherId").val(),
        "ClassId": $("#txt_ClassId").val(),
        "ClassInfoJson": $("#txt_ClassInfoJson").val(),
        "PayInt": $("#txt_PayInt").val(),
        "PaySum": $("#txt_PaySum").val(),
        "PayUsed": $("#txt_PayUsed").val(), 
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
    /// <para>�û�֧��</para>
    /// <para>��TUserPay���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class TUserPay : ITableImplement
    {
        /// <summary>��������  </summary>
        public static TUserPay Factory()
        {
            return new TUserPay();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> ���֤��:[CtrlTypeDic-{InputString}] Attribute_IsPrimary_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> �û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _OpenId
        {            
            get { return this.OpenId; }
            set { this.OpenId = value; }
        }
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _User_id
        {            
            get { return this.User_id; }
            set { this.User_id = value; }
        }
        
        /// <summary> ��ʦID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _TeacherId
        {            
            get { return this.TeacherId; }
            set { this.TeacherId = value; }
        }
        
        /// <summary> ��ĿID:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _ClassId
        {            
            get { return this.ClassId; }
            set { this.ClassId = value; }
        }
        
        /// <summary> ����Ϣ��JSON:[CtrlTypeDic-{HTML}] Attribute_IsNotNull </summary>
        public string _ClassInfoJson
        {            
            get { return this.ClassInfoJson; }
            set { this.ClassInfoJson = value; }
        }
        
        /// <summary> ֧��int:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _PayInt
        {            
            get { return this.PayInt; }
            set { this.PayInt = value; }
        }
        
        /// <summary> ֧�����:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _PaySum
        {            
            get { return this.PaySum; }
            set { this.PaySum = value; }
        }
        
        /// <summary> Ҫ��:[CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public decimal _PayUsed
        {            
            get { return this.PayUsed; }
            set { this.PayUsed = value; }
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
        
        /// <summary> ������ID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
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
        
        /// <summary> ��ʦID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string TeacherId
        {
            get { return this.m_teacherid; }
            set //
            {
                if (!teacherid_initialized || m_teacherid != value)
                {
                    this.m_teacherid = value;
                }
                teacherid_initialized = true;
            }
        }
        
        /// <summary> ��ĿID:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassId
        {
            get { return this.m_classid; }
            set //
            {
                if (!classid_initialized || m_classid != value)
                {
                    this.m_classid = value;
                }
                classid_initialized = true;
            }
        }
        
        /// <summary> ����Ϣ��JSON:[CtrlTypeDic-{HTML}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string ClassInfoJson
        {
            get { return this.m_classinfojson; }
            set //
            {
                if (!classinfojson_initialized || m_classinfojson != value)
                {
                    this.m_classinfojson = value;
                }
                classinfojson_initialized = true;
            }
        }
        
        /// <summary> ֧��int:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal PayInt
        {
            get { return this.m_payint; }
            set //
            {
                if (!payint_initialized || m_payint != value)
                {
                    this.m_payint = value;
                }
                payint_initialized = true;
            }
        }
        
        /// <summary> ֧�����:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal PaySum
        {
            get { return this.m_paysum; }
            set //
            {
                if (!paysum_initialized || m_paysum != value)
                {
                    this.m_paysum = value;
                }
                paysum_initialized = true;
            }
        }
        
        /// <summary> Ҫ��:[CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public decimal PayUsed
        {
            get { return this.m_payused; }
            set //
            {
                if (!payused_initialized || m_payused != value)
                {
                    this.m_payused = value;
                }
                payused_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[TUserPay].[Id]", typeof(int), 4, default(int));
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem OpenId =  new AttributeItem("[TUserPay].[OpenId]", typeof(string), 50, default(string));
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem User_id =  new AttributeItem("[TUserPay].[User_id]", typeof(string), 50, default(string));
            
            /// <summary>��ʦID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem TeacherId =  new AttributeItem("[TUserPay].[TeacherId]", typeof(string), 50, default(string));
            
            /// <summary>��ĿID:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem ClassId =  new AttributeItem("[TUserPay].[ClassId]", typeof(string), 200, default(string));
            
            /// <summary>����Ϣ��JSON:[CtrlTypeDic-{HTML}]</summary>
            public static AttributeItem ClassInfoJson =  new AttributeItem("[TUserPay].[ClassInfoJson]", typeof(string), 2000, default(string));
            
            /// <summary>֧��int:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PayInt =  new AttributeItem("[TUserPay].[PayInt]", typeof(decimal), 18, default(decimal));
            
            /// <summary>֧�����:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PaySum =  new AttributeItem("[TUserPay].[PaySum]", typeof(decimal), 18, default(decimal));
            
            /// <summary>Ҫ��:[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PayUsed =  new AttributeItem("[TUserPay].[PayUsed]", typeof(decimal), 18, default(decimal));
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_openid;
        /// <summary></summary>
        protected bool openid_initialized = false;
        
        private string m_user_id;
        /// <summary></summary>
        protected bool user_id_initialized = false;
        
        private string m_teacherid;
        /// <summary></summary>
        protected bool teacherid_initialized = false;
        
        private string m_classid;
        /// <summary></summary>
        protected bool classid_initialized = false;
        
        private string m_classinfojson;
        /// <summary></summary>
        protected bool classinfojson_initialized = false;
        
        private decimal m_payint;
        /// <summary></summary>
        protected bool payint_initialized = false;
        
        private decimal m_paysum;
        /// <summary></summary>
        protected bool paysum_initialized = false;
        
        private decimal m_payused;
        /// <summary></summary>
        protected bool payused_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "TUserPay";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.openid_initialized = IsLoadAllAttributes;this.user_id_initialized = IsLoadAllAttributes;this.teacherid_initialized = IsLoadAllAttributes;this.classid_initialized = IsLoadAllAttributes;this.classinfojson_initialized = IsLoadAllAttributes;this.payint_initialized = IsLoadAllAttributes;this.paysum_initialized = IsLoadAllAttributes;this.payused_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITableImplement af_GetOptionValueSchema()
		{ 
			TUserPay value = new TUserPay();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"OpenId"))
				value.openid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"User_id"))
				value.user_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"TeacherId"))
				value.teacherid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassId"))
				value.classid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"ClassInfoJson"))
				value.classinfojson_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PayInt"))
				value.payint_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PaySum"))
				value.paysum_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PayUsed"))
				value.payused_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new TUserPay Clone()
        {
            return (TUserPay)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static TUserPay()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public TUserPay() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public TUserPay(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public TUserPay(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public TUserPay(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public TUserPay(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public TUserPay(int id1, string openid1, string user_id1, string teacherid1, string classid1, string classinfojson1, decimal payint1, decimal paysum1, decimal payused1)
        {
            
            this.Id = id1;
            
            this.OpenId = openid1;
            
            this.User_id = user_id1;
            
            this.TeacherId = teacherid1;
            
            this.ClassId = classid1;
            
            this.ClassInfoJson = classinfojson1;
            
            this.PayInt = payint1;
            
            this.PaySum = paysum1;
            
            this.PayUsed = payused1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static TUserPay FromIView(IView view)
        {
            return (TUserPay)IView.GetITable(view, "TUserPay");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static TUserPay GetOneInstance()
        {
            TUserPay value = new TUserPay();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public TUserPay Retrieve()
        {
            BLLTable<TUserPay>.GetRowData(this);
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
			    			
			    case "OpenId":
			        return OpenId;
			    			
			    case "User_id":
			        return User_id;
			    			
			    case "TeacherId":
			        return TeacherId;
			    			
			    case "ClassId":
			        return ClassId;
			    			
			    case "ClassInfoJson":
			        return ClassInfoJson;
			    			
			    case "PayInt":
			        return PayInt;
			    			
			    case "PaySum":
			        return PaySum;
			    			
			    case "PayUsed":
			        return PayUsed;
			
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
			    			
			    case "OpenId":
			        this.OpenId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "User_id":
			        this.User_id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "TeacherId":
			        this.TeacherId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassId":
			        this.ClassId = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "ClassInfoJson":
			        this.ClassInfoJson = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PayInt":
			        this.PayInt = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "PaySum":
			        this.PaySum = Convert.ToDecimal(AttributeValue);
                    return true;
			    			
			    case "PayUsed":
			        this.PayUsed = Convert.ToDecimal(AttributeValue);
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
				
				case "OpenId":
					return openid_initialized;
				
				case "User_id":
					return user_id_initialized;
				
				case "TeacherId":
					return teacherid_initialized;
				
				case "ClassId":
					return classid_initialized;
				
				case "ClassInfoJson":
					return classinfojson_initialized;
				
				case "PayInt":
					return payint_initialized;
				
				case "PaySum":
					return paysum_initialized;
				
				case "PayUsed":
					return payused_initialized;
				
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
				
				case "OpenId":
					openid_initialized = ret;
					return true;
				
				case "User_id":
					user_id_initialized = ret;
					return true;
				
				case "TeacherId":
					teacherid_initialized = ret;
					return true;
				
				case "ClassId":
					classid_initialized = ret;
					return true;
				
				case "ClassInfoJson":
					classinfojson_initialized = ret;
					return true;
				
				case "PayInt":
					payint_initialized = ret;
					return true;
				
				case "PaySum":
					paysum_initialized = ret;
					return true;
				
				case "PayUsed":
					payused_initialized = ret;
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
                AttributeItem attr = TUserPay.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (openid_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.OpenId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(OpenId);
                }
			}
			
			if (user_id_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.User_id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(User_id);
                }
			}
			
			if (teacherid_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.TeacherId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(TeacherId);
                }
			}
			
			if (classid_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.ClassId;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassId);
                }
			}
			
			if (classinfojson_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.ClassInfoJson;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(ClassInfoJson);
                }
			}
			
			if (payint_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.PayInt;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PayInt);
                }
			}
			
			if (paysum_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.PaySum;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PaySum);
                }
			}
			
			if (payused_initialized)
			{
                AttributeItem attr = TUserPay.Attribute.PayUsed;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PayUsed);
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
        public class TUserPayJson
        {
            
            /// <summary>���֤��:[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>�û��ı�ʶ���Ե�ǰ���ں�Ψһ:[CtrlTypeDic-{InputString}]</summary>
            public string OpenId { get; set; }
            
            /// <summary>������ID:[CtrlTypeDic-{InputString}]</summary>
            public string User_id { get; set; }
            
            /// <summary>��ʦID:[CtrlTypeDic-{InputString}]</summary>
            public string TeacherId { get; set; }
            
            /// <summary>��ĿID:[CtrlTypeDic-{InputString}]</summary>
            public string ClassId { get; set; }
            
            /// <summary>����Ϣ��JSON:[CtrlTypeDic-{HTML}]</summary>
            public string ClassInfoJson { get; set; }
            
            /// <summary>֧��int:[CtrlTypeDic-{InputString}]</summary>
            public decimal PayInt { get; set; }
            
            /// <summary>֧�����:[CtrlTypeDic-{InputString}]</summary>
            public decimal PaySum { get; set; }
            
            /// <summary>Ҫ��:[CtrlTypeDic-{InputString}]</summary>
            public decimal PayUsed { get; set; }
        }
        #endregion
    }
}
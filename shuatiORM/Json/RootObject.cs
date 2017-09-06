using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using AgileFrame.Orm.PersistenceLayer.DAL.Base;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
using System.Text;
using System.Web;
//using AgileFrame.Orm.PersistenceLayer.Model;

namespace AgileFrame.Orm.PersistenceLayer.Model
{
    /// <summary>
    /// �����������
    /// </summary>
    public class JsonRoot : RootObject
    {
    }
    /// <summary>
    /// �����������
    /// </summary>
    public partial class RootObject
    {
        public static string kongzhiStr = "/\u0000|\u0001|\u0002|\u0003|\u0004|\u0005|\u0006|\u0007|\u0008|\u0009|\u000a|\u000b|\u000c|\u000d|\u000e|\u000f|\u0010|\u0011|\u0012|\u0013|\u0014|\u0015|\u0016|\u0017|\u0018|\u0019|\u001a|\u001b|\u001c|\u001d|\u001e|\u001f/g,";
        //public static string kongzhiStr = "/\u0000|\u0001|\u0002|\u0003|\u0004|\u0005|\u0006|\u0007/g,";

        public static System.Text.RegularExpressions.Regex regObj1 = new System.Text.RegularExpressions.Regex(kongzhiStr, System.Text.RegularExpressions.RegexOptions.Multiline);

        /// <summary>
        /// �Ӹ���ͨ�������� �ҳ��ӱ��¼��
        /// </summary>
        /// <typeparam name="MyTable">����</typeparam>
        /// <typeparam name="subMyTable">�ӱ�</typeparam>
        /// <param name="tzslist">�Ѿ��ҳ��ĸ����������</param>
        /// <param name="value">�ӱ�ȡֵ����</param>
        /// <param name="cond1"></param>
        /// <param name="ZsId"></param>
        /// <param name="subZsId"></param>
        /// <returns></returns>
        public static List<subMyTable> Select<MyTable, subMyTable>(List<MyTable> tzslist, subMyTable value, subMyTable cond1, AttributeItem ZsId, AttributeItem subZsId)
            where MyTable : ITableImplement, new()
            where subMyTable : ITableImplement, new()
        {
            List<subMyTable> tkmlist2 = new List<subMyTable>();
            subMyTable condkemu2 = new subMyTable();
            List<string> ids = new List<string>();
            foreach (MyTable t1 in tzslist)
            {
                ids.Add(t1.GetString(ZsId));
            }
            condkemu2.In(subZsId, ids.ToArray());
            tkmlist2 = BLLTable<subMyTable>.Select(value, null, null, new subMyTable[] { condkemu2, cond1 });
            return tkmlist2;
        }
        //public RootObject Add(List<St_TzsTypeInfo> zsTypeList, List<MyTable> zsList, AttributeItem relationAttr1, AttributeItem relationAttr2)
        //{
        //    return Add(zsTypeList, zsList, relationAttr1, relationAttr2);
        //}
        /// <summary>
        /// json�ĸ��ӹ�ϵ����
        /// </summary>
        /// <typeparam name="MyTable"></typeparam>
        /// <typeparam name="subMyTable"></typeparam>
        /// <param name="infoList"></param>
        /// <param name="subInfoList"></param>
        /// <param name="relationAttr"></param>
        /// <param name="subRelationAttr"></param>
        /// <returns></returns>
        public RootObject Add<MyTable, subMyTable>(List<MyTable> infoList, List<subMyTable> subInfoList,
            AttributeItem relationAttr, AttributeItem subRelationAttr)
            where MyTable : ITableImplement, new()
            where subMyTable : ITableImplement, new()
        {
            Dictionary<string, List<subMyTable>> dic1 = new Dictionary<string, List<subMyTable>>();
            if (subInfoList != null && subRelationAttr != null)
            {
                foreach (subMyTable zs1 in subInfoList)
                {
                    string key1 = zs1.GetString(subRelationAttr);
                    if (!dic1.ContainsKey(key1))
                        dic1.Add(key1, new List<subMyTable>() { zs1 });
                    else
                        dic1[key1].Add(zs1);
                }
            }
            if (subRelationAttr != null)
            {
                bool isChecked = false;
                foreach (MyTable zsType1 in infoList)
                {
                    string key1 = zsType1.GetString(relationAttr);
                    if (!isChecked)
                    {
                        if (relationAttr.TableName.ToLower() != zsType1.TableName().ToLower())
                            throw new Exception("RootObject Add �����������");
                        isChecked = true;
                    }
                    isChecked = true;
                    List<subMyTable> zsList1;
                    if (dic1.TryGetValue(key1, out zsList1))
                    {
                        string json1 = new JsonService(isDebug).ToJson(zsList1);
                        zsType1.af_JsonAppend("\"list\":" + json1);// + ","
                        //string js1 = zsType1.ToJson();
                    }
                }
            }
            this.data.Add(infoList);
            return this;
        }
    }
    /// <summary>
    /// set��add������Ϊdata�ڵ���������ݱ���
    /// </summary>
    public partial class RootObject
    {
        public static void ReGetFrame(string table_name)
        {
            if (JsonData.dicFrameing.ContainsKey(table_name))
                JsonData.dicFrameing.Remove(table_name);
            if (JsonData.dicTables.ContainsKey(table_name))
                JsonData.dicTables.Remove(table_name);
            if (JsonData.dicFields.ContainsKey(table_name))
                JsonData.dicFields.Remove(table_name);
            if (JsonData.dicEnums.ContainsKey(table_name))
                JsonData.dicEnums.Remove(table_name);
            if (JsonData.dicFieldsPos.ContainsKey(table_name))
                JsonData.dicFieldsPos.Remove(table_name);
            if (JsonData.dicEnumsPos.ContainsKey(table_name))
                JsonData.dicEnumsPos.Remove(table_name);
            JsonData.GetFrame(table_name);
        }
    }
    /// <summary>
    /// set��add������Ϊdata�ڵ���������ݱ���
    /// </summary>
    public partial class RootObject
    {
        //����list����һ��json�ṹ
        public bool isShuati = false;
        public bool isTest = false;
        public bool RefreshZh = false;
        public bool isZh = true;

        public StringBuilder config_tb = new StringBuilder(256);
        public StringBuilder config_show = new StringBuilder(256);
        //public StringBuilder config_sort = new StringBuilder(256);
        public bool success = false;
        public int code { get; set; }
        public string error { get; set; }//ö��ֵ
        public string msg { get; set; }
        public string message { get; set; }
        public int resultCode { get; set; }
        //cch����
        public string errMsg { get; set; }
        public string userKey { get; set; }


        public RootObject(bool isDebug)
            : this(default(int), default(string), isDebug)
        {
        }
        public RootObject()
            : this(default(int), default(string), false)
        {
        }
        public RootObject(int code, string msg)
            : this(code, msg, false)
        {
        }
        public RootObject(int code, string msg, bool isDebug)
        {
            topDic1 = new AFDictionary<string, string>();
            topDic2 = new AFDictionary<string, string>();
            this.code = code;
            this.msg = msg;
            this.isDebug = isDebug;
            datalist1 = new List<JsonData>();
        }
        public bool isLower = false;
        public bool isHeadLower = false;
        public RootObject Add<MyTable>(MyTable MyTable1) where MyTable : ITableImplement, new()
        {
            data.Add(MyTable1, "");
            return this;
        }
        [Obsolete]
        public RootObject Add<MyTable>(MyTable MyTable1, string tableName) where MyTable : ITableImplement, new()
        {
            data.Add(MyTable1, tableName);
            return this;
        }
        //[Obsolete]
        //public RootObject Add<MyTable>(List<MyTable> MyTableList, string tablelistName) where MyTable : ITableImplement, new()
        //{
        //    return Add(MyTableList, tablelistName, -1, -1);
        //}
        [Obsolete]
        public RootObject Add<MyTable>(List<MyTable> MyTableList, string tablelistName, int pageIndex, int totalCount) where MyTable : ITableImplement, new()
        {
            data.Add(tablelistName, MyTableList, 10, pageIndex, totalCount);
            return this;
        }
        //[Obsolete]
        //public RootObject Add<MyTable>(List<MyTable> MyTableList) where MyTable : ITableImplement, new()
        //{
        //    return Add(MyTableList, null);
        //}

        #region ���ݲ�������-��dataҲ������

        public bool isDebug { get; set; }
        public AFDictionary<string, string> dic1 { get; set; }
        public AFDictionary<string, string> dic2 { get; set; }

        public RootObject Add(string key1, int value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public RootObject Add(string key1, double value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public RootObject Add(string key1, float value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public RootObject Add(string key1, decimal value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public RootObject Add(string key1, bool value1)
        {
            if (value1)
                return Add2(key1, "true");
            else
                return Add2(key1, "false");
        }
        public RootObject Add2(string key1, string value1)
        {
            if (dic2 == null) dic2 = new AFDictionary<string, string>();
            if (!dic2.ContainsKey(key1))
                dic2.Add(key1, Convert.ToString(value1));
            else
                dic2[key1] = Convert.ToString(value1);
            return this;
        }

        List<JsonData> datalist1 = null;
        public JsonData data
        {
            get
            {
                initDataList();
                JsonData data1 = new JsonData(isDebug, isZh, this);
                datalist1.Add(data1);
                return data1;
            }
        }
        public void initDataList()
        {
            if (datalist1 == null)
                datalist1 = new List<JsonData>();
        }
        public AFDictionary<string, string> topDic1 { get; set; }
        public AFDictionary<string, string> topDic2 { get; set; }
        public void Add(ITableImplement table, string tableName)
        {
            this.data.Add(tableName, table);
        }
        public void Add(string tableName, ITableImplement table)
        {
            this.data.Add(table, tableName);
        }
        public void Add(ITableImplement table)
        {
            this.data.Add(table);// table = table;
        }
        public void Add<MyTable>(List<MyTable> tablelist) where MyTable : ITableImplement, new()
        {
            this.data.Add(tablelist);
        }
        public void Add<MyTable>(List<MyTable> tablelist, string tablelistName) where MyTable : ITableImplement, new()
        {
            this.data.Add(tablelistName, tablelist);
        }
        public void Add<MyTable>(string tablelistName, List<MyTable> tablelist) where MyTable : ITableImplement, new()
        {
            this.data.Add(tablelistName, tablelist);
        }
        public void AddTop(string key1, string value)
        {
            if (!topDic1.ContainsKey(key1))
                topDic1.Add(key1, value);
            else
                topDic1[key1] = value;
        }
        public void AddTop(string key1, int value)
        {
            if (!topDic2.ContainsKey(key1))
                topDic2.Add(key1, value.ToString());
            else
                topDic2[key1] = value.ToString();
        }
        public void AddTop(string key1, bool value)
        {
            if (!topDic2.ContainsKey(key1))
                topDic2.Add(key1, value.ToString());
            else
                topDic2[key1] = value.ToString();
        }
        #endregion ���ݲ�������-��dataҲ������

        public string ToJsonLower()
        {
            isLower = true;
            return ToJson(false);
        }
        bool isJiami = false;
        public string ToJsonHeadLower(bool isJiami)
        {
            this.isJiami = isJiami;
            isHeadLower = true;
            return ToJson(false);
        }
        public string ToJsonHeadLower()
        {
            isHeadLower = true;
            return ToJson(false);
        }
        public string ToJson()
        {
            return ToJson(false);
        }

        public string ToJson(bool isJiami)
        {
            string json1 = "";
            this.isJiami = isJiami;

            try
            {
                #region 2data����
                JsonService jsobj = new JsonService(isDebug);

                jsobj.isHeadLower = isHeadLower;
                jsobj.isLower = isLower;

                if (isTest) return "";
                StringBuilder sbData = new StringBuilder(256);
                if (datalist1 != null && datalist1.Count > 0)
                {
                    StringBuilder sb2 = new StringBuilder(256);
                    foreach (JsonData data2 in datalist1)
                    {
                        string json5 = data2.ToJson(false, isShuati, isHeadLower, isLower);
                        if (string.IsNullOrEmpty(json5)) continue;
                        sb2.Append(json5);//.Append(",");
                    }
                    if (sb2.Length > 0)
                        sbData.Append(sb2);
                }

                if (dic1 != null && dic1.Count > 0)
                {
                    foreach (string key1 in dic1.Keys)
                    {
                        string value1 = dic1[key1];
                        sbData.Append("\"").Append(key1).Append("\":").Append("\"").Append(JsonService.filterJson(value1)).Append("\"");
                        sbData.Append(",");
                    }
                }
                if (dic2 != null && dic2.Count > 0)
                {
                    foreach (string key1 in dic2.Keys)
                    {
                        string value1 = dic2[key1];
                        sbData.Append("\"").Append(key1).Append("\":").Append(JsonService.filterJson(value1));
                        sbData.Append(",");
                    }
                }
                #endregion data����-��dataҲ������

                if (sbData.Length > 1)
                {
                    if (code == 0)
                        code = 200;
                    if (string.IsNullOrEmpty(msg))
                        msg = "�����ɹ�";
                    if (string.IsNullOrEmpty(message))
                        message = "success";
                }
                else
                {
                    //code = 500;
                    //msg = "δ���ڴ˼�¼";
                }
                if (resultCode == 0) resultCode = code;
                if (string.IsNullOrEmpty(message)) message = msg;

                StringBuilder sb1 = new StringBuilder("{");
                if (success)
                {
                    code = 200; resultCode = 200;
                }
                //qts
                if (success || code == 200 || resultCode == 200)
                    sb1.Append("\"success\":true,");
                else
                    sb1.Append("\"success\":false,");

                sb1.Append("\"code\":").Append(code).Append("").Append(",")

                    .Append("\"resultCode\":").Append(resultCode).Append("").Append(",")
                    .Append("\"message\":\"").Append(message).Append("\"").Append(",")
                    .Append("\"errMsg\":\"").Append(errMsg).Append("\"").Append(",")
                    .Append("\"error\":\"").Append(error).Append("\"").Append(",")

                    .Append("\"msg\":\"").Append(msg).Append("\"").Append(",")
                    .Append("\"userKey\":\"").Append(userKey).Append("\"").Append(",");

                bool hasData = false;
                if (topDic1.Count > 0)
                {
                    foreach (string key1 in topDic1.Keys)
                    {
                        sb1.Append("\"").Append(key1).Append("\":\"").Append(topDic1[key1]).Append("\"").Append(",");
                        if (key1 == "data")
                            hasData = true;
                    }
                }
                if (topDic2.Count > 0)
                {
                    foreach (string key1 in topDic2.Keys)
                    {
                        sb1.Append("\"").Append(key1).Append("\":").Append(topDic2[key1]).Append(",");
                        if (key1 == "data")
                            hasData = true;
                    }
                }
                if (config_show.Length > 4)
                {
                    config_show.Remove(config_show.Length - 1, 1);
                    sbData.Append("\"config_show\":[").Append(config_show.ToString()).Append("]");
                    sbData.Append(",");
                }
                if (config_tb.Length > 4)
                {
                    config_tb.Remove(config_tb.Length - 1, 1);
                    sbData.Append("\"config_tb\":[").Append(config_tb.ToString()).Append("]");
                    sbData.Append(",");
                }
                //if (config_sort.Length > 4)
                //{
                //    config_sort.Remove(config_sort.Length - 1, 1);
                //    sbData.Append("\"config_sort\":[").Append(config_sort.ToString()).Append("]");
                //    sbData.Append(",");
                //}
                if (!hasData)//����Ѿ�������dataԪ�أ������治�ظ�
                {
                    sb1.Append("\"data\":");

                    if (!sbData.ToString().StartsWith("["))
                    {
                        sb1.Append("{");
                    }

                    sb1.Append(sbData.ToString().TrimEnd(','));

                    if (!sbData.ToString().StartsWith("["))
                    {
                        sb1.Append("}");
                    }
                }

                if (sb1[sb1.Length - 1] == ',')
                    sb1.Remove(sb1.Length - 1, 1);

                json1 = sb1.Append("}").ToString();
                json1 = filterKongZhi(json1).Trim();

                if (!string.IsNullOrEmpty(json1) && !string.IsNullOrEmpty(json1.Trim()))
                {
                    if (this.isJiami)
                    {
                        HttpContext.Current.Response.ContentType = "text/html";//; charset=utf-8
                        HttpContext.Current.Response.Charset = "utf-8";
                        //string json2 = escape(json1);
                        //json2 = Jiami(json2);
                        string json2 = KaiSa.Encrypt(json1);
                        return json2;
                    }
                    else
                    {
                        HttpContext.Current.Response.ContentType = "application/json";//; charset=utf-8
                        HttpContext.Current.Response.Charset = "utf-8";
                    }
                }
            }
            catch (Exception ex1)
            {
                Cs.Error(ex1.ToString());
                return ex1.ToString();
            }
            return json1;
        }

        #region ���ܺ���
        public static string Jiami(string data)
        {
            string json2 = "";

            //json2 = AESHelper.AESEncrypt(JsonData);

            if (!string.IsNullOrEmpty(data))
                json2 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(data));
            if (json2.Length > 8)
            {
                string s1 = "zMDY1JXUwMDczJXUwMDc1JXU";//getSourceId();
                json2 = json2.Insert(8, s1);
            }
            return json2;
        }

        //��C#��̨ʵ��JavaScript�ĺ���escape()���ַ���ת��  
        //Щ����֧�ֺ���  
        public static string escape(string s)
        {
            StringBuilder sb = new StringBuilder(256);
            byte[] byteArr = System.Text.Encoding.Unicode.GetBytes(s);

            for (int i = 0; i < byteArr.Length; i += 2)
            {
                sb.Append("%u");
                sb.Append(byteArr[i + 1].ToString("X2"));//���ֽ�ת��Ϊʮ�����Ƶ��ַ���������ʽ  

                sb.Append(byteArr[i].ToString("X2"));
            }
            return sb.ToString();

        }
        //��JavaScript��escape()ת����ȥ���ַ������ͻ���  
        //Щ����֧�ֺ���  
        public static string unescape(string s)
        {

            string str = s.Remove(0, 2);//ɾ����ǰ��������%u��  
            string[] strArr = str.Split(new string[] { "%u" }, StringSplitOptions.None);//�����ַ�����%u���ָ�  
            byte[] byteArr = new byte[strArr.Length * 2];
            for (int i = 0, j = 0; i < strArr.Length; i++, j += 2)
            {
                byteArr[j + 1] = Convert.ToByte(strArr[i].Substring(0, 2), 16);  //��ʮ��������ʽ���ִ�����ת��Ϊ�������ֽ�  
                byteArr[j] = Convert.ToByte(strArr[i].Substring(2, 2), 16);
            }
            str = System.Text.Encoding.Unicode.GetString(byteArr);��//���ֽ�תΪunicode����  
            return str;
        }
        #endregion ���ܺ���

        IdWorker id1 = new IdWorker(0, 0);
        protected string getSourceId()
        {
            return CRC.getCrcWithString(id1.nextIdUnique().ToString());
        }
        public static string filterKongZhi(string json1)
        {
            json1 = regObj1.Replace(json1, "");
            return json1;
        }
    }
}
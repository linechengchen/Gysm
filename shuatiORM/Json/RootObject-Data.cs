using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using AgileFrame.Orm.PersistenceLayer.DAL.Base;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
//using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
using System.Text;

namespace AgileFrame.Orm.PersistenceLayer.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonData
    {
        public static string ToJson(List<int> upload_pic_list)
        {
            StringBuilder sb = new StringBuilder(128);
            sb.Append("{");
            bool exist = false;
            for (int i = 0; i < upload_pic_list.Count; i++)
            {
                //if (!string.IsNullOrEmpty(upload_pic_list[i]))
                {
                    exist = true;
                    sb.Append(upload_pic_list[i]).Append(",");
                }
            }
            if (exist)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            sb.Append("}");
            return sb.ToString();
        }
        public static string ToJson(List<string> upload_pic_list)
        {
            StringBuilder sb = new StringBuilder(128);
            sb.Append("{");
            bool exist = false;
            for (int i = 0; i < upload_pic_list.Count; i++)
            {
                if (!string.IsNullOrEmpty(upload_pic_list[i]))
                {
                    exist = true;
                    sb.Append("\"").Append(upload_pic_list[i]).Append("\",");
                }
            }
            if (exist)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            sb.Append("}");
            return sb.ToString();
        }
        RootObject r1;
        public JsonData(bool isDebug, bool isZh, RootObject r1)
        {
            this.r1 = r1;
            this.isDebug = isDebug;
            this.isZh = isZh;
            dic1 = new AFDictionary<string, string>();
            tablelist = new List<ITableImplement>();
        }

        #region 1数据操作代码-子data也可以有
        public int[] linkPageNumbers = new int[] { 1 };// { get; set; }
        public int pageNum = -1;// { get; set; }
        public int pageSize = -1;// { get; set; }
        public int totalCount = -1;// { get; set; }
        public int totalPageNum = -1;// { get; set; }

        public bool isDebug = false;
        public bool isZh = false;

        //public AFDictionary<string, int> dicJson1 { get; set; }
        public AFDictionary<string, string> dic1 { get; set; }
        public AFDictionary<string, string> dic2 { get; set; }

        //字段 和 字段小写名
        public AFDictionary<AttributeItem, string> dic_enum { get; set; }

        public ITableImplement table { get; set; }
        public List<ITableImplement> tablelist { get; set; }

        public string tableName;
        public string tablelistName = null;
        public List<JsonData> datalist1 { get; set; }//数组对象内嵌套
        public JsonData subData
        {
            get
            {
                initDataList();
                JsonData data1 = new JsonData(isDebug, isZh, r1);
                datalist1.Add(data1);
                return data1;
            }
        }
        //public AFDictionary<string, string> topDic1 { get; set; }

        public JsonData Add(ITableImplement table, string tableName)
        {
            return Add(tableName, table);
        }
        public JsonData Add(string tableName, ITableImplement table)
        {
            this.tableName = tableName;
            this.table = table;
            return this;
        }
        public static DateTime dt1 = DateTime.MinValue;
        public static Dictionary<string, bool> dicFrameing = new Dictionary<string, bool>();
        public static Dictionary<string, Frame_TableConfig> dicTables = new Dictionary<string, Frame_TableConfig>();
        public static Dictionary<string, SortedDictionary<string, Frame_FieldConfig>> dicFields = new Dictionary<string, SortedDictionary<string, Frame_FieldConfig>>();
        public static Dictionary<string, SortedDictionary<string, Frame_EnumConfig>> dicEnums = new Dictionary<string, SortedDictionary<string, Frame_EnumConfig>>();
        public static Dictionary<string, SortedDictionary<int, string>> dicFieldsPos = new Dictionary<string, SortedDictionary<int, string>>();
        public static Dictionary<string, SortedDictionary<int, string>> dicEnumsPos = new Dictionary<string, SortedDictionary<int, string>>();

        public static void GetFrame(string table_name)
        {
            //string key1 = f1.Table_name + "-" + f1.Fname;
            if (!dicFrameing.ContainsKey(table_name))
            {
                dicFrameing.Add(table_name, true);
                if (!dicTables.ContainsKey(table_name))
                {
                    Frame_TableConfig table1 = BLLTable<Frame_TableConfig>.GetRowData(Frame_TableConfig.Attribute.Table_name, table_name);
                    if (table1 != null)
                    {
                        Frame_FieldConfig f_cond1 = new Frame_FieldConfig();
                        f_cond1.Table_name = table_name;
                        List<Frame_FieldConfig> list1 = BLLTable<Frame_FieldConfig>.Select(new Frame_FieldConfig(), f_cond1);
                        int pos1 = list1.Count + 1;
                        foreach (Frame_FieldConfig f1 in list1)
                        {
                            if (!dicFields.ContainsKey(table_name))
                                dicFields.Add(table_name, new SortedDictionary<string, Frame_FieldConfig>());
                            if (!dicFields[table_name].ContainsKey(f1.Fname))
                            {
                                dicFields[table_name].Add(f1.Fname, f1);
                            }
                            if (f1.Position < 1)
                            {
                                pos1++;
                                f1.Position = pos1;
                            }
                            if (!dicFieldsPos.ContainsKey(table_name))
                                dicFieldsPos.Add(table_name, new SortedDictionary<int, string>());
                            if (!dicFieldsPos[table_name].ContainsKey(f1.Position))
                            {
                                dicFieldsPos[table_name].Add(f1.Position, f1.Fname);
                            }
                        }
                        Frame_EnumConfig e_cond1 = new Frame_EnumConfig();
                        e_cond1.Table_name = table_name;
                        List<Frame_EnumConfig> list2 = BLLTable<Frame_EnumConfig>.Select(new Frame_EnumConfig(), e_cond1);
                        int pos2 = 1;
                        foreach (Frame_EnumConfig f1 in list2)
                        {
                            string enumKey = table_name + "_" + f1.Fname;
                            if (!dicEnums.ContainsKey(enumKey))
                                dicEnums.Add(enumKey, new SortedDictionary<string, Frame_EnumConfig>());
                            if (!dicEnums[enumKey].ContainsKey(f1.Key))
                            {
                                dicEnums[enumKey].Add(f1.Key, f1);
                            }
                            if (f1.Position < 1)
                            {
                                pos2++;
                                f1.Position = pos2;
                            }
                            if (!dicEnumsPos.ContainsKey(enumKey))
                                dicEnumsPos.Add(enumKey, new SortedDictionary<int, string>());
                            if (!dicEnumsPos[enumKey].ContainsKey(f1.Position))
                            {
                                dicEnumsPos[enumKey].Add(f1.Position, f1.Key);
                            }
                        }
                    }
                }
            }
        }
        public int fieldSeq = 0;
        public JsonData AddConfigShow(ITableImplement val_list, string show_fields, string list_fields)
        {
            ITableImplement val_show = val_list.Clone();
            foreach (AttributeItem attr1 in val_list.af_AttributeItemList)
            {
                if (show_fields.Contains(attr1.FieldName))
                    val_show.SetInitialized(attr1, true);

                if (list_fields.Contains(attr1.FieldName))
                    val_list.SetInitialized(attr1, true);
            }
            return this;
        }
        public JsonData AddConfigShow(string Table_name1)
        {
            string Table_name = Table_name1.Trim();
            Dictionary<string, bool> dic1 = new Dictionary<string, bool>();
            if (Table_name1.Contains("(") && Table_name1.Contains(")"))
            {
                if (Table_name1.Contains("[") && Table_name1.Contains("]"))
                {
                    Table_name = StringHelper.CutString(Table_name1, "[", "]");
                }
                string Table_name2 = StringHelper.CutString(Table_name1, "(", ")");
                string[] Table_name3 = Table_name2.Split(',');
                foreach (string Table_name4 in Table_name3)
                {
                    if (!string.IsNullOrEmpty(Table_name4) && Table_name4.Trim().Length > 1)
                    {
                        string Table_name5 = Table_name4.Trim();
                        if (!dic1.ContainsKey(Table_name5))
                        {
                            dic1.Add(Table_name5, true);
                        }
                    }
                }
                if (dic1.Count == 0)
                    throw new Exception("AddConfigShow字段输入格式不正确，正确写法是 [Xb_teacher_resume] (Uuid,User_id)");
            }
            GetFrame(Table_name);
            //增加枚举量
            JsonService js = new JsonService();
            js.isHeadLower = true;
            Frame_TableConfig table1 = BLLTable<Frame_TableConfig>.GetRowData(Frame_TableConfig.Attribute.Table_name, Table_name);
            if (table1 != null)
            {
                r1.config_tb.Append("{");               
                string js2 = js.ToJsonKeyValue<Frame_TableConfig>(table1, 10000);
                r1.config_tb.Append(js2);
                r1.config_tb.Append("},");
                SortedDictionary<string, Frame_FieldConfig> confgDic2 = null;
                bool pos2 = dicFields.TryGetValue(Table_name, out confgDic2);
                SortedDictionary<int, string> confgPosDic1 = null;
                if (pos2 && dicFieldsPos.TryGetValue(Table_name, out confgPosDic1))
                {
                    foreach (string fieldName in confgPosDic1.Values)
                    {
                        if (dic1.Count > 0 && !dic1.ContainsKey(fieldName))
                            continue;
                        Frame_FieldConfig confg1 = null;
                        if (confgDic2.TryGetValue(fieldName, out confg1))
                        {
                            if (fieldName == "Ctrl")
                            {
                            }
                            r1.config_show.Append("{");
                            string js1 = js.ToJsonKeyValue<Frame_FieldConfig>(confg1, 10000);
                            if (string.IsNullOrEmpty(js1))
                            {
                                r1.config_show.Remove(r1.config_show.Length - 1, 1);
                            }
                            else
                            {
                                //加载enum枚举量               
                                SortedDictionary<string, Frame_EnumConfig> confgDic3 = null;
                                bool pos3 = dicEnums.TryGetValue(Table_name + "_" + fieldName, out confgDic3);
                                SortedDictionary<int, string> confgPosDic3 = null;
                                bool isJsonTrue3 = false;
                                StringBuilder enumStr = null;
                                //取得多选项的 位置，和对应的key
                                if (pos3 && dicEnumsPos.TryGetValue(Table_name + "_" + fieldName, out confgPosDic3))
                                {
                                    if (confgPosDic3.Count > 0)
                                    {
                                        enumStr = new StringBuilder(256);
                                        foreach (string key in confgPosDic3.Values)
                                        {
                                            Frame_EnumConfig config3 = null;
                                            if (confgDic3.TryGetValue(key, out config3))
                                            {
                                                string js3 = js.ToJsonKeyValue<Frame_EnumConfig>(config3, 10000);
                                                if (!string.IsNullOrEmpty(js3))
                                                {
                                                    isJsonTrue3 = true;
                                                    enumStr.Append("{");
                                                    enumStr.Append(js3);
                                                    enumStr.Append("},");
                                                }
                                            }
                                        }
                                        if (isJsonTrue3)
                                            enumStr.Remove(enumStr.Length - 1, 1);
                                    }
                                }
                                if (isJsonTrue3)
                                {
                                    r1.config_show.Append("\"enum_array\":[");
                                    r1.config_show.Append(enumStr);
                                    r1.config_show.Append("],");
                                }
                                r1.config_show.Append(js1);
                                r1.config_show.Append("},");
                            }
                        }
                    }
                }
            }
            return this;
        }
        public JsonData AddConfigShow(AttributeItem attr)
        {
            r1.config_show.Append("{");
            //SortedDictionary<string, Frame_FieldConfig> confgDic1 = null;
            //if (dicFields.TryGetValue(attr.TableName, out confgDic1))
            //{
            //    foreach (Frame_FieldConfig confg1 in confgDic1.Values)
            //    {
            //        JsonService js = new JsonService();
            //        string js1 = js.ToJsonKeyValue<Frame_FieldConfig>(confg1, 10000);
            //        if (string.IsNullOrEmpty(js1))
            //            js1 = ",";
            //        r1.config_show.Append(js1);
            //    }
            //}
            //else
            {
                string fieldname = attr.FieldName;//
                r1.config_show.Append("\"fname\":\"").Append(fieldname).Append("\",");
                r1.config_show.Append("\"Pos\":").Append(Convert.ToString(attr.Desc.af_Pos).ToLower()).Append(",");
                if (attr.Desc.af_ListPos != "列表位置")
                    r1.config_show.Append("\"ListPos\":").Append(Convert.ToString(attr.Desc.af_ListPos).ToLower()).Append(",");
                r1.config_show.Append("\"IsListVisable\":").Append(Convert.ToString(attr.Desc.af_ListVisable).ToLower()).Append(",");
                r1.config_show.Append("\"IsVisable\":").Append(Convert.ToString(attr.Desc.af_Visable).ToLower()).Append(",");
                r1.config_show.Append("\"IsReadOnly\":").Append(Convert.ToString(attr.Desc.af_ReadOnly).ToLower()).Append(",");
                r1.config_show.Append("\"zh\":\"").Append(attr.ZhName).Append("\",");
                r1.config_show.Append("\"title\":\"").Append(attr.ZhName).Append("\",");
                r1.config_show.Append("\"position\":").Append(fieldSeq).Append(",");
                r1.config_show.Append("\"is_cache\":true,");
                r1.config_show.Append("\"api_code\":\"").Append(fieldname).Append("\",");
                r1.config_show.Append("\"customized_validation_message\":\"").Append("").Append("\",");
                r1.config_show.Append("\"field_inability_info\":\"").Append("").Append("\",");
                r1.config_show.Append("\"grids_to_occupy\":\"").Append("").Append("\",");
                r1.config_show.Append("\"notes\":\"").Append("").Append("\",");
                r1.config_show.Append("\"predefined_value\":\"").Append("").Append("\",");
                r1.config_show.Append("\"private\":\"").Append("").Append("\",");

                r1.config_show.Append("\"range_max\":\"").Append("").Append("\",");
                r1.config_show.Append("\"range_min\":\"").Append("").Append("\",");

                r1.config_show.Append("\"maximum_length\":\"").Append("").Append("\",");
                r1.config_show.Append("\"minimum_length\":\"").Append("").Append("\",");

                r1.config_show.Append("\"start_new_row\":\"").Append("").Append("\",");
                r1.config_show.Append("\"validations\":\"").Append("").Append("\",");
                r1.config_show.Append("\"associated\":").Append("false").Append(",");
                r1.config_show.Append("\"random_choices\":").Append("false").Append(",");
                r1.config_show.Append("\"quota_blank_warning\":\"").Append("").Append("\",");

                string ctrl1 = Enum.GetName(typeof(BaseCtrlType), attr.CtrlType());
                string enumJson = attr.GetEnumJson("enum_array");
                if (!string.IsNullOrEmpty(enumJson))
                {
                    r1.config_show.Append(enumJson).Append(",");
                    if (ctrl1.ToLower() == "unknown")
                        ctrl1 = "SelectMultiple";

                    int fieldSeq2 = 0;
                    StringBuilder enum_ext = new StringBuilder(256);

                    //foreach()
                    {
                        enum_ext.Append("\"_type\":\"").Append("Choice").Append("\",");
                        enum_ext.Append("\"api_code\":\"").Append("").Append("\",");
                        enum_ext.Append("\"hidden\":\"").Append("false").Append("\",");
                        enum_ext.Append("\"position\":").Append(fieldSeq2).Append(",");
                        enum_ext.Append("\"selected\":\"").Append("false").Append("\",");
                        enum_ext.Append("\"api_code\":\"").Append("").Append("\",");
                        enum_ext.Append("\"quota\":\"").Append("").Append("\",");
                        enum_ext.Append("\"quota_temp\":\"").Append("").Append("\",");
                        enumJson = enumJson.Replace("{chinese", "{" + enum_ext.ToString() + "chinese");
                    }
                }
                if (ctrl1.ToLower() == "unknown")
                    ctrl1 = "InputString";

                r1.config_show.Append("\"ctrl\":\"").Append(ctrl1).Append("\",");
                fieldSeq++;
            }
            r1.config_show.Remove(r1.config_show.Length - 1, 1);
            r1.config_show.Append("},");
            return this;
        }
        public JsonData Add(string keyName, List<string> fieldlist)
        {
            return r1.data.Add(keyName, ToJson(fieldlist));
        }
        public JsonData Add(ITableImplement table)
        {
            this.table = table;
            return this;
        }
        public JsonData Add<MyTable>(List<MyTable> tablelist) where MyTable : ITableImplement, new()
        {
            return Add("", tablelist);
        }
        public JsonData Add<MyTable>(List<MyTable> tablelist, string tablelistName) where MyTable : ITableImplement, new()
        {
            return Add(tablelistName, tablelist);
        }
        public JsonData Add<MyTable>(string tablelistName, List<MyTable> tablelist) where MyTable : ITableImplement, new()
        {
            if (tablelist == null || tablelist.Count == 0) return this;
            if (tablelistName != "")
                this.tablelistName = tablelistName;
            this.tablelist = new List<AgileFrame.Orm.PersistenceLayer.Model.ITableImplement>();
            this.tablelist.AddRange(tablelist);
            return this;
        }
        private string tablelistJson;
        public JsonData Add(string tablelistName, string tablelistJson, int pageSize, int pageIndex, int count)
        {
            if (tablelistJson == null || tablelistJson.Length == 0) return this;
            if (tablelistName != "")
                this.tablelistName = tablelistName;
            this.tablelistJson = tablelistJson;
            this.pageNum = pageIndex;
            this.pageSize = pageSize;
            this.totalCount = count;
            this.totalPageNum = 1 + (count / pageSize);
            List<int> list1 = new List<int>();
            for (int i = 0; i < totalPageNum; i++)
            {
                list1.Add(i);
            }
            this.linkPageNumbers = list1.ToArray();
            return this;
        }
        public JsonData Add<MyTable>(string tablelistName, List<MyTable> tablelist, int pageSize, int pageIndex, int count) where MyTable : ITableImplement, new()
        {
            if (tablelist == null || tablelist.Count == 0) return this;
            if (tablelistName != "")
                this.tablelistName = tablelistName;
            this.tablelist = new List<AgileFrame.Orm.PersistenceLayer.Model.ITableImplement>();
            this.tablelist.AddRange(tablelist);
            this.pageNum = pageIndex;
            this.pageSize = pageSize;
            this.totalCount = count;
            this.totalPageNum = 1 + (count / pageSize);
            List<int> list1 = new List<int>();
            for (int i = 0; i < totalPageNum; i++)
            {
                list1.Add(i);
            }
            this.linkPageNumbers = list1.ToArray();
            return this;
        }
        //public JsonData Add(string json1)
        //{
        //    if (!dicJson1.ContainsKey(json1))
        //        dicJson1.Add(json1, 1);
        //    return this;
        //}
        public JsonData AddTop(string key1, string value)
        {
            r1.dic1.Add(key1, value);
            //if (topDic1 == null) topDic1 = new AFDictionary<string, string>();
            //if (!topDic1.ContainsKey(key1))
            //    topDic1.Add(key1, value);
            //else
            //    topDic1[key1] = value;
            return this;
        }
        public void initDataList()
        {
            if (datalist1 == null)
                datalist1 = new List<JsonData>();
        }
        #endregion 数据操作代码-子data也可以有

        //public void Add<MyTable>(MyTable table1) where MyTable : ITableImplement, new()
        //{
        //    if (this.data1 == null)
        //        this.data1 = new JsonData(isDebug);
        //    data1.Add(table1);
        //}
        //public void AddSub<MyTable>(MyTable table1) where MyTable : ITableImplement, new()
        //{
        //    if (this.datalist1 == null)
        //        this.datalist1 = new List<JsonData>();
        //    JsonData data = new JsonData(isDebug);
        //    data.Add(table1);
        //    datalist1.Add(data);
        //}
        //public void AddSub<MyTable>(List<MyTable> listTable1) where MyTable : ITableImplement, new()
        //{
        //    if (this.datalist1 == null)
        //        this.datalist1 = new List<JsonData>();
        //    JsonData data = new JsonData(isDebug);
        //    data.Add(listTable1);
        //    datalist1.Add(data);
        //}
        public JsonData Add<MyTable>(MyTable table1) where MyTable : ITableImplement, new()
        {
            this.table = table1;
            return this;
        }
        public JsonData Add(string key1, int value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public JsonData Add(string key1, double value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public JsonData Add(string key1, float value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public JsonData Add(string key1, decimal value1)
        {
            return Add2(key1, Convert.ToString(value1));
        }
        public JsonData Add(string key1, bool value1)
        {
            if (value1)
                return Add2(key1, "true");
            else
                return Add2(key1, "false");
        }
        public JsonData Add2(string key1, string value1)
        {
            if (dic2 == null) dic2 = new AFDictionary<string, string>();
            if (!dic2.ContainsKey(key1))
                dic2.Add(key1, Convert.ToString(value1));
            else
                dic2[key1] = Convert.ToString(value1);
            return this;
        }
        public JsonData Add(string key1, string value)
        {
            if (dic1 == null) dic1 = new AFDictionary<string, string>();
            if (!dic1.ContainsKey(key1))
                dic1.Add(key1, value);
            else
                dic1[key1] = value;
            return this;
        }
        public JsonData Add(Dictionary<string, string> dic1)
        {
            foreach (string key1 in dic1.Keys)
            {
                Add(key1, dic1[key1]);
            }
            return this;
        }
        public JsonData Add(AttributeItem attr, string value)
        {
            return Add(attr.FieldName, value);
        }
        /// <summary>
        /// 枚举字段转变为json对象！
        /// </summary>
        /// <param name="attr"></param>
        /// <returns></returns>
        public JsonData AddEnum(AttributeItem attr)
        {
            if (dic_enum == null) dic_enum = new AFDictionary<AttributeItem, string>();
            if (!dic_enum.ContainsKey(attr))
                dic_enum.Add(attr, attr.FieldNameHeadLower);
            return this;
        }
        /// <summary>
        /// 枚举字段转变为json对象！
        /// </summary>
        /// <param name="attr"></param>
        /// <returns></returns>
        public JsonData AddEnum(string keyName, AttributeItem attr)
        {
            if (dic_enum == null) dic_enum = new AFDictionary<AttributeItem, string>();
            if (!dic_enum.ContainsKey(attr))
                dic_enum.Add(attr, keyName);
            return this;
        }
        public string ToJson(bool jiami, bool isShuati, bool isHeadLower, bool isLower)
        {
            #region 2data数据
            JsonService jsobj = new JsonService(isZh);
            jsobj.isHeadLower = isHeadLower;
            jsobj.isLower = isLower;
            jsobj.isEnumChinese = !isShuati;

            StringBuilder sbData = new StringBuilder(256);
            if (table != null && table.IsNotNull())
            {
                if (isZh)
                {
                    string js2 = jsobj.ToJsonZh(table, r1.RefreshZh);
                    sbData.Append("\"").Append(table._TableName + "_zh").Append("\":").Append(js2)
                        .Append(",");
                }
                if (!string.IsNullOrEmpty(tableName))
                {
                    sbData.Append("\"").Append(tableName).Append("\"").Append(":");
                    sbData.Append(jsobj.ToJson(table)).Append(",");
                }
                else
                {
                    string sb1 = jsobj.ToJson(table);
                    if (sb1.StartsWith("{"))
                        sbData.Append(sb1.Substring(1, sb1.Length - 2)).Append(",");
                    else
                        sbData.Append(sb1).Append(",");
                }
                if (datalist1 != null && datalist1.Count > 0)
                {
                    StringBuilder sb2 = new StringBuilder(256);
                    foreach (JsonData data2 in datalist1)
                    {
                        string json5 = data2.ToJson(false, isShuati, isHeadLower, isLower);//.TrimEnd(',')
                        if (string.IsNullOrEmpty(json5)) continue;
                        sb2.Append(json5);//.Append(",");
                    }
                    if (sb2.Length > 0)
                        sbData.Append(sb2);
                }
            }
            if (tablelist != null && tablelist.Count > 0)
            {
                tablelistJson = jsobj.ToJson(tablelist);
                if (string.IsNullOrEmpty(tablelistName))
                    tablelistName = tablelist[0]._TableName;
            }
            if (!string.IsNullOrEmpty(tablelistJson))
            {
                if (!isShuati)//非刷题！isShuati带有list
                {
                    if (!string.IsNullOrEmpty(tablelistName))
                    {
                        if (pageNum != -1)//分页页码
                        {
                            //sbData.Append("\"linkPageNumbers\":").Append("[");
                            //if (linkPageNumbers != null && linkPageNumbers.Length > 0)
                            //{
                            //    foreach (int i in linkPageNumbers)
                            //        sbData.Append(i).Append(",");
                            //    sbData.Remove(sbData.Length - 1, 1);
                            //}
                            //sbData.Append("]").Append(",");
                            sbData.Append("\"pageNum\":").Append(pageNum).Append("").Append(",");
                            sbData.Append("\"pageSize\":").Append(pageSize).Append("").Append(",");
                            sbData.Append("\"totalCount\":").Append(totalCount).Append("").Append(",");
                            sbData.Append("\"totalPageNum\":").Append(totalPageNum).Append("").Append(",");
                        }
                        sbData.Append("\"").Append(tablelistName).Append("\"").Append(":");
                        sbData.Append(tablelistJson)
                            .Append(",");
                    }
                    else
                        sbData.Append(tablelistJson.TrimEnd('}').TrimStart('{'))
                            .Append(",");

                    if (isZh)
                    {
                        if (tablelist != null && tablelist.Count > 0)
                        {
                            string js2 = jsobj.ToJsonZh(tablelist[0], r1.RefreshZh);
                            sbData.Append("\"").Append(tablelist[0]._TableName).Append("_zh\":").Append(js2)
                                .Append(",");
                        }
                    }
                }
                else//刷题！isShuati带有list
                {
                    sbData.Append("\"").Append(tablelistName).Append("\":");
                    sbData.Append("{");
                    if (totalCount >= 0)
                        sbData.Append("\"total\":\"").Append(totalCount).Append("\"").Append(",");
                    if (pageNum >= 0)
                        sbData.Append("\"pageIndex\":\"").Append(pageNum).Append("\"").Append(",");

                    if (isZh)
                    {
                        if (tablelist != null && tablelist.Count > 0)
                        {
                            string js2 = jsobj.ToJsonZh(tablelist[0], r1.RefreshZh);
                            //.Append("\"list_zh\":")
                            sbData.Append(tablelist[0]._TableName).Append("_zh\":").Append(js2).Append(",");
                        }
                    }
                    sbData.Append("\"list\":").Append(tablelistJson);
                    sbData.Append("},");
                }
            }
            if (dic1 != null && dic1.Count > 0)
            {
                foreach (string key1 in dic1.Keys)
                {
                    string value1 = dic1[key1];
                    if (!string.IsNullOrEmpty(value1) && (value1.StartsWith("[") || value1.StartsWith("{")))
                        sbData.Append("\"").Append(key1).Append("\":").Append((value1));
                    else
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
            if (dic_enum != null && dic_enum.Count > 0)
            {
                foreach (AttributeItem key1 in dic_enum.Keys)
                {
                    //if (string.IsNullOrEmpty(key1.Desc))
                    //    key1.Desc = key1.DataBaseField
                    string enumJson = key1.GetEnumJson(dic_enum[key1]);
                    if (!string.IsNullOrEmpty(enumJson))
                    {
                        sbData.Append(enumJson);
                        sbData.Append(",");
                    }
                }
            }
            #endregion data数据-子data也可以有
            return sbData.ToString();
        }
        /*
        public string ToJson2(bool jiami, bool isShuati, bool isHeadLower, bool isLower)
        {
            JsonService jsobj = new JsonService(isZh);
            jsobj.isHeadLower = isHeadLower;
            jsobj.isLower = isLower;

            StringBuilder sbData = new StringBuilder(256);
            string tbName = null;

            if (!string.IsNullOrEmpty(tableName))
            {
                tbName = tableName;
            }
            else if (tablelist.Count > 0)
            {
                tbName = tablelist[0]._TableName;
            }

            if (tablelist != null && tablelist.Count > 0)
            {
                totalCount = tablelist.Count;
                if (isDebug)
                {
                    try
                    {
                        sbData.Append("\"").Append(tbName).Append("_zh").Append("\":\"").Append(tablelist[0]._ZhName).Append("\",");
                    }
                    catch (Exception ex)
                    {
                        Cs.Error("_ZhName:" + ex.ToString());
                    }
                }
                if (isShuati)//带有list
                {
                    sbData.Append("\"").Append(tbName).Append("\":");
                    sbData.Append("{");
                    if (totalCount >= 0)
                        sbData.Append("\"total\":\"").Append(totalCount).Append("\"").Append(",");
                    if (pageNum >= 0)
                        sbData.Append("\"pageIndex\":\"").Append(pageNum).Append("\"").Append(",");

                    if (isDebug)
                    {
                        string js2 = jsobj.ToJsonZh(tablelist[0], r1.RefreshZh);
                        sbData.Append("\"list_zh\":").Append(js2).Append(",");
                    }
                    string js1 = jsobj.ToJson(tablelist);
                    sbData.Append("\"list\":").Append(js1);
                    sbData.Append("},");
                }
                else
                {
                    sbData.Append("\"").Append(tbName).Append("\":");
                    string js1 = jsobj.ToJson(tablelist);
                    sbData.Append(js1); 
                    sbData.Append(",");

                    if (datalist1 != null && datalist1.Count > 0)
                    {
                        foreach (JsonData data2 in datalist1)
                        {
                            sbData.Append(data2.ToJson(false, isShuati, isHeadLower, isLower));
                            sbData.Append(",");
                        }
                    }

                    if (isDebug)
                    {
                        string js2 = jsobj.ToJsonZh(tablelist[0], r1.RefreshZh);
                        sbData.Append("\"").Append(tbName).Append("_zh\":").Append(js2).Append(",");
                    }
                }
            }
            if (table != null && table.IsNotNull())
            {
                if (!string.IsNullOrEmpty(tableName))
                    tbName = tableName;
                else
                    tbName = table._TableName;
                sbData.Append("\"").Append(tbName).Append("\":").Append(jsobj.ToJson(table)).Append(",");
                if (isDebug)
                {
                    string js2 = jsobj.ToJsonZh(table, r1.RefreshZh);
                    sbData.Append("\"").Append(tbName + "_zh").Append("\":").Append(js2).Append(",");
                }
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
            return sbData.ToString();
        }
        */
    }

    //public class Data<MyTable> where MyTable : ITableImplement, new()
    //{
    //    public MyTable data { get; set; }

    //    public string ToJson()
    //    {
    //        string tbName = data._TableName;
    //        StringBuilder sb1 = new StringBuilder("");
    //        sb1.Append("\"").Append(tbName).Append("\":").Append(new JsonService(isZh).ToJson(data));

    //        //追加有误   
    //        return sb1.Append("").ToString();
    //    }
    //}
}
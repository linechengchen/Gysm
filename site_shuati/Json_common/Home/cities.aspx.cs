using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 SELECT TOP 1000 [id]
      ,[city]
      ,[province]
      ,[lat]
      ,[lng]
      ,[IsHot]
      ,[create_by]
  FROM [ShuaTiShenQi].[dbo].[TCity]
  
  delete FROM [ShuaTiShenQi].[dbo].[TCity]
  
  Insert into [ShuaTiShenQi].[dbo].[TCity]
  ([city],[province]) select distinct [City],[Province]
  from [ShuaTiShenQi].[dbo].[TSchool]   where city is not null and city != '' order by  [City] asc
 */
public partial class Json_cityJson : BasePageShuati
{
    //{"code":200,"message":"success","data":{"cities":[{"id":36,"name":"温州","province_id":null,"spell_all":null,"spell_short":null,"province":null,"adcode":null,"location":null,"available":0,"initial":null,"is_hot":0,"extra_warehouse":null,"weight":0,"initialNum":0}]}}
    protected string city_name = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        city_name = Request.QueryString["city_name"];
        if (string.IsNullOrEmpty(city_name))
            city_name = Request.QueryString["cityname"];
        //city_name = Request.Form["city_name"];
        //city_name = Request["city_name"];
        //string a1 = Request.ServerVariables["city_name"];
        if (Request["t"] == "1") return;
        if (!string.IsNullOrEmpty(city_name))
        {
            JsonRoot r1 = new JsonRoot();
            TCity city1 = BLLTable<TCity>.GetRowData(TCity.Attribute.City, city_name.TrimEnd('市'));
            if (city1 != null)
            {
                r1.code = 200;
                r1.Add(new List<TCity>() { city1 }, "cities");
                string city = r1.ToJsonHeadLower(isJiami);
                Response.Write(city);
                Response.End();
            }
            else
            {
                Response.Write(r1.ToJsonHeadLower(isJiami));
                Response.End();
            }
        }
        else if("onlycity" == Request["type"])
        {
            TCity val1 = new TCity();
            val1.Id = 0;
            val1.City = "";
            val1.Province = "";
            val1.OrderBy(TCity.Attribute.City, Order.Asc);
            List<TCity> list1 = BLLTable<TCity>.Select(val1);
            JsonRoot r1 = new JsonRoot();
            r1.code = 200;
            r1.data.Add("cities", list1);
            Response.Write(r1.ToJsonHeadLower(isJiami));
            Response.End();
        }
        else{
            TCity val1 = new TCity();
            val1.Id = 0;
            val1.City = "";
            val1.Province = "";
            val1.OrderBy(TCity.Attribute.City, Order.Asc);
            List<TCity> list1 = BLLTable<TCity>.Select(val1);
            RootCity r1 = new RootCity(); r1.data = new Data();
            r1.data.hotCities = new List<HotCitiesItem>();
            r1.data.normalCity = new List<NormalCityItem>();

            r1.data.hotCities.Add(new HotCitiesItem(802102, "北京"));
            r1.data.hotCities.Add(new HotCitiesItem(807802, "广州"));
            r1.data.hotCities.Add(new HotCitiesItem(808802, "杭州"));
            r1.data.hotCities.Add(new HotCitiesItem(818602, "南京"));
            r1.data.hotCities.Add(new HotCitiesItem(822702, "上海"));
            r1.data.hotCities.Add(new HotCitiesItem(828502, "武汉"));
            r1.data.hotCities.Add(new HotCitiesItem(835502, "郑州"));
            r1.data.hotCities.Add(new HotCitiesItem(827302, "温州"));
            r1.data.hotCityNum = 8;
            r1.data.normalCityNum = 354;

            Dictionary<string, List<CitiesItem>> dic1 = new Dictionary<string, List<CitiesItem>>();

            string str1 = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char c1 in str1)
            {
                dic1.Add(c1.ToString().ToUpper(), new List<CitiesItem>());
            }

            foreach (TCity t1 in list1)
            {
                string s1 = ConvertToPinYin(t1.City);
                if (!string.IsNullOrEmpty(s1))
                {
                    dic1[s1[0].ToString().ToUpper()].Add(new CitiesItem(t1.Id, t1.City));
                }
            }
            foreach (string c1 in dic1.Keys)
            {
                if (dic1[c1].Count > 0)
                    r1.data.normalCity.Add(new NormalCityItem(c1, dic1[c1]));
            }
            r1.message = "success";
            r1.code = 200;
            Response.Write(JsonConvert.SerializeObject(r1));
            Response.End();
        }
    }
    private string ConvertToPinYin(string str)
    {
        string PYstr = "";
        foreach (char item in str.ToCharArray())
        {
            if (Microsoft.International.Converters.PinYinConverter.ChineseChar.IsValidChar(item))
            {
                Microsoft.International.Converters.PinYinConverter.ChineseChar cc = new Microsoft.International.Converters.PinYinConverter.ChineseChar(item);

                //PYstr += string.Join("", cc.Pinyins.ToArray());
                PYstr += cc.Pinyins[0].Substring(0, cc.Pinyins[0].Length - 1);
                //PYstr += cc.Pinyins[0].Substring(0, cc.Pinyins[0].Length - 1).Substring(0, 1).ToLower();
            }
            else
            {
                PYstr += item.ToString();
            }
        }
        return PYstr;
    }
}
public class HotCitiesItem
{
    public HotCitiesItem(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    /// <summary>
    /// 
    /// </summary>
    public int id { get; set; }
    /// <summary>
    /// 杭州
    /// </summary>
    public string name { get; set; }
}

public class CitiesItem
{
    public CitiesItem(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    /// <summary>
    /// 
    /// </summary>
    public int id { get; set; }
    /// <summary>
    /// 安阳
    /// </summary>
    public string name { get; set; }
}

public class NormalCityItem
{
    public NormalCityItem(string initial, List<CitiesItem> cities)
    {
        this.initial = initial;
        this.cities = cities;
    }
    /// <summary>
    /// 
    /// </summary>
    public string initial { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<CitiesItem> cities { get; set; }
}

public class Data
{
    /// <summary>
    /// 
    /// </summary>
    public int normalCityNum { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<HotCitiesItem> hotCities { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int hotCityNum { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<NormalCityItem> normalCity { get; set; }
}

public class RootCity
{
    /// <summary>
    /// 
    /// </summary>
    public int code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string message { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Data data { get; set; }
}
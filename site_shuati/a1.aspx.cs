using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using RedisService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using 微信运营辅助软件;

public partial class all : BasePageShuati
{
    protected string sc = "194";//zlg
    protected string type1 = "";
    protected string source1 = "";
    protected void setParams()
    {
        if (!string.IsNullOrEmpty(Request["type1"]))
        {
            type1 = Convert.ToString(Request["type1"]);
        }
        if (!string.IsNullOrEmpty(Request["source1"]))
        {
            source1 = Convert.ToString(Request["source1"]);
        }
        #region sc的过滤
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = getSc();
        }
    }
    protected string getSc()
    {
        string sc2sc = @"196=1952
198=1953
205=2042
208=2072
246=2162
235=2252
236=2253
350=3102
351=3103

352=3122
342=3123

360=3202
747=7462
797=7872

795=7912
796=7913
";
        Dictionary<string, string> dic1 = new Dictionary<string, string>();
        foreach (string s1 in sc2sc.Split('\n'))
        {
            if (!string.IsNullOrEmpty(s1))
            {
                string[] s2s = s1.Split('=');
                if (s2s.Length == 2)
                {
                    dic1.Add(s2s[0], s2s[1]);
                }
            }
        }
        string sc1 = Convert.ToString(Request["sc"]).Trim();
        if (!string.IsNullOrEmpty(sc1) && dic1.ContainsKey(sc1))
        {
            return dic1[sc1];
        }
        return sc1;
    }
    #endregion sc的过滤
    
    protected void Page_Load(object sender, EventArgs e)
    {
        setParams();
    }
}
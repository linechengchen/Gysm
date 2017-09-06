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

public partial class siteSource1 : BasePageShuati
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
        if (!string.IsNullOrEmpty(Request["sc"]))
        {
            sc = ScHelper.getSc(this);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        MyRedis.Ping();
        setParams();

    }
}
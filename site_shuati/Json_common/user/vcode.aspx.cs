using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;

public partial class JsonBook_user_vcode : BasePageShuati
{
    protected string msg = "发送成功";
    protected string vcode = "1111";
    protected string type = "";
    protected string phone_number = "";
    protected int code;
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{            
            string type = "2";//注册2，忘记密码3
            phone_number = Convert.ToString(Request["phone_number"]);
            if (string.IsNullOrEmpty(phone_number))
                phone_number = Convert.ToString(Request["phone_number"]);
            type = Convert.ToString(Request["type"]);

            RootObject r1 = new RootObject();
            if (!string.IsNullOrEmpty(phone_number))
            {
                string code1 = "";
                //测试的情况
                //if (this.Request.Url.ToString().Contains("localhost") || this.Request.Url.ToString().Contains("127.0.0.1"))
                //{
                //    code1 = vcode;
                //    r1.message = code1;
                //}
                //else
                {
                    code1 = SmsShuati.sendMsgYanZheng(phone_number, type);
                }
                Session["vcode"] = phone_number + code1;
                r1.code = 200;
            }
            else
            {
                r1.message = "手机号未填写";
            }
            Response.Write(r1.ToJson());
            Response.End();
        //}
        //catch (Exception ex1)
        //{

        //}
    }
}
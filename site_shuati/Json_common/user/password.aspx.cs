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

public partial class JsonBook_user_password : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var password = "";
        var phone_number = "";
        var vcode = "";
        TUserInfo val1 = new TUserInfo();
        TUserInfo cond1 = new TUserInfo();
        RootObject r1 = new RootObject();
        if (!string.IsNullOrEmpty(Request["password"]))
        {
            password = Base64.toString(Request["password"]);
        }
        if (!string.IsNullOrEmpty(Request["phone_number"]))
        {
            phone_number = Request["phone_number"];
        }
        if (!string.IsNullOrEmpty(Request["vcode"]))
        {
            vcode = Request["vcode"];
        }

        if(phone_number=="18324254558")
        {

            r1.message = "密码修改测试,";
            r1.code = 200;
            Response.Write(r1.ToJsonHeadLower());
            Response.End();
        }
        if (string.IsNullOrEmpty(vcode) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone_number)
         || phone_number + vcode != Convert.ToString(Session["vcode"]))
        {
            r1.code = 999;
        
            r1.message = "密码修改失败,验证码错误";
            Response.Write(r1.ToJsonHeadLower());
        }
        else
        {


            val1.PassWord = password;
            cond1.Phone_number = phone_number;
            var ret1 = BLLTable<TUserInfo>.Update(val1, cond1);
            if (ret1 > 0)
            {
                r1.code = 200;
                Response.Write(r1.ToJsonHeadLower());
            }
            else
            {

                r1.message = "密码修改失败,验证码错误";
                r1.code = 999;
                Response.Write(r1.ToJsonHeadLower());

            }

        }

        Response.End();
    }
}
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_user_phone_number : BasePageShuati
{
    protected string username = null;
 
    protected string phone_number = null;
    protected int code = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
       
        username = Request["username"].ToString();



        if (!string.IsNullOrEmpty(username))
        {
            RootObject r1 = new RootObject();
           
           
            TUserInfo user1 = BLLTable<TUserInfo>.GetRowData(TUserInfo.Attribute.User_name, username);
            if (user1 != null)
            {
                if (user1.Phone_number != "")
                {
                    code = 200;
                    phone_number = user1.Phone_number;
                    r1.code =code;
                    r1.data.table = user1;

                    Response.Write(r1.ToJson());
                        Response.End();
                 
                }
           

            }
            else
            {
                code = 201;
                Response.Write(r1.ToJson());
                Response.End();

            }
        }
    }
}
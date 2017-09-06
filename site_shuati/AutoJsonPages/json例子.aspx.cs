using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Script.Serialization;//命名空间：json序列化dll
using AgileFrame.Orm.PersistenceLayer.BLL.Base;//命名空间：三层结构，业务逻辑层
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;//命名空间：三层结构，实体层

public partial class app_jianzhi_user_user_auto_Xt_course :BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["t"] == "1") return; //此处显示页面前端的测试json
        
        //处理数据表：Xt_course
        act_Xt_course();
    }
    
    #region Xt_course
    Xt_course param1 = new Xt_course();
    string action = "";
    protected void act_Xt_course()
    {     
        JsonRoot r1 = new JsonRoot();
        //获得前端页面传递的所有对象的输入参数
        param1 = set(new Xt_course());
        //写业务代码

        //if (!string.IsNullOrEmpty(Request["token"])) param1.UserId = new Guid(Request["token"]);
        //if (!string.IsNullOrEmpty(Request["UserId"])) param1.UserId = new Guid(Request["UserId"]);
        setRequest(param1, Xt_course.Attribute.Uuid, "token", "UserId", "User_Id");//UserEducationId

        int ret1 = -1;//大于-1，表示成功。
        try
        {
            action = Request["act"];
            switch (action)//数据库操作
            {
                case "udpate"://数据库-更新对象
                    if (param1.IsNotNull() && param1.Uuid != default(Guid))
                        ret1 = BLLTable<Xt_course>.Update(param1, Xt_course.Attribute.Uuid);//UserEducationId
                    break;

                case "add"://数据库-增加对象
                    if (param1.IsNotNull())
                        ret1 = BLLTable<Xt_course>.Insert(param1);
                    break;

                case "delete"://数据库-删除对象
                    if (param1.IsNotNull() && param1.Uuid != default(Guid))
                        ret1 = BLLTable<Xt_course>.Delete(Xt_course.Attribute.Uuid, param1.Uuid);
                    break;

                case "getone"://数据库-查询单个对象
                    Xt_course value2 = new Xt_course();
                    value2 = BLLTable<Xt_course>.GetRowData(value2, param1);
                    //r1.Add(value2, "节点名称");//代码示例
                    r1.data.Add("Xt_course", value2);
                    ret1 = 1;
                    break;

                case "get":
                case "select"://数据库-查询对象列表, 
                case "listAll":
                default://默认
                    List<Xt_course> list1 = new List<Xt_course>();
                    Xt_course value1 = new Xt_course();
                    value1.Top(20);
                    list1 = BLLTable<Xt_course>.Select(value1, param1);
                    //r1.Add(list1, "节点名称");//代码示例
                    r1.data.Add("Xt_course", list1);
                    ret1 = 1;
                    break;
            }
        }
        catch (Exception ex1)
        {
            Cs.Fatal("71" + ex1.Message);
        }
        if (ret1 > 0)
        {
            r1.code = 200;
            r1.errMsg = "操作成功";
        }
        else
        {
            r1.code = ret1;
            r1.errMsg = "操作失败，请截图反馈给管理员，谢谢您！";
        }
        string json1 = r1.ToJsonHeadLower();
        Response.Write(json1);
        Response.End();
    }
    #endregion
}
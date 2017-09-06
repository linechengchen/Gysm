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

//http://stbd.aibangxs.com/zhuxuetang2/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=list&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  列表：
//{"code":200,"msg":"成功","data":null}
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//http://stbd.aibangxs.com/zhuxuetang2/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=add&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  增加：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//http://stbd.aibangxs.com/zhuxuetang2/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=delete&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  删除：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//http://stbd.aibangxs.com/zhuxuetang2/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=edit&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  修改：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

public partial class app_jianzhi_user_user_auto_Xt_note : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["t"] == "1") return; //此处显示页面前端的测试json
        
        //处理数据表：Xt_note
        act_Xt_note();
    }

    #region Xt_note
    List<string> classlist = new List<string>();
    protected string classes_idlist = "";
    protected void act_Xt_note()
    {     
        JsonRoot r1 = new JsonRoot();
        //获得前端页面传递的所有对象的输入参数
        Xt_note param1 = new Xt_note();
        param1.SetInitialized(Xt_note.Attribute.Id, false);
        param1 = set(param1);
        if (!string.IsNullOrEmpty(Request["classes_id"]))
        {
            param1.Course_id = Request["classes_id"];
        }
        if(!string.IsNullOrEmpty(Request["classid[]"]))
        {
            classes_idlist = Request["classid[]"];
            classlist.AddRange(classes_idlist.Split(','));
        }

        if (!string.IsNullOrEmpty(Request["id"]))
        {
            param1.Uuid = Guid.Parse(Request["id"]);
        }
        if (!string.IsNullOrEmpty(Request["Uuid"]))
        {
            param1.Uuid = Guid.Parse(Request["Uuid"]);
        }

        //if (!string.IsNullOrEmpty(Request["token"])) param1.UserId = new Guid(Request["token"]);
        //if (!string.IsNullOrEmpty(Request["UserId"])) param1.UserId = new Guid(Request["UserId"]);
        //setRequest(param1, Xt_note.Attribute.Uuid, "token", "UserId", "User_Id");//UserEducationId

        int ret1 = -1;//大于-1，表示成功。
        try
        {
            string action = Request["act"];
            switch (action)//数据库操作
            {
                case "edit":
                case "update"://数据库-更新对象
                    if (!string.IsNullOrEmpty(Request["top"]))
                    {
                        param1.Is_top = Convert.ToString(Request["top"]);
                        if (param1.Is_top == "0") param1.Is_top = "1";
                        else param1.Is_top = "0";
                    }
                    if (param1.IsNotNull() && param1.Uuid != default(Guid))
                    {
                        ret1 = BLLTable<Xt_note>.Update(param1, Xt_note.Attribute.Uuid);//UserEducationId
                    }
                    break;

                case "add"://数据库-增加对象
                    if (param1.IsNotNull())
                    {
                        if (classlist.Count > 0)
                        {
                            foreach (string classId in classlist)
                            {
                                param1.Course_id = classId;
                                ret1 = BLLTable<Xt_note>.Insert(param1);
                            }
                        }
                    }
                    break;

                case "delete"://数据库-删除对象
                    if (param1.IsNotNull() && param1.Uuid != default(Guid))
                        ret1 = BLLTable<Xt_note>.Delete(Xt_note.Attribute.Uuid, param1.Uuid);
                    break;

                case "getone"://数据库-查询单个对象
                    Xt_note value2 = new Xt_note();
                    value2 = BLLTable<Xt_note>.GetRowData(value2, param1);
                    //r1.Add(value2, "节点名称");//代码示例
                    r1.data.Add("Xt_note", value2);
                    ret1 = 1;
                    break;

                case "get":
                case "select"://数据库-查询对象列表, 
                case "list":
                case "listAll":
                default://默认
                    List<Xt_note> list1 = new List<Xt_note>();
                    Xt_note value1 = new Xt_note();
                    value1.Top(20);
                    list1 = BLLTable<Xt_note>.Select(value1, param1);
                    //r1.Add(list1, "节点名称");//代码示例
                    r1.data.Add("Xt_note", list1);
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
            r1.message = r1.errMsg = "操作成功";
        }
        else
        {
            r1.code = ret1;
            r1.message = r1.errMsg = "操作失败，请截图反馈给管理员，谢谢您！";
        }
        r1.AddTop("info", r1.message);
        r1.AddTop("status","" + ((ret1 > 0) ? 1 : -1));
        r1.AddTop("url", "/Classes/index.aspx?classes_id=" + param1.Course_id);
        
        string json1 = r1.ToJsonHeadLower();
        Response.Write(json1);
        Response.End();
    }
    #endregion

    #region 公共封装接口代码
    //从页面request中获取参数赋值到对象中
    private void setRequest<MyTable>(MyTable table1, AttributeItem attr1, params string[] names)
        where MyTable : ITableImplement, new()
    {
        foreach (string name in names)
        {
            if (!string.IsNullOrEmpty(Request[name]))
            {
                table1.SetValue(attr1, name);
                break;
            }
        }
    }
    //request获取所有参数
    private MyTable set<MyTable>(MyTable itable)
        where MyTable : ITableImplement, new()
    {
        int count = 0;
        if (itable.IsNull()) itable.LoadAllAttributes(true);
        foreach (AttributeItem attr1 in itable.af_GetAttributes())
        {
            string f1 = Request[attr1.FieldName];
            if (!string.IsNullOrEmpty(f1))
            {
                count++;
                itable.SetValue(attr1, f1);
            }
            else
                itable.SetInitialized(attr1, false);

        }
        if (count == 0)//可能是post对象进来，是否需要处理
        {
            string js1 = null;
            try
            {
                js1 = getString();
                if (js1.StartsWith("{"))
                {
                    JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    //PostData = javaScriptSerializer.Deserialize<PostData>(js1);//字符串反序列化
                    //string email = Convert.ToString(Request.Form["email"]);
                    Response.Write("前端传参方式为json字符串模式\r\n");
                    Response.Write(js1);
                    Response.End();
                }
                else
                {
                    //string email = Convert.ToString(Request.Form["email"]);
                    //Response.Write("前端传参方式为非json字符串模式\r\n");
                    //Response.Write(js1);
                    //Response.End();
                }
            }
            catch (Exception ex1) { Response.Write(js1 + "==异常==" + ex1.Message); Response.End(); }
        }
        return itable;
    }
    //得到post字符串
    public string getString()
    {
        string json1 = (Request.InputStream != null) ? (new System.IO.StreamReader(Request.InputStream).ReadToEnd()) : ""; Request.InputStream.Close();
        return json1;
    }

    #endregion
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Script.Serialization;//命名空间：json序列化dll
using AgileFrame.Orm.PersistenceLayer.BLL.Base;//命名空间：三层结构，业务逻辑层
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
using System.Text;
using System.IO;//命名空间：三层结构，实体层

//将WX_USER_INFO 批量查找替换成其他实体类，即可实现json接口
#region 接口说明

//1、讲师简历信息 (id,教课经验,大学名字年纪经验,大学专业,工作行业,自我简介,uuid,随身照,微信头像,高考成绩,面试评分1-经验,面试评分2-沟通,面试评分3-技能,面试总分,讲师姓名,性别,手机号,出生年月日,高中学校是否重点,擅长科目,家教经验,经验详细介绍,意向工作区域,家乡所在区域,其他意向区域,填写日期,微信昵称,微信性别,微信国家,微信省市,微信市,f26,f27,openid,提交人,提交时间,修改时间,填写设备,操作系统,浏览器,ip,是否显示,是否置顶,置顶超时日期)
//    [WX_USER_INFO] (Id,Experience_year,College,College_major,Work_field,Introduce,Uuid,Photo,Wx_head_img,Score_high_school,Score_mianshi1,Score_mianshi2,Score_mianshi3,Score_mianshi,Teacher_name,Sex,Phone_number,Born,High_school,Good_at,Experience,Experience_intro,Work_area,Home_area,Other_area,Create_time,Wx_nick_name,Wx_sex,Wx_country,Wx_province,Wx_city,F26,F27,OpenID,Wx_create_man,Wx_post_time,Wx_modify_time,Wx_device,Wx_os,Wx_explore,IP,Is_show,On_top,On_top_timeout)
//说明："Experience_year":教课经验,"College":大学名字年纪经验,"College_major":大学专业,"Work_field":工作行业,"Introduce":自我简介,"Photo":随身照,"Wx_head_img":微信头像,"Score_high_school":高考成绩,"Score_mianshi1":面试评分1-经验,"Score_mianshi2":面试评分2-沟通,"Score_mianshi3":面试评分3-技能,"Score_mianshi":面试总分,"Teacher_name":讲师姓名,"Sex":性别,"Phone_number":手机号,"Born":出生年月日,"High_school":高中学校是否重点,"Good_at":擅长科目,"Experience":家教经验,"Experience_intro":经验详细介绍,"Work_area":意向工作区域,"Home_area":家乡所在区域,"Other_area":其他意向区域,"Create_time":填写日期,"Wx_nick_name":微信昵称,"Wx_sex":微信性别,"Wx_country":微信国家,"Wx_province":微信省市,"Wx_city":微信市,"Wx_create_man":提交人,"Wx_post_time":提交时间,"Wx_modify_time":修改时间,"Wx_device":填写设备,"Wx_os":操作系统,"Wx_explore":浏览器,"Is_show":是否显示,"On_top":是否置顶,"On_top_timeout":置顶超时日期)

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/WX_USER_INFO/WX_USER_INFO.aspx?act=list&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  列表：
//{"code":200,"msg":"成功","data":null}
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/WX_USER_INFO/WX_USER_INFO.aspx?act=add&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  增加：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/WX_USER_INFO/WX_USER_INFO.aspx?act=delete&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  删除：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/WX_USER_INFO/WX_USER_INFO.aspx?act=on_top&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  置顶：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/WX_USER_INFO/WX_USER_INFO.aspx?act=edit&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  修改：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）
#endregion 接口说明

public partial class AutoJsonPages_Xb_product : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["t"] == "1") return; //此处显示页面前端的测试json

       ;
        //处理数据表：WX_USER_INFO
        bindphone();
    }

    #region 输入输出参数
    WX_USER_INFO param1 = new WX_USER_INFO();//输入条件参数
    JsonRoot r1 = new JsonRoot();//json返回的对象
    int ret1 = -1;//大于-1，表示成功。//数据处理返回值，用于修改code值

    string user_id = "";//传入act参数

    string action = "";//传入act参数
    string type = "";//传入type参数
    string catelog = "";//传入类型参数
    string grade = "";//传入类型参数
    #endregion 输入输出参数

    #region action路由_Xb_product
    protected void bindphone()
    {
        //获得前端页面传递的所有对象的输入参数
        //param1.SetInitialized(WX_USER_INFO.Attribute.Id, false);
        //param1 = set(param1);

       
        //if (!string.IsNullOrEmpty(Request["token"])) param1.UserId = new Guid(Request["token"]);
        //if (!string.IsNullOrEmpty(Request["UserId"])) param1.UserId = new Guid(Request["UserId"]);
        //setRequest(param1, WX_USER_INFO.Attribute.Uuid, "token", "UserId", "User_Id");//UserEducationId
        try
        {
            user_id = Request["user_id"];
            action = Request["act"];
            type = Request["type"];
            catelog = Request["catelog"];
            switch (action)//数据库操作
            {
                case "order_buy"://数据库-查询单个对象                    
                   
                    break;
                case "del_fav":
                    del_fav();
                    break;
                case "add_fav":
                    add_fav();
                    break;
                case "on_top":
                    on_top();
                    break;
                case "edit":
                case "update":
                    update();
                    break;
                case "add"://数据库-增加对象
                    add();
                    break;
                case "delete"://数据库-删除对象
                 
                    break;
                case "getone"://数据库-查询单个对象                    
                    getone();
                    break;
                case "get":
                case "select":
                case "list":
                case "listAll":
                default://默认//数据库-查询对象列表, 
                    list();
                    break;
            }
            if (ret1 > 0)
            {
                r1.code = 200;

            }
            else
            {
                r1.code = ret1;
              
            }
        }
        catch (Exception ex1)
        {
            Cs.Fatal("71" + ex1.Message);
            r1.code = -1;
            r1.message = ex1.Message;
        }
        r1.isDebug = true;
        string json1 = r1.ToJsonHeadLower();
        Response.Write(json1);
        Response.End();
    }
    #endregion

    #region action增删改查代码
    //获取列表页
    protected void list()
    {
        //StringBuilder sbInt1; StringBuilder sbTime1; StringBuilder sbDaySum1;
        //var page_type = Request["page_type"] ;
        //if (!string.IsNullOrEmpty(page_type))
        //{
        //    param1.Page_type = Convert.ToInt32(page_type);
            
        //}

        //List<WX_USER_INFO> list1 = new List<WX_USER_INFO>();
        //WX_USER_INFO value1 = new WX_USER_INFO();
        //value1.af_PageBy(WX_USER_INFO.Attribute.Id, Order.Desc);
       
        //int pageSize = 2;
        //int pageIndex = 1;
        //int count = -1;

        //if (!string.IsNullOrEmpty(Request["pageSize"]))
        //    pageSize = Convert.ToInt32(Request["pageSize"]);
        //if (!string.IsNullOrEmpty(Request["pageNum"]))
        //    pageIndex = Convert.ToInt32(Request["pageNum"]);
        //if (!string.IsNullOrEmpty(Request["pageIndex"]))
        //    pageIndex = Convert.ToInt32(Request["pageIndex"]);
        //if (!string.IsNullOrEmpty(Request["count"]))
        //    count = Convert.ToInt32(Request["count"]);
        //if (!string.IsNullOrEmpty(Request["totalCount"]))
        //    count = Convert.ToInt32(Request["totalCount"]);

        //#region 本表字段
        //string Good_at = "";
        //string sex = "";
        //string time = "";
        //string keyword = "";

        //if(!string.IsNullOrEmpty(grade))
        //{
        //    if (grade != "0")
        //    {
        //        //param1.Grade = Convert.ToInt32(grade);
        //        param1.Where(string.Format(" (Grade_min < {0} and Grade_max > {0}) or Grade = {0}", grade));
        //    }
        //}

        ////value1.OrderBy("order by on_top desc, Create_time desc");
        //#endregion 本表字段

        //try
        //{
        //    param1.Page_type = 2;
        //    list1 = BLLTable<WX_USER_INFO>.SelectByPage(value1, param1, pageSize, pageIndex, ref count);

        //    #region 本表字段

        //    #endregion 本表字段
        //}
        //catch (Exception e1)
        //{
        //    r1.data.Add("error1", e1.Message);
        //    list1 = BLLTable<WX_USER_INFO>.Select(15); Cs.Error(e1.ToString());
        //}
        //r1.data.Add("WX_USER_INFO", list1, pageSize, pageIndex, count);

        #region 本表业务条件

        #endregion 本表业务条件

        ret1 = 1;
    }
    //详情页，获取一条记录
    protected void getone()
    {
        r1.data.Add("notice", "");
        
        #region 本表业务条件
        if (type == "answer")
            r1.data.Add("title", "推荐教员");
        else
            r1.data.Add("title", "选择时间");

        if (type == "answer")
        {
            string Kemu_id = Request["Kemu_id"];
            string Kemu_name = Request["Kemu_name"];
            string Grade = Request["Grade"];
            if (!string.IsNullOrEmpty(user_id))
            {
                Xb_kemuinfo kemu1 = new Xb_kemuinfo();
                kemu1.Kemu_id = Convert.ToInt32(Kemu_id);
                kemu1.Kemu_name = Kemu_name;
                kemu1.Grade = Convert.ToInt32(Grade);
                kemu1.User_id = user_id;

                int ret5 = BLLTable<Xb_kemuinfo>.Update(kemu1, Xb_kemuinfo.Attribute.Kemu_id);
                if (ret5 < 1)
                {
                    r1.data.Add("kemuErr", "用户的科目选择数据未保存成功");
                }
            }
         
        }
        #endregion 本表业务条件

        WX_USER_INFO value2 = new WX_USER_INFO();
        value2 = BLLTable<WX_USER_INFO>.GetRowData(value2, param1);
        //r1.Add(value2, "节点名称");//代码示例
        r1.data.Add("WX_USER_INFO", value2);

        #region 本表字段
        
        #endregion 本表字段

        ret1 = 1;
    }
    //增加
    protected void add()
    {
        if (param1.IsNotNull())
        {
            //foreach (string classId in classlist)//批量增加
            {
                ret1 = BLLTable<WX_USER_INFO>.Insert(param1);
            }
        }
    }
    //更新
    protected void update()
    {        //数据库-更新对象
        param1.User_id = Request["User_id"];
        if (param1.IsNotNull() && param1.User_id != default(string))
        {
            try
            {

           
            WX_USER_INFO cond1 = new WX_USER_INFO();
            WX_USER_INFO val1 = new WX_USER_INFO();
            cond1.User_id = Request["user_id"];
            WX_USER_INFO select1 = new WX_USER_INFO();
            select1 = BLLTable<WX_USER_INFO>.SelectOne(val1, cond1);
            if(!string.IsNullOrEmpty(select1.User_id)&& string.IsNullOrEmpty(select1.Phone_number))
            {
                param1.Phone_number = Request["phone_number"];
                ret1 = BLLTable<WX_USER_INFO>.Update(param1, WX_USER_INFO.Attribute.User_id);//UserEducationId
                    r1.message = "绑定成功";

            }
            else
                {
                    r1.message = "手机保存过，或者其他错误";
                }
            
            }
            catch(Exception ex)
            { r1.msg = ex.ToString();  }

        
           
        }
    }
    //置顶，非置顶
    protected void on_top()
    {
        if (!string.IsNullOrEmpty(Request["on_top"]))
        {
            param1.af_ValueSQL = " set param1.On_top = !param1.On_top ";
            ret1 = BLLTable<WX_USER_INFO>.Update(param1, WX_USER_INFO.Attribute.User_id);//UserEducationId
        }
    }
    //加入收藏
    protected void add_fav()
    {
        if (Request["user_id"] != null)
        {
            //Xb_teacher_student_fav value5 = new Xb_teacher_student_fav();
            //Xb_teacher_student_fav cond5 = new Xb_teacher_student_fav();
            //cond5.Teacher_id = Convert.ToString(param1.Uuid);
            //cond5.Student_id = Request["user_id"];
            //cond5.Is_fav = true;
            //int isfav = BLLTable<Xb_teacher_student_fav>.SaveOrUpdate(cond5,
            //    Xb_teacher_student_fav.Attribute.Teacher_id, Xb_teacher_student_fav.Attribute.Student_id);
            //if (isfav > 0)
            //{
            //    r1.code = 200;
            //}
            //else
            //{
            //    r1.code = -1;
            //    r1.errMsg = "操作失败";
            //}
        }
    }
    //删除收藏
    protected void del_fav()
    {
        if (Request["user_id"] != null)
        {
            Xb_teacher_student_fav value5 = new Xb_teacher_student_fav();
            Xb_teacher_student_fav cond5 = new Xb_teacher_student_fav();
          
            cond5.Student_id = Request["user_id"];
            int isfav = BLLTable<Xb_teacher_student_fav>.Delete(cond5);
            if (isfav > 0)
                r1.code = 200;
            else
            {
                r1.code = -1;
                r1.errMsg = "操作失败";
            }
        }
    }
    #endregion action增删改查代码
        
    #region 本表数据处理函数
   
    #endregion 本表数据处理函数

}
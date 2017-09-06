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

//将V_xb_job_apply 批量查找替换成其他实体类，即可实现json接口we
#region 接口说明

//1、讲师简历信息 (id,教课经验,大学名字年纪经验,大学专业,工作行业,自我简介,uuid,随身照,微信头像,高考成绩,面试评分1-经验,面试评分2-沟通,面试评分3-技能,面试总分,讲师姓名,性别,手机号,出生年月日,高中学校是否重点,擅长科目,家教经验,经验详细介绍,意向工作区域,家乡所在区域,其他意向区域,填写日期,微信昵称,微信性别,微信国家,微信省市,微信市,f26,f27,openid,提交人,提交时间,修改时间,填写设备,操作系统,浏览器,ip,是否显示,是否置顶,置顶超时日期)
//    [V_xb_job_apply] (Id,Experience_year,College,College_major,Work_field,Introduce,Uuid,Photo,Wx_head_img,Score_high_school,Score_mianshi1,Score_mianshi2,Score_mianshi3,Score_mianshi,Teacher_name,Sex,Phone_number,Born,High_school,Good_at,Experience,Experience_intro,Work_area,Home_area,Other_area,Create_time,Wx_nick_name,Wx_sex,Wx_country,Wx_province,Wx_city,F26,F27,OpenID,Wx_create_man,Wx_post_time,Wx_modify_time,Wx_device,Wx_os,Wx_explore,IP,Is_show,On_top,On_top_timeout)
//说明："Experience_year":教课经验,"College":大学名字年纪经验,"College_major":大学专业,"Work_field":工作行业,"Introduce":自我简介,"Photo":随身照,"Wx_head_img":微信头像,"Score_high_school":高考成绩,"Score_mianshi1":面试评分1-经验,"Score_mianshi2":面试评分2-沟通,"Score_mianshi3":面试评分3-技能,"Score_mianshi":面试总分,"Teacher_name":讲师姓名,"Sex":性别,"Phone_number":手机号,"Born":出生年月日,"High_school":高中学校是否重点,"Good_at":擅长科目,"Experience":家教经验,"Experience_intro":经验详细介绍,"Work_area":意向工作区域,"Home_area":家乡所在区域,"Other_area":其他意向区域,"Create_time":填写日期,"Wx_nick_name":微信昵称,"Wx_sex":微信性别,"Wx_country":微信国家,"Wx_province":微信省市,"Wx_city":微信市,"Wx_create_man":提交人,"Wx_post_time":提交时间,"Wx_modify_time":修改时间,"Wx_device":填写设备,"Wx_os":操作系统,"Wx_explore":浏览器,"Is_show":是否显示,"On_top":是否置顶,"On_top_timeout":置顶超时日期)

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/V_xb_job_apply/V_xb_job_apply.aspx?act=list&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  列表：
//{"code":200,"msg":"成功","data":null}
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/V_xb_job_apply/V_xb_job_apply.aspx?act=add&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  增加：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/V_xb_job_apply/V_xb_job_apply.aspx?act=delete&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  删除：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/V_xb_job_apply/V_xb_job_apply.aspx?act=on_top&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  置顶：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/V_xb_job_apply/V_xb_job_apply.aspx?act=edit&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  修改：
//说明："realName":姓名,"groupId":分组id(空表示未分组),"head":头像,"is_pass":是否审核（0未审核 1已审核）
#endregion 接口说明

public partial class AutoJsonPages_xb_getuser : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["t"] == "1") return; //此处显示页面前端的测试json

        ;
        //处理数据表：V_xb_job_apply
        act_V_xb_job_apply();
    }

    #region 输入输出参数
    V_xb_job_apply param1 = new V_xb_job_apply();//输入条件参数
    JsonRoot r1 = new JsonRoot();//json返回的对象
    int ret1 = -1;//大于-1，表示成功。//数据处理返回值，用于修改code值



    string action = "";//传入act参数
    string type = "";//传入type参数
    string catelog = "";//传入类型参数
    string kefu = "";//传入类型参数
    #endregion 输入输出参数

    #region action路由_V_xb_job_apply
    protected void act_V_xb_job_apply()
    {
        //获得前端页面传递的所有对象的输入参数
        param1.SetInitialized(V_xb_job_apply.Attribute.Id, false);
        param1 = set(param1);

        //if (!string.IsNullOrEmpty(Request["id"]))
        //{
        //    param1.Teacher_uuid = Guid.Parse(Request["id"]);
        //}
        //if (!string.IsNullOrEmpty(Request["Uuid"]))
        //{
        //    param1.Uuid = Guid.Parse(Request["Uuid"]);
        //}
        //if (!string.IsNullOrEmpty(Request["token"])) param1.UserId = new Guid(Request["token"]);
        //if (!string.IsNullOrEmpty(Request["UserId"])) param1.UserId = new Guid(Request["UserId"]);
        //setRequest(param1, V_xb_job_apply.Attribute.Uuid, "token", "UserId", "User_Id");//UserEducationId
        try
        {
            user_id = Request["user_id"];
            action = Request["act"];
            type = Request["type"];
            catelog = Request["catelog"];
            kefu = Request["kefu"];
            switch (action)//数据库操作
            {
                case "del_fav":
                    del_fav();
                    break;
                case "add_fav":
                    add_fav();
                    break;
                case "on_top":
                    on_top();
                    break;
                case "update":
                case "edit":
                    edit();
                    break;
                case "add"://数据库-增加对象
                    add();
                    break;
                case "delete"://数据库-删除对象
                    if (!string.IsNullOrEmpty(Request["Uuid"])){
						Guid Uuid = new Guid(Request["Uuid"]);
                        ret1 = BLLTable<V_xb_job_apply>.Delete(V_xb_job_apply.Attribute.Uuid, Uuid);
					}
                    break;
                case "getone"://数据库-查询单个对象                    
                    getone();
                    break;
                case "control_config"://数据库-查询单个对象                    
                    control_config();
                    r1.code = 200;
                    break;
                case "enum":
                    enumselect();
                    break;
                case "get":
                case "select":
                case "list":
                    list();
                    break;
                //case "listAll":
                //default://默认//数据库-查询对象列表, 
                //    list();
                //    break;
            }
            if (ret1 > 0)
            {
                r1.code = 200;
                r1.message = r1.errMsg = "操作成功";
            }
            else
            {
                r1.code = ret1;
                r1.message = r1.errMsg = "操作失败，请帮忙截图反馈给管理员，谢谢您！";
            }
        }
        catch (Exception ex1)
        {
            Cs.Fatal("71" + ex1.Message);
            r1.code = -1;
            r1.message = ex1.Message;
            throw;
        }
        r1.isDebug = true;
        string json1 = r1.ToJson();
        Response.Write(json1);
        Response.End();
    }
    #endregion

    #region action增删改查代码
    //获取业务枚举量页
    protected void enumselect()
    {



        ret1 = 1;
    }
    protected void add()
    {
        V_xb_job_apply val1 = new V_xb_job_apply();
        V_xb_job_apply cond1 = new V_xb_job_apply();
		
        
		if(Request["Uuid"] != null){
			string Uuid = Convert.ToString(Request["Uuid"]);
			val1.Uuid = StringHelper.GuidParse(Uuid);
		}
        
		if(Request["Job_title"] != null){
			string Job_title = Convert.ToString(Request["Job_title"]);
			val1.Job_title = Convert.ToString(Job_title);
		}
        
		if(Request["Job_code"] != null){
			string Job_code = Convert.ToString(Request["Job_code"]);
			val1.Job_code = Convert.ToInt32(Job_code);
		}
        
		if(Request["Address"] != null){
			string Address = Convert.ToString(Request["Address"]);
			val1.Address = Convert.ToString(Address);
		}
        
		if(Request["Salary"] != null){
			string Salary = Convert.ToString(Request["Salary"]);
			val1.Salary = Convert.ToString(Salary);
		}
        
		if(Request["Salary_unit"] != null){
			string Salary_unit = Convert.ToString(Request["Salary_unit"]);
			val1.Salary_unit = Convert.ToString(Salary_unit);
		}
        
		if(Request["Teacher_name"] != null){
			string Teacher_name = Convert.ToString(Request["Teacher_name"]);
			val1.Teacher_name = Convert.ToString(Teacher_name);
		}
        
		if(Request["College"] != null){
			string College = Convert.ToString(Request["College"]);
			val1.College = Convert.ToString(College);
		}
        
		if(Request["Create_time"] != null){
			string Create_time = Convert.ToString(Request["Create_time"]);
			val1.Create_time = Convert.ToDateTime(Create_time);
		}
        
		if(Request["Apply_title"] != null){
			string Apply_title = Convert.ToString(Request["Apply_title"]);
			val1.Apply_title = Convert.ToString(Apply_title);
		}
        
		if(Request["User_id"] != null){
			string User_id = Convert.ToString(Request["User_id"]);
			val1.User_id = StringHelper.GuidParse(User_id);
		}
        
		if(Request["Job_uuid"] != null){
			string Job_uuid = Convert.ToString(Request["Job_uuid"]);
			val1.Job_uuid = StringHelper.GuidParse(Job_uuid);
		}

        val1.Uuid = Guid.NewGuid();
        ret1 = BLLTable<V_xb_job_apply>.Insert(val1);
        if (ret1 > 0)
        {
            Response.Write("<meta http-equiv='Refresh' content='3;URL=http://localhost:22312/edit_V_xb_job_apply.html?Uuid=" + val1.Uuid + "'/> ");
            Response.Write("<Script Language=JavaScript>document.write('修改成功 等待三秒跳回原来页面')</Script>");
        }
        else
        {
            Response.Write("<meta http-equiv='Refresh' content='30;URL=http://localhost:22312/edit_V_xb_job_apply.html?Uuid=" + val1.Uuid + "'/> ");
            Response.Write("<Script Language=JavaScript>document.write('修改失败 请联系管理员，或等待三十秒跳回原来页面')</Script>");

        }
        Response.End();
    }
    protected void edit()
    {
        V_xb_job_apply val1 = new V_xb_job_apply();
        V_xb_job_apply cond1 = new V_xb_job_apply();
		
        
		if(Request["Job_title"] != null){
			string Job_title = Convert.ToString(Request["Job_title"]);
			val1.Job_title = Convert.ToString(Job_title);
		}
        
		if(Request["Job_code"] != null){
			string Job_code = Convert.ToString(Request["Job_code"]);
			val1.Job_code = Convert.ToInt32(Job_code);
		}
        
		if(Request["Address"] != null){
			string Address = Convert.ToString(Request["Address"]);
			val1.Address = Convert.ToString(Address);
		}
        
		if(Request["Salary"] != null){
			string Salary = Convert.ToString(Request["Salary"]);
			val1.Salary = Convert.ToString(Salary);
		}
        
		if(Request["Salary_unit"] != null){
			string Salary_unit = Convert.ToString(Request["Salary_unit"]);
			val1.Salary_unit = Convert.ToString(Salary_unit);
		}
        
		if(Request["Teacher_name"] != null){
			string Teacher_name = Convert.ToString(Request["Teacher_name"]);
			val1.Teacher_name = Convert.ToString(Teacher_name);
		}
        
		if(Request["College"] != null){
			string College = Convert.ToString(Request["College"]);
			val1.College = Convert.ToString(College);
		}
        
		if(Request["Create_time"] != null){
			string Create_time = Convert.ToString(Request["Create_time"]);
			val1.Create_time = Convert.ToDateTime(Create_time);
		}
        
		if(Request["Apply_title"] != null){
			string Apply_title = Convert.ToString(Request["Apply_title"]);
			val1.Apply_title = Convert.ToString(Apply_title);
		}
        
		if(Request["User_id"] != null){
			string User_id = Convert.ToString(Request["User_id"]);
			val1.User_id = StringHelper.GuidParse(User_id);
		}
        
		if(Request["Job_uuid"] != null){
			string Job_uuid = Convert.ToString(Request["Job_uuid"]);
			val1.Job_uuid = StringHelper.GuidParse(Job_uuid);
		}		

        string Uuid = Request["Uuid"];
        cond1.Uuid = new Guid(Request["Uuid"]);

        ret1 = BLLTable<V_xb_job_apply>.Update(val1, cond1);
        if (ret1 > 0)
        {
            Response.Write("<meta http-equiv='Refresh' content='3;URL=http://localhost:22312/edit_V_xb_job_apply.html?Uuid=" + Uuid + "'/> ");
            Response.Write("<Script Language=JavaScript>document.write('修改成功 等待三秒跳回原来页面')</Script>");
        }
        else
        {
            Response.Write("<meta http-equiv='Refresh' content='3;URL=http://localhost:22312/edit_V_xb_job_apply.html?Uuid=" + Uuid + "'/> ");
            Response.Write("<Script Language=JavaScript>document.write('修改失败 等待三秒跳回原来页面')</Script>");
        }
        Response.End();
    }
    //获取列表页

    protected void list()
    {
        int pageSize = 10;
        int pageIndex = 1;
        int count = -1;

        if (!string.IsNullOrEmpty(Request["pageSize"]))
            pageSize = Convert.ToInt32(Request["pageSize"]);
        if (!string.IsNullOrEmpty(Request["pageNum"]))
            pageIndex = Convert.ToInt32(Request["pageNum"]);
        if (!string.IsNullOrEmpty(Request["pageIndex"]))
            pageIndex = Convert.ToInt32(Request["pageIndex"]);
        if (!string.IsNullOrEmpty(Request["count"]))
            count = Convert.ToInt32(Request["count"]);
        if (!string.IsNullOrEmpty(Request["totalCount"]))
            count = Convert.ToInt32(Request["totalCount"]);

        #region 本表字段-设置查询条件
        string Good_at = "";
        string sex = "";
        string time = "";

        string keyword = "";

        V_xb_job_apply cond1 = new V_xb_job_apply();
        V_xb_job_apply val1 = new V_xb_job_apply();

        string sort1 = Request["sort"];
        if (!string.IsNullOrEmpty(Request["sort"]))
        {
            string sort = Request["sort"];

            sort = sort.Replace('^', ' ');

            cond1.OrderBy(string.Format("order by {0}", sort));
        }
        else
        {
            val1.OrderBy(string.Format("order by {0} desc", V_xb_job_apply.Attribute.Id));
        }

        AttributeItem attrSearch = Xb_teacher_resume.Attribute.Job_title;
        if (!string.IsNullOrEmpty(Request[attrSearch.FieldName]))
        {
            cond1.Where(attrSearch.FieldName + " like '{0}%'", Request[attrSearch.FieldName]);
        }

        List<V_xb_job_apply> list1 = new List<V_xb_job_apply>();

        list1 = BLLTable<V_xb_job_apply>.SelectByPage(val1, cond1, pageSize, pageIndex, ref count);
        r1.data.Add("V_xb_job_apply", list1, pageSize, pageIndex, count);

        #endregion 本表字段-设置查询条件

        #region 本表业务枚举量

        V_xb_job_apply xb1 = new V_xb_job_apply();
        foreach (AttributeItem attr in xb1.af_AttributeItemList)
        {
            r1.data.AddConfigShow(attr);
            r1.data.AddConfigSort(attr);
        }
        #endregion 本表业务条件

        ret1 = 1;
    }
    //详情页，获取一条记录
    protected void getone()
    {
        #region 本表业务条件
        if (type == "answer")
            r1.data.Add("title", "推荐教员");
        else
            r1.data.Add("title", "选择时间");
        #endregion 本表业务条件

        V_xb_job_apply val1 = new V_xb_job_apply();
        V_xb_job_apply cond1 = new V_xb_job_apply();
        cond1.Uuid = new Guid(Request["Uuid"]);
        V_xb_job_apply teache1 = BLLTable<V_xb_job_apply>.SelectOne(val1, cond1);
        r1.data.Add("V_xb_job_apply", teache1);

        V_xb_job_apply value2 = new V_xb_job_apply();
        value2 = BLLTable<V_xb_job_apply>.GetRowData(value2, param1);
        //r1.Add(value2, "节点名称");//代码示例
        r1.data.Add("V_xb_job_apply", value2);

        #region 本表字段 如果需要收藏功能
        //if (Request["user_id"] != null)
        //{
        //    Xb_teacher_student_fav value5 = new Xb_teacher_student_fav();
        //    Xb_teacher_student_fav cond5 = new Xb_teacher_student_fav();
        //    //cond5.Teacher_id = Convert.ToString(param1.Uuid);
        //    //cond5.Student_id = Request["user_id"];
        //    bool isfav = BLLTable<Xb_teacher_student_fav>.Exists(cond5);
        //    r1.data.Add("isfav", isfav);
        //}
        //else
        //{
        //    r1.data.Add("isfav", false);
        //}

        #endregion 本表字段

        ret1 = 1;
    }
    //详情页，获取一条记录
    protected void control_config()
    {
        r1.data.Add("title", "爱帮学霸家教简历");
        r1.data.Add("small_title", "想在大学期间做一些兼职么，请认真填写表格即享海量家教信息"
            + "\n【学霸家教】是大学城知道老师带队的教育品牌，在低价低质竞争环境下，始终保持定位于中高端家长人群。"
            + "\n进驻教员享受规范的培训，技能指导的机会。与签约家长进行正规的培训。");

        #region 本表业务枚举量

        //foreach (AttributeItem attr in new V_xb_job_apply().af_AttributeItemList)
        //{
        //    string ctrl1 = Enum.GetName(typeof(BaseCtrlType), attr.CtrlType());
        //    if (ctrl1 == "SelectDrop")
        //        r1.data.AddEnum(attr.FieldName.ToLower(), attr);
        //    else
        //        r1.data.Add(attr.FieldName.ToLower(), ctrl1);
        //    r1.data.Add(attr.FieldName.ToLower() + "_title", attr.ZhName);
        //}

        #endregion 本表业务条件
    }
    //置顶，非置顶
    protected void on_top()
    {
        if (!string.IsNullOrEmpty(Request["on_top"]))
        {

        }
    }
    //加入收藏
    protected void add_fav()
    {
        if (Request["user_id"] != null)
        {
            //Xb_teacher_student_fav value5 = new Xb_teacher_student_fav();
            //Xb_teacher_student_fav cond5 = new Xb_teacher_student_fav();

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
        if (Request["Uuid"] != null)
        {
            Xb_teacher_student_fav value5 = new Xb_teacher_student_fav();
            Xb_teacher_student_fav cond5 = new Xb_teacher_student_fav();

            cond5.Uuid = Request["Uuid"];
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

    #region 上传插入图片
    static string ImgFileUploadPath = @"E:\工程项目\刷题神器\小程序微信接口\Headimg_V_xb_job_apply\";
    static string imgSubDir = ImgFileUploadPath + @"headimg_big\";
    internal string upload_file()
    {
        if (!Directory.Exists(imgSubDir))
        {
            Directory.CreateDirectory(imgSubDir);
        }
        List<string> upload_pic_list = new List<string>();
        string upload_pic = "";
        System.Web.HttpFileCollection _file = System.Web.HttpContext.Current.Request.Files;

        if (_file.Count > 0)
        {
            for (int i = 0; i < _file.Count; i++)
            {
                File.AppendAllText(ImgFileUploadPath + "\\1.txt", "文件数：" + _file.Count);
                //文件大小  
                long size = _file[i].ContentLength;
                //文件类型  
                string type = _file[i].ContentType;
                //文件名  
                string name = _file[i].FileName;
                if (!string.IsNullOrEmpty(name))
                {
                    //文件格式  
                    string _tp = System.IO.Path.GetExtension(name);

                    if (!string.IsNullOrEmpty(_tp))
                    {
                        string _tp2 = _tp.ToLower();
                        if (_tp2 == ".jpg" || _tp2 == ".jpeg" || _tp2 == ".gif" || _tp2 == ".png"
                            || _tp2 == ".swf" || _tp2 == ".avi" || _tp2 == ".mp4" || _tp2 == ".mp4")
                        {
                            //获取文件流  
                            System.IO.Stream stream = _file[i].InputStream;
                            //保存文件  
                            string saveName = "teacher_resume_" + DateTime.Now.ToString("yyyyMMddHHmmss") + _tp;
                            string saveNameMin = "teacher_resume_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_100" + _tp;
                            string path = imgSubDir + saveName;//"/upload/area/" + saveName;//DataFactory.WFile.FileUploadPath
                            string pathMin = imgSubDir + saveNameMin;//"/upload/area/" + saveName;//DataFactory.WFile.FileUploadPath
                            _file[i].SaveAs(path);
                            //Jz_userImages.ImageMax = "../../../../FileUploader/jz_albumImages/" + saveName;
                            upload_pic = saveName;
                            upload_pic_list.Add(upload_pic);
                        }
                    }
                }
            }


        }
        if (upload_pic_list.Count == 0) return "";
        if (upload_pic_list.Count == 1) return upload_pic_list[0];
        else
            return JsonData.ToJson(upload_pic_list);
    }
    #endregion
}
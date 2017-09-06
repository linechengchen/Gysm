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
using System.Text;//命名空间：三层结构，实体层

public partial class AutoJsonPages_Xt_task_xt_task_addjson : BasePageShuati
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //data.name = document.getElementById('name').value; //标题
        //data.category_id = createClas.find('[name="category_id"]').val();//分类
        //data.end_time = document.getElementById('end_times').value;//截至时间
        //data.level = document.getElementById('level').value;//难度
        //data.is_group = createClas.find('[name="is_group"]').val();//是否作业
        //data.type = createClas.find('[name="type"]').val();//类型
        //data.content = createClas.find('[name="content"]').val();//内容

        getCourse_id();
        RootObject r1 = new RootObject();
        Xt_task cond1 = new Xt_task();
        Xt_task val1 = new Xt_task();
        Xt_course_task val2=new Xt_course_task();
        Xt_course_task cond2=new Xt_course_task();

        string name = Request["name"];
        string category_id = Request["category_id"]; //截止时间
        string end_time = Request["end_time"];//难易程度：
        string level = Request["level"];//是否作业
        string is_group = Request["is_group"];//点评设置
        string type = Request["type"];//小组作业：
        string content = Request["content"];//类型：
        string classes_id = Request["classes_id"];
        StringBuilder Category_ids = new StringBuilder(256);
        StringBuilder Category_names = new StringBuilder(256);
        Split_category(category_id, ref Category_ids, ref Category_names);
        val1.Title = name; val1.Category_names=Category_names.ToString();val1.Endtime=Convert.ToDateTime(end_time);
        val1.Content=content;val1._Task_type=type;val1.Group_work=is_group;
        val1.Uuid = Guid.NewGuid();
        val2.Uuid = Guid.NewGuid();
        val2.Course_id=getCourse_id();
        val2.Task_id = val1.Uuid.ToString();

        int ret2 = BLLTable<Xt_course_task>.Insert(val2);
        int ret1 = BLLTable<Xt_task>.Insert(val1);
        if (ret1 > 0 && ret2>0)
        {
            r1.message = "添加成功";
            r1.code = 200;
            r1.AddTop("url", "/Classes/index.aspx?classes_id=" + classes_id);

        }
        else
        {
            r1.message = "添加失败";
            r1.code = 2001;
        }
        Response.Write(r1.ToJsonHeadLower());
        Response.End();


        //cond1.Title = name;
        //cond1.Category_id = name;

        //        string search_type = Request["search_type"];
        //string kw = Request["kw"];
        //string reward = Request["reward"];
        //string numbers = Request["numbers"];
        //string end_time = Request["end_time"];
        //string level = Request["level"];
        //string is_private = Request["is_private"];
        //string task_class = Request["task_class"];
        //string type = Request["type"];
        //string is_task = Request["is_task"];
        //string is_group = Request["is_group"]; //出现2次
        //string vay_comment = Request["vay_comment"]; //出现2次
        //string score_level[] = Request["score_level[]"]; //出现4次
        //string answer[] = Request["answer[]"];
        //string question[] = Request["question[]"];
        //string answer1 = Request["answer1"];
        //string forward_num[] = Request["forward_num[]"]; //出现4次
        //string weibo_content = Request["weibo_content"];
        //string actual = Request["actual"];
        ////cond1.search_type = search_type;
        //cond1.kw = kw;
        //cond1.reward = reward;
        //cond1.numbers = numbers;
        //cond1.end_time = end_time;
        //cond1.level = level;
        //cond1.is_private = is_private;
        //cond1.task_class = task_class;
        //cond1.type = type;
        //cond1.is_task = is_task;
        //string is_group = Request["is_group"]; //出现2次
        //string vay_comment = Request["vay_comment"]; //出现2次
        //string score_level[] = Request["score_level[]"]; //出现4次
        //cond1.answer[] = answer[];
        //cond1.question[] = question[];
        //cond1.answer1 = answer1;
        //string forward_num[] = Request["forward_num[]"]; //出现4次
        //cond1.weibo_content = weibo_content;
        //cond1.actual = actual;

    }
}
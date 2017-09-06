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

public partial class AutoJsonPages_Xt_task_Xt_task_add : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Xt_course_task val1 = new Xt_course_task() { };
        Xt_task val2 = new Xt_task() { };

        Xt_course_task cond1 = new Xt_course_task() { };
        Xt_task cond2 = new Xt_task() { };
        RootObject r1 = new RootObject() { };
        string classes_id = Request["classes_id"];
        string data_task_id = Request["task_id"];
        if (!string.IsNullOrEmpty(classes_id) && (!string.IsNullOrEmpty(data_task_id)))
        {
           
            cond1.Task_id = data_task_id;
            cond2.Uuid=Guid.Parse(data_task_id);
            cond1.Course_id=classes_id;
          int ret1=  BLLTable<Xt_task>.Delete(cond2);
          int ret2 = BLLTable<Xt_course_task>.Delete(cond1);
            if(ret1==1 && ret2==1)
            r1.message = "删除成功";
            r1.code = 200;
        }
        else
        {
            r1.message = "删除失败";
            r1.code = 201;
        }


        Response.Write(r1.ToJsonHeadLower());
        Response.End();
    }
    #region 前台代码接口 class_task.js
    //}, function () {
    //        $.ajax({
    //            type: "POST",
    //            url: url_delete,
    //            data: {
    //                'classes_id': $('#classes_id').val(),
    //                'task_id': obj.attr('data-task-id')
    //            },
    //            dataType: "json",
    //            success: function (data) {
    //                if (data.code == '200') {
    //                    $.ui.success(data.message);
    //                    // class-common-item
    //                    var par = obj.parents('.class-common-item');
    //                    par.remove();
    //                } else {
    //                    $.ui.error(data.message);
    //                }
    //            },
    //            error: function () {
    //                $.ui.error('操作失败');
    //            }
    //        });
    //    });
    //});
    #endregion
}
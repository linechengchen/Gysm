﻿using System;
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
    protected Xt_task val1 = new Xt_task() { };
    protected void Page_Load(object sender, EventArgs e)
    {
        Xt_task cond1 = new Xt_task() { };
        if(!string .IsNullOrEmpty(Request["classes_id"]))
        {
           val1= BLLTable<Xt_task>.SelectOne(new Xt_task() { }, cond1);

        }
        



    }
}
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AutoJsonPages_Xt_note_Add : BasePageShuati
{
    protected List<Xt_course> list1 = new List<Xt_course>();
    protected Xt_note result1 = new Xt_note();
    protected string Course_id = "";
    protected string uuid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["uuid"]))
        {
            uuid = Request["uuid"];
            Xt_note val1 = new Xt_note();
            Xt_note cond1 = new Xt_note();
            result1 = BLLTable<Xt_note>.SelectOne(Xt_note.Attribute.Uuid, uuid);
        }
        if (!string.IsNullOrEmpty(Request["classes_id"]))
        {
            Course_id = Request["classes_id"];            
            //param1.Course_id = Request["classes_id"];

            //Xt_course val1 = new Xt_course();
            //Xt_course cond1 = new Xt_course();
            ////cond1.Teacher_id = tearchId;
            ////cond1.Is_file 
            //list1 = BLLTable<Xt_course>.Select(val1, cond1);
        }
    }
}
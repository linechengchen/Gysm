using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;

public partial class Json_JianZhi_a_jsonTest : BasePageShuati
{
    RootObject r1 = new RootObject();
    protected void Page_Load(object sender, EventArgs e)
    {
        Test_sql_sample();

        string json1 = "";

        json1 = Test3();
        if (Request["id"] == "1") json1 = Test1();
        if (Request["id"] == "2") json1 = Test2();
        if (Request["id"] == "3") json1 = Test3();
        if (Request["id"] == "4") json1 = Test4();
        Response.Write(json1);
        Response.End();
    }

    public int pageSize = 50;
    public int top = 100;
    public int pageIndex = 1;
    int count1 = -1;
    //数据库操作示例
    public void Test_sql_sample()//枚举量的例子
    {
        /////////////////大学科目
        St_kemuInfo condkemu = new St_kemuInfo();
        //condkemu.OrderBy(St_kemuInfo.Attribute.Seq, Order.Desc);
        condkemu.OrderBy(St_kemuInfo.Attribute.KemuId, Order.Asc);
        condkemu.KemuType = 1;

        St_kemuInfo valkemu1 = new St_kemuInfo();
        valkemu1.KemuId = 0;
        valkemu1.KemuName = "";
        valkemu1.ZsId = 0;
        valkemu1.IsShowIndex = false;
        //查询：取值对象，条件对象
        List<St_kemuInfo>  tkmlist = BLLTable<St_kemuInfo>.Select(valkemu1, condkemu);
        tkmlist = BLLTable<St_kemuInfo>.Select(new St_kemuInfo(), condkemu);
        //分页查询
        tkmlist = BLLTable<St_kemuInfo>.SelectByPage(valkemu1, condkemu, top, pageIndex, ref count1);

        //？


        "".ToString();
    }
    public string Test5()//枚举量的例子
    {
        int partJobId = 92846;
        Jz_partJobs jobs1 = BLLTable<Jz_partJobs>.SelectOne(Jz_partJobs.Attribute.PartJobId, partJobId);
        if (jobs1 == null) return "";
        r1.Add(jobs1);

        jobs1.SelectOne<Jz_childrenPartJobClassifications>(Jz_childrenPartJobClassifications.Attribute.ClassificationId, jobs1.ClassificationId)
            ._TableName = "classificationVO";
        r1.Add(jobs1, "表名");
        string json1 = r1.ToJsonHeadLower();
        return json1;
    }
    public string Test4()//枚举量的例子
    {
        string json1 = Jz_childrenPartJobClassifications.Attribute.ClassificationEnum.GetEnumJson();
        return json1;
    }
    string conn = "";
    public string Test2()//树结构例子代码
    {
        //复杂的查询操作方式
        //Jz_childrenPartJobClassifications val1 = new Jz_childrenPartJobClassifications();
        //Jz_childrenPartJobClassifications other1 = new Jz_childrenPartJobClassifications();
        //List<Jz_childrenPartJobClassifications> otherVal1 = new List<Jz_childrenPartJobClassifications>();
        //Jz_childrenPartJobClassifications cond1 = new Jz_childrenPartJobClassifications();
        //Relation r1 = new AgileFrame.Orm.PersistenceLayer.Model.Relation(Jz_childrenPartJobClassifications.Attribute.Id, Jz_childrenPartJobClassifications.Attribute.ParentId);
        //List<Jz_childrenPartJobClassifications> list1 = BLLTable<Jz_childrenPartJobClassifications>
            //.Select(val1, r1, other1, cond1);

        //简单的查询操作方式
        List<Jz_childrenPartJobClassifications> list1 = BLLTable<Jz_childrenPartJobClassifications>
            .Select();// .Select(val1, r1, other1, cond1);

        //建立树结构json
        string json1 = BLLTable<Jz_childrenPartJobClassifications>.JsonTree(list1,
            Jz_childrenPartJobClassifications.Attribute.ClassificationId, Jz_childrenPartJobClassifications.Attribute.ParentId
            , "0");
        return json1;
    }
    public string Test3()//主从结构的例子代码
    {
        ///////////////////////////////

        //证书表
        List<St_TzsInfo> tzslist = BLLTable<St_TzsInfo>.Select();//new St_TzsInfo()
        //科目表
        List<St_kemuInfo_zs> tkmlist = BLLTable<St_kemuInfo_zs>.Select();//new St_kemuInfo()

        //生成科目与证书的关联主从json
        string json2 = BLLTable<St_TzsInfo>.JsonTree(tzslist, tkmlist,
            St_TzsInfo.Attribute.ZsId, St_kemuInfo_zs.Attribute.ZsId);
        json2.ToString();

        ///////////////////////////////

        string json3 =
        BLLTable<St_TzsInfo>.JsonTree_Add(tzslist, tkmlist,
            St_TzsInfo.Attribute.ZsId, St_kemuInfo_zs.Attribute.ZsId)
            .JsonTree_Add(tzslist, tkmlist,
            St_TzsInfo.Attribute.ZsId, St_kemuInfo_zs.Attribute.ZsId).ToJson();

        return json2;
    }
    public string Test1()
    {
        List<Jz_userImages> listuserimage = new List<Jz_userImages>();
        listuserimage = BLLTable<Jz_userImages>.Select();
        List<Jz_resume> listresume = new List<Jz_resume>();
        List<Jz_userEducation> listuserEducation = new List<Jz_userEducation>();
        Jz_resume resume1 = BLLTable<Jz_resume>.GetRowData(1);
        Jz_userEducation condEducation = new AgileFrame.Orm.PersistenceLayer.Model.Jz_userEducation();
        condEducation.User_id = resume1.User_id;
        List <Jz_userEducation> list2 = resume1.Select(new Jz_userEducation(), condEducation);

        if (!string.IsNullOrEmpty(resume1.Tags))
        {
            Jz_userTagVOs cond1 = new Jz_userTagVOs();
            cond1.In(Jz_userTagVOs.Attribute.UserTagId, resume1.Tags.Trim(','));
            Jz_userTagVOs val1 = new Jz_userTagVOs();
            val1._Name = "";
            List<Jz_userTagVOs> listUserTag = BLLTable<Jz_userTagVOs>.Select(val1, cond1);
            r1.data.Add(listUserTag, "userTags");
        }
        listuserEducation = BLLTable<Jz_userEducation>.Select(3);
        
        listuserEducation[0].Add("listuserimage", listuserimage.ToArray());
        r1.data.Add(resume1, "resume1");
        r1.data.Add(listuserEducation, "userEducations");
        r1.data.Add(listuserEducation[0], "userEducation");
        r1.data.Add(listuserimage, "userImages");
        //r1.isDebug = true;
        //r1.isShuati = true;

        string json1 = r1.ToJsonHeadLower();
        return json1;       
    }

    private void 数据库操作例子代码()
    {
        //get获取所有json字符串参数
        string user_id = "";
        if (string.IsNullOrEmpty(Request["user_id"]))
            user_id = Convert.ToString(Request["user_id"]);

        if (Request["t"] == "1") return; JsonRoot r1 = new JsonRoot();
        TUserInfo user1 = new TUserInfo();
        user1.Top(100);
        TUserInfo cond1 = new TUserInfo();
        List<TUserInfo> list1 = BLLTable<TUserInfo>.Select(user1, cond1);

        int ret1 = BLLTable<TUserInfo>.Update(user1, TUserInfo.Attribute.User_id);
        if (ret1 > 0)
        {
            r1.code = 200;
            string json1 = r1.ToJsonHeadLower();
            Response.Write(json1);
            Response.End();
        }
    }
}
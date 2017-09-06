using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Script.Serialization;//�����ռ䣺json���л�dll
using AgileFrame.Orm.PersistenceLayer.BLL.Base;//�����ռ䣺����ṹ��ҵ���߼���
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;//�����ռ䣺����ṹ��ʵ���

public partial class app_jianzhi_user_user_auto_Xt_course :BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["t"] == "1") return; //�˴���ʾҳ��ǰ�˵Ĳ���json
        
        //�������ݱ�Xt_course
        act_Xt_course();
    }
    
    #region Xt_course
    Xt_course param1 = new Xt_course();
    string action = "";
    protected void act_Xt_course()
    {     
        JsonRoot r1 = new JsonRoot();
        //���ǰ��ҳ�洫�ݵ����ж�����������
        param1 = set(new Xt_course());
        //дҵ�����

        //if (!string.IsNullOrEmpty(Request["token"])) param1.UserId = new Guid(Request["token"]);
        //if (!string.IsNullOrEmpty(Request["UserId"])) param1.UserId = new Guid(Request["UserId"]);
        setRequest(param1, Xt_course.Attribute.Uuid, "token", "UserId", "User_Id");//UserEducationId

        int ret1 = -1;//����-1����ʾ�ɹ���
        try
        {
            action = Request["act"];
            switch (action)//���ݿ����
            {
                case "udpate"://���ݿ�-���¶���
                    if (param1.IsNotNull() && param1.Uuid != default(Guid))
                        ret1 = BLLTable<Xt_course>.Update(param1, Xt_course.Attribute.Uuid);//UserEducationId
                    break;

                case "add"://���ݿ�-���Ӷ���
                    if (param1.IsNotNull())
                        ret1 = BLLTable<Xt_course>.Insert(param1);
                    break;

                case "delete"://���ݿ�-ɾ������
                    if (param1.IsNotNull() && param1.Uuid != default(Guid))
                        ret1 = BLLTable<Xt_course>.Delete(Xt_course.Attribute.Uuid, param1.Uuid);
                    break;

                case "getone"://���ݿ�-��ѯ��������
                    Xt_course value2 = new Xt_course();
                    value2 = BLLTable<Xt_course>.GetRowData(value2, param1);
                    //r1.Add(value2, "�ڵ�����");//����ʾ��
                    r1.data.Add("Xt_course", value2);
                    ret1 = 1;
                    break;

                case "get":
                case "select"://���ݿ�-��ѯ�����б�, 
                case "listAll":
                default://Ĭ��
                    List<Xt_course> list1 = new List<Xt_course>();
                    Xt_course value1 = new Xt_course();
                    value1.Top(20);
                    list1 = BLLTable<Xt_course>.Select(value1, param1);
                    //r1.Add(list1, "�ڵ�����");//����ʾ��
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
            r1.errMsg = "�����ɹ�";
        }
        else
        {
            r1.code = ret1;
            r1.errMsg = "����ʧ�ܣ����ͼ����������Ա��лл����";
        }
        string json1 = r1.ToJsonHeadLower();
        Response.Write(json1);
        Response.End();
    }
    #endregion
}
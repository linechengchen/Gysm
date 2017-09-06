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

//http://stbd.aibangxs.com/zhuxuetang2/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=list&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  �б�
//{"code":200,"msg":"�ɹ�","data":null}
//˵����"realName":����,"groupId":����id(�ձ�ʾδ����),"head":ͷ��,"is_pass":�Ƿ���ˣ�0δ��� 1����ˣ�

//http://stbd.aibangxs.com/zhuxuetang2/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=add&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  ���ӣ�
//˵����"realName":����,"groupId":����id(�ձ�ʾδ����),"head":ͷ��,"is_pass":�Ƿ���ˣ�0δ��� 1����ˣ�

//http://stbd.aibangxs.com/zhuxuetang2/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=delete&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  ɾ����
//˵����"realName":����,"groupId":����id(�ձ�ʾδ����),"head":ͷ��,"is_pass":�Ƿ���ˣ�0δ��� 1����ˣ�

//http://stbd.aibangxs.com/zhuxuetang2/AutoJsonPages/Xt_note/Xt_note_json.aspx?act=edit&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  �޸ģ�
//˵����"realName":����,"groupId":����id(�ձ�ʾδ����),"head":ͷ��,"is_pass":�Ƿ���ˣ�0δ��� 1����ˣ�

public partial class app_jianzhi_user_user_auto_Xt_note : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["t"] == "1") return; //�˴���ʾҳ��ǰ�˵Ĳ���json
        
        //�������ݱ�Xt_note
        act_Xt_note();
    }

    #region Xt_note
    List<string> classlist = new List<string>();
    protected string classes_idlist = "";
    protected void act_Xt_note()
    {     
        JsonRoot r1 = new JsonRoot();
        //���ǰ��ҳ�洫�ݵ����ж�����������
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

        int ret1 = -1;//����-1����ʾ�ɹ���
        try
        {
            string action = Request["act"];
            switch (action)//���ݿ����
            {
                case "edit":
                case "update"://���ݿ�-���¶���
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

                case "add"://���ݿ�-���Ӷ���
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

                case "delete"://���ݿ�-ɾ������
                    if (param1.IsNotNull() && param1.Uuid != default(Guid))
                        ret1 = BLLTable<Xt_note>.Delete(Xt_note.Attribute.Uuid, param1.Uuid);
                    break;

                case "getone"://���ݿ�-��ѯ��������
                    Xt_note value2 = new Xt_note();
                    value2 = BLLTable<Xt_note>.GetRowData(value2, param1);
                    //r1.Add(value2, "�ڵ�����");//����ʾ��
                    r1.data.Add("Xt_note", value2);
                    ret1 = 1;
                    break;

                case "get":
                case "select"://���ݿ�-��ѯ�����б�, 
                case "list":
                case "listAll":
                default://Ĭ��
                    List<Xt_note> list1 = new List<Xt_note>();
                    Xt_note value1 = new Xt_note();
                    value1.Top(20);
                    list1 = BLLTable<Xt_note>.Select(value1, param1);
                    //r1.Add(list1, "�ڵ�����");//����ʾ��
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
            r1.message = r1.errMsg = "�����ɹ�";
        }
        else
        {
            r1.code = ret1;
            r1.message = r1.errMsg = "����ʧ�ܣ����ͼ����������Ա��лл����";
        }
        r1.AddTop("info", r1.message);
        r1.AddTop("status","" + ((ret1 > 0) ? 1 : -1));
        r1.AddTop("url", "/Classes/index.aspx?classes_id=" + param1.Course_id);
        
        string json1 = r1.ToJsonHeadLower();
        Response.Write(json1);
        Response.End();
    }
    #endregion

    #region ������װ�ӿڴ���
    //��ҳ��request�л�ȡ������ֵ��������
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
    //request��ȡ���в���
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
        if (count == 0)//������post����������Ƿ���Ҫ����
        {
            string js1 = null;
            try
            {
                js1 = getString();
                if (js1.StartsWith("{"))
                {
                    JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    //PostData = javaScriptSerializer.Deserialize<PostData>(js1);//�ַ��������л�
                    //string email = Convert.ToString(Request.Form["email"]);
                    Response.Write("ǰ�˴��η�ʽΪjson�ַ���ģʽ\r\n");
                    Response.Write(js1);
                    Response.End();
                }
                else
                {
                    //string email = Convert.ToString(Request.Form["email"]);
                    //Response.Write("ǰ�˴��η�ʽΪ��json�ַ���ģʽ\r\n");
                    //Response.Write(js1);
                    //Response.End();
                }
            }
            catch (Exception ex1) { Response.Write(js1 + "==�쳣==" + ex1.Message); Response.End(); }
        }
        return itable;
    }
    //�õ�post�ַ���
    public string getString()
    {
        string json1 = (Request.InputStream != null) ? (new System.IO.StreamReader(Request.InputStream).ReadToEnd()) : ""; Request.InputStream.Close();
        return json1;
    }

    #endregion
}
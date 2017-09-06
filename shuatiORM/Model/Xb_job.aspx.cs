using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Script.Serialization;//�����ռ䣺json���л�dll
using AgileFrame.Orm.PersistenceLayer.BLL.Base;//�����ռ䣺����ṹ��ҵ���߼���
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
using System.Text;
using System.IO;//�����ռ䣺����ṹ��ʵ���

//��Xb_job ���������滻������ʵ���࣬����ʵ��json�ӿ�we
#region �ӿ�˵��

//1����ʦ������Ϣ (id,�̿ξ���,��ѧ������;���,��ѧרҵ,������ҵ,���Ҽ��,uuid,������,΢��ͷ��,�߿��ɼ�,��������1-����,��������2-��ͨ,��������3-����,�����ܷ�,��ʦ����,�Ա�,�ֻ���,����������,����ѧУ�Ƿ��ص�,�ó���Ŀ,�ҽ̾���,������ϸ����,����������,������������,������������,��д����,΢���ǳ�,΢���Ա�,΢�Ź���,΢��ʡ��,΢����,f26,f27,openid,�ύ��,�ύʱ��,�޸�ʱ��,��д�豸,����ϵͳ,�����,ip,�Ƿ���ʾ,�Ƿ��ö�,�ö���ʱ����)
//    [Xb_job] (Id,Experience_year,College,College_major,Work_field,Introduce,Uuid,Photo,Wx_head_img,Score_high_school,Score_mianshi1,Score_mianshi2,Score_mianshi3,Score_mianshi,Teacher_name,Sex,Phone_number,Born,High_school,Good_at,Experience,Experience_intro,Work_area,Home_area,Other_area,Create_time,Wx_nick_name,Wx_sex,Wx_country,Wx_province,Wx_city,F26,F27,OpenID,Wx_create_man,Wx_post_time,Wx_modify_time,Wx_device,Wx_os,Wx_explore,IP,Is_show,On_top,On_top_timeout)
//˵����"Experience_year":�̿ξ���,"College":��ѧ������;���,"College_major":��ѧרҵ,"Work_field":������ҵ,"Introduce":���Ҽ��,"Photo":������,"Wx_head_img":΢��ͷ��,"Score_high_school":�߿��ɼ�,"Score_mianshi1":��������1-����,"Score_mianshi2":��������2-��ͨ,"Score_mianshi3":��������3-����,"Score_mianshi":�����ܷ�,"Teacher_name":��ʦ����,"Sex":�Ա�,"Phone_number":�ֻ���,"Born":����������,"High_school":����ѧУ�Ƿ��ص�,"Good_at":�ó���Ŀ,"Experience":�ҽ̾���,"Experience_intro":������ϸ����,"Work_area":����������,"Home_area":������������,"Other_area":������������,"Create_time":��д����,"Wx_nick_name":΢���ǳ�,"Wx_sex":΢���Ա�,"Wx_country":΢�Ź���,"Wx_province":΢��ʡ��,"Wx_city":΢����,"Wx_create_man":�ύ��,"Wx_post_time":�ύʱ��,"Wx_modify_time":�޸�ʱ��,"Wx_device":��д�豸,"Wx_os":����ϵͳ,"Wx_explore":�����,"Is_show":�Ƿ���ʾ,"On_top":�Ƿ��ö�,"On_top_timeout":�ö���ʱ����)

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/Xb_job/Xb_job.aspx?act=list&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  �б�
//{"code":200,"msg":"�ɹ�","data":null}
//˵����"realName":����,"groupId":����id(�ձ�ʾδ����),"head":ͷ��,"is_pass":�Ƿ���ˣ�0δ��� 1����ˣ�

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/Xb_job/Xb_job.aspx?act=add&pid=A1567077-5A39-4A81-9550-BE12FD884973
//  ���ӣ�
//˵����"realName":����,"groupId":����id(�ձ�ʾδ����),"head":ͷ��,"is_pass":�Ƿ���ˣ�0δ��� 1����ˣ�

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/Xb_job/Xb_job.aspx?act=delete&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  ɾ����
//˵����"realName":����,"groupId":����id(�ձ�ʾδ����),"head":ͷ��,"is_pass":�Ƿ���ˣ�0δ��� 1����ˣ�

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/Xb_job/Xb_job.aspx?act=on_top&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  �ö���
//˵����"realName":����,"groupId":����id(�ձ�ʾδ����),"head":ͷ��,"is_pass":�Ƿ���ˣ�0δ��� 1����ˣ�

//https://stbd.javalong.com/zhuxuetang2/AutoJsonPages/Xb_job/Xb_job.aspx?act=edit&uuid=A1567077-5A39-4A81-9550-BE12FD884973
//  �޸ģ�
//˵����"realName":����,"groupId":����id(�ձ�ʾδ����),"head":ͷ��,"is_pass":�Ƿ���ˣ�0δ��� 1����ˣ�
#endregion �ӿ�˵��

public partial class AutoJsonPages_xb_getuser : BasePageShuati
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["t"] == "1") return; //�˴���ʾҳ��ǰ�˵Ĳ���json

        ;
        //�������ݱ�Xb_job
        act_Xb_job();
    }

    #region �����������
    Xb_job param1 = new Xb_job();//������������
    JsonRoot r1 = new JsonRoot();//json���صĶ���
    int ret1 = -1;//����-1����ʾ�ɹ���//���ݴ�����ֵ�������޸�codeֵ



    string action = "";//����act����
    string type = "";//����type����
    string catelog = "";//�������Ͳ���
    string kefu = "";//�������Ͳ���
    #endregion �����������

    #region action·��_Xb_job
    protected void act_Xb_job()
    {
        //���ǰ��ҳ�洫�ݵ����ж�����������
        param1.SetInitialized(Xb_job.Attribute.Id, false);
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
        //setRequest(param1, Xb_job.Attribute.Uuid, "token", "UserId", "User_Id");//UserEducationId
        try
        {
            user_id = Request["user_id"];
            action = Request["act"];
            type = Request["type"];
            catelog = Request["catelog"];
            kefu = Request["kefu"];
            switch (action)//���ݿ����
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
                case "add"://���ݿ�-���Ӷ���
                    add();
                    break;
                case "delete"://���ݿ�-ɾ������
                    if (!string.IsNullOrEmpty(Request["Uuid"])){
						Guid Uuid = new Guid(Request["Uuid"]);
                        ret1 = BLLTable<Xb_job>.Delete(Xb_job.Attribute.Uuid, Uuid);
					}
                    break;
                case "getone"://���ݿ�-��ѯ��������                    
                    getone();
                    break;
                case "control_config"://���ݿ�-��ѯ��������                    
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
                //default://Ĭ��//���ݿ�-��ѯ�����б�, 
                //    list();
                //    break;
            }
            if (ret1 > 0)
            {
                r1.code = 200;
                r1.message = r1.errMsg = "�����ɹ�";
            }
            else
            {
                r1.code = ret1;
                r1.message = r1.errMsg = "����ʧ�ܣ����æ��ͼ����������Ա��лл����";
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

    #region action��ɾ�Ĳ����
    //��ȡҵ��ö����ҳ
    protected void enumselect()
    {



        ret1 = 1;
    }
    protected void add()
    {
        Xb_job val1 = new Xb_job();
        Xb_job cond1 = new Xb_job();
		
        
		if(Request["Id"] != null){
			string Id = Convert.ToString(Request["Id"]);
			val1.Id = Convert.ToInt32(Id);
		}
        
		if(Request["Address"] != null){
			string Address = Convert.ToString(Request["Address"]);
			val1.Address = Convert.ToString(Address);
		}
        
		if(Request["Job_code"] != null){
			string Job_code = Convert.ToString(Request["Job_code"]);
			val1.Job_code = Convert.ToInt32(Job_code);
		}
        
		if(Request["Job_title"] != null){
			string Job_title = Convert.ToString(Request["Job_title"]);
			val1.Job_title = Convert.ToString(Job_title);
		}
        
		if(Request["Salary"] != null){
			string Salary = Convert.ToString(Request["Salary"]);
			val1.Salary = Convert.ToString(Salary);
		}
        
		if(Request["Salary_unit"] != null){
			string Salary_unit = Convert.ToString(Request["Salary_unit"]);
			val1.Salary_unit = Convert.ToString(Salary_unit);
		}
        
		if(Request["Uuid"] != null){
			string Uuid = Convert.ToString(Request["Uuid"]);
			val1.Uuid = StringHelper.GuidParse(Uuid);
		}

        val1.Uuid = Guid.NewGuid();
        ret1 = BLLTable<Xb_job>.Insert(val1);
        if (ret1 > 0)
        {
            Response.Write("<meta http-equiv='Refresh' content='3;URL=http://localhost:22312/edit_Xb_job.html?Uuid=" + val1.Uuid + "'/> ");
            Response.Write("<Script Language=JavaScript>document.write('�޸ĳɹ� �ȴ���������ԭ��ҳ��')</Script>");
        }
        else
        {
            Response.Write("<meta http-equiv='Refresh' content='30;URL=http://localhost:22312/edit_Xb_job.html?Uuid=" + val1.Uuid + "'/> ");
            Response.Write("<Script Language=JavaScript>document.write('�޸�ʧ�� ����ϵ����Ա����ȴ���ʮ������ԭ��ҳ��')</Script>");

        }
        Response.End();
    }
    protected void edit()
    {
        Xb_job val1 = new Xb_job();
        Xb_job cond1 = new Xb_job();
		
        
		if(Request["Address"] != null){
			string Address = Convert.ToString(Request["Address"]);
			val1.Address = Convert.ToString(Address);
		}
        
		if(Request["Job_code"] != null){
			string Job_code = Convert.ToString(Request["Job_code"]);
			val1.Job_code = Convert.ToInt32(Job_code);
		}
        
		if(Request["Job_title"] != null){
			string Job_title = Convert.ToString(Request["Job_title"]);
			val1.Job_title = Convert.ToString(Job_title);
		}
        
		if(Request["Salary"] != null){
			string Salary = Convert.ToString(Request["Salary"]);
			val1.Salary = Convert.ToString(Salary);
		}
        
		if(Request["Salary_unit"] != null){
			string Salary_unit = Convert.ToString(Request["Salary_unit"]);
			val1.Salary_unit = Convert.ToString(Salary_unit);
		}		

        string Uuid = Request["Uuid"];
        cond1.Uuid = new Guid(Request["Uuid"]);

        ret1 = BLLTable<Xb_job>.Update(val1, cond1);
        if (ret1 > 0)
        {
            Response.Write("<meta http-equiv='Refresh' content='3;URL=http://localhost:22312/edit_Xb_job.html?Uuid=" + Uuid + "'/> ");
            Response.Write("<Script Language=JavaScript>document.write('�޸ĳɹ� �ȴ���������ԭ��ҳ��')</Script>");
        }
        else
        {
            Response.Write("<meta http-equiv='Refresh' content='3;URL=http://localhost:22312/edit_Xb_job.html?Uuid=" + Uuid + "'/> ");
            Response.Write("<Script Language=JavaScript>document.write('�޸�ʧ�� �ȴ���������ԭ��ҳ��')</Script>");
        }
        Response.End();
    }
    //��ȡ�б�ҳ

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

        #region �����ֶ�-���ò�ѯ����
        string Good_at = "";
        string sex = "";
        string time = "";

        string keyword = "";

        Xb_job cond1 = new Xb_job();
        Xb_job val1 = new Xb_job();

        string sort1 = Request["sort"];
        if (!string.IsNullOrEmpty(Request["sort"]))
        {
            string sort = Request["sort"];

            sort = sort.Replace('^', ' ');

            cond1.OrderBy(string.Format("order by {0}", sort));
        }
        else
        {
            val1.OrderBy(string.Format("order by {0} desc", Xb_job.Attribute.Id));
        }

        AttributeItem attrSearch = Xb_teacher_resume.Attribute.Job_title;
        if (!string.IsNullOrEmpty(Request[attrSearch.FieldName]))
        {
            cond1.Where(attrSearch.FieldName + " like '{0}%'", Request[attrSearch.FieldName]);
        }

        List<Xb_job> list1 = new List<Xb_job>();

        list1 = BLLTable<Xb_job>.SelectByPage(val1, cond1, pageSize, pageIndex, ref count);
        r1.data.Add("Xb_job", list1, pageSize, pageIndex, count);

        #endregion �����ֶ�-���ò�ѯ����

        #region ����ҵ��ö����

        Xb_job xb1 = new Xb_job();
        foreach (AttributeItem attr in xb1.af_AttributeItemList)
        {
            r1.data.AddConfigShow(attr);
            r1.data.AddConfigSort(attr);
        }
        #endregion ����ҵ������

        ret1 = 1;
    }
    //����ҳ����ȡһ����¼
    protected void getone()
    {
        #region ����ҵ������
        if (type == "answer")
            r1.data.Add("title", "�Ƽ���Ա");
        else
            r1.data.Add("title", "ѡ��ʱ��");
        #endregion ����ҵ������

        Xb_job val1 = new Xb_job();
        Xb_job cond1 = new Xb_job();
        cond1.Uuid = new Guid(Request["Uuid"]);
        Xb_job teache1 = BLLTable<Xb_job>.SelectOne(val1, cond1);
        r1.data.Add("Xb_job", teache1);

        Xb_job value2 = new Xb_job();
        value2 = BLLTable<Xb_job>.GetRowData(value2, param1);
        //r1.Add(value2, "�ڵ�����");//����ʾ��
        r1.data.Add("Xb_job", value2);

        #region �����ֶ� �����Ҫ�ղع���
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

        #endregion �����ֶ�

        ret1 = 1;
    }
    //����ҳ����ȡһ����¼
    protected void control_config()
    {
        r1.data.Add("title", "����ѧ�Լҽ̼���");
        r1.data.Add("small_title", "���ڴ�ѧ�ڼ���һЩ��ְô����������д��������ҽ���Ϣ"
            + "\n��ѧ�Լҽ̡��Ǵ�ѧ��֪����ʦ���ӵĽ���Ʒ�ƣ��ڵͼ۵��ʾ��������£�ʼ�ձ��ֶ�λ���и߶˼ҳ���Ⱥ��"
            + "\n��פ��Ա���ܹ淶����ѵ������ָ���Ļ��ᡣ��ǩԼ�ҳ������������ѵ��");

        #region ����ҵ��ö����

        //foreach (AttributeItem attr in new Xb_job().af_AttributeItemList)
        //{
        //    string ctrl1 = Enum.GetName(typeof(BaseCtrlType), attr.CtrlType());
        //    if (ctrl1 == "SelectDrop")
        //        r1.data.AddEnum(attr.FieldName.ToLower(), attr);
        //    else
        //        r1.data.Add(attr.FieldName.ToLower(), ctrl1);
        //    r1.data.Add(attr.FieldName.ToLower() + "_title", attr.ZhName);
        //}

        #endregion ����ҵ������
    }
    //�ö������ö�
    protected void on_top()
    {
        if (!string.IsNullOrEmpty(Request["on_top"]))
        {

        }
    }
    //�����ղ�
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
            //    r1.errMsg = "����ʧ��";
            //}
        }
    }
    //ɾ���ղ�
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
                r1.errMsg = "����ʧ��";
            }
        }
    }
    #endregion action��ɾ�Ĳ����

    #region �ϴ�����ͼƬ
    static string ImgFileUploadPath = @"E:\������Ŀ\ˢ������\С����΢�Žӿ�\Headimg_Xb_job\";
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
                File.AppendAllText(ImgFileUploadPath + "\\1.txt", "�ļ�����" + _file.Count);
                //�ļ���С  
                long size = _file[i].ContentLength;
                //�ļ�����  
                string type = _file[i].ContentType;
                //�ļ���  
                string name = _file[i].FileName;
                if (!string.IsNullOrEmpty(name))
                {
                    //�ļ���ʽ  
                    string _tp = System.IO.Path.GetExtension(name);

                    if (!string.IsNullOrEmpty(_tp))
                    {
                        string _tp2 = _tp.ToLower();
                        if (_tp2 == ".jpg" || _tp2 == ".jpeg" || _tp2 == ".gif" || _tp2 == ".png"
                            || _tp2 == ".swf" || _tp2 == ".avi" || _tp2 == ".mp4" || _tp2 == ".mp4")
                        {
                            //��ȡ�ļ���  
                            System.IO.Stream stream = _file[i].InputStream;
                            //�����ļ�  
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